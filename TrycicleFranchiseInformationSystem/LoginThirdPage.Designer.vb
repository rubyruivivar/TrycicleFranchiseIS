<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginThirdPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginThirdPage))
        Panel1 = New Panel()
        Label3 = New Label()
        Panel2 = New Panel()
        labelWelcome1 = New Label()
        labelDearest1 = New Label()
        picboxTricycle2 = New PictureBox()
        btnLogin1 = New Button()
        btnSignup1 = New Button()
        Panel3 = New Panel()
        Panel1.SuspendLayout()
        CType(picboxTricycle2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(13), CByte(71), CByte(127))
        Panel1.Controls.Add(Label3)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1348, 70)
        Panel1.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(46, 23)
        Label3.Name = "Label3"
        Label3.Size = New Size(432, 23)
        Label3.TabIndex = 8
        Label3.Text = "TRICYCLE FRANCHISE INFORMATION SYSTEM"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(204), CByte(51), CByte(136))
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 651)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1348, 70)
        Panel2.TabIndex = 3
        ' 
        ' labelWelcome1
        ' 
        labelWelcome1.Anchor = AnchorStyles.None
        labelWelcome1.AutoSize = True
        labelWelcome1.Font = New Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelWelcome1.Location = New Point(692, 168)
        labelWelcome1.Name = "labelWelcome1"
        labelWelcome1.Size = New Size(463, 106)
        labelWelcome1.TabIndex = 4
        labelWelcome1.Text = "WELCOME!"
        ' 
        ' labelDearest1
        ' 
        labelDearest1.Anchor = AnchorStyles.None
        labelDearest1.AutoSize = True
        labelDearest1.Font = New Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelDearest1.ForeColor = Color.FromArgb(CByte(125), CByte(49), CByte(173))
        labelDearest1.Location = New Point(614, 258)
        labelDearest1.Name = "labelDearest1"
        labelDearest1.Size = New Size(597, 60)
        labelDearest1.TabIndex = 7
        labelDearest1.Text = "OUR DEAREST FRANCHISEE"
        ' 
        ' picboxTricycle2
        ' 
        picboxTricycle2.Anchor = AnchorStyles.Bottom
        picboxTricycle2.Image = CType(resources.GetObject("picboxTricycle2.Image"), Image)
        picboxTricycle2.Location = New Point(-27, 117)
        picboxTricycle2.Name = "picboxTricycle2"
        picboxTricycle2.Size = New Size(622, 513)
        picboxTricycle2.SizeMode = PictureBoxSizeMode.StretchImage
        picboxTricycle2.TabIndex = 8
        picboxTricycle2.TabStop = False
        ' 
        ' btnLogin1
        ' 
        btnLogin1.Anchor = AnchorStyles.None
        btnLogin1.BackColor = Color.FromArgb(CByte(218), CByte(97), CByte(164))
        btnLogin1.Cursor = Cursors.Hand
        btnLogin1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin1.ForeColor = SystemColors.ButtonHighlight
        btnLogin1.Location = New Point(820, 351)
        btnLogin1.Name = "btnLogin1"
        btnLogin1.Size = New Size(210, 70)
        btnLogin1.TabIndex = 10
        btnLogin1.Text = "LOG IN"
        btnLogin1.UseVisualStyleBackColor = False
        ' 
        ' btnSignup1
        ' 
        btnSignup1.Anchor = AnchorStyles.None
        btnSignup1.BackColor = Color.FromArgb(CByte(121), CByte(167), CByte(213))
        btnSignup1.Cursor = Cursors.Hand
        btnSignup1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSignup1.ForeColor = SystemColors.ButtonHighlight
        btnSignup1.Location = New Point(820, 425)
        btnSignup1.Name = "btnSignup1"
        btnSignup1.Size = New Size(210, 70)
        btnSignup1.TabIndex = 9
        btnSignup1.Text = "SIGN UP"
        btnSignup1.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.DimGray
        Panel3.Dock = DockStyle.Bottom
        Panel3.Location = New Point(0, 626)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1348, 25)
        Panel3.TabIndex = 11
        ' 
        ' LoginThirdPage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1348, 721)
        Controls.Add(Panel3)
        Controls.Add(btnLogin1)
        Controls.Add(btnSignup1)
        Controls.Add(picboxTricycle2)
        Controls.Add(labelDearest1)
        Controls.Add(labelWelcome1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "LoginThirdPage"
        StartPosition = FormStartPosition.CenterScreen
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(picboxTricycle2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents labelWelcome1 As Label
    Friend WithEvents labelDearest1 As Label
    Friend WithEvents picboxTricycle2 As PictureBox
    Friend WithEvents btnLogin1 As Button
    Friend WithEvents btnSignup1 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
End Class
