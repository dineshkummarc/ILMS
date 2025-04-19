Public Class frminventory

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Dim typeofAction As String
        typeofAction = "Saved"
        If btnsave.Text = "Save Item" Then
            issucess = jokeninsert("INSERT INTO `tblitem` (`ITEMID`, `ITEMNAME`, `ITEMCOLOR`, `ITEMBRAND`, `ITEMDESC`, `REMARKS`, `ITEMSTATUS`) " & _
                  " VALUES (NULL, '" & txtitemname.Text & "', '" & txtcolor.Text & "', '" & txtbrand.Text & "', '" & txtdescription.Text & "', '" & txtremarks.Text & "', '" & txtstatus.Text & "');")
            typeofAction = "Saved"
        ElseIf btnsave.Text = "Modify Item" Then
            issucess = jokenupdate("UPDATE `tblitem` SET `ITEMNAME` = '" & txtitemname.Text & "', `ITEMCOLOR` = '" & txtcolor.Text & "', `ITEMBRAND` = '" & txtbrand.Text & "', " & _
                        " `ITEMDESC` = '" & txtdescription.Text & "', `REMARKS` = '" & txtremarks.Text & "', `ITEMSTATUS` ='" & txtstatus.Text & "' WHERE `ITEMID` = " & Me.Text & "")
            typeofAction = "Modified"
        End If

        If issucess = True Then
            MsgBox("New Item Inventory has been " & typeofAction)
        Else
            MsgBox("No Item Inventory has been " & typeofAction)
        End If

        closeChildForm()
        anyfrm(frminventorylist)
    End Sub
End Class