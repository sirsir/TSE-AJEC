Public Class clsBatchComm
    Inherits System.ComponentModel.BackgroundWorker
#Region "Const Variable"
    Private Const FORMULA_NO As Integer = 1
    Private Const FORMULA_SEND_COMPLETED As Integer = 2

    Private Const RM_NAME As Integer = 1
    Private Const RM_LOT As Integer = 6
    Private Const MAX_VALUE As Integer = 20
    Private Const MIN_VALUE As Integer = 22
    Private Const FINAL_VALUE As Integer = 24
    Private Const SP1_VALUE As Integer = 26
    Private Const SP2_VALUE As Integer = 28
    Private Const CPS_VALUE As Integer = 30
    Private Const HZ_H As Integer = 32
    Private Const HZ_M As Integer = 34
    Private Const HZ_L As Integer = 36
    Private Const CRUSHER As Integer = 38


    Private Const AUTO_MANAUL As Integer = 0
    Private Const FORMULA_NO_REQUEST As Integer = 1
    Private Const BATCH_NO As Integer = 2
    Private Const BATCH_OIL_NO As Integer = 3
    Private Const PLAN As Integer = 4
    Private Const COFFEE_ACTUAL As Integer = 6
    Private Const CREAM_ACTUAL As Integer = 8
    Private Const SUGAR_ACTUAL As Integer = 10
    Private Const OIL_ACTUAL As Integer = 12
    Private Const RUN_RETURN As Integer = 14
    Private Const END_PROCESS As Integer = 15
    Private Const COFFEE_COMPLETED As Integer = 16
    Private Const CREAM_COMPLETED As Integer = 17
    Private Const SUGAR_COMPLETED As Integer = 18
    Private Const OIL_COMPLETED As Integer = 19
    Private Const RM1_DISCHARGE As Integer = 20
    Private Const RM2_DISCHARGE As Integer = 21
    Private Const RM3_DISCHARGE As Integer = 22
    Private Const RM4_DISCHARGE As Integer = 23
    Private Const MOTOR_COFFEE_STATUS As Integer = 24
    Private Const MOTOR_CREAM_STATUS As Integer = 25
    Private Const MOTOR_SUGAR_STATUS As Integer = 26
    Private Const READ_COUNT As Integer = 27

    Public Const REPORT_PROGRESS_INITIAL_COMPLETE = 0
    Public Const REPORT_PROGRESS_BATCH_STARTED = 1
    Public Const REPORT_PROGRESS_BATCH_COMPLETED = 50
    Public Const REPORT_PROGRESS_PLC_DISCONNECT = 99
    Public Const REPORT_PROGRESS_EXCEPTION = 100
#End Region
#Region "Attributes"
    'Private m_frmMain As frmBatchResult
    Private m_clsPlcWrapper As clsPlcWrapper
    Private m_intAddressWriteLifeCheck As Integer
    Private m_intAddressWriteFormulaSend As Integer
    Private m_intAddressReadFormulaRequest As Integer

    Private m_intLineNo As Integer

    Private m_intRMWeightCount As Integer
    Private m_intRMLiquidCount As Integer
    Private m_intFormulaNoSend As Integer
    Private m_intRevisionId As Integer

    Private m_intFormulaNo As Integer

    Private m_intFormulaToSend As Integer
    Private m_intFormulaToSendComplete As Integer
    Private m_intFormulaToSendClear As Integer

    Private m_bFormulaSendComplete As Boolean
    Private m_bTankSelected As Boolean()
    Private m_bTankCompleted As Boolean()
    Private m_strRMName As String()
    Private m_strRMLot As String()
    Private m_intMax As Double()
    Private m_intMin As Double()
    Private m_intFinal As Double()
    Private m_intSP1 As Double()
    Private m_intSP2 As Double()
    Private m_intCPS As Double()

    Private m_bManual As Boolean
    Private m_intFormulaNoRequest As Integer
    Private m_intReadFormulaNoRequest As Integer
    Private m_intBatchNo As Integer
    Private m_intReadBatchNo As Integer
    Private m_intShiftCode As Integer
    Private m_intBatchOilNo As Integer
    Private m_intReadBatchOilNo As Integer
    Private m_intPlanNo As Integer
    Private m_dblCoffeeActual As Double
    Private m_dblCreamActual As Double
    Private m_dblSugarActual As Double
    Private m_dblOilActual As Double
    Private m_dblReadCoffeeActual As Double
    Private m_dblReadCreamActual As Double
    Private m_dblReadSugarActual As Double
    Private m_dblReadOilActual As Double
    Private m_bRunReturn As Boolean
    Private m_intEndProcess As Integer
    Private m_bCoffeeCompleted As Boolean
    Private m_bCreamCompleted As Boolean
    Private m_bSugarCompleted As Boolean
    Private m_bOilCompleted As Boolean
    Private m_bAllSelectedRMCompleted As Boolean
    Private m_bRM1Discharge As Boolean
    Private m_bRM2Discharge As Boolean
    Private m_bRM3Discharge As Boolean
    Private m_bRM4Discharge As Boolean
    Private m_bMotorCoffeeStatus As Boolean
    Private m_bMotorCreamStatus As Boolean
    Private m_bMotorSugarStatus As Boolean

    Private m_intCoffeeCompleted As Integer
    Private m_intCreamCompleted As Integer
    Private m_intSugarCompleted As Integer
    Private m_intOilCompleted As Integer
    'Private m_intRM1Discharge As Integer
    'Private m_intRM2Discharge As Integer
    'Private m_intRM3Discharge As Integer
    'Private m_intRM4Discharge As Integer
    'Private m_intMotorCoffeeStatus As Integer
    'Private m_intMotorCreamStatus As Integer
    'Private m_intMotorSugarStatus As Integer

    Private m_intOldFormulaNoRequest As Integer
    Private m_intOldBatchNo As Integer
    Private m_intOldBatchOilNo As Integer
    Private m_intOldPlanNo As Integer
    Private m_dblOldCoffeeActual As Double
    Private m_dblOldCreamActual As Double
    Private m_dblOldSugarActual As Double
    Private m_dblOldOilActual As Double
    Private m_bOldRunReturn As Boolean
    Private m_bOldRMCompleted As Boolean
    Private m_intOldEndProcess As Integer
    Private m_bOldCoffeeCompleted As Boolean
    Private m_bOldCreamCompleted As Boolean
    Private m_bOldSugarCompleted As Boolean
    Private m_bOldOilCompleted As Boolean
    Private m_bOldRM1Discharge As Boolean
    Private m_bOldRM2Discharge As Boolean
    Private m_bOldRM3Discharge As Boolean
    Private m_bOldRM4Discharge As Boolean
    Private m_bOldMotorCoffeeStatus As Boolean
    Private m_bOldMotorCreamStatus As Boolean
    Private m_bOldMotorSugarStatus As Boolean

    Private m_bPLCConnect As Boolean
    Private m_strLastLog As String

    Private m_bBatchStarted As Boolean
    Private m_intManualBatch As Integer
    Private m_intManualBatchOil As Integer
    Private m_intBatchSeq As Integer
    Private m_datReadWhen As Date

    Private m_dtFormulaDetailCurrentActive As DataTable
    Private m_dtFormulaDetailLastest As DataTable
    Private m_objLogger As clsLogger
    Private m_objBatchResultInfo As clsBatchResultInfo
    Private m_htbRM As Hashtable

    Private m_datBatchStartWhen As DateTime
#End Region

