Public Class RenewalData
    Dim recordCount As Integer = 0

    ' Refresh Renewal DataGridView
    Private Sub RefreshRenewalData()
        Try
            Dim query As String = "SELECT `renewal_id` AS 'Renewal ID', `franchise_id` AS 'Franchise ID', `franchisee_id` AS 'Franchisee ID', " &
                                  "`submission_date` AS 'Submission Date', `processing_date` AS 'Processing Date', `approval_date` AS 'Approval Date', " &
                                  "`expiration_date` AS 'Expiration Date', `renewal_type` AS 'Renewal Type', `compliance_status` AS 'Compliance Status', " &
                                  "`status` AS 'Status', `renewal_number` AS 'Renewal Number', `renewal_fee` AS 'Renewal Fee', `penalty_fee` AS 'Penalty Fee', " &
                                  "`fee_paid` AS 'Fee Paid', `authority_id` AS 'Authority ID' FROM renewaldatabase"
            recordCount = RenewalDatabaseModule.LoadToDGV(query, dgvRenewal)
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
            If txtFranchiseID.Tag Is Nothing Then
                MsgBox("Select a record to update.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            ' Validate that the required fields are filled
            If txtFranchiseID.Text.Trim = Nothing Then
                MsgBox("Enter Franchisee ID.")
                txtFranchiseID.Focus()
                Exit Sub
            End If
            If txtFranchiseeID.Text.Trim = Nothing Then
                MsgBox("Enter Franchisee ID.")
                txtFranchiseeID.Focus()
                Exit Sub
            End If
            If cbxRenewalType.Text.Trim = Nothing Then
                MsgBox("Enter Status.")
                cbxRenewalType.Focus()
                Exit Sub
            End If
            If cbxComplianceStatus.Text.Trim = Nothing Then
                MsgBox("Enter Status.")
                cbxComplianceStatus.Focus()
                Exit Sub
            End If
            If cbxStatus.Text.Trim = Nothing Then
                MsgBox("Enter Status.")
                cbxStatus.Focus()
                Exit Sub
            End If
            If txtRenewalNumber.Text.Trim = Nothing Then
                MsgBox("Enter Renewal Number.")
                txtRenewalNumber.Focus()
                Exit Sub
            End If
            If txtRenewalFee.Text.Trim = Nothing Then
                MsgBox("Enter Renewal Fee.")
                txtRenewalFee.Focus()
                Exit Sub
            End If
            If txtPenaltyFee.Text.Trim = Nothing Then
                MsgBox("Enter Penalty Fee.")
                txtPenaltyFee.Focus()
                Exit Sub
            End If
            If txtAuthorityID.Text.Trim = Nothing Then
                MsgBox("Enter Fee Paid.")
                txtAuthorityID.Focus()
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
                                                    txtFranchiseID.Text, txtFranchiseeID.Text, dtpSubmissionDate.Value.ToString("yyyy-MM-dd"),
                                                    dtpProcessingDate.Value.ToString("yyyy-MM-dd"), dtpApprovalDate.Value.ToString("yyyy-MM-dd"),
                                                    dtpExpirationDate.Value.ToString("yyyy-MM-dd"), cbxRenewalType.Text, cbxComplianceStatus.Text,
                                                    cbxStatus.Text, txtRenewalNumber.Text, txtRenewalFee.Text, txtPenaltyFee.Text, txtAuthorityID.Text,
                                                    txtFranchiseID.Tag)

                ' Execute the query
                RenewalDatabaseModule.ExecuteNonQuery(query)

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
    ' Delete Button Click
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            ' Check if a record is selected
            If txtFranchiseID.Tag Is Nothing Then
                MsgBox("Select a record to delete.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            ' Confirmation message
            If MsgBox("Are you sure you want to delete record with Renewal ID: " & txtFranchiseID.Tag &
                  " belonging to Franchisee ID: " & txtFranchiseeID.Text & "?",
                  MsgBoxStyle.YesNo, "Delete Record") = MsgBoxResult.Yes Then

                ' Delete query
                Dim query As String = String.Format("DELETE FROM renewaldatabase WHERE renewal_id='{0}'", txtFranchiseID.Tag)

                ' Execute the query
                RenewalDatabaseModule.ExecuteNonQuery(query)

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
            If e.RowIndex >= 0 Then
                ' Set fields from selected row
                txtFranchiseID.Tag = dgvRenewal.Rows(e.RowIndex).Cells(0).Value.ToString()
                txtFranchiseID.Text = dgvRenewal.Rows(e.RowIndex).Cells(1).Value.ToString()
                txtFranchiseeID.Text = dgvRenewal.Rows(e.RowIndex).Cells(2).Value.ToString()
                dtpSubmissionDate.Value = DateTime.Parse(dgvRenewal.Rows(e.RowIndex).Cells(3).Value.ToString())
                dtpProcessingDate.Value = DateTime.Parse(dgvRenewal.Rows(e.RowIndex).Cells(4).Value.ToString())
                dtpApprovalDate.Value = DateTime.Parse(dgvRenewal.Rows(e.RowIndex).Cells(5).Value.ToString())
                dtpExpirationDate.Value = DateTime.Parse(dgvRenewal.Rows(e.RowIndex).Cells(6).Value.ToString())
                cbxRenewalType.Text = dgvRenewal.Rows(e.RowIndex).Cells(7).Value.ToString()
                cbxComplianceStatus.Text = dgvRenewal.Rows(e.RowIndex).Cells(8).Value.ToString()
                cbxStatus.Text = dgvRenewal.Rows(e.RowIndex).Cells(9).Value.ToString()
                txtRenewalNumber.Text = dgvRenewal.Rows(e.RowIndex).Cells(10).Value.ToString()
                txtRenewalFee.Text = dgvRenewal.Rows(e.RowIndex).Cells(11).Value.ToString()
                txtPenaltyFee.Text = dgvRenewal.Rows(e.RowIndex).Cells(12).Value.ToString()
                txtAuthorityID.Text = dgvRenewal.Rows(e.RowIndex).Cells(14).Value.ToString()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    ' Clear form fields after successful save
    Private Sub ClearFormFields()
        txtFranchiseID.Clear()
        txtFranchiseeID.Clear()
        txtRenewalNumber.Clear()
        txtRenewalFee.Clear()
        txtPenaltyFee.Clear()
        txtAuthorityID.Clear()

        cbxRenewalType.Text = "Renewal Type"
        cbxComplianceStatus.Text = "Compliance Status"
        cbxStatus.Text = "Status"
        cbxRenewalType.ForeColor = Color.Gray
        cbxComplianceStatus.ForeColor = Color.Gray
        cbxStatus.ForeColor = Color.Gray

    End Sub

End Class
