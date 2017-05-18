Imports MySql.Data.MySqlClient
Public Class Akun
    Sub tampilAkun()
        Call bukaDB()
        DA = New MySqlDataAdapter("SELECT id 'id', jenis_akun 'jenis_akun', username 'username' from akun", Conn)
        DS = New DataSet
        DA.Fill(DS, "akun")
        DataGridView1.DataSource = DS.Tables("akun")
        DataGridView1.ReadOnly = True
    End Sub

    Sub tampilCombo()
        Call bukaDB()
        CMD = New MySqlCommand("SELECT id from akun", Conn)
        RD = CMD.ExecuteReader
        ComboBox2.Items.Clear()
        Do While RD.Read
            ComboBox2.Items.Add(RD.Item(0))
        Loop
        CMD.Dispose()
        RD.Close()
        Conn.Close()
    End Sub

    Private Sub Akun_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        KaryawanToolStripMenuItem.Text = LoginForm1.box.Text
        Call bukaDB()
        Call tampilAkun()
        Call tampilCombo()
    End Sub

    Sub clearAkun()
        TextBoxId.Text = ""
        ComboBox1.Text = ""
        TextBoxUsername.Text = ""
        TextBoxPassword.Text = ""
        TextBoxId.Focus()
        TextBoxId.Enabled = True
    End Sub

    Private Sub ButtonTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonTambah.Click
        Dim jenis_akun As String
        If ComboBox1.Text = "admin" Then
            jenis_akun = "admin"
        Else
            jenis_akun = "karyawan"
        End If
        If ComboBox1.Text = "karyawan" Then
            jenis_akun = "karyawan"
        Else
            jenis_akun = "Admin"
        End If

        Try
            Call bukaDB()
            CMD = New MySqlCommand("SELECT id from akun where id = '" & TextBoxId.Text & "'", Conn)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                MsgBox("Maaf, Data dengan ID tersebut sudah ada", MsgBoxStyle.Exclamation, "Peringatan")
            Else
                Call bukaDB()
                simpan = "INSERT INTO akun (id, jenis_akun, username, password) VALUES (?,?,?,?)"
                CMD = Conn.CreateCommand
                With CMD
                    .CommandText = simpan
                    .Connection = Conn
                    .Parameters.Add("p1", MySqlDbType.Int32, 5).Value = TextBoxId.Text
                    .Parameters.Add("p2", MySqlDbType.Enum, 0, "jenis_akun").Value = jenis_akun
                    .Parameters.Add("p3", MySqlDbType.VarChar, 15).Value = TextBoxUsername.Text
                    .Parameters.Add("p4", MySqlDbType.VarChar, 15).Value = TextBoxPassword.Text
                    .ExecuteNonQuery()
                End With
                Call tampilAkun()
                Call clearAkun()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Terjadi Kesalahan")
        End Try
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Call bukaDB()
        CMD = New MySqlCommand("SELECT * FROM akun where id = '" & ComboBox2.Text & "'", Conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            TextBoxId.Text = RD.Item(0)
            ComboBox1.Text = RD.Item(1)
            TextBoxUsername.Text = RD.Item(2)
            TextBoxPassword.Text = RD.Item(3)
            TextBoxId.Enabled = False
            ComboBox2.Focus()
            TextBoxUsername.Focus()
            TextBoxPassword.Focus()
        End If
    End Sub

    Private Sub ButtonHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHapus.Click
        Try
            Call bukaDB()
            hapus = "DELETE FROM akun WHERE id = @p1"
            CMD = Conn.CreateCommand
            With CMD
                .CommandText = hapus
                .Connection = Conn
                .Parameters.Add("p1", MySqlDbType.Int32, 5).Value = TextBoxId.Text
                .ExecuteNonQuery()
            End With
            Call clearAkun()
            Call tampilAkun()
            Call tampilCombo()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Terjadi kesalahan")
        End Try
    End Sub


    Private Sub ButtonEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEdit.Click
        Dim jenis_akun As String
        If ComboBox1.Text = "admin" Then
            jenis_akun = "admin"
        Else
            jenis_akun = "karyawan"
        End If
        If ComboBox1.Text = "karyawan" Then
            jenis_akun = "karyawan"
        Else
            jenis_akun = "admin"
        End If

        Try
            Call bukaDB()
            ubah = "UPDATE akun SET jenis_akun=@p2, username=@p3, password=@p4  WHERE id=@p1"
            CMD = Conn.CreateCommand
            With CMD
                .CommandText = ubah
                .Connection = Conn
                .Parameters.Add("p1", MySqlDbType.Int32, 5).Value = TextBoxId.Text
                .Parameters.Add("p2", MySqlDbType.Enum, 0, "jenis_akun").Value = jenis_akun
                .Parameters.Add("p3", MySqlDbType.VarChar, 15).Value = TextBoxUsername.Text
                .Parameters.Add("p4", MySqlDbType.VarChar, 15).Value = TextBoxPassword.Text
                .ExecuteNonQuery()
            End With
            Call clearAkun()
            Call tampilAkun()
            Call tampilCombo()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Terjadi kesalahan")
        End Try
    End Sub

   

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call clearAkun()
    End Sub


    Private Sub BerandaKaryawan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        KaryawanToolStripMenuItem.Text = LoginForm1.box.Text

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

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Visible = False
        LoginForm1.Visible = True
    End Sub
End Class