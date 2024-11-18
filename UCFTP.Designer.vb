<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCFTP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCFTP))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btn_upload = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.PanelMenu, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TabControl1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.69606!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.30394!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1067, 579)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.ImageList = Me.ImageList1
        Me.TabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TabControl1.Location = New System.Drawing.Point(3, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1061, 67)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage2.Controls.Add(Me.btn_upload)
        Me.TabPage2.Controls.Add(Me.btn_delete)
        Me.TabPage2.Location = New System.Drawing.Point(4, 27)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1053, 36)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "STB TOKO"
        '
        'btn_upload
        '
        Me.btn_upload.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_upload.FlatAppearance.BorderSize = 0
        Me.btn_upload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_upload.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_upload.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_upload.Location = New System.Drawing.Point(4, 3)
        Me.btn_upload.Name = "btn_upload"
        Me.btn_upload.Size = New System.Drawing.Size(70, 26)
        Me.btn_upload.TabIndex = 2
        Me.btn_upload.Text = "UPLOAD"
        Me.btn_upload.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_delete.FlatAppearance.BorderSize = 0
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_delete.Location = New System.Drawing.Point(80, 3)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(70, 26)
        Me.btn_delete.TabIndex = 1
        Me.btn_delete.Text = "DELETE"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "icons8-upload-16.png")
        Me.ImageList1.Images.SetKeyName(1, "icons8-ftp-16.png")
        '
        'PanelMenu
        '
        Me.PanelMenu.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelMenu.BackColor = System.Drawing.Color.White
        Me.PanelMenu.Location = New System.Drawing.Point(3, 82)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(1061, 494)
        Me.PanelMenu.TabIndex = 1
        '
        'UCFTP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "UCFTP"
        Me.Size = New System.Drawing.Size(1067, 579)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_upload As Button
    Friend WithEvents ImageList1 As ImageList
End Class
