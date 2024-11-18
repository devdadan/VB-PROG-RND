Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Net
Imports System.Diagnostics
Imports System.Threading.Tasks
Imports Newtonsoft.Json
Imports System.Threading

Public Class UCTembakSQL
    Dim jenistoko, listcabang, jenisstation As String
    Dim hostName As String = Dns.GetHostName()
    Dim NameHost As String = Replace(hostName, "-", "_")
    Dim hostEntry As IPHostEntry = Dns.GetHostEntry(hostName)
    Dim tokomain As String = Application.StartupPath + "\tokomain_sql.ini"
    Dim namatable = NameHost.ToString + "_IP_SQL"
    Private Sub TableLayoutPanel2_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel2.Paint

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

    Private Sub UCTembakSQL_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TabPage2.Visible = False
        PictureBox1.Visible = False
        Label6.Visible = False
        lbltox.Visible = False
        bukacabang()
        buatfiletoko()
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False

    End Sub
    Private Sub loadtoko()
        If Not File.Exists(tokomain) Then
            MsgBox("FILE TOKOMAIN TIDAK DITEMUKAN" + vbCrLf + "HARAP PASTIKAN FILE ADA!", MsgBoxStyle.Critical)
        Else
            konek()
            btn_load.Enabled = False
            sql = "CREATE TABLE IF NOT EXISTS " + namatable
            sql += "(`TOKO` varchar(4) DEFAULT NULL,`STATUS` varchar(20) DEFAULT NULL) ENGINE=InnoDB DEFAULT CHARSET=latin1"
            cmd = New MySqlCommand(sql, con)
            cmd.ExecuteNonQuery()

            If Cb_jenistoko.Text = "SOME STORES" Then

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
                    jenisstation = "is_induk=1"
                Else
                    jenisstation = "station='I1'"
                End If
                If Cb_jenistoko.Text = "ALL TOKO" Then
                    jenistoko = " " & listcabang
                ElseIf Cb_jenistoko.Text = "ALL TOKO FRC" Then
                    jenistoko = "And toko Like 'F%' " & listcabang
                ElseIf Cb_jenistoko.Text = "ALL TOKO REG" Then
                    jenistoko = "and toko like 'T%' " & listcabang
                ElseIf Cb_jenistoko.Text = "ALL TOKO CRM" Then
                    jenistoko = "and toko like 'R%' " & listcabang
                ElseIf Cb_jenistoko.Text = "ALL TOKO SIMULASI" Then
                    jenistoko = "and toko in(SELECT kd_toko FROM simulasi.table_toko WHERE sim=1) " & listcabang
                Else

                    jenistoko = "and toko in(select toko from " + namatable + ") " & listcabang
                End If

                Dim dt As DataTable = New DataTable
                dt.Clear()
                dg_listoko.Columns.Clear()
                sql = "SELECT CABANG,TOKO,NAMA,STATION,IP AS IPHOST,'' AS `STATUS` FROM bck_m_ip WHERE " + jenisstation + " " + jenistoko
                da = New MySqlDataAdapter(sql, con)
                da.Fill(dt)
                dg_listoko.DataSource = dt
                settcolumn()
                lbljmltoko.Text = dg_listoko.Rows.Count
                btn_load.Enabled = True
                MsgBox("Data ditampilkan", MsgBoxStyle.Information)
                ClsApps.sqllog(sql)
            Catch ex As Exception
                ClsApps.sqllog(sql)
                btn_load.Enabled = True
                btn_load.Text = "Selesai load data .."
                btn_load.Text = "LOAD"
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




        dg_listoko.Columns(0).Width = 80
        dg_listoko.Columns(1).Width = 80
        dg_listoko.Columns(2).Width = 220
        dg_listoko.Columns(3).Width = 120
        dg_listoko.Columns(4).Width = 100
        dg_listoko.Columns(5).Width = 200




    End Sub
    Private Sub Cb_jenistoko_SelectedValueChanged(sender As Object, e As EventArgs) Handles Cb_jenistoko.SelectedValueChanged
        If Cb_jenistoko.Text = "SOME STORES" Then
            LinkLabel1.Visible = True
        Else
            LinkLabel1.Visible = False
        End If
    End Sub

    Private Sub btn_load_Click(sender As Object, e As EventArgs) Handles btn_load.Click
        If cb_cabang.Text = "" Or cb_station.Text = "" Or Cb_jenistoko.Text = "" Then
            ClsApps.msg("exclaimer", "Mohon lengkapi data!", True, 60)
        Else
            btn_load.Text = "Sedang load data .."
            loadtoko()
            btn_load.Text = "Selesai load data .."
            btn_load.Text = "LOAD"
        End If

    End Sub


    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If File.Exists(tokomain) Then
            Process.Start(tokomain)
        Else
            ClsApps.msg("exclaimer", "FILE tokomain_sql.ini TIDAK ADA!", True, 60)

        End If
    End Sub


    Private Sub btn_proses_Click(sender As Object, e As EventArgs) Handles btn_proses.Click
        If lbljmltoko.Text = 0 Then
            ClsApps.msg("warning", "Mohon load data dulu!", True, 60)
        Else
            If txt_sql.Text = "" Then
                ClsApps.msg("exclaimer", "Mohon isi textbox script sql!", True, 60)
            Else
                If Not BackgroundWorker1.IsBusy Then
                    BackgroundWorker1.RunWorkerAsync()
                End If
            End If

        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        proses()
    End Sub

    Private Sub buatfiletoko()
        If Not File.Exists(tokomain) Then
            Using writer As StreamWriter = New StreamWriter(tokomain)
                writer.WriteLine("TOKO")
            End Using
        End If
    End Sub

    Private Sub tutupfungsi()
        txt_sql.Enabled = False
        btn_load.Enabled = False
        btn_proses.Enabled = False
        cb_cabang.Enabled = False
        cb_station.Enabled = False
        Cb_jenistoko.Enabled = False
    End Sub
    Private Sub bukafungsi()
        txt_sql.Enabled = True
        btn_load.Enabled = True
        btn_proses.Enabled = True
        cb_cabang.Enabled = True
        cb_station.Enabled = True
        Cb_jenistoko.Enabled = True
    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click
        TreeView1.Nodes.Clear()
        Dim path As String = Application.StartupPath + "\Data\"
        Dim selecteddirectory As String = path
        Dim rootnode As New TreeNode(selecteddirectory)
        TreeView1.Nodes.Add(rootnode)
        PopulateTreeView(selecteddirectory, rootnode)
    End Sub
    Private Sub PopulateTreeView(directoryPath As String, parentNode As TreeNode)
        Dim sqlFiles As String() = Directory.GetFiles(directoryPath, "SQL_*.txt")
        For Each sqlFile As String In sqlFiles
            Dim fileInfo As New FileInfo(sqlFile)
            Dim fileNode As New TreeNode($"{Path.GetFileName(sqlFile)} - {fileInfo.LastWriteTime.ToString("HH:mm:ss")}")
            parentNode.Nodes.Add(fileNode)
        Next

        Dim directories As String() = Directory.GetDirectories(directoryPath)
        For Each directory As String In directories
            Dim directoryNode As New TreeNode(Path.GetFileName(directory))
            parentNode.Nodes.Add(directoryNode)
            PopulateTreeView(directory, directoryNode)
        Next
    End Sub

    Private cancellationTokenSource As CancellationTokenSource
    Private Sub proses()
        Try

            PictureBox1.Visible = True
            Label6.Visible = True
            lbltox.Visible = True
            konek()
            tutupfungsi()
            btn_proses.Text = "Loading .."
            Dim db As String = ""
            Dim flagsintak As String = ""
            Dim bacasintak As String = ""
            Dim query As String = ""
            query = txt_sql.Text.ToUpper
            bacasintak = Microsoft.VisualBasic.Left(txt_sql.Text, 6)
            If bacasintak = "UPDATE" Or bacasintak = "INSERT" Or bacasintak = "DELETE" Then
                flagsintak = "execute"
            ElseIf bacasintak = "SELECT" Or bacasintak = "select" Or bacasintak = "Select" Then
                flagsintak = "reader"
            Else
                ClsApps.msg("exclaimer", "Target sintak tidak diketahui", True, 60)
            End If
            If cb_station.Text = "POS" Then
                db = "POS"
            Else
                db = "IKIOSKTERMINAL"
            End If
            sql = "CREATE TABLE if not exists `sql_data` (
          `ID` varchar(100) DEFAULT NULL,
          `TANGGAL` date DEFAULT NULL,
          `USER` varchar(50) DEFAULT NULL,
          `PARTISIPAN` varchar(4) DEFAULT NULL,
          `TOKO` text,
          `IP` varchar(20) DEFAULT NULL,
          `QUERY` text,
          `ADDTIME` datetime DEFAULT NULL
        ) ENGINE=InnoDB DEFAULT CHARSET=latin1"
            Dim cmd0 As MySqlCommand = New MySqlCommand(sql, con)
            cmd0.ExecuteNonQuery()
            Dim partisipan As String = Cb_jenistoko.Text
            Dim id As String = ""
            id = ClsApps.BuatID.ToString
            Dim idproses As String = id

            Dim user As String = ""
            user = userlogin
            'Dim sql1 As String = "INSERT INTO SQL_DATA (`ID`,TANGGAL,`USER`,PARTISIPAN,TOKO,IP,QUERY,ADDTIME) SELECT '" + idproses + "' as id,now(),"
            'sql1 += user + " AS  `USER`,'" & partisipan & "',(SELECT GROUP_CONCAT(DISTINCT TOKO ORDER BY TOKO ASC SEPARATOR ',') FROM bck_m_ip WHERE " + jenisstation + " " + jenistoko + ") AS TOKO,"
            'sql1 += "'" & hostName.ToString & "',""" & txt_sql.Text & """,now() as addtime"
            'ClsApps.Tulislog(sql1)
            'Dim cmd1 As MySqlCommand = New MySqlCommand(sql1, con)
            'cmd1.ExecuteNonQuery()
            'cmd1.Dispose()
            ClsApps.Tulislog("Proses untuk laporan id " & idproses)
            Dim datatampung As DataTable = New DataTable
            Dim isFirstOperation As Boolean = True
            Dim lockObject As New Object()
            Dim dtx As DataTable = New DataTable
            DataGridView1.DataSource = Nothing
            DataGridView1.Enabled = True
            Parallel.ForEach(dg_listoko.Rows.Cast(Of DataGridViewRow)(), Sub(row, loopState, rowIndex)
                                                                             Dim isFirst As Boolean
                                                                             SyncLock lockObject
                                                                                 isFirst = isFirstOperation

                                                                                 isFirstOperation = False
                                                                             End SyncLock
                                                                             Dim gdg As String = row.Cells(0).Value.ToString
                                                                             Dim toko As String = row.Cells(1).Value.ToString
                                                                             Dim nama As String = row.Cells(2).Value.ToString
                                                                             Dim ip As String = row.Cells(4).Value.ToString
                                                                             datatampung.Clear()
                                                                             If ClsApps.CekKoneksi(ip) Then
                                                                                 Try
                                                                                     Dim con1 As MySqlConnection
                                                                                     Dim cmd12 As MySqlCommand
                                                                                     Dim host As String = ""
                                                                                     Dim host2 As String = ""
                                                                                     Dim host3 As String = ""
                                                                                     If db = "POS" Then
                                                                                         host = "server=" + ip + ";uid=root;pwd=" + passtok + ";database=" + db + ";Pooling=False;Connection Timeout=120;"
                                                                                         host2 = "server=" + ip + ";uid=root;pwd=" + passtok2 + ";database=" + db + ";Pooling=False;Connection Timeout=120;"
                                                                                         host3 = "server=" + ip + ";uid=root;pwd=" + passtok3 + ";database=" + db + ";Pooling=False;Connection Timeout=120;"

                                                                                     Else
                                                                                         host = "server=" + ip + ";uid=ikiosk;pwd=indomaret;database=ikioskterminal;Pooling=False;Connection Timeout=120;"
                                                                                     End If

                                                                                     Try
                                                                                         con1 = New MySqlConnection(host)
                                                                                         con1.Open()
                                                                                     Catch ex As Exception
                                                                                         Try
                                                                                             con1 = New MySqlConnection(host2)
                                                                                             con1.Open()
                                                                                         Catch exx As Exception
                                                                                             con1 = New MySqlConnection(host3)
                                                                                             con1.Open()
                                                                                         End Try
                                                                                     End Try


                                                                                     If flagsintak = "execute" Then
                                                                                         Dim cmd1 As MySqlCommand
                                                                                         Dim sqlb As String = query
                                                                                         cmd1 = New MySqlCommand(sqlb, con1)
                                                                                         Dim resultexe As Integer = cmd1.ExecuteNonQuery()
                                                                                         con1.Close()
                                                                                         cmd1.Dispose()
                                                                                         DataGridView1.Rows.Add(gdg.ToString, toko.ToString, nama.ToString, resultexe)
                                                                                     Else
                                                                                         Dim sql2 As String = query
                                                                                         Dim da1 As MySqlDataAdapter = New MySqlDataAdapter(sql2, con1)
                                                                                         da1.Fill(dtx)
                                                                                         DataGridView1.DataSource = dtx
                                                                                     End If
                                                                                 Catch ex As Exception
                                                                                     ClsApps.Tulislog(toko + " : PASS SQL TIDAK SESUAI")
                                                                                 End Try

                                                                             Else
                                                                                 ClsApps.Tulislog(toko + " : TIDAK KONEK")
                                                                             End If

                                                                             Me.Invoke(Sub()
                                                                                           Dim progressPercentage As Integer = CInt((rowIndex + 1) * 100 / dg_listoko.Rows.Count)
                                                                                           btn_proses.Text = progressPercentage.ToString() & "%"
                                                                                           lbltox.Text = toko & "-" & nama
                                                                                       End Sub)
                                                                         End Sub)

            Application.DoEvents()
            'If Buathasil() Then
            bukafungsi()
            btn_proses.Text = "Selesai"
            btn_proses.Text = "PROSES"
            ClsApps.msg("success", "Selesai proses", False, 60)
        Catch ex As Exception
            bukafungsi()
            MsgBox(ex.Message)
        Finally
            btn_proses.Enabled = True
            btn_proses.Text = "PROSES"

        End Try
        PictureBox1.Visible = False
        Label6.Visible = False
        lbltox.Visible = False

    End Sub
    Private Function UpdateRow(toko As String, id As String, result As String, status As String) As Boolean
        Dim success As Boolean = False
        Try
            Dim updateSql As String = "UPDATE sql_data SET status=@status, hasil=@result, addtime=NOW() WHERE toko=@toko AND id=@id"
            Using cmd As New MySqlCommand(updateSql, con)
                cmd.Parameters.AddWithValue("@status", status)
                cmd.Parameters.AddWithValue("@result", result)
                cmd.Parameters.AddWithValue("@toko", toko)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.ExecuteNonQuery()
            End Using
            success = True
        Catch ex As Exception
            success = False
            LogAndUpdateError(toko, id, ex)
        End Try
        Return success
    End Function

    Private Sub LogAndUpdateError(toko As String, id As String, ex As Exception)
        Try
            Dim errorMessage As String = "GAGAL: " & ex.Message
            Dim logUpdateSql As String = "UPDATE sql_data SET status='GAGAL', hasil=@errorMessage WHERE toko=@toko AND id=@id"
            Using cmd As New MySqlCommand(logUpdateSql, con)
                cmd.Parameters.AddWithValue("@errorMessage", errorMessage)
                cmd.Parameters.AddWithValue("@toko", toko)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.ExecuteNonQuery()
            End Using
            ClsApps.Tulislog("Execute update error: " & ex.Message)
        Catch logEx As Exception
            ' Log the log exception if necessary
        End Try
    End Sub



    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        Dim activeTabIndex As Integer = TabControl1.SelectedIndex
        Select Case activeTabIndex
            Case 0
                Label5.Visible = True
                lbljmltoko.Visible = True
            Case 1
                Label5.Visible = False
                lbljmltoko.Visible = False
                buatreport()
        End Select
    End Sub
    Private Sub buatreport()
        TreeView1.Nodes.Clear()
        Dim path As String = Application.StartupPath + "\Data\"
        Dim selecteddirectory As String = path
        Dim rootNode As New TreeNode($"{DateTime.Now.ToString("yyyy-MM-dd")}")
        TreeView1.Nodes.Add(rootNode)
        PopulateTreeView(selecteddirectory, rootNode)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Clipboard.SetText(RichTextBox1.Text)
            Dim toolTip As New ToolTip()
            toolTip.Show("Text copied to clipboard.", Button2, 0, -30, 2000)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub Cb_jenistoko_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_jenistoko.SelectedIndexChanged

    End Sub

    Private Sub cb_cabang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_cabang.SelectedIndexChanged

    End Sub

    Private Sub TreeView1_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseClick
        If e.Node.Parent IsNot Nothing Then
            Dim fileName As String = e.Node.Text.Split("-"c)(0).Trim()
            Dim filepath As String = Application.StartupPath + "\Data\" + fileName
            Dim fileContent As String = File.ReadAllText(filepath)
            RichTextBox1.Text = fileContent
        End If
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
End Class