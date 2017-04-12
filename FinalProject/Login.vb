Imports FinalProject.Logins
Imports System.IO
Public Class Login


    Dim AllUsers As New Dictionary(Of String, Logins)
    Dim AllPass As New Dictionary(Of String, Logins)



    Dim Allow As Boolean = False

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim infile As StreamReader
        Try
            infile = File.OpenText("UserInformation.txt")
            While Not infile.EndOfStream
                Dim entireline As String = infile.ReadLine()
                Dim tokens() As String = entireline.Split(","c)
                Dim LoginData As New Logins(tokens(0), tokens(1))
                AllUsers.Add(LoginData.UserName, LoginData)
                AllPass.Add(LoginData.Password, LoginData)
            End While
            infile.Close()
        Catch ex As Exception
            MessageBox.Show("FileNotFound")
            Me.Close()
        End Try

    End Sub

    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        CheckLogin()
        If Allow = True Then
            Main.ShowDialog()

        End If



    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub CheckLogin()
        Dim AllowUser As Boolean = False
        Dim AllowPass As Boolean = False
        Dim chkUser As String
        Dim chkPass As String

        chkUser = txtUser.Text
        chkPass = txtPass.Text


        If AllUsers.ContainsKey(chkUser) Then
            AllowUser = True
        Else
            MessageBox.Show("UserName Not Found")
                Return
            End If

        If AllPass.ContainsKey(chkPass) Then
            AllowPass = True
        Else
            MessageBox.Show("Invalid Password")
                Return
            End If

       
        If AllowUser And AllowPass = True Then
            Allow = True
        End If
    End Sub


End Class
