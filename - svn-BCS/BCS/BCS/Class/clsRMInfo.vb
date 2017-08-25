Public Class clsRMInfo
#Region "Public"
    Public Shared m_objLogger As clsLogger = New clsLogger
#End Region
#Region "Attributes"
    Private m_intRMNo As Integer
    Private m_strRMCode As String
    Private m_intScaleId As Integer
#End Region
#Region "Property"

    Public Property RMNo() As Integer
        Get
            Return Me.m_intRMNo
        End Get
        Set(ByVal value As Integer)
            Me.m_intRMNo = value
        End Set
    End Property
    Public Property RMCode() As String
        Get
            Return Me.m_strRMCode
        End Get
        Set(ByVal value As String)
            Me.m_strRMCode = value
        End Set
    End Property
    Public Property ScaleId() As Integer
        Get
            Return Me.m_intScaleId
        End Get
        Set(ByVal value As Integer)
            Me.m_intScaleId = value
        End Set
    End Property
#End Region

#Region "Constructor"
    Protected Sub New()
        Reset()
    End Sub

    Public Overridable Sub Reset()
        m_intRMNo = -1
        m_strRMCode = String.Empty
        m_intScaleId = -1
    End Sub
#End Region

#Region "method"
    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : Find
    '   Purpose         : Find Object clsRMInfo by RM Id
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------

    Public Shared Function Find(ByVal intRMNo As Integer) As clsRMInfo
        Dim dt As DataTable
        Dim sSqlCmd As String = _
            " SELECT * " & _
            " FROM [RM_MASTER] rm " & _
            " WHERE rm.[RM_NO] = " & intRMNo
        Try
            dt = clsAdoxCached.GetDataTable(sSqlCmd)
            Find = New clsRMInfo()
            If Not dt Is Nothing AndAlso dt.Rows.Count > 0 Then
                With dt.Rows(0)
                    Find.RMNo = .Item("RM_NO")
                    Find.RMCode = .Item("RM_CODE")
                    Find.ScaleId = .Item("SCALE_ID")
                End With
            End If
        Catch ex As Exception
            MessageBox.Show("clsRMInfo.Find : " & ex.ToString())
            Find = Nothing
        End Try
    End Function
    Public Shared Function FindByScale(ByVal intScaleId As Integer) As DataTable
        Dim dt As DataTable
        Dim sSqlCmd As String = _
            " SELECT * " & _
            " FROM [RM_MASTER] rm " & _
            " WHERE rm.[SCALE_ID] = " & intScaleId
        Try
            dt = clsAdoxCached.GetDataTable(sSqlCmd)
            If Not dt Is Nothing AndAlso dt.Rows.Count > 0 Then
                FindByScale = dt
            Else
                FindByScale = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show("clsRMInfo.FindWeight : " & ex.ToString())
            FindByScale = Nothing
        End Try
    End Function
    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : FindAll
    '   Purpose         : FindAll Object clsRMInfo
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------

    Public Shared Function FindAll() As DataTable
        Dim sSqlCmd As String = _
            " SELECT * " & _
            " FROM [RM_MASTER]"
        Try
            FindAll = clsAdoxCached.GetDataTable(sSqlCmd)
        Catch ex As Exception
            MessageBox.Show("clsRMInfo.FindAll : " & ex.ToString())
            FindAll = Nothing
        End Try
    End Function
    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : Count
    '   Purpose         : Count Object clsRMInfo
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------
    Public Shared Function Count(Optional ByVal intScaleId As Integer = 0) As Integer
        Dim dt As DataTable
        Dim intCount As Integer = 0
        Dim sSqlCmd As String = _
            " SELECT COUNT(RM_NO) " & _
            " FROM [RM_MASTER] "
        Dim sSqlScaleCmd As String = ""
        Try
            If intScaleId > 0 Then
                sSqlScaleCmd = " WHERE SCALE_ID = " & intScaleId
            End If
            dt = clsAdoxCached.GetDataTable(sSqlCmd & sSqlScaleCmd)
            If Not dt Is Nothing AndAlso dt.Rows.Count = 0 Then
                Count = 0
            Else
                Count = dt.Rows(0).Item(0)
            End If
        Catch ex As Exception
            'MessageBox.Show("clsRMInfo.Count : " & ex.ToString())
            m_objLogger.AppendLog(ex)
            Count = -1
        End Try
    End Function

    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : AddRMCodeToCombo
    '   Purpose         : Add RMCode to Combobox
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------

    Public Shared Sub AddRMCodeToCombo(ByVal cmb As System.Windows.Forms.ComboBox)
        Dim intRMCount As Integer
        Dim dtRMInfo As DataTable
        Dim i As Integer = 0
        Try
            dtRMInfo = clsRMInfo.FindAll()
            If Not dtRMInfo Is Nothing Then
                intRMCount = dtRMInfo.Rows.Count
                For i = 0 To intRMCount - 1
                    cmb.Items.Add(dtRMInfo.Rows(i).Item("RM_CODE"))
                Next
            End If
        Catch ex As Exception
            MessageBox.Show("clsRMInfo.AddRMCodeToCombo : " & ex.ToString())
        End Try
    End Sub
    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : Create
    '   Purpose         : Create Object clsRMInfo
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------
    Public Shared Sub Create(ByVal strRMCode As String, _
                                  ByVal intScaleId As Integer)
        Dim sSqlCmd As String = _
            " INSERT INTO [RM_MASTER]" & _
            "([RM_CODE] " & _
            ",[SCALE_ID] " & _
            ") VALUES ( " & _
            "'" & strRMCode & "'" & _
            "," & intScaleId & _
            ")"
        Try
            clsAdoxCached.Execute(sSqlCmd)
        Catch ex As Exception
            MessageBox.Show("clsRMInfo.Create : " & ex.ToString())
        End Try
    End Sub

    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : Delete
    '   Purpose         : Delete Object clsRMInfo
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------
    Public Shared Sub Delete(ByVal intRMNo As Integer)
        Dim sSqlCmd As String = _
            " DELETE FROM [RM_MASTER]" & _
            " WHERE " & _
            " RM_NO = " & intRMNo
        Try
            clsAdoxCached.Execute(sSqlCmd)
        Catch ex As Exception
            MessageBox.Show("clsRMInfo.Delete : " & ex.ToString())
        End Try
    End Sub
    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : Update
    '   Purpose         : Update Object clsRMInfo
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------
    Public Shared Sub Update(ByVal intRMNo As Integer, _
                                  ByVal strRMCode As String, _
                                  ByVal intScaleId As Integer)
        Dim sSqlCmd As String = _
            " UPDATE [RM_MASTER]" & _
            " SET " & _
            " [RM_CODE]  = '" & strRMCode & "'" & _
            ",[SCALE_ID]  = '" & intScaleId & _
            " WHERE [RM_NO] = " & intRMNo
        Try
            clsAdoxCached.Execute(sSqlCmd)
        Catch ex As Exception
            MessageBox.Show("clsRMInfo.Update : " & ex.ToString())
        End Try
    End Sub
#End Region
End Class
