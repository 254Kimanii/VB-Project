Imports MySql.Data.MySqlClient
Public Class Form1
    Dim con As New MySqlConnection("server=localhost;userid=root;password=2002;database=infouser")
    Dim cmd As New MySqlCommand
    Dim result As Integer
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT COUNT(1) FROM user_info WHERE first_name = @FirstName AND password = @Password AND registration_number = @RegNumber"
            cmd.Parameters.Clear() ' Clear existing parameters
            cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text)
            cmd.Parameters.AddWithValue("@RegNumber", txtRegNo.Text)
            cmd.Parameters.AddWithValue("@password", txtPassword.Text)

            If Convert.ToInt32(cmd.ExecuteScalar()) > 0 Then
                MessageBox.Show("Successful login!")
                Dim votingForm As New Form2()
                votingForm.Show()
                Me.Hide()
            Else
                MessageBox.Show("Try again. Invalid username or password.")
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

End Class
