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

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Dim AdminAccCreation As New UserControl2()
        Guna2Panel1.Controls.Clear()
        Guna2Panel1.Controls.Add(AdminAccCreation)
    End Sub

    Private Sub Guna2GradientButton6_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton6.Click
        If CurrentRole = "admin" Then
            Dim StudentDashboard As New UserControl1()
            Guna2Panel1.Controls.Clear()
            Guna2Panel1.Controls.Add(StudentDashboard)

        Else
            Dim AdminDashBoard As New UserControl4
            Guna2Panel1.Controls.Clear()
            Guna2Panel1.Controls.Add(AdminDashBoard)
        End If
    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        Dim AttendanceOverview As New UserControl3()
        Guna2Panel1.Controls.Clear()
        Guna2Panel1.Controls.Add(AttendanceOverview)
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Add UserControl2 to Guna2Panel1 only if it's not already added
        If Not Guna2Panel1.Controls.Contains(u) Then
            Guna2Panel1.Controls.Clear()
            Guna2Panel1.Controls.Add(u)
        End If

        If CurrentRole = "admin" Then
            Guna2GradientButton1.Hide()
            Guna2GradientButton2.Hide()
            Guna2GradientButton3.Hide()
        End If
    End Sub
End Class
