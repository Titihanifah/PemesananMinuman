﻿Public Class Member

    
   

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        ' rtboutput.Text = lblNama.Text + " : " + txtnama.Text + vbCrLf + lblTempat.Text + " : " + _
        ' txttempat.Text(+vbCrLf + lblEmail.Text + " : " + txtemail.Text + vbCrLf + _
        ' lblNotelp.Text + " : " + txtNotelp.Text + vbCrLf + lblAlamat.Text + " : " + alamat.Text)

    End Sub

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click

        If txtnama.Text = "" Or txttempat.Text = "" Or txtemail.Text = "" Or txtNotelp.Text = "" Or alamat.Text = "" Then
            MsgBox("Inputan tidak boleh kosong", vbOKOnly, "Peringatan !")
        Else
            rtbHasil.Text += lblNama.Text + " : " + txtnama.Text + vbCrLf + lblTempat.Text + " : " + _
            txttempat.Text + vbCrLf + lblEmail.Text + " : " + txtemail.Text + vbCrLf + _
            lblNotelp.Text + " : " + txtNotelp.Text + vbCrLf + lblAlamat.Text + " : " + alamat.Text + vbCrLf + "=====================" + vbCrLf

            MsgBox(txtnama.Text + vbCrLf + txttempat.Text + vbCrLf + txtemail.Text + vbCrLf + txtNotelp.Text + vbCrLf + alamat.Text + vbCrLf + "Apakah data yang Anda masukkan benar ?", vbOKOnly, "Attention !")
            txtnama.Text = ""
            txttempat.Text = ""
            txtemail.Text = ""
            txtNotelp.Text = ""
            alamat.Text = ""


        End If



    End Sub

    
    Private Sub Menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DaftarMenu.Click
        Form1.Visible = True
        Me.Visible = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Pesan.Visible = True
        Me.Visible = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DaftarMenu.Visible = True
        Me.Visible = False
    End Sub

    
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

    End Sub
End Class