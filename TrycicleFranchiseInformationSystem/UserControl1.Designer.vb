<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2franchise
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
        tbFranchiseDuration = New TextBox()
        tbLicenseNumber = New TextBox()
        tbRoute = New TextBox()
        tbTotalViolations = New TextBox()
        tbFeePaid = New TextBox()
        tbAssociation = New TextBox()
        tbVehicleID = New TextBox()
        btnSave = New Button()
        tbFranchiseeID = New TextBox()
        cbxArea = New ComboBox()
        cbxFranchiseType = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        Label5 = New Label()
        dtpExpirationDate = New DateTimePicker()
        dtpLastRenewalDate = New DateTimePicker()
        dtpDateIssued = New DateTimePicker()
        cbxStatus = New ComboBox()
        LabelVehicle_Regulatory = New Label()
        Panel1 = New Panel()
        btnSearch = New Button()
        txtSearch = New TextBox()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' tbFranchiseDuration
        ' 
        tbFranchiseDuration.Location = New Point(286, 205)
        tbFranchiseDuration.Margin = New Padding(3, 2, 3, 2)
        tbFranchiseDuration.Name = "tbFranchiseDuration"
        tbFranchiseDuration.PlaceholderText = "Franchise Duration"
        tbFranchiseDuration.ReadOnly = True
        tbFranchiseDuration.Size = New Size(218, 23)
        tbFranchiseDuration.TabIndex = 43
        ' 
        ' tbLicenseNumber
        ' 
        tbLicenseNumber.Location = New Point(53, 166)
        tbLicenseNumber.Margin = New Padding(3, 2, 3, 2)
        tbLicenseNumber.Name = "tbLicenseNumber"
        tbLicenseNumber.PlaceholderText = "License Number"
        tbLicenseNumber.ReadOnly = True
        tbLicenseNumber.Size = New Size(218, 23)
        tbLicenseNumber.TabIndex = 42
        ' 
        ' tbRoute
        ' 
        tbRoute.Location = New Point(53, 220)
        tbRoute.Margin = New Padding(3, 2, 3, 2)
        tbRoute.Name = "tbRoute"
        tbRoute.PlaceholderText = "Route"
        tbRoute.ReadOnly = True
        tbRoute.Size = New Size(218, 23)
        tbRoute.TabIndex = 41
        ' 
        ' tbTotalViolations
        ' 
        tbTotalViolations.Location = New Point(286, 57)
        tbTotalViolations.Margin = New Padding(3, 2, 3, 2)
        tbTotalViolations.Name = "tbTotalViolations"
        tbTotalViolations.PlaceholderText = "Total Violations"
        tbTotalViolations.ReadOnly = True
        tbTotalViolations.Size = New Size(218, 23)
        tbTotalViolations.TabIndex = 37
        ' 
        ' tbFeePaid
        ' 
        tbFeePaid.Location = New Point(286, 231)
        tbFeePaid.Margin = New Padding(3, 2, 3, 2)
        tbFeePaid.Name = "tbFeePaid"
        tbFeePaid.PlaceholderText = "Fee Paid"
        tbFeePaid.ReadOnly = True
        tbFeePaid.Size = New Size(218, 23)
        tbFeePaid.TabIndex = 35
        ' 
        ' tbAssociation
        ' 
        tbAssociation.Location = New Point(53, 247)
        tbAssociation.Margin = New Padding(3, 2, 3, 2)
        tbAssociation.Name = "tbAssociation"
        tbAssociation.PlaceholderText = "Association"
        tbAssociation.ReadOnly = True
        tbAssociation.Size = New Size(218, 23)
        tbAssociation.TabIndex = 33
        ' 
        ' tbVehicleID
        ' 
        tbVehicleID.Location = New Point(53, 111)
        tbVehicleID.Margin = New Padding(3, 2, 3, 2)
        tbVehicleID.Name = "tbVehicleID"
        tbVehicleID.PlaceholderText = "Vehicle ID"
        tbVehicleID.ReadOnly = True
        tbVehicleID.Size = New Size(218, 23)
        tbVehicleID.TabIndex = 31
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.CornflowerBlue
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(429, 280)
        btnSave.Margin = New Padding(3, 2, 3, 2)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(125, 28)
        btnSave.TabIndex = 44
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' tbFranchiseeID
        ' 
        tbFranchiseeID.Location = New Point(53, 57)
        tbFranchiseeID.Margin = New Padding(3, 2, 3, 2)
        tbFranchiseeID.Name = "tbFranchiseeID"
        tbFranchiseeID.PlaceholderText = "Franchisee ID"
        tbFranchiseeID.ReadOnly = True
        tbFranchiseeID.Size = New Size(218, 23)
        tbFranchiseeID.TabIndex = 46
        ' 
        ' cbxArea
        ' 
        cbxArea.FormattingEnabled = True
        cbxArea.Items.AddRange(New Object() {"approved", "denied", "pending"})
        cbxArea.Location = New Point(53, 194)
        cbxArea.Name = "cbxArea"
        cbxArea.Size = New Size(218, 23)
        cbxArea.TabIndex = 76
        ' 
        ' cbxFranchiseType
        ' 
        cbxFranchiseType.FormattingEnabled = True
        cbxFranchiseType.Items.AddRange(New Object() {"compliant", "non-compliant"})
        cbxFranchiseType.Location = New Point(53, 84)
        cbxFranchiseType.Name = "cbxFranchiseType"
        cbxFranchiseType.Size = New Size(218, 23)
        cbxFranchiseType.TabIndex = 75
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(286, 162)
        Label1.Name = "Label1"
        Label1.Size = New Size(118, 17)
        Label1.TabIndex = 92
        Label1.Text = "Last Renewal Date"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(286, 121)
        Label2.Name = "Label2"
        Label2.Size = New Size(101, 17)
        Label2.TabIndex = 91
        Label2.Text = "Expiration Date"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(286, 79)
        Label5.Name = "Label5"
        Label5.Size = New Size(79, 17)
        Label5.TabIndex = 90
        Label5.Text = "Date Issued"
        ' 
        ' dtpExpirationDate
        ' 
        dtpExpirationDate.Location = New Point(286, 138)
        dtpExpirationDate.Name = "dtpExpirationDate"
        dtpExpirationDate.Size = New Size(218, 23)
        dtpExpirationDate.TabIndex = 88
        ' 
        ' dtpLastRenewalDate
        ' 
        dtpLastRenewalDate.Location = New Point(286, 179)
        dtpLastRenewalDate.Name = "dtpLastRenewalDate"
        dtpLastRenewalDate.Size = New Size(218, 23)
        dtpLastRenewalDate.TabIndex = 87
        ' 
        ' dtpDateIssued
        ' 
        dtpDateIssued.Location = New Point(286, 96)
        dtpDateIssued.Name = "dtpDateIssued"
        dtpDateIssued.Size = New Size(218, 23)
        dtpDateIssued.TabIndex = 86
        ' 
        ' cbxStatus
        ' 
        cbxStatus.FormattingEnabled = True
        cbxStatus.Items.AddRange(New Object() {"approved", "denied", "pending"})
        cbxStatus.Location = New Point(53, 138)
        cbxStatus.Name = "cbxStatus"
        cbxStatus.Size = New Size(218, 23)
        cbxStatus.TabIndex = 93
        ' 
        ' LabelVehicle_Regulatory
        ' 
        LabelVehicle_Regulatory.AutoSize = True
        LabelVehicle_Regulatory.BackColor = Color.Transparent
        LabelVehicle_Regulatory.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelVehicle_Regulatory.ForeColor = Color.White
        LabelVehicle_Regulatory.Location = New Point(18, 12)
        LabelVehicle_Regulatory.Name = "LabelVehicle_Regulatory"
        LabelVehicle_Regulatory.Size = New Size(173, 17)
        LabelVehicle_Regulatory.TabIndex = 16
        LabelVehicle_Regulatory.Text = "FRANCHISE INFORMATION"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Black
        Panel1.Controls.Add(LabelVehicle_Regulatory)
        Panel1.Controls.Add(btnSearch)
        Panel1.Controls.Add(txtSearch)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(597, 41)
        Panel1.TabIndex = 94
        ' 
        ' btnSearch
        ' 
        btnSearch.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnSearch.BackColor = Color.CornflowerBlue
        btnSearch.FlatAppearance.BorderSize = 0
        btnSearch.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        btnSearch.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSearch.ForeColor = Color.White
        btnSearch.Location = New Point(1197, 8)
        btnSearch.Margin = New Padding(3, 2, 3, 2)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(125, 28)
        btnSearch.TabIndex = 87
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' txtSearch
        ' 
        txtSearch.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtSearch.BackColor = SystemColors.ScrollBar
        txtSearch.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtSearch.Location = New Point(972, 11)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "  Search to renewal"
        txtSearch.Size = New Size(219, 23)
        txtSearch.TabIndex = 86
        ' 
        ' Form2franchise
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.RosyBrown
        Controls.Add(Panel1)
        Controls.Add(cbxStatus)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(Label5)
        Controls.Add(dtpExpirationDate)
        Controls.Add(dtpLastRenewalDate)
        Controls.Add(dtpDateIssued)
        Controls.Add(cbxArea)
        Controls.Add(cbxFranchiseType)
        Controls.Add(tbFranchiseeID)
        Controls.Add(btnSave)
        Controls.Add(tbFranchiseDuration)
        Controls.Add(tbLicenseNumber)
        Controls.Add(tbRoute)
        Controls.Add(tbTotalViolations)
        Controls.Add(tbFeePaid)
        Controls.Add(tbAssociation)
        Controls.Add(tbVehicleID)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form2franchise"
        Size = New Size(597, 416)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents tbFranchiseDuration As TextBox
    Friend WithEvents tbLicenseNumber As TextBox
    Friend WithEvents tbRoute As TextBox
    Friend WithEvents tbTotalViolations As TextBox
    Friend WithEvents tbFeePaid As TextBox
    Friend WithEvents tbAssociation As TextBox
    Friend WithEvents tbVehicleID As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents tbFranchiseeID As TextBox
    Friend WithEvents cbxArea As ComboBox
    Friend WithEvents cbxFranchiseType As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpExpirationDate As DateTimePicker
    Friend WithEvents dtpLastRenewalDate As DateTimePicker
    Friend WithEvents dtpDateIssued As DateTimePicker
    Friend WithEvents cbxStatus As ComboBox
    Friend WithEvents LabelVehicle_Regulatory As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox

End Class
