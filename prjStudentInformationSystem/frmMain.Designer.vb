<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmMain))
        MenuStrip1 = New MenuStrip()
        STUDENTDATABASEToolStripMenuItem = New ToolStripMenuItem()
        StudentManagementToolStripMenuItem = New ToolStripMenuItem()
        SUBJECTRECORDToolStripMenuItem = New ToolStripMenuItem()
        ToolStripButton1 = New ToolStripButton()
        ToolStrip1 = New ToolStrip()
        MenuStrip1.SuspendLayout()
        ToolStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {STUDENTDATABASEToolStripMenuItem, SUBJECTRECORDToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(772, 24)
        MenuStrip1.TabIndex = 9
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' STUDENTDATABASEToolStripMenuItem
        ' 
        STUDENTDATABASEToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {StudentManagementToolStripMenuItem})
        STUDENTDATABASEToolStripMenuItem.Name = "STUDENTDATABASEToolStripMenuItem"
        STUDENTDATABASEToolStripMenuItem.Size = New Size(126, 20)
        STUDENTDATABASEToolStripMenuItem.Text = "STUDENT DATABASE"
        ' 
        ' StudentManagementToolStripMenuItem
        ' 
        StudentManagementToolStripMenuItem.Name = "StudentManagementToolStripMenuItem"
        StudentManagementToolStripMenuItem.Size = New Size(189, 22)
        StudentManagementToolStripMenuItem.Text = "Student Management"
        ' 
        ' SUBJECTRECORDToolStripMenuItem
        ' 
        SUBJECTRECORDToolStripMenuItem.Name = "SUBJECTRECORDToolStripMenuItem"
        SUBJECTRECORDToolStripMenuItem.Size = New Size(112, 20)
        SUBJECTRECORDToolStripMenuItem.Text = "SUBJECT RECORD"
        ' 
        ' ToolStripButton1
        ' 
        ToolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), Image)
        ToolStripButton1.ImageTransparentColor = Color.Magenta
        ToolStripButton1.Name = "ToolStripButton1"
        ToolStripButton1.Size = New Size(39, 39)
        ToolStripButton1.Text = "ToolStripButton1"
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.ImageScalingSize = New Size(35, 35)
        ToolStrip1.Items.AddRange(New ToolStripItem() {ToolStripButton1})
        ToolStrip1.Location = New Point(0, 24)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(772, 42)
        ToolStrip1.TabIndex = 11
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(772, 523)
        Controls.Add(ToolStrip1)
        Controls.Add(MenuStrip1)
        IsMdiContainer = True
        Margin = New Padding(4, 3, 4, 3)
        Name = "frmMain"
        Text = "Student Information System (BETA)"
        WindowState = FormWindowState.Maximized
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents STUDENTDATABASEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SUBJECTRECORDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStrip1 As ToolStrip
End Class
