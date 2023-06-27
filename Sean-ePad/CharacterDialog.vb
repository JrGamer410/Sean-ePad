Imports System.ComponentModel.Design

Public Class CharacterDialog
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.RichTextBox1.Text &= ListBox1.SelectedItem
    End Sub

    Private Sub CharacterDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.lang.Text = "English" Then
            Me.Text = "Character Dialog"
            Button1.Text = "Copy"
            Button2.Text = "Insert"
            Button4.Text = "Exit"
            Button3.Text = "Help"
            Label1.Text = "Choose a character:"
        End If
        If Form1.lang.Text = "Afrikaans" Then
            Me.Text = "Karakter Dialoog"
            Button1.Text = "Kopieer"
            Button2.Text = "Voeg in"
            Button4.Text = "Verlaat"
            Label1.Text = "Kies 'n karakter:"
        End If
        If Form1.lang.Text = "Albanian" Then
            Me.Text = "Dialogu i personazheve"
            Button1.Text = "Kopjo"
            Button2.Text = "Fut"
            Button3.Text = "Ndihmë"
            Button4.Text = "Dilni"
            Label1.Text = "Zgjidhni një personazh:"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Clipboard.SetText(ListBox1.SelectedItem)
    End Sub
End Class