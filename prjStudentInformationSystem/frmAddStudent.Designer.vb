<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddStudent
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmAddStudent))
        txtStudentId = New TextBox()
        txtLastname = New TextBox()
        txtFirstname = New TextBox()
        txtMiddlename = New TextBox()
        txtAddress = New TextBox()
        txtEmailAdd = New TextBox()
        txtContactno = New TextBox()
        cmbGender = New ComboBox()
        dtBirth = New DateTimePicker()
        cmbYearlevel = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        PictureBox1 = New PictureBox()
        GroupBox1 = New GroupBox()
        Button1 = New Button()
        picStudentPhoto = New PictureBox()
        btnExit = New Button()
        btnSave = New Button()
        Label11 = New Label()
        OpenFileDialog1 = New OpenFileDialog()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        CType(picStudentPhoto, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtStudentId
        ' 
        txtStudentId.Location = New Point(177, 68)
        txtStudentId.Name = "txtStudentId"
        txtStudentId.Size = New Size(121, 23)
        txtStudentId.TabIndex = 0
        ' 
        ' txtLastname
        ' 
        txtLastname.Location = New Point(177, 99)
        txtLastname.Name = "txtLastname"
        txtLastname.Size = New Size(230, 23)
        txtLastname.TabIndex = 1
        ' 
        ' txtFirstname
        ' 
        txtFirstname.Location = New Point(177, 128)
        txtFirstname.Name = "txtFirstname"
        txtFirstname.Size = New Size(230, 23)
        txtFirstname.TabIndex = 2
        ' 
        ' txtMiddlename
        ' 
        txtMiddlename.Location = New Point(177, 157)
        txtMiddlename.Name = "txtMiddlename"
        txtMiddlename.Size = New Size(230, 23)
        txtMiddlename.TabIndex = 3
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(177, 244)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(230, 23)
        txtAddress.TabIndex = 4
        ' 
        ' txtEmailAdd
        ' 
        txtEmailAdd.Location = New Point(177, 272)
        txtEmailAdd.Name = "txtEmailAdd"
        txtEmailAdd.Size = New Size(230, 23)
        txtEmailAdd.TabIndex = 5
        ' 
        ' txtContactno
        ' 
        txtContactno.Location = New Point(177, 302)
        txtContactno.Name = "txtContactno"
        txtContactno.Size = New Size(121, 23)
        txtContactno.TabIndex = 6
        ' 
        ' cmbGender
        ' 
        cmbGender.DropDownStyle = ComboBoxStyle.DropDownList
        cmbGender.FormattingEnabled = True
        cmbGender.Items.AddRange(New Object() {"MALE", "FEMALE"})
        cmbGender.Location = New Point(177, 215)
        cmbGender.Name = "cmbGender"
        cmbGender.Size = New Size(121, 23)
        cmbGender.TabIndex = 8
        ' 
        ' dtBirth
        ' 
        dtBirth.Format = DateTimePickerFormat.Short
        dtBirth.Location = New Point(177, 186)
        dtBirth.Name = "dtBirth"
        dtBirth.Size = New Size(121, 23)
        dtBirth.TabIndex = 9
        ' 
        ' cmbYearlevel
        ' 
        cmbYearlevel.DropDownStyle = ComboBoxStyle.DropDownList
        cmbYearlevel.FormattingEnabled = True
        cmbYearlevel.Items.AddRange(New Object() {"1", "2", "3", "4"})
        cmbYearlevel.Location = New Point(177, 331)
        cmbYearlevel.Name = "cmbYearlevel"
        cmbYearlevel.Size = New Size(121, 23)
        cmbYearlevel.TabIndex = 10
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(39, 70)
        Label1.Name = "Label1"
        Label1.Size = New Size(117, 21)
        Label1.TabIndex = 11
        Label1.Text = "STUDENT ID #"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(39, 101)
        Label2.Name = "Label2"
        Label2.Size = New Size(95, 21)
        Label2.TabIndex = 12
        Label2.Text = "LASTNAME"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(39, 130)
        Label3.Name = "Label3"
        Label3.Size = New Size(99, 21)
        Label3.TabIndex = 13
        Label3.Text = "FIRSTNAME"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(39, 159)
        Label4.Name = "Label4"
        Label4.Size = New Size(119, 21)
        Label4.TabIndex = 14
        Label4.Text = "MIDDLENAME"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(37, 188)
        Label5.Name = "Label5"
        Label5.Size = New Size(96, 21)
        Label5.TabIndex = 15
        Label5.Text = "BIRTHDATE"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(37, 217)
        Label6.Name = "Label6"
        Label6.Size = New Size(74, 21)
        Label6.TabIndex = 16
        Label6.Text = "GENDER"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(39, 246)
        Label7.Name = "Label7"
        Label7.Size = New Size(82, 21)
        Label7.TabIndex = 17
        Label7.Text = "ADDRESS"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.ForeColor = Color.White
        Label8.Location = New Point(37, 274)
        Label8.Name = "Label8"
        Label8.Size = New Size(134, 21)
        Label8.TabIndex = 18
        Label8.Text = "EMAIL ADDRESS"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.ForeColor = Color.White
        Label9.Location = New Point(37, 304)
        Label9.Name = "Label9"
        Label9.Size = New Size(115, 21)
        Label9.TabIndex = 19
        Label9.Text = "CONTACT NO."
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.ForeColor = Color.White
        Label10.Location = New Point(37, 333)
        Label10.Name = "Label10"
        Label10.Size = New Size(95, 21)
        Label10.TabIndex = 20
        Label10.Text = "YEARLEVEL"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Dock = DockStyle.Top
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(786, 115)
        PictureBox1.TabIndex = 21
        PictureBox1.TabStop = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Maroon
        GroupBox1.BackgroundImageLayout = ImageLayout.None
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(picStudentPhoto)
        GroupBox1.Controls.Add(btnExit)
        GroupBox1.Controls.Add(btnSave)
        GroupBox1.Controls.Add(Label11)
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(cmbYearlevel)
        GroupBox1.Controls.Add(dtBirth)
        GroupBox1.Controls.Add(cmbGender)
        GroupBox1.Controls.Add(txtContactno)
        GroupBox1.Controls.Add(txtEmailAdd)
        GroupBox1.Controls.Add(txtAddress)
        GroupBox1.Controls.Add(txtMiddlename)
        GroupBox1.Controls.Add(txtFirstname)
        GroupBox1.Controls.Add(txtLastname)
        GroupBox1.Controls.Add(txtStudentId)
        GroupBox1.FlatStyle = FlatStyle.System
        GroupBox1.Location = New Point(36, 152)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(695, 407)
        GroupBox1.TabIndex = 22
        GroupBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), Image)
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(496, 183)
        Button1.Name = "Button1"
        Button1.Size = New Size(128, 36)
        Button1.TabIndex = 25
        Button1.UseVisualStyleBackColor = True
        ' 
        ' picStudentPhoto
        ' 
        picStudentPhoto.BackgroundImage = CType(resources.GetObject("picStudentPhoto.BackgroundImage"), Image)
        picStudentPhoto.BackgroundImageLayout = ImageLayout.Stretch
        picStudentPhoto.Location = New Point(468, 19)
        picStudentPhoto.Name = "picStudentPhoto"
        picStudentPhoto.Size = New Size(177, 158)
        picStudentPhoto.SizeMode = PictureBoxSizeMode.StretchImage
        picStudentPhoto.TabIndex = 24
        picStudentPhoto.TabStop = False
        ' 
        ' btnExit
        ' 
        btnExit.BackgroundImage = CType(resources.GetObject("btnExit.BackgroundImage"), Image)
        btnExit.BackgroundImageLayout = ImageLayout.Stretch
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Location = New Point(552, 317)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(93, 57)
        btnExit.TabIndex = 23
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.BackgroundImage = CType(resources.GetObject("btnSave.BackgroundImage"), Image)
        btnSave.BackgroundImageLayout = ImageLayout.Stretch
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Location = New Point(428, 317)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(96, 57)
        btnSave.TabIndex = 22
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.ForeColor = Color.White
        Label11.Location = New Point(25, 19)
        Label11.Name = "Label11"
        Label11.Size = New Size(299, 32)
        Label11.TabIndex = 21
        Label11.Text = "STUDENT INFORMATION"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' frmAddStudent
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PapayaWhip
        ClientSize = New Size(786, 599)
        Controls.Add(GroupBox1)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Location = New Point(3, 93)
        Name = "frmAddStudent"
        StartPosition = FormStartPosition.Manual
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(picStudentPhoto, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents txtStudentId As TextBox
    Friend WithEvents txtLastname As TextBox
    Friend WithEvents txtFirstname As TextBox
    Friend WithEvents txtMiddlename As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtEmailAdd As TextBox
    Friend WithEvents txtContactno As TextBox
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents dtBirth As DateTimePicker
    Friend WithEvents cmbYearlevel As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents picStudentPhoto As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
