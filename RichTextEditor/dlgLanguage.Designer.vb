<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class LanguageDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LanguageDialog))
        TableLayoutPanel1 = New TableLayoutPanel()
        OK_Button = New Button()
        Cancel_Button = New Button()
        LanguageComboBox = New ComboBox()
        LabelLanguage = New Label()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(OK_Button, 0, 0)
        TableLayoutPanel1.Controls.Add(Cancel_Button, 1, 0)
        TableLayoutPanel1.Location = New Point(214, 147)
        TableLayoutPanel1.Margin = New Padding(4, 5, 4, 5)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 47F))
        TableLayoutPanel1.Size = New Size(243, 47)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' OK_Button
        ' 
        OK_Button.Anchor = AnchorStyles.None
        OK_Button.FlatStyle = FlatStyle.System
        OK_Button.Location = New Point(5, 5)
        OK_Button.Margin = New Padding(4, 5, 4, 5)
        OK_Button.Name = "OK_Button"
        OK_Button.Size = New Size(111, 37)
        OK_Button.TabIndex = 2
        OK_Button.Text = "OK"
        ' 
        ' Cancel_Button
        ' 
        Cancel_Button.Anchor = AnchorStyles.None
        Cancel_Button.DialogResult = DialogResult.Cancel
        Cancel_Button.FlatStyle = FlatStyle.System
        Cancel_Button.Location = New Point(126, 5)
        Cancel_Button.Margin = New Padding(4, 5, 4, 5)
        Cancel_Button.Name = "Cancel_Button"
        Cancel_Button.Size = New Size(111, 37)
        Cancel_Button.TabIndex = 2
        Cancel_Button.Text = "Annuler"
        ' 
        ' LanguageComboBox
        ' 
        LanguageComboBox.BackColor = SystemColors.GradientInactiveCaption
        LanguageComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        LanguageComboBox.FlatStyle = FlatStyle.System
        LanguageComboBox.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LanguageComboBox.ForeColor = SystemColors.WindowText
        LanguageComboBox.FormattingEnabled = True
        LanguageComboBox.Location = New Point(13, 62)
        LanguageComboBox.MaxDropDownItems = 3
        LanguageComboBox.Name = "LanguageComboBox"
        LanguageComboBox.Size = New Size(451, 38)
        LanguageComboBox.Sorted = True
        LanguageComboBox.TabIndex = 1
        ' 
        ' LabelLanguage
        ' 
        LabelLanguage.AutoSize = True
        LabelLanguage.Font = New Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelLanguage.Location = New Point(9, 38)
        LabelLanguage.Name = "LabelLanguage"
        LabelLanguage.Size = New Size(182, 21)
        LabelLanguage.TabIndex = 2
        LabelLanguage.Text = "Langages disponibles :"
        ' 
        ' LanguageDialog
        ' 
        AcceptButton = OK_Button
        AutoScaleDimensions = New SizeF(10F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        CancelButton = Cancel_Button
        ClientSize = New Size(477, 213)
        Controls.Add(LabelLanguage)
        Controls.Add(LanguageComboBox)
        Controls.Add(TableLayoutPanel1)
        Font = New Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedDialog
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4, 5, 4, 5)
        MaximizeBox = False
        MinimizeBox = False
        Name = "LanguageDialog"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "Choisissez votre Langage :"
        TableLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents OK_Button As Button
    Friend WithEvents LanguageComboBox As ComboBox
    Friend WithEvents LabelLanguage As Label
End Class
