''' <summary>
''' Popotte v6
''' Work on Vista sp2, Windows 7 sp1, windows 8, Windows 8.1 and Windows 10 and 11. Need .Net10
''' Copyright Martin Laflamme 2003/2026
''' Read licence.txt
''' </summary>
Module Internet
    Public Function DownloadFile(ByRef URL As String, ByRef destinationFileName As String) As Integer
        'Get Language
        Dim LangINI As IniFile = frmMain.LangIni
        Dim RetVal As Integer = 0
        If My.Computer.Network.IsAvailable = True Then
            Try
                My.Computer.Network.DownloadFile(URL, destinationFileName, "", "", False, 60000, True)
            Catch ex As ArgumentException
                MessageBox.Show(LangINI.GetKeyValue("Popotte - EditorWindow - Messagebox", "18"), "Popotte - " & LangINI.GetKeyValue("Popotte - EditorWindow - Messagebox", "7"), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                RetVal = -1
            Catch ex As TimeoutException
                MessageBox.Show(LangINI.GetKeyValue("Popotte - EditorWindow - Messagebox", "19"), "Popotte - " & LangINI.GetKeyValue("Popotte - EditorWindow - Messagebox", "7"), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                RetVal = -1
            Catch ex As Exception
                MessageBox.Show(LangINI.GetKeyValue("Popotte - EditorWindow - Messagebox", "12") & " " & ex.ToString, "Popotte - " & LangINI.GetKeyValue("Popotte - EditorWindow - Messagebox", "7"), MessageBoxButtons.OK, MessageBoxIcon.Warning) 'else display any possible error
                RetVal = -1
            End Try
        Else
            MessageBox.Show(LangINI.GetKeyValue("Popotte - EditorWindow - Messagebox", "21"), "Popotte - " & LangINI.GetKeyValue("Popotte - EditorWindow - Messagebox", "7"), MessageBoxButtons.OK, MessageBoxIcon.Warning)
            RetVal = -1
        End If
        Return RetVal
    End Function
End Module
