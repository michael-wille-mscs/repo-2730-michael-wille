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
        Me.txtMeasurement = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblresult = New System.Windows.Forms.Label()
        Me.radSubInchtoCent = New System.Windows.Forms.RadioButton()
        Me.radSubCenttoInch = New System.Windows.Forms.RadioButton()
        Me.radFunctionInchtoCent = New System.Windows.Forms.RadioButton()
        Me.radFunctionCenttoInch = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboNAME = New System.Windows.Forms.ComboBox()
        Me.lblWeightResult = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.radFunction = New System.Windows.Forms.RadioButton()
        Me.radSub = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEarthWeight = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtMeasurement
        '
        Me.txtMeasurement.Location = New System.Drawing.Point(0, 46)
        Me.txtMeasurement.Name = "txtMeasurement"
        Me.txtMeasurement.Size = New System.Drawing.Size(100, 25)
        Me.txtMeasurement.TabIndex = 0
        Me.txtMeasurement.Text = "10"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "&Measurement:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(0, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Result:"
        '
        'lblresult
        '
        Me.lblresult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblresult.Location = New System.Drawing.Point(0, 117)
        Me.lblresult.Name = "lblresult"
        Me.lblresult.Size = New System.Drawing.Size(123, 31)
        Me.lblresult.TabIndex = 3
        '
        'radSubInchtoCent
        '
        Me.radSubInchtoCent.AutoSize = True
        Me.radSubInchtoCent.Location = New System.Drawing.Point(175, 24)
        Me.radSubInchtoCent.Name = "radSubInchtoCent"
        Me.radSubInchtoCent.Size = New System.Drawing.Size(180, 21)
        Me.radSubInchtoCent.TabIndex = 4
        Me.radSubInchtoCent.TabStop = True
        Me.radSubInchtoCent.Text = "Sub: Inches to &Centimeters"
        Me.radSubInchtoCent.UseVisualStyleBackColor = True
        '
        'radSubCenttoInch
        '
        Me.radSubCenttoInch.AutoSize = True
        Me.radSubCenttoInch.Location = New System.Drawing.Point(175, 71)
        Me.radSubCenttoInch.Name = "radSubCenttoInch"
        Me.radSubCenttoInch.Size = New System.Drawing.Size(180, 21)
        Me.radSubCenttoInch.TabIndex = 5
        Me.radSubCenttoInch.TabStop = True
        Me.radSubCenttoInch.Text = "Sub: Centimeters to &Inches"
        Me.radSubCenttoInch.UseVisualStyleBackColor = True
        '
        'radFunctionInchtoCent
        '
        Me.radFunctionInchtoCent.AutoSize = True
        Me.radFunctionInchtoCent.Location = New System.Drawing.Point(175, 127)
        Me.radFunctionInchtoCent.Name = "radFunctionInchtoCent"
        Me.radFunctionInchtoCent.Size = New System.Drawing.Size(206, 21)
        Me.radFunctionInchtoCent.TabIndex = 6
        Me.radFunctionInchtoCent.TabStop = True
        Me.radFunctionInchtoCent.Text = "Function: Inches to &Centimeters"
        Me.radFunctionInchtoCent.UseVisualStyleBackColor = True
        '
        'radFunctionCenttoInch
        '
        Me.radFunctionCenttoInch.AutoSize = True
        Me.radFunctionCenttoInch.Location = New System.Drawing.Point(175, 188)
        Me.radFunctionCenttoInch.Name = "radFunctionCenttoInch"
        Me.radFunctionCenttoInch.Size = New System.Drawing.Size(206, 21)
        Me.radFunctionCenttoInch.TabIndex = 7
        Me.radFunctionCenttoInch.TabStop = True
        Me.radFunctionCenttoInch.Text = "Function: Centimeters to &Inches"
        Me.radFunctionCenttoInch.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(137, 207)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "&Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radFunctionCenttoInch)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblresult)
        Me.GroupBox1.Controls.Add(Me.radSubInchtoCent)
        Me.GroupBox1.Controls.Add(Me.radSubCenttoInch)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.radFunctionInchtoCent)
        Me.GroupBox1.Controls.Add(Me.txtMeasurement)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(399, 246)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "p418 #15-16 Measurement Converter"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboNAME)
        Me.GroupBox2.Controls.Add(Me.lblWeightResult)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.radFunction)
        Me.GroupBox2.Controls.Add(Me.radSub)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtEarthWeight)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 287)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(399, 236)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "p426-427 #4-6 Weight on different planets"
        '
        'cboNAME
        '
        Me.cboNAME.FormattingEnabled = True
        Me.cboNAME.Location = New System.Drawing.Point(118, 49)
        Me.cboNAME.Name = "cboNAME"
        Me.cboNAME.Size = New System.Drawing.Size(121, 25)
        Me.cboNAME.TabIndex = 14
        '
        'lblWeightResult
        '
        Me.lblWeightResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWeightResult.Location = New System.Drawing.Point(118, 102)
        Me.lblWeightResult.Name = "lblWeightResult"
        Me.lblWeightResult.Size = New System.Drawing.Size(121, 30)
        Me.lblWeightResult.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(134, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Weight On"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Earth Weight"
        '
        'radFunction
        '
        Me.radFunction.AutoSize = True
        Me.radFunction.Location = New System.Drawing.Point(259, 101)
        Me.radFunction.Name = "radFunction"
        Me.radFunction.Size = New System.Drawing.Size(74, 21)
        Me.radFunction.TabIndex = 10
        Me.radFunction.TabStop = True
        Me.radFunction.Text = "Function"
        Me.radFunction.UseVisualStyleBackColor = True
        '
        'radSub
        '
        Me.radSub.AutoSize = True
        Me.radSub.Location = New System.Drawing.Point(259, 63)
        Me.radSub.Name = "radSub"
        Me.radSub.Size = New System.Drawing.Size(48, 21)
        Me.radSub.TabIndex = 9
        Me.radSub.TabStop = True
        Me.radSub.Text = "Sub"
        Me.radSub.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(256, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Calculate Using:"
        '
        'txtEarthWeight
        '
        Me.txtEarthWeight.Location = New System.Drawing.Point(7, 49)
        Me.txtEarthWeight.Name = "txtEarthWeight"
        Me.txtEarthWeight.Size = New System.Drawing.Size(100, 25)
        Me.txtEarthWeight.TabIndex = 0
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 535)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMain"
        Me.Text = "mwille Ex3C1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtMeasurement As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblresult As Label
    Friend WithEvents radSubInchtoCent As RadioButton
    Friend WithEvents radSubCenttoInch As RadioButton
    Friend WithEvents radFunctionInchtoCent As RadioButton
    Friend WithEvents radFunctionCenttoInch As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblWeightResult As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents radFunction As RadioButton
    Friend WithEvents radSub As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents txtEarthWeight As TextBox
    Friend WithEvents cboNAME As ComboBox
End Class
