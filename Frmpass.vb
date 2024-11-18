Public Class Frmpass
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pass1 As String = ClsApps.GetServer("root", TextBox1.Text)
        Dim pass2 As String = ClsApps.GetServer("kasir", TextBox1.Text)
        TextBox2.Text = pass1
        TextBox3.Text = pass2
    End Sub
End Class