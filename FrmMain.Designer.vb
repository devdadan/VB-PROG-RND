<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_sql = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btn_aksi = New System.Windows.Forms.Button()
        Me.btn_ftp = New System.Windows.Forms.Button()
        Me.PanelMain = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbljam = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.lbljam)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btn_sql)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.btn_aksi)
        Me.Panel1.Controls.Add(Me.btn_ftp)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 615)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1067, 36)
        Me.Panel1.TabIndex = 0
        '
        'btn_sql
        '
        Me.btn_sql.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_sql.BackgroundImage = Global.ProgRND.My.Resources.Resources.icons8_sql_30
        Me.btn_sql.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_sql.FlatAppearance.BorderSize = 0
        Me.btn_sql.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_sql.Location = New System.Drawing.Point(56, 1)
        Me.btn_sql.Name = "btn_sql"
        Me.btn_sql.Size = New System.Drawing.Size(42, 34)
        Me.btn_sql.TabIndex = 5
        Me.btn_sql.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_sql.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackgroundImage = Global.ProgRND.My.Resources.Resources.icons8_minimize_30
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(976, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(43, 38)
        Me.Button2.TabIndex = 4
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btn_aksi
        '
        Me.btn_aksi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_aksi.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btn_aksi.BackgroundImage = Global.ProgRND.My.Resources.Resources.icons8_access_30
        Me.btn_aksi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_aksi.FlatAppearance.BorderSize = 0
        Me.btn_aksi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btn_aksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_aksi.Location = New System.Drawing.Point(1024, -1)
        Me.btn_aksi.Name = "btn_aksi"
        Me.btn_aksi.Size = New System.Drawing.Size(43, 38)
        Me.btn_aksi.TabIndex = 2
        Me.btn_aksi.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_aksi.UseVisualStyleBackColor = False
        '
        'btn_ftp
        '
        Me.btn_ftp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_ftp.BackgroundImage = Global.ProgRND.My.Resources.Resources.icons8_upload_to_the_cloud_30
        Me.btn_ftp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_ftp.FlatAppearance.BorderSize = 0
        Me.btn_ftp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ftp.Location = New System.Drawing.Point(6, 2)
        Me.btn_ftp.Name = "btn_ftp"
        Me.btn_ftp.Size = New System.Drawing.Size(42, 34)
        Me.btn_ftp.TabIndex = 1
        Me.btn_ftp.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_ftp.UseVisualStyleBackColor = True
        '
        'PanelMain
        '
        Me.PanelMain.BackColor = System.Drawing.Color.Gainsboro
        Me.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMain.Location = New System.Drawing.Point(0, 0)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(1067, 615)
        Me.PanelMain.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(802, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(117, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "userlogin"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Visible = False
        '
        'lbljam
        '
        Me.lbljam.AutoSize = True
        Me.lbljam.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbljam.ForeColor = System.Drawing.Color.Silver
        Me.lbljam.Location = New System.Drawing.Point(781, 11)
        Me.lbljam.Name = "lbljam"
        Me.lbljam.Size = New System.Drawing.Size(44, 16)
        Me.lbljam.TabIndex = 0
        Me.lbljam.Text = "00:00:00"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 651)
        Me.Controls.Add(Me.PanelMain)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmMain"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelMain As Panel
    Friend WithEvents btn_ftp As Button
    Friend WithEvents btn_aksi As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_sql As Button
    Friend WithEvents lbljam As Label
    Friend WithEvents Timer1 As Timer
End Class
