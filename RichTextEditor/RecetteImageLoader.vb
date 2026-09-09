Imports System.IO
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Collections.Concurrent

Public Class RecetteImageLoader
    Private ReadOnly _owner As Control
    Private ReadOnly _lvs As New List(Of ListView)()
    Private ReadOnly _imageList As ImageList
    Private ReadOnly _popotteDir As String
    Private ReadOnly _cache As New ConcurrentDictionary(Of String, Integer)() ' key = "Folder\Name"
    Private ReadOnly _placeholderIndex As Integer

    Public Sub New(owner As Control, lv As ListView, imgList As ImageList, popotteDir As String, ParamArray otherLvs() As ListView)
        _owner = owner
        _lvs.Add(lv)
        If otherLvs IsNot Nothing Then
            For Each v In otherLvs
                If v IsNot Nothing Then _lvs.Add(v)
            Next
        End If
        _imageList = imgList
        _popotteDir = popotteDir

        ' Assurer un placeholder en position 0
        If _imageList.Images.Count = 0 Then
            Dim placeholderPath = Path.Combine(Application.StartupPath, "Images", "Recette.bmp")
            If File.Exists(placeholderPath) Then
                _imageList.Images.Add(Image.FromFile(placeholderPath))
            Else
                ' crée un placeholder basique si absent
                Dim bmp As New Bitmap(_imageList.ImageSize.Width, _imageList.ImageSize.Height)
                Using g = Graphics.FromImage(bmp)
                    g.Clear(Color.LightGray)
                End Using
                _imageList.Images.Add(bmp)
            End If
        End If
        _placeholderIndex = 0
    End Sub

    ' Retourne l'index à utiliser immédiatement (placeholder ou cache) et lance le chargement si nécessaire
    Public Function GetIndexAndLoad(rname As String, folderName As String) As Integer
        Dim key = $"{folderName}\{rname}"
        Dim existingIdx As Integer = -1
        If _cache.TryGetValue(key, existingIdx) Then
            Return existingIdx
        End If

        ' Réserver le placeholder
        _cache.TryAdd(key, _placeholderIndex)

        ' Lancer le chargement en arrière-plan
        Task.Run(Sub() LoadAndPublish(key, rname, folderName))

        Return _placeholderIndex
    End Function

    ' Réinitialise l'image list et le cache (utile avant de remplir une nouvelle vue)
    Public Sub ResetImageList()
        SyncLock _imageList.Images
            _imageList.Images.Clear()
            _cache.Clear()
            ' recrée placeholder
            Dim placeholderPath = Path.Combine(Application.StartupPath, "Images", "Recette.bmp")
            If File.Exists(placeholderPath) Then
                _imageList.Images.Add(Image.FromFile(placeholderPath))
            Else
                Dim bmp As New Bitmap(_imageList.ImageSize.Width, _imageList.ImageSize.Height)
                Using g = Graphics.FromImage(bmp)
                    g.Clear(Color.LightGray)
                End Using
                _imageList.Images.Add(bmp)
            End If
        End SyncLock
    End Sub

    Private Sub LoadAndPublish(key As String, rname As String, folderName As String)
        Try
            Dim rtfPath = Path.Combine(_popotteDir, folderName, rname & ".rtf")
            Dim finalImg As Image = Nothing

            If File.Exists(rtfPath) Then
                Dim rtfStr As String = File.ReadAllText(rtfPath, Encoding.Default)
                Dim hex As String = Nothing

                ' Try to use existing form functions if available (more robust)
                Dim parentForm = TryCast(_owner, dlgLivres)
                If parentForm IsNot Nothing Then
                    Try
                        hex = parentForm.ExtractImgHex(rtfStr)
                        If Not String.IsNullOrWhiteSpace(hex) Then
                            Dim buf = parentForm.ToBinary(hex)
                            If buf IsNot Nothing AndAlso buf.Length > 0 Then
                                Using ms As New MemoryStream(buf)
                                    Dim src As Image = Image.FromStream(ms)
                                    finalImg = New Bitmap(src, _imageList.ImageSize) ' crèe un thumbnail
                                End Using
                            End If
                        End If
                    Catch
                        hex = Nothing
                    End Try
                End If

                ' Fallback to internal extractor if needed
                If String.IsNullOrWhiteSpace(hex) Then
                    hex = ExtractImgHexFromRtf(rtfStr)
                    If Not String.IsNullOrWhiteSpace(hex) Then
                        Dim buf = HexToBytes(hex)
                        If buf IsNot Nothing AndAlso buf.Length > 0 Then
                            Using ms As New MemoryStream(buf)
                                Dim src As Image = Image.FromStream(ms)
                                finalImg = New Bitmap(src, _imageList.ImageSize)
                            End Using
                        End If
                    End If
                End If
            End If

            If finalImg Is Nothing Then
                Dim placeholderPath = Path.Combine(Application.StartupPath, "Images", "Recette.bmp")
                If File.Exists(placeholderPath) Then
                    finalImg = Image.FromFile(placeholderPath)
                Else
                    Dim bmp As New Bitmap(_imageList.ImageSize.Width, _imageList.ImageSize.Height)
                    Using g = Graphics.FromImage(bmp)
                        g.Clear(Color.LightGray)
                    End Using
                    finalImg = bmp
                End If
            End If

            ' Publier sur le thread UI
            If _owner IsNot Nothing AndAlso _owner.IsHandleCreated Then
                _owner.BeginInvoke(Sub()
                                       SyncLock _imageList.Images
                                           _imageList.Images.Add(finalImg)
                                           Dim newIdx = _imageList.Images.Count - 1
                                           _cache(key) = newIdx
                                       End SyncLock

                                       ' Mettre à jour les items visibles portant le même nom dans toutes les listviews fournies
                                       For Each lv In _lvs
                                           For Each it As ListViewItem In lv.Items
                                               If it.Text = rname Then
                                                   it.ImageIndex = _cache(key)
                                               End If
                                           Next
                                           lv.Invalidate()
                                       Next
                                   End Sub)
            End If
        Catch
            ' silencieux — on conserve le placeholder en cas d'erreur
        End Try
    End Sub

    ' Extraction simple du bloc hex après \pict (approche robuste pour la majorité des RTF générés)
    Private Function ExtractImgHexFromRtf(rtf As String) As String
        If String.IsNullOrEmpty(rtf) Then Return Nothing
        Dim pictIndex = rtf.IndexOf("\\pict", StringComparison.OrdinalIgnoreCase)
        If pictIndex = -1 Then Return Nothing
        ' Prendre tout jusqu'à la première accolade fermante après \pict
        Dim tail = rtf.Substring(pictIndex)
        Dim m = Regex.Match(tail, "\\pict[\s\S]*?([0-9A-Fa-f\s\r\n]+)}", RegexOptions.IgnoreCase)
        If m.Success AndAlso m.Groups.Count > 1 Then
            Dim hex = m.Groups(1).Value
            ' Supprimer espaces et retours ligne
            hex = Regex.Replace(hex, "\s+", "")
            Return hex
        End If
        ' Fallback : extraire tous les hex du reste
        Dim fallback = Regex.Match(tail, "([0-9A-Fa-f]{2,})")
        If fallback.Success Then
            Return Regex.Replace(fallback.Value, "\s+", "")
        End If
        Return Nothing
    End Function

    Private Function HexToBytes(hex As String) As Byte()
        Try
            hex = Regex.Replace(hex, "[^0-9A-Fa-f]", "")
            If hex.Length Mod 2 <> 0 Then hex = hex.Substring(0, hex.Length - 1)
            Dim len = hex.Length \ 2
            Dim bytes(len - 1) As Byte
            For i = 0 To len - 1
                bytes(i) = Convert.ToByte(hex.Substring(i * 2, 2), 16)
            Next
            Return bytes
        Catch
            Return Nothing
        End Try
    End Function
End Class
