﻿Imports MySql.Data.MySqlClient

Public Class Userlogin

    'Dim connString As String = "Server=localhost;Database=your_database;Uid=your_username;Pwd=your_password;"

    ' Placeholder behavior for Franchisee ID text box
    Private Sub txtboxFranchiseeID1_Enter(sender As Object, e As EventArgs) Handles txtboxFranchiseeID1.Enter
        If txtboxFranchiseeID1.Text = "Enter Franchisee ID" Then
            txtboxFranchiseeID1.Text = ""
            txtboxFranchiseeID1.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtboxFranchiseeID1_Leave(sender As Object, e As EventArgs) Handles txtboxFranchiseeID1.Leave
        If txtboxFranchiseeID1.Text = "" Then
            txtboxFranchiseeID1.Text = "Enter Franchisee ID"
            txtboxFranchiseeID1.ForeColor = Color.Silver
        End If
    End Sub

    ' Placeholder behavior for Password text box
    Private Sub txtboxPassFID1_Enter(sender As Object, e As EventArgs) Handles txtboxPassFID1.Enter
        If txtboxPassFID1.Text = "Enter Password" Then
            txtboxPassFID1.Text = ""
            txtboxPassFID1.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtboxPassFID1_Leave(sender As Object, e As EventArgs) Handles txtboxPassFID1.Leave
        If txtboxPassFID1.Text = "" Then
            txtboxPassFID1.Text = "Enter Password"
            txtboxPassFID1.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnContinue2.Click
        ' Retrieve user input
        Dim franchiseeId As String = txtboxFranchiseeID1.Text
        Dim enteredPassword As String = txtboxPassFID1.Text

        ' Validate input fields
        If String.IsNullOrWhiteSpace(franchiseeId) Or String.IsNullOrWhiteSpace(enteredPassword) Then
            MessageBox.Show("Please enter your Franchisee ID and Password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Database connection string
        Dim connString As String = "Server=127.0.0.1;Database=exampletest;Uid=root;Pwd=;"

        ' Create a connection to the database
        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()

                ' SQL query to retrieve the encrypted password
                Dim query As String = "SELECT password FROM samplelatest WHERE franchiseeID=@id"

                ' Create command object
                Using cmd As New MySqlCommand(query, conn)
                    ' Add parameters to prevent SQL injection
                    cmd.Parameters.AddWithValue("@id", franchiseeId)

                    ' Retrieve encrypted password
                    Dim encryptedPassword As String = Convert.ToString(cmd.ExecuteScalar())

                    If String.IsNullOrEmpty(encryptedPassword) Then
                        MessageBox.Show("Invalid Franchisee ID or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If

                    ' Decrypt the password
                    Dim decryptedPassword As String = Decrypt(encryptedPassword)

                    ' Compare with entered password
                    If decryptedPassword = enteredPassword Then
                        MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ' Open the next form
                        Dim Form1 As New Form1
                        Form1.Show()
                        Me.Hide() ' Hide the login form
                    Else
                        MessageBox.Show("Invalid Franchisee ID or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                conn.Close()
            End Try
        End Using
    End Sub


    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtboxPassFID1.PasswordChar = "*"c
        txtboxPassFID1.PasswordChar = "*"c
    End Sub

    Private Sub btnTogglePasswordFS_Click(sender As Object, e As EventArgs) Handles btnTogglePasswordFS.Click
        If txtboxPassFID1.PasswordChar = "*"c Then
            txtboxPassFID1.PasswordChar = ControlChars.NullChar ' Show the password
        Else
            txtboxPassFID1.PasswordChar = "*"c ' Hide the password
        End If
    End Sub
End Class