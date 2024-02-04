Imports OnTap.Form2

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Dim r As New Form2()
        If Guna2TextBox2.Text = "alexjoy0480@gmail.com" And Guna2TextBox1.Text = "admin" Then
            r.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid Password")
        End If
    End Sub

    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox2.Click
        Application.Exit()
    End Sub
End Class
