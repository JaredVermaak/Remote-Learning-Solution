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
        Me.lblEndOfSession = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtWhatYouLearned = New System.Windows.Forms.TextBox()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblEndOfSession
        '
        Me.lblEndOfSession.AutoSize = True
        Me.lblEndOfSession.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndOfSession.Location = New System.Drawing.Point(61, 9)
        Me.lblEndOfSession.Name = "lblEndOfSession"
        Me.lblEndOfSession.Size = New System.Drawing.Size(175, 29)
        Me.lblEndOfSession.TabIndex = 0
        Me.lblEndOfSession.Text = "End of Session"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "What is one thing you learned this session:"
        '
        'txtWhatYouLearned
        '
        Me.txtWhatYouLearned.Location = New System.Drawing.Point(48, 54)
        Me.txtWhatYouLearned.Multiline = True
        Me.txtWhatYouLearned.Name = "txtWhatYouLearned"
        Me.txtWhatYouLearned.Size = New System.Drawing.Size(205, 58)
        Me.txtWhatYouLearned.TabIndex = 2
        '
        'btnContinue
        '
        Me.btnContinue.Location = New System.Drawing.Point(111, 118)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(75, 23)
        Me.btnContinue.TabIndex = 3
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 154)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.txtWhatYouLearned)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblEndOfSession)
        Me.Name = "Form2"
        Me.Text = "End Of Session"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblEndOfSession As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtWhatYouLearned As TextBox
    Friend WithEvents btnContinue As Button
End Class
