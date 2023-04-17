Public Class Settings
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If nofeaturealerts.Checked = True Then
            System.IO.File.Create("nofeaturealerts")
        Else
            If System.IO.File.Exists("nofeaturealerts") Then
                My.Computer.FileSystem.DeleteFile("nofeaturealerts")
            End If
        End If
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If FontDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            Label2.Font = FontDialog1.Font
            Button2.Font = FontDialog1.Font
            Button1.Font = FontDialog1.Font
            Button3.Font = FontDialog1.Font
            Me.Font = FontDialog1.Font
            About.Button1.Font = FontDialog1.Font
            Form1.Font = FontDialog1.Font
            Form1.MenuStrip1.Font = FontDialog1.Font
            About.Label1.Font = FontDialog1.Font
            About.LinkLabel1.Font = FontDialog1.Font
            Label5.Font = FontDialog1.Font
            Label4.Font = FontDialog1.Font
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "English" Then
            Form1.lang.Text = "English"
            Label2.Text = "Text Color:"
            Button2.Text = "OK"
            Button1.Text = "Cancel"
            Me.Text = "Settings"
            About.Button1.Text = "OK"
            Form1.Text = "Sean-ePad"
            Form1.MenuStrip1.Text = ""
            Button1.Text = "Cancel"
            About.LinkLabel1.Text = "here"
            CloseMe.Label1.Text = "Please wait while Sean-ePad exits..."
            nofeaturealerts.Text = "Don't show feature alerts"
            Button4.Text = "Change..."
            Button5.Text = "Change..."
            Label5.Text = "Language:"
            Form1.NewWindowToolStripMenuItem.Text = "New Window"
            Form1.NewToolStripMenuItem.Text = "New"
            Form1.SettingsToolStripMenuItem.Text = "Settings"
        End If
        If ComboBox1.Text = "Afrikaans" Then
            Form1.lang.Text = "Afrikaans"
            CloseMe.Label1.Text = "Wag asseblief terwyl Sean-ePad uitgaan..."
            Button1.Text = "Kanselleer"
            nofeaturealerts.Text = "Moenie kenmerkwaarskuwings wys nie"
            Me.Text = "Instellings"
            About.LinkLabel1.Text = "hier"
            Button4.Text = "Verander..."
            Button5.Text = "Verander..."
            Label5.Text = "Taal:"
            Label2.Text = "Tekskleur:"
            Form1.NewToolStripMenuItem.Text = "Nuut"
            Form1.NewWindowToolStripMenuItem.Text = "Nuwe venster"
            Form1.SettingsToolStripMenuItem.Text = "Instellings"
        End If
        If ComboBox1.Text = "Albanian" Then
            Form1.lang.Text = "Albanian"
            Label2.Text = "Ngjyra e tekstit:"
            Me.Text = "Cilësimet"
            Button2.Text = "Anulo"
            nofeaturealerts.Text = "Mos shfaq sinjalizimet e veçorive"
            Form1.NewToolStripMenuItem.Text = "I ri"
            Form1.NewWindowToolStripMenuItem.Text = "Dritare e re"
            Form1.SettingsToolStripMenuItem.Text = "Cilësimet"
            Button1.Text = "Anulo"
        End If
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'If Form1.setinfoclosedetector.Text = "Y" Then
        'CheckBox1.Enabled = False
        'nofeaturealerts.Enabled = False
        'Button5.Enabled = False
        'Label6.Visible = True
        'LinkLabel1.Visible = True
        'Label7.Visible = True
        'If settingsinfo.warn1.Text = "1" Then
        'nofeaturealerts.Checked = True
        'End If
        'End If
        If Form1.lang.Text = "English" Then
            Form1.lang.Text = "English"
            Label2.Text = ""
            Button2.Text = "OK"
            Button1.Text = ""
            Me.Text = "Settings"
            About.Button1.Text = "OK"
            Form1.Text = "Sean-ePad"
            Form1.MenuStrip1.Text = ""
            Button1.Text = "Cancel"
            About.LinkLabel1.Text = "here"
            CloseMe.Label1.Text = "Please wait while Sean-ePad exits..."
            nofeaturealerts.Text = "Don't show feature alerts"
            Button4.Text = "Change..."
            Button5.Text = "Change..."
        End If
        If Form1.lang.Text = "Afrikaans" Then
            Form1.lang.Text = "Afrikaans"
            CloseMe.Label1.Text = "Wag asseblief terwyl Sean-ePad uitgaan..."
            Button1.Text = "Kanselleer"
            nofeaturealerts.Text = "Moenie kenmerkwaarskuwings wys nie"
            Me.Text = "Instellings"
            About.LinkLabel1.Text = "hier"
            Button4.Text = "Verander..."
            Button5.Text = "Verander..."
        End If
        If System.IO.File.Exists("nofeaturealerts") Then
            nofeaturealerts.Checked = True
        Else
            nofeaturealerts.Checked = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles nofeaturealerts.CheckedChanged

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        settingsinfo.Show()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub
End Class