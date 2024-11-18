Imports MySql.Data.MySqlClient
Imports DevComponents.DotNetBar
Public Class SplashScreen1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim SuperTooltip1 As New SuperTooltip()
        If TextBoxX1.Text = "" Or TextBoxX2.Text = "" Then
            MsgBox("Harap lengkapi form", MsgBoxStyle.Exclamation)
        Else
            konek()

            Try
                Dim nama As String = ""
                Dim pass As String = ""
                nama = TextBoxX1.Text
                pass = TextBoxX2.Text

                sql = "select count(*) from userlogin where recid='' and nik='" + nama + "' and pass=password('" + pass + "')"
                cmd = New MySqlCommand(sql, con)
                If ClsApps.CompareStrings(cmd.ExecuteScalar(), 1) Then
                    sql = "select username from userlogin where nik='" + nama + "'"
                    cmd = New MySqlCommand(sql, con)
                    namauser = cmd.ExecuteScalar()
                    userlogin = nama.ToString
                    FrmMain.Label2.Text = namauser.ToUpper
                    FrmMain.Label2.Visible = True
                    flaglogin = 1
                    FrmMain.unlock()
                    Me.Close()
                Else
                    MsgBox("Data user tidak ditemukan", MsgBoxStyle.Exclamation)
                End If

            Catch ex As Exception
                ClsApps.sqllog(sql)
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub SplashScreen1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class
