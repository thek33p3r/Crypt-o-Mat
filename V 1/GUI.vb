Imports System
Imports System.IO
Imports System.Security.Cryptography

Public Class GUI
    Dim id1 As Integer = 0
    Dim id2 As Integer = 0

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

    End Sub

    Public Sub GUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pwframe As New login
        pwframe.MdiParent = Me
        pwframe.Show()
    End Sub


    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click
        Dim frame As New crypt2
        id1 = id1 + 1
        frame.MdiParent = Me
        frame.Text = "Crypt " & id1
        frame.Show()
    End Sub

    Private Sub FileToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem1.Click
        Dim frame2 As New decrypt
        id2 = id2 + 1
        frame2.MdiParent = Me
        frame2.Text = "Decrypt " & id2
        frame2.Show()
    End Sub

    Private Sub PasswordManagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasswordManagerToolStripMenuItem.Click
        Dim manager As New manager
        manager.MdiParent = Me
        manager.Show()

    End Sub

    Private Sub UserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserToolStripMenuItem.Click
        Dim user As New user
        user.MdiParent = Me
        user.Show()
    End Sub

    Private Sub StyleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StyleToolStripMenuItem.Click
        cdbg.ShowDialog()
        Me.BackColor = Me.cdbg.Color
    End Sub

    Private Sub HilfeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HilfeToolStripMenuItem.Click
        Dim info As New splash
        info.MdiParent = Me
        info.Show()
    End Sub
End Class
