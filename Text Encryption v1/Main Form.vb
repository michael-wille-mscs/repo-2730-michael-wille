'Name: Text Encryptor
'Purpose: Use a simple concept to encrypt text by moving the entered character forward by 8 ASCII characters
'Programmer: Michael Wille, 10/14/2017


Option Infer Off
Option Explicit On
Option Strict On


Public Class frmMain

    Private Sub btnEncrypt_Click(sender As Object, e As EventArgs) Handles btnEncrypt.Click

        Dim newString As System.Text.StringBuilder = New System.Text.StringBuilder()

        'Lowercase convert/encrypt 8 ASCII characters forward
        For Each character As Char In txtMessage.Text
            If character = "a"c Then
                newString.Append(Chr(105))
            ElseIf character = "b"c Then
                newString.Append(Chr(106))
            ElseIf character = "c"c Then
                newString.Append(Chr(107))
            ElseIf character = "d"c Then
                newString.Append(Chr(108))
            ElseIf character = "e"c Then
                newString.Append(Chr(109))
            ElseIf character = "f"c Then
                newString.Append(Chr(110))
            ElseIf character = "g"c Then
                newString.Append(Chr(111))
            ElseIf character = "h"c Then
                newString.Append(Chr(112))
            ElseIf character = "i"c Then
                newString.Append(Chr(113))
            ElseIf character = "j"c Then
                newString.Append(Chr(114))
            ElseIf character = "k"c Then
                newString.Append(Chr(115))
            ElseIf character = "l"c Then
                newString.Append(Chr(116))
            ElseIf character = "m"c Then
                newString.Append(Chr(117))
            ElseIf character = "n"c Then
                newString.Append(Chr(118))
            ElseIf character = "o"c Then
                newString.Append(Chr(119))
            ElseIf character = "p"c Then
                newString.Append(Chr(120))
            ElseIf character = "q"c Then
                newString.Append(Chr(121))
            ElseIf character = "r"c Then
                newString.Append(Chr(122))
            ElseIf character = "s"c Then
                newString.Append(Chr(97))
            ElseIf character = "t"c Then
                newString.Append(Chr(98))
            ElseIf character = "u"c Then
                newString.Append(Chr(99))
            ElseIf character = "v"c Then
                newString.Append(Chr(100))
            ElseIf character = "w"c Then
                newString.Append(Chr(101))
            ElseIf character = "x"c Then
                newString.Append(Chr(102))
            ElseIf character = "y"c Then
                newString.Append(Chr(103))
            ElseIf character = "z"c Then
                newString.Append(Chr(104))

                'Uppercase convert/encrypt 8 ASCII characters forward
            ElseIf character = "A"c Then
                newString.Append(Chr(73))
            ElseIf character = "B"c Then
                newString.Append(Chr(74))
            ElseIf character = "C"c Then
                newString.Append(Chr(75))
            ElseIf character = "D"c Then
                newString.Append(Chr(76))
            ElseIf character = "E"c Then
                newString.Append(Chr(77))
            ElseIf character = "F"c Then
                newString.Append(Chr(78))
            ElseIf character = "G"c Then
                newString.Append(Chr(79))
            ElseIf character = "H"c Then
                newString.Append(Chr(80))
            ElseIf character = "I"c Then
                newString.Append(Chr(81))
            ElseIf character = "J"c Then
                newString.Append(Chr(82))
            ElseIf character = "K"c Then
                newString.Append(Chr(83))
            ElseIf character = "L"c Then
                newString.Append(Chr(84))
            ElseIf character = "M"c Then
                newString.Append(Chr(85))
            ElseIf character = "N"c Then
                newString.Append(Chr(86))
            ElseIf character = "O"c Then
                newString.Append(Chr(87))
            ElseIf character = "P"c Then
                newString.Append(Chr(88))
            ElseIf character = "Q"c Then
                newString.Append(Chr(89))
            ElseIf character = "R"c Then
                newString.Append(Chr(90))
            ElseIf character = "S"c Then
                newString.Append(Chr(65))
            ElseIf character = "T"c Then
                newString.Append(Chr(66))
            ElseIf character = "U"c Then
                newString.Append(Chr(67))
            ElseIf character = "V"c Then
                newString.Append(Chr(68))
            ElseIf character = "W"c Then
                newString.Append(Chr(69))
            ElseIf character = "X"c Then
                newString.Append(Chr(70))
            ElseIf character = "Y"c Then
                newString.Append(Chr(71))
            ElseIf character = "Z"c Then
                newString.Append(Chr(72))

            Else
                newString.Append(Chr(Asc(character) - 2))
            End If
        Next

        txtEncryptedMessage.Text = newString.ToString()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtMessage.Text = String.Empty
        txtEncryptedMessage.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub ClearEncrypted_TextChanged(sender As Object, e As EventArgs) Handles txtMessage.TextChanged
        txtEncryptedMessage.Text = String.Empty
    End Sub
End Class
