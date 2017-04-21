Public Class NewInven
    Private mInventory As New Inventory


    Private Sub Input_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GSCDataSet.Accounts' table. You can move, or remove it, as needed.
        Me.AccountsTableAdapter.Fill(Me.GSCDataSet.Accounts)
        'TODO: This line of code loads data into the 'GSCDataSet.Cookies' table. You can move, or remove it, as needed.





    End Sub

    Private Sub btnSub_Click(sender As Object, e As EventArgs) Handles btnSub.Click
        Dim Scheduled As DateTime
        Try
            Scheduled = Inventory.CombinedDateTime(dtpDate.Value.Date, CDate("12:00"))

        Catch ex As Exception

        End Try


        Dim UserName As String = cboUsers.SelectedValue.ToString


        If mInventory.insert(UserName, Scheduled, txtMints.Text, txtLites.Text, txtPatties.Text, txtBread.Text, txtComment.Text, txtZip.Text) Then
            Me.Close()
        Else
            MessageBox.Show("Unable to add new cookie sheet")
        End If


    End Sub

    Private Sub btnClr_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        For Each txt As TextBox In Controls.OfType(Of TextBox)
            txt.Clear()
        Next


    End Sub

    Private Sub btnCncl_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()


    End Sub

    Private Sub dtpDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpDate.ValueChanged

    End Sub

    Private Sub txtMints_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtZip.KeyPress, txtPatties.KeyPress, txtMints.KeyPress, txtLites.KeyPress, txtBread.KeyPress
        If Char.IsControl(e.KeyChar) Then Exit Sub
        Dim txt As TextBox = CType(sender, TextBox)

        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True

        Else Exit Sub
        End If
    End Sub
End Class