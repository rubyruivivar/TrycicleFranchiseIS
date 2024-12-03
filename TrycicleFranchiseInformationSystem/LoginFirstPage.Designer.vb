<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginFirstPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginFirstPage))
        Panel1 = New Panel()
        Panel2 = New Panel()
        picboxTricy1 = New PictureBox()
        labelTricycle1 = New Label()
        btnContinue1 = New Button()
        labelFranchise1 = New Label()
        labelInformation1 = New Label()
        labelSystem1 = New Label()
        CType(picboxTricy1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(13), CByte(71), CByte(127))
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1348, 70)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(204), CByte(51), CByte(136))
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 651)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1348, 70)
        Panel2.TabIndex = 1
        ' 
        ' picboxTricy1
        ' 
        picboxTricy1.Anchor = AnchorStyles.None
        picboxTricy1.Image = CType(resources.GetObject("picboxTricy1.Image"), Image)
        picboxTricy1.Location = New Point(248, 137)
        picboxTricy1.Name = "picboxTricy1"
        picboxTricy1.Size = New Size(449, 438)
        picboxTricy1.SizeMode = PictureBoxSizeMode.StretchImage
        picboxTricy1.TabIndex = 2
        picboxTricy1.TabStop = False
        ' 
        ' labelTricycle1
        ' 
        labelTricycle1.Anchor = AnchorStyles.None
        labelTricycle1.AutoSize = True
        labelTricycle1.Font = New Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelTricycle1.Location = New Point(703, 137)
        labelTricycle1.Name = "labelTricycle1"
        labelTricycle1.Size = New Size(400, 106)
        labelTricycle1.TabIndex = 3
        labelTricycle1.Text = "TRICYCLE"
        ' 
        ' btnContinue1
        ' 
        btnContinue1.Anchor = AnchorStyles.None
        btnContinue1.BackColor = SystemColors.ActiveCaptionText
        btnContinue1.Cursor = Cursors.Hand
        btnContinue1.FlatStyle = FlatStyle.Flat
        btnContinue1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnContinue1.ForeColor = SystemColors.ButtonHighlight
        btnContinue1.Location = New Point(730, 505)
        btnContinue1.Name = "btnContinue1"
        btnContinue1.Size = New Size(210, 70)
        btnContinue1.TabIndex = 4
        btnContinue1.Text = "CONTINUE"
        btnContinue1.UseVisualStyleBackColor = False
        ' 
        ' labelFranchise1
        ' 
        labelFranchise1.Anchor = AnchorStyles.None
        labelFranchise1.AutoSize = True
        labelFranchise1.Font = New Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelFranchise1.Location = New Point(703, 230)
        labelFranchise1.Name = "labelFranchise1"
        labelFranchise1.Size = New Size(482, 106)
        labelFranchise1.TabIndex = 5
        labelFranchise1.Text = "FRANCHISE"
        ' 
        ' labelInformation1
        ' 
        labelInformation1.Anchor = AnchorStyles.None
        labelInformation1.AutoSize = True
        labelInformation1.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelInformation1.ForeColor = Color.FromArgb(CByte(125), CByte(49), CByte(173))
        labelInformation1.Location = New Point(712, 336)
        labelInformation1.Name = "labelInformation1"
        labelInformation1.Size = New Size(457, 81)
        labelInformation1.TabIndex = 6
        labelInformation1.Text = "INFORMATION"
        ' 
        ' labelSystem1
        ' 
        labelSystem1.Anchor = AnchorStyles.None
        labelSystem1.AutoSize = True
        labelSystem1.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelSystem1.ForeColor = Color.FromArgb(CByte(125), CByte(49), CByte(173))
        labelSystem1.Location = New Point(712, 404)
        labelSystem1.Name = "labelSystem1"
        labelSystem1.Size = New Size(262, 81)
        labelSystem1.TabIndex = 7
        labelSystem1.Text = "SYSTEM"
        ' 
        ' LoginFirstPage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1348, 721)
        Controls.Add(labelSystem1)
        Controls.Add(labelInformation1)
        Controls.Add(btnContinue1)
        Controls.Add(labelTricycle1)
        Controls.Add(picboxTricy1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(labelFranchise1)
        Name = "LoginFirstPage"
        StartPosition = FormStartPosition.CenterScreen
        WindowState = FormWindowState.Maximized
        CType(picboxTricy1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents picboxTricy1 As PictureBox
    Friend WithEvents labelTricycle1 As Label
    Friend WithEvents btnContinue1 As Button
    Friend WithEvents labelFranchise1 As Label
    Friend WithEvents labelInformation1 As Label
    Friend WithEvents labelSystem1 As Label

End Class
