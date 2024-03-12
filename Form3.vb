Imports OnTap.StudentAccountCreation

Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CurrentUsername As String = Form1.loggedInUsername
        Dim CurrentRole As String = Form1.loggedInUserRole

        ProfileUsername.Text = CurrentUsername

    End Sub


    Private Sub Guna2GradientButton5_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton5.Click
        Application.Exit()
    End Sub

    Private Sub Guna2GradientButton6_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton6.Click
        Dim AdminDashboard As New UserControl4()
        Guna2Panel1.Controls.Clear()
        Guna2Panel1.Controls.Add(AdminDashboard)
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click

        Dim AdminAccountCreation As New UserControl2
        Guna2Panel1.Controls.Clear()
        Guna2Panel1.Controls.Add(AdminAccountCreation)

    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click

        Dim StudentAccountCreation As New StudentAccountCreation
        Guna2Panel1.Controls.Clear()
        Guna2Panel1.Controls.Add(StudentAccountCreation)

    End Sub

    Private Sub Guna2GradientButton7_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton7.Click

        Dim AddAttendance As New AddAttendance()
        Guna2Panel1.Controls.Clear()
        Guna2Panel1.Controls.Add(AddAttendance)

    End Sub

    Private Sub Guna2GradientButton3_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton3.Click

        Dim DeleteUser As New UserControl5()
        Guna2Panel1.Controls.Clear()
        Guna2Panel1.Controls.Add(DeleteUser)

    End Sub

    Private Sub Guna2GradientButton4_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton4.Click
        Dim changepassword As New PasswordChange()
        Guna2Panel1.Controls.Clear()
        Guna2Panel1.Controls.Add(changepassword)
    End Sub
End Class