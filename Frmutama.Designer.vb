<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frmutama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmutama))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SQLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TembakSQLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PassSQLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FTPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UploadFTPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackupIPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PROGRAMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FILEUPDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MASTERPROGRAMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.POSREALTIMEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PosrealtimeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TOLSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PASSWORDOTPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GENERATEPSCPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GENERATEBARCODEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DECRYPTPOSJUALToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip1.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdminToolStripMenuItem, Me.SQLToolStripMenuItem, Me.FTPToolStripMenuItem, Me.IPToolStripMenuItem, Me.PROGRAMToolStripMenuItem, Me.POSREALTIMEToolStripMenuItem, Me.TOLSToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(156, 589)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem})
        Me.AdminToolStripMenuItem.Image = Global.ProgRND.My.Resources.Resources.icons8_login_401
        Me.AdminToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(143, 62)
        Me.AdminToolStripMenuItem.Text = "Admin"
        Me.AdminToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(130, 26)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'SQLToolStripMenuItem
        '
        Me.SQLToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TembakSQLToolStripMenuItem, Me.PassSQLToolStripMenuItem})
        Me.SQLToolStripMenuItem.Image = Global.ProgRND.My.Resources.Resources.icons8_sql_40
        Me.SQLToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SQLToolStripMenuItem.Name = "SQLToolStripMenuItem"
        Me.SQLToolStripMenuItem.Size = New System.Drawing.Size(143, 62)
        Me.SQLToolStripMenuItem.Text = "SQL"
        Me.SQLToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TembakSQLToolStripMenuItem
        '
        Me.TembakSQLToolStripMenuItem.Name = "TembakSQLToolStripMenuItem"
        Me.TembakSQLToolStripMenuItem.Size = New System.Drawing.Size(170, 26)
        Me.TembakSQLToolStripMenuItem.Text = "Tembak SQL"
        '
        'PassSQLToolStripMenuItem
        '
        Me.PassSQLToolStripMenuItem.Name = "PassSQLToolStripMenuItem"
        Me.PassSQLToolStripMenuItem.Size = New System.Drawing.Size(170, 26)
        Me.PassSQLToolStripMenuItem.Text = "Pass SQL"
        '
        'FTPToolStripMenuItem
        '
        Me.FTPToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UploadFTPToolStripMenuItem})
        Me.FTPToolStripMenuItem.Image = Global.ProgRND.My.Resources.Resources.icons8_ftp_40
        Me.FTPToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FTPToolStripMenuItem.Name = "FTPToolStripMenuItem"
        Me.FTPToolStripMenuItem.Size = New System.Drawing.Size(143, 62)
        Me.FTPToolStripMenuItem.Text = "FTP"
        Me.FTPToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'UploadFTPToolStripMenuItem
        '
        Me.UploadFTPToolStripMenuItem.Name = "UploadFTPToolStripMenuItem"
        Me.UploadFTPToolStripMenuItem.Size = New System.Drawing.Size(114, 26)
        Me.UploadFTPToolStripMenuItem.Text = "FTP"
        '
        'IPToolStripMenuItem
        '
        Me.IPToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackupIPToolStripMenuItem})
        Me.IPToolStripMenuItem.Image = Global.ProgRND.My.Resources.Resources.icons8_ipv6_40
        Me.IPToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.IPToolStripMenuItem.Name = "IPToolStripMenuItem"
        Me.IPToolStripMenuItem.Size = New System.Drawing.Size(143, 62)
        Me.IPToolStripMenuItem.Text = "IP"
        Me.IPToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BackupIPToolStripMenuItem
        '
        Me.BackupIPToolStripMenuItem.Name = "BackupIPToolStripMenuItem"
        Me.BackupIPToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.BackupIPToolStripMenuItem.Text = "Remote toko"
        '
        'PROGRAMToolStripMenuItem
        '
        Me.PROGRAMToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FILEUPDToolStripMenuItem, Me.MASTERPROGRAMToolStripMenuItem})
        Me.PROGRAMToolStripMenuItem.Image = Global.ProgRND.My.Resources.Resources.icons8_program_40
        Me.PROGRAMToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PROGRAMToolStripMenuItem.Name = "PROGRAMToolStripMenuItem"
        Me.PROGRAMToolStripMenuItem.Size = New System.Drawing.Size(143, 62)
        Me.PROGRAMToolStripMenuItem.Text = "PROGRAM"
        Me.PROGRAMToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'FILEUPDToolStripMenuItem
        '
        Me.FILEUPDToolStripMenuItem.Name = "FILEUPDToolStripMenuItem"
        Me.FILEUPDToolStripMenuItem.Size = New System.Drawing.Size(202, 26)
        Me.FILEUPDToolStripMenuItem.Text = "FILE UPD"
        '
        'MASTERPROGRAMToolStripMenuItem
        '
        Me.MASTERPROGRAMToolStripMenuItem.Name = "MASTERPROGRAMToolStripMenuItem"
        Me.MASTERPROGRAMToolStripMenuItem.Size = New System.Drawing.Size(202, 26)
        Me.MASTERPROGRAMToolStripMenuItem.Text = "MASTER PROGRAM"
        '
        'POSREALTIMEToolStripMenuItem
        '
        Me.POSREALTIMEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PosrealtimeToolStripMenuItem1})
        Me.POSREALTIMEToolStripMenuItem.Image = Global.ProgRND.My.Resources.Resources.icons8_reload_40
        Me.POSREALTIMEToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.POSREALTIMEToolStripMenuItem.Name = "POSREALTIMEToolStripMenuItem"
        Me.POSREALTIMEToolStripMenuItem.Size = New System.Drawing.Size(143, 62)
        Me.POSREALTIMEToolStripMenuItem.Text = "POSRT"
        Me.POSREALTIMEToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'PosrealtimeToolStripMenuItem1
        '
        Me.PosrealtimeToolStripMenuItem1.Name = "PosrealtimeToolStripMenuItem1"
        Me.PosrealtimeToolStripMenuItem1.Size = New System.Drawing.Size(178, 26)
        Me.PosrealtimeToolStripMenuItem1.Text = "Posrealtime"
        '
        'TOLSToolStripMenuItem
        '
        Me.TOLSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PASSWORDOTPToolStripMenuItem, Me.GENERATEPSCPToolStripMenuItem, Me.GENERATEBARCODEToolStripMenuItem, Me.DECRYPTPOSJUALToolStripMenuItem})
        Me.TOLSToolStripMenuItem.Image = Global.ProgRND.My.Resources.Resources.icons8_tools_40
        Me.TOLSToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TOLSToolStripMenuItem.Name = "TOLSToolStripMenuItem"
        Me.TOLSToolStripMenuItem.Size = New System.Drawing.Size(143, 62)
        Me.TOLSToolStripMenuItem.Text = "TOLS"
        Me.TOLSToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'PASSWORDOTPToolStripMenuItem
        '
        Me.PASSWORDOTPToolStripMenuItem.Name = "PASSWORDOTPToolStripMenuItem"
        Me.PASSWORDOTPToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.PASSWORDOTPToolStripMenuItem.Text = "PASSWORD OTP"
        '
        'GENERATEPSCPToolStripMenuItem
        '
        Me.GENERATEPSCPToolStripMenuItem.Name = "GENERATEPSCPToolStripMenuItem"
        Me.GENERATEPSCPToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.GENERATEPSCPToolStripMenuItem.Text = "GENERATE PSCP"
        '
        'GENERATEBARCODEToolStripMenuItem
        '
        Me.GENERATEBARCODEToolStripMenuItem.Name = "GENERATEBARCODEToolStripMenuItem"
        Me.GENERATEBARCODEToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.GENERATEBARCODEToolStripMenuItem.Text = "GENERATE BARCODE"
        '
        'DECRYPTPOSJUALToolStripMenuItem
        '
        Me.DECRYPTPOSJUALToolStripMenuItem.Name = "DECRYPTPOSJUALToolStripMenuItem"
        Me.DECRYPTPOSJUALToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.DECRYPTPOSJUALToolStripMenuItem.Text = "DECRYPT POS JUAL"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(143, 4)
        '
        'Frmutama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(920, 589)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Frmutama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PROG-RND"
        Me.TransparencyKey = System.Drawing.Color.Red
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SQLToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TembakSQLToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FTPToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UploadFTPToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PassSQLToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IPToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackupIPToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PROGRAMToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FILEUPDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MASTERPROGRAMToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents POSREALTIMEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PosrealtimeToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TOLSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PASSWORDOTPToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GENERATEPSCPToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GENERATEBARCODEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DECRYPTPOSJUALToolStripMenuItem As ToolStripMenuItem
End Class
