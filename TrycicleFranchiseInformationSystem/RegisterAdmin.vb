Imports System.Text
Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography

Public Class RegisterAdmin

    Private Sub txboxADMUS_Enter(sender As Object, e As EventArgs) Handles txboxADMUS.Enter
        If txboxADMUS.Text = "Enter Username" Then

            txboxADMUS.Text = ""
            txboxADMUS.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txboxADMUS_Leave(sender As Object, e As EventArgs) Handles txboxADMUS.Leave
        If txboxADMUS.Text = "" Then

            txboxADMUS.Text = "Enter Username"
            txboxADMUS.ForeColor = Color.Silver
        End If

    End Sub

    Private Sub txtboxEmailAD_Enter(sender As Object, e As EventArgs) Handles txtboxEmailAD.Enter
        If txtboxEmailAD.Text = "Enter Email" Then

            txtboxEmailAD.Text = ""
            txtboxEmailAD.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtboxEmailAD_Leave(sender As Object, e As EventArgs) Handles txtboxEmailAD.Leave
        If txtboxEmailAD.Text = "" Then
            txtboxEmailAD.Text = "Enter Email"
            txtboxEmailAD.ForeColor = Color.Silver
        End If
    End Sub



    Private Sub btnTglPassAD_Click(sender As Object, e As EventArgs) Handles btnTglPassAD.Click

        If txtboxPassADMUS.PasswordChar = "*"c Then
            txtboxPassADMUS.PasswordChar = ControlChars.NullChar
        Else
            txtboxPassADMUS.PasswordChar = "*"c
        End If

        If txtboxCnfrmADMUS.PasswordChar = "*"c Then
            txtboxCnfrmADMUS.PasswordChar = ControlChars.NullChar
        Else
            txtboxCnfrmADMUS.PasswordChar = "*"c
        End If
    End Sub
    Dim connString As String = "Server=127.0.0.1;Database=exampletest;Uid=root;Pwd=;"


    Private Sub btnSignupADMSU_Click(sender As Object, e As EventArgs) Handles btnSignupADMSU.Click
        If AreAllFieldsValid() Then
            If RegisterAdminToDatabase() Then
                Dim placeholderForm As New Placeholder
                placeholderForm.Show()
                Me.Hide()
            End If
        End If
    End Sub

    Private Function RegisterAdminToDatabase() As Boolean
        Dim conn As New MySqlConnection(connString)
        Try
            conn.Open()

            Dim query As String = "INSERT INTO sampletable2 (username, emailaddress, password) VALUES (@Username, @Email, @Password)"
            Dim key As String = "YourEncryptionKeyHere"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Username", txboxADMUS.Text)
                cmd.Parameters.AddWithValue("@Email", txtboxEmailAD.Text)
                cmd.Parameters.AddWithValue("@Password", txtboxPassADMUS.Text)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Admin registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            conn.Close()
        End Try
    End Function

    Private Function IsPasswordValid(password As String) As Boolean
        Dim passwordRegex As New Regex(PasswordComplexityPattern)
        Return passwordRegex.IsMatch(password)
    End Function

    Function IsPasswordConfirmed() As Boolean
        Return txtboxPassADMUS.Text = txtboxCnfrmADMUS.Text
    End Function

    Private Const PasswordComplexityPattern As String = "^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{8,}$"

    Private Function AreAllFieldsValid() As Boolean
        If txboxADMUS.Text = "" OrElse txboxADMUS.Text = "Enter Username" Then
            MessageBox.Show("Please enter a Username.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        ElseIf txtboxEmailAD.Text = "" OrElse txtboxEmailAD.Text = "Enter Email" Then
            MessageBox.Show("Please enter an Email.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        ElseIf txtboxPassADMUS.Text = "" OrElse txtboxPassADMUS.Text = "Enter your password" Then
            MessageBox.Show("Please enter a password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        ElseIf Not IsPasswordValid(txtboxPassADMUS.Text) Then
            MessageBox.Show("Password must be at least 8 characters, contain at least one uppercase letter, one lowercase letter, and one number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        ElseIf Not IsPasswordConfirmed() Then
            MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function

    Private Sub RegisterAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtboxPassADMUS.PasswordChar = "*"c
        txtboxCnfrmADMUS.PasswordChar = "*"c
    End Sub

End Class