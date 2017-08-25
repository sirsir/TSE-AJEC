Public Class frmDataMaterial

#Region "Public Variables"

#End Region

#Region "Private Variables"
    Dim m_strViewForMaterialDetail As String = "V_DATA_MATERIAL"
#End Region
#Region "Constructor AND Destructor"
    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub
#End Region

#Region "Events"
    Private Sub frmDataMaterial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ClearHeader()

        clsRMInfo.AddRMCodeToCombo(cmbRMCode)
        LoadMaterialData()
        'DgFinal.
        'DgCPS.defaultview.allownew = False
        'DgCPS.defaultview.allownew = False

    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        ClearHeader()
    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
#End Region
#Region "Private Function"
    Private Sub ClearHeader()
        txtCode.Text = String.Empty
        cmbRMCode.SelectedIndex = -1
        cmbBinName.SelectedIndex = -1
        DgFinal.Item(0, 0).Value = String.Empty
        DgOver.Item(0, 0).Value = String.Empty
        DgUnder.Item(0, 0).Value = String.Empty
        DgSP1.Item(0, 0).Value = String.Empty
        DgSP2.Item(0, 0).Value = String.Empty
        DgCPS.Item(0, 0).Value = String.Empty
    End Sub
    Private Sub LoadMaterialData()
        Dim dt As DataTable = clsAdoxCached.GetDataTable("Select * from " & m_strViewForMaterialDetail)
        If Not dt Is Nothing Then
            DgDetail.Columns.Clear()
            DgDetail.DataSource = dt
        End If
    End Sub
#End Region

#Region "Public Function"

#End Region
End Class