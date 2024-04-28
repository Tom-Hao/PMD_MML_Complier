<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.mainMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.檔案FToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.開新檔案NToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.開啟舊檔OToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.儲存檔案SToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.另存為ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.結束XToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.編譯CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.執行編譯RToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.編輯EToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.路徑指定DToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.說明HToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.關於這個程式AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.outputGroupBox = New System.Windows.Forms.GroupBox()
        Me.outputTextBox = New System.Windows.Forms.RichTextBox()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.mmlCodeTextBox = New System.Windows.Forms.TextBox()
        Me.mainMenuStrip.SuspendLayout()
        Me.outputGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainMenuStrip
        '
        Me.mainMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mainMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.檔案FToolStripMenuItem, Me.編譯CToolStripMenuItem, Me.編輯EToolStripMenuItem, Me.說明HToolStripMenuItem})
        Me.mainMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.mainMenuStrip.Name = "mainMenuStrip"
        Me.mainMenuStrip.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.mainMenuStrip.Size = New System.Drawing.Size(711, 24)
        Me.mainMenuStrip.TabIndex = 1
        Me.mainMenuStrip.Text = "MenuStrip1"
        '
        '檔案FToolStripMenuItem
        '
        Me.檔案FToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.開新檔案NToolStripMenuItem, Me.開啟舊檔OToolStripMenuItem, Me.儲存檔案SToolStripMenuItem, Me.另存為ToolStripMenuItem, Me.ToolStripSeparator1, Me.結束XToolStripMenuItem})
        Me.檔案FToolStripMenuItem.Name = "檔案FToolStripMenuItem"
        Me.檔案FToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.檔案FToolStripMenuItem.Text = "檔案(&F)"
        '
        '開新檔案NToolStripMenuItem
        '
        Me.開新檔案NToolStripMenuItem.Name = "開新檔案NToolStripMenuItem"
        Me.開新檔案NToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.開新檔案NToolStripMenuItem.Text = "開新檔案(&N)"
        '
        '開啟舊檔OToolStripMenuItem
        '
        Me.開啟舊檔OToolStripMenuItem.Name = "開啟舊檔OToolStripMenuItem"
        Me.開啟舊檔OToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.開啟舊檔OToolStripMenuItem.Text = "開啟舊檔(&O)..."
        '
        '儲存檔案SToolStripMenuItem
        '
        Me.儲存檔案SToolStripMenuItem.Name = "儲存檔案SToolStripMenuItem"
        Me.儲存檔案SToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.儲存檔案SToolStripMenuItem.Text = "儲存檔案(&S)"
        '
        '另存為ToolStripMenuItem
        '
        Me.另存為ToolStripMenuItem.Name = "另存為ToolStripMenuItem"
        Me.另存為ToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.另存為ToolStripMenuItem.Text = "另存為..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(146, 6)
        '
        '結束XToolStripMenuItem
        '
        Me.結束XToolStripMenuItem.Name = "結束XToolStripMenuItem"
        Me.結束XToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.結束XToolStripMenuItem.Text = "結束(&X)"
        '
        '編譯CToolStripMenuItem
        '
        Me.編譯CToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.執行編譯RToolStripMenuItem})
        Me.編譯CToolStripMenuItem.Name = "編譯CToolStripMenuItem"
        Me.編譯CToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.編譯CToolStripMenuItem.Text = "編譯(&C)"
        '
        '執行編譯RToolStripMenuItem
        '
        Me.執行編譯RToolStripMenuItem.Name = "執行編譯RToolStripMenuItem"
        Me.執行編譯RToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.執行編譯RToolStripMenuItem.Text = "執行編譯(&R)"
        '
        '編輯EToolStripMenuItem
        '
        Me.編輯EToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.路徑指定DToolStripMenuItem})
        Me.編輯EToolStripMenuItem.Name = "編輯EToolStripMenuItem"
        Me.編輯EToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.編輯EToolStripMenuItem.Text = "設定(&S)"
        '
        '路徑指定DToolStripMenuItem
        '
        Me.路徑指定DToolStripMenuItem.Name = "路徑指定DToolStripMenuItem"
        Me.路徑指定DToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.路徑指定DToolStripMenuItem.Text = "路徑指定(&D)"
        '
        '說明HToolStripMenuItem
        '
        Me.說明HToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.關於這個程式AToolStripMenuItem})
        Me.說明HToolStripMenuItem.Name = "說明HToolStripMenuItem"
        Me.說明HToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.說明HToolStripMenuItem.Text = "說明(&H)"
        '
        '關於這個程式AToolStripMenuItem
        '
        Me.關於這個程式AToolStripMenuItem.Name = "關於這個程式AToolStripMenuItem"
        Me.關於這個程式AToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.關於這個程式AToolStripMenuItem.Text = "關於這個程式(&A)"
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.Filter = "MML程式碼檔案|*.MML|文字檔|*.TXT|所有檔案|*.*"
        '
        'SaveFileDialog
        '
        Me.SaveFileDialog.Filter = "MML程式碼檔案|*.MML|文字檔|*.TXT|所有檔案|*.*"
        '
        'outputGroupBox
        '
        Me.outputGroupBox.Controls.Add(Me.outputTextBox)
        Me.outputGroupBox.Location = New System.Drawing.Point(9, 434)
        Me.outputGroupBox.Margin = New System.Windows.Forms.Padding(2)
        Me.outputGroupBox.Name = "outputGroupBox"
        Me.outputGroupBox.Padding = New System.Windows.Forms.Padding(2)
        Me.outputGroupBox.Size = New System.Drawing.Size(694, 80)
        Me.outputGroupBox.TabIndex = 2
        Me.outputGroupBox.TabStop = False
        Me.outputGroupBox.Text = "輸出"
        '
        'outputTextBox
        '
        Me.outputTextBox.DetectUrls = False
        Me.outputTextBox.Location = New System.Drawing.Point(2, 17)
        Me.outputTextBox.Name = "outputTextBox"
        Me.outputTextBox.ReadOnly = True
        Me.outputTextBox.Size = New System.Drawing.Size(689, 58)
        Me.outputTextBox.TabIndex = 0
        Me.outputTextBox.Text = ""
        '
        'Timer
        '
        Me.Timer.Interval = 500
        '
        'mmlCodeTextBox
        '
        Me.mmlCodeTextBox.Font = New System.Drawing.Font("PMingLiU", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.mmlCodeTextBox.Location = New System.Drawing.Point(0, 27)
        Me.mmlCodeTextBox.Multiline = True
        Me.mmlCodeTextBox.Name = "mmlCodeTextBox"
        Me.mmlCodeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.mmlCodeTextBox.Size = New System.Drawing.Size(711, 402)
        Me.mmlCodeTextBox.TabIndex = 3
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 524)
        Me.Controls.Add(Me.mmlCodeTextBox)
        Me.Controls.Add(Me.outputGroupBox)
        Me.Controls.Add(Me.mainMenuStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PMD MML編譯公用程式"
        Me.mainMenuStrip.ResumeLayout(False)
        Me.mainMenuStrip.PerformLayout()
        Me.outputGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mainMenuStrip As MenuStrip
    Friend WithEvents 檔案FToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 編輯EToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 說明HToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 開新檔案NToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 開啟舊檔OToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 儲存檔案SToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 另存為ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents 結束XToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 路徑指定DToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 關於這個程式AToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFileDialog As SaveFileDialog
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents 編譯CToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 執行編譯RToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents outputGroupBox As GroupBox
    Friend WithEvents Timer As Timer
    Friend WithEvents outputTextBox As RichTextBox
    Friend WithEvents mmlCodeTextBox As TextBox
End Class
