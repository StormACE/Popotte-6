<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgAboutBox
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgAboutBox))
        LabelCopyright = New Label()
        LabelVersion = New Label()
        LabelProductName = New Label()
        LogoPictureBox = New PictureBox()
        TableLayoutPanel = New TableLayoutPanel()
        CType(LogoPictureBox, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' LabelCopyright
        ' 
        LabelCopyright.AutoSize = True
        LabelCopyright.Location = New Point(351, 216)
        LabelCopyright.Margin = New Padding(7, 0, 3, 0)
        LabelCopyright.Name = "LabelCopyright"
        LabelCopyright.Size = New Size(105, 28)
        LabelCopyright.TabIndex = 0
        LabelCopyright.Text = "Copyright"
        LabelCopyright.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LabelVersion
        ' 
        LabelVersion.AccessibleRole = AccessibleRole.None
        LabelVersion.AutoSize = True
        LabelVersion.Dock = DockStyle.Fill
        LabelVersion.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelVersion.Location = New Point(351, 61)
        LabelVersion.Margin = New Padding(7, 0, 3, 0)
        LabelVersion.Name = "LabelVersion"
        LabelVersion.Size = New Size(495, 155)
        LabelVersion.TabIndex = 0
        LabelVersion.Text = "Version"
        LabelVersion.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LabelProductName
        ' 
        LabelProductName.AutoSize = True
        LabelProductName.Dock = DockStyle.Fill
        LabelProductName.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelProductName.Location = New Point(351, 0)
        LabelProductName.Margin = New Padding(7, 0, 3, 0)
        LabelProductName.Name = "LabelProductName"
        LabelProductName.Size = New Size(495, 61)
        LabelProductName.TabIndex = 0
        LabelProductName.Text = "Nom du produit"
        LabelProductName.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LogoPictureBox
        ' 
        LogoPictureBox.Dock = DockStyle.Fill
        LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), Image)
        LogoPictureBox.Location = New Point(3, 3)
        LogoPictureBox.Name = "LogoPictureBox"
        TableLayoutPanel.SetRowSpan(LogoPictureBox, 6)
        LogoPictureBox.Size = New Size(338, 609)
        LogoPictureBox.SizeMode = PictureBoxSizeMode.Zoom
        LogoPictureBox.TabIndex = 0
        LogoPictureBox.TabStop = False
        ' 
        ' TableLayoutPanel
        ' 
        TableLayoutPanel.ColumnCount = 2
        TableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 40.63205F))
        TableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 59.36795F))
        TableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel.Controls.Add(LogoPictureBox, 0, 0)
        TableLayoutPanel.Controls.Add(LabelProductName, 1, 0)
        TableLayoutPanel.Controls.Add(LabelVersion, 1, 1)
        TableLayoutPanel.Controls.Add(LabelCopyright, 1, 2)
        TableLayoutPanel.Dock = DockStyle.Fill
        TableLayoutPanel.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TableLayoutPanel.Location = New Point(11, 10)
        TableLayoutPanel.Name = "TableLayoutPanel"
        TableLayoutPanel.RowCount = 6
        TableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 25.2032528F))
        TableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 50.5691071F))
        TableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 1.300813F))
        TableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 10.5691061F))
        TableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 2.113821F))
        TableLayoutPanel.Size = New Size(849, 615)
        TableLayoutPanel.TabIndex = 0
        ' 
        ' dlgAboutBox
        ' 
        AutoScaleDimensions = New SizeF(144F, 144F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoSize = True
        ClientSize = New Size(871, 635)
        Controls.Add(TableLayoutPanel)
        Font = New Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedDialog
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "dlgAboutBox"
        Padding = New Padding(11, 10, 11, 10)
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "AboutBox1"
        CType(LogoPictureBox, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel.ResumeLayout(False)
        TableLayoutPanel.PerformLayout()
        ResumeLayout(False)

    End Sub
    Friend WithEvents LabelCopyright As Label
    Friend WithEvents LabelVersion As Label
    Friend WithEvents LabelProductName As Label
    Friend WithEvents LogoPictureBox As PictureBox
    Friend WithEvents TableLayoutPanel As TableLayoutPanel
End Class