#Region "Property"
    Public Property AddressWriteLifeCheck() As Integer
        Get
            Return Me.m_intAddressWriteLifeCheck
        End Get
        Set(ByVal value As Integer)
            Me.m_intAddressWriteLifeCheck = value
        End Set
    End Property
    Public Property AddressWriteFormulaSend() As Integer
        Get
            Return Me.m_intAddressWriteFormulaSend
        End Get
        Set(ByVal value As Integer)
            Me.m_intAddressWriteFormulaSend = value
        End Set
    End Property
    Public Property AddressReadFormulaRequest() As Integer
        Get
            Return Me.m_intAddressReadFormulaRequest
        End Get
        Set(ByVal value As Integer)
            Me.m_intAddressReadFormulaRequest = value
        End Set
    End Property
    Public ReadOnly Property BatchStarted As Boolean
        Get
            Return Me.m_bBatchStarted
        End Get
    End Property
    Public Property ManualBatch As Integer
        Get
            Return Me.m_intManualBatch
        End Get
        Set(ByVal value As Integer)
            Me.m_intManualBatch = value
        End Set
    End Property
    Public Property ManualBatchOil As Integer
        Get
            Return Me.m_intManualBatchOil
        End Get
        Set(ByVal value As Integer)
            Me.m_intManualBatchOil = value
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
    Public Property RMWeightCount() As Integer
        Get
            Return Me.m_intRMWeightCount
        End Get
        Set(ByVal value As Integer)
            Me.m_intRMWeightCount = value
        End Set
    End Property
    Public Property RMLiquidCount() As Integer
        Get
            Return Me.m_intRMLiquidCount
        End Get
        Set(ByVal value As Integer)
            Me.m_intRMLiquidCount = value
        End Set
    End Property
    Public ReadOnly Property FormulaNoSend() As Integer
        Get
            Return Me.m_intFormulaNoSend
        End Get
    End Property
    Public ReadOnly Property FormulaSendComplete() As Boolean
        Get
            Return Me.m_bFormulaSendComplete
        End Get
    End Property
    Public ReadOnly Property TankCompleted As Boolean()
        Get
            Return m_bTankCompleted
        End Get
    End Property
    Public WriteOnly Property TankSelected(ByVal intTankNo As Integer) As Boolean
        'Get
        '    Return Me.m_bTankSelected(intTankNo - 1)
        'End Get
        Set(ByVal value As Boolean)
            Me.m_bTankSelected(intTankNo - 1) = value
            'm_clsPlcWrapper.WriteMemoryWordIntegerDMBCD0( m_intAddressWriteFormulaSend + (50 * (intTankNo - 1)), value)
        End Set
    End Property
    Public WriteOnly Property ShiftCode As Integer
        Set(ByVal value As Integer)
            m_intShiftCode = value
        End Set
    End Property
    Public Property RMName(ByVal intTankNo As Integer) As String
        Get
            Return Me.m_strRMName(intTankNo - 1)
        End Get
        Set(ByVal value As String)
            Me.m_strRMName(intTankNo - 1) = value
            m_clsPlcWrapper.WriteMemoryWordIntegerDMBCD0(m_intAddressWriteFormulaSend + RM_NAME + (50 * (intTankNo - 1)), value)
            'm_clsPlcWrapper.WriteMemoryWordIntegerDMBIN0(m_intAddressWriteFormulaSend + RM_NAME + (50 * (intTankNo - 1)), value)
        End Set
    End Property
    Public Property RMLot(ByVal intTankNo As Integer) As String
        Get
            Return Me.m_strRMLot(intTankNo - 1)
        End Get
        Set(ByVal value As String)
            Me.m_strRMLot(intTankNo - 1) = value
            m_clsPlcWrapper.WriteMemoryWordIntegerDMBCD0(m_intAddressWriteFormulaSend + RM_LOT + (50 * (intTankNo - 1)), value)
            'm_clsPlcWrapper.WriteMemoryWordIntegerDMBIN0(m_intAddressWriteFormulaSend + RM_LOT + (50 * (intTankNo - 1)), value)
        End Set
    End Property
    Public Property Max(ByVal intTankNo As Integer) As Double
        Get
            Return Me.m_intMax(intTankNo - 1)
        End Get
        Set(ByVal value As Double)
            Me.m_intMax(intTankNo - 1) = value
            m_clsPlcWrapper.WriteMemoryWordIntegerDMBCD0(m_intAddressWriteFormulaSend + MAX_VALUE + (50 * (intTankNo - 1)), value)
            'm_clsPlcWrapper.WriteMemoryWordIntegerDMBIN0(m_intAddressWriteFormulaSend + MAX_VALUE + (50 * (intTankNo - 1)), value)


        End Set
    End Property
    Public Property Min(ByVal intTankNo As Integer) As Double
        Get
            Return Me.m_intMax(intTankNo - 1)
        End Get
        Set(ByVal value As Double)
            Me.m_intMin(intTankNo - 1) = value
            m_clsPlcWrapper.WriteMemoryWordIntegerDMBCD0(m_intAddressWriteFormulaSend + MIN_VALUE + (50 * (intTankNo - 1)), value)
            'm_clsPlcWrapper.WriteMemoryWordIntegerDMBIN0(m_intAddressWriteFormulaSend + MIN_VALUE + (50 * (intTankNo - 1)), value)
        End Set
    End Property
    Public Property Final(ByVal intTankNo As Integer) As Double
        Get
            Return Me.m_intFinal(intTankNo - 1)
        End Get
        Set(ByVal value As Double)
            Me.m_intFinal(intTankNo - 1) = value
            m_clsPlcWrapper.WriteMemoryWordIntegerDMBCD0(m_intAddressWriteFormulaSend + FINAL_VALUE + (50 * (intTankNo - 1)), value)
            'm_clsPlcWrapper.WriteMemoryWordIntegerDMBIN0(m_intAddressWriteFormulaSend + FINAL_VALUE + (50 * (intTankNo - 1)), value)
        End Set
    End Property
    Public Property SP1(ByVal intTankNo As Integer) As Double
        Get
            Return Me.m_intSP1(intTankNo - 1)
        End Get
        Set(ByVal value As Double)
            Me.m_intSP1(intTankNo - 1) = value
            m_clsPlcWrapper.WriteMemoryWordIntegerDMBCD0(m_intAddressWriteFormulaSend + SP1_VALUE + (50 * (intTankNo - 1)), value)
            'm_clsPlcWrapper.WriteMemoryWordIntegerDMBIN0(m_intAddressWriteFormulaSend + SP1_VALUE + (50 * (intTankNo - 1)), value)
        End Set
    End Property
    Public Property SP2(ByVal intTankNo As Integer) As Double
        Get
            Return Me.m_intSP2(intTankNo - 1)
        End Get
        Set(ByVal value As Double)
            Me.m_intSP2(intTankNo - 1) = value
            m_clsPlcWrapper.WriteMemoryWordIntegerDMBCD0(m_intAddressWriteFormulaSend + SP2_VALUE + (50 * (intTankNo - 1)), value)
            'm_clsPlcWrapper.WriteMemoryWordIntegerDMBIN0(m_intAddressWriteFormulaSend + SP2_VALUE + (50 * (intTankNo - 1)), value)
        End Set
    End Property
    Public Property CPS(ByVal intTankNo As Integer) As Double
        Get
            Return Me.m_intCPS(intTankNo - 1)
        End Get
        Set(ByVal value As Double)
            Me.m_intCPS(intTankNo - 1) = value
            m_clsPlcWrapper.WriteMemoryWordIntegerDMBCD0(m_intAddressWriteFormulaSend + CPS_VALUE + (50 * (intTankNo - 1)), value)
            'm_clsPlcWrapper.WriteMemoryWordIntegerDMBIN0(m_intAddressWriteFormulaSend + CPS_VALUE + (50 * (intTankNo - 1)), value)
        End Set
    End Property
    Public Property OldFormulaNoRequest As Integer
        Get
            Return m_intOldFormulaNoRequest
        End Get
        Set(ByVal value As Integer)
            m_intOldFormulaNoRequest = value
        End Set
    End Property
    Public Property OldBatchNo As Integer
        Get
            Return m_intOldBatchNo
        End Get
        Set(ByVal value As Integer)
            m_intOldBatchNo = value
        End Set
    End Property
    Public Property OldBatchOilNo As Integer
        Get
            Return m_intOldBatchOilNo
        End Get
        Set(ByVal value As Integer)
            m_intOldBatchOilNo = value
        End Set
    End Property
    Public Property OldPlanNo As Integer
        Get
            Return m_intOldPlanNo
        End Get
        Set(ByVal value As Integer)
            m_intOldPlanNo = value
        End Set
    End Property
    Public Property OldCoffeeActual As Double
        Get
            Return m_dblOldCoffeeActual
        End Get
        Set(ByVal value As Double)
            m_dblOldCoffeeActual = value
        End Set
    End Property
    Public Property OldCreamActual As Double
        Get
            Return m_dblOldCreamActual
        End Get
        Set(ByVal value As Double)
            m_dblOldCreamActual = value
        End Set
    End Property
    Public Property OldSugarActual As Double
        Get
            Return m_dblOldSugarActual
        End Get
        Set(ByVal value As Double)
            m_dblOldSugarActual = value
        End Set
    End Property
    Public Property OldOilActual As Double
        Get
            Return m_dblOldOilActual
        End Get
        Set(ByVal value As Double)
            m_dblOldOilActual = value
        End Set
    End Property
    Public Property OldRunReturn As Boolean
        Get
            Return m_bOldRunReturn
        End Get
        Set(ByVal value As Boolean)
            m_bOldRunReturn = value
        End Set
    End Property
    Public Property OldRMCompleted As Boolean
        Get
            Return m_bOldRMCompleted
        End Get
        Set(ByVal value As Boolean)
            m_bOldRMCompleted = value
        End Set
    End Property
    Public ReadOnly Property OldEndProcess As Boolean
        Get
            Return IIf(m_intOldEndProcess > 0, True, False)
        End Get
    End Property
    Public Property OldCoffeeCompleted As Boolean
        Get
            Return m_bOldCoffeeCompleted
        End Get
        Set(ByVal value As Boolean)
            m_bOldCoffeeCompleted = value
        End Set
    End Property
    Public Property OldCreamCompleted As Boolean
        Get
            Return m_bOldCreamCompleted
        End Get
        Set(ByVal value As Boolean)
            m_bOldCreamCompleted = value
        End Set
    End Property
    Public Property OldSugarCompleted As Boolean
        Get
            Return m_bOldSugarCompleted
        End Get
        Set(ByVal value As Boolean)
            m_bOldSugarCompleted = value
        End Set
    End Property
    Public Property OldOilCompleted As Boolean
        Get
            Return m_bOldOilCompleted
        End Get
        Set(ByVal value As Boolean)
            m_bOldOilCompleted = value
        End Set
    End Property
    Public Property OldRM1Discharge As Boolean
        Get
            Return m_bOldRM1Discharge
        End Get
        Set(ByVal value As Boolean)
            m_bOldRM1Discharge = value
        End Set
    End Property
    Public Property OldRM2Discharge As Boolean
        Get
            Return m_bOldRM2Discharge
        End Get
        Set(ByVal value As Boolean)
            m_bOldRM2Discharge = value
        End Set
    End Property
    Public Property OldRM3Discharge As Boolean
        Get
            Return m_bOldRM3Discharge
        End Get
        Set(ByVal value As Boolean)
            m_bOldRM3Discharge = value
        End Set
    End Property
    Public Property OldRM4Discharge As Boolean
        Get
            Return m_bOldRM4Discharge
        End Get
        Set(ByVal value As Boolean)
            m_bOldRM3Discharge = value
        End Set
    End Property
    Public Property OldMotorCoffeeStatus As Boolean
        Get
            Return m_bOldMotorCoffeeStatus
        End Get
        Set(ByVal value As Boolean)
            m_bOldMotorCoffeeStatus = value
        End Set
    End Property
    Public Property OldMotorCreamStatus As Boolean
        Get
            Return m_bOldMotorCreamStatus
        End Get
        Set(ByVal value As Boolean)
            m_bOldMotorCreamStatus = value
        End Set
    End Property
    Public Property OldMotorSugarStatus As Boolean
        Get
            Return m_bOldMotorSugarStatus
        End Get
        Set(ByVal value As Boolean)
            m_bOldMotorSugarStatus = value
        End Set
    End Property
    Public Property PLCConnect As Boolean
        Get
            Return m_bPLCConnect
        End Get
        Set(ByVal value As Boolean)
            m_bPLCConnect = value
        End Set
    End Property
    Public Property LastLog As String
        Get
            Return m_strLastLog
        End Get
        Set(ByVal value As String)
            m_strLastLog = value
        End Set
    End Property

    Public Property BatchNo As Integer
        Get
            Return m_intBatchNo
        End Get
        Set(ByVal value As Integer)
            m_intBatchNo = value
        End Set
    End Property
    Public Property BatchOilNo As Integer
        Get
            Return m_intBatchOilNo
        End Get
        Set(ByVal value As Integer)
            m_intBatchOilNo = value
        End Set
    End Property

    Public WriteOnly Property FormulaToSend As Integer
        Set(ByVal value As Integer)
            m_intFormulaToSend = value
        End Set
    End Property
