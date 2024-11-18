Imports MySql.Data.MySqlClient
Public Class FrmHome
    Private dt As DataTable
    Private Sub tampilprogram()
        konek3()
        Try
            dt = New DataTable
            dt.Clear()
            Dim sql As String = "SELECT A.ID,A.TGL_TERIMA,A.TGL_RILIS,A.TYPE,A.NAMA_PROGRAM,A.VERSI,IFNULL(B.NAMAFILE,'KOSONG') AS NAMAFILE,A.`STATUS` FROM TABLE_SIMULASI A LEFT JOIN M_FILE_UPD B ON A.NAMA_PROGRAM = B.NAMA_PROGRAM AND A.VERSI = B.VERSI GROUP BY A.`type`,A.nama_program,A.versi ORDER BY A.ID DESC "
            Dim da As MySqlDataAdapter = New MySqlDataAdapter(sql, con2)
            da.Fill(dt)
            dgprg.DataSource = dt
            dgprg.Columns(0).Width = 50
            dgprg.Columns(1).Width = 80
            dgprg.Columns(2).Width = 80
            dgprg.Columns(3).Width = 50
            dgprg.Columns(4).Width = 250
            dgprg.Columns(5).Width = 100
            dgprg.Columns(6).Width = 100
            dgprg.Columns(7).Width = 100


            AddHandler dgprg.CellFormatting, AddressOf dgprg_CellFormatting

        Catch ex As Exception
            MsgBox(ex.Message + ex.StackTrace)
        End Try
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim dv As New DataView(dt)
        dv.RowFilter = String.Format("NAMA_PROGRAM LIKE '%{0}%' OR VERSI LIKE '%{0}%' OR `STATUS` LIKE '%{0}%' ", txtSearch.Text)
        dgprg.DataSource = dv
    End Sub
    Private Sub dgprg_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)
        If dgprg.Columns(e.ColumnIndex).Name = "STATUS" Then
            If e.Value IsNot Nothing Then
                Dim cellValue As String = e.Value.ToString()
                Select Case cellValue
                    Case "SIMULASI"
                        e.CellStyle.BackColor = Color.DodgerBlue
                    Case "HOLD"
                        e.CellStyle.BackColor = Color.DarkGray
                    Case "RILIS"
                        e.CellStyle.BackColor = Color.LightGreen
                    Case Else
                        e.CellStyle.BackColor = Color.White
                End Select
            Else
                e.CellStyle.BackColor = Color.White
            End If
        End If

    End Sub

    Private Sub FrmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilprogram()
    End Sub

    Dim dt2 As DataTable
    Private Sub TextBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tampilprogram()
        MsgBox("Selesi")
    End Sub
End Class