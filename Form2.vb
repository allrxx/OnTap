Imports OnTap.Form1
Imports OnTap.UserControl2
Imports OnTap.UserControl3

Public Class Form2
    Dim v As New Form1()
    Dim u As New UserControl2()
    Dim CurrentUsername As String = Form1.loggedInUsername
    Dim CurrentRole As String = Form1.loggedInUserRole


    Private Sub Guna2GradientButton5_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton5.Click
        Application.Exit()
    End Sub

    Private Sub Guna2GradientButton6_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton6.Click
        Dim StudentDashboard As New UserControl1()
        Guna2Panel1.Controls.Clear()
        Guna2Panel1.Controls.Add(StudentDashboard)

    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        Dim AttendanceOverview As New UserControl3()
        Guna2Panel1.Controls.Clear()
        Guna2Panel1.Controls.Add(AttendanceOverview)
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Guna2GradientButton4_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton4.Click
        Dim StudentPassChange As New PasswordChange()
        Guna2Panel1.Controls.Clear()
        Guna2Panel1.Controls.Add(StudentPassChange)
    End Sub
End Class
