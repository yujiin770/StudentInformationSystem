Public Class ViewInformation
    Dim QR_Generator As New MessagingToolkit.QRCode.Codec.QRCodeEncoder
    Dim arrImage() As Byte
    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            Dim mstream As New System.IO.MemoryStream()
            PicQr.BackgroundImage.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            arrImage = mstream.GetBuffer()
            Dim fileSize As UInt32 = mstream.Length
            mstream.Close()

            If utilities.UpdateStudent(txtId.Text,
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
                ManageForm.EnabledTrue()
                ManageForm.viewdata()
                ManageForm.MainPanel.Visible = False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtStudentNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStudentNumber.TextChanged, txtFullName.TextChanged, CboCourse.TextChanged
        If txtStudentNumber.Text = "" Or txtFullName.Text = "" Or CboCourse.Text = "" Or txtEmailAddress.Text = "" Or TxtPhoneNumber.Text = "" Or CboGender.Text = "" Or txtAge.Text = "" Or TxtAddress.Text = "" Or txtGuardianName.Text = "" Then
            PicQr.BackgroundImage = Nothing
        Else
            Dim qrContent As String = txtStudentNumber.Text & vbCrLf & txtFullName.Text & vbCrLf & CboCourse.Text & vbCrLf & txtEmailAddress.Text & vbCrLf & TxtPhoneNumber.Text & vbCrLf & CboGender.Text & vbCrLf & txtAge.Text & vbCrLf & TxtAddress.Text & vbCrLf & txtGuardianName.Text
            PicQr.BackgroundImage = QR_Generator.Encode(qrContent)
        End If
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
            txtAge.Text = ""
        End Try
    End Sub

    Private Sub CboBirthDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboBirthDate.ValueChanged
        Try
            Dim birthDate As Date = CboBirthDate.Value
            Dim today As Date = Date.Today

            Dim age As Integer = today.Year - birthDate.Year

            If (today.Month < birthDate.Month) Or (today.Month = birthDate.Month And today.Day < birthDate.Day) Then
                age -= 1
            End If

            txtAge.Text = age.ToString()
        Catch ex As Exception
            txtAge.Text = ""
        End Try
    End Sub

    Private Sub ViewInformation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        ManageForm.MainPanel.Visible = False
        ManageForm.EnabledTrue()
    End Sub
    Private Sub btnSumbit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSumbit.Click
        ManageForm.MainPanel2.Visible = True
        ManageForm.MainPanel.Visible = False
    End Sub

    Private Sub GunaLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaLabel1.Click
        ManageForm.MainPanel.Hide()
        ManageForm.EnabledTrue()
        ViewInformationPanel.Visible = False
    End Sub

    Private Sub ViewInformationPanel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles ViewInformationPanel.Paint

    End Sub
End Class