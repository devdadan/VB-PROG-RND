Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Net
Imports System.Threading.Tasks
Imports System.Text.RegularExpressions
Public Class FrmTembak
    Dim jenistoko, listcabang, jenisstation As String
    Dim hostName As String = Dns.GetHostName()
    Dim NameHost As String = Replace(hostName, "-", "_")
    Dim hostEntry As IPHostEntry = Dns.GetHostEntry(hostName)
    Dim tokomain As String = Application.StartupPath + "\tokomain_sql.ini"
    Dim namatable = NameHost.ToString + "_IP_SQL"
    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
    Private Sub bukacabang()
        cb_cabang.SelectedIndex = -1
        konek()
        Try
            Dim dts As DataTable = New DataTable
            sql = "SELECT * FROM MASTER_CABANG ORDER BY KODE_CAB"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dts)
            Dim newRow As DataRow = dts.NewRow()
            newRow("KODE_CAB") = "SEMUA CABANG"
            newRow("NAMA_CAB") = "SEMUA CABANG"
            dts.Rows.Add(newRow)

            If dts IsNot Nothing AndAlso dts.Rows.Count > 0 Then
                cb_cabang.DataSource = dts
                cb_cabang.DisplayMember = "KODE_CAB"
                cb_cabang.ValueMember = "KODE_CAB"

            Else
                MsgBox("No data found in the master_cabang table.")
            End If
            con.Close()

        Catch ex As Exception
            ClsApps.sqllog("bukacabang :" + ex.Message)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Private Sub FrmTembak_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LinkLabel1.Visible = False
        bukacabang()
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        ambilpass()
        If File.Exists(Application.StartupPath + "\Tembaksql.tmp") Then
            If ClsApps.msg("tanya", "Ada report yang belum terproses, proses sekarang?", False, 60) Then
                If Buathasil() Then
                    ClsApps.msg("success", "Data berhasil diproses", False, 60)
                Else
                    ClsApps.msg("warning", "Data gagal diproses", False, 60)
                End If
            End If
        End If

    End Sub

    Private Sub cb_cabang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_cabang.SelectedIndexChanged

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If File.Exists(tokomain) Then
            Process.Start(tokomain)
        Else
            ClsApps.msg("exclaimer", "FILE tokomain_sql.ini TIDAK ADA!", True, 60)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If cb_cabang.Text = "" Or cb_station.Text = "" Then
            ClsApps.msg("exclaimer", "Mohon lengkapi data!", True, 60)
        Else
            Button3.Enabled = False
            Button3.Text = "LOADING.."
            loadtoko()
            Button3.Enabled = True
            Button3.Text = "LOAD TOKO"
        End If
    End Sub

    Private Sub cb_jenistoko_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_jenistoko.SelectedIndexChanged
        If cb_jenistoko.Text = "BEBERAPA TOKO" Then
            LinkLabel1.Visible = True
        Else
            LinkLabel1.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If q1.Text = "" Then
            ClsApps.msg("exclaimer", "mohon isi text query", True, 60)
        Else
            If dg_listoko.Rows.Count > 0 Then
                BackgroundWorker1.RunWorkerAsync()
            End If

        End If
    End Sub
    Private Sub kirim()
        Button1.Enabled = False
        Button3.Enabled = False
        Dim query1 As String
        Dim flag1 As Boolean = False
        Dim flag2 As Boolean = False
        Dim flag3 As Boolean = False
        Dim db As String
        db = cb_station.Text
        If q1.Text <> "" Then
            query1 = q1.Text
            flag1 = True
        End If

        Dim bacasintak, flagsintak As String
        bacasintak = Microsoft.VisualBasic.Left(query1.ToUpper, 6)
        If bacasintak = "UPDATE" Or bacasintak = "INSERT" Or bacasintak = "DELETE" Or bacasintak = "CREATE" Or bacasintak = "DROP " Then
            flagsintak = "execute"
        ElseIf bacasintak = "SELECT" Or bacasintak = "select" Or bacasintak = "Select" Then
            flagsintak = "reader"
        Else
            ClsApps.msg("exclaimer", "Target sintak tidak diketahui", True, 60)
            Me.Close()
        End If

        If ClsApps.msg("tanya", "Akan eksekusi sintak berikut ?" & vbCrLf & query1, False, 60) Then
            Dim filetmp As String = Application.StartupPath + "\Tembaksql.tmp"
            Dim duascript As Boolean = False
            Dim datasc As String() = query1.Split(";"c)

            Try
                Parallel.ForEach(dg_listoko.Rows.Cast(Of DataGridViewRow)().ToList(), Sub(row, loopState, rowIndex)
                                                                                          Try

                                                                                              Dim gdg As String = row.Cells(0).Value.ToString
                                                                                              ClsApps.Tulislog(gdg)
                                                                                              Dim toko As String = row.Cells(1).Value.ToString
                                                                                              ClsApps.Tulislog(gdg)
                                                                                              Dim nama As String = row.Cells(2).Value.ToString
                                                                                              ClsApps.Tulislog(gdg)
                                                                                              Dim ip As String = row.Cells(4).Value.ToString
                                                                                              ClsApps.Tulislog(gdg)
                                                                                              Dim datatampung As DataTable = New DataTable
                                                                                              Me.Invoke(Sub()
                                                                                                            Button1.Text = toko + " - " + nama
                                                                                                            lbljmltoko.Text -= 1
                                                                                                        End Sub)

                                                                                              If ClsApps.CekKoneksi(ip) Then
                                                                                                  row.Cells(5).Value = "OK"
                                                                                                  If ClsApps.TembakSQL3(ip, db, flagsintak, query1, datatampung, gdg, nama, toko) Then
                                                                                                      row.Cells(6).Value = "SUKSES"
                                                                                                  Else
                                                                                                      row.Cells(6).Value = "GAGAL"
                                                                                                  End If


                                                                                              Else
                                                                                                  Me.Invoke(Sub()
                                                                                                                row.Cells(5).Value = "NOK"
                                                                                                                row.Cells(6).Value = "GAGAL"
                                                                                                                ClsApps.WriteToFile($"{gdg}|{toko}|{nama}|KONEKSI NOK", filetmp)

                                                                                                            End Sub)
                                                                                              End If
                                                                                          Catch ex As Exception
                                                                                              Me.Invoke(Sub()
                                                                                                            row.Cells(6).Value = "ERROR"
                                                                                                            ClsApps.WriteToFile($"Error on {rowIndex} - {ex.Message}", filetmp)
                                                                                                        End Sub)
                                                                                          End Try


                                                                                      End Sub)
                Application.DoEvents()
                If Buathasil() Then
                Else
                    If ClsApps.msg("tanya", "Gagal buat file report, ulang proses?", False, 60) Then
                        Buathasil()
                    End If

                End If

            Catch ex As Exception

                MsgBox(ex.Message)
            Finally
                Button1.Enabled = True
                Button3.Enabled = True
                Button1.Text = "PROSES"
                MessageBox.Show("Selesai proses data")
            End Try
        Else
            ClsApps.msg("exclaimer", "Oke sir!", True, 10)
        End If

    End Sub
    Private Sub dg_listoko_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dg_listoko.DataError
        ClsApps.Tulislog("Kesalahan dalam memproses data: " & e.Exception.Message)
    End Sub
    Private Function Buathasil() As Boolean
        Dim id As String = ""
        id = Application.StartupPath + "\Data\SQL_" & ClsApps.BuatID.ToString & ".txt"
        Dim result As Boolean = False
        Try
            Dim namafile1 As String = ""
            Dim namafile2 As String = ""
            namafile1 = Application.StartupPath + "\Tembaksql.tmp"
            namafile2 = id
            If File.Exists(Application.StartupPath + "\Tembaksql.tmp") Then
                File.Move(namafile1, namafile2)
            End If
            ClsApps.sqllog("Move file " & namafile1 & "ke " & namafile2)
            result = True
            File.Delete(namafile1)
        Catch ex As Exception
            result = False
            ClsApps.sqllog(ex.Message)
        End Try
        Return result
    End Function

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        kirim()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        FrmDATA.ShowDialog()
    End Sub

    Private Sub loadtoko()
        If Not File.Exists(tokomain) Then
            MsgBox("FILE TOKOMAIN TIDAK DITEMUKAN" + vbCrLf + "HARAP PASTIKAN FILE ADA!", MsgBoxStyle.Critical)
        Else
            konek()
            sql = "CREATE TABLE IF NOT EXISTS " + namatable
            sql += "(`TOKO` varchar(4) DEFAULT NULL,`STATUS` varchar(20) DEFAULT NULL) ENGINE=InnoDB DEFAULT CHARSET=latin1"
            cmd = New MySqlCommand(sql, con)
            cmd.ExecuteNonQuery()

            If cb_jenistoko.Text = "BEBERAPA TOKO" Then

                sql = "delete from " + namatable
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()

                sql = "load data local infile """ + Replace(tokomain, "\", "\\") + """ into table " + namatable + " ignore 1 lines"
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()
            End If
            Try
                jenistoko = ""
                jenisstation = ""

                If cb_cabang.Text = "SEMUA CABANG" Then
                    listcabang = ""
                Else
                    listcabang = "and cabang='" + cb_cabang.Text + "'"
                End If
                If cb_station.Text = "POS" Then
                    jenisstation = "station=1"
                Else
                    jenisstation = "station='I1'"
                End If
                If cb_jenistoko.Text = "SEMUA TOKO" Then
                    jenistoko = " " & listcabang
                ElseIf cb_jenistoko.Text = "SEMUA TOKO FRC" Then
                    jenistoko = "And toko Like 'F%' " & listcabang
                ElseIf cb_jenistoko.Text = "SEMUA TOKO REG" Then
                    jenistoko = "and toko like 'T%' " & listcabang
                ElseIf cb_jenistoko.Text = "SEMUA TOKO CRM" Then
                    jenistoko = "and toko like 'R%' " & listcabang
                ElseIf cb_jenistoko.Text = "SEMUA TOKO SIMULASI" Then
                    jenistoko = "and toko in(SELECT kd_toko FROM simulasi.table_toko WHERE sim=1) " & listcabang
                Else

                    jenistoko = "and toko in(select toko from " + namatable + ") " & listcabang
                End If

                Dim dt As DataTable = New DataTable
                dt.Clear()
                dg_listoko.Columns.Clear()
                sql = "SELECT CABANG,TOKO,NAMA,STATION,IP AS IPHOST,'' KONEKSI,'' AS `STATUS` FROM m_ip WHERE " + jenisstation + " " + jenistoko + " and station=1"
                da = New MySqlDataAdapter(sql, con)
                da.Fill(dt)
                dg_listoko.DataSource = dt
                settcolumn()
                lbljmltoko.Text = dg_listoko.Rows.Count
                MsgBox("Data ditampilkan", MsgBoxStyle.Information)
                ClsApps.sqllog(sql)
            Catch ex As Exception
                ClsApps.sqllog(sql)

                MsgBox(ex.Message)

            End Try
        End If
    End Sub
    Private Sub settcolumn()
        dg_listoko.Columns(0).Name = "col0"
        dg_listoko.Columns(1).Name = "col1"
        dg_listoko.Columns(2).Name = "col2"
        dg_listoko.Columns(3).Name = "col3"
        dg_listoko.Columns(4).Name = "col4"
        dg_listoko.Columns(5).Name = "col5"
        dg_listoko.Columns(6).Name = "col6"

        dg_listoko.Columns(0).Width = 80
        dg_listoko.Columns(1).Width = 80
        dg_listoko.Columns(2).Width = 220
        dg_listoko.Columns(3).Width = 120
        dg_listoko.Columns(4).Width = 100
        dg_listoko.Columns(5).Width = 200
        dg_listoko.Columns(6).Width = 200

    End Sub
End Class