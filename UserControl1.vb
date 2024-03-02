Imports System.Data.SqlClient

Public Class UserControl1

    Dim connectionString As String = "Data Source=ALLRX\SQLEXPRESS;Initial Catalog=ontap;Integrated Security=True;Encrypt=False"

    Private Sub UserControl1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Call the method to retrieve attendance data
        RetrieveAttendanceData()
    End Sub

    Private Sub RetrieveAttendanceData()
        Dim yourLoggedInUsername As String = Form1.loggedInUsername

        Try
            ' Connect to the database
            Using connection As New SqlConnection(connectionString)
                ' SQL query to retrieve attendance data for the logged-in user
                Dim query As String = "SELECT classes_attended, total_classes, classes_attended, semester FROM attendance WHERE username = @username"

                ' Create a command with the query and connection
                Using command As New SqlCommand(query, connection)
                    ' Replace '@username' with the actual username of the logged-in user
                    command.Parameters.AddWithValue("@username", yourLoggedInUsername)

                    ' Open the connection
                    connection.Open()

                    ' Execute the command and read the data
                    Using reader As SqlDataReader = command.ExecuteReader()
                        ' Check if data exists
                        If reader.Read() Then
                            ' Retrieve data from the reader
                            Dim classesAttended As Integer = Convert.ToInt32(reader("classes_attended"))
                            Dim totalClasses As Integer = Convert.ToInt32(reader("total_classes"))
                            Dim classesPresent As Integer = Convert.ToInt32(reader("classes_attended"))
                            Dim semester As Integer = Convert.ToInt32(reader("semester"))

                            ' Update labels with retrieved data
                            Label1.Text = If(totalClasses > 0, ((classesAttended / totalClasses) * 100).ToString("0.00") & "%", "")
                            Label8.Text = classesAttended.ToString()
                            Label6.Text = totalClasses.ToString()
                            Label4.Text = semester


                            ' Update progress bar with attendance percentage
                            Guna2ProgressBar1.Value = (classesPresent / totalClasses) * 100
                        Else
                            ' No data found for the logged-in user
                            MessageBox.Show("No attendance data found for the logged-in user.")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ' Handle exceptions
            MessageBox.Show("Error retrieving attendance data: " & ex.Message)
        End Try
    End Sub
End Class
