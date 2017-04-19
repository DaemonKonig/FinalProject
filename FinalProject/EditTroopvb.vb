Public Class EditTroopvb
    Private mAccount As New Accounts
    Public Property mUserId As Short
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub EditTroopvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim row As GSCDataSet.AccountsRow
        row = mAccount.GetByUserId(mUserId)

        txtUser.Text = row.Username
        txtPass.Text = row.Password
        txtPhone.Text = row.PhoneNumber

    End Sub

    Private Sub btnSub_Click(sender As Object, e As EventArgs) Handles btnSub.Click






        If mAccount.Update(txtUser.Text, txtPass.Text, txtPhone.Text, mUserId, txtUser.Text) Then
            Me.Close()
        Else
            MessageBox.Show("Cannot Update Troop")
        End If

    End Sub
End Class