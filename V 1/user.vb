Public Class user

    Private Sub user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "DataDataSet.Table2". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.Table2TableAdapter.Fill(Me.DataDataSet.Table2)

    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Me.Table2TableAdapter.Update(Me.DataDataSet.Table2)
    End Sub
End Class