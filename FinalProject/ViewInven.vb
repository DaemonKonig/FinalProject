Public Class ViewInven
    Private mInventory As New Inventory

    Private Sub ViewInven_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GSCDataSet.Inventory' table. You can move, or remove it, as needed.
        Me.InventoryTableAdapter.Fill(Me.GSCDataSet.Inventory)

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvInven.SelectedRows.Count > 0 Then
            Dim InventoryId As Short = CShort(dgvInven.SelectedRows(0).Cells(0).Value)
            Dim frm As New ModInven
            frm.mInventoryId = InventoryId
            frm.ShowDialog()
            dgvInven.DataSource = mInventory.items
        Else
            MessageBox.Show("Please select the Inventory sheet to edit")
        End If
    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvInven.SelectedRows.Count > 0 Then
            Dim InventoryId As Short = CShort(dgvInven.SelectedRows(0).Cells(0).Value)
            If mInventory.Delete(InventoryId) Then
                dgvInven.DataSource = mInventory.items
            Else
                MessageBox.Show("Unable to delete this Sheet")
            End If
        End If
    End Sub


End Class