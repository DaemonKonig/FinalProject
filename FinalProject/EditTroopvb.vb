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






        If mAccount.Update(txtUser.Text, txtPass.Text, CInt(txtPhone.Text), mUserId, txtMessage.Text) Then
            Me.Close()
        Else
            MessageBox.Show("Cannot Update Troop")
        End If

    End Sub

    Private Sub txtMessage_TextChanged(sender As Object, e As EventArgs) Handles txtMessage.TextChanged

    End Sub

    Private Sub txtPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhone.KeyPress
        If Char.IsControl(e.KeyChar) Then Exit Sub
        Dim txt As TextBox = CType(sender, TextBox)

        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True

        Else Exit Sub
        End If
    End Sub
End Class