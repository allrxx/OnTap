Imports System.Data.SqlClient

Public Class UserControl4

    Dim connectionString As String = "Data Source=ALLRX\SQLEXPRESS;Initial Catalog=ontap;Integrated Security=True;Encrypt=False"

    Private Sub UserControl4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CalculateAndDisplayAverageAttendance()
        FindStudentWithLeastAttendance()
    End Sub

    Private Sub CalculateAndDisplayAverageAttendance()
        Try
            Dim totalAttendancePercentage As Double = 0
            Dim totalStudents As Integer = 0

            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Count the total number of students in the attendance table
                Dim countQuery As String = "SELECT COUNT(DISTINCT rollno) AS TotalStudents FROM attendance"
                Using countCommand As New SqlCommand(countQuery, connection)
                    totalStudents = Convert.ToInt32(countCommand.ExecuteScalar())
                End Using

                ' If there are students, calculate the average attendance percentage
                If totalStudents > 0 Then
                    Dim totalAttendanceSum As Double = 0 ' Changed to Double to avoid integer division

                    Dim query As String = "SELECT total_classes, classes_attended FROM attendance"
                    Using command As New SqlCommand(query, connection)
                        Using reader As SqlDataReader = command.ExecuteReader()
                            While reader.Read()
                                Dim totalClasses As Integer = Convert.ToInt32(reader("total_classes"))
                                Dim classesAttended As Integer = Convert.ToInt32(reader("classes_attended")) ' Fixed column name
                                totalAttendanceSum += (classesAttended / totalClasses) * 100
                            End While
                        End Using
                    End Using

                    ' Calculate the average attendance percentage
                    totalAttendancePercentage = totalAttendanceSum / totalStudents
                End If
            End Using

            ' Display the average attendance percentage
            Label14.Text = totalAttendancePercentage.ToString("0.00") & "%"
            Label12.Text = totalStudents.ToString()

        Catch ex As Exception
            ' Handle exceptions
            MessageBox.Show("Error calculating average attendance: " & ex.Message)
        End Try
    End Sub

    Private Sub FindStudentWithLeastAttendance()
        Try
            Dim minAttendancePercentage As Double = Double.MaxValue ' Initialize to a large value
            Dim studentWithLeastAttendance As String = ""

            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Select the student with the least attendance percentage
                Dim query As String = "SELECT rollno, (classes_attended * 100.0 / total_classes) AS attendance_percentage FROM attendance ORDER BY attendance_percentage ASC"
                Using command As New SqlCommand(query, connection)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            studentWithLeastAttendance = reader("rollno").ToString()
                            minAttendancePercentage = Convert.ToDouble(reader("attendance_percentage"))
                        End If
                    End Using
                End Using
            End Using

            ' Display the student with the least attendance
            If String.IsNullOrEmpty(studentWithLeastAttendance) Then
                MessageBox.Show("No student attendance data found.")
            Else
                Label8.Text = studentWithLeastAttendance
                Label1.Text = minAttendancePercentage.ToString("0.00") & "%"
                Guna2ProgressBar1.Value = Convert.ToInt32(minAttendancePercentage)
            End If

        Catch ex As Exception
            ' Handle exceptions
            MessageBox.Show("Error finding student with least attendance: " & ex.Message)
        End Try
    End Sub

    Private Sub Guna2GroupBox1_Click(sender As Object, e As EventArgs) Handles Guna2GroupBox1.Click

    End Sub
End Class
