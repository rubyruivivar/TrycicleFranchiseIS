<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RenewalData
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        dgvRenewal = New DataGridView()
        btnUpdate = New Button()
        btnDelete = New Button()
        LabelRenewal = New Label()
        lblRecordCount = New Label()
        cbxStatus = New ComboBox()
        cbxComplianceStatus = New ComboBox()
        cbxRenewalType = New ComboBox()
        dtpExpirationDate = New DateTimePicker()
        dtpApprovalDate = New DateTimePicker()
        dtpProcessingDate = New DateTimePicker()
        dtpSubmissionDate = New DateTimePicker()
        txtRenewalNumber = New TextBox()
        txtAuthorityID = New TextBox()
        txtPenaltyFee = New TextBox()
        txtRenewalFee = New TextBox()
        txtFranchiseID = New TextBox()
        txtFranchiseeID = New TextBox()
        CType(dgvRenewal, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvRenewal
        ' 
        dgvRenewal.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvRenewal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvRenewal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRenewal.Location = New Point(32, 356)
        dgvRenewal.Name = "dgvRenewal"
        dgvRenewal.Size = New Size(893, 298)
        dgvRenewal.TabIndex = 0
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.CornflowerBlue
        btnUpdate.FlatAppearance.BorderSize = 0
        btnUpdate.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        btnUpdate.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        btnUpdate.FlatStyle = FlatStyle.Flat
        btnUpdate.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdate.ForeColor = Color.White
        btnUpdate.Location = New Point(134, 275)
        btnUpdate.Margin = New Padding(3, 2, 3, 2)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(125, 28)
        btnUpdate.TabIndex = 30
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.CornflowerBlue
        btnDelete.FlatAppearance.BorderSize = 0
        btnDelete.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.ForeColor = Color.White
        btnDelete.Location = New Point(305, 275)
        btnDelete.Margin = New Padding(3, 2, 3, 2)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(125, 28)
        btnDelete.TabIndex = 31
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' LabelRenewal
        ' 
        LabelRenewal.AutoSize = True
        LabelRenewal.FlatStyle = FlatStyle.Flat
        LabelRenewal.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelRenewal.Location = New Point(31, 13)
        LabelRenewal.Name = "LabelRenewal"
        LabelRenewal.Size = New Size(201, 21)
        LabelRenewal.TabIndex = 32
        LabelRenewal.Text = "RENEWAL INFORMATION"
        ' 
        ' lblRecordCount
        ' 
        lblRecordCount.AutoSize = True
        lblRecordCount.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRecordCount.Location = New Point(32, 338)
        lblRecordCount.Name = "lblRecordCount"
        lblRecordCount.Size = New Size(43, 15)
        lblRecordCount.TabIndex = 48
        lblRecordCount.Text = "Label2"
        ' 
        ' cbxStatus
        ' 
        cbxStatus.FormattingEnabled = True
        cbxStatus.Items.AddRange(New Object() {"approved", "denied", "pending"})
        cbxStatus.Location = New Point(276, 98)
        cbxStatus.Name = "cbxStatus"
        cbxStatus.Size = New Size(218, 23)
        cbxStatus.TabIndex = 81
        ' 
        ' cbxComplianceStatus
        ' 
        cbxComplianceStatus.FormattingEnabled = True
        cbxComplianceStatus.Items.AddRange(New Object() {"compliant", "non-compliant"})
        cbxComplianceStatus.Location = New Point(276, 71)
        cbxComplianceStatus.Name = "cbxComplianceStatus"
        cbxComplianceStatus.Size = New Size(218, 23)
        cbxComplianceStatus.TabIndex = 80
        ' 
        ' cbxRenewalType
        ' 
        cbxRenewalType.FormattingEnabled = True
        cbxRenewalType.Items.AddRange(New Object() {"annual", "semi-annual"})
        cbxRenewalType.Location = New Point(31, 233)
        cbxRenewalType.Name = "cbxRenewalType"
        cbxRenewalType.Size = New Size(218, 23)
        cbxRenewalType.TabIndex = 79
        ' 
        ' dtpExpirationDate
        ' 
        dtpExpirationDate.Location = New Point(31, 207)
        dtpExpirationDate.Name = "dtpExpirationDate"
        dtpExpirationDate.Size = New Size(218, 23)
        dtpExpirationDate.TabIndex = 78
        ' 
        ' dtpApprovalDate
        ' 
        dtpApprovalDate.Location = New Point(31, 180)
        dtpApprovalDate.Name = "dtpApprovalDate"
        dtpApprovalDate.Size = New Size(218, 23)
        dtpApprovalDate.TabIndex = 77
        ' 
        ' dtpProcessingDate
        ' 
        dtpProcessingDate.Location = New Point(31, 153)
        dtpProcessingDate.Name = "dtpProcessingDate"
        dtpProcessingDate.Size = New Size(218, 23)
        dtpProcessingDate.TabIndex = 76
        ' 
        ' dtpSubmissionDate
        ' 
        dtpSubmissionDate.Location = New Point(31, 126)
        dtpSubmissionDate.Name = "dtpSubmissionDate"
        dtpSubmissionDate.Size = New Size(218, 23)
        dtpSubmissionDate.TabIndex = 75
        ' 
        ' txtRenewalNumber
        ' 
        txtRenewalNumber.Location = New Point(276, 126)
        txtRenewalNumber.Margin = New Padding(3, 2, 3, 2)
        txtRenewalNumber.Name = "txtRenewalNumber"
        txtRenewalNumber.PlaceholderText = "Renewal Number"
        txtRenewalNumber.Size = New Size(218, 23)
        txtRenewalNumber.TabIndex = 74
        ' 
        ' txtAuthorityID
        ' 
        txtAuthorityID.Location = New Point(275, 207)
        txtAuthorityID.Margin = New Padding(3, 2, 3, 2)
        txtAuthorityID.Name = "txtAuthorityID"
        txtAuthorityID.PlaceholderText = "Authority ID"
        txtAuthorityID.Size = New Size(219, 23)
        txtAuthorityID.TabIndex = 73
        ' 
        ' txtPenaltyFee
        ' 
        txtPenaltyFee.Location = New Point(275, 180)
        txtPenaltyFee.Margin = New Padding(3, 2, 3, 2)
        txtPenaltyFee.Name = "txtPenaltyFee"
        txtPenaltyFee.PlaceholderText = "Penalty Fee"
        txtPenaltyFee.Size = New Size(219, 23)
        txtPenaltyFee.TabIndex = 72
        ' 
        ' txtRenewalFee
        ' 
        txtRenewalFee.Location = New Point(275, 153)
        txtRenewalFee.Margin = New Padding(3, 2, 3, 2)
        txtRenewalFee.Name = "txtRenewalFee"
        txtRenewalFee.PlaceholderText = "Renewal Fee"
        txtRenewalFee.Size = New Size(219, 23)
        txtRenewalFee.TabIndex = 71
        ' 
        ' txtFranchiseID
        ' 
        txtFranchiseID.Location = New Point(31, 71)
        txtFranchiseID.Margin = New Padding(3, 2, 3, 2)
        txtFranchiseID.Name = "txtFranchiseID"
        txtFranchiseID.PlaceholderText = "Franchisee ID"
        txtFranchiseID.Size = New Size(218, 23)
        txtFranchiseID.TabIndex = 70
        ' 
        ' txtFranchiseeID
        ' 
        txtFranchiseeID.Location = New Point(31, 98)
        txtFranchiseeID.Margin = New Padding(3, 2, 3, 2)
        txtFranchiseeID.Name = "txtFranchiseeID"
        txtFranchiseeID.PlaceholderText = "Franchise ID"
        txtFranchiseeID.Size = New Size(218, 23)
        txtFranchiseeID.TabIndex = 69
        ' 
        ' RenewalData
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.RosyBrown
        Controls.Add(cbxStatus)
        Controls.Add(cbxComplianceStatus)
        Controls.Add(cbxRenewalType)
        Controls.Add(dtpExpirationDate)
        Controls.Add(dtpApprovalDate)
        Controls.Add(dtpProcessingDate)
        Controls.Add(dtpSubmissionDate)
        Controls.Add(txtRenewalNumber)
        Controls.Add(txtAuthorityID)
        Controls.Add(txtPenaltyFee)
        Controls.Add(txtRenewalFee)
        Controls.Add(txtFranchiseID)
        Controls.Add(txtFranchiseeID)
        Controls.Add(lblRecordCount)
        Controls.Add(LabelRenewal)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(dgvRenewal)
        Name = "RenewalData"
        Size = New Size(949, 678)
        CType(dgvRenewal, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvRenewal As DataGridView
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents LabelRenewal As Label
    Friend WithEvents lblRecordCount As Label
    Friend WithEvents cbxStatus As ComboBox
    Friend WithEvents cbxComplianceStatus As ComboBox
    Friend WithEvents cbxRenewalType As ComboBox
    Friend WithEvents dtpExpirationDate As DateTimePicker
    Friend WithEvents dtpApprovalDate As DateTimePicker
    Friend WithEvents dtpProcessingDate As DateTimePicker
    Friend WithEvents dtpSubmissionDate As DateTimePicker
    Friend WithEvents txtRenewalNumber As TextBox
    Friend WithEvents txtAuthorityID As TextBox
    Friend WithEvents txtPenaltyFee As TextBox
    Friend WithEvents txtRenewalFee As TextBox
    Friend WithEvents txtFranchiseID As TextBox
    Friend WithEvents txtFranchiseeID As TextBox

End Class
