Public Class clsRevisionInfo

#Region "Public"
    Public Shared m_objLogger As clsLogger = New clsLogger
#End Region
#Region "Attributes"
    Private m_intRevisionId As Integer
    Private m_intFormulaId As Integer
    Private m_intRevisionNo As Integer
    Private m_bActiveFlag As Boolean
#End Region
#Region "Property"

    Public Property RevisionId() As Integer
        Get
            Return Me.m_intRevisionId
        End Get
        Set(ByVal value As Integer)
            Me.m_intRevisionId = value
        End Set
    End Property
    Public Property FormulaId() As Integer
        Get
            Return Me.m_intFormulaId
        End Get
        Set(ByVal value As Integer)
            Me.m_intFormulaId = value
        End Set
    End Property
    Public Property RevisionNo() As Integer
        Get
            Return Me.m_intRevisionNo
        End Get
        Set(ByVal value As Integer)
            Me.m_intRevisionNo = value
        End Set
    End Property
    Public Property ActiveFlag() As Boolean
        Get
            Return Me.m_bActiveFlag
        End Get
        Set(ByVal value As Boolean)
            Me.m_bActiveFlag = value
        End Set
    End Property
#End Region

#Region "Constructor"
    Protected Sub New()
        Reset()
    End Sub

    Public Overridable Sub Reset()
        m_intRevisionId = -1
        m_intFormulaId = -1
        m_intRevisionNo = -1
        m_bActiveFlag = False
    End Sub
#End Region

