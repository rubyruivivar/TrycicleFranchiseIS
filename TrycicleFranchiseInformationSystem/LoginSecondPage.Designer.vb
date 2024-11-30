<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginSecondPage
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
        labelSignIn1 = New Label()
        btnStandUser1 = New Button()
        btnAdmin1 = New Button()
        Panel1.SuspendLayout()
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
        Panel1.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(46, 23)
        Label3.Name = "Label3"
        Label3.Size = New Size(432, 23)
        Label3.TabIndex = 7
        Label3.Text = "TRICYCLE FRANCHISE INFORMATION SYSTEM"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(204), CByte(51), CByte(136))
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 651)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1348, 70)
        Panel2.TabIndex = 2
        ' 
        ' labelSignIn1
        ' 
        labelSignIn1.Anchor = AnchorStyles.None
        labelSignIn1.AutoSize = True
        labelSignIn1.Font = New Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelSignIn1.Location = New Point(503, 160)
        labelSignIn1.Name = "labelSignIn1"
        labelSignIn1.Size = New Size(345, 106)
        labelSignIn1.TabIndex = 4
        labelSignIn1.Text = "SIGN IN"
        ' 
        ' btnStandUser1
        ' 
        btnStandUser1.Anchor = AnchorStyles.None
        btnStandUser1.BackColor = SystemColors.ActiveCaptionText
        btnStandUser1.Cursor = Cursors.Hand
        btnStandUser1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnStandUser1.ForeColor = SystemColors.ButtonHighlight
        btnStandUser1.Location = New Point(567, 285)
        btnStandUser1.Name = "btnStandUser1"
        btnStandUser1.Size = New Size(210, 70)
        btnStandUser1.TabIndex = 5
        btnStandUser1.Text = "Standard User"
        btnStandUser1.UseVisualStyleBackColor = False
        ' 
        ' btnAdmin1
        ' 
        btnAdmin1.Anchor = AnchorStyles.None
        btnAdmin1.BackColor = SystemColors.ControlDarkDark
        btnAdmin1.Cursor = Cursors.Hand
        btnAdmin1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAdmin1.ForeColor = SystemColors.ButtonHighlight
        btnAdmin1.Location = New Point(567, 364)
        btnAdmin1.Name = "btnAdmin1"
        btnAdmin1.Size = New Size(210, 70)
        btnAdmin1.TabIndex = 6
        btnAdmin1.Text = "Administrator"
        btnAdmin1.UseVisualStyleBackColor = False
        ' 
        ' LoginSecondPage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1348, 721)
        Controls.Add(btnAdmin1)
        Controls.Add(btnStandUser1)
        Controls.Add(labelSignIn1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "LoginSecondPage"
        StartPosition = FormStartPosition.CenterScreen
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents labelSignIn1 As Label
    Friend WithEvents btnStandUser1 As Button
    Friend WithEvents btnAdmin1 As Button
    Friend WithEvents Label3 As Label
End Class
