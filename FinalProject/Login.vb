Imports FinalProject.Logins
Imports System.IO
Public Class Login
    Public activeUser As String = ""

    Dim AllUsers As New List(Of String)
    Dim AllPass As New List(Of String)



    Dim Allow As Boolean = False
    Dim Combo As Boolean = False

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim infile As StreamReader = File.OpenText("UserInformation.txt")
        Try
            While Not infile.EndOfStream
                Dim entireline As String = infile.ReadLine()
                Dim tokens() As String = entireline.Split(","c)
                Dim LoginData As New Logins(tokens(0), tokens(1))
                AllUsers.Add(LoginData.UserName)
                AllPass.Add(LoginData.Password)
            End While
            infile.Close()
        Catch ex As Exception
            MessageBox.Show("FileNotFound")
            Me.Close()
        End Try

    End Sub

    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        CheckLogin()

        If Allow And Combo = True Then
            Main.ShowDialog()
        Else
            MessageBox.Show("Invalid Combination")
            Return
        End If

        activeUser = txtUser.Text

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub CheckLogin()
        Dim AllowUser As Boolean = False
        Dim AllowPass As Boolean = False
        Dim chkUser As String
        Dim chkPass As String
        Dim idxUser As Integer
        Dim idxPass As Integer

        chkUser = txtUser.Text
        chkPass = txtPass.Text


        If AllUsers.Contains(chkUser) Then
            AllowUser = True
            idxUser = AllUsers.IndexOf(chkUser)
        Else
            MessageBox.Show("UserName Not Found")
                Return
            End If

        If AllPass.Contains(chkPass) Then
            AllowPass = True
            idxPass = AllUsers.IndexOf(chkUser)
        Else
            MessageBox.Show("Invalid Password")
                Return
            End If

        If idxPass = idxUser Then
            Combo = True
        Else
            MessageBox.Show("Invalid Username and Password")
        End If
        If AllowUser And AllowPass = True Then
            Allow = True
        Else
            MessageBox.Show("Invalid Username and Password")
            Return
        End If
    End Sub


End Class
