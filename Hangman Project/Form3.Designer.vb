<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.txtbWord = New System.Windows.Forms.TextBox()
        Me.lblTurn = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.rdbNormal = New System.Windows.Forms.RadioButton()
        Me.rdbDouble = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(88, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter in a word:"
        '
        'txtbWord
        '
        Me.txtbWord.Location = New System.Drawing.Point(166, 74)
        Me.txtbWord.Name = "txtbWord"
        Me.txtbWord.Size = New System.Drawing.Size(259, 20)
        Me.txtbWord.TabIndex = 1
        '
        'lblTurn
        '
        Me.lblTurn.AutoSize = True
        Me.lblTurn.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTurn.Location = New System.Drawing.Point(210, 9)
        Me.lblTurn.Name = "lblTurn"
        Me.lblTurn.Size = New System.Drawing.Size(111, 28)
        Me.lblTurn.TabIndex = 2
        Me.lblTurn.Text = "___'s Turn"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(220, 158)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 3
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'rdbNormal
        '
        Me.rdbNormal.AutoSize = True
        Me.rdbNormal.Location = New System.Drawing.Point(198, 114)
        Me.rdbNormal.Name = "rdbNormal"
        Me.rdbNormal.Size = New System.Drawing.Size(58, 17)
        Me.rdbNormal.TabIndex = 4
        Me.rdbNormal.TabStop = True
        Me.rdbNormal.Text = "Normal"
        Me.rdbNormal.UseVisualStyleBackColor = True
        '
        'rdbDouble
        '
        Me.rdbDouble.AutoSize = True
        Me.rdbDouble.Location = New System.Drawing.Point(262, 114)
        Me.rdbDouble.Name = "rdbDouble"
        Me.rdbDouble.Size = New System.Drawing.Size(59, 17)
        Me.rdbDouble.TabIndex = 5
        Me.rdbDouble.TabStop = True
        Me.rdbDouble.Text = "Double"
        Me.rdbDouble.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 214)
        Me.Controls.Add(Me.rdbDouble)
        Me.Controls.Add(Me.rdbNormal)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblTurn)
        Me.Controls.Add(Me.txtbWord)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtbWord As TextBox
    Friend WithEvents lblTurn As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents rdbNormal As RadioButton
    Friend WithEvents rdbDouble As RadioButton
End Class
