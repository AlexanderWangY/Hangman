Public Class frmMain
    Dim bodypart As Integer
    Public Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picBody.Hide()
        picHead.Hide()
        picLeft.Hide()
        picLLeft.Hide()
        picRight.Hide()
        picRLeg.Hide()
        Form3.Hide()

        lblPlayer1Point.Text = Module1.playerOne + "'s points: " + Module1.scoreOne.ToString
        lblPlayer2Point.Text = Module1.playerTwo + "'s points: " + Module1.scoreTwo.ToString

        If Module1.normal = False Then
            Module1.guessWordPoints *= 2
        End If

        bodypart = 0

        lblGuess.Text = String.Empty

        For Each c As Char In Module1.guessWord

            If c = " " Then
                lblGuess.Text += " "
            Else
                lblGuess.Text += "-"
            End If
        Next
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Form3.Show()
        Me.Close()
    End Sub

    Public Sub btn_Click(sender As Object, e As EventArgs) Handles btnA.Click, btnB.Click, btnC.Click,
        btnD.Click, btnE.Click, btnF.Click, btnG.Click, btnH.Click, btnI.Click, btnJ.Click, btnK.Click,
        btnL.Click, btnM.Click, btnN.Click, btnO.Click, btnP.Click,
        btnQ.Click, btnR.Click, btnS.Click, btnT.Click, btnU.Click, btnV.Click, btnW.Click, btnX.Click, btnY.Click, btnZ.Click


        Dim btn As Button = CType(sender, Button)
        Dim letter As Char = btn.Text
        Dim count As Integer = 0
        If Module1.guessWord.Contains(letter) Then
            For x As Integer = 0 To Module1.guessWord.Length - 1
                If Module1.guessWord(x) = letter Then
                    lblGuess.Text = lblGuess.Text.Remove(x, 1)
                    lblGuess.Text = lblGuess.Text.Insert(x, letter)
                End If
            Next
            count += 1
        End If
        If count = 0 Then
            bodypart += 1
            If bodypart = 1 Then
                picHead.Show()
            ElseIf bodypart = 2 Then
                picBody.Show()
            ElseIf bodypart = 3 Then
                picRight.Show()
            ElseIf bodypart = 4 Then
                picLeft.Show()
            ElseIf bodypart = 5 Then
                picRLeg.Show()
            ElseIf bodypart = 6 Then
                picLLeft.Show()
                If Module1.turnName = 0 Then
                    Module1.scoreTwo += Module1.guessWordPoints
                    lblPlayer1Point.Text = Module1.playerOne + "'s points: " + Module1.scoreOne.ToString
                    lblPlayer2Point.Text = Module1.playerTwo + "'s points: " + Module1.scoreTwo.ToString
                    MsgBox(Module1.playerOne + " lost the round!")
                Else
                    Module1.scoreOne += Module1.guessWordPoints
                    lblPlayer1Point.Text = Module1.playerOne + "'s points: " + Module1.scoreOne.ToString
                    lblPlayer2Point.Text = Module1.playerTwo + "'s points: " + Module1.scoreTwo.ToString
                    MsgBox(Module1.playerTwo + " lost the round!")
                End If
            End If
        End If


        Dim checkFinish As Integer = 0
        For Each c As Char In lblGuess.Text
            If c = "-" Then
                checkFinish += 1
            End If
        Next

        If checkFinish = 0 Then
            If Module1.turnName = 0 Then
                Module1.scoreOne += Module1.guessWordPoints
                lblPlayer1Point.Text = Module1.playerOne + "'s points: " + Module1.scoreOne.ToString
                lblPlayer2Point.Text = Module1.playerTwo + "'s points: " + Module1.scoreTwo.ToString
                MsgBox(Module1.playerOne + " won the round!")
            Else
                Module1.scoreTwo += Module1.guessWordPoints
                lblPlayer1Point.Text = Module1.playerOne + "'s points: " + Module1.scoreOne.ToString
                lblPlayer2Point.Text = Module1.playerTwo + "'s points: " + Module1.scoreTwo.ToString
                MsgBox(Module1.playerTwo + " won the round!")
            End If

            Form3.Show()
            Me.Close()
        End If

        btn.Enabled = False

    End Sub
End Class
