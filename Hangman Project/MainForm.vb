Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picBody.Hide()
        picHead.Hide()
        picLeft.Hide()
        picLLeft.Hide()
        picRight.Hide()
        picRLeg.Hide()
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub frmMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim guess As String
        Dim printOut As String
        guess = Module1.guessWord
        If Module1.turnNumber = 0 Then

        Else
            For Each c As Char In Module1.guessWord.ToString
                If c.Equals(" ") Then
                    printOut += " "
                Else
                    printOut += "-"
                End If
            Next
            lblGuess.Text = printOut
        End If
    End Sub
End Class
