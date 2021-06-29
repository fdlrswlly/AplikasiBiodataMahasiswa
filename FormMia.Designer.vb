<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMia))
        Me.CbJurusan = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CrystalReport1 = New AxCrystal.AxCrystalReport()
        CType(Me.CrystalReport1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CbJurusan
        '
        Me.CbJurusan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbJurusan.FormattingEnabled = True
        Me.CbJurusan.Location = New System.Drawing.Point(38, 52)
        Me.CbJurusan.Name = "CbJurusan"
        Me.CbJurusan.Size = New System.Drawing.Size(173, 21)
        Me.CbJurusan.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(235, 52)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Cetak"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CrystalReport1
        '
        Me.CrystalReport1.Enabled = True
        Me.CrystalReport1.Location = New System.Drawing.Point(128, 108)
        Me.CrystalReport1.Name = "CrystalReport1"
        Me.CrystalReport1.OcxState = CType(resources.GetObject("CrystalReport1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.CrystalReport1.Size = New System.Drawing.Size(28, 28)
        Me.CrystalReport1.TabIndex = 2
        '
        'FormMia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 134)
        Me.Controls.Add(Me.CrystalReport1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CbJurusan)
        Me.Name = "FormMia"
        Me.Text = "FormMia"
        CType(Me.CrystalReport1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CbJurusan As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CrystalReport1 As AxCrystal.AxCrystalReport
End Class
