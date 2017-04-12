Imports FinalProject.Login
Imports System.IO
Public Class Users
    Private NewUser As New Dictionary(Of String, Logins)

    Private Sub btnSub_Click(sender As Object, e As EventArgs) Handles btnSub.Click
        CreateUser()

    End Sub

    Private Sub CreateUser()
        Dim UserName As String = txtName.Text
        Dim PassWord As String = txtPass.Text
        Dim outFile As StreamWriter = File.AppendText("UserInformation.txt")

        If UserName & PassWord IsNot "" Then
            outFile.WriteLine(UserName & "," & PassWord)
            outFile.Close()
            MessageBox.Show("User has been added")
        Else
            MessageBox.Show("Please enter a valid username and password")
            Return
        End If




    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class