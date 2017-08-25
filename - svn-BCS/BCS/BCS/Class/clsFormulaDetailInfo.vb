Public Class clsFormulaDetailInfo
#Region "Public"
    Public Shared m_objLogger As clsLogger = New clsLogger
#End Region
#Region "Attributes"
    Private m_intCheckBoxCrusher As Double
    Private m_intRMNo As Integer
    Private m_intRevisionId As Integer
    Private m_bChecked As Boolean
    Private m_strRMLot As String
    Private m_dblMaxValue As Double
    Private m_dblFinalValue As Double
    Private m_dblMinValue As Double
    Private m_dblSP1Value As Double
    Private m_dblSP2Value As Double
    Private m_dblCPSValue As Double
    Private m_dblHzHigh As Double
    Private m_dblHzMedium As Double
    Private m_dblHzLow As Double

#End Region
#Region "Property"
    Public Property Crusher() As Double
        Get
            Return Me.m_intCheckBoxCrusher
        End Get
        Set(ByVal value As Double)
            Me.m_intCheckBoxCrusher = value
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
    Public Property Checked() As Boolean
        Get
            Return Me.m_bChecked
        End Get
        Set(ByVal value As Boolean)
            Me.m_bChecked = value
        End Set
    End Property
    Public Property RMLot() As String
        Get
            Return Me.m_strRMLot
        End Get
        Set(ByVal value As String)
            Me.m_strRMLot = value
        End Set
    End Property
    Public Property MaxValue() As Double
        Get
            Return Me.m_dblMaxValue
        End Get
        Set(ByVal value As Double)
            Me.m_dblMaxValue = value
        End Set
    End Property
    Public Property FinalValue() As Double
        Get
            Return Me.m_dblFinalValue
        End Get
        Set(ByVal value As Double)
            Me.m_dblFinalValue = value
        End Set
    End Property
    Public Property MinValue() As Double
        Get
            Return Me.m_dblMinValue
        End Get
        Set(ByVal value As Double)
            Me.m_dblMinValue = value
        End Set
    End Property
    Public Property SP1Value() As Double
        Get
            Return Me.m_dblSP1Value
        End Get
        Set(ByVal value As Double)
            Me.m_dblSP1Value = value
        End Set
    End Property
    Public Property SP2Value() As Double
        Get
            Return Me.m_dblSP2Value
        End Get
        Set(ByVal value As Double)
            Me.m_dblSP2Value = value
        End Set
    End Property
    Public Property CPSValue() As Double
        Get
            Return Me.m_dblCPSValue
        End Get
        Set(ByVal value As Double)
            Me.m_dblCPSValue = value
        End Set
    End Property

    Public Property HzHigh As Double
        Get
            Return m_dblHzHigh
        End Get
        Set(ByVal value As Double)
            m_dblHzHigh = value
        End Set
    End Property

    Public Property HzMedium As Double
        Get
            Return m_dblHzMedium
        End Get
        Set(ByVal value As Double)
            m_dblHzMedium = value
        End Set
    End Property

    Public Property HzLow As Double
        Get
            Return m_dblHzLow
        End Get
        Set(ByVal value As Double)
            m_dblHzLow = value
        End Set
    End Property
#End Region

#Region "Constructor"
    Protected Sub New()
        Reset()
    End Sub

    Public Overridable Sub Reset()
        m_intRMNo = -1
        m_intRevisionId = -1
        m_bChecked = False
        m_strRMLot = String.Empty
        m_dblMaxValue = 0
        m_dblFinalValue = 0
        m_dblMinValue = 0
        m_dblSP1Value = 0
        m_dblSP2Value = 0
        m_dblCPSValue = 0
        m_dblHzHigh = 0
        m_dblHzMedium = 0
        m_dblHzLow = 0
    End Sub
#End Region

