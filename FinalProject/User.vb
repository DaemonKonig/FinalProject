Public Class User
    Private adapter As New GSCDataSetTableAdapters.AccountsTableAdapter

    Public ReadOnly Property Items() As DataTable
        Get
            Dim table As DataTable = adapter.GetData()
            table.DefaultView.Sort = "UserName"
            Return table
        End Get
    End Property
End Class
