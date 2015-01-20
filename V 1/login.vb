Public Class login
    Dim id As Single = 3
    Dim secvar As Integer = 0
    Dim waitvar As Integer = 60
    ' TODO: Code zum Durchführen der benutzerdefinierten Authentifizierung mithilfe des angegebenen Benutzernamens und des Kennworts hinzufügen 
    ' (Siehe http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' Der benutzerdefinierte Prinzipal kann anschließend wie folgt an den Prinzipal des aktuellen Threads angefügt werden: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' wobei CustomPrincipal die IPrincipal-Implementierung ist, die für die Durchführung der Authentifizierung verwendet wird. 
    ' Anschließend gibt My.User Identitätsinformationen zurück, die in das CustomPrincipal-Objekt gekapselt sind,
    ' z. B. den Benutzernamen, den Anzeigenamen usw.

    Public Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim pw As String = PasswordTextBox.Text
        Dim pwcheck As String = lblpass.Text

        If pw = pwcheck Then

            'Dim manager As New manager
            'manager.MdiParent = GUI
            'manager.Show()
            GUI.MenuStrip1.Enabled = True
            GUI.ToolStripStatusLabel2.Text = ComboBox1.Text
            GUI.ToolStripStatusLabel2.Visible = True
            Dim time As String = DateAndTime.Now
            GUI.ToolStripStatusLabel3.Text = time
            GUI.ToolStripStatusLabel3.Visible = True
            Me.Close()
        Else
            id = id - 1
            lblstatus.Text = "wrong password..." & id & "trys left!"
        End If

        If id = 0 Then
            timerwait.Enabled = True
            lblstatus.Text = " "
            OK.Enabled = False
            ComboBox1.Enabled = False
            PasswordTextBox.Enabled = False
        End If


    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DataDataSet.Table2". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.Table2TableAdapter.Fill(Me.DataDataSet.Table2)

    End Sub

    Private Sub timerwait_Tick(sender As Object, e As EventArgs) Handles timerwait.Tick
        If secvar < 60 Then
            secvar = secvar + 1
            Dim lockvar As Integer = waitvar - secvar
            OK.Text = "Wait..." & lockvar
        ElseIf secvar = 60 Then
            timerwait.Enabled = False
            id = 3
            secvar = 0
            OK.Text = "Login"
            OK.Enabled = True
            ComboBox1.Enabled = True
            PasswordTextBox.Enabled = True
        End If
    End Sub
End Class
