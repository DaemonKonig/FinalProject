Public Class View

    Private mUser As New User


    Private Sub rdoSold_CheckedChanged(sender As Object, e As EventArgs) Handles rdoSold.CheckedChanged
        If rdoSold.Checked = True Then
            dvgCookies.Visible = True
            dvgInven.Visible = False

        End If
    End Sub

    Private Sub rdoInvent_CheckedChanged(sender As Object, e As EventArgs) Handles rdoInvent.CheckedChanged
        If rdoInvent.Checked = True Then
            dvgCookies.Visible = False
            dvgInven.Visible = True

        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub View_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GSCDataSet1.Inventory' table. You can move, or remove it, as needed.
        Me.InventoryTableAdapter.Fill(Me.GSCDataSet1.Inventory)
        'TODO: This line of code loads data into the 'GSCDataSet1.Cookies' table. You can move, or remove it, as needed.
        Me.CookiesTableAdapter.Fill(Me.GSCDataSet1.Cookies)

        rdoSold.Checked = True





        With cboSrchFor
            .DataSource = mUser.Items
            .DisplayMember = "UserName"
            .ValueMember = "Id"
            .DropDownStyle = ComboBoxStyle.DropDownList
            .SelectedIndex = -1
        End With


    End Sub


End Class