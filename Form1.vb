Imports OnTap.Form2
Imports System.Data.SqlClient
Imports System.Security.Cryptography

Public Class Form1

    Dim connectionString As String = "Data Source=ALLRX\SQLEXPRESS;Initial Catalog=ontap;Integrated Security=True;Encrypt=False"

    ' Variable to store the username of the logged-in user
    Public Shared loggedInUsername As String
    ' Variable to store the role of the logged-in user
    Public Shared loggedInUserRole As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Form load logic (if any)
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Dim username As String = Guna2TextBox2.Text
        Dim password As String = Guna2TextBox1.Text

        ' Perform authentication and retrieve the username and role
        Dim role As String = AuthenticateUser(username, password)
        If Not String.IsNullOrEmpty(role) Then
            ' Store the username and role
            loggedInUsername = username
            loggedInUserRole = role

            ' Open the new form or perform other actions based on the role
            Dim form2 As New Form2()
            form2.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid credentials")
        End If
    End Sub

    ' Function to authenticate the user and retrieve the role
    Private Function AuthenticateUser(username As String, password As String) As String
        Dim role As String = ""
        Dim query As String = "SELECT role FROM [User] WHERE username=@username AND password=@password"

        Using connection As New SqlConnection(connectionString)
            Using Command As New SqlCommand(query, connection)
                Command.Parameters.AddWithValue("@username", username)
                Command.Parameters.AddWithValue("@password", password)
                connection.Open()
                Dim result As Object = Command.ExecuteScalar()

                ' If a role is retrieved, assign it to the role variable
                If result IsNot Nothing Then
                    role = Convert.ToString(result)
                End If
            End Using
        End Using

        ' Return the role
        Return role
    End Function

    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox2.Click
        Application.Exit()
    End Sub
End Class
