Imports System.Text

Public Class base64_encode
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RichTextBox2.Text = "" Then
        Else
            My.Computer.Clipboard.SetText(RichTextBox2.Text)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Dim originalString As String = RichTextBox1.Text
        Dim originalBytes As Byte() = Encoding.UTF8.GetBytes(originalString)
        Dim base64String As String = Convert.ToBase64String(originalBytes)
        RichTextBox2.Text = base64String
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        Dim originalString As String = RichTextBox1.Text
        Dim originalBytes As Byte() = Encoding.UTF8.GetBytes(originalString)
        Dim base64String As String = Convert.ToBase64String(originalBytes)
        RichTextBox2.Text = base64String
    End Sub

    Private Sub base64_encode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.lang.Text = "Russian" Then
            Me.Text = "Кодировать в base64"
            Button2.Text = "Закрывать"
            Button1.Text = "Копировать вывод"
            Label1.Text = "Вход:"
            Label2.Text = "Выход:"
        End If
        If Form1.lang.Text = "Japanese" Then
            Label2.Text = "出力："
            Label1.Text = "入力："
            Me.Text = "Base64にエンコードする"
            Button2.Text = "近い"
            Button1.Text = "出力のコピー"
        End If
    End Sub
End Class