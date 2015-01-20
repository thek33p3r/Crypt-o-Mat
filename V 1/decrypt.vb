Imports System.IO
Imports System.Text
Imports System.Security.Cryptography

Public Class decrypt
    Protected Sub Decrypt(sender As Object, e As EventArgs)
        txtdecryptedtext.Text = Me.Decrypt(txtEncryptedText.Text.Trim())
    End Sub

    Private Function Decrypt(cipherText As String) As String
        Dim EncryptionKey As String = tbkey.Text
        Dim cipherBytes As Byte() = Convert.FromBase64String(cipherText)
        Using encryptor As Aes = Aes.Create()
            Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D, _
             &H65, &H64, &H76, &H65, &H64, &H65, _
             &H76})
            encryptor.Key = pdb.GetBytes(32)
            encryptor.IV = pdb.GetBytes(16)
            Using ms As New MemoryStream()
                Using cs As New CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write)
                    cs.Write(cipherBytes, 0, cipherBytes.Length)
                    cs.Close()
                End Using
                cipherText = Encoding.Unicode.GetString(ms.ToArray())
            End Using
        End Using
        Return cipherText
    End Function

    Private Sub btnsource_Click(sender As Object, e As EventArgs) Handles btnsource.Click
        Try
            ofdsource.ShowDialog()
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText(ofdsource.FileName)
            txtEncryptedText.Text = fileReader
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btndec_Click(sender As Object, e As EventArgs) Handles btndec.Click
        txtdecryptedtext.Text = Me.Decrypt(txtEncryptedText.Text.Trim())
    End Sub

    Private Sub btnloadkey_Click(sender As Object, e As EventArgs) Handles btnloadkey.Click
        Try
            ofdkey.ShowDialog()
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText(ofdkey.FileName)
            tbkey.Text = fileReader
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtEncryptedText_DragEnter(sender As Object, e As DragEventArgs) Handles txtEncryptedText.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.All
        End If
    End Sub

    Private Sub txtEncryptedText_DragDrop(sender As Object, e As DragEventArgs) Handles txtEncryptedText.DragDrop
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim MyFiles() As String
            ' Assign the files to an array.
            MyFiles = e.Data.GetData(DataFormats.FileDrop)
            ' Display the file Name
            'TextBoxDrop.Text = MyFiles(0)
            ' Display the file contents
            txtEncryptedText.Text = My.Computer.FileSystem.ReadAllText(MyFiles(0))
        End If
    End Sub

    Private Sub tbkey_DragEnter(sender As Object, e As DragEventArgs) Handles tbkey.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.All
        End If
    End Sub

    Private Sub tbkey_DragDrop(sender As Object, e As DragEventArgs) Handles tbkey.DragDrop
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim MyFiles() As String
            ' Assign the files to an array.
            MyFiles = e.Data.GetData(DataFormats.FileDrop)
            ' Display the file Name
            'TextBoxDrop.Text = MyFiles(0)
            ' Display the file contents
            tbkey.Text = My.Computer.FileSystem.ReadAllText(MyFiles(0))
        End If
    End Sub
End Class