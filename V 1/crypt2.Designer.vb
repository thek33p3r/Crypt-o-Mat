<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class crypt2
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txtOriginalText = New System.Windows.Forms.TextBox()
        Me.btnenc = New System.Windows.Forms.Button()
        Me.tbkey = New System.Windows.Forms.TextBox()
        Me.btnsource = New System.Windows.Forms.Button()
        Me.ofdsource = New System.Windows.Forms.OpenFileDialog()
        Me.txtencryptedtext = New System.Windows.Forms.TextBox()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.fbdout = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnsavekey = New System.Windows.Forms.Button()
        Me.fbdsavekey = New System.Windows.Forms.FolderBrowserDialog()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtOriginalText
        '
        Me.txtOriginalText.AllowDrop = True
        Me.txtOriginalText.ContextMenuStrip = Me.ContextMenuStrip1
        Me.txtOriginalText.Location = New System.Drawing.Point(12, 41)
        Me.txtOriginalText.Multiline = True
        Me.txtOriginalText.Name = "txtOriginalText"
        Me.txtOriginalText.Size = New System.Drawing.Size(309, 224)
        Me.txtOriginalText.TabIndex = 1
        '
        'btnenc
        '
        Me.HelpProvider1.SetHelpString(Me.btnenc, "Starts the encryption.")
        Me.btnenc.Location = New System.Drawing.Point(338, 12)
        Me.btnenc.Name = "btnenc"
        Me.HelpProvider1.SetShowHelp(Me.btnenc, True)
        Me.btnenc.Size = New System.Drawing.Size(75, 23)
        Me.btnenc.TabIndex = 2
        Me.btnenc.Text = "Encrypt"
        Me.btnenc.UseVisualStyleBackColor = True
        '
        'tbkey
        '
        Me.HelpProvider1.SetHelpString(Me.tbkey, "Enter a Key")
        Me.tbkey.Location = New System.Drawing.Point(12, 276)
        Me.tbkey.Name = "tbkey"
        Me.HelpProvider1.SetShowHelp(Me.tbkey, True)
        Me.tbkey.Size = New System.Drawing.Size(228, 20)
        Me.tbkey.TabIndex = 3
        Me.tbkey.Text = "Cryptomat"
        '
        'btnsource
        '
        Me.HelpProvider1.SetHelpString(Me.btnsource, "Open any text file")
        Me.btnsource.Location = New System.Drawing.Point(12, 12)
        Me.btnsource.Name = "btnsource"
        Me.HelpProvider1.SetShowHelp(Me.btnsource, True)
        Me.btnsource.Size = New System.Drawing.Size(75, 23)
        Me.btnsource.TabIndex = 4
        Me.btnsource.Text = "Open file"
        Me.btnsource.UseVisualStyleBackColor = True
        '
        'ofdsource
        '
        Me.ofdsource.FileName = "OpenFileDialog1"
        '
        'txtencryptedtext
        '
        Me.txtencryptedtext.AllowDrop = True
        Me.txtencryptedtext.Location = New System.Drawing.Point(338, 41)
        Me.txtencryptedtext.Multiline = True
        Me.txtencryptedtext.Name = "txtencryptedtext"
        Me.txtencryptedtext.Size = New System.Drawing.Size(309, 224)
        Me.txtencryptedtext.TabIndex = 5
        '
        'btnsave
        '
        Me.HelpProvider1.SetHelpString(Me.btnsave, "Save your encrypted text. ")
        Me.btnsave.Location = New System.Drawing.Point(572, 274)
        Me.btnsave.Name = "btnsave"
        Me.HelpProvider1.SetShowHelp(Me.btnsave, True)
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 6
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnsavekey
        '
        Me.btnsavekey.Location = New System.Drawing.Point(246, 274)
        Me.btnsavekey.Name = "btnsavekey"
        Me.btnsavekey.Size = New System.Drawing.Size(75, 23)
        Me.btnsavekey.TabIndex = 7
        Me.btnsavekey.Text = "Save Key"
        Me.btnsavekey.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(127, 26)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem1.Text = "open file.."
        '
        'crypt2
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 303)
        Me.Controls.Add(Me.btnsavekey)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.txtencryptedtext)
        Me.Controls.Add(Me.btnsource)
        Me.Controls.Add(Me.tbkey)
        Me.Controls.Add(Me.btnenc)
        Me.Controls.Add(Me.txtOriginalText)
        Me.Name = "crypt2"
        Me.Text = "crypt2"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtOriginalText As System.Windows.Forms.TextBox
    Friend WithEvents btnenc As System.Windows.Forms.Button
    Friend WithEvents tbkey As System.Windows.Forms.TextBox
    Friend WithEvents btnsource As System.Windows.Forms.Button
    Friend WithEvents ofdsource As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtencryptedtext As System.Windows.Forms.TextBox
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents fbdout As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btnsavekey As System.Windows.Forms.Button
    Friend WithEvents fbdsavekey As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
End Class
