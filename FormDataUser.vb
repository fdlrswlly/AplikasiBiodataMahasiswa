Imports System.Data.Odbc
Public Class FormDataUser
    Sub FormNonaktif()
        txt_kduser.Enabled = False
        txt_nmuser.Enabled = False
        txt_passuser.Enabled = False
        cb_leveluser.Enabled = False
    End Sub
    Sub FormAktif()
        txt_kduser.Enabled = True
        txt_nmuser.Enabled = True
        txt_passuser.Enabled = True
        cb_leveluser.Enabled = True
    End Sub
    Sub kosongkan()
        txt_kduser.Clear()
        txt_nmuser.Clear()
        txt_passuser.Clear()
        cb_leveluser.Items.Clear()
    End Sub
    Sub FormNormal()
        kosongkan()
        FormNonaktif()
        Btn_hapus.Enabled = True
        Btn_hapus.Text = "&HAPUS"
        Btn_simpan.Text = "&SIMPAN"
        Btn_simpan.BackColor = Color.Red
        Btn_hapus.BackColor = Color.Red
        Btn_simpan.Enabled = False
        Btn_keluar.Text = "&KELUAR"
    End Sub
    Sub subLevelUser()
        cb_leveluser.Items.Add("Admin")
        cb_leveluser.Items.Add("User")
    End Sub
    Sub buatkduser()
        On Error Resume Next
        CMD = New OdbcCommand("SELECT * FROM dt_user " _
                              & "WHERE dt_user.IdUser IN (SELECT MAX(IdUser)" _
                              & "FROM dt_user) ORDER BY IdUser Desc", DbKoneksi)
        Dim Urut As String
        Dim Hitung As Long
        DR = CMD.ExecuteReader
        DR.Read()
        If Not DR.HasRows Then
            Urut = "US" + "001"
        Else
            If Microsoft.VisualBasic.Right(DR.GetString(0), 3) >= "999" Then
                Urut = "US" + "001"
            Else
                Hitung = Microsoft.VisualBasic.Right(DR.GetString(0), 3) + 1
                Urut = "US" + Microsoft.VisualBasic.Right("000" & Hitung, 3)
            End If
        End If
        DR.Close()
        txt_kduser.Text = Urut
    End Sub
    Sub AktifDataGridUser()
        With DataGridUser
            .EnableHeadersVisualStyles = False
            Try
                .Font = New Font(DataGridUser.Font, FontStyle.Bold)
                DataGridUser.DefaultCellStyle.Font = New Font("Arial", 9)
                DataGridUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
                DataGridUser.ColumnHeadersHeight = 35

                'Kode User
                DataGridUser.Columns(0).Width = 100
                DataGridUser.Columns(0).HeaderText = "Kode User"
                DataGridUser.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

                'Nama User
                DataGridUser.Columns(1).Width = 100
                DataGridUser.Columns(1).HeaderText = "Nama User"
                DataGridUser.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

                'Pass User
                DataGridUser.Columns(2).Width = 100
                DataGridUser.Columns(2).HeaderText = "Password"
                DataGridUser.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

                'Level User
                DataGridUser.Columns(3).Width = 110
                DataGridUser.Columns(3).HeaderText = "Level User"
                DataGridUser.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            Catch ex As Exception

            End Try
        End With
    End Sub
    'Menampilkan data user
    Sub TampilDataGridUser()
        Call KoneksiDb()
        DA = New OdbcDataAdapter("SELECT * FROM dt_user ORDER BY IdUser ASC", DbKoneksi)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS)
        DataGridUser.DataSource = DS.Tables(0)
        DataGridUser.ReadOnly = True
        Call AktifDataGridUser()
    End Sub

    Private Sub FormDataUser_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call KoneksiDb()
        Call FormNonaktif()
        Call TampilDataGridUser()
        Call AktifDataGridUser()
        Btn_simpan.Enabled = False
        Btn_simpan.BackColor = Color.Red
        Btn_hapus.Enabled = False
        Btn_hapus.BackColor = Color.Red
        Btn_tambah.BackColor = Color.CornflowerBlue
    End Sub

    Private Sub Btn_simpan_Click(sender As System.Object, e As System.EventArgs) Handles Btn_simpan.Click
        If txt_kduser.Text = "" Then
            MsgBox("Isi terlebih dahulu Kode User", vbInformation, "Informasi")
            txt_kduser.Focus()
        ElseIf txt_nmuser.Text = "" Then
            MsgBox("Isi terlebih dahulu Nama User", vbInformation, "Informasi")
            txt_nmuser.Focus()
        ElseIf txt_passuser.Text = "" Then
            MsgBox("Isi terlebih dahulu Password User", vbInformation, "Informasi")
            txt_passuser.Focus()
        Else
            If Btn_simpan.Text = "&SIMPAN" Then
                sqlInsert = "INSERT INTO dt_user VALUES ('" & txt_kduser.Text & "','" _
                    & txt_nmuser.Text & "','" _
                    & txt_passuser.Text & "','" _
                    & cb_leveluser.Text & "')"
                CMD = New OdbcCommand(sqlInsert, DbKoneksi)
                CMD.ExecuteNonQuery()
                Call FormNormal()
                Call TampilDataGridUser()
                Btn_tambah.Enabled = True
                Btn_simpan.Enabled = False
                Btn_tambah.BackColor = Color.CornflowerBlue
                Btn_simpan.BackColor = Color.Red
            End If
        End If
    End Sub

    Private Sub Btn_tambah_Click(sender As System.Object, e As System.EventArgs) Handles Btn_tambah.Click
        Call FormAktif()
        Call buatkduser()
        Call subLevelUser()
        txt_kduser.Focus()
        Btn_tambah.Enabled = False
        Btn_tambah.BackColor = Color.Red
        Btn_simpan.Enabled = True
        Btn_simpan.Text = "&SIMPAN"
        Btn_simpan.BackColor = Color.CornflowerBlue
        Btn_hapus.Enabled = True
        Btn_hapus.BackColor = Color.CornflowerBlue
        Btn_keluar.Text = "&BATAL"
    End Sub

    Private Sub Btn_keluar_Click(sender As System.Object, e As System.EventArgs) Handles Btn_keluar.Click
        If Btn_keluar.Text = "&KELUAR" Then
            Me.Close()
        Else
            Call FormNormal()
            Call kosongkan()

            Btn_tambah.Enabled = True
            Btn_tambah.BackColor = Color.CornflowerBlue
            Btn_simpan.BackColor = Color.Red
        End If
    End Sub
End Class