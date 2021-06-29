Public Class Form2
    'Sub kuadrat(ByVal Angka As Integer) As Integer
    '   kuadrat = Angka * Angka
    'End Sub
    Structure Siswa
        Dim NIM As Integer
        Dim Name As String
        Dim TTL As Date
    End Structure

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Const Pi As Single = 3.142
        Dim R As Single = 10
        Dim LuasLingkaran As Single
        LuasLingkaran = Pi * R ^ 2
        MsgBox("Luas Lingkaran " & "Radius " & R & " = " & LuasLingkaran)
    End Sub

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Dim num As Integer
        'Dim Namamhs(5) As String
        'For num = 1 To 5
        'Namamhs(num) = InputBox("Masukkan Nama Mahasiswa", "Masukkan Nama")
        'ListBox1.Items.Add(Namamhs(num))
        'Next
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim siswa As Siswa
        siswa.NIM = 201804029
        siswa.Name = "Reika Fitriani"
        siswa.TTL = "23/10/2006"
        MsgBox(siswa.NIM & vbCrLf & siswa.Name & vbCrLf & siswa.TTL)

    End Sub
    Sub Tampilkan(ByVal Nama As String)
        Nama = "Test"
        MessageBox.Show("Menampilkan procedure dengan " & Nama)

    End Sub
    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim coba As String
        coba = ListBox1.Text = "Test"
        Call Tampilkan(coba)
    End Sub

    'Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
    'Dim bilangan As Integer
    'For angka = 0 To 6
    'bilangan = kuadrat(angka)
    'ListBox1.Items.Add(bilangan)
    'Next
    'End Sub
End Class