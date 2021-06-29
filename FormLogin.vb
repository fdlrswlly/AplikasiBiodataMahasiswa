Imports System.Data.Odbc

Public Class FormLogin


    Private Sub Btn_login_Click(sender As System.Object, e As System.EventArgs) Handles Btn_login.Click
        Call KoneksiDb()
        If txt_username.Text = "" Then
            MsgBox("Username Harus Diisi", MsgBoxStyle.Exclamation, "Kosong !!")
            txt_username.Focus()
        ElseIf txt_password.Text = "" Then
            MsgBox("Password Harus Diisi", MsgBoxStyle.Exclamation, "Kosong !!")
            txt_password.Focus()
        Else
            CMD = New OdbcCommand("SELECT * FROM dt_user WHERE NmUser='" & txt_username.Text & "'", DbKoneksi)
            DR = CMD.ExecuteReader
            DR.Read()
            If Not DR.HasRows = 0 Then
                CMD = New OdbcCommand("SELECT * FROM dt_user WHERE PassUser='" & txt_password.Text & "'", DbKoneksi)
                DR = CMD.ExecuteReader
                DR.Read()
                If Not DR.HasRows = 0 Then
                    If DR.Item("LevelUser") = "Admin" And DR.Item("NmUser") = txt_username.Text Then
                        With FormMenuUtama
                            Hide()
                            .Show()
                            .DataMasterToolStripMenuItem.Enabled = True
                            .DataMahasiswaToolStripMenuItem.Enabled = True
                            .AbsensiToolStripMenuItem.Enabled = True
                            .JadwalKuliahToolStripMenuItem.Enabled = True
                            .KartuToolStripMenuItem.Enabled = True
                        End With
                    ElseIf DR.Item("LevelUser") = "User" And DR.Item("NmUser") = txt_username.Text Then
                        With FormMenuUtama
                            Hide()
                            .Show()
                            .DataMasterToolStripMenuItem.Enabled = True
                            .DataMahasiswaToolStripMenuItem.Enabled = True
                            .AbsensiToolStripMenuItem.Enabled = True
                            .JadwalKuliahToolStripMenuItem.Enabled = True
                            .KartuToolStripMenuItem.Enabled = True
                            .DataUserToolStripMenuItem.Enabled = False
                        End With
                    Else
                        MsgBox("Anda tidak diizinkan menggunakan program ini", vbCritical + vbOKOnly, "Informasi")
                        txt_username.Text = ""
                        txt_password.Text = ""
                        Exit Sub
                    End If
                Else
                    If Hitung < 4 Then
                        MsgBox("Password Yang anda masukkan salah !!, Anda sudah melakukan percobaan login sebanyak: " & Hitung, vbCritical + vbOKOnly, "Perhatian")
                        txt_password.Text = ""
                        txt_password.Focus()
                        Hitung = Hitung + 1
                    Else
                        MsgBox("Anda Bukan User yang berhak!!", vbCritical + vbOKOnly, "Perhatian")
                        Me.Close()
                    End If
                End If
            Else
                MsgBox("Anda belum terdaftar, Silahkan hubungi Bagian Admin", vbCritical + vbOKOnly, "Warning")
                txt_username.Text = ""
                txt_password.Text = ""
                txt_username.Focus()
            End If
        End If
                    
    End Sub

    Private Sub FormLogin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btn_batal_Click(sender As System.Object, e As System.EventArgs) Handles Btn_batal.Click
        Dim Pesan As String
        Pesan = MsgBox("Yakin Mau Keluar?", vbQuestion + vbYesNo, "Konfirmasi")
        If Pesan = vbYes Then
            Me.Close()
        Else
            txt_password.Focus()
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        FormGantiPassword.Show()
    End Sub
End Class