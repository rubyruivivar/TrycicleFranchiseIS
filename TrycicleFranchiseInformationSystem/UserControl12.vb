Public Class RenewalData
    Dim recordCount As Integer = 0
    Dim searchQuery As String = ""

    ' Refresh Renewal DataGridView
    Private Sub RefreshRenewalData()
        Try
            Dim query As String = "SELECT `renewal_id` AS 'Renewal ID', `franchise_id` AS 'Franchise ID', `franchisee_id` AS 'Franchisee ID', " &
                                  "`submission_date` AS 'Submission Date', `processing_date` AS 'Processing Date', `approval_date` AS 'Approval Date', " &
                                  "`expiration_date` AS 'Expiration Date', `renewal_type` AS 'Renewal Type', `compliance_status` AS 'Compliance Status', " &
                                  "`status` AS 'Status', `renewal_number` AS 'Renewal Number', `renewal_fee` AS 'Renewal Fee', `penalty_fee` AS 'Penalty Fee', " &
                                  "`fee_paid` AS 'Fee Paid', `authority_id` AS 'Authority ID' FROM renewaldatabase " & searchQuery

            recordCount = modDB.LoadToDGV(query, dgvRenewal)
            lblRecordCount.Text = "Total Records: " & recordCount
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    ' Load Event
    Private Sub RenewalData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Fill

        ' Set placeholders for all ComboBoxes
        SetComboBoxPlaceholder(cbxRenewalType, "Renewal Type")
        SetComboBoxPlaceholder(cbxComplianceStatus, "Compliance Status")
        SetComboBoxPlaceholder(cbxStatus, "Status")

        RefreshRenewalData()
    End Sub

    ' Search Bar KeyPress Event
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        ' Update search query to filter by the input text across multiple fields
        searchQuery = "WHERE `renewal_id` LIKE '%" & txtSearch.Text & "%' OR `franchise_id` LIKE '%" & txtSearch.Text & "%' " &
                  "OR `franchisee_id` LIKE '%" & txtSearch.Text & "%' OR `submission_date` LIKE '%" & txtSearch.Text & "%' " &
                  "OR `processing_date` LIKE '%" & txtSearch.Text & "%' OR `approval_date` LIKE '%" & txtSearch.Text & "%' " &
                  "OR `expiration_date` LIKE '%" & txtSearch.Text & "%' OR `renewal_type` LIKE '%" & txtSearch.Text & "%' " &
                  "OR `compliance_status` LIKE '%" & txtSearch.Text & "%' OR `status` LIKE '%" & txtSearch.Text & "%' " &
                  "OR `renewal_number` LIKE '%" & txtSearch.Text & "%' OR `renewal_fee` LIKE '%" & txtSearch.Text & "%' " &
                  "OR `penalty_fee` LIKE '%" & txtSearch.Text & "%' OR `fee_paid` LIKE '%" & txtSearch.Text & "%' " &
                  "OR `authority_id` LIKE '%" & txtSearch.Text & "%'"

        ' Refresh the DataGridView with filtered data
        RefreshRenewalData()
    End Sub

    ' Button Click for Search
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ' Same logic can be applied if a dedicated search button is used
        searchQuery = "WHERE `renewal_id` LIKE '%" & txtSearch.Text & "%' OR `franchise_id` LIKE '%" & txtSearch.Text & "%' " &
                  "OR `franchisee_id` LIKE '%" & txtSearch.Text & "%' OR `submission_date` LIKE '%" & txtSearch.Text & "%' " &
                  "OR `processing_date` LIKE '%" & txtSearch.Text & "%' OR `approval_date` LIKE '%" & txtSearch.Text & "%' " &
                  "OR `expiration_date` LIKE '%" & txtSearch.Text & "%' OR `renewal_type` LIKE '%" & txtSearch.Text & "%' " &
                  "OR `compliance_status` LIKE '%" & txtSearch.Text & "%' OR `status` LIKE '%" & txtSearch.Text & "%' " &
                  "OR `renewal_number` LIKE '%" & txtSearch.Text & "%' OR `renewal_fee` LIKE '%" & txtSearch.Text & "%' " &
                  "OR `penalty_fee` LIKE '%" & txtSearch.Text & "%' OR `fee_paid` LIKE '%" & txtSearch.Text & "%' " &
                  "OR `authority_id` LIKE '%" & txtSearch.Text & "%'"

        ' Refresh the DataGridView with filtered data
        RefreshRenewalData()
    End Sub

    ' ComboBox Placeholder Logic
    Private Sub ComboBox_GotFocus(sender As Object, e As EventArgs) _
        Handles cbxRenewalType.GotFocus, cbxComplianceStatus.GotFocus, cbxStatus.GotFocus

        Dim comboBox As ComboBox = CType(sender, ComboBox)

        ' Clear placeholder text on focus
        If comboBox.ForeColor = Color.Gray Then
            comboBox.Text = ""
            comboBox.ForeColor = Color.Black
        End If
    End Sub

    Private Sub ComboBox_LostFocus(sender As Object, e As EventArgs) _
        Handles cbxRenewalType.LostFocus, cbxComplianceStatus.LostFocus, cbxStatus.LostFocus

        Dim comboBox As ComboBox = CType(sender, ComboBox)

        ' Restore placeholder text if no value is selected
        If String.IsNullOrWhiteSpace(comboBox.Text) Then
            Select Case comboBox.Name
                Case "cbxRenewalType"
                    SetComboBoxPlaceholder(comboBox, "Renewal Type")
                Case "cbxComplianceStatus"
                    SetComboBoxPlaceholder(comboBox, "Compliance Status")
                Case "cbxStatus"
                    SetComboBoxPlaceholder(comboBox, "Status")
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
            If tbFranchiseID.Tag Is Nothing Then
                MsgBox("Select a record to update.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            ' Validate that the required fields are filled
            If tbFranchiseID.Text.Trim = Nothing Then
                MsgBox("Enter Franchisee ID.")
                tbFranchiseID.Focus()
                Exit Sub
            End If
            If tbFranchiseeID.Text.Trim = Nothing Then
                MsgBox("Enter Franchisee ID.")
                tbFranchiseeID.Focus()
                Exit Sub
            End If

            ' Validation: Check if the required fields are not empty
            If cbxRenewalType.Text = "Renewal Type" OrElse cbxComplianceStatus.Text = "Compliance Status" OrElse cbxStatus.Text = "Status" Then
                MsgBox("Please fill in all required fields.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If tbRenewalNumber.Text.Trim = Nothing Then
                MsgBox("Enter Renewal Number.")
                tbRenewalNumber.Focus()
                Exit Sub
            End If
            If tbRenewalFee.Text.Trim = Nothing Then
                MsgBox("Enter Renewal Fee.")
                tbRenewalFee.Focus()
                Exit Sub
            End If
            If tbPenaltyFee.Text.Trim = Nothing Then
                MsgBox("Enter Penalty Fee.")
                tbPenaltyFee.Focus()
                Exit Sub
            End If
            If tbAuthorityID.Text.Trim = Nothing Then
                MsgBox("Enter Fee Paid.")
                tbAuthorityID.Focus()
                Exit Sub
            End If

            ' Confirm update action
            If MsgBox("Are you sure you want to update?", MsgBoxStyle.YesNo, "Update") = MsgBoxResult.Yes Then
                ' Update query including all the fields except renewal_id (primary key)
                Dim query As String = String.Format("UPDATE renewaldatabase SET " &
                                                    "franchise_id='{0}', franchisee_id='{1}', submission_date='{2}', " &
                                                    "processing_date='{3}', approval_date='{4}', expiration_date='{5}', " &
                                                    "renewal_type='{6}', compliance_status='{7}', status='{8}', " &
                                                    "renewal_number='{9}', renewal_fee='{10}', penalty_fee='{11}', " &
                                                    "authority_id='{12}' " &
                                                    "WHERE renewal_id='{13}'",
                                                    tbFranchiseID.Text, tbFranchiseeID.Text, dtpSubmissionDate.Value.ToString("yyyy-MM-dd"),
                                                    dtpProcessingDate.Value.ToString("yyyy-MM-dd"), dtpApprovalDate.Value.ToString("yyyy-MM-dd"),
                                                    dtpExpirationDate.Value.ToString("yyyy-MM-dd"), cbxRenewalType.Text, cbxComplianceStatus.Text,
                                                    cbxStatus.Text, tbRenewalNumber.Text, tbRenewalFee.Text, tbPenaltyFee.Text, tbAuthorityID.Text,
                                                    tbFranchiseID.Tag)

                ' Execute the query
                ' RenewalDatabaseModule.ExecuteNonQuery(query)
                modDB.readQuery(query)

                ' Notify success
                MsgBox("Record updated successfully!", MsgBoxStyle.Information)

                ' Refresh the DataGridView
                RefreshRenewalData()

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
            If tbFranchiseID.Tag Is Nothing Then
                MsgBox("Select a record to delete.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            ' Confirmation message.
            If MsgBox("Are you sure you want to delete record with Renewal ID: " & tbFranchiseID.Tag &
                      " belonging to Franchisee ID: " & tbFranchiseeID.Text & "?",
                      MsgBoxStyle.YesNo, "Delete Record") = MsgBoxResult.Yes Then

                ' Delete query
                Dim query = String.Format("DELETE FROM renewaldatabase WHERE renewal_id='{0}'", tbFranchiseID.Tag)

                ' Execute the query
                ' RenewalDatabaseModule.ExecuteNonQuery(query)
                modDB.readQuery(query)

                ' Notify success
                MsgBox("Record deleted successfully!", MsgBoxStyle.Information)

                ' Refresh the DataGridView
                RefreshRenewalData()

                ' Optionally, clear the form after saving
                ClearFormFields()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    ' DataGridView CellDoubleClick Event
    Private Sub dgvRenewal_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRenewal.CellDoubleClick
        Try
            Dim row As DataGridViewRow = dgvRenewal.Rows(e.RowIndex)
            tbFranchiseeID.Tag = row.Cells("Renewal ID").Value
            tbFranchiseeID.Text = row.Cells("Franchisee ID").Value.ToString()
            tbFranchiseID.Text = row.Cells("Franchise ID").Value.ToString()
            tbRenewalNumber.Text = row.Cells("Renewal Number").Value.ToString()
            tbRenewalFee.Text = row.Cells("Renewal Fee").Value.ToString()
            tbPenaltyFee.Text = row.Cells("Penalty Fee").Value.ToString()
            tbAuthorityID.Text = row.Cells("Authority ID").Value.ToString()
            cbxRenewalType.Text = row.Cells("Renewal Type").Value.ToString()
            cbxComplianceStatus.Text = row.Cells("Compliance Status").Value.ToString()
            cbxStatus.Text = row.Cells("Status").Value.ToString()
            dtpSubmissionDate.Value = DateTime.Parse(row.Cells("Submission Date").Value.ToString())
            dtpProcessingDate.Value = DateTime.Parse(row.Cells("Processing Date").Value.ToString())
            dtpApprovalDate.Value = DateTime.Parse(row.Cells("Approval Date").Value.ToString())
            dtpExpirationDate.Value = DateTime.Parse(row.Cells("Expiration Date").Value.ToString())
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    ' Clear Form Fields
    Private Sub ClearFormFields()
        tbFranchiseID.Clear()
        tbFranchiseeID.Clear()
        tbRenewalNumber.Clear()
        tbRenewalFee.Clear()
        tbPenaltyFee.Clear()
        tbAuthorityID.Clear()
        cbxRenewalType.SelectedIndex = -1
        cbxComplianceStatus.SelectedIndex = -1
        cbxStatus.SelectedIndex = -1
        dtpSubmissionDate.Value = DateTime.Now
        dtpProcessingDate.Value = DateTime.Now
        dtpApprovalDate.Value = DateTime.Now
        dtpExpirationDate.Value = DateTime.Now
    End Sub

End Class
