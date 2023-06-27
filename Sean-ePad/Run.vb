Public Class Run
    Private Sub Run_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.lang.Text = "Afrikaans" Then
            Label1.Text = "Tik die naam van 'n program, gids, dokument of internet in
hulpbron, en Sean-ePad sal dit vir jou oopmaak."
            Button2.Text = "Kanselleer"
        End If
        If Form1.lang.Text = "Japanese" Then
            Button3.Text = "OK"
            Button2.Text = "キャンセル"
            Label1.Text = "プログラム、フォルダー、ドキュメント、またはインターネットの名前を入力します
リソースを開くと、Sean-ePad がそれを開きます。"
            Button1.Text = "ブラウズ..."
            Label2.Text = "開ける："
            Me.Text = "走る"
        End If
        If Form1.lang.Text = "Russian" Then
            Button2.Text = "Отмена"
            Button1.Text = "Просматривать..."
            Label1.Text = "Введите имя программы, папки, документа или Интернета.
ресурс, и Sean-ePad откроет его для вас."
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            Button3.Enabled = False
        Else
            Button3.Enabled = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Process.Start(TextBox1.Text)
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            TextBox1.Text = OpenFileDialog1.FileName
        End If
    End Sub
End Class