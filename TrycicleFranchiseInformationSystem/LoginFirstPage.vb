Public Class LoginFirstPage
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnContinue1.Click
        Dim form2 As New LoginSecondPage()

        form2.Show()
    End Sub


End Class
