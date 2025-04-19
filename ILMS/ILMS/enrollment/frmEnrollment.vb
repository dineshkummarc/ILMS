Public Class frmEnrollment

    Private Sub frmEnrollment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'LoadAY()
        'LoadSemester()
        txtay.Text = ay
        txtsem.Text = sem
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FlagStudent = "Enrollment"
        closeChildForm()
        anyfrm(frmListStudent)


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            jokenfindthis("SELECT * FROM `tblenrollment` WHERE `STUDENTID`='" & txtidnum.Text & "' and `SEMESTER`='" & txtsem.Text & "' AND `AY`='" & txtay.Text & "'")
           

            issucess = jokeninsert("INSERT INTO `tblenrollment` (`ENROLLMENTID`, `STUDENTNAME`, `STUDENTID`,`COURSE`, `YEARLEVEL`, `SEMESTER`, `AY`, `TIMEALLOTED`)" & _
                            " VALUES (NULL, '" & txtfullname.Text & "', '" & txtidnum.Text & "', '" & txtcourse.Text & "','" & txtyrlevel.Text & "','" & txtsem.Text & "', '" & txtay.Text & "', '" & txttime.Text & "');")
            If issucess = True Then
                MsgBox("Student has been successfully Enrolled!")
            Else
                MsgBox("Student has not been Enrolled!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        closeChildForm()
        anyfrm(frmenrollmentlist)
    End Sub
End Class