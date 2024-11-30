<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginAdminHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginAdminHome))
        Panel1 = New Panel()
        Panel2 = New Panel()
        btnLoginAdmin = New Button()
        picboxAdmin1 = New PictureBox()
        Label3 = New Label()
        Panel1.SuspendLayout()
        CType(picboxAdmin1, ComponentModel.ISupportInitialize).BeginInit()
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
        Panel1.TabIndex = 6
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(204), CByte(51), CByte(136))
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 651)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1348, 70)
        Panel2.TabIndex = 7
        ' 
        ' btnLoginAdmin
        ' 
        btnLoginAdmin.Anchor = AnchorStyles.None
        btnLoginAdmin.BackColor = Color.FromArgb(CByte(218), CByte(97), CByte(164))
        btnLoginAdmin.Cursor = Cursors.Hand
        btnLoginAdmin.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLoginAdmin.ForeColor = SystemColors.ButtonHighlight
        btnLoginAdmin.Location = New Point(570, 532)
        btnLoginAdmin.Name = "btnLoginAdmin"
        btnLoginAdmin.Size = New Size(210, 70)
        btnLoginAdmin.TabIndex = 11
        btnLoginAdmin.Text = "LOG IN"
        btnLoginAdmin.UseVisualStyleBackColor = False
        ' 
        ' picboxAdmin1
        ' 
        picboxAdmin1.Anchor = AnchorStyles.None
        picboxAdmin1.Image = CType(resources.GetObject("picboxAdmin1.Image"), Image)
        picboxAdmin1.Location = New Point(440, 88)
        picboxAdmin1.Name = "picboxAdmin1"
        picboxAdmin1.Size = New Size(449, 438)
        picboxAdmin1.SizeMode = PictureBoxSizeMode.StretchImage
        picboxAdmin1.TabIndex = 12
        picboxAdmin1.TabStop = False
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
        ' LoginAdminHome
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1348, 721)
        Controls.Add(picboxAdmin1)
        Controls.Add(btnLoginAdmin)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "LoginAdminHome"
        StartPosition = FormStartPosition.CenterScreen
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(picboxAdmin1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnLoginAdmin As Button
    Friend WithEvents picboxAdmin1 As PictureBox
    Friend WithEvents Label3 As Label
End Class
