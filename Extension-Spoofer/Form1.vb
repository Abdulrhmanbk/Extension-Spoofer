Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using openFileDialog As OpenFileDialog = New OpenFileDialog()
            openFileDialog.Filter = "Executable files (*.exe)|*.exe"
            openFileDialog.ShowDialog()

            TextBox1.Text = openFileDialog.FileName
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim rChar As String = ChrW("&H202E")
        Dim fileName As String = TextBox2.Text & rChar & StrReverse(TextBox3.Text) & ".exe"

        My.Computer.FileSystem.RenameFile(TextBox1.Text, fileName)
    End Sub
End Class
