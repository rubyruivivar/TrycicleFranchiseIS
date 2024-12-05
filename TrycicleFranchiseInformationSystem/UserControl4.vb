Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.Cmp

Public Class Form1franchisee
    Private Sub Form1franchisee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Fill

        ' Set placeholders for all ComboBoxes
        SetComboBoxPlaceholder(cbxgender, "Gender")
        SetComboBoxPlaceholder(cbxCivilStatus, "Civil Status")
        SetComboBoxPlaceholder(cbxMunicipality, "Municipality")
        SetComboBoxPlaceholder(cbxvalidID, "Valid ID")
    End Sub

    ' ComboBox Placeholder Logic
    Private Sub ComboBox_GotFocus(sender As Object, e As EventArgs) _
        Handles cbxgender.GotFocus, cbxCivilStatus.GotFocus, cbxMunicipality.GotFocus, cbxvalidID.GotFocus

        Dim comboBox As ComboBox = CType(sender, ComboBox)

        ' Clear placeholder text on focus
        If comboBox.ForeColor = Color.Gray Then
            comboBox.Text = ""
            comboBox.ForeColor = Color.Black
        End If
    End Sub

    Private Sub ComboBox_LostFocus(sender As Object, e As EventArgs) _
        Handles cbxgender.LostFocus, cbxCivilStatus.LostFocus, cbxMunicipality.LostFocus, cbxvalidID.LostFocus

        Dim comboBox As ComboBox = CType(sender, ComboBox)

        ' Restore placeholder text if no value is selected
        If String.IsNullOrWhiteSpace(comboBox.Text) Then
            Select Case comboBox.Name
                Case "cbxgender"
                    SetComboBoxPlaceholder(comboBox, "Gender")
                Case "cbxCivilStatus"
                    SetComboBoxPlaceholder(comboBox, "Civil Status")
                Case "cbxMunicipality"
                    SetComboBoxPlaceholder(comboBox, "Municipality")
                Case "cbxvalidID"
                    SetComboBoxPlaceholder(comboBox, "Valid ID")
            End Select
        End If
    End Sub

    Private Sub SetComboBoxPlaceholder(comboBox As ComboBox, placeholder As String)
        comboBox.Text = placeholder
        comboBox.ForeColor = Color.Gray
    End Sub

    ' Save Button Click to Insert Data into the Database
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            ' Validation: Check if the required fields are not empty
            If cbxgender.Text = "Gender" OrElse cbxCivilStatus.Text = "Civil Status" OrElse cbxMunicipality.Text = "Municipality" OrElse cbxvalidID.Text = "Valid ID" Then
                MsgBox("Please fill in all required fields.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If tbfirstname.Text.Trim = Nothing Then
                MsgBox("Enter First Name.")
                tbfirstname.Focus()
                Exit Sub
            End If
            If tblastname.Text.Trim = Nothing Then
                MsgBox("Enter Last Name.")
                tblastname.Focus()
                Exit Sub
            End If
            If tbphonenum.Text.Trim = Nothing Then
                MsgBox("Enter Phone Number.")
                tbphonenum.Focus()
                Exit Sub
            End If
            If tblicensenum.Text.Trim = Nothing Then
                MsgBox("Enter License Number.")
                tblicensenum.Focus()
                Exit Sub
            End If
            If tbinsurance.Text.Trim = Nothing Then
                MsgBox("Enter Insurance Policy Number.")
                tbinsurance.Focus()
                Exit Sub
            End If
            If tbbarangay.Text.Trim = Nothing Then
                MsgBox("Enter Barangay.")
                tbbarangay.Focus()
                Exit Sub
            End If

            If dtpdateofbirth.Value = dtpdateofbirth.MinDate Then
                MsgBox("Please select valid dates.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            ' Construct the SQL query to insert the new renewal record
            Dim query As String = String.Format("INSERT INTO franchiseedatabase " &
                                                "(first_name, middle_name, last_name, gender, date_of_birth, phone_number, barangay, municipality, valid_id, license_number, insurance_policy_number, civil_status) " &
                                                "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}')",
                                                tbfirstname.Text.Trim, tbmiddlename.Text.Trim, tblastname.Text.Trim,
                                                cbxgender.Text.Trim, dtpdateofbirth.Value.ToString("yyyy-MM-dd"), tbphonenum.Text.Trim,
                                                tbbarangay.Text.Trim, cbxMunicipality.Text.Trim, cbxvalidID.Text.Trim,
                                                tblicensenum.Text.Trim, tbinsurance.Text.Trim, cbxCivilStatus.Text.Trim)

            ' Execute the query using the module method
            ' RenewalDatabaseModule.ExecuteNonQuery(query)
            modDB.readQuery(query)

            MsgBox("New renewal record saved successfully!", MsgBoxStyle.Information)

            ' Optionally, clear the form after saving
            ClearFormFields()

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    ' Clear form fields after successful save
    Private Sub ClearFormFields()
        tbfirstname.Clear()
        tbmiddlename.Clear()
        tblastname.Clear()
        tbphonenum.Clear()
        tbbarangay.Clear()
        tblicensenum.Clear()
        tbinsurance.Clear()

        cbxgender.Text = "Gender"
        cbxCivilStatus.Text = "Civil Status"
        cbxMunicipality.Text = "Municipality"
        cbxvalidID.Text = "Valid ID"
        cbxgender.ForeColor = Color.Gray
        cbxCivilStatus.ForeColor = Color.Gray
        cbxMunicipality.ForeColor = Color.Gray
        cbxvalidID.ForeColor = Color.Gray



    End Sub


End Class



