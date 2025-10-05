Imports System.Drawing.Drawing2D
Public Class AdminForm


    Sub SwitchPanel(ByVal panel As Form)
        MainPanel.Controls.Clear()
        panel.TopLevel = False
        MainPanel.Controls.Add(panel)
        panel.Show()
    End Sub
    Private Sub BtnDashboard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDashboard.Click
        SwitchPanel(Dashboard)
        DashboardBtn()
        ManageForm.viewdata()
        AddRecordFrm.txClear()
    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        SwitchPanel(AddRecordFrm)
        ManageForm.viewdata()
        AddBtn()
    End Sub

    Private Sub BtnManage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnManage.Click
        SwitchPanel(ManageForm)
        ManageForm.viewdata()
        ManageBtn()
        AddRecordFrm.txClear()
    End Sub



    'Color Sub

    Private Sub DashboardBtn()
        BtnDashboard.BaseColor = Color.FromArgb(254, 254, 254)
        BtnAdd.BaseColor = Color.Transparent
        BtnManage.BaseColor = Color.Transparent
        BtnDashboard.ForeColor = Color.FromArgb(130, 0, 12)
        BtnAdd.ForeColor = Color.FromArgb(254, 254, 254)
        BtnManage.ForeColor = Color.FromArgb(254, 254, 254)
        BtnDashboard.Image = My.Resources.DashboardIconRed
        BtnAdd.Image = My.Resources.add
        BtnManage.Image = My.Resources.record_keeping
       

    End Sub

    Sub AddBtn()
        BtnAdd.BaseColor = Color.FromArgb(254, 254, 254)
        BtnDashboard.BaseColor = Color.Transparent
        BtnManage.BaseColor = Color.Transparent
        BtnAdd.ForeColor = Color.FromArgb(130, 0, 12)
        BtnDashboard.ForeColor = Color.FromArgb(254, 254, 254)
        BtnManage.ForeColor = Color.FromArgb(254, 254, 254)
        BtnAdd.Image = My.Resources.addRed
        BtnDashboard.Image = My.Resources.DashboardIcon
        BtnManage.Image = My.Resources.record_keeping
    End Sub

    Private Sub ManageBtn()
        BtnManage.BaseColor = Color.FromArgb(254, 254, 254)
        BtnAdd.BaseColor = Color.Transparent
        BtnDashboard.BaseColor = Color.Transparent
        BtnManage.ForeColor = Color.FromArgb(130, 0, 12)
        BtnAdd.Image = My.Resources.add
        BtnDashboard.Image = My.Resources.DashboardIcon
        BtnManage.Image = My.Resources.record_keepingRed
        BtnDashboard.ForeColor = Color.FromArgb(254, 254, 254)
        BtnAdd.ForeColor = Color.FromArgb(254, 254, 254)
      

    End Sub


    Private Sub AdminForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim radius As Integer = 50
        Dim bounds As New Rectangle(0, 0, Me.Width, Me.Height)
        Dim path As New GraphicsPath()
        path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90)
        path.AddArc(bounds.Right - radius, bounds.Y, radius, radius, 270, 90)
        path.AddArc(bounds.Right - radius, bounds.Bottom - radius, radius, radius, 0, 90)
        path.AddArc(bounds.X, bounds.Bottom - radius, radius, radius, 90, 90)
        path.CloseAllFigures()
        Me.Region = New Region(path)
        GunaTransition1.ShowSync(Guna2Panel1)
    End Sub

    Private Sub AdminForm_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim radius As Integer = 50
        Dim bounds As New Rectangle(0, 0, Me.Width, Me.Height)
        Dim path As New Drawing2D.GraphicsPath()

        path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90)
        path.AddArc(bounds.Right - radius, bounds.Y, radius, radius, 270, 90)
        path.AddArc(bounds.Right - radius, bounds.Bottom - radius, radius, radius, 0, 90)
        path.AddArc(bounds.X, bounds.Bottom - radius, radius, radius, 90, 90)
        path.CloseAllFigures()
    End Sub

    
    Private Sub BtnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Log Out Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            LoginForm.UsernameTxtBox.Focus()
            DashboardBtn()
            LoginForm.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Guna2Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub

    Private Sub MainPanel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MainPanel.Paint

    End Sub
    Sub transition()
        GunaTransition1.Show(LoginForm.Panel1)
        GunaTransition1.Show(LoginForm.GunaLabel3)
        GunaTransition1.Show(LoginForm.GunaLabel1)
        GunaTransition1.Show(LoginForm.GunaPictureBox1)
    End Sub
    Private Sub LogoutBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutBtn.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Hide()
            transition()
            LoginForm.Show()
            DashboardBtn()
        End If
    End Sub
End Class