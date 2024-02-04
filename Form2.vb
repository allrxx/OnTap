Imports OnTap.Form1
Imports OnTap.UserControl2

Public Class Form2
    Dim v As New Form1()
    Dim u As New UserControl2()
    Private Sub Guna2GradientButton5_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton5.Click
        Application.Exit()
    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint
        u.Show()
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Dim AdminAccCreation As New UserControl2()
        Guna2Panel1.Controls.Clear()
        Guna2Panel1.Controls.Add(AdminAccCreation)
    End Sub
End Class