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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnIfThen = New System.Windows.Forms.Button()
        Me.btnNestedIf = New System.Windows.Forms.Button()
        Me.btnIfElseIf = New System.Windows.Forms.Button()
        Me.btnSelectCase = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblTotalCommission = New System.Windows.Forms.Label()
        Me.lblAdditionalAmount = New System.Windows.Forms.Label()
        Me.lblCommissionOnly = New System.Windows.Forms.Label()
        Me.txtSales = New System.Windows.Forms.TextBox()
        Me.chkGreaterThan10 = New System.Windows.Forms.CheckBox()
        Me.chkTraveling = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Sales:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(363, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(429, 398)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Commission Calculations"
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(119, 318)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(146, 33)
        Me.Label19.TabIndex = 12
        Me.Label19.Text = "$700"
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(119, 266)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(146, 33)
        Me.Label18.TabIndex = 11
        Me.Label18.Text = "$500"
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(207, 177)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(229, 33)
        Me.Label17.TabIndex = 10
        Me.Label17.Text = "$3,120 + 14% of sales > 30,000"
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(207, 134)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(208, 33)
        Me.Label16.TabIndex = 9
        Me.Label16.Text = "$120 + 13% of sales > 6,000"
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(207, 86)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(146, 33)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "10% of sales"
        '
        'Label14
        '
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label14.Location = New System.Drawing.Point(207, 46)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(146, 33)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "Commission"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(7, 318)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(146, 33)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Traveling"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(6, 266)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(146, 33)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "> 10 years"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(7, 219)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(146, 33)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Additional amounts:"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(7, 177)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(146, 33)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "> 30,000"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(6, 134)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(146, 33)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "6,000 - 29,999.99"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(7, 86)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(146, 33)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "1 - 5,999.99"
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Location = New System.Drawing.Point(7, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(146, 33)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Sales ($)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Commission only:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 269)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Additional amount:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 368)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Total commission:"
        '
        'btnIfThen
        '
        Me.btnIfThen.Location = New System.Drawing.Point(196, 50)
        Me.btnIfThen.Name = "btnIfThen"
        Me.btnIfThen.Size = New System.Drawing.Size(149, 30)
        Me.btnIfThen.TabIndex = 1
        Me.btnIfThen.Text = "If Then"
        Me.btnIfThen.UseVisualStyleBackColor = True
        '
        'btnNestedIf
        '
        Me.btnNestedIf.Location = New System.Drawing.Point(196, 136)
        Me.btnNestedIf.Name = "btnNestedIf"
        Me.btnNestedIf.Size = New System.Drawing.Size(149, 30)
        Me.btnNestedIf.TabIndex = 2
        Me.btnNestedIf.Text = "Nested If"
        Me.btnNestedIf.UseVisualStyleBackColor = True
        '
        'btnIfElseIf
        '
        Me.btnIfElseIf.Location = New System.Drawing.Point(196, 222)
        Me.btnIfElseIf.Name = "btnIfElseIf"
        Me.btnIfElseIf.Size = New System.Drawing.Size(149, 30)
        Me.btnIfElseIf.TabIndex = 3
        Me.btnIfElseIf.Text = "If Else If"
        Me.btnIfElseIf.UseVisualStyleBackColor = True
        '
        'btnSelectCase
        '
        Me.btnSelectCase.Location = New System.Drawing.Point(196, 308)
        Me.btnSelectCase.Name = "btnSelectCase"
        Me.btnSelectCase.Size = New System.Drawing.Size(149, 30)
        Me.btnSelectCase.TabIndex = 4
        Me.btnSelectCase.Text = "Select Case"
        Me.btnSelectCase.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(196, 418)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(149, 30)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblTotalCommission
        '
        Me.lblTotalCommission.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalCommission.Location = New System.Drawing.Point(16, 407)
        Me.lblTotalCommission.Name = "lblTotalCommission"
        Me.lblTotalCommission.Size = New System.Drawing.Size(158, 41)
        Me.lblTotalCommission.TabIndex = 10
        Me.lblTotalCommission.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAdditionalAmount
        '
        Me.lblAdditionalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAdditionalAmount.Location = New System.Drawing.Point(16, 308)
        Me.lblAdditionalAmount.Name = "lblAdditionalAmount"
        Me.lblAdditionalAmount.Size = New System.Drawing.Size(158, 41)
        Me.lblAdditionalAmount.TabIndex = 11
        Me.lblAdditionalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCommissionOnly
        '
        Me.lblCommissionOnly.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCommissionOnly.Location = New System.Drawing.Point(16, 209)
        Me.lblCommissionOnly.Name = "lblCommissionOnly"
        Me.lblCommissionOnly.Size = New System.Drawing.Size(158, 41)
        Me.lblCommissionOnly.TabIndex = 12
        Me.lblCommissionOnly.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSales
        '
        Me.txtSales.Location = New System.Drawing.Point(16, 50)
        Me.txtSales.Name = "txtSales"
        Me.txtSales.Size = New System.Drawing.Size(158, 27)
        Me.txtSales.TabIndex = 0
        Me.txtSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chkGreaterThan10
        '
        Me.chkGreaterThan10.Location = New System.Drawing.Point(16, 93)
        Me.chkGreaterThan10.Name = "chkGreaterThan10"
        Me.chkGreaterThan10.Size = New System.Drawing.Size(109, 23)
        Me.chkGreaterThan10.TabIndex = 14
        Me.chkGreaterThan10.Text = "> 10 Years"
        Me.chkGreaterThan10.UseVisualStyleBackColor = True
        '
        'chkTraveling
        '
        Me.chkTraveling.AutoSize = True
        Me.chkTraveling.Location = New System.Drawing.Point(16, 122)
        Me.chkTraveling.Name = "chkTraveling"
        Me.chkTraveling.Size = New System.Drawing.Size(89, 24)
        Me.chkTraveling.TabIndex = 15
        Me.chkTraveling.Text = "Traveling"
        Me.chkTraveling.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(807, 473)
        Me.Controls.Add(Me.chkTraveling)
        Me.Controls.Add(Me.chkGreaterThan10)
        Me.Controls.Add(Me.txtSales)
        Me.Controls.Add(Me.lblCommissionOnly)
        Me.Controls.Add(Me.lblAdditionalAmount)
        Me.Controls.Add(Me.lblTotalCommission)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSelectCase)
        Me.Controls.Add(Me.btnIfElseIf)
        Me.Controls.Add(Me.btnNestedIf)
        Me.Controls.Add(Me.btnIfThen)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMain"
        Me.Text = "mwille Ex2H1 Marshall"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnIfThen As Button
    Friend WithEvents btnNestedIf As Button
    Friend WithEvents btnIfElseIf As Button
    Friend WithEvents btnSelectCase As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblTotalCommission As Label
    Friend WithEvents lblAdditionalAmount As Label
    Friend WithEvents lblCommissionOnly As Label
    Friend WithEvents txtSales As TextBox
    Friend WithEvents chkGreaterThan10 As CheckBox
    Friend WithEvents chkTraveling As CheckBox
End Class
