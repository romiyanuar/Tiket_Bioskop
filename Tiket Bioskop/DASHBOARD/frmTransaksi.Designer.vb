<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransaksi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTransaksi))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtJumlah = New System.Windows.Forms.TextBox()
        Me.txtHargaJual = New System.Windows.Forms.TextBox()
        Me.txtKodeFilm = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.btnHitung = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 190)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(810, 256)
        Me.DataGridView1.TabIndex = 15
        '
        'txtJumlah
        '
        Me.txtJumlah.Location = New System.Drawing.Point(641, 81)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(40, 20)
        Me.txtJumlah.TabIndex = 13
        '
        'txtHargaJual
        '
        Me.txtHargaJual.Location = New System.Drawing.Point(334, 81)
        Me.txtHargaJual.Name = "txtHargaJual"
        Me.txtHargaJual.Size = New System.Drawing.Size(187, 20)
        Me.txtHargaJual.TabIndex = 14
        '
        'txtKodeFilm
        '
        Me.txtKodeFilm.Location = New System.Drawing.Point(122, 81)
        Me.txtKodeFilm.Name = "txtKodeFilm"
        Me.txtKodeFilm.Size = New System.Drawing.Size(65, 20)
        Me.txtKodeFilm.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Futura Hv BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Location = New System.Drawing.Point(220, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 19)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Harga Jual"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Futura Hv BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Location = New System.Drawing.Point(12, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 19)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Kode Film"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("LEMON MILK Medium", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(295, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(239, 53)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Transaksi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Futura Hv BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Location = New System.Drawing.Point(540, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 19)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Jumlah"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Futura Hv BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label5.Location = New System.Drawing.Point(377, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 19)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Total Biaya"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(491, 153)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(187, 20)
        Me.txtTotal.TabIndex = 14
        '
        'btnHitung
        '
        Me.btnHitung.Location = New System.Drawing.Point(703, 76)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(75, 23)
        Me.btnHitung.TabIndex = 16
        Me.btnHitung.Text = "Hitung"
        Me.btnHitung.UseVisualStyleBackColor = True
        '
        'frmTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(834, 461)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtJumlah)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtHargaJual)
        Me.Controls.Add(Me.txtKodeFilm)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmTransaksi"
        Me.Text = "frmSearch"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtJumlah As System.Windows.Forms.TextBox
    Friend WithEvents txtHargaJual As System.Windows.Forms.TextBox
    Friend WithEvents txtKodeFilm As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents btnHitung As System.Windows.Forms.Button
End Class
