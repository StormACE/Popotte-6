<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgReplace
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgReplace))
        btnFindNext = New Button()
        btnFind = New Button()
        chkMatchCase = New CheckBox()
        txtSearchTerm = New TextBox()
        LabelMot = New Label()
        txtReplacementText = New TextBox()
        LabelRemplacer = New Label()
        btnReplace = New Button()
        btnReplaceAll = New Button()
        OpacityHScrollBar = New HScrollBar()
        SuspendLayout()
        ' 
        ' btnFindNext
        ' 
        btnFindNext.FlatStyle = FlatStyle.System
        btnFindNext.Location = New Point(157, 201)
        btnFindNext.Margin = New Padding(4, 5, 4, 5)
        btnFindNext.Name = "btnFindNext"
        btnFindNext.Size = New Size(124, 34)
        btnFindNext.TabIndex = 5
        btnFindNext.Text = "&Suivant"
        btnFindNext.UseVisualStyleBackColor = True
        ' 
        ' btnFind
        ' 
        btnFind.FlatStyle = FlatStyle.System
        btnFind.Location = New Point(22, 201)
        btnFind.Margin = New Padding(4, 5, 4, 5)
        btnFind.Name = "btnFind"
        btnFind.Size = New Size(124, 34)
        btnFind.TabIndex = 4
        btnFind.Text = "&Rechercher"
        btnFind.UseVisualStyleBackColor = True
        ' 
        ' chkMatchCase
        ' 
        chkMatchCase.AutoSize = True
        chkMatchCase.FlatStyle = FlatStyle.System
        chkMatchCase.Location = New Point(22, 152)
        chkMatchCase.Margin = New Padding(4, 5, 4, 5)
        chkMatchCase.Name = "chkMatchCase"
        chkMatchCase.Size = New Size(233, 26)
        chkMatchCase.TabIndex = 3
        chkMatchCase.Text = "Sensible aux majuscules"
        chkMatchCase.UseVisualStyleBackColor = True
        ' 
        ' txtSearchTerm
        ' 
        txtSearchTerm.BackColor = SystemColors.GradientInactiveCaption
        txtSearchTerm.BorderStyle = BorderStyle.FixedSingle
        txtSearchTerm.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtSearchTerm.Location = New Point(20, 40)
        txtSearchTerm.Margin = New Padding(4, 5, 4, 5)
        txtSearchTerm.Name = "txtSearchTerm"
        txtSearchTerm.Size = New Size(533, 34)
        txtSearchTerm.TabIndex = 1
        ' 
        ' LabelMot
        ' 
        LabelMot.AutoSize = True
        LabelMot.Location = New Point(16, 13)
        LabelMot.Margin = New Padding(4, 0, 4, 0)
        LabelMot.Name = "LabelMot"
        LabelMot.Size = New Size(79, 21)
        LabelMot.TabIndex = 5
        LabelMot.Text = "Mot Cl�:"
        ' 
        ' txtReplacementText
        ' 
        txtReplacementText.BackColor = SystemColors.GradientInactiveCaption
        txtReplacementText.BorderStyle = BorderStyle.FixedSingle
        txtReplacementText.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtReplacementText.Location = New Point(22, 113)
        txtReplacementText.Margin = New Padding(4, 5, 4, 5)
        txtReplacementText.Name = "txtReplacementText"
        txtReplacementText.Size = New Size(531, 34)
        txtReplacementText.TabIndex = 2
        ' 
        ' LabelRemplacer
        ' 
        LabelRemplacer.AutoSize = True
        LabelRemplacer.Location = New Point(17, 86)
        LabelRemplacer.Margin = New Padding(4, 0, 4, 0)
        LabelRemplacer.Name = "LabelRemplacer"
        LabelRemplacer.Size = New Size(125, 21)
        LabelRemplacer.TabIndex = 10
        LabelRemplacer.Text = "Remplacer par:"
        ' 
        ' btnReplace
        ' 
        btnReplace.FlatStyle = FlatStyle.System
        btnReplace.Location = New Point(291, 201)
        btnReplace.Margin = New Padding(4, 5, 4, 5)
        btnReplace.Name = "btnReplace"
        btnReplace.Size = New Size(124, 34)
        btnReplace.TabIndex = 6
        btnReplace.Text = "Rem&placer"
        btnReplace.UseVisualStyleBackColor = True
        ' 
        ' btnReplaceAll
        ' 
        btnReplaceAll.FlatStyle = FlatStyle.System
        btnReplaceAll.Location = New Point(427, 201)
        btnReplaceAll.Margin = New Padding(4, 5, 4, 5)
        btnReplaceAll.Name = "btnReplaceAll"
        btnReplaceAll.Size = New Size(124, 34)
        btnReplaceAll.TabIndex = 7
        btnReplaceAll.Text = "&Tous"
        btnReplaceAll.UseVisualStyleBackColor = True
        ' 
        ' OpacityHScrollBar
        ' 
        OpacityHScrollBar.Location = New Point(20, 250)
        OpacityHScrollBar.Name = "OpacityHScrollBar"
        OpacityHScrollBar.Size = New Size(530, 26)
        OpacityHScrollBar.TabIndex = 11
        ' 
        ' dlgReplace
        ' 
        AutoScaleDimensions = New SizeF(144F, 144F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoSize = True
        ClientSize = New Size(573, 294)
        Controls.Add(OpacityHScrollBar)
        Controls.Add(btnReplaceAll)
        Controls.Add(btnReplace)
        Controls.Add(txtReplacementText)
        Controls.Add(LabelRemplacer)
        Controls.Add(btnFindNext)
        Controls.Add(btnFind)
        Controls.Add(chkMatchCase)
        Controls.Add(txtSearchTerm)
        Controls.Add(LabelMot)
        Font = New Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedDialog
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4, 5, 4, 5)
        MaximizeBox = False
        MinimizeBox = False
        Name = "dlgReplace"
        ShowInTaskbar = False
        Text = "Popotte - Rechercher/Remplacer"
        TopMost = True
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents btnFindNext As System.Windows.Forms.Button
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents chkMatchCase As System.Windows.Forms.CheckBox
    Friend WithEvents txtSearchTerm As System.Windows.Forms.TextBox
    Friend WithEvents LabelMot As System.Windows.Forms.Label
    Friend WithEvents txtReplacementText As System.Windows.Forms.TextBox
    Friend WithEvents LabelRemplacer As System.Windows.Forms.Label
    Friend WithEvents btnReplace As System.Windows.Forms.Button
    Friend WithEvents btnReplaceAll As System.Windows.Forms.Button
    Friend WithEvents OpacityHScrollBar As HScrollBar
End Class
