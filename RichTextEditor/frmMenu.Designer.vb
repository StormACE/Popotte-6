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
        ButtonClose = New Button()
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
        EffacerToolStripMenuItem = New ToolStripMenuItem()
        ListBoxMonday = New ListBox()
        ContextMenuStrip2 = New ContextMenuStrip(components)
        Modifier2ToolStripMenuItem = New ToolStripMenuItem()
        Effacer2ToolStripMenuItem = New ToolStripMenuItem()
        ListBoxTuesday = New ListBox()
        ContextMenuStrip3 = New ContextMenuStrip(components)
        Modifier3ToolStripMenuItem = New ToolStripMenuItem()
        Effacer3ToolStripMenuItem = New ToolStripMenuItem()
        ListBoxWednesday = New ListBox()
        ContextMenuStrip4 = New ContextMenuStrip(components)
        Modifier4ToolStripMenuItem = New ToolStripMenuItem()
        Effacer4ToolStripMenuItem = New ToolStripMenuItem()
        ListBoxThursday = New ListBox()
        ContextMenuStrip5 = New ContextMenuStrip(components)
        Modifier5ToolStripMenuItem = New ToolStripMenuItem()
        Effacer5ToolStripMenuItem = New ToolStripMenuItem()
        ListBoxFriday = New ListBox()
        ContextMenuStrip6 = New ContextMenuStrip(components)
        Modifier6ToolStripMenuItem = New ToolStripMenuItem()
        Effacer6ToolStripMenuItem = New ToolStripMenuItem()
        ListBoxSaturday = New ListBox()
        ContextMenuStrip7 = New ContextMenuStrip(components)
        Modifier7ToolStripMenuItem = New ToolStripMenuItem()
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
        ' ButtonClose
        ' 
        ButtonClose.Font = New Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonClose.Location = New Point(898, 839)
        ButtonClose.Name = "ButtonClose"
        ButtonClose.Size = New Size(94, 47)
        ButtonClose.TabIndex = 7
        ButtonClose.Text = "Fermer"
        ButtonClose.UseVisualStyleBackColor = True
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
        ContextMenuStrip1.ImageScalingSize = New Size(24, 24)
        ContextMenuStrip1.Items.AddRange(New ToolStripItem() {ModifierToolStripMenuItem, EffacerToolStripMenuItem})
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(160, 68)
        ' 
        ' ModifierToolStripMenuItem
        ' 
        ModifierToolStripMenuItem.Name = "ModifierToolStripMenuItem"
        ModifierToolStripMenuItem.Size = New Size(159, 32)
        ModifierToolStripMenuItem.Text = "Modifier"
        ' 
        ' EffacerToolStripMenuItem
        ' 
        EffacerToolStripMenuItem.Image = CType(resources.GetObject("EffacerToolStripMenuItem.Image"), Image)
        EffacerToolStripMenuItem.Name = "EffacerToolStripMenuItem"
        EffacerToolStripMenuItem.Size = New Size(159, 32)
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
        ContextMenuStrip2.ImageScalingSize = New Size(24, 24)
        ContextMenuStrip2.Items.AddRange(New ToolStripItem() {Modifier2ToolStripMenuItem, Effacer2ToolStripMenuItem})
        ContextMenuStrip2.Name = "ContextMenuStrip2"
        ContextMenuStrip2.Size = New Size(160, 68)
        ' 
        ' Modifier2ToolStripMenuItem
        ' 
        Modifier2ToolStripMenuItem.Name = "Modifier2ToolStripMenuItem"
        Modifier2ToolStripMenuItem.Size = New Size(159, 32)
        Modifier2ToolStripMenuItem.Text = "Modifier"
        ' 
        ' Effacer2ToolStripMenuItem
        ' 
        Effacer2ToolStripMenuItem.Image = CType(resources.GetObject("Effacer2ToolStripMenuItem.Image"), Image)
        Effacer2ToolStripMenuItem.Name = "Effacer2ToolStripMenuItem"
        Effacer2ToolStripMenuItem.Size = New Size(159, 32)
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
        ContextMenuStrip3.ImageScalingSize = New Size(24, 24)
        ContextMenuStrip3.Items.AddRange(New ToolStripItem() {Modifier3ToolStripMenuItem, Effacer3ToolStripMenuItem})
        ContextMenuStrip3.Name = "ContextMenuStrip3"
        ContextMenuStrip3.Size = New Size(160, 68)
        ' 
        ' Modifier3ToolStripMenuItem
        ' 
        Modifier3ToolStripMenuItem.Name = "Modifier3ToolStripMenuItem"
        Modifier3ToolStripMenuItem.Size = New Size(159, 32)
        Modifier3ToolStripMenuItem.Text = "Modifier"
        ' 
        ' Effacer3ToolStripMenuItem
        ' 
        Effacer3ToolStripMenuItem.Image = CType(resources.GetObject("Effacer3ToolStripMenuItem.Image"), Image)
        Effacer3ToolStripMenuItem.Name = "Effacer3ToolStripMenuItem"
        Effacer3ToolStripMenuItem.Size = New Size(159, 32)
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
        ContextMenuStrip4.ImageScalingSize = New Size(24, 24)
        ContextMenuStrip4.Items.AddRange(New ToolStripItem() {Modifier4ToolStripMenuItem, Effacer4ToolStripMenuItem})
        ContextMenuStrip4.Name = "ContextMenuStrip4"
        ContextMenuStrip4.Size = New Size(160, 68)
        ' 
        ' Modifier4ToolStripMenuItem
        ' 
        Modifier4ToolStripMenuItem.Name = "Modifier4ToolStripMenuItem"
        Modifier4ToolStripMenuItem.Size = New Size(159, 32)
        Modifier4ToolStripMenuItem.Text = "Modifier"
        ' 
        ' Effacer4ToolStripMenuItem
        ' 
        Effacer4ToolStripMenuItem.Image = CType(resources.GetObject("Effacer4ToolStripMenuItem.Image"), Image)
        Effacer4ToolStripMenuItem.Name = "Effacer4ToolStripMenuItem"
        Effacer4ToolStripMenuItem.Size = New Size(159, 32)
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
        ContextMenuStrip5.ImageScalingSize = New Size(24, 24)
        ContextMenuStrip5.Items.AddRange(New ToolStripItem() {Modifier5ToolStripMenuItem, Effacer5ToolStripMenuItem})
        ContextMenuStrip5.Name = "ContextMenuStrip5"
        ContextMenuStrip5.Size = New Size(160, 68)
        ' 
        ' Modifier5ToolStripMenuItem
        ' 
        Modifier5ToolStripMenuItem.Name = "Modifier5ToolStripMenuItem"
        Modifier5ToolStripMenuItem.Size = New Size(159, 32)
        Modifier5ToolStripMenuItem.Text = "Modifier"
        ' 
        ' Effacer5ToolStripMenuItem
        ' 
        Effacer5ToolStripMenuItem.Image = CType(resources.GetObject("Effacer5ToolStripMenuItem.Image"), Image)
        Effacer5ToolStripMenuItem.Name = "Effacer5ToolStripMenuItem"
        Effacer5ToolStripMenuItem.Size = New Size(159, 32)
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
        ContextMenuStrip6.ImageScalingSize = New Size(24, 24)
        ContextMenuStrip6.Items.AddRange(New ToolStripItem() {Modifier6ToolStripMenuItem, Effacer6ToolStripMenuItem})
        ContextMenuStrip6.Name = "ContextMenuStrip6"
        ContextMenuStrip6.Size = New Size(160, 68)
        ' 
        ' Modifier6ToolStripMenuItem
        ' 
        Modifier6ToolStripMenuItem.Name = "Modifier6ToolStripMenuItem"
        Modifier6ToolStripMenuItem.Size = New Size(159, 32)
        Modifier6ToolStripMenuItem.Text = "Modifier"
        ' 
        ' Effacer6ToolStripMenuItem
        ' 
        Effacer6ToolStripMenuItem.Image = CType(resources.GetObject("Effacer6ToolStripMenuItem.Image"), Image)
        Effacer6ToolStripMenuItem.Name = "Effacer6ToolStripMenuItem"
        Effacer6ToolStripMenuItem.Size = New Size(159, 32)
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
        ContextMenuStrip7.ImageScalingSize = New Size(24, 24)
        ContextMenuStrip7.Items.AddRange(New ToolStripItem() {Modifier7ToolStripMenuItem, Effacer7ToolStripMenuItem})
        ContextMenuStrip7.Name = "ContextMenuStrip7"
        ContextMenuStrip7.Size = New Size(160, 68)
        ' 
        ' Modifier7ToolStripMenuItem
        ' 
        Modifier7ToolStripMenuItem.Name = "Modifier7ToolStripMenuItem"
        Modifier7ToolStripMenuItem.Size = New Size(159, 32)
        Modifier7ToolStripMenuItem.Text = "Modifier"
        ' 
        ' Effacer7ToolStripMenuItem
        ' 
        Effacer7ToolStripMenuItem.Image = CType(resources.GetObject("Effacer7ToolStripMenuItem.Image"), Image)
        Effacer7ToolStripMenuItem.Name = "Effacer7ToolStripMenuItem"
        Effacer7ToolStripMenuItem.Size = New Size(159, 32)
        Effacer7ToolStripMenuItem.Text = "Effacer"
        ' 
        ' ButtonPreview
        ' 
        ButtonPreview.Font = New Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonPreview.Location = New Point(763, 839)
        ButtonPreview.Name = "ButtonPreview"
        ButtonPreview.Size = New Size(129, 47)
        ButtonPreview.TabIndex = 22
        ButtonPreview.Text = "Version Papier"
        ButtonPreview.UseVisualStyleBackColor = True
        ' 
        ' Button1Touteff
        ' 
        Button1Touteff.Font = New Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1Touteff.Location = New Point(628, 839)
        Button1Touteff.Name = "Button1Touteff"
        Button1Touteff.Size = New Size(129, 47)
        Button1Touteff.TabIndex = 23
        Button1Touteff.Text = "Tout Effacer"
        Button1Touteff.UseVisualStyleBackColor = True
        ' 
        ' frmMenu
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1041, 919)
        Controls.Add(Button1Touteff)
        Controls.Add(ButtonPreview)
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
        Controls.Add(ButtonClose)
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
    Friend WithEvents ButtonClose As Button
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
End Class
