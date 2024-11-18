Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Public Class Formbarcode
	Private StringArrangementNumeric As String
	Private TATStringArrangement As String
	Private TATStringArrangementNumeric As String
	Public Sub New()
		StringArrangementNumeric = "4702583691"
		InitializeComponent()
		TATStringArrangement = "1THE2QUICK3BROWN4FX5JMPS6V7LAZY8DG90"
		TATStringArrangementNumeric = "4702583691"
	End Sub
	Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

	End Sub
	Private Function Caesar_Encrypt_AllNumeric(PlainText As String, TanggalNpb As String, BulanNpb As String) As String
		Dim text As String = ""
		Dim num As Integer = Conversions.ToInteger(TanggalNpb) + Conversions.ToInteger(BulanNpb)
		If num Mod 10 = 0 Then
			num = 5
		End If
		Dim num2 As Integer = 0
		Dim num3 As Integer = PlainText.Length - 1
		For i As Integer = num2 To num3
			Dim num4 As Integer = Me.StringArrangementNumeric.IndexOf(Conversions.ToString(PlainText(i)))
			Dim num5 As Integer = num Mod Me.StringArrangementNumeric.Length
			Dim text2 As String = Conversions.ToString(Me.StringArrangementNumeric(If((num4 + num5 <= Me.StringArrangementNumeric.Length - 1), (num4 + num5), (num5 - (Me.StringArrangementNumeric.Length - 1 - num4) - 1))))
			text += text2
		Next
		Dim text3 As String = text + num.ToString().PadLeft(2, "0"c)
		Dim num6 As Integer = 0
		Dim num7 As Integer = 0
		Dim num8 As Integer = text3.Length - 1
		For j As Integer = num7 To num8
			Dim text2 As String = Conversions.ToString(text3(j))
			Conversions.ToInteger(text2)
			num6 = CInt(Math.Round(CDbl(num6) + CDbl((j + 1)) * Conversions.ToDouble(text2)))
		Next
		Dim text4 As String = If((text3.Length <> 10), Conversions.ToString(num6 Mod 17), Conversions.ToString(num6 Mod 13))
		If Conversions.ToDouble(text4) = 0.0 Then
			text4 = Conversions.ToString(9)
		End If
		Return text4.PadLeft(2, "0"c) + text
	End Function
	Private Function TATCaesar_Encrypt_AllNumeric(PlainText As String) As String
		Dim text As String = ""
		Dim num As Integer = DateTime.Now.Month + DateTime.Now.Day
		Dim flag As Boolean = num Mod 10 = 0
		Dim flag2 As Boolean = flag
		If flag2 Then
			num = 5
		End If
		Dim num2 As Integer = PlainText.Length - 1
		Dim num3 As Integer = num2
		For i As Integer = 0 To num3
			Dim value As String = Conversions.ToString(PlainText(i))
			Dim num4 As Integer = Me.StringArrangementNumeric.IndexOf(value)
			Dim num5 As Integer = num Mod Me.StringArrangementNumeric.Length
			flag = (num4 + num5 > Me.StringArrangementNumeric.Length - 1)
			Dim flag3 As Boolean = flag
			Dim index As Integer
			If flag3 Then
				index = num5 - (Me.StringArrangementNumeric.Length - 1 - num4) - 1
			Else
				index = num4 + num5
			End If
			Dim str As String = Conversions.ToString(Me.StringArrangementNumeric(index))
			text += str
		Next
		Dim text2 As String = text
		text2 += num.ToString().PadLeft(2, "0"c)
		Dim num6 As Integer = 0
		Dim num7 As Integer = text2.Length - 1
		Dim num8 As Integer = num7
		For j As Integer = 0 To num8
			Dim value2 As String = Conversions.ToString(text2(j))
			Dim num9 As Integer = Conversions.ToInteger(value2)
			num6 = CInt(Math.Round(Math.Round(CDbl(num6) + CDbl((j + 1)) * Conversions.ToDouble(value2))))
		Next
		flag = (text2.Length = 10)
		Dim flag4 As Boolean = flag
		Dim text3 As String
		If flag4 Then
			text3 = Conversions.ToString(num6 Mod 13)
		Else
			text3 = Conversions.ToString(num6 Mod 23)
		End If
		flag = (Conversions.ToDouble(text3) = 0.0)
		Dim flag5 As Boolean = flag
		If flag5 Then
			text3 = Conversions.ToString(9)
		End If
		Return text3.PadLeft(2, "0"c) + text + DateTime.Now.Day.ToString().PadLeft(2, "0"c)
	End Function

	' Token: 0x06000004 RID: 4 RVA: 0x00002224 File Offset: 0x00000424
	Private Function Caesar_Decrypt_AllNumeric(CipherText As String, pass As Integer, daysalah As String) As String
		Dim text As String = ""
		If pass Mod 10 = 0 Then
			pass = 5
		End If
		If CipherText.Length < 10 Then
			text = "00000000000"
		Else
			Dim left As String = CipherText.Substring(CipherText.Length - 2)
			CipherText = CipherText.Substring(0, CipherText.Length - 2)
			If Operators.CompareString(left, daysalah, False) <> 0 Then
				text = "00000000000"
			Else
				Dim num As Integer = 0
				Dim right As String = CipherText.Substring(0, 2)
				CipherText = CipherText.Substring(2)
				CipherText += pass.ToString().PadLeft(2, "0"c)
				Dim num2 As Integer = 0
				Dim num3 As Integer = CipherText.Length - 1
				For i As Integer = num2 To num3
					Dim text2 As String = Conversions.ToString(CipherText(i))
					Conversions.ToInteger(text2)
					num = CInt(Math.Round(CDbl(num) + CDbl((i + 1)) * Conversions.ToDouble(text2)))
				Next
				Dim text3 As String = If((CipherText.Length <> 10), Conversions.ToString(num Mod 23), Conversions.ToString(num Mod 13))
				If Conversions.ToDouble(text3) = 0.0 Then
					text3 = Conversions.ToString(9)
				End If
				If Operators.CompareString(text3.PadLeft(2, "0"c), right, False) <> 0 Then
					text = "00000000000"
				Else
					CipherText = CipherText.Substring(0, CipherText.Length - 2)
					Dim num4 As Integer = 0
					Dim num5 As Integer = CipherText.Length - 1
					For j As Integer = num4 To num5
						Dim num6 As Integer = Me.StringArrangementNumeric.IndexOf(Conversions.ToString(CipherText(j)))
						Dim num7 As Integer = pass Mod Me.StringArrangementNumeric.Length
						Dim text2 As String = Conversions.ToString(Me.StringArrangementNumeric(If((num6 - num7 >= 0), (num6 - num7), (Me.StringArrangementNumeric.Length - num7 - num6))))
						text += text2
					Next
				End If
			End If
		End If
		Return text
	End Function

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Dim plainText As String = Strings.Format(RuntimeHelpers.GetObjectValue(Conversions.ToInteger(Me.TextBox1.Text)), "000000#") + "9998"
		Dim tanggalNpb As String = Conversions.ToString(Me.DateTimePicker1.Value.Month)
		Dim bulanNpb As String = Conversions.ToString(Me.DateTimePicker1.Value.Day)
		Me.TextBox2.Text = Me.Caesar_Encrypt_AllNumeric(plainText, tanggalNpb, bulanNpb)
		TextBox2.Focus()
		TextBox2.SelectAll()
	End Sub
	Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
		Dim flag As Boolean = e.KeyCode = Keys.[Return]
		If flag Then
			Button1.PerformClick()
		End If
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		Dim text As String = TATCaesar_Encrypt_AllNumeric(Me.TextBox3.Text.PadLeft(6, "0"c))
		TextBox4.Text = text
		TextBox4.Focus()
		TextBox4.SelectAll()
	End Sub

	Private Sub TextBox3_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox3.KeyDown
		Dim flag As Boolean = e.KeyCode = Keys.[Return]
		If flag Then
			Me.Button2.PerformClick()
		End If
	End Sub

	Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

	End Sub

	Private Sub Formbarcode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		TextBox1.Focus()
	End Sub
End Class