Public Class ctrlPlcStatus

#Region "Public Variables"
#End Region

#Region "Private Variables"
    Dim m_intBatchNo As Integer
    Dim m_intBatchOilNo As Integer
    Dim m_intManualBatchNo As Integer
    Dim m_intManualBatchOilNo As Integer
    Dim m_intFormulaCode As Integer
    Dim m_strLine As String = "LINE :: "
    Dim m_intLineNo As Integer
#End Region


#Region "Properties"
    Public Property BatchNo() As Integer
        Get
            Return Me.m_intBatchNo
        End Get
        Set(ByVal value As Integer)
            Me.m_intBatchNo = value
            Me.txtBatchNo.Text = value.ToString
        End Set
    End Property
    Public Property BatchOilNo() As Integer
        Get
            Return Me.m_intBatchOilNo
        End Get
        Set(ByVal value As Integer)
            If value <> m_intBatchOilNo Then
                Me.m_intBatchOilNo = value
                Me.txtBatchOilNo.Text = value.ToString
            End If
        End Set
    End Property
    Public Property ManualBatchNo() As Integer
        Get
            Return Me.m_intManualBatchNo
        End Get
        Set(ByVal value As Integer)
            Me.m_intManualBatchNo = value
        End Set
    End Property
    Public Property ManualBatchOilNo() As Integer
        Get
            Return Me.m_intManualBatchOilNo
        End Get
        Set(ByVal value As Integer)
            Me.m_intManualBatchOilNo = value
        End Set
    End Property
    Public Property FormulaCode() As Integer
        Get
            Return Me.m_intFormulaCode
        End Get
        Set(ByVal value As Integer)
            Me.m_intFormulaCode = value
            If value > 0 Then
                Me.lblFormula.Text = (clsFormulaInfo.FindByFormulaCodeLineNo(value, m_intLineNo).FormulaName).ToUpper
            End If
        End Set
    End Property
    Public Property LineNo() As Integer
        Get
            Return Me.m_intLineNo
        End Get
        Set(ByVal value As Integer)
            Me.m_intLineNo = value
            'Me.lblLine.Text = m_strLine & clsLineInfo.FindLineCode(value)
        End Set
    End Property
    Public Property LineName() As String
        Get
            Return Me.lblLineName.Text
        End Get
        Set(value As String)
            Me.lblLineName.Text = value
        End Set
    End Property
#End Region

#Region "Construtor"
    Sub New(ByVal intLineNo As Integer)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        Reset()
        'Me.lblLine.Text = m_strLine & clsLineInfo.FindLineCode(intLineNo)
    End Sub

    Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        Reset()
    End Sub

    Public Overridable Sub Reset()
        m_intBatchNo = -1
        m_intBatchOilNo = -1
        m_intManualBatchNo = -1
        m_intManualBatchOilNo = -1
    End Sub
#End Region
#Region "Event"
    'Private Sub txtBatchNo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBatchNo.Click
    '    If m_intBatchNo > -1 And Integer.TryParse(InputBox("Enter New Batch No.", "New Batch"), m_intManualBatchNo) Then
    '        MsgBox("Next Batch No. is " & m_intManualBatchNo)
    '    End If
    'End Sub
    'Private Sub txtBatchOilNo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBatchOilNo.Click
    '    If m_intBatchNo > -1 And Integer.TryParse(InputBox("Enter New Batch Oil No.", "New Batch Oil"), m_intManualBatchOilNo) Then
    '        MsgBox("Next Batch Oil No. is " & m_intManualBatchOilNo)
    '    End If
    'End Sub
#End Region
#Region "Public Function"
#End Region
#Region "Private Function"
#End Region
End Class
