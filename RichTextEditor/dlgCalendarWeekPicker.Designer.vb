' Copyright Martin Laflamme 2003/2026
' Read licence.txt

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgCalendarWeekPicker
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        MonthCalendar1 = New MonthCalendar()
        LabelSelectedWeek = New Label()
        ButtonOK = New Button()
        ButtonCancel = New Button()
        LabelInstructions = New Label()
        SuspendLayout()
        ' 
        ' MonthCalendar1
        ' 
        MonthCalendar1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        MonthCalendar1.Location = New Point(80, 58)
        MonthCalendar1.Name = "MonthCalendar1"
        MonthCalendar1.TabIndex = 0
        ' 
        ' LabelSelectedWeek
        ' 
        LabelSelectedWeek.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        LabelSelectedWeek.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelSelectedWeek.Location = New Point(-1, 330)
        LabelSelectedWeek.Name = "LabelSelectedWeek"
        LabelSelectedWeek.Size = New Size(466, 33)
        LabelSelectedWeek.TabIndex = 1
        LabelSelectedWeek.Text = "Semaine"
        LabelSelectedWeek.TextAlign = ContentAlignment.TopCenter
        ' 
        ' ButtonOK
        ' 
        ButtonOK.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        ButtonOK.DialogResult = DialogResult.OK
        ButtonOK.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonOK.Location = New Point(272, 388)
        ButtonOK.Name = "ButtonOK"
        ButtonOK.Size = New Size(85, 34)
        ButtonOK.TabIndex = 2
        ButtonOK.Text = "OK"
        ButtonOK.UseVisualStyleBackColor = True
        ' 
        ' ButtonCancel
        ' 
        ButtonCancel.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        ButtonCancel.DialogResult = DialogResult.Cancel
        ButtonCancel.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonCancel.Location = New Point(363, 388)
        ButtonCancel.Name = "ButtonCancel"
        ButtonCancel.Size = New Size(96, 34)
        ButtonCancel.TabIndex = 3
        ButtonCancel.Text = "Annuler"
        ButtonCancel.UseVisualStyleBackColor = True
        ' 
        ' LabelInstructions
        ' 
        LabelInstructions.Location = New Point(-1, 9)
        LabelInstructions.Name = "LabelInstructions"
        LabelInstructions.Size = New Size(473, 30)
        LabelInstructions.TabIndex = 4
        LabelInstructions.Text = "Cliquez sur un jour pour sélectionner la semaine"
        LabelInstructions.TextAlign = ContentAlignment.TopCenter
        ' 
        ' dlgCalendarWeekPicker
        ' 
        AcceptButton = ButtonOK
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = ButtonCancel
        ClientSize = New Size(471, 434)
        Controls.Add(LabelInstructions)
        Controls.Add(ButtonCancel)
        Controls.Add(ButtonOK)
        Controls.Add(LabelSelectedWeek)
        Controls.Add(MonthCalendar1)
        Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "dlgCalendarWeekPicker"
        StartPosition = FormStartPosition.CenterParent
        Text = "Sélectionner une semaine"
        ResumeLayout(False)
    End Sub

    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents LabelSelectedWeek As Label
    Friend WithEvents ButtonOK As Button
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents LabelInstructions As Label

End Class
