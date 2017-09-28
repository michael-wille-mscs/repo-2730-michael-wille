<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Retirement_Form
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtGrossWeeklyPay = New System.Windows.Forms.TextBox()
        Me.txtEmployeeRate = New System.Windows.Forms.TextBox()
        Me.txtEmployerRate = New System.Windows.Forms.TextBox()
        Me.lblEmployeeAnnualCont = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblEmployerAnnualCont = New System.Windows.Forms.Label()
        Me.lblTotalAnnualCont = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 21)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Gross weekly pay:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(309, 21)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Employee contribution rate (Decimal form):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(307, 21)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Employer contribution rate (Decimal form):"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(221, 21)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Employee annual contribution:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(219, 21)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Employer annual contribution:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 213)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(187, 21)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Total annual contribution:"
        '
        'txtGrossWeeklyPay
        '
        Me.txtGrossWeeklyPay.Location = New System.Drawing.Point(216, 13)
        Me.txtGrossWeeklyPay.Name = "txtGrossWeeklyPay"
        Me.txtGrossWeeklyPay.Size = New System.Drawing.Size(213, 29)
        Me.txtGrossWeeklyPay.TabIndex = 0
        '
        'txtEmployeeRate
        '
        Me.txtEmployeeRate.Location = New System.Drawing.Point(329, 53)
        Me.txtEmployeeRate.Name = "txtEmployeeRate"
        Me.txtEmployeeRate.Size = New System.Drawing.Size(100, 29)
        Me.txtEmployeeRate.TabIndex = 1
        '
        'txtEmployerRate
        '
        Me.txtEmployerRate.Location = New System.Drawing.Point(329, 93)
        Me.txtEmployerRate.Name = "txtEmployerRate"
        Me.txtEmployerRate.Size = New System.Drawing.Size(100, 29)
        Me.txtEmployerRate.TabIndex = 2
        '
        'lblEmployeeAnnualCont
        '
        Me.lblEmployeeAnnualCont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmployeeAnnualCont.Location = New System.Drawing.Point(240, 133)
        Me.lblEmployeeAnnualCont.Name = "lblEmployeeAnnualCont"
        Me.lblEmployeeAnnualCont.Size = New System.Drawing.Size(189, 29)
        Me.lblEmployeeAnnualCont.TabIndex = 12
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(17, 272)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(110, 34)
        Me.btnCalc.TabIndex = 3
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(151, 272)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(110, 34)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(292, 272)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(110, 34)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblEmployerAnnualCont
        '
        Me.lblEmployerAnnualCont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmployerAnnualCont.Location = New System.Drawing.Point(240, 173)
        Me.lblEmployerAnnualCont.Name = "lblEmployerAnnualCont"
        Me.lblEmployerAnnualCont.Size = New System.Drawing.Size(189, 29)
        Me.lblEmployerAnnualCont.TabIndex = 13
        '
        'lblTotalAnnualCont
        '
        Me.lblTotalAnnualCont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalAnnualCont.Location = New System.Drawing.Point(240, 213)
        Me.lblTotalAnnualCont.Name = "lblTotalAnnualCont"
        Me.lblTotalAnnualCont.Size = New System.Drawing.Size(189, 29)
        Me.lblTotalAnnualCont.TabIndex = 14
        '
        'Retirement_Form
        '
        Me.AcceptButton = Me.btnCalc
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 316)
        Me.Controls.Add(Me.lblTotalAnnualCont)
        Me.Controls.Add(Me.lblEmployerAnnualCont)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblEmployeeAnnualCont)
        Me.Controls.Add(Me.txtEmployerRate)
        Me.Controls.Add(Me.txtEmployeeRate)
        Me.Controls.Add(Me.txtGrossWeeklyPay)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Retirement_Form"
        Me.Text = "Retirement_Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtGrossWeeklyPay As TextBox
    Friend WithEvents txtEmployeeRate As TextBox
    Friend WithEvents txtEmployerRate As TextBox
    Friend WithEvents lblEmployeeAnnualCont As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblEmployerAnnualCont As Label
    Friend WithEvents lblTotalAnnualCont As Label
End Class
