Imports MySql.Data.MySqlClient

Module ModGlobalProcedure

    Public Function fncConnectToDatabase() As Boolean
        Try
            servername = "localhost"
            databasename = "umtc"
            databaseuserid = "root"
            databasepassword = ""
            port = "3306"

            If conUMTC.State = ConnectionState.Closed Then
                conUMTC = New MySqlConnection

                strConnection = "SERVER=" & servername & ";" _
                              & "DATABASE=" & databasename & ";" _
                              & "USERNAME=" & databaseuserid & ";" _
                              & "PASSWORD=" & databasepassword & ";" _
                              & "PORT=" & port & ";" _
                              & "DEFAULT COMMAND TIMEOUT=" & 20 * 60

                conUMTC.ConnectionString = strConnection
                conUMTC.Open()
                command.Connection = conUMTC
                Return True
            Else
                conUMTC.Close()
                Return False
            End If

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try

        Return False
    End Function

    Public Sub checkDatabaseConnection()
        If fncConnectToDatabase() = True Then
        Else
            conUMTC.Open()
        End If

    End Sub

End Module
