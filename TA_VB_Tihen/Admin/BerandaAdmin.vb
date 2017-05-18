Public Class BerandaAdmin

    Private Sub BerandaAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AkunToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AkunToolStripMenuItem.Click
        Akun.Visible = True
        Me.Visible = False
    End Sub

    Private Sub TransaksiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransaksiToolStripMenuItem.Click
        Me.Visible = False
        Transaksi.Visible = True
    End Sub

    Private Sub MemberToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MemberToolStripMenuItem.Click
        Me.Visible = False
        Member.Visible = True
    End Sub

    Private Sub MinumanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MinumanToolStripMenuItem.Click
        Me.Visible = False
        MinumanAdmin.Visible = True
    End Sub

    Private Sub TopingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TopingToolStripMenuItem.Click
        Me.Visible = False
        Toping.Visible = True
    End Sub

    Private Sub KaryawanToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KaryawanToolStripMenuItem1.Click
        Me.Visible = False
        Karyawan.Visible = True
    End Sub

    
    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Visible = False
        LoginForm1.Visible = True
    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs)

    End Sub
End Class