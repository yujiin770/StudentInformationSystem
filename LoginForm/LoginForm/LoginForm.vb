Imports System.Drawing.Drawing2D
Public Class LoginForm
    Dim counter As Integer = 0
    Dim loginSuccess As Boolean = False
    Private Sub BtnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLogin.Click
        Dim login_usertype = 1
        Dim result = utilities.Login(UsernameTxtBox.Text, PasswordTextBox.Text, login_usertype)
        If result Then
            loginSuccess = True
            LoginLoading.Visible = True
            Timer1.Start()

            counter = 0
            Timer1.Start()
            Login()

            Dashboard.RefreshDashboard()
        Else
            UsernameTxtBox.Clear()
            PasswordTextBox.Clear()
            UsernameTxtBox.Focus()
        End If
    End Sub


    Sub transition()
        GunaTransition1.HideSync(Panel1)
        GunaTransition1.HideSync(GunaLabel3)
        GunaTransition1.HideSync(GunaLabel1)
        GunaTransition1.HideSync(GunaPictureBox1)
        GunaTransition1.Show(AdminForm.Guna2Panel1)
        GunaTransition1.Show(Dashboard.Guna2Panel5)
        GunaTransition1.Show(Dashboard.Guna2Panel1)
        GunaTransition1.Show(Dashboard.Guna2Panel2)
        GunaTransition1.Show(Dashboard.Guna2Panel3)
        GunaTransition1.Show(Dashboard.Guna2Panel4)
    End Sub

    Private Sub Login()
        UsernameTxtBox.Enabled = False
        PasswordTextBox.Enabled = False
        BtnExit.Enabled = False
        BtnLogin.Enabled = False
        btnShowHide.Enabled = False
    End Sub

    Private Sub Success()
        UsernameTxtBox.Enabled = True
        PasswordTextBox.Enabled = True
        BtnExit.Enabled = True
        BtnLogin.Enabled = True
        btnShowHide.Enabled = True
    End Sub
    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        ExitPanel.Visible = True
        BtnLogin.Enabled = False
        BtnExit.Enabled = False
        FrgtPassword.Enabled = False
        UsernameTxtBox.Enabled = False
        PasswordTextBox.Enabled = False
    End Sub
    Sub transitionIntro1()
        GunaTransition2.Show(Panel1)
        GunaTransition2.Show(GunaLabel3)
        GunaTransition2.Show(GunaLabel1)
        GunaTransition2.Show(GunaPictureBox1)
    End Sub
    Private Sub LoginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        transitionIntro1()
        Dim radius As Integer = 50
        Dim bounds As New Rectangle(0, 0, Me.Width, Me.Height)
        Dim path As New GraphicsPath()
        path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90)
        path.AddArc(bounds.Right - radius, bounds.Y, radius, radius, 270, 90)
        path.AddArc(bounds.Right - radius, bounds.Bottom - radius, radius, radius, 0, 90)
        path.AddArc(bounds.X, bounds.Bottom - radius, radius, radius, 90, 90)
        path.CloseAllFigures()
        Me.Region = New Region(path)
    End Sub

    Private Sub BtnYes_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub


    Private Sub UsernameTxtBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles UsernameTxtBox.KeyPress
        If e.KeyChar = Chr(13) Then
            e.Handled = True

            BtnLogin.PerformClick()
        End If
    End Sub

    Private Sub UsernameTxtBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsernameTxtBox.TextChanged

    End Sub

    Private Sub PasswordTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PasswordTextBox.KeyPress
        If e.KeyChar = Chr(13) Then

            e.Handled = True


            BtnLogin.PerformClick()
        End If
    End Sub

    Private Sub LoginForm_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim radius As Integer = 50
        Dim bounds As New Rectangle(0, 0, Me.Width, Me.Height)
        Dim path As New Drawing2D.GraphicsPath()

        path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90)
        path.AddArc(bounds.Right - radius, bounds.Y, radius, radius, 270, 90)
        path.AddArc(bounds.Right - radius, bounds.Bottom - radius, radius, radius, 0, 90)
        path.AddArc(bounds.X, bounds.Bottom - radius, radius, radius, 90, 90)
        path.CloseAllFigures()
    End Sub

    Private Sub GunaWinCircleProgressIndicator1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        counter += 1

        If counter >= 3 AndAlso loginSuccess Then
            Timer1.Stop()
            Timer1.Stop()
            transition()
            LoginLoading.Visible = False
            Success()
            UsernameTxtBox.Text = Nothing
            PasswordTextBox.Text = Nothing
            AdminForm.Show()
            AdminForm.SwitchPanel(Dashboard)
            Me.Hide()
        End If
    End Sub

    Private Sub btnShowHide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowHide.Click
        If PasswordTextBox.PasswordChar = "*" Then
            'Show Password
            PasswordTextBox.PasswordChar = ""
            btnShowHide.Image = My.Resources.show
        Else
            'Hide Password
            PasswordTextBox.PasswordChar = "*"
            btnShowHide.Image = My.Resources.invisible
        End If
    End Sub



    Private Sub BtnNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNo.Click
        ExitPanel.Visible = False
        BtnLogin.Enabled = True
        BtnExit.Enabled = True
        FrgtPassword.Enabled = True
        UsernameTxtBox.Enabled = True
        PasswordTextBox.Enabled = True
    End Sub

    Private Sub BtnYes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnYes.Click
        End

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class