Imports MySql.Data.MySqlClient

Public Class Form2
    Dim connString As String = "Server=localhost;Database=infouser;Uid=root;Pwd=2002;"
    Dim conn As New MySqlConnection(connString)

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.Open()
            MessageBox.Show("Connected to MySQL database!")
        Catch ex As Exception
            MessageBox.Show("Error connecting to database: " & ex.Message)
        End Try
    End Sub

    Private Sub cbxSchool_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxSchool.SelectedIndexChanged
        ' Clear existing items in ComboBox2
        cbxParticipants.Items.Clear()
        Dim selectedCategory As String = cbxSchool.SelectedItem.ToString()

        ' Add candidates based on the selected school
        Select Case selectedCategory
            Case "COPAS"
                cbxParticipants.Items.Add("Candidate A")
                cbxParticipants.Items.Add("Candidate B")
            Case "COETEC"
                cbxParticipants.Items.Add("Candidate X")
                cbxParticipants.Items.Add("Candidate Y")
            Case "COHRED"
                cbxParticipants.Items.Add("Candidate P")
                cbxParticipants.Items.Add("Candidate Q")
                ' Add more cases for other schools
        End Select

        lblDelegate.Text = "Pick a delegate"
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim selectedCandidate As String = cbxParticipants.SelectedItem.ToString()
        Dim selectedSchool As String = cbxSchool.SelectedItem.ToString()

        ' Update votes in the Candidates table
        Dim sql As String = $"UPDATE user_info SET Votes = Votes + 1 WHERE candidate = @CandidateName"
        Dim cmd As New MySqlCommand(sql, conn)
        cmd.Parameters.AddWithValue("@CandidateName", selectedCandidate)

        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show($"Vote added for {selectedCandidate} from {selectedSchool}!")
        Catch ex As Exception
            MessageBox.Show("Error updating votes: " & ex.Message)
        End Try
    End Sub
End Class
