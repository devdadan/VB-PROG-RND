<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCDelete
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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btn_proses = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.dg_listoko = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbljmltoko = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_zipfile = New System.Windows.Forms.TextBox()
        Me.Cb_jenistoko = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_folderstb = New System.Windows.Forms.TextBox()
        Me.btn_load = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.btn_download = New System.Windows.Forms.Button()
        CType(Me.dg_listoko, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btn_proses
        '
        Me.btn_proses.BackColor = System.Drawing.Color.Goldenrod
        Me.btn_proses.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_proses.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btn_proses.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_proses.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_proses.ForeColor = System.Drawing.Color.White
        Me.btn_proses.Location = New System.Drawing.Point(5, 311)
        Me.btn_proses.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btn_proses.Name = "btn_proses"
        Me.btn_proses.Size = New System.Drawing.Size(1028, 42)
        Me.btn_proses.TabIndex = 16
        Me.btn_proses.Text = "PROSES"
        Me.btn_proses.UseVisualStyleBackColor = False
        '
        'BackgroundWorker1
        '
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
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dg_listoko.DefaultCellStyle = DataGridViewCellStyle1
        Me.dg_listoko.Location = New System.Drawing.Point(5, 22)
        Me.dg_listoko.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dg_listoko.Name = "dg_listoko"
        Me.dg_listoko.ReadOnly = True
        Me.dg_listoko.RowHeadersVisible = False
        Me.dg_listoko.Size = New System.Drawing.Size(1029, 283)
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
        Me.Column3.Width = 330
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
        Me.Column5.Width = 150
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Panel2.Controls.Add(Me.dg_listoko)
        Me.Panel2.Controls.Add(Me.btn_proses)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.lbljmltoko)
        Me.Panel2.Location = New System.Drawing.Point(6, 127)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1047, 359)
        Me.Panel2.TabIndex = 33
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 4)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 15)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Jumlah Toko :"
        '
        'lbljmltoko
        '
        Me.lbljmltoko.AutoSize = True
        Me.lbljmltoko.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbljmltoko.Location = New System.Drawing.Point(80, 5)
        Me.lbljmltoko.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbljmltoko.Name = "lbljmltoko"
        Me.lbljmltoko.Size = New System.Drawing.Size(13, 15)
        Me.lbljmltoko.TabIndex = 9
        Me.lbljmltoko.Text = "0"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(269, 24)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(67, 15)
        Me.LinkLabel1.TabIndex = 31
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Buka toko.txt"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 5)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 15)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "FILE NAME"
        '
        'txt_zipfile
        '
        Me.txt_zipfile.Location = New System.Drawing.Point(11, 22)
        Me.txt_zipfile.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_zipfile.Name = "txt_zipfile"
        Me.txt_zipfile.Size = New System.Drawing.Size(241, 20)
        Me.txt_zipfile.TabIndex = 24
        '
        'Cb_jenistoko
        '
        Me.Cb_jenistoko.BackColor = System.Drawing.Color.Goldenrod
        Me.Cb_jenistoko.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_jenistoko.FormattingEnabled = True
        Me.Cb_jenistoko.Items.AddRange(New Object() {"ALL TOKO", "ALL TOKO FRC", "ALL TOKO CRM", "ALL TOKO REG", "ALL TOKO SIMULASI", "SOME STORES"})
        Me.Cb_jenistoko.Location = New System.Drawing.Point(11, 99)
        Me.Cb_jenistoko.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Cb_jenistoko.Name = "Cb_jenistoko"
        Me.Cb_jenistoko.Size = New System.Drawing.Size(240, 21)
        Me.Cb_jenistoko.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 82)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 15)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "JENIS TOKO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 43)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 15)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "FOLDER STB"
        '
        'txt_folderstb
        '
        Me.txt_folderstb.Location = New System.Drawing.Point(11, 60)
        Me.txt_folderstb.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_folderstb.Name = "txt_folderstb"
        Me.txt_folderstb.Size = New System.Drawing.Size(241, 20)
        Me.txt_folderstb.TabIndex = 35
        '
        'btn_load
        '
        Me.btn_load.BackColor = System.Drawing.Color.Goldenrod
        Me.btn_load.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_load.FlatAppearance.BorderSize = 0
        Me.btn_load.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_load.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_load.ForeColor = System.Drawing.Color.White
        Me.btn_load.Image = Global.ProgRND.My.Resources.Resources.icons8_delete_file_25
        Me.btn_load.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_load.Location = New System.Drawing.Point(269, 43)
        Me.btn_load.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btn_load.Name = "btn_load"
        Me.btn_load.Size = New System.Drawing.Size(108, 36)
        Me.btn_load.TabIndex = 32
        Me.btn_load.Text = "Load Toko"
        Me.btn_load.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_load.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(383, 104)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(124, 17)
        Me.CheckBox1.TabIndex = 37
        Me.CheckBox1.Text = "Tampilkan jumlah file"
        Me.CheckBox1.UseVisualStyleBackColor = True
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
        Me.btn_download.Location = New System.Drawing.Point(269, 84)
        Me.btn_download.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btn_download.Name = "btn_download"
        Me.btn_download.Size = New System.Drawing.Size(108, 36)
        Me.btn_download.TabIndex = 38
        Me.btn_download.Text = "Download"
        Me.btn_download.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_download.UseVisualStyleBackColor = False
        '
        'UCDelete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btn_download)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_folderstb)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btn_load)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_zipfile)
        Me.Controls.Add(Me.Cb_jenistoko)
        Me.Controls.Add(Me.Label1)
        Me.Name = "UCDelete"
        Me.Size = New System.Drawing.Size(1061, 494)
        CType(Me.dg_listoko, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btn_proses As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents dg_listoko As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents lbljmltoko As Label
    Friend WithEvents btn_load As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_zipfile As TextBox
    Friend WithEvents Cb_jenistoko As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_folderstb As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents btn_download As Button
End Class
