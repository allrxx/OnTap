<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl6
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Suite.CustomizableEdges()
        Guna2GroupBox1 = New Guna2GroupBox()
        SuspendLayout()
        ' 
        ' Guna2GroupBox1
        ' 
        Guna2GroupBox1.BorderColor = Color.White
        Guna2GroupBox1.BorderRadius = 18
        Guna2GroupBox1.CustomBorderColor = Color.White
        Guna2GroupBox1.CustomizableEdges = CustomizableEdges1
        Guna2GroupBox1.Font = New Font("Segoe UI", 9F)
        Guna2GroupBox1.ForeColor = Color.White
        Guna2GroupBox1.Location = New Point(34, 68)
        Guna2GroupBox1.Name = "Guna2GroupBox1"
        Guna2GroupBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2GroupBox1.Size = New Size(750, 307)
        Guna2GroupBox1.TabIndex = 0
        Guna2GroupBox1.Text = "Guna2GroupBox1"
        ' 
        ' UserControl6
        ' 
        AutoScaleDimensions = New SizeF(8F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(240), CByte(243), CByte(248))
        Controls.Add(Guna2GroupBox1)
        Name = "UserControl6"
        Size = New Size(817, 470)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2GroupBox1 As Guna2GroupBox

End Class
