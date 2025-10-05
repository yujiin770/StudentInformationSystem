<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.lblTotalStudents = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.GunaPictureBox2 = New Guna.UI.WinForms.GunaPictureBox()
        Me.lblMaleStudents = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.GunaPictureBox3 = New Guna.UI.WinForms.GunaPictureBox()
        Me.lblFemaleStudents = New System.Windows.Forms.Label()
        Me.lblResolvedCases = New System.Windows.Forms.Label()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.TimerDateTime = New System.Windows.Forms.Timer(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanelRecent = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ChartCourseEnrolled = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel9 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BtnExit = New Guna.UI.WinForms.GunaLabel()
        Me.BtnAddRecords = New Guna.UI.WinForms.GunaButton()
        Me.lblTimeandDate = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel3.SuspendLayout()
        CType(Me.GunaPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel4.SuspendLayout()
        CType(Me.ChartCourseEnrolled, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.White
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.Guna2Panel1.BorderRadius = 15
        Me.Guna2Panel1.BorderThickness = 2
        Me.Guna2Panel1.Controls.Add(Me.GunaPictureBox1)
        Me.Guna2Panel1.Controls.Add(Me.lblTotalStudents)
        Me.Guna2Panel1.Controls.Add(Me.Label3)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.White
        Me.Guna2Panel1.Location = New System.Drawing.Point(33, 146)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(281, 162)
        Me.Guna2Panel1.TabIndex = 39
        Me.Guna2Panel1.Visible = False
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = Global.LoginForm.My.Resources.Resources.group
        Me.GunaPictureBox1.Location = New System.Drawing.Point(20, 61)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(80, 71)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaPictureBox1.TabIndex = 40
        Me.GunaPictureBox1.TabStop = False
        '
        'lblTotalStudents
        '
        Me.lblTotalStudents.AutoSize = True
        Me.lblTotalStudents.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalStudents.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalStudents.ForeColor = System.Drawing.Color.Black
        Me.lblTotalStudents.Location = New System.Drawing.Point(137, 81)
        Me.lblTotalStudents.Name = "lblTotalStudents"
        Me.lblTotalStudents.Size = New System.Drawing.Size(95, 37)
        Me.lblTotalStudents.TabIndex = 39
        Me.lblTotalStudents.Text = "1, 247"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(15, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(201, 37)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Total Students"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.White
        Me.Guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.Guna2Panel2.BorderRadius = 15
        Me.Guna2Panel2.BorderThickness = 2
        Me.Guna2Panel2.Controls.Add(Me.GunaPictureBox2)
        Me.Guna2Panel2.Controls.Add(Me.lblMaleStudents)
        Me.Guna2Panel2.Controls.Add(Me.Label4)
        Me.Guna2Panel2.FillColor = System.Drawing.Color.White
        Me.Guna2Panel2.Location = New System.Drawing.Point(358, 146)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(281, 162)
        Me.Guna2Panel2.TabIndex = 42
        Me.Guna2Panel2.Visible = False
        '
        'GunaPictureBox2
        '
        Me.GunaPictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.GunaPictureBox2.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox2.Image = Global.LoginForm.My.Resources.Resources.men
        Me.GunaPictureBox2.Location = New System.Drawing.Point(20, 61)
        Me.GunaPictureBox2.Name = "GunaPictureBox2"
        Me.GunaPictureBox2.Size = New System.Drawing.Size(80, 71)
        Me.GunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaPictureBox2.TabIndex = 41
        Me.GunaPictureBox2.TabStop = False
        '
        'lblMaleStudents
        '
        Me.lblMaleStudents.AutoSize = True
        Me.lblMaleStudents.BackColor = System.Drawing.Color.Transparent
        Me.lblMaleStudents.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaleStudents.ForeColor = System.Drawing.Color.Black
        Me.lblMaleStudents.Location = New System.Drawing.Point(157, 81)
        Me.lblMaleStudents.Name = "lblMaleStudents"
        Me.lblMaleStudents.Size = New System.Drawing.Size(49, 37)
        Me.lblMaleStudents.TabIndex = 40
        Me.lblMaleStudents.Text = "89"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(15, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 37)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Male"
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.White
        Me.Guna2Panel3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.Guna2Panel3.BorderRadius = 15
        Me.Guna2Panel3.BorderThickness = 2
        Me.Guna2Panel3.Controls.Add(Me.GunaPictureBox3)
        Me.Guna2Panel3.Controls.Add(Me.lblFemaleStudents)
        Me.Guna2Panel3.Controls.Add(Me.lblResolvedCases)
        Me.Guna2Panel3.FillColor = System.Drawing.Color.White
        Me.Guna2Panel3.Location = New System.Drawing.Point(676, 146)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(281, 162)
        Me.Guna2Panel3.TabIndex = 40
        Me.Guna2Panel3.Visible = False
        '
        'GunaPictureBox3
        '
        Me.GunaPictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.GunaPictureBox3.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox3.Image = Global.LoginForm.My.Resources.Resources.female
        Me.GunaPictureBox3.Location = New System.Drawing.Point(17, 61)
        Me.GunaPictureBox3.Name = "GunaPictureBox3"
        Me.GunaPictureBox3.Size = New System.Drawing.Size(80, 71)
        Me.GunaPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaPictureBox3.TabIndex = 41
        Me.GunaPictureBox3.TabStop = False
        '
        'lblFemaleStudents
        '
        Me.lblFemaleStudents.AutoSize = True
        Me.lblFemaleStudents.BackColor = System.Drawing.Color.Transparent
        Me.lblFemaleStudents.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFemaleStudents.ForeColor = System.Drawing.Color.Black
        Me.lblFemaleStudents.Location = New System.Drawing.Point(140, 81)
        Me.lblFemaleStudents.Name = "lblFemaleStudents"
        Me.lblFemaleStudents.Size = New System.Drawing.Size(88, 37)
        Me.lblFemaleStudents.TabIndex = 40
        Me.lblFemaleStudents.Text = "1,159"
        '
        'lblResolvedCases
        '
        Me.lblResolvedCases.AutoSize = True
        Me.lblResolvedCases.BackColor = System.Drawing.Color.Transparent
        Me.lblResolvedCases.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResolvedCases.ForeColor = System.Drawing.Color.Black
        Me.lblResolvedCases.Location = New System.Drawing.Point(21, 11)
        Me.lblResolvedCases.Name = "lblResolvedCases"
        Me.lblResolvedCases.Size = New System.Drawing.Size(109, 37)
        Me.lblResolvedCases.TabIndex = 38
        Me.lblResolvedCases.Text = "Female"
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.BackColor = System.Drawing.Color.White
        Me.Guna2Panel4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.Guna2Panel4.BorderRadius = 15
        Me.Guna2Panel4.BorderThickness = 2
        Me.Guna2Panel4.Controls.Add(Me.Label6)
        Me.Guna2Panel4.Controls.Add(Me.FlowLayoutPanelRecent)
        Me.Guna2Panel4.Controls.Add(Me.Label5)
        Me.Guna2Panel4.Controls.Add(Me.ChartCourseEnrolled)
        Me.Guna2Panel4.FillColor = System.Drawing.Color.White
        Me.Guna2Panel4.Location = New System.Drawing.Point(33, 335)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.ShadowDecoration.Parent = Me.Guna2Panel4
        Me.Guna2Panel4.Size = New System.Drawing.Size(922, 407)
        Me.Guna2Panel4.TabIndex = 49
        Me.Guna2Panel4.Visible = False
        '
        'TimerDateTime
        '
        Me.TimerDateTime.Enabled = True
        Me.TimerDateTime.Interval = 1000
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(13, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(232, 40)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "Recently Added"
        '
        'FlowLayoutPanelRecent
        '
        Me.FlowLayoutPanelRecent.BackColor = System.Drawing.Color.White
        Me.FlowLayoutPanelRecent.Location = New System.Drawing.Point(20, 90)
        Me.FlowLayoutPanelRecent.Name = "FlowLayoutPanelRecent"
        Me.FlowLayoutPanelRecent.Size = New System.Drawing.Size(456, 279)
        Me.FlowLayoutPanelRecent.TabIndex = 55
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(482, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(313, 40)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "Enrollment by Course"
        '
        'ChartCourseEnrolled
        '
        Me.ChartCourseEnrolled.BorderlineColor = System.Drawing.Color.WhiteSmoke
        ChartArea2.Name = "ChartArea1"
        Me.ChartCourseEnrolled.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.ChartCourseEnrolled.Legends.Add(Legend2)
        Me.ChartCourseEnrolled.Location = New System.Drawing.Point(469, 75)
        Me.ChartCourseEnrolled.Name = "ChartCourseEnrolled"
        Me.ChartCourseEnrolled.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.ChartCourseEnrolled.Series.Add(Series2)
        Me.ChartCourseEnrolled.Size = New System.Drawing.Size(440, 309)
        Me.ChartCourseEnrolled.TabIndex = 53
        Me.ChartCourseEnrolled.Text = "Chart1"
        '
        'Guna2Panel5
        '
        Me.Guna2Panel5.BackColor = System.Drawing.Color.White
        Me.Guna2Panel5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.Guna2Panel5.BorderRadius = 15
        Me.Guna2Panel5.Controls.Add(Me.Guna2Panel9)
        Me.Guna2Panel5.Controls.Add(Me.Label10)
        Me.Guna2Panel5.Controls.Add(Me.BtnExit)
        Me.Guna2Panel5.Controls.Add(Me.BtnAddRecords)
        Me.Guna2Panel5.Controls.Add(Me.lblTimeandDate)
        Me.Guna2Panel5.Controls.Add(Me.Label2)
        Me.Guna2Panel5.FillColor = System.Drawing.Color.White
        Me.Guna2Panel5.Location = New System.Drawing.Point(22, -1)
        Me.Guna2Panel5.Name = "Guna2Panel5"
        Me.Guna2Panel5.ShadowDecoration.Parent = Me.Guna2Panel5
        Me.Guna2Panel5.Size = New System.Drawing.Size(971, 141)
        Me.Guna2Panel5.TabIndex = 105
        Me.Guna2Panel5.Visible = False
        '
        'Guna2Panel9
        '
        Me.Guna2Panel9.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Guna2Panel9.BorderColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.Guna2Panel9.BorderRadius = 4
        Me.Guna2Panel9.BorderThickness = 2
        Me.Guna2Panel9.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2Panel9.Location = New System.Drawing.Point(11, 60)
        Me.Guna2Panel9.Name = "Guna2Panel9"
        Me.Guna2Panel9.ShadowDecoration.Parent = Me.Guna2Panel9
        Me.Guna2Panel9.Size = New System.Drawing.Size(915, 4)
        Me.Guna2Panel9.TabIndex = 110
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(12, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(485, 47)
        Me.Label10.TabIndex = 109
        Me.Label10.Text = "Student Information System"
        '
        'BtnExit
        '
        Me.BtnExit.AutoSize = True
        Me.BtnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExit.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnExit.Location = New System.Drawing.Point(892, 10)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(43, 39)
        Me.BtnExit.TabIndex = 108
        Me.BtnExit.Text = "X"
        Me.BtnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnAddRecords
        '
        Me.BtnAddRecords.Animated = True
        Me.BtnAddRecords.AnimationHoverSpeed = 0.07!
        Me.BtnAddRecords.AnimationSpeed = 0.03!
        Me.BtnAddRecords.BackColor = System.Drawing.Color.Transparent
        Me.BtnAddRecords.BaseColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BtnAddRecords.BorderColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.BtnAddRecords.BorderSize = 2
        Me.BtnAddRecords.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddRecords.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnAddRecords.FocusedColor = System.Drawing.Color.Empty
        Me.BtnAddRecords.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddRecords.ForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.BtnAddRecords.Image = CType(resources.GetObject("BtnAddRecords.Image"), System.Drawing.Image)
        Me.BtnAddRecords.ImageSize = New System.Drawing.Size(0, 0)
        Me.BtnAddRecords.Location = New System.Drawing.Point(763, 87)
        Me.BtnAddRecords.Name = "BtnAddRecords"
        Me.BtnAddRecords.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.BtnAddRecords.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.BtnAddRecords.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BtnAddRecords.OnHoverImage = Nothing
        Me.BtnAddRecords.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.BtnAddRecords.Radius = 7
        Me.BtnAddRecords.Size = New System.Drawing.Size(170, 38)
        Me.BtnAddRecords.TabIndex = 107
        Me.BtnAddRecords.Text = "Add Records"
        Me.BtnAddRecords.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTimeandDate
        '
        Me.lblTimeandDate.AutoSize = True
        Me.lblTimeandDate.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeandDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblTimeandDate.Location = New System.Drawing.Point(606, 32)
        Me.lblTimeandDate.Name = "lblTimeandDate"
        Me.lblTimeandDate.Size = New System.Drawing.Size(0, 25)
        Me.lblTimeandDate.TabIndex = 106
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(15, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(186, 37)
        Me.Label2.TabIndex = 105
        Me.Label2.Text = "DASHBOARD"
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1005, 768)
        Me.Controls.Add(Me.Guna2Panel5)
        Me.Controls.Add(Me.Guna2Panel4)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        CType(Me.GunaPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel4.PerformLayout()
        CType(Me.ChartCourseEnrolled, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel5.ResumeLayout(False)
        Me.Guna2Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblTotalStudents As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblMaleStudents As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblFemaleStudents As System.Windows.Forms.Label
    Friend WithEvents lblResolvedCases As System.Windows.Forms.Label
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents GunaPictureBox2 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaPictureBox3 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents TimerDateTime As System.Windows.Forms.Timer
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanelRecent As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ChartCourseEnrolled As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel9 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents BtnExit As Guna.UI.WinForms.GunaLabel
    Friend WithEvents BtnAddRecords As Guna.UI.WinForms.GunaButton
    Friend WithEvents lblTimeandDate As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
