Imports System.IO

Public Class Form1
    Dim gravity, obsSpeed, lefty, toppy, check As Short
    Dim locateX, locateY As Short
    Dim intersection As Boolean = False
    Dim countdown As Short = 4
    Dim x As Control
    Dim newPosition As New Random
    Dim spawning As Integer = 0
    Dim leveltime As Integer = 0
    Dim levels As Short = 1
    Dim announcing As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeyPreview = True
        Announcer.Text = "Level" & Environment.NewLine & "1"
        score = 0
        highscore = 0
        If difficulty = 3 Then
            Spawner.Interval = 600
        ElseIf difficulty = 1 Then
            Spawner.Interval = 800
        End If
        Me.ActiveControl = Label1
        My.Computer.Audio.Play("C:\Users\Student\source\repos\Walrunner\Walrunner\Fish_On.wav", AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub ScoreTime_Tick(sender As Object, e As EventArgs) Handles ScoreTime.Tick
        leveltime += 1
        Select Case difficulty
            Case 1
                score += 1
            Case 2
                score += 2
            Case 3
                score += 3
        End Select

        levelling(leveltime)
        HighBox.Text = highscore.ToString
        ScoreBox.Text = score.ToString
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Space Then
            timers()
            constants()

            If MC.Bounds.IntersectsWith(Wall1.Bounds) Then
                MC.Image = Walrunner.My.Resources.Resources.Monkey
                moveRight.Enabled = True
            ElseIf MC.Bounds.IntersectsWith(Wall2.Bounds) Then
                MC.Image = Walrunner.My.Resources.Resources.Monek1
                moveLeft.Enabled = True
            End If
        ElseIf e.KeyCode = Keys.Escape Then
            Dim Paused As Form2 = New Form2()
            ender()

            Paused.ShowDialog()
            Announcer.Show()
            Cont.Enabled = True
        End If

    End Sub

    Private Sub moveLeft_Tick(sender As Object, e As EventArgs) Handles moveLeft.Tick
        MC.Top -= toppy
        MC.Left -= lefty
        If MC.Bounds.IntersectsWith(Wall1.Bounds) Then
            moveLeft.Enabled = False
            GravityTime.Enabled = True
        End If
    End Sub

    Private Sub moveRight_Tick(sender As Object, e As EventArgs) Handles moveRight.Tick
        MC.Top -= toppy
        MC.Left += lefty
        If MC.Bounds.IntersectsWith(Wall2.Bounds) Then
            moveRight.Enabled = False
            GravityTime.Enabled = True
        End If
    End Sub

    Private Sub GravityTime_Tick(sender As Object, e As EventArgs) Handles GravityTime.Tick
        If MC.Bounds.IntersectsWith(Wall1.Bounds) Or MC.Bounds.IntersectsWith(Wall2.Bounds) Then
            MC.Top += gravity

        End If
    End Sub

    Private Sub Checker_Tick(sender As Object, e As EventArgs) Handles Checker.Tick
        For Each x In Me.Controls
            If TypeOf x Is PictureBox And x IsNot MC Then
                intersection = collide(x, MC)
                If intersection = True Then
                    ender()
                    My.Computer.Audio.Stop()
                    MsgBox("You lose!")
                    If easy = False Then
                        MsgBox("Easy mode is now unlocked!")
                        easy = True
                    End If
                    If score >= highscore Then
                        highscore = score
                        If System.IO.File.Exists(path) Then
                            ReadWrite(highscore)
                        End If
                    End If
                    Form3.Show()
                    Me.Hide()
                    score = 0
                End If
            End If
        Next x
    End Sub

    Private Sub Cont_Tick(sender As Object, e As EventArgs) Handles Cont.Tick
        countdown -= 1
        Announcer.Text = countdown
        If countdown = 0 Then
            timers()
            GravityTime.Enabled = True
            moveLeft.Enabled = True
            moveRight.Enabled = True
            Cont.Enabled = False
        End If

    End Sub

    Private Sub Obsfalling_Tick(sender As Object, e As EventArgs) Handles Obsfalling.Tick
        For Each x In Me.Controls
            If TypeOf x Is PictureBox And x IsNot MC Then
                If x.Tag.ToString = "obstacle" And x IsNot Laser Then
                    x.Top += obsSpeed
                End If

                If x.Tag.ToString = "obstacle" And x.Bottom >= Me.Bottom Then
                    Me.Controls.Remove(x)
                End If
            End If
        Next x

    End Sub

    Public Function collide(RandomObj As PictureBox, Player As PictureBox) As Boolean
        If RandomObj.Tag.ToString = "obstacle" AndAlso Player.Bounds.IntersectsWith(RandomObj.Bounds) Then
            Return True
        End If
        Return False
    End Function

    Private Sub AnnounceTime_Tick(sender As Object, e As EventArgs) Handles AnnounceTime.Tick
        If Announcer.Visible = True Then
            announcing += 1
            If announcing Mod 3 = 0 Then
                Announcer.Visible = False
                AnnounceTime.Enabled = False
                announcing = 0
            End If
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles HighBox.TextChanged

    End Sub

    Private Sub Spawner_Tick(sender As Object, e As EventArgs) Handles Spawner.Tick
        Dim newBox As New PictureBox
        spawning += 1
        If spawning Mod 2 = 0 Then
            newBox.Visible = True
            newBox.Width = 30
            locateY = 40 + newPosition.Next Mod 55
            newBox.Height = locateY
            newBox.Tag = "obstacle"

            locateX = 47 + newPosition.Next Mod 370
            Select Case difficulty
                Case 1
                    If locateX <= 140 Then
                        locateX = 47
                    Else locateX = 371
                    End If
                Case 2
                    If locateX <= 140 Then
                        locateX = 47
                    ElseIf locateX <= 280 And locateX > 140 Then
                        locateX = 210
                    Else locateX = 371
                    End If
                Case 3
                    locateX = locateX
            End Select

            newBox.Location = New Point(locateX, 0)
            If difficulty = 3 Then
                If newBox.Bounds.IntersectsWith(Wall1.Bounds) Then
                    newBox.Location = New Point(locateX + 30, 0)
                ElseIf newBox.Bounds.IntersectsWith(Wall2.Bounds) Then
                    newBox.Location = New Point(locateX - 30, 0)
                End If
            End If
            'newBox.BackgroundImage = " "
            newBox.BackColor = Color.FromArgb(51, 255, 255)
            Me.Controls.Add(newBox)

        End If
    End Sub

    Private Sub timers()
        ScoreTime.Enabled = True
        Checker.Enabled = True
        GravityTime.Enabled = False
        Obsfalling.Enabled = True
        Spawner.Enabled = True
        AnnounceTime.Enabled = True
    End Sub

    Private Sub ender()
        ScoreTime.Enabled = False
        moveLeft.Enabled = False
        moveRight.Enabled = False
        GravityTime.Enabled = False
        Obsfalling.Enabled = False
        Checker.Enabled = False
        Spawner.Enabled = False

    End Sub

    Private Sub constants()
        Select Case difficulty
            Case 1
                gravity = 2
                lefty = 10
                toppy = 1
                obsSpeed = 4
            Case 2
                gravity = 2
                lefty = 10
                toppy = 1
                obsSpeed = 4
            Case 3
                gravity = 2
                lefty = 10
                toppy = 1
                obsSpeed = 4
        End Select
    End Sub

    Private Sub levelling(ByRef i As Integer)
        If i Mod 75 = 0 Then
            levels += 1
            Announcer.Visible = True
            Announcer.Text = "Level" & Environment.NewLine & levels
            AnnounceTime.Enabled = True
            Spawner.Interval -= 50
        End If
    End Sub

    Private Sub ReadWrite(highscore As Integer)
        'Dim check As String List(Of String) = New List(Of String)
        Dim scoring As String
        Dim checker As Integer
        Dim hsReader As New System.IO.StreamReader(path, False)
        'Do While Not hsReader.EndOfStream
        'check.Add(hsReader.ReadLine())
        ' Loop
        ' scoring = hsReader.Read(2, hsReader)
        Dim check = File.ReadAllLines(path)
        scoring = check(1)
        hsReader.Close()
        checker = Integer.Parse(scoring)
        If highscore >= checker Then
            MsgBox("True")
            Dim hsWriter As New System.IO.StreamWriter(path, False)

            hsWriter.WriteLine(Name)
            hsWriter.WriteLine(highscore)
            hsWriter.Close()
        End If




    End Sub
End Class
