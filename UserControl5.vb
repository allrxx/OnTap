Imports System.Data.SqlClient

Public Class UserControl5

    ' Connection string to connect to the database
    Dim connectionString As String = "Data Source=ALLRX\SQLEXPRESS;Initial Catalog=ontap;Integrated Security=True;Encrypt=False"

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        ' Get the username from the textbox
        Dim username As String = Guna2TextBox1.Text

        ' Delete records related to the username from the attendance table
        DeleteAttendanceRecords(username)

        ' Delete the user record from the username table
        DeleteUserRecord(username)
    End Sub

    ' Method to delete records related to the username from the attendance table
    Private Sub DeleteAttendanceRecords(username As String)
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Construct the SQL DELETE statement for the attendance table
                Dim query As String = "DELETE FROM attendance WHERE username = @username"

                ' Create a SqlCommand object
                Using command As New SqlCommand(query, connection)
                    ' Add parameters to the SqlCommand
                    command.Parameters.AddWithValue("@username", username)

                    ' Execute the DELETE statement
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    ' Check if any records were deleted
                    If rowsAffected > 0 Then
                        MessageBox.Show("Attendance records deleted successfully.")
                    Else
                        MessageBox.Show("No attendance records found for the username.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error deleting attendance records: " & ex.Message)
        End Try
    End Sub

    ' Method to delete the user record from the username table
    Private Sub DeleteUserRecord(username As String)
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Construct the SQL DELETE statement for the username table
                Dim query As String = "DELETE FROM [User] WHERE username = @username"

                ' Create a SqlCommand object
                Using command As New SqlCommand(query, connection)
                    ' Add parameters to the SqlCommand
                    command.Parameters.AddWithValue("@username", username)

                    ' Execute the DELETE statement
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    ' Check if any records were deleted
                    If rowsAffected > 0 Then
                        MessageBox.Show("User record deleted successfully.")
                    Else
                        MessageBox.Show("No user record found for the username.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error deleting user record: " & ex.Message)
        End Try
    End Sub

    Private Sub Guna2GroupBox7_Click(sender As Object, e As EventArgs) Handles Guna2GroupBox7.Click

    End Sub

    Private Sub UserControl5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
