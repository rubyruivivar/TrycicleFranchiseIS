<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1franchisee
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
        tbfirstname = New TextBox()
        tbmiddlename = New TextBox()
        tblastname = New TextBox()
        tbphonenum = New TextBox()
        tbbarangay = New TextBox()
        tblicensenum = New TextBox()
        tbinsurance = New TextBox()
        btnSave = New Button()
        LabelVehicle_Regulatory = New Label()
        Panel1 = New Panel()
        btnSearch = New Button()
        txtSearch = New TextBox()
        cbxCivilStatus = New ComboBox()
        cbxMunicipality = New ComboBox()
        cbxvalidID = New ComboBox()
        dtpdateofbirth = New DateTimePicker()
        Label1 = New Label()
        Label2 = New Label()
        cbxgender = New ComboBox()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' tbfirstname
        ' 
        tbfirstname.Location = New Point(60, 75)
        tbfirstname.Margin = New Padding(3, 2, 3, 2)
        tbfirstname.Name = "tbfirstname"
        tbfirstname.PlaceholderText = "First Name"
        tbfirstname.Size = New Size(218, 23)
        tbfirstname.TabIndex = 2
        ' 
        ' tbmiddlename
        ' 
        tbmiddlename.Location = New Point(60, 102)
        tbmiddlename.Margin = New Padding(3, 2, 3, 2)
        tbmiddlename.Name = "tbmiddlename"
        tbmiddlename.PlaceholderText = "Middle Name (Optional)"
        tbmiddlename.Size = New Size(218, 23)
        tbmiddlename.TabIndex = 3
        ' 
        ' tblastname
        ' 
        tblastname.Location = New Point(60, 129)
        tblastname.Margin = New Padding(3, 2, 3, 2)
        tblastname.Name = "tblastname"
        tblastname.PlaceholderText = "Last Name"
        tblastname.Size = New Size(218, 23)
        tblastname.TabIndex = 4
        ' 
        ' tbphonenum
        ' 
        tbphonenum.Location = New Point(305, 75)
        tbphonenum.Margin = New Padding(3, 2, 3, 2)
        tbphonenum.Name = "tbphonenum"
        tbphonenum.PlaceholderText = "Phone Number"
        tbphonenum.Size = New Size(218, 23)
        tbphonenum.TabIndex = 5
        ' 
        ' tbbarangay
        ' 
        tbbarangay.Location = New Point(305, 169)
        tbbarangay.Margin = New Padding(3, 2, 3, 2)
        tbbarangay.Name = "tbbarangay"
        tbbarangay.PlaceholderText = "Barangay"
        tbbarangay.Size = New Size(218, 23)
        tbbarangay.TabIndex = 8
        ' 
        ' tblicensenum
        ' 
        tblicensenum.Location = New Point(305, 102)
        tblicensenum.Margin = New Padding(3, 2, 3, 2)
        tblicensenum.Name = "tblicensenum"
        tblicensenum.PlaceholderText = "License Number"
        tblicensenum.Size = New Size(218, 23)
        tblicensenum.TabIndex = 9
        ' 
        ' tbinsurance
        ' 
        tbinsurance.Location = New Point(305, 129)
        tbinsurance.Margin = New Padding(3, 2, 3, 2)
        tbinsurance.Name = "tbinsurance"
        tbinsurance.PlaceholderText = "Insurance Policy Number"
        tbinsurance.Size = New Size(218, 23)
        tbinsurance.TabIndex = 11
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
        btnSave.Location = New Point(397, 306)
        btnSave.Margin = New Padding(3, 2, 3, 2)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(125, 28)
        btnSave.TabIndex = 29
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' LabelVehicle_Regulatory
        ' 
        LabelVehicle_Regulatory.AutoSize = True
        LabelVehicle_Regulatory.BackColor = Color.Transparent
        LabelVehicle_Regulatory.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelVehicle_Regulatory.ForeColor = Color.White
        LabelVehicle_Regulatory.Location = New Point(18, 12)
        LabelVehicle_Regulatory.Name = "LabelVehicle_Regulatory"
        LabelVehicle_Regulatory.Size = New Size(250, 17)
        LabelVehicle_Regulatory.TabIndex = 16
        LabelVehicle_Regulatory.Text = "FRANCHISEE PERSONAL INFORMATION"
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
        Panel1.Size = New Size(594, 41)
        Panel1.TabIndex = 91
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
        btnSearch.Location = New Point(1588, 8)
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
        txtSearch.Location = New Point(1363, 11)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "  Search to renewal"
        txtSearch.Size = New Size(219, 23)
        txtSearch.TabIndex = 86
        ' 
        ' cbxCivilStatus
        ' 
        cbxCivilStatus.FormattingEnabled = True
        cbxCivilStatus.Items.AddRange(New Object() {"Single", "Married", "Widowed"})
        cbxCivilStatus.Location = New Point(60, 227)
        cbxCivilStatus.Name = "cbxCivilStatus"
        cbxCivilStatus.Size = New Size(218, 23)
        cbxCivilStatus.TabIndex = 99
        ' 
        ' cbxMunicipality
        ' 
        cbxMunicipality.FormattingEnabled = True
        cbxMunicipality.Items.AddRange(New Object() {"Basud", "Capalonga", "Daet", "Jose Panganiban", "Labo", "Mercedes", "Paracale", "San Lorenzo Ruiz", "San Vicente", "Santa Elena", "Talisay", "Vinzons"})
        cbxMunicipality.Location = New Point(305, 196)
        cbxMunicipality.Name = "cbxMunicipality"
        cbxMunicipality.Size = New Size(218, 23)
        cbxMunicipality.TabIndex = 98
        ' 
        ' cbxvalidID
        ' 
        cbxvalidID.FormattingEnabled = True
        cbxvalidID.Items.AddRange(New Object() {"Driver's License", "Barangay Clearance", "Police Clearance", "National ID"})
        cbxvalidID.Location = New Point(305, 225)
        cbxvalidID.Name = "cbxvalidID"
        cbxvalidID.Size = New Size(218, 23)
        cbxvalidID.TabIndex = 97
        ' 
        ' dtpdateofbirth
        ' 
        dtpdateofbirth.Location = New Point(60, 198)
        dtpdateofbirth.Name = "dtpdateofbirth"
        dtpdateofbirth.Size = New Size(218, 23)
        dtpdateofbirth.TabIndex = 100
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label1.Location = New Point(306, 154)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 15)
        Label1.TabIndex = 101
        Label1.Text = "Address"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label2.Location = New Point(63, 181)
        Label2.Name = "Label2"
        Label2.Size = New Size(55, 15)
        Label2.TabIndex = 103
        Label2.Text = "Birthdate"
        ' 
        ' cbxgender
        ' 
        cbxgender.FormattingEnabled = True
        cbxgender.Items.AddRange(New Object() {"Female", "Male"})
        cbxgender.Location = New Point(60, 157)
        cbxgender.Name = "cbxgender"
        cbxgender.Size = New Size(218, 23)
        cbxgender.TabIndex = 104
        ' 
        ' Form1franchisee
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = Color.RosyBrown
        Controls.Add(cbxgender)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(dtpdateofbirth)
        Controls.Add(cbxCivilStatus)
        Controls.Add(cbxMunicipality)
        Controls.Add(cbxvalidID)
        Controls.Add(Panel1)
        Controls.Add(btnSave)
        Controls.Add(tbinsurance)
        Controls.Add(tblicensenum)
        Controls.Add(tbbarangay)
        Controls.Add(tbphonenum)
        Controls.Add(tblastname)
        Controls.Add(tbmiddlename)
        Controls.Add(tbfirstname)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form1franchisee"
        Size = New Size(594, 461)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents tbfirstname As TextBox
    Friend WithEvents tbmiddlename As TextBox
    Friend WithEvents tblastname As TextBox
    Friend WithEvents tbphonenum As TextBox
    Friend WithEvents tbbarangay As TextBox
    Friend WithEvents tblicensenum As TextBox
    Friend WithEvents tbinsurance As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents LabelVehicle_Regulatory As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents cbxCivilStatus As ComboBox
    Friend WithEvents cbxMunicipality As ComboBox
    Friend WithEvents cbxvalidID As ComboBox
    Friend WithEvents dtpdateofbirth As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents cbxgender As ComboBox

End Class
