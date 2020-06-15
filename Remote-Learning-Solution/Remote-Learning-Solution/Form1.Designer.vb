<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WeeklyReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblSubject = New System.Windows.Forms.Label()
        Me.rdbHss = New System.Windows.Forms.RadioButton()
        Me.rdmMathematics = New System.Windows.Forms.RadioButton()
        Me.rdbEnglish = New System.Windows.Forms.RadioButton()
        Me.rndScience = New System.Windows.Forms.RadioButton()
        Me.btnStartStop = New System.Windows.Forms.Button()
        Me.lblNxtSession = New System.Windows.Forms.Label()
        Me.lblNxtBreak = New System.Windows.Forms.Label()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.lblStop = New System.Windows.Forms.Label()
        Me.lblTimeNxtSession = New System.Windows.Forms.Label()
        Me.lblTimeNxtBreak = New System.Windows.Forms.Label()
        Me.lblStopTime = New System.Windows.Forms.Label()
        Me.lblStartTime = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(376, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WeeklyReportToolStripMenuItem})
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'WeeklyReportToolStripMenuItem
        '
        Me.WeeklyReportToolStripMenuItem.Name = "WeeklyReportToolStripMenuItem"
        Me.WeeklyReportToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.WeeklyReportToolStripMenuItem.Text = "Weekly Report"
        '
        'lblSubject
        '
        Me.lblSubject.AutoSize = True
        Me.lblSubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubject.Location = New System.Drawing.Point(8, 42)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(67, 20)
        Me.lblSubject.TabIndex = 1
        Me.lblSubject.Text = "Subject:"
        '
        'rdbHss
        '
        Me.rdbHss.AutoSize = True
        Me.rdbHss.Location = New System.Drawing.Point(12, 147)
        Me.rdbHss.Name = "rdbHss"
        Me.rdbHss.Size = New System.Drawing.Size(47, 17)
        Me.rdbHss.TabIndex = 2
        Me.rdbHss.TabStop = True
        Me.rdbHss.Text = "HSS"
        Me.rdbHss.UseVisualStyleBackColor = True
        '
        'rdmMathematics
        '
        Me.rdmMathematics.AutoSize = True
        Me.rdmMathematics.Location = New System.Drawing.Point(13, 76)
        Me.rdmMathematics.Name = "rdmMathematics"
        Me.rdmMathematics.Size = New System.Drawing.Size(85, 17)
        Me.rdmMathematics.TabIndex = 3
        Me.rdmMathematics.TabStop = True
        Me.rdmMathematics.Text = "Mathematics"
        Me.rdmMathematics.UseVisualStyleBackColor = True
        '
        'rdbEnglish
        '
        Me.rdbEnglish.AutoSize = True
        Me.rdbEnglish.Location = New System.Drawing.Point(12, 100)
        Me.rdbEnglish.Name = "rdbEnglish"
        Me.rdbEnglish.Size = New System.Drawing.Size(59, 17)
        Me.rdbEnglish.TabIndex = 4
        Me.rdbEnglish.TabStop = True
        Me.rdbEnglish.Text = "English"
        Me.rdbEnglish.UseVisualStyleBackColor = True
        '
        'rndScience
        '
        Me.rndScience.AutoSize = True
        Me.rndScience.Location = New System.Drawing.Point(12, 124)
        Me.rndScience.Name = "rndScience"
        Me.rndScience.Size = New System.Drawing.Size(64, 17)
        Me.rndScience.TabIndex = 5
        Me.rndScience.TabStop = True
        Me.rndScience.Text = "Science"
        Me.rndScience.UseVisualStyleBackColor = True
        '
        'btnStartStop
        '
        Me.btnStartStop.Location = New System.Drawing.Point(12, 201)
        Me.btnStartStop.Name = "btnStartStop"
        Me.btnStartStop.Size = New System.Drawing.Size(91, 48)
        Me.btnStartStop.TabIndex = 6
        Me.btnStartStop.Text = "Start"
        Me.btnStartStop.UseVisualStyleBackColor = True
        '
        'lblNxtSession
        '
        Me.lblNxtSession.AutoSize = True
        Me.lblNxtSession.Location = New System.Drawing.Point(177, 78)
        Me.lblNxtSession.Name = "lblNxtSession"
        Me.lblNxtSession.Size = New System.Drawing.Size(83, 13)
        Me.lblNxtSession.TabIndex = 7
        Me.lblNxtSession.Text = "Next Session in:"
        '
        'lblNxtBreak
        '
        Me.lblNxtBreak.AutoSize = True
        Me.lblNxtBreak.Location = New System.Drawing.Point(186, 102)
        Me.lblNxtBreak.Name = "lblNxtBreak"
        Me.lblNxtBreak.Size = New System.Drawing.Size(74, 13)
        Me.lblNxtBreak.TabIndex = 8
        Me.lblNxtBreak.Text = "Next Break in:"
        '
        'lblStart
        '
        Me.lblStart.AutoSize = True
        Me.lblStart.Location = New System.Drawing.Point(202, 210)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(58, 13)
        Me.lblStart.TabIndex = 9
        Me.lblStart.Text = "Start Time:"
        '
        'lblStop
        '
        Me.lblStop.AutoSize = True
        Me.lblStop.Location = New System.Drawing.Point(202, 236)
        Me.lblStop.Name = "lblStop"
        Me.lblStop.Size = New System.Drawing.Size(58, 13)
        Me.lblStop.TabIndex = 10
        Me.lblStop.Text = "Stop Time:"
        '
        'lblTimeNxtSession
        '
        Me.lblTimeNxtSession.AutoSize = True
        Me.lblTimeNxtSession.Location = New System.Drawing.Point(266, 76)
        Me.lblTimeNxtSession.Name = "lblTimeNxtSession"
        Me.lblTimeNxtSession.Size = New System.Drawing.Size(43, 13)
        Me.lblTimeNxtSession.TabIndex = 11
        Me.lblTimeNxtSession.Text = "______"
        '
        'lblTimeNxtBreak
        '
        Me.lblTimeNxtBreak.AutoSize = True
        Me.lblTimeNxtBreak.Location = New System.Drawing.Point(266, 104)
        Me.lblTimeNxtBreak.Name = "lblTimeNxtBreak"
        Me.lblTimeNxtBreak.Size = New System.Drawing.Size(43, 13)
        Me.lblTimeNxtBreak.TabIndex = 12
        Me.lblTimeNxtBreak.Text = "______"
        '
        'lblStopTime
        '
        Me.lblStopTime.AutoSize = True
        Me.lblStopTime.Location = New System.Drawing.Point(266, 236)
        Me.lblStopTime.Name = "lblStopTime"
        Me.lblStopTime.Size = New System.Drawing.Size(43, 13)
        Me.lblStopTime.TabIndex = 13
        Me.lblStopTime.Text = "______"
        '
        'lblStartTime
        '
        Me.lblStartTime.AutoSize = True
        Me.lblStartTime.Location = New System.Drawing.Point(266, 210)
        Me.lblStartTime.Name = "lblStartTime"
        Me.lblStartTime.Size = New System.Drawing.Size(43, 13)
        Me.lblStartTime.TabIndex = 14
        Me.lblStartTime.Text = "______"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 317)
        Me.Controls.Add(Me.lblStartTime)
        Me.Controls.Add(Me.lblStopTime)
        Me.Controls.Add(Me.lblTimeNxtBreak)
        Me.Controls.Add(Me.lblTimeNxtSession)
        Me.Controls.Add(Me.lblStop)
        Me.Controls.Add(Me.lblStart)
        Me.Controls.Add(Me.lblNxtBreak)
        Me.Controls.Add(Me.lblNxtSession)
        Me.Controls.Add(Me.btnStartStop)
        Me.Controls.Add(Me.rndScience)
        Me.Controls.Add(Me.rdbEnglish)
        Me.Controls.Add(Me.rdmMathematics)
        Me.Controls.Add(Me.rdbHss)
        Me.Controls.Add(Me.lblSubject)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Remote Learning System"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WeeklyReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblSubject As Label
    Friend WithEvents rdbHss As RadioButton
    Friend WithEvents rdmMathematics As RadioButton
    Friend WithEvents rdbEnglish As RadioButton
    Friend WithEvents rndScience As RadioButton
    Friend WithEvents btnStartStop As Button
    Friend WithEvents lblNxtSession As Label
    Friend WithEvents lblNxtBreak As Label
    Friend WithEvents lblStart As Label
    Friend WithEvents lblStop As Label
    Friend WithEvents lblTimeNxtSession As Label
    Friend WithEvents lblTimeNxtBreak As Label
    Friend WithEvents lblStopTime As Label
    Friend WithEvents lblStartTime As Label
End Class
