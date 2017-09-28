'Programmer: Michael Wille
'Program Name: Cranston Berries Calculator
'Purpose: Calculate projected sales based on a percentage
'Date: 9/27/2017

'Options allow the programmer to see potential errors in his/her coding.
Option Strict On
Option Infer Off
Option Explicit On


Public Class frmMain

    'Takes the amount of sales and multiplies by the expected increase in percent. Displays result.
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decProjInc As Decimal
        Dim decStrawbCurrent As Decimal
        Dim decBlueBCurrent As Decimal
        Dim decRaspCurrent As Decimal
        Dim decStrawProj As Decimal
        Dim decBlueBProj As Decimal
        Dim decRaspProj As Decimal

        'convert current sales textbox entry into decimal variables
        Decimal.TryParse(txtStrawberries.Text, decStrawbCurrent)
        Decimal.TryParse(txtBlueberries.Text, decBlueBCurrent)
        Decimal.TryParse(txtRaspberries.Text, decRaspCurrent)

                'convert projected sales percentage increase into decimal variable
        Decimal.TryParse(txtProjectedIncrease.Text, decProjInc)

        'calculate projected sales for Strawberries, Blueberries and Raspberries
        decStrawProj = decStrawbCurrent * (1 + decProjInc)
        decBlueBProj = decBlueBCurrent * (1 + decProjInc)
        decRaspProj = decRaspCurrent * (1 + decProjInc)

        'Display projected sales for Strawberries, Blueberries and Raspberries
        lblStrawberries.Text = decStrawProj.ToString("C2")
        lblBlueberries.Text = decBlueBProj.ToString("C2")
        lblRaspberries.Text = decRaspProj.ToString("C2")

        'lblStrawberries.Text = Format((1 + Val(txtProjectedIncrease.Text)) * Val(txtStrawberries.Text), "currency")
        'lblBlueberries.Text = Format((1 + Val(txtProjectedIncrease.Text)) * Val(txtBlueberries.Text), "currency")
        'lblRaspberries.Text = Format((1 + Val(txtProjectedIncrease.Text)) * Val(txtRaspberries.Text), "currency")
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

    Private Sub btnRetirement_Click(sender As Object, e As EventArgs) Handles btnRetirement.Click
        Retirement_Form.Show()
    End Sub
End Class
