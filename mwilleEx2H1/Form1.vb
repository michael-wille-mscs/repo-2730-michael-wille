'Michael Wille
'If, Nested If, Elseif, Select Case
'Calculate Commission Amounts
'11/1/2017


Option Strict On
Option Explicit On
Option Infer Off



Public Class frmMain
    Private Sub txtSales_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSales.KeyPress
        'Text boxes only accept numbers or backspace
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            'cancel the entered key
            e.Handled = True
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


    Private Sub txtSales_click(sender As Object, e As EventArgs) Handles txtSales.Click
        txtSales.SelectAll()
    End Sub

    Private Sub btnIfThen_Click(sender As Object, e As EventArgs) Handles btnIfThen.Click
        lblCommissionOnly.Text = String.Empty
        lblAdditionalAmount.Text = String.Empty
        lblTotalCommission.Text = String.Empty

        Dim dblSales As Double = 0.0
        Dim dblCommissionOnly As Double = 0.0
        Dim dblAdditionalAmount As Double = 0.0
        Dim dblTotalCommission As Double = 0.0
        Dim boolSalesOK As Boolean = Double.TryParse(txtSales.Text, dblSales)

        If Not boolSalesOK Then
            MessageBox.Show("Invalid input", "Number Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If boolSalesOK AndAlso dblSales < 1.0 Then
            dblCommissionOnly = 0.0
        End If

        If boolSalesOK AndAlso dblSales >= 1.0 AndAlso dblSales < 6000.0 Then
            dblCommissionOnly = dblSales * 0.1
        End If

        If boolSalesOK AndAlso dblSales >= 6000.0 AndAlso dblSales < 30000.0 Then
            dblCommissionOnly = 120 + (dblSales - 6000) * 0.13
        End If

        If boolSalesOK AndAlso dblSales >= 30000 Then
            dblCommissionOnly = 3120 + (dblSales - 30000) * 0.14
        End If

        If chkGreaterThan10.Checked Then
            dblAdditionalAmount = dblAdditionalAmount + 500.0
        End If

        If chkTraveling.Checked Then
            dblAdditionalAmount = dblAdditionalAmount + 700.0
        End If

        dblTotalCommission = dblCommissionOnly + dblAdditionalAmount

        If boolSalesOK Then
            lblCommissionOnly.Text = dblCommissionOnly.ToString("c2")
            lblAdditionalAmount.Text = dblAdditionalAmount.ToString("c2")
            lblTotalCommission.Text = dblTotalCommission.ToString("c2")

        End If

        txtSales.Focus()
    End Sub

    Private Sub btnNestedIf_Click(sender As Object, e As EventArgs) Handles btnNestedIf.Click
        lblCommissionOnly.Text = String.Empty
        lblAdditionalAmount.Text = String.Empty
        lblTotalCommission.Text = String.Empty

        Dim dblSales As Double = 0.0
        Dim dblCommissionOnly As Double = 0.0
        Dim dblAdditionalAmount As Double = 0.0
        Dim dblTotalCommission As Double = 0.0
        Dim boolSalesOK As Boolean = Double.TryParse(txtSales.Text, dblSales)

        If Not boolSalesOK Then
            MessageBox.Show("Invalid input", "Number Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            If boolSalesOK AndAlso dblSales < 1.0 Then
                dblCommissionOnly = 0.0
            Else
                If dblSales < 6000.0 Then
                    dblCommissionOnly = dblSales * 0.1
                Else
                    If dblSales < 30000.0 Then
                        dblCommissionOnly = 120 + (dblSales - 6000) * 0.13
                    Else
                        'If dblSales >= 30000 Then
                        dblCommissionOnly = 3120 + (dblSales - 30000) * 0.14

                    End If
                End If
            End If
        End If


        If chkTraveling.Checked Then
            dblAdditionalAmount = dblAdditionalAmount + 700.0
        End If

        If chkGreaterThan10.Checked Then
            dblAdditionalAmount = dblAdditionalAmount + 500.0
        End If

        dblTotalCommission = dblCommissionOnly + dblAdditionalAmount

        If boolSalesOK Then
            lblCommissionOnly.Text = dblCommissionOnly.ToString("c2")
            lblAdditionalAmount.Text = dblAdditionalAmount.ToString("c2")
            lblTotalCommission.Text = dblTotalCommission.ToString("c2")
        End If
        txtSales.Focus()
    End Sub

    Private Sub btnIfElseIf_Click(sender As Object, e As EventArgs) Handles btnIfElseIf.Click
        lblCommissionOnly.Text = String.Empty
        lblAdditionalAmount.Text = String.Empty
        lblTotalCommission.Text = String.Empty

        Dim dblSales As Double = 0.0
        Dim dblCommissionOnly As Double = 0.0
        Dim dblAdditionalAmount As Double = 0.0
        Dim dblTotalCommission As Double = 0.0
        Dim boolSalesOK As Boolean = Double.TryParse(txtSales.Text, dblSales)

        If Not boolSalesOK Then
            MessageBox.Show("Invalid input", "Number Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf boolSalesOK AndAlso dblSales < 1.0 Then
            dblCommissionOnly = 0.0


        ElseIf dblSales < 6000.0 Then
            dblCommissionOnly = dblSales * 0.1


        ElseIf dblSales < 30000.0 Then
            dblCommissionOnly = 120 + (dblSales - 6000) * 0.13


        Else
            dblCommissionOnly = 3120 + (dblSales - 30000) * 0.14

        End If


        If chkGreaterThan10.Checked Then
            dblAdditionalAmount = dblAdditionalAmount + 500.0
        End If

        If chkTraveling.Checked Then
            dblAdditionalAmount = dblAdditionalAmount + 700.0
        End If

        txtSales.Focus()

        dblTotalCommission = dblCommissionOnly + dblAdditionalAmount

        If boolSalesOK Then
            lblCommissionOnly.Text = dblCommissionOnly.ToString("c2")
            lblAdditionalAmount.Text = dblAdditionalAmount.ToString("c2")
            lblTotalCommission.Text = dblTotalCommission.ToString("c2")
        End If

    End Sub

    Private Sub btnSelectCase_Click(sender As Object, e As EventArgs) Handles btnSelectCase.Click
        lblCommissionOnly.Text = String.Empty
        lblAdditionalAmount.Text = String.Empty
        lblTotalCommission.Text = String.Empty

        Dim dblSales As Double = 0.0
        Dim dblCommissionOnly As Double = 0.0
        Dim dblAdditionalAmount As Double = 0.0
        Dim dblTotalCommission As Double = 0.0
        Dim boolSalesOK As Boolean = Double.TryParse(txtSales.Text, dblSales)

        If Not boolSalesOK Then
            MessageBox.Show("Invalid input", "Number Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Select Case dblSales

            Case Is < 1.0
                dblCommissionOnly = 0.0

            Case Is < 6000.0
                dblCommissionOnly = dblSales * 0.1

            Case Is < 30000.0
                dblCommissionOnly = 120 + (dblSales - 6000) * 0.13

            Case Else
                dblCommissionOnly = 3120 + (dblSales - 30000) * 0.14

        End Select


        If chkGreaterThan10.Checked Then
            dblAdditionalAmount = dblAdditionalAmount + 500.0
        End If

        If chkTraveling.Checked Then
            dblAdditionalAmount = dblAdditionalAmount + 700.0
        End If

        dblTotalCommission = dblCommissionOnly + dblAdditionalAmount

        If boolSalesOK Then
            lblCommissionOnly.Text = dblCommissionOnly.ToString("c2")
            lblAdditionalAmount.Text = dblAdditionalAmount.ToString("c2")
            lblTotalCommission.Text = dblTotalCommission.ToString("c2")
        End If

        txtSales.Focus()
    End Sub

    Private Sub ClearLabels(sender As Object, e As EventArgs) Handles txtSales.TextChanged, chkGreaterThan10.CheckedChanged, chkTraveling.CheckedChanged
        lblCommissionOnly.Text = String.Empty
        lblAdditionalAmount.Text = String.Empty
        lblTotalCommission.Text = String.Empty
    End Sub
End Class
