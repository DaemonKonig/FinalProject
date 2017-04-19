Public Class ViewTroop
    Private mUser As New Accounts

    Private Sub ViewTroop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GSCDataSet.Accounts' table. You can move, or remove it, as needed.
        Me.AccountsTableAdapter.Fill(Me.GSCDataSet.Accounts)

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvTroop.SelectedRows.Count > 0 Then
            Dim UserId As Short = CShort(dgvTroop.SelectedRows(0).Cells(0).Value)
            Dim frm As New EditTroopvb
            frm.mUserId = UserId
            frm.ShowDialog()
            dgvTroop.DataSource = mUser.items
        Else
            MessageBox.Show("Please select the User to edit")
        End If
    End Sub
End Class