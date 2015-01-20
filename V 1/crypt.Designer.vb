<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class crypt
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
        Me.btngo = New System.Windows.Forms.Button()
        Me.ofdin = New System.Windows.Forms.OpenFileDialog()
        Me.btninfile = New System.Windows.Forms.Button()
        Me.tbenc = New System.Windows.Forms.TextBox()
        Me.tbtext = New System.Windows.Forms.TextBox()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnsend = New System.Windows.Forms.Button()
        Me.fbdout = New System.Windows.Forms.FolderBrowserDialog()
        Me.SuspendLayout()
        '
        'btngo
        '
        Me.btngo.Location = New System.Drawing.Point(320, 12)
        Me.btngo.Name = "btngo"
        Me.btngo.Size = New System.Drawing.Size(75, 23)
        Me.btngo.TabIndex = 3
        Me.btngo.Text = "GO"
        Me.btngo.UseVisualStyleBackColor = True
        '
        'ofdin
        '
        Me.ofdin.FileName = "OpenFileDialog1"
        '
        'btninfile
        '
        Me.btninfile.Location = New System.Drawing.Point(12, 12)
        Me.btninfile.Name = "btninfile"
        Me.btninfile.Size = New System.Drawing.Size(75, 23)
        Me.btninfile.TabIndex = 4
        Me.btninfile.Text = "Choose file.."
        Me.btninfile.UseVisualStyleBackColor = True
        '
        'tbenc
        '
        Me.tbenc.Location = New System.Drawing.Point(320, 41)
        Me.tbenc.Multiline = True
        Me.tbenc.Name = "tbenc"
        Me.tbenc.Size = New System.Drawing.Size(272, 275)
        Me.tbenc.TabIndex = 5
        '
        'tbtext
        '
        Me.tbtext.AllowDrop = True
        Me.tbtext.Location = New System.Drawing.Point(12, 41)
        Me.tbtext.Multiline = True
        Me.tbtext.Name = "tbtext"
        Me.tbtext.Size = New System.Drawing.Size(272, 275)
        Me.tbtext.TabIndex = 6
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(12, 322)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 7
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnsend
        '
        Me.btnsend.Location = New System.Drawing.Point(93, 322)
        Me.btnsend.Name = "btnsend"
        Me.btnsend.Size = New System.Drawing.Size(75, 23)
        Me.btnsend.TabIndex = 8
        Me.btnsend.Text = "Email"
        Me.btnsend.UseVisualStyleBackColor = True
        '
        'crypt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 354)
        Me.Controls.Add(Me.btnsend)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.tbtext)
        Me.Controls.Add(Me.tbenc)
        Me.Controls.Add(Me.btninfile)
        Me.Controls.Add(Me.btngo)
        Me.Name = "crypt"
        Me.Text = "crypt"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btngo As System.Windows.Forms.Button
    Friend WithEvents ofdin As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btninfile As System.Windows.Forms.Button
    Friend WithEvents tbenc As System.Windows.Forms.TextBox
    Friend WithEvents tbtext As System.Windows.Forms.TextBox
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnsend As System.Windows.Forms.Button
    Friend WithEvents fbdout As System.Windows.Forms.FolderBrowserDialog
End Class
