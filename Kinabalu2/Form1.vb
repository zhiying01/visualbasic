Imports System.Data.OleDb

Public Class Form1
    Dim con As New OleDbConnection
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\visual studio\Database\MountKinabalu.accdb"
        con.Open()
        Dim login As OleDbCommand = New OleDbCommand("Select ClimberID, ClimberPassword from Climber Where [ClimberID]='" & TextBox1.Text & "'and [ClimberPassword]='" & TextBox2.Text & "'", con)
        Dim ID As OleDbDataReader = login.ExecuteReader

        If (ID.Read() = True) Then
            Me.Hide()
            MsgBox("Login Sucessful !")
        Else
            MsgBox("Login Failed !")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If MsgBox("Are you sure you want to EXIT?", vbYesNo, "Login") Then
            End
        Else
        End If
    End Sub
End Class
