<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDisplayStudent
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmDisplayStudent))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        PictureBox1 = New PictureBox()
        r = New GroupBox()
        btnSearch = New Button()
        chkAuto = New CheckBox()
        txtSearch = New TextBox()
        cmbSearchType = New ComboBox()
        Label1 = New Label()
        grdStudent = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column11 = New DataGridViewTextBoxColumn()
        Column12 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        Column10 = New DataGridViewTextBoxColumn()
        btnAdd = New Button()
        btnDelete = New Button()
        btnEdit = New Button()
        btnExit = New Button()
        lblTotal = New Label()
        btnEnroll = New Button()
        btnPrint = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        r.SuspendLayout()
        CType(grdStudent, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Dock = DockStyle.Top
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(797, 115)
        PictureBox1.TabIndex = 22
        PictureBox1.TabStop = False
        ' 
        ' r
        ' 
        r.BackColor = Color.Maroon
        r.Controls.Add(btnSearch)
        r.Controls.Add(chkAuto)
        r.Controls.Add(txtSearch)
        r.Controls.Add(cmbSearchType)
        r.Controls.Add(Label1)
        r.Location = New Point(12, 135)
        r.Name = "r"
        r.Size = New Size(769, 131)
        r.TabIndex = 23
        r.TabStop = False
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.IndianRed
        btnSearch.BackgroundImage = CType(resources.GetObject("btnSearch.BackgroundImage"), Image)
        btnSearch.BackgroundImageLayout = ImageLayout.Stretch
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.Location = New Point(535, 22)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(72, 58)
        btnSearch.TabIndex = 4
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' chkAuto
        ' 
        chkAuto.AutoSize = True
        chkAuto.Font = New Font("Ravie", 9F, FontStyle.Bold, GraphicsUnit.Point)
        chkAuto.ForeColor = SystemColors.ButtonHighlight
        chkAuto.Location = New Point(259, 96)
        chkAuto.Name = "chkAuto"
        chkAuto.Size = New Size(153, 21)
        chkAuto.TabIndex = 3
        chkAuto.Text = "Auto Complete"
        chkAuto.UseVisualStyleBackColor = True
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(259, 57)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(250, 23)
        txtSearch.TabIndex = 2
        ' 
        ' cmbSearchType
        ' 
        cmbSearchType.DropDownStyle = ComboBoxStyle.DropDownList
        cmbSearchType.FormattingEnabled = True
        cmbSearchType.Items.AddRange(New Object() {"ALL", "LASTNAME", "STUDENTID"})
        cmbSearchType.Location = New Point(259, 26)
        cmbSearchType.Name = "cmbSearchType"
        cmbSearchType.Size = New Size(250, 23)
        cmbSearchType.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Ravie", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(91, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(130, 17)
        Label1.TabIndex = 0
        Label1.Text = "SEARCH TYPE"
        ' 
        ' grdStudent
        ' 
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.Brown
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.Window
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        grdStudent.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        grdStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        grdStudent.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column11, Column12, Column4, Column5, Column6, Column7, Column8, Column9, Column10})
        grdStudent.EditMode = DataGridViewEditMode.EditProgrammatically
        grdStudent.Location = New Point(12, 284)
        grdStudent.Name = "grdStudent"
        grdStudent.RowTemplate.Height = 25
        grdStudent.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        grdStudent.Size = New Size(769, 281)
        grdStudent.TabIndex = 24
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "ID"
        Column1.Name = "Column1"
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Student ID"
        Column2.Name = "Column2"
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Lastname"
        Column3.Name = "Column3"
        Column3.Width = 200
        ' 
        ' Column11
        ' 
        Column11.HeaderText = "Firstname"
        Column11.Name = "Column11"
        ' 
        ' Column12
        ' 
        Column12.HeaderText = "Middlename"
        Column12.Name = "Column12"
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Birthdate"
        Column4.Name = "Column4"
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Gender"
        Column5.Name = "Column5"
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Address"
        Column6.Name = "Column6"
        Column6.Width = 250
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "Email Add"
        Column7.Name = "Column7"
        Column7.Width = 175
        ' 
        ' Column8
        ' 
        Column8.HeaderText = "Contact No."
        Column8.Name = "Column8"
        ' 
        ' Column9
        ' 
        Column9.HeaderText = "Year Level"
        Column9.Name = "Column9"
        ' 
        ' Column10
        ' 
        Column10.HeaderText = "Student Pic"
        Column10.Name = "Column10"
        Column10.Visible = False
        ' 
        ' btnAdd
        ' 
        btnAdd.BackgroundImage = CType(resources.GetObject("btnAdd.BackgroundImage"), Image)
        btnAdd.BackgroundImageLayout = ImageLayout.Stretch
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.Location = New Point(340, 585)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(73, 37)
        btnAdd.TabIndex = 25
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.BackgroundImage = CType(resources.GetObject("btnDelete.BackgroundImage"), Image)
        btnDelete.BackgroundImageLayout = ImageLayout.Stretch
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Location = New Point(419, 586)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(81, 36)
        btnDelete.TabIndex = 26
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.BackgroundImage = CType(resources.GetObject("btnEdit.BackgroundImage"), Image)
        btnEdit.BackgroundImageLayout = ImageLayout.Stretch
        btnEdit.FlatStyle = FlatStyle.Flat
        btnEdit.Location = New Point(506, 585)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(81, 37)
        btnEdit.TabIndex = 27
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.BackgroundImage = CType(resources.GetObject("btnExit.BackgroundImage"), Image)
        btnExit.BackgroundImageLayout = ImageLayout.Stretch
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Location = New Point(697, 586)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(72, 36)
        btnExit.TabIndex = 29
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblTotal.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        lblTotal.Location = New Point(12, 596)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(100, 15)
        lblTotal.TabIndex = 30
        lblTotal.Text = "TOTAL RECORDS"
        ' 
        ' btnEnroll
        ' 
        btnEnroll.BackgroundImage = CType(resources.GetObject("btnEnroll.BackgroundImage"), Image)
        btnEnroll.BackgroundImageLayout = ImageLayout.Stretch
        btnEnroll.FlatStyle = FlatStyle.Flat
        btnEnroll.Location = New Point(153, 580)
        btnEnroll.Name = "btnEnroll"
        btnEnroll.Size = New Size(144, 42)
        btnEnroll.TabIndex = 31
        btnEnroll.UseVisualStyleBackColor = True
        ' 
        ' btnPrint
        ' 
        btnPrint.BackgroundImage = CType(resources.GetObject("btnPrint.BackgroundImage"), Image)
        btnPrint.BackgroundImageLayout = ImageLayout.Stretch
        btnPrint.FlatStyle = FlatStyle.Flat
        btnPrint.Location = New Point(593, 586)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(73, 37)
        btnPrint.TabIndex = 32
        btnPrint.UseVisualStyleBackColor = True
        ' 
        ' frmDisplayStudent
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PapayaWhip
        ClientSize = New Size(797, 643)
        Controls.Add(btnPrint)
        Controls.Add(btnEnroll)
        Controls.Add(lblTotal)
        Controls.Add(btnExit)
        Controls.Add(btnEdit)
        Controls.Add(btnDelete)
        Controls.Add(btnAdd)
        Controls.Add(grdStudent)
        Controls.Add(r)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Location = New Point(3, 93)
        Name = "frmDisplayStudent"
        StartPosition = FormStartPosition.Manual
        Text = "frmDisplayStudent"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        r.ResumeLayout(False)
        r.PerformLayout()
        CType(grdStudent, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents r As GroupBox
    Friend WithEvents cmbSearchType As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents chkAuto As CheckBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents grdStudent As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents btnEnroll As Button
    Friend WithEvents btnPrint As Button
End Class
