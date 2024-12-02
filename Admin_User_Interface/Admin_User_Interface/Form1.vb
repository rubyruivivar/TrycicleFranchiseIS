Public Class Form1

    Private Sub RoundedButton(j As Button)
        j.FlatAppearance.BorderSize = 0
        j.FlatStyle = FlatStyle.Flat
        j.BackColor = Color.Black
        j.ForeColor = Color.White
        j.Cursor = Cursors.Hand
        j.Font = New Font("Impact", 12)

        Dim v As New Drawing2D.GraphicsPath
        v.StartFigure()

        v.AddArc(New RectangleF(0, 0, 40, 40), 180, 90)
        v.AddLine(40, 0, j.Width - 40, 0)

        v.AddArc(New RectangleF(j.Width - 40, 0, 40, 40), -90, 90)
        v.AddLine(j.Width, 40, j.Width, j.Height - 40)

        v.AddArc(New RectangleF(j.Width - 40, j.Height - 40, 40, 40), 0, 90)
        v.AddLine(j.Width - 40, j.Height, 40, j.Height)

        v.AddArc(New RectangleF(0, j.Height - 40, 40, 40), 90, 90)
        v.CloseAllFigures()

        j.Region = New Region(v)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim next_form As New Choose()
        next_form.Show()
        Me.Hide()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RoundedButton(Button1)
    End Sub

    Private Sub Form1(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to close?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
End Class