<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCSTBupload
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cb_jenistoko = New System.Windows.Forms.ComboBox()
        Me.txt_zipfile = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cb_station = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.lbljmltoko = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dg_listoko = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_proses = New System.Windows.Forms.Button()
        Me.lbl_datemodified = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_size = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblnamazip = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.btn_download = New System.Windows.Forms.Button()
        Me.btn_load = New System.Windows.Forms.Button()
        Me.btnopenfile = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dg_listoko, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 86)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "JENIS TOKO"
        '
        'Cb_jenistoko
        '
        Me.Cb_jenistoko.BackColor = System.Drawing.Color.SteelBlue
        Me.Cb_jenistoko.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_jenistoko.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_jenistoko.FormattingEnabled = True
        Me.Cb_jenistoko.Items.AddRange(New Object() {"ALL TOKO", "ALL TOKO FRC", "ALL TOKO CRM", "ALL TOKO REG", "ALL TOKO SIMULASI", "SOME STORES"})
        Me.Cb_jenistoko.Location = New System.Drawing.Point(6, 103)
        Me.Cb_jenistoko.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Cb_jenistoko.Name = "Cb_jenistoko"
        Me.Cb_jenistoko.Size = New System.Drawing.Size(240, 22)
        Me.Cb_jenistoko.TabIndex = 2
        '
        'txt_zipfile
        '
        Me.txt_zipfile.Location = New System.Drawing.Point(6, 19)
        Me.txt_zipfile.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_zipfile.Name = "txt_zipfile"
        Me.txt_zipfile.ReadOnly = True
        Me.txt_zipfile.Size = New System.Drawing.Size(186, 20)
        Me.txt_zipfile.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 2)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "FILE ZIP UPLOAD"
        '
        'cb_station
        '
        Me.cb_station.BackColor = System.Drawing.Color.SteelBlue
        Me.cb_station.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_station.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_station.FormattingEnabled = True
        Me.cb_station.Items.AddRange(New Object() {"POS", "IKIOSK"})
        Me.cb_station.Location = New System.Drawing.Point(7, 61)
        Me.cb_station.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cb_station.Name = "cb_station"
        Me.cb_station.Size = New System.Drawing.Size(240, 22)
        Me.cb_station.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 43)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "STATION"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(262, 28)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(67, 15)
        Me.LinkLabel1.TabIndex = 8
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Buka toko.txt"
        '
        'lbljmltoko
        '
        Me.lbljmltoko.AutoSize = True
        Me.lbljmltoko.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbljmltoko.Location = New System.Drawing.Point(1029, 140)
        Me.lbljmltoko.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbljmltoko.Name = "lbljmltoko"
        Me.lbljmltoko.Size = New System.Drawing.Size(13, 15)
        Me.lbljmltoko.TabIndex = 9
        Me.lbljmltoko.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(953, 140)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 15)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Jumlah Toko :"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.TabControl1)
        Me.Panel2.Controls.Add(Me.btn_proses)
        Me.Panel2.Location = New System.Drawing.Point(2, 134)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1057, 357)
        Me.Panel2.TabIndex = 15
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(6, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1044, 303)
        Me.TabControl1.TabIndex = 17
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dg_listoko)
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1036, 273)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "LIST TOKO"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dg_listoko
        '
        Me.dg_listoko.AllowUserToAddRows = False
        Me.dg_listoko.AllowUserToDeleteRows = False
        Me.dg_listoko.AllowUserToResizeColumns = False
        Me.dg_listoko.AllowUserToResizeRows = False
        Me.dg_listoko.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_listoko.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column6, Me.Column4, Me.Column5})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dg_listoko.DefaultCellStyle = DataGridViewCellStyle1
        Me.dg_listoko.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_listoko.Location = New System.Drawing.Point(3, 3)
        Me.dg_listoko.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dg_listoko.Name = "dg_listoko"
        Me.dg_listoko.ReadOnly = True
        Me.dg_listoko.RowHeadersVisible = False
        Me.dg_listoko.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_listoko.Size = New System.Drawing.Size(1030, 267)
        Me.dg_listoko.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "CABANG"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "KODETOKO"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "NAMATOKO"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 320
        '
        'Column6
        '
        Me.Column6.HeaderText = "STATION"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "IPHOST"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 150
        '
        'Column5
        '
        Me.Column5.HeaderText = "STATUS"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column5.Width = 250
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
        Me.btn_proses.Location = New System.Drawing.Point(7, 312)
        Me.btn_proses.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btn_proses.Name = "btn_proses"
        Me.btn_proses.Size = New System.Drawing.Size(1043, 42)
        Me.btn_proses.TabIndex = 16
        Me.btn_proses.Text = "PROSES"
        Me.btn_proses.UseVisualStyleBackColor = False
        '
        'lbl_datemodified
        '
        Me.lbl_datemodified.AutoSize = True
        Me.lbl_datemodified.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_datemodified.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbl_datemodified.Location = New System.Drawing.Point(754, 105)
        Me.lbl_datemodified.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_datemodified.Name = "lbl_datemodified"
        Me.lbl_datemodified.Size = New System.Drawing.Size(11, 15)
        Me.lbl_datemodified.TabIndex = 5
        Me.lbl_datemodified.Text = "-"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(753, 89)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 15)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "TANGGAL"
        '
        'lbl_size
        '
        Me.lbl_size.AutoSize = True
        Me.lbl_size.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_size.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbl_size.Location = New System.Drawing.Point(653, 106)
        Me.lbl_size.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_size.Name = "lbl_size"
        Me.lbl_size.Size = New System.Drawing.Size(11, 15)
        Me.lbl_size.TabIndex = 3
        Me.lbl_size.Text = "-"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(652, 89)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 15)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "UKURAN FILE"
        '
        'lblnamazip
        '
        Me.lblnamazip.AutoSize = True
        Me.lblnamazip.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnamazip.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblnamazip.Location = New System.Drawing.Point(389, 105)
        Me.lblnamazip.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblnamazip.Name = "lblnamazip"
        Me.lblnamazip.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblnamazip.Size = New System.Drawing.Size(11, 15)
        Me.lblnamazip.TabIndex = 1
        Me.lblnamazip.Text = "-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(389, 89)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "NAMA FILE"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BackgroundWorker1
        '
        '
        'btn_download
        '
        Me.btn_download.BackColor = System.Drawing.Color.Goldenrod
        Me.btn_download.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_download.FlatAppearance.BorderSize = 0
        Me.btn_download.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_download.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_download.ForeColor = System.Drawing.Color.White
        Me.btn_download.Image = Global.ProgRND.My.Resources.Resources.icons8_downloads_folder_25
        Me.btn_download.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_download.Location = New System.Drawing.Point(262, 89)
        Me.btn_download.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btn_download.Name = "btn_download"
        Me.btn_download.Size = New System.Drawing.Size(108, 36)
        Me.btn_download.TabIndex = 18
        Me.btn_download.Text = "Download"
        Me.btn_download.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_download.UseVisualStyleBackColor = False
        '
        'btn_load
        '
        Me.btn_load.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_load.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_load.FlatAppearance.BorderSize = 0
        Me.btn_load.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_load.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_load.ForeColor = System.Drawing.Color.White
        Me.btn_load.Image = Global.ProgRND.My.Resources.Resources.icons8_load_25
        Me.btn_load.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_load.Location = New System.Drawing.Point(262, 47)
        Me.btn_load.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btn_load.Name = "btn_load"
        Me.btn_load.Size = New System.Drawing.Size(108, 36)
        Me.btn_load.TabIndex = 13
        Me.btn_load.Text = "Load Toko"
        Me.btn_load.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_load.UseVisualStyleBackColor = False
        '
        'btnopenfile
        '
        Me.btnopenfile.BackColor = System.Drawing.Color.SteelBlue
        Me.btnopenfile.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.btnopenfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnopenfile.Image = Global.ProgRND.My.Resources.Resources.icons8_browse_folder_20
        Me.btnopenfile.Location = New System.Drawing.Point(199, 18)
        Me.btnopenfile.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnopenfile.Name = "btnopenfile"
        Me.btnopenfile.Size = New System.Drawing.Size(48, 21)
        Me.btnopenfile.TabIndex = 4
        Me.btnopenfile.UseVisualStyleBackColor = False
        '
        'UCSTBupload
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btn_download)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbljmltoko)
        Me.Controls.Add(Me.lbl_datemodified)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lbl_size)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btn_load)
        Me.Controls.Add(Me.lblnamazip)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cb_station)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnopenfile)
        Me.Controls.Add(Me.txt_zipfile)
        Me.Controls.Add(Me.Cb_jenistoko)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "UCSTBupload"
        Me.Size = New System.Drawing.Size(1061, 494)
        Me.Panel2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dg_listoko, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Cb_jenistoko As ComboBox
    Friend WithEvents txt_zipfile As TextBox
    Friend WithEvents btnopenfile As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents cb_station As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents lbljmltoko As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_load As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dg_listoko As DataGridView
    Friend WithEvents lbl_datemodified As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lbl_size As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblnamazip As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btn_proses As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents btn_download As Button
End Class
