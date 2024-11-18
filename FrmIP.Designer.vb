<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIP
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dg_ip = New System.Windows.Forms.DataGridView()
        Me.ppos = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TOKO = New System.Windows.Forms.Label()
        Me.CAB = New System.Windows.Forms.Label()
        Me.txtip = New System.Windows.Forms.TextBox()
        Me.txt_cab = New System.Windows.Forms.TextBox()
        Me.txt_toko = New System.Windows.Forms.TextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.CARI = New System.Windows.Forms.Label()
        Me.txt_cari = New System.Windows.Forms.TextBox()
        Me.pkiosk = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.txtmnu = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dg_ip, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.71072!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.28928!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1056, 612)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dg_ip)
        Me.Panel1.Controls.Add(Me.ppos)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 99)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1050, 510)
        Me.Panel1.TabIndex = 0
        '
        'dg_ip
        '
        Me.dg_ip.AllowUserToAddRows = False
        Me.dg_ip.AllowUserToDeleteRows = False
        Me.dg_ip.AllowUserToResizeColumns = False
        Me.dg_ip.AllowUserToResizeRows = False
        Me.dg_ip.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_ip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_ip.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_ip.Location = New System.Drawing.Point(0, 0)
        Me.dg_ip.Name = "dg_ip"
        Me.dg_ip.ReadOnly = True
        Me.dg_ip.RowHeadersWidth = 51
        Me.dg_ip.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_ip.Size = New System.Drawing.Size(1050, 510)
        Me.dg_ip.TabIndex = 0
        '
        'ppos
        '
        Me.ppos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ppos.AutoSize = True
        Me.ppos.Location = New System.Drawing.Point(246, 490)
        Me.ppos.Name = "ppos"
        Me.ppos.Size = New System.Drawing.Size(56, 17)
        Me.ppos.TabIndex = 11
        Me.ppos.Text = "Label3"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.Panel2.Controls.Add(Me.txtmnu)
        Me.Panel2.Controls.Add(Me.LinkLabel2)
        Me.Panel2.Controls.Add(Me.LinkLabel1)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.TOKO)
        Me.Panel2.Controls.Add(Me.CAB)
        Me.Panel2.Controls.Add(Me.txtip)
        Me.Panel2.Controls.Add(Me.txt_cab)
        Me.Panel2.Controls.Add(Me.txt_toko)
        Me.Panel2.Controls.Add(Me.txtpass)
        Me.Panel2.Controls.Add(Me.CARI)
        Me.Panel2.Controls.Add(Me.txt_cari)
        Me.Panel2.Controls.Add(Me.pkiosk)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1050, 90)
        Me.Panel2.TabIndex = 1
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(-134, 36)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(128, 17)
        Me.LinkLabel1.TabIndex = 14
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Load ulang toko"
        Me.LinkLabel1.Visible = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(938, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 51)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "VNC"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(702, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "STATION"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(702, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "IP"
        '
        'TOKO
        '
        Me.TOKO.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TOKO.AutoSize = True
        Me.TOKO.Font = New System.Drawing.Font("Consolas", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TOKO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TOKO.Location = New System.Drawing.Point(497, 33)
        Me.TOKO.Name = "TOKO"
        Me.TOKO.Size = New System.Drawing.Size(40, 17)
        Me.TOKO.TabIndex = 7
        Me.TOKO.Text = "TOKO"
        '
        'CAB
        '
        Me.CAB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CAB.AutoSize = True
        Me.CAB.Font = New System.Drawing.Font("Consolas", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CAB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CAB.Location = New System.Drawing.Point(505, 9)
        Me.CAB.Name = "CAB"
        Me.CAB.Size = New System.Drawing.Size(32, 17)
        Me.CAB.TabIndex = 6
        Me.CAB.Text = "CAB"
        '
        'txtip
        '
        Me.txtip.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtip.Location = New System.Drawing.Point(732, 6)
        Me.txtip.Name = "txtip"
        Me.txtip.Size = New System.Drawing.Size(200, 24)
        Me.txtip.TabIndex = 5
        '
        'txt_cab
        '
        Me.txt_cab.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_cab.Location = New System.Drawing.Point(543, 6)
        Me.txt_cab.Name = "txt_cab"
        Me.txt_cab.Size = New System.Drawing.Size(143, 24)
        Me.txt_cab.TabIndex = 4
        '
        'txt_toko
        '
        Me.txt_toko.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_toko.Location = New System.Drawing.Point(543, 33)
        Me.txt_toko.Name = "txt_toko"
        Me.txt_toko.Size = New System.Drawing.Size(143, 24)
        Me.txt_toko.TabIndex = 3
        '
        'txtpass
        '
        Me.txtpass.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtpass.Location = New System.Drawing.Point(789, 36)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(143, 24)
        Me.txtpass.TabIndex = 2
        '
        'CARI
        '
        Me.CARI.AutoSize = True
        Me.CARI.Font = New System.Drawing.Font("Consolas", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CARI.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CARI.Location = New System.Drawing.Point(5, 12)
        Me.CARI.Name = "CARI"
        Me.CARI.Size = New System.Drawing.Size(40, 17)
        Me.CARI.TabIndex = 1
        Me.CARI.Text = "CARI"
        '
        'txt_cari
        '
        Me.txt_cari.Location = New System.Drawing.Point(51, 9)
        Me.txt_cari.Name = "txt_cari"
        Me.txt_cari.Size = New System.Drawing.Size(191, 24)
        Me.txt_cari.TabIndex = 0
        '
        'pkiosk
        '
        Me.pkiosk.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pkiosk.AutoSize = True
        Me.pkiosk.Location = New System.Drawing.Point(246, 408)
        Me.pkiosk.Name = "pkiosk"
        Me.pkiosk.Size = New System.Drawing.Size(56, 17)
        Me.pkiosk.TabIndex = 12
        Me.pkiosk.Text = "Label3"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(161, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 17)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "pedp"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Font = New System.Drawing.Font("Consolas", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.LinkColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LinkLabel2.Location = New System.Drawing.Point(679, 66)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(104, 17)
        Me.LinkLabel2.TabIndex = 15
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Cek Menu Edp"
        '
        'txtmnu
        '
        Me.txtmnu.Location = New System.Drawing.Point(789, 63)
        Me.txtmnu.Name = "txtmnu"
        Me.txtmnu.Size = New System.Drawing.Size(143, 24)
        Me.txtmnu.TabIndex = 16
        '
        'FrmIP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1056, 612)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "FrmIP"
        Me.Text = "REMOTE TOKO"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dg_ip, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dg_ip As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents CARI As Label
    Friend WithEvents txt_cari As TextBox
    Friend WithEvents txtip As TextBox
    Friend WithEvents txt_cab As TextBox
    Friend WithEvents txt_toko As TextBox
    Friend WithEvents txtpass As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TOKO As Label
    Friend WithEvents CAB As Label
    Friend WithEvents ppos As Label
    Friend WithEvents pkiosk As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents txtmnu As TextBox
End Class
