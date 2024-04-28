<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dictionary
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pathTextBox = New System.Windows.Forms.TextBox()
        Me.pathButton = New System.Windows.Forms.Button()
        Me.okButton = New System.Windows.Forms.Button()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MML編譯器MC之所在路徑："
        '
        'pathTextBox
        '
        Me.pathTextBox.Location = New System.Drawing.Point(20, 30)
        Me.pathTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pathTextBox.Name = "pathTextBox"
        Me.pathTextBox.Size = New System.Drawing.Size(348, 22)
        Me.pathTextBox.TabIndex = 1
        '
        'pathButton
        '
        Me.pathButton.Location = New System.Drawing.Point(366, 30)
        Me.pathButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pathButton.Name = "pathButton"
        Me.pathButton.Size = New System.Drawing.Size(21, 20)
        Me.pathButton.TabIndex = 2
        Me.pathButton.Text = "..."
        Me.pathButton.UseVisualStyleBackColor = True
        '
        'okButton
        '
        Me.okButton.Location = New System.Drawing.Point(140, 67)
        Me.okButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.okButton.Name = "okButton"
        Me.okButton.Size = New System.Drawing.Size(95, 22)
        Me.okButton.TabIndex = 3
        Me.okButton.Text = "確定"
        Me.okButton.UseVisualStyleBackColor = True
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.Filter = "MML編譯程式MC|MC.EXE"
        '
        'Dictionary
        '
        Me.AcceptButton = Me.okButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 99)
        Me.Controls.Add(Me.okButton)
        Me.Controls.Add(Me.pathButton)
        Me.Controls.Add(Me.pathTextBox)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpButton = True
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Dictionary"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "路徑指定"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents pathTextBox As TextBox
    Friend WithEvents pathButton As Button
    Friend WithEvents okButton As Button
    Friend WithEvents OpenFileDialog As OpenFileDialog
End Class
