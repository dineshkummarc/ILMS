﻿Public Class LoginForm1

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        sql = "SELECT * FROM `useraccounts` WHERE `ACCOUNT_USERNAME`='" & UsernameTextBox.Text & "' AND `ACCOUNT_PASSWORD`='" & PasswordTextBox.Text & "' "
        jokenfindthis(sql)

        If GetNumRows() = 1 Then
            LoadSingleResult("login")
            LoadAY()
            LoadSemester()

        Else
            MsgBox("Username or Passwrord does registered, Please contact administrator!")

        End If
        ' CheckResult("login")

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
