Public Class Usercontrol10
    Dim recordCount As Integer = 0
    Dim searchQuery As String = ""

    ' Refresh Renewal DataGridView
    Private Sub RefreshFranchiseelData()
        Try
            Dim query As String = "SELECT `franchisee_id` AS 'Franchisee ID', `first_name` AS 'First Name', `middle_name` AS 'Middle Name', " &
                                  "`last_name` AS 'Last Name', `gender` AS 'Gender', `date_of_birth` AS 'Birthdate', " &
                                  "`phone_number` AS 'Phone Number', `barangay` AS 'Barangay', `municipality` AS 'Municipality', " &
                                  "`city_province` AS 'City/Province', `zip_code` AS 'Zip Code', `valid_id` AS 'Valid ID', `license_number` AS 'License Number', " &
                                  "`insurance_policy_number` AS 'Insurance Policy Number', `civil_status` AS 'Civil Status' FROM franchiseedatabase " & searchQuery

            recordCount = modDB.LoadToDGV(query, dgvFranchisee)
            lblRecordCount.Text = "Total Records: " & recordCount
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    ' Load Event
    Private Sub Usercontrol10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Fill

        ' Set placeholders for all ComboBoxes
        SetComboBoxPlaceholder(cbxgender, "Gender")
        SetComboBoxPlaceholder(cbxCivilStatus, "Civil Status")
        SetComboBoxPlaceholder(cbxMunicipality, "Municipality")
        SetComboBoxPlaceholder(cbxvalidID, "Valid ID")

        RefreshFranchiseelData()
    End Sub

    ' Search Bar KeyPress Event
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        ' Update search query to filter by the input text across multiple fields
        searchQuery = "WHERE `franchisee_id` LIKE '%" & txtSearch.Text & "%' OR `first_name` LIKE '%" & txtSearch.Text & "%' " &
                  "OR `middle_name` LIKE '%" & txtSearch.Text & "%' OR `last_name` LIKE '%" & txtSearch.Text & "%' " &
                  "OR `gender` LIKE '%" & txtSearch.Text & "%' OR `date_of_birth` LIKE '%" & txtSearch.Text & "%' " &
                  "OR `phone_number` LIKE '%" & txtSearch.Text & "%' OR `barangay` LIKE '%" & txtSearch.Text & "%' " &
                  "OR `municipality` LIKE '%" & txtSearch.Text & "%' OR `city_province` LIKE '%" & txtSearch.Text & "%' " &
                  "OR `zip_code` LIKE '%" & txtSearch.Text & "%' OR `valid_id` LIKE '%" & txtSearch.Text & "%' " &
                  "OR `license_number` LIKE '%" & txtSearch.Text & "%' OR `insurance_policy_number` LIKE '%" & txtSearch.Text & "%' " &
                  "OR `civil_status` LIKE '%" & txtSearch.Text & "%'"

        ' Refresh the DataGridView with filtered data
        RefreshFranchiseelData()
    End Sub

    ' Button Click for Search
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ' Same logic can be applied if a dedicated search button is used
        searchQuery = "WHERE `franchisee_id` LIKE '%" & txtSearch.Text & "%' OR `first_name` LIKE '%" & txtSearch.Text & "%' " &
                  "OR `middle_name` LIKE '%" & txtSearch.Text & "%' OR `last_name` LIKE '%" & txtSearch.Text & "%' " &
                  "OR `gender` LIKE '%" & txtSearch.Text & "%' OR `date_of_birth` LIKE '%" & txtSearch.Text & "%' " &
                  "OR `phone_number` LIKE '%" & txtSearch.Text & "%' OR `barangay` LIKE '%" & txtSearch.Text & "%' " &
                  "OR `municipality` LIKE '%" & txtSearch.Text & "%' OR `city_province` LIKE '%" & txtSearch.Text & "%' " &
                  "OR `zip_code` LIKE '%" & txtSearch.Text & "%' OR `valid_id` LIKE '%" & txtSearch.Text & "%' " &
                  "OR `license_number` LIKE '%" & txtSearch.Text & "%' OR `insurance_policy_number` LIKE '%" & txtSearch.Text & "%' " &
                  "OR `civil_status` LIKE '%" & txtSearch.Text & "%'"

        ' Refresh the DataGridView with filtered data
        RefreshFranchiseelData()
    End Sub

    ' ComboBox Placeholder Logic
    Private Sub ComboBox_GotFocus(sender As Object, e As EventArgs)

        Dim comboBox = CType(sender, ComboBox)

        ' Clear placeholder text on focus
        If comboBox.ForeColor = Color.Gray Then
            comboBox.Text = ""
            comboBox.ForeColor = Color.Black
        End If
    End Sub

    Private Sub ComboBox_LostFocus(sender As Object, e As EventArgs)

        Dim comboBox = CType(sender, ComboBox)

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

    ' Update Button Click
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            If tbfirstname.Tag Is Nothing Then
                MsgBox("Select a record to update.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

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

            ' Confirm update action
            If MsgBox("Are you sure you want to update?", MsgBoxStyle.YesNo, "Update") = MsgBoxResult.Yes Then
                ' Update query including all the fields except renewal_id (primary key)
                Dim query = String.Format("UPDATE franchiseedatabase SET " &
                                       "first_name='{0}', middle_name='{1}', last_name='{2}', " &
                                       "gender='{3}', date_of_birth='{4}', phone_number='{5}', " &
                                       "barangay='{6}', municipality='{7}', valid_id='{8}', " &
                                       "license_number='{9}', insurance_policy_number='{10}', civil_status='{11}' " &
                                       "WHERE franchisee_id='{12}'",
                                       tbfirstname.Text, tbmiddlename.Text, tblastname.Text,
                                       cbxgender.Text, dtpdateofbirth.Value.ToString("yyyy-MM-dd"), tbphonenum.Text,
                                       tbbarangay.Text, cbxMunicipality.Text, cbxvalidID.Text,
                                       tblicensenum.Text, tbinsurance.Text, cbxCivilStatus.Text,
                                       tbfirstname.Tag)


                ' Execute the query
                ' RenewalDatabaseModule.ExecuteNonQuery(query)
                modDB.readQuery(query)

                ' Notify success
                MsgBox("Record updated successfully!", MsgBoxStyle.Information)

                ' Refresh the DataGridView
                RefreshFranchiseelData()

                ' Optionally, clear the form after saving
                ClearFormFields()

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    ' Delete Button Click
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            ' Check if a record is selected
            If tbfirstname.Tag Is Nothing Then
                MsgBox("Select a record to delete.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            ' Confirmation message.
            If MsgBox("Are you sure you want to delete record of Franchisee ID: " & tbfirstname.Tag &
                      " ?",
                      MsgBoxStyle.YesNo, "Delete Record") = MsgBoxResult.Yes Then

                ' Delete query
                Dim query = String.Format("DELETE FROM franchiseedatabase WHERE franchisee_id='{0}'", tbfirstname.Tag)

                ' Execute the query
                ' RenewalDatabaseModule.ExecuteNonQuery(query)
                modDB.readQuery(query)

                ' Notify success
                MsgBox("Record deleted successfully!", MsgBoxStyle.Information)

                ' Refresh the DataGridView
                RefreshFranchiseelData()

                ' Optionally, clear the form after saving
                ClearFormFields()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    ' DataGridView CellDoubleClick Event
    Private Sub dgvFranchisee_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFranchisee.CellDoubleClick
        Try
            Dim row = dgvFranchisee.Rows(e.RowIndex)
            tbfirstname.Tag = row.Cells("Franchisee ID").Value
            tbfirstname.Text = row.Cells("First Name").Value
            tbmiddlename.Text = row.Cells("Middle Name").Value.ToString
            tblastname.Text = row.Cells("Last Name").Value.ToString
            tbphonenum.Text = row.Cells("Phone Number").Value.ToString
            tblicensenum.Text = row.Cells("License Number").Value.ToString
            tbinsurance.Text = row.Cells("Insurance Policy Number").Value.ToString
            tbbarangay.Text = row.Cells("Barangay").Value.ToString
            cbxgender.Text = row.Cells("Gender").Value.ToString
            cbxCivilStatus.Text = row.Cells("Civil Status").Value.ToString
            cbxMunicipality.Text = row.Cells("Municipality").Value.ToString
            cbxvalidID.Text = row.Cells("Valid ID").Value.ToString
            dtpdateofbirth.Value = Date.Parse(row.Cells("Birthdate").Value.ToString)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    ' Clear Form Fields
    Private Sub ClearFormFields()
        tbfirstname.Clear()
        tbmiddlename.Clear()
        tblastname.Clear()
        tbphonenum.Clear()
        tblicensenum.Clear()
        tbinsurance.Clear()
        tbbarangay.Clear()
        cbxgender.SelectedIndex = -1
        cbxCivilStatus.SelectedIndex = -1
        cbxMunicipality.SelectedIndex = -1
        cbxvalidID.SelectedIndex = -1
        dtpdateofbirth.Value = DateTime.Now

    End Sub

End Class
