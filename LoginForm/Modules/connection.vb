Imports System.Data.SqlClient

Module connection
    Public ConnString = "Server=.\SQLEXPRESS; Database=DBStudentInformation; Trusted_Connection=True;"
    Public Connect As New SqlConnection(ConnString)
    Public Parameters As New List(Of SqlParameter)
    Public Data As DataSet
    Public Datacount As Integer



    Public Sub Open()
        If Connect.State = ConnectionState.Closed Then
            Connect.Open()
        End If
    End Sub

    Public Sub Close()
        If Connect.State = ConnectionState.Open Then
            Connect.Close()
        End If
    End Sub

    Public Sub AddParam(ByVal Key As String, ByVal value As String)
        Parameters.Add(New SqlParameter(Key, value))
    End Sub

    Public Function Query(ByVal command_query As String)
        Open()

        Dim command As New SqlCommand(command_query, Connect)

        If Parameters.Count > 0 Then
            For Each param As SqlParameter In Parameters
                command.Parameters.Add(param)
            Next
            Parameters.Clear()
        End If


        Dim Adapter As New SqlDataAdapter(command)

        Data = New DataSet
        Datacount = Adapter.Fill(Data)

        Close()
        Return Datacount > 0
    End Function

    Public Function Insert(ByVal insertQuery As String) As Boolean
        Try
            Open()
            Dim command As New SqlCommand(insertQuery, Connect)

            If Parameters.Count > 0 Then
                For Each param As SqlParameter In Parameters
                    command.Parameters.Add(param)
                Next
                Parameters.Clear()
            End If

            Datacount = command.ExecuteNonQuery()
            Return Datacount > 0

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Close()
        End Try
    End Function

    Public Function Update(ByVal updateQuery As String) As Boolean
        Try
            Open()
            Dim command As New SqlCommand(updateQuery, Connect)

            If Parameters.Count > 0 Then
                For Each param As SqlParameter In Parameters
                    command.Parameters.Add(param)
                Next
                Parameters.Clear()
            End If

            Datacount = command.ExecuteNonQuery()
            Return Datacount > 0
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Close()
        End Try
    End Function

    Public Function Delete(ByVal deleteQuery As String) As Boolean
        Try
            Open()
            Dim command As New SqlCommand(deleteQuery, Connect)

            If Parameters.Count > 0 Then
                For Each param As SqlParameter In Parameters
                    command.Parameters.Add(param)
                Next
                Parameters.Clear()
            End If

            Datacount = command.ExecuteNonQuery()
            Return Datacount > 0
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Close()
        End Try
    End Function

End Module
