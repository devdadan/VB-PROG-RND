Imports MySql.Data.MySqlClient
Imports REG.Fungsi
Public Class Formposrt
    Dim con As MySqlConnection
    Dim da As MySqlDataAdapter
    Dim contok As MySqlConnection
    Private Sub Formposrt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        GetNok()
        lblloading.Text = ""
        pbar.Value = 75
    End Sub

    Private Sub GetNok()
        Try
            koneklokal2()
            Dim dt As DataTable = New DataTable()
            dt.Clear()
            DataGridView1.Columns.Clear()
            Dim sql As String = "SELECT CONCAT('ID', REPLACE(REPLACE(REPLACE(CUT_OFF, ':', ''), ' ', ''), '-', '')) AS ID,NAMATABLE, TIME(cut_off) AS JAM, COUNT(1) AS TOTAL_NOK,`STATUS` " &
                            "FROM posrt " &
                            "WHERE DATE(cut_off) = CURDATE() " &
                            "GROUP BY HOUR(cut_off), ID " &
                            "ORDER BY cut_off DESC;"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGridView1.DataSource = dt
            settcolumn()


            Dim btnColumn As New DataGridViewButtonColumn()
            btnColumn.Name = "ActionColumn"
            btnColumn.HeaderText = "Action"
            btnColumn.Text = "Cek posrt toko"
            btnColumn.UseColumnTextForButtonValue = True
            If Not DataGridView1.Columns.Contains("ActionColumn") Then
                DataGridView1.Columns.Add(btnColumn)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = DataGridView1.Columns("ActionColumn").Index Then
            Dim idValue As String = DataGridView1.Rows(e.RowIndex).Cells("ID").Value.ToString()
            ExecuteFunction(idValue)
        End If
    End Sub

    Private Sub DataGridView1_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs) Handles DataGridView1.RowPrePaint
        Dim dgv As DataGridView = CType(sender, DataGridView)
        Dim status As String = dgv.Rows(e.RowIndex).Cells("STATUS").Value.ToString()

        If status = "1" Then
            dgv.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightGreen
            dgv.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.White
        Else
            dgv.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Red
            dgv.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
        End If
    End Sub


    Private Sub ExecuteFunction(id As String)
        Dim tanya As DialogResult = MessageBox.Show("Akan cek posrealtime toko dengan ID " & id & "?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If tanya = DialogResult.Yes Then
            'Try
            '    koneklokal2()
            '    Dim sqlc As String = "DELETE FROM POSRT_CEK WHERE `ID`='" & id & "'"
            '    Dim cmdc As MySqlCommand = New MySqlCommand(sqlc, con)
            '    cmdc.ExecuteNonQuery()
            '    con.Close()
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            'End Try
            If id.StartsWith("ID") Then
                id = id.Substring(2)
            End If

            If id.Length = 14 Then
                Dim year As String = id.Substring(0, 4)
                Dim month As String = id.Substring(4, 2)
                Dim day As String = id.Substring(6, 2)
                Dim hour As String = id.Substring(8, 2)
                Dim minute As String = id.Substring(10, 2)
                Dim second As String = id.Substring(12, 2)


                Dim formattedDateTime As String = $"{year}-{month}-{day} {hour}:{minute}:{second}"
                getpaket(formattedDateTime)

                'MessageBox.Show("Formatted Date-Time: " & formattedDateTime, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("ID format is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else

            MessageBox.Show("Operasi dibatalkan.", "Dibatalkan", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub
    Private Sub settcolumn()
        DataGridView1.Columns(0).Name = "ID"
        DataGridView1.Columns(1).Name = "NAMATABLE"
        DataGridView1.Columns(2).Name = "JAM"
        DataGridView1.Columns(3).Name = "NOK"


        DataGridView1.Columns(0).Width = 300
        DataGridView1.Columns(1).Width = 100
        DataGridView1.Columns(2).Width = 100
        DataGridView1.Columns(3).Width = 100
        DataGridView1.Columns(4).Width = 50

    End Sub
    Private Sub getpaket(id As String)
        Try
            lblloading.Text = "Get paket .."
            koneklokal2()
            Dim dt2 As DataTable = New DataTable()
            dt2.Clear()
            DataGridView2.Columns.Clear()

            Dim sql As String = "SELECT A.TOKO,A.KODEGUDANG,A.NAMATABLE,A.CUT_OFF,B.IP,CONCAT('ID',REPLACE(REPLACE(REPLACE(A.CUT_OFF,':',''),' ',''),'-','')) AS ID FROM DB_SCRAP.POSRT A JOIN SIEDP.M_IP B ON A.TOKO = B.TOKO WHERE A.cut_off='" & id & "' AND B.STATION=1"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt2)
            DataGridView2.DataSource = dt2

            Dim row As Integer = DataGridView2.Rows.Count
            If row = 0 Then
                lblloading.Text = "Gagal get paket .."
                MsgBox("Gagal get paket posrt!", MsgBoxStyle.Critical)
            Else
                lblloading.Text = "Mulai .."

                pbar.Maximum = 100
                pbar.Minimum = 0
                pbar.Value = 0
                BackgroundWorker1.RunWorkerAsync()

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub koneklokal2()
        Try
            Dim Mysql As String = "server=192.168.190.100;uid=root;pwd=15032012;database=db_scrap;Pooling=False;Connection Timeout=120;"
            con = New MySqlConnection(Mysql)
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Function koneksitoko(ip As String) As Boolean
        Dim sector As String = Fungsi.GetPass()
        Dim parts As String() = sector.Split("|"c)
        Dim res As Boolean = False

        If parts.Length >= 3 Then
            Dim passwords As String() = {parts(0), parts(1), parts(2)}

            For Each password In passwords
                Try
                    Dim isector As String = ""
                    isector = Fungsi.GetServer("root", password)
                    Dim conpos As String = $"server={ip};uid=root;pwd={isector};database=POS;Pooling=False;Connection Timeout=120;"
                    contok = New MySqlConnection(conpos)
                    contok.Open()
                    res = True
                    Exit For
                Catch ex As Exception
                    Fungsi.Tulislog($"Gagal menghubungkan ke toko pada {ip} dengan password {password}: {ex.Message}")
                End Try
            Next
        Else
            MsgBox("GAGAL MENDAPATKAN SECTOR", MsgBoxStyle.Critical)
            Fungsi.Tulislog("Data yang diperoleh dari GetPass tidak lengkap.")
        End If

        Return res
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GetNok()
        MsgBox("Ok", MsgBoxStyle.Information)
    End Sub
    Dim IDD As String
    Private Sub proses()
        Dim a As Integer = DataGridView2.Rows.Count - 1
        For i As Integer = 0 To a

            If i = a Then
                MsgBox("Selesai", MsgBoxStyle.Information)
                pbar.Value = 0
                lblloading.Text = "Loading .."
            End If
            pbar.Value = (i * 100) / a

            Dim cellValue As Object = DataGridView2.Rows(i).Cells(0).Value
            lblloading.Text = If(cellValue IsNot Nothing, cellValue.ToString(), "No Data")

            Dim cellValue2 As Object = DataGridView2.Rows(i).Cells(4).Value
            Dim ip As String = If(cellValue2 IsNot Nothing, cellValue2.ToString(), "0.0.0.0")
            Dim cellValue3 As Object = DataGridView2.Rows(i).Cells(0).Value
            Dim toko As String = If(cellValue3 IsNot Nothing, cellValue3.ToString(), "No Data")
            Dim cellValue4 As Object = DataGridView2.Rows(i).Cells(1).Value
            Dim gudang As String = If(cellValue4 IsNot Nothing, cellValue4.ToString(), "No Data")
            Dim cellValue5 As Object = DataGridView2.Rows(i).Cells(5).Value
            IDD = If(cellValue5 IsNot Nothing, cellValue5.ToString(), "No Data")

            Try
                lblloading.Text = "PING -> " & ip
                If Fungsi.CekKoneksi(ip) Then
                    If koneksitoko(ip) Then
                        Try
                            lblloading.Text = toko & " -> KONEK KE TOKO"
                            Dim sql As String = "SELECT CONCAT(TIMESTAMPDIFF(MINUTE, `Tgl`, NOW()), ' | ', `LOG`) AS DiffLog FROM posrt_tracelog WHERE DATE(tgl)=CURDATE() AND `log` LIKE '%SendTableOK%' OR LOG LIKE '%Unable to connect%' OR LOG LIKE '%The underlying connection%' OR LOG LIKE '%The operation has timed out%' OR LOG LIKE '%Kirim data mutasi & stock DIHENTIKAN%' OR LOG LIKE '%Kirim data mutasi & stock sudah BERJALAN kembali%' ORDER BY idtracelog DESC LIMIT 1"
                            Dim cmd As MySqlCommand = New MySqlCommand(sql, contok)
                            Dim difflog As String = ""
                            difflog = cmd.ExecuteScalar
                            If difflog.Contains("Kirim data mutasi & stock DIHENTIKAN. Sedang ada proses HITUNG ULANG") Then
                                Dim sqlb As String = "update const set docno=0,rdocno=0 where rkey='hum'"
                                Dim cmdb As MySqlCommand = New MySqlCommand(sqlb, contok)
                                cmdb.ExecuteNonQuery()
                                logs(IDD, "UPD HUM OK | " & difflog, toko, gudang)
                                lblloading.Text = toko & " -> UPD HUM OK"
                            ElseIf difflog.Contains("Kirim data mutasi & stock DIHENTIKAN. Sedang ada proses TUTUP HARIAN") Then
                                Dim sqlb1 As String = "update const set docno=0,rdocno=0 where rkey='ttp'"
                                Dim cmdb1 As MySqlCommand = New MySqlCommand(sqlb1, contok)
                                cmdb1.ExecuteNonQuery()
                                logs(IDD, "UPD TTP OK | " & difflog, toko, gudang)
                                lblloading.Text = toko & " -> UPD TTP OK"
                            Else
                                lblloading.Text = toko & " -> INSERT LOGS"
                                logs(IDD, difflog, toko, gudang)
                            End If
                            contok.Close()
                        Catch ex As Exception
                            lblloading.Text = toko & " -> ERROR"
                            logs(IDD, ex.Message, toko, gudang)
                        End Try
                    Else
                        lblloading.Text = toko & " -> TIDAK KONEK SQL"
                        logs(IDD, "TIDAK KONEK SQL", toko, gudang)
                    End If
                Else
                    lblloading.Text = toko & " -> KONEKSI NOK"
                    logs(IDD, "KONEKSI NOK", toko, gudang)
                End If
            Catch ex As Exception

            End Try
            Threading.Thread.Sleep(100)
        Next
        Try
            koneklokal2()
            Dim sqlc As String = "UPDATE POSRT SET `STATUS`=1 WHERE CONCAT('ID',REPLACE(REPLACE(REPLACE(CUT_OFF,':',''),' ',''),'-',''))='" & IDD & "'"
            Dim cmdc As MySqlCommand = New MySqlCommand(sqlc, con)
            cmdc.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        GetNok()
    End Sub
    Private Sub logs(id As String, ket As String, toko As String, cab As String)
        Try
            koneklokal2()
            Dim sqlq As String = "UPDATE POSRT SET `LOGS`='" & ket & "',`status`='1' where kodegudang='" & cab & "' and toko='" & toko & "' and CONCAT('ID',REPLACE(REPLACE(REPLACE(CUT_OFF,':',''),' ',''),'-',''))='" & id & "'"
            'Dim sql As String = "REPLACE INTO POSRT_CEK (ID,TOKO,CAB,KETERANGAN)"
            'sql += "values ('" & id & "','" & toko & "','" & cab & "','" & ket & "')"
            Dim cmd As MySqlCommand = New MySqlCommand(sqlq, con)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Close()
        End Try
    End Sub


    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        proses()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub
End Class