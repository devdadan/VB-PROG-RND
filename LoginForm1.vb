Imports MySql.Data.MySqlClient
Imports REG.Fungsi
Public Class LoginForm1

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If UsernameTextBox.Text = "" Or PasswordTextBox.Text = "" Then
            MsgBox("Harap lengkapi form", MsgBoxStyle.Exclamation)
        Else
            konek()

            Try
                Dim nama As String = ""
                Dim pass As String = ""
                nama = UsernameTextBox.Text
                pass = PasswordTextBox.Text

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
                    Frmutama.buka()
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

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