#End Region
#Region "ReadOnly Property"
    Public ReadOnly Property Manual As Boolean
        Get
            Return m_bManual
        End Get
    End Property
    Public ReadOnly Property FormulaNoRequest As Integer
        Get
            Return m_intFormulaNoRequest
        End Get
    End Property
    Public ReadOnly Property PlanNo As Integer
        Get
            Return m_intPlanNo
        End Get
    End Property
    Public ReadOnly Property CoffeeActual As Double
        Get
            Return m_dblCoffeeActual
        End Get
    End Property
    Public ReadOnly Property CreamActual As Double
        Get
            Return m_dblCreamActual
        End Get
    End Property
    Public ReadOnly Property SugarActual As Double
        Get
            Return m_dblSugarActual
        End Get
    End Property
    Public ReadOnly Property OilActual As Double
        Get
            Return m_dblOilActual
        End Get
    End Property
    Public ReadOnly Property RunReturn As Boolean
        Get
            Return m_bRunReturn
        End Get
    End Property
    Public ReadOnly Property EndProcess As Boolean
        Get
            Return IIf(m_intEndProcess > 0, True, False)
        End Get
    End Property
    Public ReadOnly Property IsCoffeeCompleted As Boolean
        Get
            Return m_bCoffeeCompleted
        End Get
    End Property
    Public ReadOnly Property IsCreamCompleted As Boolean
        Get
            Return m_bCreamCompleted
        End Get
    End Property
    Public ReadOnly Property IsSugarCompleted As Boolean
        Get
            Return m_bSugarCompleted
        End Get
    End Property
    Public ReadOnly Property IsOilCompleted As Boolean
        Get
            Return m_bOilCompleted
        End Get
    End Property
    Public ReadOnly Property AllSelectedRMCompleted As Boolean
        Get
            Return m_bAllSelectedRMCompleted
        End Get
    End Property
    Public ReadOnly Property RM1Discharge As Boolean
        Get
            Return m_bRM1Discharge
        End Get
    End Property
    Public ReadOnly Property RM2Discharge As Boolean
        Get
            Return m_bRM2Discharge
        End Get
    End Property
    Public ReadOnly Property RM3Discharge As Boolean
        Get
            Return m_bRM3Discharge
        End Get
    End Property
    Public ReadOnly Property RM4Discharge As Boolean
        Get
            Return m_bRM4Discharge
        End Get
    End Property
    Public ReadOnly Property MotorCoffeeStatus As Boolean
        Get
            Return m_bMotorCoffeeStatus
        End Get
    End Property
    Public ReadOnly Property MotorCreamStatus As Boolean
        Get
            Return m_bMotorCreamStatus
        End Get
    End Property
    Public ReadOnly Property MotorSugarStatus As Boolean
        Get
            Return m_bMotorSugarStatus
        End Get
    End Property
    Public ReadOnly Property ActiveFormula As DataTable
        Get
            Return m_dtFormulaDetailCurrentActive
        End Get
    End Property

