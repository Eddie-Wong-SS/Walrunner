<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Names = New System.Windows.Forms.TextBox()
        Me.CurScore = New System.Windows.Forms.TextBox()
        Me.HScore = New System.Windows.Forms.TextBox()
        Me.Reset = New System.Windows.Forms.Button()
        Me.Quit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(35, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(121, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(328, 55)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Score Screen"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(36, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Your Score:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(37, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "HighScore: "
        '
        'Names
        '
        Me.Names.BackColor = System.Drawing.Color.Black
        Me.Names.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Names.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Names.Location = New System.Drawing.Point(112, 101)
        Me.Names.Name = "Names"
        Me.Names.ReadOnly = True
        Me.Names.Size = New System.Drawing.Size(221, 29)
        Me.Names.TabIndex = 4
        Me.Names.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CurScore
        '
        Me.CurScore.BackColor = System.Drawing.Color.Black
        Me.CurScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurScore.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.CurScore.Location = New System.Drawing.Point(163, 152)
        Me.CurScore.Name = "CurScore"
        Me.CurScore.ReadOnly = True
        Me.CurScore.Size = New System.Drawing.Size(170, 29)
        Me.CurScore.TabIndex = 5
        Me.CurScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'HScore
        '
        Me.HScore.BackColor = System.Drawing.Color.Black
        Me.HScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HScore.ForeColor = System.Drawing.Color.Red
        Me.HScore.Location = New System.Drawing.Point(161, 205)
        Me.HScore.Name = "HScore"
        Me.HScore.ReadOnly = True
        Me.HScore.Size = New System.Drawing.Size(172, 29)
        Me.HScore.TabIndex = 6
        Me.HScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Reset
        '
        Me.Reset.BackColor = System.Drawing.Color.Goldenrod
        Me.Reset.Location = New System.Drawing.Point(511, 89)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(75, 53)
        Me.Reset.TabIndex = 6
        Me.Reset.Text = "Back To Main Menu"
        Me.Reset.UseVisualStyleBackColor = False
        '
        'Quit
        '
        Me.Quit.BackColor = System.Drawing.Color.Goldenrod
        Me.Quit.Location = New System.Drawing.Point(511, 192)
        Me.Quit.Name = "Quit"
        Me.Quit.Size = New System.Drawing.Size(75, 42)
        Me.Quit.TabIndex = 7
        Me.Quit.Text = "Exit"
        Me.Quit.UseVisualStyleBackColor = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(616, 407)
        Me.Controls.Add(Me.Reset)
        Me.Controls.Add(Me.Quit)
        Me.Controls.Add(Me.HScore)
        Me.Controls.Add(Me.CurScore)
        Me.Controls.Add(Me.Names)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Names As TextBox
    Friend WithEvents CurScore As TextBox
    Friend WithEvents HScore As TextBox
    Friend WithEvents Reset As Button
    Friend WithEvents Quit As Button
End Class
