Public Class frmAddStudent
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Dispose()
    End Sub

    Private Sub frmAddStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkDatabaseConnection()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If action = "Insert" Then
                With command
                    .Parameters.Clear()
                    .CommandText = "prcInsertStudent"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@p_studentid", txtStudentId.Text)
                    .Parameters.AddWithValue("@p_lastname", txtLastname.Text)
                    .Parameters.AddWithValue("@p_firstname", txtFirstname.Text)
                    .Parameters.AddWithValue("@p_middlename", txtMiddlename.Text)
                    .Parameters.AddWithValue("@p_birthdate", Format(dtBirth.Value, "yyyy-MM-dd"))
                    .Parameters.AddWithValue("@p_gender", cmbGender.Text)
                    .Parameters.AddWithValue("@p_emailadd", txtEmailAdd.Text)
                    .Parameters.AddWithValue("@p_mobile_no", txtContactno.Text)
                    .Parameters.AddWithValue("@p_address", txtAddress.Text)
                    .Parameters.AddWithValue("@p_Yearlevel", CInt(cmbYearlevel.Text))
                    .Parameters.AddWithValue("@p_studentPic", studentphotopath)
                    .ExecuteNonQuery()

                End With
            Else
                With command

                    .Parameters.Clear()
                    .CommandText = "prcUpdateStudentByID"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@p_id", id)
                    .Parameters.AddWithValue("@p_studentid", txtStudentId.Text)
                    .Parameters.AddWithValue("@p_lastname", txtLastname.Text)
                    .Parameters.AddWithValue("@p_firstname", txtFirstname.Text)
                    .Parameters.AddWithValue("@p_middlename", txtMiddlename.Text)
                    .Parameters.AddWithValue("@p_birthdate", Format(dtBirth.Value, "yyyy-MM-dd"))
                    .Parameters.AddWithValue("@p_gender", cmbGender.Text)
                    .Parameters.AddWithValue("@p_emailadd", txtEmailAdd.Text)
                    .Parameters.AddWithValue("@p_mobile_no", txtContactno.Text)
                    .Parameters.AddWithValue("@p_address", txtAddress.Text)
                    .Parameters.AddWithValue("@p_Yearlevel", CInt(cmbYearlevel.Text))
                    .Parameters.AddWithValue("@p_studentPic", studentphotopath)
                    .ExecuteNonQuery()

                End With
            End If

            MessageBox.Show("Record Successfully Save", "Saving Record", MessageBoxButtons.OK, MessageBoxIcon.Information)

            txtStudentId.Clear()
            txtLastname.Clear()
            txtFirstname.Clear()
            txtMiddlename.Clear()
            txtAddress.Clear()
            txtEmailAdd.Clear()
            txtContactno.Clear()
            dtBirth.Value = Now()
            cmbGender.SelectedIndex = -1
            cmbYearlevel.SelectedIndex = -1

            Me.Dispose()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            With OpenFileDialog1
                .Title = "Select Student Photo"
                .FileName = ""
                If .ShowDialog = System.Windows.Forms.DialogResult.OK Then
                    picStudentPhoto.Image = Image.FromFile(.FileName)
                    studentphotopath = .FileName

                End If
            End With
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

End Class
