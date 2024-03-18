Imports System.Data.SqlClient

Public Class AddAttendance

    ' Connection string to connect to the database
    Dim connectionString As String = "Data Source=ALLRX\SQLEXPRESS;Initial Catalog=ontap;Integrated Security=True;Encrypt=False"

    ' Event handler for the button click event
    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        ' Call a method to add attendance
        AddAttendanceToDatabase()
    End Sub

    ' Method to add attendance to the database
    Private Sub AddAttendanceToDatabase()
        Try
            ' Get the attendance values from the user input
            Dim rollNo As String = Guna2TextBox6.Text
            Dim totalClasses As Integer = Guna2TextBox3.Text
            Dim classesAbsent As Integer = Guna2TextBox5.Text
            Dim classesAttended As Integer = Convert.ToInt32(Guna2TextBox4.Text)
            Dim username As String = Guna2TextBox1.Text
            Dim semester As Integer = Guna2TextBox2.Text

            ' Create a connection to the database
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Construct the SQL INSERT statement
                Dim query As String = "INSERT INTO attendance (rollno, total_classes, classes_attended, username, classes_absent) VALUES (@rollno, @total_classes, @classes_attended, @username, @classes_absent)"

                ' Create a SqlCommand object
                Using command As New SqlCommand(query, connection)
                    ' Add parameters to the SqlCommand
                    command.Parameters.AddWithValue("@rollno", rollNo)
                    command.Parameters.AddWithValue("@total_classes", totalClasses)
                    command.Parameters.AddWithValue("@classes_attended", classesAttended)
                    command.Parameters.AddWithValue("@username", username)
                    command.Parameters.AddWithValue("@classes_absent", classesAbsent) ' Add this line

                    ' Execute the INSERT statement
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    ' Check if the attendance was added successfully
                    If rowsAffected > 0 Then
                        MessageBox.Show("Attendance added successfully.")
                        Me.Hide()
                    Else
                        MessageBox.Show("Failed to add attendance.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error adding attendance: " & ex.Message)
        End Try
    End Sub

    Private Sub Guna2GroupBox1_Click(sender As Object, e As EventArgs) Handles Guna2GroupBox1.Click

    End Sub

    Private Sub AddAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
