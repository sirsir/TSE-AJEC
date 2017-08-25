Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frmBatchResult

#Region "Public Variables"
    Public m_bFinishLoad As Boolean = False
    Public m_dblActual As Double = 0
    Public m_intRunningLogNo As Integer = 0
    Public m_objLogger As clsLogger = New clsLogger
    Public m_objLoggerL1 As clsLogger = New clsLogger("Batch1")
    Public m_objLoggerL2 As clsLogger = New clsLogger("Batch2")
#End Region

#Region "Private Variables"
    'VIEW FOR VIEWING ONLY
    Dim m_strViewFormulaRunning As String = "V_FORMULA_RUNNING"

    'Line no list info
    Dim m_dtLineNo As DataTable

    'status on light
    Dim m_bRunReturn As Boolean = False
    Dim m_bCompleterm As Boolean = False
    Dim m_bEndProcess As Boolean = False
    Dim m_bRM1Discharge As Boolean = False
    Dim m_bRM2Discharge As Boolean = False
    Dim m_bRM3DIscharge As Boolean = False

    'username priority
    Dim m_strRoleId As String = "USR"

    'table column
    Dim m_intColRMName As Integer = 0
    Dim m_intColRMLot As Integer = 1
    Dim m_intColMax As Integer = 2
    Dim m_intColTarget As Integer = 3
    Dim m_intColMin As Integer = 4
    Dim m_intColActual As Integer = 5
    Dim m_intColDiff As Integer = 6
    Dim m_intColCount As Integer = 7

    'table column hidden
    Dim m_intColFormulaCode As Integer = 7
    Dim m_intColLineNo As Integer = 8
    Dim m_intColRMNo As Integer = 9

    'shift code
    Dim m_intShiftCode As Integer = 1

    Dim m_arrBatch As ArrayList
    Dim m_frmGraphic As frmGraphic

    Dim m_bMotorCoffee As Integer
    Dim m_bMotorCream As Integer
    Dim m_bMotorSugar As Integer

    Dim m_dblOldMaterialWeight As Double()
    Dim m_dblOldMaterialLiquid As Double()
    Dim m_bChkCompleted As Boolean()

    Dim m_dtPlc As DataTable()
    Public m_intOldFormulaCode As Integer()

    Dim m_objBatchResultInfo As clsBatchResultInfo

#End Region

#Region "Properties"
    Public Property ShiftCode As Integer
        Get
            Return Me.m_intShiftCode
        End Get
        Set(ByVal value As Integer)
            Me.m_intShiftCode = value
        End Set
    End Property

    Public ReadOnly Property ArrayBatchComm As ArrayList
        Get
            Return m_arrBatch
        End Get
    End Property
#End Region

#Region "Constructor AND Destructor"
    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        m_objBatchResultInfo = New clsBatchResultInfo
    End Sub
#End Region

