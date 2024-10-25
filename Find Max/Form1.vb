Imports System.Text.RegularExpressions

Public Class Form1
    Private Sub Compare_Click(sender As Object, e As EventArgs) Handles Compare.Click
        'to fnd max numbers
        Dim a, b, c As Integer
        a = Val(Txt1.Text)
        b = Val(Txt2.Text)
        c = Val(Txt3.Text)
        'compare the numbers
        If a > b And a > c Then
            lblOutput.Text = a & " is a maximum"
        ElseIf b > a And b > c Then
            lblOutput.Text = b & " is a maximum"
        ElseIf c > a And c > b Then
            lblOutput.Text = c & " is a maximum"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Check.Click
        'to find a num +ve, -ve, 0
        Dim a As Integer
        a = Val(Txt1.Text)
        'compare
        If a > 0 Then
            lblOutput.Text = a & " is POSITIVE"
        ElseIf a < 0 Then
            lblOutput.Text = a & " is NEGATIVE"
        ElseIf a = 0 Then
            lblOutput.Text = a & " is ZERO"


        End If
    End Sub

    Private Sub Divisible_Click(sender As Object, e As EventArgs) Handles Divisible.Click
        'to find a number whether divisible with 5 and 11 or not
        Dim a As Integer
        a = Val(Txt1.Text)
        'check divisible by 5 and 11
        If a Mod 5 = 0 And a Mod 11 = 0 Then
            lblOutput.Text = a & " CAN divisible by 5 and 11"
        Else
            lblOutput.Text = a & " CANNOT divisible by 5 and 11"
        End If
    End Sub

    Private Sub Odd_Click(sender As Object, e As EventArgs) Handles Odd.Click
        'to find if a number is odd or integer
        Dim a As Integer
        a = Val(Txt1.Text)
        'to find odd or even
        If a Mod 2 = 0 Then
            lblOutput.Text = a & " is an even number"
        Else
            lblOutput.Text = a & " is an odd number"
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As String
        a = Val(Txt1.Text)
        If System.Text.RegularExpressions.Regex.IsMatch(Txt1.Text, "[^a-z]+$", RegexOptions.IgnoreCase) Then
            MsgBox("This is not alphabet")
        Else
            MsgBox("This is alphabet")
        End If
    End Sub
End Class
