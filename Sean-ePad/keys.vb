Public Class keys
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub keys_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.lang.Text = "English" Then
            Me.Text = "Shortcut Keys"
            Button1.Text = "Close"
        End If
        If Form1.lang.Text = "Afrikaans" Then
            Me.Text = "Kortpadsleutels"
            Button1.Text = "Naby"
        End If
        If Form1.lang.Text = "Albanian" Then
            Me.Text = "Tastet e shkurtoreve"
            Form1.Text = "Mbylle"
        End If
    End Sub
End Class