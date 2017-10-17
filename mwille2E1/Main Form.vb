'Program: AndAlso, OrElse
'Purpose: Calculate using And, OrElse, =, <>
'Programmer: Michael Wille

Option Infer Off
Option Explicit On
Option Strict On

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtSavannahCC.Text = String.Empty
        txtOrderAmount.Text = String.Empty
        lblShippingCharge.Text = String.Empty
        txtID.Text = String.Empty
        txtSales.Text = String.Empty
        lblCommission.Text = String.Empty

        txtOrderAmount.Focus()
    End Sub

    Private Sub btnCalcAnd_Click(sender As Object, e As EventArgs) Handles btnCalcAnd.Click

        Const SHIPPINGCHARGE As Decimal = 9
        Const FREESHIPPING As Decimal = 0
        Dim ORDERAMOUNT As Decimal
        Dim strSAVANNAHCREDITCARD As String

        Decimal.TryParse(txtOrderAmount.Text, ORDERAMOUNT)

        strSAVANNAHCREDITCARD = txtSavannahCC.Text

        If ORDERAMOUNT >= 100 AndAlso strSAVANNAHCREDITCARD.ToUpper = "Y" Then
            lblShippingCharge.Text = FREESHIPPING.ToString("C2")
        Else
            lblShippingCharge.Text = SHIPPINGCHARGE.ToString("C2")


        End If

    End Sub

    Private Sub btnOr_Click(sender As Object, e As EventArgs) Handles btnOr.Click
        Const decSHIPPINGCHARGE As Decimal = 9
        Const decFREESHIPPING As Decimal = 0
        Dim decORDERAMOUNT As Decimal
        Dim strSAVANNAHCREDITCARD As String

        Decimal.TryParse(txtOrderAmount.Text, decORDERAMOUNT)

        strSAVANNAHCREDITCARD = txtSavannahCC.Text

        If decORDERAMOUNT < 100 OrElse strSAVANNAHCREDITCARD.ToUpper <> "Y" Then
            lblShippingCharge.Text = decSHIPPINGCHARGE.ToString("C2")
        Else
            lblShippingCharge.Text = decFREESHIPPING.ToString("C2")
        End If
    End Sub

    Private Sub ClearShippingLabel_TextChanged(sender As Object, e As EventArgs) Handles txtOrderAmount.TextChanged, txtSavannahCC.TextChanged
        lblShippingCharge.Text = String.Empty
    End Sub

    Private Sub btnCalcEquals_Click(sender As Object, e As EventArgs) Handles btnCalcEquals.Click
        'Const decMINIMUMSALES As Decimal = 25000
        Const decSALESIDCOMMISSION As Decimal = CDec(0.15)
        Const decALLOTHER As Decimal = CDec(0.12)
        Dim decSALES As Decimal
        Dim strID As String

        Decimal.TryParse(txtSales.Text, decSALES)

        strID = txtID.Text.ToUpper

        If (strID = ("A1") And decSALES >= 25000) OrElse (strID = ("B2") And decSALES >= 25000) OrElse (strID = ("C3") And decSALES >= 25000) Then
            lblCommission.Text = (decSALES * decSALESIDCOMMISSION).ToString("C2")
        Else
            lblCommission.Text = (decSALES * decALLOTHER).ToString("C2")
        End If

    End Sub

    Private Sub btnCalcNE_Click(sender As Object, e As EventArgs) Handles btnCalcNE.Click
        Const decSALESIDCOMMISSION As Decimal = CDec(0.15)
        Const decALLOTHER As Decimal = CDec(0.12)
        Dim decSALES As Decimal
        Dim strID As String

        Decimal.TryParse(txtSales.Text, decSALES)

        strID = txtID.Text.ToUpper

        If (strID <> ("A1") OrElse decSALES < 25000) AndAlso (strID <> ("B2") OrElse decSALES < 25000) AndAlso (strID <> ("C3") OrElse decSALES < 25000) Then
            lblCommission.Text = (decSALES * decALLOTHER).ToString("C2")
        Else
            lblCommission.Text = (decSALES * decSALESIDCOMMISSION).ToString("C2")
        End If

    End Sub

    Private Sub ClearCommissionLabel_TextChanged(sender As Object, e As EventArgs) Handles txtSales.TextChanged, txtID.TextChanged
        lblCommission.Text = String.Empty
    End Sub
End Class
