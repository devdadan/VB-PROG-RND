Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Configuration
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Security.Cryptography
Imports System.Text
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Public Class Frmotp
	Private Sub Frmotp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		txt_kdtk.Focus()
	End Sub

	Public Sub cek()
		Dim no As String

		If Me.rbt_lain.Checked Then
			no = Conversions.ToString(16)
		ElseIf Me.rbt_ba.Checked Then
			no = "06"
		ElseIf Me.rbt_socon.Checked Then
			no = "12"
		ElseIf Me.rbt_BASO.Checked Then
			no = "08"
		ElseIf Me.rbt_draft_sn.Checked Then
			no = "03"
		ElseIf Me.RdTakaki.Checked Then
			no = "09"
		ElseIf Me.rbt_rtt.Checked Then
			no = "03"
		ElseIf Me.rbt_nondesc.Checked Then
			no = "03"
		Else
			no = "04"
		End If

		Dim sPassW As String = "K3XN08UTSW53I55MR/XGPL35YQ3G=="
		Dim Key As String = sPassW.Substring(4, 2) + sPassW.Substring(10, 2) + sPassW.Substring(22, 2)
		Dim CTOK As String = Me.txt_kdtk.Text
		Dim str As String = Key + no + CTOK + Strings.Format(DateTime.Now, "yyMMdd")
		Me.TextBox2.Text = Me.Encrypt(str, True, Strings.Left(str, 6))
		Me.TextBox2.Focus()
		Me.TextBox2.SelectAll()
	End Sub
	Public Function Encrypt(toEncrypt As String, useHashing As Boolean, Keynya As String) As String
		Dim jam As String = toEncrypt.Substring(0, 6)
		Dim data As String = toEncrypt.Substring(6)
		Dim toEncryptArray As Byte() = Encoding.UTF8.GetBytes(data)
		Dim settingsReader As AppSettingsReader = New AppSettingsReader()
		Dim keyArray As Byte()
		If useHashing Then
			Dim hashmd5 As MD5CryptoServiceProvider = New MD5CryptoServiceProvider()
			keyArray = hashmd5.ComputeHash(Encoding.UTF8.GetBytes(Keynya))
			hashmd5.Clear()
		Else
			keyArray = Encoding.UTF8.GetBytes(Keynya)
		End If
		Dim tdes As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider()
		tdes.Key = keyArray
		tdes.Mode = CipherMode.ECB
		tdes.Padding = PaddingMode.PKCS7
		Dim resultArray As Byte() = tdes.CreateEncryptor().TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length)
		tdes.Clear()
		Dim hasilenc As String = Convert.ToBase64String(resultArray, 0, resultArray.Length)
		Return String.Concat(New String() {hasilenc.Substring(0, 4), jam.Substring(0, 2), hasilenc.Substring(4, 4), jam.Substring(2, 2), hasilenc.Substring(8, 10), jam.Substring(4, 2), hasilenc.Substring(18)}).ToUpper()
	End Function

	Private Sub txt_kdtk_TextChanged(sender As Object, e As EventArgs) Handles txt_kdtk.TextChanged

	End Sub

	Private Sub txt_kdtk_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_kdtk.KeyDown
		Dim flag As Boolean = e.KeyCode = Keys.[Return]
		If flag Then
			Me.cek()
		End If
	End Sub
End Class