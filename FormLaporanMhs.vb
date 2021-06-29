Imports System.Data.Odbc
Imports CrystalDecisions.CrystalReports.Engine
Public Class FormLaporanMhs

    Private Sub btn_laporan_Click(sender As System.Object, e As System.EventArgs) Handles btn_laporan.Click
        Dim LapReport As New ReportDocument
        LapReport.Load(Application.StartupPath + "\" + "CrystalReport1.rpt")
        CrystalReportViewer1.ReportSource = LapReport
        CrystalReportViewer1.SelectionFormula = "{dt_mahasiswa1.jurusanMhs}='" & Cb_jurusan.Text & "'"
        CrystalReportViewer1.RefreshReport()
        MyBase.OnLoad(e)
    End Sub

    Sub TampilJurusan()
        Call KoneksiDb()
        CMD = New OdbcCommand("SELECT jurusanMhs from dt_mahasiswa GROUP BY jurusanMhs", DbKoneksi)
        DR = CMD.ExecuteReader
        Cb_jurusan.Items.Clear()
        While DR.Read
            Cb_jurusan.Items.Add(DR(0).ToString)
        End While
    End Sub
    Private Sub FormLaporanMhs_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call TampilJurusan()
    End Sub

End Class