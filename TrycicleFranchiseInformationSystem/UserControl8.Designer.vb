<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3vehicle
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
        tbcolor = New TextBox()
        tbyear_of_manufacture = New TextBox()
        tbfranchise_id = New TextBox()
        tb_net_weight = New TextBox()
        tbmileage = New TextBox()
        tb_engine_num = New TextBox()
        tb_purchase_date = New TextBox()
        tbtransmission_type = New TextBox()
        tb_official_receipt = New TextBox()
        tb_chassis_num = New TextBox()
        tbfuel_type = New TextBox()
        tbmodel = New TextBox()
        tbplate_number = New TextBox()
        tb_vehicle_id = New TextBox()
        LabelVehicle_Regulatory = New Label()
        BtnAdd = New Button()
        Panel1 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' tbcolor
        ' 
        tbcolor.Location = New Point(36, 182)
        tbcolor.Margin = New Padding(3, 2, 3, 2)
        tbcolor.Name = "tbcolor"
        tbcolor.PlaceholderText = "Color"
        tbcolor.Size = New Size(244, 23)
        tbcolor.TabIndex = 30
        ' 
        ' tbyear_of_manufacture
        ' 
        tbyear_of_manufacture.Location = New Point(36, 207)
        tbyear_of_manufacture.Margin = New Padding(3, 2, 3, 2)
        tbyear_of_manufacture.Name = "tbyear_of_manufacture"
        tbyear_of_manufacture.PlaceholderText = "Year Manufactured"
        tbyear_of_manufacture.Size = New Size(244, 23)
        tbyear_of_manufacture.TabIndex = 29
        ' 
        ' tbfranchise_id
        ' 
        tbfranchise_id.Location = New Point(36, 232)
        tbfranchise_id.Margin = New Padding(3, 2, 3, 2)
        tbfranchise_id.Name = "tbfranchise_id"
        tbfranchise_id.PlaceholderText = "Franchise ID"
        tbfranchise_id.Size = New Size(244, 23)
        tbfranchise_id.TabIndex = 28
        ' 
        ' tb_net_weight
        ' 
        tb_net_weight.Location = New Point(312, 256)
        tb_net_weight.Margin = New Padding(3, 2, 3, 2)
        tb_net_weight.Name = "tb_net_weight"
        tb_net_weight.PlaceholderText = "Net Weight"
        tb_net_weight.Size = New Size(244, 23)
        tb_net_weight.TabIndex = 27
        ' 
        ' tbmileage
        ' 
        tbmileage.Location = New Point(312, 232)
        tbmileage.Margin = New Padding(3, 2, 3, 2)
        tbmileage.Name = "tbmileage"
        tbmileage.PlaceholderText = "Mileage"
        tbmileage.Size = New Size(244, 23)
        tbmileage.TabIndex = 26
        ' 
        ' tb_engine_num
        ' 
        tb_engine_num.Location = New Point(312, 158)
        tb_engine_num.Margin = New Padding(3, 2, 3, 2)
        tb_engine_num.Name = "tb_engine_num"
        tb_engine_num.PlaceholderText = "Engine Number"
        tb_engine_num.Size = New Size(244, 23)
        tb_engine_num.TabIndex = 25
        ' 
        ' tb_purchase_date
        ' 
        tb_purchase_date.Location = New Point(312, 207)
        tb_purchase_date.Margin = New Padding(3, 2, 3, 2)
        tb_purchase_date.Name = "tb_purchase_date"
        tb_purchase_date.PlaceholderText = "Purchase Date"
        tb_purchase_date.Size = New Size(244, 23)
        tb_purchase_date.TabIndex = 24
        ' 
        ' tbtransmission_type
        ' 
        tbtransmission_type.Location = New Point(312, 108)
        tbtransmission_type.Margin = New Padding(3, 2, 3, 2)
        tbtransmission_type.Name = "tbtransmission_type"
        tbtransmission_type.PlaceholderText = "Transmission Type"
        tbtransmission_type.Size = New Size(244, 23)
        tbtransmission_type.TabIndex = 23
        ' 
        ' tb_official_receipt
        ' 
        tb_official_receipt.Location = New Point(312, 182)
        tb_official_receipt.Margin = New Padding(3, 2, 3, 2)
        tb_official_receipt.Name = "tb_official_receipt"
        tb_official_receipt.PlaceholderText = "Official Receipt"
        tb_official_receipt.Size = New Size(244, 23)
        tb_official_receipt.TabIndex = 22
        ' 
        ' tb_chassis_num
        ' 
        tb_chassis_num.Location = New Point(312, 133)
        tb_chassis_num.Margin = New Padding(3, 2, 3, 2)
        tb_chassis_num.Name = "tb_chassis_num"
        tb_chassis_num.PlaceholderText = "Chassis Number"
        tb_chassis_num.Size = New Size(244, 23)
        tb_chassis_num.TabIndex = 21
        ' 
        ' tbfuel_type
        ' 
        tbfuel_type.Location = New Point(36, 256)
        tbfuel_type.Margin = New Padding(3, 2, 3, 2)
        tbfuel_type.Name = "tbfuel_type"
        tbfuel_type.PlaceholderText = "Fuel Type"
        tbfuel_type.Size = New Size(244, 23)
        tbfuel_type.TabIndex = 20
        ' 
        ' tbmodel
        ' 
        tbmodel.Location = New Point(36, 158)
        tbmodel.Margin = New Padding(3, 2, 3, 2)
        tbmodel.Name = "tbmodel"
        tbmodel.PlaceholderText = "Model"
        tbmodel.Size = New Size(244, 23)
        tbmodel.TabIndex = 19
        ' 
        ' tbplate_number
        ' 
        tbplate_number.Location = New Point(36, 133)
        tbplate_number.Margin = New Padding(3, 2, 3, 2)
        tbplate_number.Name = "tbplate_number"
        tbplate_number.PlaceholderText = "Plate Number"
        tbplate_number.Size = New Size(244, 23)
        tbplate_number.TabIndex = 18
        ' 
        ' tb_vehicle_id
        ' 
        tb_vehicle_id.Location = New Point(36, 108)
        tb_vehicle_id.Margin = New Padding(3, 2, 3, 2)
        tb_vehicle_id.Name = "tb_vehicle_id"
        tb_vehicle_id.PlaceholderText = "Vehicle ID"
        tb_vehicle_id.Size = New Size(244, 23)
        tb_vehicle_id.TabIndex = 17
        ' 
        ' LabelVehicle_Regulatory
        ' 
        LabelVehicle_Regulatory.AutoSize = True
        LabelVehicle_Regulatory.BackColor = Color.Transparent
        LabelVehicle_Regulatory.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelVehicle_Regulatory.ForeColor = Color.White
        LabelVehicle_Regulatory.Location = New Point(18, 15)
        LabelVehicle_Regulatory.Name = "LabelVehicle_Regulatory"
        LabelVehicle_Regulatory.Size = New Size(139, 15)
        LabelVehicle_Regulatory.TabIndex = 16
        LabelVehicle_Regulatory.Text = "VEHICLE INFORMATION"
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
        BtnAdd.Location = New Point(431, 319)
        BtnAdd.Margin = New Padding(3, 2, 3, 2)
        BtnAdd.Name = "BtnAdd"
        BtnAdd.Size = New Size(125, 28)
        BtnAdd.TabIndex = 45
        BtnAdd.Text = "Save"
        BtnAdd.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Black
        Panel1.Controls.Add(LabelVehicle_Regulatory)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(600, 41)
        Panel1.TabIndex = 46
        ' 
        ' Form3vehicle
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.RosyBrown
        Controls.Add(Panel1)
        Controls.Add(BtnAdd)
        Controls.Add(tbcolor)
        Controls.Add(tbyear_of_manufacture)
        Controls.Add(tbfranchise_id)
        Controls.Add(tb_net_weight)
        Controls.Add(tbmileage)
        Controls.Add(tb_engine_num)
        Controls.Add(tb_purchase_date)
        Controls.Add(tbtransmission_type)
        Controls.Add(tb_official_receipt)
        Controls.Add(tb_chassis_num)
        Controls.Add(tbfuel_type)
        Controls.Add(tbmodel)
        Controls.Add(tbplate_number)
        Controls.Add(tb_vehicle_id)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form3vehicle"
        Size = New Size(600, 416)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents tbcolor As TextBox
    Friend WithEvents tbyear_of_manufacture As TextBox
    Friend WithEvents tbfranchise_id As TextBox
    Friend WithEvents tb_net_weight As TextBox
    Friend WithEvents tbmileage As TextBox
    Friend WithEvents tb_engine_num As TextBox
    Friend WithEvents tb_purchase_date As TextBox
    Friend WithEvents tbtransmission_type As TextBox
    Friend WithEvents tb_official_receipt As TextBox
    Friend WithEvents tb_chassis_num As TextBox
    Friend WithEvents tbfuel_type As TextBox
    Friend WithEvents tbmodel As TextBox
    Friend WithEvents tbplate_number As TextBox
    Friend WithEvents tb_vehicle_id As TextBox
    Friend WithEvents LabelVehicle_Regulatory As Label
    Friend WithEvents BtnAdd As Button
    Friend WithEvents Panel1 As Panel

End Class
