<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MinumanAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MinumanAdmin))
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.TextBoxStock = New System.Windows.Forms.TextBox
        Me.LabelStok = New System.Windows.Forms.Label
        Me.ButtonHapus = New System.Windows.Forms.Button
        Me.ButtonTambah = New System.Windows.Forms.Button
        Me.ButtonEdit = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.TextBoxHarga = New System.Windows.Forms.TextBox
        Me.TextBoxNama = New System.Windows.Forms.TextBox
        Me.TextBoxId = New System.Windows.Forms.TextBox
        Me.LabelHarga = New System.Windows.Forms.Label
        Me.LabelNama = New System.Windows.Forms.Label
        Me.LabelId = New System.Windows.Forms.Label
        Me.LabelJudul = New System.Windows.Forms.Label
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DaftarMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MinumanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TopingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.KaryawanToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.AkunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.KaryawanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        MenuStrip1 = New System.Windows.Forms.MenuStrip
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(388, 131)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 54
        '
        'TextBoxStock
        '
        Me.TextBoxStock.Location = New System.Drawing.Point(251, 256)
        Me.TextBoxStock.Name = "TextBoxStock"
        Me.TextBoxStock.Size = New System.Drawing.Size(246, 20)
        Me.TextBoxStock.TabIndex = 53
        '
        'LabelStok
        '
        Me.LabelStok.AutoSize = True
        Me.LabelStok.Location = New System.Drawing.Point(107, 256)
        Me.LabelStok.Name = "LabelStok"
        Me.LabelStok.Size = New System.Drawing.Size(35, 13)
        Me.LabelStok.TabIndex = 52
        Me.LabelStok.Text = "Stock"
        '
        'ButtonHapus
        '
        Me.ButtonHapus.Location = New System.Drawing.Point(434, 454)
        Me.ButtonHapus.Name = "ButtonHapus"
        Me.ButtonHapus.Size = New System.Drawing.Size(75, 23)
        Me.ButtonHapus.TabIndex = 51
        Me.ButtonHapus.Text = "Hapus"
        Me.ButtonHapus.UseVisualStyleBackColor = True
        '
        'ButtonTambah
        '
        Me.ButtonTambah.Location = New System.Drawing.Point(90, 454)
        Me.ButtonTambah.Name = "ButtonTambah"
        Me.ButtonTambah.Size = New System.Drawing.Size(75, 23)
        Me.ButtonTambah.TabIndex = 49
        Me.ButtonTambah.Text = "Tambah"
        Me.ButtonTambah.UseVisualStyleBackColor = True
        '
        'ButtonEdit
        '
        Me.ButtonEdit.Location = New System.Drawing.Point(335, 454)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEdit.TabIndex = 50
        Me.ButtonEdit.Text = "Edit"
        Me.ButtonEdit.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(128, 299)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(369, 135)
        Me.DataGridView1.TabIndex = 48
        '
        'TextBoxHarga
        '
        Me.TextBoxHarga.Location = New System.Drawing.Point(251, 223)
        Me.TextBoxHarga.Name = "TextBoxHarga"
        Me.TextBoxHarga.Size = New System.Drawing.Size(246, 20)
        Me.TextBoxHarga.TabIndex = 47
        '
        'TextBoxNama
        '
        Me.TextBoxNama.Location = New System.Drawing.Point(251, 175)
        Me.TextBoxNama.Name = "TextBoxNama"
        Me.TextBoxNama.Size = New System.Drawing.Size(246, 20)
        Me.TextBoxNama.TabIndex = 46
        '
        'TextBoxId
        '
        Me.TextBoxId.Location = New System.Drawing.Point(251, 132)
        Me.TextBoxId.Name = "TextBoxId"
        Me.TextBoxId.Size = New System.Drawing.Size(130, 20)
        Me.TextBoxId.TabIndex = 45
        '
        'LabelHarga
        '
        Me.LabelHarga.AutoSize = True
        Me.LabelHarga.Location = New System.Drawing.Point(106, 223)
        Me.LabelHarga.Name = "LabelHarga"
        Me.LabelHarga.Size = New System.Drawing.Size(36, 13)
        Me.LabelHarga.TabIndex = 44
        Me.LabelHarga.Text = "Harga"
        '
        'LabelNama
        '
        Me.LabelNama.AutoSize = True
        Me.LabelNama.Location = New System.Drawing.Point(106, 175)
        Me.LabelNama.Name = "LabelNama"
        Me.LabelNama.Size = New System.Drawing.Size(84, 13)
        Me.LabelNama.TabIndex = 43
        Me.LabelNama.Text = "Nama Minuman "
        '
        'LabelId
        '
        Me.LabelId.AutoSize = True
        Me.LabelId.Location = New System.Drawing.Point(106, 132)
        Me.LabelId.Name = "LabelId"
        Me.LabelId.Size = New System.Drawing.Size(67, 13)
        Me.LabelId.TabIndex = 42
        Me.LabelId.Text = "ID Minuman "
        '
        'LabelJudul
        '
        Me.LabelJudul.AutoSize = True
        Me.LabelJudul.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelJudul.Location = New System.Drawing.Point(246, 71)
        Me.LabelJudul.Name = "LabelJudul"
        Me.LabelJudul.Size = New System.Drawing.Size(251, 25)
        Me.LabelJudul.TabIndex = 41
        Me.LabelJudul.Text = "Daftar Stock Minuman "
        Me.LabelJudul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuStrip1
        '
        MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TransaksiToolStripMenuItem, Me.MemberToolStripMenuItem, Me.DaftarMenuToolStripMenuItem, Me.KaryawanToolStripMenuItem1, Me.AkunToolStripMenuItem, Me.KaryawanToolStripMenuItem})
        MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        MenuStrip1.Location = New System.Drawing.Point(0, 0)
        MenuStrip1.Margin = New System.Windows.Forms.Padding(100, 10, 10, 10)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        MenuStrip1.Size = New System.Drawing.Size(743, 44)
        MenuStrip1.TabIndex = 57
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
        'KaryawanToolStripMenuItem1
        '
        Me.KaryawanToolStripMenuItem1.Image = Global.TA_VB_Tihen.My.Resources.Resources.username
        Me.KaryawanToolStripMenuItem1.Margin = New System.Windows.Forms.Padding(10)
        Me.KaryawanToolStripMenuItem1.Name = "KaryawanToolStripMenuItem1"
        Me.KaryawanToolStripMenuItem1.Size = New System.Drawing.Size(86, 20)
        Me.KaryawanToolStripMenuItem1.Text = "Karyawan"
        '
        'AkunToolStripMenuItem
        '
        Me.AkunToolStripMenuItem.Image = Global.TA_VB_Tihen.My.Resources.Resources.username
        Me.AkunToolStripMenuItem.Margin = New System.Windows.Forms.Padding(10)
        Me.AkunToolStripMenuItem.Name = "AkunToolStripMenuItem"
        Me.AkunToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.AkunToolStripMenuItem.Text = "Akun"
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
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.TA_VB_Tihen.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(130, 88)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 58
        Me.PictureBox1.TabStop = False
        '
        'MinumanAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 483)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(MenuStrip1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBoxStock)
        Me.Controls.Add(Me.LabelStok)
        Me.Controls.Add(Me.ButtonHapus)
        Me.Controls.Add(Me.ButtonTambah)
        Me.Controls.Add(Me.ButtonEdit)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBoxHarga)
        Me.Controls.Add(Me.TextBoxNama)
        Me.Controls.Add(Me.TextBoxId)
        Me.Controls.Add(Me.LabelHarga)
        Me.Controls.Add(Me.LabelNama)
        Me.Controls.Add(Me.LabelId)
        Me.Controls.Add(Me.LabelJudul)
        Me.Name = "MinumanAdmin"
        Me.Text = "MinumanAdmin"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBoxStock As System.Windows.Forms.TextBox
    Friend WithEvents LabelStok As System.Windows.Forms.Label
    Friend WithEvents ButtonHapus As System.Windows.Forms.Button
    Friend WithEvents ButtonTambah As System.Windows.Forms.Button
    Friend WithEvents ButtonEdit As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TextBoxHarga As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNama As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxId As System.Windows.Forms.TextBox
    Friend WithEvents LabelHarga As System.Windows.Forms.Label
    Friend WithEvents LabelNama As System.Windows.Forms.Label
    Friend WithEvents LabelId As System.Windows.Forms.Label
    Friend WithEvents LabelJudul As System.Windows.Forms.Label
    Friend WithEvents TransaksiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MemberToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DaftarMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MinumanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TopingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KaryawanToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AkunToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KaryawanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
