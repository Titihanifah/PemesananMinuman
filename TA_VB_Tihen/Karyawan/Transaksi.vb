Imports MySql.Data.MySqlClient
Public Class Transaksi

    Sub tampiltransaksi()
        Call bukaDB()
        DA = New MySqlDataAdapter("SELECT id_transaksi 'ID', tgl_transaksi 'Tgl Transaksi', jumlah 'Jumlah', total 'Total' from transaksi", Conn)
        DA = New MySqlDataAdapter("select  transaksi.id_transaksi, transaksi.nama, transaksi.tgl_transaksi,  detail_transaksi.id_minuman, detail_transaksi.id_toping, detail_transaksi.jumlah, detail_transaksi.total FROM transaksi, detail_transaksi WHERE transaksi.id_transaksi = detail_transaksi.id_transaksi", Conn)
        DS = New DataSet
        DA.Fill(DS, "transaksi, detail_transaksi")
        DataGridView1.DataSource = DS.Tables("transaksi, detail_transaksi")
        DataGridView1.ReadOnly = True
    End Sub
    Sub clearTransaksi()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        jumlahToping.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        DataGridView1.DataSource = Nothing
        DataGridView1.Refresh()
        TextBox1.Focus()
    End Sub

    Sub tampilToping()
        Call bukaDB()
        CMD = New MySqlCommand("SELECT nama from toping", Conn)
        RD = CMD.ExecuteReader
        ComboBox2.Items.Clear()
        Do While RD.Read
            ComboBox2.Items.Add(RD.Item(0))
        Loop
        CMD.Dispose()
        RD.Close()
        Conn.Close()
    End Sub
    Sub tampilMinuman()
        Call bukaDB()
        CMD = New MySqlCommand("SELECT nama from minuman", Conn)
        RD = CMD.ExecuteReader
        ComboBox1.Items.Clear()
        Do While RD.Read
            ComboBox1.Items.Add(RD.Item(0))
        Loop
        CMD.Dispose()
        RD.Close()
        Conn.Close()
    End Sub




    'Private Sub ButtonTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonTambah.Click


    '    Try
    '        Call bukaDB()
    '        CMD = New MySqlCommand("SELECT id from transaksi where id = '" & TextBoxId.Text & "'", Conn)
    '        RD = CMD.ExecuteReader
    '        RD.Read()
    '        If RD.HasRows Then
    '            MsgBox("Maaf, Data dengan ID tersebut sudah ada", MsgBoxStyle.Exclamation, "Peringatan")
    '        Else
    '            Call bukaDB()
    '            simpan = "INSERT INTO transaksi (id, jenis_transaksi, username, password) VALUES (?,?,?,?)"
    '            CMD = Conn.CreateCommand
    '            With CMD
    '                .CommandText = simpan
    '                .Connection = Conn
    '                .Parameters.Add("p1", MySqlDbType.Int32, 5).Value = TextBoxId.Text
    '                .Parameters.Add("p2", MySqlDbType.Enum, 0, "jenis_transaksi").Value = jenis_transaksi
    '                .Parameters.Add("p3", MySqlDbType.VarChar, 15).Value = TextBoxUsername.Text
    '                .Parameters.Add("p4", MySqlDbType.VarChar, 15).Value = TextBoxPassword.Text
    '                .ExecuteNonQuery()
    '            End With
    '            Call tampiltransaksi()
    '            Call cleartransaksi()
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.ToString, MsgBoxStyle.Critical, "Terjadi Kesalahan")
    '    End Try
    'End Sub

    'Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
    '    Call bukaDB()
    '    CMD = New MySqlCommand("SELECT * FROM transaksi where id = '" & ComboBox2.Text & "'", Conn)
    '    RD = CMD.ExecuteReader
    '    RD.Read()
    '    If RD.HasRows Then
    '        TextBoxId.Text = RD.Item(0)
    '        ComboBox1.Text = RD.Item(1)
    '        TextBoxUsername.Text = RD.Item(2)
    '        TextBoxPassword.Text = RD.Item(3)
    '        TextBoxId.Enabled = False
    '        ComboBox2.Focus()
    '        TextBoxUsername.Focus()
    '        TextBoxPassword.Focus()
    '    End If
    'End Sub

    'Private Sub ButtonHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHapus.Click
    '    Try
    '        Call bukaDB()
    '        hapus = "DELETE FROM transaksi WHERE id = @p1"
    '        CMD = Conn.CreateCommand
    '        With CMD
    '            .CommandText = hapus
    '            .Connection = Conn
    '            .Parameters.Add("p1", MySqlDbType.Int32, 5).Value = TextBoxId.Text
    '            .ExecuteNonQuery()
    '        End With
    '        Call cleartransaksi()
    '        Call tampiltransaksi()
    '        Call tampilCombo()
    '    Catch ex As Exception
    '        MsgBox(ex.ToString, MsgBoxStyle.Critical, "Terjadi kesalahan")
    '    End Try
    'End Sub


    'Private Sub ButtonEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEdit.Click
    '    Dim jenis_transaksi As String
    '    If ComboBox1.Text = "admin" Then
    '        jenis_transaksi = "admin"
    '    Else
    '        jenis_transaksi = "karyawan"
    '    End If
    '    If ComboBox1.Text = "karyawan" Then
    '        jenis_transaksi = "karyawan"
    '    Else
    '        jenis_transaksi = "admin"
    '    End If

    '    Try
    '        Call bukaDB()
    '        ubah = "UPDATE transaksi SET jenis_transaksi=@p2, username=@p3, password=@p4  WHERE id=@p1"
    '        CMD = Conn.CreateCommand
    '        With CMD
    '            .CommandText = ubah
    '            .Connection = Conn
    '            .Parameters.Add("p1", MySqlDbType.Int32, 5).Value = TextBoxId.Text
    '            .Parameters.Add("p2", MySqlDbType.Enum, 0, "jenis_transaksi").Value = jenis_transaksi
    '            .Parameters.Add("p3", MySqlDbType.VarChar, 15).Value = TextBoxUsername.Text
    '            .Parameters.Add("p4", MySqlDbType.VarChar, 15).Value = TextBoxPassword.Text
    '            .ExecuteNonQuery()
    '        End With
    '        'Call cleartransaksi()
    '        Call tampiltransaksi()
    '        ' Call tampilCombo()
    '    Catch ex As Exception
    '        MsgBox(ex.ToString, MsgBoxStyle.Critical, "Terjadi kesalahan")
    '    End Try
    'End Sub




    Private Sub Transaksi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TransaksiUsername.Text = BerandaKaryawan.KaryawanToolStripMenuItem.Text
        'KaryawanToolStripMenuItem.Text = LoginForm1.box.Text
        Call bukaDB()
        Call tampiltransaksi()
        Call tampilMinuman()
        Call tampilToping()
        Call clearTransaksi()
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

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class
