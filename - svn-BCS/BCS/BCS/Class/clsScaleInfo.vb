Public Class clsScaleInfo
#Region "Attributes"
    Private m_intScaleId As Integer
    Private m_strScaleName As String
#End Region
#Region "Property"

    Public Property ScaleId() As Integer
        Get
            Return Me.m_intScaleId
        End Get
        Set(ByVal value As Integer)
            Me.m_intScaleId = value
        End Set
    End Property
    Public Property ScaleName() As String
        Get
            Return Me.m_strScaleName
        End Get
        Set(ByVal value As String)
            Me.m_strScaleName = value
        End Set
    End Property
#End Region

#Region "Constructor"
    Protected Sub New()
        Reset()
    End Sub

    Public Overridable Sub Reset()
        m_intScaleId = -1
        m_strScaleName = String.Empty
    End Sub
#End Region

#Region "method"
    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : Find
    '   Purpose         : Find Scale Name by Scale Id
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------

    Public Shared Function FindScaleName(ByVal intScaleId As Integer) As String
        Dim dt As DataTable
        Dim strScaleName As String = String.Empty
        Dim sSqlCmd As String = _
            " SELECT * " & _
            " FROM [SCALE_MASTER] bm " & _
            " WHERE bm.[SCALE_ID] = " & intScaleId
        Try
            dt = clsAdoxCached.GetDataTable(sSqlCmd)
            If Not dt Is Nothing AndAlso dt.Rows.Count > 0 Then
                strScaleName = dt.Rows(0).Item("SCALE_NAME")
                If strScaleName = Nothing Then
                    strScaleName = String.Empty
                End If
            End If
            FindScaleName = strScaleName
        Catch ex As Exception
            MessageBox.Show("clsScaleInfo.Update : " & ex.ToString())
            FindScaleName = String.Empty
        End Try
    End Function
    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : Count
    '   Purpose         : Count Object clsScaleInfo
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------
    Public Shared Function Count() As Integer
        Dim dt As DataTable
        Dim intCount As Integer = 0
        Dim sSqlCmd As String = _
            " SELECT COUNT(SCALE_ID) " & _
            " FROM [SCALE_MASTER]"
        Try
            dt = clsAdoxCached.GetDataTable(sSqlCmd)
            If Not dt Is Nothing AndAlso dt.Rows.Count = 0 Then
                Count = 0
            Else
                Count = dt.Rows(0).Item(0)
            End If
        Catch ex As Exception
            MessageBox.Show("clsScaleInfo.Count : " & ex.ToString())
            Count = -1
        End Try
    End Function

    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : Create
    '   Purpose         : Create Object clsScaleInfo
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------
    Public Shared Sub Create(ByVal strScaleName As String)
        Dim sSqlCmd As String = _
            " INSERT INTO [SCALE_MASTER]" & _
            "([SCALE_NAME] " & _
            " ) VALUES ( " & _
            "'" & strScaleName & "'" & _
            ")"
        Try
            clsAdoxCached.Execute(sSqlCmd)
        Catch ex As Exception
            MessageBox.Show("clsScaleInfo.Create : " & ex.ToString())
        End Try
    End Sub

    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : Delete
    '   Purpose         : Delete Object clsScaleInfo
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------
    Public Shared Sub Delete(ByVal intScaleId As Integer)
        Dim sSqlCmd As String = _
            " DELETE FROM [SCALE_MASTER]" & _
            " WHERE " & _
            " SCALE_ID = " & intScaleId
        Try
            clsAdoxCached.Execute(sSqlCmd)
        Catch ex As Exception
            MessageBox.Show("clsScaleInfo.Delete : " & ex.ToString())
        End Try
    End Sub
    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : Update
    '   Purpose         : Update Object clsScaleInfo
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------
    Public Shared Sub Update(ByVal intScaleId As Integer, _
                                  ByVal strScaleName As String)
        Dim sSqlCmd As String = _
            " UPDATE [SCALE_MASTER]" & _
            " SET " & _
            " [SCALE_NAME]  = '" & strScaleName & "'" & _
            " WHERE [SCALE_ID] = " & intScaleId
        Try
            clsAdoxCached.Execute(sSqlCmd)
        Catch ex As Exception
            MessageBox.Show("clsScaleInfo.Update : " & ex.ToString())
        End Try
    End Sub
#End Region
End Class
