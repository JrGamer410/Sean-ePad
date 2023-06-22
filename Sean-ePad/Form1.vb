Imports System.IO
Public Class Form1
    Dim current_file As String
    Dim draft As String
    Dim s_file As String
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        RichTextBox1.Text = ""
        Me.Text = "Sean-ePad"
        current_file = ""
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim dialog3 As DialogResult
        dialog3 = MessageBox.Show("Do you want to save your current file?", "Sean-ePad", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If dialog3 = DialogResult.No Then
            CloseMe.Show()
        End If
        If dialog3 = DialogResult.Yes Then
            If SaveFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
                Dim location As String

                location = SaveFileDialog1.FileName

                My.Computer.FileSystem.WriteAllText(location, "" & RichTextBox1.Text, True)
                Me.Text = SaveFileDialog1.FileName
            End If
            CloseMe.Show()
        End If

    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click

        'MsgBox("If you click Cancel, the program will crash.", 0 + 48, "WARNING!")
        If SaveFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            Dim location As String

            location = SaveFileDialog1.FileName
            If File.Exists(SaveFileDialog1.FileName) Then
                My.Computer.FileSystem.DeleteFile(SaveFileDialog1.FileName)
            Else

            End If

            My.Computer.FileSystem.WriteAllText(location, "" & RichTextBox1.Text, True)
            Me.Text = SaveFileDialog1.FileName
            current_file = SaveFileDialog1.FileName
            Me.Text &= " - Sean-ePad"
            s_file = draft
        End If



    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs)
        My.Computer.Clipboard.SetText(RichTextBox1.Text)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub

    Private Sub BatAndcmdMessageProWindowsVersionsOnlyToolStripMenuItem_Click(sender As Object, e As EventArgs)
        RichTextBox1.Text &= "msg *"
    End Sub

    Private Sub InsertCodeExamplesToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click


        If FontDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            RichTextBox1.Font = FontDialog1.Font
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        If current_file = "" Then
            If SaveFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
                Dim location As String

                location = SaveFileDialog1.FileName
                If File.Exists(SaveFileDialog1.FileName) Then
                    My.Computer.FileSystem.DeleteFile(SaveFileDialog1.FileName)
                Else

                End If

                My.Computer.FileSystem.WriteAllText(location, "" & RichTextBox1.Text, True)
                Me.Text = SaveFileDialog1.FileName
            End If
        Else

            My.Computer.FileSystem.DeleteFile(current_file)
            My.Computer.FileSystem.WriteAllText(current_file, "" & RichTextBox1.Text, True)
            s_file = draft


        End If
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim strtext As String
        If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            strtext = OpenFileDialog1.FileName
            Me.Text = OpenFileDialog1.FileName
            current_file = OpenFileDialog1.FileName
            RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(strtext)
            Me.Text &= " - Sean-ePad"
            s_file = RichTextBox1.Text
        End If
    End Sub

    Private Sub DateTimeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DateTimeToolStripMenuItem.Click

        RichTextBox1.Text &= MonthCalendar1.TodayDate
    End Sub

    Private Sub BatcmdMessageOnlyWorksOnProVersionsOnWindowsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BatcmdMessageOnlyWorksOnProVersionsOnWindowsToolStripMenuItem.Click
        RichTextBox1.Text &= "msg *"
    End Sub

    Private Sub VbsMessageToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DateAndTimeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DateAndTimeToolStripMenuItem.Click
        RichTextBox1.Text &= DateTimePicker1.Value
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Settings.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs)
        RichTextBox1.Text &= "©"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next

        Process.Start("Tips.exe")
        'settingsinfo.Show()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'MsgBox(s_file)
        'MsgBox(draft)
        If draft = s_file Then

        Else
            Dim dialog2 As DialogResult
            dialog2 = MessageBox.Show("Do you want to save your current file?

Wil jy jou huidige lêer stoor?", "Sean-ePad", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
            If dialog2 = DialogResult.No Then
                CloseMe.Show()
            End If
            If dialog2 = DialogResult.Yes Then
                If SaveFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
                    Dim location As String

                    location = SaveFileDialog1.FileName
                    My.Computer.FileSystem.DeleteFile(SaveFileDialog1.FileName)
                    My.Computer.FileSystem.WriteAllText(location, "" & RichTextBox1.Text, True)
                    Me.Text = SaveFileDialog1.FileName
                End If
                CloseMe.Show()
            End If
            If dialog2 = DialogResult.Cancel Then
                If (e.CloseReason = CloseReason.UserClosing) Then
                    e.Cancel = True
                End If
            End If
        End If

    End Sub

    Private Sub DocumentationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DocumentationToolStripMenuItem.Click
        Help.Show()
    End Sub

    Private Sub NewWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewWindowToolStripMenuItem.Click
        On Error Resume Next
        If File.Exists("Sean-ePad.exe") Then
            Process.Start("Sean-ePad.exe")
        Else

            Process.Start("Sean-ePad v1.5.exe")


        End If
    End Sub

    Private Sub MoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MoreToolStripMenuItem.Click

    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        RichTextBox1.Text &= "©"
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        RichTextBox1.Text &= "®"
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        RichTextBox1.Text &= "¼"
    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        RichTextBox1.Text &= "±"
    End Sub

    Private Sub ShortcutKeysToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShortcutKeysToolStripMenuItem.Click
        If lang.Text = "Afrikaans" Then
            MsgBox("Die Kortpadsleutels-kieslys is nog nie uit Engels vertaal nie (behalwe die titelbalk en Toe-knoppie).", 0 + 16, "Kortpadsleutels")
            keys.Show()
        ElseIf lang.Text = "Albanian" Then
            MsgBox("Menuja 'Testat e shkurtoreve' nuk është përkthyer ende nga anglishtja (përveç shiritit të titullit dhe butonit Mbyll).", 0 + 16, "Tastet e shkurtoreve")
            keys.Show()
        Else
            keys.Show()
        End If

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        draft = RichTextBox1.Text
    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem7.Click
        RichTextBox1.Text &= "½"
    End Sub

    Private Sub ToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem8.Click
        RichTextBox1.Text &= "¾"
    End Sub

    Private Sub ToolStripMenuItem9_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem9.Click
        RichTextBox1.Text &= "¿"
    End Sub

    Private Sub ToolStripMenuItem10_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem10.Click
        RichTextBox1.Text &= "֎"
    End Sub

    Private Sub ToolStripMenuItem11_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem11.Click
        RichTextBox1.Text &= "☻"
    End Sub

    Private Sub ToolStripMenuItem12_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem12.Click
        RichTextBox1.Text &= "♥"
    End Sub

    Private Sub ToolStripMenuItem13_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem13.Click
        RichTextBox1.Text &= "▲"
    End Sub

    Private Sub ToolStripMenuItem14_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem14.Click
        RichTextBox1.Text &= "⅞"
    End Sub

    Private Sub ToolStripMenuItem15_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem15.Click
        RichTextBox1.Text &= "█"
    End Sub

    Private Sub ToolStripMenuItem16_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem16.Click
        RichTextBox1.Text &= "⁴"
    End Sub

    Private Sub ToolStripMenuItem17_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem17.Click
        RichTextBox1.Text &= "₤"
    End Sub

    Private Sub ToolStripMenuItem18_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem18.Click
        RichTextBox1.Text &= "☺"
    End Sub

    Private Sub ToolStripMenuItem19_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem19.Click
        RichTextBox1.Text &= "™"
    End Sub

    Private Sub ToolStripMenuItem20_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem20.Click
        RichTextBox1.Text &= "♪"
    End Sub

    Private Sub ToolStripMenuItem21_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem21.Click
        RichTextBox1.Text &= "♫"
    End Sub

    Private Sub ToolStripMenuItem2_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        RichTextBox1.Text &= "⅓"
    End Sub

    Private Sub ToolStripMenuItem22_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem22.Click
        RichTextBox1.Text &= "⅔"
    End Sub

    Private Sub ToolStripMenuItem23_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem23.Click
        RichTextBox1.Text &= "№"
    End Sub

    Private Sub ToolStripMenuItem24_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem24.Click
        RichTextBox1.Text &= "₵"
    End Sub

    Private Sub ToolStripMenuItem25_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem25.Click
        RichTextBox1.Text &= "≥"
    End Sub

    Private Sub ToolStripMenuItem26_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem26.Click
        RichTextBox1.Text &= "≤"
    End Sub

    Private Sub ToolStripMenuItem27_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem27.Click
        RichTextBox1.Text &= "₿"
    End Sub

    Private Sub ToolStripMenuItem28_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem28.Click
        RichTextBox1.Text &= "₩"
    End Sub

    Private Sub ToolStripMenuItem29_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem29.Click
        RichTextBox1.Text &= "‽"
    End Sub

    Private Sub InsertAnMLAFormatBookReportStartingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertAnMLAFormatBookReportStartingToolStripMenuItem.Click
        MLAFormatInsert.Show()
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        'MsgBox("This feature is currently broken. It only prints a blank piece of paper. So if you want to do that, go ahead.", 0 + 48, "Broken Feature Alert")
        If System.IO.File.Exists("nofeaturealerts") Then

        Else

            If Me.lang.Text = "English" Then
                MsgBox("The whole document will not be printed. Only a certain amount to the right and down will be printed. Please check the print preview dialog (CTRL+SHIFT+P) to see how your print will look.", 0 + 48, "Print Restriction Warning")
            End If
            If lang.Text = "Afrikaans" Then
                MsgBox("Die hele dokument sal nie gedruk word nie. Slegs 'n sekere bedrag regs en onder sal gedruk word. Gaan asseblief die drukvoorskou-dialoog na (CTRL+SHIFT+P) om te sien hoe jou afdruk sal lyk.", 0 + 48, "Druk beperkingswaarskuwing")
            End If
        End If
        PrintDialog1.Document = PrintDocument1
        PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
        PrintDialog1.AllowSomePages = True
        If PrintDialog1.ShowDialog = DialogResult.OK Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
            PrintDocument1.Print()
        End If

    End Sub

    Private Sub OpenPrintPreviewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenPrintPreviewToolStripMenuItem.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString(RichTextBox1.Text, RichTextBox1.Font, Brushes.Black, 100, 100)
    End Sub

    Private Sub NoOptionsYetToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub OpenCharacterDialogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenCharacterDialogToolStripMenuItem.Click
        CharacterDialog.Show()
    End Sub

    Private Sub UsingNamespaceStdToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsingNamespaceStdToolStripMenuItem.Click
        RichTextBox1.Text &= "using namespace std;"
    End Sub

    Private Sub CopyEntireDocumentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyEntireDocumentToolStripMenuItem.Click
        If RichTextBox1.Text = "" Then
        Else
            My.Computer.Clipboard.SetText(RichTextBox1.Text)
        End If
    End Sub
End Class
