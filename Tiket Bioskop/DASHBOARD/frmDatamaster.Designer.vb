<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDatamaster
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDatamaster))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboJudulFilm = New System.Windows.Forms.ComboBox()
        Me.txtKodeFilm = New System.Windows.Forms.TextBox()
        Me.txtHargaJual = New System.Windows.Forms.TextBox()
        Me.txtStokTiket = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("LEMON MILK Medium", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(295, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(218, 53)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data Film"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Futura Hv BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Location = New System.Drawing.Point(112, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kode Film"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Futura Hv BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Location = New System.Drawing.Point(112, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Judul Film"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Futura Hv BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Location = New System.Drawing.Point(435, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 19)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Harga Jual"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Futura Hv BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label5.Location = New System.Drawing.Point(435, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 19)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Stok Tiket"
        '
        'cboJudulFilm
        '
        Me.cboJudulFilm.FormattingEnabled = True
        Me.cboJudulFilm.Items.AddRange(New Object() {"Kimetsu No Yaiba : Mugen Train", "Godzilla vs Kong", "The Avengers : End Game", "Jumanji: The Next Level"})
        Me.cboJudulFilm.Location = New System.Drawing.Point(222, 119)
        Me.cboJudulFilm.Name = "cboJudulFilm"
        Me.cboJudulFilm.Size = New System.Drawing.Size(162, 21)
        Me.cboJudulFilm.TabIndex = 2
        '
        'txtKodeFilm
        '
        Me.txtKodeFilm.Location = New System.Drawing.Point(222, 84)
        Me.txtKodeFilm.Name = "txtKodeFilm"
        Me.txtKodeFilm.Size = New System.Drawing.Size(162, 20)
        Me.txtKodeFilm.TabIndex = 3
        '
        'txtHargaJual
        '
        Me.txtHargaJual.Location = New System.Drawing.Point(549, 84)
        Me.txtHargaJual.Name = "txtHargaJual"
        Me.txtHargaJual.Size = New System.Drawing.Size(162, 20)
        Me.txtHargaJual.TabIndex = 3
        '
        'txtStokTiket
        '
        Me.txtStokTiket.Location = New System.Drawing.Point(549, 120)
        Me.txtStokTiket.Name = "txtStokTiket"
        Me.txtStokTiket.Size = New System.Drawing.Size(162, 20)
        Me.txtStokTiket.TabIndex = 3
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 193)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(810, 256)
        Me.DataGridView1.TabIndex = 4
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(261, 164)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(75, 23)
        Me.btnInsert.TabIndex = 5
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(364, 164)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 5
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(464, 164)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 5
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'frmDatamaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(834, 461)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtStokTiket)
        Me.Controls.Add(Me.txtHargaJual)
        Me.Controls.Add(Me.txtKodeFilm)
        Me.Controls.Add(Me.cboJudulFilm)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmDatamaster"
        Me.Text = "frmDatamaster"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboJudulFilm As System.Windows.Forms.ComboBox
    Friend WithEvents txtKodeFilm As System.Windows.Forms.TextBox
    Friend WithEvents txtHargaJual As System.Windows.Forms.TextBox
    Friend WithEvents txtStokTiket As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
End Class
