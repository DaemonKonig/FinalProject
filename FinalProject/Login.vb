Imports FinalProject.Main
Imports System.IO
Public Class Login



    Public ActiveAdmin As Boolean
    Public ActiveUser As Boolean



    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GSCDataSet.Accounts' table. You can move, or remove it, as needed.
        Me.AccountsTableAdapter.Fill(Me.GSCDataSet.Accounts)



    End Sub

    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click

        If txtPass.Text = cboUsers.SelectedValue.ToString.Trim Then
            If cboUsers.Text = "Admin" Then
                Dim frmAdmin As New Main
                frmAdmin.Admin = True
            End If
            Dim frmmain As New Main
                frmmain.Active = True
                frmmain.ShowDialog()

            Else

                MessageBox.Show("Invalid Password")

            Return
        End If
        Me.Close()


    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub CheckLogin()




    End Sub


End Class
