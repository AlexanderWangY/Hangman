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

    Private Sub frmMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown
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
            MsgBox("FOUND")
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
            Select Case bodypart
                Case 1
                    picHead.Visible = True
                Case 2
                    picBody.Visible = True
                Case 3
                    picRight.Visible = True
                Case 4
                    picLeft.Visible = True
                Case 5
                    picRLeg.Visible = True
                Case 6
                    picLLeft.Visible = True
            End Select
        End If


        Dim checkFinish As Integer = 0
        For Each c As Char In lblGuess.Text
            If c = "-" Then
                checkFinish += 1
            End If
        Next

        If checkFinish = 0 Then
            If Module1.turnName = 0 Then
                MsgBox(Module1.playerOne + " won!")
            Else
                MsgBox(Module1.playerTwo + " won!")
            End If
        End If

        btn.Enabled = False

    End Sub
End Class
