'Name               Richardson County Property Tax Project
'Purpose:           Calculate sales tax
'Programmer:        Michael Wille
'Date Created:      8/28/2017

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the form
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear Text box and Label
        txtAssessed.Text = String.Empty
        lblTax.Text = String.Empty
        'Focus back to text box
        txtAssessed.Focus()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'Calculate and display the dollar amount of the property tax in the label field
        lblTax.Text = Val(txtAssessed.Text) * 0.015
        'Convert tax amount to currency value
        lblTax.Text = Format(lblTax.Text, "Currency")
    End Sub
End Class
