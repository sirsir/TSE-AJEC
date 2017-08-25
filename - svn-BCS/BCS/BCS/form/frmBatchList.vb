Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Windows.Forms

Public Class frmBatchList

#Region "Attribute"
    Private m_intLineNo As Integer = -1
    Private m_strRoleId As String = "USR"
    Private m_intFormulaId As Integer
    Private m_intShift As Integer
    Private m_clsBatchResultInfo As clsBatchResultInfo
    Private m_dt As DataTable
    Private m_nRmType As eRmType
    Private m_datFrom As DateTime
    Private m_datTo As DateTime

    Private m_intColBatchSeq As Integer = 0
    Private m_intColBatchDate As Integer = 1
    Private m_intColBatchNo As Integer = 2
    Private m_intColFormulaId As Integer = 3
    Private m_intColFormulaName As Integer = 4
    Private m_intColLineNo As Integer = 5
    Private m_intColShiftCode As Integer = 6
    Private m_intColCoffeeActualValue As Integer = 7
    Private m_intColCreamActualValue As Integer = 8
    Private m_intColSugarActualValue As Integer = 9
    Private m_intColOilActualValue As Integer = 7

#End Region

    Public Enum eRmType
        Weight
        Liquid
    End Enum

#Region "Constant"
    Private Const cintBatchDateTimeColumnIndex As Integer = 1
    Private Const cintBatchSeqColumnIndex As Integer = 0
#End Region


#Region "Properties"
    Public WriteOnly Property LineNo As Integer
        Set(ByVal value As Integer)
            m_intLineNo = value
        End Set
    End Property
#End Region

#Region "Constructor AND Destructor"
    Public Sub New(ByVal strRoleId As String, ByVal intLineNo As Integer, Optional ByVal rmType As eRmType = eRmType.Weight)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        m_strRoleId = strRoleId
        m_intLineNo = intLineNo
        m_clsBatchResultInfo = New clsBatchResultInfo
        m_nRmType = rmType
        m_intFormulaId = -1
        m_intShift = -1
        m_datFrom = Now
        m_datTo = Now
    End Sub
#End Region

#Region "Events"

    Private Sub frmBatchList_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Dim frm As frmBatchResult = DirectCast(Me.Owner, frmBatchResult)

        frm.btnReportB1.Enabled = True
        frm.btnReportB2.Enabled = True
    End Sub
    Private Sub frmBatchList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            dtpFrom.CustomFormat = "dd/MM/yyyy   HH:mm:ss"
            dtpTo.CustomFormat = "dd/MM/yyyy   HH:mm:ss"

            dtpFrom.Value = Now
            dtpTo.Value = Now
            dtpFrom.Checked = False
            dtpTo.Checked = False
            lblLine.Text = "LINE" & clsLineInfo.FindLineCode(m_intLineNo)

            cmbShift.DataSource = clsShiftInfo.FindAll
            cmbShift.DisplayMember = "SHIFT_CODE"
            cmbShift.ValueMember = "SHIFT_CODE"
            cmbShift.SelectedIndex = -1

            cmbFormula.DataSource = clsFormulaInfo.FindByLineNo(m_intLineNo)
            cmbFormula.DisplayMember = "FORMULA_NAME"
            cmbFormula.ValueMember = "FORMULA_ID"
            cmbFormula.SelectedIndex = -1

            cmbRMType.SelectedIndex = 0
            m_nRmType = eRmType.Weight
        Catch ex As Exception
            MessageBox.Show("frmBatchList : " & ex.ToString())
        End Try
    End Sub

#End Region

