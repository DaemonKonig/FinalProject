Public Class Main
    Public NewCookie As Boolean
    Public Change As Boolean
    Private Sub ViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmAddTrpr.Click
        Users.ShowDialog()
    End Sub

    Private Sub tsmNCS_Click(sender As Object, e As EventArgs) Handles tsmNCS.Click
        NewCookieSheet.ShowDialog()
        NewCookie = False
    End Sub

    Private Sub tsmInvent_Click(sender As Object, e As EventArgs) Handles tsmInvent.Click
        NewCookieSheet.ShowDialog()
        NewCookie = True
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub tsmCkieSht_Click(sender As Object, e As EventArgs) Handles tsmCkieSht.Click
        View.ShowDialog()
    End Sub

    Private Sub tsmViewTrp_Click(sender As Object, e As EventArgs) Handles tsmViewTrp.Click

    End Sub

    Private Sub tsmChangeCS_Click(sender As Object, e As EventArgs) Handles tsmChangeCS.Click
        Modify.ShowDialog()
        Change = False
    End Sub

    Private Sub tsmChangeTrpr_Click(sender As Object, e As EventArgs) Handles tsmChangeTrpr.Click
        Modify.ShowDialog()
        Change = True
    End Sub

    Private Sub tsmClose_Click(sender As Object, e As EventArgs) Handles tsmClose.Click
        Me.Close()
    End Sub
End Class