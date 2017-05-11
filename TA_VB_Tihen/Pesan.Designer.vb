<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pesan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pesan))
        Me.txtKembali = New System.Windows.Forms.Label
        Me.lbljmlgreentea = New System.Windows.Forms.Label
        Me.txtjmlgreentea = New System.Windows.Forms.TextBox
        Me.Hasil = New System.Windows.Forms.GroupBox
        Me.lblKembali = New System.Windows.Forms.Label
        Me.txtBayar = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblHarga = New System.Windows.Forms.Label
        Me.lblTotal = New System.Windows.Forms.Label
        Me.lbljmlcaramel = New System.Windows.Forms.Label
        Me.txtjmlcaramel = New System.Windows.Forms.TextBox
        Me.lbljmlcapucino = New System.Windows.Forms.Label
        Me.txtjmlcapucino = New System.Windows.Forms.TextBox
        Me.lbljmlbublegum = New System.Windows.Forms.Label
        Me.txtjmlbublegum = New System.Windows.Forms.TextBox
        Me.Cetak = New System.Windows.Forms.Button
        Me.lbljmlmilo = New System.Windows.Forms.Label
        Me.txtjmlmilo = New System.Windows.Forms.TextBox
        Me.lbljmlhazelnut = New System.Windows.Forms.Label
        Me.txtjmlhazelnut = New System.Windows.Forms.TextBox
        Me.lbljmlVanila = New System.Windows.Forms.Label
        Me.txtjmlVanila = New System.Windows.Forms.TextBox
        Me.radioOreo = New System.Windows.Forms.RadioButton
        Me.lbljumlah = New System.Windows.Forms.Label
        Me.txtJumlah = New System.Windows.Forms.TextBox
        Me.GreenTea = New System.Windows.Forms.CheckBox
        Me.radioPudding = New System.Windows.Forms.RadioButton
        Me.Caramel = New System.Windows.Forms.CheckBox
        Me.radioPearl = New System.Windows.Forms.RadioButton
        Me.Cappucino = New System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BubbleGum = New System.Windows.Forms.CheckBox
        Me.Milo = New System.Windows.Forms.CheckBox
        Me.Hazelnut = New System.Windows.Forms.CheckBox
        Me.VanillaChocho = New System.Windows.Forms.CheckBox
        Me.checkChochoOreo = New System.Windows.Forms.CheckBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.btnReset = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtnama = New System.Windows.Forms.TextBox
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DaftarMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.Hasil.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        MenuStrip1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtKembali
        '
        Me.txtKembali.AutoSize = True
        Me.txtKembali.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtKembali.Location = New System.Drawing.Point(91, 85)
        Me.txtKembali.Name = "txtKembali"
        Me.txtKembali.Size = New System.Drawing.Size(13, 13)
        Me.txtKembali.TabIndex = 28
        Me.txtKembali.Text = "  "
        '
        'lbljmlgreentea
        '
        Me.lbljmlgreentea.AutoSize = True
        Me.lbljmlgreentea.Location = New System.Drawing.Point(156, 270)
        Me.lbljmlgreentea.Name = "lbljmlgreentea"
        Me.lbljmlgreentea.Size = New System.Drawing.Size(40, 13)
        Me.lbljmlgreentea.TabIndex = 23
        Me.lbljmlgreentea.Text = "Jumlah"
        '
        'txtjmlgreentea
        '
        Me.txtjmlgreentea.Location = New System.Drawing.Point(202, 267)
        Me.txtjmlgreentea.Name = "txtjmlgreentea"
        Me.txtjmlgreentea.Size = New System.Drawing.Size(52, 20)
        Me.txtjmlgreentea.TabIndex = 22
        '
        'Hasil
        '
        Me.Hasil.Controls.Add(Me.txtKembali)
        Me.Hasil.Controls.Add(Me.lblKembali)
        Me.Hasil.Controls.Add(Me.txtBayar)
        Me.Hasil.Controls.Add(Me.Label3)
        Me.Hasil.Controls.Add(Me.lblHarga)
        Me.Hasil.Controls.Add(Me.lblTotal)
        Me.Hasil.Location = New System.Drawing.Point(367, 361)
        Me.Hasil.Name = "Hasil"
        Me.Hasil.Size = New System.Drawing.Size(188, 113)
        Me.Hasil.TabIndex = 14
        Me.Hasil.TabStop = False
        Me.Hasil.Text = "Hasil"
        '
        'lblKembali
        '
        Me.lblKembali.AutoSize = True
        Me.lblKembali.Location = New System.Drawing.Point(6, 84)
        Me.lblKembali.Name = "lblKembali"
        Me.lblKembali.Size = New System.Drawing.Size(44, 13)
        Me.lblKembali.TabIndex = 27
        Me.lblKembali.Text = "Kembali"
        '
        'txtBayar
        '
        Me.txtBayar.Location = New System.Drawing.Point(94, 52)
        Me.txtBayar.Name = "txtBayar"
        Me.txtBayar.Size = New System.Drawing.Size(88, 20)
        Me.txtBayar.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Bayar"
        '
        'lblHarga
        '
        Me.lblHarga.AutoSize = True
        Me.lblHarga.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblHarga.Location = New System.Drawing.Point(91, 28)
        Me.lblHarga.Name = "lblHarga"
        Me.lblHarga.Size = New System.Drawing.Size(13, 13)
        Me.lblHarga.TabIndex = 25
        Me.lblHarga.Text = "  "
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(6, 27)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(36, 13)
        Me.lblTotal.TabIndex = 24
        Me.lblTotal.Text = "Harga"
        '
        'lbljmlcaramel
        '
        Me.lbljmlcaramel.AutoSize = True
        Me.lbljmlcaramel.Location = New System.Drawing.Point(156, 230)
        Me.lbljmlcaramel.Name = "lbljmlcaramel"
        Me.lbljmlcaramel.Size = New System.Drawing.Size(40, 13)
        Me.lbljmlcaramel.TabIndex = 21
        Me.lbljmlcaramel.Text = "Jumlah"
        '
        'txtjmlcaramel
        '
        Me.txtjmlcaramel.Location = New System.Drawing.Point(202, 227)
        Me.txtjmlcaramel.Name = "txtjmlcaramel"
        Me.txtjmlcaramel.Size = New System.Drawing.Size(52, 20)
        Me.txtjmlcaramel.TabIndex = 20
        '
        'lbljmlcapucino
        '
        Me.lbljmlcapucino.AutoSize = True
        Me.lbljmlcapucino.Location = New System.Drawing.Point(156, 197)
        Me.lbljmlcapucino.Name = "lbljmlcapucino"
        Me.lbljmlcapucino.Size = New System.Drawing.Size(40, 13)
        Me.lbljmlcapucino.TabIndex = 19
        Me.lbljmlcapucino.Text = "Jumlah"
        '
        'txtjmlcapucino
        '
        Me.txtjmlcapucino.Location = New System.Drawing.Point(202, 194)
        Me.txtjmlcapucino.Name = "txtjmlcapucino"
        Me.txtjmlcapucino.Size = New System.Drawing.Size(52, 20)
        Me.txtjmlcapucino.TabIndex = 18
        '
        'lbljmlbublegum
        '
        Me.lbljmlbublegum.AutoSize = True
        Me.lbljmlbublegum.Location = New System.Drawing.Point(156, 161)
        Me.lbljmlbublegum.Name = "lbljmlbublegum"
        Me.lbljmlbublegum.Size = New System.Drawing.Size(40, 13)
        Me.lbljmlbublegum.TabIndex = 17
        Me.lbljmlbublegum.Text = "Jumlah"
        '
        'txtjmlbublegum
        '
        Me.txtjmlbublegum.Location = New System.Drawing.Point(202, 158)
        Me.txtjmlbublegum.Name = "txtjmlbublegum"
        Me.txtjmlbublegum.Size = New System.Drawing.Size(52, 20)
        Me.txtjmlbublegum.TabIndex = 16
        '
        'Cetak
        '
        Me.Cetak.Location = New System.Drawing.Point(211, 502)
        Me.Cetak.Name = "Cetak"
        Me.Cetak.Size = New System.Drawing.Size(75, 23)
        Me.Cetak.TabIndex = 12
        Me.Cetak.Text = "Cetak"
        Me.Cetak.UseVisualStyleBackColor = True
        '
        'lbljmlmilo
        '
        Me.lbljmlmilo.AutoSize = True
        Me.lbljmlmilo.Location = New System.Drawing.Point(156, 128)
        Me.lbljmlmilo.Name = "lbljmlmilo"
        Me.lbljmlmilo.Size = New System.Drawing.Size(40, 13)
        Me.lbljmlmilo.TabIndex = 15
        Me.lbljmlmilo.Text = "Jumlah"
        '
        'txtjmlmilo
        '
        Me.txtjmlmilo.Location = New System.Drawing.Point(202, 125)
        Me.txtjmlmilo.Name = "txtjmlmilo"
        Me.txtjmlmilo.Size = New System.Drawing.Size(52, 20)
        Me.txtjmlmilo.TabIndex = 14
        '
        'lbljmlhazelnut
        '
        Me.lbljmlhazelnut.AutoSize = True
        Me.lbljmlhazelnut.Location = New System.Drawing.Point(156, 95)
        Me.lbljmlhazelnut.Name = "lbljmlhazelnut"
        Me.lbljmlhazelnut.Size = New System.Drawing.Size(40, 13)
        Me.lbljmlhazelnut.TabIndex = 13
        Me.lbljmlhazelnut.Text = "Jumlah"
        '
        'txtjmlhazelnut
        '
        Me.txtjmlhazelnut.Location = New System.Drawing.Point(202, 92)
        Me.txtjmlhazelnut.Name = "txtjmlhazelnut"
        Me.txtjmlhazelnut.Size = New System.Drawing.Size(52, 20)
        Me.txtjmlhazelnut.TabIndex = 12
        '
        'lbljmlVanila
        '
        Me.lbljmlVanila.AutoSize = True
        Me.lbljmlVanila.Location = New System.Drawing.Point(156, 63)
        Me.lbljmlVanila.Name = "lbljmlVanila"
        Me.lbljmlVanila.Size = New System.Drawing.Size(40, 13)
        Me.lbljmlVanila.TabIndex = 11
        Me.lbljmlVanila.Text = "Jumlah"
        '
        'txtjmlVanila
        '
        Me.txtjmlVanila.Location = New System.Drawing.Point(202, 60)
        Me.txtjmlVanila.Name = "txtjmlVanila"
        Me.txtjmlVanila.Size = New System.Drawing.Size(52, 20)
        Me.txtjmlVanila.TabIndex = 10
        '
        'radioOreo
        '
        Me.radioOreo.AutoSize = True
        Me.radioOreo.Location = New System.Drawing.Point(22, 29)
        Me.radioOreo.Name = "radioOreo"
        Me.radioOreo.Size = New System.Drawing.Size(48, 17)
        Me.radioOreo.TabIndex = 0
        Me.radioOreo.TabStop = True
        Me.radioOreo.Text = "Oreo"
        Me.radioOreo.UseVisualStyleBackColor = True
        '
        'lbljumlah
        '
        Me.lbljumlah.AutoSize = True
        Me.lbljumlah.Location = New System.Drawing.Point(156, 28)
        Me.lbljumlah.Name = "lbljumlah"
        Me.lbljumlah.Size = New System.Drawing.Size(40, 13)
        Me.lbljumlah.TabIndex = 9
        Me.lbljumlah.Text = "Jumlah"
        '
        'txtJumlah
        '
        Me.txtJumlah.Location = New System.Drawing.Point(202, 25)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(52, 20)
        Me.txtJumlah.TabIndex = 8
        '
        'GreenTea
        '
        Me.GreenTea.AutoSize = True
        Me.GreenTea.Location = New System.Drawing.Point(6, 266)
        Me.GreenTea.Name = "GreenTea"
        Me.GreenTea.Size = New System.Drawing.Size(77, 17)
        Me.GreenTea.TabIndex = 7
        Me.GreenTea.Text = "Green Tea"
        Me.GreenTea.UseVisualStyleBackColor = True
        '
        'radioPudding
        '
        Me.radioPudding.AutoSize = True
        Me.radioPudding.Location = New System.Drawing.Point(22, 60)
        Me.radioPudding.Name = "radioPudding"
        Me.radioPudding.Size = New System.Drawing.Size(64, 17)
        Me.radioPudding.TabIndex = 1
        Me.radioPudding.TabStop = True
        Me.radioPudding.Text = "Pudding"
        Me.radioPudding.UseVisualStyleBackColor = True
        '
        'Caramel
        '
        Me.Caramel.AutoSize = True
        Me.Caramel.Location = New System.Drawing.Point(6, 230)
        Me.Caramel.Name = "Caramel"
        Me.Caramel.Size = New System.Drawing.Size(64, 17)
        Me.Caramel.TabIndex = 6
        Me.Caramel.Text = "Caramel"
        Me.Caramel.UseVisualStyleBackColor = True
        '
        'radioPearl
        '
        Me.radioPearl.AutoSize = True
        Me.radioPearl.Location = New System.Drawing.Point(22, 93)
        Me.radioPearl.Name = "radioPearl"
        Me.radioPearl.Size = New System.Drawing.Size(49, 17)
        Me.radioPearl.TabIndex = 2
        Me.radioPearl.TabStop = True
        Me.radioPearl.Text = "Pearl"
        Me.radioPearl.UseVisualStyleBackColor = True
        '
        'Cappucino
        '
        Me.Cappucino.AutoSize = True
        Me.Cappucino.Location = New System.Drawing.Point(6, 194)
        Me.Cappucino.Name = "Cappucino"
        Me.Cappucino.Size = New System.Drawing.Size(77, 17)
        Me.Cappucino.TabIndex = 5
        Me.Cappucino.Text = "Cappucino"
        Me.Cappucino.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbljmlgreentea)
        Me.GroupBox1.Controls.Add(Me.txtjmlgreentea)
        Me.GroupBox1.Controls.Add(Me.lbljmlcaramel)
        Me.GroupBox1.Controls.Add(Me.txtjmlcaramel)
        Me.GroupBox1.Controls.Add(Me.lbljmlcapucino)
        Me.GroupBox1.Controls.Add(Me.txtjmlcapucino)
        Me.GroupBox1.Controls.Add(Me.lbljmlbublegum)
        Me.GroupBox1.Controls.Add(Me.txtjmlbublegum)
        Me.GroupBox1.Controls.Add(Me.lbljmlmilo)
        Me.GroupBox1.Controls.Add(Me.txtjmlmilo)
        Me.GroupBox1.Controls.Add(Me.lbljmlhazelnut)
        Me.GroupBox1.Controls.Add(Me.txtjmlhazelnut)
        Me.GroupBox1.Controls.Add(Me.lbljmlVanila)
        Me.GroupBox1.Controls.Add(Me.txtjmlVanila)
        Me.GroupBox1.Controls.Add(Me.lbljumlah)
        Me.GroupBox1.Controls.Add(Me.txtJumlah)
        Me.GroupBox1.Controls.Add(Me.GreenTea)
        Me.GroupBox1.Controls.Add(Me.Caramel)
        Me.GroupBox1.Controls.Add(Me.Cappucino)
        Me.GroupBox1.Controls.Add(Me.BubbleGum)
        Me.GroupBox1.Controls.Add(Me.Milo)
        Me.GroupBox1.Controls.Add(Me.Hazelnut)
        Me.GroupBox1.Controls.Add(Me.VanillaChocho)
        Me.GroupBox1.Controls.Add(Me.checkChochoOreo)
        Me.GroupBox1.Location = New System.Drawing.Point(64, 141)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(274, 333)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Minuman"
        '
        'BubbleGum
        '
        Me.BubbleGum.AutoSize = True
        Me.BubbleGum.Location = New System.Drawing.Point(6, 158)
        Me.BubbleGum.Name = "BubbleGum"
        Me.BubbleGum.Size = New System.Drawing.Size(78, 17)
        Me.BubbleGum.TabIndex = 4
        Me.BubbleGum.Text = "Buble Gum"
        Me.BubbleGum.UseVisualStyleBackColor = True
        '
        'Milo
        '
        Me.Milo.AutoSize = True
        Me.Milo.Location = New System.Drawing.Point(6, 125)
        Me.Milo.Name = "Milo"
        Me.Milo.Size = New System.Drawing.Size(45, 17)
        Me.Milo.TabIndex = 3
        Me.Milo.Text = "Milo"
        Me.Milo.UseVisualStyleBackColor = True
        '
        'Hazelnut
        '
        Me.Hazelnut.AutoSize = True
        Me.Hazelnut.Location = New System.Drawing.Point(6, 92)
        Me.Hazelnut.Name = "Hazelnut"
        Me.Hazelnut.Size = New System.Drawing.Size(108, 17)
        Me.Hazelnut.TabIndex = 2
        Me.Hazelnut.Text = "Hazelnut Chocho"
        Me.Hazelnut.UseVisualStyleBackColor = True
        '
        'VanillaChocho
        '
        Me.VanillaChocho.AutoSize = True
        Me.VanillaChocho.Location = New System.Drawing.Point(6, 60)
        Me.VanillaChocho.Name = "VanillaChocho"
        Me.VanillaChocho.Size = New System.Drawing.Size(89, 17)
        Me.VanillaChocho.TabIndex = 1
        Me.VanillaChocho.Text = "Vanila Choco"
        Me.VanillaChocho.UseVisualStyleBackColor = True
        '
        'checkChochoOreo
        '
        Me.checkChochoOreo.AutoSize = True
        Me.checkChochoOreo.Location = New System.Drawing.Point(6, 28)
        Me.checkChochoOreo.Name = "checkChochoOreo"
        Me.checkChochoOreo.Size = New System.Drawing.Size(89, 17)
        Me.checkChochoOreo.TabIndex = 0
        Me.checkChochoOreo.Text = "Chocho Oreo"
        Me.checkChochoOreo.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.radioPearl)
        Me.GroupBox5.Controls.Add(Me.radioPudding)
        Me.GroupBox5.Controls.Add(Me.radioOreo)
        Me.GroupBox5.Location = New System.Drawing.Point(366, 140)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(189, 211)
        Me.GroupBox5.TabIndex = 11
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Toping"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(331, 502)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 15
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Nama"
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(172, 111)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(151, 20)
        Me.txtnama.TabIndex = 24
        '
        'MenuStrip1
        '
        MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TransaksiToolStripMenuItem, Me.MemberToolStripMenuItem, Me.DaftarMenuToolStripMenuItem})
        MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        MenuStrip1.Location = New System.Drawing.Point(0, 0)
        MenuStrip1.Margin = New System.Windows.Forms.Padding(100, 10, 10, 10)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        MenuStrip1.Size = New System.Drawing.Size(595, 44)
        MenuStrip1.TabIndex = 26
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
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
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
        Me.PictureBox2.Location = New System.Drawing.Point(5, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(142, 78)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 27
        Me.PictureBox2.TabStop = False
        '
        'Pesan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(595, 544)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(MenuStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.Hasil)
        Me.Controls.Add(Me.Cetak)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.btnReset)
        Me.Name = "Pesan"
        Me.Text = "Pesan"
        Me.Hasil.ResumeLayout(False)
        Me.Hasil.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtKembali As System.Windows.Forms.Label
    Friend WithEvents lbljmlgreentea As System.Windows.Forms.Label
    Friend WithEvents txtjmlgreentea As System.Windows.Forms.TextBox
    Friend WithEvents Hasil As System.Windows.Forms.GroupBox
    Friend WithEvents lblKembali As System.Windows.Forms.Label
    Friend WithEvents txtBayar As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblHarga As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lbljmlcaramel As System.Windows.Forms.Label
    Friend WithEvents txtjmlcaramel As System.Windows.Forms.TextBox
    Friend WithEvents lbljmlcapucino As System.Windows.Forms.Label
    Friend WithEvents txtjmlcapucino As System.Windows.Forms.TextBox
    Friend WithEvents lbljmlbublegum As System.Windows.Forms.Label
    Friend WithEvents txtjmlbublegum As System.Windows.Forms.TextBox
    Friend WithEvents Cetak As System.Windows.Forms.Button
    Friend WithEvents lbljmlmilo As System.Windows.Forms.Label
    Friend WithEvents txtjmlmilo As System.Windows.Forms.TextBox
    Friend WithEvents lbljmlhazelnut As System.Windows.Forms.Label
    Friend WithEvents txtjmlhazelnut As System.Windows.Forms.TextBox
    Friend WithEvents lbljmlVanila As System.Windows.Forms.Label
    Friend WithEvents txtjmlVanila As System.Windows.Forms.TextBox
    Friend WithEvents radioOreo As System.Windows.Forms.RadioButton
    Friend WithEvents lbljumlah As System.Windows.Forms.Label
    Friend WithEvents txtJumlah As System.Windows.Forms.TextBox
    Friend WithEvents GreenTea As System.Windows.Forms.CheckBox
    Friend WithEvents radioPudding As System.Windows.Forms.RadioButton
    Friend WithEvents Caramel As System.Windows.Forms.CheckBox
    Friend WithEvents radioPearl As System.Windows.Forms.RadioButton
    Friend WithEvents Cappucino As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BubbleGum As System.Windows.Forms.CheckBox
    Friend WithEvents Milo As System.Windows.Forms.CheckBox
    Friend WithEvents Hazelnut As System.Windows.Forms.CheckBox
    Friend WithEvents VanillaChocho As System.Windows.Forms.CheckBox
    Friend WithEvents checkChochoOreo As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents TransaksiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MemberToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DaftarMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
