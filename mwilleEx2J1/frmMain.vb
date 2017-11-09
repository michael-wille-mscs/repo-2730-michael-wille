' Name:         Chapter 8, String functions, list boxes
' Purpose:      #2: Interprets color code
'               #5: Sets proper upper/lower case
'               #6: Interprets shipping code
' Programmer:   <Michael Wille> on <11/8/2017>

Option Strict On
Option Explicit On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub ItemNumbers_TextChanged(sender As Object, e As EventArgs) _
            Handles txtItem1.TextChanged, txtItem2.TextChanged, txtItem3.TextChanged, txtItem4.TextChanged, txtItem5.TextChanged
        lstColors.Items.Clear()
    End Sub

    Private Sub btnDisplayColor_Click(sender As Object, e As EventArgs) Handles btnDisplayColor.Click
        DisplayColor(txtItem1.Text)
        DisplayColor(txtItem2.Text)
        DisplayColor(txtItem3.Text)
        DisplayColor(txtItem4.Text)
        DisplayColor(txtItem5.Text)
    End Sub

    Private Sub DisplayColor(ByVal itemNum As String)
        Dim strBLUE As String = "b"
        Dim strGREEN As String = "g"
        Dim strRED As String = "r"
        Dim strWHITE As String = "w"
        'Dim strITEMNUMBER As String = itemNum
        If itemNum.Length <> 7 Then
            MessageBox.Show("The item number must contain 7 characters.", "Item Number", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf CBool(itemNum.ToLower.Substring(3, 1) = "b") Then
            lstColors.Items.Add(itemNum & ": Blue")
        ElseIf CBool(itemNum.ToLower.Substring(3, 1) = strGREEN) Then
            lstColors.Items.Add(itemNum & ": Green")
        ElseIf CBool(itemNum.ToLower.Substring(3, 1) = strRED) Then
            lstColors.Items.Add(itemNum & ": Red")
        ElseIf CBool(itemNum.ToLower.Substring(3, 1) = strWHITE) Then
            lstColors.Items.Add(itemNum & ": White")
        Else
            lstColors.Items.Add(itemNum & ": Invalid")
        End If


    End Sub

    Private Sub txtName_Enter(sender As Object, e As EventArgs) Handles txtName.Enter
        txtName.SelectAll()
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        lblName.Text = String.Empty
    End Sub

    Private Sub btnDisplayDelivery_Click(sender As Object, e As EventArgs) Handles btnDisplayDelivery.Click
        DisplayDelivery(txtPartNum1.Text)
        DisplayDelivery(txtPartNum2.Text)
        DisplayDelivery(txtPartNum3.Text)
        DisplayDelivery(txtPartNum4.Text)
        DisplayDelivery(txtPartNum5.Text)
        DisplayDelivery(txtPartNum6.Text)
    End Sub

    Private Sub DisplayDelivery(ByVal partNum As String)

        If partNum.Length <> 3 AndAlso partNum.Length <> 4 Then
            MessageBox.Show("The part number must contain 3 to 4 characters.",
                            "Part Number", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf partNum.ToLower Like "##[m][s]" Then
            lstDelivery.Items.Add("Mail - Standard")
        ElseIf partNum.ToLower Like "##[m][p]" Then
            lstDelivery.Items.Add("Mail - Priority")
        ElseIf partNum.ToLower Like "##[f][s]" Then
            lstDelivery.Items.Add("FedEx - Standard")
        ElseIf partNum.ToLower Like "##[f][o]" Then
            lstDelivery.Items.Add("FedEx = Overnight")
        ElseIf partNum.ToLower Like "##[u]" Then
            lstDelivery.Items.Add("UPS")
        Else
            lstDelivery.Items.Add("Invalid Entry")
        End If
    End Sub

    Private Sub PartNum_TextChanged(sender As Object, e As EventArgs) _
            Handles txtPartNum1.TextChanged, txtPartNum2.TextChanged, txtPartNum3.TextChanged, txtPartNum4.TextChanged, txtPartNum5.TextChanged, txtPartNum6.TextChanged
        lstDelivery.Items.Clear()
    End Sub

    'btnProper_Click pseudocode:
    '1) Convert txtName to lower case, store in strName
    '2) Use strName.Substring() to get first character of strName, convert to upper case, store in strFirstChar
    '3) Remove first character of strName
    '4) Insert strFirstChar at beginning of strName
    '5) Use strName.IndexOf() to find the space character. Add 1 and store in index
    '6) Repeat steps 2 - 4 to remove/insert first letter of last name



    Private Sub btnProper_Click(sender As Object, e As EventArgs) Handles btnProper.Click
        Dim strNAME As String
        Dim strFIRSTNAMECHARONE As String
        Dim strLASTNAMECHARONE As String
        Dim intCHARINDEXSPACE As Integer
        'First Name
        strNAME = txtName.Text.ToLower
        intCHARINDEXSPACE = strNAME.IndexOf(" ") + 1
        strFIRSTNAMECHARONE = strNAME.ToUpper.Substring(0, 1)
        strNAME = strNAME.Remove(0, 1)
        strNAME = strNAME.Insert(0, strFIRSTNAMECHARONE)
        'Last Name
        strLASTNAMECHARONE = strNAME.ToUpper.Substring(intCHARINDEXSPACE, 1)
        strNAME = strNAME.Remove(intCHARINDEXSPACE, 1)
        strNAME = strNAME.Insert(intCHARINDEXSPACE, strLASTNAMECHARONE)
        lblName.Text = strNAME
        'If 

        'End If
    End Sub

End Class
