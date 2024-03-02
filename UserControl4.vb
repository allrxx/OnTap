Imports OnTap.Form2
Imports OnTap.UserControl3

Public Class UserControl4

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        ' Initialize an instance of Form2
        Dim r As Form2 = TryCast(Application.OpenForms("Form2"), Form2)

        ' Create an instance of UserControl5
        Dim UserSearch As New UserControl5

        ' Clear and add UserControl5 to the Guna2Panel1 of Form2
        r.Guna2Panel1.Controls.Clear()
        r.Guna2Panel1.Controls.Add(UserSearch)

    End Sub
End Class
