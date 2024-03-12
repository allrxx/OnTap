Imports System.Data.SqlClient

Public Class PasswordChange

    Dim CurrentUsername As String = Form1.loggedInUsername
    Dim connectionString As String = "Data Source=ALLRX\SQLEXPRESS;Initial Catalog=ontap;Integrated Security=True;Encrypt=False"

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Dim username As String = Guna2TextBox1.Text
        Dim password As String = Guna2TextBox2.Text
        Dim newPassword As String = Guna2TextBox3.Text

        ' Check if the entered username and password match the records in the database
        If ValidateUser(username, password) Then
            ' Update the password for the currently logged-in user
            If ChangePassword(newPassword) Then
                MessageBox.Show("Password changed successfully.")
            Else
                MessageBox.Show("Failed to change password.")
            End If
        Else
            MessageBox.Show("Invalid username or password.")
        End If
    End Sub

    Private Function ValidateUser(username As String, password As String) As Boolean
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT COUNT(*) FROM [User] WHERE username = @username AND password = @password"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@username", username)
                    command.Parameters.AddWithValue("@password", password)
                    Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                    Return count > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error validating user: " & ex.Message)
            Return False
        End Try
    End Function

    Private Function ChangePassword(newPassword As String) As Boolean
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "UPDATE [User] SET password = @newPassword WHERE username = @username"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@newPassword", newPassword)
                    command.Parameters.AddWithValue("@username", CurrentUsername)
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    Return rowsAffected > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error changing password: " & ex.Message)
            Return False
        End Try
    End Function

End Class
