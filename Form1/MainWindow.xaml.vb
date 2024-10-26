Class MainWindow
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        'find smaller uber
        Dim a, b, smallest As Integer
        a = Val(txt1.Text)
        b = Val(txt2.Text)
        If a < b Then
            a = smallest
        ElseIf b < a Then
            b = smallest
        End If

        'find the GCD
        For c As Integer = 1 To smallest

            If a Mod c = 0 And b Mod c = 0 Then
                ListBox1.Items.Add(c)

            End If
        Next
        ' ListBox1.Items.Add(c)
    End Sub

End Class
