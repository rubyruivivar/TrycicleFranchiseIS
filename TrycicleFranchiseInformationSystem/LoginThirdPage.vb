Public Class LoginThirdPage
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnLogin1.Click
        Dim form4 As New Form4()

        form4.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSignup1.Click
        Dim form5 As New LoginFranchiseeSU()

        form5.Show()
    End Sub
End Class