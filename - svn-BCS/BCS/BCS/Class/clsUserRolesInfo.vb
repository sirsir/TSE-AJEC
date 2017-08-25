Public Class clsUserRolesInfo

#Region "Attributes"
    Private m_strUserId As String
    Private m_strRoleId As String
#End Region
#Region "Property"

    Public Property UserId() As String
        Get
            Return Me.m_strUserId
        End Get
        Set(ByVal value As String)
            Me.m_strUserId = value
        End Set
    End Property
    Public Property RoleId() As String
        Get
            Return Me.m_strRoleId
        End Get
        Set(ByVal value As String)
            Me.m_strRoleId = value
        End Set
    End Property
#End Region

#Region "Constructor"
    Protected Sub New()
        Reset()
    End Sub

    Public Overridable Sub Reset()
        m_strUserId = String.Empty
        m_strRoleId = String.Empty
    End Sub
#End Region

#Region "method"
    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : Find
    '   Purpose         : Find Role Id by User Id
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------

    Public Shared Function FindRoleId(ByVal strUserId As String) As String
        Dim dt As DataTable
        Dim strRoleId As String = String.Empty
        Dim sSqlCmd As String = _
            " SELECT * " & _
            " FROM [USER_ROLES] ur " & _
            " WHERE ur.[USER_ID] = '" & strUserId & "'"
        Try
            dt = clsAdoxCached.GetDataTable(sSqlCmd)
            If Not dt Is Nothing AndAlso dt.Rows.Count > 0 Then
                strRoleId = dt.Rows(0).Item("ROLE_ID")
                If strRoleId = Nothing Then
                    strRoleId = String.Empty
                End If
            End If
            FindRoleId = strRoleId
        Catch ex As Exception
            MessageBox.Show("clsUserRolesInfo.FindRoleId : " & ex.ToString())
            FindRoleId = Nothing
        End Try
    End Function
    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : Count
    '   Purpose         : Count Object clsUserRolesInfo
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------
    Public Shared Function Count() As String
        Dim dt As DataTable
        Dim sSqlCmd As String = _
            " SELECT COUNT(USER_ID) " & _
            " FROM [USER_ROLES]"
        Try
            dt = clsAdoxCached.GetDataTable(sSqlCmd)
            If Not dt Is Nothing AndAlso dt.Rows.Count = 0 Then
                Count = 0
            Else
                Count = dt.Rows(0).Item(0)
            End If
        Catch ex As Exception
            MessageBox.Show("clsUserRolesInfo.Count : " & ex.ToString())
            Count = -1
        End Try
    End Function

    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : Create
    '   Purpose         : Create Object clsUserRolesInfo
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------
    Public Shared Function Create(ByVal strUserId As String, _
                                  ByVal strRoleId As String)
        Dim sSqlCmd As String = _
            " INSERT INTO [USER_ROLES]" & _
            "([USER_ID] " & _
            ",[ROLE_ID] " & _
            ") VALUES ( " & _
            " '" & strUserId & "' " & _
            " '" & strRoleId & "' " & _
            ")"
        Try
            clsAdoxCached.Execute(sSqlCmd)
        Catch ex As Exception
            MessageBox.Show("clsUserRolesInfo.Create : " & ex.ToString())
        End Try
        Return Nothing
    End Function

    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : Delete
    '   Purpose         : Delete Object clsUserRoleInfo
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------
    Public Shared Function Delete(ByVal strUserId As String)
        Dim sSqlCmd As String = _
            " DELETE FROM [USER_ROLES]" & _
            " WHERE " & _
            " USER_ID = '" & strUserId & "'"
        Try
            clsAdoxCached.Execute(sSqlCmd)
        Catch ex As Exception
            MessageBox.Show("clsUserRolesInfo.Delete : " & ex.ToString())
        End Try
        Return Nothing
    End Function
    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : Update
    '   Purpose         : Update Object clsUserRolesInfo
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------
    Public Shared Function Update(ByVal strUserId As String, _
                                  ByVal strRoleId As String)
        Dim sSqlCmd As String = _
            " UPDATE [USER_ROLES]" & _
            " SET " & _
            ",[ROLE_ID]  = '" & strRoleId & "'" & _
            " WHERE [USER_ID] = '" & strUserId & "'"
        Try
            clsAdoxCached.Execute(sSqlCmd)
        Catch ex As Exception
            MessageBox.Show("clsUserRolesInfo.Update : " & ex.ToString())
        End Try
        Return Nothing
    End Function
#End Region
End Class
