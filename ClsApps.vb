Imports MySql.Data.MySqlClient
Imports System.Net.NetworkInformation
Imports System.IO
Imports System.Net
Imports Newtonsoft.Json
Imports System.Diagnostics
Imports System.Text
Imports System.Security.Cryptography

Public Class ClsApps

    Public Shared Function CekKoneksi(ipAddress As String) As Boolean
        Try
            Dim pingSender As New Ping()
            Dim reply As PingReply = pingSender.Send(ipAddress)
            If reply.Status = IPStatus.Success Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Shared Sub sqllog(ss As String)
        Try
            konek()
            Dim strHostName As String = System.Net.Dns.GetHostName()
            Dim strIPAddress As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString
            Dim thnn As String = Format(Now, "yyyy-MM-dd HH:mm:ss")
            Dim appname As String = Application.ProductName + " v." + Application.ProductVersion
            Using cmdDelete As New MySqlCommand("DELETE FROM tracelog_app WHERE DATE(tgl) <= DATE_SUB(CURDATE(), INTERVAL 2 DAY);", con)
                cmdDelete.ExecuteNonQuery()
            End Using
            Using cmdInsert As New MySqlCommand("INSERT INTO tracelog_app (Tgl, appname, log, addid) VALUES (@thnn, @appname, @log, @addid)", con)
                cmdInsert.Parameters.AddWithValue("@thnn", thnn)
                cmdInsert.Parameters.AddWithValue("@appname", appname)
                cmdInsert.Parameters.AddWithValue("@log", ss)
                cmdInsert.Parameters.AddWithValue("@addid", strIPAddress)

                cmdInsert.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            Tulislog("ERROR INSERT LOG KE SQL: " + ex.Message)
        End Try
    End Sub
    Public Shared Sub simpanfileupd(exe As String, versi As String, tgl As String, jam As String, ukuran As String)
        Try
            konek()
            Dim strHostName As String = System.Net.Dns.GetHostName()
            Dim strIPAddress As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString
            Dim thnn As String = Format(Now, "yyyy-MM-dd HH:mm:ss")
            Dim appname As String = Application.ProductName + " v." + Application.ProductVersion
            Using cmdInsert As New MySqlCommand("INSERT INTO master_fileupd (namaexe, versi, tgl,jam,ukuran) VALUES (@namaexe, @versi, @date,@jam,@ukuran)", con)
                cmdInsert.Parameters.AddWithValue("@namaexe", exe)
                cmdInsert.Parameters.AddWithValue("@versi", versi)
                cmdInsert.Parameters.AddWithValue("@date", tgl)
                cmdInsert.Parameters.AddWithValue("@jam", jam)
                cmdInsert.Parameters.AddWithValue("@ukuran", ukuran)

                cmdInsert.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            Tulislog("INFORMASI FILE UPD: " + ex.Message)
        End Try
    End Sub
    Public Shared Sub Kill()
        Dim batFilePath As String = Application.StartupPath + "\Kill.bat"
        If Not File.Exists(batFilePath) Then
            Using tulis As StreamWriter = File.CreateText(batFilePath)
                tulis.WriteLine("taskkill /f /im " + Application.ProductName + ".exe")
                tulis.Flush()
            End Using
        End If

        Dim startInfo As New ProcessStartInfo()
        startInfo.FileName = "cmd.exe"
        startInfo.Arguments = "/C " & batFilePath
        startInfo.CreateNoWindow = True
        startInfo.UseShellExecute = False

        Dim process As New Process()
        process.StartInfo = startInfo
        process.Start()
        process.Dispose()
    End Sub


    Public Shared Sub Tulislog(slog As String)
        Try
            Dim thn As String = Format(Now, "yyyy-MM-dd")
            Dim th As String = Format(Now, "yyyyMM")
            Dim thnn As String = Format(Now, "yyyy-MM-dd HH:mm:ss")
            Dim tulis As StreamWriter
            If Not File.Exists(Application.StartupPath & "\TRACELOG_" + th + ".txt") Then
                tulis = File.CreateText(Application.StartupPath & "\TRACELOG_" + th + ".txt")
                tulis.WriteLine("##### LOG PROGRAM #####")
                tulis.WriteLine(thnn & " : " & slog)
                tulis.Flush()
                tulis.Close()
            Else
                tulis = File.AppendText(Application.StartupPath & "\TRACELOG_" + th + ".txt")
                tulis.WriteLine(thnn & " : " & slog)
                tulis.Flush()
                tulis.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Public Shared Function GetServer(user As String, period As String) As String
        Dim Pass = GetVersi(user, period)
        Return Pass
    End Function
    Public Shared Function GetVersi(User As String, periode As String) As String
        Dim Period As String = periode
        Return Versi(Period.Substring(0, 4) & "-" & Period.Substring(4, 2) & "-" & Period.Substring(6, 2), User.ToLower())
    End Function
    Public Shared Function Versi(Periode As String, User As String) As String

        Dim text = Encrypt(User & " : " & DefaultVer(User), Date.Parse(Periode).ToString("yyyy-MM-dd"), User)
        text = text.Replace("'", "")
        Return text.Substring(10) & text.Substring(0, 10)
    End Function
    Public Shared Function DefaultVer(User As String) As String
        Dim result = ""
        If Equals(User.ToUpper().Trim(), "root".ToUpper().Trim()) Then
            result = Decrypt("AYBOzt4YQ4zHbTY2bRiajA==", User, "12345")
        End If
        If Equals(User.ToUpper().Trim(), "kasir".ToUpper().Trim()) Then
            result = Decrypt("kRUXVE+bgdwh3Ptfbiw9yg==", User, "12345")
        End If
        If Equals(User.ToUpper().Trim(), "app".ToUpper().Trim()) Then
            result = Decrypt("hEUSKSjtKQ8dgPIwNIU2Dg==", User, "12345")
        End If
        If Equals(User.ToUpper().Trim(), "edp".ToUpper().Trim()) Then
            result = Decrypt("21TRmBPTF5Vs2b3mM6FnrA==", User, "12345")
        End If
        If Equals(User.ToUpper().Trim(), "dbe".ToUpper().Trim()) Then
            result = Decrypt("hGBKT3Q+fgNe9sE4lU2Osw==", User, "12345")
        End If
        Return result
    End Function
    Public Shared Function Encrypt(plainText As String, passPhrase As String, saltValue As String) As String
        Dim strHashName = "SHA1"
        Dim iterations = 2
        Dim s = "@1B2c3D4e5F6g7H8"
        Dim num = 256
        Dim bytes = Encoding.ASCII.GetBytes(s)
        Dim bytes2 = Encoding.ASCII.GetBytes(saltValue)
        Dim bytes3 = Encoding.UTF8.GetBytes(plainText)
        Dim passwordDeriveBytes As PasswordDeriveBytes = New PasswordDeriveBytes(passPhrase, bytes2, strHashName, iterations)
        Dim bytes4 As Byte() = passwordDeriveBytes.GetBytes(Math.Round(num / 8.0))
        Dim transform As ICryptoTransform = New RijndaelManaged With {
.Mode = CipherMode.CBC
}.CreateEncryptor(bytes4, bytes)
        Dim memoryStream As MemoryStream = New MemoryStream()
        Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, transform, CryptoStreamMode.Write)
        cryptoStream.Write(bytes3, 0, bytes3.Length)
        cryptoStream.FlushFinalBlock()
        Dim inArray As Byte() = memoryStream.ToArray()
        memoryStream.Close()
        cryptoStream.Close()
        Return Convert.ToBase64String(inArray)
    End Function
    Public Shared Function Decrypt(cipherText As String, passPhrase As String, saltValue As String) As String
        Dim strHashName = "SHA1"
        Dim iterations = 2
        Dim s = "@1B2c3D4e5F6g7H8"
        Dim num = 256
        Dim bytes = Encoding.ASCII.GetBytes(s)
        Dim bytes2 = Encoding.ASCII.GetBytes(saltValue)
        Dim array = Convert.FromBase64String(cipherText)

        Dim passwordDeriveBytes As PasswordDeriveBytes = New PasswordDeriveBytes(passPhrase, bytes2, strHashName, iterations)
        Dim bytes3 As Byte() = passwordDeriveBytes.GetBytes(Math.Round(num / 8.0))
        Dim transform As ICryptoTransform = New RijndaelManaged With {
.Mode = CipherMode.CBC
}.CreateDecryptor(bytes3, bytes)
        Dim memoryStream As MemoryStream = New MemoryStream(array)
        Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, transform, CryptoStreamMode.Read)
        Dim array2 = New Byte(array.Length + 1 - 1) {}
        Dim count As Integer = cryptoStream.Read(array2, 0, array2.Length)
        memoryStream.Close()
        cryptoStream.Close()
        Return Encoding.UTF8.GetString(array2, 0, count)
    End Function
    Public Shared Function FtpUploadFile(filetoupload As String, ftpuri As String, ftpusername As String, ftppassword As String) As Boolean
        Dim ftpWebRequest As FtpWebRequest = CType(WebRequest.Create(ftpuri), FtpWebRequest)
        Try
            ftpWebRequest.Method = "STOR"
            ftpWebRequest.Credentials = New NetworkCredential(ftpusername, ftppassword)
            Dim array As Byte() = File.ReadAllBytes(filetoupload)
            ftpWebRequest.ContentLength = CLng(array.Length)
            ftpWebRequest.UsePassive = True
            ftpWebRequest.Proxy = New WebProxy()
            Using requestStream As Stream = ftpWebRequest.GetRequestStream()
                requestStream.Write(array, 0, array.Length)
                requestStream.Close()
            End Using
        Catch ex As Exception
            sqllog(ex.Message + vbCrLf + ex.StackTrace)
            Return False
        End Try
        sqllog("Complete: " + filetoupload)
        Return True
    End Function
    Public Shared Function FtpUploadFile2(filetoupload As String, ftpuri As String, ftpusername As String, ftppassword As String, toko As String, id As String) As Boolean
        Dim ftpWebRequest As FtpWebRequest = CType(WebRequest.Create(ftpuri), FtpWebRequest)

        Try
            ftpWebRequest.Method = WebRequestMethods.Ftp.UploadFile
            ftpWebRequest.Credentials = New NetworkCredential(ftpusername, ftppassword)

            Dim array As Byte() = File.ReadAllBytes(filetoupload)
            ftpWebRequest.ContentLength = CLng(array.Length)
            ftpWebRequest.UsePassive = True
            ftpWebRequest.Proxy = New WebProxy()

            Using requestStream As Stream = ftpWebRequest.GetRequestStream()
                requestStream.Write(array, 0, array.Length)
                requestStream.Close()
            End Using
            Dim fileSizeSent As Long = ftpWebRequest.ContentLength
            Dim logMessage As String = "SUKSES FILE TERKIRIM " + fileSizeSent.ToString + " bytes"
            updatertoko(toko, id, logMessage)
        Catch ex As Exception
            sqllog(ex.Message + vbCrLf + ex.StackTrace)
            Return False
        End Try

        sqllog($"Upload selesai: {filetoupload}")
        Return True
    End Function
    Public Shared Function FtpUploadFile3(filetoupload As String, ftpuri As String, ftpusername As String, ftppassword As String) As String
        Dim ftpWebRequest As FtpWebRequest = CType(WebRequest.Create(ftpuri), FtpWebRequest)
        Dim logmessage As String
        Try
            ftpWebRequest.Method = WebRequestMethods.Ftp.UploadFile
            ftpWebRequest.Credentials = New NetworkCredential(ftpusername, ftppassword)

            Dim array As Byte() = File.ReadAllBytes(filetoupload)
            ftpWebRequest.ContentLength = CLng(array.Length)
            ftpWebRequest.UsePassive = True
            ftpWebRequest.Proxy = New WebProxy()

            Using requestStream As Stream = ftpWebRequest.GetRequestStream()
                requestStream.Write(array, 0, array.Length)
                requestStream.Close()
            End Using
            Dim fileSizeSent As Long = ftpWebRequest.ContentLength
            logmessage = "TERKIRIM " + fileSizeSent.ToString + " bytes"

        Catch ex As Exception
            sqllog(ex.Message + vbCrLf + ex.StackTrace)
            logmessage = "GAGAL TERKIRIM :" + ex.Message
        End Try
        Return logmessage
    End Function
    Public Shared Function BuatID() As String
        Dim userx As String = userlogin
        Dim period As String = Format(Now, "yyyyMMddHHmm")
        Dim result As String = userx & period
        Return result
    End Function

    Public Shared Function updatertoko(toko As String, id As String, data As String)
        Try
            konek()

            sql = "CREATE TABLE IF NOT EXISTS FTP_DATA (
              `ID` VARCHAR(100) DEFAULT NULL,
              `TANGGAL` DATE DEFAULT NULL,
              `USER` VARCHAR(50) DEFAULT NULL,
              `CABANG` VARCHAR(4) DEFAULT NULL,
              `TOKO` VARCHAR(4) DEFAULT NULL,
              `NAMA` VARCHAR(50) DEFAULT NULL,
              `IP` VARCHAR(20) DEFAULT NULL,
              `HASIL` TEXT,
              `ADDTIME` DATETIME DEFAULT NULL
            ) ENGINE=InnoDB DEFAULT CHARSET=latin1"

            Using cmdCreateTable As New MySqlCommand(sql, con)
                cmdCreateTable.ExecuteNonQuery()
            End Using


            Dim sqlUpdate As String = "UPDATE FTP_DATA SET HASIL=@data, ADDTIME=NOW() WHERE TANGGAL=CURDATE() AND ID=@id AND TOKO=@toko"

            Using cmdUpdate As New MySqlCommand(sqlUpdate, con)
                cmdUpdate.Parameters.AddWithValue("@id", id)
                cmdUpdate.Parameters.AddWithValue("@toko", toko)
                cmdUpdate.Parameters.AddWithValue("@data", data)
                cmdUpdate.ExecuteNonQuery()
            End Using

        Catch ex As Exception
            sqllog(ex.Message + vbNewLine + sql)
        End Try
    End Function


    Public Shared Function FtpDeleteFile(ftpUri As String, ftpUsername As String, ftpPassword As String, fileNameToDelete As String) As Boolean
        Try
            Dim ftpWebRequest As FtpWebRequest = CType(WebRequest.Create($"{ftpUri}/{fileNameToDelete}"), FtpWebRequest)

            ftpWebRequest.Method = WebRequestMethods.Ftp.DeleteFile
            ftpWebRequest.Credentials = New NetworkCredential(ftpUsername, ftpPassword)

            Dim response As FtpWebResponse = CType(ftpWebRequest.GetResponse(), FtpWebResponse)
            response.Close()

            Console.WriteLine($"File '{fileNameToDelete}' deleted successfully.")
            Return True
        Catch ex As Exception
            Tulislog(ex.Message)
            Console.WriteLine($"Error deleting file '{fileNameToDelete}': {ex.Message}")
            Return False
        End Try
    End Function
    Public Shared Function FtpDeleteAllFiles(ftpUri As String, ftpUsername As String, ftpPassword As String, folder As String) As Boolean
        Try
            Dim fileList As List(Of String) = GetFtpFileList(ftpUri & folder, ftpUsername, ftpPassword)
            If fileList IsNot Nothing Then
                For Each fileNameToDelete As String In fileList
                    Tulislog("delete file : host = " & ftpUri & ",username = " & ftpUsername & ",password = " & ftpPassword & ",file = " & folder & "/" & fileNameToDelete)
                    If Not FtpDeleteFile(ftpUri, ftpUsername, ftpPassword, fileNameToDelete) Then
                        Tulislog("Gagal delete file :" & fileNameToDelete)
                        Console.WriteLine($"Error deleting file '{fileNameToDelete}'.")
                        Return False
                    End If
                Next
            End If


            Console.WriteLine("All files deleted successfully.")
            Return True
        Catch ex As Exception
            Tulislog(ex.Message)
            Console.WriteLine($"Error deleting files: {ex.Message}")
            Return False
        End Try
    End Function
    Public Shared Function FtpCheckAllFiles(ftpUri As String, ftpUsername As String, ftpPassword As String, folder As String) As Integer
        Dim result As Integer = 0
        Try
            Dim fileList As List(Of String) = GetFtpFileList(ftpUri & folder, ftpUsername, ftpPassword)
            If fileList IsNot Nothing Then
                result = fileList.Count
            Else
                result = 0
            End If
        Catch ex As Exception
            Tulislog(ex.Message)
            Console.WriteLine($"Error deleting files: {ex.Message}")
        End Try
        Return result
    End Function


    Private Shared Function GetFtpFileList(ftpUri As String, ftpUsername As String, ftpPassword As String) As List(Of String)
        Dim fileList As New List(Of String)

        Try
            Dim ftpWebRequest As FtpWebRequest = CType(WebRequest.Create(ftpUri), FtpWebRequest)
            ftpWebRequest.Method = WebRequestMethods.Ftp.ListDirectory
            ftpWebRequest.Credentials = New NetworkCredential(ftpUsername, ftpPassword)

            Using response As FtpWebResponse = CType(ftpWebRequest.GetResponse(), FtpWebResponse)
                Using streamReader As New StreamReader(response.GetResponseStream())
                    While Not streamReader.EndOfStream
                        Dim fileName As String = streamReader.ReadLine()
                        fileList.Add(fileName)
                    End While
                End Using
            End Using

            Return fileList
        Catch ex As Exception
            Tulislog(ex.Message)
            ' Log atau tangani kesalahan mendapatkan daftar file
            Console.WriteLine($"Error getting file list: {ex.Message}")
            Return Nothing
        End Try
    End Function

    Public Shared Function CompareStrings(str1 As String, str2 As String) As Boolean
        Return String.Equals(str1, str2, StringComparison.OrdinalIgnoreCase)
    End Function
    Public Shared Sub BuatHistory(jenis As String, status As String, namafile As String, jmltoko As String)
        konek()
        Try
            Dim strHostName As String = System.Net.Dns.GetHostName()
            Dim strIPAddress As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString
            sql = "CREATE TABLE IF NOT EXISTS HISTORY_FTP (
              `JENIS_COMMAND` varchar(50) DEFAULT NULL,
              `USER` varchar(50) DEFAULT NULL,"
            sql += "`TANGGAL` date DEFAULT NULL,
              `TIME` time DEFAULT NULL,
              `LIST_TOKO` text,
              `FILE` varchar(200) DEFAULT NULL,
              `STATUS` varchar(10) DEFAULT NULL
            ) ENGINE=InnoDB DEFAULT CHARSET=latin1"
            cmd = New MySqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            Dim jeniscommand As String = jenis
            Dim tanggal As String = Format(Now, "yyyy-MM-dd")
            Dim stime As String = Format(Now, "hh:mm:ss")
            Dim fileupload As String = namafile
            Dim sql1 As String = "INSERT INTO HISTORY_FTP (JENIS_COMMAND,`USER`,TANGGAL,`TIME`,LIST_TOKO,FILE,`STATUS`)"
            sql1 += "values ('" + jeniscommand + "','" + strHostName.ToUpper + "','" + tanggal + "','" + stime + "','" + jmltoko + "','" + fileupload + "','" + status + "')"
            cmd = New MySqlCommand(sql1, con)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            ClsApps.sqllog("BuatHistory :" + ex.Message + vbCrLf + ex.StackTrace + vbCrLf + "Last query : " + sql)
        End Try
    End Sub
    Public Shared Function msg(jenis As String, isi As String, bolehtutup As Boolean, lama As Integer) As Boolean
        FrmMessage.jenismsg = jenis
        FrmMessage.isipesan = isi
        FrmMessage.timermsg = bolehtutup
        FrmMessage.timeclose = lama
        FrmMessage.ShowDialog()
        If jenis = "tanya" Then
            Return FrmMessage.respons
        End If
    End Function
    Public Shared Function TembakSQL(ip As String, db As String, flagsintak As String, query As String, data1 As DataTable, gudang As String, namatok As String, kodetok As String) As Boolean
        Dim con1 As MySqlConnection
        Dim cmd1 As MySqlCommand
        Dim result As Boolean = False
        Dim filetmp As String = Application.StartupPath + "\Tembaksql.tmp"
        data1.Clear()
        Try
            Dim host As String = ""
            If db = "POS" Then
                host = "server=" + ip + ";uid=root;pwd=" + passtok + ";database=" + db + ";Pooling=False;Connection Timeout=120;"
            Else
                host = "server=" + ip + ";uid=ikiosk;pwd=indomaret;database=ikioskterminal;Pooling=False;Connection Timeout=120;"
            End If

            con1 = New MySqlConnection(host)
            con1.Open()

            If flagsintak = "execute" Then
                Dim sql1 As String = query
                cmd1 = New MySqlCommand(sql1, con1)
                Dim resultexe As Integer = cmd1.ExecuteNonQuery()
                con1.Close()
                cmd1.Dispose()
                Using writer1 As New StreamWriter(filetmp, True)
                    writer1.Write($"{gudang}|{kodetok}|{namatok}|{resultexe} ROWS")
                    writer1.WriteLine()
                End Using
            Else
                Dim sql2 As String = query
                Dim da1 As MySqlDataAdapter = New MySqlDataAdapter(sql2, con1)
                da1.Fill(data1)
                If Not data1.Columns.Contains("FTOKO") Then
                    data1.Columns.Add("FTOKO", GetType(String))
                End If
                For Each row As DataRow In data1.Rows
                    row("FTOKO") = kodetok
                Next
                Dim ftokoColumn As DataColumn = data1.Columns("FTOKO")
                data1.Columns.Remove(ftokoColumn)
                data1.Columns.Add(ftokoColumn)
                Using writer As New StreamWriter(filetmp, True)
                    For Each row As DataRow In data1.Rows
                        For Each col As DataColumn In data1.Columns
                            writer.Write(row(col))
                            If col IsNot data1.Columns(data1.Columns.Count - 1) Then
                                writer.Write("|")
                            End If
                        Next
                        writer.WriteLine()
                    Next
                End Using
            End If

            result = True
        Catch ex As Exception
            result = False
            Using writer2 As New StreamWriter(filetmp, True)
                writer2.Write($"{gudang}|{kodetok}|{namatok}|{ex.Message}")
                writer2.WriteLine()
            End Using
            ClsApps.sqllog("GAGAL KONEK: " & ex.Message + ex.StackTrace)

        End Try
        Return result
    End Function
    Public Shared Function TembakSQL2(ip As String, db As String, flagsintak As String, query As String, data1 As DataTable, gudang As String, namatok As String, kodetok As String, id As String) As Boolean
        Dim con1 As MySqlConnection
        Dim cmd1 As MySqlCommand
        Dim result As Boolean = False
        Try
            data1.Clear()
            Dim host As String = ""
            Dim host2 As String = ""
            If db = "POS" Then
                host = "server=" + ip + ";uid=root;pwd=" + passtok + ";database=" + db + ";Pooling=False;Connection Timeout=120;"
                host2 = "server=" + ip + ";uid=root;pwd=" + passtok2 + ";database=" + db + ";Pooling=False;Connection Timeout=120;"

            Else
                host = "server=" + ip + ";uid=ikiosk;pwd=indomaret;database=ikioskterminal;Pooling=False;Connection Timeout=120;"
            End If
            Try
                con1 = New MySqlConnection(host)
                con1.Open()
            Catch ex As Exception
                con1 = New MySqlConnection(host2)
                con1.Open()
            End Try


            If flagsintak = "execute" Then
                Dim sql1 As String = query
                cmd1 = New MySqlCommand(sql1, con1)

            Else
                Dim sql2 As String = query
                Dim da1 As MySqlDataAdapter = New MySqlDataAdapter(sql2, con1)
                da1.Fill(data1)
                Dim jsonResult As String = JsonConvert.SerializeObject(data1, Formatting.Indented)
                Try
                    Using cmd As New MySqlCommand(sql, con)
                        Dim sql As String = "UPDATE sql_data SET `hasil`=@jsonResult WHERE toko=@kodetok and id=@idtok"
                        cmd.Parameters.AddWithValue("@jsonResult", jsonResult)
                        cmd.Parameters.AddWithValue("@kodetok", kodetok)
                        cmd.Parameters.AddWithValue("idtok", id)
                        cmd.ExecuteNonQuery()
                    End Using

                Catch ex As Exception
                    Tulislog(ex.Message + sql + ex.StackTrace)
                End Try
            End If

            result = True
        Catch ex As Exception
            result = False
            ClsApps.Tulislog("GAGAL KONEK: " & ex.Message + ex.StackTrace)

        End Try
        Return result
    End Function

    Public Shared Function TembakSQL3(ip As String, db As String, flagsintak As String, query As String, data1 As DataTable, gudang As String, namatok As String, kodetok As String) As Boolean
        Dim con1 As MySqlConnection
        Dim cmd1 As MySqlCommand
        Dim result As Boolean = False
        Dim filetmp As String = Application.StartupPath + "\Tembaksql.tmp"


        Try
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
                Dim sql1 As String = query
                cmd1 = New MySqlCommand(sql1, con1)
                Dim resultexe As Integer = cmd1.ExecuteNonQuery()
                con1.Close()
                cmd1.Dispose()
                WriteToFile($"{gudang}|{kodetok}|{namatok}|{resultexe} ROWS", filetmp)
            Else
                Dim sql2 As String = query
                Dim da1 As MySqlDataAdapter = New MySqlDataAdapter(sql2, con1)
                da1.Fill(data1)
                If data1.Rows.Count > 0 Then
                    For Each row As DataRow In data1.Rows
                        Dim rowString As String = ""
                        rowString += gudang & "|" & kodetok & "|" & namatok & "|"
                        For Each col As DataColumn In data1.Columns
                            rowString += row(col).ToString() & "|"
                        Next
                        WriteToFile(rowString.TrimEnd("|"c), filetmp)
                    Next
                Else
                    WriteToFile($"{gudang}|{kodetok}|{namatok}| TIDAK ADA DATA", filetmp)
                End If

            End If

            result = True
        Catch ex As Exception
            ClsApps.sqllog("GAGAL KONEK: " & ex.Message + ex.StackTrace)
            result = False
            WriteToFile($"{gudang}|{kodetok}|{namatok}|{ex.Message}", filetmp)
        End Try
        data1.Clear()
        Return result
    End Function
    Private Shared fileLock As New Object()
    Public Shared Sub WriteToFile(content As String, filepath As String)
        SyncLock fileLock
            Using writer As New StreamWriter(filepath, True)
                writer.WriteLine(content)
            End Using
        End SyncLock
    End Sub
End Class
