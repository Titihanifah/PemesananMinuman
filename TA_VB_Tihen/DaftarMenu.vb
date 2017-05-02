Public Class DaftarMenu



    Private Sub Menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DaftarMenu.Click
        Form1.Visible = True
        Me.Visible = False
    End Sub

   

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Member.Visible = True
        Me.Visible = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Pesan.Visible = True
        Me.Visible = False
    End Sub

    Private Sub DaftarMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class