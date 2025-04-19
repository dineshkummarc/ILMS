Public Class frminventorylist

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        frminventory.Show()

    End Sub

    Private Sub frminventorylist_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        jokenfindthis("SELECT `ITEMID`, `ITEMNAME`, `ITEMCOLOR`, `ITEMBRAND`, `ITEMDESC`, `REMARKS`, `ITEMSTATUS` FROM `tblitem`")
        LoadData(DataGridView1, "inventorylist")


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        jokenfindthis("SELECT * FROM `tblitem` WHERE `ITEMID` = " & DataGridView1.CurrentRow.Cells(0).Value & "")
        LoadSingleResult("Inventory")

    End Sub
End Class