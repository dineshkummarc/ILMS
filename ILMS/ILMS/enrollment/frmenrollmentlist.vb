Public Class frmenrollmentlist

    Private Sub frmenrollmentlist_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        jokenfindthis("SELECT `STUDENTID`,`STUDENTNAME`,COURSE, YEARLEVEL,`SEMESTER`,`AY`, `TIMEALLOTED` FROM `tblenrollment` WHERE SEMESTER='" & sem & "' and AY='" & ay & "'")
        LoadData(DataGridView1, "enrollment")
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        frmEnrollment.Show()
    End Sub
End Class