<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginFranchiseeSU
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
        labelFIDSI = New Label()
        labelNameSI = New Label()
        txboxFNAMSI = New TextBox()
        txboxMNAMSI = New TextBox()
        txboxLNAMSI = New TextBox()
        labelPNUMSI = New Label()
        txboxPNUMSI = New TextBox()
        txtboxPrvnce = New TextBox()
        txtboxMncplty = New TextBox()
        labelAddressSI = New Label()
        txtboxBrngy = New TextBox()
        txtbxZipCod = New TextBox()
        labelBirthDateSI = New Label()
        labelGender = New Label()
        btnSignupSi = New Button()
        combbxGender = New ComboBox()
        dtmepickerDOBSI = New DateTimePicker()
        txtboxPassSI = New TextBox()
        txtboxConfirmPass = New TextBox()
        labelPassSI = New Label()
        labelCPassSI = New Label()
        btnTogglePassword = New Button()
        mtxboxFID = New MaskedTextBox()
        Panel1.SuspendLayout()
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
        Panel1.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
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
        Panel2.TabIndex = 5
        ' 
        ' labelFIDSI
        ' 
        labelFIDSI.Anchor = AnchorStyles.None
        labelFIDSI.AutoSize = True
        labelFIDSI.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold)
        labelFIDSI.Location = New Point(95, 69)
        labelFIDSI.Name = "labelFIDSI"
        labelFIDSI.Size = New Size(254, 50)
        labelFIDSI.TabIndex = 7
        labelFIDSI.Text = "Franchisee ID"
        ' 
        ' labelNameSI
        ' 
        labelNameSI.Anchor = AnchorStyles.None
        labelNameSI.AutoSize = True
        labelNameSI.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold)
        labelNameSI.Location = New Point(95, 190)
        labelNameSI.Name = "labelNameSI"
        labelNameSI.Size = New Size(125, 50)
        labelNameSI.TabIndex = 9
        labelNameSI.Text = "Name"
        ' 
        ' txboxFNAMSI
        ' 
        txboxFNAMSI.Anchor = AnchorStyles.None
        txboxFNAMSI.Font = New Font("Segoe UI", 19.8000011F)
        txboxFNAMSI.ForeColor = SystemColors.AppWorkspace
        txboxFNAMSI.Location = New Point(103, 244)
        txboxFNAMSI.Name = "txboxFNAMSI"
        txboxFNAMSI.Size = New Size(557, 51)
        txboxFNAMSI.TabIndex = 8
        txboxFNAMSI.Text = "First Name"
        ' 
        ' txboxMNAMSI
        ' 
        txboxMNAMSI.Anchor = AnchorStyles.None
        txboxMNAMSI.Font = New Font("Segoe UI", 19.8000011F)
        txboxMNAMSI.ForeColor = SystemColors.AppWorkspace
        txboxMNAMSI.Location = New Point(103, 301)
        txboxMNAMSI.Name = "txboxMNAMSI"
        txboxMNAMSI.Size = New Size(557, 51)
        txboxMNAMSI.TabIndex = 10
        txboxMNAMSI.Text = "Middle Name (Optional)"
        ' 
        ' txboxLNAMSI
        ' 
        txboxLNAMSI.Anchor = AnchorStyles.None
        txboxLNAMSI.Font = New Font("Segoe UI", 19.8000011F)
        txboxLNAMSI.ForeColor = SystemColors.AppWorkspace
        txboxLNAMSI.Location = New Point(103, 358)
        txboxLNAMSI.Name = "txboxLNAMSI"
        txboxLNAMSI.Size = New Size(557, 51)
        txboxLNAMSI.TabIndex = 11
        txboxLNAMSI.Text = "Last Name"
        ' 
        ' labelPNUMSI
        ' 
        labelPNUMSI.Anchor = AnchorStyles.None
        labelPNUMSI.AutoSize = True
        labelPNUMSI.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold)
        labelPNUMSI.Location = New Point(690, 69)
        labelPNUMSI.Name = "labelPNUMSI"
        labelPNUMSI.Size = New Size(285, 50)
        labelPNUMSI.TabIndex = 13
        labelPNUMSI.Text = "Phone Number"
        ' 
        ' txboxPNUMSI
        ' 
        txboxPNUMSI.Anchor = AnchorStyles.None
        txboxPNUMSI.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txboxPNUMSI.ForeColor = SystemColors.AppWorkspace
        txboxPNUMSI.Location = New Point(702, 122)
        txboxPNUMSI.Name = "txboxPNUMSI"
        txboxPNUMSI.Size = New Size(342, 51)
        txboxPNUMSI.TabIndex = 12
        txboxPNUMSI.Text = "09XXXXXXXXX"
        ' 
        ' txtboxPrvnce
        ' 
        txtboxPrvnce.Anchor = AnchorStyles.None
        txtboxPrvnce.Font = New Font("Segoe UI", 19.8000011F)
        txtboxPrvnce.ForeColor = SystemColors.AppWorkspace
        txtboxPrvnce.Location = New Point(702, 244)
        txtboxPrvnce.Name = "txtboxPrvnce"
        txtboxPrvnce.Size = New Size(557, 51)
        txtboxPrvnce.TabIndex = 17
        txtboxPrvnce.Text = "Province"
        ' 
        ' txtboxMncplty
        ' 
        txtboxMncplty.Anchor = AnchorStyles.None
        txtboxMncplty.Font = New Font("Segoe UI", 19.8000011F)
        txtboxMncplty.ForeColor = SystemColors.AppWorkspace
        txtboxMncplty.Location = New Point(702, 301)
        txtboxMncplty.Name = "txtboxMncplty"
        txtboxMncplty.Size = New Size(557, 51)
        txtboxMncplty.TabIndex = 16
        txtboxMncplty.Text = "Municipality"
        ' 
        ' labelAddressSI
        ' 
        labelAddressSI.Anchor = AnchorStyles.None
        labelAddressSI.AutoSize = True
        labelAddressSI.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold)
        labelAddressSI.Location = New Point(690, 190)
        labelAddressSI.Name = "labelAddressSI"
        labelAddressSI.Size = New Size(161, 50)
        labelAddressSI.TabIndex = 15
        labelAddressSI.Text = "Address"
        ' 
        ' txtboxBrngy
        ' 
        txtboxBrngy.Anchor = AnchorStyles.None
        txtboxBrngy.Font = New Font("Segoe UI", 19.8000011F)
        txtboxBrngy.ForeColor = SystemColors.AppWorkspace
        txtboxBrngy.Location = New Point(702, 358)
        txtboxBrngy.Name = "txtboxBrngy"
        txtboxBrngy.Size = New Size(557, 51)
        txtboxBrngy.TabIndex = 14
        txtboxBrngy.Text = "Barangay"
        ' 
        ' txtbxZipCod
        ' 
        txtbxZipCod.Anchor = AnchorStyles.None
        txtbxZipCod.Font = New Font("Segoe UI", 19.8000011F)
        txtbxZipCod.ForeColor = SystemColors.AppWorkspace
        txtbxZipCod.Location = New Point(702, 415)
        txtbxZipCod.Name = "txtbxZipCod"
        txtbxZipCod.Size = New Size(557, 51)
        txtbxZipCod.TabIndex = 18
        txtbxZipCod.Text = "Zip Code"
        ' 
        ' labelBirthDateSI
        ' 
        labelBirthDateSI.Anchor = AnchorStyles.None
        labelBirthDateSI.AutoSize = True
        labelBirthDateSI.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold)
        labelBirthDateSI.Location = New Point(95, 416)
        labelBirthDateSI.Name = "labelBirthDateSI"
        labelBirthDateSI.Size = New Size(246, 50)
        labelBirthDateSI.TabIndex = 20
        labelBirthDateSI.Text = "Date of Birth"
        ' 
        ' labelGender
        ' 
        labelGender.Anchor = AnchorStyles.None
        labelGender.AutoSize = True
        labelGender.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold)
        labelGender.Location = New Point(414, 415)
        labelGender.Name = "labelGender"
        labelGender.Size = New Size(148, 50)
        labelGender.TabIndex = 22
        labelGender.Text = "Gender"
        ' 
        ' btnSignupSi
        ' 
        btnSignupSi.Anchor = AnchorStyles.None
        btnSignupSi.BackColor = SystemColors.ActiveCaptionText
        btnSignupSi.Cursor = Cursors.Hand
        btnSignupSi.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSignupSi.ForeColor = SystemColors.ButtonHighlight
        btnSignupSi.Location = New Point(1049, 584)
        btnSignupSi.Name = "btnSignupSi"
        btnSignupSi.Size = New Size(210, 70)
        btnSignupSi.TabIndex = 24
        btnSignupSi.Text = "SIGN UP"
        btnSignupSi.UseVisualStyleBackColor = False
        ' 
        ' combbxGender
        ' 
        combbxGender.Anchor = AnchorStyles.None
        combbxGender.Font = New Font("Segoe UI", 19.8000011F)
        combbxGender.FormattingEnabled = True
        combbxGender.Location = New Point(414, 467)
        combbxGender.Name = "combbxGender"
        combbxGender.Size = New Size(246, 53)
        combbxGender.TabIndex = 25
        ' 
        ' dtmepickerDOBSI
        ' 
        dtmepickerDOBSI.Anchor = AnchorStyles.None
        dtmepickerDOBSI.CalendarFont = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtmepickerDOBSI.Font = New Font("Segoe UI", 19.8000011F)
        dtmepickerDOBSI.Location = New Point(103, 469)
        dtmepickerDOBSI.Name = "dtmepickerDOBSI"
        dtmepickerDOBSI.Size = New Size(246, 51)
        dtmepickerDOBSI.TabIndex = 26
        ' 
        ' txtboxPassSI
        ' 
        txtboxPassSI.Anchor = AnchorStyles.None
        txtboxPassSI.Font = New Font("Segoe UI", 19.8000011F)
        txtboxPassSI.ForeColor = SystemColors.ActiveCaptionText
        txtboxPassSI.Location = New Point(103, 603)
        txtboxPassSI.Name = "txtboxPassSI"
        txtboxPassSI.Size = New Size(382, 51)
        txtboxPassSI.TabIndex = 27
        ' 
        ' txtboxConfirmPass
        ' 
        txtboxConfirmPass.Anchor = AnchorStyles.None
        txtboxConfirmPass.Font = New Font("Segoe UI", 19.8000011F)
        txtboxConfirmPass.ForeColor = SystemColors.ActiveCaptionText
        txtboxConfirmPass.Location = New Point(502, 603)
        txtboxConfirmPass.Name = "txtboxConfirmPass"
        txtboxConfirmPass.Size = New Size(382, 51)
        txtboxConfirmPass.TabIndex = 28
        ' 
        ' labelPassSI
        ' 
        labelPassSI.Anchor = AnchorStyles.None
        labelPassSI.AutoSize = True
        labelPassSI.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold)
        labelPassSI.Location = New Point(103, 550)
        labelPassSI.Name = "labelPassSI"
        labelPassSI.Size = New Size(187, 50)
        labelPassSI.TabIndex = 29
        labelPassSI.Text = "Password"
        ' 
        ' labelCPassSI
        ' 
        labelCPassSI.Anchor = AnchorStyles.None
        labelCPassSI.AutoSize = True
        labelCPassSI.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold)
        labelCPassSI.Location = New Point(502, 550)
        labelCPassSI.Name = "labelCPassSI"
        labelCPassSI.Size = New Size(339, 50)
        labelCPassSI.TabIndex = 30
        labelCPassSI.Text = "Confirm Password"
        ' 
        ' btnTogglePassword
        ' 
        btnTogglePassword.Anchor = AnchorStyles.None
        btnTogglePassword.BackColor = SystemColors.AppWorkspace
        btnTogglePassword.Font = New Font("Segoe UI Light", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnTogglePassword.Location = New Point(422, 571)
        btnTogglePassword.Name = "btnTogglePassword"
        btnTogglePassword.Size = New Size(63, 27)
        btnTogglePassword.TabIndex = 31
        btnTogglePassword.Text = "Toggle"
        btnTogglePassword.UseVisualStyleBackColor = False
        ' 
        ' mtxboxFID
        ' 
        mtxboxFID.Anchor = AnchorStyles.None
        mtxboxFID.Cursor = Cursors.IBeam
        mtxboxFID.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        mtxboxFID.Location = New Point(103, 122)
        mtxboxFID.Mask = "00-000"
        mtxboxFID.Name = "mtxboxFID"
        mtxboxFID.PromptChar = "X"c
        mtxboxFID.Size = New Size(557, 51)
        mtxboxFID.TabIndex = 32
        ' 
        ' LoginFranchiseeSU
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1348, 721)
        Controls.Add(mtxboxFID)
        Controls.Add(btnTogglePassword)
        Controls.Add(labelCPassSI)
        Controls.Add(labelPassSI)
        Controls.Add(txtboxConfirmPass)
        Controls.Add(txtboxPassSI)
        Controls.Add(dtmepickerDOBSI)
        Controls.Add(combbxGender)
        Controls.Add(btnSignupSi)
        Controls.Add(labelGender)
        Controls.Add(labelBirthDateSI)
        Controls.Add(txtbxZipCod)
        Controls.Add(txtboxPrvnce)
        Controls.Add(txtboxMncplty)
        Controls.Add(labelAddressSI)
        Controls.Add(txtboxBrngy)
        Controls.Add(labelPNUMSI)
        Controls.Add(txboxPNUMSI)
        Controls.Add(txboxLNAMSI)
        Controls.Add(txboxMNAMSI)
        Controls.Add(labelNameSI)
        Controls.Add(txboxFNAMSI)
        Controls.Add(labelFIDSI)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "LoginFranchiseeSU"
        StartPosition = FormStartPosition.CenterScreen
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents labelFIDSI As Label
    Friend WithEvents labelNameSI As Label
    Friend WithEvents txboxFNAMSI As TextBox
    Friend WithEvents txboxMNAMSI As TextBox
    Friend WithEvents txboxLNAMSI As TextBox
    Friend WithEvents labelPNUMSI As Label
    Friend WithEvents txboxPNUMSI As TextBox
    Friend WithEvents txtboxPrvnce As TextBox
    Friend WithEvents txtboxMncplty As TextBox
    Friend WithEvents labelAddressSI As Label
    Friend WithEvents txtboxBrngy As TextBox
    Friend WithEvents txtbxZipCod As TextBox
    Friend WithEvents labelBirthDateSI As Label
    Friend WithEvents labelGender As Label
    Friend WithEvents btnSignupSi As Button
    Friend WithEvents combbxGender As ComboBox
    Friend WithEvents dtmepickerDOBSI As DateTimePicker
    Friend WithEvents txtboxPassSI As TextBox
    Friend WithEvents txtboxConfirmPass As TextBox
    Friend WithEvents labelPassSI As Label
    Friend WithEvents labelCPassSI As Label
    Friend WithEvents btnTogglePassword As Button
    Friend WithEvents mtxboxFID As MaskedTextBox
    Friend WithEvents Label3 As Label
End Class