#Region "Events"

    Private Sub frmBatchResult_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim intCount As Integer = 0
        Dim strLineName1 As String
        Dim strLineName2 As String

        CtrlPlcStatus1.BatchNo = 0
        CtrlPlcStatus1.BatchOilNo = 0
        CtrlPlcStatus1.ManualBatchNo = 0
        CtrlPlcStatus1.ManualBatchOilNo = 0
        CtrlPlcStatus1.FormulaCode = -1
        CtrlPlcStatus2.BatchNo = 0
        CtrlPlcStatus2.BatchOilNo = 0
        CtrlPlcStatus2.ManualBatchNo = 0
        CtrlPlcStatus2.ManualBatchOilNo = 0
        CtrlPlcStatus2.FormulaCode = -1
        Try
            'Disable all tool
            Me.DisableAllTool()
            m_bFinishLoad = False

            'open login dialog
            Dim frm As frmLogin
            frm = New frmLogin
            frm.ShowDialog()

            'check pass
            If frm.m_bLoginPass Then
                'set priority
                m_strRoleId = frm.m_strRoleId
                If m_strRoleId = "ADM" Then
                    btnShiftMenu.Enabled = True
                Else
                    btnShiftMenu.Enabled = False
                End If
                'enable all tool
                Me.EnableAllTool()

                CtrlPlcStatus1.LineNo = 1
                CtrlPlcStatus2.LineNo = 2

                'get current date/time for display 
                lblDate.Text = DateValue(Now)
                lblTime.Text = TimeValue(Now)

                'write log
                DgLog.Rows().Clear()
                clsLog.AddLog(clsLog.eWriteLog.OpenForm)

                m_dtLineNo = clsLineInfo.FindAll

                'CheckShiftTime(Now().Hour, Now().Minute)
                m_bFinishLoad = True

                m_frmGraphic = New frmGraphic(m_strRoleId)


                intCount = clsRMInfo.Count(1)
                ReDim m_dblOldMaterialWeight(0 To intCount - 1)
                ReDim m_bChkCompleted(0 To intCount - 1)
                For i As Integer = 0 To intCount - 1
                    m_dblOldMaterialWeight(i) = 0
                    m_bChkCompleted(i) = False
                Next

                intCount = clsRMInfo.Count(2)
                ReDim m_dblOldMaterialLiquid(0 To intCount - 1)
                For i As Integer = 0 To intCount - 1
                    m_dblOldMaterialLiquid(i) = 0
                Next

                intCount = clsLineInfo.Count
                ReDim m_intOldFormulaCode(0 To intCount - 1)
                ReDim m_dtPlc(0 To intCount - 1)
                For i As Integer = 0 To intCount - 1
                    m_intOldFormulaCode(i) = 0
                    m_dtPlc(i) = Nothing
                Next
                
                strLineName1 = clsLineInfo.FindLineCode(1)
                strLineName2 = clsLineInfo.FindLineCode(2)
                CtrlPlcStatus1.LineName = strLineName1
                CtrlPlcStatus2.LineName = strLineName2
                
                btnGraphicLineB1.Text = "GRAPHICLINE " & strLineName1
                btnGraphicLineB2.Text = "GRAPHICLINE " & strLineName2
                btnReportB1.Text = strLineName1 & vbCrLf & "รายงาน"
                btnReportB2.Text = strLineName2 & vbCrLf & "รายงาน"
                btnFormulaB1.Text = strLineName1 & vbCrLf & "สูตร"
                btnFormulaB2.Text = strLineName2 & vbCrLf & "สูตร"
                'Control.CheckForIllegalCrossThreadCalls = False
                ''''''''''''''SAMPLE''''''''''''''
                m_arrBatch = New ArrayList
                Dim dtObjLine As DataTable = clsLineInfo.FindAll()
                Dim objBatch As clsBatchComm
                For i As Integer = 0 To 1
                    objBatch = New clsBatchComm(dtObjLine.Rows(i), Me)
                    objBatch.WorkerSupportsCancellation = True
                    objBatch.WorkerReportsProgress = True
                    m_arrBatch.Add(objBatch)
                    AddHandler objBatch.ProgressChanged, AddressOf ProgressChanged
                    objBatch.ShiftCode = m_intShiftCode
                    objBatch.RunWorkerAsync()
                Next
                'Dim obj As clsBatchComm = DirectCast(m_arrBatch(0), clsBatchComm)
                ''''''''''''''''''''''''''''''''''

            Else
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("frmBatchResult_Load :" & ex.ToString)
        End Try
    End Sub

    Private Sub frmBatchResult_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Try
            clsLog.AddLog(clsLog.eWriteLog.CloseForm)
        Catch ex As Exception
            MessageBox.Show("btnExit_Click :" & ex.ToString)
        End Try
    End Sub
    Private Sub tmr1Sec_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmr1Sec.Tick
        Try
            If m_bFinishLoad Then
                'set current date/time
                lblDate.Text = DateValue(Now)
                lblTime.Text = TimeValue(Now)

                'If Now().Second = 0 Then
                '    Dim intHour As Integer = Now().Hour
                '    Dim intMin As Integer = Now().Minute

                '    Dim obj As clsBatchComm
                '    Dim bAllStop As Boolean = True
                '    For i As Integer = 0 To 1
                '        obj = DirectCast(m_arrBatch(i), clsBatchComm)
                '        bAllStop = bAllStop And Not obj.BatchStarted
                '    Next

                '    CheckReportTime(intHour, intMin)
                '    If bAllStop Then
                '        CheckShiftTime(intHour, intMin)
                '    End If
                'End If
            End If
        Catch ex As Exception
            MessageBox.Show("tmr1Sec_Tick :" & ex.ToString)
            m_objLogger.AppendLog(ex)
        End Try
    End Sub
    Private Sub btnGraphicLineB1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGraphicLineB1.Click
        OpenGraphic(1)
    End Sub

    Private Sub btnGraphicLineB2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGraphicLineB2.Click
        OpenGraphic(2)
    End Sub
    Private Sub btnReportB1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReportB1.Click
        OpenReport(1, frmBatchList.eRmType.Weight)
    End Sub

    Private Sub btnReportB2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReportB2.Click
        OpenReport(2, frmBatchList.eRmType.Weight)
    End Sub

    Private Sub btnFormulaB1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFormulaB1.Click
        OpenFormulaDesign(1)
    End Sub

    Private Sub btnFormulaB2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFormulaB2.Click
        OpenFormulaDesign(2)
    End Sub

    Private Sub btnShiftMenu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnShiftMenu.Click
        OpenShiftSetting()
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Try
            If MsgBox("Are you sure to exit program?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                clsLog.AddLog(clsLog.eWriteLog.CloseForm)
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("btnExit_Click :" & ex.ToString)
        End Try
    End Sub
#End Region

#Region "Private Function"
    Private Sub ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs)

        Dim objBatchComm As clsBatchComm = DirectCast(sender, clsBatchComm)
        Dim objPlcStatus As ctrlPlcStatus
        Dim objPlcStatusLight As CtrlPlcStatusLight
        Dim dt As DataTable
        Dim dblMaterialWeight(clsRMInfo.Count(1) - 1) As Double
        Dim dblActual As Double
        Dim dblDiff As Double
        Dim dblFinal As Double
        Dim dblMaterialLiquid(clsRMInfo.Count(2) - 1) As Double
        Dim bMaterialChange As Boolean = False
        Dim bMaterialCompleted As Boolean = False
        Dim objLogger As clsLogger

        If objBatchComm.LineNo = 1 Then
            objPlcStatus = Me.CtrlPlcStatus1
            objPlcStatusLight = Me.CtrlPlcStatusLight1
            objLogger = m_objLoggerL1
        Else ' objBatchComm.LineNo = 2 Then
            objPlcStatus = Me.CtrlPlcStatus2
            objPlcStatusLight = Me.CtrlPlcStatusLight2
            objLogger = m_objLoggerL2
        End If
        Try
            objPlcStatus.BatchNo = objBatchComm.BatchNo
            objPlcStatus.BatchOilNo = objBatchComm.BatchOilNo

            ''Manual Batch No
            'If objPlcStatus.ManualBatchNo > 0 And Not objBatchComm.BatchStarted Then
            '    objBatchComm.ManualBatch = objPlcStatus.ManualBatchNo
            '    objPlcStatus.BatchNo = objPlcStatus.ManualBatchNo
            '    objPlcStatus.ManualBatchNo = 0
            '    'LoadDataTableToPlc()
            'ElseIf objBatchComm.ManualBatch = 0 Then
            '    objPlcStatus.BatchNo = objBatchComm.BatchNo
            'End If

            ''Manual Batch Oil No.
            'If objPlcStatus.ManualBatchOilNo > 0 And Not objBatchComm.BatchStarted Then
            '    objBatchComm.ManualBatchOil = objPlcStatus.ManualBatchOilNo
            '    objPlcStatus.BatchOilNo = objPlcStatus.ManualBatchOilNo
            '    objPlcStatus.ManualBatchOilNo = 0
            '    ' LoadDataTableToPlc()
            'ElseIf objBatchComm.ManualBatchOil = 0 Then
            '    objPlcStatus.BatchOilNo = objBatchComm.BatchOilNo
            'End If

            objPlcStatus.FormulaCode = objBatchComm.FormulaNoRequest
            If objPlcStatus.FormulaCode > 0 Then
                If m_intOldFormulaCode(objPlcStatus.LineNo - 1) <> objPlcStatus.FormulaCode Then
                    m_intOldFormulaCode(objPlcStatus.LineNo - 1) = objPlcStatus.FormulaCode
                    LoadDataTableToPlc()
                End If
            End If

            If m_frmGraphic.m_intLineNo = objBatchComm.LineNo Then
                m_frmGraphic.CoffeeMotor = objBatchComm.MotorCoffeeStatus
                m_frmGraphic.CreamMotor = objBatchComm.MotorCreamStatus
                m_frmGraphic.SugarMotor = objBatchComm.MotorSugarStatus

                m_frmGraphic.Coffee = objBatchComm.CoffeeActual
                m_frmGraphic.Cream = objBatchComm.CreamActual
                m_frmGraphic.Sugar = objBatchComm.SugarActual
                'ElseIf m_frmGraphic.m_intLineNo > -1 Then
                '    m_frmGraphic.Coffee = 0
                '    m_frmGraphic.Cream = 0
                '    m_frmGraphic.Sugar = 0
            End If

            If e.ProgressPercentage = clsBatchComm.REPORT_PROGRESS_INITIAL_COMPLETE Then
                objBatchComm.ShiftCode = m_intShiftCode
                SetDiffColumnEnableColor(objPlcStatus.LineNo, False)
                'LoadDataTableToPlc()
            ElseIf e.ProgressPercentage = clsBatchComm.REPORT_PROGRESS_BATCH_STARTED _
                And objPlcStatus.BatchNo > 0 _
                And objBatchComm.ActiveFormula IsNot Nothing Then
                'And Not clsFormulaDetailInfo.FindActive(objPlcStatus.FormulaCode, objBatchComm.LineNo) Is Nothing Then

                For i As Integer = 1 To objPlcStatus.DGData.Rows.Count
                    If m_dtPlc(objPlcStatus.LineNo - 1).Rows(i - 1).Item(m_intColRMNo) = 1 Then
                        dblActual = objBatchComm.CoffeeActual
                    ElseIf m_dtPlc(objPlcStatus.LineNo - 1).Rows(i - 1).Item(m_intColRMNo) = 2 Then
                        dblActual = objBatchComm.CreamActual
                    ElseIf m_dtPlc(objPlcStatus.LineNo - 1).Rows(i - 1).Item(m_intColRMNo) = 3 Then
                        dblActual = objBatchComm.SugarActual
                    ElseIf m_dtPlc(objPlcStatus.LineNo - 1).Rows(i - 1).Item(m_intColRMNo) = 4 Then
                        dblActual = objBatchComm.OilActual
                    End If
                    objPlcStatus.DGData.Rows(i - 1).Cells(m_intColActual).Value = dblActual
                    'objPlcStatus.DGData.Rows(i - 1).Cells(m_intColActual).Style.ForeColor = Color.White
                    dblFinal = CDbl(objPlcStatus.DGData.Rows(i - 1).Cells(m_intColActual - 2).Value)
                    dblDiff = (dblActual - dblFinal)
                    'objPlcStatus.DGData.Rows(i - 1).Cells(m_intColActual + 1).Value = dblDiff.ToString("F2", culInfo)
                    objPlcStatus.DGData.Rows(i - 1).Cells(m_intColActual + 1).Value = dblDiff
                    objPlcStatus.DGData.Rows(i - 1).Cells(m_intColActual + 1).Style.ForeColor = Color.Red
                Next

                'BATCH_NO
                dt = objBatchComm.ActiveFormula
                If Not dt Is Nothing And dt.Rows.Count > 0 Then
                    For i As Integer = 1 To objPlcStatus.DGData.Rows.Count
                        SetColorCompleteRunning(objPlcStatus.LineNo, i - 1, objBatchComm.TankCompleted(i - 1))
                    Next
                End If

                'If m_frmGraphic.m_intLineNo = objBatchComm.LineNo Then
                '    m_frmGraphic.CoffeeMotor = objBatchComm.MotorCoffeeStatus
                '    m_frmGraphic.CreamMotor = objBatchComm.MotorCreamStatus
                '    m_frmGraphic.SugarMotor = objBatchComm.MotorSugarStatus

                '    m_frmGraphic.Coffee = objBatchComm.CoffeeActual
                '    m_frmGraphic.Cream = objBatchComm.CreamActual
                '    m_frmGraphic.Sugar = objBatchComm.SugarActual
                'ElseIf m_frmGraphic.m_intLineNo > -1 Then
                '    m_frmGraphic.Coffee = 0
                '    m_frmGraphic.Cream = 0
                '    m_frmGraphic.Sugar = 0
                'End If
                m_dblOldMaterialLiquid = dblMaterialLiquid
                m_dblOldMaterialWeight = dblMaterialWeight

            ElseIf e.ProgressPercentage = clsBatchComm.REPORT_PROGRESS_BATCH_COMPLETED Then
                'TODO
                clsRevisionInfo.SetNextRevision(objPlcStatus.FormulaCode, objBatchComm.LineNo)
                m_bChkCompleted = {False}
                LoadDataTableToPlc()
            ElseIf e.ProgressPercentage = clsBatchComm.REPORT_PROGRESS_PLC_DISCONNECT Then
                clsLog.AddLog(clsLog.eWriteLog.PLCDisconnect)
            ElseIf e.ProgressPercentage = clsBatchComm.REPORT_PROGRESS_EXCEPTION Then
                clsLog.AddLog(clsLog.eWriteLog.PLCError)
            End If

            objPlcStatusLight.RunReturn = objBatchComm.RunReturn
            objPlcStatusLight.RM1Complete = objBatchComm.IsCoffeeCompleted
            objPlcStatusLight.RM2Complete = objBatchComm.IsCreamCompleted
            objPlcStatusLight.RM3Complete = objBatchComm.IsSugarCompleted
            objPlcStatusLight.RM4Complete = objBatchComm.IsOilCompleted
            objPlcStatusLight.EndProcess = objBatchComm.EndProcess
            objPlcStatusLight.RM1Discharge = objBatchComm.RM1Discharge
            objPlcStatusLight.RM2Discharge = objBatchComm.RM2Discharge
            objPlcStatusLight.RM3Discharge = objBatchComm.RM3Discharge
            objPlcStatusLight.RM4Discharge = objBatchComm.RM4Discharge
            'TODO objPlcStatusLight.RM4Discharge = objBatchComm.RM4Discharge
        Catch ex As Exception
            objLogger.AppendLog(ex)
        End Try
    End Sub

    Private Sub DisableAllTool()
        Me.CtrlPlcStatus1.Enabled = False
        Me.CtrlPlcStatus2.Enabled = False
        Me.CtrlPlcStatusLight1.Enabled = False
        Me.CtrlPlcStatusLight2.Enabled = False
        Me.btnFormulaB1.Enabled = False
        Me.btnFormulaB2.Enabled = False
        Me.btnGraphicLineB1.Enabled = False
        Me.btnGraphicLineB2.Enabled = False
        Me.btnReportB1.Enabled = False
        Me.btnReportB2.Enabled = False
        Me.btnExit.Enabled = False
        Me.btnShiftMenu.Enabled = False
    End Sub

    Private Sub EnableAllTool()
        Me.CtrlPlcStatus1.Enabled = True
        Me.CtrlPlcStatus2.Enabled = True
        Me.CtrlPlcStatusLight1.Enabled = True
        Me.CtrlPlcStatusLight2.Enabled = True
        Me.btnFormulaB1.Enabled = True
        Me.btnFormulaB2.Enabled = True
        Me.btnGraphicLineB1.Enabled = True
        Me.btnGraphicLineB2.Enabled = True
        Me.btnReportB1.Enabled = True
        Me.btnReportB2.Enabled = True
        Me.btnExit.Enabled = True
    End Sub

    Private Sub OpenShiftSetting()
        Dim frm As frmShift
        Dim intFormulaId As Integer = -1
        Try
            If m_strRoleId = "ADM" Then
                frm = New frmShift()
                frm.ShowDialog()
                CheckShiftTime(Now().Hour, Now().Minute)
            End If
        Catch ex As Exception
            MessageBox.Show("OpenShiftSetting :" & ex.ToString)
        End Try
    End Sub
    Private Sub OpenGraphic(ByVal intCtrlLineNo As Integer)
        Dim intFormulaId As Integer = -1
        Try
            If intCtrlLineNo = 1 Then
                intFormulaId = CtrlPlcStatus1.FormulaCode
            ElseIf intCtrlLineNo = 2 Then
                intFormulaId = CtrlPlcStatus2.FormulaCode
            End If

            m_frmGraphic.CoffeeMotor = False
            m_frmGraphic.CreamMotor = False
            m_frmGraphic.SugarMotor = False
            'm_frmGraphic.m_intLineNo = -1


            m_frmGraphic.m_intFormulaId = intFormulaId
            m_frmGraphic.m_intLineNo = intCtrlLineNo
            m_frmGraphic.Show(Me)

            Me.btnGraphicLineB1.Enabled = False
            Me.btnGraphicLineB2.Enabled = False
            'm_frmGraphic.ShowDialog()
            'm_frmGraphic.CoffeeMotor = False
            'm_frmGraphic.CreamMotor = False
            'm_frmGraphic.SugarMotor = False
            'm_frmGraphic.m_intLineNo = -1
        Catch ex As Exception
            MessageBox.Show("OpenGraphic :" & ex.ToString)
        End Try
    End Sub
    Private Sub OpenReport(ByVal intCtrlLineNo As Integer, ByVal nRmType As frmBatchList.eRmType)
        Dim frm As frmBatchList
        Try
            frm = New frmBatchList(m_strRoleId, intCtrlLineNo, nRmType)
            frm.LineNo = intCtrlLineNo
            'frm.ShowDialog()
            frm.Show(Me)
            Me.btnReportB1.Enabled = False
            Me.btnReportB2.Enabled = False
        Catch ex As Exception
            MessageBox.Show("OpenReport :" & ex.ToString)
        End Try
    End Sub
    Private Sub OpenFormulaDesign(ByVal intCtrlLineNo As Integer)
        Dim frm As frmFormulaDesign
        Dim frmLogin As frmLogin
        Dim intFormulaId As Integer = -1
        Try
            'need to login before edit formula design
            frmLogin = New frmLogin
            frmLogin.ShowDialog()
            If frmLogin.m_bLoginPass Then
                If intCtrlLineNo = 1 Then
                    intFormulaId = CtrlPlcStatus1.FormulaCode
                ElseIf intCtrlLineNo = 2 Then
                    intFormulaId = CtrlPlcStatus2.FormulaCode
                End If
                frm = New frmFormulaDesign(frmLogin.m_strRoleId, intFormulaId, Me)
                frm.m_intLineNo = intCtrlLineNo

                'frm.ShowDialog()
                frm.Show()
                Me.btnFormulaB1.Enabled = False
                Me.btnFormulaB2.Enabled = False
                'If intCtrlLineNo = 1 Then
                '    Me.btnFormulaB1.Enabled = False
                'ElseIf intCtrlLineNo = 2 Then
                '    Me.btnFormulaB2.Enabled = False
                'End If
                'LoadDataTableToPlc()
            End If
        Catch ex As Exception
            MessageBox.Show("OpenFormulaDesign :" & ex.ToString)
        End Try
    End Sub
    Public Sub LoadDataTableToPlc()
        Dim iCol As Integer = 0
        Dim iRow As Integer = 0
        Dim sSqlCmd1 As String
        Dim sSqlCmd2 As String
        Try
            'load data from plc:LINE1
            sSqlCmd1 = "SELECT * FROM " & m_strViewFormulaRunning & _
                                                " WHERE FORMULA_CODE = " & CtrlPlcStatus1.FormulaCode & _
                                                " AND LINE_NO = " & CtrlPlcStatus1.LineNo

            m_dtPlc(0) = clsAdoxCached.GetDataTable(sSqlCmd1)
            If Not m_dtPlc(0) Is Nothing AndAlso m_dtPlc(0).Rows.Count > 0 Then
                'clear all rows
                CtrlPlcStatus1.DGData.Rows.Clear()
                'Add all rows needed
                CtrlPlcStatus1.DGData.Rows.Add(m_dtPlc(0).Rows.Count - 1)

                'input all data into the cell
                For iRow = 0 To m_dtPlc(0).Rows.Count - 1
                    For iCol = 0 To m_intColCount - 1
                        CtrlPlcStatus1.DGData.Item(iCol, iRow).Value = m_dtPlc(0).Rows(iRow).Item(iCol)
                    Next
                Next
                'CtrlPlcStatus1.DGData.DataSource = m_dtPlc(0)
            End If

            'load data from plc:LINE2
            sSqlCmd2 = "SELECT * FROM " & m_strViewFormulaRunning & _
                                                " WHERE FORMULA_CODE = " & CtrlPlcStatus2.FormulaCode & _
                                                " AND LINE_NO = " & CtrlPlcStatus2.LineNo
            m_dtPlc(1) = clsAdoxCached.GetDataTable(sSqlCmd2)
            If Not m_dtPlc(1) Is Nothing AndAlso m_dtPlc(1).Rows.Count > 0 Then
                'clear all rows
                CtrlPlcStatus2.DGData.Rows.Clear()
                'Add all rows needed
                CtrlPlcStatus2.DGData.Rows.Add(m_dtPlc(1).Rows.Count - 1)

                'input all data into the cell
                For iRow = 0 To m_dtPlc(1).Rows.Count - 1
                    For iCol = 0 To m_intColCount - 1
                        CtrlPlcStatus2.DGData.Item(iCol, iRow).Value = m_dtPlc(1).Rows(iRow).Item(iCol)
                    Next
                Next
                'CtrlPlcStatus2.DGData.DataSource = m_dtPlc(1)
            End If

        Catch ex As Exception
            m_objLogger.AppendLog(ex)
        End Try
    End Sub
    Public Sub SetDiffColumnEnableColor(ByVal intLineNo As Integer, ByVal bRunning As Boolean)
        If intLineNo = 1 Then
            For intRow = 0 To CtrlPlcStatus1.DGData.RowCount - 1
                If bRunning Then
                    CtrlPlcStatus1.DGData.Item(m_intColDiff, intRow).Style.ForeColor = Color.White
                Else
                    CtrlPlcStatus1.DGData.Item(m_intColDiff, intRow).Style.ForeColor = Color.Gray
                End If
            Next
        ElseIf intLineNo = 2 Then
            For intRow = 0 To CtrlPlcStatus2.DGData.RowCount - 1
                If bRunning Then
                    CtrlPlcStatus2.DGData.Item(m_intColDiff, intRow).Style.ForeColor = Color.White
                Else
                    CtrlPlcStatus2.DGData.Item(m_intColDiff, intRow).Style.ForeColor = Color.Gray
                End If
            Next
        End If
    End Sub
    Public Sub SetCompleteRunning(ByVal intLineNo As Integer, ByVal intRow As Integer, ByVal dblValue As Double)
        If intLineNo = 1 And intRow >= 0 Then
            CtrlPlcStatus1.DGData.Item(m_intColActual, intRow).Value = dblValue
        ElseIf intLineNo = 2 And intRow >= 0 Then
            CtrlPlcStatus2.DGData.Item(m_intColActual, intRow).Value = dblValue
        End If
        SetColorCompleteRunning(intLineNo, intRow)
    End Sub
    Private Sub SetColorCompleteRunning(ByVal intLineNo As Integer, ByVal intRow As Integer, Optional ByVal bComplete As Boolean = True)
        Try
            If intLineNo = 1 Then
                ''set all cell back to original color
                'CtrlPlcStatus1.DGData.ForeColor = Color.Black
                'set current running to be an active color
                If intRow = -1 Then
                    'Do nothing
                ElseIf intRow < CtrlPlcStatus1.DGData.RowCount And m_intColActual < CtrlPlcStatus1.DGData.ColumnCount And bComplete Then
                    CtrlPlcStatus1.DGData.Item(m_intColActual, intRow).Style.ForeColor = Color.Lime
                ElseIf intRow < CtrlPlcStatus1.DGData.RowCount And m_intColActual < CtrlPlcStatus1.DGData.ColumnCount And Not bComplete Then
                    CtrlPlcStatus1.DGData.Item(m_intColActual, intRow).Style.ForeColor = Color.White
                End If
            ElseIf intLineNo = 2 Then
                ''set all cell back to original color
                'CtrlPlcStatus2.DGData.ForeColor = Color.Black
                'set current running to be an active color
                If intRow = -1 Then
                    'Do nothing
                ElseIf intRow < CtrlPlcStatus2.DGData.RowCount And m_intColActual < CtrlPlcStatus2.DGData.ColumnCount And bComplete Then
                    CtrlPlcStatus2.DGData.Item(m_intColActual, intRow).Style.ForeColor = Color.Lime
                ElseIf intRow < CtrlPlcStatus2.DGData.RowCount And m_intColActual < CtrlPlcStatus2.DGData.ColumnCount And Not bComplete Then
                    CtrlPlcStatus2.DGData.Item(m_intColActual, intRow).Style.ForeColor = Color.White
                End If
            End If
        Catch ex As Exception
            'MessageBox.Show("SetColorCurrentRunning :" & ex.ToString)
            If intLineNo = 1 Then
                m_objLoggerL1.AppendLog(ex)
            ElseIf intLineNo = 2 Then
                m_objLoggerL2.AppendLog(ex)
            Else
                m_objLogger.AppendLog(ex)
            End If
        End Try
    End Sub
    'Private Sub CheckReportTime(ByVal intHour As Integer, ByVal intMin As Integer)
    '    'check if it's pdf report print/save time
    '    If intHour = My.Settings.g_dtCreatePDFTime.Hours And intMin = My.Settings.g_dtCreatePDFTime.Minutes Then
    '        Dim i As Integer
    '        If Not m_dtLineNo Is Nothing Then
    '            If m_dtLineNo.Rows.Count > 0 Then
    '                For i = 0 To m_dtLineNo.Rows.Count - 1
    '                    clsCrReport.CreateReport(DateValue(Now), DateValue(Now), m_dtLineNo.Rows(i).Item("LINE_NO"), False, False)
    '                Next
    '            End If
    '        End If
    '    End If
    'End Sub
    Private Sub CheckShiftTime(ByVal intHour As Integer, ByVal intMin As Integer)
        Dim intShiftRow As Integer = 0
        Dim dtShift As DataTable = clsShiftInfo.FindAll
        Dim tmShiftStart As TimeSpan
        Dim tmShiftEnd As TimeSpan
        Dim tmCurrent As TimeSpan
        If Not dtShift Is Nothing Then
            For intShiftRow = 0 To dtShift.Rows.Count - 1
                tmShiftStart = GetTimeSpan(dtShift.Rows(intShiftRow).Item("TIME_START_HR"), _
                                           dtShift.Rows(intShiftRow).Item("TIME_START_MIN"))
                tmShiftEnd = GetTimeSpan(dtShift.Rows(intShiftRow).Item("TIME_END_HR"), _
                                           dtShift.Rows(intShiftRow).Item("TIME_END_MIN"))
                tmCurrent = GetTimeSpan(intHour, intMin)
                If (tmShiftStart <= tmShiftEnd And tmShiftStart <= tmCurrent And tmShiftEnd >= tmCurrent) _
                    Or (tmShiftStart > tmShiftEnd And (tmCurrent >= tmShiftStart Or tmCurrent <= tmShiftEnd)) Then
                    m_intShiftCode = dtShift.Rows(intShiftRow).Item("SHIFT_CODE")

                    If lblShift.Text <> clsShiftInfo.FindShiftName(m_intShiftCode) Then
                        lblShift.Text = clsShiftInfo.FindShiftName(m_intShiftCode)
                        clsLog.AddLog(clsLog.eWriteLog.ShiftChange, lblShift.Text)
                        Exit For
                    End If
                End If
            Next
        End If
    End Sub
    Private Function GetTimeSpan(ByVal intHour As Integer, ByVal intMin As Integer) As TimeSpan
        GetTimeSpan = TimeSpan.Parse(intHour & ":" & intMin)
    End Function
#End Region

#Region "Public Function"

#End Region

    Private Sub CtrlPlcStatus2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CtrlPlcStatus2.Load

    End Sub
End Class
