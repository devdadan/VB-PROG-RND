<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmftp
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.pnl_up = New System.Windows.Forms.Panel()
        Me.pnl_del = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1087, 604)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TabControl2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1079, 575)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TOKO"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Panel1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1079, 575)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TAMPUNG"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.Location = New System.Drawing.Point(3, 3)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(1073, 569)
        Me.TabControl2.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.pnl_up)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1065, 543)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "UPLOAD"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.pnl_del)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1065, 443)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "DELETE"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'pnl_up
        '
        Me.pnl_up.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_up.Location = New System.Drawing.Point(3, 3)
        Me.pnl_up.Name = "pnl_up"
        Me.pnl_up.Size = New System.Drawing.Size(1059, 537)
        Me.pnl_up.TabIndex = 0
        '
        'pnl_del
        '
        Me.pnl_del.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_del.Location = New System.Drawing.Point(3, 3)
        Me.pnl_del.Name = "pnl_del"
        Me.pnl_del.Size = New System.Drawing.Size(1059, 437)
        Me.pnl_del.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1073, 569)
        Me.Panel1.TabIndex = 0
        '
        'Frmftp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1087, 604)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Frmftp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frmftp"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents pnl_up As Panel
    Friend WithEvents pnl_del As Panel
    Friend WithEvents Panel1 As Panel
End Class
