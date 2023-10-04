
Imports System.DirectoryServices.ActiveDirectory
Imports System.Threading.Tasks.Dataflow
Imports MySql.Data.MySqlClient

Public Class frmDisplayStudent
    Dim yrno As Integer

    Private Sub frmDisplayStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkDatabaseConnection()
        prcDisplayStudent()
    End Sub

    Private Sub prcDisplayStudent()

        Try
            sqlUMTCAdapter = New MySqlDataAdapter
            datUMTC = New DataTable

            With command
                .Parameters.Clear()
                .CommandText = "prcDisplayStudents"
                .CommandType = CommandType.StoredProcedure
                sqlUMTCAdapter.SelectCommand = command
                datUMTC.Clear()
                sqlUMTCAdapter.Fill(datUMTC)
                lblTotal.Text = "TOTAL RECORDS: " & datUMTC.Rows.Count
                If datUMTC.Rows.Count > 0 Then
                    grdStudent.RowCount = datUMTC.Rows.Count
                    row = 0
                    While Not datUMTC.Rows.Count - 1 < row
                        grdStudent.Rows(row).Cells(0).Value = datUMTC.Rows(row).Item("id").ToString
                        grdStudent.Rows(row).Cells(1).Value = datUMTC.Rows(row).Item("studentid").ToString
                        grdStudent.Rows(row).Cells(2).Value = datUMTC.Rows(row).Item("lastname").ToString
                        grdStudent.Rows(row).Cells(3).Value = datUMTC.Rows(row).Item("firstname").ToString
                        grdStudent.Rows(row).Cells(4).Value = datUMTC.Rows(row).Item("middlename").ToString
                        grdStudent.Rows(row).Cells(5).Value = Format(Convert.ToDateTime(datUMTC.Rows(row).Item("birthdate").ToString), "MMM dd, yyyy")
                        grdStudent.Rows(row).Cells(6).Value = datUMTC.Rows(row).Item("gender").ToString
                        grdStudent.Rows(row).Cells(7).Value = datUMTC.Rows(row).Item("address").ToString
                        grdStudent.Rows(row).Cells(8).Value = datUMTC.Rows(row).Item("emailadd").ToString
                        grdStudent.Rows(row).Cells(9).Value = datUMTC.Rows(row).Item("mobile_no").ToString
                        grdStudent.Rows(row).Cells(10).Value = datUMTC.Rows(row).Item("Yearlevel").ToString
                        grdStudent.Rows(row).Cells(11).Value = datUMTC.Rows(row).Item("studentPic").ToString

                        row = row + 1

                    End While

                Else
                    MessageBox.Show("No Available Records", "Records", MessageBoxButtons.OK, MessageBoxIcon.Question)
                End If
            End With

            sqlUMTCAdapter.Dispose()
            datUMTC.Dispose()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub



    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Dispose()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        With frmAddStudent
            action = "Insert"
            .ShowDialog()
        End With
        prcDisplayStudent()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        sqlUMTCAdapter = New MySqlDataAdapter
        datUMTC = New DataTable
        Try

            With command
                .Parameters.Clear()
                .CommandText = "prcDisplayStudentByFilter"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_filter", cmbSearchType.Text)
                .Parameters.AddWithValue("@p_search", txtSearch.Text)
                sqlUMTCAdapter.SelectCommand = command
                datUMTC.Clear()
                sqlUMTCAdapter.Fill(datUMTC)
                lblTotal.Text = "TOTAL RECORDS: " & datUMTC.Rows.Count
                If datUMTC.Rows.Count > 0 Then
                    grdStudent.RowCount = datUMTC.Rows.Count
                    row = 0
                    While Not datUMTC.Rows.Count - 1 < row
                        grdStudent.Rows(row).Cells(0).Value = datUMTC.Rows(row).Item("id").ToString
                        grdStudent.Rows(row).Cells(1).Value = datUMTC.Rows(row).Item("studentid").ToString
                        grdStudent.Rows(row).Cells(2).Value = datUMTC.Rows(row).Item("lastname").ToString
                        grdStudent.Rows(row).Cells(3).Value = datUMTC.Rows(row).Item("firstname").ToString
                        grdStudent.Rows(row).Cells(4).Value = datUMTC.Rows(row).Item("middlename").ToString
                        grdStudent.Rows(row).Cells(5).Value = Format(Convert.ToDateTime(datUMTC.Rows(row).Item("birthdate").ToString), "MMM dd, yyyy")
                        grdStudent.Rows(row).Cells(6).Value = datUMTC.Rows(row).Item("gender").ToString
                        grdStudent.Rows(row).Cells(7).Value = datUMTC.Rows(row).Item("address").ToString
                        grdStudent.Rows(row).Cells(8).Value = datUMTC.Rows(row).Item("emailadd").ToString
                        grdStudent.Rows(row).Cells(9).Value = datUMTC.Rows(row).Item("mobile_no").ToString
                        grdStudent.Rows(row).Cells(10).Value = datUMTC.Rows(row).Item("Yearlevel").ToString
                        grdStudent.Rows(row).Cells(11).Value = datUMTC.Rows(row).Item("studentPic").ToString

                        row = row + 1

                    End While
                    txtSearch.Clear()
                    cmbSearchType.SelectedIndex = -1

                Else
                    MessageBox.Show("No Available Records", "Records", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End With
            sqlUMTCAdapter.Dispose()
            datUMTC.Dispose()
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            With command
                .Parameters.Clear()
                .CommandText = "prcDeleteStudentById"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_id", CInt(grdStudent.CurrentRow.Cells(0).Value))
                .ExecuteNonQuery()
            End With
            MessageBox.Show("Student Successfully Deleted", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            prcDisplayStudent()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If chkAuto.Checked = True Then
            procSearchStudentByFilterWithAutoComplete()
        Else

        End If
    End Sub

    Private Sub procSearchStudentByFilterWithAutoComplete()
        sqlUMTCAdapter = New MySqlDataAdapter
        datUMTC = New DataTable
        Try

            With command
                .Parameters.Clear()
                .CommandText = "prcSearchStudentByFilterWithAutoComplete"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_filter", cmbSearchType.Text)
                .Parameters.AddWithValue("@p_search", txtSearch.Text)
                sqlUMTCAdapter.SelectCommand = command
                datUMTC.Clear()
                sqlUMTCAdapter.Fill(datUMTC)
                lblTotal.Text = "TOTAL RECORDS: " & datUMTC.Rows.Count
                If datUMTC.Rows.Count > 0 Then
                    grdStudent.RowCount = datUMTC.Rows.Count
                    row = 0
                    While Not datUMTC.Rows.Count - 1 < row

                        grdStudent.Rows(row).Cells(0).Value = datUMTC.Rows(row).Item("id").ToString
                        grdStudent.Rows(row).Cells(1).Value = datUMTC.Rows(row).Item("studentid").ToString
                        grdStudent.Rows(row).Cells(2).Value = datUMTC.Rows(row).Item("lastname").ToString
                        grdStudent.Rows(row).Cells(3).Value = datUMTC.Rows(row).Item("firstname").ToString
                        grdStudent.Rows(row).Cells(4).Value = datUMTC.Rows(row).Item("middlename").ToString
                        grdStudent.Rows(row).Cells(5).Value = Format(Convert.ToDateTime(datUMTC.Rows(row).Item("birthdate").ToString), "MMM dd, yyyy")
                        grdStudent.Rows(row).Cells(6).Value = datUMTC.Rows(row).Item("gender").ToString
                        grdStudent.Rows(row).Cells(7).Value = datUMTC.Rows(row).Item("address").ToString
                        grdStudent.Rows(row).Cells(8).Value = datUMTC.Rows(row).Item("emailadd").ToString
                        grdStudent.Rows(row).Cells(9).Value = datUMTC.Rows(row).Item("mobile_no").ToString
                        grdStudent.Rows(row).Cells(10).Value = datUMTC.Rows(row).Item("Yearlevel").ToString
                        grdStudent.Rows(row).Cells(11).Value = datUMTC.Rows(row).Item("studentPic").ToString
                        row = row + 1

                    End While

                Else
                    txtSearch.Clear()
                    cmbSearchType.SelectedIndex = -1
                    MessageBox.Show("No Available Records", "Records", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End With
            sqlUMTCAdapter.Dispose()
            datUMTC.Dispose()
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        With frmAddStudent
            action = "Update"
            id = CInt(grdStudent.CurrentRow.Cells(0).Value)
            .txtStudentId.Text = grdStudent.CurrentRow.Cells(1).Value
            .txtLastname.Text = grdStudent.CurrentRow.Cells(2).Value
            .txtFirstname.Text = grdStudent.CurrentRow.Cells(3).Value
            .txtMiddlename.Text = grdStudent.CurrentRow.Cells(4).Value
            .dtBirth.Value = Format(Convert.ToDateTime(grdStudent.CurrentRow.Cells(5).Value), "yyyy,MMM,dd")
            .cmbGender.Text = grdStudent.CurrentRow.Cells(6).Value
            .txtAddress.Text = grdStudent.CurrentRow.Cells(7).Value
            .txtEmailAdd.Text = grdStudent.CurrentRow.Cells(8).Value
            .txtContactno.Text = grdStudent.CurrentRow.Cells(9).Value
            yrno = CInt(grdStudent.CurrentRow.Cells(10).Value)

            If yrno = 1 Then
                .cmbYearlevel.Text = "1"
            ElseIf yrno = 2 Then
                .cmbYearlevel.Text = "2"
            ElseIf yrno = 3 Then
                .cmbYearlevel.Text = "3"
            Else
                .cmbYearlevel.Text = "4"
            End If
            studentphotopath = grdStudent.CurrentRow.Cells(11).Value
            .ShowDialog()
        End With
        prcDisplayStudent()
    End Sub


    Private Sub btnEnroll_Click(sender As Object, e As EventArgs) Handles btnEnroll.Click
        With frmEnrollment
            id = CInt(grdStudent.CurrentRow.Cells(0).Value)
            .txtStudentId.Text = grdStudent.CurrentRow.Cells(1).Value
            .txtLastname.Text = grdStudent.CurrentRow.Cells(2).Value
            .txtFirstname.Text = grdStudent.CurrentRow.Cells(3).Value
            .txtMiddlename.Text = grdStudent.CurrentRow.Cells(4).Value
            studentphotopath = grdStudent.CurrentRow.Cells(11).Value
            .ShowDialog()
        End With
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        'CHANGE HERE PRINTING
        'TESTING PULL REQUEST
    End Sub
End Class