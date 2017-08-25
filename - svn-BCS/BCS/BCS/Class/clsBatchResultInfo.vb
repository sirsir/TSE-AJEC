Public Class clsBatchResultInfo
#Region "Public"
    Public Shared m_objLogger As clsLogger = New clsLogger
#End Region

#Region "Attributes"
    Private m_intBatchNo As Integer
    Private m_dtBatchDate As DateTime
    Private m_intShiftCode As Integer
    Private m_intRMNo As Integer
    Private m_intRevisionId As Integer
    Private m_dblReadValueActual As Double
    Private m_intBatchSeq As Integer
    Private m_adox As clsAdoX
#End Region

#Region "Property"
    Public Property BatchNo() As Integer
        Get
            Return Me.m_intBatchNo
        End Get
        Set(ByVal value As Integer)
            Me.m_intBatchNo = value
        End Set
    End Property
    Public Property BatchDate() As DateTime
        Get
            Return Me.m_dtBatchDate
        End Get
        Set(ByVal value As DateTime)
            Me.m_dtBatchDate = value
        End Set
    End Property
    Public Property ShiftCode() As Integer
        Get
            Return Me.m_intShiftCode
        End Get
        Set(ByVal value As Integer)
            Me.m_intShiftCode = value
        End Set
    End Property
    Public Property RMNo() As Integer
        Get
            Return Me.m_intRMNo
        End Get
        Set(ByVal value As Integer)
            Me.m_intRMNo = value
        End Set
    End Property
    Public Property RevisionId() As Integer
        Get
            Return Me.m_intRevisionId
        End Get
        Set(ByVal value As Integer)
            Me.m_intRevisionId = value
        End Set
    End Property
    Public Property ReadValueActual() As Double
        Get
            Return Me.m_dblReadValueActual
        End Get
        Set(ByVal value As Double)
            Me.m_dblReadValueActual = value
        End Set
    End Property

    Public Property BatchSeq As Integer
        Get
            Return m_intBatchSeq
        End Get
        Set(ByVal value As Integer)
            m_intBatchSeq = value
        End Set
    End Property
#End Region

#Region "Constructor"
    Public Sub New()
        Reset()
    End Sub

    Public Overridable Sub Reset()
        m_intBatchNo = -1
        m_dtBatchDate = Date.MinValue
        m_intShiftCode = -1
        m_intRMNo = -1
        m_intRevisionId = -1
        m_dblReadValueActual = 0
        m_adox = New clsAdoX
    End Sub
#End Region

