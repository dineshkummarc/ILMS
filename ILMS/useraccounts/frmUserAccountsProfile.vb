Public Class frmUserAccountsProfile

    
    
    Private Sub frmUserAccountsProfile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Height = 340

        jokenfindthis("SELECT  `ACCOUNT_ID` ,  `ACCOUNT_NAME` AS Name,  `ACCOUNT_USERNAME` AS Username,  `ACCOUNT_TYPE` AS Type, empid FROM useraccounts")
        fillTable(DataGridView1, "LoadUser")

    End Sub

    
    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        If Label6.Text = "Show List of Users" Then
            Me.Height = 548
            Label6.Text = "Hide list of users"
        ElseIf Label6.Text = "Hide list of users" Then
            Me.Height = 340
            Label6.Text = "Show List of Users"
        End If
    End Sub

    
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        jokenfindthis("select * from useraccounts where empid =" & txtEmpid.Text & "")

        If DefaultResult() = True Then
            MsgBox("Employee ID already exist.")
        Else

            jokeninsert("insert into useraccounts (account_name, account_username, account_password, account_type, empid) values ('" & _
                                             txtname.Text & "','" & txtuname.Text & "', '" & txtpass.Text & "','" & cbtype.Text & "'," & txtEmpid.Text & ")")
            ClearAll(GroupBox1, "UserAccounts")

        End If


       


    End Sub

    Private Sub btndel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndel.Click
        jokendelete("delete from useraccounts where account_id = " & lblid.Text & "")
        ClearAll(GroupBox1, "UserAccounts")

    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        lblid.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        txtname.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        txtuname.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        cbtype.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        txtEmpid.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString


    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click

        If txtpass.Text <> txtconfirm.Text Then
            MsgBox("Password Confirmation did not match!", MsgBoxStyle.Information)
        Else
            jokenupdate("UPDATE useraccounts set account_name ='" & txtname.Text & "', account_username = '" & txtuname.Text & "', account_password = ('" & txtpass.Text & "'), account_type= '" & cbtype.Text & "' where account_id = " & lblid.Text & "")
            ClearAll(GroupBox1, "UserAccounts")

        End If

    End Sub
End Class