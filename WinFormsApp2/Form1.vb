Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim num, num1 As Integer
        Dim StuName(2, 2) As String '2 dimensional Array 2x2
        Dim output As String
        For num = 0 To 1 '1st repetition 
            output = ""
            For num1 = 0 To 1 '2nd repetition

                StuName(num, num1) = InputBox("Enter name")
                output &= StuName(num, num1) & ""

            Next num1 '+1
            ListBox1.Items.Add(output)

        Next num
    End Sub
End Class
