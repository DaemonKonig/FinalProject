Public Class ModInven


    Public Property mInventoryId As Short
    Private mInventory As New Inventory
    Private mUserNames As New Accounts

    Private Sub ModInven_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GSCDataSet.Accounts' table. You can move, or remove it, as needed.
        Me.AccountsTableAdapter.Fill(Me.GSCDataSet.Accounts)

        Dim row As GSCDataSet.InventoryRow
        row = mInventory.GetByInventoryId(mInventoryId)
        dtpDate.Value = row.Scheduled.Date
        txtBread.Text = row.ShortBread
        txtLites.Text = row.Caramel_deLites
        txtMints.Text = row.ThinMints
        txtPatties.Text = row.PeanutButter_Patties
        txtComment.Text = row.Comments



    End Sub



    Private Sub btnSub_Click(sender As Object, e As EventArgs) Handles btnSub.Click
        Dim Scheduled As DateTime

        Scheduled = Cookies.CombinedDateTime(dtpDate.Value.Date, CDate("12:00"))



        Dim UserName As String = cboTrpr.SelectedValue.ToString.Trim


        If mInventory.Update(UserName, Scheduled, txtMints.Text, txtLites.Text, txtPatties.Text, txtBread.Text, txtComment.Text, txtZip.Text, mInventoryId) Then
            Me.Close()
        Else
            MessageBox.Show("Cannot Update Inventory Sheet, Please ensure that all forms are filled out correctly")
        End If


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        For Each txt As TextBox In Controls.OfType(Of TextBox)
            txt.Clear()
        Next
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTrpr.SelectedIndexChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click, Label7.Click, Label6.Click, Label5.Click, Label4.Click, Label3.Click, Label2.Click, Label8.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtComment.TextChanged, txtZip.TextChanged, txtBread.TextChanged, txtPatties.TextChanged, txtLites.TextChanged, txtMints.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSub.Click, btnClose.Click, btnClear.Click

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