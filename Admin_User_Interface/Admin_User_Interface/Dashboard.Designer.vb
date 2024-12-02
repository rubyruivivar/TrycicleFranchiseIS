<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Dim Button1 As Button
        Dim Profile As Button
        Dim Services As Button
        Dim Request As Button
        Dim About As Button
        Dim Logout As Button
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Panel1 = New Panel()
        Panel3 = New Panel()
        Panel2 = New Panel()
        Panel4 = New Panel()
        Panel5 = New Panel()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Button1 = New Button()
        Profile = New Button()
        Services = New Button()
        Request = New Button()
        About = New Button()
        Logout = New Button()
        Panel1.SuspendLayout()
        Panel5.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(149), CByte(194), CByte(236))
        Button1.BackgroundImageLayout = ImageLayout.None
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(1, 27)
        Button1.Name = "Button1"
        Button1.Size = New Size(271, 40)
        Button1.TabIndex = 0
        Button1.Text = "Dashboard"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Profile
        ' 
        Profile.BackColor = Color.FromArgb(CByte(149), CByte(194), CByte(236))
        Profile.BackgroundImageLayout = ImageLayout.None
        Profile.FlatAppearance.BorderSize = 0
        Profile.FlatStyle = FlatStyle.Flat
        Profile.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Profile.ForeColor = Color.White
        Profile.Location = New Point(2, 84)
        Profile.Name = "Profile"
        Profile.Size = New Size(269, 40)
        Profile.TabIndex = 1
        Profile.Text = "My Profile"
        Profile.UseVisualStyleBackColor = False
        ' 
        ' Services
        ' 
        Services.BackColor = Color.FromArgb(CByte(149), CByte(194), CByte(236))
        Services.BackgroundImageLayout = ImageLayout.None
        Services.FlatAppearance.BorderSize = 0
        Services.FlatStyle = FlatStyle.Flat
        Services.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Services.ForeColor = Color.White
        Services.Location = New Point(1, 139)
        Services.Name = "Services"
        Services.Size = New Size(271, 40)
        Services.TabIndex = 2
        Services.Text = "Services"
        Services.UseVisualStyleBackColor = False
        ' 
        ' Request
        ' 
        Request.BackColor = Color.FromArgb(CByte(149), CByte(194), CByte(236))
        Request.BackgroundImageLayout = ImageLayout.None
        Request.FlatAppearance.BorderSize = 0
        Request.FlatStyle = FlatStyle.Flat
        Request.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Request.ForeColor = Color.White
        Request.Location = New Point(2, 195)
        Request.Name = "Request"
        Request.Size = New Size(270, 40)
        Request.TabIndex = 3
        Request.Text = "Track my Reques"
        Request.UseVisualStyleBackColor = False
        ' 
        ' About
        ' 
        About.BackColor = Color.FromArgb(CByte(149), CByte(194), CByte(236))
        About.BackgroundImageLayout = ImageLayout.None
        About.FlatAppearance.BorderSize = 0
        About.FlatStyle = FlatStyle.Flat
        About.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        About.ForeColor = Color.White
        About.Location = New Point(1, 251)
        About.Name = "About"
        About.Size = New Size(271, 40)
        About.TabIndex = 4
        About.Text = "About Us"
        About.UseVisualStyleBackColor = False
        ' 
        ' Logout
        ' 
        Logout.BackColor = Color.FromArgb(CByte(149), CByte(194), CByte(236))
        Logout.BackgroundImageLayout = ImageLayout.None
        Logout.FlatAppearance.BorderSize = 0
        Logout.FlatStyle = FlatStyle.Flat
        Logout.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Logout.ForeColor = Color.White
        Logout.Location = New Point(1, 307)
        Logout.Name = "Logout"
        Logout.Size = New Size(272, 40)
        Logout.TabIndex = 5
        Logout.Text = "Logout"
        Logout.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(149), CByte(194), CByte(236))
        Panel1.Controls.Add(Profile)
        Panel1.Controls.Add(Logout)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(About)
        Panel1.Controls.Add(Request)
        Panel1.Controls.Add(Services)
        Panel1.Controls.Add(Button1)
        Panel1.Location = New Point(0, 42)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(275, 497)
        Panel1.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.Location = New Point(273, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(632, 491)
        Panel3.TabIndex = 3
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(237), CByte(134), CByte(191))
        Panel2.Location = New Point(274, 492)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(632, 46)
        Panel2.TabIndex = 2
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = SystemColors.ButtonHighlight
        Panel4.Location = New Point(274, 45)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(632, 446)
        Panel4.TabIndex = 3
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.Black
        Panel5.Controls.Add(PictureBox1)
        Panel5.Controls.Add(Label2)
        Panel5.Location = New Point(0, 0)
        Panel5.Margin = New Padding(3, 2, 3, 2)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(906, 46)
        Panel5.TabIndex = 3
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(51, 40)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(57, 12)
        Label2.Name = "Label2"
        Label2.Size = New Size(271, 20)
        Label2.TabIndex = 8
        Label2.Text = "Tricycle Franchising Information System"
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(906, 538)
        Controls.Add(Panel5)
        Controls.Add(Panel2)
        Controls.Add(Panel4)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Dashboard"
        Text = "TRICYCLE FRANCHISING INFORMATION SYSTEM"
        Panel1.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
End Class
