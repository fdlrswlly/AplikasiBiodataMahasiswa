<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDataUser
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cb_leveluser = New System.Windows.Forms.ComboBox()
        Me.txt_passuser = New System.Windows.Forms.TextBox()
        Me.txt_nmuser = New System.Windows.Forms.TextBox()
        Me.txt_kduser = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Btn_keluar = New System.Windows.Forms.Button()
        Me.Btn_tambah = New System.Windows.Forms.Button()
        Me.Btn_hapus = New System.Windows.Forms.Button()
        Me.Btn_simpan = New System.Windows.Forms.Button()
        Me.DataGridUser = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(458, 48)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DATA USER"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cb_leveluser)
        Me.GroupBox1.Controls.Add(Me.txt_passuser)
        Me.GroupBox1.Controls.Add(Me.txt_nmuser)
        Me.GroupBox1.Controls.Add(Me.txt_kduser)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(458, 123)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'cb_leveluser
        '
        Me.cb_leveluser.FormattingEnabled = True
        Me.cb_leveluser.Location = New System.Drawing.Point(79, 89)
        Me.cb_leveluser.Name = "cb_leveluser"
        Me.cb_leveluser.Size = New System.Drawing.Size(160, 21)
        Me.cb_leveluser.TabIndex = 7
        '
        'txt_passuser
        '
        Me.txt_passuser.Location = New System.Drawing.Point(79, 63)
        Me.txt_passuser.Name = "txt_passuser"
        Me.txt_passuser.Size = New System.Drawing.Size(160, 20)
        Me.txt_passuser.TabIndex = 6
        '
        'txt_nmuser
        '
        Me.txt_nmuser.Location = New System.Drawing.Point(79, 37)
        Me.txt_nmuser.Name = "txt_nmuser"
        Me.txt_nmuser.Size = New System.Drawing.Size(160, 20)
        Me.txt_nmuser.TabIndex = 5
        '
        'txt_kduser
        '
        Me.txt_kduser.Location = New System.Drawing.Point(79, 13)
        Me.txt_kduser.Name = "txt_kduser"
        Me.txt_kduser.Size = New System.Drawing.Size(103, 20)
        Me.txt_kduser.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Level User"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nama User"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Kode"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Btn_keluar)
        Me.GroupBox2.Controls.Add(Me.Btn_tambah)
        Me.GroupBox2.Controls.Add(Me.Btn_hapus)
        Me.GroupBox2.Controls.Add(Me.Btn_simpan)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 199)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(453, 73)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'Btn_keluar
        '
        Me.Btn_keluar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Btn_keluar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_keluar.Location = New System.Drawing.Point(346, 16)
        Me.Btn_keluar.Name = "Btn_keluar"
        Me.Btn_keluar.Size = New System.Drawing.Size(96, 43)
        Me.Btn_keluar.TabIndex = 3
        Me.Btn_keluar.Text = "KELUAR"
        Me.Btn_keluar.UseVisualStyleBackColor = False
        '
        'Btn_tambah
        '
        Me.Btn_tambah.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Btn_tambah.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_tambah.Location = New System.Drawing.Point(232, 16)
        Me.Btn_tambah.Name = "Btn_tambah"
        Me.Btn_tambah.Size = New System.Drawing.Size(103, 43)
        Me.Btn_tambah.TabIndex = 2
        Me.Btn_tambah.Text = "TAMBAH"
        Me.Btn_tambah.UseVisualStyleBackColor = False
        '
        'Btn_hapus
        '
        Me.Btn_hapus.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Btn_hapus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_hapus.Location = New System.Drawing.Point(122, 16)
        Me.Btn_hapus.Name = "Btn_hapus"
        Me.Btn_hapus.Size = New System.Drawing.Size(100, 43)
        Me.Btn_hapus.TabIndex = 1
        Me.Btn_hapus.Text = "HAPUS"
        Me.Btn_hapus.UseVisualStyleBackColor = False
        '
        'Btn_simpan
        '
        Me.Btn_simpan.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Btn_simpan.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_simpan.Location = New System.Drawing.Point(12, 16)
        Me.Btn_simpan.Name = "Btn_simpan"
        Me.Btn_simpan.Size = New System.Drawing.Size(101, 43)
        Me.Btn_simpan.TabIndex = 0
        Me.Btn_simpan.Text = "SIMPAN"
        Me.Btn_simpan.UseVisualStyleBackColor = False
        '
        'DataGridUser
        '
        Me.DataGridUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridUser.Location = New System.Drawing.Point(15, 278)
        Me.DataGridUser.Name = "DataGridUser"
        Me.DataGridUser.Size = New System.Drawing.Size(453, 165)
        Me.DataGridUser.TabIndex = 3
        '
        'FormDataUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 465)
        Me.Controls.Add(Me.DataGridUser)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormDataUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DATA USER"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cb_leveluser As System.Windows.Forms.ComboBox
    Friend WithEvents txt_passuser As System.Windows.Forms.TextBox
    Friend WithEvents txt_nmuser As System.Windows.Forms.TextBox
    Friend WithEvents txt_kduser As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_keluar As System.Windows.Forms.Button
    Friend WithEvents Btn_tambah As System.Windows.Forms.Button
    Friend WithEvents Btn_hapus As System.Windows.Forms.Button
    Friend WithEvents Btn_simpan As System.Windows.Forms.Button
    Friend WithEvents DataGridUser As System.Windows.Forms.DataGridView
End Class
