﻿
'Name:       Bakery Project
'Purpose:    Calculate the total number of items sold and total sales.
'Programmer: Michael Wille on 8/28/2017   

Option Strict On

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Prepare screen for the next sale
        txtDonuts.Text = String.Empty
        txtmuffins.Text = String.Empty
        lblTotalItems.Text = String.Empty
        lblTotalSales.Text = String.Empty
        'Send focus to donuts box
        txtDonuts.Focus()

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'Calculate number of items sold and total sales
        lblTotalItems.Text = Format(Val(txtDonuts.Text) + Val(txtmuffins.Text), "fixed")
        lblTotalSales.Text = Format(Val(lblTotalItems.Text) * 0.5, "currency")
        'lblTotalSales.Text = Format(Val(lblTotalSales.Text, "currency")
    End Sub
End Class
