Imports MySql.Data.MySqlClient

Public Class Form5Renewal
    Private Sub Form5Renewal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Fill

        ' Set placeholders for all ComboBoxes
        SetComboBoxPlaceholder(cbxRenewalType, "Renewal Type")
        SetComboBoxPlaceholder(cbxComplianceStatus, "Compliance Status")
        SetComboBoxPlaceholder(cbxStatus, "Status")
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

    ' Save Button Click to Insert Data into the Database
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            ' Validation: Check if the required fields are not empty
            If cbxRenewalType.Text = "Renewal Type" OrElse cbxComplianceStatus.Text = "Compliance Status" OrElse cbxStatus.Text = "Status" Then
                MsgBox("Please fill in all required fields.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If txtFranchiseID.Text.Trim = Nothing Then
                MsgBox("Enter Franchise ID.")
                txtFranchiseID.Focus()
                Exit Sub
            End If
            If txtFranchiseeID.Text.Trim = Nothing Then
                MsgBox("Enter Franchisee ID.")
                txtFranchiseeID.Focus()
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
                MsgBox("Enter Authority ID.")
                txtAuthorityID.Focus()
                Exit Sub
            End If

            If dtpSubmissionDate.Value = dtpSubmissionDate.MinDate OrElse dtpProcessingDate.Value = dtpProcessingDate.MinDate OrElse dtpApprovalDate.Value = dtpApprovalDate.MinDate OrElse dtpExpirationDate.Value = dtpExpirationDate.MinDate Then
                MsgBox("Please select valid dates.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            ' Construct the SQL query to insert the new renewal record
            Dim query As String = String.Format("INSERT INTO renewaldatabase " &
                                                "(franchise_id, franchisee_id, renewal_type, compliance_status, status, submission_date, processing_date, approval_date, expiration_date, renewal_number, renewal_fee, penalty_fee, authority_id) " &
                                                "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}')",
                                                txtFranchiseID.Text.Trim, txtFranchiseeID.Text.Trim,
                                                cbxRenewalType.Text.Trim, cbxComplianceStatus.Text.Trim, cbxStatus.Text.Trim,
                                                dtpSubmissionDate.Value.ToString("yyyy-MM-dd"), dtpProcessingDate.Value.ToString("yyyy-MM-dd"),
                                                dtpApprovalDate.Value.ToString("yyyy-MM-dd"), dtpExpirationDate.Value.ToString("yyyy-MM-dd"),
                                                txtRenewalNumber.Text.Trim, txtRenewalFee.Text.Trim, txtPenaltyFee.Text.Trim,
                                                txtAuthorityID.Text.Trim)

            ' Execute the query using the module method
            RenewalDatabaseModule.ExecuteNonQuery(query)

            MsgBox("New renewal record saved successfully!", MsgBoxStyle.Information)

            ' Optionally, clear the form after saving
            ClearFormFields()

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
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
