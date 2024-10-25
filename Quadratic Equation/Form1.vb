Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c As String
        Dim sqrt, result1, result2 As Double
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        c = Val(TextBox3.Text)
        sqrt = Math.Sqrt(b * b - (4 * a * c))
        result1 = (-b + sqrt) / (2 * a)
        result2 = (-b - sqrt) / (2 * a)

        TextBox4.Text = result1
        TextBox5.Text = result2
        result1.ToString("N2") 'to set it to only 2 decimal places
        result2.ToString("N2")

        MsgBox("do not put zero in input A", MsgBoxStyle.OkOnly)
    End Sub


End Class
