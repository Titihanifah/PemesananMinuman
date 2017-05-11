<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BerandaKaryawan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BerandaKaryawan))
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DaftarMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MinumanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TopingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.KaryawanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        MenuStrip1 = New System.Windows.Forms.MenuStrip
        MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TransaksiToolStripMenuItem, Me.MemberToolStripMenuItem, Me.DaftarMenuToolStripMenuItem, Me.KaryawanToolStripMenuItem})
        MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        MenuStrip1.Location = New System.Drawing.Point(0, 0)
        MenuStrip1.Margin = New System.Windows.Forms.Padding(100, 10, 10, 10)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        MenuStrip1.Size = New System.Drawing.Size(675, 44)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        AddHandler MenuStrip1.ItemClicked, AddressOf Me.MenuStrip1_ItemClicked
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
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(266, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 32)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Daftar Menu"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(350, 78)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Order"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(440, 78)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Member"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.TA_VB_Tihen.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(44, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(152, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.TA_VB_Tihen.My.Resources.Resources.logo
        Me.PictureBox2.Location = New System.Drawing.Point(0, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(154, 78)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'BerandaKaryawan
        '
        Me.ClientSize = New System.Drawing.Size(675, 387)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(MenuStrip1)
        Me.MainMenuStrip = MenuStrip1
        Me.Name = "BerandaKaryawan"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents DaftarMenu As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DaftarMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MemberToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents MinumanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TopingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KaryawanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
