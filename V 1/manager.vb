Public Class manager

    Private Sub manager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DataDataSet.Table". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.TableTableAdapter.Fill(Me.DataDataSet.Table)

    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Me.TableTableAdapter.Update(Me.DataDataSet.Table)
    End Sub
End Class