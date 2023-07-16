Imports System.IO

Public Class whatsnew
    Private Sub whatsnew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.lang.Text = "Japanese" Then
            CheckBox1.Text = "Sean-ePad が起動するたびにこれを表示します"
            Button1.Text = "近い"
            Me.Text = "新着情報"
            Label1.Text = "Sean-ePad v1.7 で導入された新機能:"
        End If
        If Form1.lang.Text = "Russian" Then
            Label1.Text = "Новые функции, представленные в Sean-ePad v1.7:"
            Button1.Text = "Закрывать"
            Me.Text = "Что нового"
            CheckBox1.Text = "Показывать это каждый раз при запуске Sean-ePad"
            RichTextBox1.Text = "- Поддержка японского языка
- Что нового в диалоговом окне
- Настройки теперь сохраняются в папку AppData
- Поддержка русского языка"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Dim appDataPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
        Dim filePath As String = Path.Combine(appDataPath, "Sean-ePad\no_new_dialog")
        Directory.CreateDirectory(Path.GetDirectoryName(filePath))
        If CheckBox1.Checked = True Then
            If System.IO.File.Exists(filePath) Then
                My.Computer.FileSystem.DeleteFile(filePath)
            End If
        Else
            Dim file As System.IO.StreamWriter
            file = My.Computer.FileSystem.OpenTextFileWriter(filePath, True)
            file.WriteLine("")
            file.Close()
        End If
    End Sub
End Class