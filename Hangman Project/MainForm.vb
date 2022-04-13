Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain
    Dim bodypart As Integer
    Dim gameOver As Boolean
    Dim reverseCheck As Boolean
    Public Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picBody.Hide()
        picHead.Hide()
        picLeft.Hide()
        picLLeft.Hide()
        picRight.Hide()
        picRLeg.Hide()
        Form3.Hide()

        gameOver = False
        reverseCheck = False

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

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If gameOver = True Then
            If Module1.scoreOne >= 100 Then
                MsgBox(Module1.playerOne + " WON the GAME!!!")
            ElseIf Module1.scoreTwo >= 100 Then
                MsgBox(Module1.playerTwo + " WON the GAME!!!")
            End If

            Form2.txtbPlayer1.Clear()
            Form2.txtbPlayer2.Clear()
            Form2.Show()
            Me.Close()
        Else
            Form3.Show()
            Me.Close()
        End If
    End Sub

    Public Sub btn_Click(sender As Object, e As EventArgs) Handles btnA.Click, btnB.Click, btnC.Click,
        btnD.Click, btnE.Click, btnF.Click, btnG.Click, btnH.Click, btnI.Click, btnJ.Click, btnK.Click,
        btnL.Click, btnM.Click, btnN.Click, btnO.Click, btnP.Click,
        btnQ.Click, btnR.Click, btnS.Click, btnT.Click, btnU.Click, btnV.Click, btnW.Click, btnX.Click, btnY.Click, btnZ.Click


        Dim btn As Button = CType(sender, Button)
        Dim letter As String = btn.Text
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
        'If count = 0 Then
        '    bodypart += 1
        '    If bodypart = 1 Then
        '        picHead.Show()
        '    ElseIf bodypart = 2 Then
        '        picBody.Show()
        '    ElseIf bodypart = 3 Then
        '        picRight.Show()
        '    ElseIf bodypart = 4 Then
        '        picLeft.Show()
        '    ElseIf bodypart = 5 Then
        '        picRLeg.Show()
        '    ElseIf bodypart = 6 Then
        '        picLLeft.Show()
        '        If Module1.turnName = 0 Then
        '            Module1.scoreTwo += Module1.guessWordPoints
        '            lblPlayer1Point.Text = Module1.playerOne + "'s points: " + Module1.scoreOne.ToString
        '            lblPlayer2Point.Text = Module1.playerTwo + "'s points: " + Module1.scoreTwo.ToString
        '            MsgBox(Module1.playerOne + " lost the round!")

        '            lblGuess.Text = Module1.guessWord

        '            ' This disables all buttons
        '            Dim ctrl As Control
        '            For Each ctrl In Me.Controls
        '                If TypeOf ctrl Is Button Then
        '                    ctrl.Enabled = False
        '                End If
        '            Next

        '            btnVeto.Enabled = True
        '            btnNext.Enabled = True

        '            If Module1.scoreOne >= 100 Then
        '                gameOver = True
        '            ElseIf Module1.scoreTwo >= 100 Then
        '                gameOver = True
        '            End If

        '        Else
        '            Module1.scoreOne += Module1.guessWordPoints
        '            lblPlayer1Point.Text = Module1.playerOne + "'s points: " + Module1.scoreOne.ToString
        '            lblPlayer2Point.Text = Module1.playerTwo + "'s points: " + Module1.scoreTwo.ToString
        '            MsgBox(Module1.playerTwo + " lost the round!")

        '            lblGuess.Text = Module1.guessWord

        '            ' This disables all buttons
        '            Dim ctrl As Control
        '            For Each ctrl In Me.Controls
        '                If TypeOf ctrl Is Button Then
        '                    ctrl.Enabled = False
        '                End If
        '            Next

        '            btnVeto.Enabled = True
        '            btnNext.Enabled = True

        '            If Module1.scoreOne >= 100 Then
        '                gameOver = True
        '            ElseIf Module1.scoreTwo >= 100 Then
        '                gameOver = True
        '            End If

        '        End If
        '    End If
        'End If


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

                ' This disables all buttons
                Dim ctrl As Control
                For Each ctrl In Me.Controls
                    If TypeOf ctrl Is Button Then
                        ctrl.Enabled = False
                    End If
                Next
                btnNext.Enabled = True

                If Module1.scoreOne >= 100 Then
                    gameOver = True
                ElseIf Module1.scoreTwo >= 100 Then
                    gameOver = True
                End If

            Else
                Module1.scoreTwo += Module1.guessWordPoints
                lblPlayer1Point.Text = Module1.playerOne + "'s points: " + Module1.scoreOne.ToString
                lblPlayer2Point.Text = Module1.playerTwo + "'s points: " + Module1.scoreTwo.ToString
                MsgBox(Module1.playerTwo + " won the round!")

                ' This disables all buttons
                Dim ctrl As Control
                For Each ctrl In Me.Controls
                    If TypeOf ctrl Is Button Then
                        ctrl.Enabled = False
                    End If
                Next
                btnNext.Enabled = True

                If Module1.scoreOne >= 100 Then
                    gameOver = True
                ElseIf Module1.scoreTwo >= 100 Then
                    gameOver = True
                End If

            End If
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

                    lblGuess.Text = Module1.guessWord

                    ' This disables all buttons
                    Dim ctrl As Control
                    For Each ctrl In Me.Controls
                        If TypeOf ctrl Is Button Then
                            ctrl.Enabled = False
                        End If
                    Next

                    btnVeto.Enabled = True
                    btnNext.Enabled = True

                    If Module1.scoreOne >= 100 Then
                        gameOver = True
                    ElseIf Module1.scoreTwo >= 100 Then
                        gameOver = True
                    End If

                Else
                    Module1.scoreOne += Module1.guessWordPoints
                    lblPlayer1Point.Text = Module1.playerOne + "'s points: " + Module1.scoreOne.ToString
                    lblPlayer2Point.Text = Module1.playerTwo + "'s points: " + Module1.scoreTwo.ToString
                    MsgBox(Module1.playerTwo + " lost the round!")

                    lblGuess.Text = Module1.guessWord

                    ' This disables all buttons
                    Dim ctrl As Control
                    For Each ctrl In Me.Controls
                        If TypeOf ctrl Is Button Then
                            ctrl.Enabled = False
                        End If
                    Next

                    btnVeto.Enabled = True
                    btnNext.Enabled = True

                    If Module1.scoreOne >= 100 Then
                        gameOver = True
                    ElseIf Module1.scoreTwo >= 100 Then
                        gameOver = True
                    End If

                End If
            End If
        End If

        btn.Enabled = False

    End Sub

    Private Sub btnVeto_Click(sender As Object, e As EventArgs) Handles btnVeto.Click
        If reverseCheck = False Then
            If Module1.turnName = 0 Then
                MsgBox("Reversing points because " + Module1.playerTwo + " can't spell lmfao")
                Module1.scoreOne += Module1.guessWordPoints
                Module1.scoreTwo -= Module1.guessWordPoints

                lblPlayer1Point.Text = Module1.playerOne + "'s points: " + Module1.scoreOne.ToString
                lblPlayer2Point.Text = Module1.playerTwo + "'s points: " + Module1.scoreTwo.ToString

                If Module1.scoreOne >= 100 Then
                    gameOver = True
                ElseIf Module1.scoreTwo >= 100 Then
                    gameOver = True
                End If

            ElseIf Module1.turnName = 1 Then
                MsgBox("Reversing points because " + Module1.playerOne + " can't spell lmfao")
                Module1.scoreTwo += Module1.guessWordPoints
                Module1.scoreOne -= Module1.guessWordPoints

                lblPlayer1Point.Text = Module1.playerOne + "'s points: " + Module1.scoreOne.ToString
                lblPlayer2Point.Text = Module1.playerTwo + "'s points: " + Module1.scoreTwo.ToString

                If Module1.scoreOne >= 100 Then
                    gameOver = True
                ElseIf Module1.scoreTwo >= 100 Then
                    gameOver = True
                End If

            End If
            reverseCheck = True
        End If
    End Sub
End Class
