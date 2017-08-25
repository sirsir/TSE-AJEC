Public Class clsLog

#Region "Public"
    Public Shared m_objLogger As clsLogger = New clsLogger
#End Region
#Region "Attributes"
    Private Shared m_intRunningLogNo As Integer
    Private Shared m_intLimitRow As Integer

    Enum eWriteLog
        OpenForm = 1
        CloseForm
        RptCreate
        RptPrint
        RptView
        RptDelete
        FormulaDesignNewSave
        FormulaDesignRename
        FormulaDesignEditSave
        FormulaDesignDelete
        CountTotalLog
        ShiftChange
        BatchNoChange
        PLCDisconnect
        PLCConnect
        PLCError
    End Enum

#End Region

#Region "Property"
    Public Shared Property RunningLogNo() As Integer
        Get
            Return m_intRunningLogNo
        End Get
        Set(ByVal value As Integer)
            m_intRunningLogNo = value
        End Set
    End Property
    Public Shared Property LimitRow() As Integer
        Get
            Return m_intLimitRow
        End Get
        Set(ByVal value As Integer)
            m_intLimitRow = value
        End Set
    End Property
#End Region

#Region "Constructor"
    Protected Sub New()
        Reset()
    End Sub

    Public Overridable Sub Reset()
        m_intRunningLogNo = 0
        m_intLimitRow = 0
    End Sub
#End Region

#Region "method"

    Public Shared Sub AddLog(ByVal eAction As eWriteLog, Optional ByVal strText As String = "")
        Dim strWriteAction As String = String.Empty
        Dim frmMain As frmBatchResult
        Dim dg As DataGridView
        Dim sSqlCmd As String
        Try
            strWriteAction = GetWriteLog(eAction)
            If eAction <> eWriteLog.CloseForm Then
                LimitRow = My.Settings.g_intLimitLogLine
                frmMain = My.Application.OpenForms.Item(0)
                dg = frmMain.DgLog

                'set running log no.
                RunningLogNo = frmMain.m_intRunningLogNo
                RunningLogNo = RunningLogNo + 1

                'Add Empty Row
                dg.Rows.Insert(0)

                'if LimitRow = 0 then row number is not limit.
                If LimitRow > 0 Then
                    While dg.Rows.Count > LimitRow
                        'Remove last row
                        dg.Rows.RemoveAt(dg.Rows.Count - 1)
                    End While
                End If

                'write Log
                dg.Item(0, 0).Value = RunningLogNo.ToString
                dg.Item(1, 0).Value = FormatDateTime(Now, DateFormat.ShortDate)
                dg.Item(2, 0).Value = FormatDateTime(Now, DateFormat.ShortTime)
                dg.Item(3, 0).Value = strWriteAction & " " & strText
                frmMain.m_intRunningLogNo = RunningLogNo
            End If
            sSqlCmd = "INSERT INTO [LOG_MASTER]" & _
                     "([LOG_DATETIME]" & _
                     ",[LOG_MSG]" & _
                     ") VALUES ( " & _
                     " getdate()" & _
                     ",'" & strWriteAction & " " & strText & "'" & _
                     ")"

            clsAdoxCached.Execute(sSqlCmd)

        Catch ex As Exception
            'MessageBox.Show("AddLog :" & ex.ToString)
            m_objLogger.AppendLog(ex)
        End Try
    End Sub
    Public Shared Function GetWriteLog(ByVal eAction As eWriteLog) As String
        If eAction = eWriteLog.OpenForm Then
            GetWriteLog = " Program Start "
        ElseIf eAction = eWriteLog.CloseForm Then
            GetWriteLog = " Program End "
        ElseIf eAction = eWriteLog.RptCreate Then
            GetWriteLog = " Create report "
        ElseIf eAction = eWriteLog.RptPrint Then
            GetWriteLog = " Print report "
        ElseIf eAction = eWriteLog.RptView Then
            GetWriteLog = " View report "
        ElseIf eAction = eWriteLog.RptDelete Then
            GetWriteLog = " Delete report "
        ElseIf eAction = eWriteLog.FormulaDesignNewSave Then
            GetWriteLog = " Create new formula "
        ElseIf eAction = eWriteLog.FormulaDesignRename Then
            GetWriteLog = " Rename formula "
        ElseIf eAction = eWriteLog.FormulaDesignEditSave Then
            GetWriteLog = " Save change in formula "
        ElseIf eAction = eWriteLog.FormulaDesignDelete Then
            GetWriteLog = " Delete formula "
        ElseIf eAction = eWriteLog.ShiftChange Then
            GetWriteLog = " Change to Shift "
        ElseIf eAction = eWriteLog.BatchNoChange Then
            GetWriteLog = " Change Batch No. At Seq. "
        ElseIf eAction = eWriteLog.PLCDisconnect Then
            GetWriteLog = " Disconnect from PLC"
        ElseIf eAction = eWriteLog.PLCConnect Then
            GetWriteLog = " Connect to PLC "
        ElseIf eAction = eWriteLog.PLCError Then
            GetWriteLog = " PLC Error: "
        Else
            GetWriteLog = String.Empty
        End If
    End Function

    'Public Shared Sub LogException(ByVal ex As Exception, Optional ByVal strInfo As String = "", Optional ByVal showMessageBox As Boolean = False)
    '    'TODO Call This Function when exception
    '    Dim strMessage As String = String.Empty

    '    strMessage &= "[" & Now.ToString("yyyy/MM/dd HH:mm:ss") & "]"
    '    strMessage &= ex.StackTrace

    '    If strInfo IsNot Nothing AndAlso strInfo <> "" Then
    '        strMessage &= "[" & strInfo & "]"
    '    End If
    '    My.Application.Log.WriteEntry(strMessage)

    '    If showMessageBox Then
    '        MsgBox(ex.Message, MsgBoxStyle.Critical)
    '    End If
    'End Sub

#End Region
End Class
