<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTembak
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
        Me.components = New System.ComponentModel.Container()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.q1 = New FastColoredTextBoxNS.FastColoredTextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.lbljmltoko = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cb_jenistoko = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cb_station = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.cb_cabang = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.dg_listoko = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.q1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.dg_listoko, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TabControl2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.23404!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.76596!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(858, 470)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.Location = New System.Drawing.Point(3, 3)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(852, 121)
        Me.TabControl2.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.q1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(844, 95)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Query 1"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'q1
        '
        Me.q1.AutoScrollMinSize = New System.Drawing.Size(27, 14)
        Me.q1.BackBrush = Nothing
        Me.q1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.q1.CharHeight = 14
        Me.q1.CharWidth = 8
        Me.q1.CommentPrefix = "--"
        Me.q1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.q1.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.q1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.q1.IsReplaceMode = False
        Me.q1.Language = FastColoredTextBoxNS.Language.SQL
        Me.q1.LeftBracket = Global.Microsoft.VisualBasic.ChrW(40)
        Me.q1.Location = New System.Drawing.Point(3, 3)
        Me.q1.Name = "q1"
        Me.q1.Paddings = New System.Windows.Forms.Padding(0)
        Me.q1.RightBracket = Global.Microsoft.VisualBasic.ChrW(41)
        Me.q1.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.q1.Size = New System.Drawing.Size(838, 89)
        Me.q1.TabIndex = 0
        Me.q1.Zoom = 100
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.LinkLabel2)
        Me.Panel3.Controls.Add(Me.lbljmltoko)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.cb_jenistoko)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.cb_station)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.LinkLabel1)
        Me.Panel3.Controls.Add(Me.cb_cabang)
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Controls.Add(Me.dg_listoko)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 130)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(852, 337)
        Me.Panel3.TabIndex = 1
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(178, 55)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(97, 13)
        Me.LinkLabel2.TabIndex = 11
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "DATA TEMBAK SQL"
        '
        'lbljmltoko
        '
        Me.lbljmltoko.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbljmltoko.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbljmltoko.Location = New System.Drawing.Point(767, 9)
        Me.lbljmltoko.Name = "lbljmltoko"
        Me.lbljmltoko.Size = New System.Drawing.Size(75, 46)
        Me.lbljmltoko.TabIndex = 10
        Me.lbljmltoko.Text = "0"
        Me.lbljmltoko.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(178, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "TIPE TOKO"
        '
        'cb_jenistoko
        '
        Me.cb_jenistoko.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_jenistoko.FormattingEnabled = True
        Me.cb_jenistoko.Items.AddRange(New Object() {"SEMUA TOKO", "SEMUA TOKO FRC", "SEMUA TOKO CRM", "SEMUA TOKO REG", "SEMUA TOKO SIMULASI", "BEBERAPA TOKO"})
        Me.cb_jenistoko.Location = New System.Drawing.Point(181, 20)
        Me.cb_jenistoko.Name = "cb_jenistoko"
        Me.cb_jenistoko.Size = New System.Drawing.Size(163, 21)
        Me.cb_jenistoko.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "SCHEMA"
        '
        'cb_station
        '
        Me.cb_station.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_station.FormattingEnabled = True
        Me.cb_station.Items.AddRange(New Object() {"POS", "IKIOSKTERMINAL"})
        Me.cb_station.Location = New System.Drawing.Point(9, 20)
        Me.cb_station.Name = "cb_station"
        Me.cb_station.Size = New System.Drawing.Size(163, 21)
        Me.cb_station.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "CABANG"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(178, 68)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(91, 13)
        Me.LinkLabel1.TabIndex = 4
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "BUKA LIST TOKO"
        '
        'cb_cabang
        '
        Me.cb_cabang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_cabang.FormattingEnabled = True
        Me.cb_cabang.Location = New System.Drawing.Point(9, 60)
        Me.cb_cabang.Name = "cb_cabang"
        Me.cb_cabang.Size = New System.Drawing.Size(163, 21)
        Me.cb_cabang.TabIndex = 3
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Location = New System.Drawing.Point(767, 58)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "LOAD TOKO"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'dg_listoko
        '
        Me.dg_listoko.AllowUserToAddRows = False
        Me.dg_listoko.AllowUserToDeleteRows = False
        Me.dg_listoko.AllowUserToResizeColumns = False
        Me.dg_listoko.AllowUserToResizeRows = False
        Me.dg_listoko.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dg_listoko.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_listoko.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_listoko.Location = New System.Drawing.Point(8, 87)
        Me.dg_listoko.Name = "dg_listoko"
        Me.dg_listoko.ReadOnly = True
        Me.dg_listoko.Size = New System.Drawing.Size(834, 203)
        Me.dg_listoko.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(7, 296)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(836, 35)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "PROSES"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BackgroundWorker1
        '
        '
        'FrmTembak
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(858, 470)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrmTembak"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmTembak"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        CType(Me.q1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dg_listoko, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Panel3 As Panel
    Friend WithEvents cb_cabang As ComboBox
    Friend WithEvents Button3 As Button
    Friend WithEvents dg_listoko As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents q1 As FastColoredTextBoxNS.FastColoredTextBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents cb_station As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cb_jenistoko As ComboBox
    Friend WithEvents lbljmltoko As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents LinkLabel2 As LinkLabel
End Class
