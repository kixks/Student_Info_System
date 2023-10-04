Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Common

Public Class frmEnrollment
    Dim sid As Integer
    Private Sub prcDisplayAllSubject()

        Try
            sqlUMTCAdapter = New MySqlDataAdapter
            datUMTC = New DataTable

            With command
                .Parameters.Clear()
                .CommandText = "prcDisplayAllSubject"
                .CommandType = CommandType.StoredProcedure
                sqlUMTCAdapter.SelectCommand = command
                datUMTC.Clear()
                sqlUMTCAdapter.Fill(datUMTC)

                If datUMTC.Rows.Count > 0 Then
                    row = 0
                    While Not datUMTC.Rows.Count - 1 < row
                        cmbSubject.Items.Add("" & datUMTC.Rows(row).Item("subjcode").ToString())
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

    Private Sub frmEnrollment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        prcDisplayAllSubject()
        prcStudentlSubject("studentid", txtStudentId.Text)
    End Sub

    Private Sub cmbSubject_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSubject.SelectedIndexChanged
        Try
            sqlUMTCAdapter = New MySqlDataAdapter
            datUMTC = New DataTable

            With command
                .Parameters.Clear()
                .CommandText = "prcGetSubjectIDBySubjcode"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_subjcode", cmbSubject.Text)
                sqlUMTCAdapter.SelectCommand = command
                datUMTC.Clear()
                sqlUMTCAdapter.Fill(datUMTC)
                If datUMTC.Rows.Count > 0 Then
                    row = 0
                    sid = datUMTC.Rows(row).Item("id").ToString()
                End If

            End With

            sqlUMTCAdapter.Dispose()
            datUMTC.Dispose()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            If fncCheckSubjectDuplicate(txtStudentId.Text, cmbSubject.Text) = False Then
                With command
                    .Parameters.Clear()
                    .CommandText = "prcInsertStudentSubject"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@p_stid", id)
                    .Parameters.AddWithValue("@p_sid", sid)
                    .ExecuteNonQuery()
                End With
            Else
                MessageBox.Show("Subject Already Enrolled", "Duplicate Subject", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            prcStudentlSubject("studentid", txtStudentId.Text)
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Sub prcStudentlSubject(p_filter As String, p_search As String)

        Try
            sqlUMTCAdapter = New MySqlDataAdapter
            datUMTC = New DataTable

            With command
                .Parameters.Clear()
                .CommandText = "prcDisplayStudentSubjectBy"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_filter", p_filter)
                .Parameters.AddWithValue("@p_search", p_search)
                sqlUMTCAdapter.SelectCommand = command
                datUMTC.Clear()
                sqlUMTCAdapter.Fill(datUMTC)

                If datUMTC.Rows.Count > 0 Then
                    grdSubject.RowCount = datUMTC.Rows.Count
                    row = 0
                    While Not datUMTC.Rows.Count - 1 < row
                        grdSubject.Rows(row).Cells(0).Value = datUMTC.Rows(row).Item("id").ToString
                        grdSubject.Rows(row).Cells(2).Value = datUMTC.Rows(row).Item("subjcode").ToString
                        grdSubject.Rows(row).Cells(3).Value = datUMTC.Rows(row).Item("description").ToString
                        grdSubject.Rows(row).Cells(4).Value = datUMTC.Rows(row).Item("units").ToString
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
    Function fncCheckSubjectDuplicate(p_studentid As String, p_subjcode As String) As Boolean
        Dim result As String

        sqlUMTCAdapter = New MySqlDataAdapter
        datUMTC = New DataTable

        With command
            .Parameters.Clear()
            .CommandText = "prcDisplaySubjectByStudentIDandSubjectID"
            .CommandType = CommandType.StoredProcedure
            .Parameters.AddWithValue("@p_studentid", p_studentid)
            .Parameters.AddWithValue("@p_subjcode", p_subjcode)
            sqlUMTCAdapter.SelectCommand = command
            datUMTC.Clear()
            sqlUMTCAdapter.Fill(datUMTC)

            If datUMTC.Rows.Count > 0 Then
                result = True
            Else
                result = False
            End If
        End With


        sqlUMTCAdapter.Dispose()
        datUMTC.Dispose()
        Try

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
        Return result
    End Function

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            With command
                .Parameters.Clear()
                .CommandText = "prcDeleteStudentSubject"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_id", CInt(grdSubject.CurrentRow.Cells(0).Value))
                .ExecuteNonQuery()
            End With
            prcStudentlSubject("studentid", txtStudentId.Text)
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

End Class