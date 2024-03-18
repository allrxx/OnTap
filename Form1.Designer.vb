<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Suite.CustomizableEdges()
        LoginPage = New Guna2BorderlessForm(components)
        Guna2TextBox1 = New Guna2TextBox()
        Guna2TextBox2 = New Guna2TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Guna2ToggleSwitch1 = New Guna2ToggleSwitch()
        Guna2PictureBox1 = New Guna2PictureBox()
        Label3 = New Label()
        Guna2GradientButton1 = New Guna2GradientButton()
        Label4 = New Label()
        Label5 = New Label()
        Guna2PictureBox2 = New Guna2PictureBox()
        CType(Guna2PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(Guna2PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LoginPage
        ' 
        LoginPage.BorderRadius = 15
        LoginPage.ContainerControl = Me
        LoginPage.DockIndicatorTransparencyValue = 0.25R
        LoginPage.TransparentWhileDrag = True
        ' 
        ' Guna2TextBox1
        ' 
        Guna2TextBox1.BorderRadius = 22
        Guna2TextBox1.CustomizableEdges = CustomizableEdges11
        Guna2TextBox1.DefaultText = "Password"
        Guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        Guna2TextBox1.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        Guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox1.Font = New Font("Segoe UI", 9F)
        Guna2TextBox1.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox1.IconLeft = My.Resources.Resources.Password_Icon
        Guna2TextBox1.IconLeftOffset = New Point(7, 0)
        Guna2TextBox1.IconLeftSize = New Size(25, 25)
        Guna2TextBox1.Location = New Point(606, 279)
        Guna2TextBox1.Name = "Guna2TextBox1"
        Guna2TextBox1.PasswordChar = ChrW(0)
        Guna2TextBox1.PlaceholderText = ""
        Guna2TextBox1.SelectedText = ""
        Guna2TextBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        Guna2TextBox1.Size = New Size(338, 45)
        Guna2TextBox1.TabIndex = 1
        Guna2TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' Guna2TextBox2
        ' 
        Guna2TextBox2.BackgroundImageLayout = ImageLayout.None
        Guna2TextBox2.BorderRadius = 22
        Guna2TextBox2.CustomizableEdges = CustomizableEdges9
        Guna2TextBox2.DefaultText = "Username"
        Guna2TextBox2.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        Guna2TextBox2.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        Guna2TextBox2.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox2.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox2.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox2.Font = New Font("Segoe UI", 9F)
        Guna2TextBox2.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox2.IconLeft = My.Resources.Resources.icons8_user_male_94
        Guna2TextBox2.IconLeftOffset = New Point(7, 0)
        Guna2TextBox2.IconLeftSize = New Size(25, 25)
        Guna2TextBox2.Location = New Point(606, 220)
        Guna2TextBox2.Name = "Guna2TextBox2"
        Guna2TextBox2.PasswordChar = ChrW(0)
        Guna2TextBox2.PlaceholderText = ""
        Guna2TextBox2.SelectedText = ""
        Guna2TextBox2.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        Guna2TextBox2.Size = New Size(338, 45)
        Guna2TextBox2.TabIndex = 2
        Guna2TextBox2.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.FlatStyle = FlatStyle.System
        Label1.Font = New Font("Yu Gothic Medium", 23F, FontStyle.Bold)
        Label1.Location = New Point(626, 151)
        Label1.Name = "Label1"
        Label1.Size = New Size(310, 44)
        Label1.TabIndex = 3
        Label1.Text = "Welcome Back !!!"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(664, 344)
        Label2.Name = "Label2"
        Label2.Size = New Size(99, 17)
        Label2.TabIndex = 4
        Label2.Text = "Show Password"
        ' 
        ' Guna2ToggleSwitch1
        ' 
        Guna2ToggleSwitch1.CheckedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2ToggleSwitch1.CheckedState.FillColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2ToggleSwitch1.CheckedState.InnerBorderColor = Color.White
        Guna2ToggleSwitch1.CheckedState.InnerColor = Color.White
        Guna2ToggleSwitch1.CustomizableEdges = CustomizableEdges7
        Guna2ToggleSwitch1.Location = New Point(621, 344)
        Guna2ToggleSwitch1.Name = "Guna2ToggleSwitch1"
        Guna2ToggleSwitch1.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        Guna2ToggleSwitch1.Size = New Size(34, 20)
        Guna2ToggleSwitch1.TabIndex = 5
        Guna2ToggleSwitch1.UncheckedState.BorderColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        Guna2ToggleSwitch1.UncheckedState.FillColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        Guna2ToggleSwitch1.UncheckedState.InnerBorderColor = Color.White
        Guna2ToggleSwitch1.UncheckedState.InnerColor = Color.White
        ' 
        ' Guna2PictureBox1
        ' 
        Guna2PictureBox1.CustomizableEdges = CustomizableEdges5
        Guna2PictureBox1.Image = My.Resources.Resources.Create_an_image_with_a_white_background_for_the___1_
        Guna2PictureBox1.ImageRotate = 0F
        Guna2PictureBox1.Location = New Point(-13, -3)
        Guna2PictureBox1.Name = "Guna2PictureBox1"
        Guna2PictureBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2PictureBox1.Size = New Size(568, 573)
        Guna2PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Guna2PictureBox1.TabIndex = 6
        Guna2PictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Yu Gothic UI", 23F, FontStyle.Bold)
        Label3.Location = New Point(723, 104)
        Label3.Name = "Label3"
        Label3.Size = New Size(101, 46)
        Label3.TabIndex = 7
        Label3.Text = "Hello"
        ' 
        ' Guna2GradientButton1
        ' 
        Guna2GradientButton1.BorderRadius = 14
        Guna2GradientButton1.CustomizableEdges = CustomizableEdges3
        Guna2GradientButton1.DisabledState.BorderColor = Color.DarkGray
        Guna2GradientButton1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2GradientButton1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2GradientButton1.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2GradientButton1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2GradientButton1.FillColor = Color.FromArgb(CByte(60), CByte(145), CByte(239))
        Guna2GradientButton1.FillColor2 = Color.FromArgb(CByte(57), CByte(157), CByte(238))
        Guna2GradientButton1.Font = New Font("Segoe UI", 9F)
        Guna2GradientButton1.ForeColor = Color.White
        Guna2GradientButton1.Location = New Point(607, 382)
        Guna2GradientButton1.Name = "Guna2GradientButton1"
        Guna2GradientButton1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2GradientButton1.Size = New Size(338, 41)
        Guna2GradientButton1.TabIndex = 8
        Guna2GradientButton1.Text = "Login"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe MDL2 Assets", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ControlDarkDark
        Label4.Location = New Point(620, 430)
        Label4.Name = "Label4"
        Label4.Size = New Size(127, 14)
        Label4.TabIndex = 9
        Label4.Text = "Don't have an account ?"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.FlatStyle = FlatStyle.System
        Label5.Font = New Font("Segoe MDL2 Assets", 8.830189F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ActiveCaptionText
        Label5.Location = New Point(747, 431)
        Label5.Name = "Label5"
        Label5.Size = New Size(116, 13)
        Label5.TabIndex = 10
        Label5.Text = "Can't find your account ?"
        ' 
        ' Guna2PictureBox2
        ' 
        Guna2PictureBox2.BackColor = Color.White
        Guna2PictureBox2.CustomizableEdges = CustomizableEdges1
        Guna2PictureBox2.Image = My.Resources.Resources.icons8_close_48
        Guna2PictureBox2.ImageRotate = 0F
        Guna2PictureBox2.Location = New Point(951, 12)
        Guna2PictureBox2.Name = "Guna2PictureBox2"
        Guna2PictureBox2.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2PictureBox2.Size = New Size(30, 30)
        Guna2PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        Guna2PictureBox2.TabIndex = 11
        Guna2PictureBox2.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(254), CByte(254), CByte(254))
        ClientSize = New Size(994, 568)
        Controls.Add(Guna2PictureBox2)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Guna2GradientButton1)
        Controls.Add(Label3)
        Controls.Add(Guna2PictureBox1)
        Controls.Add(Guna2ToggleSwitch1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Guna2TextBox2)
        Controls.Add(Guna2TextBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        Opacity = 0.85R
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(Guna2PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(Guna2PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LoginPage As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2ToggleSwitch1 As Guna.UI2.WinForms.Guna2ToggleSwitch
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2GradientButton1 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Guna2PictureBox2 As Guna2PictureBox

End Class