#Region "method"
    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : Find
    '   Purpose         : Find object clsRevisionInfo by Revision Id
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------

    Public Shared Function Find(ByVal intRevisionId As Integer) As clsRevisionInfo
        Dim dt As DataTable
        Dim sSqlCmd As String = _
            " SELECT * " & _
            " FROM [REVISION] bm " & _
            " WHERE bm.[REVISION_ID] = " & intRevisionId
        Try
            dt = clsAdoxCached.GetDataTable(sSqlCmd)
            Find = New clsRevisionInfo()
            If Not dt Is Nothing AndAlso dt.Rows.Count > 0 Then
                With dt.Rows(0)
                    Find.RevisionId = .Item("REVISION_ID")
                    Find.FormulaId = .Item("FORMULA_ID")
                    Find.RevisionNo = .Item("REVISION_NO")
                    Find.ActiveFlag = .Item("ACTIVE_FLAG")
                End With
            End If
        Catch ex As Exception
            MessageBox.Show("clsRevisionInfo.Find : " & ex.ToString())
            Find = Nothing
        End Try
    End Function
    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : FindAll
    '   Purpose         : FindAll Object clsBinInfo
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------

    Public Shared Function FindAll() As DataTable
        Dim sSqlCmd As String = _
            " SELECT * " & _
            " FROM [REVISION]"
        Try
            FindAll = clsAdoxCached.GetDataTable(sSqlCmd)
        Catch ex As Exception
            MessageBox.Show("clsRevisionInfo.FindAll : " & ex.ToString())
            FindAll = Nothing
        End Try
    End Function
    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : FindLastestID
    '   Purpose         : FindLastestID
    '   Created         : Pentita 18/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------

    Public Shared Function FindLastestID() As Integer
        Dim dt As DataTable
        Dim sSqlCmd As String = _
            " SELECT MAX(REVISION_ID) " & _
            " FROM [REVISION]"
        Try
            dt = clsAdoxCached.GetDataTable(sSqlCmd)
            If Not dt Is Nothing AndAlso dt.Rows.Count > 0 Then
                FindLastestID = dt.Rows(0).Item(0)
            Else
                FindLastestID = -1
            End If
        Catch ex As Exception
            MessageBox.Show("clsRevisionInfo.FindLastestID : " & ex.ToString())
            FindLastestID = Nothing
        End Try
    End Function
    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : FindLastestID
    '   Purpose         : FindLastestID
    '   Created         : Pentita 18/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------

    Public Shared Function FindLastestIDByFormulaId(ByVal intFormulaId As Integer) As Integer
        Dim dt As DataTable
        Dim sSqlCmd As String = _
            " SELECT MAX(REVISION_ID) " & _
            " FROM [REVISION] " & _
            " WHERE [FORMULA_ID] = " & intFormulaId
        Try
            dt = clsAdoxCached.GetDataTable(sSqlCmd)
            If Not dt Is Nothing AndAlso dt.Rows.Count > 0 Then
                FindLastestIDByFormulaId = dt.Rows(0).Item(0)
            Else
                FindLastestIDByFormulaId = 1
            End If
        Catch ex As Exception
            MessageBox.Show("clsRevisionInfo.FindLastestID : " & ex.ToString())
            FindLastestIDByFormulaId = 1
        End Try
    End Function
    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : SetNextRevision
    '   Purpose         : SetNextRevision
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------
    Public Shared Sub SetNextRevision(ByVal intFormulaCode As Integer, ByVal intLineNo As Integer)
        'Dim sSqlCmd As String = _
        '    " UPDATE [REVISION] " & _
        '    " SET ACTIVE_FLAG = 0 WHERE REVISION_ID = " & _
        '    " (SELECT REVISION_ID " & _
        '    " FROM [REVISION] " & _
        '    " WHERE [ACTIVE_FLAG] = 1 " & _
        '    " AND [FORMULA_ID] = " & _
        '    " (SELECT FORMULA_ID FROM FORMULA_MASTER WHERE LINE_NO = " & intLineNo & _
        '    " AND FORMULA_CODE = " & intFormulaCode & "))"
        'Dim sSqlCmd2 As String = _
        '    " UPDATE [REVISION] " & _
        '    " SET ACTIVE_FLAG = 1 WHERE REVISION_ID = " & _
        '    " (SELECT MAX(REVISION_ID) " & _
        '    " FROM [REVISION] " & _
        '    " WHERE [FORMULA_ID] = " & _
        '    " (SELECT FORMULA_ID FROM FORMULA_MASTER WHERE LINE_NO = " & intLineNo & _
        '    " AND FORMULA_CODE = " & intFormulaCode & "))"

        Dim sSqlCmd As String = _
            " UPDATE [REVISION] " & _
            " SET ACTIVE_FLAG = 0 " & _
            " WHERE REVISION_ID < " & _
            " ( " & _
            "   SELECT MAX(REVISION_ID) " & _
            "   FROM [REVISION] " & _
            "   WHERE [FORMULA_ID] = " & _
            "       ( " & _
            "           SELECT FORMULA_ID FROM FORMULA_MASTER WHERE LINE_NO = " & intLineNo & _
            "           AND FORMULA_CODE = " & intFormulaCode & _
            "       )" & _
            " ) " & _
            " AND [FORMULA_ID] = " & _
            " ( " & _
            "   SELECT FORMULA_ID FROM FORMULA_MASTER WHERE LINE_NO = " & intLineNo & _
            "   AND FORMULA_CODE = " & intFormulaCode & _
            " )"
        Dim sSqlCmd2 As String = _
            " UPDATE [REVISION] " & _
            " SET ACTIVE_FLAG = 1 WHERE REVISION_ID = " & _
            " (SELECT MAX(REVISION_ID) " & _
            " FROM [REVISION] " & _
            " WHERE [FORMULA_ID] = " & _
            " (SELECT FORMULA_ID FROM FORMULA_MASTER WHERE LINE_NO = " & intLineNo & _
            " AND FORMULA_CODE = " & intFormulaCode & "))"

        Try
            clsAdoxCached.Execute(sSqlCmd & sSqlCmd2)
        Catch ex As Exception
            'MessageBox.Show("clsRevisionInfo.SetNextRevision : " & ex.ToString())
            m_objLogger.AppendLog(ex)
        End Try
    End Sub
    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : Count
    '   Purpose         : Count Object clsBinInfo
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------
    Public Shared Function Count() As Integer
        Dim dt As DataTable
        Dim intCount As Integer = 0
        Dim sSqlCmd As String = _
            " SELECT COUNT(REVISION_ID) " & _
            " FROM [REVISION]"
        Try
            dt = clsAdoxCached.GetDataTable(sSqlCmd)
            If Not dt Is Nothing AndAlso dt.Rows.Count = 0 Then
                Count = 0
            Else
                Count = dt.Rows(0).Item(0)
            End If
        Catch ex As Exception
            MessageBox.Show("clsRevisionInfo.Count : " & ex.ToString())
            Count = -1
        End Try
    End Function

    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : AddRevisionNOToCombo
    '   Purpose         : Add RMCode to Combobox
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------

    Public Shared Sub AddRevisionNOToCombo(ByVal cmb As System.Windows.Forms.ComboBox)
        Dim dtRevisionInfo As DataTable
        Dim intRevisionCount As Integer
        Dim i As Integer = 0
        Try
            dtRevisionInfo = clsRevisionInfo.FindAll()
            If Not dtRevisionInfo Is Nothing Then
                intRevisionCount = dtRevisionInfo.Rows.Count
                For i = 0 To intRevisionCount - 1
                    cmb.Items.Add(dtRevisionInfo.Rows(i).Item("REVISION_NO"))
                Next
            End If
        Catch ex As Exception
            MessageBox.Show("clsRevisionInfo.AddRevisionNOToCombo : " & ex.ToString())
        End Try
    End Sub

    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : Create
    '   Purpose         : Create Object clsRevisionInfo
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------
    Public Shared Function Create(ByVal intFormulaId As Integer _
                                  , ByVal intRevisionNo As Integer _
                                  , ByVal bActiveFlag As Boolean) As clsRevisionInfo
        Dim objRevisionInfo As clsRevisionInfo = New clsRevisionInfo()
        Dim bSuccess As Boolean = 0
        Dim sSqlCmd As String = String.Empty
        Dim intActiveFlag As Integer = -1
        Try
            If bActiveFlag Then
                intActiveFlag = 1
            Else
                intActiveFlag = 0
            End If

            sSqlCmd = _
                " INSERT INTO [REVISION]" & _
                "([REVISION_ID]" & _
                ",[FORMULA_ID] " & _
                ",[REVISION_NO] " & _
                ",[ACTIVE_FLAG] " & _
                " ) VALUES ( " & _
                " " & FindLastestID() + 1 & _
                "," & intFormulaId & _
                "," & intRevisionNo & _
                "," & intActiveFlag & _
                ")"
            bSuccess = clsAdoxCached.Execute(sSqlCmd)

            If bSuccess Then
                objRevisionInfo.RevisionId = FindLastestID()
                objRevisionInfo.FormulaId = intFormulaId
                objRevisionInfo.RevisionNo = intRevisionNo
                objRevisionInfo.ActiveFlag = bActiveFlag
            End If
            Create = objRevisionInfo
        Catch ex As Exception
            MessageBox.Show("clsRevisionInfo.Create : " & ex.ToString())
            Create = Nothing
        End Try
    End Function

    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : Delete
    '   Purpose         : Delete Object clsRevisionInfo
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------
    Public Shared Sub Delete(ByVal intRevisionId As Integer)
        Dim sSqlCmd As String = _
            " DELETE FROM [REVISION]" & _
            " WHERE " & _
            " REVISION_ID = " & intRevisionId
        Try
            clsAdoxCached.Execute(sSqlCmd)
        Catch ex As Exception
            MessageBox.Show("clsRevisionInfo.Delete : " & ex.ToString())
        End Try
    End Sub

    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : Delete
    '   Purpose         : Delete Object clsRevisionInfo
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------
    Public Shared Sub DeleteAllByFormula(ByVal intFormulaId As Integer)
        Dim sSqlCmd As String = _
            " DELETE FROM [REVISION]" & _
            " WHERE " & _
            " FORMULA_ID = " & intFormulaId
        Try
            clsAdoxCached.Execute(sSqlCmd)
        Catch ex As Exception
            MessageBox.Show("clsRevisionInfo.DeleteAllByFormula : " & ex.ToString())
        End Try
    End Sub
    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : Update
    '   Purpose         : Update Object clsBinInfo
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------
    Public Shared Sub Update(ByVal intRevisionId As Integer _
                                  , ByVal intFormulaId As Integer _
                                  , ByVal intRevisionNo As Integer _
                                  , ByVal bActiveFlag As Boolean)
        Dim sSqlCmd As String = _
            " UPDATE [REVISION]" & _
            " SET " & _
            " [FORMULA_ID]  = " & intFormulaId & _
            ",[REVISION_NO]  = " & intRevisionNo & _
            ",[ACTIVE_FLAG]  = " & bActiveFlag & _
            " WHERE [REVISION_ID] = " & intRevisionId
        Try
            clsAdoxCached.Execute(sSqlCmd)
        Catch ex As Exception
            MessageBox.Show("clsRevisionInfo.Update : " & ex.ToString())
        End Try
    End Sub
#End Region
End Class
