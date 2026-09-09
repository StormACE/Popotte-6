<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgStartup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgStartup))
        Label1 = New Label()
        Label2 = New Label()
        RadioButton1 = New RadioButton()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        RadioButton4 = New RadioButton()
        Label3 = New Label()
        Button1 = New Button()
        RadioButton2 = New RadioButton()
        PictureBox1 = New PictureBox()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Crimson
        Label1.Location = New Point(662, 69)
        Label1.Name = "Label1"
        Label1.Size = New Size(545, 111)
        Label1.TabIndex = 2
        Label1.Text = "Popotte v6"
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(657, 256)
        Label2.Name = "Label2"
        Label2.Size = New Size(564, 106)
        Label2.TabIndex = 9
        Label2.Text = "Veuillez choisir le dossier où seront sauvegardées vos recettes."
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.BackgroundImage = CType(resources.GetObject("RadioButton1.BackgroundImage"), Image)
        RadioButton1.BackgroundImageLayout = ImageLayout.Stretch
        RadioButton1.Location = New Point(743, 472)
        RadioButton1.Margin = New Padding(3, 4, 3, 4)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(21, 20)
        RadioButton1.TabIndex = 10
        RadioButton1.TabStop = True
        RadioButton1.TextImageRelation = TextImageRelation.ImageAboveText
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(784, 410)
        PictureBox2.Margin = New Padding(3, 4, 3, 4)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(291, 139)
        PictureBox2.TabIndex = 11
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), Image)
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox3.Location = New Point(783, 556)
        PictureBox3.Margin = New Padding(3, 4, 3, 4)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(291, 98)
        PictureBox3.TabIndex = 12
        PictureBox3.TabStop = False
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RadioButton4.Location = New Point(743, 696)
        RadioButton4.Margin = New Padding(3, 4, 3, 4)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(362, 36)
        RadioButton4.TabIndex = 13
        RadioButton4.TabStop = True
        RadioButton4.Text = "   Dossier Local Personnalisé"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 919)
        Label3.Name = "Label3"
        Label3.Size = New Size(258, 25)
        Label3.TabIndex = 14
        Label3.Text = "© Martin Laflamme 2003/2026"
        ' 
        ' Button1
        ' 
        Button1.FlatStyle = FlatStyle.System
        Button1.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(1050, 896)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(157, 48)
        Button1.TabIndex = 15
        Button1.Text = "Suivant"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(743, 594)
        RadioButton2.Margin = New Padding(3, 4, 3, 4)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(21, 20)
        RadioButton2.TabIndex = 16
        RadioButton2.TabStop = True
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(49, 69)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(576, 672)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' dlgStartup
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1251, 969)
        Controls.Add(RadioButton2)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(RadioButton4)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(RadioButton1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4, 6, 4, 6)
        MaximizeBox = False
        MinimizeBox = False
        Name = "dlgStartup"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "Démarrage"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
End Class
