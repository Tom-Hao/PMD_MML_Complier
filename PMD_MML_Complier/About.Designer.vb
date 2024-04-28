<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(About))
        Me.okButton = New System.Windows.Forms.Button()
        Me.appNameLabel = New System.Windows.Forms.Label()
        Me.cpLabel = New System.Windows.Forms.Label()
        Me.mcCpLabel = New System.Windows.Forms.Label()
        Me.iconLabel = New System.Windows.Forms.Label()
        Me.iconBox = New System.Windows.Forms.PictureBox()
        CType(Me.iconBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'okButton
        '
        Me.okButton.Location = New System.Drawing.Point(189, 142)
        Me.okButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.okButton.Name = "okButton"
        Me.okButton.Size = New System.Drawing.Size(123, 38)
        Me.okButton.TabIndex = 0
        Me.okButton.Text = "確定"
        Me.okButton.UseVisualStyleBackColor = True
        '
        'appNameLabel
        '
        Me.appNameLabel.AutoSize = True
        Me.appNameLabel.Location = New System.Drawing.Point(121, 25)
        Me.appNameLabel.Name = "appNameLabel"
        Me.appNameLabel.Size = New System.Drawing.Size(259, 15)
        Me.appNameLabel.TabIndex = 1
        Me.appNameLabel.Text = "PMD MML編譯公用程式 版本 1.0.1.145"
        '
        'cpLabel
        '
        Me.cpLabel.AutoSize = True
        Me.cpLabel.Location = New System.Drawing.Point(121, 52)
        Me.cpLabel.Name = "cpLabel"
        Me.cpLabel.Size = New System.Drawing.Size(214, 15)
        Me.cpLabel.TabIndex = 2
        Me.cpLabel.Text = "版權所有 (C) 2024 Tom Hao 製作"
        '
        'mcCpLabel
        '
        Me.mcCpLabel.AutoSize = True
        Me.mcCpLabel.Location = New System.Drawing.Point(121, 105)
        Me.mcCpLabel.Name = "mcCpLabel"
        Me.mcCpLabel.Size = New System.Drawing.Size(325, 15)
        Me.mcCpLabel.TabIndex = 3
        Me.mcCpLabel.Text = "MML編譯程式MC 版權所有 (C) M.Kajihara(KAJA)"
        '
        'iconLabel
        '
        Me.iconLabel.AutoSize = True
        Me.iconLabel.Location = New System.Drawing.Point(121, 79)
        Me.iconLabel.Name = "iconLabel"
        Me.iconLabel.Size = New System.Drawing.Size(232, 15)
        Me.iconLabel.TabIndex = 4
        Me.iconLabel.Text = "這個程式的圖標由凜果與百橙繪製"
        '
        'iconBox
        '
        Me.iconBox.Image = CType(resources.GetObject("iconBox.Image"), System.Drawing.Image)
        Me.iconBox.Location = New System.Drawing.Point(31, 25)
        Me.iconBox.Margin = New System.Windows.Forms.Padding(4)
        Me.iconBox.Name = "iconBox"
        Me.iconBox.Size = New System.Drawing.Size(64, 60)
        Me.iconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.iconBox.TabIndex = 5
        Me.iconBox.TabStop = False
        '
        'About
        '
        Me.AcceptButton = Me.okButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 194)
        Me.Controls.Add(Me.iconBox)
        Me.Controls.Add(Me.iconLabel)
        Me.Controls.Add(Me.mcCpLabel)
        Me.Controls.Add(Me.cpLabel)
        Me.Controls.Add(Me.appNameLabel)
        Me.Controls.Add(Me.okButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpButton = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "About"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "關於 PMD MML編譯公用程式"
        CType(Me.iconBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents okButton As Button
    Friend WithEvents appNameLabel As Label
    Friend WithEvents cpLabel As Label
    Friend WithEvents mcCpLabel As Label
    Friend WithEvents iconLabel As Label
    Friend WithEvents iconBox As PictureBox
End Class
