Imports MySql.Data.MySqlClient

Module RenewalDatabaseModule
    Private connectionString As String = "Server=localhost;Database=student_profile;Uid=root;Pwd=;"
    Private connection As New MySqlConnection(connectionString)

    Public Sub ExecuteNonQuery(query As String)
        Try
            connection.Open()
            Dim command As New MySqlCommand(query, connection)
            command.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Renewal Database error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Public Function LoadToDGV(query As String, dgv As DataGridView) As Integer
        Dim count As Integer = 0
        Try
            connection.Open()
            Dim adapter As New MySqlDataAdapter(query, connection)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)
            dgv.DataSource = dataTable
            count = dataTable.Rows.Count
        Catch ex As Exception
            Throw New Exception("Renewal Database error: " & ex.Message)
        Finally
            connection.Close()
        End Try
        Return count
    End Function
End Module
