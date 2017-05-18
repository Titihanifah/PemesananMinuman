<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Minuman
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Minuman))
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.TextBoxStock = New System.Windows.Forms.TextBox
        Me.LabelStok = New System.Windows.Forms.Label
        Me.ButtonHapus = New System.Windows.Forms.Button
        Me.ButtonEdit = New System.Windows.Forms.Button
        Me.ButtonTambah = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.TextBoxHarga = New System.Windows.Forms.TextBox
        Me.TextBoxNama = New System.Windows.Forms.TextBox
        Me.TextBoxId = New System.Windows.Forms.TextBox
        Me.LabelHarga = New System.Windows.Forms.Label
        Me.LabelNama = New System.Windows.Forms.Label
        Me.LabelId = New System.Windows.Forms.Label
        Me.LabelJudul = New System.Windows.Forms.Label
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DaftarMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MinumanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TopingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.KaryawanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        MenuStrip1 = New System.Windows.Forms.MenuStrip
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(388, 126)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(109, 21)
        Me.ComboBox1.TabIndex = 35
        '
        'TextBoxStock
        '
        Me.TextBoxStock.Location = New System.Drawing.Point(251, 251)
        Me.TextBoxStock.Name = "TextBoxStock"
        Me.TextBoxStock.Size = New System.Drawing.Size(246, 20)
        Me.TextBoxStock.TabIndex = 34
        '
        'LabelStok
        '
        Me.LabelStok.AutoSize = True
        Me.LabelStok.Location = New System.Drawing.Point(107, 251)
        Me.LabelStok.Name = "LabelStok"
        Me.LabelStok.Size = New System.Drawing.Size(35, 13)
        Me.LabelStok.TabIndex = 33
        Me.LabelStok.Text = "Stock"
        '
        'ButtonHapus
        '
        Me.ButtonHapus.Location = New System.Drawing.Point(434, 449)
        Me.ButtonHapus.Name = "ButtonHapus"
        Me.ButtonHapus.Size = New System.Drawing.Size(75, 23)
        Me.ButtonHapus.TabIndex = 32
        Me.ButtonHapus.Text = "Hapus"
        Me.ButtonHapus.UseVisualStyleBackColor = True
        '
        'ButtonEdit
        '
        Me.ButtonEdit.Location = New System.Drawing.Point(335, 449)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEdit.TabIndex = 31
        Me.ButtonEdit.Text = "Edit"
        Me.ButtonEdit.UseVisualStyleBackColor = True
        '
        'ButtonTambah
        '
        Me.ButtonTambah.Location = New System.Drawing.Point(90, 449)
        Me.ButtonTambah.Name = "ButtonTambah"
        Me.ButtonTambah.Size = New System.Drawing.Size(75, 23)
        Me.ButtonTambah.TabIndex = 30
        Me.ButtonTambah.Text = "Tambah"
        Me.ButtonTambah.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(109, 295)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(369, 135)
        Me.DataGridView1.TabIndex = 29
        '
        'TextBoxHarga
        '
        Me.TextBoxHarga.Location = New System.Drawing.Point(251, 209)
        Me.TextBoxHarga.Name = "TextBoxHarga"
        Me.TextBoxHarga.Size = New System.Drawing.Size(246, 20)
        Me.TextBoxHarga.TabIndex = 28
        '
        'TextBoxNama
        '
        Me.TextBoxNama.Location = New System.Drawing.Point(251, 168)
        Me.TextBoxNama.Name = "TextBoxNama"
        Me.TextBoxNama.Size = New System.Drawing.Size(246, 20)
        Me.TextBoxNama.TabIndex = 27
        '
        'TextBoxId
        '
        Me.TextBoxId.Location = New System.Drawing.Point(251, 127)
        Me.TextBoxId.Name = "TextBoxId"
        Me.TextBoxId.Size = New System.Drawing.Size(130, 20)
        Me.TextBoxId.TabIndex = 26
        '
        'LabelHarga
        '
        Me.LabelHarga.AutoSize = True
        Me.LabelHarga.Location = New System.Drawing.Point(106, 209)
        Me.LabelHarga.Name = "LabelHarga"
        Me.LabelHarga.Size = New System.Drawing.Size(36, 13)
        Me.LabelHarga.TabIndex = 25
        Me.LabelHarga.Text = "Harga"
        '
        'LabelNama
        '
        Me.LabelNama.AutoSize = True
        Me.LabelNama.Location = New System.Drawing.Point(106, 168)
        Me.LabelNama.Name = "LabelNama"
        Me.LabelNama.Size = New System.Drawing.Size(84, 13)
        Me.LabelNama.TabIndex = 24
        Me.LabelNama.Text = "Nama Minuman "
        '
        'LabelId
        '
        Me.LabelId.AutoSize = True
        Me.LabelId.Location = New System.Drawing.Point(106, 127)
        Me.LabelId.Name = "LabelId"
        Me.LabelId.Size = New System.Drawing.Size(67, 13)
        Me.LabelId.TabIndex = 23
        Me.LabelId.Text = "ID Minuman "
        '
        'LabelJudul
        '
        Me.LabelJudul.AutoSize = True
        Me.LabelJudul.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelJudul.Location = New System.Drawing.Point(187, 65)
        Me.LabelJudul.Name = "LabelJudul"
        Me.LabelJudul.Size = New System.Drawing.Size(251, 25)
        Me.LabelJudul.TabIndex = 22
        Me.LabelJudul.Text = "Daftar Stock Minuman "
        Me.LabelJudul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.TA_VB_Tihen.My.Resources.Resources.logo
        Me.PictureBox3.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(64, 44)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 74
        Me.PictureBox3.TabStop = False
        '
        'MenuStrip1
        '
        MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder
        MenuStrip1.BackgroundImage = Global.TA_VB_Tihen.My.Resources.Resources._270_Mesh_Header_LightOrange_Yellow
        MenuStrip1.GripMargin = New System.Windows.Forms.Padding(0)
        MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TransaksiToolStripMenuItem, Me.MemberToolStripMenuItem, Me.DaftarMenuToolStripMenuItem, Me.KaryawanToolStripMenuItem})
        MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        MenuStrip1.Location = New System.Drawing.Point(0, 0)
        MenuStrip1.Margin = New System.Windows.Forms.Padding(100, 10, 10, 10)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        MenuStrip1.Size = New System.Drawing.Size(591, 44)
        MenuStrip1.TabIndex = 73
        MenuStrip1.Text = "MenuStrip1"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.TransaksiToolStripMenuItem.CheckOnClick = True
        Me.TransaksiToolStripMenuItem.Font = New System.Drawing.Font("DFGothic-EB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TransaksiToolStripMenuItem.Image = CType(resources.GetObject("TransaksiToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TransaksiToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TransaksiToolStripMenuItem.Margin = New System.Windows.Forms.Padding(70, 10, 10, 10)
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.RightToLeftAutoMirrorImage = True
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(108, 20)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        Me.TransaksiToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TransaksiToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'MemberToolStripMenuItem
        '
        Me.MemberToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.MemberToolStripMenuItem.AutoToolTip = True
        Me.MemberToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MemberToolStripMenuItem.Font = New System.Drawing.Font("DFGothic-EB", 12.0!)
        Me.MemberToolStripMenuItem.Image = Global.TA_VB_Tihen.My.Resources.Resources.member
        Me.MemberToolStripMenuItem.Margin = New System.Windows.Forms.Padding(10)
        Me.MemberToolStripMenuItem.Name = "MemberToolStripMenuItem"
        Me.MemberToolStripMenuItem.RightToLeftAutoMirrorImage = True
        Me.MemberToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.MemberToolStripMenuItem.Text = "Member"
        Me.MemberToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.MemberToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'DaftarMenuToolStripMenuItem
        '
        Me.DaftarMenuToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.DaftarMenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MinumanToolStripMenuItem, Me.TopingToolStripMenuItem})
        Me.DaftarMenuToolStripMenuItem.Font = New System.Drawing.Font("DFGothic-EB", 12.0!)
        Me.DaftarMenuToolStripMenuItem.Image = Global.TA_VB_Tihen.My.Resources.Resources.menu
        Me.DaftarMenuToolStripMenuItem.Margin = New System.Windows.Forms.Padding(10)
        Me.DaftarMenuToolStripMenuItem.Name = "DaftarMenuToolStripMenuItem"
        Me.DaftarMenuToolStripMenuItem.RightToLeftAutoMirrorImage = True
        Me.DaftarMenuToolStripMenuItem.Size = New System.Drawing.Size(124, 20)
        Me.DaftarMenuToolStripMenuItem.Text = "Daftar Menu"
        Me.DaftarMenuToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.DaftarMenuToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'MinumanToolStripMenuItem
        '
        Me.MinumanToolStripMenuItem.BackgroundImage = Global.TA_VB_Tihen.My.Resources.Resources._1
        Me.MinumanToolStripMenuItem.Name = "MinumanToolStripMenuItem"
        Me.MinumanToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.MinumanToolStripMenuItem.Text = "Minuman"
        '
        'TopingToolStripMenuItem
        '
        Me.TopingToolStripMenuItem.BackgroundImage = Global.TA_VB_Tihen.My.Resources.Resources._1
        Me.TopingToolStripMenuItem.Name = "TopingToolStripMenuItem"
        Me.TopingToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.TopingToolStripMenuItem.Text = "Toping"
        '
        'KaryawanToolStripMenuItem
        '
        Me.KaryawanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem})
        Me.KaryawanToolStripMenuItem.Font = New System.Drawing.Font("DFGothic-EB", 12.0!)
        Me.KaryawanToolStripMenuItem.Image = Global.TA_VB_Tihen.My.Resources.Resources.username
        Me.KaryawanToolStripMenuItem.Margin = New System.Windows.Forms.Padding(10)
        Me.KaryawanToolStripMenuItem.Name = "KaryawanToolStripMenuItem"
        Me.KaryawanToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.KaryawanToolStripMenuItem.Text = "     "
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.BackgroundImage = Global.TA_VB_Tihen.My.Resources.Resources._1
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'Minuman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 506)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(MenuStrip1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBoxStock)
        Me.Controls.Add(Me.LabelStok)
        Me.Controls.Add(Me.ButtonHapus)
        Me.Controls.Add(Me.ButtonEdit)
        Me.Controls.Add(Me.ButtonTambah)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBoxHarga)
        Me.Controls.Add(Me.TextBoxNama)
        Me.Controls.Add(Me.TextBoxId)
        Me.Controls.Add(Me.LabelHarga)
        Me.Controls.Add(Me.LabelNama)
        Me.Controls.Add(Me.LabelId)
        Me.Controls.Add(Me.LabelJudul)
        Me.Name = "Minuman"
        Me.Text = "Minuman"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBoxStock As System.Windows.Forms.TextBox
    Friend WithEvents LabelStok As System.Windows.Forms.Label
    Friend WithEvents ButtonHapus As System.Windows.Forms.Button
    Friend WithEvents ButtonEdit As System.Windows.Forms.Button
    Friend WithEvents ButtonTambah As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TextBoxHarga As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNama As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxId As System.Windows.Forms.TextBox
    Friend WithEvents LabelHarga As System.Windows.Forms.Label
    Friend WithEvents LabelNama As System.Windows.Forms.Label
    Friend WithEvents LabelId As System.Windows.Forms.Label
    Friend WithEvents LabelJudul As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents TransaksiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MemberToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DaftarMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MinumanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TopingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KaryawanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
