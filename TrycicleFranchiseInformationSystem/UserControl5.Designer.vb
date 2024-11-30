<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5Renewal
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        LabelRenewal = New Label()
        cbxStatus = New ComboBox()
        cbxComplianceStatus = New ComboBox()
        cbxRenewalType = New ComboBox()
        txtRenewalNumber = New TextBox()
        txtAuthorityID = New TextBox()
        txtPenaltyFee = New TextBox()
        txtRenewalFee = New TextBox()
        txtFranchiseeID = New TextBox()
        txtFranchiseID = New TextBox()
        btnSave = New Button()
        dtpExpirationDate = New DateTimePicker()
        dtpApprovalDate = New DateTimePicker()
        dtpProcessingDate = New DateTimePicker()
        dtpSubmissionDate = New DateTimePicker()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' LabelRenewal
        ' 
        LabelRenewal.AutoSize = True
        LabelRenewal.FlatStyle = FlatStyle.Flat
        LabelRenewal.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelRenewal.Location = New Point(194, 8)
        LabelRenewal.Name = "LabelRenewal"
        LabelRenewal.Size = New Size(201, 21)
        LabelRenewal.TabIndex = 0
        LabelRenewal.Text = "RENEWAL INFORMATION"
        ' 
        ' cbxStatus
        ' 
        cbxStatus.FormattingEnabled = True
        cbxStatus.Items.AddRange(New Object() {"approved", "denied", "pending"})
        cbxStatus.Location = New Point(59, 147)
        cbxStatus.Name = "cbxStatus"
        cbxStatus.Size = New Size(218, 23)
        cbxStatus.TabIndex = 68
        ' 
        ' cbxComplianceStatus
        ' 
        cbxComplianceStatus.FormattingEnabled = True
        cbxComplianceStatus.Items.AddRange(New Object() {"compliant", "non-compliant"})
        cbxComplianceStatus.Location = New Point(59, 120)
        cbxComplianceStatus.Name = "cbxComplianceStatus"
        cbxComplianceStatus.Size = New Size(218, 23)
        cbxComplianceStatus.TabIndex = 67
        ' 
        ' cbxRenewalType
        ' 
        cbxRenewalType.FormattingEnabled = True
        cbxRenewalType.Items.AddRange(New Object() {"annual", "semi-annual"})
        cbxRenewalType.Location = New Point(59, 93)
        cbxRenewalType.Name = "cbxRenewalType"
        cbxRenewalType.Size = New Size(218, 23)
        cbxRenewalType.TabIndex = 66
        ' 
        ' txtRenewalNumber
        ' 
        txtRenewalNumber.Location = New Point(60, 175)
        txtRenewalNumber.Margin = New Padding(3, 2, 3, 2)
        txtRenewalNumber.Name = "txtRenewalNumber"
        txtRenewalNumber.PlaceholderText = "Renewal Number"
        txtRenewalNumber.Size = New Size(218, 23)
        txtRenewalNumber.TabIndex = 61
        ' 
        ' txtAuthorityID
        ' 
        txtAuthorityID.Location = New Point(302, 39)
        txtAuthorityID.Margin = New Padding(3, 2, 3, 2)
        txtAuthorityID.Name = "txtAuthorityID"
        txtAuthorityID.PlaceholderText = "Authority ID"
        txtAuthorityID.Size = New Size(219, 23)
        txtAuthorityID.TabIndex = 60
        ' 
        ' txtPenaltyFee
        ' 
        txtPenaltyFee.Location = New Point(59, 229)
        txtPenaltyFee.Margin = New Padding(3, 2, 3, 2)
        txtPenaltyFee.Name = "txtPenaltyFee"
        txtPenaltyFee.PlaceholderText = "Penalty Fee"
        txtPenaltyFee.Size = New Size(219, 23)
        txtPenaltyFee.TabIndex = 59
        ' 
        ' txtRenewalFee
        ' 
        txtRenewalFee.Location = New Point(59, 202)
        txtRenewalFee.Margin = New Padding(3, 2, 3, 2)
        txtRenewalFee.Name = "txtRenewalFee"
        txtRenewalFee.PlaceholderText = "Renewal Fee"
        txtRenewalFee.Size = New Size(219, 23)
        txtRenewalFee.TabIndex = 58
        ' 
        ' txtFranchiseeID
        ' 
        txtFranchiseeID.Location = New Point(59, 66)
        txtFranchiseeID.Margin = New Padding(3, 2, 3, 2)
        txtFranchiseeID.Name = "txtFranchiseeID"
        txtFranchiseeID.PlaceholderText = "Franchisee ID"
        txtFranchiseeID.Size = New Size(218, 23)
        txtFranchiseeID.TabIndex = 57
        ' 
        ' txtFranchiseID
        ' 
        txtFranchiseID.Location = New Point(59, 39)
        txtFranchiseID.Margin = New Padding(3, 2, 3, 2)
        txtFranchiseID.Name = "txtFranchiseID"
        txtFranchiseID.PlaceholderText = "Franchise ID"
        txtFranchiseID.Size = New Size(218, 23)
        txtFranchiseID.TabIndex = 56
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.CornflowerBlue
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(396, 270)
        btnSave.Margin = New Padding(3, 2, 3, 2)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(125, 28)
        btnSave.TabIndex = 69
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' dtpExpirationDate
        ' 
        dtpExpirationDate.Location = New Point(302, 203)
        dtpExpirationDate.Name = "dtpExpirationDate"
        dtpExpirationDate.Size = New Size(218, 23)
        dtpExpirationDate.TabIndex = 82
        ' 
        ' dtpApprovalDate
        ' 
        dtpApprovalDate.Location = New Point(303, 162)
        dtpApprovalDate.Name = "dtpApprovalDate"
        dtpApprovalDate.Size = New Size(218, 23)
        dtpApprovalDate.TabIndex = 81
        ' 
        ' dtpProcessingDate
        ' 
        dtpProcessingDate.Location = New Point(302, 121)
        dtpProcessingDate.Name = "dtpProcessingDate"
        dtpProcessingDate.Size = New Size(218, 23)
        dtpProcessingDate.TabIndex = 80
        ' 
        ' dtpSubmissionDate
        ' 
        dtpSubmissionDate.Location = New Point(302, 79)
        dtpSubmissionDate.Name = "dtpSubmissionDate"
        dtpSubmissionDate.Size = New Size(218, 23)
        dtpSubmissionDate.TabIndex = 79
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(303, 186)
        Label4.Name = "Label4"
        Label4.Size = New Size(101, 17)
        Label4.TabIndex = 89
        Label4.Text = "Expiration Date"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(303, 145)
        Label3.Name = "Label3"
        Label3.Size = New Size(95, 17)
        Label3.TabIndex = 88
        Label3.Text = "Approval Date"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(303, 104)
        Label2.Name = "Label2"
        Label2.Size = New Size(105, 17)
        Label2.TabIndex = 87
        Label2.Text = "Processing Date"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(303, 62)
        Label1.Name = "Label1"
        Label1.Size = New Size(109, 17)
        Label1.TabIndex = 86
        Label1.Text = "Submission Date"
        ' 
        ' Form5Renewal
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = Color.RosyBrown
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(dtpExpirationDate)
        Controls.Add(dtpApprovalDate)
        Controls.Add(dtpProcessingDate)
        Controls.Add(dtpSubmissionDate)
        Controls.Add(btnSave)
        Controls.Add(cbxStatus)
        Controls.Add(cbxComplianceStatus)
        Controls.Add(cbxRenewalType)
        Controls.Add(txtRenewalNumber)
        Controls.Add(txtAuthorityID)
        Controls.Add(txtPenaltyFee)
        Controls.Add(txtRenewalFee)
        Controls.Add(txtFranchiseeID)
        Controls.Add(txtFranchiseID)
        Controls.Add(LabelRenewal)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form5Renewal"
        Size = New Size(594, 461)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LabelRenewal As Label
    Friend WithEvents cbxStatus As ComboBox
    Friend WithEvents cbxComplianceStatus As ComboBox
    Friend WithEvents cbxRenewalType As ComboBox
    Friend WithEvents txtRenewalNumber As TextBox
    Friend WithEvents txtAuthorityID As TextBox
    Friend WithEvents txtPenaltyFee As TextBox
    Friend WithEvents txtRenewalFee As TextBox
    Friend WithEvents txtFranchiseeID As TextBox
    Friend WithEvents txtFranchiseID As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents dtpExpirationDate As DateTimePicker
    Friend WithEvents dtpApprovalDate As DateTimePicker
    Friend WithEvents dtpProcessingDate As DateTimePicker
    Friend WithEvents dtpSubmissionDate As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label

End Class
