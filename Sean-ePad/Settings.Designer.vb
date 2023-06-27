<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Settings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.nofeaturealerts = New System.Windows.Forms.CheckBox()
        Me.debug_enable = New System.Windows.Forms.CheckBox()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.word_count = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(86, 209)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(5, 209)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "OK"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Location = New System.Drawing.Point(167, 209)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Help"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Text Color:"
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.Location = New System.Drawing.Point(73, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Change..."
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Program font:"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(96, 49)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "Change..."
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(255, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "This also, for whatever reason, changes the text font"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Language:"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.ComboBox1, "Changes the language of Sean-ePad. Not all of the program, including these help s" &
        "trings, are translated.")
        Me.ComboBox1.Items.AddRange(New Object() {"English", "Japanese", "Afrikaans", "Albanian", "Japanese", "Russian"})
        Me.ComboBox1.Location = New System.Drawing.Point(76, 79)
        Me.ComboBox1.Name = "ComboBox1"
        Me.HelpProvider1.SetShowHelp(Me.ComboBox1, True)
        Me.ComboBox1.Size = New System.Drawing.Size(166, 21)
        Me.ComboBox1.TabIndex = 10
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.Location = New System.Drawing.Point(15, 106)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(217, 30)
        Me.CheckBox1.TabIndex = 11
        Me.CheckBox1.Text = "Show non-text file extensions in Save As" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and Open dialogs" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'nofeaturealerts
        '
        Me.nofeaturealerts.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.nofeaturealerts, "Disables warnings about some features not working as they should")
        Me.nofeaturealerts.Location = New System.Drawing.Point(15, 142)
        Me.nofeaturealerts.Name = "nofeaturealerts"
        Me.HelpProvider1.SetShowHelp(Me.nofeaturealerts, True)
        Me.nofeaturealerts.Size = New System.Drawing.Size(143, 17)
        Me.nofeaturealerts.TabIndex = 12
        Me.nofeaturealerts.Text = "Don't show feature alerts"
        Me.nofeaturealerts.UseVisualStyleBackColor = True
        '
        'debug_enable
        '
        Me.debug_enable.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.debug_enable, "Shows elements and message boxes used for debugging")
        Me.debug_enable.Location = New System.Drawing.Point(15, 165)
        Me.debug_enable.Name = "debug_enable"
        Me.HelpProvider1.SetShowHelp(Me.debug_enable, True)
        Me.debug_enable.Size = New System.Drawing.Size(177, 17)
        Me.debug_enable.TabIndex = 13
        Me.debug_enable.Text = "Show debug text and msgboxes"
        Me.debug_enable.UseVisualStyleBackColor = True
        '
        'word_count
        '
        Me.word_count.AutoSize = True
        Me.word_count.Location = New System.Drawing.Point(15, 188)
        Me.word_count.Name = "word_count"
        Me.word_count.Size = New System.Drawing.Size(167, 17)
        Me.word_count.TabIndex = 14
        Me.word_count.Text = "Show word count while typing"
        Me.word_count.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(269, 240)
        Me.Controls.Add(Me.word_count)
        Me.Controls.Add(Me.debug_enable)
        Me.Controls.Add(Me.nofeaturealerts)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Settings"
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents Label3 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents nofeaturealerts As CheckBox
    Friend WithEvents debug_enable As CheckBox
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents word_count As CheckBox
End Class
