Public Class clsFormulaInfo

#Region "Attributes"
    Private m_intFormulaId As Integer
    Private m_intFormulaCode As Integer
    Private m_strFormulaName As String
    Private m_intLineNo As Integer
#End Region
#Region "Property"

    Public Property FormulaId() As Integer
        Get
            Return Me.m_intFormulaId
        End Get
        Set(ByVal value As Integer)
            Me.m_intFormulaId = value
        End Set
    End Property
    Public Property FormulaCode() As Integer
        Get
            Return Me.m_intFormulaCode
        End Get
        Set(ByVal value As Integer)
            Me.m_intFormulaCode = value
        End Set
    End Property
    Public Property FormulaName() As String
        Get
            Return Me.m_strFormulaName
        End Get
        Set(ByVal value As String)
            Me.m_strFormulaName = value
        End Set
    End Property
    Public Property LineNo() As Integer
        Get
            Return Me.m_intLineNo
        End Get
        Set(ByVal value As Integer)
            Me.m_intLineNo = value
        End Set
    End Property
#End Region

#Region "Constructor"
    Protected Sub New()
        Reset()
    End Sub

    Public Overridable Sub Reset()
        m_intFormulaId = -1
        m_intFormulaCode = -1
        m_strFormulaName = String.Empty
        m_intLineNo = -1
    End Sub
#End Region

