
Public Class Modify
    Public Property mCookieId As Short
    Private mCookieSheet As New Cookies
    Private mUserNames As New Accounts

    Private Sub Modify_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GSCDataSet.Accounts' table. You can move, or remove it, as needed.
        Me.AccountsTableAdapter.Fill(Me.GSCDataSet.Accounts)
        Dim row As GSCDataSet.CookiesRow
        row = mCookieSheet.GetByCookieId(mCookieId)
        dtpDate.Value = row.Scheduled.Date
        txtBread.Text = row.ShortBread
        txtLites.Text = row.Caramel_deLites
        txtMints.Text = row.ThinMints
        txtPatties.Text = row.PeanutButter_Patties
        txtComment.Text = row.Comments



    End Sub

    Private Sub btnSub_Click(sender As Object, e As EventArgs) Handles btnSub.Click
        Dim Scheduled As DateTime
        Dim UserName As String = cboTrpr.SelectedValue.ToString.Trim
        Scheduled = Cookies.CombinedDateTime(dtpDate.Value.Date, CDate("12:00"))



        If mCookieSheet.Update(UserName, Scheduled, txtMints.Text, txtLites.Text, txtPatties.Text, txtBread.Text, txtComment.Text, txtZip.Text, mCookieId) Then
            Me.Close()
        Else
            MessageBox.Show("Cannot Update Cookie Sheet, Please ensure that all forms are filled out correctly")
        End If


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        For Each txt As TextBox In Controls.OfType(Of TextBox)
            txt.Clear()
        Next
    End Sub

    Private Sub txtClose_Click(sender As Object, e As EventArgs) Handles txtClose.Click
        Me.Close()
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