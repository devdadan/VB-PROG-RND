<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCTembakSQL
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_sql = New FastColoredTextBoxNS.FastColoredTextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbljmltoko = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.dg_listoko = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbltox = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cb_station = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.cb_cabang = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Cb_jenistoko = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_load = New System.Windows.Forms.Button()
        Me.btn_proses = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.txt_sql, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_listoko, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.75!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.25!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 407.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1065, 577)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel1.Controls.Add(Me.txt_sql)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 34)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1059, 132)
        Me.Panel1.TabIndex = 0
        '
        'txt_sql
        '
        Me.txt_sql.AutoScrollMinSize = New System.Drawing.Size(27, 14)
        Me.txt_sql.BackBrush = Nothing
        Me.txt_sql.CharHeight = 14
        Me.txt_sql.CharWidth = 8
        Me.txt_sql.CommentPrefix = "--"
        Me.txt_sql.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_sql.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.txt_sql.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_sql.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.txt_sql.IsReplaceMode = False
        Me.txt_sql.Language = FastColoredTextBoxNS.Language.SQL
        Me.txt_sql.LeftBracket = Global.Microsoft.VisualBasic.ChrW(40)
        Me.txt_sql.Location = New System.Drawing.Point(0, 0)
        Me.txt_sql.Name = "txt_sql"
        Me.txt_sql.Paddings = New System.Windows.Forms.Padding(0)
        Me.txt_sql.RightBracket = Global.Microsoft.VisualBasic.ChrW(41)
        Me.txt_sql.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_sql.Size = New System.Drawing.Size(1059, 132)
        Me.txt_sql.TabIndex = 0
        Me.txt_sql.Zoom = 100
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.btn_proses)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 172)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1059, 402)
        Me.Panel2.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbljmltoko)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TabControl1)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(242, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(810, 340)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DATA"
        '
        'lbljmltoko
        '
        Me.lbljmltoko.AutoSize = True
        Me.lbljmltoko.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbljmltoko.Location = New System.Drawing.Point(782, 18)
        Me.lbljmltoko.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbljmltoko.Name = "lbljmltoko"
        Me.lbljmltoko.Size = New System.Drawing.Size(12, 15)
        Me.lbljmltoko.TabIndex = 29
        Me.lbljmltoko.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(729, 18)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 15)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "JUMLAH :"
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(3, 16)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(804, 321)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Controls.Add(Me.dg_listoko)
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(796, 290)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "RESULT"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 6)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(781, 278)
        Me.DataGridView1.TabIndex = 2
        '
        'dg_listoko
        '
        Me.dg_listoko.AllowUserToAddRows = False
        Me.dg_listoko.AllowUserToDeleteRows = False
        Me.dg_listoko.AllowUserToOrderColumns = True
        Me.dg_listoko.AllowUserToResizeColumns = False
        Me.dg_listoko.AllowUserToResizeRows = False
        Me.dg_listoko.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_listoko.Location = New System.Drawing.Point(3, 369)
        Me.dg_listoko.Name = "dg_listoko"
        Me.dg_listoko.ReadOnly = True
        Me.dg_listoko.RowHeadersVisible = False
        Me.dg_listoko.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_listoko.Size = New System.Drawing.Size(172, 284)
        Me.dg_listoko.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.TableLayoutPanel2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 27)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(796, 290)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "REPORT"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Teal
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(296, 243)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(494, 42)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "COPY"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.70886!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.29114!))
        Me.TableLayoutPanel2.Controls.Add(Me.TreeView1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.RichTextBox1, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(790, 284)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'TreeView1
        '
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.Location = New System.Drawing.Point(3, 3)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(283, 278)
        Me.TreeView1.TabIndex = 29
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(292, 3)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(494, 231)
        Me.RichTextBox1.TabIndex = 30
        Me.RichTextBox1.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbltox)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.cb_station)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.LinkLabel1)
        Me.GroupBox1.Controls.Add(Me.cb_cabang)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Cb_jenistoko)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btn_load)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(227, 340)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        '
        'lbltox
        '
        Me.lbltox.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltox.Location = New System.Drawing.Point(79, 117)
        Me.lbltox.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbltox.Name = "lbltox"
        Me.lbltox.Size = New System.Drawing.Size(130, 15)
        Me.lbltox.TabIndex = 30
        Me.lbltox.Text = "T000 - NAMA TOKO"
        Me.lbltox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(28, 116)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 15)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Loading : "
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ProgRND.My.Resources.Resources.Cube_1s_200px
        Me.PictureBox1.Location = New System.Drawing.Point(48, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(119, 95)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'cb_station
        '
        Me.cb_station.BackColor = System.Drawing.Color.SteelBlue
        Me.cb_station.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_station.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_station.FormattingEnabled = True
        Me.cb_station.Items.AddRange(New Object() {"POS", "IKIOSK"})
        Me.cb_station.Location = New System.Drawing.Point(5, 203)
        Me.cb_station.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cb_station.Name = "cb_station"
        Me.cb_station.Size = New System.Drawing.Size(216, 23)
        Me.cb_station.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 185)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 15)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "STATION"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(6, 274)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(84, 15)
        Me.LinkLabel1.TabIndex = 25
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "BUKA TOKO.TXT"
        '
        'cb_cabang
        '
        Me.cb_cabang.BackColor = System.Drawing.Color.SteelBlue
        Me.cb_cabang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_cabang.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_cabang.FormattingEnabled = True
        Me.cb_cabang.Location = New System.Drawing.Point(4, 159)
        Me.cb_cabang.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cb_cabang.Name = "cb_cabang"
        Me.cb_cabang.Size = New System.Drawing.Size(217, 23)
        Me.cb_cabang.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(2, 141)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 15)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "CABANG"
        '
        'Cb_jenistoko
        '
        Me.Cb_jenistoko.BackColor = System.Drawing.Color.SteelBlue
        Me.Cb_jenistoko.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_jenistoko.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_jenistoko.FormattingEnabled = True
        Me.Cb_jenistoko.Items.AddRange(New Object() {"ALL TOKO", "ALL TOKO FRC", "ALL TOKO CRM", "ALL TOKO REG", "ALL TOKO SIMULASI", "SOME STORES"})
        Me.Cb_jenistoko.Location = New System.Drawing.Point(4, 246)
        Me.Cb_jenistoko.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Cb_jenistoko.Name = "Cb_jenistoko"
        Me.Cb_jenistoko.Size = New System.Drawing.Size(217, 23)
        Me.Cb_jenistoko.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1, 229)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 15)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "JENIS TOKO"
        '
        'btn_load
        '
        Me.btn_load.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_load.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_load.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_load.FlatAppearance.BorderSize = 0
        Me.btn_load.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btn_load.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_load.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_load.ForeColor = System.Drawing.Color.White
        Me.btn_load.Location = New System.Drawing.Point(6, 292)
        Me.btn_load.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btn_load.Name = "btn_load"
        Me.btn_load.Size = New System.Drawing.Size(215, 42)
        Me.btn_load.TabIndex = 20
        Me.btn_load.Text = "LOAD"
        Me.btn_load.UseVisualStyleBackColor = False
        '
        'btn_proses
        '
        Me.btn_proses.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_proses.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_proses.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_proses.FlatAppearance.BorderSize = 0
        Me.btn_proses.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btn_proses.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_proses.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_proses.ForeColor = System.Drawing.Color.White
        Me.btn_proses.Location = New System.Drawing.Point(9, 353)
        Me.btn_proses.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btn_proses.Name = "btn_proses"
        Me.btn_proses.Size = New System.Drawing.Size(1041, 42)
        Me.btn_proses.TabIndex = 17
        Me.btn_proses.Text = "PROSES"
        Me.btn_proses.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1059, 25)
        Me.Panel3.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.ProgRND.My.Resources.Resources.icons8_close_20
        Me.Button1.Location = New System.Drawing.Point(1037, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(20, 22)
        Me.Button1.TabIndex = 29
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(5, 6)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 16)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "TEMBAK DATABASE SQL"
        '
        'BackgroundWorker1
        '
        '
        'UCTembakSQL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "UCTembakSQL"
        Me.Size = New System.Drawing.Size(1065, 577)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.txt_sql, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_listoko, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txt_sql As FastColoredTextBoxNS.FastColoredTextBox
    Friend WithEvents btn_proses As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_load As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents cb_cabang As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Cb_jenistoko As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents cb_station As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dg_listoko As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents lbljmltoko As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbltox As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