#Region "method"
    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : Find
    '   Purpose         : Find Object clsFormulaInfo by Formula Id
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------

    Public Shared Function Find(ByVal intFormulaId As Integer) As clsFormulaInfo
        Dim dt As DataTable
        Dim strLineName As String = String.Empty
        Dim sSqlCmd As String = _
            " SELECT * " & _
            " FROM [FORMULA_MASTER] fm " & _
            " WHERE fm.[FORMULA_ID] = " & intFormulaId
        Try
            dt = clsAdoxCached.GetDataTable(sSqlCmd)
            Find = New clsFormulaInfo()
            If Not dt Is Nothing AndAlso dt.Rows.Count > 0 Then
                With dt.Rows(0)
                    Find.FormulaId = .Item("FORMULA_ID")
                    Find.FormulaCode = .Item("FORMULA_CODE")
                    Find.FormulaName = .Item("FORMULA_NAME")
                    Find.LineNo = .Item("LINE_NO")
                End With
            Else
                Find = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show("clsFormulaInfo.Find : " & ex.ToString())
            Find = Nothing
        End Try
    End Function

    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : FindByLineNo
    '   Purpose         : FindByLineNo Object clsFormulaInfo by Line No
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------

    Public Shared Function FindByLineNo(ByVal intLineNo As Integer) As DataTable
        Dim dt As DataTable
        Dim strLineName As String = String.Empty
        Dim sSqlCmd As String = _
            " SELECT * " & _
            " FROM [FORMULA_MASTER] fm " & _
            " WHERE fm.[LINE_NO] = " & intLineNo

        Try
            dt = clsAdoxCached.GetDataTable(sSqlCmd)
            If Not dt Is Nothing AndAlso dt.Rows.Count > 0 Then
                FindByLineNo = dt
            Else
                FindByLineNo = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show("clsFormulaInfo.Find : " & ex.ToString())
            FindByLineNo = Nothing
        End Try
    End Function


    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : FindByFormulaCodeLineNo
    '   Purpose         : FindByFormulaCodeLineNo Object clsFormulaInfo by Formula Code and Line No
    '   Created         : Ball 20151028-12_48
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------

    Public Shared Function FindByFormulaCodeLineNo(ByVal intFormulaCode As Integer, ByVal intLineNo As Integer) As clsFormulaInfo
        Dim dt As DataTable
        Dim strLineName As String = String.Empty
        Dim sSqlCmd As String = _
            " SELECT * " & _
            " FROM [FORMULA_MASTER] fm " & _
            " WHERE fm.[LINE_NO] = " & intLineNo & _
            " AND fm.[FORMULA_CODE] = " & intFormulaCode

        Try
            dt = clsAdoxCached.GetDataTable(sSqlCmd)
            FindByFormulaCodeLineNo = New clsFormulaInfo()
            If Not dt Is Nothing AndAlso dt.Rows.Count > 0 Then
                With dt.Rows(0)
                    FindByFormulaCodeLineNo.FormulaId = .Item("FORMULA_ID")
                    FindByFormulaCodeLineNo.FormulaCode = .Item("FORMULA_CODE")
                    FindByFormulaCodeLineNo.FormulaName = .Item("FORMULA_NAME")
                    FindByFormulaCodeLineNo.LineNo = .Item("LINE_NO")
                End With
            Else
                FindByFormulaCodeLineNo = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show("clsFormulaInfo.FindByFormulaCodeLineNo : " & ex.ToString())
            FindByFormulaCodeLineNo = Nothing
        End Try
    End Function

    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : FindAll
    '   Purpose         : FindAll Object clsFormulaInfo
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------

    Public Shared Function FindAll() As DataTable
        Dim dt As DataTable
        Dim sSqlCmd As String = _
            " SELECT * " & _
            " FROM [FORMULA_MASTER]"
        Try
            dt = clsAdoxCached.GetDataTable(sSqlCmd)
            If Not dt Is Nothing AndAlso dt.Rows.Count > 0 Then
                FindAll = dt
            Else
                FindAll = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show("clsFormulaInfo.FindAll : " & ex.ToString())
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
            " SELECT MAX(FORMULA_ID) " & _
            " FROM [FORMULA_MASTER]"
        Try
            dt = clsAdoxCached.GetDataTable(sSqlCmd)
            If Not dt Is Nothing AndAlso dt.Rows.Count > 0 Then
                FindLastestID = dt.Rows(0).Item(0)
            Else
                FindLastestID = -1
            End If
        Catch ex As Exception
            MessageBox.Show("clsFormulaInfo.FindLastestID : " & ex.ToString())
            FindLastestID = -1
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

    Public Shared Function FindLastestCode(ByVal intLineNo As Integer) As Integer
        Dim dt As DataTable
        Dim sSqlCmd As String = _
            " SELECT MAX(FORMULA_CODE) " & _
            " FROM [FORMULA_MASTER] " & _
            " WHERE LINE_NO = " & intLineNo
        Try
            dt = clsAdoxCached.GetDataTable(sSqlCmd)
            If Not dt Is Nothing AndAlso dt.Rows.Count > 0 Then
                FindLastestCode = dt.Rows(0).Item(0)
            Else
                FindLastestCode = -1
            End If
        Catch ex As Exception
            MessageBox.Show("clsFormulaInfo.FindLastestID : " & ex.ToString())
            FindLastestCode = -1
        End Try
    End Function
    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : Count
    '   Purpose         : Count Object clsFormulaInfo
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------
    Public Shared Function Count() As Integer
        Dim dt As DataTable
        Dim intCount As Integer = 0
        Dim sSqlCmd As String = _
            " SELECT COUNT(FORMULA_ID) " & _
            " FROM [FORMULA_MASTER]"
        Try
            dt = clsAdoxCached.GetDataTable(sSqlCmd)
            If Not dt Is Nothing AndAlso dt.Rows.Count = 0 Then
                Count = 0
            Else
                Count = dt.Rows(0).Item(0)
            End If
        Catch ex As Exception
            MessageBox.Show("clsFormulaInfo.Count : " & ex.ToString())
            Count = -1
        End Try
    End Function

    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : CountByLineNo
    '   Purpose         : Count Object clsFormulaInfo by line no
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------
    Public Shared Function CountByLineNo(ByVal intLineNo As Integer) As Integer
        Dim dt As DataTable
        Dim intCount As Integer = 0
        Dim sSqlCmd As String = _
            " SELECT COUNT(FORMULA_ID) " & _
            " FROM [FORMULA_MASTER] " & _
            " WHERE LINE_NO = " & intLineNo
        Try
            dt = clsAdoxCached.GetDataTable(sSqlCmd)
            If Not dt Is Nothing AndAlso dt.Rows.Count = 0 Then
                CountByLineNo = 0
            Else
                CountByLineNo = dt.Rows(0).Item(0)
            End If
        Catch ex As Exception
            MessageBox.Show("clsFormulaInfo.Count : " & ex.ToString())
            CountByLineNo = -1
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

    Public Shared Function AddFormulaNameToCombo(ByVal cmb As System.Windows.Forms.ComboBox, ByVal intLineNo As Integer) As Integer()
        Dim dtFormulaInfo As DataTable = FindByLineNo(intLineNo)
        Dim i As Integer = 0
        Dim intArrayList(dtFormulaInfo.Rows.Count - 1) As Integer
        Try
            cmb.Items.Clear()
            If Not dtFormulaInfo Is Nothing Then
                For i = 0 To dtFormulaInfo.Rows.Count - 1
                    If intLineNo = dtFormulaInfo.Rows(i).Item("LINE_NO") Then
                        cmb.Items.Add(dtFormulaInfo.Rows(i).Item("FORMULA_NAME"))
                        intArrayList(i) = dtFormulaInfo.Rows(i).Item("FORMULA_ID")
                    End If
                Next
                AddFormulaNameToCombo = intArrayList
            Else
                AddFormulaNameToCombo = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show("clsFormulaInfo.AddFormulaNameToCombo : " & ex.ToString())
            AddFormulaNameToCombo = Nothing
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
    Public Shared Function Create(ByVal intFormulaCode As Integer, _
                                  ByVal strFormulaName As String, _
                                  ByVal intLineNo As Integer) As clsFormulaInfo
        Dim objFormulaInfo As clsFormulaInfo = New clsFormulaInfo()
        Dim bSuccess As Boolean = 0
        Dim sSqlCmd As String = _
            " INSERT INTO [FORMULA_MASTER]" & _
            "([FORMULA_CODE] " & _
            ",[FORMULA_NAME] " & _
            ",[LINE_NO] " & _
            " ) VALUES ( " & _
            " " & intFormulaCode & _
            ",'" & strFormulaName & "'" & _
            "," & intLineNo & _
            ")"
        Try
            bSuccess = clsAdoxCached.Execute(sSqlCmd)

            If bSuccess Then
                objFormulaInfo.FormulaId = FindLastestID()
                objFormulaInfo.FormulaCode = intFormulaCode
                objFormulaInfo.FormulaName = strFormulaName
                objFormulaInfo.LineNo = intLineNo
            End If
        Catch ex As Exception
            MessageBox.Show("clsFormulaInfo.Create : " & ex.ToString())
        End Try
        Return objFormulaInfo
    End Function

    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : Delete
    '   Purpose         : Delete Object clsFormulaInfo
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------
    Public Shared Sub Delete(ByVal intFormulaId As Integer)
        Dim sSqlCmd As String = _
            " DELETE FROM [FORMULA_MASTER]" & _
            " WHERE [FORMULA_ID] = " & intFormulaId
        Try
            clsAdoxCached.Execute(sSqlCmd)
        Catch ex As Exception
            MessageBox.Show("clsFormulaInfo.Delete : " & ex.ToString())
        End Try
    End Sub
    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : Update
    '   Purpose         : Update Object clsFormulaInfo
    '   Created         : Pentita 15/06/2012
    '   Modified        :
    '
    '   Linked          : clsAdoxCached.GetDataTable
    '--------------------------------------------------------------------------------------------------------
    Public Shared Sub Update(ByVal intFormulaId As Integer, _
                             ByVal intFormulaCode As Integer, _
                                  ByVal strFormulaName As String, _
                                  ByVal intLineNo As Integer)
        Dim sSqlCmd As String = _
            " UPDATE [FORMULA_MASTER]" & _
            " SET " & _
            " [FORMULA_CODE]  = " & intFormulaCode & _
            ",[FORMULA_NAME]  = '" & strFormulaName & "'" & _
            ",[LINE_NO]  = " & intLineNo & _
            " WHERE [FORMULA_ID] = " & intFormulaId
        Try
            clsAdoxCached.Execute(sSqlCmd)
        Catch ex As Exception
            MessageBox.Show("clsFormulaInfo.Update : " & ex.ToString())
        End Try
    End Sub
#End Region
End Class
