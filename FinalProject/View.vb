﻿Public Class View





    Private Sub rdoSold_CheckedChanged(sender As Object, e As EventArgs) Handles rdoSold.CheckedChanged
        If rdoSold.Checked = True Then
            dvgCookie.Visible = True
            dgvInvent.Visible = False

        End If
    End Sub

    Private Sub rdoInvent_CheckedChanged(sender As Object, e As EventArgs) Handles rdoInvent.CheckedChanged
        If rdoInvent.Checked = True Then
            dvgCookie.Visible = False
            dgvInvent.Visible = True

        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub View_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GSCDataSet.Cookies' table. You can move, or remove it, as needed.
        Me.CookiesTableAdapter.Fill(Me.GSCDataSet.Cookies)
        'TODO: This line of code loads data into the 'GSCDataSet.Inventory' table. You can move, or remove it, as needed.
        Me.InventoryTableAdapter.Fill(Me.GSCDataSet.Inventory)




        rdoSold.Checked = True
        dgvInvent.Visible = False
    End Sub



    Private Sub tscboUser_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub tscboUser_SelectedIndexChanged(sender As Object, e As EventArgs) 

    End Sub
End Class