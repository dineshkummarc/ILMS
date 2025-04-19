
Imports MySql.Data.MySqlClient


Module jokensqlstatements

    Public Sub jokenfindthis(ByVal sql As String)
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            con.Close()
            da.Dispose()
        End Try


    End Sub
    Public Sub LoadSingleResult(ByVal param As String)

        Try

            con.Open()
            dReader = cmd.ExecuteReader()
            Select Case param
                Case "studentEnrollment"
                    Do While dReader.Read = True
                        With frmEnrollment
                            .txtidnum.Text = dReader("IDNO")
                            .txtfullname.Text = dReader("LNAME") & ", " & dReader("FNAME") & " " & dReader("MNAME")


                        End With

                    Loop
                Case "Inventory"
                    Do While dReader.Read = True
                        With frminventory
                            .txtitemname.Text = dReader(1)
                            .txtcolor.Text = dReader(2)
                            .txtbrand.Text = dReader(3)
                            .txtdescription.Text = dReader(4)
                            .txtremarks.Text = dReader(5)
                            .txtstatus.Text = dReader(6)
                            .Text = dReader(0)
                            .btnsave.Text = "Modify Item"

                            .Show()
                        End With

                    Loop
                Case "student"
                    Do While dReader.Read = True
                        '`IDNO`, `FNAME`, `LNAME`, `MNAME`, `SEX`, `BDAY`, `AGE`, `CONTACT_NO`, `HOME_ADD`, `EMAIL`, `ACC_PASSWORD`
                        With frmstudent
                            .txtidnum.Enabled = False
                            .txtidnum.Text = dReader("IDNO")
                            .FNAME.Text = dReader("FNAME")
                            .LNAME.Text = dReader("LNAME")
                            .MNAME.Text = dReader("MNAME")


                            If dReader("SEX") = "Male" Then
                                .RadioButtonMale.Checked = True
                                .RadioButtonFemale.Checked = False
                            ElseIf dReader("SEX") = "Female" Then
                                .RadioButtonMale.Checked = False
                                .RadioButtonFemale.Checked = True

                            End If
                            .dtpBday.Text = Format(dReader("BDAY"), "yyyy-MM-dd")
                            .txtage.Text = dReader("AGE")
                            .CONTACT.Text = dReader("CONTACT_NO")
                            .ADDRESS.Text = dReader("HOME_ADD")
                            .EMAIL.Text = dReader("EMAIL")
                            .txtpassword.Text = dReader("ACC_PASSWORD")
                            .txtpassword.Enabled = True
                            .Show()
                            .btnSave.Enabled = True
                            .btnSave.Text = "Update"

                        End With
                    Loop
                Case "login"
                    Do While dReader.Read = True

                        ACCOUNT_NAME = dReader("ACCOUNT_NAME")
                        ACCOUNT_USERNAME = dReader("ACCOUNT_USERNAME")
                        ACCOUNT_TYPE = dReader("ACCOUNT_TYPE")
                        EMPID = dReader("EMPID")
                        main.btnlogin.Text = "Logout"
                        main.btnlogin.Image = ILMS.My.Resources.Resources.logout
                        main.TSUser.Text = "Hi, " & fullname
                        enabledmenu("Admin")
                        LoginForm1.Close()
                    Loop
                Case "isdefaultsem"
                    Do While dReader.Read = True
                        sem = dReader("listname")
                    Loop
                Case "isdefaultay"
                    Do While dReader.Read = True
                        ay = dReader("listname")
                    Loop
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            da.Dispose()
            con.Close()
        End Try
    End Sub



End Module
