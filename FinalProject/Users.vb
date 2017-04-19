Imports FinalProject.Login
Imports System.IO
Public Class Users
    Private mAccounts As New Accounts

    Private Sub btnSub_Click(sender As Object, e As EventArgs) Handles btnSub.Click



        If mAccounts.insert(txtName.Text, txtPass.Text, txtPhone.Text, txtName.Text) Then
            Me.Close()
        Else
            MessageBox.Show("Unable to add new user")
        End If


    End Sub









    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class