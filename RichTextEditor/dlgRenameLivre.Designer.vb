<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RenommerLivreDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RenommerLivreDialog))
        OK_Button = New Button()
        Cancel_Button = New Button()
        NomTextBox = New TextBox()
        LabelNom = New Label()
        SuspendLayout()
        ' 
        ' OK_Button
        ' 
        OK_Button.Anchor = AnchorStyles.None
        OK_Button.FlatStyle = FlatStyle.System
        OK_Button.Location = New Point(211, 144)
        OK_Button.Margin = New Padding(4, 5, 4, 5)
        OK_Button.Name = "OK_Button"
        OK_Button.Size = New Size(111, 37)
        OK_Button.TabIndex = 1
        OK_Button.Text = "OK"
        ' 
        ' Cancel_Button
        ' 
        Cancel_Button.Anchor = AnchorStyles.None
        Cancel_Button.DialogResult = DialogResult.Cancel
        Cancel_Button.FlatStyle = FlatStyle.System
        Cancel_Button.Location = New Point(333, 144)
        Cancel_Button.Margin = New Padding(4, 5, 4, 5)
        Cancel_Button.Name = "Cancel_Button"
        Cancel_Button.Size = New Size(111, 37)
        Cancel_Button.TabIndex = 2
        Cancel_Button.Text = "Annuler"
        ' 
        ' NomTextBox
        ' 
        NomTextBox.BackColor = SystemColors.GradientInactiveCaption
        NomTextBox.BorderStyle = BorderStyle.FixedSingle
        NomTextBox.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        NomTextBox.Location = New Point(20, 72)
        NomTextBox.Margin = New Padding(4, 5, 4, 5)
        NomTextBox.Name = "NomTextBox"
        NomTextBox.Size = New Size(422, 34)
        NomTextBox.TabIndex = 0
        ' 
        ' LabelNom
        ' 
        LabelNom.AutoSize = True
        LabelNom.Location = New Point(16, 46)
        LabelNom.Margin = New Padding(4, 0, 4, 0)
        LabelNom.Name = "LabelNom"
        LabelNom.Size = New Size(134, 21)
        LabelNom.TabIndex = 3
        LabelNom.Text = "Nouveau Nom : "
        ' 
        ' RenommerLivreDialog
        ' 
        AcceptButton = OK_Button
        AutoScaleDimensions = New SizeF(144F, 144F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoSize = True
        AutoValidate = AutoValidate.EnablePreventFocusChange
        CancelButton = Cancel_Button
        ClientSize = New Size(464, 201)
        Controls.Add(LabelNom)
        Controls.Add(NomTextBox)
        Controls.Add(Cancel_Button)
        Controls.Add(OK_Button)
        Font = New Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedDialog
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4, 5, 4, 5)
        MaximizeBox = False
        MinimizeBox = False
        Name = "RenommerLivreDialog"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "Popotte - Changer le Nom du Livre"
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents NomTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LabelNom As System.Windows.Forms.Label

End Class
