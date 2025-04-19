Imports System.Windows.Forms

Public Class main

    
    Private Sub studentmenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles studentmenu.Click
        FlagStudent = "LoadStudent"
        closeChildForm()
        anyfrm(frmListStudent)
    End Sub

    Private Sub main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        disabledmenu()
    End Sub

    Private Sub FacilitatorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacilitatorToolStripMenuItem.Click
        closeChildForm()
        anyfrm(frmUserAccountsProfile)
    End Sub

    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        If btnlogin.Text = "Login" Then
            LoginForm1.Show()

        Else
            btnlogin.Text = "Login"
            btnlogin.Image = ILMS.My.Resources.Resources.Login_icon
            TSUser.Text = "Hi, Guest!"
            ' lblWelcome.Text = ""
            disabledmenu()
            'unsetUserVariables()
        End If
    End Sub

    Private Sub tlsEnrollment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlsEnrollment.Click
        closeChildForm()
        anyfrm(frmenrollmentlist)
    End Sub

    Private Sub DefaultsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefaultsToolStripMenuItem.Click
        closeChildForm()
        anyfrm(frmDefaults)
    End Sub

    Private Sub tlsInventory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlsInventory.Click
        closeChildForm()
        anyfrm(frminventorylist)
    End Sub

    Private Sub tlreports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlreports.Click

    End Sub
End Class
