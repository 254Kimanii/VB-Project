<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        lblFirstname3 = New Label()
        lblLastName3 = New Label()
        lblRegNo3 = New Label()
        lblPassword3 = New Label()
        lblConfirmPassword = New Label()
        btnRegister3 = New Button()
        txtFirstName3 = New TextBox()
        txtLastName3 = New TextBox()
        txtRegNo3 = New TextBox()
        txtPassword3 = New TextBox()
        txtConfirmPassword3 = New TextBox()
        PictureBox1 = New PictureBox()
        lblSignUp = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblFirstname3
        ' 
        lblFirstname3.AutoSize = True
        lblFirstname3.ForeColor = SystemColors.HighlightText
        lblFirstname3.Location = New Point(368, 55)
        lblFirstname3.Name = "lblFirstname3"
        lblFirstname3.Size = New Size(97, 25)
        lblFirstname3.TabIndex = 0
        lblFirstname3.Text = "First Name"
        ' 
        ' lblLastName3
        ' 
        lblLastName3.AutoSize = True
        lblLastName3.ForeColor = SystemColors.HighlightText
        lblLastName3.Location = New Point(368, 112)
        lblLastName3.Name = "lblLastName3"
        lblLastName3.Size = New Size(95, 25)
        lblLastName3.TabIndex = 1
        lblLastName3.Text = "Last Name"
        ' 
        ' lblRegNo3
        ' 
        lblRegNo3.AutoSize = True
        lblRegNo3.ForeColor = SystemColors.HighlightText
        lblRegNo3.Location = New Point(368, 174)
        lblRegNo3.Name = "lblRegNo3"
        lblRegNo3.Size = New Size(176, 25)
        lblRegNo3.TabIndex = 2
        lblRegNo3.Text = "Registration Number"
        ' 
        ' lblPassword3
        ' 
        lblPassword3.AutoSize = True
        lblPassword3.ForeColor = SystemColors.HighlightText
        lblPassword3.Location = New Point(368, 227)
        lblPassword3.Name = "lblPassword3"
        lblPassword3.Size = New Size(87, 25)
        lblPassword3.TabIndex = 3
        lblPassword3.Text = "Password"
        ' 
        ' lblConfirmPassword
        ' 
        lblConfirmPassword.AutoSize = True
        lblConfirmPassword.ForeColor = SystemColors.HighlightText
        lblConfirmPassword.Location = New Point(368, 281)
        lblConfirmPassword.Name = "lblConfirmPassword"
        lblConfirmPassword.Size = New Size(156, 25)
        lblConfirmPassword.TabIndex = 4
        lblConfirmPassword.Text = "Confirm Password"
        ' 
        ' btnRegister3
        ' 
        btnRegister3.BackColor = Color.DarkOrchid
        btnRegister3.FlatStyle = FlatStyle.Popup
        btnRegister3.ForeColor = SystemColors.ControlLight
        btnRegister3.Location = New Point(543, 360)
        btnRegister3.Name = "btnRegister3"
        btnRegister3.Size = New Size(181, 43)
        btnRegister3.TabIndex = 5
        btnRegister3.Text = "Register"
        btnRegister3.UseVisualStyleBackColor = False
        ' 
        ' txtFirstName3
        ' 
        txtFirstName3.Location = New Point(554, 57)
        txtFirstName3.Name = "txtFirstName3"
        txtFirstName3.Size = New Size(157, 31)
        txtFirstName3.TabIndex = 6
        ' 
        ' txtLastName3
        ' 
        txtLastName3.Location = New Point(554, 109)
        txtLastName3.Name = "txtLastName3"
        txtLastName3.Size = New Size(157, 31)
        txtLastName3.TabIndex = 7
        ' 
        ' txtRegNo3
        ' 
        txtRegNo3.Location = New Point(554, 174)
        txtRegNo3.Name = "txtRegNo3"
        txtRegNo3.Size = New Size(157, 31)
        txtRegNo3.TabIndex = 8
        ' 
        ' txtPassword3
        ' 
        txtPassword3.Location = New Point(554, 227)
        txtPassword3.Name = "txtPassword3"
        txtPassword3.PasswordChar = "*"c
        txtPassword3.Size = New Size(157, 31)
        txtPassword3.TabIndex = 9
        ' 
        ' txtConfirmPassword3
        ' 
        txtConfirmPassword3.Location = New Point(554, 278)
        txtConfirmPassword3.Name = "txtConfirmPassword3"
        txtConfirmPassword3.PasswordChar = "*"c
        txtConfirmPassword3.Size = New Size(157, 31)
        txtConfirmPassword3.TabIndex = 10
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(313, 381)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' lblSignUp
        ' 
        lblSignUp.AutoSize = True
        lblSignUp.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSignUp.ForeColor = SystemColors.GradientInactiveCaption
        lblSignUp.Location = New Point(481, 9)
        lblSignUp.Name = "lblSignUp"
        lblSignUp.Size = New Size(94, 30)
        lblSignUp.TabIndex = 12
        lblSignUp.Text = "Sign Up"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MidnightBlue
        ClientSize = New Size(800, 450)
        Controls.Add(lblSignUp)
        Controls.Add(PictureBox1)
        Controls.Add(txtConfirmPassword3)
        Controls.Add(txtPassword3)
        Controls.Add(txtRegNo3)
        Controls.Add(txtLastName3)
        Controls.Add(txtFirstName3)
        Controls.Add(btnRegister3)
        Controls.Add(lblConfirmPassword)
        Controls.Add(lblPassword3)
        Controls.Add(lblRegNo3)
        Controls.Add(lblLastName3)
        Controls.Add(lblFirstname3)
        Name = "Form3"
        Text = "Form3"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblFirstname3 As Label
    Friend WithEvents lblLastName3 As Label
    Friend WithEvents lblRegNo3 As Label
    Friend WithEvents lblPassword3 As Label
    Friend WithEvents lblConfirmPassword As Label
    Friend WithEvents btnRegister3 As Button
    Friend WithEvents txtFirstName3 As TextBox
    Friend WithEvents txtLastName3 As TextBox
    Friend WithEvents txtRegNo3 As TextBox
    Friend WithEvents txtPassword3 As TextBox
    Friend WithEvents txtConfirmPassword3 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblSignUp As Label
End Class
