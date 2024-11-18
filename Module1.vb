Imports MySql.Data.MySqlClient
Module Module1
    Public sql As String
    Public con As MySqlConnection
    Public contok As MySqlConnection
    Public contokki As MySqlConnection
    Public con2 As MySqlConnection
    Public cmd As MySqlCommand
    Public mdr As MySqlDataReader
    Public dt As New DataTable
    Public da As New MySqlDataAdapter
    Public userlogin As String = ""
    Public namauser As String = ""
    Public Mysql As String = "server=192.168.190.100;uid=root;pwd=15032012;database=siedp;Pooling=False;Connection Timeout=120;"
    Public Mysql2 As String = "server=192.168.190.100;uid=root;pwd=15032012;database=db_scrap;Pooling=False;Connection Timeout=120;"

    Public passtok As String
    Public passtok2 As String
    Public passtok3 As String
    Public flaglogin As Integer
    Public Sub konek()
        Try
            con = New MySqlConnection(Mysql)
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
        Catch ex As Exception
            ClsApps.Tulislog("GAGAL KONEK: " & ex.Message)
        End Try
    End Sub

    Public Sub konek3()
        Try
            con2 = New MySqlConnection(Mysql2)
            If con2.State = ConnectionState.Closed Then
                con2.Open()
            End If
        Catch ex As Exception
            ClsApps.Tulislog("GAGAL KONEK: " & ex.Message)
        End Try
    End Sub

    Public Sub ambilpass()
        Try
            konek()
            sql = "SELECT period, period2, period3 FROM versi"
            cmd = New MySqlCommand(sql, con)
            mdr = cmd.ExecuteReader()
            If mdr.Read() Then
                Dim period As String = mdr.GetString(0)
                Dim period2 As String = mdr.GetString(1)
                Dim period3 As String = mdr.GetString(2)

                passtok = ClsApps.GetServer("root", period)
                passtok2 = ClsApps.GetServer("root", period2)
                passtok3 = ClsApps.GetServer("root", period3)
            End If
            mdr.Close()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message + ex.StackTrace)
        End Try
    End Sub


    Public Sub konekiki(ip)
        Try
            Dim iki As String = "server=" + ip + ";uid=ikiosk;pwd=indomaret;database=ikioskterminal;Pooling=False;Connection Timeout=120;"
            contokki = New MySqlConnection(iki)
            If contokki.State = ConnectionState.Closed Then
                contokki.Open()
            End If
        Catch ex As Exception
            ClsApps.Tulislog("GAGAL KONEK: " & ex.Message)
        End Try
    End Sub
    Public Sub konek2(ip As String)
        Try
            Dim conpos As String = "server=" + ip + ";uid=root;pwd=" + passtok + ";database=POS;Pooling=False;Connection Timeout=120;"
            contok = New MySqlConnection(conpos)
            contok.Open()
        Catch ex As Exception
            Try
                Dim conpos As String = "server=" + ip + ";uid=root;pwd=" + passtok + ";database=POS;Pooling=False;Connection Timeout=120;"
                contok = New MySqlConnection(conpos)
                contok.Open()
            Catch ex2 As Exception
                Dim conpos As String = "server=" + ip + ";uid=root;pwd=" + passtok + ";database=POS;Pooling=False;Connection Timeout=120;"
                contok = New MySqlConnection(conpos)
                contok.Open()
            End Try
        End Try
    End Sub


End Module
