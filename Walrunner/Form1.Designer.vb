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
        Me.components = New System.ComponentModel.Container()
        Me.moveLeft = New System.Windows.Forms.Timer(Me.components)
        Me.moveRight = New System.Windows.Forms.Timer(Me.components)
        Me.GravityTime = New System.Windows.Forms.Timer(Me.components)
        Me.ScoreTime = New System.Windows.Forms.Timer(Me.components)
        Me.Checker = New System.Windows.Forms.Timer(Me.components)
        Me.Cont = New System.Windows.Forms.Timer(Me.components)
        Me.Announcer = New System.Windows.Forms.Label()
        Me.Obsfalling = New System.Windows.Forms.Timer(Me.components)
        Me.Spawner = New System.Windows.Forms.Timer(Me.components)
        Me.AnnounceTime = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.HighBox = New System.Windows.Forms.TextBox()
        Me.ScoreBox = New System.Windows.Forms.TextBox()
        Me.Laser = New System.Windows.Forms.PictureBox()
        Me.Obs1 = New System.Windows.Forms.PictureBox()
        Me.Obs2 = New System.Windows.Forms.PictureBox()
        Me.MC = New System.Windows.Forms.PictureBox()
        Me.Wall2 = New System.Windows.Forms.PictureBox()
        Me.Wall1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.Laser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Obs1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Obs2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wall2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wall1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'moveLeft
        '
        Me.moveLeft.Interval = 10
        '
        'moveRight
        '
        Me.moveRight.Interval = 10
        '
        'GravityTime
        '
        Me.GravityTime.Interval = 20
        '
        'ScoreTime
        '
        Me.ScoreTime.Interval = 200
        '
        'Checker
        '
        Me.Checker.Interval = 20
        '
        'Cont
        '
        Me.Cont.Interval = 1000
        '
        'Announcer
        '
        Me.Announcer.AutoSize = True
        Me.Announcer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Announcer.Location = New System.Drawing.Point(189, 40)
        Me.Announcer.MinimumSize = New System.Drawing.Size(30, 0)
        Me.Announcer.Name = "Announcer"
        Me.Announcer.Size = New System.Drawing.Size(30, 24)
        Me.Announcer.TabIndex = 6
        Me.Announcer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Obsfalling
        '
        Me.Obsfalling.Interval = 1
        '
        'Spawner
        '
        Me.Spawner.Interval = 700
        '
        'AnnounceTime
        '
        Me.AnnounceTime.Interval = 1000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Cyan
        Me.Label1.Location = New System.Drawing.Point(396, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = " Highscore:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Cyan
        Me.Label2.Location = New System.Drawing.Point(408, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Score:"
        '
        'HighBox
        '
        Me.HighBox.BackColor = System.Drawing.SystemColors.InfoText
        Me.HighBox.ForeColor = System.Drawing.Color.Maroon
        Me.HighBox.Location = New System.Drawing.Point(462, 6)
        Me.HighBox.Name = "HighBox"
        Me.HighBox.ReadOnly = True
        Me.HighBox.Size = New System.Drawing.Size(71, 20)
        Me.HighBox.TabIndex = 10
        Me.HighBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ScoreBox
        '
        Me.ScoreBox.BackColor = System.Drawing.SystemColors.InfoText
        Me.ScoreBox.ForeColor = System.Drawing.Color.Cyan
        Me.ScoreBox.Location = New System.Drawing.Point(457, 48)
        Me.ScoreBox.Name = "ScoreBox"
        Me.ScoreBox.ReadOnly = True
        Me.ScoreBox.Size = New System.Drawing.Size(88, 20)
        Me.ScoreBox.TabIndex = 11
        Me.ScoreBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Laser
        '
        Me.Laser.BackColor = System.Drawing.Color.Maroon
        Me.Laser.Location = New System.Drawing.Point(0, 662)
        Me.Laser.Name = "Laser"
        Me.Laser.Size = New System.Drawing.Size(545, 26)
        Me.Laser.TabIndex = 5
        Me.Laser.TabStop = False
        Me.Laser.Tag = "obstacle"
        '
        'Obs1
        '
        Me.Obs1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Obs1.Location = New System.Drawing.Point(370, 253)
        Me.Obs1.Name = "Obs1"
        Me.Obs1.Size = New System.Drawing.Size(30, 50)
        Me.Obs1.TabIndex = 4
        Me.Obs1.TabStop = False
        Me.Obs1.Tag = "obstacle"
        '
        'Obs2
        '
        Me.Obs2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Obs2.Location = New System.Drawing.Point(52, 403)
        Me.Obs2.Name = "Obs2"
        Me.Obs2.Size = New System.Drawing.Size(30, 50)
        Me.Obs2.TabIndex = 3
        Me.Obs2.TabStop = False
        Me.Obs2.Tag = "obstacle"
        '
        'MC
        '
        Me.MC.Image = Global.Walrunner.My.Resources.Resources.Monek1
        Me.MC.Location = New System.Drawing.Point(52, 519)
        Me.MC.Name = "MC"
        Me.MC.Size = New System.Drawing.Size(25, 50)
        Me.MC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MC.TabIndex = 2
        Me.MC.TabStop = False
        '
        'Wall2
        '
        Me.Wall2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Wall2.Location = New System.Drawing.Point(395, 0)
        Me.Wall2.Name = "Wall2"
        Me.Wall2.Size = New System.Drawing.Size(150, 675)
        Me.Wall2.TabIndex = 1
        Me.Wall2.TabStop = False
        Me.Wall2.Tag = "Wall"
        '
        'Wall1
        '
        Me.Wall1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Wall1.Location = New System.Drawing.Point(0, 0)
        Me.Wall1.Name = "Wall1"
        Me.Wall1.Size = New System.Drawing.Size(54, 675)
        Me.Wall1.TabIndex = 0
        Me.Wall1.TabStop = False
        Me.Wall1.Tag = "Wall"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PictureBox1.Location = New System.Drawing.Point(47, 51)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 50)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Tag = "obstacle"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 687)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ScoreBox)
        Me.Controls.Add(Me.HighBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Announcer)
        Me.Controls.Add(Me.Laser)
        Me.Controls.Add(Me.Obs1)
        Me.Controls.Add(Me.Obs2)
        Me.Controls.Add(Me.MC)
        Me.Controls.Add(Me.Wall2)
        Me.Controls.Add(Me.Wall1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.Laser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Obs1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Obs2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wall2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wall1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents moveLeft As Timer
    Friend WithEvents moveRight As Timer
    Friend WithEvents Wall1 As PictureBox
    Friend WithEvents MC As PictureBox
    Friend WithEvents Obs2 As PictureBox
    Friend WithEvents Obs1 As PictureBox
    Friend WithEvents Laser As PictureBox
    Friend WithEvents GravityTime As Timer
    Friend WithEvents ScoreTime As Timer
    Friend WithEvents Checker As Timer
    Friend WithEvents Cont As Timer
    Friend WithEvents Announcer As Label
    Friend WithEvents Obsfalling As Timer
    Friend WithEvents Spawner As Timer
    Friend WithEvents AnnounceTime As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Wall2 As PictureBox
    Friend WithEvents HighBox As TextBox
    Friend WithEvents ScoreBox As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
