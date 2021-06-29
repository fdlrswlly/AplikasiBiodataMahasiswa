<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGantiPassword
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt_passLama = New System.Windows.Forms.TextBox()
        Me.Txt_passBaru = New System.Windows.Forms.TextBox()
        Me.Txt_konfirmasi = New System.Windows.Forms.TextBox()
        Me.Txt_ubah = New System.Windows.Forms.Button()
        Me.Txt_batal = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Password Lama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password Baru"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Konfirmasi Password Baru"
        '
        'Txt_passLama
        '
        Me.Txt_passLama.Location = New System.Drawing.Point(171, 38)
        Me.Txt_passLama.Name = "Txt_passLama"
        Me.Txt_passLama.PasswordChar = Global.Microsoft.VisualBasic.ChrW(88)
        Me.Txt_passLama.Size = New System.Drawing.Size(159, 20)
        Me.Txt_passLama.TabIndex = 3
        '
        'Txt_passBaru
        '
        Me.Txt_passBaru.Location = New System.Drawing.Point(171, 78)
        Me.Txt_passBaru.Name = "Txt_passBaru"
        Me.Txt_passBaru.PasswordChar = Global.Microsoft.VisualBasic.ChrW(88)
        Me.Txt_passBaru.Size = New System.Drawing.Size(159, 20)
        Me.Txt_passBaru.TabIndex = 4
        '
        'Txt_konfirmasi
        '
        Me.Txt_konfirmasi.Location = New System.Drawing.Point(171, 111)
        Me.Txt_konfirmasi.Name = "Txt_konfirmasi"
        Me.Txt_konfirmasi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(88)
        Me.Txt_konfirmasi.Size = New System.Drawing.Size(159, 20)
        Me.Txt_konfirmasi.TabIndex = 5
        '
        'Txt_ubah
        '
        Me.Txt_ubah.Location = New System.Drawing.Point(171, 153)
        Me.Txt_ubah.Name = "Txt_ubah"
        Me.Txt_ubah.Size = New System.Drawing.Size(72, 26)
        Me.Txt_ubah.TabIndex = 6
        Me.Txt_ubah.Text = "UBAH"
        Me.Txt_ubah.UseVisualStyleBackColor = True
        '
        'Txt_batal
        '
        Me.Txt_batal.Location = New System.Drawing.Point(258, 153)
        Me.Txt_batal.Name = "Txt_batal"
        Me.Txt_batal.Size = New System.Drawing.Size(72, 26)
        Me.Txt_batal.TabIndex = 7
        Me.Txt_batal.Text = "BATAL"
        Me.Txt_batal.UseVisualStyleBackColor = True
        '
        'FormGantiPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 200)
        Me.Controls.Add(Me.Txt_batal)
        Me.Controls.Add(Me.Txt_ubah)
        Me.Controls.Add(Me.Txt_konfirmasi)
        Me.Controls.Add(Me.Txt_passBaru)
        Me.Controls.Add(Me.Txt_passLama)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormGantiPassword"
        Me.Text = "FormGantiPassword"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Txt_passLama As System.Windows.Forms.TextBox
    Friend WithEvents Txt_passBaru As System.Windows.Forms.TextBox
    Friend WithEvents Txt_konfirmasi As System.Windows.Forms.TextBox
    Friend WithEvents Txt_ubah As System.Windows.Forms.Button
    Friend WithEvents Txt_batal As System.Windows.Forms.Button
End Class
