Imports System
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Public Class crypt

    Private Sub btngo_Click(sender As Object, e As EventArgs) Handles btngo.Click
        Dim original As String = tbtext.Text

        ' Create a new instance of the Aes
        ' class.  This generates a new key and initialization 
        ' vector (IV).
        Using myAes As Aes = Aes.Create()

            ' Encrypt the string to an array of bytes.
            Dim encrypted As Byte() = EncryptStringToBytes_Aes(original, myAes.Key, myAes.IV)

            ' Decrypt the bytes to a string.
            Dim roundtrip As String = DecryptStringFromBytes_Aes(encrypted, myAes.Key, myAes.IV)

            'Display the original data and the decrypted data.
            Console.WriteLine("Original:   {0}", original)
            Console.WriteLine("Round Trip: {0}", roundtrip)
            tbenc.Text = UnicodeBytesToString(encrypted)
        End Using

    End Sub

    Public Shared Sub Main()


    End Sub 'Main

    Shared Function EncryptStringToBytes_Aes(ByVal plainText As String, ByVal Key() As Byte, ByVal IV() As Byte) As Byte()
        ' Check arguments.
        If plainText Is Nothing OrElse plainText.Length <= 0 Then
            Throw New ArgumentNullException("plainText")
        End If
        If Key Is Nothing OrElse Key.Length <= 0 Then
            Throw New ArgumentNullException("Key")
        End If
        If IV Is Nothing OrElse IV.Length <= 0 Then
            Throw New ArgumentNullException("Key")
        End If
        Dim encrypted() As Byte
        ' Create an Aes object
        ' with the specified key and IV.
        Using aesAlg As Aes = Aes.Create()

            aesAlg.Key = Key
            aesAlg.IV = IV

            ' Create a decrytor to perform the stream transform.
            Dim encryptor As ICryptoTransform = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV)
            ' Create the streams used for encryption.
            Using msEncrypt As New MemoryStream()
                Using csEncrypt As New CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write)
                    Using swEncrypt As New StreamWriter(csEncrypt)

                        'Write all data to the stream.
                        swEncrypt.Write(plainText)
                    End Using
                    encrypted = msEncrypt.ToArray()
                End Using
            End Using
        End Using

        ' Return the encrypted bytes from the memory stream.
        Return encrypted

    End Function 'EncryptStringToBytes_Aes

    Shared Function DecryptStringFromBytes_Aes(ByVal cipherText() As Byte, ByVal Key() As Byte, ByVal IV() As Byte) As String
        ' Check arguments.
        If cipherText Is Nothing OrElse cipherText.Length <= 0 Then
            Throw New ArgumentNullException("cipherText")
        End If
        If Key Is Nothing OrElse Key.Length <= 0 Then
            Throw New ArgumentNullException("Key")
        End If
        If IV Is Nothing OrElse IV.Length <= 0 Then
            Throw New ArgumentNullException("Key")
        End If
        ' Declare the string used to hold
        ' the decrypted text.
        Dim plaintext As String = Nothing

        ' Create an Aes object
        ' with the specified key and IV.
        Using aesAlg As Aes = Aes.Create()
            aesAlg.Key = Key
            aesAlg.IV = IV

            ' Create a decrytor to perform the stream transform.
            Dim decryptor As ICryptoTransform = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV)

            ' Create the streams used for decryption.
            Using msDecrypt As New MemoryStream(cipherText)

                Using csDecrypt As New CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read)

                    Using srDecrypt As New StreamReader(csDecrypt)


                        ' Read the decrypted bytes from the decrypting stream
                        ' and place them in a string.
                        plaintext = srDecrypt.ReadToEnd()
                    End Using
                End Using
            End Using
        End Using

        Return plaintext

    End Function 'DecryptStringFromBytes_Aes

    Private Function UnicodeBytesToString(
    ByVal bytes() As Byte) As String

        Return System.Text.Encoding.Unicode.GetString(bytes)
    End Function

    Private Sub btninfile_Click(sender As Object, e As EventArgs) Handles btninfile.Click
        Try
            ofdin.ShowDialog()
            Dim sourcepath As String = ofdin.FileName
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText(sourcepath)
            tbtext.Text = fileReader
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
            Dim info As Byte() = New UTF8Encoding(True).GetBytes(tbenc.Text)
            fs.Write(info, 0, info.Length)
            fs.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub tbtext_DragDrop(sender As Object, e As DragEventArgs) Handles tbtext.DragDrop
        tbtext.Text = e.Data.GetData(DataFormats.Text)
    End Sub
End Class