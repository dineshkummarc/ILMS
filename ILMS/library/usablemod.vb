Imports MySql.Data.MySqlClient
Module usablemod


#Region "Enable Menu"

    Public Sub enabledmenu(ByVal who As String)

        Select Case who

            Case "Admin"

                main.tlmasterfiles.Enabled = True
                main.tlsEnrollment.Enabled = True
                main.tlsInventory.Enabled = True
                main.tlreports.Enabled = True
                main.tlsettings.Enabled = True

        End Select


    End Sub

#End Region

#Region "Disable Menu"

    Public Sub disabledmenu()

        main.tlmasterfiles.Enabled = False
        main.tlsEnrollment.Enabled = False
        main.tlsInventory.Enabled = False
        main.tlreports.Enabled = False
        main.tlsettings.Enabled = False

    End Sub

#End Region




#Region "Fill Table"

    Public Sub LoadData(ByVal obj As Object, ByVal param As String)
        Try

            con.Open()
            dReader = cmd.ExecuteReader()
            '  obj.Rows.Clear()
            Select Case param
                Case "STUDENTLIST"
                    obj.Rows.Clear()
                    Do While dReader.Read = True
                        obj.Rows.Add(dReader(0), dReader(1), dReader(2), dReader(3), dReader(4), dReader(5), dReader(6), dReader(7))
                    Loop
                Case "enrollment"
                    obj.Rows.Clear()
                    Do While dReader.Read = True
                        obj.Rows.Add(dReader(0), dReader(1), dReader(2), dReader(3), dReader(4), dReader(5), dReader(6))
                    Loop
                Case "inventorylist"
                    obj.Rows.Clear()
                    Do While dReader.Read = True
                        obj.Rows.Add(dReader(0), dReader(1), dReader(2), dReader(3), dReader(4), dReader(5), dReader(6))
                    Loop
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            da.Dispose()
            con.Close()
        End Try
    End Sub
 


    Public Sub fillTable(ByVal dtgrd As Object, ByVal design As String)
        Dim publictable As New DataTable

        Try
            da.SelectCommand = cmd
            da.Fill(publictable)
            dtgrd.DataSource = publictable

            Select Case design


                Case "defaults"
                    dtgrd.Columns(0).Visible = False
                    dtgrd.Columns(1).Visible = False
                    dtgrd.Columns(2).Visible = False


            End Select

            da.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try

    End Sub

#End Region

#Region "Clear All Text"

    Public Sub ClearAll(ByVal group As Object, ByVal what As String)

        Select Case what

            Case "UserAccounts"
                For Each ctrl As Control In group.Controls
                    If ctrl.GetType Is GetType(TextBox) Then
                        ctrl.Text = Nothing
                    End If
                Next

            Case "AddInstructor"
                For Each ctrl As Control In group.Controls
                    If ctrl.GetType Is GetType(TextBox) Then
                        ctrl.Text = Nothing
                    End If
                Next
                

        End Select

    End Sub


#End Region
   



End Module
