Public Class settingsinfo
    Private Sub settingsinfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.setinfoclosedetector.Text = "N"
    End Sub

    Private Sub settingsinfo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If (e.CloseReason = CloseReason.UserClosing) Then
            Form1.setinfoclosedetector.Text = "Y"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class