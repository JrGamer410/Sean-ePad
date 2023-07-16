Imports System.IO

Public Class Settings
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim file As System.IO.StreamWriter
        Dim appDataPath2 As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
        Dim filePath2 As String = Path.Combine(appDataPath2, "Sean-ePad\nofeaturealerts")
        Dim appDataPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
        Dim filePath As String = Path.Combine(appDataPath, "Sean-ePad\showdebug")
        Dim appDataPath3 As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
        Dim filePath3 As String = Path.Combine(appDataPath3, "Sean-ePad\wordcount")

        If nofeaturealerts.Checked = True Then
            Directory.CreateDirectory(Path.GetDirectoryName(filePath2))
            file = My.Computer.FileSystem.OpenTextFileWriter(filePath2, True)
            file.WriteLine("")
            file.Close()
        Else
            If System.IO.File.Exists(filePath2) Then
                My.Computer.FileSystem.DeleteFile(filePath2)
            End If
        End If
        If word_count.Checked = True Then
            Directory.CreateDirectory(Path.GetDirectoryName(filePath3))
            file = My.Computer.FileSystem.OpenTextFileWriter(filePath3, True)
            file.WriteLine("")
            file.Close()
            Form1.WordCount0ToolStripMenuItem.Visible = True
        Else
            If System.IO.File.Exists(filePath3) Then
                My.Computer.FileSystem.DeleteFile(filePath2)
            End If
            Form1.WordCount0ToolStripMenuItem.Visible = False
        End If
        If debug_enable.Checked = True Then

            Try
                Directory.CreateDirectory(Path.GetDirectoryName(filePath))
                File = My.Computer.FileSystem.OpenTextFileWriter(filePath, True)
                File.WriteLine("")
                File.Close()
                Form1.lang.Visible = True
                Form1.setinfoclosedetector.Visible = True
            Catch ex As Exception
                MsgBox("An error has occurred while trying to save the settings you've applied. Try again later or report an issue on the GitHub page. The error is: " & ex.Message, 0 + 16, "Error!")
            End Try
        Else
            Form1.lang.Visible = False
            Form1.setinfoclosedetector.Visible = False
            If System.IO.File.Exists(filepath) Then
                My.Computer.FileSystem.DeleteFile(filePath)
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
        Dim appDataPath_ru As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
        Dim filePath_ru As String = Path.Combine(appDataPath_ru, "Sean-ePad\russian")
        Dim appDataPath_jp As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
        Dim filePath_jp As String = Path.Combine(appDataPath_jp, "Sean-ePad\japanese")
        Dim file As System.IO.StreamWriter
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
            Run.Label1.Text = "Type the name of a program, folder, document, or Internet
resource, and Sean-ePad will open it for you."
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
            Run.Label1.Text = "Tik die naam van 'n program, gids, dokument of internet in
hulpbron, en Sean-ePad sal dit vir jou oopmaak."
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
        If ComboBox1.Text = "Japanese" Then
            Form1.lang.Text = "Japanese"
            Me.Text = "設定"
            Button2.Text = "OK"
            Button1.Text = "キャンセル"
            Form1.NewToolStripMenuItem.Text = "新しい"
            file = My.Computer.FileSystem.OpenTextFileWriter(filePath_ru, True)
            file.WriteLine("")
            file.Close()
        End If
        If ComboBox1.Text = "Russian" Then
            Form1.lang.Text = "Russian"
            file = My.Computer.FileSystem.OpenTextFileWriter(filePath_jp, True)
            file.WriteLine("")
            file.Close()
        End If
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim appDataPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
        Dim filePath As String = Path.Combine(appDataPath, "Sean-ePad\showdebug")
        Dim appDataPath2 As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
        Dim filePath2 As String = Path.Combine(appDataPath2, "Sean-ePad\nofeaturealerts")
        Dim appDataPath3 As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
        Dim filePath3 As String = Path.Combine(appDataPath3, "Sean-ePad\wordcount")
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
        If Form1.lang.Text = "Japanese" Then
            Me.Text = "設定"
            Button2.Text = "OK"
            Button1.Text = "キャンセル"
        End If
        If System.IO.File.Exists(filePath2) Then
            nofeaturealerts.Checked = True
        End If
        If System.IO.File.Exists(filePath) Then
            debug_enable.Checked = True
        End If
        If System.IO.File.Exists(filePath3) Then
            word_count.Checked = True
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles nofeaturealerts.CheckedChanged

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        settingsinfo.Show()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub debug_enable_CheckedChanged(sender As Object, e As EventArgs) Handles debug_enable.CheckedChanged

    End Sub

    Private Sub CheckBox2_CheckedChanged_1(sender As Object, e As EventArgs) Handles word_count.CheckedChanged

    End Sub
End Class