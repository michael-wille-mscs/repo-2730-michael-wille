'Programmer: Michael Wille
'Photo Workshop Payroll Calculator
'Date Created: 9/20/2017

Option Strict On
Option Infer On
Option Explicit On



Public Class frmMain
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear all fields and focus to start of tab order
        txtName.Text = String.Empty
        txtHours.Text = String.Empty
        txtPay.Text = String.Empty
        lblGross.Text = String.Empty
        lblFWT.Text = String.Empty
        lblFICA.Text = String.Empty
        lblState.Text = String.Empty
        lblNet.Text = String.Empty

        'Keep format displayed in text boxes
        txtHours.Text = "0.00"
        txtPay.Text = "0.00"

        txtName.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the Program
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'Calculate and display results
        lblGross.Text = Format(Val(txtHours.Text) * Val(txtPay.Text), "fixed")
        lblFWT.Text = Format((Val(lblGross.Text) * 0.2), "fixed")
        lblFICA.Text = Format((Val(lblGross.Text) * 0.08), "fixed")
        lblState.Text = Format((Val(lblGross.Text) * 0.03), "fixed")
        lblNet.Text = Format((Val(lblGross.Text) - Val(lblFWT.Text) - Val(lblFICA.Text) - Val(lblState.Text)), "fixed")
    End Sub
End Class
