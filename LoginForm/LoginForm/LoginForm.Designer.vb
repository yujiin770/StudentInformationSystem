﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Dim Animation1 As Guna.UI.Animation.Animation = New Guna.UI.Animation.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Dim Animation2 As Guna.UI.Animation.Animation = New Guna.UI.Animation.Animation()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnShowHide = New Guna.UI.WinForms.GunaButton()
        Me.LoginLoading = New Guna.UI2.WinForms.Guna2WinProgressIndicator()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaButton2 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.BtnExit = New Guna.UI.WinForms.GunaLabel()
        Me.FrgtPassword = New Guna.UI.WinForms.GunaLinkLabel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.BtnLogin = New Guna.UI.WinForms.GunaButton()
        Me.PasswordTextBox = New Guna.UI.WinForms.GunaTextBox()
        Me.UsernameTxtBox = New Guna.UI.WinForms.GunaTextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GunaTransition1 = New Guna.UI.WinForms.GunaTransition(Me.components)
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.ExitPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.BtnNo = New Guna.UI.WinForms.GunaButton()
        Me.GunaLabel9 = New Guna.UI.WinForms.GunaLabel()
        Me.BtnYes = New Guna.UI.WinForms.GunaButton()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaTransition2 = New Guna.UI.WinForms.GunaTransition(Me.components)
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ExitPanel.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnShowHide)
        Me.Panel1.Controls.Add(Me.LoginLoading)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.GunaLabel2)
        Me.Panel1.Controls.Add(Me.GunaLabel4)
        Me.Panel1.Controls.Add(Me.GunaButton2)
        Me.Panel1.Controls.Add(Me.GunaButton1)
        Me.Panel1.Controls.Add(Me.BtnExit)
        Me.Panel1.Controls.Add(Me.FrgtPassword)
        Me.Panel1.Controls.Add(Me.GunaLabel6)
        Me.Panel1.Controls.Add(Me.GunaLabel5)
        Me.Panel1.Controls.Add(Me.BtnLogin)
        Me.Panel1.Controls.Add(Me.PasswordTextBox)
        Me.Panel1.Controls.Add(Me.UsernameTxtBox)
        Me.GunaTransition1.SetDecoration(Me.Panel1, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition2.SetDecoration(Me.Panel1, Guna.UI.Animation.DecorationType.None)
        Me.Panel1.Location = New System.Drawing.Point(602, -3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(880, 835)
        Me.Panel1.TabIndex = 11
        Me.Panel1.Visible = False
        '
        'btnShowHide
        '
        Me.btnShowHide.Animated = True
        Me.btnShowHide.AnimationHoverSpeed = 0.07!
        Me.btnShowHide.AnimationSpeed = 0.03!
        Me.btnShowHide.BackColor = System.Drawing.Color.Transparent
        Me.btnShowHide.BaseColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.btnShowHide.BorderColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.btnShowHide.BorderSize = 3
        Me.btnShowHide.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaTransition1.SetDecoration(Me.btnShowHide, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition2.SetDecoration(Me.btnShowHide, Guna.UI.Animation.DecorationType.None)
        Me.btnShowHide.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnShowHide.FocusedColor = System.Drawing.Color.Empty
        Me.btnShowHide.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowHide.ForeColor = System.Drawing.Color.White
        Me.btnShowHide.Image = CType(resources.GetObject("btnShowHide.Image"), System.Drawing.Image)
        Me.btnShowHide.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnShowHide.Location = New System.Drawing.Point(443, 564)
        Me.btnShowHide.Name = "btnShowHide"
        Me.btnShowHide.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.btnShowHide.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.btnShowHide.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.btnShowHide.OnHoverImage = Nothing
        Me.btnShowHide.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.btnShowHide.Radius = 15
        Me.btnShowHide.Size = New System.Drawing.Size(48, 44)
        Me.btnShowHide.TabIndex = 30
        Me.btnShowHide.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LoginLoading
        '
        Me.LoginLoading.AnimationSpeed = 79
        Me.LoginLoading.AutoStart = True
        Me.LoginLoading.BackColor = System.Drawing.Color.Transparent
        Me.LoginLoading.CircleSize = 2.0!
        Me.GunaTransition2.SetDecoration(Me.LoginLoading, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition1.SetDecoration(Me.LoginLoading, Guna.UI.Animation.DecorationType.None)
        Me.LoginLoading.Location = New System.Drawing.Point(272, 481)
        Me.LoginLoading.Name = "LoginLoading"
        Me.LoginLoading.NumberOfCircles = 9
        Me.LoginLoading.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.LoginLoading.Size = New System.Drawing.Size(114, 114)
        Me.LoginLoading.TabIndex = 29
        Me.LoginLoading.UseTransparentBackground = True
        Me.LoginLoading.Visible = False
        '
        'PictureBox1
        '
        Me.GunaTransition1.SetDecoration(Me.PictureBox1, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition2.SetDecoration(Me.PictureBox1, Guna.UI.Animation.DecorationType.None)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(233, 144)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(281, 182)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'GunaLabel2
        '
        Me.GunaLabel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.GunaTransition1.SetDecoration(Me.GunaLabel2, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition2.SetDecoration(Me.GunaLabel2, Guna.UI.Animation.DecorationType.None)
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GunaLabel2.Location = New System.Drawing.Point(70, 96)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(601, 59)
        Me.GunaLabel2.TabIndex = 24
        Me.GunaLabel2.Text = "OF SAINT ADELINE"
        Me.GunaLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GunaLabel4
        '
        Me.GunaLabel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.GunaTransition1.SetDecoration(Me.GunaLabel4, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition2.SetDecoration(Me.GunaLabel4, Guna.UI.Animation.DecorationType.None)
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GunaLabel4.Location = New System.Drawing.Point(70, 49)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(601, 59)
        Me.GunaLabel4.TabIndex = 23
        Me.GunaLabel4.Text = "DATAMEX COLLEGE "
        Me.GunaLabel4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GunaButton2
        '
        Me.GunaButton2.Animated = True
        Me.GunaButton2.AnimationHoverSpeed = 0.07!
        Me.GunaButton2.AnimationSpeed = 0.03!
        Me.GunaButton2.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.GunaButton2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.GunaButton2.BorderSize = 3
        Me.GunaButton2.Cursor = System.Windows.Forms.Cursors.Default
        Me.GunaTransition1.SetDecoration(Me.GunaButton2, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition2.SetDecoration(Me.GunaButton2, Guna.UI.Animation.DecorationType.None)
        Me.GunaButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton2.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GunaButton2.Image = CType(resources.GetObject("GunaButton2.Image"), System.Drawing.Image)
        Me.GunaButton2.ImageSize = New System.Drawing.Size(30, 30)
        Me.GunaButton2.Location = New System.Drawing.Point(202, 564)
        Me.GunaButton2.Name = "GunaButton2"
        Me.GunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.GunaButton2.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.GunaButton2.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.GunaButton2.OnHoverImage = Nothing
        Me.GunaButton2.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.GunaButton2.Radius = 15
        Me.GunaButton2.Size = New System.Drawing.Size(48, 44)
        Me.GunaButton2.TabIndex = 22
        Me.GunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaButton1
        '
        Me.GunaButton1.Animated = True
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.GunaButton1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.GunaButton1.BorderSize = 3
        Me.GunaButton1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GunaTransition1.SetDecoration(Me.GunaButton1, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition2.SetDecoration(Me.GunaButton1, Guna.UI.Animation.DecorationType.None)
        Me.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GunaButton1.Image = CType(resources.GetObject("GunaButton1.Image"), System.Drawing.Image)
        Me.GunaButton1.ImageSize = New System.Drawing.Size(30, 30)
        Me.GunaButton1.Location = New System.Drawing.Point(202, 469)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.GunaButton1.Radius = 15
        Me.GunaButton1.Size = New System.Drawing.Size(48, 44)
        Me.GunaButton1.TabIndex = 21
        Me.GunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnExit
        '
        Me.BtnExit.AutoSize = True
        Me.BtnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaTransition1.SetDecoration(Me.BtnExit, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition2.SetDecoration(Me.BtnExit, Guna.UI.Animation.DecorationType.None)
        Me.BtnExit.Font = New System.Drawing.Font("Segoe UI Black", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BtnExit.Location = New System.Drawing.Point(684, 11)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(48, 50)
        Me.BtnExit.TabIndex = 20
        Me.BtnExit.Text = "X"
        Me.BtnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrgtPassword
        '
        Me.FrgtPassword.AutoSize = True
        Me.GunaTransition1.SetDecoration(Me.FrgtPassword, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition2.SetDecoration(Me.FrgtPassword, Guna.UI.Animation.DecorationType.None)
        Me.FrgtPassword.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FrgtPassword.LinkColor = System.Drawing.Color.White
        Me.FrgtPassword.Location = New System.Drawing.Point(285, 692)
        Me.FrgtPassword.Name = "FrgtPassword"
        Me.FrgtPassword.Size = New System.Drawing.Size(160, 25)
        Me.FrgtPassword.TabIndex = 19
        Me.FrgtPassword.TabStop = True
        Me.FrgtPassword.Text = "Forgot Password?"
        '
        'GunaLabel6
        '
        Me.GunaLabel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.GunaTransition1.SetDecoration(Me.GunaLabel6, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition2.SetDecoration(Me.GunaLabel6, Guna.UI.Animation.DecorationType.None)
        Me.GunaLabel6.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.ForeColor = System.Drawing.Color.White
        Me.GunaLabel6.Location = New System.Drawing.Point(186, 519)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(154, 34)
        Me.GunaLabel6.TabIndex = 18
        Me.GunaLabel6.Text = "Password:"
        Me.GunaLabel6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GunaLabel5
        '
        Me.GunaLabel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.GunaTransition1.SetDecoration(Me.GunaLabel5, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition2.SetDecoration(Me.GunaLabel5, Guna.UI.Animation.DecorationType.None)
        Me.GunaLabel5.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.ForeColor = System.Drawing.Color.White
        Me.GunaLabel5.Location = New System.Drawing.Point(186, 427)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(154, 34)
        Me.GunaLabel5.TabIndex = 17
        Me.GunaLabel5.Text = "Username:"
        Me.GunaLabel5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BtnLogin
        '
        Me.BtnLogin.Animated = True
        Me.BtnLogin.AnimationHoverSpeed = 0.07!
        Me.BtnLogin.AnimationSpeed = 0.03!
        Me.BtnLogin.BackColor = System.Drawing.Color.Transparent
        Me.BtnLogin.BaseColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.BtnLogin.BorderColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BtnLogin.BorderSize = 3
        Me.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaTransition1.SetDecoration(Me.BtnLogin, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition2.SetDecoration(Me.BtnLogin, Guna.UI.Animation.DecorationType.None)
        Me.BtnLogin.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnLogin.FocusedColor = System.Drawing.Color.Empty
        Me.BtnLogin.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BtnLogin.Image = CType(resources.GetObject("BtnLogin.Image"), System.Drawing.Image)
        Me.BtnLogin.ImageSize = New System.Drawing.Size(0, 0)
        Me.BtnLogin.Location = New System.Drawing.Point(193, 632)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BtnLogin.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.BtnLogin.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.BtnLogin.OnHoverImage = Nothing
        Me.BtnLogin.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.BtnLogin.Radius = 7
        Me.BtnLogin.Size = New System.Drawing.Size(310, 47)
        Me.BtnLogin.TabIndex = 16
        Me.BtnLogin.Text = "Login"
        Me.BtnLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.BackColor = System.Drawing.Color.Transparent
        Me.PasswordTextBox.BaseColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.PasswordTextBox.BorderColor = System.Drawing.Color.White
        Me.PasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTransition1.SetDecoration(Me.PasswordTextBox, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition2.SetDecoration(Me.PasswordTextBox, Guna.UI.Animation.DecorationType.None)
        Me.PasswordTextBox.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.PasswordTextBox.FocusedBorderColor = System.Drawing.Color.White
        Me.PasswordTextBox.FocusedForeColor = System.Drawing.Color.White
        Me.PasswordTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTextBox.ForeColor = System.Drawing.Color.White
        Me.PasswordTextBox.Location = New System.Drawing.Point(193, 560)
        Me.PasswordTextBox.MaxLength = 10
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Radius = 10
        Me.PasswordTextBox.SelectedText = ""
        Me.PasswordTextBox.Size = New System.Drawing.Size(310, 51)
        Me.PasswordTextBox.TabIndex = 11
        Me.PasswordTextBox.TextOffsetX = 55
        '
        'UsernameTxtBox
        '
        Me.UsernameTxtBox.BackColor = System.Drawing.Color.Transparent
        Me.UsernameTxtBox.BaseColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.UsernameTxtBox.BorderColor = System.Drawing.Color.White
        Me.UsernameTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTransition1.SetDecoration(Me.UsernameTxtBox, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition2.SetDecoration(Me.UsernameTxtBox, Guna.UI.Animation.DecorationType.None)
        Me.UsernameTxtBox.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.UsernameTxtBox.FocusedBorderColor = System.Drawing.Color.White
        Me.UsernameTxtBox.FocusedForeColor = System.Drawing.Color.White
        Me.UsernameTxtBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameTxtBox.ForeColor = System.Drawing.Color.White
        Me.UsernameTxtBox.Location = New System.Drawing.Point(193, 465)
        Me.UsernameTxtBox.Name = "UsernameTxtBox"
        Me.UsernameTxtBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UsernameTxtBox.Radius = 10
        Me.UsernameTxtBox.SelectedText = ""
        Me.UsernameTxtBox.Size = New System.Drawing.Size(310, 51)
        Me.UsernameTxtBox.TabIndex = 10
        Me.UsernameTxtBox.TextOffsetX = 55
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'GunaTransition1
        '
        Me.GunaTransition1.AnimationType = Guna.UI.Animation.AnimationType.HorizBlind
        Me.GunaTransition1.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0.0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0.0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0.0!
        Animation1.RotateLimit = 0.0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0.0!
        Animation1.TransparencyCoeff = 0.0!
        Me.GunaTransition1.DefaultAnimation = Animation1
        Me.GunaTransition1.MaxAnimationTime = 3500
        '
        'GunaLabel3
        '
        Me.GunaLabel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GunaTransition1.SetDecoration(Me.GunaLabel3, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition2.SetDecoration(Me.GunaLabel3, Guna.UI.Animation.DecorationType.None)
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.GunaLabel3.Location = New System.Drawing.Point(42, 120)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(528, 76)
        Me.GunaLabel3.TabIndex = 41
        Me.GunaLabel3.Text = "SYSTEM"
        Me.GunaLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.GunaLabel3.Visible = False
        '
        'GunaLabel1
        '
        Me.GunaLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GunaTransition1.SetDecoration(Me.GunaLabel1, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition2.SetDecoration(Me.GunaLabel1, Guna.UI.Animation.DecorationType.None)
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(27, 61)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(553, 59)
        Me.GunaLabel1.TabIndex = 40
        Me.GunaLabel1.Text = "STUDENT INFORMATION"
        Me.GunaLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.GunaLabel1.Visible = False
        '
        'ExitPanel
        '
        Me.ExitPanel.BackColor = System.Drawing.Color.Transparent
        Me.ExitPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.ExitPanel.BorderRadius = 10
        Me.ExitPanel.BorderThickness = 3
        Me.ExitPanel.Controls.Add(Me.Guna2Panel2)
        Me.ExitPanel.Controls.Add(Me.BtnYes)
        Me.ExitPanel.Controls.Add(Me.GunaLabel7)
        Me.ExitPanel.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GunaTransition1.SetDecoration(Me.ExitPanel, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition2.SetDecoration(Me.ExitPanel, Guna.UI.Animation.DecorationType.None)
        Me.ExitPanel.FillColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.ExitPanel.Location = New System.Drawing.Point(465, 308)
        Me.ExitPanel.Name = "ExitPanel"
        Me.ExitPanel.ShadowDecoration.Parent = Me.ExitPanel
        Me.ExitPanel.Size = New System.Drawing.Size(295, 195)
        Me.ExitPanel.TabIndex = 42
        Me.ExitPanel.Visible = False
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Guna2Panel2.BorderColor = System.Drawing.Color.White
        Me.Guna2Panel2.BorderRadius = 10
        Me.Guna2Panel2.BorderThickness = 3
        Me.Guna2Panel2.Controls.Add(Me.BtnNo)
        Me.Guna2Panel2.Controls.Add(Me.GunaLabel9)
        Me.Guna2Panel2.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GunaTransition1.SetDecoration(Me.Guna2Panel2, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition2.SetDecoration(Me.Guna2Panel2, Guna.UI.Animation.DecorationType.None)
        Me.Guna2Panel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Guna2Panel2.Location = New System.Drawing.Point(139, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(153, 195)
        Me.Guna2Panel2.TabIndex = 21
        '
        'BtnNo
        '
        Me.BtnNo.Animated = True
        Me.BtnNo.AnimationHoverSpeed = 0.07!
        Me.BtnNo.AnimationSpeed = 0.03!
        Me.BtnNo.BackColor = System.Drawing.Color.Transparent
        Me.BtnNo.BaseColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BtnNo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnNo.BorderSize = 3
        Me.BtnNo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaTransition1.SetDecoration(Me.BtnNo, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition2.SetDecoration(Me.BtnNo, Guna.UI.Animation.DecorationType.None)
        Me.BtnNo.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnNo.FocusedColor = System.Drawing.Color.Empty
        Me.BtnNo.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnNo.Image = CType(resources.GetObject("BtnNo.Image"), System.Drawing.Image)
        Me.BtnNo.ImageSize = New System.Drawing.Size(0, 0)
        Me.BtnNo.Location = New System.Drawing.Point(32, 119)
        Me.BtnNo.Name = "BtnNo"
        Me.BtnNo.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnNo.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BtnNo.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BtnNo.OnHoverImage = Nothing
        Me.BtnNo.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnNo.Radius = 15
        Me.BtnNo.Size = New System.Drawing.Size(89, 47)
        Me.BtnNo.TabIndex = 19
        Me.BtnNo.Text = "No"
        Me.BtnNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel9
        '
        Me.GunaLabel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GunaTransition1.SetDecoration(Me.GunaLabel9, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition2.SetDecoration(Me.GunaLabel9, Guna.UI.Animation.DecorationType.None)
        Me.GunaLabel9.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.GunaLabel9.Location = New System.Drawing.Point(4, 43)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.Size = New System.Drawing.Size(146, 24)
        Me.GunaLabel9.TabIndex = 18
        Me.GunaLabel9.Text = "you want to Exit?"
        Me.GunaLabel9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BtnYes
        '
        Me.BtnYes.Animated = True
        Me.BtnYes.AnimationHoverSpeed = 0.07!
        Me.BtnYes.AnimationSpeed = 0.03!
        Me.BtnYes.BackColor = System.Drawing.Color.Transparent
        Me.BtnYes.BaseColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.BtnYes.BorderColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BtnYes.BorderSize = 3
        Me.BtnYes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaTransition1.SetDecoration(Me.BtnYes, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition2.SetDecoration(Me.BtnYes, Guna.UI.Animation.DecorationType.None)
        Me.BtnYes.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnYes.FocusedColor = System.Drawing.Color.Empty
        Me.BtnYes.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnYes.ForeColor = System.Drawing.Color.White
        Me.BtnYes.Image = CType(resources.GetObject("BtnYes.Image"), System.Drawing.Image)
        Me.BtnYes.ImageSize = New System.Drawing.Size(0, 0)
        Me.BtnYes.Location = New System.Drawing.Point(34, 119)
        Me.BtnYes.Name = "BtnYes"
        Me.BtnYes.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BtnYes.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.BtnYes.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.BtnYes.OnHoverImage = Nothing
        Me.BtnYes.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.BtnYes.Radius = 15
        Me.BtnYes.Size = New System.Drawing.Size(90, 47)
        Me.BtnYes.TabIndex = 20
        Me.BtnYes.Text = "Yes"
        Me.BtnYes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel7
        '
        Me.GunaLabel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.GunaTransition1.SetDecoration(Me.GunaLabel7, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition2.SetDecoration(Me.GunaLabel7, Guna.UI.Animation.DecorationType.None)
        Me.GunaLabel7.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel7.ForeColor = System.Drawing.Color.White
        Me.GunaLabel7.Location = New System.Drawing.Point(16, 37)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(114, 30)
        Me.GunaLabel7.TabIndex = 19
        Me.GunaLabel7.Text = "Are you sure"
        Me.GunaLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GunaTransition2
        '
        Me.GunaTransition2.AnimationType = Guna.UI.Animation.AnimationType.Transparent
        Me.GunaTransition2.Cursor = Nothing
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
        Animation2.TransparencyCoeff = 1.0!
        Me.GunaTransition2.DefaultAnimation = Animation2
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaTransition1.SetDecoration(Me.GunaPictureBox1, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition2.SetDecoration(Me.GunaPictureBox1, Guna.UI.Animation.DecorationType.None)
        Me.GunaPictureBox1.Image = CType(resources.GetObject("GunaPictureBox1.Image"), System.Drawing.Image)
        Me.GunaPictureBox1.Location = New System.Drawing.Point(114, 199)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(379, 425)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaPictureBox1.TabIndex = 43
        Me.GunaPictureBox1.TabStop = False
        Me.GunaPictureBox1.Visible = False
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1341, 811)
        Me.Controls.Add(Me.ExitPanel)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GunaPictureBox1)
        Me.GunaTransition2.SetDecoration(Me, Guna.UI.Animation.DecorationType.None)
        Me.GunaTransition1.SetDecoration(Me, Guna.UI.Animation.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoginForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ExitPanel.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BtnLogin As Guna.UI.WinForms.GunaButton
    Friend WithEvents PasswordTextBox As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents UsernameTxtBox As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents FrgtPassword As Guna.UI.WinForms.GunaLinkLabel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents BtnExit As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton2 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents LoginLoading As Guna.UI2.WinForms.Guna2WinProgressIndicator
    Friend WithEvents btnShowHide As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaTransition1 As Guna.UI.WinForms.GunaTransition
    Friend WithEvents GunaTransition2 As Guna.UI.WinForms.GunaTransition
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents ExitPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BtnNo As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents BtnYes As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
End Class
