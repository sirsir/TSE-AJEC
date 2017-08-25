Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Windows.Forms

Public Class frmCrReport

#Region "Public Variables"
#End Region

#Region "Private Variables"
#End Region

#Region "Constructor AND Destructor"
    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub
#End Region
#Region "Events"

    Private Sub frmCrReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
        Catch ex As Exception
            MsgBox("Sub frmCrReport_Load")
        End Try
    End Sub
#End Region
End Class