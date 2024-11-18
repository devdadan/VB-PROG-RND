Public Class Frmutama
    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        Dim frm0 As New LoginForm1
        frm0.MdiParent = Me
        frm0.Show()
    End Sub

    Private Sub Frmutama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tutup()
    End Sub
    Public Sub buka()
        TembakSQLToolStripMenuItem.Enabled = True
        UploadFTPToolStripMenuItem.Enabled = True
        PassSQLToolStripMenuItem.Enabled = True
        BackupIPToolStripMenuItem.Enabled = True
        LoginToolStripMenuItem.Enabled = False
        PosrealtimeToolStripMenuItem1.Enabled = True
        FILEUPDToolStripMenuItem.Enabled = True
        MASTERPROGRAMToolStripMenuItem.Enabled = False
        GENERATEPSCPToolStripMenuItem.Enabled = True
        PASSWORDOTPToolStripMenuItem.Enabled = True
        FILEUPDToolStripMenuItem.Enabled = True
        GENERATEBARCODEToolStripMenuItem.Enabled = True
        DECRYPTPOSJUALToolStripMenuItem.Enabled = True
    End Sub
    Public Sub tutup()
        TembakSQLToolStripMenuItem.Enabled = False
        UploadFTPToolStripMenuItem.Enabled = False
        PassSQLToolStripMenuItem.Enabled = False
        BackupIPToolStripMenuItem.Enabled = False
        LoginToolStripMenuItem.Enabled = True
        PosrealtimeToolStripMenuItem1.Enabled = False
        FILEUPDToolStripMenuItem.Enabled = False
        MASTERPROGRAMToolStripMenuItem.Enabled = False
        GENERATEPSCPToolStripMenuItem.Enabled = False
        PASSWORDOTPToolStripMenuItem.Enabled = False
        FILEUPDToolStripMenuItem.Enabled = False
        GENERATEBARCODEToolStripMenuItem.Enabled = False
        DECRYPTPOSJUALToolStripMenuItem.Enabled = False
    End Sub

    Private Sub TembakSQLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TembakSQLToolStripMenuItem.Click
        Dim frm1 As New FrmTembak
        frm1.MdiParent = Me
        frm1.Dock = DockStyle.Fill
        frm1.WindowState = FormWindowState.Maximized
        frm1.Show()
    End Sub

    Private Sub DeleteFTPToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PassSQLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PassSQLToolStripMenuItem.Click
        Dim frmpass As New Frmbukapass
        frmpass.ShowDialog()
        If frmpass.result Then
            Dim frm2 As New Frmpass
            frm2.MdiParent = Me
            frm2.WindowState = FormWindowState.Normal
            frm2.Show()
        Else

        End If

    End Sub

    Private Sub UploadFTPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UploadFTPToolStripMenuItem.Click
        Dim frm3 As New Frmftp
        frm3.MdiParent = Me
        frm3.WindowState = FormWindowState.Normal
        frm3.Show()

    End Sub

    Private Sub BackupIPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackupIPToolStripMenuItem.Click
        Dim frm4 As New FrmIP
        frm4.MdiParent = Me
        frm4.WindowState = FormWindowState.Normal
        frm4.Show()
    End Sub

    Private Sub FILEUPDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FILEUPDToolStripMenuItem.Click
        Dim frm5 As New FrmProgram
        frm5.MdiParent = Me
        frm5.WindowState = FormWindowState.Normal
        frm5.Show()
    End Sub

    Private Sub MASTERPROGRAMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MASTERPROGRAMToolStripMenuItem.Click
        Dim frm6 As New FrmHome
        frm6.MdiParent = Me
        frm6.WindowState = FormWindowState.Normal
        frm6.Show()
    End Sub

    Private Sub PROGRAMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PROGRAMToolStripMenuItem.Click

    End Sub

    Private Sub POSREALTIMEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles POSREALTIMEToolStripMenuItem.Click

    End Sub

    Private Sub PosrealtimeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PosrealtimeToolStripMenuItem1.Click
        Dim frm7 As New Formposrt
        frm7.MdiParent = Me
        frm7.WindowState = FormWindowState.Normal
        frm7.Show()
    End Sub

    Private Sub TOLSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TOLSToolStripMenuItem.Click

    End Sub

    Private Sub PASSWORDOTPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PASSWORDOTPToolStripMenuItem.Click
        Dim frm8 As New Frmotp
        frm8.MdiParent = Me
        frm8.WindowState = FormWindowState.Normal
        frm8.Show()
    End Sub

    Private Sub GENERATEPSCPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GENERATEPSCPToolStripMenuItem.Click
        Dim frm9 As New Formpscp
        frm9.MdiParent = Me
        frm9.WindowState = FormWindowState.Normal
        frm9.Show()
    End Sub

    Private Sub GENERATEBARCODEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GENERATEBARCODEToolStripMenuItem.Click
        Dim frm10 As New Formbarcode
        frm10.MdiParent = Me
        frm10.WindowState = FormWindowState.Normal
        frm10.Show()
    End Sub

    Private Sub DECRYPTPOSJUALToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DECRYPTPOSJUALToolStripMenuItem.Click
        Dim frm11 As New Formdecryptpos
        frm11.MdiParent = Me
        frm11.WindowState = FormWindowState.Normal
        frm11.Show()
    End Sub
End Class