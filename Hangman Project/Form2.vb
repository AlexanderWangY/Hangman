Option Explicit On
Option Infer Off
Option Strict On

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

    Private Sub txtbPlayer1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbPlayer1.KeyPress
        If txtbPlayer1.Text.Length >= 20 Then
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub txtbPlayer2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbPlayer2.KeyPress
        If txtbPlayer2.Text.Length >= 22 Then
            e.KeyChar = Nothing
        End If
    End Sub
End Class