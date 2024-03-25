Imports System.Data.SqlClient

Public Class UserControl7

    ' Connection string to connect to the database '
    Dim connectionString As String = "Data Source=ALLRX\SQLEXPRESS;Initial Catalog=ontap;Integrated Security=True;Encrypt=False"

    ' Method to retrieve attendance data '
    Public Sub RetrieveAttendanceData()
        Dim yourLoggedInUsername As String = Form1.loggedInUsername

        Try
            ' Connect to the database '
            Using connection As New SqlConnection(connectionString)
                ' Improved SQL query to select only necessary data and filter by semester '
                Dim query As String = "SELECT classes_attended, total_classes, semester FROM attendance WHERE username = @username"

                ' Create a command with the query and connection '
                Using command As New SqlCommand(query, connection)
                    ' Replace '@username' with the actual username of the logged-in user '
                    command.Parameters.AddWithValue("@username", yourLoggedInUsername)

                    ' Open the connection '
                    connection.Open()

                    ' Execute the command and read the data '
                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            ' Retrieve data from the reader '
                            Dim classesAttended As Integer = If(Not IsDBNull(reader("classes_attended")), Convert.ToInt32(reader("classes_attended")), 0)
                            Dim totalClasses As Integer = If(Not IsDBNull(reader("total_classes")), Convert.ToInt32(reader("total_classes")), 0)

                            ' Calculate attendance percentage (default to 0 if no classes) '
                            Dim attendancePercentage As Double = If(totalClasses > 0, (classesAttended / totalClasses) * 100, 0)

                            ' Update labels with retrieved data '
                            Label1.Text = attendancePercentage.ToString("0.00") & "%"
                            Label8.Text = classesAttended.ToString()
                            Label6.Text = totalClasses.ToString()

                            ' Update progress bar with attendance percentage '
                            Guna2ProgressBar1.Value = CInt(attendancePercentage)

                            ' Calculate the amount of classes needed to attend '
                            Dim classesNeeded As Integer = Math.Max(0, Math.Ceiling((0.75 * totalClasses - classesAttended) / (1 - attendancePercentage / 100)))

                            ' Calculate classes bunkable '
                            Dim classesBunkable As Integer = totalClasses - classesAttended - classesNeeded

                            ' Update labels with calculated values '
                            Label12.Text = classesNeeded.ToString()

                            ' Change label text and group box color based on attendance percentage '
                            If attendancePercentage < 75 Then
                                Label13.Text = "GO TO CLASS"
                                Label13.Location = New Point(36, 132)
                                Label13.ForeColor = Color.Red
                            Else
                                ' Update Label13 to display bunkable classes if attendance is 75% or above '
                                Label13.Text = classesBunkable.ToString()
                                Label13.ForeColor = Color.Green
                            End If
                        Else
                            ' No data found for the logged-in user '
                            MessageBox.Show("No attendance data found for the logged-in user.")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ' Handle exceptions '
            MessageBox.Show("Error retrieving attendance data: " & ex.Message)
        End Try
    End Sub

    Private Sub UserControl7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Call the RetrieveAttendanceData method when the user control loads '
        RetrieveAttendanceData()
    End Sub
End Class
