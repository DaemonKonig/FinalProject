Public Class NewCookieSheet
    Private mCookies As New Cookies
    Private mUserName As New Accounts

    Private Sub Input_Load(sender As Object, e As EventArgs) Handles MyBase.Load




    End Sub

    Private Sub btnSub_Click(sender As Object, e As EventArgs) Handles btnSub.Click
        Dim Scheduled As DateTime
        Try
            Scheduled = Cookies.CombinedDateTime(dtpDate.Value.Date, CDate("12:00"))

        Catch ex As Exception

        End Try


        Dim UserName As Short = CShort()


        If mCookies.insert(UserName, Scheduled, txtMints.Text, txtCaramel.Text, txtPatties.Text, txtBread.Text, txtComments.Text, txtZip.Text) Then
            Me.Close()
        Else

        End If


    End Sub

    Private Sub btnClr_Click(sender As Object, e As EventArgs) Handles btnClr.Click



    End Sub

    Private Sub btnCncl_Click(sender As Object, e As EventArgs) Handles btnCncl.Click



    End Sub

    Private Sub dtpDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpDate.ValueChanged

    End Sub
End Class