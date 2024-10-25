Public Class Form1
    Private Sub Balance_Click(sender As Object, e As EventArgs) Handles Balance.Click
        'to find the change for amount given
        Dim a, temp, a100, a50, a20, a10, a5, a1 As Integer
        a = Val(TextBox1.Text)

        'If TextBox1.Text = Is Not Char Then
        '    MsgBox("Error")
        'End If
        a100 = a / 100
        temp = a Mod 100
        a = a - (100 * a100)

        ListBox1.Items.Add("Note 100 = " & a100)

        a50 = a / 50
        temp = a Mod 50
        a = a - (50 * a50)

        ListBox1.Items.Add("Note 50 = " & a50)

        a20 = a / 20
        temp = a Mod 20
        a = a - (20 * a20)

        ListBox1.Items.Add("Note 20 = " & a20)

        a10 = a / 10
        temp = a Mod 10
        a = a - (10 * a10)

        ListBox1.Items.Add("Note 10 = " & a10)

        a5 = a / 5
        temp = a Mod 5
        a = a - (5 * a5)

        ListBox1.Items.Add("Note 5 = " & a5)

        a1 = a / 1
        temp = a Mod 1
        a = a - (1 * a1)

        ListBox1.Items.Add("Note 1 = " & a1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As String
        a = Val(TextBox2.Text)  'to find the spesific character in the parameter
        If a = InStr(a, "~") Then
            MsgBox("Error")
        Else
            MsgBox("Ok")
        End If
    End Sub
End Class
