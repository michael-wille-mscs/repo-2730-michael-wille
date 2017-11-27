'Multiplication Project
'Purpose Display a multiplication table that shows the multiplicand, multiplier, and product
'Programmer: Michael Wille on 11-25-2017

Option Strict On
Option Explicit On
Option Infer Off

Public Class frmMain
    Const dblTAXRATE As Double = 0.05
    Private Sub btnForNext_Click(sender As Object, e As EventArgs) Handles btnForNext.Click
        Dim intNUMBER, product As Integer
        lstMult.Items.Clear()
        lstMult.Items.Add("For loop:")
        Integer.TryParse(txtNumber.Text, intNUMBER)
        'For loop
        For intCOUNT As Integer = 1 To 9 Step 1

            product = intNUMBER * intCOUNT
            Dim strOUTPUT As String = "    " & intNUMBER.ToString() & " * " & intCOUNT.ToString & " = " & product.ToString
            'Add results to list box
            lstMult.Items.Add(strOUTPUT).ToString()
        Next intCOUNT

    End Sub

    Private Sub btnDoLoop_Click(sender As Object, e As EventArgs) Handles btnDoLoop.Click
        Dim intNUMBER, product As Integer
        Dim intCOUNT As Integer
        lstMult.Items.Clear()
        lstMult.Items.Add("Do loop:")
        Integer.TryParse(txtNumber.Text, intNUMBER)
        'Do loop

        Do
            intCOUNT += 1
            product = intNUMBER * intCOUNT
            Dim strOUTPUT As String = "    " & intNUMBER.ToString() & " * " & intCOUNT.ToString & " = " & product.ToString

            'Add results to list box
            lstMult.Items.Add(strOUTPUT)
        Loop Until intCOUNT = 9

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtNumber_Enter(sender As Object, e As EventArgs) Handles txtNumber.Enter
        txtNumber.SelectAll()
    End Sub

    Private Sub txtNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumber.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNumber_TextChanged(sender As Object, e As EventArgs) Handles txtNumber.TextChanged
        lstMult.Items.Clear()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load Listbox with test data:
        'repeat for each number 1 to 4
        'Add the number to the Listbox
        'next index

        Dim dblSELECTEDPRICE As Double

        For dblNUMBER As Double = 1 To 4 Step 1
            lstPrices.Items.Add(dblNUMBER).ToString()
        Next dblNUMBER

        'calculate pretaxe total:
        'declare for each index 0 to lstPrices.items.count
        'set Listbox SelectedIndex to index
        'set strSelectedItem and to the Listbox SelectItem
        'convert strSelectedPrice to Double and set dblSelectedPrice
        'add dblSelectedPrice to dblPretaxTotal
        'next index
        Dim dblPRETAXTOTAL As Double = 0
        Dim dblTAX As Double

        For intINDEX As Integer = 0 To lstPrices.Items.Count - 1

            lstPrices.SelectedIndex = intINDEX
            Dim strSELECTEDITEM As String = Convert.ToString(lstPrices.SelectedItem)
            Double.TryParse(strSELECTEDITEM, dblSELECTEDPRICE)
            dblPRETAXTOTAL = dblSELECTEDPRICE + dblPRETAXTOTAL

        Next intINDEX
        dblTAX = dblPRETAXTOTAL * dblTAXRATE
        lblPretaxTotal.Text = dblPRETAXTOTAL.ToString("N2")
        lblTax.Text = dblTAX.ToString("N2")
        lblTotal.Text = (dblPRETAXTOTAL + dblTAX).ToString("N2")
        lstPrices.SelectedIndex = -1

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim strPRICE As String
        Dim strPROMPT As String = "Enter a price." & " Valid prices: 1.00  to 9.99"
        Dim strTITLE As String = "Enter a Price:"
        Dim strTITLE2 As String = "Invalid Price"
        Dim dblPRICE As Double
        Dim dblSELECTEDPRICE As Double
        Dim dblPRETAXTOTAL As Double = 0
        Dim dblTAX As Double

        'get strPrice using Inputbox
        strPRICE = InputBox(strPROMPT, strTITLE, "0")
        'convert strPrice to double: dblPrice
        Double.TryParse(strPRICE, dblPRICE)
        'repeat as long as price is invalid: outside of range 1 to  9.99
        Do While dblPRICE < 1 Or dblPRICE > 9.99

            strPRICE = InputBox(strPROMPT, strTITLE2, "0")
            Double.TryParse(strPRICE, dblPRICE)

            'end repeat
        Loop

        'add dblPrice to ListBox
        lstPrices.Items.Add(dblPRICE).ToString()

        ''calculate and display totals

        For intINDEX As Integer = 0 To lstPrices.Items.Count - 1

            lstPrices.SelectedIndex = intINDEX
            Dim strSELECTEDITEM As String = Convert.ToString(lstPrices.SelectedItem)
            Double.TryParse(strSELECTEDITEM, dblSELECTEDPRICE)
            dblPRETAXTOTAL = dblSELECTEDPRICE + dblPRETAXTOTAL

        Next intINDEX
        dblTAX = dblPRETAXTOTAL * dblTAXRATE
        lblPretaxTotal.Text = dblPRETAXTOTAL.ToString("N2")
        lblTax.Text = dblTAX.ToString("N2")
        lblTotal.Text = (dblPRETAXTOTAL + dblTAX).ToString("N2")
        lstPrices.SelectedIndex = -1
    End Sub



    Private Sub lstPrices_KeyDown(sender As Object, e As KeyEventArgs) Handles lstPrices.KeyDown
        'if an item is selected and the user pressed 'Del' or 'Back'
        'Dim intSelectedIndex As Integer = lstPrices.Items.Count - 1
        'intSelectedIndex = lstPrices.Items.Count
        'lstPrices.Items.Remove(intSelectedIndex)
        'lstPrices.SelectedIndex = intINDEX2
        'lstPrices.SelectedIndex = intSelectedIndex

        'lstPrices.Items.Remove(intSelectedIndex)

        If e.KeyCode = Keys.Back or e.KeyCode = Keys.Delete Then
            'e.Handled = True
            lstPrices.Items.Remove(lstPrices.SelectedItem)
            'lstPrices.Items.RemoveAt(lstPrices.SelectedIndex)

            'remove the listbox item at the selected index
            'Dim strSELECTEDITEM As String = CType((lstPrices.SelectedItem), String)
            'lstPrices.SelectedItem.clear
            'lstPrices.SelectedItem.remove()
            'lstPrices.SelectedItems.Clear()
            'If e.KeyCode = Keys.Delete AndAlso lstPrices.SelectedItem <> Nothing Then
            'lstPrices.Items.RemoveAt(lstPrices.SelectedIndex)
            'calculate and display new totals

            Dim strPROMPT As String = "Enter a price." & " Valid prices: 1.00  to 9.99"
            Dim strTITLE As String = "Enter a Price:"
            Dim strTITLE2 As String = "Invalid Price"
            Dim dblSELECTEDPRICE As Double
            Dim dblPRETAXTOTAL As Double = 0
            Dim dblTAX As Double

            For intINDEX As Integer = 0 To lstPrices.Items.Count - 1

                    lstPrices.SelectedIndex = intINDEX
                    Dim strSELECTEDITEM As String = Convert.ToString(lstPrices.SelectedItem)
                    Double.TryParse(strSELECTEDITEM, dblSELECTEDPRICE)
                    dblPRETAXTOTAL = dblSELECTEDPRICE + dblPRETAXTOTAL

                Next intINDEX
                dblTAX = dblPRETAXTOTAL * dblTAXRATE
                lblPretaxTotal.Text = dblPRETAXTOTAL.ToString("N2")
                lblTax.Text = dblTAX.ToString("N2")
                lblTotal.Text = (dblPRETAXTOTAL + dblTAX).ToString("N2")
                lstPrices.SelectedIndex = -1
            End If

    End Sub
End Class
