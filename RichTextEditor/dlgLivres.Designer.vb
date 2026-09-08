<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgLivres
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

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgLivres))
        ListViewLivres = New ListView()
        LivreContextMenuStrip = New ContextMenuStrip(components)
        NewBookToolStripMenuItem = New ToolStripMenuItem()
        ChangerLeNomDuLivreToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        EffacerLeLivreToolStripMenuItem = New ToolStripMenuItem()
        RevenirButton = New Button()
        FermerButton = New Button()
        ListViewRecettes = New ListView()
        RecetteContextMenuStrip = New ContextMenuStrip(components)
        ToolStripMenuItemFAV = New ToolStripMenuItem()
        ToolStripMenuItemMenu = New ToolStripMenuItem()
        ToolStripSeparator4 = New ToolStripSeparator()
        ModifierLesInfosDeLaRecetteToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator3 = New ToolStripSeparator()
        OuvrirAvecEditeurExterneToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator2 = New ToolStripSeparator()
        EffacerLaRecetteToolStripMenuItem = New ToolStripMenuItem()
        ListViewRecherche = New ListView()
        ButtonRecherche = New Button()
        ScanRichTextBox = New RichTextBox()
        ColorDialog1 = New ColorDialog()
        ButtonFav = New Button()
        TextBoxRecherche = New TextBox()
        FavorisContextMenuStrip = New ContextMenuStrip(components)
        AddToMenuToolStripMenuItem = New ToolStripMenuItem()
        EnleverFavToolStripMenuItem = New ToolStripMenuItem()
        ButtonRandom = New Button()
        LivreContextMenuStrip.SuspendLayout()
        RecetteContextMenuStrip.SuspendLayout()
        FavorisContextMenuStrip.SuspendLayout()
        SuspendLayout()
        ' 
        ' ListViewLivres
        ' 
        ListViewLivres.ContextMenuStrip = LivreContextMenuStrip
        ListViewLivres.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ListViewLivres.LabelEdit = True
        ListViewLivres.Location = New Point(20, 81)
        ListViewLivres.Margin = New Padding(4)
        ListViewLivres.Name = "ListViewLivres"
        ListViewLivres.Size = New Size(1010, 608)
        ListViewLivres.TabIndex = 0
        ListViewLivres.UseCompatibleStateImageBehavior = False
        ListViewLivres.View = View.Details
        ' 
        ' LivreContextMenuStrip
        ' 
        LivreContextMenuStrip.ImageScalingSize = New Size(24, 24)
        LivreContextMenuStrip.Items.AddRange(New ToolStripItem() {NewBookToolStripMenuItem, ChangerLeNomDuLivreToolStripMenuItem, ToolStripSeparator1, EffacerLeLivreToolStripMenuItem})
        LivreContextMenuStrip.Name = "LivreContextMenuStrip"
        LivreContextMenuStrip.Size = New Size(289, 106)
        ' 
        ' NewBookToolStripMenuItem
        ' 
        NewBookToolStripMenuItem.Image = CType(resources.GetObject("NewBookToolStripMenuItem.Image"), Image)
        NewBookToolStripMenuItem.Name = "NewBookToolStripMenuItem"
        NewBookToolStripMenuItem.Size = New Size(288, 32)
        NewBookToolStripMenuItem.Text = "Nouveau Livre"
        ' 
        ' ChangerLeNomDuLivreToolStripMenuItem
        ' 
        ChangerLeNomDuLivreToolStripMenuItem.Name = "ChangerLeNomDuLivreToolStripMenuItem"
        ChangerLeNomDuLivreToolStripMenuItem.Size = New Size(288, 32)
        ChangerLeNomDuLivreToolStripMenuItem.Text = "Changer le Nom du Livre"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(285, 6)
        ' 
        ' EffacerLeLivreToolStripMenuItem
        ' 
        EffacerLeLivreToolStripMenuItem.Image = CType(resources.GetObject("EffacerLeLivreToolStripMenuItem.Image"), Image)
        EffacerLeLivreToolStripMenuItem.Name = "EffacerLeLivreToolStripMenuItem"
        EffacerLeLivreToolStripMenuItem.Size = New Size(288, 32)
        EffacerLeLivreToolStripMenuItem.Text = "Effacer le Livre"
        ' 
        ' RevenirButton
        ' 
        RevenirButton.FlatStyle = FlatStyle.System
        RevenirButton.Location = New Point(20, 780)
        RevenirButton.Margin = New Padding(4)
        RevenirButton.Name = "RevenirButton"
        RevenirButton.Size = New Size(124, 38)
        RevenirButton.TabIndex = 0
        RevenirButton.Text = "&Revenir"
        RevenirButton.UseVisualStyleBackColor = True
        ' 
        ' FermerButton
        ' 
        FermerButton.DialogResult = DialogResult.Cancel
        FermerButton.FlatStyle = FlatStyle.System
        FermerButton.Location = New Point(908, 780)
        FermerButton.Margin = New Padding(4)
        FermerButton.Name = "FermerButton"
        FermerButton.Size = New Size(124, 38)
        FermerButton.TabIndex = 1
        FermerButton.Text = "&Fermer"
        FermerButton.UseVisualStyleBackColor = True
        ' 
        ' ListViewRecettes
        ' 
        ListViewRecettes.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ListViewRecettes.FullRowSelect = True
        ListViewRecettes.GridLines = True
        ListViewRecettes.LabelEdit = True
        ListViewRecettes.Location = New Point(20, 81)
        ListViewRecettes.Margin = New Padding(4)
        ListViewRecettes.Name = "ListViewRecettes"
        ListViewRecettes.ShowItemToolTips = True
        ListViewRecettes.Size = New Size(1008, 608)
        ListViewRecettes.TabIndex = 3
        ListViewRecettes.UseCompatibleStateImageBehavior = False
        ListViewRecettes.Visible = False
        ' 
        ' RecetteContextMenuStrip
        ' 
        RecetteContextMenuStrip.AccessibleRole = AccessibleRole.TitleBar
        RecetteContextMenuStrip.ImageScalingSize = New Size(24, 24)
        RecetteContextMenuStrip.Items.AddRange(New ToolStripItem() {ToolStripMenuItemFAV, ToolStripMenuItemMenu, ToolStripSeparator4, ModifierLesInfosDeLaRecetteToolStripMenuItem, ToolStripSeparator3, OuvrirAvecEditeurExterneToolStripMenuItem, ToolStripSeparator2, EffacerLaRecetteToolStripMenuItem})
        RecetteContextMenuStrip.Name = "RecetteContextMenuStrip"
        RecetteContextMenuStrip.Size = New Size(331, 182)
        ' 
        ' ToolStripMenuItemFAV
        ' 
        ToolStripMenuItemFAV.Image = CType(resources.GetObject("ToolStripMenuItemFAV.Image"), Image)
        ToolStripMenuItemFAV.Name = "ToolStripMenuItemFAV"
        ToolStripMenuItemFAV.Size = New Size(330, 32)
        ToolStripMenuItemFAV.Text = "Ajouter aux Favoris"
        ' 
        ' ToolStripMenuItemMenu
        ' 
        ToolStripMenuItemMenu.Name = "ToolStripMenuItemMenu"
        ToolStripMenuItemMenu.Size = New Size(330, 32)
        ToolStripMenuItemMenu.Text = "Ajouter au Menu"
        ' 
        ' ToolStripSeparator4
        ' 
        ToolStripSeparator4.Name = "ToolStripSeparator4"
        ToolStripSeparator4.Size = New Size(327, 6)
        ' 
        ' ModifierLesInfosDeLaRecetteToolStripMenuItem
        ' 
        ModifierLesInfosDeLaRecetteToolStripMenuItem.Name = "ModifierLesInfosDeLaRecetteToolStripMenuItem"
        ModifierLesInfosDeLaRecetteToolStripMenuItem.Size = New Size(330, 32)
        ModifierLesInfosDeLaRecetteToolStripMenuItem.Text = "Modifier les infos de la recette"
        ' 
        ' ToolStripSeparator3
        ' 
        ToolStripSeparator3.Name = "ToolStripSeparator3"
        ToolStripSeparator3.Size = New Size(327, 6)
        ' 
        ' OuvrirAvecEditeurExterneToolStripMenuItem
        ' 
        OuvrirAvecEditeurExterneToolStripMenuItem.Enabled = False
        OuvrirAvecEditeurExterneToolStripMenuItem.Name = "OuvrirAvecEditeurExterneToolStripMenuItem"
        OuvrirAvecEditeurExterneToolStripMenuItem.Size = New Size(330, 32)
        OuvrirAvecEditeurExterneToolStripMenuItem.Text = "Ouvrir avec l'éditeur externe"
        ' 
        ' ToolStripSeparator2
        ' 
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New Size(327, 6)
        ' 
        ' EffacerLaRecetteToolStripMenuItem
        ' 
        EffacerLaRecetteToolStripMenuItem.Image = CType(resources.GetObject("EffacerLaRecetteToolStripMenuItem.Image"), Image)
        EffacerLaRecetteToolStripMenuItem.Name = "EffacerLaRecetteToolStripMenuItem"
        EffacerLaRecetteToolStripMenuItem.Size = New Size(330, 32)
        EffacerLaRecetteToolStripMenuItem.Text = "Effacer la recette"
        ' 
        ' ListViewRecherche
        ' 
        ListViewRecherche.BackColor = SystemColors.ControlLightLight
        ListViewRecherche.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ListViewRecherche.Location = New Point(20, 81)
        ListViewRecherche.Margin = New Padding(4)
        ListViewRecherche.Name = "ListViewRecherche"
        ListViewRecherche.Size = New Size(1008, 608)
        ListViewRecherche.TabIndex = 4
        ListViewRecherche.UseCompatibleStateImageBehavior = False
        ' 
        ' ButtonRecherche
        ' 
        ButtonRecherche.FlatStyle = FlatStyle.System
        ButtonRecherche.Location = New Point(459, 780)
        ButtonRecherche.Margin = New Padding(4)
        ButtonRecherche.Name = "ButtonRecherche"
        ButtonRecherche.Size = New Size(124, 38)
        ButtonRecherche.TabIndex = 5
        ButtonRecherche.Text = "Re&chercher"
        ButtonRecherche.UseVisualStyleBackColor = True
        ' 
        ' ScanRichTextBox
        ' 
        ScanRichTextBox.DetectUrls = False
        ScanRichTextBox.Location = New Point(0, 0)
        ScanRichTextBox.Margin = New Padding(4)
        ScanRichTextBox.Name = "ScanRichTextBox"
        ScanRichTextBox.Size = New Size(1, 1)
        ScanRichTextBox.TabIndex = 6
        ScanRichTextBox.Text = ""
        ScanRichTextBox.Visible = False
        ' 
        ' ButtonFav
        ' 
        ButtonFav.BackColor = SystemColors.ButtonFace
        ButtonFav.BackgroundImage = CType(resources.GetObject("ButtonFav.BackgroundImage"), Image)
        ButtonFav.BackgroundImageLayout = ImageLayout.Stretch
        ButtonFav.Location = New Point(20, 6)
        ButtonFav.Margin = New Padding(4)
        ButtonFav.Name = "ButtonFav"
        ButtonFav.Size = New Size(69, 68)
        ButtonFav.TabIndex = 7
        ButtonFav.UseVisualStyleBackColor = False
        ' 
        ' TextBoxRecherche
        ' 
        TextBoxRecherche.AcceptsTab = True
        TextBoxRecherche.AccessibleDescription = ""
        TextBoxRecherche.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        TextBoxRecherche.BackColor = SystemColors.GradientInactiveCaption
        TextBoxRecherche.Location = New Point(364, 716)
        TextBoxRecherche.Margin = New Padding(4)
        TextBoxRecherche.Name = "TextBoxRecherche"
        TextBoxRecherche.Size = New Size(314, 29)
        TextBoxRecherche.TabIndex = 4
        ' 
        ' FavorisContextMenuStrip
        ' 
        FavorisContextMenuStrip.AccessibleRole = AccessibleRole.TitleBar
        FavorisContextMenuStrip.ImageScalingSize = New Size(24, 24)
        FavorisContextMenuStrip.Items.AddRange(New ToolStripItem() {AddToMenuToolStripMenuItem, EnleverFavToolStripMenuItem})
        FavorisContextMenuStrip.Name = "RecetteContextMenuStrip"
        FavorisContextMenuStrip.Size = New Size(240, 68)
        ' 
        ' AddToMenuToolStripMenuItem
        ' 
        AddToMenuToolStripMenuItem.Name = "AddToMenuToolStripMenuItem"
        AddToMenuToolStripMenuItem.Size = New Size(239, 32)
        AddToMenuToolStripMenuItem.Text = "Add to menu"
        ' 
        ' EnleverFavToolStripMenuItem
        ' 
        EnleverFavToolStripMenuItem.Image = CType(resources.GetObject("EnleverFavToolStripMenuItem.Image"), Image)
        EnleverFavToolStripMenuItem.Name = "EnleverFavToolStripMenuItem"
        EnleverFavToolStripMenuItem.Size = New Size(239, 32)
        EnleverFavToolStripMenuItem.Text = "Enlever des favoris"
        ' 
        ' ButtonRandom
        ' 
        ButtonRandom.BackgroundImage = CType(resources.GetObject("ButtonRandom.BackgroundImage"), Image)
        ButtonRandom.BackgroundImageLayout = ImageLayout.Stretch
        ButtonRandom.Location = New Point(93, 6)
        ButtonRandom.Name = "ButtonRandom"
        ButtonRandom.Size = New Size(69, 68)
        ButtonRandom.TabIndex = 8
        ButtonRandom.UseVisualStyleBackColor = True
        ' 
        ' dlgLivres
        ' 
        AutoScaleMode = AutoScaleMode.None
        AutoSize = True
        CancelButton = FermerButton
        ClientSize = New Size(1053, 836)
        Controls.Add(ButtonRandom)
        Controls.Add(TextBoxRecherche)
        Controls.Add(ButtonFav)
        Controls.Add(ScanRichTextBox)
        Controls.Add(ButtonRecherche)
        Controls.Add(ListViewRecherche)
        Controls.Add(ListViewRecettes)
        Controls.Add(ListViewLivres)
        Controls.Add(FermerButton)
        Controls.Add(RevenirButton)
        Font = New Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedDialog
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4)
        MaximizeBox = False
        MinimizeBox = False
        Name = "dlgLivres"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        LivreContextMenuStrip.ResumeLayout(False)
        RecetteContextMenuStrip.ResumeLayout(False)
        FavorisContextMenuStrip.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents ListViewLivres As System.Windows.Forms.ListView
    Friend WithEvents RevenirButton As System.Windows.Forms.Button
    Friend WithEvents FermerButton As System.Windows.Forms.Button
    Friend WithEvents ListViewRecettes As System.Windows.Forms.ListView
    Friend WithEvents LivreContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EffacerLeLivreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RecetteContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ModifierLesInfosDeLaRecetteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EffacerLaRecetteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListViewRecherche As System.Windows.Forms.ListView
    Friend WithEvents ButtonRecherche As System.Windows.Forms.Button
    Friend WithEvents ScanRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents NewBookToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents OuvrirAvecEditeurExterneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangerLeNomDuLivreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents ButtonFav As Button
    Friend WithEvents TextBoxRecherche As TextBox
    Friend WithEvents ToolStripMenuItemFAV As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents FavorisContextMenuStrip As ContextMenuStrip
    Friend WithEvents EnleverFavToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ButtonRandom As Button
    Friend WithEvents ToolStripMenuItemMenu As ToolStripMenuItem
    Friend WithEvents AddToMenuToolStripMenuItem As ToolStripMenuItem
End Class
