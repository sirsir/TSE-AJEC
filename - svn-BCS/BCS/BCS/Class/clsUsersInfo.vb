Public Class clsUsersInfo

#Region "Attributes"
    Private m_strUserId As String
    Private m_strUserDescr As String
    Private m_strPassword As String
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
    Public Property UserDescr() As String
        Get
            Return Me.m_strUserDescr
        End Get
        Set(ByVal value As String)
            Me.m_strUserDescr = value
        End Set
    End Property
    Public Property Password() As String
        Get
            Return Me.m_strPassword
        End Get
        Set(ByVal value As String)
            Me.m_strPassword = value
        End Set
    End Property
#End Region

#Region "Constructor"
    Protected Sub New()
        Reset()
    End Sub

    Public Overridable Sub Reset()
        m_strUserId = String.Empty
        m_strUserDescr = String.Empty
        m_strPassword = String.Empty
    End Sub
#End Region

#Region "method"
    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : Find
    '   Purpose         : Find Object clsUsersInfo by User Id
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------

    Public Shared Function Find(ByVal strUserId As String) As clsUsersInfo
        Dim dt As DataTable
        Dim sSqlCmd As String = _
            " SELECT * " & _
            " FROM [USERS] u " & _
            " WHERE u.[USER_ID] = '" & strUserId & "'"
        Try
            dt = clsAdoxCached.GetDataTable(sSqlCmd)
            Find = New clsUsersInfo()
            If dt.Rows.Count <> 0 Then
                With dt.Rows(0)
                    Find.UserId = .Item("USER_ID")
                    Find.UserDescr = .Item("USER_DESCR")
                    Find.Password = .Item("PASSWORD")
                End With
            End If
        Catch ex As Exception
            MessageBox.Show("clsUsersInfo.Find : " & ex.ToString())
            Find = Nothing
        End Try
    End Function

    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : CheckPasswordByUserDescr
    '   Purpose         : Check Password by user description
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------

    Public Shared Function CheckPassword(ByVal strUserId As String, ByVal strPassword As String) As Boolean
        Dim dt As DataTable
        Dim sSqlCmd As String = _
            " SELECT * " & _
            " FROM [USERS] u " & _
            " WHERE u.[USER_ID] = '" & strUserId & "'" & _
            " AND u.[PASSWORD] = '" & strPassword & "'"
        Try
            dt = clsAdoxCached.GetDataTable(sSqlCmd)
            If dt.Rows.Count < 1 Then
                CheckPassword = False
            Else
                CheckPassword = True
            End If
        Catch ex As Exception
            MessageBox.Show("clsUsersInfo.CheckPassword : " & ex.ToString())
            CheckPassword = False
        End Try
    End Function

    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : CheckAvailableUserDescr
    '   Purpose         : Check available user description
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------

    Public Shared Function CheckAvailableUser(ByVal strUserId As String) As Boolean
        Dim dt As DataTable
        Dim sSqlCmd As String = _
            " SELECT * " & _
            " FROM [USERS] u " & _
            " WHERE u.[USER_ID] = '" & strUserId & "'"
        Try
            dt = clsAdoxCached.GetDataTable(sSqlCmd)
            If dt.Rows.Count < 1 Then
                CheckAvailableUser = False
            Else
                CheckAvailableUser = True
            End If
        Catch ex As Exception
            MessageBox.Show("clsUsersInfo.CheckAvailableUser : " & ex.ToString())
            CheckAvailableUser = False
        End Try
    End Function
    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : FindAll
    '   Purpose         : FindAll Object clsUsersInfo
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------

    Public Shared Function FindAll() As DataTable
        Dim sSqlCmd As String = _
            " SELECT * " & _
            " FROM [USERS]"
        FindAll = clsAdoxCached.GetDataTable(sSqlCmd)
    End Function
    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : Count
    '   Purpose         : Count Object clsUsersInfo
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------
    Public Shared Function Count() As String
        Dim dt As DataTable
        Dim sSqlCmd As String = _
            " SELECT COUNT(USER_ID) " & _
            " FROM [USERS]"
        Try
            dt = clsAdoxCached.GetDataTable(sSqlCmd)
            If dt.Rows.Count = 0 Then
                Count = 0
            Else
                Count = dt.Rows(0).Item(0)
            End If
        Catch ex As Exception
            MessageBox.Show("clsUsersInfo.Count : " & ex.ToString())
            Count = -1
        End Try
    End Function

    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : AddUserToCombo
    '   Purpose         : Add User to Combobox
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------

    Public Shared Function AddUserToCombo(ByVal cmb As System.Windows.Forms.ComboBox)
        Dim intUserCount As Integer
        Dim dtUserInfo As DataTable
        Dim i As Integer = 0
        Try
            dtUserInfo = clsUsersInfo.FindAll()
            If Not dtUserInfo Is Nothing Then
                intUserCount = dtUserInfo.Rows.Count
                For i = 0 To intUserCount - 1
                    cmb.Items.Add(dtUserInfo.Rows(i).Item("USER_ID"))
                Next
            End If
        Catch ex As Exception
            MessageBox.Show("clsUsersInfo.AddUserToCombo : " & ex.ToString())
        End Try
        Return Nothing
    End Function
    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : Create
    '   Purpose         : Create Object clsUsersInfo
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------
    Public Shared Function Create(ByVal strUserId As String, _
                                  ByVal strUserDescr As String, _
                                  ByVal strPassword As String)
        Dim sSqlCmd As String = _
            " INSERT INTO [USERS]" & _
            "([USER_ID] " & _
            ",[USER_DESCR] " & _
            ",[PASSWORD] " & _
            ") VALUES ( " & _
            "'" & strUserId & "'" & _
            ",'" & strUserDescr & "'" & _
            ",'" & strPassword & "'" & _
            ")"
        Try
            clsAdoxCached.Execute(sSqlCmd)
        Catch ex As Exception
            MessageBox.Show("clsUsersInfo.Create : " & ex.ToString())
        End Try
        Return Nothing
    End Function

    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : Delete
    '   Purpose         : Delete Object clsUsersInfo
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------
    Public Shared Function Delete(ByVal strUserId As String)
        Dim sSqlCmd As String = _
            " DELETE FROM [USERS]" & _
            " WHERE " & _
            " USER_ID = " & strUserId
        Try
            clsAdoxCached.Execute(sSqlCmd)
        Catch ex As Exception
            MessageBox.Show("clsUsersInfo.Delete : " & ex.ToString())
        End Try
        Return Nothing
    End Function
    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : Update
    '   Purpose         : Update Object clsUsersInfo
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------
    Public Shared Function Update(ByVal strUserId As String, _
                                  ByVal strUserDescr As String, _
                                  ByVal strPassword As String)
        Dim sSqlCmd As String = _
            " UPDATE [USERS]" & _
            " SET " & _
            ",[USER_DESCR]  = '" & strUserDescr & "'" & _
            ",[PASSWORD]  = '" & strPassword & "'" & _
            " WHERE [USER_ID] = '" & strUserId & "'"
        Try
            clsAdoxCached.Execute(sSqlCmd)
        Catch ex As Exception
            MessageBox.Show("clsUsersInfo.Update : " & ex.ToString())
        End Try
        Return Nothing
    End Function
#End Region
End Class
