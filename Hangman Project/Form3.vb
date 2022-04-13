Option Explicit On
Option Infer Off
Option Strict On

Public Class Form3

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        If rdbDouble.Checked Then
            Module1.normal = False
        Else
            Module1.normal = True
        End If

        Module1.guessWord = txtbWord.Text.ToUpper
        Module1.guessWordPoints = 0
        For Each c As Char In Module1.guessWord
            If c = " " Then
                Continue For
            Else
                Module1.guessWordPoints += 1
            End If
        Next
        frmMain.Show()
        Me.Close()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles Me.Load

        txtbWord.Clear()

        If (Module1.turnName = 0) Then
            lblTurn.Text = Module1.playerOne + "'s turn to choose a word"
            lblLookAway.Text = Module1.playerTwo + ", LOOK AWAy!"
            Module1.turnName += 1
        ElseIf (Module1.turnName = 1) Then
            lblTurn.Text = Module1.playerTwo + "'ss turn to choose a word"
            lblLookAway.Text = Module1.playerOne + ", LOOK AWAy!"
            Module1.turnName -= 1
        End If
    End Sub

    Private Sub txtbWord_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbWord.KeyPress
        If AscW(e.KeyChar) = 8 Then
        ElseIf txtbWord.Text.Length = 20 Then
            e.KeyChar = Nothing
        Else
            If AscW(e.KeyChar) > 64 And AscW(e.KeyChar) < 91 Or AscW(e.KeyChar) > 96 And AscW(e.KeyChar) < 123 Or AscW(e.KeyChar) = 8 Or AscW(e.KeyChar) = 32 Then
            Else
                e.KeyChar = Nothing
            End If
        End If
    End Sub
End Class