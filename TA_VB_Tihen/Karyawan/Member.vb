Imports MySql.Data.MySqlClient

Public Class Member

    Sub tampilMember()
        Call bukaDB() ' panggil koneksi kedatabase melalui modul
        DA = New MySqlDataAdapter("SELECT id_customer 'ID', nama 'Nama' , tempat_lahir 'Tempat Lahir' , tgl_lahir 'Tgl Lahir', email 'Email' ,  telepon 'Telepon', alamat 'Alamat', poin 'Poin' FROM customer", Conn)
        DS = New DataSet
        DA.Fill(DS, "customer")
        DataGridView1.DataSource = DS.Tables("customer")
        DataGridView1.ReadOnly = True

    End Sub
    Private Sub customer(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        KaryawanToolStripMenuItem.Text = LoginForm1.box.Text
        Call bukaDB()
        Call tampilMember()
        Call tampilCombo()
    End Sub

    Sub clearMember()
        txtId.Text = ""
        txtNamaLengkap.Text = ""
        txtTempatLahir.Text = ""
        DateTimePicker1.Text = ""
        txtEmailC.Text = ""
        txtTelepon.Text = ""
        txtAlamat.Text = ""
        txtPoin.Text = ""
        txtId.Focus()
        txtId.Enabled = True

    End Sub


    Private Sub Tambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        Dim hari, bulan, tahun, tgllahir As String

        hari = CStr(DateTimePicker1.Value.Day)
        bulan = CStr(DateTimePicker1.Value.Month)
        tahun = CStr(DateTimePicker1.Value.Year)
        tgllahir = tahun + "-" + bulan + "-" + hari

        Try
            Call bukaDB()
            CMD = New MySqlCommand("SELECT id_customer from customer WHERE id_customer = '" & txtId.Text & "'", Conn)
            RD = CMD.ExecuteReader
            RD.Read()

            If RD.HasRows Then
                MsgBox("Maaf, Data dengan ID tersebut sudah ada", MsgBoxStyle.Exclamation, "Peringatan")
            Else
                Call bukaDB()

                simpan = "INSERT INTO customer (id_customer, nama, tempat_lahir, tgl_lahir, email, telepon, alamat, poin) VALUES (?,?,?,?,?,?,?,?)"
                CMD = Conn.CreateCommand
                With CMD
                    .CommandText = simpan
                    .Connection = Conn
                    .Parameters.Add("p1", MySqlDbType.Int32, 5).Value = txtId.Text
                    .Parameters.Add("p2", MySqlDbType.VarChar, 20).Value = txtNamaLengkap.Text
                    .Parameters.Add("p3", MySqlDbType.VarChar, 20).Value = txtTempatLahir.Text
                    .Parameters.Add("p4", MySqlDbType.Date, 0, "tgl_lahir").Value = tgllahir
                    .Parameters.Add("p5", MySqlDbType.VarChar, 25).Value = txtEmailC.Text
                    .Parameters.Add("p6", MySqlDbType.VarChar, 13).Value = txtTelepon.Text
                    .Parameters.Add("p7", MySqlDbType.VarChar, 50).Value = txtAlamat.Text
                    .Parameters.Add("p8", MySqlDbType.Int32, 4).Value = txtPoin.Text
                    .ExecuteNonQuery()
                End With
                Call tampilMember()
                Call clearMember()


            End If

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Kesalahan")
        End Try
    End Sub

    Sub tampilCombo()
        Call bukaDB()
        CMD = New MySqlCommand("SELECT id_customer from customer", Conn)
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
        Dim hari, bulan, tahun, tgllahir As String

        hari = CStr(DateTimePicker1.Value.Day)
        bulan = CStr(DateTimePicker1.Value.Month)
        tahun = CStr(DateTimePicker1.Value.Year)
        tgllahir = tahun + "-" + bulan + "-" + hari


        Try
            Call bukaDB()
            hapus = "DELETE FROM customer WHERE id_customer=@p1"
            CMD = Conn.CreateCommand
            With CMD
                .CommandText = hapus
                .Connection = Conn
                .Parameters.Add("p1", MySqlDbType.Int16, 5).Value = txtId.Text
                .Parameters.Add("p2", MySqlDbType.VarChar, 20).Value = txtNamaLengkap.Text
                .Parameters.Add("p3", MySqlDbType.VarChar, 20).Value = txtTempatLahir.Text
                .Parameters.Add("p4", MySqlDbType.Date, 0, "tgl_lahir").Value = tgllahir
                .Parameters.Add("p5", MySqlDbType.VarChar, 25).Value = txtEmailC.Text
                .Parameters.Add("p6", MySqlDbType.VarChar, 13).Value = txtTelepon.Text
                .Parameters.Add("p7", MySqlDbType.VarChar, 50).Value = txtAlamat.Text
                .Parameters.Add("p8", MySqlDbType.Int16, 4).Value = textbox.Text

                .ExecuteNonQuery()
            End With
            Call clearMember()
            Call tampilMember()
            Call tampilCombo()

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Terjadi Kesalahan")
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim hari, bulan, tahun, tgllahir As String

        hari = CStr(DateTimePicker1.Value.Day)
        bulan = CStr(DateTimePicker1.Value.Month)
        tahun = CStr(DateTimePicker1.Value.Year)
        tgllahir = tahun + "-" + bulan + "-" + hari


        Try
            Call bukaDB()

            ubah = "UPDATE customer SET nama = @p2, tempat_lahir = @p3, tgl_lahir = @p4 , email = @p5, telepon = @p6, alamat = @p7 , poin = @p8  WHERE id_customer = @p1"
            CMD = Conn.CreateCommand
            With CMD
                .CommandText = ubah
                .Connection = Conn
                .Parameters.Add("p1", MySqlDbType.Int32, 5).Value = txtId.Text
                .Parameters.Add("p2", MySqlDbType.VarChar, 20).Value = txtNamaLengkap.Text
                .Parameters.Add("p3", MySqlDbType.VarChar, 20).Value = txtTempatLahir.Text
                .Parameters.Add("p4", MySqlDbType.Date, 0, "tgl_lahir").Value = tgllahir
                .Parameters.Add("p5", MySqlDbType.VarChar, 25).Value = txtEmailC.Text
                .Parameters.Add("p6", MySqlDbType.VarChar, 13).Value = txtTelepon.Text
                .Parameters.Add("p7", MySqlDbType.VarChar, 50).Value = txtAlamat.Text
                .Parameters.Add("p8", MySqlDbType.Int32, 4).Value = txtPoin.Text
                .ExecuteNonQuery()
            End With
            Call clearMember()
            Call tampilMember()
            Call tampilCombo()


        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Kesalahan")
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Call clearMember()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Call bukaDB()
        CMD = New MySqlCommand("SELECT * FROM customer WHERE id_customer ='" & ComboBox1.Text & "'", Conn)
        RD = CMD.ExecuteReader
        RD.Read()

        If RD.HasRows Then
            txtId.Text = RD.Item(0)
            txtNamaLengkap.Text = RD.Item(1)
            txtTempatLahir.Text = RD.Item(2)
            DateTimePicker1.Text = RD.Item(3)
            txtEmailC.Text = RD.Item(4)
            txtTelepon.Text = RD.Item(5)
            txtAlamat.Text = RD.Item(6)
            txtPoin.Text = RD.Item(7)
            txtId.Enabled = False
            txtNamaLengkap.Focus()
        End If
    End Sub
    Private Sub TransaksiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransaksiToolStripMenuItem.Click
        Transaksi.Visible = True
        Me.Visible = False
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

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class