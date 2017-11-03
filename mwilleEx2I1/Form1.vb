'Michael Wille
'String Manipulation
'11/3/2017


Option Strict On
Option Explicit On
Option Infer Off



Public Class frmMain
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        '#03: Remove/Insert 1
        Dim strWord As String = txt03RemoveInsert1.Text
        strWord = strWord.Remove(0, 1)
        strWord = strWord.Insert(0, "cr")
        lbl03RemoveInsert1.Text = strWord

        '#04: Substring
        Dim strItem As String = txt04Substring.Text
        Dim strColor As String = strItem.Substring(2, 4)
        lbl04Substring.Text = strColor

        '#05a: Length
        Dim strlength As String = txt05aLength.Text
        Dim intNumberChars As Integer = strlength.Length
        lbl05aLength.Text = CType(intNumberChars, String)

        '#05b: Trim
        Dim strCity As String = txt05bTrim.Text.Trim
        lbl05bTrim.Text = strCity

        '#05c: Remove/Insert 2
        Dim strWord2 As String = txt05cRemoveInsert2.Text
        strWord2 = strWord2.Remove(1, 1)
        strWord2 = strWord2.Insert(1, "rit")
        lbl05cRemoveInsert2.Text = strWord2

        '#05d: Insert
        Dim strMSG As String = txt05dInsert.Text
        lbl05dinsert.Text = strMSG.Insert(0, "Mon")

        '#05e: Pad
        Dim strPay As String = txt05ePad.Text
        lbl05ePad.Text = strPay.PadLeft(10, CChar("*"))

        '#06: Remove/Replace
        Dim strAmount As String = txt06Remove.Text
        lbl06Remove.Text = strAmount.Replace(",", String.Empty)

        'Dim Result As String = txt06Remove.Text

        'Do
        '    Result = Replace(Result, ",")
        'Loop Until InStr(Result, ",") = 0

        '#07: Contains
        Dim strAddress As String = txt07Contains.Text
        Dim blnIsContained As Boolean = strAddress.ToLower.Contains("jefferson st")
        If blnIsContained = True Then
            lbl07Contains.Text = "Jeff St. Found"
        Else
            lbl07Contains.Text = "Street Not Found"
        End If

        '#12: Len/Remove/Replace
        Dim dblSales As Double = 1000
        Dim strTax As String = txt12LenRemove.Text
        Dim dblTax As Double = CDec(strTax.Replace(" ", String.Empty).Replace("%", String.Empty))
        Dim dblTotalSalesTax As Double = (0.01) * Convert.ToDouble(dblTax * dblSales)
        lbl12LenRemove.Text = CType(dblTotalSalesTax, String)

        '#13: Like
        Dim strZip As String = txt13Like.Text
        If strZip Like "605??" Then
            lbl13Like.Text = "Shipping: $25"
        ElseIf strZip Like "606??" Then
            lbl13Like.Text = "Shipping $30"
        Else
            lbl13Like.Text = "Invalid Zip"

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
