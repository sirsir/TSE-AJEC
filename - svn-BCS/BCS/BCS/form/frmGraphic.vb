Public Class frmGraphic

#Region "Public Variables"
    Public m_intFormulaId As Integer = -1
    Public m_intLineNo As Integer = -1

    Public m_dblCream As Double = 0
    Public m_dblSugar As Double = 0
    Public m_dblCoffee As Double = 0
    Public m_bCreamMotor As Boolean = False
    Public m_bSugarMotor As Boolean = False
    Public m_bCoffeeMotor As Boolean = False
#End Region

#Region "Private Variables"
    Dim m_strRoleId As String = "USR"
#End Region
#Region "Properties"
    Public Property Coffee() As Double
        Get
            Return m_dblCoffee
        End Get
        Set(ByVal value As Double)
            Me.m_dblCoffee = value
            Me.lblCoffee.Text = Format(m_dblCoffee, "0.00")
        End Set
    End Property
    Public Property Cream() As Double
        Get
            Return m_dblCream
        End Get
        Set(ByVal value As Double)
            Me.m_dblCream = value
            Me.lblCream.Text = Format(m_dblCream, "0.00")
        End Set
    End Property
    Public Property Sugar() As Double
        Get
            Return m_dblSugar
        End Get
        Set(ByVal value As Double)
            Me.m_dblSugar = value
            Me.lblSugar.Text = Format(m_dblSugar, "0.00")
        End Set
    End Property

    Public Property CoffeeMotor() As Boolean
        Get
            Return m_bCoffeeMotor
        End Get
        Set(ByVal value As Boolean)
            Me.m_bCoffeeMotor = value
            If value Then
                Me.pbCoffeeOn.Visible = True
                Me.pbCoffeeMotorOn.Visible = True
                Me.pbCoffeeMotorOff.Visible = False
            Else
                Me.pbCoffeeOn.Visible = False
                Me.pbCoffeeMotorOn.Visible = False
                Me.pbCoffeeMotorOff.Visible = True
            End If
        End Set
    End Property
    Public Property CreamMotor() As Boolean
        Get
            Return m_bCreamMotor
        End Get
        Set(ByVal value As Boolean)
            Me.m_bCreamMotor = value
            If value Then
                Me.PbCreamOn.Visible = True
                Me.pbCreamMotorOn.Visible = True
                Me.pbCreamMotorOff.Visible = False
            Else
                Me.PbCreamOn.Visible = False
                Me.pbCreamMotorOn.Visible = False
                Me.pbCreamMotorOff.Visible = True
            End If
        End Set
    End Property
    Public Property SugarMotor() As Boolean
        Get
            Return m_bSugarMotor
        End Get
        Set(ByVal value As Boolean)
            Me.m_bSugarMotor = value
            If value Then
                Me.PbSugarOn.Visible = True
                Me.pbSugarMotorOn.Visible = True
                Me.pbSugarMotorOff.Visible = False
            Else
                Me.PbSugarOn.Visible = False
                Me.pbSugarMotorOn.Visible = False
                Me.pbSugarMotorOff.Visible = True
            End If
        End Set
    End Property
#End Region
#Region "Constructor AND Destructor"
    Public Sub New(ByVal strRoleId As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        m_strRoleId = strRoleId

    End Sub
#End Region

#Region "Events"
    Private Sub frmGraphic_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "STATUS LINE " & clsLineInfo.FindLineCode(m_intLineNo)

        lblCoffee.Text = Format(m_dblCoffee, "0.00")
        lblCream.Text = Format(m_dblCream, "0.00")
        lblSugar.Text = Format(m_dblSugar, "0.00")
    End Sub

#End Region

#Region "Private Function"

#End Region

#Region "Public Function"
#End Region

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Hide()
    End Sub

    Private Sub frmGraphic_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        If Me.Visible = False Then
            Dim frm As frmBatchResult = DirectCast(Me.Owner, frmBatchResult)
            frm.btnGraphicLineB1.Enabled = True
            frm.btnGraphicLineB2.Enabled = True
        End If
    End Sub
End Class