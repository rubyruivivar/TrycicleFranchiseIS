Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class LoginAdminLOGIN

    Private Sub txtboxUserAd1_Enter(sender As Object, e As EventArgs) Handles txtboxUserAd1.Enter
        If txtboxUserAd1.Text = "Enter Username" Then

            txtboxUserAd1.Text = ""
            txtboxUserAd1.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtboxUserAd1_Leave(sender As Object, e As EventArgs) Handles txtboxUserAd1.Leave
        If txtboxUserAd1.Text = "" Then

            txtboxUserAd1.Text = "Enter Username"
            txtboxUserAd1.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub txtboxPassUserad1_Enter(sender As Object, e As EventArgs) Handles txtboxPassUserad1.Enter
        If txtboxPassUserad1.Text = "Enter Password" Then

            txtboxPassUserad1.Text = ""
            txtboxPassUserad1.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtboxPassUserad1_Leave(sender As Object, e As EventArgs) Handles txtboxPassUserad1.Leave
        If txtboxPassUserad1.Text = "" Then

            txtboxPassUserad1.Text = "Enter Password"
            txtboxPassUserad1.ForeColor = Color.Silver
        End If
    End Sub

    ' Login button click event
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnContinue3.Click
        '    ' Retrieve admin input
        Dim adminUsername As String = txtboxUserAd1.Text
        Dim adminPassword As String = txtboxPassUserad1.Text

        ' Validate input fields
        If String.IsNullOrWhiteSpace(adminUsername) Or String.IsNullOrWhiteSpace(adminPassword) Then
            MessageBox.Show("Please enter your Username and Password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Database connection string
        Dim connString As String = "Server=127.0.0.1;Database=exampletest;Uid=root;Pwd=;"

        ' Create a connection to the database
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()

                ' SQL query to validate admin credentials
                Dim query As String = "SELECT COUNT(1) FROM sampletable2 WHERE username=@username AND password=@password"

                ' Create command object
                Using cmd As New MySqlCommand(query, conn)
                    ' Add parameters to prevent SQL injection
                    cmd.Parameters.AddWithValue("@username", adminUsername)
                    cmd.Parameters.AddWithValue("@password", adminPassword) ' Consider adding hashed passwords

                    ' Execute the query
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    If count = 1 Then
                        MessageBox.Show("Admin Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ' Open the admin dashboard
                        Dim placeholderForm As New Placeholder
                        placeholderForm.Show()
                        Me.Hide() ' Hide the login form
                    Else
                        MessageBox.Show("Invalid Username or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                conn.Close()
            End Try
        End Using

    End Sub

    Public Shared RegistrationComplete As Boolean = False

    Private Sub LoginAdminLOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtboxPassUserad1.PasswordChar = "*"c

        If GetRowCount() >= 2 Then
            lnklbl_Admin.Visible = False ' Hide the link label
        Else
            lnklbl_Admin.Visible = True ' Show the link label
        End If
    End Sub

    Private Sub lnklbl_Admin_Click(sender As Object, e As EventArgs) Handles lnklbl_Admin.Click
        ' Open the register form
        Dim registerForm As New RegisterAdmin
        registerForm.Show()
        Me.Hide()
    End Sub

    Private Function GetRowCount() As Integer
        Dim connString As String = "Server=127.0.0.1;Database=exampletest;Uid=root;Pwd=;"
        Dim rowCount As Integer = 0

        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()
                Dim query As String = "SELECT COUNT(*) FROM sampletable2" ' Adjust table name if necessary
                Using cmd As New MySqlCommand(query, conn)
                    rowCount = Convert.ToInt32(cmd.ExecuteScalar())
                End Using
            Catch ex As Exception
                MessageBox.Show("An error occurred while fetching data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                conn.Close()
            End Try
        End Using

        Return rowCount
    End Function

    Private Sub btnTogglePasswordAP_Click(sender As Object, e As EventArgs) Handles btnTogglePasswordAP.Click
        If txtboxPassUserad1.PasswordChar = "*"c Then
            txtboxPassUserad1.PasswordChar = ControlChars.NullChar ' Show the password
        Else
            txtboxPassUserad1.PasswordChar = "*"c ' Hide the password
        End If
    End Sub
End Class