Public Class Retirement_Form
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtGrossWeeklyPay.Text = String.Empty
        txtEmployeeRate.Text = String.Empty
        txtEmployerRate.Text = String.Empty
        lblEmployeeAnnualCont.Text = String.Empty
        lblEmployerAnnualCont.Text = String.Empty
        lblTotalAnnualCont.Text = String.Empty

        'Set focus to first tab item
        txtGrossWeeklyPay.Focus()

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'declare variables
        Dim decGross As Decimal
        Dim decEmployeeRate As Decimal
        Dim decEmployerRate As Decimal
        Dim decEmployeeAnnualRate As Decimal
        Dim decEmployerAnnualRate As Decimal
        Dim decTotalAnnualContRate As Decimal

        'convert textbox values into variables
        Decimal.TryParse(txtGrossWeeklyPay.Text, decGross)
        Decimal.TryParse(txtEmployeeRate.Text, decEmployeeRate)
        Decimal.TryParse(txtEmployerRate.Text, decEmployerRate)

        'calculate employee contribution rate
        decEmployeeAnnualRate = decEmployeeRate * (52 * decGross)
        decEmployerAnnualRate = decEmployerRate * (52 * decGross)
        decTotalAnnualContRate = decEmployeeAnnualRate + decEmployerAnnualRate

        'display annual contributions toward retirement account
        lblEmployeeAnnualCont.Text = decEmployeeAnnualRate.ToString("C2")
        lblEmployerAnnualCont.Text = decEmployerAnnualRate.ToString("C2")
        lblTotalAnnualCont.Text = decTotalAnnualContRate.ToString("C2")

    End Sub

    'clears label values when new user texbox data is entered
    Private Sub ClearLabels(sender As Object, e As EventArgs) _
        Handles txtGrossWeeklyPay.TextChanged, txtEmployeeRate.TextChanged, txtEmployerRate.TextChanged
        lblEmployeeAnnualCont.Text = String.Empty
        lblEmployerAnnualCont.Text = String.Empty
        lblTotalAnnualCont.Text = String.Empty
    End Sub
End Class