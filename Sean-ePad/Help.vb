Public Class Help
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ListBox1.SelectedItem.ToString = "Sean-ePad Help Under Construction" Then
            RichTextBox1.Text = "Help unavaliable!

The Help application is under construction and most help toppics are
currently unavaliable.

If you need help with this program, please post
on the Sean-e Forums."
        End If
        If ListBox1.SelectedItem.ToString = "New Window doesn't work" Then
            RichTextBox1.Text = "When clicking New Window (or CTRL+SHIFT+N) and no window appears, this is because the exe was renamed.

For the New Window function to work, the exe must be named 'Sean-ePad.exe' or 'Sean-ePad <version>.exe"
        End If
        If ListBox1.SelectedItem.ToString = "Saving files" Then
            RichTextBox1.Text = "Currently, to save a file, you have to do CTRL+SHIFT+S and overwrite the file.

I'm currently trying to find a way to have CTRL+S do this automatically, but that will come in a future update.

Sorry about that!"

        End If
        If ListBox1.SelectedItem.ToString = "Printing" Then
            RichTextBox1.Text = "How to print in Sean-ePad.

To print, press CTRL+P or go to File > Print. As of now, it only prints in Black & White from what I've tested (even with colored text). It cannot print images, it will simply ignore them.

To view the page preview, press CTRL+SHIFT+P or go to File > Open Print Preview. You can print from this dialog, too, but you don't choose the printer (I think it uses the most recent but I'm not sure)."

        End If
    End Sub

    Private Sub Help_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.lang.Text = "English" Then
            Label2.Text = "Topics:"
            TextBox1.Text = "Search under construction!"
            Button1.Text = "View"
            Button2.Text = "Exit"
            RichTextBox1.Text = "No help topic selected"
            Label1.Text = "For help, click a help topic on the left and click 'View'."
        End If
        If Form1.lang.Text = "Afrikaans" Then
            Label2.Text = "Onderwerpe:"
            TextBox1.Text = "Soek onder konstruksie!"
            Button1.Text = "Beskou"
            Button2.Text = "Verlaat"
            RichTextBox1.Text = "Geen hulponderwerp gekies nie"
            Label1.Text = "Vir hulp, klik 'n onderwerp aan die linkerkant en klik 'Bekyk'."
        End If
        If Form1.lang.Text = "Albanian" Then
            LinkLabel1.Text = "Kërko"
            Me.Text = "Sean-ePad Ndihmë"
            TextBox1.Text = "Kërkoni në ndërtim!"
        End If
    End Sub
End Class