Public Class Form3

    Public turn As Integer = 0
    Private Sub Form3_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If (turn = 0) Then
            lblTurn.Text = Module1.playerOne + "'s Turn"
            turn += 1
        ElseIf (turn = 1) Then
            lblTurn.Text = Module1.playerTwo + "'s Turn"
            turn -= 1
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        For Each c As Char In txtbWord.Text
            Module1.word.Add(c)
        Next

        If rdbDouble.Checked Then
            Module1.normal = False
        Else
            Module1.normal = True
        End If

        Module1.guessWord = txtbWord.Text
        Module1.turnNumber += 1
        frmMain.Show()
        Me.Hide()
    End Sub
End Class