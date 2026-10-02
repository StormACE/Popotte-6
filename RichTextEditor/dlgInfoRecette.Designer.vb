<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgInfoRecette
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgInfoRecette))
        Cancel_Button = New Button()
        OK_Button = New Button()
        NomTextBox = New TextBox()
        NoteComboBox = New ComboBox()
        DescTextBox = New TextBox()
        LabelRecette = New Label()
        LabelNote = New Label()
        LabelDesc = New Label()
        LabelLivre = New Label()
        ComboBoxLivre = New ComboBox()
        SuspendLayout()
        ' 
        ' Cancel_Button
        ' 
        Cancel_Button.Anchor = AnchorStyles.None
        Cancel_Button.DialogResult = DialogResult.Cancel
        Cancel_Button.FlatStyle = FlatStyle.System
        Cancel_Button.Location = New Point(502, 265)
        Cancel_Button.Margin = New Padding(4, 5, 4, 5)
        Cancel_Button.Name = "Cancel_Button"
        Cancel_Button.Size = New Size(111, 37)
        Cancel_Button.TabIndex = 5
        Cancel_Button.Text = "Annuler"
        ' 
        ' OK_Button
        ' 
        OK_Button.Anchor = AnchorStyles.None
        OK_Button.FlatStyle = FlatStyle.System
        OK_Button.Location = New Point(380, 265)
        OK_Button.Margin = New Padding(4, 5, 4, 5)
        OK_Button.Name = "OK_Button"
        OK_Button.Size = New Size(111, 37)
        OK_Button.TabIndex = 4
        OK_Button.Text = "OK"
        ' 
        ' NomTextBox
        ' 
        NomTextBox.BackColor = SystemColors.GradientInactiveCaption
        NomTextBox.BorderStyle = BorderStyle.FixedSingle
        NomTextBox.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        NomTextBox.Location = New Point(20, 47)
        NomTextBox.Margin = New Padding(4, 5, 4, 5)
        NomTextBox.Name = "NomTextBox"
        NomTextBox.Size = New Size(591, 34)
        NomTextBox.TabIndex = 0
        ' 
        ' NoteComboBox
        ' 
        NoteComboBox.BackColor = SystemColors.GradientInactiveCaption
        NoteComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        NoteComboBox.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        NoteComboBox.FormattingEnabled = True
        NoteComboBox.Location = New Point(380, 129)
        NoteComboBox.Margin = New Padding(4, 5, 4, 5)
        NoteComboBox.Name = "NoteComboBox"
        NoteComboBox.Size = New Size(231, 36)
        NoteComboBox.TabIndex = 2
        ' 
        ' DescTextBox
        ' 
        DescTextBox.BackColor = SystemColors.GradientInactiveCaption
        DescTextBox.BorderStyle = BorderStyle.FixedSingle
        DescTextBox.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DescTextBox.Location = New Point(20, 208)
        DescTextBox.Margin = New Padding(4, 5, 4, 5)
        DescTextBox.Name = "DescTextBox"
        DescTextBox.Size = New Size(591, 34)
        DescTextBox.TabIndex = 3
        ' 
        ' LabelRecette
        ' 
        LabelRecette.AutoSize = True
        LabelRecette.Location = New Point(16, 21)
        LabelRecette.Margin = New Padding(4, 0, 4, 0)
        LabelRecette.Name = "LabelRecette"
        LabelRecette.Size = New Size(158, 21)
        LabelRecette.TabIndex = 5
        LabelRecette.Text = "Nom de la Recette :"
        ' 
        ' LabelNote
        ' 
        LabelNote.AutoSize = True
        LabelNote.Location = New Point(376, 103)
        LabelNote.Margin = New Padding(4, 0, 4, 0)
        LabelNote.Name = "LabelNote"
        LabelNote.Size = New Size(56, 21)
        LabelNote.TabIndex = 6
        LabelNote.Text = "Note :"
        ' 
        ' LabelDesc
        ' 
        LabelDesc.AutoSize = True
        LabelDesc.Location = New Point(16, 182)
        LabelDesc.Margin = New Padding(4, 0, 4, 0)
        LabelDesc.Name = "LabelDesc"
        LabelDesc.Size = New Size(106, 21)
        LabelDesc.TabIndex = 7
        LabelDesc.Text = "Description :"
        ' 
        ' LabelLivre
        ' 
        LabelLivre.AutoSize = True
        LabelLivre.Location = New Point(16, 103)
        LabelLivre.Margin = New Padding(4, 0, 4, 0)
        LabelLivre.Name = "LabelLivre"
        LabelLivre.Size = New Size(55, 21)
        LabelLivre.TabIndex = 8
        LabelLivre.Text = "Livre :"
        ' 
        ' ComboBoxLivre
        ' 
        ComboBoxLivre.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ComboBoxLivre.AutoCompleteSource = AutoCompleteSource.ListItems
        ComboBoxLivre.BackColor = SystemColors.GradientInactiveCaption
        ComboBoxLivre.DropDownHeight = 118
        ComboBoxLivre.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ComboBoxLivre.FormattingEnabled = True
        ComboBoxLivre.IntegralHeight = False
        ComboBoxLivre.Location = New Point(20, 129)
        ComboBoxLivre.Margin = New Padding(4, 5, 4, 5)
        ComboBoxLivre.Name = "ComboBoxLivre"
        ComboBoxLivre.Size = New Size(347, 36)
        ComboBoxLivre.Sorted = True
        ComboBoxLivre.TabIndex = 1
        ' 
        ' dlgInfoRecette
        ' 
        AcceptButton = OK_Button
        AutoScaleDimensions = New SizeF(144F, 144F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoSize = True
        CancelButton = Cancel_Button
        ClientSize = New Size(636, 321)
        Controls.Add(ComboBoxLivre)
        Controls.Add(LabelLivre)
        Controls.Add(LabelDesc)
        Controls.Add(LabelNote)
        Controls.Add(LabelRecette)
        Controls.Add(DescTextBox)
        Controls.Add(NoteComboBox)
        Controls.Add(NomTextBox)
        Controls.Add(Cancel_Button)
        Controls.Add(OK_Button)
        Font = New Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedDialog
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4, 5, 4, 5)
        MaximizeBox = False
        MinimizeBox = False
        Name = "dlgInfoRecette"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "Popotte - Modifier les Infos de la Recette"
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents NomTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NoteComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DescTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LabelRecette As System.Windows.Forms.Label
    Friend WithEvents LabelNote As System.Windows.Forms.Label
    Friend WithEvents LabelDesc As System.Windows.Forms.Label
    Friend WithEvents LabelLivre As System.Windows.Forms.Label
    Friend WithEvents ComboBoxLivre As System.Windows.Forms.ComboBox

End Class
