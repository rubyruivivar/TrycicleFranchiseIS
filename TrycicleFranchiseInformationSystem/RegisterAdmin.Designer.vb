<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterAdmin
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
        Panel2 = New Panel()
        Panel1 = New Panel()
        Label3 = New Label()
        txboxADMUS = New TextBox()
        txtboxEmailAD = New TextBox()
        txtboxPassADMUS = New TextBox()
        txtboxCnfrmADMUS = New TextBox()
        btnSignupADMSU = New Button()
        labelADMSU = New Label()
        lblEmailADMSU = New Label()
        lblPassADMSU = New Label()
        lblCPassADMSU = New Label()
        btnTglPassAD = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(204), CByte(51), CByte(136))
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 651)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1348, 70)
        Panel2.TabIndex = 5
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(13), CByte(71), CByte(127))
        Panel1.Controls.Add(Label3)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1348, 70)
        Panel1.TabIndex = 6
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
        ' txboxADMUS
        ' 
        txboxADMUS.Anchor = AnchorStyles.None
        txboxADMUS.Font = New Font("Segoe UI", 19.8000011F)
        txboxADMUS.ForeColor = SystemColors.AppWorkspace
        txboxADMUS.Location = New Point(373, 190)
        txboxADMUS.Name = "txboxADMUS"
        txboxADMUS.Size = New Size(557, 51)
        txboxADMUS.TabIndex = 9
        txboxADMUS.Text = "Enter Username"
        ' 
        ' txtboxEmailAD
        ' 
        txtboxEmailAD.Anchor = AnchorStyles.None
        txtboxEmailAD.Font = New Font("Segoe UI", 19.8000011F)
        txtboxEmailAD.ForeColor = SystemColors.AppWorkspace
        txtboxEmailAD.Location = New Point(373, 297)
        txtboxEmailAD.Name = "txtboxEmailAD"
        txtboxEmailAD.Size = New Size(557, 51)
        txtboxEmailAD.TabIndex = 10
        txtboxEmailAD.Text = "Enter Email"
        ' 
        ' txtboxPassADMUS
        ' 
        txtboxPassADMUS.Anchor = AnchorStyles.None
        txtboxPassADMUS.Font = New Font("Segoe UI", 19.8000011F)
        txtboxPassADMUS.ForeColor = SystemColors.ActiveCaptionText
        txtboxPassADMUS.Location = New Point(373, 419)
        txtboxPassADMUS.Name = "txtboxPassADMUS"
        txtboxPassADMUS.Size = New Size(382, 51)
        txtboxPassADMUS.TabIndex = 28
        ' 
        ' txtboxCnfrmADMUS
        ' 
        txtboxCnfrmADMUS.Anchor = AnchorStyles.None
        txtboxCnfrmADMUS.Font = New Font("Segoe UI", 19.8000011F)
        txtboxCnfrmADMUS.ForeColor = SystemColors.ActiveCaptionText
        txtboxCnfrmADMUS.Location = New Point(373, 526)
        txtboxCnfrmADMUS.Name = "txtboxCnfrmADMUS"
        txtboxCnfrmADMUS.Size = New Size(382, 51)
        txtboxCnfrmADMUS.TabIndex = 29
        ' 
        ' btnSignupADMSU
        ' 
        btnSignupADMSU.Anchor = AnchorStyles.None
        btnSignupADMSU.BackColor = SystemColors.ActiveCaptionText
        btnSignupADMSU.Cursor = Cursors.Hand
        btnSignupADMSU.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSignupADMSU.ForeColor = SystemColors.ButtonHighlight
        btnSignupADMSU.Location = New Point(794, 507)
        btnSignupADMSU.Name = "btnSignupADMSU"
        btnSignupADMSU.Size = New Size(210, 70)
        btnSignupADMSU.TabIndex = 30
        btnSignupADMSU.Text = "SIGN UP"
        btnSignupADMSU.UseVisualStyleBackColor = False
        ' 
        ' labelADMSU
        ' 
        labelADMSU.Anchor = AnchorStyles.None
        labelADMSU.AutoSize = True
        labelADMSU.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold)
        labelADMSU.Location = New Point(364, 137)
        labelADMSU.Name = "labelADMSU"
        labelADMSU.Size = New Size(196, 50)
        labelADMSU.TabIndex = 31
        labelADMSU.Text = "Username"
        ' 
        ' lblEmailADMSU
        ' 
        lblEmailADMSU.Anchor = AnchorStyles.None
        lblEmailADMSU.AutoSize = True
        lblEmailADMSU.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold)
        lblEmailADMSU.Location = New Point(364, 244)
        lblEmailADMSU.Name = "lblEmailADMSU"
        lblEmailADMSU.Size = New Size(118, 50)
        lblEmailADMSU.TabIndex = 32
        lblEmailADMSU.Text = "Email"
        ' 
        ' lblPassADMSU
        ' 
        lblPassADMSU.Anchor = AnchorStyles.None
        lblPassADMSU.AutoSize = True
        lblPassADMSU.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold)
        lblPassADMSU.Location = New Point(364, 366)
        lblPassADMSU.Name = "lblPassADMSU"
        lblPassADMSU.Size = New Size(187, 50)
        lblPassADMSU.TabIndex = 33
        lblPassADMSU.Text = "Password"
        ' 
        ' lblCPassADMSU
        ' 
        lblCPassADMSU.Anchor = AnchorStyles.None
        lblCPassADMSU.AutoSize = True
        lblCPassADMSU.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold)
        lblCPassADMSU.Location = New Point(364, 473)
        lblCPassADMSU.Name = "lblCPassADMSU"
        lblCPassADMSU.Size = New Size(339, 50)
        lblCPassADMSU.TabIndex = 34
        lblCPassADMSU.Text = "Confirm Password"
        ' 
        ' btnTglPassAD
        ' 
        btnTglPassAD.Anchor = AnchorStyles.None
        btnTglPassAD.BackColor = SystemColors.AppWorkspace
        btnTglPassAD.Font = New Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnTglPassAD.Location = New Point(692, 389)
        btnTglPassAD.Name = "btnTglPassAD"
        btnTglPassAD.Size = New Size(63, 27)
        btnTglPassAD.TabIndex = 35
        btnTglPassAD.Text = "Toggle"
        btnTglPassAD.UseVisualStyleBackColor = False
        ' 
        ' RegisterAdmin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1348, 721)
        Controls.Add(btnTglPassAD)
        Controls.Add(lblCPassADMSU)
        Controls.Add(lblPassADMSU)
        Controls.Add(lblEmailADMSU)
        Controls.Add(labelADMSU)
        Controls.Add(btnSignupADMSU)
        Controls.Add(txtboxCnfrmADMUS)
        Controls.Add(txtboxPassADMUS)
        Controls.Add(txtboxEmailAD)
        Controls.Add(txboxADMUS)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Name = "RegisterAdmin"
        StartPosition = FormStartPosition.CenterScreen
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents txboxADMUS As TextBox
    Friend WithEvents txtboxEmailAD As TextBox
    Friend WithEvents txtboxPassADMUS As TextBox
    Friend WithEvents txtboxCnfrmADMUS As TextBox
    Friend WithEvents btnSignupADMSU As Button
    Friend WithEvents labelADMSU As Label
    Friend WithEvents lblEmailADMSU As Label
    Friend WithEvents lblPassADMSU As Label
    Friend WithEvents lblCPassADMSU As Label
    Friend WithEvents btnTglPassAD As Button
End Class
