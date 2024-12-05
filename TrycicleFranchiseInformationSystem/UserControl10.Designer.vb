<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl10
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
        LabelVehicle_Regulatory = New Label()
        Panel1 = New Panel()
        btnSearch = New Button()
        txtSearch = New TextBox()
        lblRecordCount = New Label()
        btnDelete = New Button()
        btnUpdate = New Button()
        dgvFranchisee = New DataGridView()
        cbxgender = New ComboBox()
        Label2 = New Label()
        Label1 = New Label()
        dtpdateofbirth = New DateTimePicker()
        cbxCivilStatus = New ComboBox()
        cbxMunicipality = New ComboBox()
        cbxvalidID = New ComboBox()
        tbinsurance = New TextBox()
        tblicensenum = New TextBox()
        tbbarangay = New TextBox()
        tbphonenum = New TextBox()
        tblastname = New TextBox()
        tbmiddlename = New TextBox()
        tbfirstname = New TextBox()
        Panel1.SuspendLayout()
        CType(dgvFranchisee, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LabelVehicle_Regulatory
        ' 
        LabelVehicle_Regulatory.AutoSize = True
        LabelVehicle_Regulatory.BackColor = Color.Transparent
        LabelVehicle_Regulatory.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelVehicle_Regulatory.ForeColor = Color.White
        LabelVehicle_Regulatory.Location = New Point(18, 15)
        LabelVehicle_Regulatory.Name = "LabelVehicle_Regulatory"
        LabelVehicle_Regulatory.Size = New Size(163, 15)
        LabelVehicle_Regulatory.TabIndex = 16
        LabelVehicle_Regulatory.Text = "FRANCHISEE INFORMATION"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Black
        Panel1.Controls.Add(btnSearch)
        Panel1.Controls.Add(txtSearch)
        Panel1.Controls.Add(LabelVehicle_Regulatory)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(949, 41)
        Panel1.TabIndex = 47
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
        btnSearch.Location = New Point(796, 8)
        btnSearch.Margin = New Padding(3, 2, 3, 2)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(125, 28)
        btnSearch.TabIndex = 89
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' txtSearch
        ' 
        txtSearch.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtSearch.BackColor = SystemColors.ScrollBar
        txtSearch.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtSearch.Location = New Point(571, 11)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "  Search to renewal"
        txtSearch.Size = New Size(219, 23)
        txtSearch.TabIndex = 88
        ' 
        ' lblRecordCount
        ' 
        lblRecordCount.AutoSize = True
        lblRecordCount.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRecordCount.Location = New Point(31, 340)
        lblRecordCount.Name = "lblRecordCount"
        lblRecordCount.Size = New Size(43, 15)
        lblRecordCount.TabIndex = 52
        lblRecordCount.Text = "Label2"
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
        btnDelete.Location = New Point(276, 305)
        btnDelete.Margin = New Padding(3, 2, 3, 2)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(125, 28)
        btnDelete.TabIndex = 51
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
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
        btnUpdate.Location = New Point(124, 305)
        btnUpdate.Margin = New Padding(3, 2, 3, 2)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(125, 28)
        btnUpdate.TabIndex = 50
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' dgvFranchisee
        ' 
        dgvFranchisee.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvFranchisee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvFranchisee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvFranchisee.Location = New Point(32, 356)
        dgvFranchisee.Name = "dgvFranchisee"
        dgvFranchisee.Size = New Size(893, 298)
        dgvFranchisee.TabIndex = 49
        ' 
        ' cbxgender
        ' 
        cbxgender.FormattingEnabled = True
        cbxgender.Items.AddRange(New Object() {"Female", "Male"})
        cbxgender.Location = New Point(31, 157)
        cbxgender.Name = "cbxgender"
        cbxgender.Size = New Size(218, 23)
        cbxgender.TabIndex = 118
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label2.Location = New Point(34, 181)
        Label2.Name = "Label2"
        Label2.Size = New Size(55, 15)
        Label2.TabIndex = 117
        Label2.Text = "Birthdate"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label1.Location = New Point(277, 154)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 15)
        Label1.TabIndex = 116
        Label1.Text = "Address"
        ' 
        ' dtpdateofbirth
        ' 
        dtpdateofbirth.Location = New Point(31, 198)
        dtpdateofbirth.Name = "dtpdateofbirth"
        dtpdateofbirth.Size = New Size(218, 23)
        dtpdateofbirth.TabIndex = 115
        ' 
        ' cbxCivilStatus
        ' 
        cbxCivilStatus.FormattingEnabled = True
        cbxCivilStatus.Items.AddRange(New Object() {"Single", "Married", "Widowed"})
        cbxCivilStatus.Location = New Point(31, 227)
        cbxCivilStatus.Name = "cbxCivilStatus"
        cbxCivilStatus.Size = New Size(218, 23)
        cbxCivilStatus.TabIndex = 114
        ' 
        ' cbxMunicipality
        ' 
        cbxMunicipality.FormattingEnabled = True
        cbxMunicipality.Items.AddRange(New Object() {"Basud", "Capalonga", "Daet", "Jose Panganiban", "Labo", "Mercedes", "Paracale", "San Lorenzo Ruiz", "San Vicente", "Santa Elena", "Talisay", "Vinzons"})
        cbxMunicipality.Location = New Point(276, 196)
        cbxMunicipality.Name = "cbxMunicipality"
        cbxMunicipality.Size = New Size(218, 23)
        cbxMunicipality.TabIndex = 113
        ' 
        ' cbxvalidID
        ' 
        cbxvalidID.FormattingEnabled = True
        cbxvalidID.Items.AddRange(New Object() {"Driver\'s License", "Barangay Clearance", "Police Clearance", "National ID"})
        cbxvalidID.Location = New Point(276, 225)
        cbxvalidID.Name = "cbxvalidID"
        cbxvalidID.Size = New Size(218, 23)
        cbxvalidID.TabIndex = 112
        ' 
        ' tbinsurance
        ' 
        tbinsurance.Location = New Point(276, 129)
        tbinsurance.Margin = New Padding(3, 2, 3, 2)
        tbinsurance.Name = "tbinsurance"
        tbinsurance.PlaceholderText = "Insurance Policy Number"
        tbinsurance.Size = New Size(218, 23)
        tbinsurance.TabIndex = 111
        ' 
        ' tblicensenum
        ' 
        tblicensenum.Location = New Point(276, 102)
        tblicensenum.Margin = New Padding(3, 2, 3, 2)
        tblicensenum.Name = "tblicensenum"
        tblicensenum.PlaceholderText = "License Number"
        tblicensenum.Size = New Size(218, 23)
        tblicensenum.TabIndex = 110
        ' 
        ' tbbarangay
        ' 
        tbbarangay.Location = New Point(276, 169)
        tbbarangay.Margin = New Padding(3, 2, 3, 2)
        tbbarangay.Name = "tbbarangay"
        tbbarangay.PlaceholderText = "Barangay"
        tbbarangay.Size = New Size(218, 23)
        tbbarangay.TabIndex = 109
        ' 
        ' tbphonenum
        ' 
        tbphonenum.Location = New Point(276, 75)
        tbphonenum.Margin = New Padding(3, 2, 3, 2)
        tbphonenum.Name = "tbphonenum"
        tbphonenum.PlaceholderText = "Phone Number"
        tbphonenum.Size = New Size(218, 23)
        tbphonenum.TabIndex = 108
        ' 
        ' tblastname
        ' 
        tblastname.Location = New Point(31, 129)
        tblastname.Margin = New Padding(3, 2, 3, 2)
        tblastname.Name = "tblastname"
        tblastname.PlaceholderText = "Last Name"
        tblastname.Size = New Size(218, 23)
        tblastname.TabIndex = 107
        ' 
        ' tbmiddlename
        ' 
        tbmiddlename.Location = New Point(31, 102)
        tbmiddlename.Margin = New Padding(3, 2, 3, 2)
        tbmiddlename.Name = "tbmiddlename"
        tbmiddlename.PlaceholderText = "Middle Name (Optional)"
        tbmiddlename.Size = New Size(218, 23)
        tbmiddlename.TabIndex = 106
        ' 
        ' tbfirstname
        ' 
        tbfirstname.Location = New Point(32, 75)
        tbfirstname.Margin = New Padding(3, 2, 3, 2)
        tbfirstname.Name = "tbfirstname"
        tbfirstname.PlaceholderText = "First Name"
        tbfirstname.Size = New Size(218, 23)
        tbfirstname.TabIndex = 105
        ' 
        ' UserControl10
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.RosyBrown
        Controls.Add(cbxgender)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(dtpdateofbirth)
        Controls.Add(cbxCivilStatus)
        Controls.Add(cbxMunicipality)
        Controls.Add(cbxvalidID)
        Controls.Add(tbinsurance)
        Controls.Add(tblicensenum)
        Controls.Add(tbbarangay)
        Controls.Add(tbphonenum)
        Controls.Add(tblastname)
        Controls.Add(tbmiddlename)
        Controls.Add(tbfirstname)
        Controls.Add(lblRecordCount)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(dgvFranchisee)
        Controls.Add(Panel1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "UserControl10"
        Size = New Size(949, 678)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgvFranchisee, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LabelVehicle_Regulatory As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblRecordCount As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents dgvFranchisee As DataGridView
    Friend WithEvents cbxgender As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpdateofbirth As DateTimePicker
    Friend WithEvents cbxCivilStatus As ComboBox
    Friend WithEvents cbxMunicipality As ComboBox
    Friend WithEvents cbxvalidID As ComboBox
    Friend WithEvents tbinsurance As TextBox
    Friend WithEvents tblicensenum As TextBox
    Friend WithEvents tbbarangay As TextBox
    Friend WithEvents tbphonenum As TextBox
    Friend WithEvents tblastname As TextBox
    Friend WithEvents tbmiddlename As TextBox
    Friend WithEvents tbfirstname As TextBox

End Class
