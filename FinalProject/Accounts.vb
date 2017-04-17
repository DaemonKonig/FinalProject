Public Class Accounts
    Private adapter As GSCDataSetTableAdapters.AccountsTableAdapter

    Public Function insert(ByVal Username As String, ByVal Password As String, ByVal PhoneNumber As Integer)
        Try
            adapter.Insert(Username, Password, PhoneNumber)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public ReadOnly Property Items() As DataTable
        Get
            Dim table As DataTable = adapter.GetData()
            table.DefaultView.Sort = "UserName"
            Return table
        End Get
    End Property

    Public Function Update(ByVal Username As String, ByVal Password As String, ByVal PhoneNumber As Integer, ByVal userId As Integer) As Boolean
        Try
            adapter.Update(Username, Password, PhoneNumber, userId)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function Delete(ByVal UserId As Integer) As Boolean
        Dim rowsAffected As Integer = adapter.Delete(UserId)
        Return rowsAffected > 0

    End Function

End Class
