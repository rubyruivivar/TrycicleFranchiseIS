Public Class EntryForms
    Private Sub EntryForms_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PanelForms.Controls.Clear()
        Dim form1franchisee As New Form1franchisee()
        PanelForms.Controls.Add(form1franchisee)
        form1franchisee.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PanelForms.Controls.Clear()
        Dim form2franchise As New Form2franchise()
        PanelForms.Controls.Add(form2franchise)
        form2franchise.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PanelForms.Controls.Clear()
        Dim form3vehicle As New Form3vehicle()
        PanelForms.Controls.Add(form3vehicle)
        form3vehicle.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        PanelForms.Controls.Clear()
        Dim form4regulatory As New Form4regulatory()
        PanelForms.Controls.Add(form4regulatory)
        form4regulatory.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        PanelForms.Controls.Clear()
        Dim form5Renewal As New Form5Renewal()
        PanelForms.Controls.Add(form5Renewal)
        form5Renewal.Show()
    End Sub

    Private Sub PanelForms_Paint(sender As Object, e As PaintEventArgs) Handles PanelForms.Paint

    End Sub
End Class
