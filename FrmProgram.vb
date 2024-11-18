Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Net
Imports ICSharpCode.SharpZipLib.Zip
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports Microsoft.VisualBasic.CompilerServices
Imports System.Globalization

Public Class FrmProgram
    Dim ftpuser, ftppass, ftphost, uri As String
    Private Sub FrmProgram_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
    End Sub

    Private Sub bacazip(nmfile As String)
        Try
            If System.IO.File.Exists(nmfile) Then
                Using fs As FileStream = System.IO.File.OpenRead(nmfile)
                    Using zipInputStream As New ZipInputStream(fs)
                        Dim entry As ZipEntry = zipInputStream.GetNextEntry()
                        While entry IsNot Nothing
                            Dim textv As String
                            textv = ""
                            Dim fileName As String = entry.Name
                            Dim fileSize As Long = entry.Size
                            Dim fileDate As DateTime = entry.DateTime
                            Dim fileExtension As String = Path.GetExtension(fileName)
                            Dim fileType As String = If(String.IsNullOrEmpty(fileExtension), "Folder", fileExtension)
                            Dim versi As String = entry.Version.ToString
                            Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("Scripting.FileSystemObject", ""))
                            Dim listViewItem As New ListViewItem(fileName)
                            listViewItem.SubItems.Add(fileSize.ToString())
                            If fileName.ToLower.Contains("exe") Or fileName.ToLower.Contains("dll") Then
                                If Not Directory.Exists(Application.StartupPath + "\tmp") Then
                                    Directory.CreateDirectory(Application.StartupPath + "\tmp")
                                End If
                                UnZip(nmfile, Application.StartupPath + "\tmp", fileName)
                                Thread.Sleep(500)
                                textv = Conversions.ToString(NewLateBinding.LateGet(objectValue, Nothing, "GetFileVersion", New Object() {Application.StartupPath + "\tmp\" + fileName}, Nothing, Nothing, Nothing))
                                listViewItem.SubItems.Add(textv)
                                Thread.Sleep(500)

                                If File.Exists(Application.StartupPath + "\tmp\" + fileName) Then
                                    File.Delete(Application.StartupPath + "\tmp\" + fileName)
                                End If
                            Else
                                textv = ""
                                listViewItem.SubItems.Add("")
                            End If
                            listViewItem.SubItems.Add(fileDate.ToString("dd/MM/yyyy"))
                            listViewItem.SubItems.Add(fileDate.ToString("hh:mm"))

                            List_zip.Items.Add(listViewItem)
                            ClsApps.simpanfileupd(fileName, textv, fileDate.ToString("dd/MM/yyyy"), fileDate.ToString("hh:mm"), fileSize.ToString)
                            entry = zipInputStream.GetNextEntry()
                        End While
                    End Using
                End Using
            End If
        Catch ex As Exception
            MsgBox(ex.Message + ex.Message)
        End Try

    End Sub
    Private Function UnZip(pathSource As String, pathTarget As String, NamaFile As String) As Boolean
        Dim result As Boolean
        Try
            If Not Directory.Exists(pathTarget) Then
                Directory.CreateDirectory(pathTarget)
            End If
            Dim fastZip As FastZip = New FastZip()
            fastZip.ExtractZip(pathSource, pathTarget, NamaFile)
            result = True
        Catch ex As Exception
            MsgBox(ex.Message)
            result = False
        End Try
        Return result
    End Function



    Private Sub txt_path_TextChanged(sender As Object, e As EventArgs) Handles txt_path.TextChanged
        If txt_path.Text <> "" Then
            List_zip.Items.Clear()
            Dim namafile1 As String = txt_path.Text
            bacazip(namafile1)
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim openfile As OpenFileDialog = New OpenFileDialog
            openfile.InitialDirectory = "D:\#PROGRAM\"
            openfile.Filter = "Zip Files (*.zip)|*.zip|All files (*.*)|*.*"

            If openfile.ShowDialog() = DialogResult.OK Then
                txt_path.Text = openfile.FileName
            Else
                MessageBox.Show("File selection canceled.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Dim flagproses As Boolean = False
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        buatfile()

    End Sub
    Private Sub buatfile()
        Dim flagdown As Boolean = False
        If ck_down.Checked = True Then
            flagdown = True
        Else
            flagdown = False
        End If
        Try
            If ck_pos.Checked = True Then
                Dim flag As Boolean = False
                flag = buattxt("BACKOFF")
                If flagdown Then
                    FileAutoupd("BACKOFF")
                End If
                If flag Then
                    MsgBox("SELESAI BUAT FILE UPD POS")
                Else
                    MsgBox("GAGAL BUAT FILE")
                End If
            End If
            If ck_ikiosk.Checked = True Then
                Dim flag As Boolean = False
                flag = buattxt("I-KIOSK")
                If flag Then
                    MsgBox("SELESAI BUAT FILE UP IKIOSK")
                Else
                    MsgBox("GAGAL BUAT FILE")
                End If
            End If
            If ck_prg.Checked = True Then
                Dim flag As Boolean = False
                flag = buattxt("PRG_TAMPUNG")
                If flag Then
                    MsgBox("SELESAI BUAT FILE UP PRG_TAMPUNG")
                Else
                    MsgBox("GAGAL BUAT FILE")
                End If
            End If

            flagproses = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Function buattxt(jenis As String) As Boolean
        Dim result As Boolean = False
        Try
            Dim flag1 As String
            Dim nama1 As String
            If jenis = "BACKOFF" Then
                flag1 = "|D:\BACKOFF"
                nama1 = "FILE_UPD_"
            ElseIf jenis = "I-KIOSK" Then
                flag1 = "|D:\I-KIOSK"
                nama1 = "IKIOSKFILE_UPD_"
            Else
                flag1 = "|D:\PRG_TAMPUNG"
                nama1 = "PRGTAMPUNG_UPD_"
            End If

            Dim sumber As String = txt_path.Text
            Dim nmfile As String = Path.GetFileName(sumber)
            Dim nmfile1 As String = Path.GetFileName(sumber)
            Dim pathfile As String = Path.GetDirectoryName(sumber)
            nmfile = nmfile + ".txt"
            Dim pathfull As String = pathfile & "\" & nmfile
            If File.Exists(pathfull) Then
                File.Delete(pathfull)
            End If
            Using streamwriter As StreamWriter = File.CreateText(pathfull)
                For Each item As ListViewItem In List_zip.Items
                    Dim isFirstItem As Boolean = True
                    For Each subItem As ListViewItem.ListViewSubItem In item.SubItems
                        If Not isFirstItem Then
                            streamwriter.Write("|")
                        End If
                        streamwriter.Write(subItem.Text)
                        isFirstItem = False
                    Next
                    streamwriter.Write(flag1)
                    streamwriter.WriteLine()
                Next
            End Using

            result = True
        Catch ex As Exception
            MsgBox(ex.Message)
            result = False
        End Try
        Return result
    End Function

    Private Function FileAutoupd(jenis As String) As Boolean
        Formtanya.ShowDialog()
        Dim idver As String = Formtanya.nilver
        Dim idflag As String = Formtanya.idconfg

        Dim result As Boolean = False
        Try
            Dim flag1 As String
            Dim nama1 As String
            If jenis = "BACKOFF" Then
                flag1 = "|D:\BACKOFF"
                nama1 = "FILE_UPD_"
            ElseIf jenis = "I-KIOSK" Then
                flag1 = "|D:\I-KIOSK"
                nama1 = "IKIOSKFILE_UPD_"
            Else
                flag1 = "|D:\PRG_TAMPUNG"
                nama1 = "PRGTAMPUNG_UPD_"
            End If

            Dim sumber As String = txt_path.Text
            Dim nmfile As String = Path.GetFileName(sumber)
            Dim nmfile1 As String = Path.GetFileName(sumber)
            Dim pathfile As String = Path.GetDirectoryName(sumber)
            Dim currentDate As DateTime = DateTime.Now
            Dim formattedDate As String = currentDate.ToString("ddMMyy")
            Dim filedown As String
            filedown = "AutoUPD_WEB_" & formattedDate & ".csv"
            Dim pathfull As String = pathfile & "\" & filedown
            If File.Exists(pathfull) Then
                File.Delete(pathfull)
            End If

            WriteListViewToCsv(List_zip, pathfull, jenis, idflag, idver)
            result = True
        Catch ex As Exception
            MsgBox(ex.Message)
            result = False
        End Try
        Return result
    End Function

    Sub WriteListViewToCsv(ByVal listView As ListView, ByVal outputFilePath As String, destination As String, upanddown As String, idver As String)
        Dim csvHeader As String = "ID_KONFIGURASI|NAMA_FILE|VERSI_FILE|LAST_MODIFIED|FOLDER|FLAG_UP_DOWN|UPDTIME"

        Using writer As New StreamWriter(outputFilePath)
            writer.WriteLine(csvHeader)
            For Each item As ListViewItem In listView.Items
                Try
                    Dim idKonfigurasi As String = idver
                    Dim namaFile As String = item.Text
                    Dim versiFile As String = item.SubItems(2).Text
                    Dim jam As String = item.SubItems(4).Text

                    ' Pastikan format tanggal di SubItems(3) sesuai dengan "dd/MM/yyyy" atau format yang diinginkan
                    Dim lastModified As DateTime = DateTime.ParseExact(item.SubItems(3).Text, "dd/MM/yyyy", CultureInfo.InvariantCulture)

                    Dim formattedLastModified As String = lastModified.ToString("dd-MM-yyyy")
                    Dim folder As String = destination
                    Dim flagUpDown As String = upanddown
                    Dim updtTime As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")

                    ' Menggabungkan tanggal yang diformat dengan waktu
                    Dim csvLine As String = $"{idKonfigurasi}|{namaFile}|{versiFile}|{formattedLastModified} {jam}|{folder}|{flagUpDown}|{updtTime}"
                    writer.WriteLine(csvLine)
                Catch ex As Exception
                    ' Tangani error, bisa dengan logging atau menampilkan pesan ke user
                    Console.WriteLine($"Error processing item '{item.Text}': {ex.Message}")
                End Try
            Next

        End Using
    End Sub
    Sub ZipFiles(file1Path As String, file2Path As String, zipFilePath As String)
        Using zipStream As ZipOutputStream = New ZipOutputStream(File.Create(zipFilePath))
            AddFileToZip(file1Path, zipStream)
            AddFileToZip(file2Path, zipStream)

        End Using
    End Sub
    Sub AddFileToZip(filePath As String, zipStream As ZipOutputStream)
        Using fs As FileStream = File.OpenRead(filePath)
            Dim entry As ZipEntry = New ZipEntry(Path.GetFileName(filePath))
            zipStream.PutNextEntry(entry)
            Dim buffer As Byte() = New Byte(4096) {}
            Dim bytesRead As Integer
            Do
                bytesRead = fs.Read(buffer, 0, buffer.Length)
                zipStream.Write(buffer, 0, bytesRead)
            Loop While bytesRead > 0
            zipStream.CloseEntry()
        End Using
    End Sub

    Private Sub ck_pos_CheckedChanged(sender As Object, e As EventArgs) Handles ck_pos.CheckedChanged
        If ck_pos.Checked = True Then
            ck_ikiosk.Checked = False
            ck_prg.Checked = False
        End If
    End Sub

    Private Sub ck_ikiosk_CheckedChanged(sender As Object, e As EventArgs) Handles ck_ikiosk.CheckedChanged
        If ck_ikiosk.Checked = True Then
            ck_pos.Checked = False
            ck_prg.Checked = False
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Try
            Dim openfile As OpenFileDialog = New OpenFileDialog
            openfile.InitialDirectory = "D:\#PROGRAM\"
            openfile.Filter = "Zip Files (*.zip)|*.zip"

            If openfile.ShowDialog() = DialogResult.OK Then

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

    End Sub

    Private Sub ck_prg_CheckedChanged(sender As Object, e As EventArgs) Handles ck_prg.CheckedChanged
        If ck_prg.Checked = True Then
            ck_pos.Checked = False
            ck_ikiosk.Checked = False
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Function cekftp(cabang As String) As String
        Dim result As String
        Try
            konek()
            sql = "SELECT SERVER FROM publink.m_cabang WHERE KDCAB='" + cabang + "'"
            cmd = New MySqlCommand(sql, con)
            result = cmd.ExecuteScalar()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            result = ""
        End Try
        Return result
    End Function

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        BackgroundWorker1.RunWorkerAsync()
    End Sub

End Class