#Region "Private Function"
    Private Function CheckDateFromTo(ByVal dtStartingDate As DateTime, ByVal dtEndingDate As DateTime) As Boolean
        Try
            If dtStartingDate <= dtEndingDate Then
                CheckDateFromTo = True
            Else
                CheckDateFromTo = False
                MsgBox("Ending Date is before Starting Date. Plase Change.")
            End If
        Catch ex As Exception
            MessageBox.Show("CheckDateFromTo : " & ex.ToString())
            CheckDateFromTo = False
        End Try
    End Function
    Private Sub CreateReport(ByVal dtStartingDate As DateTime, ByVal dtEndingDate As DateTime)
        Try
            If CheckDateFromTo(dtStartingDate, dtEndingDate) Then
                If m_nRmType = eRmType.Weight Then
                    clsCrReport.CreateReportWeight(dtStartingDate, dtEndingDate, m_intLineNo, m_intFormulaId, True)
                ElseIf m_nRmType = eRmType.Liquid Then
                    clsCrReport.CreateReportLiquid(dtStartingDate, dtEndingDate, m_intLineNo, m_intFormulaId, True)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("CreateReport : " & ex.ToString())
        End Try
    End Sub
    Private Sub DeleteReport(ByVal dtStartingDate As DateTime, ByVal dtEndingDate As DateTime)
        Try
            If CheckDateFromTo(dtStartingDate, dtEndingDate) Then
                If MsgBox("Confirm delete Report during " & dtStartingDate & " To " & dtEndingDate, MsgBoxStyle.OkCancel) = 1 Then
                    clsCrReport.DeleteReport(dtStartingDate, dtEndingDate)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("DeleteReport : " & ex.ToString())
        End Try
    End Sub
#End Region

