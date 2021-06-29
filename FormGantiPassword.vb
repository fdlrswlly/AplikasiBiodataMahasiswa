Imports System.Data.Odbc
Public Class FormGantiPassword
    Sub Kosong()
        Txt_passLama.Text = ""
        Txt_passBaru.Text = ""
        Txt_konfirmasi.Text = ""
        Txt_passLama.Enabled = True
        Txt_passBaru.Enabled = False
        Txt_konfirmasi.Enabled = False
    End Sub
    Private Sub FormGantiPassword_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call Kosong()
    End Sub

    Private Sub Txt_batal_Click(sender As System.Object, e As System.EventArgs) Handles Txt_batal.Click
        Me.Close()
    End Sub

    Private Sub Txt_passLama_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_passLama.KeyPress
        If e.KeyChar = Chr(13) Then
            Call KoneksiDb()
            CMD = New OdbcCommand("SELECT * FROM dt_user WHERE PassUser= '" & Txt_passLama.Text & "'", DbKoneksi)
            DR = CMD.ExecuteReader
            DR.Read()
            If DR.HasRows Then
                Txt_passBaru.Enabled = True
                Txt_konfirmasi.Enabled = True
                Txt_passBaru.Focus()
            Else
                MsgBox("Password Lama Salah", vbCritical, "ERROR!!")
                Txt_passLama.Text = ""
            End If
        End If
    End Sub

    Private Sub Txt_ubah_Click(sender As System.Object, e As System.EventArgs) Handles Txt_ubah.Click
        If Txt_passBaru.Text = "" Or Txt_konfirmasi.Text = "" Then
            MsgBox("Password Baru Harus diisi", vbExclamation, "Kosong")
        Else
            If Txt_passBaru.Text <> Txt_konfirmasi.Text Then
                MsgBox("Password Baru dan Konfirmasi Tidak sesuai", vbCritical, "ERROR!!")
                Txt_passBaru.Text = ""
                Txt_konfirmasi.Text = ""
            Else
                Call KoneksiDb()
                Dim EditPass As String = "UPDATE dt_user set PassUser= '" & Txt_konfirmasi.Text & "' where PassUser = '" & Txt_passLama.Text & "'"
                CMD = New OdbcCommand(EditPass, DbKoneksi)
                CMD.ExecuteNonQuery()
                MsgBox("Password Berhasil Diubah", vbInformation, "Informasi")
                Call Kosong()
                Close()
            End If
        End If
    End Sub
End Class