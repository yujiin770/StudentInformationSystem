Imports System.Data.SqlClient
Imports System.Drawing.Drawing2D
Imports System.Text.RegularExpressions
Public Class AddRecordFrm
    Dim QR_Generator As New MessagingToolkit.QRCode.Codec.QRCodeEncoder
    Dim arrImage() As Byte

    Sub viewdata()
        Dim con1 As New SqlConnection("server=.\SQLEXPRESS; Database=DBStudentInformation; Trusted_Connection=True;")
        Dim sql As String = "SELECT ID, StudentNumber, FullName, BirthDate, Course, EmailAddress, PhoneNumber, Gender, Age, Address, GuardianName, GuardianPhoneNumber, QR FROM StudentsInfo"
        Dim Adapter As New SqlDataAdapter(sql, con1)
        Dim data As New DataTable("StudentsInfo")
        Adapter.Fill(data)
        ManageForm.dgvinfo.datasource = data
    End Sub


    Private Sub Guna2Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub

    Private Sub txtStudentNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStudentNumber.TextChanged, txtFullName.TextChanged, CboCourse.TextChanged, txtEmailAddress.TextChanged, TxtPhoneNumber.TextChanged, CboGender.TextChanged, txtAge.TextChanged, TxtAddress.TextChanged, txtGuardianName.TextChanged, txtGuardianPhone.TextChanged
        If txtStudentNumber.Text = "" Or txtFullName.Text = "" Or CboCourse.Text = "" Or txtEmailAddress.Text = "" Or TxtPhoneNumber.Text = "" Or CboGender.Text = "" Or txtAge.Text = "" Or TxtAddress.Text = "" Or txtGuardianName.Text = "" Or txtGuardianPhone.Text = "" Then
            PicQr.BackgroundImage = Nothing
        Else
            Dim qrContent As String = txtStudentNumber.Text & vbCrLf & txtFullName.Text & vbCrLf & CboCourse.Text & vbCrLf & txtEmailAddress.Text & vbCrLf & TxtPhoneNumber.Text & vbCrLf & CboGender.Text & vbCrLf & txtAge.Text & vbCrLf & TxtAddress.Text & vbCrLf & txtGuardianName.Text & vbCrLf & txtGuardianPhone.Text
            PicQr.BackgroundImage = QR_Generator.Encode(qrContent)
        End If
    End Sub


    Private Sub Guna2Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MainPanel.Paint

    End Sub


    Private Sub Guna2Panel2_Paint_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnContinue.Click
        If String.IsNullOrWhiteSpace(txtStudentNumber.Text) Then
            MessageBox.Show("Please enter a Student Number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtStudentNumber.Focus()
            Return
        End If
        If String.IsNullOrWhiteSpace(txtFullName.Text) Then
            MessageBox.Show("Please enter your Full Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtFullName.Focus()
            Return
        End If

        If CboCourse.SelectedIndex = -1 Then
            MessageBox.Show("Please select a Courses.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CboCourse.Focus()
            Return
        End If
        If String.IsNullOrWhiteSpace(txtEmailAddress.Text) Then
            MessageBox.Show("Please enter an Email Address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtEmailAddress.Focus()
            Return
        Else
            Dim emailPattern As String = "^[^@\s]+@[^@\s]+\.[^@\s]+$"
            If Not Regex.IsMatch(txtEmailAddress.Text, emailPattern) Then
                MessageBox.Show("Please enter a valid Email Address format.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtEmailAddress.Focus()
                Return
            End If
        End If
        MessageBox.Show("Step 1 Complete!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        MainPanel.Visible = False
        MainPanel2.Visible = True
        MainPanel3.Visible = False
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub



    Private Sub BtnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBack.Click
        MainPanel.Visible = True
        MainPanel2.Visible = False
        MainPanel3.Visible = False
    End Sub

    Private Sub BtnContinue2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnContinue2.Click
    
        If CboBirthDate.Value.Date > Date.Today Then
            MessageBox.Show("The selected Birthday cannot be in the future.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CboBirthDate.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(TxtPhoneNumber.Text) Then
            MessageBox.Show("Please enter a Phone Number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtPhoneNumber.Focus()
            Return
        Else
            Dim phonePattern As String = "^[\d\s\-\(\)\+]+$"
            If Not Regex.IsMatch(TxtPhoneNumber.Text, phonePattern) Then
                MessageBox.Show("Please enter a valid Phone Number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TxtPhoneNumber.Focus()
                Return
            End If
        End If
        If CboGender.SelectedIndex = -1 Then
            MessageBox.Show("Please select a Gender.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CboGender.Focus()
            Return
        End If
        MessageBox.Show("Step 2 Complete! ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        MainPanel2.Hide()
        MainPanel.Hide()
        MainPanel3.Show()
    End Sub


    Private Sub GunaButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaButton1.Click
        MainPanel3.Hide()
        MainPanel2.Show()
        MainPanel.Hide()

    End Sub



    Private Sub btnSumbit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSumbit.Click
        Try
            Dim mstream As New System.IO.MemoryStream()
            PicQr.BackgroundImage.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            arrImage = mstream.GetBuffer()
            Dim fileSize As UInt32 = mstream.Length
            mstream.Close()

            If utilities.InsertStudent(
         txtStudentNumber.Text,
         txtFullName.Text,
         CDate(CboBirthDate.Text),
         CboCourse.Text,
         txtEmailAddress.Text,
         TxtPhoneNumber.Text,
         CboGender.Text,
         txtAge.Text,
         TxtAddress.Text,
         txtGuardianName.Text,
         txtGuardianPhone.Text,
         arrImage) Then

                utilities.SaveQR(PicQr.BackgroundImage)
                ManageForm.viewdata()
                MainPanel3.Visible = False
                MainPanel.Visible = True
                txClear()
                If Application.OpenForms().OfType(Of Dashboard).Any() Then
                    Dim dash As Dashboard = Application.OpenForms().OfType(Of Dashboard).First()
                    dash.RefreshDashboard()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CboBirthDate_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboBirthDate.TextChanged
        Try
            Dim birthDate As Date = CDate(CboBirthDate.Text)
            Dim today As Date = Date.Today

            Dim age As Integer = today.Year - birthDate.Year

            If (today.Month < birthDate.Month) Or (today.Month = birthDate.Month And today.Day < birthDate.Day) Then
                age -= 1
            End If

            txtAge.Text = age.ToString()
        Catch ex As Exception
            txtAge.Text = Nothing
        End Try
    End Sub

    Private Sub CboBirthDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboBirthDate.ValueChanged
        Try
            Dim birthDate As Date = CboBirthDate.Value
            Dim today As Date = Date.Today

            Dim age As Integer = today.Year - birthDate.Year

            ' If birthday hasn’t occurred yet this year, subtract 1
            If (today.Month < birthDate.Month) Or (today.Month = birthDate.Month And today.Day < birthDate.Day) Then
                age -= 1
            End If

            txtAge.Text = age.ToString()
        Catch ex As Exception
            txtAge.Text = ""
        End Try
    End Sub

    Sub txClear()
        txtFullName.Clear()
        TxtAddress.Clear()
        txtAge.Clear()
        txtEmailAddress.Clear()
        txtGuardianName.Clear()
        txtGuardianPhone.Clear()
        txtGuardianPhone.Clear()
        TxtPhoneNumber.Clear()
        txtStudentNumber.Clear()
    End Sub

    Private Sub MainPanel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MainPanel3.Paint

    End Sub

    Private Sub AddRecordFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


     

    End Sub
End Class