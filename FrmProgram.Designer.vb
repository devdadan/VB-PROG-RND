<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmProgram
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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txt_path = New System.Windows.Forms.TextBox()
        Me.List_zip = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ck_pos = New System.Windows.Forms.CheckBox()
        Me.ck_ikiosk = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ck_prg = New System.Windows.Forms.CheckBox()
        Me.ck_down = New System.Windows.Forms.CheckBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog2"
        '
        'BackgroundWorker1
        '
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(960, 524)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "AUTOUPDCABANG"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.ck_down)
        Me.Panel1.Controls.Add(Me.ck_prg)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.ck_ikiosk)
        Me.Panel1.Controls.Add(Me.ck_pos)
        Me.Panel1.Controls.Add(Me.List_zip)
        Me.Panel1.Controls.Add(Me.txt_path)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(954, 518)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "NAMA FILE ZIP : "
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(881, 15)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(68, 26)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "  ...   "
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txt_path
        '
        Me.txt_path.Location = New System.Drawing.Point(154, 16)
        Me.txt_path.Name = "txt_path"
        Me.txt_path.ReadOnly = True
        Me.txt_path.Size = New System.Drawing.Size(721, 24)
        Me.txt_path.TabIndex = 9
        '
        'List_zip
        '
        Me.List_zip.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.List_zip.GridLines = True
        Me.List_zip.HideSelection = False
        Me.List_zip.Location = New System.Drawing.Point(12, 55)
        Me.List_zip.Name = "List_zip"
        Me.List_zip.Size = New System.Drawing.Size(937, 407)
        Me.List_zip.TabIndex = 5
        Me.List_zip.UseCompatibleStateImageBehavior = False
        Me.List_zip.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Name"
        Me.ColumnHeader1.Width = 400
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "RawSize"
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Version"
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Date"
        Me.ColumnHeader4.Width = 200
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Time"
        Me.ColumnHeader5.Width = 100
        '
        'ck_pos
        '
        Me.ck_pos.AutoSize = True
        Me.ck_pos.Font = New System.Drawing.Font("Consolas", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ck_pos.ForeColor = System.Drawing.Color.White
        Me.ck_pos.Location = New System.Drawing.Point(15, 492)
        Me.ck_pos.Name = "ck_pos"
        Me.ck_pos.Size = New System.Drawing.Size(54, 21)
        Me.ck_pos.TabIndex = 6
        Me.ck_pos.Text = "POS"
        Me.ck_pos.UseVisualStyleBackColor = True
        '
        'ck_ikiosk
        '
        Me.ck_ikiosk.AutoSize = True
        Me.ck_ikiosk.Font = New System.Drawing.Font("Consolas", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ck_ikiosk.ForeColor = System.Drawing.Color.White
        Me.ck_ikiosk.Location = New System.Drawing.Point(75, 492)
        Me.ck_ikiosk.Name = "ck_ikiosk"
        Me.ck_ikiosk.Size = New System.Drawing.Size(78, 21)
        Me.ck_ikiosk.TabIndex = 7
        Me.ck_ikiosk.Text = "IKIOSK"
        Me.ck_ikiosk.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(504, 468)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(445, 45)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "BUAT FILE UPD"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ck_prg
        '
        Me.ck_prg.AutoSize = True
        Me.ck_prg.Font = New System.Drawing.Font("Consolas", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ck_prg.ForeColor = System.Drawing.Color.White
        Me.ck_prg.Location = New System.Drawing.Point(159, 492)
        Me.ck_prg.Name = "ck_prg"
        Me.ck_prg.Size = New System.Drawing.Size(118, 21)
        Me.ck_prg.TabIndex = 12
        Me.ck_prg.Text = "PRG_TAMPUNG"
        Me.ck_prg.UseVisualStyleBackColor = True
        '
        'ck_down
        '
        Me.ck_down.AutoSize = True
        Me.ck_down.Font = New System.Drawing.Font("Consolas", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ck_down.ForeColor = System.Drawing.Color.White
        Me.ck_down.Location = New System.Drawing.Point(15, 468)
        Me.ck_down.Name = "ck_down"
        Me.ck_down.Size = New System.Drawing.Size(102, 21)
        Me.ck_down.TabIndex = 13
        Me.ck_down.Text = "DOWNGRADE"
        Me.ck_down.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(968, 554)
        Me.TabControl1.TabIndex = 14
        '
        'FrmProgram
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(968, 554)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrmProgram"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmProgram"
        Me.TabPage1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ck_down As CheckBox
    Friend WithEvents ck_prg As CheckBox
    Friend WithEvents Button2 As Button
    Friend WithEvents ck_ikiosk As CheckBox
    Friend WithEvents ck_pos As CheckBox
    Friend WithEvents List_zip As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents txt_path As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TabControl1 As TabControl
End Class
