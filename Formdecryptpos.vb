Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Security.Cryptography
Imports System.Text
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Public Class Formdecryptpos
	Private MyKey As String
	Private _EncSaltValue As String

	Private strFileToEncrypt As String
	Private strFileToDecrypt As String
	Private strOutputEncrypt As String
	Private strOutputDecrypt As String
	Private fsInput As FileStream
	Private fsOutput As FileStream
	Private Enum CryptoAction
		ActionEncrypt = 1
		ActionDecrypt
	End Enum
	Public Sub New()

		MyKey = "chrysan87"
		InitializeComponent()

	End Sub
	Private Sub Formdecryptpos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub
	Private Sub EncryptOrDecryptFile(strInputFile As String, strOutputFile As String, bytKey As Byte(), bytIV As Byte(), Direction As Formdecryptpos.CryptoAction)
		Me.fsInput = New FileStream(strInputFile, FileMode.Open, FileAccess.Read)
		Me.fsOutput = New FileStream(strOutputFile, FileMode.OpenOrCreate, FileAccess.Write)
		Me.fsOutput.SetLength(0L)
		Dim bytBuffer As Byte() = New Byte(4096) {}
		Dim lngBytesProcessed As Long = 0L
		Dim lngFileLength As Long = Me.fsInput.Length
		Dim cspRijndael As RijndaelManaged = New RijndaelManaged()
		Dim csCryptoStream As CryptoStream
		Select Case Direction
			Case Formdecryptpos.CryptoAction.ActionEncrypt
				csCryptoStream = New CryptoStream(Me.fsOutput, cspRijndael.CreateEncryptor(bytKey, bytIV), CryptoStreamMode.Write)
			Case Formdecryptpos.CryptoAction.ActionDecrypt
				csCryptoStream = New CryptoStream(Me.fsOutput, cspRijndael.CreateDecryptor(bytKey, bytIV), CryptoStreamMode.Write)
		End Select
		While lngBytesProcessed < lngFileLength
			Dim intBytesInCurrentBlock As Integer = Me.fsInput.Read(bytBuffer, 0, 4096)
			csCryptoStream.Write(bytBuffer, 0, intBytesInCurrentBlock)
			lngBytesProcessed += CLng(intBytesInCurrentBlock)
		End While
		csCryptoStream.Close()
		Me.fsInput.Close()
		Me.fsOutput.Close()
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		Dim flag As Boolean = File.Exists(Me.TextBox1.Text)
		If flag Then
			Dim Filename As String = Me.TextBox1.Text.Replace(".txt", "_Decrypt.txt")
			Dim bytKey As Byte() = Me.CreateKey("chrysan")
			Dim bytIV As Byte() = Me.CreateIV("chrysan")
			Me.EncryptOrDecryptFile(Me.TextBox1.Text, Filename, bytKey, bytIV, Formdecryptpos.CryptoAction.ActionDecrypt)
			MsgBox("File berhasil di decrypt", MsgBoxStyle.Information)
			Process.Start(Filename)
		End If
	End Sub
	Private Function CreateKey(strPassword As String) As Byte()
		Dim chrData As Char() = strPassword.ToCharArray()
		Dim intLength As Integer = chrData.GetUpperBound(0)
		Dim bytDataToHash As Byte() = New Byte(intLength + 1 - 1) {}
		Dim num As Integer = 0
		Dim upperBound As Integer = chrData.GetUpperBound(0)
		Dim i As Integer = num
		Dim num3 As Integer
		While True
			Dim num2 As Integer = i
			num3 = upperBound
			If num2 > num3 Then
				Exit While
			End If
			bytDataToHash(i) = CByte(Strings.Asc(chrData(i)))
			i += 1
		End While
		Dim SHA512 As SHA512Managed = New SHA512Managed()
		Dim bytResult As Byte() = SHA512.ComputeHash(bytDataToHash)
		Dim bytKey As Byte() = New Byte(31) {}
		Dim j As Integer = 0
		Dim num4 As Integer
		Do
			bytKey(j) = bytResult(j)
			j += 1
			num4 = j
			num3 = 31
		Loop While num4 <= num3
		Return bytKey
	End Function
	Private Function CreateIV(strPassword As String) As Byte()
		Dim chrData As Char() = strPassword.ToCharArray()
		Dim intLength As Integer = chrData.GetUpperBound(0)
		Dim bytDataToHash As Byte() = New Byte(intLength + 1 - 1) {}
		Dim num As Integer = 0
		Dim upperBound As Integer = chrData.GetUpperBound(0)
		Dim i As Integer = num
		Dim num3 As Integer
		While True
			Dim num2 As Integer = i
			num3 = upperBound
			If num2 > num3 Then
				Exit While
			End If
			bytDataToHash(i) = CByte(Strings.Asc(chrData(i)))
			i += 1
		End While
		Dim SHA512 As SHA512Managed = New SHA512Managed()
		Dim bytResult As Byte() = SHA512.ComputeHash(bytDataToHash)
		Dim bytIV As Byte() = New Byte(15) {}
		Dim j As Integer = 32
		Dim num4 As Integer
		Do
			bytIV(j - 32) = bytResult(j)
			j += 1
			num4 = j
			num3 = 47
		Loop While num4 <= num3
		Return bytIV
	End Function

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Dim flag As Boolean = Me.OpenFileDialog1.ShowDialog() = DialogResult.OK
		If flag Then
			Me.TextBox1.Text = Me.OpenFileDialog1.FileName
		End If
	End Sub
End Class