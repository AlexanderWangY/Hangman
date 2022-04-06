Public Class Form3

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        If rdbDouble.Checked Then
            Module1.normal = False
        Else
            Module1.normal = True
        End If

        Module1.guessWord = txtbWord.Text.ToUpper
        Module1.turnNumber += 1
        frmMain.Show()
        Me.Close()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles Me.Load

        txtbWord.Clear()
        rdbNormal.Checked = True
        rdbDouble.Checked = False
        If (Module1.turnName = 0) Then
            lblTurn.Text = Module1.playerOne + "'s Turn"
            Module1.turnName += 1
        ElseIf (Module1.turnName = 1) Then
            lblTurn.Text = Module1.playerTwo + "'s Turn"
            Module1.turnName -= 1
        End If
    End Sub
End Class