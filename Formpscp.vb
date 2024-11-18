Imports MySql.Data.MySqlClient
Public Class Formpscp
	Private connectionString As String

	Private Sub Formpscp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		namadt3()
	End Sub
	Public Sub namadt3()
		Dim dateTime As DateTime = DateTime.Today.AddDays(0.0)
		Dim str As String
		Select Case dateTime.Month
			Case 10
				str = "A"
			Case 11
				str = "B"
			Case 12
				str = "C"
			Case Else
				str = dateTime.Month.ToString()
		End Select
		Dim text As String = "DT*" + dateTime.Year.ToString().Substring(3, 1) + str + dateTime.Day.ToString("00")
		Me.TextBox2.Text = text
	End Sub
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Try
			Clipboard.SetText(Me.TextBox3.Text)
			Application.DoEvents()
			Me.ToolTip1.Show("Text Berhasil di Copy", Me.TextBox3, 600)
			Me.TextBox3.Focus()
			Me.TextBox3.SelectAll()
		Catch ex As Exception
			Me.ToolTip1.Show("Gagal Copy Text", Me.TextBox3, 600)
		End Try
	End Sub

	Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

	End Sub

	Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
		Using mySqlConnection As MySqlConnection = New MySqlConnection(Me.connectionString)
			Dim flag As Boolean = e.KeyCode = Keys.[Return]
			If flag Then
				Dim flag2 As Boolean = Me.TextBox1.TextLength = 4
				If flag2 Then
					Try
						Dim user As String = ""
						Dim pass As String = ""
						Dim host As String = ""
						Dim port As String = ""

						Select Case ComboBox1.Text
							Case "G001"
								user = "edp_ams_jkt1"
								pass = "edp@ams001"
								host = "172.24.31.95"
								port = "21"
							Case "G027"
								user = "edp_ams_bdg"
								pass = "edp@ams027"
								host = "172.24.31.72"
								port = "21" ' Ganti sesuai nilai yang sesuai
							Case "G080"
								user = "edp_ams_pwk"
								pass = "edp@ams080"
								host = "172.24.31.97"
								port = "21" ' Ganti sesuai nilai yang sesuai
							Case "G105"
								user = "edp_ams_bks"
								pass = "edp@ams105"
								host = "172.24.31.80"
								port = "21" ' Ganti sesuai nilai yang sesuai
							Case "G137"
								user = "edp_ams_jkt2"
								pass = "edp@ams137"
								host = "172.24.31.94"
								port = "21" ' Ganti sesuai nilai yang sesuai
							Case "G049"
								user = "edp_ams_pku"
								pass = "edp@ams049"
								host = "172.24.31.89"
								port = "21" ' Ganti sesuai nilai yang sesuai
							Case "G116"
								user = "edp_ams_btm"
								pass = "edp@ams116"
								host = "172.24.31.99"
								port = "21" ' Ganti sesuai nilai yang sesuai
							Case "G219"
								user = "edp_ams_tpg"
								pass = "edp@ams219"
								host = "172.24.31.116"
								port = "21" ' Ganti sesuai nilai yang sesuai
							Case "G259"
								user = "edp_ams_nad"
								pass = "edp@ams259"
								host = "172.24.31.117"
								port = "21" ' Ganti sesuai nilai yang sesuai
							Case "G257"
								user = "edp_ams_stb"
								pass = "edp@ams257"
								host = "172.24.31.119"
								port = "21" ' Ganti sesuai nilai yang sesuai
							Case "G009"
								user = "edp_ams_mdn"
								pass = "edp@ams009"
								host = "172.24.31.100"
								port = "21" ' Ganti sesuai nilai yang sesuai
							Case "G218"
								user = "edp_ams_nias"
								pass = "edp@ams218"
								host = "172.24.31.109"
								port = "21"
							Case Else
								MessageBox.Show("Cabang tidak ditemukan.")
						End Select
						Me.TextBox3.Text = String.Concat(New String() {String.Format("d:\backoff\pscp -scp -unsafe -pw {0} {1}@{2}:sent/", pass, user, host), Me.TextBox2.Text, Me.TextBox1.Text.Substring(0, 1).ToUpper(), ".", Me.TextBox1.Text.Substring(1).ToUpper(), " D:\idm"})
						Me.Button1.PerformClick()

					Catch ex As Exception
						Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, Nothing)
					End Try
				End If
			End If
		End Using
	End Sub
End Class