Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'to find whether the alpahbet is a consonant or an vowel
        Dim a As String
        a = InputBox("Please enter alpahbet", "Alphabet")
        If a = "A" Or a = "E" Or a = "I" Or a = "O" Or a = "U" Or a = "a" Or a = "e" Or a = "i" Or a = "o" Or a = "u" Then
            MsgBox("is a vowel")
        Else
            MsgBox("is a consonant")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a As String
        a = InputBox("Please enter alphabet", "Alphabet")
        Select Case a
            Case "A", "E", "I", "O", "U"
                MsgBox("Vowel")
            Case Else
                MsgBox("Consonant")
        End Select
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim s As Integer
        s = InputBox("Enter your salary", "Salary")
        Select Case s
            Case < 5000
                MsgBox("Low Income")
            Case 5001 To 9999
                MsgBox("Middle Income")
            Case > 10000
                MsgBox("High Income")
        End Select
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim km As Integer, cm As Integer, m As Integer
        cm = InputBox("Enter the length", "CM")
        Select Case cm
            Case m
                ListBox1.Text = Val(cm * 1000)
            Case km
                ListBox1.Text = Val(cm * 100000)
        End Select

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim a As Integer
        a = InputBox("Enter number for a day", "1-7")
        Select Case a
            Case "1"
                MsgBox("Sunday")
            Case "2"
                MsgBox("Monday")
            Case "3"
                MsgBox("Tuesday")
            Case "4"
                MsgBox("Wednesday")
            Case "5"
                MsgBox("Thursday")
            Case "6"
                MsgBox("Friday")
            Case "7"
                MsgBox("Saturday")
            Case Else
                MsgBox("Invalid number")
        End Select
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim a, num1, num2, result As Integer
        
    End Sub
End Class
