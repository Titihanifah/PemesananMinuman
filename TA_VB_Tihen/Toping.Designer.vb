<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Toping
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Toping))
        Me.textbox = New System.Windows.Forms.Label
        Me.stokT = New System.Windows.Forms.TextBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.txtIdT = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtToping = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtHargaT = New System.Windows.Forms.TextBox
        Me.DataToping = New System.Windows.Forms.DataGridView
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnSubmit = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DaftarMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MinumanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TopingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.KaryawanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        MenuStrip1 = New System.Windows.Forms.MenuStrip
        CType(Me.DataToping, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'textbox
        '
        Me.textbox.AutoSize = True
        Me.textbox.Location = New System.Drawing.Point(49, 200)
        Me.textbox.Name = "textbox"
        Me.textbox.Size = New System.Drawing.Size(29, 13)
        Me.textbox.TabIndex = 57
        Me.textbox.Text = "Stok"
        '
        'stokT
        '
        Me.stokT.Location = New System.Drawing.Point(147, 197)
        Me.stokT.Name = "stokT"
        Me.stokT.Size = New System.Drawing.Size(168, 20)
        Me.stokT.TabIndex = 58
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(239, 105)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(75, 21)
        Me.ComboBox1.TabIndex = 56
        '
        'txtIdT
        '
        Me.txtIdT.Location = New System.Drawing.Point(149, 105)
        Me.txtIdT.Name = "txtIdT"
        Me.txtIdT.Size = New System.Drawing.Size(84, 20)
        Me.txtIdT.TabIndex = 55
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(49, 108)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(18, 13)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "ID"
        '
        'txtToping
        '
        Me.txtToping.Location = New System.Drawing.Point(147, 134)
        Me.txtToping.Name = "txtToping"
        Me.txtToping.Size = New System.Drawing.Size(167, 20)
        Me.txtToping.TabIndex = 52
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Harga"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(47, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Nama Toping"
        '
        'txtHargaT
        '
        Me.txtHargaT.Location = New System.Drawing.Point(147, 165)
        Me.txtHargaT.Name = "txtHargaT"
        Me.txtHargaT.Size = New System.Drawing.Size(168, 20)
        Me.txtHargaT.TabIndex = 53
        '
        'DataToping
        '
        Me.DataToping.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataToping.Location = New System.Drawing.Point(31, 239)
        Me.DataToping.Name = "DataToping"
        Me.DataToping.Size = New System.Drawing.Size(337, 113)
        Me.DataToping.TabIndex = 63
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(303, 358)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(65, 23)
        Me.Button3.TabIndex = 62
        Me.Button3.Text = "Batal"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(214, 358)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(65, 23)
        Me.Button2.TabIndex = 61
        Me.Button2.Text = "Hapus"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(144, 358)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(54, 23)
        Me.Button1.TabIndex = 60
        Me.Button1.Text = "Edit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(63, 358)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(60, 23)
        Me.btnSubmit.TabIndex = 59
        Me.btnSubmit.Text = "Tambah"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.TA_VB_Tihen.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(12, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(130, 88)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 65
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TransaksiToolStripMenuItem, Me.MemberToolStripMenuItem, Me.DaftarMenuToolStripMenuItem, Me.KaryawanToolStripMenuItem})
        MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        MenuStrip1.Location = New System.Drawing.Point(0, 0)
        MenuStrip1.Margin = New System.Windows.Forms.Padding(100, 10, 10, 10)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        MenuStrip1.Size = New System.Drawing.Size(615, 44)
        MenuStrip1.TabIndex = 64
        MenuStrip1.Text = "MenuStrip1"
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
        Me.DaftarMenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MinumanToolStripMenuItem, Me.TopingToolStripMenuItem})
        Me.DaftarMenuToolStripMenuItem.Image = Global.TA_VB_Tihen.My.Resources.Resources.menu
        Me.DaftarMenuToolStripMenuItem.Margin = New System.Windows.Forms.Padding(10)
        Me.DaftarMenuToolStripMenuItem.Name = "DaftarMenuToolStripMenuItem"
        Me.DaftarMenuToolStripMenuItem.RightToLeftAutoMirrorImage = True
        Me.DaftarMenuToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
        Me.DaftarMenuToolStripMenuItem.Text = "Daftar Menu"
        Me.DaftarMenuToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.DaftarMenuToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'MinumanToolStripMenuItem
        '
        Me.MinumanToolStripMenuItem.Name = "MinumanToolStripMenuItem"
        Me.MinumanToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.MinumanToolStripMenuItem.Text = "Minuman"
        '
        'TopingToolStripMenuItem
        '
        Me.TopingToolStripMenuItem.Name = "TopingToolStripMenuItem"
        Me.TopingToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.TopingToolStripMenuItem.Text = "Toping"
        '
        'KaryawanToolStripMenuItem
        '
        Me.KaryawanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem})
        Me.KaryawanToolStripMenuItem.Image = Global.TA_VB_Tihen.My.Resources.Resources.username
        Me.KaryawanToolStripMenuItem.Margin = New System.Windows.Forms.Padding(10)
        Me.KaryawanToolStripMenuItem.Name = "KaryawanToolStripMenuItem"
        Me.KaryawanToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.KaryawanToolStripMenuItem.Text = "     "
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'Toping
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 406)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(MenuStrip1)
        Me.Controls.Add(Me.DataToping)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.textbox)
        Me.Controls.Add(Me.stokT)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.txtIdT)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtToping)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtHargaT)
        Me.Name = "Toping"
        Me.Text = "Toping"
        CType(Me.DataToping, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents textbox As System.Windows.Forms.Label
    Friend WithEvents stokT As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents txtIdT As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtToping As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtHargaT As System.Windows.Forms.TextBox
    Friend WithEvents DataToping As System.Windows.Forms.DataGridView
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TransaksiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MemberToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DaftarMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MinumanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TopingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KaryawanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
