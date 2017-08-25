Public Class clsRoleInfo

#Region "Attributes"
    Private m_strRoleId As String
    Private m_strRoleDescr As String
#End Region
#Region "Property"

    Public Property RoleId() As String
        Get
            Return Me.m_strRoleId
        End Get
        Set(ByVal value As String)
            Me.m_strRoleId = value
        End Set
    End Property
    Public Property RoleDescr() As String
        Get
            Return Me.m_strRoleDescr
        End Get
        Set(ByVal value As String)
            Me.m_strRoleDescr = value
        End Set
    End Property
#End Region

#Region "Constructor"
    Protected Sub New()
        Reset()
    End Sub

    Public Overridable Sub Reset()
        m_strRoleId = String.Empty
        m_strRoleDescr = String.Empty
    End Sub
#End Region

#Region "method"
    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : Find
    '   Purpose         : Find Role Descr by Role Id
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------

    Public Shared Function FindRoleDescr(ByVal strRoleId As String) As String
        Dim dt As DataTable
        Dim strRoleDescr As String = 0
        Dim sSqlCmd As String = _
            " SELECT * " & _
            " FROM [ROLES] ur " & _
            " WHERE ur.[ROLE_ID] = " & strRoleDescr
        Try
            dt = clsAdoxCached.GetDataTable(sSqlCmd)
            If Not dt Is Nothing AndAlso dt.Rows.Count > 0 Then
                strRoleDescr = dt.Rows(0).Item("ROLE_DESCR")
                If strRoleDescr = Nothing Then
                    strRoleDescr = String.Empty
                End If
            End If
            FindRoleDescr = strRoleDescr
        Catch ex As Exception
            MessageBox.Show("clsRoleInfo.FindRoleDescr : " & ex.ToString())
            FindRoleDescr = String.Empty
        End Try
    End Function
    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : Count
    '   Purpose         : Count Object clsRolesInfo
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------
    Public Shared Function Count() As String
        Dim dt As DataTable
        Dim intCount As String = 0
        Dim sSqlCmd As String = _
            " SELECT COUNT(ROLE_ID) " & _
            " FROM [ROLES]"
        Try
            dt = clsAdoxCached.GetDataTable(sSqlCmd)
            If Not dt Is Nothing AndAlso dt.Rows.Count = 0 Then
                Count = 0
            Else
                Count = dt.Rows(0).Item(0)
            End If
        Catch ex As Exception
            MessageBox.Show("clsRoleInfo.Count : " & ex.ToString())
            Count = -1
        End Try
    End Function

    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : Create
    '   Purpose         : Create Object clsRolesInfo
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------
    Public Shared Sub Create(ByVal strRoleId As String, _
                                  ByVal strRoleDescr As String)
        Dim sSqlCmd As String = _
            " INSERT INTO [ROLES]" & _
            "([ROLE_ID] " & _
            ",[ROLE_DESCR] " & _
            ") VALUES ( " & _
            " " & strRoleId & _
            "," & strRoleDescr & _
            ")"
        Try
            clsAdoxCached.Execute(sSqlCmd)
        Catch ex As Exception
            MessageBox.Show("clsRoleInfo.Create : " & ex.ToString())
        End Try
    End Sub

    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : Delete
    '   Purpose         : Delete Object clsRoleInfo
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------
    Public Shared Sub Delete(ByVal intRoleId As Integer)
        Dim sSqlCmd As String = _
            " DELETE FROM [ROLES]" & _
            " WHERE " & _
            " ROLE_ID = " & intRoleId
        Try
            clsAdoxCached.Execute(sSqlCmd)
        Catch ex As Exception
            MessageBox.Show("clsRoleInfo.Delete : " & ex.ToString())
        End Try
    End Sub
    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : Update
    '   Purpose         : Update Object clsUserRolesInfo
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------
    Public Shared Sub Update(ByVal strRoleId As String, _
                                  ByVal strRoleDescr As String)
        Dim sSqlCmd As String = _
            " UPDATE [ROLES]" & _
            " SET " & _
            ",[ROLE_DESCR]  = " & strRoleDescr & _
            " WHERE [ROLE_ID] = " & strRoleId
        Try
            clsAdoxCached.Execute(sSqlCmd)
        Catch ex As Exception
            MessageBox.Show("clsRoleInfo.Update : " & ex.ToString())
        End Try
    End Sub
#End Region
End Class
