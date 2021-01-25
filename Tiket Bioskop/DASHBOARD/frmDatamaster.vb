Public Class frmDatamaster

    Private Property sql As String

    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
        buka()
        sql = "Insert into tbl_film(kode_film,judul_film,harga_jual,stok_tiket) values ('" & txtKodeFilm.Text & "','" & cboJudulFilm.Text & "','" & txtHargaJual.Text & "','" & txtStokTiket.Text & "')"
        kon.Execute(sql)
        tutup()

        txtKodeFilm.Text = ""
        cboJudulFilm.Text = ""
        txtHargaJual.Text = ""
        txtStokTiket.Text = ""
        MsgBox("Data Berhasil Disimpan")
        tampil()
        Isi()
        btnUpdate.Enabled = False
        btnDelete.Enabled = False

    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        buka()
        sql = "update tbl_film set judul_film='" & cboJudulFilm.Text & "', harga_jual ='" & txtHargaJual.Text & "', stok_tiket ='" & txtStokTiket.Text & "' where kode_film='" & txtKodeFilm.Text & "'"
        kon.execute(sql)
        tutup()

        txtKodeFilm.Text = ""
        cboJudulFilm.Text = ""
        txtHargaJual.Text = ""
        txtStokTiket.Text = ""
        MsgBox("Data Berhasil Diubah")
        tampil()
        Isi()
        btnUpdate.Enabled = True
        btnDelete.Enabled = True
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        buka()
        sql = "delete from tbl_film where kode_film='" & txtKodeFilm.Text & "'"
        kon.Execute(sql)
        tutup()

        txtKodeFilm.Text = ""
        cboJudulFilm.Text = ""
        txtHargaJual.Text = ""
        txtStokTiket.Text = ""
        MsgBox("Data Berhasil Dihapus")
        tampil()
        Isi()
        btnUpdate.Enabled = True
        btnDelete.Enabled = True
    End Sub
    Private Sub tampil()
        Dim judul() As String = {"No", "Kode Film", "Judul Film", "Harga Jual", "Stock"}
        Dim lebar() As String = {50, 150, 150, 150, 150}
        Dim i As Integer
        DataGridView1.RowHeadersVisible = False
        DataGridView1.ColumnCount = 5
        DataGridView1.RowCount = 1
        DataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect
        DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("Century Gothic", 12)

        For i = 0 To DataGridView1.ColumnCount - 1
            DataGridView1.Columns(i).HeaderText = judul(i)
            DataGridView1.Columns(i).Width = lebar(i)
            DataGridView1.Columns(i).DefaultCellStyle.Font = New Font("Century Gothic", 10)
            DataGridView1.Columns(i).DefaultCellStyle.BackColor = Color.AliceBlue
        Next
    End Sub
    Public Sub isi()
        Dim no As Integer
        buka()
        rek.Open("select * from tbl_film", kon, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
        no = 1
        Do While Not rek.EOF
            Me.DataGridView1.Rows.Add(no, rek.Fields("kode_film").Value, rek.Fields("judul_film").Value, rek.Fields("harga_jual").Value, rek.Fields("stok_tiket").Value)
            rek.MoveNext()
            no = no + 1
        Loop
        tutup()
    End Sub
    Private Sub form_user_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampil()
        isi()
        btnUpdate.Enabled = True
        btnDelete.Enabled = True
    End Sub
End Class