Public Class clsLineInfo

#Region "Attributes"
    Private m_intLineNo As Integer
    Private m_strLineCode As String
    Private m_intNet As Integer
    Private m_intNode As Integer
    Private m_intUnit As Integer
    Private m_intAddressLifeCheck As Integer
    Private m_intAddressFormulaSend As Integer
    Private m_intAddressFormulaRequest As Integer
#End Region

#Region "Property"

    Public Property LineNo() As Integer
        Get
            Return Me.m_intLineNo
        End Get
        Set(ByVal value As Integer)
            Me.m_intLineNo = value
        End Set
    End Property
    Public Property LineCode() As String
        Get
            Return Me.m_strLineCode
        End Get
        Set(ByVal value As String)
            Me.m_strLineCode = value
        End Set
    End Property
    Public Property Net() As Integer
        Get
            Return Me.m_intNet
        End Get
        Set(ByVal value As Integer)
            Me.m_intNet = value
        End Set
    End Property
    Public Property Node() As Integer
        Get
            Return Me.m_intNode
        End Get
        Set(ByVal value As Integer)
            Me.m_intNode = value
        End Set
    End Property
    Public Property Unit() As Integer
        Get
            Return Me.m_intUnit
        End Get
        Set(ByVal value As Integer)
            Me.m_intUnit = value
        End Set
    End Property
    Public Property AddressLifeCheck() As Integer
        Get
            Return Me.m_intAddressLifeCheck
        End Get
        Set(ByVal value As Integer)
            Me.m_intAddressLifeCheck = value
        End Set
    End Property
    Public Property AddressFormulaSend() As Integer
        Get
            Return Me.m_intAddressFormulaSend
        End Get
        Set(ByVal value As Integer)
            Me.m_intAddressFormulaSend = value
        End Set
    End Property
    Public Property AddressFormulaRequest() As Integer
        Get
            Return Me.m_intAddressFormulaRequest
        End Get
        Set(ByVal value As Integer)
            Me.m_intAddressFormulaRequest = value
        End Set
    End Property
#End Region

#Region "Constructor"
    Protected Sub New()
        Reset()
    End Sub

    Public Overridable Sub Reset()
        m_intLineNo = -1
        m_strLineCode = String.Empty
        m_intNet = -1
        m_intNode = -1
        m_intUnit = -1
        m_intAddressLifeCheck = -1
        m_intAddressFormulaSend = -1
        m_intAddressFormulaRequest = -1
    End Sub
#End Region

