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
        Me.btnCalcAnd = New System.Windows.Forms.Button()
        Me.btnOr = New System.Windows.Forms.Button()
        Me.btnCalcEquals = New System.Windows.Forms.Button()
        Me.btnCalcNE = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblCommission = New System.Windows.Forms.Label()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.txtSales = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblShippingCharge = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtOrderAmount = New System.Windows.Forms.TextBox()
        Me.txtSavannahCC = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCalcAnd
        '
        Me.btnCalcAnd.Location = New System.Drawing.Point(367, 28)
        Me.btnCalcAnd.Name = "btnCalcAnd"
        Me.btnCalcAnd.Size = New System.Drawing.Size(132, 35)
        Me.btnCalcAnd.TabIndex = 3
        Me.btnCalcAnd.Text = "Calculate (And)"
        Me.btnCalcAnd.UseVisualStyleBackColor = True
        '
        'btnOr
        '
        Me.btnOr.Location = New System.Drawing.Point(365, 68)
        Me.btnOr.Name = "btnOr"
        Me.btnOr.Size = New System.Drawing.Size(132, 35)
        Me.btnOr.TabIndex = 4
        Me.btnOr.Text = "Calculate (Or)"
        Me.btnOr.UseVisualStyleBackColor = True
        '
        'btnCalcEquals
        '
        Me.btnCalcEquals.Location = New System.Drawing.Point(367, 27)
        Me.btnCalcEquals.Name = "btnCalcEquals"
        Me.btnCalcEquals.Size = New System.Drawing.Size(132, 35)
        Me.btnCalcEquals.TabIndex = 3
        Me.btnCalcEquals.Text = "Calculate (=)"
        Me.btnCalcEquals.UseVisualStyleBackColor = True
        '
        'btnCalcNE
        '
        Me.btnCalcNE.Location = New System.Drawing.Point(367, 68)
        Me.btnCalcNE.Name = "btnCalcNE"
        Me.btnCalcNE.Size = New System.Drawing.Size(132, 35)
        Me.btnCalcNE.TabIndex = 4
        Me.btnCalcNE.Text = "Calculation (<>)"
        Me.btnCalcNE.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(179, 317)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 35)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(274, 317)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 35)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblCommission)
        Me.GroupBox1.Controls.Add(Me.lbl5)
        Me.GroupBox1.Controls.Add(Me.txtSales)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.btnCalcEquals)
        Me.GroupBox1.Controls.Add(Me.btnCalcNE)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 178)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(505, 117)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "15% commision for sales > 25000 with codes A1, B2, C3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 21)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "ID:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(93, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 21)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Sales:"
        '
        'lblCommission
        '
        Me.lblCommission.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCommission.Location = New System.Drawing.Point(229, 74)
        Me.lblCommission.Name = "lblCommission"
        Me.lblCommission.Size = New System.Drawing.Size(130, 29)
        Me.lblCommission.TabIndex = 2
        Me.lblCommission.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl5
        '
        Me.lbl5.AutoSize = True
        Me.lbl5.Location = New System.Drawing.Point(225, 48)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(100, 21)
        Me.lbl5.TabIndex = 6
        Me.lbl5.Text = "Commission:"
        '
        'txtSales
        '
        Me.txtSales.Location = New System.Drawing.Point(91, 74)
        Me.txtSales.Name = "txtSales"
        Me.txtSales.Size = New System.Drawing.Size(130, 29)
        Me.txtSales.TabIndex = 1
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(6, 74)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(79, 29)
        Me.txtID.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.lblShippingCharge)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtOrderAmount)
        Me.GroupBox2.Controls.Add(Me.txtSavannahCC)
        Me.GroupBox2.Controls.Add(Me.btnOr)
        Me.GroupBox2.Controls.Add(Me.btnCalcAnd)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 22)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(505, 117)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Free shipping for orders over $100 with Savannah CC"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(139, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 21)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "CC:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 21)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Order amount:"
        '
        'lblShippingCharge
        '
        Me.lblShippingCharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblShippingCharge.Location = New System.Drawing.Point(229, 74)
        Me.lblShippingCharge.Name = "lblShippingCharge"
        Me.lblShippingCharge.Size = New System.Drawing.Size(130, 29)
        Me.lblShippingCharge.TabIndex = 2
        Me.lblShippingCharge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(225, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 21)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Shipping Charge:"
        '
        'txtOrderAmount
        '
        Me.txtOrderAmount.Location = New System.Drawing.Point(10, 74)
        Me.txtOrderAmount.Name = "txtOrderAmount"
        Me.txtOrderAmount.Size = New System.Drawing.Size(130, 29)
        Me.txtOrderAmount.TabIndex = 0
        '
        'txtSavannahCC
        '
        Me.txtSavannahCC.Location = New System.Drawing.Point(143, 74)
        Me.txtSavannahCC.Name = "txtSavannahCC"
        Me.txtSavannahCC.Size = New System.Drawing.Size(79, 29)
        Me.txtSavannahCC.TabIndex = 1
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(529, 371)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "mwille 2E1 AndAlso, OrElse"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCalcAnd As Button
    Friend WithEvents btnOr As Button
    Friend WithEvents btnCalcEquals As Button
    Friend WithEvents btnCalcNE As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblCommission As Label
    Friend WithEvents lbl5 As Label
    Friend WithEvents txtSales As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblShippingCharge As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtOrderAmount As TextBox
    Friend WithEvents txtSavannahCC As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
End Class
