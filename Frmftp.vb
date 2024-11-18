Public Class Frmftp
    Private Sub Frmftp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnl_up.Controls.Clear()
        Dim stb As New UCSTBupload
        pnl_up.Controls.Add(stb)

        pnl_del.Controls.Clear()
        Dim del As New UCDelete
        pnl_del.Controls.Add(del)

    End Sub
End Class