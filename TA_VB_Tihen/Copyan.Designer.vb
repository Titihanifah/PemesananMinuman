﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Copyan
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
        Dim MenuStrip1 As System.Windows.Forms.MenuStrip
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Copyan))
        Me.satu = New System.Windows.Forms.TabControl
        Me.Tambah = New System.Windows.Forms.TabPage
        Me.btnSubmit = New System.Windows.Forms.Button
        Me.Input = New System.Windows.Forms.GroupBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.lblNotelp = New System.Windows.Forms.Label
        Me.lblAlamat = New System.Windows.Forms.Label
        Me.lblEmail = New System.Windows.Forms.Label
        Me.txtnama = New System.Windows.Forms.TextBox
        Me.lblTempat = New System.Windows.Forms.Label
        Me.lblNama = New System.Windows.Forms.Label
        Me.txtNotelp = New System.Windows.Forms.TextBox
        Me.alamat = New System.Windows.Forms.RichTextBox
        Me.txtemail = New System.Windows.Forms.TextBox
        Me.dtpttl = New System.Windows.Forms.DateTimePicker
        Me.txttempat = New System.Windows.Forms.TextBox
        Me.lbltgl = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.TextBox8 = New System.Windows.Forms.TextBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Tampilkan = New System.Windows.Forms.Button
        Me.rtbHasil = New System.Windows.Forms.RichTextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DaftarMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.satu.SuspendLayout()
        Me.Tambah.SuspendLayout()
        MenuStrip1.SuspendLayout()
        Me.Input.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'satu
        '
        Me.satu.Controls.Add(Me.Tambah)
        Me.satu.Controls.Add(Me.TabPage2)
        Me.satu.Location = New System.Drawing.Point(72, 79)
        Me.satu.Name = "satu"
        Me.satu.SelectedIndex = 0
        Me.satu.Size = New System.Drawing.Size(503, 473)
        Me.satu.TabIndex = 1
        '
        'Tambah
        '
        Me.Tambah.Controls.Add(Me.PictureBox1)
        Me.Tambah.Controls.Add(MenuStrip1)
        Me.Tambah.Controls.Add(Me.btnSubmit)
        Me.Tambah.Controls.Add(Me.Input)
        Me.Tambah.Controls.Add(Me.Label11)
        Me.Tambah.Controls.Add(Me.Label10)
        Me.Tambah.Controls.Add(Me.Label9)
        Me.Tambah.Controls.Add(Me.TextBox7)
        Me.Tambah.Controls.Add(Me.TextBox8)
        Me.Tambah.Location = New System.Drawing.Point(4, 22)
        Me.Tambah.Name = "Tambah"
        Me.Tambah.Padding = New System.Windows.Forms.Padding(3)
        Me.Tambah.Size = New System.Drawing.Size(495, 447)
        Me.Tambah.TabIndex = 0
        Me.Tambah.Text = "Tambah Member"
        Me.Tambah.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TransaksiToolStripMenuItem, Me.MemberToolStripMenuItem, Me.DaftarMenuToolStripMenuItem})
        MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        MenuStrip1.Location = New System.Drawing.Point(3, 3)
        MenuStrip1.Margin = New System.Windows.Forms.Padding(100, 10, 10, 10)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        MenuStrip1.Size = New System.Drawing.Size(489, 44)
        MenuStrip1.TabIndex = 42
        MenuStrip1.Text = "MenuStrip1"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(29, 413)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 41
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'Input
        '
        Me.Input.Controls.Add(Me.CheckBox1)
        Me.Input.Controls.Add(Me.lblNotelp)
        Me.Input.Controls.Add(Me.lblAlamat)
        Me.Input.Controls.Add(Me.lblEmail)
        Me.Input.Controls.Add(Me.txtnama)
        Me.Input.Controls.Add(Me.lblTempat)
        Me.Input.Controls.Add(Me.lblNama)
        Me.Input.Controls.Add(Me.txtNotelp)
        Me.Input.Controls.Add(Me.alamat)
        Me.Input.Controls.Add(Me.txtemail)
        Me.Input.Controls.Add(Me.dtpttl)
        Me.Input.Controls.Add(Me.txttempat)
        Me.Input.Controls.Add(Me.lbltgl)
        Me.Input.Location = New System.Drawing.Point(29, 103)
        Me.Input.Name = "Input"
        Me.Input.Size = New System.Drawing.Size(288, 272)
        Me.Input.TabIndex = 38
        Me.Input.TabStop = False
        Me.Input.Text = "Input"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(10, 246)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(262, 17)
        Me.CheckBox1.TabIndex = 40
        Me.CheckBox1.Text = "Setuju dengan syarat dan ketentuan yang berlaku"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'lblNotelp
        '
        Me.lblNotelp.AutoSize = True
        Me.lblNotelp.Location = New System.Drawing.Point(4, 136)
        Me.lblNotelp.Name = "lblNotelp"
        Me.lblNotelp.Size = New System.Drawing.Size(66, 13)
        Me.lblNotelp.TabIndex = 22
        Me.lblNotelp.Text = "No. Telepon"
        '
        'lblAlamat
        '
        Me.lblAlamat.AutoSize = True
        Me.lblAlamat.Location = New System.Drawing.Point(4, 164)
        Me.lblAlamat.Name = "lblAlamat"
        Me.lblAlamat.Size = New System.Drawing.Size(39, 13)
        Me.lblAlamat.TabIndex = 23
        Me.lblAlamat.Text = "Alamat"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(4, 106)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblEmail.TabIndex = 20
        Me.lblEmail.Text = "E-mail"
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(104, 18)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(168, 20)
        Me.txtnama.TabIndex = 26
        '
        'lblTempat
        '
        Me.lblTempat.AutoSize = True
        Me.lblTempat.Location = New System.Drawing.Point(4, 50)
        Me.lblTempat.Name = "lblTempat"
        Me.lblTempat.Size = New System.Drawing.Size(69, 13)
        Me.lblTempat.TabIndex = 15
        Me.lblTempat.Text = "Tempat Lahir"
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Location = New System.Drawing.Point(4, 21)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(80, 13)
        Me.lblNama.TabIndex = 13
        Me.lblNama.Text = "Nama Lengkap"
        '
        'txtNotelp
        '
        Me.txtNotelp.Location = New System.Drawing.Point(104, 129)
        Me.txtNotelp.Name = "txtNotelp"
        Me.txtNotelp.Size = New System.Drawing.Size(168, 20)
        Me.txtNotelp.TabIndex = 32
        '
        'alamat
        '
        Me.alamat.Location = New System.Drawing.Point(103, 164)
        Me.alamat.Name = "alamat"
        Me.alamat.Size = New System.Drawing.Size(169, 67)
        Me.alamat.TabIndex = 34
        Me.alamat.Text = ""
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(104, 99)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(168, 20)
        Me.txtemail.TabIndex = 30
        '
        'dtpttl
        '
        Me.dtpttl.Location = New System.Drawing.Point(103, 73)
        Me.dtpttl.Name = "dtpttl"
        Me.dtpttl.Size = New System.Drawing.Size(168, 20)
        Me.dtpttl.TabIndex = 36
        '
        'txttempat
        '
        Me.txttempat.Location = New System.Drawing.Point(104, 47)
        Me.txttempat.Name = "txttempat"
        Me.txttempat.Size = New System.Drawing.Size(168, 20)
        Me.txttempat.TabIndex = 28
        '
        'lbltgl
        '
        Me.lbltgl.AutoSize = True
        Me.lbltgl.Location = New System.Drawing.Point(4, 78)
        Me.lbltgl.Name = "lbltgl"
        Me.lbltgl.Size = New System.Drawing.Size(48, 13)
        Me.lbltgl.TabIndex = 18
        Me.lbltgl.Text = "Tgl Lahir"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(341, -72)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Nama Lengkap"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(341, -43)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Tempat Lahir"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(341, -15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Tgl Lahir"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(441, -46)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(168, 20)
        Me.TextBox7.TabIndex = 27
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(441, -75)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(168, 20)
        Me.TextBox8.TabIndex = 25
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(Me.Button4)
        Me.TabPage2.Controls.Add(Me.Button5)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Tampilkan)
        Me.TabPage2.Controls.Add(Me.rtbHasil)
        Me.TabPage2.Controls.Add(Me.PictureBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(495, 447)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Lihat Member"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(244, 19)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(76, 23)
        Me.Button3.TabIndex = 49
        Me.Button3.Text = "Daftar Menu"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(175, 19)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(63, 23)
        Me.Button4.TabIndex = 48
        Me.Button4.Text = "Order"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(102, 19)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(67, 23)
        Me.Button5.TabIndex = 47
        Me.Button5.Text = "Home"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(123, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 18)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Lihat Data Member"
        '
        'Tampilkan
        '
        Me.Tampilkan.Location = New System.Drawing.Point(109, 360)
        Me.Tampilkan.Name = "Tampilkan"
        Me.Tampilkan.Size = New System.Drawing.Size(75, 23)
        Me.Tampilkan.TabIndex = 1
        Me.Tampilkan.Text = "Tampilkan"
        Me.Tampilkan.UseVisualStyleBackColor = True
        '
        'rtbHasil
        '
        Me.rtbHasil.Location = New System.Drawing.Point(18, 96)
        Me.rtbHasil.Name = "rtbHasil"
        Me.rtbHasil.Size = New System.Drawing.Size(306, 258)
        Me.rtbHasil.TabIndex = 0
        Me.rtbHasil.Text = ""
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.TA_VB_Tihen.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(154, 78)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 43
        Me.PictureBox1.TabStop = False
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.TransaksiToolStripMenuItem.Image = CType(resources.GetObject("TransaksiToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TransaksiToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TransaksiToolStripMenuItem.Margin = New System.Windows.Forms.Padding(150, 10, 10, 10)
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.RightToLeftAutoMirrorImage = True
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        Me.TransaksiToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TransaksiToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'MemberToolStripMenuItem
        '
        Me.MemberToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.MemberToolStripMenuItem.AutoToolTip = True
        Me.MemberToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MemberToolStripMenuItem.Image = Global.TA_VB_Tihen.My.Resources.Resources.member
        Me.MemberToolStripMenuItem.Margin = New System.Windows.Forms.Padding(10)
        Me.MemberToolStripMenuItem.Name = "MemberToolStripMenuItem"
        Me.MemberToolStripMenuItem.RightToLeftAutoMirrorImage = True
        Me.MemberToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.MemberToolStripMenuItem.Text = "Member"
        Me.MemberToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.MemberToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'DaftarMenuToolStripMenuItem
        '
        Me.DaftarMenuToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.DaftarMenuToolStripMenuItem.Image = Global.TA_VB_Tihen.My.Resources.Resources.menu
        Me.DaftarMenuToolStripMenuItem.Margin = New System.Windows.Forms.Padding(10)
        Me.DaftarMenuToolStripMenuItem.Name = "DaftarMenuToolStripMenuItem"
        Me.DaftarMenuToolStripMenuItem.RightToLeftAutoMirrorImage = True
        Me.DaftarMenuToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
        Me.DaftarMenuToolStripMenuItem.Text = "Daftar Menu"
        Me.DaftarMenuToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.DaftarMenuToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.TA_VB_Tihen.My.Resources.Resources.logo
        Me.PictureBox2.Location = New System.Drawing.Point(18, 19)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(77, 56)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 44
        Me.PictureBox2.TabStop = False
        '
        'Copyan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1057, 610)
        Me.Controls.Add(Me.satu)
        Me.Name = "Copyan"
        Me.Text = "Copyan"
        Me.satu.ResumeLayout(False)
        Me.Tambah.ResumeLayout(False)
        Me.Tambah.PerformLayout()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        Me.Input.ResumeLayout(False)
        Me.Input.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents satu As System.Windows.Forms.TabControl
    Friend WithEvents Tambah As System.Windows.Forms.TabPage
    Friend WithEvents TransaksiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MemberToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DaftarMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents Input As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents lblNotelp As System.Windows.Forms.Label
    Friend WithEvents lblAlamat As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents lblTempat As System.Windows.Forms.Label
    Friend WithEvents lblNama As System.Windows.Forms.Label
    Friend WithEvents txtNotelp As System.Windows.Forms.TextBox
    Friend WithEvents alamat As System.Windows.Forms.RichTextBox
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents dtpttl As System.Windows.Forms.DateTimePicker
    Friend WithEvents txttempat As System.Windows.Forms.TextBox
    Friend WithEvents lbltgl As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Tampilkan As System.Windows.Forms.Button
    Friend WithEvents rtbHasil As System.Windows.Forms.RichTextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
