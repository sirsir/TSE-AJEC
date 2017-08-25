Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Windows.Forms

Public Class frmReport

#Region "Public Variables"
    Public m_intLineNo As Integer = -1
#End Region

#Region "Private Variables"
    Dim m_strRoleId As String = "USR"
#End Region

#Region "Constructor AND Destructor"
    Public Sub New(ByVal strRoleId As String, ByVal intLineNo As Integer)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        m_strRoleId = strRoleId
        m_intLineNo = intLineNo

    End Sub
#End Region

#Region "Events"
    Private Sub frmReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            dtpStart.Value = Today()
            dtpEnd.Value = Today()
            Me.lblLine.Text = "LINE" & clsLineInfo.FindLineCode(m_intLineNo)

        Catch ex As Exception
            MessageBox.Show("frmReport_Load : " & ex.ToString())
        End Try
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        Try
            CreateReport(dtpStart.Value, dtpEnd.Value)
        Catch ex As Exception
            MessageBox.Show("btnView_Click : " & ex.ToString())
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            DeleteReport(dtpStart.Value, dtpEnd.Value)
        Catch ex As Exception
            MessageBox.Show("btnDelete_Click : " & ex.ToString())
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Try
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("btnClose_Click : " & ex.ToString())
        End Try
    End Sub
#End Region

#Region "Private Function"
    Private Function CheckDateFromTo(ByVal dtStartingDate As Date, ByVal dtEndingDate As Date) As Boolean
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
    Private Sub CreateReport(ByVal dtStartingDate As Date, ByVal dtEndingDate As Date)
        Try
            If CheckDateFromTo(dtStartingDate, dtEndingDate) Then
                'clsCrReport.CreateReportWeight(dtStartingDate, dtEndingDate, m_intLineNo, True)
            End If
        Catch ex As Exception
            MessageBox.Show("CreateReport : " & ex.ToString())
        End Try
    End Sub
    Private Sub DeleteReport(ByVal dtStartingDate As Date, ByVal dtEndingDate As Date)
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
End Class
