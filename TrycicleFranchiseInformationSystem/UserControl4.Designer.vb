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
        tbmidname = New TextBox()
        tblastname = New TextBox()
        tbphonenum = New TextBox()
        tbgender = New TextBox()
        tbbirthdate = New TextBox()
        tbbrgy = New TextBox()
        tbmunicipality = New TextBox()
        tbcity = New TextBox()
        tbzipcode = New TextBox()
        tbowner_id = New TextBox()
        BtnAdd = New Button()
        LabelVehicle_Regulatory = New Label()
        Panel1 = New Panel()
        btnSearch = New Button()
        txtSearch = New TextBox()
        cbxBarangay = New ComboBox()
        cbxMunicipality = New ComboBox()
        cbxCityProvince = New ComboBox()
        dtpDateIssued = New DateTimePicker()
        Label1 = New Label()
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
        ' tbmidname
        ' 
        tbmidname.Location = New Point(60, 102)
        tbmidname.Margin = New Padding(3, 2, 3, 2)
        tbmidname.Name = "tbmidname"
        tbmidname.PlaceholderText = "Middle Name (Optional)"
        tbmidname.Size = New Size(218, 23)
        tbmidname.TabIndex = 3
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
        tbphonenum.Location = New Point(60, 156)
        tbphonenum.Margin = New Padding(3, 2, 3, 2)
        tbphonenum.Name = "tbphonenum"
        tbphonenum.PlaceholderText = "Phone Number"
        tbphonenum.Size = New Size(218, 23)
        tbphonenum.TabIndex = 5
        ' 
        ' tbgender
        ' 
        tbgender.Location = New Point(60, 183)
        tbgender.Margin = New Padding(3, 2, 3, 2)
        tbgender.Name = "tbgender"
        tbgender.PlaceholderText = "Gender"
        tbgender.Size = New Size(218, 23)
        tbgender.TabIndex = 6
        ' 
        ' tbbirthdate
        ' 
        tbbirthdate.Location = New Point(304, 385)
        tbbirthdate.Margin = New Padding(3, 2, 3, 2)
        tbbirthdate.Name = "tbbirthdate"
        tbbirthdate.PlaceholderText = "Birth Date (MM/DD/YY)"
        tbbirthdate.Size = New Size(218, 23)
        tbbirthdate.TabIndex = 7
        ' 
        ' tbbrgy
        ' 
        tbbrgy.Location = New Point(303, 102)
        tbbrgy.Margin = New Padding(3, 2, 3, 2)
        tbbrgy.Name = "tbbrgy"
        tbbrgy.PlaceholderText = "Baranggay"
        tbbrgy.Size = New Size(218, 23)
        tbbrgy.TabIndex = 8
        ' 
        ' tbmunicipality
        ' 
        tbmunicipality.Location = New Point(69, 396)
        tbmunicipality.Margin = New Padding(3, 2, 3, 2)
        tbmunicipality.Name = "tbmunicipality"
        tbmunicipality.PlaceholderText = "Municipality"
        tbmunicipality.Size = New Size(218, 23)
        tbmunicipality.TabIndex = 9
        ' 
        ' tbcity
        ' 
        tbcity.Location = New Point(69, 423)
        tbcity.Margin = New Padding(3, 2, 3, 2)
        tbcity.Name = "tbcity"
        tbcity.PlaceholderText = "City/Province"
        tbcity.Size = New Size(218, 23)
        tbcity.TabIndex = 10
        ' 
        ' tbzipcode
        ' 
        tbzipcode.Location = New Point(304, 274)
        tbzipcode.Margin = New Padding(3, 2, 3, 2)
        tbzipcode.Name = "tbzipcode"
        tbzipcode.PlaceholderText = "Zip Code"
        tbzipcode.Size = New Size(218, 23)
        tbzipcode.TabIndex = 11
        ' 
        ' tbowner_id
        ' 
        tbowner_id.Location = New Point(303, 184)
        tbowner_id.Margin = New Padding(3, 2, 3, 2)
        tbowner_id.Name = "tbowner_id"
        tbowner_id.PlaceholderText = "Owner ID"
        tbowner_id.Size = New Size(218, 23)
        tbowner_id.TabIndex = 12
        ' 
        ' BtnAdd
        ' 
        BtnAdd.BackColor = Color.CornflowerBlue
        BtnAdd.FlatAppearance.BorderSize = 0
        BtnAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        BtnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        BtnAdd.FlatStyle = FlatStyle.Flat
        BtnAdd.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnAdd.ForeColor = Color.White
        BtnAdd.Location = New Point(397, 306)
        BtnAdd.Margin = New Padding(3, 2, 3, 2)
        BtnAdd.Name = "BtnAdd"
        BtnAdd.Size = New Size(125, 28)
        BtnAdd.TabIndex = 29
        BtnAdd.Text = "Save"
        BtnAdd.UseVisualStyleBackColor = False
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
        ' cbxBarangay
        ' 
        cbxBarangay.FormattingEnabled = True
        cbxBarangay.Items.AddRange(New Object() {"approved", "denied", "pending"})
        cbxBarangay.Location = New Point(60, 311)
        cbxBarangay.Name = "cbxBarangay"
        cbxBarangay.Size = New Size(218, 23)
        cbxBarangay.TabIndex = 99
        ' 
        ' cbxMunicipality
        ' 
        cbxMunicipality.FormattingEnabled = True
        cbxMunicipality.Items.AddRange(New Object() {"compliant", "non-compliant"})
        cbxMunicipality.Location = New Point(303, 129)
        cbxMunicipality.Name = "cbxMunicipality"
        cbxMunicipality.Size = New Size(218, 23)
        cbxMunicipality.TabIndex = 98
        ' 
        ' cbxCityProvince
        ' 
        cbxCityProvince.FormattingEnabled = True
        cbxCityProvince.Items.AddRange(New Object() {"annual", "semi-annual"})
        cbxCityProvince.Location = New Point(303, 156)
        cbxCityProvince.Name = "cbxCityProvince"
        cbxCityProvince.Size = New Size(218, 23)
        cbxCityProvince.TabIndex = 97
        ' 
        ' dtpDateIssued
        ' 
        dtpDateIssued.Location = New Point(60, 233)
        dtpDateIssued.Name = "dtpDateIssued"
        dtpDateIssued.Size = New Size(218, 23)
        dtpDateIssued.TabIndex = 100
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label1.Location = New Point(303, 87)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 15)
        Label1.TabIndex = 101
        Label1.Text = "Address"
        ' 
        ' Form1franchisee
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = Color.RosyBrown
        Controls.Add(Label1)
        Controls.Add(dtpDateIssued)
        Controls.Add(cbxBarangay)
        Controls.Add(cbxMunicipality)
        Controls.Add(cbxCityProvince)
        Controls.Add(Panel1)
        Controls.Add(BtnAdd)
        Controls.Add(tbowner_id)
        Controls.Add(tbzipcode)
        Controls.Add(tbcity)
        Controls.Add(tbmunicipality)
        Controls.Add(tbbrgy)
        Controls.Add(tbbirthdate)
        Controls.Add(tbgender)
        Controls.Add(tbphonenum)
        Controls.Add(tblastname)
        Controls.Add(tbmidname)
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
    Friend WithEvents tbmidname As TextBox
    Friend WithEvents tblastname As TextBox
    Friend WithEvents tbphonenum As TextBox
    Friend WithEvents tbgender As TextBox
    Friend WithEvents tbbirthdate As TextBox
    Friend WithEvents tbbrgy As TextBox
    Friend WithEvents tbmunicipality As TextBox
    Friend WithEvents tbcity As TextBox
    Friend WithEvents tbzipcode As TextBox
    Friend WithEvents tbowner_id As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnAdd As Button
    Friend WithEvents LabelVehicle_Regulatory As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents cbxBarangay As ComboBox
    Friend WithEvents cbxMunicipality As ComboBox
    Friend WithEvents cbxCityProvince As ComboBox
    Friend WithEvents dtpDateIssued As DateTimePicker
    Friend WithEvents Label1 As Label

End Class