#End Region
#Region "Constructor"
    Public Sub New(ByVal dr As DataRow, ByVal frm As frmBatchResult)
        m_clsPlcWrapper = New clsPlcWrapper
        m_clsPlcWrapper.InitializeAndConnect(dr.Item("NET"), _
                                             dr.Item("NODE"), _
                                             dr.Item("UNIT"))
        m_intAddressReadFormulaRequest = dr.Item("ADDRESS_FORMULA_REQUEST")
        m_intAddressWriteLifeCheck = dr.Item("ADDRESS_LIFE_CHECK")
        m_intAddressWriteFormulaSend = dr.Item("ADDRESS_FORMULA_SEND")
        m_intLineNo = dr.Item("LINE_NO")
        RMWeightCount = clsRMInfo.Count(1)
        RMLiquidCount = clsRMInfo.Count(2)
        m_bPLCConnect = False
        m_bBatchStarted = False
        m_objLogger = New clsLogger("Batch" & m_intLineNo)
        m_objBatchResultInfo = New clsBatchResultInfo
        m_htbRM = New Hashtable
        Me.MakeRMHash()
        m_intRevisionId = -1
        m_intShiftCode = -1
        m_intBatchSeq = -1
        m_intFormulaToSend = -1
        m_intFormulaToSendComplete = -1
        m_intFormulaToSendClear = -1
        m_datBatchStartWhen = Date.MinValue

        ReDim m_bTankSelected(RMWeightCount + RMLiquidCount - 1)
        ReDim m_bTankCompleted(RMWeightCount + RMLiquidCount - 1)
        ReDim m_strRMName(RMWeightCount + RMLiquidCount - 1)
        ReDim m_strRMLot(RMWeightCount + RMLiquidCount - 1)
        ReDim m_intMax(RMWeightCount + RMLiquidCount - 1)
        ReDim m_intMin(RMWeightCount + RMLiquidCount - 1)
        ReDim m_intFinal(RMWeightCount + RMLiquidCount - 1)
        ReDim m_intSP1(RMWeightCount + RMLiquidCount - 1)
        ReDim m_intSP2(RMWeightCount + RMLiquidCount - 1)
        ReDim m_intCPS(RMWeightCount + RMLiquidCount - 1)
        For i As Integer = 0 To RMWeightCount + RMLiquidCount - 1
            m_bTankSelected(i) = New Boolean
            m_strRMName(i) = String.Empty
            m_strRMLot(i) = String.Empty
            m_intMax(i) = 0
            m_intMin(i) = 0
            m_intFinal(i) = 0
            m_intSP1(i) = 0
            m_intSP2(i) = 0
            m_intCPS(i) = 0
        Next
    End Sub
#End Region

