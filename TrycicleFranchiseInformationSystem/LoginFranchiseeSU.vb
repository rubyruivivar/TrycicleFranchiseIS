Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class LoginFranchiseeSU

    Private Sub TxboxPNUMSI_Enter(sender As Object, e As EventArgs) Handles txboxPNUMSI.Enter
        If txboxPNUMSI.Text = "09XXXXXXXXX" Then

            txboxPNUMSI.Text = ""
            txboxPNUMSI.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TxboxPNUMSI_Leave(sender As Object, e As EventArgs) Handles txboxPNUMSI.Leave
        If txboxPNUMSI.Text = "" Then

            txboxPNUMSI.Text = "09XXXXXXXXX"
            txboxPNUMSI.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub TxboxFNAMSI_Enter(sender As Object, e As EventArgs) Handles txboxFNAMSI.Enter
        If txboxFNAMSI.Text = "First Name" Then

            txboxFNAMSI.Text = ""
            txboxFNAMSI.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TxboxFNAMSI_Leave(sender As Object, e As EventArgs) Handles txboxFNAMSI.Leave
        If txboxFNAMSI.Text = "" Then

            txboxFNAMSI.Text = "First Name"
            txboxFNAMSI.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub TxboxLNAMSI_Enter(sender As Object, e As EventArgs) Handles txboxLNAMSI.Enter
        If txboxLNAMSI.Text = "Last Name" Then

            txboxLNAMSI.Text = ""
            txboxLNAMSI.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TxboxLNAMSI_Leave(sender As Object, e As EventArgs) Handles txboxLNAMSI.Leave
        If txboxLNAMSI.Text = "" Then

            txboxLNAMSI.Text = "Last Name"
            txboxLNAMSI.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub TxboxMNAMSI_Enter(sender As Object, e As EventArgs) Handles txboxMNAMSI.Enter
        If txboxMNAMSI.Text = "Middle Name (Optional)" Then

            txboxMNAMSI.Text = ""
            txboxMNAMSI.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TxboxMNAMSI_Leave(sender As Object, e As EventArgs) Handles txboxMNAMSI.Leave
        If txboxMNAMSI.Text = "" Then

            txboxMNAMSI.Text = "Middle Name (Optional)"
            txboxMNAMSI.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub TxtboxBrngy_Enter(sender As Object, e As EventArgs) Handles txtboxBrngy.Enter
        If txtboxBrngy.Text = "Barangay" Then

            txtboxBrngy.Text = ""
            txtboxBrngy.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TxtboxBrngy_Leave(sender As Object, e As EventArgs) Handles txtboxBrngy.Leave
        If txtboxBrngy.Text = "" Then

            txtboxBrngy.Text = "Barangay"
            txtboxBrngy.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub TxtboxMncplty_Enter(sender As Object, e As EventArgs) Handles txtboxMncplty.Enter
        If txtboxMncplty.Text = "Municipality" Then

            txtboxMncplty.Text = ""
            txtboxMncplty.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TxtboxMncplty_Leave(sender As Object, e As EventArgs) Handles txtboxMncplty.Leave
        If txtboxMncplty.Text = "" Then

            txtboxMncplty.Text = "Municipality"
            txtboxMncplty.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub TxtboxPrvnce_Enter(sender As Object, e As EventArgs) Handles txtboxPrvnce.Enter
        If txtboxPrvnce.Text = "Province" Then

            txtboxPrvnce.Text = ""
            txtboxPrvnce.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TxtboxPrvnce_Leave(sender As Object, e As EventArgs) Handles txtboxPrvnce.Leave
        If txtboxPrvnce.Text = "" Then

            txtboxPrvnce.Text = "Province"
            txtboxPrvnce.ForeColor = Color.Silver
        End If
    End Sub



    Private Sub TxboxLNAMSI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txboxLNAMSI.KeyPress
        ' Allow only letters, control characters (like Backspace), and spaces
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True ' Prevent the character from being entered into the TextBox
        End If
    End Sub

    Private Sub TxboxFNAMSI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txboxFNAMSI.KeyPress
        ' Allow only letters, control characters (like Backspace), and spaces
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True ' Prevent the character from being entered into the TextBox
        End If
    End Sub
    Private Sub TxboxMNAMSI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txboxMNAMSI.KeyPress
        ' Allow only letters, control characters (like Backspace), and spaces
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True ' Prevent the character from being entered into the TextBox
        End If
    End Sub
    Private Sub TxboxPNUMSI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txboxPNUMSI.KeyPress
        ' Allow only digits
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

        ' Allow only 11 digits
        If txboxPNUMSI.Text.Length >= 11 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        combbxGender.Items.Add("Male")
        combbxGender.Items.Add("Female")
        combbxGender.Items.Add("Non-binary/Other")

        dtmepickerDOBSI.Format = DateTimePickerFormat.Custom
        dtmepickerDOBSI.CustomFormat = "MM/dd/yyyy"

        txtboxPassSI.PasswordChar = "*"c
        txtboxConfirmPass.PasswordChar = "*"c

    End Sub

    Private Sub TxtbxZipCod_TextChanged(sender As Object, e As EventArgs) Handles txtbxZipCod.TextChanged
        ' Avoid processing if the placeholder text is present
        If txtbxZipCod.Text = "Zip Code" Then
            txtbxZipCod.ForeColor = Color.Silver
            Return
        End If

        ' Ensure only digits are entered and limit to 4 characters
        txtbxZipCod.Text = New String(txtbxZipCod.Text.Where(Function(c) Char.IsDigit(c)).ToArray())

        ' Trim the length to 4 digits if it exceeds
        If txtbxZipCod.Text.Length > 4 Then
            txtbxZipCod.Text = txtbxZipCod.Text.Substring(0, 4)
        End If

        ' Set cursor position to the end
        txtbxZipCod.SelectionStart = txtbxZipCod.Text.Length
    End Sub

    Private Sub TxtbxZipCod_Enter(sender As Object, e As EventArgs) Handles txtbxZipCod.Enter
        ' Clear placeholder text when entering
        If txtbxZipCod.Text = "Zip Code" Then
            txtbxZipCod.Text = ""
            txtbxZipCod.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TxtbxZipCod_Leave(sender As Object, e As EventArgs) Handles txtbxZipCod.Leave
        ' Restore placeholder text if TextBox is empty when leaving
        If txtbxZipCod.Text = "" Then
            txtbxZipCod.Text = "Zip Code"
            txtbxZipCod.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub DtmepickerDOBSI_ValueChanged(sender As Object, e As EventArgs) Handles dtmepickerDOBSI.ValueChanged
        dtmepickerDOBSI.Format = DateTimePickerFormat.Custom
        dtmepickerDOBSI.CustomFormat = "MM/dd/yyyy"
    End Sub


    Function IsPasswordStrong(password As String) As Boolean
        If password.Length < 8 Then Return False ' Minimum length requirement
        If Not System.Text.RegularExpressions.Regex.IsMatch(password, "[A-Z]") Then Return False ' At least one uppercase letter
        If Not System.Text.RegularExpressions.Regex.IsMatch(password, "[a-z]") Then Return False ' At least one lowercase letter
        If Not System.Text.RegularExpressions.Regex.IsMatch(password, "[0-9]") Then Return False ' At least one digit
        Return True
    End Function

    Function IsPasswordConfirmed() As Boolean
        Return txtboxPassSI.Text = txtboxConfirmPass.Text
    End Function

    Private PlaceholderPassword As String = "Enter your password"
    Private PlaceholderConfirmPassword As String = "Confirm your password"

    Private Const PasswordMinLength As Integer = 8
    Private Const PasswordComplexityPattern As String = "^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{8,}$"
    Private Sub mtxboxFID_Leave(sender As Object, e As EventArgs) Handles mtxboxFID.Leave
        Dim pattern As String = "^\d{2}-\d{3}$"  ' Regular expression pattern for 00-000
        Dim input As String = mtxboxFID.Text

        If Not System.Text.RegularExpressions.Regex.IsMatch(input, pattern) Then
            MessageBox.Show("Please enter the Franchisee ID in the format 00-000", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            mtxboxFID.Focus()
            mtxboxFID.SelectAll()
        End If
    End Sub

    ' Button Click to Submit
    Private Function AreAllFieldsValid() As Boolean

        Dim pattern As String = "^\d{2}-\d{3}$"
        Dim inputFID As String = mtxboxFID.Text

        ' Check if Franchisee ID matches the pattern
        If Not System.Text.RegularExpressions.Regex.IsMatch(inputFID, pattern) Then
            MessageBox.Show("Please enter the Franchisee ID in the format 00-000", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            mtxboxFID.Focus()
            mtxboxFID.SelectAll()
            Return False
        End If

        ' Check if each required field is filled out
        If txboxPNUMSI.Text = "" OrElse txboxPNUMSI.Text = "09XXXXXXXXX" Then
            MessageBox.Show("Please enter a valid phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        ElseIf txboxFNAMSI.Text = "" OrElse txboxFNAMSI.Text = "First Name" Then
            MessageBox.Show("Please enter your first name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        ElseIf txboxLNAMSI.Text = "" OrElse txboxLNAMSI.Text = "Last Name" Then
            MessageBox.Show("Please enter your last name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        ElseIf txtboxBrngy.Text = "" OrElse txtboxBrngy.Text = "Barangay" Then
            MessageBox.Show("Please enter your barangay.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        ElseIf txtboxMncplty.Text = "" OrElse txtboxMncplty.Text = "Municipality" Then
            MessageBox.Show("Please enter your municipality.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        ElseIf txtboxPrvnce.Text = "" OrElse txtboxPrvnce.Text = "Province" Then
            MessageBox.Show("Please enter your province.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        ElseIf txtbxZipCod.Text = "" OrElse txtbxZipCod.Text = "Zip Code" Then
            MessageBox.Show("Please enter your zip code.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        ElseIf combbxGender.SelectedIndex = -1 Then
            MessageBox.Show("Please select your gender.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        ElseIf txtboxPassSI.Text = "" OrElse txtboxPassSI.Text = PlaceholderPassword Then
            MessageBox.Show("Please enter a password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        ElseIf Not IsPasswordValid(txtboxPassSI.Text) Then
            MessageBox.Show("Password must be at least 8 characters, contain at least one uppercase letter, one lowercase letter, and one number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        ElseIf Not IsPasswordConfirmed() Then
            MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        ' All validations passed
        Return True
    End Function

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSignupSi.Click
        ' Perform validation check before proceeding
        If AreAllFieldsValid() Then
            ' Database connection string
            Dim connectionString As String = "Server=127.0.0.1;Database=exampletest;Uid=root;Pwd=;"
            Using connection As New MySqlConnection(connectionString)
                Try
                    connection.Open()

                    ' Insert data into the database
                    Dim query As String = "INSERT INTO samplelatest (franchiseeID, PhoneNumber, firstname, middlename, lastname, barangay, " &
"municipality, province, zipcode, birthdate, gender, password) " &
"VALUES (@franchiseeID, @PhoneNumber, @firstname, @middlename, @lastname, @barangay, " &
"@municipality, @province, @zipcode, @birthdate, @gender, @password)"

                    Using cmd As New MySqlCommand(query, connection)
                        ' Add parameters
                        cmd.Parameters.AddWithValue("@franchiseeID", mtxboxFID.Text)
                        cmd.Parameters.AddWithValue("@PhoneNumber", txboxPNUMSI.Text)
                        cmd.Parameters.AddWithValue("@firstname", txboxFNAMSI.Text)
                        cmd.Parameters.AddWithValue("@middlename", txboxMNAMSI.Text)
                        cmd.Parameters.AddWithValue("@lastname", txboxLNAMSI.Text)
                        cmd.Parameters.AddWithValue("@barangay", txtboxBrngy.Text)
                        cmd.Parameters.AddWithValue("@municipality", txtboxMncplty.Text)
                        cmd.Parameters.AddWithValue("@province", txtboxPrvnce.Text)
                        cmd.Parameters.AddWithValue("@zipcode", txtbxZipCod.Text)
                        cmd.Parameters.AddWithValue("@birthdate", dtmepickerDOBSI.Value.ToString("yyyy-MM-dd"))
                        cmd.Parameters.AddWithValue("@gender", combbxGender.Text)
                        cmd.Parameters.AddWithValue("@password", txtboxPassSI.Text) ' Consider hashing the password

                        ' Execute the command
                        cmd.ExecuteNonQuery()
                        MessageBox.Show("Sign up successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Using
                Catch ex As Exception
                    MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    connection.Close()
                End Try
            End Using

            ' Proceed to Placeholder form if sign-up is successful
            Dim placeholderForm As New Placeholder
            placeholderForm.Show()
            Me.Hide()
        End If
    End Sub
    ' Function to validate password length and complexity
    Private Function IsPasswordValid(password As String) As Boolean
        ' Check if the password matches the regex pattern (minimum 8 characters, at least 1 lowercase, 1 uppercase, 1 number, 1 special character)
        Dim passwordRegex As New Regex(PasswordComplexityPattern)
        Return passwordRegex.IsMatch(password)
    End Function
    Private Sub btnTogglePassword_Click(sender As Object, e As EventArgs) Handles btnTogglePassword.Click
        ' Toggle the password visibility
        If txtboxPassSI.PasswordChar = "*"c Then
            txtboxPassSI.PasswordChar = ControlChars.NullChar ' Show the password
        Else
            txtboxPassSI.PasswordChar = "*"c ' Hide the password
        End If

        If txtboxConfirmPass.PasswordChar = "*"c Then
            txtboxConfirmPass.PasswordChar = ControlChars.NullChar ' Show the confirm password
        Else
            txtboxConfirmPass.PasswordChar = "*"c ' Hide the confirm password
        End If
    End Sub



End Class


