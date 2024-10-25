<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.lblOutput = New System.Windows.Forms.TextBox()
        Me.Selection = New System.Windows.Forms.ComboBox()
        Me.Factor = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(64, 374)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 50)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Calculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(64, 44)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(125, 27)
        Me.txt1.TabIndex = 1
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(64, 126)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(125, 27)
        Me.txt2.TabIndex = 2
        '
        'lblOutput
        '
        Me.lblOutput.Location = New System.Drawing.Point(64, 210)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(125, 27)
        Me.lblOutput.TabIndex = 3
        '
        'Selection
        '
        Me.Selection.AllowDrop = True
        Me.Selection.FormattingEnabled = True
        Me.Selection.Items.AddRange(New Object() {"+", "-", "*", "/"})
        Me.Selection.Location = New System.Drawing.Point(302, 44)
        Me.Selection.Name = "Selection"
        Me.Selection.Size = New System.Drawing.Size(151, 28)
        Me.Selection.TabIndex = 4
        '
        'Factor
        '
        Me.Factor.Location = New System.Drawing.Point(206, 374)
        Me.Factor.Name = "Factor"
        Me.Factor.Size = New System.Drawing.Size(106, 50)
        Me.Factor.TabIndex = 5
        Me.Factor.Text = "Factor"
        Me.Factor.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(302, 126)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(150, 104)
        Me.ListBox1.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 450)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Factor)
        Me.Controls.Add(Me.Selection)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.Button1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Simple Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents txt1 As TextBox
    Friend WithEvents txt2 As TextBox
    Friend WithEvents lblOutput As TextBox
    Friend WithEvents Selection As ComboBox
    Friend WithEvents Factor As Button
    Friend WithEvents ListBox1 As ListBox
End Class
