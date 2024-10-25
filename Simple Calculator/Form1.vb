Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, total As Integer
        'use combobox need select case then the combo box name, and list out all the items as case
        'then add value and things
        Select Case Selection.Text
            Case "+"
                a = Val(txt1.Text)
                b = Val(txt2.Text)
                total = a + b
                lblOutput.Text = total
            Case "-"
                a = Val(txt1.Text)
                b = Val(txt2.Text)
                total = a - b
                lblOutput.Text = total
            Case "/"
                a = Val(txt1.Text)
                b = Val(txt2.Text)
                total = a / b
                lblOutput.Text = total
            Case "*"
                a = Val(txt1.Text)
                b = Val(txt2.Text)
                total = a * b
                lblOutput.Text = total
        End Select
    End Sub

    Private Sub Factor_Click(sender As Object, e As EventArgs) Handles Factor.Click
        'to find the factor of the number
        Dim a, factor As Integer
        a = Val(txt1.Text)
        factor = 1
        Do While a Mod factor = 0
            ListBox1.Items.Add(factor)
            factor += 1
        Loop
    End Sub
End Class
