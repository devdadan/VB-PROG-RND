Imports MySql.Data.MySqlClient
Imports System.IO
Imports REG.Fungsi
Imports System.Security.Cryptography
Imports Microsoft.VisualBasic.CompilerServices
Imports System.Text

Public Class FrmIP
    Private mPassPhrase As String
    Private mPassPhrase2 As String
    Private mSaltValue As String
    Private mHashAlgorithm As String
    Private mPasswordIterations As Integer
    Private mInitVector As String
    Private mKeySize As Integer
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Me.mPassPhrase = "C0n$7_MNU"
        Me.mPassPhrase2 = "1nD0m@R3t"
        Me.mSaltValue = "$4lTv@Lu3"
        Me.mHashAlgorithm = "SHA1"
        Me.mPasswordIterations = 2
        Me.mInitVector = "@1B2c3D4e5F6g7H8j9"
        Me.mKeySize = 256


    End Sub
    Private Sub FrmIP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_cari.Focus()
        tampil()
    End Sub
    Private Sub backup()

        Try
            Dim lokasi As String = "A:\IDM.Command\IDMCommandV2.2.0.7\Tokomain.ini"
            If File.Exists(lokasi) Then
                Dim fileInfo As New FileInfo(lokasi)
                Dim ukuranFileBytes As Long = fileInfo.Length
                Dim ukuranFileKB As Double = CDbl(ukuranFileBytes) / 1024
                Dim ukuranFileMB As Double = CDbl(ukuranFileBytes) / (1024 * 1024)
                If ukuranFileMB <> "0" Then
                    Try
                        konek()
                        Dim pathsql As String = Replace(lokasi, "\", "\\")
                        cmd = New MySqlCommand("delete from bck_m_ip", con)
                        cmd.ExecuteNonQuery()

                        sql = "LOAD DATA LOCAL INFILE '" + pathsql + "' INTO TABLE bck_m_ip FIELDS TERMINATED BY '^' IGNORE 1 LINES"
                        cmd = New MySqlCommand(sql, con)
                        cmd.ExecuteNonQuery()

                        Try
                            sql = "select count(*) from bck_m_ip"
                            cmd = New MySqlCommand(sql, con)
                            If cmd.ExecuteScalar() <> 0 Then
                                cmd = New MySqlCommand("delete from m_ip", con)
                                cmd.ExecuteNonQuery()

                                sql = "INSERT INTO M_IP (CABANG,TOKO,NAMA,STATION,IP,KONEKSI) SELECT CABANG,TOKO,NAMA,STATION,IP,KONEKSI FROM BCK_M_IP"
                                cmd = New MySqlCommand(sql, con)
                                cmd.ExecuteNonQuery()

                                sql = "create table if not exists remote.remote_tmp like remote.remote"
                                cmd = New MySqlCommand(sql, con)
                                cmd.ExecuteNonQuery()

                                sql = "delete from remote.remote_tmp"
                                cmd = New MySqlCommand(sql, con)
                                cmd.ExecuteNonQuery()

                                sql = "INSERT INTO remote.remote_tmp SELECT toko,nama,ip,'1' AS devices,cabang,
                                    CASE WHEN cabang = 'G137' THEN 'JAKARTA 2' 
                                    WHEN cabang='G001' THEN 'JAKARTA' 
                                    WHEN cabang='G027' THEN 'BANDUNG' 
                                    WHEN cabang='G259' THEN 'ACEH'"
                                sql += " WHEN cabang='G116' THEN 'BATAM'
                                    WHEN cabang='G009' THEN 'MEDAN'
                                    WHEN cabang='G049' THEN 'PEKANBARU'
                                    WHEN cabang='G080' THEN 'PURWAKARTA'"
                                sql += "WHEN cabang='G105' THEN 'BEKASI' ELSE 'UNKNOWN'
                                    END AS nama_cab,'FO' AS provider,is_induk FROM siedp.bck_m_ip WHERE is_induk=1;"

                                cmd = New MySqlCommand(sql, con)
                                cmd.ExecuteNonQuery()

                                sql = "select count(*) from remote.remote_tmp"
                                cmd = New MySqlCommand(sql, con)
                                If cmd.ExecuteScalar() <> 0 Then

                                    Try
                                        sql = "delete from remote.remote"
                                        cmd = New MySqlCommand(sql, con)
                                        cmd.ExecuteNonQuery()

                                        sql = "insert into remote.remote select * from remote.remote_tmp"
                                        cmd = New MySqlCommand(sql, con)
                                        cmd.ExecuteNonQuery()
                                    Catch ex As Exception
                                        MsgBox("GAGAL INSERT KE DB REMOTE :" + ex.Message)
                                        Me.Close()
                                    End Try

                                End If

                            End If

                        Catch ex As Exception
                            MsgBox(ex.Message)
                            Me.Close()
                        End Try
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                Else

                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
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
    Private Sub tampil()

        Try
            konek()
            dt.Clear()
            sql = "SELECT a.CABANG AS BRANCH,a.TOKO,a.NAMA,A.STATION,A.IP,A.KONEKSI,B.PASS1,B.PASS2,B.PASS3 FROM m_ip a,master_cabang b WHERE a.cabang=b.kode_cab AND a.toko like '%" + txt_cari.Text + "%' or a.nama like '%" + txt_cari.Text + "%' and  a.cabang IN(SELECT kode_cab FROM master_toko)  order by a.cabang,a.toko"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            dg_ip.DataSource = dt
            dg_ip.Columns(0).Width = 70
            dg_ip.Columns(1).Width = 70
            dg_ip.Columns(2).Width = 200
            dg_ip.Columns(3).Width = 70
            dg_ip.Columns(4).Width = 120
            dg_ip.Columns(6).Width = 0
            dg_ip.Columns(7).Width = 0
            dg_ip.Columns(8).Width = 0


            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Dim isikiosk As Boolean
    Private Sub dg_ip_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_ip.CellClick
        isikiosk = False
        txt_cab.Text = dg_ip.Rows(e.RowIndex).Cells(0).Value
        txtip.Text = dg_ip.Rows(e.RowIndex).Cells(4).Value
        txt_toko.Text = dg_ip.Rows(e.RowIndex).Cells(1).Value + " - " + dg_ip.Rows(e.RowIndex).Cells(2).Value
        ppos.Text = dg_ip.Rows(e.RowIndex).Cells(6).Value
        pkiosk.Text = dg_ip.Rows(e.RowIndex).Cells(7).Value
        txtpass.Text = dg_ip.Rows(e.RowIndex).Cells(3).Value
        txtmnu.Text = ""
        If dg_ip.Rows(e.RowIndex).Cells(3).Value = "I1" Then
            isikiosk = True
        Else
            isikiosk = False
        End If
    End Sub
    Private Sub tembak()

        Dim path As String = "C:\Program Files\uvnc bvba\UltraVNC\vncviewer.exe"
        Dim path2 As String = "C:\Program Files (X86)\uvnc bvba\UltraVNC\vncviewer.exe"
        Dim ip As String = ""
        ip = txtip.Text
        If isikiosk Then
            If File.Exists(path) Then
                Process.Start(path, "-scale 100/100 -encoding ultra -8Greycolors -password " + pkiosk.Text + " -Connect " + ip.ToString)
            Else
                Process.Start(path2, "-scale 100/100 -encoding ultra -8Greycolors -password " + pkiosk.Text + " -Connect " + ip.ToString)
            End If
            'Process.Start(path, "-scale 80/100 -encoding ultra -8Greycolors -password " + pkiosk.Text + " -Connect " + ip.ToString)
        Else
            If File.Exists(path) Then
                Process.Start(path, "-scale 100/100 -encoding ultra -8Greycolors -password " + ppos.Text + " -Connect " + ip.ToString)
            Else
                Process.Start(path2, "-scale 100/100 -encoding ultra -8Greycolors -password " + ppos.Text + " -Connect " + ip.ToString)
            End If
        End If

    End Sub

    Private Sub txt_cari_TextChanged(sender As Object, e As EventArgs) Handles txt_cari.TextChanged

    End Sub

    Private Sub dg_ip_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_ip.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tembak()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        backup()
    End Sub

    Private Sub txt_cari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cari.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            tampil()
        End If
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        If txtip.Text = "" Then
        Else
            If txtpass.Text = "1" Then
                If koneksitoko(txtip.Text) Then
                    Dim sql As String = "SELECT `DESC` FROM CONST WHERE RKEY='MNU'"
                    Dim cmd As MySqlCommand = New MySqlCommand(sql, contok)
                    Dim str As String = cmd.ExecuteScalar
                    Dim pass As String = ""
                    pass = Decrypt(str, 2)
                    txtmnu.Text = Decrypt(pass, 1)
                End If
            Else
                MsgBox("Harus station induk")
            End If

        End If
    End Sub

    Public Function Decrypt(cipherText As String, stage As Integer) As String
        Dim strPassword As String = Conversions.ToString(Interaction.IIf(stage = 1, Me.mPassPhrase, Me.mPassPhrase2))
        Dim s As String = Me.mSaltValue
        Dim strHashName As String = Me.mHashAlgorithm
        Dim iterations As Integer = Me.mPasswordIterations
        Dim s2 As String = Me.mInitVector
        Dim num As Integer = Me.mKeySize
        Dim bytes As Byte() = Encoding.ASCII.GetBytes(s2)
        Dim bytes2 As Byte() = Encoding.ASCII.GetBytes(s)
        Dim array As Byte() = Convert.FromBase64String(cipherText)
        Dim passwordDeriveBytes As PasswordDeriveBytes = New PasswordDeriveBytes(strPassword, bytes2, strHashName, iterations)
        Dim bytes3 As Byte() = passwordDeriveBytes.GetBytes(num / 8)
        Dim transform As ICryptoTransform = New RijndaelManaged() With {.Mode = CipherMode.CBC}.CreateDecryptor(bytes3, bytes)
        Dim memoryStream As MemoryStream = New MemoryStream(array)
        Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, transform, CryptoStreamMode.Read)
        Dim array2 As Byte() = New Byte(array.Length - 1 + 1 - 1) {}
        Dim count As Integer = cryptoStream.Read(array2, 0, array2.Length)
        memoryStream.Close()
        cryptoStream.Close()
        Return Encoding.UTF8.GetString(array2, 0, count)
    End Function
End Class