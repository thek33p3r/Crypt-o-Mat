Imports System.IO
Imports System.Text
Imports System.Security.Cryptography
Imports System.Net.Mail

Public Class crypt2

    Private Sub crypt2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Protected Sub Encrypt(sender As Object, e As EventArgs)
        txtencryptedtext.Text = Me.Encrypt(txtOriginalText.Text.Trim())
    End Sub

    Private Function Encrypt(clearText As String) As String
        Dim EncryptionKey As String = tbkey.Text
        Dim clearBytes As Byte() = Encoding.Unicode.GetBytes(clearText)
        Using encryptor As Aes = Aes.Create()
            Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D, _
             &H65, &H64, &H76, &H65, &H64, &H65, _
             &H76})
            encryptor.Key = pdb.GetBytes(32)
            encryptor.IV = pdb.GetBytes(16)
            Using ms As New MemoryStream()
                Using cs As New CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write)
                    cs.Write(clearBytes, 0, clearBytes.Length)
                    cs.Close()
                End Using
                clearText = Convert.ToBase64String(ms.ToArray())
            End Using
        End Using
        Return clearText
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnenc.Click
        txtencryptedtext.Text = Me.Encrypt(txtOriginalText.Text.Trim())
    End Sub

    Private Sub btnsource_Click(sender As Object, e As EventArgs) Handles btnsource.Click
        Try
            ofdsource.ShowDialog()
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText(ofdsource.FileName)
            txtOriginalText.Text = fileReader
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Try
            Dim filename As String = "enc.txt"
            fbdout.ShowDialog()
            Dim outpath As String = fbdout.SelectedPath
            Dim path As String = outpath & "\" & filename

            ' Create or overwrite the file.
            Dim fs As FileStream = File.Create(path)

            ' Add text to the file.
            Dim info As Byte() = New UTF8Encoding(True).GetBytes(txtencryptedtext.Text)
            fs.Write(info, 0, info.Length)
            fs.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnsavekey_Click(sender As Object, e As EventArgs) Handles btnsavekey.Click
        Try
            Dim filename As String = "key.dat"
            fbdsavekey.ShowDialog()
            Dim outpath As String = fbdsavekey.SelectedPath
            Dim path As String = outpath & "\" & filename

            ' Create or overwrite the file.
            Dim fs As FileStream = File.Create(path)

            ' Add text to the file.
            Dim info As Byte() = New UTF8Encoding(True).GetBytes(tbkey.Text)
            fs.Write(info, 0, info.Length)
            fs.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtOriginalText_DragDrop(sender As Object, e As DragEventArgs) Handles txtOriginalText.DragDrop
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim MyFiles() As String
            ' Assign the files to an array.
            MyFiles = e.Data.GetData(DataFormats.FileDrop)
            ' Display the file Name
            'TextBoxDrop.Text = MyFiles(0)
            ' Display the file contents
            txtOriginalText.Text = My.Computer.FileSystem.ReadAllText(MyFiles(0))
        End If
    End Sub

    Private Sub txtOriginalText_DragEnter(sender As Object, e As DragEventArgs) Handles txtOriginalText.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.All
        End If
    End Sub

    Private Sub txtOriginalText_MouseMove(sender As Object, e As MouseEventArgs) Handles txtOriginalText.MouseMove

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Try
            ofdsource.ShowDialog()
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText(ofdsource.FileName)
            txtOriginalText.Text = fileReader
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class