<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnrollment
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmEnrollment))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        PictureBox1 = New PictureBox()
        picStudentPhoto = New PictureBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        txtMiddlename = New TextBox()
        txtFirstname = New TextBox()
        txtLastname = New TextBox()
        txtStudentId = New TextBox()
        grdSubject = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Label5 = New Label()
        cmbSubject = New ComboBox()
        btnAdd = New Button()
        btnDelete = New Button()
        lblTotal = New Label()
        Button1 = New Button()
        btnExit = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(picStudentPhoto, ComponentModel.ISupportInitialize).BeginInit()
        CType(grdSubject, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Dock = DockStyle.Top
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(855, 115)
        PictureBox1.TabIndex = 23
        PictureBox1.TabStop = False
        ' 
        ' picStudentPhoto
        ' 
        picStudentPhoto.BackgroundImage = CType(resources.GetObject("picStudentPhoto.BackgroundImage"), Image)
        picStudentPhoto.BackgroundImageLayout = ImageLayout.Stretch
        picStudentPhoto.Location = New Point(129, 130)
        picStudentPhoto.Name = "picStudentPhoto"
        picStudentPhoto.Size = New Size(173, 144)
        picStudentPhoto.SizeMode = PictureBoxSizeMode.StretchImage
        picStudentPhoto.TabIndex = 25
        picStudentPhoto.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Label4.Location = New Point(327, 236)
        Label4.Name = "Label4"
        Label4.Size = New Size(119, 21)
        Label4.TabIndex = 33
        Label4.Text = "MIDDLENAME"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Label3.Location = New Point(327, 207)
        Label3.Name = "Label3"
        Label3.Size = New Size(99, 21)
        Label3.TabIndex = 32
        Label3.Text = "FIRSTNAME"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Label2.Location = New Point(327, 178)
        Label2.Name = "Label2"
        Label2.Size = New Size(95, 21)
        Label2.TabIndex = 31
        Label2.Text = "LASTNAME"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Label1.Location = New Point(327, 147)
        Label1.Name = "Label1"
        Label1.Size = New Size(117, 21)
        Label1.TabIndex = 30
        Label1.Text = "STUDENT ID #"
        ' 
        ' txtMiddlename
        ' 
        txtMiddlename.Location = New Point(465, 234)
        txtMiddlename.Name = "txtMiddlename"
        txtMiddlename.Size = New Size(230, 23)
        txtMiddlename.TabIndex = 29
        ' 
        ' txtFirstname
        ' 
        txtFirstname.Location = New Point(465, 205)
        txtFirstname.Name = "txtFirstname"
        txtFirstname.Size = New Size(230, 23)
        txtFirstname.TabIndex = 28
        ' 
        ' txtLastname
        ' 
        txtLastname.Location = New Point(465, 176)
        txtLastname.Name = "txtLastname"
        txtLastname.Size = New Size(230, 23)
        txtLastname.TabIndex = 27
        ' 
        ' txtStudentId
        ' 
        txtStudentId.Location = New Point(465, 145)
        txtStudentId.Name = "txtStudentId"
        txtStudentId.Size = New Size(121, 23)
        txtStudentId.TabIndex = 26
        ' 
        ' grdSubject
        ' 
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.Brown
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.Window
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        grdSubject.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        grdSubject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        grdSubject.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5})
        grdSubject.EditMode = DataGridViewEditMode.EditProgrammatically
        grdSubject.Location = New Point(116, 323)
        grdSubject.Name = "grdSubject"
        grdSubject.RowTemplate.Height = 25
        grdSubject.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        grdSubject.Size = New Size(596, 194)
        grdSubject.TabIndex = 34
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
        Column2.Visible = False
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Subject Code"
        Column3.Name = "Column3"
        Column3.Width = 150
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Description"
        Column4.Name = "Column4"
        Column4.Width = 200
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Units"
        Column5.Name = "Column5"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Label5.Location = New Point(70, 294)
        Label5.Name = "Label5"
        Label5.Size = New Size(148, 21)
        Label5.TabIndex = 35
        Label5.Text = "SUBJECT OFFERED"
        ' 
        ' cmbSubject
        ' 
        cmbSubject.DropDownStyle = ComboBoxStyle.DropDownList
        cmbSubject.FormattingEnabled = True
        cmbSubject.Location = New Point(224, 294)
        cmbSubject.Name = "cmbSubject"
        cmbSubject.Size = New Size(260, 23)
        cmbSubject.TabIndex = 36
        ' 
        ' btnAdd
        ' 
        btnAdd.BackgroundImage = CType(resources.GetObject("btnAdd.BackgroundImage"), Image)
        btnAdd.BackgroundImageLayout = ImageLayout.Stretch
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.Location = New Point(505, 286)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(77, 31)
        btnAdd.TabIndex = 37
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.BackgroundImage = CType(resources.GetObject("btnDelete.BackgroundImage"), Image)
        btnDelete.BackgroundImageLayout = ImageLayout.Stretch
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Location = New Point(588, 286)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(78, 31)
        btnDelete.TabIndex = 38
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblTotal.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        lblTotal.Location = New Point(610, 543)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(85, 15)
        lblTotal.TabIndex = 39
        lblTotal.Text = "TOTAL UNITS:"
        ' 
        ' Button1
        ' 
        Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), Image)
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(672, 286)
        Button1.Name = "Button1"
        Button1.Size = New Size(77, 31)
        Button1.TabIndex = 40
        Button1.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.BackgroundImage = CType(resources.GetObject("btnExit.BackgroundImage"), Image)
        btnExit.BackgroundImageLayout = ImageLayout.Stretch
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Location = New Point(70, 540)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(72, 36)
        btnExit.TabIndex = 41
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' frmEnrollment
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(855, 588)
        Controls.Add(btnExit)
        Controls.Add(Button1)
        Controls.Add(lblTotal)
        Controls.Add(btnDelete)
        Controls.Add(btnAdd)
        Controls.Add(cmbSubject)
        Controls.Add(Label5)
        Controls.Add(grdSubject)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtMiddlename)
        Controls.Add(txtFirstname)
        Controls.Add(txtLastname)
        Controls.Add(txtStudentId)
        Controls.Add(picStudentPhoto)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Location = New Point(3, 93)
        Name = "frmEnrollment"
        StartPosition = FormStartPosition.Manual
        Text = "frmEnrollment"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(picStudentPhoto, ComponentModel.ISupportInitialize).EndInit()
        CType(grdSubject, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents picStudentPhoto As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMiddlename As TextBox
    Friend WithEvents txtFirstname As TextBox
    Friend WithEvents txtLastname As TextBox
    Friend WithEvents txtStudentId As TextBox
    Friend WithEvents grdSubject As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbSubject As ComboBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
