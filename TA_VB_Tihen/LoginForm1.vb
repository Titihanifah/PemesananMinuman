Imports MySql.Data.MySqlClient
Public Class LoginForm1

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.
    'Public waktu As String
    'Public pelanggan As String
    'Public meja As String
    Public id As String

    Sub checkLogin()

        Call bukaDB()

        CMD = New MySqlCommand("SELECT * FROM akun WHERE username = '" & txtUsername.Text & "'AND password = '" & PasswordTextBox.Text & "'", Conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            If RD(1) = "admin" Then
                box.Text = RD.Item(2)
                MsgBox("Login Berhasil", MsgBoxStyle.Information)
                Me.Visible = False
                ' berandaAdmin.Visible = True
            ElseIf RD(1) = "karyawan" Then
                box.Text = RD.Item(2)
                MsgBox("Login Berhasil", MsgBoxStyle.Information)
                Me.Visible = False
                BerandaKaryawan.Visible = True

            End If

        ElseIf RD.HasRows = False Then
            If txtUsername.Text = "" Or PasswordTextBox.Text = "" Then
                txtUsername.Select()
                'labelSalah.Visible = True
                MsgBox("Username atau Password belum diisi", vbOKOnly, "Attention !")
            End If
        Else
            txtUsername.Select()
            'labelSalah.Visible = True
            MsgBox("Username atau Password Salah", vbOKOnly, "Attention !")
        End If
    End Sub

    Private Sub OK_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        checkLogin()
    End Sub

 

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub


    'Private Sub OK_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

    '    If txtUsername.Text = "" Or PasswordTextBox.Text = "" Then
    '        MsgBox("Username dan Password tidak boleh kosong", vbOKOnly, "Peringatan !")

    '    Else

    '        Me.Visible = False
    '        Form1.Visible = True
    '        Form1.lblUser.Text = txtUsername.Text

    '    End If

    'End Sub


End Class
