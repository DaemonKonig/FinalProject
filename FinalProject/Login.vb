Imports FinalProject.Accounts
Imports System.IO
Public Class Login







    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GSCDataSet.Accounts' table. You can move, or remove it, as needed.
        Me.AccountsTableAdapter.Fill(Me.GSCDataSet.Accounts)



    End Sub

    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click

        If txtPass.Text = cboUsers.SelectedValue.ToString.Trim Then


            Main.ShowDialog()
            Me.Close()
        Else
            MessageBox.Show("Invalid Password")
            Return
        End If


    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub CheckLogin()




    End Sub


End Class