#Region "method"
    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : CheckAvailable
    '   Purpose         : CheckAvailable Batch No
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : m_clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------
    'Public Shared Function CheckAvailable(ByVal intBatchNo As Integer) As Boolean
    '    Dim dt As DataTable
    '    Dim sSqlCmd As String = _
    '        " SELECT * " & _
    '        " FROM [BATCH_RESULT]" & _
    '        " WHERE BATCH_NO = " & intBatchNo
    '    Try
    '        dt = clsAdoxCached.GetDataTable(sSqlCmd)
    '        If Not dt Is Nothing AndAlso dt.Rows.Count > 0 Then
    '            CheckAvailable = True
    '        Else
    '            CheckAvailable = False
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show("clsBatchResultInfo.Count : " & ex.ToString())
    '        CheckAvailable = False
    '    End Try
    'End Function
    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : Find
    '   Purpose         : Find Object clsBatchResultInfo Object by Batch Id
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : m_clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------

    'Public Shared Function Find(ByVal intBatchNo As Integer) As clsBatchResultInfo
    '    Dim dt As DataTable
    '    Dim sSqlCmd As String = _
    '        " SELECT * " & _
    '        " FROM [BATCH_RESULT] br " & _
    '        " WHERE br.[BATCH_NO] = " & intBatchNo
    '    Try
    '        dt = clsAdoxCached.GetDataTable(sSqlCmd)
    '        Find = New clsBatchResultInfo()
    '        If Not dt Is Nothing AndAlso dt.Rows.Count > 0 Then
    '            With dt.Rows(0)
    '                Find.BatchNo = .Item("BATCH_NO")
    '                Find.BatchDate = .Item("BATCH_DATE")
    '                Find.ShiftCode = .Item("SHIFT_CODE")
    '                Find.RMNo = .Item("RM_NO")
    '                Find.RevisionId = .Item("REVISION_ID")
    '                Find.ReadValueActual = .Item("READ_VALUE_ACTUAL")
    '            End With
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show("clsBatchResultInfo.Find : " & ex.ToString())
    '        Find = Nothing
    '    End Try
    'End Function


    Public Function GetBatchSeqOfRevision(ByVal revisionId As Integer) As Integer
        Dim dt As DataTable
        Dim sSqlCmd As String = _
            " SELECT ISNULL(MAX(BATCH_SEQ),0) + 1 " & _
            " FROM [BATCH_RESULT] " & _
            " WHERE [REVISION_ID] = " & revisionId
        Try
            dt = m_adox.GetDataTable(sSqlCmd)
            If Not dt Is Nothing AndAlso dt.Rows.Count > 0 Then
                Return dt.Rows(0).Item(0)
            Else
                Return -1
            End If
        Catch ex As Exception
            m_objLogger.AppendLog(ex)
            Return -1
        End Try
    End Function

    Public Function GetBatchSeqOfFormulaCode(ByVal formulaCode As Integer) As Integer
        Dim dt As DataTable
        Dim sSqlCmd As String = _
            " SELECT ISNULL(MAX(BATCH_SEQ),0) + 1" & _
            " FROM [BATCH_RESULT] br join REVISION rv " & _
            " on br.REVISION_ID = rv.REVISION_ID" & _
            " join FORMULA_MASTER fm " & _
            " on rv.FORMULA_ID = fm.FORMULA_ID" & _
            " WHERE fm.FORMULA_CODE = " & formulaCode
        Try
            dt = m_adox.GetDataTable(sSqlCmd)
            If Not dt Is Nothing AndAlso dt.Rows.Count > 0 Then
                Return dt.Rows(0).Item(0)
            Else
                Return -1
            End If
        Catch ex As Exception
            m_objLogger.AppendLog(ex)
            Return -1
        End Try
    End Function

    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : Count
    '   Purpose         : Count Object clsBatchResultInfo
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : m_clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------
    'Public Shared Function Count() As Integer
    '    Dim dt As DataTable
    '    Dim sSqlCmd As String = _
    '        " SELECT COUNT(BATCH_NO) " & _
    '        " FROM [BATCH_RESULT]"
    '    Try
    '        dt = clsAdoxCached.GetDataTable(sSqlCmd)
    '        If Not dt Is Nothing AndAlso dt.Rows.Count = 0 Then
    '            Count = 0
    '        Else
    '            Count = dt.Rows(0).Item(0)
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show("clsBatchResultInfo.Count : " & ex.ToString())
    '        Count = -1
    '    End Try
    'End Function

    ''--------------------------------------------------------------------------------------------------------
    ''   Function Name   : CheckAvailableID
    ''   Purpose         : Find Object clsBatchResultInfo Object by Batch Id
    ''   Created         : Pentita 15/06/2012
    ''   Modified        :
    ''
    ''   Linked          : m_clsAdoxCached.GetDataTable
    ''--------------------------------------------------------------------------------------------------------

    'Public Function CheckAvailableID(ByVal intBatchNo As Integer, ByVal dtBatchDate As DateTime, ByVal intLineNo As Integer, ByVal intScaleId As Integer, Optional ByVal intRMNo As Integer = 0) As Boolean
    '    Dim dt As DataTable
    '    Dim sSqlCmd As String = _
    '        " SELECT COUNT(*) " & _
    '        " FROM [BATCH_RESULT] br " & _
    '        " JOIN REVISION as rev ON br.REVISION_ID = rev.REVISION_ID " & _
    '        " JOIN FORMULA_MASTER as fml ON rev.FORMULA_ID = fml.FORMULA_ID " & _
    '        " WHERE br.[BATCH_NO] = " & intBatchNo & _
    '        " AND CONVERT(VARCHAR,br.[BATCH_DATE],111) = '" & dtBatchDate.ToString("yyyy/MM/dd") & "'" & _
    '        " AND fml.LINE_NO = " & intLineNo & _
    '        " AND RM_NO IN (SELECT RM_NO FROM RM_MASTER WHERE SCALE_ID = " & intScaleId & ")"

    '    '" AND br.[BATCH_DATE] = CONVERT(datetime, '" & dtBatchDate.ToString("yyyy/MM/dd") & "',111)" & _
    '    Try
    '        If intRMNo > 0 Then
    '            sSqlCmd &= " AND RM_NO = " & intRMNo
    '        End If
    '        dt = m_adox.GetDataTable(sSqlCmd)
    '        If Not dt Is Nothing AndAlso dt.Rows.Count > 0 AndAlso (dt.Rows(0).Item(0) = clsRMInfo.Count(intScaleId) And intRMNo = 0) Then
    '            CheckAvailableID = True
    '        ElseIf Not dt Is Nothing AndAlso dt.Rows.Count > 0 AndAlso (dt.Rows(0).Item(0) >= 1 And intRMNo > 0) Then
    '            CheckAvailableID = True
    '        Else
    '            CheckAvailableID = False
    '        End If
    '    Catch ex As Exception
    '        'MessageBox.Show("clsBatchResultInfo.CheckAvailableID : " & ex.ToString())
    '        m_objLogger.AppendLog(ex)
    '        CheckAvailableID = False
    '    End Try
    'End Function
    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : CheckExistingBatchResult
    '   Purpose         : Find Object clsBatchResultInfo Object by PK
    '   Created         : Chirayuth 08/08/2012
    '   Modified        :
    '
    '   Linked          : m_adox.GetDataTable
    '--------------------------------------------------------------------------------------------------------

    Public Function CheckExistingBatchResult(ByVal intBatchSeq As Integer, _
                                  ByVal dtBatchDate As DateTime, _
                                  ByVal intRMNo As Integer,
                                  ByVal intRevisionId As Integer) As Boolean
        Dim dt As DataTable
        Dim sSqlCmd As String = _
            " SELECT COUNT(*) " & _
            " FROM [BATCH_RESULT] br " & _
            " WHERE br.[BATCH_SEQ] = " & intBatchSeq & _
            " AND (CONVERT(VARCHAR,br.[BATCH_DATE],111) = CONVERT(varchar,CONVERT(date,'" & dtBatchDate.ToString("s") & "'),111)" & _
            " OR CONVERT(VARCHAR,br.[BATCH_DATE],111) = CONVERT(varchar,CONVERT(date,'" & DateAdd(DateInterval.Hour, -1, dtBatchDate).ToString("s") & "'),111))" & _
            " AND br.[RM_NO] = " & intRMNo & _
            " AND br.[REVISION_ID] = " & intRevisionId
        Try
            dt = m_adox.GetDataTable(sSqlCmd)
            If Not dt Is Nothing AndAlso dt.Rows.Count > 0 AndAlso dt.Rows(0).Item(0) > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            'MessageBox.Show("clsBatchResultInfo.CheckAvailableID : " & ex.ToString())
            m_objLogger.AppendLog(ex)
            Return False
        End Try
    End Function
    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : Create
    '   Purpose         : Create Object clsBatchResultInfo
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : m_clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------
    Public Function Create(ByVal intBatchNo As Integer, _
                                  ByVal dtBatchDate As DateTime, _
                                  ByVal intShiftCode As Integer, _
                                  ByVal intRMNo As Integer, _
                                  ByVal intRevisionId As Integer, _
                                  ByVal dblReadValueActual As Double, _
                                  ByVal intBatchSeq As Integer) As Integer
        Dim sSqlCmd As String = _
            " INSERT INTO [BATCH_RESULT]" & _
            "([BATCH_NO] " & _
            ",[BATCH_DATE] " & _
            ",[SHIFT_CODE] " & _
            ",[RM_NO] " & _
            ",[REVISION_ID] " & _
            ",[READ_VALUE_ACTUAL] " & _
            ",[BATCH_SEQ] " & _
            ") VALUES ( " & _
            " " & intBatchNo & _
            "," & "'" & dtBatchDate.ToString("s") & "'" & _
            "," & intShiftCode & _
            "," & intRMNo & _
            "," & intRevisionId & _
            "," & dblReadValueActual & _
            "," & intBatchSeq & _
            ")"
        Try
            Return m_adox.Execute(sSqlCmd)
        Catch ex As Exception
            'MessageBox.Show("clsBatchResultInfo.Create : " & ex.ToString())
            m_objLogger.AppendLog(ex)
        End Try
        Return 0
    End Function

    Public Function CreateWithoutShift(ByVal intBatchNo As Integer, _
                                  ByVal dtBatchDate As DateTime, _
                                  ByVal intRMNo As Integer, _
                                  ByVal intRevisionId As Integer, _
                                  ByVal dblReadValueActual As Double, _
                                  ByVal intBatchSeq As Integer) As Integer
        Dim sSqlCmd As String = _
            " INSERT INTO [BATCH_RESULT]" & _
            "([BATCH_NO] " & _
            ",[BATCH_DATE] " & _
            ",[RM_NO] " & _
            ",[REVISION_ID] " & _
            ",[READ_VALUE_ACTUAL] " & _
            ",[BATCH_SEQ] " & _
            ") VALUES ( " & _
            " " & intBatchNo & _
            "," & "'" & dtBatchDate.ToString("s") & "'" & _
            "," & intRMNo & _
            "," & intRevisionId & _
            "," & dblReadValueActual & _
            "," & intBatchSeq & _
            ")"
        Try
            Return m_adox.Execute(sSqlCmd)
        Catch ex As Exception
            'MessageBox.Show("clsBatchResultInfo.Create : " & ex.ToString())
            m_objLogger.AppendLog(ex)
        End Try
        Return 0
    End Function

    Public Function FillZeroWeightRecords(ByVal intBatchNo As Integer, _
                                 ByVal dtBatchStart As DateTime, _
                                 ByVal intRevisionId As Integer, _
                                 ByVal intBatchSeq As Integer) As Integer
        Dim sSqlCmd As String = _
        " INSERT INTO [BATCH_RESULT]" & _
        " ([BATCH_NO]" & _
        " ,[BATCH_DATE]" & _
        " ,[RM_NO]" & _
        " ,[SHIFT_CODE]" & _
        " ,[REVISION_ID]" & _
        " ,[READ_VALUE_ACTUAL]" & _
        " ,[BATCH_SEQ])" & _
        "   SELECT DISTINCT " & intBatchNo & " BATCH_NO" & _
        "       , '" & dtBatchStart.ToString("s") & "' BATCH_DATE" & _
        "       , rm.RM_NO RM_NO" & _
        "       , NULL SHIFT_CODE" & _
        "       , " & intRevisionId & " REVISION_ID" & _
        "       , 0 READ_VALUE_ACTUAL" & _
        "       , " & intBatchSeq & " BATCH_SEQ" & _
        "   FROM BATCH_RESULT br, RM_MASTER rm " & _
        "   WHERE rm.RM_NO in (select RM_NO from RM_MASTER where RM_CODE NOT LIKE 'OIL') "

        Try
            Return m_adox.Execute(sSqlCmd)
        Catch ex As Exception
            'MessageBox.Show("clsBatchResultInfo.Create : " & ex.ToString())
            m_objLogger.AppendLog(ex)
        End Try
        Return 0
    End Function

    Public Function FillZeroOilRecords(ByVal intBatchOilNo As Integer, _
                                 ByVal dtBatchStart As DateTime, _
                                 ByVal intRevisionId As Integer, _
                                 ByVal intBatchSeq As Integer) As Integer
        Dim sSqlCmd As String = _
        " INSERT INTO [BATCH_RESULT]" & _
        " ([BATCH_NO]" & _
        " ,[BATCH_DATE]" & _
        " ,[RM_NO]" & _
        " ,[SHIFT_CODE]" & _
        " ,[REVISION_ID]" & _
        " ,[READ_VALUE_ACTUAL]" & _
        " ,[BATCH_SEQ])" & _
        "   SELECT DISTINCT " & intBatchOilNo & " BATCH_NO" & _
        "       , '" & dtBatchStart.ToString("s") & "' BATCH_DATE" & _
        "       , rm.RM_NO RM_NO" & _
        "       , NULL SHIFT_CODE" & _
        "       , " & intRevisionId & " REVISION_ID" & _
        "       , 0 READ_VALUE_ACTUAL" & _
        "       , " & intBatchSeq & " BATCH_SEQ" & _
        "   FROM BATCH_RESULT br, RM_MASTER rm " & _
        "   WHERE rm.RM_NO in (select RM_NO from RM_MASTER where RM_CODE LIKE 'OIL')  "

        Try
            Return m_adox.Execute(sSqlCmd)
        Catch ex As Exception
            'MessageBox.Show("clsBatchResultInfo.Create : " & ex.ToString())
            m_objLogger.AppendLog(ex)
        End Try
        Return 0
    End Function

    ''--------------------------------------------------------------------------------------------------------
    ''   Function Name   : CreateNewBatchWeight
    ''   Purpose         : CreateNewBatchWeight Object clsBatchResultInfo
    ''   Created         : Pentita 15/06/2012
    ''   Modified        :
    ''
    ''   Linked          : m_clsAdoxCached.GetDataTable
    ''--------------------------------------------------------------------------------------------------------
    'Public Function CreateNewBatch(ByVal intBatchNo As Integer, _
    '                              ByVal dtBatchDate As DateTime, _
    '                              ByVal intShiftCode As Integer, _
    '                              ByVal intRevisionId As Integer, _
    '                              ByVal intScaleId As Integer, _
    '                              ByVal dblReadValueActual As Double())
    '    Dim dt As DataTable
    '    Dim i As Integer
    '    Dim intCount As Integer
    '    Try
    '        dt = clsRMInfo.FindByScale(intScaleId)
    '        intCount = dt.Rows.Count
    '        If Not dt Is Nothing Then
    '            For i = 1 To intCount
    '                If Not CheckAvailableID(intBatchNo, dtBatchDate, intScaleId, dt.Rows(i - 1).Item("RM_NO")) Then
    '                    Create(intBatchNo, dtBatchDate, intShiftCode, CInt(dt.Rows(i - 1).Item("RM_NO")), intRevisionId, dblReadValueActual(i - 1))
    '                End If
    '            Next
    '        End If
    '    Catch ex As Exception
    '        m_objLogger.AppendLog(ex)
    '    End Try
    '    Return Nothing
    'End Function
    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : CreateNewBatchLiquid
    '   Purpose         : CreateNewBatch Object clsBatchResultInfo
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : m_clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : Delete
    '   Purpose         : Delete Object clsMaterialInfo
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : m_clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------
    Public Function Delete(ByVal intBatchNo As Integer)
        Dim sSqlCmd As String = _
            " DELETE FROM [BATCH_RESULT]" & _
            " WHERE [BATCH_NO] = " & intBatchNo
        Try
            m_adox.Execute(sSqlCmd)
        Catch ex As Exception
            m_objLogger.AppendLog(ex)
        End Try
        Return Nothing
    End Function
    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : Update
    '   Purpose         : Update Object clsMaterialInfo
    '   Created         : Pentita 15/06/2012
    '   Modified        : Chirayuth 29/08/2012
    '
    '   Linked          : m_adox.GetDataTable
    '--------------------------------------------------------------------------------------------------------
    Public Function Update(ByVal dtBatchDate As DateTime, _
                                  ByVal intRMNo As Integer, _
                                  ByVal intRevisionId As Integer, _
                                  ByVal dblReadValueActual As Double, _
                                  ByVal intBatchSeq As Integer) As Integer
        Dim sSqlCmd As String = _
            " UPDATE [BATCH_RESULT]" & _
            " SET " & _
            " [BATCH_DATE] = '" & dtBatchDate.ToString("s") & "'" & _
            " ,[READ_VALUE_ACTUAL] = " & dblReadValueActual & _
            " WHERE [BATCH_RESULT].[BATCH_SEQ] =  " & intBatchSeq & _
            " AND (CONVERT(VARCHAR,[BATCH_DATE],111) = CONVERT(varchar,CONVERT(date,'" & dtBatchDate.ToString("s") & "'),111)" & _
            " OR CONVERT(VARCHAR,[BATCH_DATE],111) = CONVERT(varchar,CONVERT(date,'" & DateAdd(DateInterval.Hour, -1, dtBatchDate).ToString("s") & "'),111))" & _
            " AND [BATCH_RESULT].[REVISION_ID] = " & intRevisionId & _
            " AND [BATCH_RESULT].[RM_NO]  = " & intRMNo

        Try
            Return m_adox.Execute(sSqlCmd)
        Catch ex As Exception
            'MessageBox.Show("clsBatchResultInfo.Update : " & ex.ToString())
            m_objLogger.AppendLog(ex)
        End Try
        Return 0
    End Function
    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : Update
    '   Purpose         : Update Object clsMaterialInfo
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : m_clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------
    'Public Function UpdateBatch(ByVal intBatchNo As Integer, _
    '                              ByVal dtBatchDate As DateTime, _
    '                              ByVal intShiftCode As Integer, _
    '                              ByVal intRevisionId As Integer, _
    '                              ByVal dblReadValueActual As Double())
    '    Try
    '        For i As Integer = 1 To dblReadValueActual.Length
    '            Update(intBatchNo, dtBatchDate, intShiftCode, i, intRevisionId, dblReadValueActual(i - 1))
    '        Next
    '    Catch ex As Exception
    '        m_objLogger.AppendLog(ex)
    '    End Try
    '    Return Nothing
    'End Function

    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : CreateOrOverwrite
    '   Purpose         : Create Object clsBatchResultInfo and overwrite if already exits
    '   Created         : Chirayuth 08/08/2012
    '   Modified        :
    '
    '   Linked          : m_clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------
    Public Function CreateOrOverwrite(ByVal intBatchNo As Integer, _
                                  ByVal dtBatchDate As DateTime, _
                                  ByVal intRMNo As Integer, _
                                  ByVal intRevisionId As Integer, _
                                  ByVal dblReadValueActual As Double, _
                                  ByVal intBatchSeq As Integer) As Integer

        Try
            If Me.CheckExistingBatchResult(intBatchSeq, dtBatchDate, intRMNo, intRevisionId) Then
                Return Me.Update(dtBatchDate, intRMNo, intRevisionId, dblReadValueActual, intBatchSeq)
            Else
                Return Me.CreateWithoutShift(intBatchNo, dtBatchDate, intRMNo, intRevisionId, dblReadValueActual, intBatchSeq)
            End If
        Catch ex As Exception
            'MessageBox.Show("clsBatchResultInfo.Create : " & ex.ToString())
            m_objLogger.AppendLog(ex)
        End Try
        Return 0
    End Function
#End Region
End Class
