<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginAdminLOGIN
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
        Panel1 = New Panel()
        Label3 = New Label()
        Panel2 = New Panel()
        btnContinue3 = New Button()
        Panel3 = New Panel()
        btnTogglePasswordAP = New Button()
        lnklbl_Admin = New LinkLabel()
        labelPassUserAd1 = New Label()
        txtboxPassUserad1 = New TextBox()
        labelUserAd1 = New Label()
        txtboxUserAd1 = New TextBox()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
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
        Panel1.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(46, 23)
        Label3.Name = "Label3"
        Label3.Size = New Size(432, 23)
        Label3.TabIndex = 9
        Label3.Text = "TRICYCLE FRANCHISE INFORMATION SYSTEM"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(204), CByte(51), CByte(136))
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 651)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1348, 70)
        Panel2.TabIndex = 6
        ' 
        ' btnContinue3
        ' 
        btnContinue3.Anchor = AnchorStyles.None
        btnContinue3.BackColor = SystemColors.ActiveCaptionText
        btnContinue3.Cursor = Cursors.Hand
        btnContinue3.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnContinue3.ForeColor = SystemColors.ButtonHighlight
        btnContinue3.Location = New Point(568, 530)
        btnContinue3.Name = "btnContinue3"
        btnContinue3.Size = New Size(210, 70)
        btnContinue3.TabIndex = 11
        btnContinue3.Text = "CONTINUE"
        btnContinue3.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.Anchor = AnchorStyles.None
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(btnTogglePasswordAP)
        Panel3.Controls.Add(lnklbl_Admin)
        Panel3.Controls.Add(labelPassUserAd1)
        Panel3.Controls.Add(txtboxPassUserad1)
        Panel3.Controls.Add(labelUserAd1)
        Panel3.Controls.Add(txtboxUserAd1)
        Panel3.Location = New Point(227, 90)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(891, 409)
        Panel3.TabIndex = 12
        ' 
        ' btnTogglePasswordAP
        ' 
        btnTogglePasswordAP.Anchor = AnchorStyles.None
        btnTogglePasswordAP.BackColor = SystemColors.AppWorkspace
        btnTogglePasswordAP.Font = New Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnTogglePasswordAP.Location = New Point(688, 222)
        btnTogglePasswordAP.Name = "btnTogglePasswordAP"
        btnTogglePasswordAP.Size = New Size(63, 32)
        btnTogglePasswordAP.TabIndex = 32
        btnTogglePasswordAP.Text = "Toggle"
        btnTogglePasswordAP.UseVisualStyleBackColor = False
        ' 
        ' lnklbl_Admin
        ' 
        lnklbl_Admin.ActiveLinkColor = Color.Khaki
        lnklbl_Admin.AutoSize = True
        lnklbl_Admin.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lnklbl_Admin.Location = New Point(520, 322)
        lnklbl_Admin.Name = "lnklbl_Admin"
        lnklbl_Admin.Size = New Size(231, 31)
        lnklbl_Admin.TabIndex = 4
        lnklbl_Admin.TabStop = True
        lnklbl_Admin.Text = "Click here to Sign up!"
        ' 
        ' labelPassUserAd1
        ' 
        labelPassUserAd1.AutoSize = True
        labelPassUserAd1.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelPassUserAd1.Location = New Point(184, 203)
        labelPassUserAd1.Name = "labelPassUserAd1"
        labelPassUserAd1.Size = New Size(187, 50)
        labelPassUserAd1.TabIndex = 3
        labelPassUserAd1.Text = "Password"
        ' 
        ' txtboxPassUserad1
        ' 
        txtboxPassUserad1.Cursor = Cursors.IBeam
        txtboxPassUserad1.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtboxPassUserad1.ForeColor = SystemColors.ActiveCaptionText
        txtboxPassUserad1.Location = New Point(194, 261)
        txtboxPassUserad1.Name = "txtboxPassUserad1"
        txtboxPassUserad1.Size = New Size(557, 51)
        txtboxPassUserad1.TabIndex = 2
        ' 
        ' labelUserAd1
        ' 
        labelUserAd1.AutoSize = True
        labelUserAd1.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelUserAd1.Location = New Point(184, 72)
        labelUserAd1.Name = "labelUserAd1"
        labelUserAd1.Size = New Size(196, 50)
        labelUserAd1.TabIndex = 1
        labelUserAd1.Text = "Username"
        ' 
        ' txtboxUserAd1
        ' 
        txtboxUserAd1.Cursor = Cursors.IBeam
        txtboxUserAd1.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtboxUserAd1.ForeColor = SystemColors.AppWorkspace
        txtboxUserAd1.Location = New Point(194, 129)
        txtboxUserAd1.Name = "txtboxUserAd1"
        txtboxUserAd1.Size = New Size(557, 51)
        txtboxUserAd1.TabIndex = 0
        txtboxUserAd1.Text = "Enter Username"
        ' 
        ' LoginAdminLOGIN
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1348, 721)
        Controls.Add(Panel3)
        Controls.Add(btnContinue3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "LoginAdminLOGIN"
        StartPosition = FormStartPosition.CenterScreen
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnContinue3 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents labelPassUserAd1 As Label
    Friend WithEvents txtboxPassUserad1 As TextBox
    Friend WithEvents labelUserAd1 As Label
    Friend WithEvents txtboxUserAd1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lnklbl_Admin As LinkLabel
    Friend WithEvents btnTogglePasswordAP As Button
End Class
