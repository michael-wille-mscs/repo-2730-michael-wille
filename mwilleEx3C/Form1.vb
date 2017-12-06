'Programmer - Michael Wille
'Sub Procedures and Functions
'12/3/2017

Option Strict On
Option Explicit On
Option Infer On


Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cboNAME.Items.Add("Mercury")
        cboNAME.Items.Add("Venus")
        cboNAME.Items.Add("Earth")
        cboNAME.Items.Add("Mars")
        cboNAME.Items.Add("Jupiter")
        cboNAME.Items.Add("Saturn")
        cboNAME.Items.Add("Uranus")
        cboNAME.Items.Add("Neptune")
        'Totally Still a Planet!
        cboNAME.Items.Add("Pluto")
        cboNAME.SelectedIndex = 2
    End Sub

    Private Sub lblEarthWeight_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEarthWeight.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub lblEarthWeight_Enter(sender As Object, e As EventArgs) Handles txtEarthWeight.Enter
        txtEarthWeight.SelectAll()
    End Sub

    Private Function Calcweightfunc(ByVal intweight As Integer) As Double
        Dim dblGRAVITY As Double

        Select Case cboNAME.Text
            Case "Mercury", "Mars"
                dblGRAVITY = CInt(0.38)
            Case "Mercury", "Mars"
                dblGRAVITY = CInt(0.91)
            Case "Mercury", "Mars"
                dblGRAVITY = CInt(1.0)
            Case "Mercury", "Mars"
                dblGRAVITY = CInt(2.34)
            Case "Mercury", "Mars"
                dblGRAVITY = CInt(1.06)
            Case "Mercury", "Mars"
                dblGRAVITY = CInt(0.92)
            Case "Mercury", "Mars"
                dblGRAVITY = CInt(1.14)
            Case "Mercury", "Mars"
                dblGRAVITY = CInt(0.06)
        End Select
        Dim dblnewweight As Integer
        Return intweight * dblGRAVITY
        'lblWeightResult.Text = dblnewweight.ToString("n2")

    End Function

    Private Sub CalcWeightSub(ByVal dblweight As Double, ByRef dblWeightonPlanet As Double)

        dblWeightonPlanet = dblweight * 1

    End Sub

    Private Sub I2Changed(sender As Object, e As EventArgs) Handles _
        txtEarthWeight.TextChanged, radSub.CheckedChanged, radFunction.CheckedChanged
        Dim dblWeightonPlanet As Double = 0.0
        Dim dblweight As Double = 0.0

        Double.TryParse(txtEarthWeight.Text, dblWeightonPlanet)

        If radSub.Checked Then
            CalcWeightSub(dblweight, dblWeightonPlanet)
        ElseIf radfunction.Checked Then
            Calcweightfunc(CInt(dblweight))
        End If

        lblWeightResult.Text = dblWeightonPlanet.ToString("n2")
    End Sub







    Private Sub txtMeasurement_Enter(sender As Object, e As EventArgs) Handles txtMeasurement.Enter
        txtMeasurement.SelectAll()
    End Sub

    Private Sub txtMeasurement_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMeasurement.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub CalcCentimetersSub(ByVal dblMeasurement As Double, ByRef dblRESULT As Double)
        dblRESULT = dblMeasurement * 2.54
    End Sub

    Private Sub CalcInchesSub(ByVal dblMeasurement As Double, ByRef dblRESULT As Double)
        dblRESULT = dblMeasurement / 2.54
    End Sub

    Private Function CalcCentimetersfunc(ByVal dblMeasurement As Double) As Double
        'Dim dblRESULT As Double
        'dblRESULT = dblMeasurement * 2.54
        Return dblMeasurement * 2.54
    End Function

    Private Function CalcInchesfunc(ByVal dblMeasurement As Double) As Double
        'Dim dblRESULT As Double
        'dblRESULT = dblMeasurement / 2.54
        Return dblMeasurement / 2.54
    End Function

    Private Sub IChanged(sender As Object, e As EventArgs) _
        Handles txtMeasurement.TextChanged, radSubInchtoCent.CheckedChanged, radSubCenttoInch.CheckedChanged, radFunctionInchtoCent.CheckedChanged, radFunctionCenttoInch.CheckedChanged
        Dim dblMEASUREMENT As Double
        Dim dblRESULT As Double

        Double.TryParse(txtMeasurement.Text, dblMEASUREMENT)

        If radSubInchtoCent.Checked Then
            CalcCentimetersSub(dblMEASUREMENT, dblRESULT)
        ElseIf radSubCenttoInch.Checked Then
            CalcInchesSub(dblMEASUREMENT, dblRESULT)


        ElseIf radFunctionCenttoInch.Checked Then
            Call CalcInchesfunc(dblRESULT)
        End If

        lblresult.Text = dblRESULT.ToString("n2")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
