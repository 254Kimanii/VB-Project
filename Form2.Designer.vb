<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        lblSchool = New Label()
        btnSubmit = New Button()
        cbxSchool = New ComboBox()
        cbxParticipants = New ComboBox()
        lblDelegate = New Label()
        SuspendLayout()
        ' 
        ' lblSchool
        ' 
        lblSchool.AutoSize = True
        lblSchool.BorderStyle = BorderStyle.FixedSingle
        lblSchool.Location = New Point(40, 35)
        lblSchool.Name = "lblSchool"
        lblSchool.Size = New Size(172, 27)
        lblSchool.TabIndex = 0
        lblSchool.Text = "Choose your school"
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.DeepSkyBlue
        btnSubmit.Location = New Point(40, 171)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(112, 34)
        btnSubmit.TabIndex = 4
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' cbxSchool
        ' 
        cbxSchool.FormattingEnabled = True
        cbxSchool.Items.AddRange(New Object() {"COPAS", "COETEC", "COHRED"})
        cbxSchool.Location = New Point(244, 34)
        cbxSchool.Name = "cbxSchool"
        cbxSchool.Size = New Size(182, 33)
        cbxSchool.TabIndex = 5
        ' 
        ' cbxParticipants
        ' 
        cbxParticipants.FormattingEnabled = True
        cbxParticipants.Location = New Point(244, 103)
        cbxParticipants.Name = "cbxParticipants"
        cbxParticipants.Size = New Size(182, 33)
        cbxParticipants.TabIndex = 6
        ' 
        ' lblDelegate
        ' 
        lblDelegate.AutoSize = True
        lblDelegate.Location = New Point(40, 111)
        lblDelegate.Name = "lblDelegate"
        lblDelegate.Size = New Size(63, 25)
        lblDelegate.TabIndex = 7
        lblDelegate.Text = "Label1"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblDelegate)
        Controls.Add(cbxParticipants)
        Controls.Add(cbxSchool)
        Controls.Add(btnSubmit)
        Controls.Add(lblSchool)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblSchool As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents cbxSchool As ComboBox
    Friend WithEvents cbxParticipants As ComboBox
    Friend WithEvents lblDelegate As Label
End Class
