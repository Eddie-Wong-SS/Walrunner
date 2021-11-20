Imports System.IO

Public Class Form3
    Dim i As Integer = 0
    Dim scoring As String

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Names.Text = Name
        CurScore.Text = score
        HScore.Text = highscore
        Me.ActiveControl = Label1

        Dim scReader As New System.IO.StreamReader(path, False)
        Dim check As String() = File.ReadAllLines(path)
        scoring = check(1)
        HScore.Text = scoring
        scReader.Close()
    End Sub

    Private Sub Quit_Click(sender As Object, e As EventArgs) Handles Quit.Click
        If MessageBox.Show("Are you sure you want to close this application?", "Close",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
            End
        End If
    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        Application.Restart()
    End Sub
End Class