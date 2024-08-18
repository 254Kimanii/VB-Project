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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        lblFirstName = New Label()
        txtFirstName = New TextBox()
        txtRegNo = New TextBox()
        lblRegNo = New Label()
        txtPassword = New TextBox()
        lblPassword = New Label()
        btnLogin = New Button()
        btnRegister = New Button()
        lblSignIn = New Label()
        SuspendLayout()
        ' 
        ' lblFirstName
        ' 
        lblFirstName.AutoSize = True
        lblFirstName.BackColor = SystemColors.InactiveCaption
        lblFirstName.Location = New Point(249, 69)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New Size(97, 25)
        lblFirstName.TabIndex = 0
        lblFirstName.Text = "First Name"
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(249, 114)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(335, 31)
        txtFirstName.TabIndex = 1
        ' 
        ' txtRegNo
        ' 
        txtRegNo.Location = New Point(249, 210)
        txtRegNo.Name = "txtRegNo"
        txtRegNo.Size = New Size(335, 31)
        txtRegNo.TabIndex = 2
        ' 
        ' lblRegNo
        ' 
        lblRegNo.AutoSize = True
        lblRegNo.BackColor = SystemColors.InactiveCaption
        lblRegNo.Location = New Point(249, 165)
        lblRegNo.Name = "lblRegNo"
        lblRegNo.Size = New Size(176, 25)
        lblRegNo.TabIndex = 3
        lblRegNo.Text = "Registration Number"
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(249, 306)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(335, 31)
        txtPassword.TabIndex = 4
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.BackColor = SystemColors.InactiveCaption
        lblPassword.Location = New Point(249, 261)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(87, 25)
        lblPassword.TabIndex = 5
        lblPassword.Text = "Password"
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = SystemColors.ActiveCaption
        btnLogin.FlatStyle = FlatStyle.Popup
        btnLogin.ForeColor = SystemColors.ControlLightLight
        btnLogin.Location = New Point(329, 355)
        btnLogin.Margin = New Padding(3, 3, 3, 8)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(212, 37)
        btnLogin.TabIndex = 6
        btnLogin.Text = "Sign In"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' btnRegister
        ' 
        btnRegister.Location = New Point(329, 408)
        btnRegister.Margin = New Padding(8)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(212, 35)
        btnRegister.TabIndex = 7
        btnRegister.Text = "Create Account"
        btnRegister.UseVisualStyleBackColor = True
        ' 
        ' lblSignIn
        ' 
        lblSignIn.AutoSize = True
        lblSignIn.BackColor = SystemColors.ActiveCaption
        lblSignIn.FlatStyle = FlatStyle.Popup
        lblSignIn.Font = New Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSignIn.Location = New Point(329, 9)
        lblSignIn.Name = "lblSignIn"
        lblSignIn.Size = New Size(80, 25)
        lblSignIn.TabIndex = 9
        lblSignIn.Text = "Sign In"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.MenuHighlight
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(800, 450)
        Controls.Add(lblSignIn)
        Controls.Add(btnRegister)
        Controls.Add(btnLogin)
        Controls.Add(lblPassword)
        Controls.Add(txtPassword)
        Controls.Add(lblRegNo)
        Controls.Add(txtRegNo)
        Controls.Add(txtFirstName)
        Controls.Add(lblFirstName)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtRegNo As TextBox
    Friend WithEvents lblRegNo As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnRegister As Button
    Friend WithEvents lblSignIn As Label

End Class
