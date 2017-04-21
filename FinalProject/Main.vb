Imports FinalProject.Login
Public Class Main
    Public Active As Boolean


    Private Sub ViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmAddTrpr.Click
        Users.ShowDialog()
    End Sub

    Private Sub tsmNCS_Click(sender As Object, e As EventArgs) Handles tsmNCS.Click
        NewCookieSheet.ShowDialog()

    End Sub

    Private Sub tsmInvent_Click(sender As Object, e As EventArgs) Handles tsmInvent.Click
        NewInven.ShowDialog()

    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Active = False Then
            Me.Close()
        End If



    End Sub

    Private Sub tsmCkieSht_Click(sender As Object, e As EventArgs) Handles tsmCkieSht.Click
        View.ShowDialog()
    End Sub

    Private Sub tsmViewTrp_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub tsmChangeCS_Click(sender As Object, e As EventArgs)
        Modify.ShowDialog()

    End Sub

    Private Sub tsmChangeTrpr_Click(sender As Object, e As EventArgs)
        Modify.ShowDialog()

    End Sub

    Private Sub tsmClose_Click(sender As Object, e As EventArgs) Handles tsmClose.Click
        Me.Close()
    End Sub

    Private Sub lblLogged_Click(sender As Object, e As EventArgs) Handles lblLogged.Click

    End Sub

    Private Sub CookiesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CookiesToolStripMenuItem.Click
        ViewMod.ShowDialog()
    End Sub

    Private Sub InventoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventoryToolStripMenuItem.Click
        ViewInven.ShowDialog()
    End Sub

    Private Sub TroopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TroopToolStripMenuItem.Click
        ViewTroop.ShowDialog()
    End Sub
End Class