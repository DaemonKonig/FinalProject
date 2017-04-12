Imports System.Data.OleDb
Public Class Logins
    Private mUserName As String
    Private mPassword As String

    Public Const UsrNmanPssWrd As String = "Logins.Text"


    Public ReadOnly Property UserName As String
        Get
            Return mUserName
        End Get
    End Property

    Public ReadOnly Property Password As String
        Get
            Return mPassword
        End Get
    End Property

    Public Sub New(ByVal pUsername As String, ByVal pPassword As String)
        mUserName = pUsername
        mPassword = pPassword

    End Sub
End Class
