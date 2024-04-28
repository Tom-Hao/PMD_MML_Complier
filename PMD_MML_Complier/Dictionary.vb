Public Class Dictionary
    Public settingFile As String

    Private Sub pathTextBox_TextChanged(sender As Object, e As EventArgs) Handles pathTextBox.TextChanged

    End Sub

    Private Sub Dictionary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\" & "setting.ini") Then
            settingFile = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\" & "setting.ini", System.Text.Encoding.Default)
        Else
            System.IO.File.Create(Application.StartupPath & "\" & "setting.ini")
        End If
        pathTextBox.Text = settingFile

    End Sub

    Private Sub pathButton_Click(sender As Object, e As EventArgs) Handles pathButton.Click
        If OpenFileDialog.ShowDialog() = DialogResult.OK Then
            pathTextBox.Text = OpenFileDialog.FileName
        End If
    End Sub

    Private Sub okButton_Click(sender As Object, e As EventArgs) Handles okButton.Click
        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\" & "setting.ini", pathTextBox.Text, False, System.Text.Encoding.Default)
        Me.Close()
    End Sub
End Class