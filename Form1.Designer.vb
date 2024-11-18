<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelContent = New System.Windows.Forms.Panel()
        Me.btn_aksi = New System.Windows.Forms.Button()
        Me.btn_ftp = New System.Windows.Forms.Button()
        Me.btn_home = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btn_aksi)
        Me.Panel1.Controls.Add(Me.btn_ftp)
        Me.Panel1.Controls.Add(Me.btn_home)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(61, 556)
        Me.Panel1.TabIndex = 0
        '
        'PanelContent
        '
        Me.PanelContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContent.Location = New System.Drawing.Point(61, 0)
        Me.PanelContent.Name = "PanelContent"
        Me.PanelContent.Size = New System.Drawing.Size(902, 556)
        Me.PanelContent.TabIndex = 1
        '
        'btn_aksi
        '
        Me.btn_aksi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_aksi.FlatAppearance.BorderSize = 0
        Me.btn_aksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_aksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_aksi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_aksi.Image = Global.ProgRND.My.Resources.Resources.icons8_login_401
        Me.btn_aksi.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_aksi.Location = New System.Drawing.Point(2, 496)
        Me.btn_aksi.Name = "btn_aksi"
        Me.btn_aksi.Size = New System.Drawing.Size(58, 57)
        Me.btn_aksi.TabIndex = 2
        Me.btn_aksi.Text = "LOGIN"
        Me.btn_aksi.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_aksi.UseVisualStyleBackColor = True
        '
        'btn_ftp
        '
        Me.btn_ftp.FlatAppearance.BorderSize = 0
        Me.btn_ftp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ftp.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ftp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_ftp.Image = Global.ProgRND.My.Resources.Resources.icons8_ftp_40
        Me.btn_ftp.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_ftp.Location = New System.Drawing.Point(2, 61)
        Me.btn_ftp.Name = "btn_ftp"
        Me.btn_ftp.Size = New System.Drawing.Size(58, 57)
        Me.btn_ftp.TabIndex = 1
        Me.btn_ftp.Text = "FTP"
        Me.btn_ftp.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_ftp.UseVisualStyleBackColor = True
        '
        'btn_home
        '
        Me.btn_home.FlatAppearance.BorderSize = 0
        Me.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_home.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_home.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_home.Image = Global.ProgRND.My.Resources.Resources.icons8_speed_30
        Me.btn_home.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_home.Location = New System.Drawing.Point(2, 3)
        Me.btn_home.Name = "btn_home"
        Me.btn_home.Size = New System.Drawing.Size(58, 57)
        Me.btn_home.TabIndex = 0
        Me.btn_home.Text = "Home"
        Me.btn_home.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_home.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(3, 448)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(55, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(963, 556)
        Me.Controls.Add(Me.PanelContent)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_home As Button
    Friend WithEvents btn_ftp As Button
    Friend WithEvents PanelContent As Panel
    Friend WithEvents btn_aksi As Button
    Friend WithEvents Button1 As Button
End Class