#Region "method"
    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : Find
    '   Purpose         : Find LineCode by LineNo
    '   Created         : Pentita 14/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------

    Public Shared Function FindLineCode(ByVal intLineNo As Integer) As String
        Dim dt As DataTable
        Dim strLineName As String = String.Empty
        Dim sSqlCmd As String = _
            " SELECT * " & _
            " FROM [LINE_MASTER] lm " & _
            " WHERE lm.[LINE_NO] = " & intLineNo
        Try
            dt = clsAdoxCached.GetDataTable(sSqlCmd)
            If Not dt Is Nothing AndAlso dt.Rows.Count > 0 Then
                strLineName = dt.Rows(0).Item("LINE_CODE")
                If strLineName = Nothing Then
                    strLineName = String.Empty
                End If
            End If
            FindLineCode = strLineName
        Catch ex As Exception
            MessageBox.Show("clsLineInfo.FindLineCode : " & ex.ToString())
            FindLineCode = Nothing
        End Try
    End Function
    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : FindAll
    '   Purpose         : FindAll data in line master
    '   Created         : Pentita 14/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------

    Public Shared Function FindAll() As DataTable
        Dim dt As DataTable
        Dim sSqlCmd As String = _
            " SELECT * " & _
            " FROM [LINE_MASTER] lm "
        Try
            dt = clsAdoxCached.GetDataTable(sSqlCmd)
            If Not dt Is Nothing AndAlso dt.Rows.Count > 0 Then
                FindAll = dt
            Else
                FindAll = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show("clsLineInfo.FindAll : " & ex.ToString())
            FindAll = Nothing
        End Try
    End Function
    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : Count
    '   Purpose         : Count Object clsLineInfo
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------
    Public Shared Function Count() As Integer
        Dim dt As DataTable
        Dim intCount As Integer = 0
        Dim sSqlCmd As String = _
            " SELECT COUNT(LINE_NO) " & _
            " FROM [LINE_MASTER]"
        dt = clsAdoxCached.GetDataTable(sSqlCmd)
        Try
            If Not dt Is Nothing AndAlso dt.Rows.Count = 0 Then
                Count = 0
            Else
                Count = dt.Rows(0).Item(0)
            End If
        Catch ex As Exception
            MessageBox.Show("clsLineInfo.Count : " & ex.ToString())
            Count = Nothing
        End Try
    End Function
    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : Create
    '   Purpose         : Create Object clsFormulaInfo
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------
    Public Shared Function Create(ByVal strLineCode As String _
                                  , ByVal intNet As Integer _
                                  , ByVal intNode As Integer _
                                  , ByVal intUnit As Integer _
                                  , ByVal intLifeCheck As Integer _
                                  , ByVal intFormulaSend As Integer _
                                  , ByVal intFormulaRequest As Integer _
                                  )
        Dim sSqlCmd As String = _
            " INSERT INTO [LINE_MASTER]" & _
            "([LINE_CODE])" & _
            "([NET])" & _
            "([NODE])" & _
            "([UNIT])" & _
            "([ADDRESS_LIFE_CHECK])" & _
            "([ADDRESS_FORMULA_SEND])" & _
            "([ADDRESS_FORMULA_REQUEST])" & _
            " VALUES ( " & _
            " '" & strLineCode & "'" & _
            " ," & intNet & _
            " ," & intNode & _
            " ," & intUnit & _
            " ," & intLifeCheck & _
            " ," & intFormulaSend & _
            " ," & intFormulaRequest & _
            ")"
        Try
            clsAdoxCached.Execute(sSqlCmd)
        Catch ex As Exception
            MessageBox.Show("clsLineInfo.Create : " & ex.ToString())
        End Try
        Return Nothing
    End Function


    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : Delete
    '   Purpose         : Delete Object clsLineInfo
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------
    Public Shared Function Delete(ByVal intLineNo As Integer)
        Dim sSqlCmd As String = _
            " DELETE FROM [LINE_MASTER]" & _
            " WHERE [LINE_NO] = " & intLineNo
        Try
            clsAdoxCached.Execute(sSqlCmd)
        Catch ex As Exception
            MessageBox.Show("clsLineInfo.Delete : " & ex.ToString())
        End Try
        Return Nothing
    End Function
    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : Update
    '   Purpose         : Update Object clsFormulaInfo
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------
    Public Shared Function Update(ByVal intLineNo As Integer _
                                  , ByVal strLineCode As String _
                                  , ByVal intNet As Integer _
                                  , ByVal intNode As Integer _
                                  , ByVal intUnit As Integer _
                                  , ByVal intLifeCheck As Integer _
                                  , ByVal intFormulaSend As Integer _
                                  , ByVal intFormulaRequest As Integer _
                                  )
        Dim sSqlCmd As String = _
            " UPDATE [LINE_MASTER]" & _
            " SET " & _
            " [LINE_CODE]  = '" & strLineCode & "'" & _
            ",[NET]  = " & intNet & _
            ",[NODE]  = " & intNode & _
            ",[UNIT]  = " & intUnit & _
            ",[ADDRESS_LIFE_CHECK]  = " & intLifeCheck & _
            ",[ADDRESS_FORMULA_SEND]  = " & intFormulaSend & _
            ",[ADDRESS_FORMULA_REQUEST]  = " & intFormulaRequest & _
            " WHERE [LINE_NO] = " & intLineNo
        Try
            clsAdoxCached.Execute(sSqlCmd)
        Catch ex As Exception
            MessageBox.Show("clsLineInfo.Update : " & ex.ToString())
        End Try
        Return Nothing
    End Function
#End Region
End Class