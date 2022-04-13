<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbPlayer1 = New System.Windows.Forms.TextBox()
        Me.txtbPlayer2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnLetsGo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(140, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Player 1's Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(140, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Player 2's Name:"
        '
        'txtbPlayer1
        '
        Me.txtbPlayer1.Location = New System.Drawing.Point(84, 89)
        Me.txtbPlayer1.Name = "txtbPlayer1"
        Me.txtbPlayer1.Size = New System.Drawing.Size(195, 20)
        Me.txtbPlayer1.TabIndex = 2
        Me.txtbPlayer1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtbPlayer2
        '
        Me.txtbPlayer2.Location = New System.Drawing.Point(84, 128)
        Me.txtbPlayer2.Name = "txtbPlayer2"
        Me.txtbPlayer2.Size = New System.Drawing.Size(195, 20)
        Me.txtbPlayer2.TabIndex = 3
        Me.txtbPlayer2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(96, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 26)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Hangman Game"
        '
        'btnLetsGo
        '
        Me.btnLetsGo.Location = New System.Drawing.Point(146, 163)
        Me.btnLetsGo.Name = "btnLetsGo"
        Me.btnLetsGo.Size = New System.Drawing.Size(75, 23)
        Me.btnLetsGo.TabIndex = 5
        Me.btnLetsGo.Text = "Let's Go"
        Me.btnLetsGo.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 230)
        Me.Controls.Add(Me.btnLetsGo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtbPlayer2)
        Me.Controls.Add(Me.txtbPlayer1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbPlayer1 As TextBox
    Friend WithEvents txtbPlayer2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnLetsGo As Button
End Class
