Public Class FrmMessage
    Public msgbtn As String
    Public timeclose As Integer
    Public timermsg As Boolean
    Public isipesan As String
    Public pic As String
    Public jenismsg As String
    Private CountDownFrom As TimeSpan
    Private TargetDT As DateTime
    Public flagtanya As Boolean
    Public respons As Boolean
    Public Sub New()
        AddHandler MyBase.Load, AddressOf FrmMessage_Load
        AddHandler MyBase.Paint, AddressOf FrmMessage_Paint
        isipesan = ""
        jenismsg = ""
        Me.timeClose = 60
        Me.timermsg = False

        flagtanya = False
        respons = False
        InitializeComponent()
    End Sub

    Private Sub FrmMessage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbltimeclose.Visible = False

        If jenismsg = "tanya" Then
            btnno.Visible = True
            btnyes.Text = "YES"
            lblpesan.Text = isipesan
            PictureBox1.Image = My.Resources.icons8_question_mark_100__1_1
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
            flagtanya = True
        ElseIf jenismsg = "warning" Then
            btnno.Visible = False
            btnyes.Text = "OK"
            lblpesan.Text = isipesan
            PictureBox1.Image = My.Resources.icons8_x_100
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        ElseIf jenismsg = "exclaimer" Then
            btnno.Visible = False
            btnyes.Text = "OK"
            lblpesan.Text = isipesan
            PictureBox1.Image = My.Resources.icons8_exclamation_mark_100
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        Else
            btnno.Visible = False
            btnyes.Text = "OK"
            lblpesan.Text = isipesan
            PictureBox1.Image = My.Resources.icons8_success_100
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        End If
        If timermsg Then
            lbltimeclose.Visible = True
            Me.CountDownFrom = TimeSpan.FromSeconds(CDbl(Me.timeclose))
            Me.TargetDT = DateTime.Now.Add(Me.CountDownFrom)
            Me.tmrClose.Enabled = True
            Me.tmrClose.Start()
        End If
    End Sub

    Private Sub FrmMessage_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint

    End Sub

    Private Sub tmrClose_Tick(sender As Object, e As EventArgs) Handles tmrClose.Tick
        Dim timeSpan As TimeSpan = Me.TargetDT.Subtract(DateTime.Now)
        Dim flag As Boolean = timeSpan.TotalMilliseconds > 0.0
        If flag Then
            lbltimeclose.Text = Strings.Format(Convert.ToDateTime(timeSpan.ToString()), "HH:mm:ss")
            Application.DoEvents()
        Else
            lbltimeclose.Text = "00:00:00"
            Me.tmrClose.[Stop]()
            If flagtanya Then
                btnno.PerformClick()
            Else
                btnyes.PerformClick()
            End If

        End If
    End Sub

    Private Sub btnyes_Click(sender As Object, e As EventArgs) Handles btnyes.Click
        If flagtanya Then
            respons = True
        End If
        MyBase.Close()
    End Sub

    Private Sub btnno_Click(sender As Object, e As EventArgs) Handles btnno.Click
        If flagtanya Then
            respons = False
        End If
        MyBase.Close()
    End Sub

    Private Sub lblpesan_Click(sender As Object, e As EventArgs) Handles lblpesan.Click

    End Sub
End Class