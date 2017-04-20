Imports FinalProject.Login
Public Class Accounts
    Private Active As New Login

    Private adapter As New GSCDataSetTableAdapters.AccountsTableAdapter

    Public Function insert(ByVal Username As String, ByVal Password As String, ByVal PhoneNumber As Integer, ByVal Message As String)
        Try
            adapter.Insert(Username, Password, PhoneNumber, Message)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function Update(ByVal Username As String, ByVal Password As String, ByVal PhoneNumber As Integer, ByVal userId As Integer, ByVal Message As String) As Boolean
        Try
            adapter.Update(Username, Password, PhoneNumber, Message, userId)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function Delete(ByVal UserId As Integer) As Boolean
        Dim rowsAffected As Integer = adapter.Delete(UserId)
        Return rowsAffected > 0

    End Function

    Public ReadOnly Property items As DataTable
        Get
            Return adapter.GetData()

        End Get
    End Property

    Public Function GetByUserId(ByVal UserId As Integer) As GSCDataSet.AccountsRow
        Dim table As GSCDataSet.AccountsDataTable
        table = adapter.GetData()
        Return table.FindByUserId(UserId)
    End Function

End Class
