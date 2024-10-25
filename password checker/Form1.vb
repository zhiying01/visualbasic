Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim password As String
        password = TextBox1.Text 'containing password
        If Validatepassword(password) = True Then
            Label3.Text = ("Password VALID")
        Else
            Label3.Text = ("Password INVALID")
        End If
    End Sub

    'password is set to be 8 characters with @
    Function Validatepassword(ByVal password As String,
         Optional ByVal minLength As Integer = 10,
         Optional ByVal numSpecial As Integer = 1) As Boolean

        'check password validity
        Dim special As New System.Text.RegularExpressions.Regex("@")

        If Len(password) < minLength Then Return False

        If special.Matches(password).Count < numSpecial Then Return False

        Return True
    End Function
End Class
