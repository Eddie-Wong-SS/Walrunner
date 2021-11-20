Module Module1
    Public score As Integer
    Public highscore As Integer
    Public difficulty As Short = 3
    Public easy As Boolean = False
    Public avatar As Short = 2
    Public name As String
    Public Function reset() As Boolean
        Dim newGame As New Form1
        Form1.Controls.Clear()
        newGame.Show()
        Return True
    End Function
    Public path As String = "C:\Users\Student\source\repos\Walrunner\Walrunner\Champion.txt"

End Module
