<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgAddMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgAddMenu))
        ButtonAdd = New Button()
        Cancel_Button = New Button()
        ListBoxDays = New ListBox()
        ListBoxMeal = New ListBox()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' ButtonAdd
        ' 
        ButtonAdd.Anchor = AnchorStyles.None
        ButtonAdd.Location = New Point(326, 347)
        ButtonAdd.Margin = New Padding(4, 5, 4, 5)
        ButtonAdd.Name = "ButtonAdd"
        ButtonAdd.Size = New Size(111, 37)
        ButtonAdd.TabIndex = 0
        ButtonAdd.Text = "Ajouter"
        ' 
        ' Cancel_Button
        ' 
        Cancel_Button.Anchor = AnchorStyles.None
        Cancel_Button.DialogResult = DialogResult.Cancel
        Cancel_Button.Location = New Point(445, 347)
        Cancel_Button.Margin = New Padding(4, 5, 4, 5)
        Cancel_Button.Name = "Cancel_Button"
        Cancel_Button.Size = New Size(111, 37)
        Cancel_Button.TabIndex = 1
        Cancel_Button.Text = "Annuler"
        ' 
        ' ListBoxDays
        ' 
        ListBoxDays.BackColor = SystemColors.GradientInactiveCaption
        ListBoxDays.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ListBoxDays.FormattingEnabled = True
        ListBoxDays.Location = New Point(24, 73)
        ListBoxDays.Name = "ListBoxDays"
        ListBoxDays.Size = New Size(242, 308)
        ListBoxDays.TabIndex = 1
        ' 
        ' ListBoxMeal
        ' 
        ListBoxMeal.BackColor = SystemColors.GradientInactiveCaption
        ListBoxMeal.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ListBoxMeal.FormattingEnabled = True
        ListBoxMeal.Location = New Point(326, 73)
        ListBoxMeal.Name = "ListBoxMeal"
        ListBoxMeal.Size = New Size(221, 118)
        ListBoxMeal.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(242, 32)
        Label1.TabIndex = 3
        Label1.Text = "Jour de la semaine :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(326, 24)
        Label2.Name = "Label2"
        Label2.Size = New Size(95, 32)
        Label2.TabIndex = 4
        Label2.Text = "Repas :"
        ' 
        ' dlgAddMenu
        ' 
        AcceptButton = ButtonAdd
        AutoScaleDimensions = New SizeF(10F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = Cancel_Button
        ClientSize = New Size(584, 411)
        Controls.Add(ButtonAdd)
        Controls.Add(Label2)
        Controls.Add(Cancel_Button)
        Controls.Add(Label1)
        Controls.Add(ListBoxMeal)
        Controls.Add(ListBoxDays)
        Font = New Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedDialog
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4, 5, 4, 5)
        MaximizeBox = False
        MinimizeBox = False
        Name = "dlgAddMenu"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "Ajouter la recette au Menu"
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents ButtonAdd As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents ListBoxDays As ListBox
    Friend WithEvents ListBoxMeal As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
