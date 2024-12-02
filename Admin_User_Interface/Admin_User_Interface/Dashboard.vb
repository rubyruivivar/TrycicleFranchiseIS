Public Class Dashboard

    Private WithEvents Profile As Button
    Private WithEvents Services As Button
    Private WithEvents Request As Button
    Private WithEvents About As Button
    Private WithEvents Logout As Button

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    End Sub

    Private Sub Profile_Click(sender As Object, e As EventArgs) Handles Profile.Click

    End Sub

    Private Sub Services_Click(sender As Object, e As EventArgs) Handles Services.Click

    End Sub

    Private Sub Request_Click(sender As Object, e As EventArgs) Handles Request.Click

    End Sub

    Private Sub About_Click(sender As Object, e As EventArgs) Handles About.Click

    End Sub

    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click

    End Sub

    Private Sub Dashboard(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to close?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
End Class