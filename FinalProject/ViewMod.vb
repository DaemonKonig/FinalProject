Public Class ViewMod
    Private mCookies As New Cookies



    Private Sub ViewMod_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'GSCDataSet.Cookies' table. You can move, or remove it, as needed.
        Me.CookiesTableAdapter.Fill(Me.GSCDataSet.Cookies)





    End Sub




    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvCookies.SelectedRows.Count > 0 Then
            Dim CookieId As Short = CShort(dgvCookies.SelectedRows(0).Cells(0).Value)
            Dim frm As New Modify
            frm.mCookieId = CookieId
            frm.ShowDialog()
            dgvCookies.DataSource = mCookies.items
        Else
            MessageBox.Show("Please select the CookieSheet to edit")
        End If
    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvCookies.SelectedRows.Count > 0 Then
            Dim CookieId As Short = CShort(dgvCookies.SelectedRows(0).Cells(0).Value)
            If mCookies.Delete(CookieId) Then
                dgvCookies.DataSource = mCookies.items
            Else
                MessageBox.Show("Unable to delete this Sheet")
            End If
        End If
    End Sub
End Class