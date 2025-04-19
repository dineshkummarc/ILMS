Public Class frmstudent

    Dim gender As String
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        bdaystring = Format(dtpBday.Value, "yyyy-MM-dd")
        If RadioButtonMale.Checked = True Then
            gender = "Male"
        End If
        If RadioButtonFemale.Checked = True Then
            gender = "Female"
        End If
      
        If btnSave.Text = "Save" Then
            jokenfindthis("SELECT COUNT(*) FROM `tblstudent` WHERE `IDNO`='" & txtidnum.Text & "'")

            If GetCount() > 0 Then
                MsgBox("ID Number already exist!")
            Else
                If txtidnum.Text = "" Then
                    ErrorProvider1.SetError(txtidnum, "ID Number is Required!")
                    If LNAME.Text = "" Then
                        ErrorProvider2.SetError(LNAME, "Last Name is Required!")
                        If FNAME.Text = "" Then
                            ErrorProvider3.SetError(FNAME, "First Name is Required!")
                        End If
                    End If
                Else

                    issucess = jokeninsert("INSERT INTO `tblstudent` (`IDNO`, `FNAME`, `LNAME`, `MNAME`, " & _
                           " `SEX`, `BDAY`, `AGE`, `CONTACT_NO`, `HOME_ADD`, `EMAIL`, `ACC_PASSWORD`) " & _
                           " VALUES ('" & txtidnum.Text & "', '" & FNAME.Text & "', '" & LNAME.Text & "', '" & MNAME.Text & "', " & _
                           " '" & gender & "', '" & bdaystring & "', '" & txtage.Text & "', '" & CONTACT.Text & "', '" & ADDRESS.Text & "', '" & EMAIL.Text & "', '1234');")

                    If issucess = True Then
                        MsgBox("New student has been added successfully!")
                    Else
                        MsgBox("No student has been added!")
                    End If
                    closeChildForm()
                    anyfrm(frmListStudent)
                End If
            End If
        ElseIf btnSave.Text = "Update" Then

            If txtidnum.Text = "" Then
                ErrorProvider1.SetError(txtidnum, "ID Number is Required!")
                If LNAME.Text = "" Then
                    ErrorProvider2.SetError(LNAME, "Last Name is Required!")
                    If FNAME.Text = "" Then
                        ErrorProvider3.SetError(FNAME, "First Name is Required!")
                    End If
                End If
            Else

                issucess = jokenupdate("UPDATE tblstudent SET `FNAME`='" & FNAME.Text & "', `LNAME`='" & LNAME.Text & "', " & _
                                       " `MNAME`= '" & MNAME.Text & "', `SEX`='" & gender & "', `BDAY`='" & bdaystring & "', " & _
                                       " `AGE`= '" & txtage.Text & "', `CONTACT_NO`='" & CONTACT.Text & "', `HOME_ADD`='" & ADDRESS.Text & "', `EMAIL`='" & EMAIL.Text & "', `ACC_PASSWORD`='" & txtpassword.Text & "' WHERE IDNO='" & txtidnum.Text & "'")
                If issucess = True Then
                    MsgBox("Student has been updated successfully!")
                Else
                    MsgBox("No student has been updated!")
                End If
                closeChildForm()
                anyfrm(frmListStudent)
            End If

        Else

            MsgBox("DO nothing!")
        End If

        Me.Close()
    End Sub

    Private Sub frmstudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub dtpBday_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpBday.TextChanged

        Dim diffdate As Integer
        diffdate = Today.Year - dtpBday.Value.Year
        txtage.Text = diffdate
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub
End Class
