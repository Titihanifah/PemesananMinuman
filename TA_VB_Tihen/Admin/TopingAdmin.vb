Imports MySql.Data.MySqlClient
Public Class TopingAdmin

    Sub tampilToping()
        Call bukaDB() ' panggil koneksi kedatabase melalui modul
        DA = New MySqlDataAdapter("SELECT id_toping 'ID', nama 'Toping' , harga 'Harga' , stock_toping 'Stok' from toping", Conn)
        DS = New DataSet
        DA.Fill(DS, "toping")
        DataToping.DataSource = DS.Tables("toping")
        DataToping.ReadOnly = True

    End Sub
    Private Sub toping(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        KaryawanToolStripMenuItem.Text = LoginForm1.box.Text
        Call bukaDB()
        Call tampilToping()
        Call tampilCombo()
    End Sub

    Sub clearToping()
        txtIdT.Text = ""
        txtToping.Text = ""
        txtHargaT.Text = ""
        stokT.Text = ""
        txtIdT.Focus()
        txtIdT.Enabled = True

    End Sub


    Private Sub Tambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click

        Try
            Call bukaDB()
            CMD = New MySqlCommand("SELECT id_toping from toping WHERE id_toping = '" & txtIdT.Text & "'", Conn)
            RD = CMD.ExecuteReader
            RD.Read()

            If RD.HasRows Then
                MsgBox("Maaf, Data dengan ID tersebut sudah ada", MsgBoxStyle.Exclamation, "Peringatan")
            Else
                Call bukaDB()

                simpan = "INSERT INTO toping (id_toping, nama, harga, stock_toping) VALUES (?,?,?,?)"
                CMD = Conn.CreateCommand
                With CMD
                    .CommandText = simpan
                    .Connection = Conn
                    .Parameters.Add("p1", MySqlDbType.Int32, 5).Value = txtIdT.Text
                    .Parameters.Add("p2", MySqlDbType.VarChar, 20).Value = txtToping.Text
                    .Parameters.Add("p3", MySqlDbType.Int32, 6).Value = txtHargaT.Text
                    .Parameters.Add("p4", MySqlDbType.Int32, 5).Value = stokT.Text

                    .ExecuteNonQuery()
                End With
                Call tampilToping()
                Call clearToping()


            End If

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Kesalahan")
        End Try
    End Sub

    Sub tampilCombo()
        Call bukaDB()
        CMD = New MySqlCommand("SELECT id_toping from toping", Conn)
        RD = CMD.ExecuteReader
        ComboBox1.Items.Clear()
        Do While RD.Read
            ComboBox1.Items.Add(RD.Item(0))

        Loop
        CMD.Dispose()
        RD.Close()
        Conn.Close()
    End Sub



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Try
            Call bukaDB()
            hapus = "DELETE FROM toping WHERE id_toping=@p1"
            CMD = Conn.CreateCommand
            With CMD
                .CommandText = hapus
                .Connection = Conn
                .Parameters.Add("p1", MySqlDbType.Int32, 5).Value = txtIdT.Text
                .Parameters.Add("p2", MySqlDbType.VarChar, 20).Value = txtToping.Text
                .Parameters.Add("p3", MySqlDbType.Int32, 6).Value = txtHargaT.Text
                .Parameters.Add("p4", MySqlDbType.Int32, 5).Value = stokT.Text

                .ExecuteNonQuery()
            End With
            Call clearToping()
            Call tampilToping()
            Call tampilCombo()

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Terjadi Kesalahan")
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Try
            Call bukaDB()

            ubah = "UPDATE toping SET nama = @p2, harga = @p3, stock_toping = @p4 WHERE id_toping = @p1"
            CMD = Conn.CreateCommand
            With CMD
                .CommandText = ubah
                .Connection = Conn
                .Parameters.Add("p1", MySqlDbType.Int32, 5).Value = txtIdT.Text
                .Parameters.Add("p2", MySqlDbType.VarChar, 20).Value = txtToping.Text
                .Parameters.Add("p3", MySqlDbType.Int32, 6).Value = txtHargaT.Text
                .Parameters.Add("p4", MySqlDbType.Int32, 5).Value = stokT.Text
                .ExecuteNonQuery()
            End With
            Call clearToping()
            Call tampilToping()
            Call tampilCombo()


        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Kesalahan")
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Call clearToping()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Call bukaDB()
        CMD = New MySqlCommand("SELECT * FROM toping WHERE id_toping ='" & ComboBox1.Text & "'", Conn)
        RD = CMD.ExecuteReader
        RD.Read()

        If RD.HasRows Then
            txtIdT.Text = RD.Item(0)
            txtToping.Text = RD.Item(1)
            txtHargaT.Text = RD.Item(2)
            stokT.Text = RD.Item(3)
            txtIdT.Enabled = False
            txtToping.Focus()
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



    Private Sub MinumanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MinumanToolStripMenuItem.Click
        Me.Visible = False
        Minuman.Visible = True
    End Sub



    Private Sub BerandaKaryawan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        KaryawanToolStripMenuItem.Text = LoginForm1.box.Text

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Visible = False
        LoginForm1.Visible = True
    End Sub
End Class