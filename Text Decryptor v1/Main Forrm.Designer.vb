<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDecryptedMessage = New System.Windows.Forms.TextBox()
        Me.btnExit2 = New System.Windows.Forms.Button()
        Me.btnClear2 = New System.Windows.Forms.Button()
        Me.btnDecrypt = New System.Windows.Forms.Button()
        Me.txtMessageToDecrypt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(496, 41)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 21)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "&Decrypted Message:"
        '
        'txtDecryptedMessage
        '
        Me.txtDecryptedMessage.Location = New System.Drawing.Point(500, 70)
        Me.txtDecryptedMessage.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.txtDecryptedMessage.Name = "txtDecryptedMessage"
        Me.txtDecryptedMessage.Size = New System.Drawing.Size(328, 29)
        Me.txtDecryptedMessage.TabIndex = 2
        '
        'btnExit2
        '
        Me.btnExit2.Location = New System.Drawing.Point(717, 126)
        Me.btnExit2.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.btnExit2.Name = "btnExit2"
        Me.btnExit2.Size = New System.Drawing.Size(112, 37)
        Me.btnExit2.TabIndex = 4
        Me.btnExit2.Text = "E&xit"
        Me.btnExit2.UseVisualStyleBackColor = True
        '
        'btnClear2
        '
        Me.btnClear2.Location = New System.Drawing.Point(593, 126)
        Me.btnClear2.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.btnClear2.Name = "btnClear2"
        Me.btnClear2.Size = New System.Drawing.Size(112, 37)
        Me.btnClear2.TabIndex = 3
        Me.btnClear2.Text = "C&lear"
        Me.btnClear2.UseVisualStyleBackColor = True
        '
        'btnDecrypt
        '
        Me.btnDecrypt.Location = New System.Drawing.Point(360, 65)
        Me.btnDecrypt.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.btnDecrypt.Name = "btnDecrypt"
        Me.btnDecrypt.Size = New System.Drawing.Size(128, 37)
        Me.btnDecrypt.TabIndex = 1
        Me.btnDecrypt.Text = "Decrypt"
        Me.btnDecrypt.UseVisualStyleBackColor = True
        '
        'txtMessageToDecrypt
        '
        Me.txtMessageToDecrypt.Location = New System.Drawing.Point(15, 70)
        Me.txtMessageToDecrypt.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.txtMessageToDecrypt.Name = "txtMessageToDecrypt"
        Me.txtMessageToDecrypt.Size = New System.Drawing.Size(328, 29)
        Me.txtMessageToDecrypt.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 41)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 21)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "&Message:"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 174)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDecryptedMessage)
        Me.Controls.Add(Me.btnExit2)
        Me.Controls.Add(Me.btnClear2)
        Me.Controls.Add(Me.btnDecrypt)
        Me.Controls.Add(Me.txtMessageToDecrypt)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximumSize = New System.Drawing.Size(860, 213)
        Me.MinimumSize = New System.Drawing.Size(860, 213)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Text Decryptor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents txtDecryptedMessage As TextBox
    Friend WithEvents btnExit2 As Button
    Friend WithEvents btnClear2 As Button
    Friend WithEvents btnDecrypt As Button
    Friend WithEvents txtMessageToDecrypt As TextBox
    Friend WithEvents Label1 As Label
End Class
