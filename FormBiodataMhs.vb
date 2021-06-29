Imports System.Data.Odbc
Public Class FormBiodataMhs

    Sub FormNonaktif()
        'Class prosedur Nonaktif
        txt_nik.Enabled = False
        txt_nama.Enabled = False
        Cb_jk.Enabled = False
        Cb_agama.Enabled = False
        txt_alamat.Enabled = False
        Cb_jurusan.Enabled = False
        Cb_status.Enabled = False
    End Sub
    Sub FormAktif()
        txt_nik.Enabled = True
        txt_nama.Enabled = True
        Cb_jk.Enabled = True
        Cb_agama.Enabled = True
        txt_alamat.Enabled = True
        Cb_jurusan.Enabled = True
        Cb_status.Enabled = True
    End Sub
    Sub Kosongkan()
        'Class prosedur kosongkan
        txt_nik.Clear()
        txt_nama.Clear()
        Cb_jk.Items.Clear()
        Cb_agama.Items.Clear()
        txt_alamat.Clear()
        Cb_jurusan.Items.Clear()
        Cb_status.Items.Clear()
        'Lb_Hasil.Text = ""

    End Sub
    Sub FormNormal()
        'Class prosedur normal
        Kosongkan()
        FormNonaktif()
        btnhapus.Enabled = True
        btnhapus.Text = "&HAPUS"
        btnsimpan.Text = "&SIMPAN"
        btnsimpan.Enabled = False
        btnkeluar.Text = "&KELUAR"
    End Sub
    Sub Agama()
        Cb_agama.Items.Add("ISLAM")
        Cb_agama.Items.Add("PROTESTAN")
        Cb_agama.Items.Add("KATHOLIK")
        Cb_agama.Items.Add("HINDU")
        Cb_agama.Items.Add("BUDHA")
        Cb_agama.Items.Add("KONGHUCU")
    End Sub
    Sub statusMhs()
        Cb_status.Items.Add("AKTIF")
        Cb_status.Items.Add("NON AKTIF")
        Cb_status.Items.Add("CUTI AKADEMIK")
        Cb_status.Items.Add("DROP OUT")
    End Sub
    Sub JenisKelamin()
        Cb_jk.Items.Add("LAKI - LAKI")
        Cb_jk.Items.Add("PEREMPUAN")
    End Sub
    Sub Jurusan()
        Cb_jurusan.Items.Add("Teknologi Mesin")
        Cb_jurusan.Items.Add("Teknologi Mekatronika")
        Cb_jurusan.Items.Add("Teknologi Listrik")
        Cb_jurusan.Items.Add("Teknologi Rekayasa Perangkat Lunak")
        Cb_jurusan.Items.Add("Teknologi Industri")
        Cb_jurusan.Items.Add("Manajemen Informatika")
        Cb_jurusan.Items.Add("Akuntansi")
        Cb_jurusan.Items.Add("Hukum")
        Cb_jurusan.Items.Add("Farmasi")
    End Sub
    Sub AktifDataGridMhs()
        With DataGridMhs
            .EnableHeadersVisualStyles = False
            Try
                .Font = New Font(DataGridMhs.Font, FontStyle.Bold)
                DataGridMhs.DefaultCellStyle.Font = New Font("Arial", 9)
                DataGridMhs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
                DataGridMhs.ColumnHeadersHeight = 35

                'Memberikan nama pada header NIK
                DataGridMhs.Columns(0).Width = 80
                DataGridMhs.Columns(0).HeaderText = "NIK"
                DataGridMhs.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

                'Memberikan nama pada header Nama Mahasiswa
                DataGridMhs.Columns(1).Width = 140
                DataGridMhs.Columns(1).HeaderText = "Nama Mahasiswa"
                DataGridMhs.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

                'Memberikan nama pada header Jenis Kelamin Mahasiswa
                DataGridMhs.Columns(2).Width = 85
                DataGridMhs.Columns(2).HeaderText = "Jenis Kelamin"
                DataGridMhs.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

                'Memberikan nama pada header Agama Mahasiswa
                DataGridMhs.Columns(3).Width = 90
                DataGridMhs.Columns(3).HeaderText = "Agama"
                DataGridMhs.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

                'Memberikan nama pada header Alamat Mahasiswa
                DataGridMhs.Columns(4).Width = 150
                DataGridMhs.Columns(4).HeaderText = "Alamat"
                DataGridMhs.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

                'Memberikan nama pada header Jurusan Mahasiswa
                DataGridMhs.Columns(5).Width = 120
                DataGridMhs.Columns(5).HeaderText = "Jurusan"
                DataGridMhs.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

                'Memberikan nama pada header Status Mahasiswa
                DataGridMhs.Columns(6).Width = 85
                DataGridMhs.Columns(6).HeaderText = "Status"
                DataGridMhs.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            Catch ex As Exception

            End Try
        End With
    End Sub
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'form load
        Call KoneksiDb()
        Call FormNonaktif()
        Call TampilDataGrid()
        Call AktifDataGridMhs()
        btnsimpan.Enabled = False
        btnsimpan.BackColor = Color.Red
        btnhapus.Enabled = False
        btnhapus.BackColor = Color.Red

    End Sub

    Private Sub btnsimpan_Click(sender As System.Object, e As System.EventArgs) Handles btnsimpan.Click
        If txt_nama.Text = "" Then
            MsgBox("Lengkapi datanya dulu")
            txt_nama.Focus()
        Else
            'perintah SQL dari database ke VB.NET
            If btnsimpan.Text = "&SIMPAN" Then
                sqlInsert = "INSERT INTO dt_mahasiswa VALUES('" & txt_nik.Text & "','" _
                & txt_nama.Text & "','" _
                & Cb_jk.Text & "','" _
                & Cb_agama.Text & "','" _
                & txt_alamat.Text & "','" _
                & Cb_jurusan.Text & "','" _
                & Cb_status.Text & "')"
                CMD = New OdbcCommand(sqlInsert, DbKoneksi)
                CMD.ExecuteNonQuery()
                Call FormNormal()
                Call TampilDataGrid()
                btntambah.Enabled = True
                btnsimpan.Enabled = False
                btnsimpan.BackColor = Color.Red
                btntambah.Focus()
                btntambah.BackColor = Color.CornflowerBlue
                btnhapus.Enabled = False
                btnhapus.BackColor = Color.Red
            End If
        End If
    End Sub

    Private Sub btnkeluar_Click(sender As System.Object, e As System.EventArgs) Handles btnkeluar.Click
        'menggunakan button keluar
        If btnkeluar.Text = "&KELUAR" Then
            Me.Close()
        Else
            Call FormNormal()
            Call Kosongkan()
            btntambah.Enabled = True
            btnhapus.Enabled = False
            btnhapus.BackColor = Color.Red
            btntambah.BackColor = Color.CornflowerBlue
            btnsimpan.BackColor = Color.Red
        End If
    End Sub

    Private Sub btnhapus_Click(sender As System.Object, e As System.EventArgs) Handles btnhapus.Click
        Dim konfirm As String
        konfirm = MsgBox("Anda yakin ingin menghapus data ini ?", vbYesNo + vbQuestion, "Informasi")
        If konfirm = vbYes Then
            sqlHapus = "DELETE FROM dt_mahasiswa WHERE nikMhs = '" & txt_nik.Text & "'"
            CMD = New OdbcCommand(sqlHapus, DbKoneksi)
            CMD.ExecuteNonQuery()
            Call TampilDataGrid()
            Call Kosongkan()

            btntambah.Enabled = True
            btntambah.BackColor = Color.CornflowerBlue

            btnsimpan.Enabled = False
            btnsimpan.BackColor = Color.Red
            btnhapus.Enabled = False
            btnhapus.BackColor = Color.Red
        Else
            Call TampilDataGrid()
            Call Kosongkan()
            Call BuatNimMhs()
            btntambah.Enabled = True
            btntambah.BackColor = Color.CornflowerBlue
            btnsimpan.Enabled = True
            btnsimpan.BackColor = Color.CornflowerBlue
            btnsimpan.Text = "&SIMPAN"
            btnhapus.Enabled = False
            btnhapus.BackColor = Color.Red
            txtnama.Focus()


        End If



    End Sub

    Private Sub btntambah_Click(sender As System.Object, e As System.EventArgs) Handles btntambah.Click
        Call FormAktif()
        Call BuatNimMhs()
        Call JenisKelamin()
        Call Agama()
        Call Jurusan()
        Call statusMhs()
        txt_nik.Focus()
        btntambah.Enabled = False
        btntambah.BackColor = Color.Red
        btnhapus.Enabled = True
        btnsimpan.Enabled = True
        btnsimpan.Text = "&SIMPAN"
        btnsimpan.BackColor = Color.CornflowerBlue
        btnhapus.Text = "&HAPUS"
        btnhapus.BackColor = Color.CornflowerBlue
        btnkeluar.Text = "&BATAL"
    End Sub
    Sub TampilDataGrid()
        Call KoneksiDb()
        DA = New OdbcDataAdapter("SELECT * FROM dt_mahasiswa ORDER by nikMhs ASC", DbKoneksi)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS)
        DataGridMhs.DataSource = DS.Tables(0)
        DataGridMhs.ReadOnly = True
    End Sub
    Sub BuatNimMhs()
        On Error Resume Next
        CMD = New OdbcCommand("SELECT * FROM dt_mahasiswa " _
                              & "WHERE dt_mahasiswa.nikMhs IN (SELECT MAX(nikMhs) " _
                              & "FROM dt_mahasiswa) ORDER BY nikMhs Desc", DbKoneksi)
        'Buatkan Variable
        Dim Urutan As String
        Dim Hitung As Long
        DR = CMD.ExecuteReader
        DR.Read()
        'fungsi if penomoran
        If Not DR.HasRows Then
            Urutan = "2018" + "04" + "001"
        Else
            If Microsoft.VisualBasic.Right(DR.GetString(0), 3) >= "999" Then
                Urutan = "2018" + "04" + "001"
            Else
                Hitung = Microsoft.VisualBasic.Right(DR.GetString(0), 3) + 1
                Urutan = "2018" + "04" + Microsoft.VisualBasic.Right("000" & Hitung, 3)
            End If
        End If
        DR.Close()
        txt_nik.Text = Urutan
    End Sub
    Sub buat_kolom()
        With DataGridMhs
            'Mengisi nama pada kolom grid
            .Columns.Add("NIK", "NIK")
            .Columns.Add("Nama", "Nama")
            .Columns.Add("Jenis Kelamin", "Jenis Kelamin")
            .Columns.Add("Agama", "Agama")
            .Columns.Add("Alamat", "Alamat")
            .Columns.Add("Jurusan", "Jurusan")
            .Columns.Add("Status", "Status")
            'Mengatur ukuran table
            .Columns("NIK").Width = 100
            .Columns("Nama").Width = 100
            .Columns("Jenis Kelamin").Width = 100
            .Columns("Agama").Width = 100
            .Columns("Jurusan").Width = 100
            .Columns("Jurusan").Width = 100
            .Columns("Jenis Kelamin").Width = 100
            .Columns("Status").Width = 100
        End With
    End Sub
   

    Private Sub DataGridMhs_CellMouseClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridMhs.CellMouseClick
        Call JenisKelamin()
        Call Jurusan()

        'With DataGridMhs
        'txt_nik.Text = .Rows(e.RowIndex).Cells(0).Value
        'txt_nama.Text = .Rows(e.RowIndex).Cells(1).Value
        'Cb_jk.Text = .Rows(e.RowIndex).Cells(2).Value
        'Cb_agama.Text = .Rows(e.RowIndex).Cells(3).Value
        'txt_alamat.Text = .Rows(e.RowIndex).Cells(4).Value
        'Cb_jurusan.Text = .Rows(e.RowIndex).Cells(5).Value
        'Cb_status.Text = .Rows(e.RowIndex).Cells(6).Value
        'End With
    End Sub

    Private Sub GroupBox1_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox1.Enter

    End Sub


    Private Sub DataGridMhs_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridMhs.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        FormLapMahasiswa.Show()
    End Sub

    Private Sub txt_nik_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_nik.TextChanged

    End Sub
End Class
