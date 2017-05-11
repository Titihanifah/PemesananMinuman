Imports MySql.Data.MySqlClient
Public Class Karyawan

    Sub tampilKaryawan()
        Call bukaDB()
        DA = New MySqlDataAdapter("SELECT id 'id', nama 'nama', tgl_lahir 'tgl_lahir', alamat 'alamat', telepon 'telepon' from karyawan", Conn)
        DS = New DataSet
        DA.Fill(DS, "karyawan")
        DataGridView1.DataSource = DS.Tables("karyawan")
        DataGridView1.ReadOnly = True
    End Sub

    Sub clearKaryawan()
        TextBoxId.Text = ""
        TextBoxNama.Text = ""
        DateTimePicker1.Text = ""
        TextBoxAlamat.Text = ""
        TextBoxTelepon.Text = ""
        TextBoxId.Focus()
        ComboBox1.Text = ""
    End Sub

    Sub tampilCombo()
        Call bukaDB()
        CMD = New MySqlCommand("SELECT id from karyawan", Conn)
        RD = CMD.ExecuteReader
        ComboBox1.Items.Clear()
        Do While RD.Read
            ComboBox1.Items.Add(RD.Item(0))
        Loop
        CMD.Dispose()
        RD.Close()
        Conn.Close()
    End Sub

    Private Sub karyawan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        KaryawanToolStripMenuItem.Text = LoginForm1.box.Text
        Call bukaDB()
        Call tampilKaryawan()
        Call tampilCombo()
    End Sub

    Private Sub ButtonSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSimpan.Click
        Dim hari, bulan, tahun, tgl_lahir As String
        hari = CStr(DateTimePicker1.Value.Day)
        bulan = CStr(DateTimePicker1.Value.Month)
        tahun = CStr(DateTimePicker1.Value.Year)
        tgl_lahir = tahun + "-" + bulan + "-" + hari
        Try
            Call bukaDB()
            CMD = New MySqlCommand("SELECT id from karyawan WHERE id = '" & TextBoxId.Text & "'", Conn)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                MsgBox("Maaf, Data dengan ID tersebut sudah ada", MsgBoxStyle.Exclamation, "Peringatan")
            Else
                Call bukaDB()
                simpan = "INSERT INTO karyawan (id,nama,tgl_lahir,alamat,telepon) VALUES (?,?,?,?,?)"
                CMD = Conn.CreateCommand
                With CMD
                    .CommandText = simpan
                    .Connection = Conn
                    .Parameters.Add("p1", MySqlDbType.Int32, 5).Value = TextBoxId.Text
                    .Parameters.Add("p2", MySqlDbType.VarChar, 20).Value = TextBoxNama.Text
                    .Parameters.Add("p3", MySqlDbType.Date, 0, "tgl_lahir").Value = tgl_lahir
                    .Parameters.Add("p4", MySqlDbType.VarChar, 50).Value = TextBoxAlamat.Text
                    .Parameters.Add("p5", MySqlDbType.Int32, 13).Value = TextBoxTelepon.Text

                    .ExecuteNonQuery()
                End With
                Call tampilKaryawan()
                Call clearKaryawan()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Terjadi kesalahan")
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Call bukaDB()
        CMD = New MySqlCommand("SELECT * FROM karyawan WHERE id = '" & ComboBox1.Text & "'", Conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            TextBoxId.Text = RD.Item(0)
            TextBoxNama.Text = RD.Item(1)
            DateTimePicker1.Text = RD.Item(2)
            TextBoxAlamat.Text = RD.Item(3)
            TextBoxTelepon.Text = RD.Item(4)
            TextBoxId.Enabled = False
            TextBoxNama.Focus()
            DateTimePicker1.Focus()
            TextBoxAlamat.Focus()
            TextBoxTelepon.Focus()
        End If
    End Sub

    Private Sub ButtonHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHapus.Click
        Try
            Call bukaDB()
            hapus = "DELETE FROM karyawan WHERE id = @p1"
            CMD = Conn.CreateCommand
            With CMD
                .CommandText = hapus
                .Connection = Conn
                .Parameters.Add("p1", MySqlDbType.Int32, 5).Value = TextBoxId.Text
                .ExecuteNonQuery()
            End With
            Call clearKaryawan()
            Call tampilKaryawan()
            Call tampilCombo()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Terjadi Kesalahan")
        End Try
    End Sub

    Private Sub ButtonEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEdit.Click
        Dim hari, bulan, tahun, tgl_lahir As String
        hari = CStr(DateTimePicker1.Value.Day)
        bulan = CStr(DateTimePicker1.Value.Month)
        tahun = CStr(DateTimePicker1.Value.Year)
        tgl_lahir = tahun + "-" + bulan + "-" + hari

        Try
            Call bukaDB()
            ubah = "UPDATE karyawan SET nama=@p2, tgl_lahir=@p3, alamat=@p4, telepon=@p5 WHERE id=@p1"
            CMD = Conn.CreateCommand
            With CMD
                .CommandText = ubah
                .Connection = Conn
                .Parameters.Add("p1", MySqlDbType.Int32, 5).Value = TextBoxId.Text
                .Parameters.Add("p2", MySqlDbType.VarChar, 20).Value = TextBoxNama.Text
                .Parameters.Add("p3", MySqlDbType.Date, 0, "tgl_lahir").Value = tgl_lahir
                .Parameters.Add("p4", MySqlDbType.VarChar, 50).Value = TextBoxAlamat.Text
                .Parameters.Add("p5", MySqlDbType.Int32, 13).Value = TextBoxTelepon.Text

                .ExecuteNonQuery()
            End With
            Call clearKaryawan()
            Call tampilKaryawan()
            Call tampilCombo()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Terjadi Kesalahan")
        End Try
    End Sub

    Private Sub ButtonBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBatal.Click
        Call clearKaryawan()
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