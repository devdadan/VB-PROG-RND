Public Class FrmMain
    Dim a, b As Point
    Dim bit As Integer
    Private Sub btn_ftp_Click(sender As Object, e As EventArgs)
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub btn_home_Click(sender As Object, e As EventArgs)
        ClsApps.Kill()

    End Sub



    Private Sub btn_ftp_Click_1(sender As Object, e As EventArgs) Handles btn_ftp.Click
        btn_ftp.Tag = "Clicked"
        btn_ftp.Invalidate()
        PanelMain.Controls.Clear()
        Dim ftp As New UCFTP
        PanelMain.Controls.Add(ftp)

    End Sub

    Private Sub btn_ftp_Paint(sender As Object, e As PaintEventArgs) Handles btn_ftp.Paint
        If btn_ftp.Tag IsNot Nothing AndAlso btn_ftp.Tag.ToString() = "Clicked" Then
            Dim g As Graphics = e.Graphics
            Dim pen As New Pen(Color.WhiteSmoke)
            g.DrawLine(pen, 0, btn_ftp.Height - 1, btn_ftp.Width, btn_ftp.Height - 1)
        End If
    End Sub
    Private Sub ChangeButtonBorderStyle(clickedButton As Button)
        For Each ctrl As Control In Controls
            If TypeOf ctrl Is Button Then
                Dim button As Button = DirectCast(ctrl, Button)
                button.FlatAppearance.BorderSize = 0
            End If
        Next

        clickedButton.FlatAppearance.BorderSize = 2
        clickedButton.FlatAppearance.BorderColor = Color.Black
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        WindowState = FormWindowState.Minimized
    End Sub
    Public Sub lock()

        btn_ftp.Enabled = False
        btn_aksi.Enabled = True
        btn_sql.Enabled = False
    End Sub
    Public Sub unlock()

        btn_ftp.Enabled = True
        btn_aksi.Enabled = True
        btn_sql.Enabled = True
    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lock()
        If flaglogin <> 1 Then
            Label2.Text = "PLEASE LOGIN FIRST"
        End If
    End Sub

    Private Sub btn_aksi_Click(sender As Object, e As EventArgs) Handles btn_aksi.Click
        SplashScreen1.ShowDialog()
    End Sub

    Private Sub btn_ftp_MouseHover(sender As Object, e As EventArgs) Handles btn_ftp.MouseHover
        Dim toolTip1 As New ToolTip()
        toolTip1.SetToolTip(btn_ftp, "FTP STB")
    End Sub



    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles Button2.MouseHover
        Dim toolTip1 As New ToolTip()
        toolTip1.SetToolTip(Button2, "MINIMIZE")
    End Sub

    Private Sub btn_aksi_MouseHover(sender As Object, e As EventArgs) Handles btn_aksi.MouseHover
        Dim toolTip1 As New ToolTip()
        toolTip1.SetToolTip(btn_aksi, "LOGIN")
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) 

    End Sub
    Private Sub Panel2_MouseDown(sender As Object, e As MouseEventArgs) 
        a = Me.Location
        b = e.Location
        bit = 1
    End Sub

    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) 
        If bit = 1 Then
            Me.Location += (e.Location - b)
            System.Windows.Forms.Cursor.Current = Cursors.Hand
        End If
    End Sub

    Private Sub btn_sql_Click(sender As Object, e As EventArgs) Handles btn_sql.Click
        btn_sql.Tag = "Clicked"
        btn_sql.Invalidate()

        PanelMain.Controls.Clear()
        Dim sql As New UCTembakSQL
        PanelMain.Controls.Add(sql)
    End Sub

    Private Sub Panel2_MouseUp(sender As Object, e As MouseEventArgs) 
        bit = 0
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim waktuSekarang As DateTime = DateTime.Now


        Dim zonaWaktuIndonesia As TimeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time")
        Dim waktuIndonesia As DateTime = TimeZoneInfo.ConvertTime(waktuSekarang, TimeZoneInfo.Local, zonaWaktuIndonesia)
        Dim HariIndonesia As DateTime = TimeZoneInfo.ConvertTime(waktuSekarang, TimeZoneInfo.Local, zonaWaktuIndonesia)
        lbljam.Text = waktuIndonesia.ToString("HH:mm:ss")
        'lblhari.Text = HariIndonesia.ToString("dddd, dd MMMM yyyy")
    End Sub

    Private Sub btn_sql_Paint(sender As Object, e As PaintEventArgs) Handles btn_sql.Paint
        If btn_sql.Tag IsNot Nothing AndAlso btn_sql.Tag.ToString() = "Clicked" Then
            Dim g As Graphics = e.Graphics
            Dim pen As New Pen(Color.WhiteSmoke)
            g.DrawLine(pen, 0, btn_sql.Height - 1, btn_sql.Width, btn_sql.Height - 1)
        End If
    End Sub
End Class