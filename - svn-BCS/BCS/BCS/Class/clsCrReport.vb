Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Windows.Forms

Public Class clsCrReport
#Region "Attributes"
    Public Shared m_strReportFolderName As String = "DailyReport"
#End Region

#Region "Property"
    Public Shared Property ReportFolderName() As String
        Get
            Return m_strReportFolderName
        End Get
        Set(ByVal value As String)
            m_strReportFolderName = value
        End Set
    End Property
#End Region

#Region "Constructor"
    Protected Sub New()
        Reset()
    End Sub

    Public Overridable Sub Reset()
        m_strReportFolderName = "DailyReport"
    End Sub
#End Region

#Region "method"
    Public Shared Sub CreateReportWeight(ByVal dtStartingDate As DateTime,
                                   ByVal dtEndingDate As DateTime,
                                   ByVal intLineNo As Integer,
                                   ByVal intFormulaId As Integer,
                                   Optional ByVal bDisplayAfterExport As Boolean = False,
                                   Optional ByVal bAutoPrint As Boolean = False)
        Dim CrReport As New RptDaily ' Report Name
        Dim CrExportOptions As ExportOptions
        Dim CrDiskFileDestinationOptions As New DiskFileDestinationOptions()
        Dim CrFormatTypeOptions As New PdfRtfWordFormatOptions()
        Dim strSQL As String
        Dim dt As DataTable
        Dim intShift As Integer
        Dim intFormula As Integer
        Dim dtShiftInfo As DataTable
        Dim dtFormulaInfo As DataTable
        Dim intPdfFileCount As Integer = 0
        Dim strDiskInitName As String
        Dim strReportName As String
        Dim strDate As String
        'Trap any errors that occur on export
        Try
            'if the folder is not exist then create one
            If (Not System.IO.Directory.Exists(My.Application.Info.DirectoryPath & "\" & ReportFolderName)) Then
                System.IO.Directory.CreateDirectory(My.Application.Info.DirectoryPath & "\" & ReportFolderName)
            End If

            'set initial name for file by using date
            If dtStartingDate.Year = dtEndingDate.Year And dtStartingDate.Month = dtEndingDate.Month And dtStartingDate.Day = dtEndingDate.Day Then
                strDate = GetDateFormat(dtStartingDate)
            Else
                strDate = GetDateFormat(dtStartingDate) & "TO" & GetDateFormat(dtEndingDate)
            End If
            strDiskInitName = My.Application.Info.DirectoryPath & "\" & ReportFolderName & "\"


            'need to print each shift/formula separately
            dtShiftInfo = clsShiftInfo.FindAll
            dtFormulaInfo = clsFormulaInfo.FindByLineNo(intLineNo)
            For intShift = 0 To dtShiftInfo.Rows.Count - 1
                For intFormula = 0 To dtFormulaInfo.Rows.Count - 1
                    dt = Nothing
                    If dtFormulaInfo.Rows(intFormula).Item("FORMULA_ID") = intFormulaId Then
                        'strSQL = "SELECT * FROM V_DAILY_REPORT_WEIGHT " & _
                        '                                                    " WHERE BATCH_DATE >= '" & dtStartingDate.ToString("yyyy-MM-dd HH:mm:ss.fff") & "'" & _
                        '                                                    " AND BATCH_DATE <= '" & dtEndingDate.ToString("yyyy-MM-dd HH:mm:ss.fff") & "'" & _
                        '                                                    " AND SHIFT_CODE = " & dtShiftInfo.Rows(intShift).Item("SHIFT_CODE") & _
                        '                                                    " AND FORMULA_NAME = '" & dtFormulaInfo.Rows(intFormula).Item("FORMULA_NAME") & "'" & _
                        '                                                    " AND LINE_NO = " & intLineNo
                        strSQL = "SELECT * FROM V_DAILY_REPORT_WEIGHT " & _
                                                                            " WHERE BATCH_DATE >= '" & dtStartingDate.ToString("s") & "'" & _
                                                                            " AND BATCH_DATE <= '" & dtEndingDate.ToString("s") & "'" & _
                                                                            " AND SHIFT_CODE = " & dtShiftInfo.Rows(intShift).Item("SHIFT_CODE") & _
                                                                            " AND FORMULA_NAME = '" & dtFormulaInfo.Rows(intFormula).Item("FORMULA_NAME") & "'" & _
                                                                            " AND LINE_NO = " & intLineNo & _
                                                                            " ORDER BY 1 "
                        dt = clsAdoxCached.GetDataTable(strSQL)
                    End If

                    If Not dt Is Nothing AndAlso dt.Rows.Count > 0 Then
                        'Set the destination path and file name 
                        'm_strReportFolderName = "DailyReport"
                        strReportName = strDate & "_" & _
                                        "L" & clsLineInfo.FindLineCode(intLineNo).ToString & _
                                        "S" & dtShiftInfo.Rows(intShift).Item("SHIFT_CODE").ToString & _
                                        "F" & dtFormulaInfo.Rows(intFormula).Item("FORMULA_NAME").ToString & _
                                        ".pdf"
                        CrDiskFileDestinationOptions.DiskFileName = strDiskInitName & strReportName
                        'Specify a page range (optional)
                        CrFormatTypeOptions.FirstPageNumber = 1 ' Start Page in the Report

                        'CrFormatTypeOptions.LastPageNumber = 3 ' End Page in the Report

                        CrReport.SetDataSource(dt)

                        '------------
                        Dim pdvStartingDate As New CrystalDecisions.Shared.ParameterDiscreteValue
                        Dim pdvEndingDate As New CrystalDecisions.Shared.ParameterDiscreteValue
                        Dim pdvFormulaName As New CrystalDecisions.Shared.ParameterDiscreteValue
                        Dim pdvLineNo As New CrystalDecisions.Shared.ParameterDiscreteValue
                        Dim pdvShiftCode As New CrystalDecisions.Shared.ParameterDiscreteValue
                        Dim pdvBuildingName As New CrystalDecisions.Shared.ParameterDiscreteValue

                        Dim pvStartingDate As New CrystalDecisions.Shared.ParameterValues
                        Dim pvEndingDate As New CrystalDecisions.Shared.ParameterValues
                        Dim pvFormulaName As New CrystalDecisions.Shared.ParameterValues
                        Dim pvLineNo As New CrystalDecisions.Shared.ParameterValues
                        Dim pvShiftCode As New CrystalDecisions.Shared.ParameterValues
                        Dim pvBuildingName As New CrystalDecisions.Shared.ParameterValues

                        pdvStartingDate.Value = dtStartingDate.ToString("dd-MM-yyyy")
                        pdvEndingDate.Value = dtEndingDate.ToString("dd-MM-yyyy")
                        pdvFormulaName.Value = dtFormulaInfo.Rows(intFormula).Item("FORMULA_NAME").ToString
                        pdvLineNo.Value = clsLineInfo.FindLineCode(intLineNo).Replace("B", "").ToString
                        pdvShiftCode.Value = dtShiftInfo.Rows(intShift).Item("SHIFT_CODE").ToString
                        pdvBuildingName.Value = My.Settings.g_strBuildingName

                        pvStartingDate.Add(pdvStartingDate)
                        pvEndingDate.Add(pdvEndingDate)
                        pvFormulaName.Add(pdvFormulaName)
                        pvLineNo.Add(pdvLineNo)
                        pvShiftCode.Add(pdvShiftCode)
                        pvBuildingName.Add(pdvBuildingName)

                        CrReport.DataDefinition.ParameterFields("strStartingDate").ApplyCurrentValues(pvStartingDate)
                        CrReport.DataDefinition.ParameterFields("strEndingDate").ApplyCurrentValues(pvEndingDate)
                        CrReport.DataDefinition.ParameterFields("strFormulaName").ApplyCurrentValues(pvFormulaName)
                        CrReport.DataDefinition.ParameterFields("strLineNo").ApplyCurrentValues(pvLineNo)
                        CrReport.DataDefinition.ParameterFields("strShiftCode").ApplyCurrentValues(pvShiftCode)
                        CrReport.DataDefinition.ParameterFields("strBuildingName").ApplyCurrentValues(pvBuildingName)

                        'CrReport.Parameter_strStartingDate.CurrentValues.Add(pdvStartingDate)
                        'CrReport.Parameter_strEndingDate.CurrentValues.Add(pdvEndingDate)
                        'CrReport.Parameter_strFormulaName.CurrentValues.Add(pdvFormulaName)
                        'CrReport.Parameter_strLineNo.CurrentValues.Add(pdvLineNo)
                        'CrReport.Parameter_strShiftCode.CurrentValues.Add(pdvShiftCode)
                        '------------

                        'Set export options
                        CrExportOptions = CrReport.ExportOptions

                        With CrExportOptions
                            'Set the destination to a disk file
                            .ExportDestinationType = ExportDestinationType.DiskFile

                            'Set the format to PDF
                            .ExportFormatType = ExportFormatType.PortableDocFormat

                            'Set the destination options to DiskFileDestinationOptions object
                            .DestinationOptions = CrDiskFileDestinationOptions
                            .FormatOptions = CrFormatTypeOptions
                        End With
                        'Export the report
                        CrReport.Export()
                        clsLog.AddLog(clsLog.eWriteLog.RptCreate, "[" & strReportName & "]")

                        'count number of pdf file
                        intPdfFileCount = intPdfFileCount + 1

                        'display
                        If bDisplayAfterExport = True Then
                            DisplayWeightCrReport(CrReport)
                            clsLog.AddLog(clsLog.eWriteLog.RptView, "[" & strReportName & "]")
                        End If

                        'auto print
                        If bAutoPrint = True Then
                            PrintWeightReport(CrReport, dt.Rows.Count / 30 + IIf(dt.Rows.Count Mod 30 > 0, 1, 0))
                            clsLog.AddLog(clsLog.eWriteLog.RptPrint, "[" & strReportName & "]")
                        End If
                    End If
                Next
            Next
            If intPdfFileCount = 0 Then
                MsgBox("No Report during " & strDate)
            End If
        Catch ex As Exception
            MessageBox.Show("clsCrReport.CreateReport : " & ex.ToString())
        End Try
    End Sub
    Public Shared Sub CreateReportLiquid(ByVal dtStartingDate As DateTime,
                                   ByVal dtEndingDate As DateTime,
                                   ByVal intLineNo As Integer,
                                   ByVal intFormulaId As Integer,
                                   Optional ByVal bDisplayAfterExport As Boolean = False,
                                   Optional ByVal bAutoPrint As Boolean = False)
        Dim CrReport As New RptOilDaily ' Report Name
        Dim CrExportOptions As ExportOptions
        Dim CrDiskFileDestinationOptions As New DiskFileDestinationOptions()
        Dim CrFormatTypeOptions As New PdfRtfWordFormatOptions()
        Dim strSQL As String
        Dim dt As DataTable
        Dim intShift As Integer
        Dim intFormula As Integer
        Dim dtShiftInfo As DataTable
        Dim dtFormulaInfo As DataTable
        Dim intPdfFileCount As Integer = 0
        Dim strDiskInitName As String
        Dim strReportName As String
        Dim strDate As String
        'Trap any errors that occur on export
        Try
            'if the folder is not exist then create one
            If (Not System.IO.Directory.Exists(ReportFolderName)) Then
                System.IO.Directory.CreateDirectory(ReportFolderName)
            End If

            'set initial name for file by using date
            If dtStartingDate.Year = dtEndingDate.Year And dtStartingDate.Month = dtEndingDate.Month And dtStartingDate.Day = dtEndingDate.Day Then
                strDate = GetDateFormat(dtStartingDate)
            Else
                strDate = GetDateFormat(dtStartingDate) & "TO" & GetDateFormat(dtEndingDate)
            End If
            strDiskInitName = IO.Directory.GetCurrentDirectory & "\" & ReportFolderName & "\"


            'need to print each shift/formula separately
            dtShiftInfo = clsShiftInfo.FindAll
            dtFormulaInfo = clsFormulaInfo.FindByLineNo(intLineNo)
            For intShift = 0 To dtShiftInfo.Rows.Count - 1
                For intFormula = 0 To dtFormulaInfo.Rows.Count - 1
                    dt = Nothing
                    If dtFormulaInfo.Rows(intFormula).Item("FORMULA_ID") = intFormulaId Then
                        'strSQL = "SELECT * FROM V_DAILY_REPORT_WEIGHT " & _
                        '                                                    " WHERE BATCH_DATE >= '" & dtStartingDate.ToString("yyyy-MM-dd HH:mm:ss.fff") & "'" & _
                        '                                                    " AND BATCH_DATE <= '" & dtEndingDate.ToString("yyyy-MM-dd HH:mm:ss.fff") & "'" & _
                        '                                                    " AND SHIFT_CODE = " & dtShiftInfo.Rows(intShift).Item("SHIFT_CODE") & _
                        '                                                    " AND FORMULA_NAME = '" & dtFormulaInfo.Rows(intFormula).Item("FORMULA_NAME") & "'" & _
                        '                                                    " AND LINE_NO = " & intLineNo
                        strSQL = "SELECT * FROM V_DAILY_REPORT_LIQUID " & _
                                                                            " WHERE BATCH_DATE >= '" & dtStartingDate.ToString("s") & "'" & _
                                                                            " AND BATCH_DATE <= '" & dtEndingDate.ToString("s") & "'" & _
                                                                            " AND SHIFT_CODE = " & dtShiftInfo.Rows(intShift).Item("SHIFT_CODE") & _
                                                                            " AND FORMULA_NAME = '" & dtFormulaInfo.Rows(intFormula).Item("FORMULA_NAME") & "'" & _
                                                                            " AND LINE_NO = " & intLineNo & _
                                                                            " ORDER BY 1 "
                        dt = clsAdoxCached.GetDataTable(strSQL)
                    End If


                    If Not dt Is Nothing AndAlso dt.Rows.Count > 0 Then
                        'Set the destination path and file name 
                        'm_strReportFolderName = "DailyReport"
                        strReportName = strDate & "_" & _
                                        "L" & clsLineInfo.FindLineCode(intLineNo).ToString & _
                                        "S" & dtShiftInfo.Rows(intShift).Item("SHIFT_CODE").ToString & _
                                        "F" & dtFormulaInfo.Rows(intFormula).Item("FORMULA_NAME").ToString & _
                                        ".pdf"
                        CrDiskFileDestinationOptions.DiskFileName = strDiskInitName & strReportName
                        'Specify a page range (optional)
                        CrFormatTypeOptions.FirstPageNumber = 1 ' Start Page in the Report

                        'CrFormatTypeOptions.LastPageNumber = 3 ' End Page in the Report

                        CrReport.SetDataSource(dt)

                        '------------
                        Dim pdvStartingDate As New CrystalDecisions.Shared.ParameterDiscreteValue
                        Dim pdvEndingDate As New CrystalDecisions.Shared.ParameterDiscreteValue
                        Dim pdvFormulaName As New CrystalDecisions.Shared.ParameterDiscreteValue
                        Dim pdvLineNo As New CrystalDecisions.Shared.ParameterDiscreteValue
                        Dim pdvShiftCode As New CrystalDecisions.Shared.ParameterDiscreteValue

                        Dim pvStartingDate As New CrystalDecisions.Shared.ParameterValues
                        Dim pvEndingDate As New CrystalDecisions.Shared.ParameterValues
                        Dim pvFormulaName As New CrystalDecisions.Shared.ParameterValues
                        Dim pvLineNo As New CrystalDecisions.Shared.ParameterValues
                        Dim pvShiftCode As New CrystalDecisions.Shared.ParameterValues

                        pdvStartingDate.Value = dtStartingDate.ToString("yyyy-MM-dd")
                        pdvEndingDate.Value = dtEndingDate.ToString("yyyy-MM-dd")
                        pdvFormulaName.Value = dtFormulaInfo.Rows(intFormula).Item("FORMULA_NAME").ToString
                        pdvLineNo.Value = intLineNo.ToString
                        pdvShiftCode.Value = dtShiftInfo.Rows(intShift).Item("SHIFT_CODE").ToString

                        pvStartingDate.Add(pdvStartingDate)
                        pvEndingDate.Add(pdvEndingDate)
                        pvFormulaName.Add(pdvFormulaName)
                        pvLineNo.Add(pdvLineNo)
                        pvShiftCode.Add(pdvShiftCode)

                        CrReport.DataDefinition.ParameterFields("strStartingDate").ApplyCurrentValues(pvStartingDate)
                        CrReport.DataDefinition.ParameterFields("strEndingDate").ApplyCurrentValues(pvEndingDate)
                        CrReport.DataDefinition.ParameterFields("strFormulaName").ApplyCurrentValues(pvFormulaName)
                        CrReport.DataDefinition.ParameterFields("strLineNo").ApplyCurrentValues(pvLineNo)
                        CrReport.DataDefinition.ParameterFields("strShiftCode").ApplyCurrentValues(pvShiftCode)

                        'CrReport.Parameter_strStartingDate.CurrentValues.Add(pdvStartingDate)
                        'CrReport.Parameter_strEndingDate.CurrentValues.Add(pdvEndingDate)
                        'CrReport.Parameter_strFormulaName.CurrentValues.Add(pdvFormulaName)
                        'CrReport.Parameter_strLineNo.CurrentValues.Add(pdvLineNo)
                        'CrReport.Parameter_strShiftCode.CurrentValues.Add(pdvShiftCode)
                        '------------

                        'Set export options
                        CrExportOptions = CrReport.ExportOptions

                        With CrExportOptions
                            'Set the destination to a disk file
                            .ExportDestinationType = ExportDestinationType.DiskFile

                            'Set the format to PDF
                            .ExportFormatType = ExportFormatType.PortableDocFormat

                            'Set the destination options to DiskFileDestinationOptions object
                            .DestinationOptions = CrDiskFileDestinationOptions
                            .FormatOptions = CrFormatTypeOptions
                        End With
                        'Export the report
                        CrReport.Export()
                        clsLog.AddLog(clsLog.eWriteLog.RptCreate, "[" & strReportName & "]")

                        'count number of pdf file
                        intPdfFileCount = intPdfFileCount + 1

                        'display
                        If bDisplayAfterExport = True Then
                            DisplayLiquidCrReport(CrReport)
                            clsLog.AddLog(clsLog.eWriteLog.RptView, "[" & strReportName & "]")
                        End If

                        'auto print
                        If bAutoPrint = True Then
                            PrintLiquidReport(CrReport, dt.Rows.Count / 30 + IIf(dt.Rows.Count Mod 30 > 0, 1, 0))
                            clsLog.AddLog(clsLog.eWriteLog.RptPrint, "[" & strReportName & "]")
                        End If
                    End If
                Next
            Next
            If intPdfFileCount = 0 Then
                MsgBox("No Report during " & strDate)
            End If
        Catch ex As Exception
            MessageBox.Show("clsCrReport.CreateReport : " & ex.ToString())
        End Try
    End Sub
    Public Shared Sub DisplayWeightCrReport(ByVal CrReport As RptDaily)
        Dim frm As frmCrReport = New frmCrReport
        Dim rptViewer As CrystalReportViewer = New CrystalReportViewer

        Try
            'set report property
            rptViewer.ActiveViewIndex = 0
            rptViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            rptViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            rptViewer.Dock = System.Windows.Forms.DockStyle.Fill
            rptViewer.Location = New System.Drawing.Point(0, 0)
            rptViewer.Name = "Viewer"
            rptViewer.ReportSource = CrReport
            rptViewer.Visible = True
            rptViewer.Show()

            'add report to panel in form
            frm.pnlCrReport.Controls.Add(rptViewer)

            'show report form
            frm.Show()
        Catch ex As Exception
            MessageBox.Show("clsCrReport.DisplayCrReport :" & ex.ToString)
        End Try
    End Sub

    Public Shared Sub DisplayLiquidCrReport(ByVal CrReport As RptOilDaily)
        Dim frm As frmCrReport = New frmCrReport
        Dim rptViewer As CrystalReportViewer = New CrystalReportViewer

        Try
            'set report property
            rptViewer.ActiveViewIndex = 0
            rptViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            rptViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            rptViewer.Dock = System.Windows.Forms.DockStyle.Fill
            rptViewer.Location = New System.Drawing.Point(0, 0)
            rptViewer.Name = "Viewer"
            rptViewer.ReportSource = CrReport
            rptViewer.Visible = True
            rptViewer.Show()

            'add report to panel in form
            frm.pnlCrReport.Controls.Add(rptViewer)

            'show report form
            frm.Show()
        Catch ex As Exception
            MessageBox.Show("clsCrReport.DisplayCrReport :" & ex.ToString)
        End Try
    End Sub
    Public Shared Sub DeleteReport(ByVal dtStartingDate As DateTime, ByVal dtEndingDate As DateTime)
        Dim strFileName As String
        Dim i As Integer
        Dim strDiskInitName As String
        Dim strDate As String
        Try
            'if the folder is not exist then create one
            If (Not System.IO.Directory.Exists(ReportFolderName)) Then
                System.IO.Directory.CreateDirectory(ReportFolderName)
            Else
                'get path name
                Dim strPathName As String() = IO.Directory.GetFiles(IO.Directory.GetCurrentDirectory & "\" & ReportFolderName)

                'get initial file name
                If dtStartingDate.Year = dtEndingDate.Year And dtStartingDate.Month = dtEndingDate.Month And dtStartingDate.Day = dtEndingDate.Day Then
                    strDate = GetDateFormat(dtStartingDate)
                Else
                    strDate = GetDateFormat(dtStartingDate) & "TO" & GetDateFormat(dtEndingDate)
                End If
                strDiskInitName = strDate & "_"

                'check if the file is report file then delete
                For i = strPathName.Length - 1 To 0 Step -1
                    strFileName = GetPdfFileNameFromPath(strPathName(i))
                    If strFileName <> String.Empty Then
                        If strFileName.Substring(0, strDiskInitName.Length) = strDiskInitName Then
                            Kill(strPathName(i))
                            clsLog.AddLog(clsLog.eWriteLog.RptDelete, "(" & strDate & ")")
                        End If
                    End If
                Next
            End If
        Catch ex As Exception
            MessageBox.Show("clsCrReport.DeleteReport :" & ex.ToString)
        End Try
    End Sub
    Public Shared Sub PrintWeightReport(ByVal crReport As RptDaily, ByVal intCountPage As Integer)
        Try
            'call to current active printer to make printing order
            crReport.PrintToPrinter(1, False, 1, intCountPage)
        Catch ex As Exception
            MessageBox.Show("clsCrReport.PrintReport :" & ex.ToString)
        End Try
    End Sub
    Public Shared Sub PrintLiquidReport(ByVal crReport As RptOilDaily, ByVal intCountPage As Integer)
        Try
            'call to current active printer to make printing order
            crReport.PrintToPrinter(1, False, 1, intCountPage)
        Catch ex As Exception
            MessageBox.Show("clsCrReport.PrintReport :" & ex.ToString)
        End Try
    End Sub
    Public Shared Function GetDateFormat(ByVal dtDate As Date) As String
        Dim strDate As String = String.Empty
        Try
            strDate = dtDate.Year & "-" & dtDate.Month & "-" & dtDate.Day
        Catch ex As Exception
            MessageBox.Show("clsCrReport.GetDateFormat :" & ex.ToString)
        End Try
        GetDateFormat = strDate
    End Function
    Public Shared Function GetPdfFileNameFromPath(ByVal strPath As String)
        Dim intIndex As Integer
        Try
            'Check if it's PDF File
            If strPath.Substring(strPath.Length - 4, 4) = ".PDF" Or strPath.Substring(strPath.Length - 4, 4) = ".pdf" Then
                'Remove Extension from path
                strPath = strPath.Substring(0, strPath.Length - 4)

                'Remove path to extract only PDF File Name
                For intIndex = strPath.Length - 1 To 0 Step -1
                    If strPath.Substring(intIndex, 1) = "\" Then
                        strPath = strPath.Substring(intIndex + 1, strPath.Length - (intIndex + 1))
                        Exit For
                    End If
                Next

                'return string.empty if the result is NULL
                If strPath Is Nothing Then
                    strPath = String.Empty
                End If

            Else
                'return string.empty if cannot get pdf extension
                strPath = String.Empty
            End If
        Catch ex As Exception
            MessageBox.Show("clsCrReport.GetPdfFileNameFromPath :" & ex.ToString)
            strPath = String.Empty
        End Try
        GetPdfFileNameFromPath = strPath
    End Function

#End Region

End Class
