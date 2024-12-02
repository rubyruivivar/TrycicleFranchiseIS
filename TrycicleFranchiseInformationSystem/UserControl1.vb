Public Class Form2franchise
    Private Sub Form2franchise_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Fill

        ' Set placeholders for all ComboBoxes
        SetComboBoxPlaceholder(cbxFranchiseType, "Renewal Type")
        SetComboBoxPlaceholder(cbxStatus, "Compliance Status")
        SetComboBoxPlaceholder(cbxArea, "Status")
    End Sub

    ' ComboBox Placeholder Logic
    Private Sub ComboBox_GotFocus(sender As Object, e As EventArgs) _
        Handles cbxFranchiseType.GotFocus, cbxStatus.GotFocus, cbxArea.GotFocus

        Dim comboBox As ComboBox = CType(sender, ComboBox)

        ' Clear placeholder text on focus
        If comboBox.ForeColor = Color.Gray Then
            comboBox.Text = ""
            comboBox.ForeColor = Color.Black
        End If
    End Sub

    Private Sub ComboBox_LostFocus(sender As Object, e As EventArgs) _
        Handles cbxFranchiseType.LostFocus, cbxStatus.LostFocus, cbxArea.LostFocus

        Dim comboBox As ComboBox = CType(sender, ComboBox)

        ' Restore placeholder text if no value is selected
        If String.IsNullOrWhiteSpace(comboBox.Text) Then
            Select Case comboBox.Name
                Case "cbxFranchiseType"
                    SetComboBoxPlaceholder(comboBox, "Franchise Type")
                Case "cbxStatus"
                    SetComboBoxPlaceholder(comboBox, "Status")
                Case "cbxArea"
                    SetComboBoxPlaceholder(comboBox, "Area")
            End Select
        End If
    End Sub

    Private Sub SetComboBoxPlaceholder(comboBox As ComboBox, placeholder As String)
        comboBox.Text = placeholder
        comboBox.ForeColor = Color.Gray
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            ' Validation: Check if the required fields are not empty
            If cbxFranchiseType.Text = "Franchise Type" OrElse cbxStatus.Text = "Status" OrElse cbxArea.Text = "Area" Then
                MsgBox("Please fill in all required fields.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If tbFranchiseeID.Text.Trim = Nothing Then
                MsgBox("Enter Franchise ID.")
                tbFranchiseeID.Focus()
                Exit Sub
            End If
            If tbVehicleID.Text.Trim = Nothing Then
                MsgBox("Enter Franchisee ID.")
                tbVehicleID.Focus()
                Exit Sub
            End If
            If tbLicenseNumber.Text.Trim = Nothing Then
                MsgBox("Enter Renewal Number.")
                tbLicenseNumber.Focus()
                Exit Sub
            End If
            If tbRoute.Text.Trim = Nothing Then
                MsgBox("Enter Renewal Fee.")
                tbRoute.Focus()
                Exit Sub
            End If
            If tbAssociation.Text.Trim = Nothing Then
                MsgBox("Enter Penalty Fee.")
                tbAssociation.Focus()
                Exit Sub
            End If
            If tbTotalViolations.Text.Trim = Nothing Then
                MsgBox("Enter Authority ID.")
                tbTotalViolations.Focus()
                Exit Sub
            End If
            If tbFranchiseDuration.Text.Trim = Nothing Then
                MsgBox("Enter Authority ID.")
                tbFranchiseDuration.Focus()
                Exit Sub
            End If
            If tbFeePaid.Text.Trim = Nothing Then
                MsgBox("Enter Authority ID.")
                tbFeePaid.Focus()
                Exit Sub
            End If


            If dtpDateIssued.Value = dtpDateIssued.MinDate OrElse dtpLastRenewalDate.Value = dtpLastRenewalDate.MinDate OrElse dtpExpirationDate.Value = dtpExpirationDate.MinDate OrElse dtpExpirationDate.Value = dtpExpirationDate.MinDate Then
                MsgBox("Please select valid dates.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            ' Construct the SQL query to insert the new renewal record
            Dim query As String = String.Format("INSERT INTO franchise ")

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
    Private Sub ClearFormFields()
        tbFranchiseeID.Clear()
        tbVehicleID.Clear()
        tbLicenseNumber.Clear()
        tbRoute.Clear()
        tbAssociation.Clear()
        tbTotalViolations.Clear()
        tbFranchiseDuration.Clear()
        tbFeePaid.Clear()

        cbxFranchiseType.Text = "Renewal Type"
        cbxStatus.Text = "Compliance Status"
        cbxArea.Text = "Status"
    End Sub
End Class
