Public Class UCFTP
    Private stbup As UCSTBupload
    Private stbdel As UCDelete
    Private Sub btn_upload_Click(sender As Object, e As EventArgs) Handles btn_upload.Click

        PanelMenu.Controls.Clear()
        Dim stb As New UCSTBupload
        PanelMenu.Controls.Add(stb)
        'If stbup Is Nothing Then
        '    stbup = New UCSTBupload()
        '    AddHandler stbup.UserControlClosed, AddressOf ChildFormClosed
        'End If

        'stbup.BringToFront()
        'stbup.Show()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        PanelMenu.Controls.Clear()
        Dim stb1 As New UCDelete
        PanelMenu.Controls.Add(stb1)
    End Sub
    Private Sub UCFTP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabPage2.ImageIndex = 0
        TabPage2.Text = "STB TOKO"

    End Sub
    Public Sub ftpuoloadon()
        btn_upload.BackColor = Color.SteelBlue
        btn_delete.BackColor = Color.SlateGray

    End Sub
    Public Sub ftpuoloadof()
        btn_upload.BackColor = Color.SlateGray
        btn_delete.BackColor = Color.SteelBlue

    End Sub
    Private Sub ChildFormClosed(sender As Object, e As FormClosedEventArgs)
        If TypeOf sender Is UCSTBupload Then
            stbup = Nothing
        ElseIf TypeOf sender Is UCDelete Then
            stbdel = Nothing
        End If
    End Sub

End Class
