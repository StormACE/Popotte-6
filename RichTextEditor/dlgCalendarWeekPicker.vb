Imports System.Globalization

Public Class dlgCalendarWeekPicker

    Public SelectedWeekStart As DateTime
    Private _currentSelectedDate As DateTime = DateTime.Today
    'Get Language
    Private LangINI As IniFile = frmMain.LangIni

    Private Sub dlgCalendarWeekPicker_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LabelInstructions.Text = LangINI.GetKeyValue("Popotte - Menu", "26")
        ButtonCancel.Text = LangINI.GetKeyValue("Popotte - Menu", "27")
        ButtonOK.Text = LangINI.GetKeyValue("Popotte - Menu", "28")
        Me.Text = LangINI.GetKeyValue("Popotte - Menu", "31")
        ' Initialiser le calendrier avec la date actuelle
        MonthCalendar1.SelectionStart = _currentSelectedDate
        MonthCalendar1.SelectionEnd = _currentSelectedDate

        UpdateWeekDisplay()
    End Sub

    Private Function GetStartOfWeek(ByVal value As DateTime) As DateTime
        ' Dimanche comme premier jour de la semaine
        Dim targetDate As DateTime = value.Date
        Return targetDate.AddDays(-CInt(targetDate.DayOfWeek))
    End Function

    Private Sub UpdateWeekDisplay()
        Dim weekStart As DateTime = GetStartOfWeek(_currentSelectedDate)
        Dim weekEnd As DateTime = weekStart.AddDays(6)
        LabelSelectedWeek.Text = String.Format(LangINI.GetKeyValue("Popotte - Menu", "29") & " {0:dd/MM/yyyy} " & LangINI.GetKeyValue("Popotte - Menu", "30") & " {1:dd/MM/yyyy}", weekStart, weekEnd)
    End Sub

    Private Sub MonthCalendar1_DateSelected(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        _currentSelectedDate = e.Start
        SelectedWeekStart = GetStartOfWeek(_currentSelectedDate)
        UpdateWeekDisplay()
    End Sub

End Class
