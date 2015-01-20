<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class decrypt
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
        Me.btnsource = New System.Windows.Forms.Button()
        Me.txtEncryptedText = New System.Windows.Forms.TextBox()
        Me.ofdsource = New System.Windows.Forms.OpenFileDialog()
        Me.txtdecryptedtext = New System.Windows.Forms.TextBox()
        Me.btndec = New System.Windows.Forms.Button()
        Me.tbkey = New System.Windows.Forms.TextBox()
        Me.btnloadkey = New System.Windows.Forms.Button()
        Me.ofdkey = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'btnsource
        '
        Me.btnsource.Location = New System.Drawing.Point(13, 13)
        Me.btnsource.Name = "btnsource"
        Me.btnsource.Size = New System.Drawing.Size(75, 23)
        Me.btnsource.TabIndex = 0
        Me.btnsource.Text = "Choose file"
        Me.btnsource.UseVisualStyleBackColor = True
        '
        'txtEncryptedText
        '
        Me.txtEncryptedText.AllowDrop = True
        Me.txtEncryptedText.Location = New System.Drawing.Point(13, 42)
        Me.txtEncryptedText.Multiline = True
        Me.txtEncryptedText.Name = "txtEncryptedText"
        Me.txtEncryptedText.Size = New System.Drawing.Size(294, 220)
        Me.txtEncryptedText.TabIndex = 1
        '
        'ofdsource
        '
        Me.ofdsource.FileName = "enc.txt"
        '
        'txtdecryptedtext
        '
        Me.txtdecryptedtext.Location = New System.Drawing.Point(332, 42)
        Me.txtdecryptedtext.Multiline = True
        Me.txtdecryptedtext.Name = "txtdecryptedtext"
        Me.txtdecryptedtext.Size = New System.Drawing.Size(294, 220)
        Me.txtdecryptedtext.TabIndex = 2
        '
        'btndec
        '
        Me.btndec.Location = New System.Drawing.Point(332, 13)
        Me.btndec.Name = "btndec"
        Me.btndec.Size = New System.Drawing.Size(75, 23)
        Me.btndec.TabIndex = 3
        Me.btndec.Text = "Go"
        Me.btndec.UseVisualStyleBackColor = True
        '
        'tbkey
        '
        Me.tbkey.AllowDrop = True
        Me.tbkey.Location = New System.Drawing.Point(13, 268)
        Me.tbkey.Name = "tbkey"
        Me.tbkey.Size = New System.Drawing.Size(213, 20)
        Me.tbkey.TabIndex = 4
        Me.tbkey.Text = "enter Key"
        '
        'btnloadkey
        '
        Me.btnloadkey.Location = New System.Drawing.Point(232, 268)
        Me.btnloadkey.Name = "btnloadkey"
        Me.btnloadkey.Size = New System.Drawing.Size(75, 23)
        Me.btnloadkey.TabIndex = 5
        Me.btnloadkey.Text = "Load key"
        Me.btnloadkey.UseVisualStyleBackColor = True
        '
        'ofdkey
        '
        Me.ofdkey.FileName = "key.dat"
        '
        'decrypt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 342)
        Me.Controls.Add(Me.btnloadkey)
        Me.Controls.Add(Me.tbkey)
        Me.Controls.Add(Me.btndec)
        Me.Controls.Add(Me.txtdecryptedtext)
        Me.Controls.Add(Me.txtEncryptedText)
        Me.Controls.Add(Me.btnsource)
        Me.Name = "decrypt"
        Me.Text = "decrypt"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnsource As System.Windows.Forms.Button
    Friend WithEvents txtEncryptedText As System.Windows.Forms.TextBox
    Friend WithEvents ofdsource As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtdecryptedtext As System.Windows.Forms.TextBox
    Friend WithEvents btndec As System.Windows.Forms.Button
    Friend WithEvents tbkey As System.Windows.Forms.TextBox
    Friend WithEvents btnloadkey As System.Windows.Forms.Button
    Friend WithEvents ofdkey As System.Windows.Forms.OpenFileDialog
End Class
