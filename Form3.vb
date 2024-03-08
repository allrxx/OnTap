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

End Class