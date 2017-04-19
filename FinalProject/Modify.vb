
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

    Private Sub lblModMssg_Click(sender As Object, e As EventArgs) Handles lblModMssg.Click

    End Sub

    Private Sub btnSub_Click(sender As Object, e As EventArgs) Handles btnSub.Click
        Dim Scheduled As DateTime

        Scheduled = Cookies.CombinedDateTime(dtpDate.Value.Date, CDate("12:00"))



        Dim UserName As String = cboTrpr.SelectedValue.ToString.Trim


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
End Class