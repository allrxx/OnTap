Imports System.Data.SqlClient

Public Class Form1

    Dim connectionString As String = "Data Source=ALLRX\SQLEXPRESS;Initial Catalog=ontap;Integrated Security=True;Encrypt=False"

    ' Variable to store the username of the logged-in user
    Public Shared loggedInUsername As String

    ' Variable to store the role of the logged-in user
    Public Shared loggedInUserRole As Integer ' Changed to Integer

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Dim username As String = Guna2TextBox2.Text
        Dim password As String = Guna2TextBox1.Text

        ' Perform authentication and retrieve the role
        Dim role As Integer = AuthenticateUser(username, password) ' Changed to Integer
        If role <> 0 Then ' Check if role is not 0
            ' Store the username and role
            loggedInUsername = username
            loggedInUserRole = role

            OpenFormBasedOnRole(role)
        Else
            MessageBox.Show("Invalid username or password")
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

    Private Sub OpenFormBasedOnRole(role As Integer) ' Changed parameter type to Integer
        Select Case role
            Case 2 ' Removed quotes as we're comparing with an Integer
                Dim adminForm As New Form3()
                adminForm.Show()
                Me.Hide()
            Case 1 ' Removed quotes as we're comparing with an Integer
                Dim studentForm As New Form2()
                studentForm.Show()
                Me.Hide()
            Case Else
                MessageBox.Show("Invalid user role")
        End Select
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
