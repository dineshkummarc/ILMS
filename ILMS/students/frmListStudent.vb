Public Class frmListStudent

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        closeChildForm()
        anyfrm(frmstudent)
    End Sub

    Private Sub frmListStudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If FlagStudent = "LoadStudent" Then
            jokenfindthis("SELECT `IDNO`, CONCAT(`LNAME`,', ',`FNAME`, ' ',`MNAME`), `SEX`, `BDAY`, `AGE`, `CONTACT_NO`, `HOME_ADD`, `EMAIL` FROM `tblstudent`")
            LoadData(DataGridView1, "STUDENTLIST")
        ElseIf FlagStudent = "Enrollment" Then
            jokenfindthis("SELECT `IDNO`, CONCAT(`LNAME`,', ',`FNAME`, ' ',`MNAME`), `SEX`, `BDAY`, `AGE`, `CONTACT_NO`, `HOME_ADD`, `EMAIL` FROM `tblstudent` " & _
                          " WHERE `IDNO` NOT IN (SELECT `STUDENTID` FROM tblenrollment WHERE `SEMESTER` ='" & sem & "' and `AY`='" & ay & "')")
            LoadData(DataGridView1, "STUDENTLIST")
        End If

       
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If FlagStudent = "LoadStudent" Then
            jokenfindthis("SELECT * FROM `tblstudent` WHERE `IDNO`='" & DataGridView1.CurrentRow.Cells(0).Value & "'")
            LoadSingleResult("student")
        ElseIf FlagStudent = "Enrollment" Then
            jokenfindthis("SELECT * FROM `tblstudent` WHERE `IDNO`='" & DataGridView1.CurrentRow.Cells(0).Value & "'")
            LoadSingleResult("studentEnrollment")
            closeChildForm()
            anyfrm(frmEnrollment)
        End If
       

    End Sub
End Class