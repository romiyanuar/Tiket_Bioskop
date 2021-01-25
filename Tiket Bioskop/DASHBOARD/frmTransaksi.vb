Public Class frmTransaksi
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
    End Sub

    Private Sub btnHitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHitung.Click
        txtTotal.Text = Val(txtHargaJual.Text) * Val(txtJumlah.Text)
    End Sub
End Class