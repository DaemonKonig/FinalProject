Public Class Pass
    Private adapter As New GSCDataSetTableAdapters.AccountsTableAdapter

    Public ReadOnly Property Items() As DataTable
        Get
            Dim table As DataTable = adapter.GetData()
            table.DefaultView.Sort = "Password"
            Return table
        End Get
    End Property
End Class
