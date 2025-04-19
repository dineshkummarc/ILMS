﻿Module jokenlibrary
    Public Sub LoadSemester()
        sql = "SELECT listname FROM(tblcommon_list) WHERE category = 'SEMESTER' and isdefault =  'YES'"
        jokenfindthis(sql)
        LoadSingleResult("isdefaultsem")
    End Sub
    Public Sub LoadAY()
        sql = "SELECT listname FROM(tblcommon_list) WHERE category = 'AY' and isdefault =  'YES'"
        jokenfindthis(sql)
        LoadSingleResult("isdefaultay")
    End Sub
    Public Sub writeThisError(ByVal errMsg As String)
        Try
            Dim FILE_NAME As String = Application.StartupPath & "\errorlogfile.txt"
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, True)

            objWriter.WriteLine(errMsg)
            objWriter.Close()
        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub


    Public Function DefaultResultID() As Integer
        Dim table As New DataTable

        Try
            da.SelectCommand = cmd
            da.Fill(table)

            If table.Rows.Count > 0 Then

                Return table.Rows(0).Item(0)

            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Function

    Public Function DefaultResult() As Boolean
        Dim table As New DataTable

        Try
            da.SelectCommand = cmd
            da.Fill(table)

            If table.Rows.Count > 0 Then

                Return True
            Else

                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function
    Public Function isemptyresult() As Integer
        Try
            If GetNumRows() > 0 Then

                Return GetNumRows()

            End If
        Catch ex As Exception
            writeThisError(Format(Now, "Long Date") & " " & Date.Now.ToString("H:mm:ss") & " ===>> " & ex.Message)
            MsgBox(ex.Message)
        End Try


    End Function
    Public Function GetCount() As Integer
        Dim table As New DataTable
        Try
            da.SelectCommand = cmd
            da.Fill(table)

            Return table.Rows(0).Item(0)

        Catch ex As Exception
            writeThisError(Format(Now, "Long Date") & " " & Date.Now.ToString("H:mm:ss") & " ===>> " & ex.Message)
            MsgBox(ex.Message)
        End Try
        Return Nothing
    End Function

    Public Function GetNumRows() As Integer
        Dim table As New DataTable
        Try
            da.SelectCommand = cmd
            da.Fill(table)

            Return table.Rows.Count

        Catch ex As Exception
            writeThisError(Format(Now, "Long Date") & " " & Date.Now.ToString("H:mm:ss") & " ===>> " & ex.Message)
            MsgBox(ex.Message)
        End Try
        Return Nothing
    End Function

#Region "Auto Fill"

    Public Sub autofill(ByVal txt As Object)
        Dim publictable As New DataTable

        Try
            da.SelectCommand = cmd
            da.Fill(publictable)

            Dim r As DataRow

            txt.AutoCompleteCustomSource.Clear()
            'for each datarow in the rows of the datatable
            For Each r In publictable.Rows
                'adding the specific row of the table in the AutoCompleteCustomSource of the textbox
                txt.AutoCompleteCustomSource.Add(r.Item("ACCOUNT_USERNAME").ToString)
            Next


            da.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try

    End Sub

    Public Sub autofillid(ByVal txt As Object)
        Dim publictable As New DataTable

        Try
            da.SelectCommand = cmd
            da.Fill(publictable)

            Dim r As DataRow

            txt.AutoCompleteCustomSource.Clear()
            'for each datarow in the rows of the datatable
            For Each r In publictable.Rows
                'adding the specific row of the table in the AutoCompleteCustomSource of the textbox
                txt.AutoCompleteCustomSource.Add(r.Item("IDNO").ToString)
            Next


            da.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try

    End Sub

#End Region
#Region "Fill Combo Box"

    Public Sub fillcombo(ByVal combo As Object, ByVal member As String, ByVal idparam As String)
        Dim publictable As New DataTable
        Try
            da.SelectCommand = cmd
            da.Fill(publictable)
            With combo
                .DataSource = publictable
                .displaymember = member
                .valuemember = idparam
            End With

            da.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

#End Region
    Public Sub closeChildForm()
        For Each ChildForm As Form In main.MdiChildren
            ChildForm.Close()
        Next
    End Sub
    Public Sub anyfrm(ByVal frm As Object)

        With frm

            .MdiParent = main
            ' .Dock = DockStyle.Fill
            .Show()
        End With

    End Sub
End Module
