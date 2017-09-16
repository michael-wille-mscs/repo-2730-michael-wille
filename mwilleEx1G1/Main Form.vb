'Programmer: Michael Wille
'Project Name: Average Test Score Calaculator
'Date: 9/15/2017

Option Strict On
Option Infer On
Option Explicit On



Public Class frmMain
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Calculate the average test score of 3 tests and display result
        'Dim a As Int32
        'Dim b As Int32
        'Dim c As Int32

        lblAverage.Text = Format(((Val(txtScore1.Text) + Val(txtScore2.Text) + Val(txtScore3.Text)) / 3), "fixed")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear all fields - Focus back to first tab object
        txtScore1.Text = String.Empty
        txtScore2.Text = String.Empty
        txtScore3.Text = String.Empty
        lblAverage.Text = String.Empty

        txtScore1.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Exit the program
        Me.Close()
    End Sub
End Class
