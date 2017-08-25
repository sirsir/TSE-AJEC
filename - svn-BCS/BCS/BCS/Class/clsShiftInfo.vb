Public Class clsShiftInfo

#Region "Attributes"
    Private m_intShiftCode As Integer
    Private m_strShiftName As String
    Private m_intTimeStartHr As Integer
    Private m_intTimeStartMin As Integer
    Private m_intTimeEndHr As Integer
    Private m_intTimeEndMin As Integer
#End Region
#Region "Property"

    Public Property ShiftCode() As Integer
        Get
            Return Me.m_intShiftCode
        End Get
        Set(ByVal value As Integer)
            Me.m_intShiftCode = value
        End Set
    End Property
    Public Property ShiftName() As String
        Get
            Return Me.m_strShiftName
        End Get
        Set(ByVal value As String)
            Me.m_strShiftName = value
        End Set
    End Property
    Public Property TimeStartHr() As Integer
        Get
            Return Me.m_intTimeStartHr
        End Get
        Set(ByVal value As Integer)
            Me.m_intTimeStartHr = value
        End Set
    End Property
    Public Property TimeStartMin() As Integer
        Get
            Return Me.m_intTimeStartMin
        End Get
        Set(ByVal value As Integer)
            Me.m_intTimeStartMin = value
        End Set
    End Property
    Public Property TimeEndHr() As Integer
        Get
            Return Me.m_intTimeEndHr
        End Get
        Set(ByVal value As Integer)
            Me.m_intTimeEndHr = value
        End Set
    End Property
    Public Property TimeEndMin() As Integer
        Get
            Return Me.m_intTimeEndMin
        End Get
        Set(ByVal value As Integer)
            Me.m_intTimeEndMin = value
        End Set
    End Property
#End Region

#Region "Constructor"
    Protected Sub New()
        Reset()
    End Sub

    Public Overridable Sub Reset()
        m_intShiftCode = -1
        m_strShiftName = String.Empty
        m_intTimeStartHr = -1
        m_intTimeStartMin = -1
        m_intTimeEndHr = -1
        m_intTimeEndMin = -1
    End Sub
#End Region

