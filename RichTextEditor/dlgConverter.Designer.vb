<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgConverter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgConverter))
        Close_Button = New Button()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        ConverterComboBox = New ComboBox()
        LabelIn = New Label()
        LabelConv = New Label()
        LabelOut = New Label()
        SuspendLayout()
        ' 
        ' Close_Button
        ' 
        Close_Button.Anchor = AnchorStyles.None
        Close_Button.DialogResult = DialogResult.Cancel
        Close_Button.FlatStyle = FlatStyle.System
        Close_Button.Location = New Point(347, 129)
        Close_Button.Margin = New Padding(4, 3, 4, 3)
        Close_Button.Name = "Close_Button"
        Close_Button.Size = New Size(101, 35)
        Close_Button.TabIndex = 4
        Close_Button.Text = "Fermer"
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = SystemColors.GradientInactiveCaption
        TextBox2.Location = New Point(373, 60)
        TextBox2.Margin = New Padding(4, 3, 4, 3)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(75, 29)
        TextBox2.TabIndex = 3
        TextBox2.WordWrap = False
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.GradientInactiveCaption
        TextBox1.Location = New Point(13, 60)
        TextBox1.Margin = New Padding(4, 3, 4, 3)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(75, 29)
        TextBox1.TabIndex = 1
        TextBox1.WordWrap = False
        ' 
        ' ConverterComboBox
        ' 
        ConverterComboBox.BackColor = SystemColors.GradientInactiveCaption
        ConverterComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        ConverterComboBox.FlatStyle = FlatStyle.System
        ConverterComboBox.FormattingEnabled = True
        ConverterComboBox.Location = New Point(96, 60)
        ConverterComboBox.Margin = New Padding(4, 3, 4, 3)
        ConverterComboBox.MaxDropDownItems = 25
        ConverterComboBox.Name = "ConverterComboBox"
        ConverterComboBox.Size = New Size(269, 29)
        ConverterComboBox.TabIndex = 2
        ' 
        ' LabelIn
        ' 
        LabelIn.AutoSize = True
        LabelIn.Location = New Point(13, 36)
        LabelIn.Margin = New Padding(4, 0, 4, 0)
        LabelIn.Name = "LabelIn"
        LabelIn.Size = New Size(67, 21)
        LabelIn.TabIndex = 6
        LabelIn.Text = "Entrée :"
        ' 
        ' LabelConv
        ' 
        LabelConv.AutoSize = True
        LabelConv.Location = New Point(96, 36)
        LabelConv.Margin = New Padding(4, 0, 4, 0)
        LabelConv.Name = "LabelConv"
        LabelConv.Size = New Size(103, 21)
        LabelConv.TabIndex = 7
        LabelConv.Text = "Convertion :"
        ' 
        ' LabelOut
        ' 
        LabelOut.AutoSize = True
        LabelOut.Location = New Point(373, 36)
        LabelOut.Margin = New Padding(4, 0, 4, 0)
        LabelOut.Name = "LabelOut"
        LabelOut.Size = New Size(63, 21)
        LabelOut.TabIndex = 8
        LabelOut.Text = "Sortie :"
        ' 
        ' dlgConverter
        ' 
        AutoScaleDimensions = New SizeF(144F, 144F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoSize = True
        CancelButton = Close_Button
        ClientSize = New Size(461, 176)
        Controls.Add(LabelOut)
        Controls.Add(LabelConv)
        Controls.Add(LabelIn)
        Controls.Add(ConverterComboBox)
        Controls.Add(TextBox1)
        Controls.Add(TextBox2)
        Controls.Add(Close_Button)
        Font = New Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedDialog
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        MinimizeBox = False
        Name = "dlgConverter"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "Popotte - Convertisseur"
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents Close_Button As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ConverterComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents LabelIn As System.Windows.Forms.Label
    Friend WithEvents LabelConv As System.Windows.Forms.Label
    Friend WithEvents LabelOut As System.Windows.Forms.Label

End Class
