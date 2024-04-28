Imports System.Reflection.Emit
Imports System.Text

Public Class Main
    Public mmlCode As String
    Public mmlCodePath As String
    Public settingFile As String
    Public outputFile As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\" & "setting.ini") Then
            settingFile = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\" & "setting.ini", System.Text.Encoding.Default)
        Else
            System.IO.File.Create(Application.StartupPath & "\" & "setting.ini").Close()
            settingFile = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\" & "setting.ini", System.Text.Encoding.Default)
        End If

        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\" & "output.log") = False Then
            System.IO.File.Create(Application.StartupPath & "\" & "output.log")
        End If

        outputTextBox.Text = ""
        mmlCodePath = ""
        mmlCodeTextBox.Text = ""
    End Sub

    Private Sub 結束XToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 結束XToolStripMenuItem.Click
        Dim choice As Integer
        If mmlCodeTextBox.Text <> mmlCode Then
            choice = MsgBox("您的檔案已修改，是否儲存？", vbYesNoCancel, "警告")
            If choice = 6 Then
                My.Computer.FileSystem.WriteAllText(mmlCodePath, mmlCodeTextBox.Text, False, System.Text.Encoding.Default)
                End
            ElseIf choice = 7 Then
                End
            End If
        Else
            End
        End If

    End Sub

    Private Sub 開啟舊檔OToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 開啟舊檔OToolStripMenuItem.Click

        If OpenFileDialog.ShowDialog() = DialogResult.OK Then
            mmlCodePath = OpenFileDialog.FileName
            mmlCode = My.Computer.FileSystem.ReadAllText(mmlCodePath, System.Text.Encoding.Default)
            mmlCodeTextBox.Text = mmlCode
        End If

    End Sub

    Private Sub 開新檔案NToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 開新檔案NToolStripMenuItem.Click
        mmlCodePath = ""
        mmlCodeTextBox.Text = ""
    End Sub

    Private Sub 關於這個程式AToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 關於這個程式AToolStripMenuItem.Click
        About.ShowDialog()
    End Sub

    Private Sub 儲存檔案SToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 儲存檔案SToolStripMenuItem.Click
        If mmlCodePath <> "" Then
            My.Computer.FileSystem.WriteAllText(mmlCodePath, mmlCodeTextBox.Text, False, System.Text.Encoding.Default)
            mmlCode = My.Computer.FileSystem.ReadAllText(mmlCodePath, System.Text.Encoding.Default)
        Else
            If SaveFileDialog.ShowDialog() = DialogResult.OK Then
                mmlCodePath = SaveFileDialog.FileName
                My.Computer.FileSystem.WriteAllText(mmlCodePath, mmlCodeTextBox.Text, False, System.Text.Encoding.Default)
                mmlCode = My.Computer.FileSystem.ReadAllText(mmlCodePath, System.Text.Encoding.Default)
            End If
        End If

    End Sub

    Private Sub 另存為ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 另存為ToolStripMenuItem.Click
        If SaveFileDialog.ShowDialog() = DialogResult.OK Then
            mmlCodePath = SaveFileDialog.FileName
            My.Computer.FileSystem.WriteAllText(mmlCodePath, mmlCodeTextBox.Text, False, System.Text.Encoding.Default)
        End If
    End Sub

    Private Sub 路徑指定DToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 路徑指定DToolStripMenuItem.Click
        Dictionary.ShowDialog()
    End Sub

    Private Sub 執行編譯RToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 執行編譯RToolStripMenuItem.Click
        settingFile = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\" & "setting.ini", System.Text.Encoding.Default)
        outputTextBox.Text = ""

        If Strings.InStr(settingFile, "MC.EXE") = 0 Then
            MsgBox("請指定正確的MC.EXE檔案之位置。", vbCritical, "錯誤")
        ElseIf My.Computer.FileSystem.FileExists(settingFile) = 0 Then
            MsgBox("指定的位置未找到MC.EXE。", vbCritical, "錯誤")

        ElseIf mmlCodePath = "" Then
            MsgBox("請先保存MML檔案。", vbExclamation, "警告")
            If SaveFileDialog.ShowDialog() = DialogResult.OK Then
                mmlCodePath = SaveFileDialog.FileName
                My.Computer.FileSystem.WriteAllText(mmlCodePath, mmlCodeTextBox.Text, False, System.Text.Encoding.Default)
                Shell("cmd.exe /c " & settingFile & " " & mmlCodePath & " " & ">" & " " & Application.StartupPath & "\" & "output.log", 1)
                Timer.Enabled = True
            End If

        ElseIf mmlCodeTextBox.Text <> mmlCode Then
            Dim choice As Integer
            choice = MsgBox("您的檔案已修改，是否儲存？", vbYesNoCancel, "警告")
            If choice = 6 Then
                My.Computer.FileSystem.WriteAllText(mmlCodePath, mmlCodeTextBox.Text, False, System.Text.Encoding.Default)
                Shell("cmd.exe /c " & settingFile & " " & mmlCodePath & " " & ">" & " " & Application.StartupPath & "\" & "output.log", 1)
                Timer.Enabled = True
            ElseIf choice = 7 Then
                Shell("cmd.exe /c " & settingFile & " " & mmlCodePath & " " & ">" & " " & Application.StartupPath & "\" & "output.log", 1)
                Timer.Enabled = True
            End If
        Else

            Shell("cmd.exe /c " & settingFile & " " & mmlCodePath & " " & ">" & " " & Application.StartupPath & "\" & "output.log", 1)
            Timer.Enabled = True
        End If
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        outputTextBox.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\" & "output.log", System.Text.Encoding.Default)
        Timer.Enabled = False
    End Sub
End Class
