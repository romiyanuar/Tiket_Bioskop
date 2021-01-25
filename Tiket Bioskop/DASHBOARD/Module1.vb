Module Module1
    Public kon As New ADODB.Connection
    Public rek As New ADODB.Recordset
    Public Sub buka()
        kon.Open("DSN=dBASE FILES")
    End Sub
    Public Sub tutup()
        kon.Close()
    End Sub
End Module
