Public Class About
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Shell("start msedge https://srjamis.wixsite.com/seane/sean-epad")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("msinfo32")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Process.Start("dxdiag")
    End Sub

    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.lang.Text = "English" Then
            Me.Text = "About Sean-ePad"
            Button2.Text = "System Info"
        End If
        If Form1.lang.Text = "Afrikaans" Then
            Me.Text = "Oor Sean-ePad"
            Button2.Text = "Stelselinligting"
        End If
    End Sub
End Class