<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResearchCenter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ResearchCenter))
        ADD_Button = New Button()
        ListViewRC = New ListView()
        DEL_Button = New Button()
        TextBoxSite = New TextBox()
        LabelNom = New Label()
        TextBoxCom = New TextBox()
        LabelCom = New Label()
        SuspendLayout()
        ' 
        ' ADD_Button
        ' 
        ADD_Button.Anchor = AnchorStyles.None
        ADD_Button.FlatStyle = FlatStyle.System
        ADD_Button.Location = New Point(589, 402)
        ADD_Button.Margin = New Padding(4, 5, 4, 5)
        ADD_Button.Name = "ADD_Button"
        ADD_Button.Size = New Size(111, 37)
        ADD_Button.TabIndex = 2
        ADD_Button.Text = "Ajouter"
        ' 
        ' ListViewRC
        ' 
        ListViewRC.BackColor = SystemColors.InactiveBorder
        ListViewRC.Location = New Point(22, 21)
        ListViewRC.Margin = New Padding(4, 5, 4, 5)
        ListViewRC.Name = "ListViewRC"
        ListViewRC.ShowItemToolTips = True
        ListViewRC.Size = New Size(681, 349)
        ListViewRC.TabIndex = 3
        ListViewRC.UseCompatibleStateImageBehavior = False
        ' 
        ' DEL_Button
        ' 
        DEL_Button.FlatStyle = FlatStyle.System
        DEL_Button.Location = New Point(589, 444)
        DEL_Button.Margin = New Padding(4, 5, 4, 5)
        DEL_Button.Name = "DEL_Button"
        DEL_Button.Size = New Size(111, 37)
        DEL_Button.TabIndex = 4
        DEL_Button.Text = "Enlever"
        DEL_Button.UseVisualStyleBackColor = True
        ' 
        ' TextBoxSite
        ' 
        TextBoxSite.BackColor = SystemColors.GradientInactiveCaption
        TextBoxSite.Location = New Point(144, 405)
        TextBoxSite.Margin = New Padding(4, 5, 4, 5)
        TextBoxSite.Name = "TextBoxSite"
        TextBoxSite.Size = New Size(428, 25)
        TextBoxSite.TabIndex = 0
        ' 
        ' LabelNom
        ' 
        LabelNom.AutoSize = True
        LabelNom.Location = New Point(17, 410)
        LabelNom.Margin = New Padding(4, 0, 4, 0)
        LabelNom.Name = "LabelNom"
        LabelNom.Size = New Size(100, 19)
        LabelNom.TabIndex = 4
        LabelNom.Text = "Nom du Site :"
        ' 
        ' TextBoxCom
        ' 
        TextBoxCom.BackColor = SystemColors.GradientInactiveCaption
        TextBoxCom.Location = New Point(144, 447)
        TextBoxCom.Margin = New Padding(4, 5, 4, 5)
        TextBoxCom.Name = "TextBoxCom"
        TextBoxCom.Size = New Size(428, 25)
        TextBoxCom.TabIndex = 1
        ' 
        ' LabelCom
        ' 
        LabelCom.AutoSize = True
        LabelCom.Location = New Point(24, 452)
        LabelCom.Margin = New Padding(4, 0, 4, 0)
        LabelCom.Name = "LabelCom"
        LabelCom.Size = New Size(94, 19)
        LabelCom.TabIndex = 6
        LabelCom.Text = "Commande :"
        ' 
        ' ResearchCenter
        ' 
        AcceptButton = ADD_Button
        AutoScaleMode = AutoScaleMode.None
        AutoSize = True
        ClientSize = New Size(724, 509)
        Controls.Add(LabelCom)
        Controls.Add(TextBoxCom)
        Controls.Add(LabelNom)
        Controls.Add(TextBoxSite)
        Controls.Add(DEL_Button)
        Controls.Add(ADD_Button)
        Controls.Add(ListViewRC)
        Font = New Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedDialog
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4, 5, 4, 5)
        MaximizeBox = False
        MinimizeBox = False
        Name = "ResearchCenter"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "Popotte - Centre de Recherche"
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents ADD_Button As System.Windows.Forms.Button
    Friend WithEvents ListViewRC As System.Windows.Forms.ListView
    Friend WithEvents DEL_Button As System.Windows.Forms.Button
    Friend WithEvents TextBoxSite As System.Windows.Forms.TextBox
    Friend WithEvents LabelNom As System.Windows.Forms.Label
    Friend WithEvents TextBoxCom As System.Windows.Forms.TextBox
    Friend WithEvents LabelCom As System.Windows.Forms.Label

End Class
