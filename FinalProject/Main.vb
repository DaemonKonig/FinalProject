Imports FinalProject.Login
Public Class Main
    Public Active As Boolean
    Public Admin As Boolean

    Private Sub ViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmAddTrpr.Click
        If Admin = True Then
            Users.ShowDialog()
        Else
            MessageBox.Show("Admin Access Only")
        End If

    End Sub

    Private Sub tsmNCS_Click(sender As Object, e As EventArgs) Handles tsmNCS.Click
        NewCookieSheet.ShowDialog()

    End Sub

    Private Sub tsmInvent_Click(sender As Object, e As EventArgs) Handles tsmInvent.Click
        If Admin = True Then
            NewInven.ShowDialog()
        Else
            MessageBox.Show("Admin Access Only")
        End If


    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Active = False Then
            Me.Close()
        End If



    End Sub

    Private Sub tsmCkieSht_Click(sender As Object, e As EventArgs) Handles tsmCkieSht.Click
        View.ShowDialog()
    End Sub

    Private Sub tsmChangeCS_Click(sender As Object, e As EventArgs)
        If Admin = True Then
            Modify.ShowDialog()
        Else
            MessageBox.Show("Admin Access Only")
        End If

    End Sub

    Private Sub tsmClose_Click(sender As Object, e As EventArgs) Handles tsmClose.Click
        Me.Close()
    End Sub

    Private Sub CookiesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CookiesToolStripMenuItem.Click
        If Admin = True Then
            ViewMod.ShowDialog()
        Else
            MessageBox.Show("Admin Access Only")
        End If
    End Sub

    Private Sub InventoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventoryToolStripMenuItem.Click
        If Admin = True Then
            ViewInven.ShowDialog()
        Else
            MessageBox.Show("Admin Access Only")
        End If

    End Sub

    Private Sub TroopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TroopToolStripMenuItem.Click
        If Admin = True Then
            ViewTroop.ShowDialog()
        Else
            MessageBox.Show("Admin Access Only")
        End If
    End Sub
End Class