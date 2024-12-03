<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Panel3 = New Panel()
        btnTogglePasswordFS = New Button()
        labelPassFID1 = New Label()
        txtboxPassFID1 = New TextBox()
        labelFranchiseeID1 = New Label()
        txtboxFranchiseeID1 = New TextBox()
        btnContinue2 = New Button()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
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
        Panel1.TabIndex = 3
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
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(204), CByte(51), CByte(136))
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 651)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1348, 70)
        Panel2.TabIndex = 4
        ' 
        ' Panel3
        ' 
        Panel3.Anchor = AnchorStyles.None
        Panel3.BackColor = SystemColors.Control
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(btnTogglePasswordFS)
        Panel3.Controls.Add(labelPassFID1)
        Panel3.Controls.Add(txtboxPassFID1)
        Panel3.Controls.Add(labelFranchiseeID1)
        Panel3.Controls.Add(txtboxFranchiseeID1)
        Panel3.Location = New Point(227, 90)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(891, 409)
        Panel3.TabIndex = 5
        ' 
        ' btnTogglePasswordFS
        ' 
        btnTogglePasswordFS.Anchor = AnchorStyles.None
        btnTogglePasswordFS.BackColor = SystemColors.AppWorkspace
        btnTogglePasswordFS.Font = New Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnTogglePasswordFS.Location = New Point(688, 228)
        btnTogglePasswordFS.Name = "btnTogglePasswordFS"
        btnTogglePasswordFS.Size = New Size(63, 27)
        btnTogglePasswordFS.TabIndex = 32
        btnTogglePasswordFS.Text = "Toggle"
        btnTogglePasswordFS.UseVisualStyleBackColor = False
        ' 
        ' labelPassFID1
        ' 
        labelPassFID1.AutoSize = True
        labelPassFID1.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelPassFID1.Location = New Point(184, 208)
        labelPassFID1.Name = "labelPassFID1"
        labelPassFID1.Size = New Size(187, 50)
        labelPassFID1.TabIndex = 3
        labelPassFID1.Text = "Password"
        ' 
        ' txtboxPassFID1
        ' 
        txtboxPassFID1.Cursor = Cursors.IBeam
        txtboxPassFID1.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtboxPassFID1.ForeColor = SystemColors.ActiveCaptionText
        txtboxPassFID1.Location = New Point(194, 261)
        txtboxPassFID1.Name = "txtboxPassFID1"
        txtboxPassFID1.Size = New Size(557, 51)
        txtboxPassFID1.TabIndex = 2
        ' 
        ' labelFranchiseeID1
        ' 
        labelFranchiseeID1.AutoSize = True
        labelFranchiseeID1.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelFranchiseeID1.Location = New Point(184, 76)
        labelFranchiseeID1.Name = "labelFranchiseeID1"
        labelFranchiseeID1.Size = New Size(254, 50)
        labelFranchiseeID1.TabIndex = 1
        labelFranchiseeID1.Text = "Franchisee ID"
        ' 
        ' txtboxFranchiseeID1
        ' 
        txtboxFranchiseeID1.Cursor = Cursors.IBeam
        txtboxFranchiseeID1.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtboxFranchiseeID1.ForeColor = SystemColors.AppWorkspace
        txtboxFranchiseeID1.Location = New Point(194, 129)
        txtboxFranchiseeID1.Name = "txtboxFranchiseeID1"
        txtboxFranchiseeID1.Size = New Size(557, 51)
        txtboxFranchiseeID1.TabIndex = 0
        txtboxFranchiseeID1.Text = "Enter Franchisee ID"
        ' 
        ' btnContinue2
        ' 
        btnContinue2.Anchor = AnchorStyles.None
        btnContinue2.BackColor = SystemColors.ActiveCaptionText
        btnContinue2.Cursor = Cursors.Hand
        btnContinue2.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnContinue2.ForeColor = SystemColors.ButtonHighlight
        btnContinue2.Location = New Point(568, 530)
        btnContinue2.Name = "btnContinue2"
        btnContinue2.Size = New Size(210, 70)
        btnContinue2.TabIndex = 6
        btnContinue2.Text = "CONTINUE"
        btnContinue2.UseVisualStyleBackColor = False
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1348, 721)
        Controls.Add(btnContinue2)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Form4"
        StartPosition = FormStartPosition.CenterScreen
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents labelPassFID1 As Label
    Friend WithEvents txtboxPassFID1 As TextBox
    Friend WithEvents labelFranchiseeID1 As Label
    Friend WithEvents txtboxFranchiseeID1 As TextBox
    Friend WithEvents btnContinue2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnTogglePasswordFS As Button
End Class
