Public Class Cookies
    Private adapter As GSCDataSetTableAdapters.CookiesTableAdapter

    Public Function insert(ByVal UserName As Short, ByVal Scheduled As DateTime, ByVal ThinMints As Integer, ByVal caramel_deLites As Integer, ByVal PeanutButter_Patties As Integer, ByVal ShortBread As Integer, ByVal comments As String, ByVal zipcode As Integer)
        Try
            adapter.Insert(UserName, Scheduled, ThinMints, caramel_deLites, PeanutButter_Patties, ShortBread, comments, zipcode)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public ReadOnly Property items As DataTable
        Get
            Return adapter.GetData()

        End Get
    End Property

    Public Shared Function CombinedDateTime(ByVal aDate As DateTime, ByVal aTime As DateTime) As DateTime
        Dim ts As New TimeSpan(aTime.Hour, aTime.Minute, 0)
        Return aDate.Add(ts)
    End Function

    Public Function Update(ByVal UserName As Short, ByVal Scheduled As DateTime, ByVal ThinMints As Integer, ByVal Caramel_deLites As Integer, ByVal PeanutButter_Patties As Integer, ByVal ShortBread As Integer, ByVal comments As String, ByVal zipcode As Integer, ByVal CookieId As Integer) As Boolean
        Try
            adapter.Update(UserName, Scheduled, ThinMints, Caramel_deLites, PeanutButter_Patties, ShortBread, comments, zipcode, CookieId)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function Delete(ByVal CookieId As Integer) As Boolean
        Dim rowsAffected As Integer = adapter.Delete(CookieId)
        Return rowsAffected > 0

    End Function

    Public Function FindByCkieId(ByVal CkieId As Short) As GSCDataSet.CookiesRow
        Dim table As GSCDataSet.CookiesDataTable
        table = adapter.GetData()
        Return table.FindByCookieId(CkieId)
    End Function


End Class
