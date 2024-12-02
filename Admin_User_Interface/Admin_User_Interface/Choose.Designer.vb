<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Choose
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Choose))
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Panel1 = New Panel()
        Label1 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(13), CByte(71), CByte(127))
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(-7, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(809, 59)
        Panel2.TabIndex = 1
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(19, 8)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(51, 40)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(73, 18)
        Label2.Name = "Label2"
        Label2.Size = New Size(271, 20)
        Label2.TabIndex = 6
        Label2.Text = "Tricycle Franchising Information System"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(204), CByte(51), CByte(136))
        Panel1.Location = New Point(-3, 488)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(805, 50)
        Panel1.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Impact", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(346, 134)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 27)
        Label1.TabIndex = 3
        Label1.Text = "SIGN IN"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Black
        Button1.BackgroundImageLayout = ImageLayout.None
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.Control
        Button1.Location = New Point(304, 232)
        Button1.Name = "Button1"
        Button1.Size = New Size(170, 62)
        Button1.TabIndex = 4
        Button1.Text = "Standard User"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ControlDarkDark
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = SystemColors.ButtonHighlight
        Button2.Location = New Point(304, 332)
        Button2.Name = "Button2"
        Button2.Size = New Size(170, 62)
        Button2.TabIndex = 5
        Button2.Text = "Administrator"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Choose
        ' 
        AutoScaleDimensions = New SizeF(6F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 538)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Font = New Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = SystemColors.ActiveCaptionText
        FormBorderStyle = FormBorderStyle.FixedSingle
        HelpButton = True
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Choose"
        Text = "TRICYCLE FRANCHISING INFORMATION SYSTEM"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
End Class
