Public Class CloseMe
    Private Sub CloseMe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.lang.Text = "English" Then
            Label1.Text = "Please wait while Sean-ePad exits..."
            Me.Text = "Please wait..."
        End If
        If Form1.lang.Text = "Afrikaans" Then
            Label1.Text = "Wag asseblief terwyl Sean-ePad uitgaan..."
            Me.Text = "Wag asseblief..."
        End If
        If Form1.lang.Text = "Albanian" Then
            Label1.Text = "Ju lutemi prisni derisa Sean-ePad të dalë..."
            Me.Text = "Te lutem prit..."
        End If
        Form1.Show()
    End Sub
End Class