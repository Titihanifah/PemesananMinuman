Public Class Pesan

    Dim harga, bayar, kembalian As Double


    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter
        lbljumlah.Visible = False
        txtJumlah.Visible = False
        lbljmlVanila.Visible = False
        txtjmlVanila.Visible = False
        lbljmlgreentea.Visible = False
        txtjmlgreentea.Visible = False
        lbljmlcaramel.Visible = False
        txtjmlcaramel.Visible = False
        lbljmlcapucino.Visible = False
        txtjmlcapucino.Visible = False
        lbljmlbublegum.Visible = False
        txtjmlbublegum.Visible = False
        lbljmlbublegum.Visible = False
        txtjmlbublegum.Visible = False
        lbljmlmilo.Visible = False
        txtjmlmilo.Visible = False
        lbljmlhazelnut.Visible = False
        txtjmlhazelnut.Visible = False

        'set jumlah = 0
        txtJumlah.Text = 0
        txtjmlVanila.Text = 0
        txtjmlgreentea.Text = 0
        txtjmlcaramel.Text = 0
        txtjmlcapucino.Text = 0
        txtjmlbublegum.Text = 0
        txtjmlbublegum.Text = 0
        txtjmlmilo.Text = 0
        txtjmlhazelnut.Text = 0
    End Sub
    Private Sub checkChochoOreo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkChochoOreo.CheckedChanged
        lbljumlah.Visible = True
        txtJumlah.Visible = True

    End Sub


    Private Sub VanillaChocho_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VanillaChocho.CheckedChanged
        lbljmlVanila.Visible = True
        txtjmlVanila.Visible = True


    End Sub

    Private Sub Hazelnut_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hazelnut.CheckedChanged
        lbljmlhazelnut.Visible = True
        txtjmlhazelnut.Visible = True
    End Sub

    Private Sub Milo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Milo.CheckedChanged
        lbljmlmilo.Visible = True
        txtjmlmilo.Visible = True
    End Sub

    Private Sub BubbleGum_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BubbleGum.CheckedChanged
        lbljmlbublegum.Visible = True
        txtjmlbublegum.Visible = True
    End Sub

    Private Sub Cappucino_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cappucino.CheckedChanged
        lbljmlcapucino.Visible = True
        txtjmlcapucino.Visible = True
    End Sub

    Private Sub Caramel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Caramel.CheckedChanged
        lbljmlcaramel.Visible = True
        txtjmlcaramel.Visible = True
    End Sub

    Private Sub GreenTea_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GreenTea.CheckedChanged
        lbljmlgreentea.Visible = True
        txtjmlgreentea.Visible = True
    End Sub
    ' tombol kembali
    'Private Sub Kembali_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Me.Visible = False
    '    Form1.Visible = True
    '    DaftarMenu.Visible = False
    '    LoginForm1.Visible = False
    'End Sub




    Private Sub txtBayar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBayar.TextChanged
        kembalian = txtBayar.Text - harga
        txtKembali.Text = kembalian
    End Sub

    Private Sub txtJumlah_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtJumlah.TextChanged
        harga += txtJumlah.Text * 13000
        lblHarga.Text = harga

    End Sub

    Private Sub txtjmlVanila_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtjmlVanila.TextChanged
        harga += txtjmlVanila.Text * 14000
        lblHarga.Text = harga
    End Sub

    Private Sub txtjmlhazelnut_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtjmlhazelnut.TextChanged
        harga += txtJumlah.Text * 14000
        lblHarga.Text = harga
    End Sub

    Private Sub txtjmlmilo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtjmlmilo.TextChanged
        harga += txtJumlah.Text * 13000
        lblHarga.Text = harga
    End Sub

    Private Sub txtjmlbublegum_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtjmlbublegum.TextChanged
        harga += txtJumlah.Text * 15000
        lblHarga.Text = harga
    End Sub

    Private Sub txtjmlcapucino_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtjmlcapucino.TextChanged
        harga += txtJumlah.Text * 14000
        lblHarga.Text = harga
    End Sub

    Private Sub txtjmlcaramel_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtjmlcaramel.TextChanged
        harga += txtJumlah.Text * 16000
        lblHarga.Text = harga
    End Sub

    Private Sub txtjmlgreentea_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtjmlgreentea.TextChanged
        harga += txtJumlah.Text * 16000
        lblHarga.Text = harga
    End Sub


    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        lblHarga.Text = 0
        txtBayar.Text = 0
        txtKembali.Text = 0
        lbljumlah.Visible = False
        txtJumlah.Visible = False
        lbljmlVanila.Visible = False
        txtjmlVanila.Visible = False
        lbljmlgreentea.Visible = False
        txtjmlgreentea.Visible = False
        lbljmlcaramel.Visible = False
        txtjmlcaramel.Visible = False
        lbljmlcapucino.Visible = False
        txtjmlcapucino.Visible = False
        lbljmlbublegum.Visible = False
        txtjmlbublegum.Visible = False
        lbljmlbublegum.Visible = False
        txtjmlbublegum.Visible = False
        lbljmlmilo.Visible = False
        txtjmlmilo.Visible = False
        lbljmlhazelnut.Visible = False
        txtjmlhazelnut.Visible = False

        'set jumlah = 0
        txtJumlah.Text = 0
        txtjmlVanila.Text = 0
        txtjmlgreentea.Text = 0
        txtjmlcaramel.Text = 0
        txtjmlcapucino.Text = 0
        txtjmlbublegum.Text = 0
        txtjmlbublegum.Text = 0
        txtjmlmilo.Text = 0
        txtjmlhazelnut.Text = 0
    End Sub

    Private Sub GroupBox5_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox5.Enter

        If radioOreo.Checked Then
            harga += 3000
            lblHarga.Text = harga
        ElseIf radioPearl.Checked Then
            harga += 3000
            lblHarga.Text = harga
        Else
            harga += 3000
            lblHarga.Text = harga
        End If

    End Sub


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form1.Visible = True
        Me.Visible = False
    End Sub

    'Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    DaftarMenu.Visible = True
    '    Me.Visible = False
    'End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Member.Visible = True
        Me.Visible = False
    End Sub

    Private Sub Pesan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtKembali.Text = 0
    End Sub

    Private Sub Hitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cetak.Click
        If txtnama.Text = "" Then
            MsgBox("Nama tidak boleh kosong ", vbOKOnly, "Peringatan !")
        Else
            MsgBox("Order atas nama " + txtnama.Text + vbCrLf + vbCrLf + "Cetak Order ?", vbOKOnly, "Print")
        End If

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnama.TextChanged
       

    End Sub

    Private Sub TransaksiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransaksiToolStripMenuItem.Click
        Me.Visible = True

    End Sub

    Private Sub MemberToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MemberToolStripMenuItem.Click
        Me.Visible = False
        Member.Visible = True
    End Sub
End Class