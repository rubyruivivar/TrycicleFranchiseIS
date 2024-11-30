Public Class LoginSecondPage
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnStandUser1.Click
        Dim form3 As New LoginThirdPage()

        form3.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnAdmin1.Click
        Dim form7 As New LoginAdminHome()

        form7.Show()
    End Sub
End Class