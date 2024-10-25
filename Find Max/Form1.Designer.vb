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
        Me.Compare = New System.Windows.Forms.Button()
        Me.Txt1 = New System.Windows.Forms.TextBox()
        Me.Txt2 = New System.Windows.Forms.TextBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.Txt3 = New System.Windows.Forms.TextBox()
        Me.Check = New System.Windows.Forms.Button()
        Me.Divisible = New System.Windows.Forms.Button()
        Me.Odd = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Compare
        '
        Me.Compare.Location = New System.Drawing.Point(68, 219)
        Me.Compare.Name = "Compare"
        Me.Compare.Size = New System.Drawing.Size(159, 64)
        Me.Compare.TabIndex = 0
        Me.Compare.Text = "Compare"
        Me.Compare.UseVisualStyleBackColor = True
        '
        'Txt1
        '
        Me.Txt1.Location = New System.Drawing.Point(56, 61)
        Me.Txt1.Name = "Txt1"
        Me.Txt1.Size = New System.Drawing.Size(189, 27)
        Me.Txt1.TabIndex = 1
        '
        'Txt2
        '
        Me.Txt2.Location = New System.Drawing.Point(56, 109)
        Me.Txt2.Name = "Txt2"
        Me.Txt2.Size = New System.Drawing.Size(189, 27)
        Me.Txt2.TabIndex = 2
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblOutput.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblOutput.Location = New System.Drawing.Point(56, 311)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(177, 38)
        Me.lblOutput.TabIndex = 3
        Me.lblOutput.Text = "Label Output"
        '
        'Txt3
        '
        Me.Txt3.Location = New System.Drawing.Point(56, 164)
        Me.Txt3.Name = "Txt3"
        Me.Txt3.Size = New System.Drawing.Size(189, 27)
        Me.Txt3.TabIndex = 4
        '
        'Check
        '
        Me.Check.Location = New System.Drawing.Point(514, 61)
        Me.Check.Name = "Check"
        Me.Check.Size = New System.Drawing.Size(159, 64)
        Me.Check.TabIndex = 5
        Me.Check.Text = "Check"
        Me.Check.UseVisualStyleBackColor = True
        '
        'Divisible
        '
        Me.Divisible.Location = New System.Drawing.Point(514, 164)
        Me.Divisible.Name = "Divisible"
        Me.Divisible.Size = New System.Drawing.Size(159, 64)
        Me.Divisible.TabIndex = 6
        Me.Divisible.Text = "Divisible"
        Me.Divisible.UseVisualStyleBackColor = True
        '
        'Odd
        '
        Me.Odd.Location = New System.Drawing.Point(514, 268)
        Me.Odd.Name = "Odd"
        Me.Odd.Size = New System.Drawing.Size(159, 64)
        Me.Odd.TabIndex = 7
        Me.Odd.Text = "Odd or Even"
        Me.Odd.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(763, 74)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 29)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(937, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Odd)
        Me.Controls.Add(Me.Divisible)
        Me.Controls.Add(Me.Check)
        Me.Controls.Add(Me.Txt3)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.Txt2)
        Me.Controls.Add(Me.Txt1)
        Me.Controls.Add(Me.Compare)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Compare As Button
    Friend WithEvents Txt1 As TextBox
    Friend WithEvents Txt2 As TextBox
    Friend WithEvents lblOutput As Label
    Friend WithEvents Txt3 As TextBox
    Friend WithEvents Check As Button
    Friend WithEvents Divisible As Button
    Friend WithEvents Odd As Button
    Friend WithEvents Button1 As Button
End Class
