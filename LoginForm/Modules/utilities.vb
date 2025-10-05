Imports System.Data.SqlClient
Imports System.Drawing
Imports System.IO
Module utilities

    Public SESSION As DataRow

    Public Function Login(ByVal username As String, ByVal password As String, ByVal user_type As Integer) As Boolean
        ' Trim inputs to avoid accidental spaces
        username = username.Trim()
        password = password.Trim()

        ' Validate empty fields
        If String.IsNullOrEmpty(username) Then
            MsgBox("Username is required.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Validation Error")
            LoginForm.UsernameTxtBox.Focus()
            Return False
        End If

        If String.IsNullOrEmpty(password) Then
            MsgBox("Password is required.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Validation Error")
            LoginForm.PasswordTextBox.Focus()
            Return False
        End If

        If user_type < 0 Then
            MsgBox("Invalid user type.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Validation Error")
            Return False
        End If

        Dim query = "SELECT * FROM users WHERE username=@username AND password=@password AND user_type=@user_type"

        connection.AddParam("@username", username)
        connection.AddParam("@password", password)
        connection.AddParam("@user_type", user_type)

        Dim result = connection.Query(query)

        If result AndAlso connection.Data.Tables.Count > 0 AndAlso connection.Data.Tables(0).Rows.Count > 0 Then
            Dim user = connection.Data.Tables(0).Rows(0)

            MsgBox("Successfully Login, Welcome " & user("username"), MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "Login")

            SESSION = user
            Return True
        End If

        MsgBox("Failed to Login. Please check your credentials.", MsgBoxStyle.Critical, "Login")
        LoginForm.UsernameTxtBox.Clear()
        LoginForm.PasswordTextBox.Clear()
        LoginForm.UsernameTxtBox.Focus()

        Return False
    End Function
    Public Function InsertStudent(ByVal StudentNumber As String, ByVal Fullname As String, ByVal BirthDate As Date, ByVal Course As String, ByVal EmailAddress As String, ByVal PhoneNumber As String, ByVal Gender As String, ByVal Age As String, ByVal Address As String, ByVal GuardianName As String, ByVal GuardianPhoneNumber As String, ByVal qrImage As Byte()) As Boolean
        Try
            Dim query = "INSERT INTO StudentsInfo ([StudentNumber],[FullName],[BirthDate],[Course],[EmailAddress],[PhoneNumber],[Gender],[Age],[Address],[GuardianName],[GuardianPhoneNumber],[QR]) VALUES (@StudentNumber,@FullName,@BirthDate,@Course,@EmailAddress,@PhoneNumber,@Gender,@Age,@Address,@GuardianName,@GuardianPhoneNumber,@QR)"
            connection.AddParam("@StudentNumber", StudentNumber)
            connection.AddParam("@FullName", Fullname)
            connection.AddParam("@BirthDate", BirthDate.ToString("yyyy-MM-dd")) ' cast Date to string
            connection.AddParam("@Course", Course)
            connection.AddParam("@EmailAddress", EmailAddress)
            connection.AddParam("@PhoneNumber", PhoneNumber)
            connection.AddParam("@Gender", Gender)
            connection.AddParam("@Age", Age)
            connection.AddParam("@Address", Address)
            connection.AddParam("@GuardianName", GuardianName)
            connection.AddParam("@GuardianPhoneNumber", GuardianPhoneNumber)
            connection.Parameters.Add(New SqlParameter("@QR", qrImage))

            If connection.Insert(query) Then
                MsgBox("Added successfully", MsgBoxStyle.Information, "Success")
                Return True
            End If
        Catch ex As Exception
            MsgBox("Error adding student: " & ex.Message)
            Return False
        End Try
        Return False
    End Function

    Public Function UpdateStudent(ByVal ID As String, ByVal StudentNumber As String,
                             ByVal Fullname As String,
                             ByVal BirthDate As Date,
                             ByVal Course As String,
                             ByVal EmailAddress As String,
                             ByVal PhoneNumber As String,
                             ByVal Gender As String,
                             ByVal Age As String,
                             ByVal Address As String,
                             ByVal GuardianName As String,
                             ByVal GuardianPhoneNumber As String,
                             ByVal qrImage As Byte()) As Boolean

        Try
            Dim query = "UPDATE StudentsInfo set StudentNumber=@StudentNumber, FullName=@FullName, BirthDate=@BirthDate, Course=@Course, EmailAddress=@EmailAddress, PhoneNumber=@PhoneNumber, Gender=@Gender, Age=@Age, Address=@Address, GuardianName=@GuardianName, GuardianPhoneNumber=@GuardianPhoneNumber, QR=@QR WHERE ID=@ID"
            connection.AddParam("@ID", ID)
            connection.AddParam("@StudentNumber", StudentNumber)
            connection.AddParam("@FullName", Fullname)
            connection.AddParam("@BirthDate", BirthDate.ToString("yyyy-MM-dd")) ' cast Date to string
            connection.AddParam("@Course", Course)
            connection.AddParam("@EmailAddress", EmailAddress)
            connection.AddParam("@PhoneNumber", PhoneNumber)
            connection.AddParam("@Gender", Gender)
            connection.AddParam("@Age", Age)
            connection.AddParam("@Address", Address)
            connection.AddParam("@GuardianName", GuardianName)
            connection.AddParam("@GuardianPhoneNumber", GuardianPhoneNumber)
            connection.Parameters.Add(New SqlParameter("@QR", qrImage))

            If connection.Update(query) Then
                MsgBox("Updated successfully", MsgBoxStyle.Information, "Success")
                Return True
            End If
        Catch ex As Exception
            MsgBox("Error updating student: " & ex.Message)
            Return False
        End Try
        Return False
    End Function

    Public Function DeleteStudent(ByVal ID As String) As Boolean
        Try
            Dim query = "DELETE FROM StudentsInfo WHERE ID=@ID"
            connection.AddParam("@ID", ID)

            If connection.Delete(query) Then
                MsgBox("Deleted successfully", MsgBoxStyle.Information, "Success")
                Return True
            End If
        Catch ex As Exception
            MsgBox("Error deleting student: " & ex.Message)
            Return False
        End Try
        Return False
    End Function

    Public Sub SaveQR(ByVal qrImage As Image)
        If qrImage Is Nothing Then Return

        Dim saveDialog As New SaveFileDialog()
        saveDialog.Filter = "(*.bmp)|*.bmp|jpeg (*.jpeg)|*.jpeg|png (*.png)|*.png|tiff (*.tiff)|*.tiff"
        If saveDialog.ShowDialog() = DialogResult.OK Then
            qrImage.Save(saveDialog.FileName)
        End If
    End Sub

End Module
