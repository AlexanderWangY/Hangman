Public Class Form2
    Private Sub Form2_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        frmMain.Hide()
    End Sub

    Private Sub btnLetsGo_Click(sender As Object, e As EventArgs) Handles btnLetsGo.Click
        Module1.playerOne = txtbPlayer1.Text
        Module1.playerTwo = txtbPlayer2.Text
        Module1.scoreOne = 0
        Module1.scoreTwo = 0
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtbPlayer1.Clear()
        txtbPlayer2.Clear()
    End Sub
End Class