#Region "Method"
    Private Sub clsBatchComm_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles Me.DoWork
        Dim intTemp As Integer
        Dim bTemp As Boolean
        Dim strMessage As String = String.Empty
        Dim intResult As Integer = -1

        Me.Reset()
        While Not Me.CancellationPending
            Try
                m_clsPlcWrapper.WriteMemoryWordIntegerDMBCD0(m_intAddressWriteLifeCheck, 1)
                'm_clsPlcWrapper.WriteMemoryWordIntegerDMBIN0(m_intAddressWriteLifeCheck, 1)
                PLCConnect = True
                'End If

                If PLCConnect Then
                    Me.ReadMessageFromPLC()
                    m_datReadWhen = Now

                    Me.SendSavedFormula()

                    If Not m_bBatchStarted Then

                        'If m_intManualBatch > 0 Then
                        '    m_intBatchNo = m_intManualBatch
                        '    m_intManualBatch = 0
                        '    SendBatchNo(m_intBatchNo)
                        'End If

                        'If m_intManualBatchOil > 0 Then
                        '    m_intBatchOilNo = m_intManualBatchOil
                        '    m_intManualBatchOil = 0
                        '    SendBatchOilNo(m_intBatchOilNo)
                        'End If
                        m_intFormulaNoRequest = m_intReadFormulaNoRequest
                        Me.ReportProgress(REPORT_PROGRESS_INITIAL_COMPLETE)
                    End If

                    If m_intReadFormulaNoRequest > 0 And Not m_bBatchStarted And (m_intReadBatchNo <> 0 Or m_intReadBatchOilNo <> 0) _
                         And m_bRunReturn And Not EndProcess Then
                        'Me.Reset()
                        'TODO Get New BATCH_SEQ
                        m_intBatchSeq = m_objBatchResultInfo.GetBatchSeqOfFormulaCode(m_intFormulaNoRequest)
                        m_objLogger.AppendLog("GetBatchSeq = " & m_intBatchSeq, clsLogger.enumLogType.eInfo)
                        Me.GetFormula(m_intFormulaNoRequest)
                        m_objLogger.AppendLog("GetFormula = " & m_intFormulaNoRequest, clsLogger.enumLogType.eInfo)
                        m_intBatchNo = m_intReadBatchNo
                        m_intBatchOilNo = m_intReadBatchOilNo
                        m_objBatchResultInfo.FillZeroWeightRecords(m_intBatchNo, m_datReadWhen, m_intRevisionId, m_intBatchSeq)
                        m_objLogger.AppendLog("Fill Zero Weight Records", clsLogger.enumLogType.eInfo)
                        m_objBatchResultInfo.FillZeroOilRecords(m_intBatchOilNo, m_datReadWhen, m_intRevisionId, m_intBatchSeq)
                        m_objLogger.AppendLog("Fill Zero Oil Records", clsLogger.enumLogType.eInfo)
                        m_datBatchStartWhen = m_datReadWhen
                        m_bBatchStarted = True
                        m_objLogger.AppendLog("Batch Start", clsLogger.enumLogType.eInfo)
                    End If

                    If m_bBatchStarted Then

                        Me.ReportProgress(REPORT_PROGRESS_BATCH_STARTED)

                        If Not m_bTankCompleted(0) Then
                            m_dblCoffeeActual = m_dblReadCoffeeActual
                        End If

                        If Not m_bTankCompleted(1) Then
                            m_dblCreamActual = m_dblReadCreamActual
                        End If

                        If Not m_bTankCompleted(2) Then
                            m_dblSugarActual = m_dblReadSugarActual
                        End If

                        If Not m_bTankCompleted(3) Then
                            m_dblOilActual = m_dblReadOilActual
                        End If

                        ''Me.ProcessAutoMode()
                        'If m_bManual Then
                        'Me.ProcessManualMode()
                        'Else    'Auto
                        Me.ProcessAutoMode()
                        'End If

                        'Check If all selected already completed
                        If Not m_bAllSelectedRMCompleted Then
                            bTemp = True
                            If m_bManual Then
                                For intTemp = 0 To RMWeightCount + RMLiquidCount - 1
                                    If m_bTankCompleted(intTemp) = False Then
                                        bTemp = False
                                    End If
                                Next
                            Else
                                For intTemp = 0 To RMWeightCount + RMLiquidCount - 1
                                    If m_bTankSelected(intTemp) = True AndAlso m_bTankCompleted(intTemp) = False Then
                                        bTemp = False
                                    End If
                                Next
                            End If

                            If bTemp Then
                                m_bAllSelectedRMCompleted = True
                                m_objLogger.AppendLog("All RM Complete", clsLogger.enumLogType.eInfo)
                            End If
                        End If
                    End If

                    If m_intEndProcess = 1 Then
                        m_clsPlcWrapper.WriteMemoryWordIntegerDMBCD0(m_intAddressReadFormulaRequest + END_PROCESS, 2)
                        'm_clsPlcWrapper.WriteMemoryWordIntegerDMBIN0(m_intAddressReadFormulaRequest + END_PROCESS, 2)
                        'If m_intBatchNo > 0 _
                        '    AndAlso m_intBatchSeq > 0 _
                        '    AndAlso m_datBatchStartWhen <> Date.MinValue _
                        '    AndAlso m_intRevisionId > 0 Then
                        '    m_objBatchResultInfo.FillZeroRecords(m_intBatchNo, m_datBatchStartWhen, m_intRevisionId, m_intBatchSeq)
                        'End If

                        m_bBatchStarted = False
                        Me.Reset()
                        m_objLogger.AppendLog("Batch Complete", clsLogger.enumLogType.eInfo)
                        ReportProgress(REPORT_PROGRESS_BATCH_COMPLETED)
                    End If
                End If
            Catch exTimeOut As OMRON.Compolet.SYSMAC.SysmacIOException
                'TODO show log message : 1st time
                If PLCConnect Then
                    PLCConnect = False
                    ReportProgress(REPORT_PROGRESS_PLC_DISCONNECT)
                    'MessageBox.Show("Cannot Connect to PLC")
                    m_objLogger.AppendLog(exTimeOut)
                End If
            Catch ex As Exception
                'TODO show ex.message : if change
                If LastLog <> ex.ToString Then
                    If ex.ToString.Contains("Receive timeout error") Then
                        If PLCConnect Then
                            PLCConnect = False
                            ReportProgress(REPORT_PROGRESS_PLC_DISCONNECT)
                            'MessageBox.Show("Cannot Connect to PLC")
                            m_objLogger.AppendLog(ex)
                        End If
                    Else
                        ReportProgress(REPORT_PROGRESS_EXCEPTION)
                    End If
                    LastLog = ex.ToString
                    m_objLogger.AppendLog(ex)
                End If
            End Try
            Threading.Thread.Sleep(TimeSpan.FromMilliseconds(1000))
        End While
    End Sub

    Private Sub ReadMessageFromPLC()
        Dim intReadMemory As Integer()
        Dim singleReadMemory As Single()

        m_objLogger.AppendLog("ReadMessageFromPLC Start", clsLogger.enumLogType.eInfo)
        intReadMemory = m_clsPlcWrapper.ReadMemoryWordInteger(OMRON.Compolet.SYSMAC.SysmacCSBase.MemoryTypes.DM, m_intAddressReadFormulaRequest, (PLAN - AUTO_MANAUL + 1), OMRON.Compolet.SYSMAC.SysmacPlc.DataTypes.BIN)

        Dim strTemp As String = "intReadMemory = "
        For Each i As Integer In intReadMemory
            strTemp &= i & ","
        Next
        m_objLogger.AppendLog(strTemp, clsLogger.enumLogType.eInfo)

        m_bManual = intReadMemory(AUTO_MANAUL)
        m_intReadFormulaNoRequest = intReadMemory(FORMULA_NO_REQUEST)
        m_intReadBatchNo = intReadMemory(BATCH_NO)
        m_intReadBatchOilNo = intReadMemory(BATCH_OIL_NO)
        m_intPlanNo = intReadMemory(PLAN)

        

        intReadMemory = m_clsPlcWrapper.ReadMemoryWordInteger(OMRON.Compolet.SYSMAC.SysmacCSBase.MemoryTypes.DM, m_intAddressReadFormulaRequest + RUN_RETURN, (MOTOR_SUGAR_STATUS - RUN_RETURN + 1), OMRON.Compolet.SYSMAC.SysmacPlc.DataTypes.BCD)
        strTemp = "intReadMemory2 = "
        For Each i As Integer In intReadMemory
            strTemp &= i & ","
        Next
        m_objLogger.AppendLog(strTemp, clsLogger.enumLogType.eInfo)


        singleReadMemory = m_clsPlcWrapper.ReadMemoryDwordSingle(OMRON.Compolet.SYSMAC.SysmacCSBase.MemoryTypes.DM, m_intAddressReadFormulaRequest + COFFEE_ACTUAL, RMWeightCount + RMLiquidCount)
        m_dblReadCoffeeActual = singleReadMemory((COFFEE_ACTUAL - COFFEE_ACTUAL) / 2)
        m_dblReadCreamActual = singleReadMemory((CREAM_ACTUAL - COFFEE_ACTUAL) / 2)
        m_dblReadSugarActual = singleReadMemory((SUGAR_ACTUAL - COFFEE_ACTUAL) / 2)
        m_dblReadOilActual = singleReadMemory((OIL_ACTUAL - COFFEE_ACTUAL) / 2)

        strTemp = "singleReadMemory = "
        For Each i As Single In singleReadMemory
            strTemp &= i.ToString & ","
        Next
        m_objLogger.AppendLog(strTemp, clsLogger.enumLogType.eInfo)


        m_bRunReturn = intReadMemory(RUN_RETURN - RUN_RETURN)
        m_intEndProcess = intReadMemory(END_PROCESS - RUN_RETURN)
        'm_bCoffeeCompleted = intReadMemory(COFFEE_COMPLETED - RUN_RETURN)
        'm_bCreamCompleted = intReadMemory(CREAM_COMPLETED - RUN_RETURN)
        'm_bSugarCompleted = intReadMemory(SUGAR_COMPLETED - RUN_RETURN)
        'm_bOilCompleted = intReadMemory(OIL_COMPLETED - RUN_RETURN)

        m_intCoffeeCompleted = intReadMemory(COFFEE_COMPLETED - RUN_RETURN)
        m_intCreamCompleted = intReadMemory(CREAM_COMPLETED - RUN_RETURN)
        m_intSugarCompleted = intReadMemory(SUGAR_COMPLETED - RUN_RETURN)
        m_intOilCompleted = intReadMemory(OIL_COMPLETED - RUN_RETURN)

        m_bCoffeeCompleted = IIf(m_intCoffeeCompleted > 0, True, False)
        m_bCreamCompleted = IIf(m_intCreamCompleted > 0, True, False)
        m_bSugarCompleted = IIf(m_intSugarCompleted > 0, True, False)
        m_bOilCompleted = IIf(m_intOilCompleted > 0, True, False)

        m_bRM1Discharge = intReadMemory(RM1_DISCHARGE - RUN_RETURN)
        m_bRM2Discharge = intReadMemory(RM2_DISCHARGE - RUN_RETURN)
        m_bRM3Discharge = intReadMemory(RM3_DISCHARGE - RUN_RETURN)
        m_bRM4Discharge = intReadMemory(RM4_DISCHARGE - RUN_RETURN)
        m_bMotorCoffeeStatus = intReadMemory(MOTOR_COFFEE_STATUS - RUN_RETURN)
        m_bMotorCreamStatus = intReadMemory(MOTOR_CREAM_STATUS - RUN_RETURN)
        m_bMotorSugarStatus = intReadMemory(MOTOR_SUGAR_STATUS - RUN_RETURN)
    End Sub

    Private Sub SendFormula(ByVal nFormulaNoSend As Integer)
        Dim strTemp As String
        Dim dtFormulaDetailCurrentActive As DataTable
        Try
            m_objLogger.AppendLog("SendFormula Start", clsLogger.enumLogType.eInfo)
            dtFormulaDetailCurrentActive = clsFormulaDetailInfo.FindActive(nFormulaNoSend, LineNo)
            If Not dtFormulaDetailCurrentActive Is Nothing And dtFormulaDetailCurrentActive.Rows.Count > 0 Then
                'Dim dblWriteData(HZ_L - MAX_VALUE) As Double
                Dim singleWriteData((CRUSHER - MAX_VALUE) / 2) As Single
                Dim strRMCode As String
                Dim strRMLot As String
                Dim sngRMChecked As Single
                For i As Integer = 1 To RMWeightCount + RMLiquidCount
                    'm_clsPlcWrapper.WriteMemoryWordIntegerDMBCD0(m_intAddressWriteFormulaSend + ((i - 1) * 50), _
                    '                                        IIf(m_bTankSelected(i - 1), 1, 0))
                    sngRMChecked = IIf(CBool(dtFormulaDetailCurrentActive.Rows(i - 1).Item("CHECKED")), 1, 0)
                    m_clsPlcWrapper.WriteMemoryDwordSingle(OMRON.Compolet.SYSMAC.SysmacCSBase.MemoryTypes.DM, _
                                                           m_intAddressWriteFormulaSend + ((i - 1) * 50), _
                                                           sngRMChecked)

                    strRMCode = clsRMInfo.Find(i).RMCode
                    strRMCode.PadRight(10, " ")
                    strRMLot = dtFormulaDetailCurrentActive.Rows(i - 1).Item("RM_LOT")
                    strRMLot.PadRight(10, " ")

                    'm_clsPlcWrapper.WriteMemoryWordString(OMRON.Compolet.SYSMAC.SysmacCSBase.MemoryTypes.DM, _
                    '                                      m_intAddressWriteFormulaSend + ((i - 1) * 50) + RM_NAME, _
                    '                                      strRMCode & strRMLot)

                    singleWriteData(0) = dtFormulaDetailCurrentActive.Rows(i - 1).Item("MAX_VALUE")
                    singleWriteData(1) = dtFormulaDetailCurrentActive.Rows(i - 1).Item("MIN_VALUE")
                    singleWriteData(2) = dtFormulaDetailCurrentActive.Rows(i - 1).Item("FINAL_VALUE")
                    singleWriteData(3) = dtFormulaDetailCurrentActive.Rows(i - 1).Item("SP1_VALUE")
                    singleWriteData(4) = dtFormulaDetailCurrentActive.Rows(i - 1).Item("SP2_VALUE")
                    singleWriteData(5) = dtFormulaDetailCurrentActive.Rows(i - 1).Item("CPS_VALUE")
                    singleWriteData(6) = dtFormulaDetailCurrentActive.Rows(i - 1).Item("HZ_H")
                    singleWriteData(7) = dtFormulaDetailCurrentActive.Rows(i - 1).Item("HZ_M")
                    singleWriteData(8) = dtFormulaDetailCurrentActive.Rows(i - 1).Item("HZ_L")
                    singleWriteData(9) = dtFormulaDetailCurrentActive.Rows(i - 1).Item("CRUSHER")

                    m_clsPlcWrapper.WriteMemoryDwordSingle(OMRON.Compolet.SYSMAC.SysmacCSBase.MemoryTypes.DM, _
                                                            m_intAddressWriteFormulaSend + ((i - 1) * 50) + MAX_VALUE, _
                                                            singleWriteData)
                    strTemp = String.Format("RM:{0}, LOT: {1}, CHECKED: {2} sent. ({3},{4},{5},{6},{7},{8},{9},{10},{11},{12})", _
                                            strRMCode, _
                                            strRMLot, _
                                            sngRMChecked, _
                                            singleWriteData(0), _
                                            singleWriteData(1), _
                                            singleWriteData(2), _
                                            singleWriteData(3), _
                                            singleWriteData(4), _
                                            singleWriteData(5), _
                                            singleWriteData(6), _
                                            singleWriteData(7), _
                                            singleWriteData(8), _
                                            singleWriteData(9) _
                                            )
                    m_objLogger.AppendLog(strTemp, clsLogger.enumLogType.eInfo)
                Next
                m_clsPlcWrapper.WriteMemoryWordIntegerDMBCD0(m_intAddressWriteLifeCheck + FORMULA_NO, nFormulaNoSend)
                'm_clsPlcWrapper.WriteMemoryWordIntegerDMBIN0(m_intAddressWriteLifeCheck + FORMULA_NO, nFormulaNoSend)
                'm_clsPlcWrapper.WriteMemoryWordInteger(OMRON.Compolet.SYSMAC.SysmacCSBase.MemoryTypes.DM, m_intAddressWriteLifeCheck + FORMULA_NO, {nFormulaNoSend}, OMRON.Compolet.SYSMAC.SysmacPlc.DataTypes.BIN)
                m_objLogger.AppendLog("Write Send Formula Complete", clsLogger.enumLogType.eInfo)
                Me.m_intFormulaNoSend = nFormulaNoSend
                Me.m_intFormulaToSendComplete = nFormulaNoSend
                'Me.m_intRevisionId = dtFormulaDetailCurrentActive.Rows(0).Item("REVISION_ID")
                'Me.SendFormulaComplete(1)
            Else
                'No active formula
                dtFormulaDetailCurrentActive = Nothing
                m_objLogger.AppendLog("No active formula", clsLogger.enumLogType.eError)
            End If
        Catch ex As Exception
            m_objLogger.AppendLog(ex)
        End Try

    End Sub

    Private Sub GetFormula(ByVal nFormulaNoSend As Integer)
        Try
            m_objLogger.AppendLog("GetFormula Start", clsLogger.enumLogType.eInfo)
            m_dtFormulaDetailCurrentActive = clsFormulaDetailInfo.FindActive(nFormulaNoSend, LineNo)
            If Not m_dtFormulaDetailCurrentActive Is Nothing And m_dtFormulaDetailCurrentActive.Rows.Count > 0 Then
                For intTemp = 0 To RMWeightCount + RMLiquidCount - 1
                    m_bTankSelected(intTemp) = m_dtFormulaDetailCurrentActive.Rows(intTemp).Item("CHECKED")
                Next
                Me.m_intRevisionId = m_dtFormulaDetailCurrentActive.Rows(0).Item("REVISION_ID")
            Else
                'No active formula
                m_dtFormulaDetailCurrentActive = Nothing
                m_objLogger.AppendLog("No active formula", clsLogger.enumLogType.eError)
                MsgBox("No formula of No." & nFormulaNoSend)
            End If
        Catch ex As Exception
            m_objLogger.AppendLog(ex)
        End Try

    End Sub


    Private Sub SendBatchNo(ByVal nBatchNo As Integer)
        Try
            m_clsPlcWrapper.WriteMemoryWordIntegerDMBCD0(m_intAddressReadFormulaRequest + BATCH_NO, nBatchNo)
            'm_clsPlcWrapper.WriteMemoryWordIntegerDMBIN0(m_intAddressReadFormulaRequest + BATCH_NO, nBatchNo)
        Catch ex As Exception
            m_objLogger.AppendLog(ex)
        End Try
    End Sub

    Private Sub SendBatchOilNo(ByVal nBatchOilNo As Integer)
        Try
            m_clsPlcWrapper.WriteMemoryWordIntegerDMBCD0(m_intAddressReadFormulaRequest + BATCH_OIL_NO, nBatchOilNo)
            'm_clsPlcWrapper.WriteMemoryWordIntegerDMBIN0(m_intAddressReadFormulaRequest + BATCH_OIL_NO, nBatchOilNo)
        Catch ex As Exception
            m_objLogger.AppendLog(ex)
        End Try
    End Sub

    Private Sub SendFormulaComplete(ByVal value As Integer)
        m_clsPlcWrapper.WriteMemoryWordIntegerDMBCD0(m_intAddressWriteLifeCheck + FORMULA_SEND_COMPLETED, value)
        'm_clsPlcWrapper.WriteMemoryWordIntegerDMBIN0(m_intAddressWriteLifeCheck + FORMULA_SEND_COMPLETED, value)
        Me.m_bFormulaSendComplete = value
    End Sub

    Private Sub MakeRMHash()
        Dim dt As DataTable = clsRMInfo.FindAll()

        If dt IsNot Nothing AndAlso dt.Rows.Count Then
            For Each dr As DataRow In dt.Rows
                m_htbRM.Add(dr("RM_CODE"), dr("RM_NO"))
            Next
        Else
            m_htbRM = Nothing
        End If
    End Sub

    Private Sub ProcessManualMode()
        Dim intResult As Integer = 0
        Dim strMessage As String = String.Empty
        m_objLogger.AppendLog("ProcessManualMode Start", clsLogger.enumLogType.eInfo)

        If IsCoffeeCompleted And m_bRM1Discharge And Not m_bTankCompleted(0) Then
            intResult = m_objBatchResultInfo.CreateOrOverwrite(m_intBatchNo, m_datReadWhen, m_htbRM("COFFEE"), m_intRevisionId, m_dblCoffeeActual, m_intBatchSeq)
            If intResult > 0 Then
                m_bTankCompleted(0) = True
                strMessage = String.Format("Batch:{0}, Batch Seq:{1}, Revision:{2} insert COFFEE result completed", m_intBatchNo, m_intBatchSeq, m_intRevisionId)
                m_objLogger.AppendLog(strMessage, clsLogger.enumLogType.eInfo)
            Else
                strMessage = String.Format("Batch:{0}, Batch Seq:{1}, Revision:{2} insert COFFEE result failed", m_intBatchNo, m_intBatchSeq, m_intRevisionId)
                m_objLogger.AppendLog(strMessage, clsLogger.enumLogType.eError)
            End If
        End If

        If IsCreamCompleted And m_bRM2Discharge And Not m_bTankCompleted(1) Then
            intResult = m_objBatchResultInfo.CreateOrOverwrite(m_intBatchNo, m_datReadWhen, m_htbRM("CREAM"), m_intRevisionId, m_dblCreamActual, m_intBatchSeq)
            If intResult > 0 Then
                m_bTankCompleted(1) = True
                strMessage = String.Format("Batch:{0}, Batch Seq:{1}, Revision:{2} insert CREAM result completed", m_intBatchNo, m_intBatchSeq, m_intRevisionId)
                m_objLogger.AppendLog(strMessage, clsLogger.enumLogType.eInfo)
            Else
                strMessage = String.Format("Batch:{0}, Batch Seq:{1}, Revision:{2} insert CREAM result failed", m_intBatchNo, m_intBatchSeq, m_intRevisionId)
                m_objLogger.AppendLog(strMessage, clsLogger.enumLogType.eError)
            End If
        End If

        If IsSugarCompleted And m_bRM3Discharge And Not m_bTankCompleted(2) Then
            intResult = m_objBatchResultInfo.CreateOrOverwrite(m_intBatchNo, m_datReadWhen, m_htbRM("SUGAR"), m_intRevisionId, m_dblSugarActual, m_intBatchSeq)
            If intResult > 0 Then
                m_bTankCompleted(2) = True
                strMessage = String.Format("Batch:{0}, Batch Seq:{1}, Revision:{2} insert SUGAR result completed", m_intBatchNo, m_intBatchSeq, m_intRevisionId)
                m_objLogger.AppendLog(strMessage, clsLogger.enumLogType.eInfo)
            Else
                strMessage = String.Format("Batch:{0}, Batch Seq:{1}, Revision:{2} insert SUGAR result failed", m_intBatchNo, m_intBatchSeq, m_intRevisionId)
                m_objLogger.AppendLog(strMessage, clsLogger.enumLogType.eError)
            End If
        End If

        If Not m_bTankCompleted(3) And m_bRM4Discharge And Not m_bTankCompleted(3) Then
            intResult = m_objBatchResultInfo.CreateOrOverwrite(m_intBatchOilNo, m_datReadWhen, m_htbRM("OIL"), m_intRevisionId, m_dblOilActual, m_intBatchSeq)
            If intResult > 0 Then
                m_bTankCompleted(3) = True
                strMessage = String.Format("Batch:{0}, Batch Seq:{1}, Revision:{2} insert OIL result completed", m_intBatchNo, m_intBatchSeq, m_intRevisionId)
                m_objLogger.AppendLog(strMessage, clsLogger.enumLogType.eInfo)
            Else
                strMessage = String.Format("Batch:{0}, Batch Seq:{1}, Revision:{2} insert OIL result failed", m_intBatchNo, m_intBatchSeq, m_intRevisionId)
                m_objLogger.AppendLog(strMessage, clsLogger.enumLogType.eError)
            End If
        End If
        m_objLogger.AppendLog("ProcessManualMode End", clsLogger.enumLogType.eInfo)
    End Sub

    Private Sub ProcessAutoMode()
        Dim intResult As Integer = 0
        Dim strMessage As String = String.Empty

        m_objLogger.AppendLog("ProcessAutoMode Start", clsLogger.enumLogType.eInfo)
        If (m_bTankSelected(0) And IsCoffeeCompleted And Not m_bTankCompleted(0)) Or _
            (Not m_bTankSelected(0) And RM1Discharge And Not m_bTankCompleted(0)) Then
            intResult = m_objBatchResultInfo.CreateOrOverwrite(m_intBatchNo, m_datReadWhen, m_htbRM("COFFEE"), m_intRevisionId, m_dblCoffeeActual, m_intBatchSeq)
            If intResult > 0 Then
                If m_intCoffeeCompleted = 1 Then
                    m_clsPlcWrapper.WriteMemoryWordIntegerDMBCD0(m_intAddressReadFormulaRequest + COFFEE_COMPLETED, 2)
                    'm_clsPlcWrapper.WriteMemoryWordIntegerDMBIN0(m_intAddressReadFormulaRequest + COFFEE_COMPLETED, 2)
                    strMessage = String.Format("Batch:{0}, Batch Seq:{1}, Revision:{2}, Save COFFEE Completed:{3}, Replied 2 to PLC at DM {4}", m_intBatchNo, m_intBatchSeq, m_intRevisionId, m_dblCoffeeActual, m_intAddressReadFormulaRequest + COFFEE_COMPLETED)
                    m_objLogger.AppendLog(strMessage, clsLogger.enumLogType.eInfo)
                End If
                m_bTankCompleted(0) = True
                strMessage = String.Format("Batch:{0}, Batch Seq:{1}, Revision:{2} insert COFFEE result completed", m_intBatchNo, m_intBatchSeq, m_intRevisionId)
                m_objLogger.AppendLog(strMessage, clsLogger.enumLogType.eInfo)
            Else
                strMessage = String.Format("Batch:{0}, Batch Seq:{1}, Revision:{2} insert COFFEE result failed", m_intBatchNo, m_intBatchSeq, m_intRevisionId)
                m_objLogger.AppendLog(strMessage, clsLogger.enumLogType.eError)
            End If
        End If

        If (m_bTankSelected(1) And IsCreamCompleted And Not m_bTankCompleted(1)) Or _
            (Not m_bTankSelected(1) And RM2Discharge And Not m_bTankCompleted(1)) Then
            intResult = m_objBatchResultInfo.CreateOrOverwrite(m_intBatchNo, m_datReadWhen, m_htbRM("CREAM"), m_intRevisionId, m_dblCreamActual, m_intBatchSeq)
            If intResult > 0 Then
                If m_intCreamCompleted = 1 Then
                    m_clsPlcWrapper.WriteMemoryWordIntegerDMBCD0(m_intAddressReadFormulaRequest + CREAM_COMPLETED, 2)
                    'm_clsPlcWrapper.WriteMemoryWordIntegerDMBIN0(m_intAddressReadFormulaRequest + CREAM_COMPLETED, 2)
                    strMessage = String.Format("Batch:{0}, Batch Seq:{1}, Revision:{2}, Save CREAM Completed:{3}, Replied 2 to PLC at DM {4}", m_intBatchNo, m_intBatchSeq, m_intRevisionId, m_dblCreamActual, m_intAddressReadFormulaRequest + CREAM_COMPLETED)
                    m_objLogger.AppendLog(strMessage, clsLogger.enumLogType.eInfo)
                End If
                m_bTankCompleted(1) = True
                strMessage = String.Format("Batch:{0}, Batch Seq:{1}, Revision:{2} insert CREAM result completed", m_intBatchNo, m_intBatchSeq, m_intRevisionId)
                m_objLogger.AppendLog(strMessage, clsLogger.enumLogType.eInfo)
            Else
                strMessage = String.Format("Batch:{0}, Batch Seq:{1}, Revision:{2} insert CREAM result failed", m_intBatchNo, m_intBatchSeq, m_intRevisionId)
                m_objLogger.AppendLog(strMessage, clsLogger.enumLogType.eError)
            End If
        End If

        If (m_bTankSelected(2) And IsSugarCompleted And Not m_bTankCompleted(2)) Or _
            (Not m_bTankSelected(2) And RM3Discharge And Not m_bTankCompleted(2)) Then
            intResult = m_objBatchResultInfo.CreateOrOverwrite(m_intBatchNo, m_datReadWhen, m_htbRM("SUGAR"), m_intRevisionId, m_dblSugarActual, m_intBatchSeq)
            If intResult > 0 Then
                If m_intSugarCompleted = 1 Then
                    m_clsPlcWrapper.WriteMemoryWordIntegerDMBCD0(m_intAddressReadFormulaRequest + SUGAR_COMPLETED, 2)
                    'm_clsPlcWrapper.WriteMemoryWordIntegerDMBIN0(m_intAddressReadFormulaRequest + SUGAR_COMPLETED, 2)
                    strMessage = String.Format("Batch:{0}, Batch Seq:{1}, Revision:{2}, Save SUGAR Completed:{3}, Replied 2 to PLC at DM {4}", m_intBatchNo, m_intBatchSeq, m_intRevisionId, m_dblSugarActual, m_intAddressReadFormulaRequest + SUGAR_COMPLETED)
                    m_objLogger.AppendLog(strMessage, clsLogger.enumLogType.eInfo)
                End If
                m_bTankCompleted(2) = True
                strMessage = String.Format("Batch:{0}, Batch Seq:{1}, Revision:{2} insert SUGAR result completed", m_intBatchNo, m_intBatchSeq, m_intRevisionId)
                m_objLogger.AppendLog(strMessage, clsLogger.enumLogType.eInfo)
            Else
                strMessage = String.Format("Batch:{0}, Batch Seq:{1}, Revision:{2} insert SUGAR result failed", m_intBatchNo, m_intBatchSeq, m_intRevisionId)
                m_objLogger.AppendLog(strMessage, clsLogger.enumLogType.eError)
            End If
        End If

        If (m_bTankSelected(3) And IsOilCompleted And Not m_bTankCompleted(3)) Or _
            (Not m_bTankSelected(3) And RM4Discharge And Not m_bTankCompleted(3)) Then
            intResult = m_objBatchResultInfo.CreateOrOverwrite(m_intBatchOilNo, m_datReadWhen, m_htbRM("OIL"), m_intRevisionId, m_dblOilActual, m_intBatchSeq)
            If intResult > 0 Then
                If m_intOilCompleted = 1 Then
                    m_clsPlcWrapper.WriteMemoryWordIntegerDMBCD0(m_intAddressReadFormulaRequest + OIL_COMPLETED, 2)
                    'm_clsPlcWrapper.WriteMemoryWordIntegerDMBIN0(m_intAddressReadFormulaRequest + OIL_COMPLETED, 2)
                    strMessage = String.Format("Batch:{0}, Batch Seq:{1}, Revision:{2}, Save OIL Completed:{3}, Replied 2 to PLC at DM {4}", m_intBatchNo, m_intBatchSeq, m_intRevisionId, m_dblOilActual, m_intAddressReadFormulaRequest + OIL_COMPLETED)
                    m_objLogger.AppendLog(strMessage, clsLogger.enumLogType.eInfo)
                End If
                m_bTankCompleted(3) = True
                strMessage = String.Format("Batch:{0}, Batch Seq:{1}, Revision:{2} insert OIL result completed", m_intBatchNo, m_intBatchSeq, m_intRevisionId)
                m_objLogger.AppendLog(strMessage, clsLogger.enumLogType.eInfo)
            Else
                strMessage = String.Format("Batch:{0}, Batch Seq:{1}, Revision:{2} insert OIL result failed", m_intBatchNo, m_intBatchSeq, m_intRevisionId)
                m_objLogger.AppendLog(strMessage, clsLogger.enumLogType.eError)
            End If
        End If
        m_objLogger.AppendLog("ProcessAutoMode End", clsLogger.enumLogType.eInfo)
    End Sub

    Private Sub Reset()
        m_intFormulaNoSend = 0
        m_intRevisionId = 0
        m_intBatchSeq = 0
        m_intBatchNo = 0
        m_intBatchOilNo = 0
        m_intReadBatchNo = 0
        m_intReadBatchOilNo = 0
        For i As Integer = 0 To m_bTankCompleted.Length - 1
            m_bTankCompleted(i) = False
        Next

        m_bAllSelectedRMCompleted = False
        m_dblCoffeeActual = 0
        m_dblCreamActual = 0
        m_dblSugarActual = 0
        m_dblOilActual = 0
        m_datBatchStartWhen = Date.MinValue
    End Sub

    Private Sub SendSavedFormula()
        Try
            'm_objLogger.AppendLog("SendSavedFormula Start", clsLogger.enumLogType.eInfo)
            m_intFormulaToSendClear = m_clsPlcWrapper.ReadMemoryWordIntegerDMBCD0(m_intAddressWriteLifeCheck + FORMULA_NO)
            'm_intFormulaToSendClear = m_clsPlcWrapper.ReadMemoryWordIntegerDMBIN0(m_intAddressWriteLifeCheck + FORMULA_NO)

            If m_intFormulaToSendComplete > 0 And m_intFormulaToSendClear = 0 Then
                m_intFormulaToSend = 0
                m_intFormulaToSendComplete = 0
                m_objLogger.AppendLog("Formula Complete Flag Clear From PLC", clsLogger.enumLogType.eInfo)
            End If

            If m_intFormulaToSend > 0 And m_intFormulaToSendClear = 0 Then
                SendFormula(m_intFormulaToSend)
                m_objLogger.AppendLog("Formula Sent", clsLogger.enumLogType.eInfo)
            End If

            'If m_intFormulaToSend > 0 And m_intFormulaToSendClear > 0 Then
            '    m_clsPlcWrapper.WriteMemoryWordIntegerDMBCD0(m_intAddressWriteLifeCheck + FORMULA_NO, 0)
            '    m_intFormulaToSend = 0
            'End If
            'm_objLogger.AppendLog("SendSavedFormula End", clsLogger.enumLogType.eInfo)
        Catch ex As Exception
            m_objLogger.AppendLog(ex)
        End Try
    End Sub
#End Region
End Class
