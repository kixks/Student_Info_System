Imports System.Windows.Forms

Public Class frmMain
    Private Sub StudentManagementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentManagementToolStripMenuItem.Click
        frmDisplayStudent.ShowDialog()
    End Sub


    Private Sub ToolStripButton1_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        frmDisplayStudent.ShowDialog()
        'Testing Changes
    End Sub
End Class
