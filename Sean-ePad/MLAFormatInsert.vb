Public Class MLAFormatInsert
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If RadioButton1.Checked = True Then
            Form1.RichTextBox1.Text &= TextBox1.Text
            Form1.RichTextBox1.Text &= " , "
            Form1.RichTextBox1.Text &= TextBox2.Text
            Form1.RichTextBox1.Text &= ". "
            Form1.RichTextBox1.Text &= TextBox3.Text
            Me.Close()
        Else
            Form1.RichTextBox1.Text &= "    "
            Form1.RichTextBox1.Text &= TextBox4.Text
            Form1.RichTextBox1.Text &= ": "
            Form1.RichTextBox1.Text &= TextBox5.Text
            Form1.RichTextBox1.Text &= " "
            Form1.RichTextBox1.Text &= NumericUpDown1.Value
            Me.Close()
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            NumericUpDown1.Enabled = True
            TextBox4.Enabled = True
            TextBox5.Enabled = True
        Else
            NumericUpDown1.Enabled = False
            TextBox4.Enabled = False
            TextBox5.Enabled = False
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            TextBox1.Enabled = True
            TextBox2.Enabled = True
            TextBox3.Enabled = True
        Else
            TextBox1.Enabled = False
            TextBox2.Enabled = False
            TextBox3.Enabled = False
        End If
    End Sub
End Class