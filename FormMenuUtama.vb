Public Class FormMenuUtama

    Private Sub DataMahasiswaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DataMahasiswaToolStripMenuItem.Click
        FormBiodataMhs.ShowDialog()

    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LoginToolStripMenuItem.Click
        FormLogin.ShowDialog()
    End Sub

    Private Sub DataUserToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DataUserToolStripMenuItem.Click
        FormDataUser.ShowDialog()

    End Sub

    Private Sub FormMenuUtama_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Hide()
        FormLogin.Show()
    End Sub
End Class