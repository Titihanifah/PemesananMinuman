Public Class Transaksi

    Private Sub Transaksi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TransaksiUsername.Text = BerandaKaryawan.KaryawanToolStripMenuItem.Text
    End Sub


    Private Sub MemberToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MemberToolStripMenuItem.Click
        Me.Visible = False
        Member.Visible = True
    End Sub


    Private Sub MinumanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MinumanToolStripMenuItem.Click
        Me.Visible = False
        Minuman.Visible = True
    End Sub

    Private Sub TopingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TopingToolStripMenuItem.Click
        Me.Visible = False
        Toping.Visible = True
    End Sub

    Private Sub BerandaKaryawan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TransaksiUsername.Text = LoginForm1.box.Text

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Visible = False
        LoginForm1.Visible = True
    End Sub

End Class