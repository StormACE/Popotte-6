''' Copyright Martin Laflamme 2003/2026
''' Read licence.txt


Imports System.Text
Imports Microsoft.Win32

Public Class frmMenu

    Private regKey As RegistryKey
    'Get Language
    Private LangINI As IniFile = frmMain.LangIni

    Private CurrentWeekStart As DateTime = GetStartOfWeek(DateTime.Today)
    Private ReadOnly WeekDayNames As String() = {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"}

    Private ModifyMenu As Boolean = False

    Private Function GetStartOfWeek(ByVal value As DateTime) As DateTime
        Dim targetDate As DateTime = value.Date
        Return targetDate.AddDays(-CInt(targetDate.DayOfWeek))
    End Function

    Private Function GetMealName(ByVal mealIndex As Integer) As String
        Select Case mealIndex
            Case 0
                Return "meal1"
            Case 1
                Return "meal2"
            Case 2
                Return "meal3"
            Case Else
                Return "meal1"
        End Select
    End Function

    Private Function GetDefaultRecipeText() As String
        Return LangINI.GetKeyValue("Popotte - Menu", "1")
    End Function

    Private Function GetListBoxForDay(ByVal dayName As String) As ListBox
        Select Case dayName
            Case "Sunday"
                Return ListBoxSunday
            Case "Monday"
                Return ListBoxMonday
            Case "Tuesday"
                Return ListBoxTuesday
            Case "Wednesday"
                Return ListBoxWednesday
            Case "Thursday"
                Return ListBoxThursday
            Case "Friday"
                Return ListBoxFriday
            Case "Saturday"
                Return ListBoxSaturday
            Case Else
                Return ListBoxSunday
        End Select
    End Function

    Private Sub RefreshWeekDisplay()
        Dim weekEnd As DateTime = CurrentWeekStart.AddDays(6)
        LabelCurrentWeek.Text = String.Format(LangINI.GetKeyValue("Popotte - Menu", "22") & ": " & "{0:dd/MM/yyyy}", CurrentWeekStart, weekEnd)
    End Sub

    Private Sub FillListBoxFromRecipes(ByVal dayName As String, ByVal listBox As ListBox, ByVal keyToRead As RegistryKey)
        listBox.Items.Clear()
        For mealIndex As Integer = 0 To 2
            listBox.Items.Add(GetDefaultRecipeText())
        Next

        If keyToRead Is Nothing Then
            Return
        End If

        Dim dayKey As RegistryKey = keyToRead.OpenSubKey(dayName, False)
        If dayKey Is Nothing Then
            Return
        End If

        For mealIndex As Integer = 0 To 2
            Dim mealKey As RegistryKey = dayKey.OpenSubKey(GetMealName(mealIndex), False)
            If mealKey IsNot Nothing Then
                Dim recipeValue As String = CType(mealKey.GetValue("Recette", String.Empty), String)
                If Not String.IsNullOrWhiteSpace(recipeValue) AndAlso recipeValue <> GetDefaultRecipeText() Then
                    listBox.Items(mealIndex) = recipeValue
                End If
            End If
        Next
    End Sub

    Private Sub LoadCurrentWeekMenu()
        CenterToScreen()

        Text = LangINI.GetKeyValue("Popotte - Menu", "12")
        LabelSunday.Text = LangINI.GetKeyValue("Popotte - Menu", "2")
        LabelMonday.Text = LangINI.GetKeyValue("Popotte - Menu", "3")
        LabelTuesday.Text = LangINI.GetKeyValue("Popotte - Menu", "4")
        LabelWednesday.Text = LangINI.GetKeyValue("Popotte - Menu", "5")
        LabelThursday.Text = LangINI.GetKeyValue("Popotte - Menu", "6")
        LabelFriday.Text = LangINI.GetKeyValue("Popotte - Menu", "7")
        LabelSaturday.Text = LangINI.GetKeyValue("Popotte - Menu", "8")

        ButtonPreview.Text = LangINI.GetKeyValue("Popotte - Menu", "16")
        Button1Touteff.Text = LangINI.GetKeyValue("Popotte - Menu", "17")
        ButtonNextWeek.Text = LangINI.GetKeyValue("Popotte - Menu", "19")
        ButtonPreviousWeek.Text = LangINI.GetKeyValue("Popotte - Menu", "18")
        ButtonSave.Text = LangINI.GetKeyValue("Popotte - Menu", "21")
        ButtonPreviousWeek.Visible = True
        ButtonNextWeek.Visible = True
        ButtonSave.Visible = True
        LabelCurrentWeek.Visible = True

        ModifierToolStripMenuItem.Text = LangINI.GetKeyValue("Popotte - Menu", "10")
        EffacerToolStripMenuItem.Text = LangINI.GetKeyValue("Popotte - Menu", "11")
        Modifier2ToolStripMenuItem.Text = LangINI.GetKeyValue("Popotte - Menu", "10")
        Effacer2ToolStripMenuItem.Text = LangINI.GetKeyValue("Popotte - Menu", "11")
        Modifier3ToolStripMenuItem.Text = LangINI.GetKeyValue("Popotte - Menu", "10")
        Effacer3ToolStripMenuItem.Text = LangINI.GetKeyValue("Popotte - Menu", "11")
        Modifier4ToolStripMenuItem.Text = LangINI.GetKeyValue("Popotte - Menu", "10")
        Effacer4ToolStripMenuItem.Text = LangINI.GetKeyValue("Popotte - Menu", "11")
        Modifier5ToolStripMenuItem.Text = LangINI.GetKeyValue("Popotte - Menu", "10")
        Effacer5ToolStripMenuItem.Text = LangINI.GetKeyValue("Popotte - Menu", "11")
        Modifier6ToolStripMenuItem.Text = LangINI.GetKeyValue("Popotte - Menu", "10")
        Effacer6ToolStripMenuItem.Text = LangINI.GetKeyValue("Popotte - Menu", "11")
        Modifier7ToolStripMenuItem.Text = LangINI.GetKeyValue("Popotte - Menu", "10")
        Effacer7ToolStripMenuItem.Text = LangINI.GetKeyValue("Popotte - Menu", "11")

        CollerLeTexteToolStripMenuItem.Text = LangINI.GetKeyValue("Popotte - Menu", "20")
        CollerLeTexteToolStripMenuItem1.Text = LangINI.GetKeyValue("Popotte - Menu", "20")
        CollerLeTexteToolStripMenuItem2.Text = LangINI.GetKeyValue("Popotte - Menu", "20")
        CollerLeTexteToolStripMenuItem3.Text = LangINI.GetKeyValue("Popotte - Menu", "20")
        CollerLeTexteToolStripMenuItem4.Text = LangINI.GetKeyValue("Popotte - Menu", "20")
        CollerLeTexteToolStripMenuItem5.Text = LangINI.GetKeyValue("Popotte - Menu", "20")
        CollerLeTexteToolStripMenuItem6.Text = LangINI.GetKeyValue("Popotte - Menu", "20")

        Dim weekKey As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\Popotte\Settings\Menu\Weeks\" & CurrentWeekStart.ToString("yyyy-MM-dd"), False)
        For Each dayName As String In WeekDayNames
            FillListBoxFromRecipes(dayName, GetListBoxForDay(dayName), weekKey)
        Next

        If weekKey Is Nothing Then
            For Each dayName As String In WeekDayNames
                Dim legacyKey As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\Popotte\Settings\Menu\" & dayName, False)
                FillListBoxFromRecipes(dayName, GetListBoxForDay(dayName), legacyKey)
            Next
        End If

        RefreshWeekDisplay()
    End Sub

    Private Sub SaveCurrentWeek()
        Dim rootKey As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\Popotte\Settings\Menu", True)
        If rootKey Is Nothing Then
            rootKey = Registry.CurrentUser.CreateSubKey("Software\Popotte\Settings\Menu")
        End If

        Dim weeksKey As RegistryKey = rootKey.CreateSubKey("Weeks")
        Dim weekKey As RegistryKey = weeksKey.CreateSubKey(CurrentWeekStart.ToString("yyyy-MM-dd"))

        For Each dayName As String In WeekDayNames
            Dim listBox As ListBox = GetListBoxForDay(dayName)
            Dim dayKey As RegistryKey = weekKey.CreateSubKey(dayName)

            For mealIndex As Integer = 0 To 2
                Dim mealKey As RegistryKey = dayKey.CreateSubKey(GetMealName(mealIndex))
                Dim recipeValue As String = String.Empty

                If listBox.Items.Count > mealIndex Then
                    recipeValue = CType(listBox.Items(mealIndex), String)
                End If

                If String.IsNullOrWhiteSpace(recipeValue) OrElse recipeValue = GetDefaultRecipeText() Then
                    recipeValue = String.Empty
                End If

                mealKey.SetValue("Recette", recipeValue)
                mealKey.SetValue("Livre", String.Empty)
            Next

            Dim legacyDayKey As RegistryKey = rootKey.CreateSubKey(dayName)
            For mealIndex As Integer = 0 To 2
                Dim legacyMealKey As RegistryKey = legacyDayKey.CreateSubKey(GetMealName(mealIndex))
                Dim legacyRecipe As String = String.Empty
                If listBox.Items.Count > mealIndex Then
                    legacyRecipe = CType(listBox.Items(mealIndex), String)
                End If

                If String.IsNullOrWhiteSpace(legacyRecipe) OrElse legacyRecipe = GetDefaultRecipeText() Then
                    legacyRecipe = String.Empty
                End If

                legacyMealKey.SetValue("Recette", legacyRecipe)
                legacyMealKey.SetValue("Livre", String.Empty)
            Next
        Next
        ModifyMenu = False
        MessageBox.Show(LangINI.GetKeyValue("Popotte - Menu", "23"), "Popotte", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ButtonPreviousWeek_Click(sender As Object, e As EventArgs) Handles ButtonPreviousWeek.Click
        If ModifyMenu Then
            Dim answer As Integer = MessageBox.Show(LangINI.GetKeyValue("Popotte - EditorWindow - Messagebox", "53"), LangINI.GetKeyValue("Popotte - EditorWindow - Messagebox", "7"), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)
            Select Case answer
                Case DialogResult.Cancel
                    Return
                Case DialogResult.No
                    CurrentWeekStart = CurrentWeekStart.AddDays(-7)
                    LoadCurrentWeekMenu()
                Case DialogResult.Yes
                    SaveCurrentWeek()
                    CurrentWeekStart = CurrentWeekStart.AddDays(-7)
                    LoadCurrentWeekMenu()
            End Select
        Else
            CurrentWeekStart = CurrentWeekStart.AddDays(-7)
            LoadCurrentWeekMenu()
        End If
    End Sub

    Private Sub ButtonNextWeek_Click(sender As Object, e As EventArgs) Handles ButtonNextWeek.Click
        If ModifyMenu Then
            Dim answer As Integer = MessageBox.Show(LangINI.GetKeyValue("Popotte - EditorWindow - Messagebox", "53"), LangINI.GetKeyValue("Popotte - EditorWindow - Messagebox", "7"), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)
            Select Case answer
                Case DialogResult.Cancel
                    Return
                Case DialogResult.No
                    CurrentWeekStart = CurrentWeekStart.AddDays(7)
                    LoadCurrentWeekMenu()
                Case DialogResult.Yes
                    SaveCurrentWeek()
                    CurrentWeekStart = CurrentWeekStart.AddDays(7)
                    LoadCurrentWeekMenu()
            End Select
        Else
            CurrentWeekStart = CurrentWeekStart.AddDays(7)
            LoadCurrentWeekMenu()
        End If

    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        SaveCurrentWeek()
    End Sub

    Private Sub FrmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCurrentWeekMenu()
    End Sub

    Private Sub FrmMenu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If ModifyMenu Then
            Dim answer As Integer = MessageBox.Show(LangINI.GetKeyValue("Popotte - EditorWindow - Messagebox", "52"), LangINI.GetKeyValue("Popotte - EditorWindow - Messagebox", "7"), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)
            Select Case answer
                Case DialogResult.Cancel
                    e.Cancel = True
                Case DialogResult.No
                    ' Do nothing, just close
                Case DialogResult.Yes
                    SaveCurrentWeek()
            End Select
        End If
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        If ListBoxSunday.SelectedItems.Count > 0 Then
            Dim clipttext As String = Clipboard.GetText()
            If clipttext <> "" Then
                CollerLeTexteToolStripMenuItem.Enabled = True
            Else
                CollerLeTexteToolStripMenuItem.Enabled = False
            End If
            EffacerToolStripMenuItem.Enabled = True
            ModifierToolStripMenuItem.Enabled = True
        Else
            EffacerToolStripMenuItem.Enabled = False
            ModifierToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub ContextMenuStrip2_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip2.Opening
        If ListBoxMonday.SelectedItems.Count > 0 Then
            Dim clipttext As String = Clipboard.GetText()
            If clipttext <> "" Then
                CollerLeTexteToolStripMenuItem1.Enabled = True
            Else
                CollerLeTexteToolStripMenuItem1.Enabled = False
            End If
            Effacer2ToolStripMenuItem.Enabled = True
            Modifier2ToolStripMenuItem.Enabled = True
        Else
            Effacer2ToolStripMenuItem.Enabled = False
            Modifier2ToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub ContextMenuStrip3_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip3.Opening
        If ListBoxTuesday.SelectedItems.Count > 0 Then
            Dim clipttext As String = Clipboard.GetText()
            If clipttext <> "" Then
                CollerLeTexteToolStripMenuItem2.Enabled = True
            Else
                CollerLeTexteToolStripMenuItem2.Enabled = False
            End If
            Effacer3ToolStripMenuItem.Enabled = True
            Modifier3ToolStripMenuItem.Enabled = True
        Else
            Effacer3ToolStripMenuItem.Enabled = False
            Modifier3ToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub ContextMenuStrip4_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip4.Opening
        If ListBoxWednesday.SelectedItems.Count > 0 Then
            Dim clipttext As String = Clipboard.GetText()
            If clipttext <> "" Then
                CollerLeTexteToolStripMenuItem3.Enabled = True
            Else
                CollerLeTexteToolStripMenuItem3.Enabled = False
            End If
            Effacer4ToolStripMenuItem.Enabled = True
            Modifier4ToolStripMenuItem.Enabled = True
        Else
            Effacer4ToolStripMenuItem.Enabled = False
            Modifier4ToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub ContextMenuStrip5_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip5.Opening
        If ListBoxThursday.SelectedItems.Count > 0 Then
            Dim clipttext As String = Clipboard.GetText()
            If clipttext <> "" Then
                CollerLeTexteToolStripMenuItem4.Enabled = True
            Else
                CollerLeTexteToolStripMenuItem4.Enabled = False
            End If
            Effacer5ToolStripMenuItem.Enabled = True
            Modifier5ToolStripMenuItem.Enabled = True
        Else
            Effacer5ToolStripMenuItem.Enabled = False
            Modifier5ToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub ContextMenuStrip6_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip6.Opening
        If ListBoxFriday.SelectedItems.Count > 0 Then
            Dim clipttext As String = Clipboard.GetText()
            If clipttext <> "" Then
                CollerLeTexteToolStripMenuItem5.Enabled = True
            Else
                CollerLeTexteToolStripMenuItem5.Enabled = False
            End If
            Effacer6ToolStripMenuItem.Enabled = True
            Modifier6ToolStripMenuItem.Enabled = True
        Else
            Effacer6ToolStripMenuItem.Enabled = False
            Modifier6ToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub ContextMenuStrip7_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip7.Opening
        If ListBoxSaturday.SelectedItems.Count > 0 Then
            Dim clipttext As String = Clipboard.GetText()
            If clipttext <> "" Then
                CollerLeTexteToolStripMenuItem6.Enabled = True
            Else
                CollerLeTexteToolStripMenuItem6.Enabled = False
            End If
            Effacer7ToolStripMenuItem.Enabled = True
            Modifier7ToolStripMenuItem.Enabled = True
        Else
            Effacer7ToolStripMenuItem.Enabled = False
            Modifier7ToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub EffacerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EffacerToolStripMenuItem.Click
        Dim index As Integer = ListBoxSunday.SelectedIndex

        ListBoxSunday.Items(index) = LangINI.GetKeyValue("Popotte - Menu", "1")
        ModifyMenu = True
    End Sub

    Private Sub Effacer2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Effacer2ToolStripMenuItem.Click
        Dim index As Integer = ListBoxMonday.SelectedIndex

        ListBoxMonday.Items(index) = LangINI.GetKeyValue("Popotte - Menu", "1")
        ModifyMenu = True
    End Sub

    Private Sub Effacer3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Effacer3ToolStripMenuItem.Click
        Dim index As Integer = ListBoxTuesday.SelectedIndex

        ListBoxTuesday.Items(index) = LangINI.GetKeyValue("Popotte - Menu", "1")
        ModifyMenu = True
    End Sub

    Private Sub Effacer4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Effacer4ToolStripMenuItem.Click
        Dim index As Integer = ListBoxWednesday.SelectedIndex

        ListBoxWednesday.Items(index) = LangINI.GetKeyValue("Popotte - Menu", "1")
        ModifyMenu = True
    End Sub

    Private Sub Effacer5ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Effacer5ToolStripMenuItem.Click
        Dim index As Integer = ListBoxThursday.SelectedIndex

        ListBoxThursday.Items(index) = LangINI.GetKeyValue("Popotte - Menu", "1")
        ModifyMenu = True
    End Sub

    Private Sub Effacer6ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Effacer6ToolStripMenuItem.Click
        Dim index As Integer = ListBoxFriday.SelectedIndex

        ListBoxFriday.Items(index) = LangINI.GetKeyValue("Popotte - Menu", "1")
        ModifyMenu = True
    End Sub

    Private Sub Effacer7ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Effacer7ToolStripMenuItem.Click
        Dim index As Integer = ListBoxSaturday.SelectedIndex

        ListBoxSaturday.Items(index) = LangINI.GetKeyValue("Popotte - Menu", "1")
        ModifyMenu = True
    End Sub

    Private Sub ModifierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifierToolStripMenuItem.Click
        Dim index As Integer = ListBoxSunday.SelectedIndex
        Dim mr As New dlgmodifymenu(ListBoxSunday.Items(index).ToString, ListBoxSunday, index, 1)
        mr.ShowDialog()
        ModifyMenu = True
        mr.Dispose()
    End Sub

    Private Sub Modifier2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Modifier2ToolStripMenuItem.Click
        Dim index As Integer = ListBoxMonday.SelectedIndex
        Dim mr As New dlgmodifymenu(ListBoxMonday.Items(index).ToString, ListBoxMonday, index, 2)
        mr.ShowDialog()
        ModifyMenu = True
        mr.Dispose()
    End Sub

    Private Sub Modifier3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Modifier3ToolStripMenuItem.Click
        Dim index As Integer = ListBoxTuesday.SelectedIndex
        Dim mr As New dlgmodifymenu(ListBoxTuesday.Items(index).ToString, ListBoxTuesday, index, 3)
        mr.ShowDialog()
        ModifyMenu = True
        mr.Dispose()
    End Sub

    Private Sub Modifier4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Modifier4ToolStripMenuItem.Click
        Dim index As Integer = ListBoxWednesday.SelectedIndex
        Dim mr As New dlgmodifymenu(ListBoxWednesday.Items(index).ToString, ListBoxWednesday, index, 4)
        mr.ShowDialog()
        ModifyMenu = True
        mr.Dispose()
    End Sub

    Private Sub Modifier5ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Modifier5ToolStripMenuItem.Click
        Dim index As Integer = ListBoxThursday.SelectedIndex
        Dim mr As New dlgmodifymenu(ListBoxThursday.Items(index).ToString, ListBoxThursday, index, 5)
        mr.ShowDialog()
        ModifyMenu = True
        mr.Dispose()
    End Sub

    Private Sub Modifier6ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Modifier6ToolStripMenuItem.Click
        Dim index As Integer = ListBoxFriday.SelectedIndex
        Dim mr As New dlgmodifymenu(ListBoxFriday.Items(index).ToString, ListBoxFriday, index, 6)
        mr.ShowDialog()
        ModifyMenu = True
        mr.Dispose()
    End Sub

    Private Sub Modifier7ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Modifier7ToolStripMenuItem.Click
        Dim index As Integer = ListBoxSaturday.SelectedIndex
        Dim mr As New dlgmodifymenu(ListBoxSaturday.Items(index).ToString, ListBoxSaturday, index, 7)
        mr.ShowDialog()
        ModifyMenu = True
        mr.Dispose()
    End Sub


    Private Sub CollerLeTexteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CollerLeTexteToolStripMenuItem.Click
        Dim index As Integer = ListBoxSunday.SelectedIndex
        Dim mealgroup As String = ""
        Dim day As String = "Sunday"
        Dim clipttext As String = Clipboard.GetText()
        If clipttext <> "" Then
            ListBoxSunday.Items(index) = clipttext
            ModifyMenu = True
        End If
    End Sub

    Private Sub CollerLeTexteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CollerLeTexteToolStripMenuItem1.Click
        Dim index As Integer = ListBoxMonday.SelectedIndex
        Dim mealgroup As String = ""
        Dim day As String = "Monday"
        Dim clipttext As String = Clipboard.GetText()
        If clipttext <> "" Then
            ListBoxMonday.Items(index) = clipttext
            ModifyMenu = True
        End If
    End Sub

    Private Sub CollerLeTexteToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles CollerLeTexteToolStripMenuItem2.Click
        Dim index As Integer = ListBoxTuesday.SelectedIndex
        Dim mealgroup As String = ""
        Dim day As String = "Tuesday"
        Dim clipttext As String = Clipboard.GetText()
        If clipttext <> "" Then
            ListBoxTuesday.Items(index) = clipttext
            ModifyMenu = True
        End If
    End Sub

    Private Sub CollerLeTexteToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles CollerLeTexteToolStripMenuItem3.Click
        Dim index As Integer = ListBoxWednesday.SelectedIndex
        Dim mealgroup As String = ""
        Dim day As String = "Wednesday"
        Dim clipttext As String = Clipboard.GetText()
        If clipttext <> "" Then
            ListBoxWednesday.Items(index) = clipttext
            ModifyMenu = True
        End If
    End Sub

    Private Sub CollerLeTexteToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles CollerLeTexteToolStripMenuItem4.Click
        Dim index As Integer = ListBoxThursday.SelectedIndex
        Dim mealgroup As String = ""
        Dim day As String = "Thursday"
        Dim clipttext As String = Clipboard.GetText()
        If clipttext <> "" Then
            ListBoxThursday.Items(index) = clipttext
            ModifyMenu = True
        End If
    End Sub

    Private Sub CollerLeTexteToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles CollerLeTexteToolStripMenuItem5.Click
        Dim index As Integer = ListBoxFriday.SelectedIndex
        Dim mealgroup As String = ""
        Dim day As String = "Friday"
        Dim clipttext As String = Clipboard.GetText()
        If clipttext <> "" Then
            ListBoxFriday.Items(index) = clipttext
            ModifyMenu = True
        End If
    End Sub

    Private Sub CollerLeTexteToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles CollerLeTexteToolStripMenuItem6.Click
        Dim index As Integer = ListBoxSaturday.SelectedIndex
        Dim mealgroup As String = ""
        Dim day As String = "Saturday"
        Dim clipttext As String = Clipboard.GetText()
        If clipttext <> "" Then
            ListBoxSaturday.Items(index) = clipttext
            ModifyMenu = True
        End If
    End Sub


    Private Sub ButtonPreview_Click(sender As Object, e As EventArgs) Handles ButtonPreview.Click
        If ModifyMenu Then
            Dim answer As Integer = MessageBox.Show(LangINI.GetKeyValue("Popotte - EditorWindow - Messagebox", "52"), LangINI.GetKeyValue("Popotte - EditorWindow - Messagebox", "7"), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)
            Select Case answer
                Case DialogResult.Cancel
                    Return
                Case DialogResult.No
                    Dim answerM As Integer = MessageBox.Show(LangINI.GetKeyValue("Popotte - EditorWindow - Messagebox", "10"), LangINI.GetKeyValue("Popotte - EditorWindow - Messagebox", "7"), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)
                    Select Case answerM
                        Case DialogResult.Cancel
                        Case DialogResult.No
                            frmMain.rtbDoc.Clear()
                            Printmenu()
                            frmMain.rtbDoc.SelectAll()
                            frmMain.SetDefaultFont()
                            frmMain.rtbDoc.Focus()
                            frmMain.currentFile = ""
                            frmMain.Text = "Popotte"
                            frmMain.LivreOuvert = ""
                            frmMain.rtbDoc.SelectionAlignment = ExtendedRichTextBox.TextAlign.Left
                            frmMain.ToolStripButtonGauche.Checked = True
                            frmMain.ToolStripButtonCentre.Checked = False
                            frmMain.ToolStripButtonDroite.Checked = False
                            frmMain.TexteÀGaucheToolStripMenuItem.Checked = True
                            frmMain.TexteCentréToolStripMenuItem.Checked = False
                            frmMain.TexteÀDroiteToolStripMenuItem.Checked = False
                            Close()
                        Case DialogResult.Yes
                            frmMain.SaveToolStripMenuItem_Click(Me, e)
                            frmMain.rtbDoc.Clear()
                            Printmenu()
                            frmMain.rtbDoc.SelectAll()
                            frmMain.SetDefaultFont()
                            frmMain.rtbDoc.Focus()
                            frmMain.currentFile = ""
                            frmMain.Text = "Popotte"
                            frmMain.LivreOuvert = ""
                            frmMain.rtbDoc.SelectionAlignment = ExtendedRichTextBox.TextAlign.Left
                            frmMain.ToolStripButtonGauche.Checked = True
                            frmMain.ToolStripButtonCentre.Checked = False
                            frmMain.ToolStripButtonDroite.Checked = False
                            frmMain.TexteÀGaucheToolStripMenuItem.Checked = True
                            frmMain.TexteCentréToolStripMenuItem.Checked = False
                            frmMain.TexteÀDroiteToolStripMenuItem.Checked = False
                            Close()
                    End Select
                Case DialogResult.Yes

                    SaveCurrentWeek()
                    If frmMain.rtbDoc.Modified = False Then
                        frmMain.rtbDoc.Clear()
                        Printmenu()
                        frmMain.rtbDoc.SelectAll()
                        frmMain.SetDefaultFont()
                        frmMain.rtbDoc.Focus()
                        frmMain.currentFile = ""
                        frmMain.Text = "Popotte"
                        frmMain.LivreOuvert = ""
                        frmMain.rtbDoc.SelectionAlignment = ExtendedRichTextBox.TextAlign.Left
                        frmMain.ToolStripButtonGauche.Checked = True
                        frmMain.ToolStripButtonCentre.Checked = False
                        frmMain.ToolStripButtonDroite.Checked = False
                        frmMain.TexteÀGaucheToolStripMenuItem.Checked = True
                        frmMain.TexteCentréToolStripMenuItem.Checked = False
                        frmMain.TexteÀDroiteToolStripMenuItem.Checked = False
                        Close()
                    Else
                        Dim answerY As Integer = MessageBox.Show(LangINI.GetKeyValue("Popotte - EditorWindow - Messagebox", "10"), LangINI.GetKeyValue("Popotte - EditorWindow - Messagebox", "7"), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)
                        Select Case answerY
                            Case DialogResult.Cancel
                            Case DialogResult.No
                                frmMain.rtbDoc.Clear()
                                Printmenu()
                                frmMain.rtbDoc.SelectAll()
                                frmMain.SetDefaultFont()
                                frmMain.rtbDoc.Focus()
                                frmMain.currentFile = ""
                                frmMain.Text = "Popotte"
                                frmMain.LivreOuvert = ""
                                frmMain.rtbDoc.SelectionAlignment = ExtendedRichTextBox.TextAlign.Left
                                frmMain.ToolStripButtonGauche.Checked = True
                                frmMain.ToolStripButtonCentre.Checked = False
                                frmMain.ToolStripButtonDroite.Checked = False
                                frmMain.TexteÀGaucheToolStripMenuItem.Checked = True
                                frmMain.TexteCentréToolStripMenuItem.Checked = False
                                frmMain.TexteÀDroiteToolStripMenuItem.Checked = False
                                Close()
                            Case DialogResult.Yes
                                frmMain.SaveToolStripMenuItem_Click(Me, e)
                                frmMain.rtbDoc.Clear()
                                Printmenu()
                                frmMain.rtbDoc.SelectAll()
                                frmMain.SetDefaultFont()
                                frmMain.rtbDoc.Focus()
                                frmMain.currentFile = ""
                                frmMain.Text = "Popotte"
                                frmMain.LivreOuvert = ""
                                frmMain.rtbDoc.SelectionAlignment = ExtendedRichTextBox.TextAlign.Left
                                frmMain.ToolStripButtonGauche.Checked = True
                                frmMain.ToolStripButtonCentre.Checked = False
                                frmMain.ToolStripButtonDroite.Checked = False
                                frmMain.TexteÀGaucheToolStripMenuItem.Checked = True
                                frmMain.TexteCentréToolStripMenuItem.Checked = False
                                frmMain.TexteÀDroiteToolStripMenuItem.Checked = False
                                Close()
                        End Select
                    End If


            End Select

        Else
            If frmMain.rtbDoc.Modified = False Then
                frmMain.rtbDoc.Clear()
                Printmenu()
                frmMain.rtbDoc.SelectAll()
                frmMain.SetDefaultFont()
                frmMain.rtbDoc.Focus()
                frmMain.currentFile = ""
                frmMain.Text = "Popotte"
                frmMain.LivreOuvert = ""
                frmMain.rtbDoc.SelectionAlignment = ExtendedRichTextBox.TextAlign.Left
                frmMain.ToolStripButtonGauche.Checked = True
                frmMain.ToolStripButtonCentre.Checked = False
                frmMain.ToolStripButtonDroite.Checked = False
                frmMain.TexteÀGaucheToolStripMenuItem.Checked = True
                frmMain.TexteCentréToolStripMenuItem.Checked = False
                frmMain.TexteÀDroiteToolStripMenuItem.Checked = False
                Close()
            Else
                Dim answerM As Integer = MessageBox.Show(LangINI.GetKeyValue("Popotte - EditorWindow - Messagebox", "10"), LangINI.GetKeyValue("Popotte - EditorWindow - Messagebox", "7"), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)
                Select Case answerM
                    Case DialogResult.Cancel
                    Case DialogResult.No
                        frmMain.rtbDoc.Clear()
                        Printmenu()
                        frmMain.rtbDoc.SelectAll()
                        frmMain.SetDefaultFont()
                        frmMain.rtbDoc.Focus()
                        frmMain.currentFile = ""
                        frmMain.Text = "Popotte"
                        frmMain.LivreOuvert = ""
                        frmMain.rtbDoc.SelectionAlignment = ExtendedRichTextBox.TextAlign.Left
                        frmMain.ToolStripButtonGauche.Checked = True
                        frmMain.ToolStripButtonCentre.Checked = False
                        frmMain.ToolStripButtonDroite.Checked = False
                        frmMain.TexteÀGaucheToolStripMenuItem.Checked = True
                        frmMain.TexteCentréToolStripMenuItem.Checked = False
                        frmMain.TexteÀDroiteToolStripMenuItem.Checked = False
                        Close()
                    Case DialogResult.Yes
                        frmMain.SaveToolStripMenuItem_Click(Me, e)
                        frmMain.rtbDoc.Clear()
                        Printmenu()
                        frmMain.rtbDoc.SelectAll()
                        frmMain.SetDefaultFont()
                        frmMain.rtbDoc.Focus()
                        frmMain.currentFile = ""
                        frmMain.Text = "Popotte"
                        frmMain.LivreOuvert = ""
                        frmMain.rtbDoc.SelectionAlignment = ExtendedRichTextBox.TextAlign.Left
                        frmMain.ToolStripButtonGauche.Checked = True
                        frmMain.ToolStripButtonCentre.Checked = False
                        frmMain.ToolStripButtonDroite.Checked = False
                        frmMain.TexteÀGaucheToolStripMenuItem.Checked = True
                        frmMain.TexteCentréToolStripMenuItem.Checked = False
                        frmMain.TexteÀDroiteToolStripMenuItem.Checked = False
                        Close()
                End Select
            End If
        End If



    End Sub

    Private Sub Printmenu()
        Dim sb As New StringBuilder()
        sb.AppendLine()
        sb.AppendLine(LangINI.GetKeyValue("Popotte - Menu", "12") & " :")
        sb.AppendLine()
        sb.AppendLine(LabelSunday.Text & " :")
        sb.AppendLine(LangINI.GetKeyValue("Popotte - Menu", "13") & " :  " & ListBoxSunday.Items(0).ToString)
        sb.AppendLine(LangINI.GetKeyValue("Popotte - Menu", "14") & " :  " & ListBoxSunday.Items(1).ToString)
        sb.AppendLine(LangINI.GetKeyValue("Popotte - Menu", "15") & " :  " & ListBoxSunday.Items(2).ToString)
        sb.AppendLine()
        sb.AppendLine(LabelMonday.Text & " :")
        sb.AppendLine(LangINI.GetKeyValue("Popotte - Menu", "13") & " :  " & ListBoxMonday.Items(0).ToString)
        sb.AppendLine(LangINI.GetKeyValue("Popotte - Menu", "14") & " :  " & ListBoxMonday.Items(1).ToString)
        sb.AppendLine(LangINI.GetKeyValue("Popotte - Menu", "15") & " :  " & ListBoxMonday.Items(2).ToString)
        sb.AppendLine()
        sb.AppendLine(LabelTuesday.Text & " :")
        sb.AppendLine(LangINI.GetKeyValue("Popotte - Menu", "13") & " :  " & ListBoxTuesday.Items(0).ToString)
        sb.AppendLine(LangINI.GetKeyValue("Popotte - Menu", "14") & " :  " & ListBoxTuesday.Items(1).ToString)
        sb.AppendLine(LangINI.GetKeyValue("Popotte - Menu", "15") & " :  " & ListBoxTuesday.Items(2).ToString)
        sb.AppendLine()
        sb.AppendLine(LabelWednesday.Text & " :")
        sb.AppendLine(LangINI.GetKeyValue("Popotte - Menu", "13") & " :  " & ListBoxWednesday.Items(0).ToString)
        sb.AppendLine(LangINI.GetKeyValue("Popotte - Menu", "14") & " :  " & ListBoxWednesday.Items(1).ToString)
        sb.AppendLine(LangINI.GetKeyValue("Popotte - Menu", "15") & " :  " & ListBoxWednesday.Items(2).ToString)
        sb.AppendLine()
        sb.AppendLine(LabelThursday.Text & " :")
        sb.AppendLine(LangINI.GetKeyValue("Popotte - Menu", "13") & " :  " & ListBoxThursday.Items(0).ToString)
        sb.AppendLine(LangINI.GetKeyValue("Popotte - Menu", "14") & " :  " & ListBoxThursday.Items(1).ToString)
        sb.AppendLine(LangINI.GetKeyValue("Popotte - Menu", "15") & " :  " & ListBoxThursday.Items(2).ToString)
        sb.AppendLine()
        sb.AppendLine(LabelFriday.Text & " :")
        sb.AppendLine(LangINI.GetKeyValue("Popotte - Menu", "13") & " :  " & ListBoxFriday.Items(0).ToString)
        sb.AppendLine(LangINI.GetKeyValue("Popotte - Menu", "14") & " :  " & ListBoxFriday.Items(1).ToString)
        sb.AppendLine(LangINI.GetKeyValue("Popotte - Menu", "15") & " :  " & ListBoxFriday.Items(2).ToString)
        sb.AppendLine()
        sb.AppendLine(LabelSaturday.Text & " :")
        sb.AppendLine(LangINI.GetKeyValue("Popotte - Menu", "13") & " :  " & ListBoxSaturday.Items(0).ToString)
        sb.AppendLine(LangINI.GetKeyValue("Popotte - Menu", "14") & " :  " & ListBoxSaturday.Items(1).ToString)
        sb.AppendLine(LangINI.GetKeyValue("Popotte - Menu", "15") & " :  " & ListBoxSaturday.Items(2).ToString)

        frmMain.rtbDoc.Text = sb.ToString
    End Sub

    Private Sub Button1Touteff_Click(sender As Object, e As EventArgs) Handles Button1Touteff.Click

        Dim DlgResult = MessageBox.Show(LangINI.GetKeyValue("Popotte - MenuDialogue - MessageBox", "1"), "Popotte", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If DlgResult = DialogResult.Yes Then
            For i As Integer = 0 To 2
                ListBoxSunday.Items(i) = LangINI.GetKeyValue("Popotte - Menu", "1")
                ListBoxMonday.Items(i) = LangINI.GetKeyValue("Popotte - Menu", "1")
                ListBoxTuesday.Items(i) = LangINI.GetKeyValue("Popotte - Menu", "1")
                ListBoxWednesday.Items(i) = LangINI.GetKeyValue("Popotte - Menu", "1")
                ListBoxThursday.Items(i) = LangINI.GetKeyValue("Popotte - Menu", "1")
                ListBoxFriday.Items(i) = LangINI.GetKeyValue("Popotte - Menu", "1")
                ListBoxSaturday.Items(i) = LangINI.GetKeyValue("Popotte - Menu", "1")
            Next
            ModifyMenu = True
        End If


    End Sub


End Class