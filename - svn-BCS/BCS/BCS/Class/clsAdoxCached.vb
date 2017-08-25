Public Class clsAdoxCached

    Private Shared s_adox As clsAdoX

    Private Shared ReadOnly Property Adox() As clsAdoX
        Get
            If s_adox Is Nothing Then
                s_adox = New clsAdoX
            ElseIf s_adox.DefaultActiveConnection.State = ConnectionState.Broken Or _
                    s_adox.DefaultActiveConnection.State = ConnectionState.Closed Then
                s_adox = New clsAdoX
            End If

            Return s_adox
        End Get
    End Property

    Public Shared Sub ShrinkDatabase(ByVal sDatabaseName As String)
        Dim sSqlCmd As String = "DBCC SHRINKDATABASE('" & sDatabaseName & "')"
        SyncLock Adox
            Adox.Execute(sSqlCmd)
        End SyncLock
    End Sub

    Public Shared Sub SetXactAbort(Optional ByVal blnOn As Boolean = True)
        Dim strState As String = IIf(blnOn, "ON", "OFF")
        SyncLock Adox
            Adox.Execute("SET XACT_ABORT " & strState)
        End SyncLock
    End Sub

    Public Shared Sub BeginTransaction()
        Adox.BeginTransaction()
    End Sub

    Public Shared Sub CommitTransaction()
        Adox.CommitTransaction()
    End Sub

    Public Shared Sub RollbackTransaction()
        Adox.RollbackTransaction()
    End Sub

    Public Shared Function Execute(ByVal strSQL As String, _
            Optional ByVal blnThrowExceptionOnError As Boolean = True, _
            Optional ByVal blnEnableHandling As Boolean = False, _
            Optional ByVal blnRollbackTranErrorOccurred As Boolean = True) As Integer

        SyncLock Adox
            Execute = Adox.Execute(strSQL, blnEnableHandling, blnRollbackTranErrorOccurred)

            If Execute < 0 And blnThrowExceptionOnError Then ThrowLastDataException()
        End SyncLock
    End Function

    Public Shared Function GetDataTable(ByVal strSQL As String, _
            Optional ByVal blnThrowExceptionOnError As Boolean = True, _
            Optional ByVal blnEnableHandling As Boolean = False) As DataTable
        SyncLock Adox
            GetDataTable = Adox.GetDataTable(strSQL, blnEnableHandling)

            If GetDataTable.Columns.Count = 0 And blnThrowExceptionOnError Then ThrowLastDataException()
        End SyncLock
    End Function

    Public Shared Function ExecuteStoredProc(ByVal strStoredProcName As String, _
            Optional ByVal arrInputParams As Object = Nothing, _
            Optional ByRef adocmd As System.Data.OleDb.OleDbCommand = Nothing, _
            Optional ByVal blnThrowExceptionOnError As Boolean = True, _
            Optional ByVal blnEnableHandling As Boolean = False, _
            Optional ByVal blnRollbackTranErrorOccurred As Boolean = True) As Boolean

        SyncLock Adox
            ExecuteStoredProc = Adox.ExecuteStoredProc(strStoredProcName, arrInputParams, adocmd, blnEnableHandling, blnRollbackTranErrorOccurred)

            If Not ExecuteStoredProc And blnThrowExceptionOnError Then ThrowLastDataException()
        End SyncLock
    End Function

    Private Shared Sub ThrowLastDataException()
    End Sub

End Class