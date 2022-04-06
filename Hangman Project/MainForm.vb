Public Class frmMain

    Dim array As ArrayList(Of Char) = {"!"}
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picBody.Hide()
        picHead.Hide()
        picLeft.Hide()
        picLLeft.Hide()
        picRight.Hide()
        picRLeg.Hide()
        Form3.Hide()

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

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btnA.Click, btnB.Click, btnC.Click,
        btnD.Click, btnE.Click, btnF.Click, btnG.Click, btnH.Click, btnI.Click, btnJ.Click, btnK.Click,
        btnL.Click, btnM.Click, btnN.Click, btnO.Click, btnP.Click,
        btnQ.Click, btnR.Click, btnS.Click, btnT.Click, btnU.Click, btnV.Click, btnW.Click, btnX.Click, btnY.Click, btnZ.Click


        Dim btn As Button = CType(sender, Button)
        lblGuess.Text = String.Empty

        For Each c As Char In Module1.guessWord

            If c = " " Then
                lblGuess.Text += " "
            ElseIf array.Contains(c.ToString) Then
                lblGuess.Text += c
            ElseIf c = btn.Text Then
                lblGuess.Text += btn.Text
            Else
                lblGuess.Text += "-"
            End If
        Next
        array.Add(btn.Text)
    End Sub
End Class
