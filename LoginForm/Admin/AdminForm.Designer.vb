<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminForm
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
        Dim Animation2 As Guna.UI.Animation.Animation = New Guna.UI.Animation.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminForm))
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.LogoutBtn = New Guna.UI.WinForms.GunaButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnManage = New Guna.UI.WinForms.GunaButton()
        Me.BtnAdd = New Guna.UI.WinForms.GunaButton()
        Me.BtnDashboard = New Guna.UI.WinForms.GunaButton()
        Me.MainPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.GunaTransition1 = New Guna.UI.WinForms.GunaTransition(Me.components)
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Guna2Panel1.BorderRadius = 54
        Me.Guna2Panel1.Controls.Add(Me.LogoutBtn)
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Controls.Add(Me.PictureBox1)
        Me.Guna2Panel1.Controls.Add(Me.BtnManage)
        Me.Guna2Panel1.Controls.Add(Me.BtnAdd)
        Me.Guna2Panel1.Controls.Add(Me.BtnDashboard)
        Me.GunaTransition1.SetDecoration(Me.Guna2Panel1, Guna.UI.Animation.DecorationType.None)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(-43, -1)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(363, 778)
        Me.Guna2Panel1.TabIndex = 15
        '
        'LogoutBtn
        '
        Me.LogoutBtn.Animated = True
        Me.LogoutBtn.AnimationHoverSpeed = 0.07!
        Me.LogoutBtn.AnimationSpeed = 0.03!
        Me.LogoutBtn.BackColor = System.Drawing.Color.Transparent
        Me.LogoutBtn.BaseColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.LogoutBtn.BorderColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.LogoutBtn.BorderSize = 2
        Me.LogoutBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaTransition1.SetDecoration(Me.LogoutBtn, Guna.UI.Animation.DecorationType.None)
        Me.LogoutBtn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.LogoutBtn.FocusedColor = System.Drawing.Color.Empty
        Me.LogoutBtn.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.LogoutBtn.Image = Global.LoginForm.My.Resources.Resources.logout2
        Me.LogoutBtn.ImageOffsetX = 10
        Me.LogoutBtn.ImageSize = New System.Drawing.Size(30, 30)
        Me.LogoutBtn.Location = New System.Drawing.Point(41, 388)
        Me.LogoutBtn.Name = "LogoutBtn"
        Me.LogoutBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.LogoutBtn.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.LogoutBtn.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.LogoutBtn.OnHoverImage = Global.LoginForm.My.Resources.Resources.Logout1
        Me.LogoutBtn.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.LogoutBtn.Radius = 5
        Me.LogoutBtn.Size = New System.Drawing.Size(333, 51)
        Me.LogoutBtn.TabIndex = 37
        Me.LogoutBtn.Text = "Logout"
        Me.LogoutBtn.TextOffsetX = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransition1.SetDecoration(Me.Label2, Guna.UI.Animation.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(59, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(286, 25)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Datamex College of St. Adeline"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransition1.SetDecoration(Me.PictureBox1, Guna.UI.Animation.DecorationType.None)
        Me.PictureBox1.Image = Global.LoginForm.My.Resources.Resources.DATAMEXUPLOGO
        Me.PictureBox1.Location = New System.Drawing.Point(65, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(267, 161)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'BtnManage
        '
        Me.BtnManage.Animated = True
        Me.BtnManage.AnimationHoverSpeed = 0.07!
        Me.BtnManage.AnimationSpeed = 0.03!
        Me.BtnManage.BackColor = System.Drawing.Color.Transparent
        Me.BtnManage.BaseColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.BtnManage.BorderColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.BtnManage.BorderSize = 2
        Me.BtnManage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaTransition1.SetDecoration(Me.BtnManage, Guna.UI.Animation.DecorationType.None)
        Me.BtnManage.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnManage.FocusedColor = System.Drawing.Color.Empty
        Me.BtnManage.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnManage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BtnManage.Image = Global.LoginForm.My.Resources.Resources.record_keeping
        Me.BtnManage.ImageOffsetX = 10
        Me.BtnManage.ImageSize = New System.Drawing.Size(30, 30)
        Me.BtnManage.Location = New System.Drawing.Point(41, 331)
        Me.BtnManage.Name = "BtnManage"
        Me.BtnManage.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BtnManage.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.BtnManage.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.BtnManage.OnHoverImage = Global.LoginForm.My.Resources.Resources.record_keepingRed
        Me.BtnManage.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.BtnManage.Radius = 5
        Me.BtnManage.Size = New System.Drawing.Size(333, 51)
        Me.BtnManage.TabIndex = 32
        Me.BtnManage.Text = "Manage Records"
        Me.BtnManage.TextOffsetX = 17
        '
        'BtnAdd
        '
        Me.BtnAdd.Animated = True
        Me.BtnAdd.AnimationHoverSpeed = 0.07!
        Me.BtnAdd.AnimationSpeed = 0.03!
        Me.BtnAdd.BackColor = System.Drawing.Color.Transparent
        Me.BtnAdd.BaseColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.BtnAdd.BorderColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.BtnAdd.BorderSize = 2
        Me.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaTransition1.SetDecoration(Me.BtnAdd, Guna.UI.Animation.DecorationType.None)
        Me.BtnAdd.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnAdd.FocusedColor = System.Drawing.Color.Empty
        Me.BtnAdd.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BtnAdd.Image = Global.LoginForm.My.Resources.Resources.add
        Me.BtnAdd.ImageOffsetX = 10
        Me.BtnAdd.ImageSize = New System.Drawing.Size(30, 30)
        Me.BtnAdd.Location = New System.Drawing.Point(41, 279)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BtnAdd.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.BtnAdd.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.BtnAdd.OnHoverImage = Global.LoginForm.My.Resources.Resources.addRed
        Me.BtnAdd.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.BtnAdd.Radius = 5
        Me.BtnAdd.Size = New System.Drawing.Size(333, 51)
        Me.BtnAdd.TabIndex = 31
        Me.BtnAdd.Text = "Add Records"
        Me.BtnAdd.TextOffsetX = 17
        '
        'BtnDashboard
        '
        Me.BtnDashboard.Animated = True
        Me.BtnDashboard.AnimationHoverSpeed = 0.07!
        Me.BtnDashboard.AnimationSpeed = 0.03!
        Me.BtnDashboard.BackColor = System.Drawing.Color.Transparent
        Me.BtnDashboard.BaseColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BtnDashboard.BorderColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.BtnDashboard.BorderSize = 2
        Me.BtnDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaTransition1.SetDecoration(Me.BtnDashboard, Guna.UI.Animation.DecorationType.None)
        Me.BtnDashboard.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnDashboard.FocusedColor = System.Drawing.Color.Empty
        Me.BtnDashboard.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDashboard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnDashboard.Image = Global.LoginForm.My.Resources.Resources.DashboardIconRed
        Me.BtnDashboard.ImageOffsetX = 10
        Me.BtnDashboard.ImageSize = New System.Drawing.Size(25, 25)
        Me.BtnDashboard.Location = New System.Drawing.Point(41, 228)
        Me.BtnDashboard.Name = "BtnDashboard"
        Me.BtnDashboard.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BtnDashboard.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.BtnDashboard.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.BtnDashboard.OnHoverImage = Global.LoginForm.My.Resources.Resources.DashboardIconRed
        Me.BtnDashboard.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.BtnDashboard.Radius = 5
        Me.BtnDashboard.Size = New System.Drawing.Size(333, 51)
        Me.BtnDashboard.TabIndex = 30
        Me.BtnDashboard.Text = "Dashboard"
        Me.BtnDashboard.TextOffsetX = 25
        '
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GunaTransition1.SetDecoration(Me.MainPanel, Guna.UI.Animation.DecorationType.None)
        Me.MainPanel.Location = New System.Drawing.Point(314, 1)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.ShadowDecoration.Parent = Me.MainPanel
        Me.MainPanel.Size = New System.Drawing.Size(1012, 768)
        Me.MainPanel.TabIndex = 16
        '
        'GunaTransition1
        '
        Me.GunaTransition1.AnimationType = Guna.UI.Animation.AnimationType.HorizSlide
        Me.GunaTransition1.Cursor = Nothing
        Animation2.AnimateOnlyDifferences = True
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
        Animation2.LeafCoeff = 0.0!
        Animation2.MaxTime = 1.0!
        Animation2.MinTime = 0.0!
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
        Animation2.MosaicSize = 0
        Animation2.Padding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Animation2.RotateCoeff = 0.0!
        Animation2.RotateLimit = 0.0!
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
        Animation2.TimeCoeff = 0.0!
        Animation2.TransparencyCoeff = 0.0!
        Me.GunaTransition1.DefaultAnimation = Animation2
        '
        'AdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1325, 772)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.MainPanel)
        Me.GunaTransition1.SetDecoration(Me, Guna.UI.Animation.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminForm"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnManage As Guna.UI.WinForms.GunaButton
    Friend WithEvents BtnAdd As Guna.UI.WinForms.GunaButton
    Friend WithEvents BtnDashboard As Guna.UI.WinForms.GunaButton
    Friend WithEvents MainPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents LogoutBtn As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaTransition1 As Guna.UI.WinForms.GunaTransition
End Class
