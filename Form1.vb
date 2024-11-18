Imports System.Threading.Tasks
Imports System
Public Class Form1
    Dim a, b As Point
    Dim bit As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub SuperTabControlPanel1_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub btn_ftp_Click(sender As Object, e As EventArgs) Handles btn_ftp.Click
        PanelContent.Controls.Clear()
        Dim ftp As New UCFTP
        PanelContent.Controls.Add(ftp)
        btn_ftp.BackColor = Color.FromArgb(224, 224, 224)
        btn_home.BackColor = Color.Transparent
    End Sub

    Private Sub PanelContent_Paint(sender As Object, e As PaintEventArgs) Handles PanelContent.Paint

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lock()
    End Sub
    Public Sub lock()
        btn_home.Enabled = False
        btn_ftp.Enabled = False
        btn_aksi.Enabled = True
    End Sub
    Public Sub unlock()
        btn_home.Enabled = True
        btn_ftp.Enabled = True
        btn_aksi.Enabled = True
        btn_aksi.Text = "LOGOUT"
    End Sub



    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click
        PanelContent.Controls.Clear()
        btn_home.BackColor = Color.FromArgb(224, 224, 224)
        btn_ftp.BackColor = Color.Transparent

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

    Private Sub Panel2_MouseUp(sender As Object, e As MouseEventArgs)
        bit = 0
    End Sub

    Private Sub btn_ftp_MouseHover(sender As Object, e As EventArgs) Handles btn_ftp.MouseHover
        Dim toolTip1 As New ToolTip()
        toolTip1.SetToolTip(btn_ftp, "FILE TRANSFER PROTOCOL")
    End Sub

    Private Sub btn_aksi_Click(sender As Object, e As EventArgs) Handles btn_aksi.Click
        If btn_aksi.Text = "LOGIN" Then
            SplashScreen1.ShowDialog()
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub btn_home_MouseHover(sender As Object, e As EventArgs) Handles btn_home.MouseHover
        Dim toolTip1 As New ToolTip()
        toolTip1.SetToolTip(btn_home, "HOME")
    End Sub
End Class
