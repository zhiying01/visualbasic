Structure sales
    Public customer As Integer
    Public A4Paper As Integer
    Public NoteSheet As Integer
    Public FileFlag As Integer
    Public StapleS As Integer
    Public StaplerB As Integer
    Public Ballpen As Integer
    Public GlueStick As Integer
    Public Eraser As Integer
    Public PermenantM As Integer
    Public CalculatorCitizen As Integer
End Structure

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As sales

        n.customer = InputBox("How many customer:")
        n.A4Paper = InputBox("Amount of Photostat A4 Paper:")
        n.NoteSheet = InputBox("Amount of Note sheet 95 GM:")
        n.FileFlag = InputBox("Amount of File Flag:")
        n.StapleS = InputBox("Amount of Stapler Small:")
        n.StaplerB = InputBox("Amount of Stapler Big:")
        n.Ballpen = InputBox("Amount of Ball pen:")
        n.GlueStick = InputBox("Amount of Glue Stick:")
        n.Eraser = InputBox("Amount of Eraser:")
        n.PermenantM = InputBox("Amount of Permenant Marker:")
        n.CalculatorCitizen = InputBox("Amount of Calculator Citizen:")

        ListBox1.Items.Add(n.customer)
        ListBox1.Items.Add(n.A4Paper)
        ListBox1.Items.Add(n.NoteSheet)
        ListBox1.Items.Add(n.FileFlag)
        ListBox1.Items.Add(n.StapleS)
        ListBox1.Items.Add(n.StaplerB)
        ListBox1.Items.Add(n.Ballpen)
        ListBox1.Items.Add(n.GlueStick)
        ListBox1.Items.Add(n.Eraser)
        ListBox1.Items.Add(n.PermenantM)
        ListBox1.Items.Add(n.CalculatorCitizen)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim
    End Sub
End Class
