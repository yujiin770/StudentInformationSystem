Imports System.Data.SqlClient
Imports System.Drawing.Drawing2D

Public Class ManageForm
    Dim QR_Generator As New MessagingToolkit.QRCode.Codec.QRCodeEncoder
    Dim arrImage() As Byte
    Dim dtStudents As DataTable

    Private Sub ManageForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridDesign()
    End Sub
    Sub viewdata()
        Dim con1 As New SqlConnection("server=.\SQLEXPRESS; Database=DBStudentInformation; Trusted_Connection=True;")
        Dim sql As String = "SELECT * FROM StudentsInfo"   ' keep all columns available
        Dim Adapter As New SqlDataAdapter(sql, con1)

        dtStudents = New DataTable()
        Adapter.Fill(dtStudents)

        dgvInfo.Columns.Clear()
        dgvInfo.AutoGenerateColumns = True
        dgvInfo.DataSource = dtStudents
        dgvInfo.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 11, FontStyle.Bold)

        dgvInfo.Columns("StudentNumber").HeaderText = "Student No."
        dgvInfo.Columns("FullName").HeaderText = "Full Name"
        dgvInfo.Columns("Age").HeaderText = "Age"
        dgvInfo.Columns("Course").HeaderText = "Course"
        dgvInfo.Columns("Gender").HeaderText = "Gender"

        Dim keep As String() = {"StudentNumber", "FullName", "Age", "Course", "Gender"}
        For Each col As DataGridViewColumn In dgvInfo.Columns
            If Array.IndexOf(keep, col.Name) = -1 Then col.Visible = False
        Next

        If dgvInfo.Columns.Contains("ID") Then dgvInfo.Columns("ID").Visible = False
        If dgvInfo.Columns.Contains("QR") Then dgvInfo.Columns("QR").Visible = False



        If dgvInfo.Columns("btnView") Is Nothing Then
            Dim buttonStyle As New DataGridViewCellStyle()
            buttonStyle.BackColor = Color.FromArgb(130, 0, 12)
            buttonStyle.ForeColor = Color.FromArgb(130, 0, 12)
            buttonStyle.SelectionForeColor = Color.White
            buttonStyle.SelectionBackColor = Color.FromArgb(130, 0, 12)
            buttonStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
            buttonStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            Dim btnView As New DataGridViewButtonColumn()
            btnView.Name = "btnView"
            btnView.HeaderText = "View"
            btnView.Text = "View"
            btnView.UseColumnTextForButtonValue = True
            btnView.FlatStyle = FlatStyle.Flat
            btnView.DefaultCellStyle = buttonStyle
            dgvInfo.Columns.Add(btnView)

            Dim btnQR As New DataGridViewButtonColumn()
            btnQR.Name = "btnQR"
            btnQR.HeaderText = "QR"
            btnQR.Text = "QR"
            btnQR.UseColumnTextForButtonValue = True
            btnQR.FlatStyle = FlatStyle.Flat
            btnQR.DefaultCellStyle = buttonStyle
            dgvInfo.Columns.Add(btnQR)

            Dim btnDelete As New DataGridViewButtonColumn()
            btnDelete.Name = "btnDelete"
            btnDelete.HeaderText = "Delete"
            btnDelete.Text = "Delete"
            btnDelete.UseColumnTextForButtonValue = True
            btnDelete.FlatStyle = FlatStyle.Flat
            btnDelete.DefaultCellStyle = buttonStyle
            dgvInfo.Columns.Add(btnDelete)
        End If

        ' Put buttons at the far right
        dgvInfo.Columns("btnView").DisplayIndex = dgvInfo.Columns.Count - 3
        dgvInfo.Columns("btnQR").DisplayIndex = dgvInfo.Columns.Count - 2
        dgvInfo.Columns("btnDelete").DisplayIndex = dgvInfo.Columns.Count - 1

        LoadCourseFilter()
        LoadGenderFilter()
    End Sub

    Private Sub DataGridDesign()
        dgvInfo.BorderStyle = BorderStyle.Fixed3D
        dgvInfo.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249)
        dgvInfo.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvInfo.DefaultCellStyle.SelectionBackColor = Color.FromArgb(31, 49, 105)
        dgvInfo.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke

        dgvInfo.DefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Regular)

        dgvInfo.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        dgvInfo.EnableHeadersVisualStyles = False
        dgvInfo.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None

        dgvInfo.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(130, 0, 12)
        dgvInfo.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
    End Sub

    Sub SwitchPanel(ByVal panel As Form)
        MainPanel.Controls.Clear()
        panel.TopLevel = False
        MainPanel.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        EnabledFalse()
        SwitchPanel(ViewInformation)
        MainPanel.Visible = True
        ViewInformation.ViewInformationPanel.Visible = False
    End Sub
  Sub clickdgvUpdate()
        Dim i As Integer = dgvInfo.CurrentRow.Index

        ViewInformation.txtId.Text = dgvInfo.Rows(i).Cells("ID").Value.ToString()
        ViewInformation.txtStudentNumber.Text = dgvInfo.Rows(i).Cells("StudentNumber").Value.ToString()
        ViewInformation.txtFullName.Text = dgvInfo.Rows(i).Cells("FullName").Value.ToString()
        ViewInformation.CboBirthDate.Text = dgvInfo.Rows(i).Cells("BirthDate").Value.ToString()
        ViewInformation.CboCourse.Text = dgvInfo.Rows(i).Cells("Course").Value.ToString()
        ViewInformation.txtEmailAddress.Text = dgvInfo.Rows(i).Cells("EmailAddress").Value.ToString()
        ViewInformation.TxtPhoneNumber.Text = dgvInfo.Rows(i).Cells("PhoneNumber").Value.ToString()
        ViewInformation.CboGender.Text = dgvInfo.Rows(i).Cells("Gender").Value.ToString()
        ViewInformation.txtAge.Text = dgvInfo.Rows(i).Cells("Age").Value.ToString()
        ViewInformation.TxtAddress.Text = dgvInfo.Rows(i).Cells("Address").Value.ToString()
        ViewInformation.txtGuardianName.Text = dgvInfo.Rows(i).Cells("GuardianName").Value.ToString()
        ViewInformation.txtGuardianPhone.Text = dgvInfo.Rows(i).Cells("GuardianPhoneNumber").Value.ToString()

        Dim imgBytes As Byte() = TryCast(dgvInfo.Rows(i).Cells("QR").Value, Byte()) ' USE "QR"
        If imgBytes IsNot Nothing Then
            Using m As New IO.MemoryStream(imgBytes)
                ViewInformation.PicQr.BackgroundImage = Image.FromStream(m)
            End Using
        Else
            ViewInformation.PicQr.BackgroundImage = Nothing
        End If
    End Sub

    Private Sub clickdgvQR()
        Dim i As Integer = dgvInfo.CurrentRow.Index
        txtId.Text = dgvInfo.Rows(i).Cells("ID").Value.ToString()
        txtFullName2.Text = dgvInfo.Rows(i).Cells("FullName").Value.ToString()
        txtCourse2.Text = dgvInfo.Rows(i).Cells("Course").Value.ToString()
        txtStudentNumber2.Text = dgvInfo.Rows(i).Cells("StudentNumber").Value.ToString() ' <- fixed

        Dim imgBytes As Byte() = TryCast(dgvInfo.Rows(i).Cells("QR").Value, Byte()) ' USE "QR"
        If imgBytes IsNot Nothing Then
            Using m As New IO.MemoryStream(imgBytes)
                PicQr.BackgroundImage = Image.FromStream(m)
            End Using
        Else
            PicQr.BackgroundImage = Nothing
        End If
    End Sub

   Sub clickdgvID()
        Dim i As Integer = dgvInfo.CurrentRow.Index
        txtId.Text = dgvInfo.Rows(i).Cells("ID").Value.ToString()
        txtStudentNumber.Text = dgvInfo.Rows(i).Cells("StudentNumber").Value.ToString()
        txtFullName.Text = dgvInfo.Rows(i).Cells("FullName").Value.ToString()
        txtCourse.Text = dgvInfo.Rows(i).Cells("Course").Value.ToString()
        txtAddress.Text = dgvInfo.Rows(i).Cells("Address").Value.ToString()
        ViewInformation.lblStudentNumber.Text = dgvInfo.Rows(i).Cells("StudentNumber").Value.ToString()
        ViewInformation.lblFullName.Text = dgvInfo.Rows(i).Cells("FullName").Value.ToString()
        ViewInformation.CboBirthDate2.Text = dgvInfo.Rows(i).Cells("BirthDate").Value.ToString()
        ViewInformation.CboCourse2.Text = dgvInfo.Rows(i).Cells("Course").Value.ToString()
        ViewInformation.lblEmailAddress.Text = dgvInfo.Rows(i).Cells("EmailAddress").Value.ToString()
        ViewInformation.lblPhoneNumber.Text = dgvInfo.Rows(i).Cells("PhoneNumber").Value.ToString()
        ViewInformation.CboGender2.Text = dgvInfo.Rows(i).Cells("Gender").Value.ToString()
        ViewInformation.lblAge.Text = dgvInfo.Rows(i).Cells("Age").Value.ToString()
        ViewInformation.lblAddress.Text = dgvInfo.Rows(i).Cells("Address").Value.ToString()
        ViewInformation.lblGuardianName.Text = dgvInfo.Rows(i).Cells("GuardianName").Value.ToString()
        ViewInformation.lblGuardianPhoneNumber.Text = dgvInfo.Rows(i).Cells("GuardianPhoneNumber").Value.ToString()


        Dim imgBytes As Byte() = TryCast(dgvInfo.Rows(i).Cells("QR").Value, Byte()) ' USE "QR"
        If imgBytes IsNot Nothing Then
            Using m As New IO.MemoryStream(imgBytes)
                PicQr.BackgroundImage = Image.FromStream(m)
            End Using
        Else
            PicQr.BackgroundImage = Nothing
        End If
    End Sub

    Private Sub dgvInfo_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvInfo.CellClick
        clickdgvUpdate()
        If e.RowIndex < 0 Then Exit Sub
        If TypeOf dgvInfo.Columns(e.ColumnIndex) Is DataGridViewButtonColumn Then Exit Sub
    End Sub

    Private Sub dgvInfo_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvInfo.CellContentClick
        If e.RowIndex < 0 Then Exit Sub
        Dim colName = dgvInfo.Columns(e.ColumnIndex).Name
        If colName = "btnView" Then
            clickdgvID()
            MainPanel2.Visible = True
            EnabledFalse()
        ElseIf colName = "btnQR" Then
            clickdgvQR()
            MainPanel3.Visible = True
            EnabledFalse()
        ElseIf colName = "btnDelete" Then
            Dim id As String = dgvInfo.Rows(e.RowIndex).Cells("ID").Value.ToString()
            If MessageBox.Show("Delete this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then           
                Using con As New SqlConnection("server=.\SQLEXPRESS; Database=DBStudentInformation; Trusted_Connection=True;")
                    con.Open()
                    Using cmd As New SqlCommand("DELETE FROM StudentsInfo WHERE ID=@id", con)
                        cmd.Parameters.AddWithValue("@id", id)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
                viewdata()
                If Application.OpenForms().OfType(Of Dashboard).Any() Then
                    Dim dash As Dashboard = Application.OpenForms().OfType(Of Dashboard).First()
                    dash.RefreshDashboard()
                End If
            End If
        End If
    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MainPanel.Visible = False
    End Sub


    Sub EnabledFalse()
        AdminForm.BtnDashboard.Enabled = False
        AdminForm.BtnAdd.Enabled = False
        AdminForm.BtnManage.Enabled = False
        btnUpdate.Enabled = False
        txtSearch.Enabled = False
        CmboCourseFilter.Enabled = False
        dgvInfo.Enabled = False
        AdminForm.LogoutBtn.Enabled = False
        CboMaleandFemaleFilter.Enabled = False
    End Sub

    Sub EnabledTrue()
        AdminForm.BtnDashboard.Enabled = True
        AdminForm.BtnAdd.Enabled = True
        AdminForm.BtnManage.Enabled = True
        btnUpdate.Enabled = True
        txtSearch.Enabled = True
        CmboCourseFilter.Enabled = True
        dgvInfo.Enabled = True
        AdminForm.LogoutBtn.Enabled = True
        CboMaleandFemaleFilter.Enabled = True

    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        If dtStudents Is Nothing Then Exit Sub
        viewdata()
        Dim filterText As String = txtSearch.Text.Trim().Replace("'", "''")
        If filterText = "" Then
            dgvInfo.DataSource = dtStudents

            Exit Sub
        End If

        '
        Dim filters As New List(Of String)
        For Each col As DataColumn In dtStudents.Columns
            If col.DataType Is GetType(String) OrElse col.DataType Is GetType(Integer) Then
                filters.Add(String.Format("CONVERT([{0}], 'System.String') LIKE '%{1}%'", col.ColumnName, filterText))
            End If
        Next

        Dim dv As New DataView(dtStudents)
        dv.RowFilter = String.Join(" OR ", filters)
        dgvInfo.DataSource = dv
    End Sub

    Private Sub MainPanel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub
    Private Sub LoadCourseFilter()
        If dtStudents Is Nothing Then Exit Sub

        CmboCourseFilter.Items.Clear()
        CmboCourseFilter.Items.Add("ALL")


        Dim courseList As New HashSet(Of String)()

        For Each row As DataRow In dtStudents.Rows
            If Not IsDBNull(row("Course")) Then
                Dim courseName As String = row("Course").ToString().Trim()
                If courseName <> "" Then
                    courseList.Add(courseName)
                End If
            End If
        Next

        For Each c As String In courseList
            CmboCourseFilter.Items.Add(c)
        Next


        CmboCourseFilter.SelectedIndex = 0
    End Sub

    Private Sub LoadGenderFilter()
        If dtStudents Is Nothing Then Exit Sub

        CboMaleandFemaleFilter.Items.Clear()
        CboMaleandFemaleFilter.Items.Add("ALL")

        Dim genderList As New HashSet(Of String)()

        For Each row As DataRow In dtStudents.Rows
            If Not IsDBNull(row("Gender")) Then
                Dim genderName As String = row("Gender").ToString().Trim()
                If genderName <> "" Then
                    genderList.Add(genderName)
                End If
            End If
        Next

        For Each g As String In genderList
            CboMaleandFemaleFilter.Items.Add(g)
        Next

        CboMaleandFemaleFilter.SelectedIndex = 0
    End Sub

    Private Sub CmboCourseFilter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmboCourseFilter.SelectedIndexChanged
        If dtStudents Is Nothing Then Exit Sub
        If CmboCourseFilter.SelectedIndex = -1 Then Exit Sub

        Dim selectedCourse As String = CmboCourseFilter.SelectedItem.ToString()

        If selectedCourse = "ALL" Then
            dgvInfo.DataSource = dtStudents
        Else
            Dim dv As New DataView(dtStudents)
            dv.RowFilter = String.Format("Course = '{0}'", selectedCourse.Replace("'", "''"))
            dgvInfo.DataSource = dv
        End If
    End Sub

    

    Private Sub Btnhide_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MainPanel3.Hide()
        EnabledTrue()
    End Sub

    Private Sub CboMaleandFemaleFilter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboMaleandFemaleFilter.SelectedIndexChanged
        If dtStudents Is Nothing Then Exit Sub
        If CboMaleandFemaleFilter.SelectedIndex = -1 Then Exit Sub

        Dim selectedGender As String = CboMaleandFemaleFilter.SelectedItem.ToString()

        If selectedGender = "ALL" Then
            dgvInfo.DataSource = dtStudents
        Else
            Dim dv As New DataView(dtStudents)
            dv.RowFilter = String.Format("Gender = '{0}'", selectedGender.Replace("'", "''"))
            dgvInfo.DataSource = dv
        End If
    End Sub

    Private Sub Btnhide_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnhide.Click
        MainPanel3.Visible = False
        EnabledTrue()
    End Sub

    Private Sub BtnExit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        MainPanel2.Visible = False
        EnabledTrue()
    End Sub

    Private Sub BtnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNext.Click
        SwitchPanel(ViewInformation)
        ViewInformation.ViewInformationPanel.Visible = True
        MainPanel2.Hide()
        MainPanel.Show()
    End Sub

    Private Sub MainPanel2_Paint_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MainPanel2.Paint

    End Sub
End Class