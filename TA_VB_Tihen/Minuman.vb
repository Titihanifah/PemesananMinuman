Imports MySql.Data.MySqlClient

Public Class Minuman
    Sub tampilMenuAdmin()
        Call bukaDB()
        DA = New MySqlDataAdapter("SELECT id 'id', nama 'nama', harga 'harga', stock 'stock' from minuman", Conn)
        DS = New DataSet
        DA.Fill(DS, "minuman")
        DataGridView1.DataSource = DS.Tables("minuman")
        DataGridView1.ReadOnly = True
    End Sub

    Sub tampilCombo()
        Call bukaDB()
        CMD = New MySqlCommand("SELECT id From minuman", Conn)
        RD = CMD.ExecuteReader
        ComboBox1.Items.Clear()
        Do While RD.Read
            ComboBox1.Items.Add(RD.Item(0))
        Loop
        CMD.Dispose()
        RD.Close()
        Conn.Close()
    End Sub
    Private Sub Daftar_Menu_Admin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        KaryawanToolStripMenuItem.Text = LoginForm1.box.Text
        Call bukaDB()
        Call tampilMenuAdmin()
        Call tampilCombo()
    End Sub

    Sub clearMenuAdmin()
        TextBoxId.Text = ""
        TextBoxNama.Text = ""
        TextBoxHarga.Text = ""
        TextBoxStock.Text = ""
        TextBoxId.Focus()
    End Sub

    Private Sub ButtonTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonTambah.Click
        Try
            Call bukaDB()
            CMD = New MySqlCommand("SELECT id from minuman WHERE id = '" & TextBoxId.Text & "'", Conn)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                MsgBox("Maaf, Data dengan ID tersebut sudah ada", MsgBoxStyle.Exclamation, "Peringatan")
            Else
                Call bukaDB()
                simpan = "INSERT INTO minuman (id,nama,harga,stock) VALUES (?,?,?,?)"
                CMD = Conn.CreateCommand
                With CMD
                    .CommandText = simpan
                    .Connection = Conn
                    .Parameters.Add("p1", MySqlDbType.Int32, 5).Value = TextBoxId.Text
                    .Parameters.Add("p2", MySqlDbType.VarChar, 20).Value = TextBoxNama.Text
                    .Parameters.Add("p3", MySqlDbType.Int32, 6).Value = TextBoxHarga.Text
                    .Parameters.Add("p4", MySqlDbType.Int32, 5).Value = TextBoxStock.Text

                    .ExecuteNonQuery()
                End With
                Call tampilMenuAdmin()
                Call clearMenuAdmin()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Terjadi kesalahan")
        End Try
    End Sub

    Private Sub ButtonHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHapus.Click
        Try
            Call bukaDB()
            hapus = "DELETE FROM minuman WHERE id = @p1"
            CMD = Conn.CreateCommand
            With CMD
                .CommandText = hapus
                .Connection = Conn
                .Parameters.Add("p1", MySqlDbType.Int32, 5).Value = TextBoxId.Text
                .ExecuteNonQuery()
            End With
            Call tampilMenuAdmin()
            Call clearMenuAdmin()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Terjadi kesalahan")
        End Try
    End Sub

    Private Sub ButtonHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Visible = False
        Form1.Visible = True
    End Sub

    Private Sub ButtonAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Visible = False
        Akun.Visible = True
    End Sub

    Private Sub ButtonEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEdit.Click
        Try
            Call bukaDB()
            ubah = "UPDATE minuman SET nama=@p2, harga=@p3, stock=@p4  WHERE id=@p1"
            'ubah = "UPDATE minuman SET harga=@p3 WHERE id=@p1"
            'ubah = "UPDATE minuman SET stock=@p4 WHERE id=@p1"
            CMD = Conn.CreateCommand
            With CMD
                .CommandText = ubah
                .Connection = Conn
                .Parameters.Add("p1", MySqlDbType.Int32, 5).Value = TextBoxId.Text
                .Parameters.Add("p2", MySqlDbType.VarChar, 20).Value = TextBoxNama.Text
                .Parameters.Add("p3", MySqlDbType.Int32, 6).Value = TextBoxHarga.Text
                .Parameters.Add("p4", MySqlDbType.Int32, 5).Value = TextBoxStock.Text

                .ExecuteNonQuery()
            End With
            Call clearMenuAdmin()
            Call tampilMenuAdmin()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Terjadi kesalahan")
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Call bukaDB()
        CMD = New MySqlCommand("SELECT * FROM minuman WHERE id = '" & ComboBox1.Text & "'", Conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            TextBoxId.Text = RD.Item(0)
            TextBoxNama.Text = RD.Item(1)
            TextBoxHarga.Text = RD.Item(2)
            TextBoxStock.Text = RD.Item(3)
            TextBoxId.Enabled = False
            TextBoxNama.Focus()
            TextBoxHarga.Focus()
            TextBoxStock.Focus()

        End If
    End Sub

    Private Sub TransaksiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransaksiToolStripMenuItem.Click
        Transaksi.Visible = True
        Me.Visible = False
    End Sub

    Private Sub MemberToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MemberToolStripMenuItem.Click
        Me.Visible = False
        Member.Visible = True
    End Sub

    Private Sub TopingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TopingToolStripMenuItem.Click
        Me.Visible = False
        Toping.Visible = True
    End Sub

    Private Sub BerandaKaryawan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        KaryawanToolStripMenuItem.Text = LoginForm1.box.Text

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Visible = False
        LoginForm1.Visible = True
    End Sub
End Class