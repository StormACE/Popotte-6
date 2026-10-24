''' Copyright Martin Laflamme 2003/2026
''' Read licence.txt
Public Class dlgmodifymenu

    Dim recette As String = ""
    Dim sellist As ListBox = Nothing
    Dim ind As Integer

    'Get Language
    Private LangINI As IniFile = frmMain.LangIni


    Public Sub New(ByVal NRecette As String, ByVal SelListbox As ListBox, ByVal index As Integer, ByVal day As Integer)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        recette = NRecette
        sellist = SelListbox
        ind = index
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim day As String = ""
        If TextBox1.Text <> "" Then
            sellist.Items(ind) = TextBox1.Text
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Dlgmodifymenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Text = LangINI.GetKeyValue("Popotte - ModifyMenu", "1")
        Label1.Text = LangINI.GetKeyValue("Popotte - ModifyMenu", "2")
        Cancel_Button.Text = LangINI.GetKeyValue("Popotte - ModifyMenu", "3")
        TextBox1.Text = recette
        TextBox1.SelectAll()

    End Sub
End Class
