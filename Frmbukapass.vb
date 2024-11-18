Public Class Frmbukapass
    Public result As Boolean
    Dim nil As Integer

    Private Sub Frmbukapass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        result = False
        nil = 0
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If TextBox1.Text = "wkwk" Then
                result = True
                Me.Close()
            Else
                nil += 1
                If nil = 3 Then
                    MsgBox("Password salah 3x!")
                    Me.Close()
                Else
                    MsgBox("Password salah " & nil & "x!")
                End If
            End If
        End If
    End Sub
End Class