#Region "method"
    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : Find
    '   Purpose         : Find Shift Name by Shift Code
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------

    Public Shared Function FindShiftName(ByVal intShiftCode As Integer) As String
        Dim dt As DataTable
        Dim strShiftName As String = String.Empty
        Dim sSqlCmd As String = _
            " SELECT * " & _
            " FROM [SHIFT_MASTER] sm " & _
            " WHERE sm.[SHIFT_CODE] = " & intShiftCode
        Try
            dt = clsAdoxCached.GetDataTable(sSqlCmd)
            If Not dt Is Nothing Then
                strShiftName = dt.Rows(0).Item("SHIFT_NAME")
                If strShiftName = Nothing Then
                    strShiftName = String.Empty
                End If
            End If
            FindShiftName = strShiftName
        Catch ex As Exception
            MessageBox.Show("clsShiftInfo.FindShiftName : " & ex.ToString())
            FindShiftName = String.Empty
        End Try
    End Function

    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : Find
    '   Purpose         : Find Shift Time by Shift Code
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------

    Public Shared Function FindShiftTimeStart(ByVal intShiftCode As Integer) As TimeSpan
        Dim dt As DataTable
        Dim tmShiftStart As TimeSpan = Nothing
        Dim sSqlCmd As String = _
            " SELECT * " & _
            " FROM [SHIFT_MASTER] sm " & _
            " WHERE sm.[SHIFT_CODE] = " & intShiftCode
        Try
            dt = clsAdoxCached.GetDataTable(sSqlCmd)
            If Not dt Is Nothing Then
                tmShiftStart = TimeSpan.Parse(dt.Rows(0).Item("TIME_START_HR").ToString & _
                                        ":" & dt.Rows(0).Item("TIME_START_MIN").ToString)
            End If
            If tmShiftStart = Nothing Then
                FindShiftTimeStart = Nothing
            Else
                FindShiftTimeStart = tmShiftStart
            End If
        Catch ex As Exception
            MessageBox.Show("clsShiftInfo.FindShiftTimeStart : " & ex.ToString())
            FindShiftTimeStart = Nothing
        End Try
    End Function

    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : Find
    '   Purpose         : Find Shift Time by Shift Code
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------

    Public Shared Function FindShiftTimeEnd(ByVal intShiftCode As Integer) As TimeSpan
        Dim dt As DataTable
        Dim tmShiftEnd As TimeSpan = Nothing
        Dim sSqlCmd As String = _
            " SELECT * " & _
            " FROM [SHIFT_MASTER] sm " & _
            " WHERE sm.[SHIFT_CODE] = " & intShiftCode
        Try
            dt = clsAdoxCached.GetDataTable(sSqlCmd)
            If Not dt Is Nothing Then
                tmShiftEnd = TimeSpan.Parse(dt.Rows(0).Item("TIME_END_HR").ToString & _
                                        ":" & dt.Rows(0).Item("TIME_END_MIN").ToString)
            End If
            If tmShiftEnd = Nothing Then
                FindShiftTimeEnd = Nothing
            Else
                FindShiftTimeEnd = tmShiftEnd
            End If
        Catch ex As Exception
            MessageBox.Show("clsShiftInfo.FindShiftTimeEnd : " & ex.ToString())
            FindShiftTimeEnd = Nothing
        End Try
    End Function
    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : FindAll
    '   Purpose         : FindAll data in Shift Master
    '   Created         : Pentita 14/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------

    Public Shared Function FindAll() As DataTable
        Dim dt As DataTable
        Dim sSqlCmd As String = _
            " SELECT * " & _
            " FROM [SHIFT_MASTER] lm "
        Try
            dt = clsAdoxCached.GetDataTable(sSqlCmd)
            If Not dt Is Nothing AndAlso dt.Rows.Count > 0 Then
                FindAll = dt
            Else
                FindAll = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show("clsShiftInfo.FindAll : " & ex.ToString())
            FindAll = Nothing
        End Try
    End Function
    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : Count
    '   Purpose         : Count Object clsShiftInfo
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------
    Public Shared Function Count() As Integer
        Dim dt As DataTable
        Dim intCount As Integer = 0
        Dim sSqlCmd As String = _
            " SELECT COUNT(SHIFT_CODE) " & _
            " FROM [SHIFT_MASTER]"
        Try
            dt = clsAdoxCached.GetDataTable(sSqlCmd)
            If Not dt Is Nothing AndAlso dt.Rows.Count = 0 Then
                Count = 0
            Else
                Count = dt.Rows(0).Item(0)
            End If
        Catch ex As Exception
            MessageBox.Show("clsShiftInfo.Count : " & ex.ToString())
            Count = -1
        End Try
    End Function
    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : AddFormulaNameToCombo
    '   Purpose         : Add RMCode to Combobox
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------

    Public Shared Function AddShiftNameToCombo(ByVal cmb As System.Windows.Forms.ComboBox) As Integer()
        Dim intShiftCount As Integer
        Dim dtShiftInfo As DataTable
        Dim i As Integer = 0
        Dim intArrayList() As Integer
        Try
            cmb.Items.Clear()
            dtShiftInfo = FindAll()
            If Not dtShiftInfo Is Nothing Then
                intShiftCount = dtShiftInfo.Rows.Count
                ReDim intArrayList(intShiftCount - 1)
                For i = 0 To intShiftCount - 1
                    cmb.Items.Add(dtShiftInfo.Rows(i).Item("SHIFT_NAME"))
                    intArrayList(i) = dtShiftInfo.Rows(i).Item("SHIFT_CODE")
                Next
                AddShiftNameToCombo = intArrayList
            Else
                AddShiftNameToCombo = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show("clsFormulaInfo.AddShiftNameToCombo : " & ex.ToString())
            AddShiftNameToCombo = Nothing
        End Try
    End Function
    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : Create
    '   Purpose         : Create Object clsShiftInfo
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------
    Public Shared Function Create(ByVal intShiftCode As Integer, _
                                  ByVal strShiftName As String, _
                                  ByVal intTimeStartHr As Integer, _
                                  ByVal intTimeStartMin As Integer, _
                                  ByVal intTimeEndtHr As Integer, _
                                  ByVal intTimeEndMin As Integer)
        Dim sSqlCmd As String = _
            " INSERT INTO [SHIFT_MASTER]" & _
            "([SHIFT_CODE]" & _
            ",[SHIFT_NAME]" & _
            ",[TIME_START_HR]" & _
            ",[TIME_START_MIN]" & _
            ",[TIME_END_HR]" & _
            ",[TIME_END_MIN]" & _
            ") VALUES ( " & _
            " " & intShiftCode & _
            " ,'" & strShiftName & "'" & _
            " ," & intTimeStartHr & _
            " ," & intTimeStartMin & _
            " ," & intTimeEndtHr & _
            " ," & intTimeEndMin & _
            ")"
        Try
            clsAdoxCached.Execute(sSqlCmd)
        Catch ex As Exception
            MessageBox.Show("clsShiftInfo.Create : " & ex.ToString())
        End Try
        Return Nothing
    End Function

    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : Delete
    '   Purpose         : Delete Object clsShiftInfo
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------
    Public Shared Function Delete(ByVal intShiftCode As Integer)
        Dim sSqlCmd As String = _
            " DELETE FROM [SHIFT_MASTER]" & _
            " WHERE " & _
            " SHIFT_CODE = " & intShiftCode
        Try
            clsAdoxCached.Execute(sSqlCmd)
        Catch ex As Exception
            MessageBox.Show("clsShiftInfo.Delete : " & ex.ToString())
        End Try
        Return Nothing
    End Function
    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : Update
    '   Purpose         : Update Object clsShiftInfo
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------
    Public Shared Function Update(ByVal intShiftCode As Integer, _
                                  ByVal strShiftName As String, _
                                  ByVal intTimeStartHr As Integer, _
                                  ByVal intTimeStartMin As Integer, _
                                  ByVal intTimeEndtHr As Integer, _
                                  ByVal intTimeEndMin As Integer)
        Dim sSqlCmd As String = _
            " UPDATE [SHIFT_MASTER]" & _
            " SET " & _
            " [SHIFT_NAME]  = '" & strShiftName & "'" & _
            " ,[TIME_START_HR]  = " & intTimeStartHr & _
            " ,[TIME_START_MIN]  = " & intTimeStartMin & _
            " ,[TIME_END_HR]  = " & intTimeEndtHr & _
            " ,[TIME_END_MIN]  = " & intTimeEndMin & _
            " WHERE [SHIFT_CODE] = " & intShiftCode
        Try
            clsAdoxCached.Execute(sSqlCmd)
        Catch ex As Exception
            MessageBox.Show("clsShiftInfo.Update : " & ex.ToString())
        End Try
        Return Nothing
    End Function
#End Region
End Class
