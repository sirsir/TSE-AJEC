Public Class CtrlPlcStatusLight

#Region "Public Variables"
#End Region

#Region "Private Variables"
    Dim m_bRunReturn As Boolean
    Dim m_bRM1Complete As Boolean
    Dim m_bRM2Complete As Boolean
    Dim m_bRM3Complete As Boolean
    Dim m_bRM4Complete As Boolean

    Dim m_bEndProcess As Boolean
    Dim m_bRM1Discharge As Boolean
    Dim m_bRM2Discharge As Boolean
    Dim m_bRM3Discharge As Boolean
    Dim m_bRM4Discharge As Boolean

    Dim m_strGroupBox As String = "STATUS LINE:"
    Dim m_strStatusRun As String = "STATUSRUN"
    Dim m_strDischargeLine As String = "DISCHARGE LINE"
    Dim m_intLineNo As Integer

#End Region

#Region "Properties"
    Public Property RunReturn() As Boolean
        Get
            Return Me.m_bRunReturn
        End Get
        Set(ByVal value As Boolean)
            Me.m_bRunReturn = value
            If value Then
                Me.PbRunReturnOn.Visible = True
                Me.PbRunReturnOff.Visible = False
            Else
                Me.PbRunReturnOn.Visible = False
                Me.PbRunReturnOff.Visible = True
            End If
        End Set
    End Property
    Public Property RM1Complete() As Boolean
        Get
            Return Me.m_bRM1Complete
        End Get
        Set(ByVal value As Boolean)
            Me.m_bRM1Complete = value
            If value Then
                Me.PbRM1CompleteOn.Visible = True
                Me.PbRM1CompleteOff.Visible = False
            Else
                Me.PbRM1CompleteOn.Visible = False
                Me.PbRM1CompleteOff.Visible = True
            End If
        End Set
    End Property
    Public Property RM2Complete() As Boolean
        Get
            Return Me.m_bRM2Complete
        End Get
        Set(ByVal value As Boolean)
            Me.m_bRM2Complete = value
            If value Then
                Me.PbRM2CompleteOn.Visible = True
                Me.PbRM2CompleteOff.Visible = False
            Else
                Me.PbRM2CompleteOn.Visible = False
                Me.PbRM2CompleteOff.Visible = True
            End If
        End Set
    End Property
    Public Property RM3Complete() As Boolean
        Get
            Return Me.m_bRM3Complete
        End Get
        Set(ByVal value As Boolean)
            Me.m_bRM3Complete = value
            If value Then
                Me.PbRM3CompleteOn.Visible = True
                Me.PbRM3CompleteOff.Visible = False
            Else
                Me.PbRM3CompleteOn.Visible = False
                Me.PbRM3CompleteOff.Visible = True
            End If
        End Set
    End Property
    Public Property RM4Complete() As Boolean
        Get
            Return Me.m_bRM4Complete
        End Get
        Set(ByVal value As Boolean)
            Me.m_bRM4Complete = value
            If value Then
                Me.PbRM4CompleteOn.Visible = True
                Me.PbRM4CompleteOff.Visible = False
            Else
                Me.PbRM4CompleteOn.Visible = False
                Me.PbRM4CompleteOff.Visible = True
            End If
        End Set
    End Property
    Public Property EndProcess() As Boolean
        Get
            Return Me.m_bEndProcess
        End Get
        Set(ByVal value As Boolean)
            Me.m_bEndProcess = value
            If value Then
                Me.PbEndProcessOn.Visible = True
                Me.PbEndProcessOff.Visible = False
            Else
                Me.PbEndProcessOn.Visible = False
                Me.PbEndProcessOff.Visible = True
            End If
        End Set
    End Property
    Public Property RM1Discharge() As Boolean
        Get
            Return Me.m_bRM1Discharge
        End Get
        Set(ByVal value As Boolean)
            Me.m_bRM1Discharge = value
            If value Then
                Me.PbRM1DischargeOn.Visible = True
                Me.PbRM1DischargeOff.Visible = False
            Else
                Me.PbRM1DischargeOn.Visible = False
                Me.PbRM1DischargeOff.Visible = True
            End If
        End Set
    End Property
    Public Property RM2Discharge() As Boolean
        Get
            Return Me.m_bRM2Discharge
        End Get
        Set(ByVal value As Boolean)
            Me.m_bRM2Discharge = value
            If value Then
                Me.PbRM2DischargeOn.Visible = True
                Me.PbRM2DischargeOff.Visible = False
            Else
                Me.PbRM2DischargeOn.Visible = False
                Me.PbRM2DischargeOff.Visible = True
            End If
        End Set
    End Property
    Public Property RM3Discharge() As Boolean
        Get
            Return Me.m_bRM3Discharge
        End Get
        Set(ByVal value As Boolean)
            Me.m_bRM3Discharge = value
            If value Then
                Me.PbRM3DischargeOn.Visible = True
                Me.PbRM3DischargeOff.Visible = False
            Else
                Me.PbRM3DischargeOn.Visible = False
                Me.PbRM3DischargeOff.Visible = True
            End If
        End Set
    End Property
    Public Property RM4Discharge() As Boolean
        Get
            Return Me.m_bRM4Discharge
        End Get
        Set(ByVal value As Boolean)
            Me.m_bRM4Discharge = value
            If value Then
                Me.PbRM4DischargeOn.Visible = True
                Me.PbRM4DischargeOff.Visible = False
            Else
                Me.PbRM4DischargeOn.Visible = False
                Me.PbRM4DischargeOff.Visible = True
            End If
        End Set
    End Property

    Public Property LineNo() As Integer
        Get
            Return Me.m_intLineNo
        End Get
        Set(ByVal value As Integer)
            Me.m_intLineNo = value
            Me.GbStatusLine.Text = m_strGroupBox & clsLineInfo.FindLineCode(value)
            Me.GbDischargeLine.Text = m_strDischargeLine & clsLineInfo.FindLineCode(value)
        End Set
    End Property
#End Region
#Region "Construtor"
    Sub New(ByVal intLineNo As Integer)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        Reset()
        m_intLineNo = intLineNo
        GbStatusLine.Text = m_strGroupBox & clsLineInfo.FindLineCode(intLineNo)
        GbStatusRun.Text = m_strStatusRun
        GbDischargeLine.Text = m_strDischargeLine & clsLineInfo.FindLineCode(intLineNo)

    End Sub

    Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        Reset()
    End Sub

    Public Overridable Sub Reset()
        'set all light Off
        Me.RunReturn = False
        Me.EndProcess = False
        Me.RM1Discharge = False
        Me.RM2Discharge = False
        Me.RM3Discharge = False
        Me.RM4Discharge = False
        Me.RM1Complete = False
        Me.RM2Complete = False
        Me.RM3Complete = False
        Me.RM4Complete = False
    End Sub
#End Region

#Region "Private Function"
#End Region

    Private Sub GbStatusLine_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GbStatusLine.Enter

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
