Public Class LoginForm1

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

   
    Private Sub OK_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        If txtUsername.Text = "" Or PasswordTextBox.Text = "" Then
            MsgBox("Username dan Password tidak boleh kosong", vbOKOnly, "Peringatan !")

        Else

            Me.Visible = False
            Form1.Visible = True
            Form1.lblUser.Text = txtUsername.Text

        End If

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Cancel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
