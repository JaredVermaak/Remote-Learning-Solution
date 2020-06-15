Public Class Form1
    Dim StartTime As Integer
    Dim StopTime As Integer

    Dim arr

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnStartStop_Click(sender As Object, e As EventArgs) Handles btnStartStop.Click
        If btnStartStop.Text = "Start" Then
            btnStartStop.Text = "Stop"
        ElseIf btnStartStop.Text = "Stop" Then
            btnStartStop.Text = "Start"
        End If
    End Sub
End Class
