Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Net
Imports System.Diagnostics
Imports System.Threading.Tasks

Public Class UCDelete
    Dim namafolder, jenistoko As String
    Dim hostName As String = Dns.GetHostName()
    Dim NameHost As String = Replace(hostName, "-", "_")
    Dim hostEntry As IPHostEntry = Dns.GetHostEntry(hostName)
    Dim tokomain As String = Application.StartupPath + "\tokomain_del.ini"
    Dim namatable = NameHost.ToUpper + "_IP_DELETE"
    Dim fproses As Boolean = False
    Public Event UserControlClosed As EventHandler
    Dim fdown As Boolean = False
    Private Sub btn_load_Click(sender As Object, e As EventArgs) Handles btn_load.Click
        If Cb_jenistoko.Text = "" Then
            MsgBox("MOHON ISI FORM DENGAN LENGKAP!", MsgBoxStyle.Critical)
        Else
            loadtoko()
        End If
    End Sub
    Private Sub loadtoko()
        If Not File.Exists(tokomain) Then
            MsgBox("FILE TOKOMAIN TIDAK DITEMUKAN" + vbCrLf + "HARAP PASTIKAN FILE ADA!", MsgBoxStyle.Critical)
        Else
            konek()
            Try
                btn_load.Enabled = False

                sql = "CREATE TABLE IF NOT EXISTS " + namatable
                sql += "(`TOKO` varchar(4) DEFAULT NULL,`STATUS` varchar(20) DEFAULT NULL) ENGINE=InnoDB DEFAULT CHARSET=latin1"
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()

                sql = "delete from " + namatable
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()

                sql = "load data local infile """ + Replace(tokomain, "\", "\\") + """ into table " + namatable + " ignore 1 lines"
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()
                Dim dt As DataTable = New DataTable
                dt.Clear()
                dg_listoko.Columns.Clear()

                sql = "SELECT CABANG,TOKO,NAMA,STATION,IP AS IPHOST,'' AS `STATUS` FROM m_ip WHERE STATION='STB' " + jenistoko
                da = New MySqlDataAdapter(sql, con)
                da.Fill(dt)
                dg_listoko.DataSource = dt
                settcolumn()
                lbljmltoko.Text = dg_listoko.Rows.Count
                btn_load.Enabled = True
                MsgBox("Data ditampilkan", MsgBoxStyle.Information)
            Catch ex As Exception
                btn_load.Enabled = True
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

        dg_listoko.Columns(0).Width = 100
        dg_listoko.Columns(1).Width = 100
        dg_listoko.Columns(2).Width = 330
        dg_listoko.Columns(3).Width = 100
        dg_listoko.Columns(4).Width = 150
        dg_listoko.Columns(5).Width = 100
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If Not File.Exists(tokomain) Then
            Dim fileStream As FileStream = File.Create(tokomain)
            fileStream.Close()
        End If
        Process.Start(tokomain)
    End Sub

    Private Sub Cb_jenistoko_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_jenistoko.SelectedIndexChanged
        If Cb_jenistoko.Text <> "" Then
            If Cb_jenistoko.Text = "ALL TOKO" Then
                jenistoko = ""
            ElseIf Cb_jenistoko.Text = "ALL TOKO FRC" Then
                jenistoko = "And toko Like 'F%'"
            ElseIf Cb_jenistoko.Text = "ALL TOKO REG" Then
                jenistoko = "and toko like 'T%'"
            ElseIf Cb_jenistoko.Text = "ALL TOKO CRM" Then
                jenistoko = "and toko like 'R%'"
            ElseIf Cb_jenistoko.Text = "ALL TOKO SIMULASI" Then
                jenistoko = "and toko in(SELECT kd_toko FROM simulasi.table_toko WHERE sim=1)"
            Else

                jenistoko = "and toko in(select toko from " + namatable + ")"
            End If
        End If
    End Sub

    Private Sub btn_proses_Click(sender As Object, e As EventArgs) Handles btn_proses.Click
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            btn_proses.Enabled = False
            fproses = True
            btn_proses.Text = "Loading .."
            Dim user As String
            Dim pass As String
            user = "posterm"
            pass = "dAZAD9yq"
            Dim flagcek As Boolean = False

            If CheckBox1.Checked = True Then
                flagcek = True
            Else
                flagcek = False
            End If
            Parallel.ForEach(dg_listoko.Rows.Cast(Of DataGridViewRow)(), Sub(row, loopState, rowIndex)
                                                                             Dim host As String = row.Cells(4).Value.ToString
                                                                             If ClsApps.CekKoneksi(host) Then
                                                                                 Dim flag1 As Boolean = False
                                                                                 Dim resultcek As Integer = 0
                                                                                 If txt_zipfile.Text = "*.*" Or txt_zipfile.Text = "*" Then
                                                                                     If flagcek Then
                                                                                         resultcek = ClsApps.FtpCheckAllFiles("ftp://" + host + "/", user, pass, txt_folderstb.Text)
                                                                                     Else
                                                                                         flag1 = ClsApps.FtpDeleteAllFiles("ftp://" + host + "/", user, pass, txt_folderstb.Text)
                                                                                     End If

                                                                                 Else
                                                                                     flag1 = ClsApps.FtpDeleteFile("ftp://" + host + "/", user, pass, txt_folderstb.Text + "/" + txt_zipfile.Text)

                                                                                 End If
                                                                                 If flagcek Then
                                                                                     row.Cells("col5").Value = resultcek.ToString
                                                                                 Else
                                                                                     If flag1 Then
                                                                                         row.Cells("col5").Value = "SUKSES"
                                                                                     Else
                                                                                         row.Cells("col5").Value = "GAGAL"
                                                                                     End If
                                                                                 End If

                                                                             Else
                                                                                 row.Cells("col5").Value = "KONEKSI NOK"
                                                                             End If
                                                                             Me.Invoke(Sub()
                                                                                           Dim progressPercentage As Integer = CInt((rowIndex + 1) * 100 / dg_listoko.Rows.Count)
                                                                                           btn_proses.Text = progressPercentage.ToString() & "%"
                                                                                       End Sub)

                                                                         End Sub)


            Application.DoEvents()
            btn_proses.Text = "Selesai"
            MsgBox("Selesai")
            btn_proses.Enabled = True
            btn_proses.Text = "PROSES"
            fproses = False
            fdown = True
            ClsApps.BuatHistory("DELETE", "BERHASIL", txt_zipfile.Text, lbljmltoko.Text)
        Catch ex As Exception
            ClsApps.sqllog(ex.Message + vbCrLf + ex.StackTrace)
            ClsApps.BuatHistory("DELETE", "GAGAL", txt_zipfile.Text, lbljmltoko.Text)
            MsgBox(ex.Message)
        Finally
            btn_proses.Enabled = True
            btn_proses.Text = "PROSES"
            fproses = False

        End Try
    End Sub



    Private Sub txt_zipfile_TextChanged(sender As Object, e As EventArgs) Handles txt_zipfile.TextChanged

    End Sub

    Private Sub UCDelete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
    End Sub

    Private Sub txt_zipfile_Enter(sender As Object, e As EventArgs) Handles txt_zipfile.Enter
        txt_zipfile.BackColor = Color.Goldenrod
    End Sub



    Private Sub txt_zipfile_Leave(sender As Object, e As EventArgs) Handles txt_zipfile.Leave
        txt_zipfile.BackColor = Color.White
    End Sub

    Private Sub txt_folderstb_Leave(sender As Object, e As EventArgs) Handles txt_folderstb.Leave
        txt_folderstb.BackColor = Color.White
    End Sub
    Dim idfile, namafile As String
    Private Sub btn_download_Click(sender As Object, e As EventArgs) Handles btn_download.Click
        If fdown Then
            If Not Directory.Exists(Application.StartupPath + "\Data\") Then
                Directory.CreateDirectory(Application.StartupPath + "\Data\")
            End If
            idfile = ClsApps.BuatID
            namafile = "FTPDELETE" & idfile & ".txt"
            csv(namafile)
            fdown = False
        Else
            Dim tanya As DialogResult = MessageBox.Show("Data sudah pernah didownload" + vbCrLf +
                                                "Buka ulang file?",
                                                "Konfirmasi Download",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question)
            If tanya = DialogResult.Yes Then
                Process.Start(Application.StartupPath + "\Data\" + namafile)
            End If
        End If


    End Sub
    Sub csv(namafile As String)
        Try
            Dim headers = (From header As DataGridViewColumn In dg_listoko.Columns.Cast(Of DataGridViewColumn)()
                           Select header.HeaderText).ToArray
            Dim rows = From row As DataGridViewRow In dg_listoko.Rows.Cast(Of DataGridViewRow)()
                       Where Not row.IsNewRow
                       Select Array.ConvertAll(row.Cells.Cast(Of DataGridViewCell).ToArray, Function(c) If(c.Value IsNot Nothing, c.Value.ToString, ""))
            Using sw As New IO.StreamWriter(Application.StartupPath + "\Data\" + namafile)
                sw.WriteLine(String.Join("|", headers))
                For Each r In rows
                    sw.WriteLine(String.Join("|", r))
                Next
            End Using
            Process.Start(Application.StartupPath + "\Data\" + namafile)
        Catch ex As Exception
            MsgBox("Download Gagal karena : " + ex.Message)
        End Try

    End Sub
    Private Sub txt_folderstb_Enter(sender As Object, e As EventArgs) Handles txt_folderstb.Enter
        txt_folderstb.BackColor = Color.Goldenrod
    End Sub
End Class
