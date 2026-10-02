<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgFind
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgFind))
        LabelMot = New Label()
        txtSearchTerm = New TextBox()
        chkMatchCase = New CheckBox()
        btnFind = New Button()
        btnFindNext = New Button()
        OpacityHScrollBar = New HScrollBar()
        SuspendLayout()
        ' 
        ' LabelMot
        ' 
        LabelMot.AutoSize = True
        LabelMot.Location = New Point(22, 21)
        LabelMot.Margin = New Padding(5, 0, 5, 0)
        LabelMot.Name = "LabelMot"
        LabelMot.Size = New Size(79, 21)
        LabelMot.TabIndex = 0
        LabelMot.Text = "Mot Cl�:"
        ' 
        ' txtSearchTerm
        ' 
        txtSearchTerm.BackColor = SystemColors.GradientInactiveCaption
        txtSearchTerm.BorderStyle = BorderStyle.FixedSingle
        txtSearchTerm.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtSearchTerm.Location = New Point(27, 47)
        txtSearchTerm.Margin = New Padding(5)
        txtSearchTerm.Name = "txtSearchTerm"
        txtSearchTerm.Size = New Size(417, 34)
        txtSearchTerm.TabIndex = 1
        ' 
        ' chkMatchCase
        ' 
        chkMatchCase.AutoSize = True
        chkMatchCase.BackColor = SystemColors.Control
        chkMatchCase.FlatStyle = FlatStyle.System
        chkMatchCase.Location = New Point(27, 100)
        chkMatchCase.Margin = New Padding(5)
        chkMatchCase.Name = "chkMatchCase"
        chkMatchCase.Size = New Size(233, 26)
        chkMatchCase.TabIndex = 4
        chkMatchCase.Text = "Sensible aux Majuscules"
        chkMatchCase.UseVisualStyleBackColor = False
        ' 
        ' btnFind
        ' 
        btnFind.FlatStyle = FlatStyle.System
        btnFind.Location = New Point(457, 47)
        btnFind.Margin = New Padding(5)
        btnFind.Name = "btnFind"
        btnFind.Size = New Size(125, 34)
        btnFind.TabIndex = 2
        btnFind.Text = "&Rechercher"
        btnFind.UseVisualStyleBackColor = True
        ' 
        ' btnFindNext
        ' 
        btnFindNext.FlatStyle = FlatStyle.System
        btnFindNext.Location = New Point(457, 100)
        btnFindNext.Margin = New Padding(5)
        btnFindNext.Name = "btnFindNext"
        btnFindNext.Size = New Size(125, 34)
        btnFindNext.TabIndex = 3
        btnFindNext.Text = "&Suivant"
        btnFindNext.UseVisualStyleBackColor = True
        ' 
        ' OpacityHScrollBar
        ' 
        OpacityHScrollBar.Location = New Point(27, 150)
        OpacityHScrollBar.Name = "OpacityHScrollBar"
        OpacityHScrollBar.Size = New Size(555, 26)
        OpacityHScrollBar.TabIndex = 5
        ' 
        ' dlgFind
        ' 
        AutoScaleDimensions = New SizeF(144F, 144F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoSize = True
        ClientSize = New Size(602, 199)
        Controls.Add(OpacityHScrollBar)
        Controls.Add(btnFindNext)
        Controls.Add(btnFind)
        Controls.Add(chkMatchCase)
        Controls.Add(txtSearchTerm)
        Controls.Add(LabelMot)
        Font = New Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedDialog
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(5)
        MaximizeBox = False
        MinimizeBox = False
        Name = "dlgFind"
        ShowInTaskbar = False
        Text = "Popotte - Rechercher"
        TopMost = True
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents LabelMot As System.Windows.Forms.Label
    Friend WithEvents txtSearchTerm As System.Windows.Forms.TextBox
    Friend WithEvents chkMatchCase As System.Windows.Forms.CheckBox
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents btnFindNext As System.Windows.Forms.Button
    Friend WithEvents OpacityHScrollBar As HScrollBar
End Class
