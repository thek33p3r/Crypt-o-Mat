<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class login
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
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.OK = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Table2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataDataSet = New Crypt_o_Mat.dataDataSet()
        Me.Table2TableAdapter = New Crypt_o_Mat.dataDataSetTableAdapters.Table2TableAdapter()
        Me.lblpass = New System.Windows.Forms.Label()
        Me.lblstatus = New System.Windows.Forms.Label()
        Me.timerwait = New System.Windows.Forms.Timer(Me.components)
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LogoPictureBox.Image = Global.Crypt_o_Mat.My.Resources.Resources.lock
        Me.LogoPictureBox.Location = New System.Drawing.Point(25, 21)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(110, 97)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Location = New System.Drawing.Point(172, 6)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(151, 23)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "&Benutzername"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Location = New System.Drawing.Point(172, 50)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(151, 23)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "&Kennwort"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(174, 73)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(149, 20)
        Me.PasswordTextBox.TabIndex = 3
        '
        'OK
        '
        Me.OK.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.OK.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.OK.Location = New System.Drawing.Point(174, 132)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(149, 23)
        Me.OK.TabIndex = 4
        Me.OK.Text = "&Login"
        Me.OK.UseVisualStyleBackColor = False
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Location = New System.Drawing.Point(300, 161)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(94, 23)
        Me.Cancel.TabIndex = 5
        Me.Cancel.Text = "&Abbrechen"
        Me.Cancel.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.Table2BindingSource
        Me.ComboBox1.DisplayMember = "User"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(174, 29)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(149, 21)
        Me.ComboBox1.TabIndex = 6
        '
        'Table2BindingSource
        '
        Me.Table2BindingSource.DataMember = "Table2"
        Me.Table2BindingSource.DataSource = Me.DataDataSetBindingSource
        '
        'DataDataSetBindingSource
        '
        Me.DataDataSetBindingSource.DataSource = Me.DataDataSet
        Me.DataDataSetBindingSource.Position = 0
        '
        'DataDataSet
        '
        Me.DataDataSet.DataSetName = "dataDataSet"
        Me.DataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Table2TableAdapter
        '
        Me.Table2TableAdapter.ClearBeforeFill = True
        '
        'lblpass
        '
        Me.lblpass.AutoSize = True
        Me.lblpass.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table2BindingSource, "Data", True))
        Me.lblpass.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblpass.Location = New System.Drawing.Point(329, 32)
        Me.lblpass.Name = "lblpass"
        Me.lblpass.Size = New System.Drawing.Size(0, 13)
        Me.lblpass.TabIndex = 7
        '
        'lblstatus
        '
        Me.lblstatus.AutoSize = True
        Me.lblstatus.Location = New System.Drawing.Point(176, 105)
        Me.lblstatus.Name = "lblstatus"
        Me.lblstatus.Size = New System.Drawing.Size(0, 13)
        Me.lblstatus.TabIndex = 8
        '
        'timerwait
        '
        Me.timerwait.Interval = 1000
        '
        'login
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(363, 167)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblstatus)
        Me.Controls.Add(Me.lblpass)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "login"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "login"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents DataDataSet As Crypt_o_Mat.dataDataSet
    Friend WithEvents DataDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Table2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Table2TableAdapter As Crypt_o_Mat.dataDataSetTableAdapters.Table2TableAdapter
    Friend WithEvents lblpass As System.Windows.Forms.Label
    Friend WithEvents lblstatus As System.Windows.Forms.Label
    Friend WithEvents timerwait As System.Windows.Forms.Timer

End Class
