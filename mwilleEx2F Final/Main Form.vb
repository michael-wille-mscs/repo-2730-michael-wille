' Name:         Treeline Project
' Purpose:      Display the total room charge, tax, 
'               total resort fee, and total due
' Programmer:   Michael Wille, 10/17/2017

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub ClearLabels(sender As Object, e As EventArgs) _
        Handles txtRooms.TextChanged, txtNights.TextChanged,
        txtAdults.TextChanged, txtChildren.TextChanged, radQueen.CheckedChanged, radKing.CheckedChanged, radStandard.CheckedChanged, radAtrium.CheckedChanged, chkParkingFee.CheckedChanged
        ' clear calculated amounts

        lblRoomChg.Text = String.Empty
        lblTax.Text = String.Empty
        lblResortFee.Text = String.Empty
        lblTotalDue.Text = String.Empty
        lblParkingfee.Text = String.Empty

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'calculate totals
        Const intMAX_PER_ROOM As Integer = 6
        Const dblDAILY_ROOM_CHG_QUEEN_STAND As Double = 225.5
        Const dblDAILY_ROOM_CHG_QUEEN_ATRIUM As Double = 275
        Const dblDAILY_ROOM_CHG_KING_STAND As Double = 245.5
        Const dblDAILY_ROOM_CHG_KING_ATRIUM As Double = 325
        Const dblDAILY_PARKING_FEE As Double = 8.5
        Const dblTAX_RATE As Double = 0.1625
        Const dblDAILY_RESORT_FEE As Double = 12.5
        Const strMSG As String = "You have exceeded the maximum guests per room."
        Dim intRoomsReserved As Integer
        Dim intNights As Integer
        Dim intAdults As Integer
        Dim intChildren As Integer
        Dim intNumGuests As Integer
        Dim dblRoomsRequired As Double
        Dim dblParkingFee As Double
        Dim dblDailyRoomCharge As Double
        Dim dblTotalRoomChg As Double
        Dim dblTax As Double
        Dim dblTotalResortFee As Double
        Dim dblTotalDue As Double
        Dim blnIsRoomReservedOK As Boolean
        Dim blnIsNightsOK As Boolean
        Dim blnIsAdultsOK As Boolean
        'Dim blnIsChildrenOK As Boolean

        blnIsRoomReservedOK = Integer.TryParse(txtRooms.Text, intRoomsReserved)
        blnIsNightsOK = Integer.TryParse(txtNights.Text, intNights)
        blnIsAdultsOK = Integer.TryParse(txtAdults.Text, intAdults)
        Integer.TryParse(txtChildren.Text, intChildren)

        If blnIsRoomReservedOK AndAlso blnIsNightsOK AndAlso blnIsAdultsOK Then


            'number of guests
            intNumGuests = intAdults + intChildren
            'rooms needed for guests
            dblRoomsRequired = intNumGuests / intMAX_PER_ROOM

            If intRoomsReserved < dblRoomsRequired Then
                MessageBox.Show(strMSG, "Treeline Resort", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If radQueen.Checked Then
                    If radStandard.Checked Then
                        dblDailyRoomCharge = dblDAILY_ROOM_CHG_QUEEN_STAND
                    Else
                        dblDailyRoomCharge = dblDAILY_ROOM_CHG_QUEEN_ATRIUM
                    End If
                Else
                    If radStandard.Checked Then
                        dblDailyRoomCharge = dblDAILY_ROOM_CHG_KING_STAND
                    Else
                        dblDailyRoomCharge = dblDAILY_ROOM_CHG_KING_ATRIUM
                    End If
                End If
                dblTotalRoomChg = intRoomsReserved * intNights * dblDailyRoomCharge
                dblTax = dblTotalRoomChg * dblTAX_RATE
                dblTotalResortFee = intRoomsReserved * intNights * dblDAILY_RESORT_FEE
                If chkParkingFee.Checked Then
                    dblParkingFee = intNights * dblDAILY_PARKING_FEE
                End If
                dblTotalDue = dblTotalRoomChg + dblTax + dblTotalResortFee + dblParkingFee

                lblRoomChg.Text = dblTotalRoomChg.ToString("n2")
                lblTax.Text = dblTax.ToString("n2")
                lblResortFee.Text = dblTotalResortFee.ToString("n2")
                lblParkingfee.Text = dblParkingFee.ToString("n2")
                lblTotalDue.Text = dblTotalDue.ToString("n2")

            End If
        End If
    End Sub

    Private Sub CancelKeys_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRooms.KeyPress, txtNights.KeyPress, txtAdults.KeyPress, txtChildren.KeyPress
        'Text boxes only accept numbers or backspace
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            'cancel the entered key
            e.Handled = True
        End If



    End Sub

    Private Sub txtRooms_Enter(sender As Object, e As EventArgs) Handles txtRooms.Enter
        'select all contents of the text box when it receives focus

        txtRooms.SelectAll()

    End Sub

    Private Sub txtNights_Enter(sender As Object, e As EventArgs) Handles txtNights.Enter
        txtNights.SelectAll()
    End Sub

    Private Sub txtAdults_Enter(sender As Object, e As EventArgs) Handles txtAdults.Enter
        txtAdults.SelectAll()
    End Sub

    Private Sub txtChildren_Enter(sender As Object, e As EventArgs) Handles txtChildren.Enter
        txtChildren.SelectAll()
    End Sub


End Class
