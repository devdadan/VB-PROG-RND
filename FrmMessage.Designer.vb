<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMessage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMessage))
        Me.lblpesan = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbltimeclose = New System.Windows.Forms.Label()
        Me.btnno = New System.Windows.Forms.Button()
        Me.btnyes = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.tmrClose = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblpesan
        '
        Me.lblpesan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblpesan.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpesan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblpesan.Location = New System.Drawing.Point(4, 131)
        Me.lblpesan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblpesan.Name = "lblpesan"
        Me.lblpesan.Size = New System.Drawing.Size(544, 74)
        Me.lblpesan.TabIndex = 1
        Me.lblpesan.Text = "Ada report yang belum terproses, proses sekarang?"
        Me.lblpesan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.lbltimeclose)
        Me.Panel1.Controls.Add(Me.btnno)
        Me.Panel1.Controls.Add(Me.btnyes)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 209)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(556, 49)
        Me.Panel1.TabIndex = 2
        '
        'lbltimeclose
        '
        Me.lbltimeclose.AutoSize = True
        Me.lbltimeclose.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltimeclose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbltimeclose.Location = New System.Drawing.Point(480, 15)
        Me.lbltimeclose.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltimeclose.Name = "lbltimeclose"
        Me.lbltimeclose.Size = New System.Drawing.Size(68, 22)
        Me.lbltimeclose.TabIndex = 2
        Me.lbltimeclose.Text = "00:00:00"
        '
        'btnno
        '
        Me.btnno.BackColor = System.Drawing.Color.Gray
        Me.btnno.FlatAppearance.BorderSize = 0
        Me.btnno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnno.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnno.Location = New System.Drawing.Point(120, 5)
        Me.btnno.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnno.Name = "btnno"
        Me.btnno.Size = New System.Drawing.Size(109, 38)
        Me.btnno.TabIndex = 1
        Me.btnno.Text = "NO"
        Me.btnno.UseVisualStyleBackColor = False
        '
        'btnyes
        '
        Me.btnyes.BackColor = System.Drawing.Color.SeaGreen
        Me.btnyes.FlatAppearance.BorderSize = 0
        Me.btnyes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnyes.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnyes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnyes.Location = New System.Drawing.Point(5, 5)
        Me.btnyes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnyes.Name = "btnyes"
        Me.btnyes.Size = New System.Drawing.Size(109, 38)
        Me.btnyes.TabIndex = 0
        Me.btnyes.Text = "YES"
        Me.btnyes.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "x.png")
        Me.ImageList1.Images.SetKeyName(1, "tandatanya.png")
        Me.ImageList1.Images.SetKeyName(2, "tanya.png")
        '
        'tmrClose
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ProgRND.My.Resources.Resources.icons8_success_100
        Me.PictureBox1.Location = New System.Drawing.Point(195, 15)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(139, 112)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'FrmMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(556, 258)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblpesan)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmMessage"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmMessage"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblpesan As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents btnyes As Button
    Friend WithEvents btnno As Button
    Friend WithEvents lbltimeclose As Label
    Friend WithEvents tmrClose As Timer
End Class