#Region "method"
    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : FindAll
    '   Purpose         : FindAll
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------

    Public Shared Function FindAll() As DataTable
        Dim dt As DataTable
        Dim dblMaxValue As Double = 0
        Dim sSqlCmd As String = _
            " SELECT * " & _
            " FROM [FORMULA_DETAIL] fd "
        Try
            dt = clsAdoxCached.GetDataTable(sSqlCmd)
            If Not dt Is Nothing AndAlso dt.Rows.Count > 0 Then
                FindAll = dt
            Else
                FindAll = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show("clsFormuldaDetailInfo.FindAll : " & ex.ToString())
            FindAll = Nothing
        End Try
    End Function

    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : FindActive
    '   Purpose         : FindActive
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------

    Public Shared Function FindActive(ByVal intFormulaCode, ByVal intLineNo) As DataTable
        Dim dt As DataTable
        Dim dblMaxValue As Double = 0
        Dim sSqlCmd As String = _
        "  SELECT * FROM FORMULA_DETAIL fd " & _
        " WHERE REVISION_ID = " & _
        " (SELECT REVISION_ID FROM REVISION join  FORMULA_MASTER " & _
        " on REVISION.FORMULA_ID = FORMULA_MASTER.FORMULA_ID " & _
        " WHERE REVISION.ACTIVE_FLAG = 1 " & _
        " AND FORMULA_MASTER.FORMULA_CODE = " & intFormulaCode & _
        " AND FORMULA_MASTER.LINE_NO = " & intLineNo & ")" & _
        " ORDER BY fd.RM_NO "
        Try
            dt = clsAdoxCached.GetDataTable(sSqlCmd)
            If Not dt Is Nothing AndAlso dt.Rows.Count > 0 Then
                FindActive = dt
            Else
                FindActive = Nothing
            End If
        Catch ex As Exception
            'MessageBox.Show("clsFormuldaDetailInfo.FindActive : " & ex.ToString())
            m_objLogger.AppendLog(ex)
            FindActive = Nothing
        End Try
    End Function

    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : FindLastest
    '   Purpose         : FindLastest
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------
    Public Shared Function FindLastest(ByVal intFormulaId, ByVal intLineNo) As DataTable
        Dim dt As DataTable
        Dim dblMaxValue As Double = 0
        Dim sSqlCmd As String = _
        "  SELECT * FROM FORMULA_DETAIL fd " & _
        " WHERE REVISION_ID = " & _
        " (SELECT MAX(REVISION_ID) FROM REVISION join  FORMULA_MASTER " & _
        " on REVISION.FORMULA_ID = FORMULA_MASTER.FORMULA_ID " & _
        " WHERE FORMULA_MASTER.FORMULA_CODE = " & intFormulaId & _
        " AND FORMULA_MASTER.LINE_NO = " & intLineNo & ")"
        Try
            dt = clsAdoxCached.GetDataTable(sSqlCmd)
            If Not dt Is Nothing AndAlso dt.Rows.Count > 0 Then
                FindLastest = dt
            Else
                FindLastest = Nothing
            End If
        Catch ex As Exception
            'MessageBox.Show("clsFormuldaDetailInfo.FindLastest : " & ex.ToString())
            m_objLogger.AppendLog(ex)
            FindLastest = Nothing
        End Try
    End Function
    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : Find
    '   Purpose         : Find Final Actual Value by Formula Id and Material Id
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------

    Public Shared Function Find(ByVal intRMNo As Integer, ByVal intRevisionId As Integer) As clsFormulaDetailInfo
        Dim dt As DataTable
        Dim dblMaxValue As Double = 0
        Dim sSqlCmd As String = _
            " SELECT * " & _
            " FROM [FORMULA_DETAIL] fd " & _
            " WHERE fd.[RM_NO] = " & intRMNo & _
            " WHERE fd.[REVISION_ID] = " & intRevisionId
        Try
            dt = clsAdoxCached.GetDataTable(sSqlCmd)
            Find = New clsFormulaDetailInfo()
            If Not dt Is Nothing AndAlso dt.Rows.Count > 0 Then
                With dt.Rows(0)
                    Find.RMNo = .Item("RM_NO")
                    Find.RevisionId = .Item("REVISION_ID")
                    Find.Checked = .Item("CHECKED")
                    Find.RMLot = .Item("RM_LOT")
                    Find.MaxValue = .Item("MAX_VALUE")
                    Find.FinalValue = .Item("FINAL_VALUE")
                    Find.MinValue = .Item("MIN_VALUE")
                    Find.SP1Value = .Item("SP1_VALUE")
                    Find.SP2Value = .Item("SP2_VALUE")
                    Find.CPSValue = .Item("CPS_VALUE")
                    Find.HzHigh = .Item("HZ_H")
                    Find.HzMedium = .Item("HZ_M")
                    Find.HzLow = .Item("HZ_L")
                    Find.Crusher = .Item("CRUSHER")
                End With
            End If
        Catch ex As Exception
            MessageBox.Show("clsFormuldaDetailInfo.Find : " & ex.ToString())
            Find = Nothing
        End Try
    End Function
    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : Count
    '   Purpose         : Count Object clsFormulaDetailInfo
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------
    Public Shared Function Count(ByVal intRMNo As Integer) As Integer
        Dim dt As DataTable
        Dim intCount As Integer = 0
        Dim sSqlCmd As String = _
            " SELECT COUNT(RM_NO) " & _
            " FROM [FORMULA_DETAIL] fm" & _
            " WHERE fm.[RM_NO] = " & intRMNo
        Try
            dt = clsAdoxCached.GetDataTable(sSqlCmd)
            If Not dt Is Nothing AndAlso dt.Rows.Count = 0 Then
                Count = 0
            Else
                Count = dt.Rows(0).Item(0)
            End If
        Catch ex As Exception
            MessageBox.Show("clsFormuldaDetailInfo.Count : " & ex.ToString())
            Count = -1
        End Try
    End Function

    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : Create
    '   Purpose         : Create Object clsFormulaDetailInfo
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------
    Public Shared Function Create(ByVal intRMNo As Integer, _
                                  ByVal intRevisionId As Integer, _
                                  ByVal intChecked As Integer, _
                                  ByVal intCheckedCrusher As Integer, _
                                  ByVal strRMLot As String, _
                                  ByVal dblMaxValue As Double, _
                                  ByVal dblFinalValue As Double, _
                                  ByVal dblMinValue As Double, _
                                  ByVal dblSP1Value As Double, _
                                  ByVal dblSP2Value As Double, _
                                  ByVal dblCPSValue As Double, _
                                  ByVal dblHzHigh As Double, _
                                  ByVal dblHzMedium As Double, _
                                  ByVal dblHzLow As Double)
        Dim sSqlCmd As String = _
            " INSERT INTO [FORMULA_DETAIL]" & _
            "([RM_NO] " & _
            ",[REVISION_ID] " & _
            ",[CHECKED] " & _
            ",[CRUSHER] " & _
            ",[RM_LOT] " & _
            ",[MAX_VALUE] " & _
            ",[FINAL_VALUE] " & _
            ",[MIN_VALUE] " & _
            ",[SP1_VALUE] " & _
            ",[SP2_VALUE] " & _
            ",[CPS_VALUE] " & _
            ",[HZ_H] " & _
            ",[HZ_M] " & _
            ",[HZ_L] " & _
            " ) VALUES ( " & _
            " " & intRMNo & _
            "," & intRevisionId & _
            "," & intChecked & _
            "," & intCheckedCrusher & _
            ",'" & strRMLot & "'" & _
            "," & dblMaxValue & _
            "," & dblFinalValue & _
            "," & dblMinValue & _
            "," & dblSP1Value & _
            "," & dblSP2Value & _
            "," & dblCPSValue & _
            "," & dblHzHigh & _
            "," & dblHzMedium & _
            "," & dblHzLow & _
            ")"
        Try
            clsAdoxCached.Execute(sSqlCmd)
        Catch ex As Exception
            MessageBox.Show("clsFormuldaDetailInfo.Create : " & ex.ToString())
        End Try
        Return Nothing
    End Function

    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : Delete
    '   Purpose         : Delete Object clsFormulaDetailInfo
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------
    Public Shared Function Delete(ByVal intRevisionId As Integer)
        Dim sSqlCmd As String = _
            " DELETE FROM [FORMULA_DETAIL]" & _
            " WHERE " & _
            " REVISION_ID = " & intRevisionId
        Try
            clsAdoxCached.Execute(sSqlCmd)
        Catch ex As Exception
            MessageBox.Show("clsFormuldaDetailInfo.Delete : " & ex.ToString())
        End Try
        Return Nothing
    End Function
    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : Update
    '   Purpose         : Update Object clsFormulaDetailInfo
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------
    Public Shared Function Update(ByVal intRMNo As Integer, _
                                  ByVal intRevisionId As Integer, _
                                  ByVal bChecked As Boolean, _
                                  ByVal strRMLot As String, _
                                  ByVal dblMaxValue As Double, _
                                  ByVal dblFinalValue As Double, _
                                  ByVal dblMinValue As Double, _
                                  ByVal dblSP1Value As Double, _
                                  ByVal dblSP2Value As Double, _
                                  ByVal dblCPSValue As Double, _
                                  ByVal dblHzHigh As Double, _
                                  ByVal dblHzMedium As Double, _
                                  ByVal dblHzLow As Double)
        Dim sSqlCmd As String = _
            " UPDATE [FORMULA_DETAIL]" & _
            " SET " & _
            " [CHECKED]  = " & bChecked & _
            ",[RM_LOT]  = '" & strRMLot & "'" & _
            ",[MAX_VALUE]  = " & dblMaxValue & _
            ",[FINAL_VALUE]  = " & dblFinalValue & _
            ",[MIN_VALUE]  = " & dblMinValue & _
            ",[SP1_VALUE]  = " & dblSP1Value & _
            ",[SP2_VALUE]  = " & dblSP2Value & _
            ",[CPS_VALUE]  = " & dblCPSValue & _
            ",[HZ_H]  = " & dblHzHigh & _
            ",[HZ_M]  = " & dblHzMedium & _
            ",[HZ_L]  = " & dblHzLow & _
            " WHERE [RM_NO] = " & intRMNo & _
            " , [REVISION_ID] = " & intRevisionId
        Try
            clsAdoxCached.Execute(sSqlCmd)
        Catch ex As Exception
            MessageBox.Show("clsFormuldaDetailInfo.Update : " & ex.ToString())
        End Try
        Return Nothing
    End Function
#End Region
End Class
