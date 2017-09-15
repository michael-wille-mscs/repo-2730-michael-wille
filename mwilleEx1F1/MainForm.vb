'Programmer: Michael Wille
'Program Name: Cranston Berries Calculator
'Purpose: Calculate projected sales based on a percentage
'Date: 9/15/2017

'Options allow the programmer to see potential errors in his/her coding.
Option Strict On
Option Infer On
Option Explicit On


Public Class frmMain

    'Takes the amount of sales and multiplies by the expected increase in percent. Displays result.
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        lblStrawberries.Text = Format((1 + Val(txtProjectedIncrease.Text)) * Val(txtStrawberries.Text), "Currency")
        lblBlueberries.Text = Format((1 + Val(txtProjectedIncrease.Text)) * Val(txtBlueberries.Text), "currency")
        lblRaspberries.Text = Format((1 + Val(txtProjectedIncrease.Text)) * Val(txtRaspberries.Text), "currency")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clears all fields and puts focus on the first tab order object
        txtStrawberries.Text = String.Empty
        txtBlueberries.Text = String.Empty
        txtRaspberries.Text = String.Empty
        lblStrawberries.Text = String.Empty
        lblBlueberries.Text = String.Empty
        lblRaspberries.Text = String.Empty

        txtProjectedIncrease.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Closes the program
        Me.Close()
    End Sub
End Class
