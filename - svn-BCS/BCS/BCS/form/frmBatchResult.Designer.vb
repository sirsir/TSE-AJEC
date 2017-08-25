<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBatchResult
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblShiftString = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblTimeString = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblDateString = New System.Windows.Forms.Label()
        Me.btnShiftMenu = New System.Windows.Forms.Button()
        Me.lblShift = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.v = New System.Windows.Forms.TableLayoutPanel()
        Me.btnFormulaB2 = New System.Windows.Forms.Button()
        Me.btnFormulaB1 = New System.Windows.Forms.Button()
        Me.btnReportB2 = New System.Windows.Forms.Button()
        Me.btnReportB1 = New System.Windows.Forms.Button()
        Me.btnGraphicLineB2 = New System.Windows.Forms.Button()
        Me.btnGraphicLineB1 = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.CtrlPlcStatus2 = New BCS.ctrlPlcStatus()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.CtrlPlcStatusLight2 = New BCS.CtrlPlcStatusLight()
        Me.CtrlPlcStatusLight1 = New BCS.CtrlPlcStatusLight()
        Me.DgLog = New System.Windows.Forms.DataGridView()
        Me.ColNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColLog = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CtrlPlcStatus1 = New BCS.ctrlPlcStatus()
        Me.tmr1Sec = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.v.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.DgLog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 8
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.lblShiftString, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblTime, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblTimeString, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblDate, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblDateString, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnShiftMenu, 6, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblShift, 5, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1587, 44)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'lblShiftString
        '
        Me.lblShiftString.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblShiftString.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblShiftString.Location = New System.Drawing.Point(603, 0)
        Me.lblShiftString.Name = "lblShiftString"
        Me.lblShiftString.Size = New System.Drawing.Size(94, 44)
        Me.lblShiftString.TabIndex = 6
        Me.lblShiftString.Text = "กะที่"
        Me.lblShiftString.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblShiftString.Visible = False
        '
        'lblTime
        '
        Me.lblTime.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblTime.Location = New System.Drawing.Point(403, 0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(194, 44)
        Me.lblTime.TabIndex = 5
        Me.lblTime.Text = "11:07:11"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTimeString
        '
        Me.lblTimeString.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTimeString.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblTimeString.Location = New System.Drawing.Point(303, 0)
        Me.lblTimeString.Name = "lblTimeString"
        Me.lblTimeString.Size = New System.Drawing.Size(94, 44)
        Me.lblTimeString.TabIndex = 4
        Me.lblTimeString.Text = "Time"
        Me.lblTimeString.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDate
        '
        Me.lblDate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblDate.Location = New System.Drawing.Point(103, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(194, 44)
        Me.lblDate.TabIndex = 3
        Me.lblDate.Text = "10/06/2012"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDateString
        '
        Me.lblDateString.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblDateString.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblDateString.Location = New System.Drawing.Point(3, 0)
        Me.lblDateString.Name = "lblDateString"
        Me.lblDateString.Size = New System.Drawing.Size(94, 44)
        Me.lblDateString.TabIndex = 2
        Me.lblDateString.Text = "Date"
        Me.lblDateString.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnShiftMenu
        '
        Me.btnShiftMenu.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnShiftMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnShiftMenu.Location = New System.Drawing.Point(803, 3)
        Me.btnShiftMenu.Name = "btnShiftMenu"
        Me.btnShiftMenu.Size = New System.Drawing.Size(114, 38)
        Me.btnShiftMenu.TabIndex = 8
        Me.btnShiftMenu.Text = "ตั้งค่ากะ"
        Me.btnShiftMenu.UseVisualStyleBackColor = True
        Me.btnShiftMenu.Visible = False
        '
        'lblShift
        '
        Me.lblShift.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblShift.AutoSize = True
        Me.lblShift.Location = New System.Drawing.Point(750, 15)
        Me.lblShift.Name = "lblShift"
        Me.lblShift.Size = New System.Drawing.Size(0, 13)
        Me.lblShift.TabIndex = 9
        Me.lblShift.Visible = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.v, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.CtrlPlcStatus2, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.CtrlPlcStatus1, 0, 2)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 220.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 220.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 190.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1593, 876)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'v
        '
        Me.v.ColumnCount = 8
        Me.v.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.v.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.v.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.v.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.v.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.v.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.v.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.v.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.v.Controls.Add(Me.btnFormulaB2, 5, 0)
        Me.v.Controls.Add(Me.btnFormulaB1, 4, 0)
        Me.v.Controls.Add(Me.btnReportB2, 3, 0)
        Me.v.Controls.Add(Me.btnReportB1, 2, 0)
        Me.v.Controls.Add(Me.btnGraphicLineB2, 1, 0)
        Me.v.Controls.Add(Me.btnGraphicLineB1, 0, 0)
        Me.v.Controls.Add(Me.btnExit, 6, 0)
        Me.v.Location = New System.Drawing.Point(3, 53)
        Me.v.Name = "v"
        Me.v.RowCount = 1
        Me.v.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.v.Size = New System.Drawing.Size(1587, 94)
        Me.v.TabIndex = 2
        '
        'btnFormulaB2
        '
        Me.btnFormulaB2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFormulaB2.Image = Global.BCS.My.Resources.Resources.Formula_1600x900
        Me.btnFormulaB2.Location = New System.Drawing.Point(1003, 3)
        Me.btnFormulaB2.Name = "btnFormulaB2"
        Me.btnFormulaB2.Size = New System.Drawing.Size(194, 88)
        Me.btnFormulaB2.TabIndex = 5
        Me.btnFormulaB2.Text = "B4" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "สูตร"
        Me.btnFormulaB2.UseVisualStyleBackColor = True
        '
        'btnFormulaB1
        '
        Me.btnFormulaB1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFormulaB1.Image = Global.BCS.My.Resources.Resources.Formula_1600x900
        Me.btnFormulaB1.Location = New System.Drawing.Point(803, 3)
        Me.btnFormulaB1.Name = "btnFormulaB1"
        Me.btnFormulaB1.Size = New System.Drawing.Size(194, 88)
        Me.btnFormulaB1.TabIndex = 4
        Me.btnFormulaB1.Text = "B3" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "สูตร"
        Me.btnFormulaB1.UseVisualStyleBackColor = True
        '
        'btnReportB2
        '
        Me.btnReportB2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportB2.Image = Global.BCS.My.Resources.Resources.Formula_1600x900
        Me.btnReportB2.Location = New System.Drawing.Point(603, 3)
        Me.btnReportB2.Name = "btnReportB2"
        Me.btnReportB2.Size = New System.Drawing.Size(194, 88)
        Me.btnReportB2.TabIndex = 3
        Me.btnReportB2.Text = "B4" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "รายงาน"
        Me.btnReportB2.UseVisualStyleBackColor = True
        '
        'btnReportB1
        '
        Me.btnReportB1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportB1.Image = Global.BCS.My.Resources.Resources.Formula_1600x900
        Me.btnReportB1.Location = New System.Drawing.Point(403, 3)
        Me.btnReportB1.Name = "btnReportB1"
        Me.btnReportB1.Size = New System.Drawing.Size(194, 88)
        Me.btnReportB1.TabIndex = 2
        Me.btnReportB1.Text = "B3" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "รายงาน"
        Me.btnReportB1.UseVisualStyleBackColor = True
        '
        'btnGraphicLineB2
        '
        Me.btnGraphicLineB2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.btnGraphicLineB2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnGraphicLineB2.Image = Global.BCS.My.Resources.Resources.Graphic_1600x900
        Me.btnGraphicLineB2.Location = New System.Drawing.Point(203, 3)
        Me.btnGraphicLineB2.Name = "btnGraphicLineB2"
        Me.btnGraphicLineB2.Size = New System.Drawing.Size(194, 88)
        Me.btnGraphicLineB2.TabIndex = 1
        Me.btnGraphicLineB2.Text = "GRAPHIC LINE B4"
        Me.btnGraphicLineB2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGraphicLineB2.UseVisualStyleBackColor = True
        '
        'btnGraphicLineB1
        '
        Me.btnGraphicLineB1.AutoSize = True
        Me.btnGraphicLineB1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnGraphicLineB1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnGraphicLineB1.Image = Global.BCS.My.Resources.Resources.Graphic_1600x900
        Me.btnGraphicLineB1.Location = New System.Drawing.Point(3, 3)
        Me.btnGraphicLineB1.Name = "btnGraphicLineB1"
        Me.btnGraphicLineB1.Size = New System.Drawing.Size(194, 88)
        Me.btnGraphicLineB1.TabIndex = 0
        Me.btnGraphicLineB1.Text = "GRAPHIC LINE B3"
        Me.btnGraphicLineB1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGraphicLineB1.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(1203, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(194, 88)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'CtrlPlcStatus2
        '
        Me.CtrlPlcStatus2.BackColor = System.Drawing.SystemColors.ControlText
        Me.CtrlPlcStatus2.BatchNo = -1
        Me.CtrlPlcStatus2.BatchOilNo = -1
        Me.CtrlPlcStatus2.LineNo = 2
        Me.CtrlPlcStatus2.FormulaCode = 0
        Me.CtrlPlcStatus2.Location = New System.Drawing.Point(3, 373)
        Me.CtrlPlcStatus2.ManualBatchNo = -1
        Me.CtrlPlcStatus2.ManualBatchOilNo = -1
        Me.CtrlPlcStatus2.Name = "CtrlPlcStatus2"
        Me.CtrlPlcStatus2.Size = New System.Drawing.Size(1587, 214)
        Me.CtrlPlcStatus2.TabIndex = 5
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.AutoSize = True
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 432.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 432.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.CtrlPlcStatusLight2, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.CtrlPlcStatusLight1, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.DgLog, 0, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 593)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1587, 280)
        Me.TableLayoutPanel3.TabIndex = 6
        '
        'CtrlPlcStatusLight2
        '
        Me.CtrlPlcStatusLight2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CtrlPlcStatusLight2.EndProcess = False
        Me.CtrlPlcStatusLight2.LineNo = 2
        Me.CtrlPlcStatusLight2.Location = New System.Drawing.Point(1158, 3)
        Me.CtrlPlcStatusLight2.Name = "CtrlPlcStatusLight2"
        Me.CtrlPlcStatusLight2.RM1Complete = False
        Me.CtrlPlcStatusLight2.RM1Discharge = False
        Me.CtrlPlcStatusLight2.RM2Complete = False
        Me.CtrlPlcStatusLight2.RM2Discharge = False
        Me.CtrlPlcStatusLight2.RM3Complete = False
        Me.CtrlPlcStatusLight2.RM3Discharge = False
        Me.CtrlPlcStatusLight2.RM4Complete = False
        Me.CtrlPlcStatusLight2.RM4Discharge = False
        Me.CtrlPlcStatusLight2.RunReturn = False
        Me.CtrlPlcStatusLight2.Size = New System.Drawing.Size(426, 274)
        Me.CtrlPlcStatusLight2.TabIndex = 5
        '
        'CtrlPlcStatusLight1
        '
        Me.CtrlPlcStatusLight1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CtrlPlcStatusLight1.EndProcess = False
        Me.CtrlPlcStatusLight1.LineNo = 1
        Me.CtrlPlcStatusLight1.Location = New System.Drawing.Point(726, 3)
        Me.CtrlPlcStatusLight1.Name = "CtrlPlcStatusLight1"
        Me.CtrlPlcStatusLight1.RM1Complete = False
        Me.CtrlPlcStatusLight1.RM1Discharge = False
        Me.CtrlPlcStatusLight1.RM2Complete = False
        Me.CtrlPlcStatusLight1.RM2Discharge = False
        Me.CtrlPlcStatusLight1.RM3Complete = False
        Me.CtrlPlcStatusLight1.RM3Discharge = False
        Me.CtrlPlcStatusLight1.RM4Complete = False
        Me.CtrlPlcStatusLight1.RM4Discharge = False
        Me.CtrlPlcStatusLight1.RunReturn = False
        Me.CtrlPlcStatusLight1.Size = New System.Drawing.Size(426, 274)
        Me.CtrlPlcStatusLight1.TabIndex = 3
        '
        'DgLog
        '
        Me.DgLog.AllowUserToAddRows = False
        Me.DgLog.AllowUserToDeleteRows = False
        Me.DgLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgLog.ColumnHeadersVisible = False
        Me.DgLog.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColNo, Me.ColDate, Me.ColTime, Me.ColLog})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgLog.DefaultCellStyle = DataGridViewCellStyle1
        Me.DgLog.Location = New System.Drawing.Point(3, 3)
        Me.DgLog.Name = "DgLog"
        Me.DgLog.ReadOnly = True
        Me.DgLog.RowHeadersVisible = False
        Me.DgLog.Size = New System.Drawing.Size(717, 274)
        Me.DgLog.TabIndex = 6
        '
        'ColNo
        '
        Me.ColNo.HeaderText = "No."
        Me.ColNo.Name = "ColNo"
        Me.ColNo.ReadOnly = True
        Me.ColNo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColNo.Width = 30
        '
        'ColDate
        '
        Me.ColDate.HeaderText = "Date"
        Me.ColDate.Name = "ColDate"
        Me.ColDate.ReadOnly = True
        Me.ColDate.Width = 80
        '
        'ColTime
        '
        Me.ColTime.HeaderText = "Time"
        Me.ColTime.Name = "ColTime"
        Me.ColTime.ReadOnly = True
        Me.ColTime.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColTime.Width = 50
        '
        'ColLog
        '
        Me.ColLog.HeaderText = "Log"
        Me.ColLog.Name = "ColLog"
        Me.ColLog.ReadOnly = True
        Me.ColLog.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColLog.Width = 530
        '
        'CtrlPlcStatus1
        '
        Me.CtrlPlcStatus1.BackColor = System.Drawing.SystemColors.ControlText
        Me.CtrlPlcStatus1.BatchNo = -1
        Me.CtrlPlcStatus1.BatchOilNo = -1
        Me.CtrlPlcStatus1.LineNo = 1
        Me.CtrlPlcStatus1.FormulaCode = 0
        Me.CtrlPlcStatus1.Location = New System.Drawing.Point(3, 153)
        Me.CtrlPlcStatus1.ManualBatchNo = -1
        Me.CtrlPlcStatus1.ManualBatchOilNo = -1
        Me.CtrlPlcStatus1.Name = "CtrlPlcStatus1"
        Me.CtrlPlcStatus1.Size = New System.Drawing.Size(1587, 214)
        Me.CtrlPlcStatus1.TabIndex = 4
        '
        'tmr1Sec
        '
        Me.tmr1Sec.Enabled = True
        Me.tmr1Sec.Interval = 1000
        '
        'frmBatchResult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1594, 876)
        Me.ControlBox = False
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximumSize = New System.Drawing.Size(1600, 900)
        Me.Name = "frmBatchResult"
        Me.Text = "BATCH RESULT"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.v.ResumeLayout(False)
        Me.v.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.DgLog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblShiftString As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblTimeString As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblDateString As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents v As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnFormulaB2 As System.Windows.Forms.Button
    Friend WithEvents btnFormulaB1 As System.Windows.Forms.Button
    Friend WithEvents btnReportB2 As System.Windows.Forms.Button
    Friend WithEvents btnReportB1 As System.Windows.Forms.Button
    Friend WithEvents btnGraphicLineB2 As System.Windows.Forms.Button
    Friend WithEvents btnGraphicLineB1 As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents CtrlPlcStatus1 As BCS.ctrlPlcStatus
    Friend WithEvents CtrlPlcStatus2 As BCS.ctrlPlcStatus
    Friend WithEvents CtrlPlcStatusLight1 As BCS.CtrlPlcStatusLight
    Friend WithEvents CtrlPlcStatusLight2 As BCS.CtrlPlcStatusLight
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents DgLog As System.Windows.Forms.DataGridView
    Friend WithEvents tmr1Sec As System.Windows.Forms.Timer
    Friend WithEvents btnShiftMenu As System.Windows.Forms.Button
    Friend WithEvents lblShift As System.Windows.Forms.Label
    Friend WithEvents ColNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColTime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColLog As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
