<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtGetal = New System.Windows.Forms.TextBox()
        Me.lbx = New System.Windows.Forms.ListBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(43, 98)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(172, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Kwadraat"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtGetal
        '
        Me.txtGetal.Location = New System.Drawing.Point(43, 42)
        Me.txtGetal.Name = "txtGetal"
        Me.txtGetal.Size = New System.Drawing.Size(172, 20)
        Me.txtGetal.TabIndex = 1
        '
        'lbx
        '
        Me.lbx.FormattingEnabled = True
        Me.lbx.Location = New System.Drawing.Point(43, 240)
        Me.lbx.Name = "lbx"
        Me.lbx.Size = New System.Drawing.Size(172, 186)
        Me.lbx.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(43, 144)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(172, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Kwadraat async"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(411, 40)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(149, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Parallelle acties"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(411, 86)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(149, 23)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Parallel met argumenten"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(43, 188)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(172, 23)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "Meerdere kwadraten"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lbx)
        Me.Controls.Add(Me.txtGetal)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents txtGetal As TextBox
    Friend WithEvents lbx As ListBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
