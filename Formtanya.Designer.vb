<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formtanya
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(413, 94)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "AKAN DOWNGRADE PROGRAM SILAHKAN PILIH SETTING DOWNGRADE DIBAWAH INI"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"1", "2"})
        Me.ComboBox1.Location = New System.Drawing.Point(219, 176)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(130, 24)
        Me.ComboBox1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(82, 179)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "FLAG_UP_DOWN :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(79, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ID_KONFIGURASI  :"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(219, 149)
        Me.TextBox1.MaxLength = 9
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(130, 22)
        Me.TextBox1.TabIndex = 5
        Me.TextBox1.Text = "VER-00001"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(219, 206)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 34)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "SIMPAN"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Formtanya
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 252)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Formtanya"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formtanya"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
End Class