#Region "Public Function"
#End Region

    Private Sub btnSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Try
            If Me.cmbFormula.SelectedIndex < 0 Then
                MsgBox("Please select formula")
                Return
            End If

            Me.LoadData()
            m_intFormulaId = Me.cmbFormula.SelectedValue
        Catch ex As Exception
            MessageBox.Show("Search : " & ex.ToString())
        End Try
    End Sub

    Private Sub LoadData()
        Dim strSQL As String
        Dim strFrom As String
        Dim strTo As String

        If dtpFrom.Checked Then
            strFrom = dtpFrom.Value.ToString("s")
        End If

        If dtpTo.Checked Then
            strTo = dtpTo.Value.ToString("s")
        End If

        If m_nRmType = eRmType.Weight Then
            strSQL = "SELECT DISTINCT v_drw.BATCH_SEQ" & _
                                    "		 , Min(v_drw.BATCH_DATE) BATCH_DATE" & _
                                    "		 , v_drw.BATCH_NO" & _
                                    "		 , v_drw.FORMULA_ID" & _
                                    "		 , v_drw.FORMULA_NAME" & _
                                    "		 , v_drw.LINE_NO" & _
                                    "		 , v_drw.SHIFT_CODE" & _
                                    "        , v_drw.COFFEE_ACTUAL_VALUE" & _
                                    "        , v_drw.CREAM_ACTUAL_VALUE" & _
                                    "        , v_drw.SUGAR_ACTUAL_VALUE" & _
                                    " FROM V_DAILY_REPORT_WEIGHT v_drw" & _
                                    " WHERE v_drw.LINE_NO = " & m_intLineNo & _
                                    "  AND v_drw.FORMULA_ID = " & Me.cmbFormula.SelectedValue & _
                                    IIf(dtpFrom.Checked, "  AND v_drw.BATCH_DATE >= '" & dtpFrom.Value.ToString("s") & "'", "") & _
                                    IIf(dtpTo.Checked, "  AND v_drw.BATCH_DATE <= '" & dtpTo.Value.ToString("s") & "'", "") & _
                                    " GROUP BY v_drw.BATCH_SEQ,v_drw.BATCH_NO,v_drw.FORMULA_ID,v_drw.FORMULA_NAME,v_drw.LINE_NO,v_drw.SHIFT_CODE, v_drw.COFFEE_ACTUAL_VALUE , v_drw.CREAM_ACTUAL_VALUE, v_drw.SUGAR_ACTUAL_VALUE" & _
                                    " ORDER by BATCH_DATE,v_drw.BATCH_SEQ"
            'strSQL = "SELECT DISTINCT br.BATCH_SEQ" & _
            '            "		 , Min(br.BATCH_DATE) BATCH_DATE" & _
            '            "		 , br.BATCH_NO" & _
            '            "		 , r.FORMULA_ID" & _
            '            "		 , fm.FORMULA_NAME" & _
            '            "		 , fm.LINE_NO" & _
            '            "		 , br.SHIFT_CODE" & _
            '            " FROM        BATCH_RESULT br" & _
            '            "  join REVISION r ON br.REVISION_ID = r.REVISION_ID" & _
            '            "  join FORMULA_MASTER fm ON r.FORMULA_ID = fm.FORMULA_ID" & _
            '            "  join RM_MASTER rm ON br.RM_NO = rm.RM_NO" & _
            '            " WHERE fm.LINE_NO = " & m_intLineNo & _
            '            "  AND fm.FORMULA_ID = " & Me.cmbFormula.SelectedValue & _
            '            "  AND rm.RM_CODE NOT LIKE 'OIL'" & _
            '            IIf(dtpFrom.Checked, "  AND br.BATCH_DATE >= '" & dtpFrom.Value.ToString("s") & "'", "") & _
            '            IIf(dtpTo.Checked, "  AND br.BATCH_DATE <= '" & dtpTo.Value.ToString("s") & "'", "") & _
            '            " GROUP BY br.BATCH_SEQ,br.BATCH_NO,r.FORMULA_ID,fm.FORMULA_NAME,fm.LINE_NO,br.SHIFT_CODE	" & _
            '            " ORDER by BATCH_DATE,br.BATCH_SEQ"
        Else
            strSQL = "SELECT DISTINCT v_drl.BATCH_SEQ" & _
                                    "		 , Min(v_drl.BATCH_DATE) BATCH_DATE" & _
                                    "		 , v_drl.BATCH_NO" & _
                                    "		 , v_drl.FORMULA_ID" & _
                                    "		 , v_drl.FORMULA_NAME" & _
                                    "		 , v_drl.LINE_NO" & _
                                    "		 , v_drl.SHIFT_CODE" & _
                                    "		 , v_drl.OIL_ACTUAL_VALUE" & _
                                    " FROM V_DAILY_REPORT_LIQUID v_drl" & _
                                    " WHERE v_drl.LINE_NO = " & m_intLineNo & _
                                    "  AND v_drl.FORMULA_ID = " & Me.cmbFormula.SelectedValue & _
                                    IIf(dtpFrom.Checked, "  AND v_drl.BATCH_DATE >= '" & dtpFrom.Value.ToString("s") & "'", "") & _
                                    IIf(dtpTo.Checked, "  AND v_drl.BATCH_DATE <= '" & dtpTo.Value.ToString("s") & "'", "") & _
                                    " GROUP BY v_drl.BATCH_SEQ,v_drl.BATCH_NO,v_drl.FORMULA_ID,v_drl.FORMULA_NAME,v_drl.LINE_NO,v_drl.SHIFT_CODE, v_drl.OIL_ACTUAL_VALUE" & _
                                    " ORDER by BATCH_DATE,v_drl.BATCH_SEQ"
            'strSQL = "SELECT DISTINCT br.BATCH_SEQ" & _
            '                    "		 , Min(br.BATCH_DATE) BATCH_DATE" & _
            '                    "		 , br.BATCH_NO" & _
            '                    "		 , r.FORMULA_ID" & _
            '                    "		 , fm.FORMULA_NAME" & _
            '                    "		 , fm.LINE_NO" & _
            '                    "		 , br.SHIFT_CODE" & _
            '                    " FROM        BATCH_RESULT br" & _
            '                    "  join REVISION r ON br.REVISION_ID = r.REVISION_ID" & _
            '                    "  join FORMULA_MASTER fm ON r.FORMULA_ID = fm.FORMULA_ID" & _
            '                    "  join RM_MASTER rm ON br.RM_NO = rm.RM_NO" & _
            '                    " WHERE fm.LINE_NO = " & m_intLineNo & _
            '                    "  AND fm.FORMULA_ID = " & Me.cmbFormula.SelectedValue & _
            '                    "  AND rm.RM_CODE LIKE 'OIL'" & _
            '                    IIf(dtpFrom.Checked, "  AND br.BATCH_DATE >= '" & dtpFrom.Value.ToString("s") & "'", "") & _
            '                    IIf(dtpTo.Checked, "  AND br.BATCH_DATE <= '" & dtpTo.Value.ToString("s") & "'", "") & _
            '                    " GROUP BY br.BATCH_SEQ,br.BATCH_NO,r.FORMULA_ID,fm.FORMULA_NAME,fm.LINE_NO,br.SHIFT_CODE	" & _
            '                    " ORDER by BATCH_DATE,br.BATCH_SEQ"
        End If
        m_dt = clsAdoxCached.GetDataTable(strSQL)
        Me.dgvBatchList.DataSource = m_dt
        dgvBatchList.Columns(m_intColBatchSeq).ReadOnly = True
        dgvBatchList.Columns(m_intColBatchDate).ReadOnly = True
        dgvBatchList.Columns(m_intColBatchNo).ReadOnly = True
        dgvBatchList.Columns(m_intColFormulaId).ReadOnly = True
        dgvBatchList.Columns(m_intColFormulaName).ReadOnly = True
        dgvBatchList.Columns(m_intColLineNo).ReadOnly = True
        dgvBatchList.Columns(m_intColShiftCode).ReadOnly = True
    End Sub


    Private Sub dgvBatchList_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvBatchList.SelectionChanged
        Dim datMin As DateTime = DateTime.MaxValue
        Dim datMax As DateTime = DateTime.MinValue
        Dim datTemp As DateTime
        Try
            If dgvBatchList.SelectedRows.Count > 0 Then
                For i As Integer = 0 To dgvBatchList.SelectedRows.Count - 1
                    datTemp = dgvBatchList.SelectedRows(i).Cells(cintBatchDateTimeColumnIndex).Value
                    If datMin > datTemp Then
                        datMin = datTemp
                    End If

                    If datMax < datTemp Then
                        datMax = datTemp
                    End If
                Next
                If datMin <> DateTime.MaxValue Then
                    'dtpFrom.Value = datMin
                    m_datFrom = datMin
                End If

                If datMax <> DateTime.MinValue Then
                    'dtpTo.Value = datMax
                    m_datTo = datMax
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Selection : " & ex.ToString())
        End Try
    End Sub

    'Private Sub dgvBatchList_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvBatchList.CellMouseDoubleClick
    '    Dim dblActualValue As Double
    '    Try
    '        If m_nRmType = eRmType.Weight Then
    '            If e.ColumnIndex = m_intColCoffeeActualValue _
    '            Or e.ColumnIndex = m_intColCreamActualValue _
    '            Or e.ColumnIndex = m_intColSugarActualValue Then
    '                If Integer.TryParse(InputBox("Input new ActualValue", "Re-Actual Value"), dblActualValue) Then
    '                    If e.ColumnIndex = m_intColCoffeeActualValue Then
    '                        SetActualValue(dgvBatchList.Item(m_intColBatchSeq, e.RowIndex).Value, 1, dgvBatchList.Item(m_intColCoffeeActualValue, e.RowIndex).Value)
    '                    End If
    '                    If e.ColumnIndex = m_intColCreamActualValue Then
    '                        SetActualValue(dgvBatchList.Item(m_intColBatchSeq, e.RowIndex).Value, 2, dgvBatchList.Item(m_intColCreamActualValue, e.RowIndex).Value)
    '                    End If
    '                    If e.ColumnIndex = m_intColSugarActualValue Then
    '                        SetActualValue(dgvBatchList.Item(m_intColBatchSeq, e.RowIndex).Value, 3, dgvBatchList.Item(m_intColSugarActualValue, e.RowIndex).Value)
    '                    End If
    '                    LoadData()
    '                End If
    '            End If

    '        ElseIf m_nRmType = eRmType.Liquid Then
    '            If e.ColumnIndex = m_intColOilActualValue Then
    '                If Integer.TryParse(InputBox("Input new ActualValue", "Re-Actual Value"), dblActualValue) Then
    '                    SetActualValue(dgvBatchList.Item(m_intColBatchSeq, e.RowIndex).Value, 4, dgvBatchList.Item(m_intColOilActualValue, e.RowIndex).Value)
    '                    LoadData()
    '                End If
    '            End If
    '        End If
    '    Catch ex As Exception
    '        clsAdoxCached.RollbackTransaction()
    '        MessageBox.Show("Set Actual Value : " & ex.ToString())
    '    End Try
    'End Sub


    Private Sub cmbRMType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRMType.SelectedIndexChanged
        If cmbRMType.SelectedItem = "Weight" Then
            m_nRmType = eRmType.Weight
        ElseIf cmbRMType.SelectedItem = "Liquid" Then
            m_nRmType = eRmType.Liquid
        End If
    End Sub

    Private Sub btnReBatch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReBatch.Click
        Dim intBatchSeq As Integer = -1
        Dim intBatchNo As Integer = 1
        Dim strBatchSeq As String = String.Empty
        Dim strLog As String = String.Empty

        If Me.cmbFormula.SelectedIndex < 0 Then
            MsgBox("Please select formula")
            Return
        End If

        Try
            If dgvBatchList.SelectedRows.Count > 0 Then
                Dim strInputBatchNo As String = InputBox("Input first batch no. for selected row.", "Re-Batch")
                If strInputBatchNo <> String.Empty Then
                    If Integer.TryParse(strInputBatchNo, intBatchNo) Then
                        clsAdoxCached.BeginTransaction()
                        intBatchNo = intBatchNo + dgvBatchList.SelectedRows.Count - 1
                        For i As Integer = 0 To dgvBatchList.SelectedRows.Count - 1
                            intBatchSeq = CInt(dgvBatchList.SelectedRows(i).Cells(cintBatchSeqColumnIndex).Value)
                            Me.SetBatch(intBatchSeq, intBatchNo)
                            intBatchNo = intBatchNo - 1
                            strBatchSeq &= intBatchSeq.ToString() & " "
                        Next
                        If m_nRmType = eRmType.Weight Then
                            strLog &= strBatchSeq & "for Weight"
                        Else
                            strLog &= strBatchSeq & "for Oil"
                        End If
                        clsAdoxCached.CommitTransaction()
                        clsLog.AddLog(clsLog.eWriteLog.BatchNoChange, strLog)
                        Me.LoadData()
                    Else
                        MsgBox("Error, wrong batch no.")
                    End If

                End If
            Else
                MsgBox("Please select batch to set batch no.")
                Return
            End If
        Catch ex As Exception
            clsAdoxCached.RollbackTransaction()
            MessageBox.Show("Set BatchNo : " & ex.ToString())
        End Try
    End Sub
    Private Sub btnSetShift_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSetShift.Click
        Dim intBatchSeq As Integer = -1
        Dim strBatchSeq As String = String.Empty
        Dim strLog As String = String.Empty

        If Me.cmbFormula.SelectedIndex < 0 Then
            MsgBox("Please select formula")
            Return
        End If

        If Me.cmbShift.SelectedIndex < 0 Then
            MsgBox("Please select shift to set")
            Return
        End If

        Try
            If dgvBatchList.SelectedRows.Count > 0 Then
                clsAdoxCached.BeginTransaction()
                strLog = clsShiftInfo.FindShiftName(cmbShift.SelectedValue) & " At Seq "
                For i As Integer = 0 To dgvBatchList.SelectedRows.Count - 1
                    intBatchSeq = CInt(dgvBatchList.SelectedRows(i).Cells(cintBatchSeqColumnIndex).Value)
                    Me.SetShift(intBatchSeq, cmbShift.SelectedValue)
                    strBatchSeq &= intBatchSeq.ToString() & " "
                Next
                If m_nRmType = eRmType.Weight Then
                    strLog &= strBatchSeq & "for Weight"
                Else
                    strLog &= strBatchSeq & "for Oil"
                End If
                clsAdoxCached.CommitTransaction()
                clsLog.AddLog(clsLog.eWriteLog.ShiftChange, strLog)
                Me.LoadData()
                m_intShift = cmbShift.SelectedValue
            Else
                MsgBox("Please select batch to set shift")
                Return
            End If
        Catch ex As Exception
            clsAdoxCached.RollbackTransaction()
            MessageBox.Show("Set Shift : " & ex.ToString())
        End Try
    End Sub

    Private Sub SetShift(ByVal batchSeq As Integer, ByVal shift As Integer)
        Dim strSQL As String
        'TODO Update by RM type
        'strSQL = String.Format("UPDATE BATCH_RESULT SET SHIFT_CODE = {0} WHERE BATCH_SEQ = {1}" _
        '                       , shift _
        '                       , batchSeq)
        strSQL = String.Format("UPDATE BATCH_RESULT SET SHIFT_CODE = {0}" & _
                                 "FROM REVISION re " & _
                                 "JOIN FORMULA_MASTER fm ON re.FORMULA_ID = fm.FORMULA_ID " & _
                                 "  WHERE(BATCH_SEQ = {1}) " & _
                                 "  AND fm.FORMULA_ID = {2}" _
                               , shift _
                               , batchSeq _
                               , cmbFormula.SelectedValue)

        clsAdoxCached.Execute(strSQL, True, False)
    End Sub

    Private Sub SetBatch(ByVal batchSeq As Integer, ByVal batchNo As Integer)
        Dim strSQL As String = String.Empty
        If m_nRmType = eRmType.Weight Then
            strSQL = String.Format("UPDATE BATCH_RESULT SET BATCH_NO = {0}" & _
                                     " FROM REVISION re " & _
                                     " JOIN FORMULA_MASTER fm ON re.FORMULA_ID = fm.FORMULA_ID " & _
                                     "  WHERE(BATCH_SEQ = {1} AND (RM_NO = 1 OR RM_NO = 2 OR RM_NO =3)) " & _
                                     "  AND fm.FORMULA_ID = {2}" _
                                   , batchNo _
                                   , batchSeq _
                                   , cmbFormula.SelectedValue)
        Else
            strSQL = String.Format("UPDATE BATCH_RESULT SET BATCH_NO = {0}" & _
                                     " FROM REVISION re " & _
                                     " JOIN FORMULA_MASTER fm ON re.FORMULA_ID = fm.FORMULA_ID " & _
                                     "  WHERE(BATCH_SEQ = {1} AND RM_NO = 4) " & _
                                     "  AND fm.FORMULA_ID = {2}" _
                                   , batchNo _
                                   , batchSeq _
                                   , cmbFormula.SelectedValue)
        End If
        clsAdoxCached.Execute(strSQL, True, False)
    End Sub

    Private Sub SetActualValue(ByVal batchSeq As Integer, ByVal intRMCode As String, ByVal intActualValue As Integer)
        Dim strSQL As String
        strSQL = String.Format("UPDATE BATCH_RESULT SET READ_VALUE_ACTUAL = {0}" & _
                                 " FROM REVISION re " & _
                                 " JOIN FORMULA_MASTER fm ON re.FORMULA_ID = fm.FORMULA_ID " & _
                                 "  WHERE(BATCH_SEQ = {1} AND RM_NO = {2}) " & _
                                 "  AND fm.FORMULA_ID = {3} " _
                               , intActualValue _
                               , batchSeq _
                               , intRMCode _
                               , cmbFormula.SelectedValue)
        clsAdoxCached.Execute(strSQL, True, False)
    End Sub
    Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Try
            'CreateReport(dtpFrom.Value, dtpTo.Value)
            CreateReport(m_datFrom, m_datTo)
        Catch ex As Exception
            MessageBox.Show("Print : " & ex.ToString())
        End Try
    End Sub
End Class