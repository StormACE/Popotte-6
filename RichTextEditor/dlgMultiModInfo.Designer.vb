<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgMultiModInfo
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgMultiModInfo))
        OK_Button = New Button()
        Cancel_Button = New Button()
        LivresComboBox = New ComboBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' OK_Button
        ' 
        OK_Button.Anchor = AnchorStyles.None
        OK_Button.Location = New Point(107, 148)
        OK_Button.Margin = New Padding(4, 6, 4, 6)
        OK_Button.Name = "OK_Button"
        OK_Button.Size = New Size(111, 44)
        OK_Button.TabIndex = 0
        OK_Button.Text = "OK"
        ' 
        ' Cancel_Button
        ' 
        Cancel_Button.Anchor = AnchorStyles.None
        Cancel_Button.DialogResult = DialogResult.Cancel
        Cancel_Button.Location = New Point(227, 148)
        Cancel_Button.Margin = New Padding(4, 6, 4, 6)
        Cancel_Button.Name = "Cancel_Button"
        Cancel_Button.Size = New Size(111, 44)
        Cancel_Button.TabIndex = 1
        Cancel_Button.Text = "Annuler"
        ' 
        ' LivresComboBox
        ' 
        LivresComboBox.AllowDrop = True
        LivresComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        LivresComboBox.AutoCompleteSource = AutoCompleteSource.ListItems
        LivresComboBox.FlatStyle = FlatStyle.System
        LivresComboBox.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LivresComboBox.FormattingEnabled = True
        LivresComboBox.IntegralHeight = False
        LivresComboBox.Location = New Point(20, 74)
        LivresComboBox.Margin = New Padding(3, 4, 3, 4)
        LivresComboBox.Name = "LivresComboBox"
        LivresComboBox.Size = New Size(317, 36)
        LivresComboBox.Sorted = True
        LivresComboBox.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(14, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 25)
        Label1.TabIndex = 2
        Label1.Text = "Livre :"
        ' 
        ' dlgMultiModInfo
        ' 
        AcceptButton = OK_Button
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = Cancel_Button
        ClientSize = New Size(357, 209)
        Controls.Add(Cancel_Button)
        Controls.Add(OK_Button)
        Controls.Add(Label1)
        Controls.Add(LivresComboBox)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4, 6, 4, 6)
        MaximizeBox = False
        MinimizeBox = False
        Name = "dlgMultiModInfo"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "Déplacer vers le Livre :"
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents LivresComboBox As ComboBox
    Friend WithEvents Label1 As Label
End Class
