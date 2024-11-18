Public Class Formtanya
    Public nilver As String
    Public idconfg As String
    Private Sub Formtanya_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nilver = ""
        idconfg = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("Form wajib diisi")
        Else
            nilver = TextBox1.Text.ToUpper
            idconfg = ComboBox1.Text
            Me.Close()
        End If
    End Sub
End Class