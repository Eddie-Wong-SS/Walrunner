Public Class Form2
    Private Sub Cont_Click(sender As Object, e As EventArgs) Handles Cont.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Redo_Click(sender As Object, e As EventArgs) Handles Redo.Click
        reset()
    End Sub

    Private Sub Quit_Click(sender As Object, e As EventArgs) Handles Quit.Click
        If MessageBox.Show("Are you sure to close this application?", "Close",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
            End
        End If
    End Sub

End Class