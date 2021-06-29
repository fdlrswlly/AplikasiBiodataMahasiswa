Imports System.Data.Odbc

Public Class Form1


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        AcrReport.ReportFileName = Application.StartupPath & "\RptMahasiswa.rpt"
        AcrReport.DiscardSavedData = True
        AcrReport.WindowState = Crystal.WindowStateConstants.crptMaximized
        AcrReport.SelectionFormula = "{dt_mahasiswa.jurusanMhs}='" & ComboBox1.Text & "'"
        AcrReport.WindowShowPrintBtn = True
        AcrReport.WindowShowRefreshBtn = True

        AcrReport.PrintReport()
    End Sub
    Sub TampilJurusan()
        Call KoneksiDb()
        CMD = New OdbcCommand("SELECT jurusanMhs from dt_mahasiswa GROUP BY jurusanMhs", DbKoneksi)
        DR = CMD.ExecuteReader
        ComboBox1.Items.Clear()
        While DR.Read
            ComboBox1.Items.Add(DR(0).ToString)
        End While
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call TampilJurusan()
    End Sub
End Class