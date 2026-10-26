<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        ButtonPreviousWeek = New Button()
        ButtonNextWeek = New Button()
        ButtonSave = New Button()
        LabelCurrentWeek = New Label()
        LabelMonday = New Label()
        LabelTuesday = New Label()
        LabelWednesday = New Label()
        LabelSunday = New Label()
        LabelThursday = New Label()
        LabelFriday = New Label()
        LabelSaturday = New Label()
        ListBoxSunday = New ListBox()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        ModifierToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        CopierLeTexteToolStripMenuItem = New ToolStripMenuItem()
        CollerLeTexteToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator2 = New ToolStripSeparator()
        EffacerToolStripMenuItem = New ToolStripMenuItem()
        ListBoxMonday = New ListBox()
        ContextMenuStrip2 = New ContextMenuStrip(components)
        Modifier2ToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator4 = New ToolStripSeparator()
        CopierLeTexteToolStripMenuItem1 = New ToolStripMenuItem()
        CollerLeTexteToolStripMenuItem1 = New ToolStripMenuItem()
        ToolStripSeparator3 = New ToolStripSeparator()
        Effacer2ToolStripMenuItem = New ToolStripMenuItem()
        ListBoxTuesday = New ListBox()
        ContextMenuStrip3 = New ContextMenuStrip(components)
        Modifier3ToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator5 = New ToolStripSeparator()
        CopierLeTexteToolStripMenuItem2 = New ToolStripMenuItem()
        CollerLeTexteToolStripMenuItem2 = New ToolStripMenuItem()
        ToolStripSeparator6 = New ToolStripSeparator()
        Effacer3ToolStripMenuItem = New ToolStripMenuItem()
        ListBoxWednesday = New ListBox()
        ContextMenuStrip4 = New ContextMenuStrip(components)
        Modifier4ToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator7 = New ToolStripSeparator()
        CopierLeTexteToolStripMenuItem3 = New ToolStripMenuItem()
        CollerLeTexteToolStripMenuItem3 = New ToolStripMenuItem()
        ToolStripSeparator8 = New ToolStripSeparator()
        Effacer4ToolStripMenuItem = New ToolStripMenuItem()
        ListBoxThursday = New ListBox()
        ContextMenuStrip5 = New ContextMenuStrip(components)
        Modifier5ToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator10 = New ToolStripSeparator()
        CopierLetexteToolStripMenuItem6 = New ToolStripMenuItem()
        CollerLeTexteToolStripMenuItem4 = New ToolStripMenuItem()
        ToolStripSeparator9 = New ToolStripSeparator()
        Effacer5ToolStripMenuItem = New ToolStripMenuItem()
        ListBoxFriday = New ListBox()
        ContextMenuStrip6 = New ContextMenuStrip(components)
        Modifier6ToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator11 = New ToolStripSeparator()
        CopierLeTexteToolStripMenuItem4 = New ToolStripMenuItem()
        CollerLeTexteToolStripMenuItem5 = New ToolStripMenuItem()
        ToolStripSeparator12 = New ToolStripSeparator()
        Effacer6ToolStripMenuItem = New ToolStripMenuItem()
        ListBoxSaturday = New ListBox()
        ContextMenuStrip7 = New ContextMenuStrip(components)
        Modifier7ToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator14 = New ToolStripSeparator()
        CopierLeTexteToolStripMenuItem5 = New ToolStripMenuItem()
        CollerLeTexteToolStripMenuItem6 = New ToolStripMenuItem()
        ToolStripSeparator13 = New ToolStripSeparator()
        Effacer7ToolStripMenuItem = New ToolStripMenuItem()
        ButtonPreview = New Button()
        Button1Touteff = New Button()
        ContextMenuStrip1.SuspendLayout()
        ContextMenuStrip2.SuspendLayout()
        ContextMenuStrip3.SuspendLayout()
        ContextMenuStrip4.SuspendLayout()
        ContextMenuStrip5.SuspendLayout()
        ContextMenuStrip6.SuspendLayout()
        ContextMenuStrip7.SuspendLayout()
        SuspendLayout()
        ' 
        ' ButtonPreviousWeek
        ' 
        ButtonPreviousWeek.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonPreviousWeek.Location = New Point(297, 16)
        ButtonPreviousWeek.Name = "ButtonPreviousWeek"
        ButtonPreviousWeek.Size = New Size(150, 30)
        ButtonPreviousWeek.TabIndex = 24
        ButtonPreviousWeek.Text = "Précédente"
        ButtonPreviousWeek.UseVisualStyleBackColor = True
        ' 
        ' ButtonNextWeek
        ' 
        ButtonNextWeek.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonNextWeek.Location = New Point(842, 16)
        ButtonNextWeek.Name = "ButtonNextWeek"
        ButtonNextWeek.Size = New Size(150, 30)
        ButtonNextWeek.TabIndex = 25
        ButtonNextWeek.Text = "Suivante"
        ButtonNextWeek.UseVisualStyleBackColor = True
        ' 
        ' ButtonSave
        ' 
        ButtonSave.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonSave.Location = New Point(806, 839)
        ButtonSave.Name = "ButtonSave"
        ButtonSave.Size = New Size(186, 47)
        ButtonSave.TabIndex = 26
        ButtonSave.Text = "Sauvegarder"
        ButtonSave.UseVisualStyleBackColor = True
        ' 
        ' LabelCurrentWeek
        ' 
        LabelCurrentWeek.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelCurrentWeek.Location = New Point(462, 16)
        LabelCurrentWeek.Name = "LabelCurrentWeek"
        LabelCurrentWeek.Size = New Size(370, 30)
        LabelCurrentWeek.TabIndex = 27
        LabelCurrentWeek.Text = "Semaine"
        LabelCurrentWeek.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LabelMonday
        ' 
        LabelMonday.AutoSize = True
        LabelMonday.Font = New Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelMonday.Location = New Point(33, 156)
        LabelMonday.Name = "LabelMonday"
        LabelMonday.Size = New Size(178, 54)
        LabelMonday.TabIndex = 8
        LabelMonday.Text = "Monday"
        ' 
        ' LabelTuesday
        ' 
        LabelTuesday.AutoSize = True
        LabelTuesday.Font = New Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelTuesday.Location = New Point(33, 265)
        LabelTuesday.Name = "LabelTuesday"
        LabelTuesday.Size = New Size(176, 54)
        LabelTuesday.TabIndex = 9
        LabelTuesday.Text = "Tuesday"
        ' 
        ' LabelWednesday
        ' 
        LabelWednesday.AutoSize = True
        LabelWednesday.Font = New Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelWednesday.Location = New Point(33, 374)
        LabelWednesday.Name = "LabelWednesday"
        LabelWednesday.Size = New Size(242, 54)
        LabelWednesday.TabIndex = 10
        LabelWednesday.Text = "Wednesday"
        ' 
        ' LabelSunday
        ' 
        LabelSunday.AutoSize = True
        LabelSunday.Font = New Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelSunday.Location = New Point(33, 48)
        LabelSunday.Name = "LabelSunday"
        LabelSunday.Size = New Size(162, 54)
        LabelSunday.TabIndex = 11
        LabelSunday.Text = "Sunday"
        ' 
        ' LabelThursday
        ' 
        LabelThursday.AutoSize = True
        LabelThursday.Font = New Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelThursday.Location = New Point(33, 483)
        LabelThursday.Name = "LabelThursday"
        LabelThursday.Size = New Size(197, 54)
        LabelThursday.TabIndex = 12
        LabelThursday.Text = "Thursday"
        ' 
        ' LabelFriday
        ' 
        LabelFriday.AutoSize = True
        LabelFriday.Font = New Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelFriday.Location = New Point(33, 594)
        LabelFriday.Name = "LabelFriday"
        LabelFriday.Size = New Size(140, 54)
        LabelFriday.TabIndex = 13
        LabelFriday.Text = "Friday"
        ' 
        ' LabelSaturday
        ' 
        LabelSaturday.AutoSize = True
        LabelSaturday.Font = New Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelSaturday.Location = New Point(38, 706)
        LabelSaturday.Name = "LabelSaturday"
        LabelSaturday.Size = New Size(192, 54)
        LabelSaturday.TabIndex = 14
        LabelSaturday.Text = "Saturday"
        ' 
        ' ListBoxSunday
        ' 
        ListBoxSunday.BackColor = SystemColors.GradientInactiveCaption
        ListBoxSunday.ContextMenuStrip = ContextMenuStrip1
        ListBoxSunday.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ListBoxSunday.FormattingEnabled = True
        ListBoxSunday.Location = New Point(297, 48)
        ListBoxSunday.Name = "ListBoxSunday"
        ListBoxSunday.Size = New Size(695, 88)
        ListBoxSunday.TabIndex = 15
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ContextMenuStrip1.ImageScalingSize = New Size(24, 24)
        ContextMenuStrip1.Items.AddRange(New ToolStripItem() {ModifierToolStripMenuItem, ToolStripSeparator1, CopierLeTexteToolStripMenuItem, CollerLeTexteToolStripMenuItem, ToolStripSeparator2, EffacerToolStripMenuItem})
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(232, 152)
        ' 
        ' ModifierToolStripMenuItem
        ' 
        ModifierToolStripMenuItem.Name = "ModifierToolStripMenuItem"
        ModifierToolStripMenuItem.Size = New Size(231, 34)
        ModifierToolStripMenuItem.Text = "Modifier"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(228, 6)
        ' 
        ' CopierLeTexteToolStripMenuItem
        ' 
        CopierLeTexteToolStripMenuItem.Name = "CopierLeTexteToolStripMenuItem"
        CopierLeTexteToolStripMenuItem.Size = New Size(231, 34)
        CopierLeTexteToolStripMenuItem.Text = "Copier le texte"
        ' 
        ' CollerLeTexteToolStripMenuItem
        ' 
        CollerLeTexteToolStripMenuItem.Name = "CollerLeTexteToolStripMenuItem"
        CollerLeTexteToolStripMenuItem.Size = New Size(231, 34)
        CollerLeTexteToolStripMenuItem.Text = "Coller le texte"
        ' 
        ' ToolStripSeparator2
        ' 
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New Size(228, 6)
        ' 
        ' EffacerToolStripMenuItem
        ' 
        EffacerToolStripMenuItem.Image = CType(resources.GetObject("EffacerToolStripMenuItem.Image"), Image)
        EffacerToolStripMenuItem.Name = "EffacerToolStripMenuItem"
        EffacerToolStripMenuItem.Size = New Size(231, 34)
        EffacerToolStripMenuItem.Text = "Effacer"
        ' 
        ' ListBoxMonday
        ' 
        ListBoxMonday.BackColor = SystemColors.GradientInactiveCaption
        ListBoxMonday.ContextMenuStrip = ContextMenuStrip2
        ListBoxMonday.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ListBoxMonday.FormattingEnabled = True
        ListBoxMonday.Location = New Point(297, 156)
        ListBoxMonday.Name = "ListBoxMonday"
        ListBoxMonday.Size = New Size(695, 88)
        ListBoxMonday.TabIndex = 16
        ' 
        ' ContextMenuStrip2
        ' 
        ContextMenuStrip2.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ContextMenuStrip2.ImageScalingSize = New Size(24, 24)
        ContextMenuStrip2.Items.AddRange(New ToolStripItem() {Modifier2ToolStripMenuItem, ToolStripSeparator4, CopierLeTexteToolStripMenuItem1, CollerLeTexteToolStripMenuItem1, ToolStripSeparator3, Effacer2ToolStripMenuItem})
        ContextMenuStrip2.Name = "ContextMenuStrip2"
        ContextMenuStrip2.Size = New Size(232, 152)
        ' 
        ' Modifier2ToolStripMenuItem
        ' 
        Modifier2ToolStripMenuItem.Name = "Modifier2ToolStripMenuItem"
        Modifier2ToolStripMenuItem.Size = New Size(231, 34)
        Modifier2ToolStripMenuItem.Text = "Modifier"
        ' 
        ' ToolStripSeparator4
        ' 
        ToolStripSeparator4.Name = "ToolStripSeparator4"
        ToolStripSeparator4.Size = New Size(228, 6)
        ' 
        ' CopierLeTexteToolStripMenuItem1
        ' 
        CopierLeTexteToolStripMenuItem1.Name = "CopierLeTexteToolStripMenuItem1"
        CopierLeTexteToolStripMenuItem1.Size = New Size(231, 34)
        CopierLeTexteToolStripMenuItem1.Text = "Copier le texte"
        ' 
        ' CollerLeTexteToolStripMenuItem1
        ' 
        CollerLeTexteToolStripMenuItem1.Name = "CollerLeTexteToolStripMenuItem1"
        CollerLeTexteToolStripMenuItem1.Size = New Size(231, 34)
        CollerLeTexteToolStripMenuItem1.Text = "Coller le texte"
        ' 
        ' ToolStripSeparator3
        ' 
        ToolStripSeparator3.Name = "ToolStripSeparator3"
        ToolStripSeparator3.Size = New Size(228, 6)
        ' 
        ' Effacer2ToolStripMenuItem
        ' 
        Effacer2ToolStripMenuItem.Image = CType(resources.GetObject("Effacer2ToolStripMenuItem.Image"), Image)
        Effacer2ToolStripMenuItem.Name = "Effacer2ToolStripMenuItem"
        Effacer2ToolStripMenuItem.Size = New Size(231, 34)
        Effacer2ToolStripMenuItem.Text = "Effacer"
        ' 
        ' ListBoxTuesday
        ' 
        ListBoxTuesday.BackColor = SystemColors.GradientInactiveCaption
        ListBoxTuesday.ContextMenuStrip = ContextMenuStrip3
        ListBoxTuesday.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ListBoxTuesday.FormattingEnabled = True
        ListBoxTuesday.Location = New Point(297, 265)
        ListBoxTuesday.Name = "ListBoxTuesday"
        ListBoxTuesday.Size = New Size(695, 88)
        ListBoxTuesday.TabIndex = 17
        ' 
        ' ContextMenuStrip3
        ' 
        ContextMenuStrip3.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ContextMenuStrip3.ImageScalingSize = New Size(24, 24)
        ContextMenuStrip3.Items.AddRange(New ToolStripItem() {Modifier3ToolStripMenuItem, ToolStripSeparator5, CopierLeTexteToolStripMenuItem2, CollerLeTexteToolStripMenuItem2, ToolStripSeparator6, Effacer3ToolStripMenuItem})
        ContextMenuStrip3.Name = "ContextMenuStrip3"
        ContextMenuStrip3.Size = New Size(232, 152)
        ' 
        ' Modifier3ToolStripMenuItem
        ' 
        Modifier3ToolStripMenuItem.Name = "Modifier3ToolStripMenuItem"
        Modifier3ToolStripMenuItem.Size = New Size(231, 34)
        Modifier3ToolStripMenuItem.Text = "Modifier"
        ' 
        ' ToolStripSeparator5
        ' 
        ToolStripSeparator5.Name = "ToolStripSeparator5"
        ToolStripSeparator5.Size = New Size(228, 6)
        ' 
        ' CopierLeTexteToolStripMenuItem2
        ' 
        CopierLeTexteToolStripMenuItem2.Name = "CopierLeTexteToolStripMenuItem2"
        CopierLeTexteToolStripMenuItem2.Size = New Size(231, 34)
        CopierLeTexteToolStripMenuItem2.Text = "Copier le texte"
        ' 
        ' CollerLeTexteToolStripMenuItem2
        ' 
        CollerLeTexteToolStripMenuItem2.Name = "CollerLeTexteToolStripMenuItem2"
        CollerLeTexteToolStripMenuItem2.Size = New Size(231, 34)
        CollerLeTexteToolStripMenuItem2.Text = "Coller le texte"
        ' 
        ' ToolStripSeparator6
        ' 
        ToolStripSeparator6.Name = "ToolStripSeparator6"
        ToolStripSeparator6.Size = New Size(228, 6)
        ' 
        ' Effacer3ToolStripMenuItem
        ' 
        Effacer3ToolStripMenuItem.Image = CType(resources.GetObject("Effacer3ToolStripMenuItem.Image"), Image)
        Effacer3ToolStripMenuItem.Name = "Effacer3ToolStripMenuItem"
        Effacer3ToolStripMenuItem.Size = New Size(231, 34)
        Effacer3ToolStripMenuItem.Text = "Effacer"
        ' 
        ' ListBoxWednesday
        ' 
        ListBoxWednesday.BackColor = SystemColors.GradientInactiveCaption
        ListBoxWednesday.ContextMenuStrip = ContextMenuStrip4
        ListBoxWednesday.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ListBoxWednesday.FormattingEnabled = True
        ListBoxWednesday.Location = New Point(297, 374)
        ListBoxWednesday.Name = "ListBoxWednesday"
        ListBoxWednesday.Size = New Size(695, 88)
        ListBoxWednesday.TabIndex = 18
        ' 
        ' ContextMenuStrip4
        ' 
        ContextMenuStrip4.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ContextMenuStrip4.ImageScalingSize = New Size(24, 24)
        ContextMenuStrip4.Items.AddRange(New ToolStripItem() {Modifier4ToolStripMenuItem, ToolStripSeparator7, CopierLeTexteToolStripMenuItem3, CollerLeTexteToolStripMenuItem3, ToolStripSeparator8, Effacer4ToolStripMenuItem})
        ContextMenuStrip4.Name = "ContextMenuStrip4"
        ContextMenuStrip4.Size = New Size(232, 152)
        ' 
        ' Modifier4ToolStripMenuItem
        ' 
        Modifier4ToolStripMenuItem.Name = "Modifier4ToolStripMenuItem"
        Modifier4ToolStripMenuItem.Size = New Size(231, 34)
        Modifier4ToolStripMenuItem.Text = "Modifier"
        ' 
        ' ToolStripSeparator7
        ' 
        ToolStripSeparator7.Name = "ToolStripSeparator7"
        ToolStripSeparator7.Size = New Size(228, 6)
        ' 
        ' CopierLeTexteToolStripMenuItem3
        ' 
        CopierLeTexteToolStripMenuItem3.Name = "CopierLeTexteToolStripMenuItem3"
        CopierLeTexteToolStripMenuItem3.Size = New Size(231, 34)
        CopierLeTexteToolStripMenuItem3.Text = "Copier le texte"
        ' 
        ' CollerLeTexteToolStripMenuItem3
        ' 
        CollerLeTexteToolStripMenuItem3.Name = "CollerLeTexteToolStripMenuItem3"
        CollerLeTexteToolStripMenuItem3.Size = New Size(231, 34)
        CollerLeTexteToolStripMenuItem3.Text = "Coller le texte"
        ' 
        ' ToolStripSeparator8
        ' 
        ToolStripSeparator8.Name = "ToolStripSeparator8"
        ToolStripSeparator8.Size = New Size(228, 6)
        ' 
        ' Effacer4ToolStripMenuItem
        ' 
        Effacer4ToolStripMenuItem.Image = CType(resources.GetObject("Effacer4ToolStripMenuItem.Image"), Image)
        Effacer4ToolStripMenuItem.Name = "Effacer4ToolStripMenuItem"
        Effacer4ToolStripMenuItem.Size = New Size(231, 34)
        Effacer4ToolStripMenuItem.Text = "Effacer"
        ' 
        ' ListBoxThursday
        ' 
        ListBoxThursday.BackColor = SystemColors.GradientInactiveCaption
        ListBoxThursday.ContextMenuStrip = ContextMenuStrip5
        ListBoxThursday.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ListBoxThursday.FormattingEnabled = True
        ListBoxThursday.Location = New Point(297, 483)
        ListBoxThursday.Name = "ListBoxThursday"
        ListBoxThursday.Size = New Size(695, 88)
        ListBoxThursday.TabIndex = 19
        ' 
        ' ContextMenuStrip5
        ' 
        ContextMenuStrip5.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ContextMenuStrip5.ImageScalingSize = New Size(24, 24)
        ContextMenuStrip5.Items.AddRange(New ToolStripItem() {Modifier5ToolStripMenuItem, ToolStripSeparator10, CopierLetexteToolStripMenuItem6, CollerLeTexteToolStripMenuItem4, ToolStripSeparator9, Effacer5ToolStripMenuItem})
        ContextMenuStrip5.Name = "ContextMenuStrip5"
        ContextMenuStrip5.Size = New Size(232, 152)
        ' 
        ' Modifier5ToolStripMenuItem
        ' 
        Modifier5ToolStripMenuItem.Name = "Modifier5ToolStripMenuItem"
        Modifier5ToolStripMenuItem.Size = New Size(231, 34)
        Modifier5ToolStripMenuItem.Text = "Modifier"
        ' 
        ' ToolStripSeparator10
        ' 
        ToolStripSeparator10.Name = "ToolStripSeparator10"
        ToolStripSeparator10.Size = New Size(228, 6)
        ' 
        ' CopierLetexteToolStripMenuItem6
        ' 
        CopierLetexteToolStripMenuItem6.Name = "CopierLetexteToolStripMenuItem6"
        CopierLetexteToolStripMenuItem6.Size = New Size(231, 34)
        CopierLetexteToolStripMenuItem6.Text = "Copier le texte"
        ' 
        ' CollerLeTexteToolStripMenuItem4
        ' 
        CollerLeTexteToolStripMenuItem4.Name = "CollerLeTexteToolStripMenuItem4"
        CollerLeTexteToolStripMenuItem4.Size = New Size(231, 34)
        CollerLeTexteToolStripMenuItem4.Text = "Coller le texte"
        ' 
        ' ToolStripSeparator9
        ' 
        ToolStripSeparator9.Name = "ToolStripSeparator9"
        ToolStripSeparator9.Size = New Size(228, 6)
        ' 
        ' Effacer5ToolStripMenuItem
        ' 
        Effacer5ToolStripMenuItem.Image = CType(resources.GetObject("Effacer5ToolStripMenuItem.Image"), Image)
        Effacer5ToolStripMenuItem.Name = "Effacer5ToolStripMenuItem"
        Effacer5ToolStripMenuItem.Size = New Size(231, 34)
        Effacer5ToolStripMenuItem.Text = "Effacer"
        ' 
        ' ListBoxFriday
        ' 
        ListBoxFriday.BackColor = SystemColors.GradientInactiveCaption
        ListBoxFriday.ContextMenuStrip = ContextMenuStrip6
        ListBoxFriday.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ListBoxFriday.FormattingEnabled = True
        ListBoxFriday.Location = New Point(297, 594)
        ListBoxFriday.Name = "ListBoxFriday"
        ListBoxFriday.Size = New Size(695, 88)
        ListBoxFriday.TabIndex = 20
        ' 
        ' ContextMenuStrip6
        ' 
        ContextMenuStrip6.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ContextMenuStrip6.ImageScalingSize = New Size(24, 24)
        ContextMenuStrip6.Items.AddRange(New ToolStripItem() {Modifier6ToolStripMenuItem, ToolStripSeparator11, CopierLeTexteToolStripMenuItem4, CollerLeTexteToolStripMenuItem5, ToolStripSeparator12, Effacer6ToolStripMenuItem})
        ContextMenuStrip6.Name = "ContextMenuStrip6"
        ContextMenuStrip6.Size = New Size(232, 152)
        ' 
        ' Modifier6ToolStripMenuItem
        ' 
        Modifier6ToolStripMenuItem.Name = "Modifier6ToolStripMenuItem"
        Modifier6ToolStripMenuItem.Size = New Size(231, 34)
        Modifier6ToolStripMenuItem.Text = "Modifier"
        ' 
        ' ToolStripSeparator11
        ' 
        ToolStripSeparator11.Name = "ToolStripSeparator11"
        ToolStripSeparator11.Size = New Size(228, 6)
        ' 
        ' CopierLeTexteToolStripMenuItem4
        ' 
        CopierLeTexteToolStripMenuItem4.Name = "CopierLeTexteToolStripMenuItem4"
        CopierLeTexteToolStripMenuItem4.Size = New Size(231, 34)
        CopierLeTexteToolStripMenuItem4.Text = "Copier le texte"
        ' 
        ' CollerLeTexteToolStripMenuItem5
        ' 
        CollerLeTexteToolStripMenuItem5.Name = "CollerLeTexteToolStripMenuItem5"
        CollerLeTexteToolStripMenuItem5.Size = New Size(231, 34)
        CollerLeTexteToolStripMenuItem5.Text = "Coller le texte"
        ' 
        ' ToolStripSeparator12
        ' 
        ToolStripSeparator12.Name = "ToolStripSeparator12"
        ToolStripSeparator12.Size = New Size(228, 6)
        ' 
        ' Effacer6ToolStripMenuItem
        ' 
        Effacer6ToolStripMenuItem.Image = CType(resources.GetObject("Effacer6ToolStripMenuItem.Image"), Image)
        Effacer6ToolStripMenuItem.Name = "Effacer6ToolStripMenuItem"
        Effacer6ToolStripMenuItem.Size = New Size(231, 34)
        Effacer6ToolStripMenuItem.Text = "Effacer"
        ' 
        ' ListBoxSaturday
        ' 
        ListBoxSaturday.BackColor = SystemColors.GradientInactiveCaption
        ListBoxSaturday.ContextMenuStrip = ContextMenuStrip7
        ListBoxSaturday.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ListBoxSaturday.FormattingEnabled = True
        ListBoxSaturday.Location = New Point(297, 706)
        ListBoxSaturday.Name = "ListBoxSaturday"
        ListBoxSaturday.Size = New Size(695, 88)
        ListBoxSaturday.TabIndex = 21
        ' 
        ' ContextMenuStrip7
        ' 
        ContextMenuStrip7.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ContextMenuStrip7.ImageScalingSize = New Size(24, 24)
        ContextMenuStrip7.Items.AddRange(New ToolStripItem() {Modifier7ToolStripMenuItem, ToolStripSeparator14, CopierLeTexteToolStripMenuItem5, CollerLeTexteToolStripMenuItem6, ToolStripSeparator13, Effacer7ToolStripMenuItem})
        ContextMenuStrip7.Name = "ContextMenuStrip7"
        ContextMenuStrip7.Size = New Size(232, 152)
        ' 
        ' Modifier7ToolStripMenuItem
        ' 
        Modifier7ToolStripMenuItem.Name = "Modifier7ToolStripMenuItem"
        Modifier7ToolStripMenuItem.Size = New Size(231, 34)
        Modifier7ToolStripMenuItem.Text = "Modifier"
        ' 
        ' ToolStripSeparator14
        ' 
        ToolStripSeparator14.Name = "ToolStripSeparator14"
        ToolStripSeparator14.Size = New Size(228, 6)
        ' 
        ' CopierLeTexteToolStripMenuItem5
        ' 
        CopierLeTexteToolStripMenuItem5.Name = "CopierLeTexteToolStripMenuItem5"
        CopierLeTexteToolStripMenuItem5.Size = New Size(231, 34)
        CopierLeTexteToolStripMenuItem5.Text = "Copier le texte"
        ' 
        ' CollerLeTexteToolStripMenuItem6
        ' 
        CollerLeTexteToolStripMenuItem6.Name = "CollerLeTexteToolStripMenuItem6"
        CollerLeTexteToolStripMenuItem6.Size = New Size(231, 34)
        CollerLeTexteToolStripMenuItem6.Text = "Coller le texte"
        ' 
        ' ToolStripSeparator13
        ' 
        ToolStripSeparator13.Name = "ToolStripSeparator13"
        ToolStripSeparator13.Size = New Size(228, 6)
        ' 
        ' Effacer7ToolStripMenuItem
        ' 
        Effacer7ToolStripMenuItem.Image = CType(resources.GetObject("Effacer7ToolStripMenuItem.Image"), Image)
        Effacer7ToolStripMenuItem.Name = "Effacer7ToolStripMenuItem"
        Effacer7ToolStripMenuItem.Size = New Size(231, 34)
        Effacer7ToolStripMenuItem.Text = "Effacer"
        ' 
        ' ButtonPreview
        ' 
        ButtonPreview.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonPreview.Location = New Point(492, 839)
        ButtonPreview.Name = "ButtonPreview"
        ButtonPreview.Size = New Size(211, 47)
        ButtonPreview.TabIndex = 22
        ButtonPreview.Text = "Version Papier"
        ButtonPreview.UseVisualStyleBackColor = True
        ' 
        ' Button1Touteff
        ' 
        Button1Touteff.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1Touteff.Location = New Point(297, 839)
        Button1Touteff.Name = "Button1Touteff"
        Button1Touteff.Size = New Size(189, 47)
        Button1Touteff.TabIndex = 23
        Button1Touteff.Text = "Tout Effacer"
        Button1Touteff.UseVisualStyleBackColor = True
        ' 
        ' frmMenu
        ' 
        AutoScaleMode = AutoScaleMode.None
        ClientSize = New Size(1041, 919)
        Controls.Add(Button1Touteff)
        Controls.Add(ButtonPreview)
        Controls.Add(ButtonSave)
        Controls.Add(ButtonNextWeek)
        Controls.Add(ButtonPreviousWeek)
        Controls.Add(LabelCurrentWeek)
        Controls.Add(ListBoxSaturday)
        Controls.Add(ListBoxFriday)
        Controls.Add(ListBoxThursday)
        Controls.Add(ListBoxWednesday)
        Controls.Add(ListBoxTuesday)
        Controls.Add(ListBoxMonday)
        Controls.Add(ListBoxSunday)
        Controls.Add(LabelSaturday)
        Controls.Add(LabelFriday)
        Controls.Add(LabelThursday)
        Controls.Add(LabelSunday)
        Controls.Add(LabelWednesday)
        Controls.Add(LabelTuesday)
        Controls.Add(LabelMonday)
        Font = New Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedDialog
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "frmMenu"
        Text = "Menu"
        ContextMenuStrip1.ResumeLayout(False)
        ContextMenuStrip2.ResumeLayout(False)
        ContextMenuStrip3.ResumeLayout(False)
        ContextMenuStrip4.ResumeLayout(False)
        ContextMenuStrip5.ResumeLayout(False)
        ContextMenuStrip6.ResumeLayout(False)
        ContextMenuStrip7.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents ButtonPreviousWeek As Button
    Friend WithEvents ButtonNextWeek As Button
    Friend WithEvents ButtonSave As Button
    Friend WithEvents LabelCurrentWeek As Label
    Friend WithEvents LabelMonday As Label
    Friend WithEvents LabelTuesday As Label
    Friend WithEvents LabelWednesday As Label
    Friend WithEvents LabelSunday As Label
    Friend WithEvents LabelThursday As Label
    Friend WithEvents LabelFriday As Label
    Friend WithEvents LabelSaturday As Label
    Friend WithEvents ListBoxSunday As ListBox
    Friend WithEvents ListBoxMonday As ListBox
    Friend WithEvents ListBoxTuesday As ListBox
    Friend WithEvents ListBoxWednesday As ListBox
    Friend WithEvents ListBoxThursday As ListBox
    Friend WithEvents ListBoxFriday As ListBox
    Friend WithEvents ListBoxSaturday As ListBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ModifierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EffacerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents Modifier2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Effacer2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip3 As ContextMenuStrip
    Friend WithEvents Modifier3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Effacer3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip4 As ContextMenuStrip
    Friend WithEvents Modifier4ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Effacer4ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip5 As ContextMenuStrip
    Friend WithEvents Modifier5ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Effacer5ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip6 As ContextMenuStrip
    Friend WithEvents Modifier6ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Effacer6ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip7 As ContextMenuStrip
    Friend WithEvents Modifier7ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Effacer7ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ButtonPreview As Button
    Friend WithEvents Button1Touteff As Button
    Friend WithEvents CollerLeTexteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CollerLeTexteToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CollerLeTexteToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents CollerLeTexteToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents CollerLeTexteToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents CollerLeTexteToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents CollerLeTexteToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents CopierLeTexteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents CopierLeTexteToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents CopierLeTexteToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents CopierLeTexteToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents CopierLetexteToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator11 As ToolStripSeparator
    Friend WithEvents CopierLeTexteToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator12 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator14 As ToolStripSeparator
    Friend WithEvents CopierLeTexteToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator13 As ToolStripSeparator
End Class
