<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSplash
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
        Me.components = New System.ComponentModel.Container()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picstorks = New System.Windows.Forms.PictureBox()
        Me.piciguanas = New System.Windows.Forms.PictureBox()
        Me.tmrExit = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picstorks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.piciguanas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(180, 70)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(107, 21)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Crighton Zoo"
        '
        'lblMsg
        '
        Me.lblMsg.AutoSize = True
        Me.lblMsg.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblMsg.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg.ForeColor = System.Drawing.Color.Red
        Me.lblMsg.Location = New System.Drawing.Point(180, 115)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(188, 21)
        Me.lblMsg.TabIndex = 1
        Me.lblMsg.Text = "Come visit our residents!"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(10, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(367, 282)
        Me.Label1.TabIndex = 2
        '
        'picstorks
        '
        Me.picstorks.Image = Global.mwille1b1.My.Resources.Resources.Storks
        Me.picstorks.Location = New System.Drawing.Point(207, 151)
        Me.picstorks.Name = "picstorks"
        Me.picstorks.Size = New System.Drawing.Size(161, 138)
        Me.picstorks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picstorks.TabIndex = 4
        Me.picstorks.TabStop = False
        '
        'piciguanas
        '
        Me.piciguanas.Image = Global.mwille1b1.My.Resources.Resources.Iguanas
        Me.piciguanas.Location = New System.Drawing.Point(12, 14)
        Me.piciguanas.Name = "piciguanas"
        Me.piciguanas.Size = New System.Drawing.Size(161, 138)
        Me.piciguanas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.piciguanas.TabIndex = 3
        Me.piciguanas.TabStop = False
        '
        'tmrExit
        '
        Me.tmrExit.Enabled = True
        Me.tmrExit.Interval = 4000
        '
        'frmSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(389, 301)
        Me.ControlBox = False
        Me.Controls.Add(Me.picstorks)
        Me.Controls.Add(Me.piciguanas)
        Me.Controls.Add(Me.lblMsg)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmSplash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.picstorks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.piciguanas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblMsg As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents piciguanas As PictureBox
    Friend WithEvents picstorks As PictureBox
    Friend WithEvents tmrExit As Timer
End Class
