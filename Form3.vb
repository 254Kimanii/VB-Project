Imports MySql.Data.MySqlClient

Public Class Form3
    Private Sub btnRegister3_Click(sender As Object, e As EventArgs) Handles btnRegister3.Click

        Dim connectionString As String = "server=localhost;userid=root;password=2002;database=infouser"
        Dim connection As New MySqlConnection(connectionString)

        Try
            connection.Open()

            Dim sqlQuery As String = "INSERT INTO user_info (first_name, last_name, registration_number, password) VALUES (@FirstName, @LastName, @RegNumber, @Password)"
            Dim cmd As New MySqlCommand(sqlQuery, connection)

            cmd.Parameters.AddWithValue("@FirstName", txtFirstName3.Text)
            cmd.Parameters.AddWithValue("@LastName", txtLastName3.Text)
            cmd.Parameters.AddWithValue("@RegNumber", txtRegNo3.Text)
            cmd.Parameters.AddWithValue("@Password", txtPassword3.Text)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Registration successful!")

            ClearFields() ' Custom method to clear textboxes

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub ClearFields()
        txtFirstName3.Clear()
        txtLastName3.Clear()
        txtRegNo3.Clear()
        txtPassword3.Clear()
        txtConfirmPassword3.Clear()

        Dim loginForm As New Form1()
        loginForm.Show()
        Me.Hide()
    End Sub
End Class