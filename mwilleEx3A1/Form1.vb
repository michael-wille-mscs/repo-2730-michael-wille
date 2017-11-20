'Programmer: Michael Wille
'Purpose: Test different loop types
'Date Created: 11/16/2017

Option Strict On
Option Explicit On
Option Infer Off

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnPretestDoWhile_Click(sender As Object, e As EventArgs) Handles btnPretestDoWhile.Click
        lblEvenCountLoop.Text = "Pretest Do While" & ControlChars.NewLine
        Dim i As Integer = 2
        Do While i <= 20
            lblEvenCountLoop.Text = lblEvenCountLoop.Text & i.ToString & ControlChars.NewLine
            i += 2
        Loop
    End Sub

    Private Sub btnPretestDoUntil_Click(sender As Object, e As EventArgs) Handles btnPretestDoUntil.Click
        lblEvenCountLoop.Text = "Pretest Do Until" & ControlChars.NewLine
        Dim i As Integer = 2
        Do Until i > 20
            lblEvenCountLoop.Text = lblEvenCountLoop.Text & i.ToString & ControlChars.NewLine
            i += 2
        Loop
    End Sub

    Private Sub btnPosttestLoopWhile_Click(sender As Object, e As EventArgs) Handles btnPosttestLoopWhile.Click
        lblEvenCountLoop.Text = "Posttest Loop While" & ControlChars.NewLine
        Dim i As Integer = 2
        Do
            lblEvenCountLoop.Text = lblEvenCountLoop.Text & i.ToString & ControlChars.NewLine
            i += 2
        Loop While i <= 20
    End Sub

    Private Sub btnPosttestLoopUntil_Click(sender As Object, e As EventArgs) Handles btnPosttestLoopUntil.Click
        lblEvenCountLoop.Text = "Posttest Loop Until" & ControlChars.NewLine
        Dim i As Integer = 2
        Do
            lblEvenCountLoop.Text = lblEvenCountLoop.Text & i.ToString & ControlChars.NewLine
            i += 2
        Loop Until i > 20
    End Sub

    Private Sub btnPretestFor_Click(sender As Object, e As EventArgs) Handles btnPretestFor.Click
        lblEvenCountLoop.Text = "Pretest For" & ControlChars.NewLine

        For i As Integer = 2 To 20 Step 2
            lblEvenCountLoop.Text = lblEvenCountLoop.Text & i.ToString & ControlChars.NewLine
        Next i


    End Sub

    Private Sub btnSumDoWhile_Click(sender As Object, e As EventArgs) Handles btnSumDoWhile.Click
        txtAddition.Text = String.Empty
        lblCount.Text = String.Empty
        lblAverage.Text = String.Empty

        Const strPROMPT As String =
            "Enter a number. " & ControlChars.NewLine & "Click cancel or leave black to the end."
        Const strTITLE As String = "Number Entry"
        Dim strNUM As String
        Dim intNUM As Integer
        Dim intSUM As Integer
        Dim intCOUNT As Integer
        Dim dblAVG As Double

        strNUM = InputBox(strPROMPT, strTITLE, "0")
        'begin loop here: repeat as long as input is not empty
        Do While Int32.TryParse(strNUM, intNUM)


            txtAddition.Text = txtAddition.Text & intNUM.ToString & ControlChars.NewLine


            'update the counter and accumulator
            intCOUNT = intCOUNT + 1
            intSUM = intSUM + intNUM

            'Update Control Variable
            strNUM = InputBox(strPROMPT, strTITLE, "0")
            ' End Loop Here
        Loop

        lblCount.Text = intCOUNT.ToString

        'Check count for being greater than 0
        If intCOUNT > 0 Then
            dblAVG = intSUM / intCOUNT
            lblAverage.Text = dblAVG.ToString("N2")

        Else
            lblAverage.Text = "N/A"

        End If


    End Sub

    Private Sub btnSumLoopUntil_Click(sender As Object, e As EventArgs) Handles btnSumLoopUntil.Click
        txtAddition.Text = String.Empty
        lblCount.Text = String.Empty
        lblAverage.Text = String.Empty

        Const strPROMPT As String = "Enter a number. " & ControlChars.NewLine & "Click cancel or leave black to the end."
        Const strTITLE As String = "Number Entry"
        Dim strNUM As String
        Dim intNUM As Integer
        Dim intSUM As Integer
        Dim intCOUNT As Integer
        Dim dblAVG As Double

        strNUM = InputBox(strPROMPT, strTITLE, "0")
        'begin loop here: repeat as long as input is not empty
        Do
            Int32.TryParse(strNUM, intNUM)
            txtAddition.Text = txtAddition.Text & intNUM.ToString & ControlChars.NewLine


            'update the counter and accumulator
            intCOUNT = intCOUNT + 1
            intSUM = intSUM + intNUM

            'Update Control Variable
            strNUM = InputBox(strPROMPT, strTITLE, "0")
            ' End Loop Here
        Loop Until CInt(Int32.TryParse(strNUM, intNUM)) = 0

        lblCount.Text = intCOUNT.ToString

        'Check count for being greater than 0
        If intCOUNT > 0 Then
            dblAVG = intSUM / intCOUNT
            lblAverage.Text = dblAVG.ToString("N2")

        Else
            lblAverage.Text = "N/A"

        End If



    End Sub

    Private Sub btnSumForNext_Click(sender As Object, e As EventArgs) Handles btnSumForNext.Click
        txtAddition.Text = String.Empty
        lblCount.Text = String.Empty
        lblAverage.Text = String.Empty

        Const strPROMPT As String = "Enter the amount of numbers to be process. " & ControlChars.NewLine
        Const strPROMPT2 As String = "Enter Value"
        Const strTITLE As String = "Enter Number"
        Const strTITLE2 As String = "Enter Value"
        Dim strNUMBER As Integer
        Dim strNUM As String
        Dim intNUM As Integer
        Dim intSUM As Integer
        Dim intCOUNT As Integer
        Dim dblAVG As Double

        strNUM = InputBox(strPROMPT, strTITLE, "0")
        Int32.TryParse(strNUM, intNUM)
        'begin loop here: repeat as long as input is not empty
        For quantity As Integer = intNUM To 1 Step -1

            'step prompt 2 foward by one
            strNUMBER = CInt((" " & strNUMBER + 1).ToString)

            'Update Control Variable
            'If strPROMPT2 =
            strNUM = InputBox(strPROMPT2 & " " & "#" & strNUMBER, strTITLE2, "0") 'Then
            Int32.TryParse(strNUM, intNUM)
                txtAddition.Text = txtAddition.Text & intNUM.ToString & ControlChars.NewLine
            'End If
            'update the counter and accumulator
            intCOUNT = intCOUNT + 1
            intSUM = intSUM + intNUM


            ' End Loop Here
        Next quantity

        lblCount.Text = intCOUNT.ToString

        'Check count for being greater than 0
        If intCOUNT > 0 Then
            dblAVG = intSUM / intCOUNT
            lblAverage.Text = dblAVG.ToString("N2")

        Else
            lblAverage.Text = "N/A"

        End If


    End Sub

End Class
