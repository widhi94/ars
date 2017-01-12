<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fFaktur
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
        Me.txtArt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtKota = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtKet = New System.Windows.Forms.TextBox()
        Me.cmbFormat = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtKurs = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.kdArt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.namaArt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ket = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.txtKodeCust = New System.Windows.Forms.TextBox()
        Me.txtNamaCust = New System.Windows.Forms.TextBox()
        Me.txtkodeArt = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtTotal1 = New System.Windows.Forms.TextBox()
        Me.txtMatauang = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTanggal = New System.Windows.Forms.DateTimePicker()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(430, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tanggal"
        '
        'txtArt
        '
        Me.txtArt.Location = New System.Drawing.Point(93, 106)
        Me.txtArt.Name = "txtArt"
        Me.txtArt.Size = New System.Drawing.Size(154, 20)
        Me.txtArt.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(430, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Customer"
        '
        'txtKota
        '
        Me.txtKota.Location = New System.Drawing.Point(503, 74)
        Me.txtKota.Name = "txtKota"
        Me.txtKota.Size = New System.Drawing.Size(121, 20)
        Me.txtKota.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Art"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Harga"
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(93, 141)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(154, 20)
        Me.txtHarga.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 174)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Keterangan"
        '
        'txtKet
        '
        Me.txtKet.Location = New System.Drawing.Point(93, 167)
        Me.txtKet.Multiline = True
        Me.txtKet.Name = "txtKet"
        Me.txtKet.Size = New System.Drawing.Size(154, 43)
        Me.txtKet.TabIndex = 11
        '
        'cmbFormat
        '
        Me.cmbFormat.FormattingEnabled = True
        Me.cmbFormat.Location = New System.Drawing.Point(93, 73)
        Me.cmbFormat.Name = "cmbFormat"
        Me.cmbFormat.Size = New System.Drawing.Size(154, 21)
        Me.cmbFormat.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Format"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 276)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Kurs"
        '
        'txtKurs
        '
        Me.txtKurs.Location = New System.Drawing.Point(93, 269)
        Me.txtKurs.Name = "txtKurs"
        Me.txtKurs.Size = New System.Drawing.Size(154, 20)
        Me.txtKurs.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 229)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(23, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Qty"
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(93, 229)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(154, 20)
        Me.txtQty.TabIndex = 17
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(264, 266)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(67, 32)
        Me.btnTambah.TabIndex = 19
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kdArt, Me.namaArt, Me.ket, Me.qty, Me.harga, Me.total, Me.Column1})
        Me.DataGridView1.Location = New System.Drawing.Point(356, 100)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(741, 211)
        Me.DataGridView1.TabIndex = 20
        '
        'kdArt
        '
        Me.kdArt.HeaderText = "kode art"
        Me.kdArt.Name = "kdArt"
        '
        'namaArt
        '
        Me.namaArt.HeaderText = "Art"
        Me.namaArt.Name = "namaArt"
        '
        'ket
        '
        Me.ket.HeaderText = "Keterangan"
        Me.ket.Name = "ket"
        '
        'qty
        '
        Me.qty.HeaderText = "Qty"
        Me.qty.Name = "qty"
        '
        'harga
        '
        Me.harga.HeaderText = "Harga"
        Me.harga.Name = "harga"
        '
        'total
        '
        Me.total.HeaderText = "Jumlah"
        Me.total.Name = "total"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Jumlah IDR"
        Me.Column1.Name = "Column1"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(922, 398)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 21
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(1013, 398)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 23)
        Me.btnBatal.TabIndex = 22
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'txtKodeCust
        '
        Me.txtKodeCust.Location = New System.Drawing.Point(630, 48)
        Me.txtKodeCust.Name = "txtKodeCust"
        Me.txtKodeCust.Size = New System.Drawing.Size(36, 20)
        Me.txtKodeCust.TabIndex = 24
        '
        'txtNamaCust
        '
        Me.txtNamaCust.Location = New System.Drawing.Point(503, 48)
        Me.txtNamaCust.Name = "txtNamaCust"
        Me.txtNamaCust.Size = New System.Drawing.Size(121, 20)
        Me.txtNamaCust.TabIndex = 25
        '
        'txtkodeArt
        '
        Me.txtkodeArt.Location = New System.Drawing.Point(264, 106)
        Me.txtkodeArt.Name = "txtkodeArt"
        Me.txtkodeArt.Size = New System.Drawing.Size(36, 20)
        Me.txtkodeArt.TabIndex = 26
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(943, 326)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(154, 20)
        Me.txtTotal.TabIndex = 23
        '
        'txtTotal1
        '
        Me.txtTotal1.Location = New System.Drawing.Point(943, 352)
        Me.txtTotal1.Name = "txtTotal1"
        Me.txtTotal1.Size = New System.Drawing.Size(154, 20)
        Me.txtTotal1.TabIndex = 27
        '
        'txtMatauang
        '
        Me.txtMatauang.Location = New System.Drawing.Point(264, 141)
        Me.txtMatauang.Name = "txtMatauang"
        Me.txtMatauang.Size = New System.Drawing.Size(36, 20)
        Me.txtMatauang.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(195, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Label3"
        '
        'txtTanggal
        '
        Me.txtTanggal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtTanggal.Location = New System.Drawing.Point(503, 22)
        Me.txtTanggal.Name = "txtTanggal"
        Me.txtTanggal.Size = New System.Drawing.Size(121, 20)
        Me.txtTanggal.TabIndex = 30
        '
        'fFaktur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1153, 489)
        Me.Controls.Add(Me.txtTanggal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMatauang)
        Me.Controls.Add(Me.txtTotal1)
        Me.Controls.Add(Me.txtkodeArt)
        Me.Controls.Add(Me.txtNamaCust)
        Me.Controls.Add(Me.txtKodeCust)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtKurs)
        Me.Controls.Add(Me.cmbFormat)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtKet)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtKota)
        Me.Controls.Add(Me.txtArt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "fFaktur"
        Me.Text = "fFaktur"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtArt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtKota As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtHarga As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtKet As System.Windows.Forms.TextBox
    Friend WithEvents cmbFormat As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtKurs As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents txtKodeCust As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaCust As System.Windows.Forms.TextBox
    Friend WithEvents txtkodeArt As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal1 As System.Windows.Forms.TextBox
    Friend WithEvents txtMatauang As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents kdArt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents namaArt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ket As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents harga As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
