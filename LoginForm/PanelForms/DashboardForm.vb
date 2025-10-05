Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting
Public Class Dashboard

    Dim con As New SqlConnection("server=.\SQLEXPRESS; Database=DBStudentInformation; Trusted_Connection=True;")
    Public Sub RefreshDashboard()
        LoadDashboardStats()
        LoadRecentStudents()
        LoadCourseChart()
    End Sub

    Private Sub Dashboard_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        RefreshDashboard()
    End Sub
    Private Sub DashboardForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FlowLayoutPanelRecent.FlowDirection = FlowDirection.TopDown
        FlowLayoutPanelRecent.WrapContents = False

        TimerDateTime.Start()
        lblTimeandDate.Text = DateTime.Now.ToString("MMMM dd, yyyy hh:mm:ss tt")
    End Sub

    Private Sub LoadCourseChart()
        Try
            con.Open()

            Dim sql As String = "SELECT Course, COUNT(*) AS TotalStudents " &
                     "FROM StudentsInfo " &
                     "GROUP BY Course " &
                     "ORDER BY TotalStudents DESC"

            Dim cmd As New SqlCommand(sql, con)
            Dim rdr As SqlDataReader = cmd.ExecuteReader()


            ChartCourseEnrolled.Series.Clear()
            ChartCourseEnrolled.ChartAreas.Clear()
            ChartCourseEnrolled.Titles.Clear()


            Dim area As New ChartArea("MainArea")
            ChartCourseEnrolled.ChartAreas.Add(area)


            Dim series As New Series("Courses")
            series.ChartType = SeriesChartType.Pie
            series.IsValueShownAsLabel = True   ' Show % on pie slices
            series.LabelForeColor = Color.Black


            While rdr.Read()
                series.Points.AddXY(rdr("Course").ToString(), Convert.ToInt32(rdr("TotalStudents")))
            End While
            series("PieLabelStyle") = "Outside"
            series.BorderWidth = 2
            series.BorderColor = Color.FromArgb(130, 0, 12)

            ChartCourseEnrolled.Series.Add(series)

           

            rdr.Close()
        Catch ex As Exception
            MsgBox("Error loading course chart: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub


    Private Sub LoadDashboardStats()
        Try
            con.Open()

            ' Total Students
            Dim cmdTotal As New SqlCommand("SELECT COUNT(*) FROM StudentsInfo", con)
            lblTotalStudents.Text = cmdTotal.ExecuteScalar().ToString()

            ' Male Students
            Dim cmdMale As New SqlCommand("SELECT COUNT(*) FROM StudentsInfo WHERE Gender='Male'", con)
            lblMaleStudents.Text = cmdMale.ExecuteScalar().ToString()

            ' Female Students
            Dim cmdFemale As New SqlCommand("SELECT COUNT(*) FROM StudentsInfo WHERE Gender='Female'", con)
            lblFemaleStudents.Text = cmdFemale.ExecuteScalar().ToString()

        Catch ex As Exception
            MsgBox("Error loading dashboard stats: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub LoadRecentStudents()
        Try
            con.Open()

            Dim sql As String = "SELECT TOP 3 StudentNumber, FullName, Course, BirthDate FROM StudentsInfo ORDER BY ID DESC"
            Dim cmd As New SqlCommand(sql, con)
            Dim rdr As SqlDataReader = cmd.ExecuteReader()

            FlowLayoutPanelRecent.Controls.Clear()

            While rdr.Read()
                Dim card As New Panel
                card.Width = 400
                card.Height = 70
                card.BorderStyle = BorderStyle.Fixed3D
                card.Margin = New Padding(5)

                Dim lblStudent As New Label
                lblStudent.Text = rdr("StudentNumber").ToString() & " - " & rdr("FullName").ToString()
                lblStudent.ForeColor = Color.FromArgb(130, 0, 12)
                lblStudent.Font = New Font("Segoe UI", 13, FontStyle.Bold)
                lblStudent.AutoSize = True
                lblStudent.Location = New Point(10, 10)

                Dim lblCourse As New Label
                lblCourse.Text = "Course: " & rdr("Course").ToString()
                lblCourse.AutoSize = True
                lblCourse.Font = New Font("Segoe UI", 11, FontStyle.Regular)
                lblCourse.Location = New Point(10, 35)

                card.Controls.Add(lblStudent)
                card.Controls.Add(lblCourse)

                FlowLayoutPanelRecent.Controls.Add(card)
            End While

            rdr.Close()

        Catch ex As Exception
            MsgBox("Error loading recent students: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub


    Private Sub TimerDateTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerDateTime.Tick
        lblTimeandDate.Text = DateTime.Now.ToString("MMMM dd, yyyy hh:mm:ss tt")
    End Sub

    Private Sub BtnAddRecords_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddRecords.Click
        AdminForm.SwitchPanel(AddRecordFrm)
        AdminForm.AddBtn()
    End Sub
End Class