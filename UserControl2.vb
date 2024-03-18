﻿Imports System.Data.SqlClient
Imports System.Windows.Input

Public Class UserControl2

    Dim connectionString As String = "Data Source=ALLRX\SQLEXPRESS;Initial Catalog=ontap;Integrated Security=True;Encrypt=False"

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        ' Retrieve details from the user control fields
        Dim username As String = Guna2TextBox1.Text
        Dim firstname As String = Guna2TextBox2.Text
        Dim email As String = Guna2TextBox3.Text
        Dim role As String = "2"
        Dim password As String = Guna2TextBox4.Text
        Dim passwordmatch As String = Guna2TextBox5.Text
        Dim rollno As String = Guna2TextBox6.Text

        ' Insert details into the database
        Dim query As String = "INSERT INTO [user] (username, firstname, email, password, role, rollno) VALUES (@username, @firstname, @email, @password, @role, @rollno)"
        If password = passwordmatch Then
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@username", username)
                    command.Parameters.AddWithValue("@firstname", firstname)
                    command.Parameters.AddWithValue("@email", email)
                    command.Parameters.AddWithValue("@password", password)
                    command.Parameters.AddWithValue("@role", role)
                    command.Parameters.AddWithValue("@rollno", rollno)
                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        MessageBox.Show("Details uploaded successfully!")
                        ' Optionally, perform other actions after successful upload
                    Catch ex As Exception
                        MessageBox.Show("Error uploading details: " & ex.Message)
                    End Try
                End Using
            End Using
        Else
            MessageBox.Show("Passwords do not match!")
            Guna2TextBox4.Clear()
            Guna2TextBox5.Clear()
        End If

    End Sub

    Private Sub UserControl2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
