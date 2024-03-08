Imports OnTap.Form2
Imports System.Data.SqlClient
Imports System.Security.Cryptography

Public Class Form1

    Dim connectionString As String = "Data Source=ALLRX\SQLEXPRESS;Initial  Catalog=ontap;Integrated Security=True;Encrypt=False"

    ' Variable to store the username of the logged-in user
    Public Shared loggedInUsername As String

    ' Variable to store the role of the logged-in user
    Public Shared loggedInUserRole As String

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Dim username As String = Guna2TextBox2.Text
        Dim password As String = Guna2TextBox1.Text

        ' Perform authentication and retrieve the username and role
        Dim role As String = AuthenticateUser(username, password)
        If Not String.IsNullOrEmpty(role) Then
            ' Store the username and role
            loggedInUsername = username
            loggedInUserRole = role

            OpenFormBasedOnRole(role)
        End If
    End Sub

    ' Function to authenticate the user and retrieve the role
    Private Function AuthenticateUser(username As String, password As String) As Integer
        Dim role As Integer = 0
        Dim query As String = "SELECT role FROM [User] WHERE username=@username AND password=@password"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@username", username)
                command.Parameters.AddWithValue("@password", password)
                connection.Open()
                Dim result As Object = command.ExecuteScalar()

                ' If a role is retrieved, assign it to the role variable
                If result IsNot Nothing Then
                    role = Convert.ToInt32(result)
                End If
            End Using
        End Using

        ' Return the role
        Return role
    End Function



    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox2.Click
        Application.Exit()
    End Sub

    Private Sub OpenFormBasedOnRole(role As Int32)
        Select Case role
            Case "2"
                Dim adminForm As New Form3()
                adminForm.Show()
                Me.Hide()
            Case "1"
                Dim studentForm As New Form2()
                studentForm.Show()
                Me.Hide()
            Case Else
                MessageBox.Show("Invalid user role")
        End Select
    End Sub

End Class
