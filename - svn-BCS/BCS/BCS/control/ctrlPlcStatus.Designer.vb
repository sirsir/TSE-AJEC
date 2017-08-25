<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlPlcStatus
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblFormula = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblLineName = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtBatchOilNo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtBatchNo = New System.Windows.Forms.TextBox()
        Me.DGData = New System.Windows.Forms.DataGridView()
        Me.ColRMName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColRMLot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColMax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColTarget = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColMin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColActual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDiff = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DGData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFormula
        '
        Me.lblFormula.BackColor = System.Drawing.SystemColors.ControlText
        Me.lblFormula.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormula.ForeColor = System.Drawing.Color.White
        Me.lblFormula.Location = New System.Drawing.Point(6, 23)
        Me.lblFormula.Name = "lblFormula"
        Me.lblFormula.Size = New System.Drawing.Size(156, 122)
        Me.lblFormula.TabIndex = 0
        Me.lblFormula.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(3, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Batch No."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.lblLineName)
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Controls.Add(Me.lblFormula)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(335, 208)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Formula Running"
        '
        'lblLineName
        '
        Me.lblLineName.AutoSize = True
        Me.lblLineName.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblLineName.Location = New System.Drawing.Point(33, 145)
        Me.lblLineName.Name = "lblLineName"
        Me.lblLineName.Size = New System.Drawing.Size(95, 63)
        Me.lblLineName.TabIndex = 5
        Me.lblLineName.Text = "B1"
        Me.lblLineName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Black
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.txtBatchOilNo, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(168, 112)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(161, 90)
        Me.TableLayoutPanel2.TabIndex = 4
        '
        'txtBatchOilNo
        '
        Me.txtBatchOilNo.BackColor = System.Drawing.Color.Black
        Me.txtBatchOilNo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBatchOilNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBatchOilNo.ForeColor = System.Drawing.Color.Lime
        Me.txtBatchOilNo.Location = New System.Drawing.Point(3, 39)
        Me.txtBatchOilNo.Name = "txtBatchOilNo"
        Me.txtBatchOilNo.ReadOnly = True
        Me.txtBatchOilNo.Size = New System.Drawing.Size(155, 37)
        Me.txtBatchOilNo.TabIndex = 6
        Me.txtBatchOilNo.Text = "0"
        Me.txtBatchOilNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(4, 2)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(153, 32)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Batch Oil No."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Black
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtBatchNo, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(168, 16)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(161, 90)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'txtBatchNo
        '
        Me.txtBatchNo.BackColor = System.Drawing.Color.Black
        Me.txtBatchNo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBatchNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBatchNo.ForeColor = System.Drawing.Color.Lime
        Me.txtBatchNo.Location = New System.Drawing.Point(3, 39)
        Me.txtBatchNo.Name = "txtBatchNo"
        Me.txtBatchNo.ReadOnly = True
        Me.txtBatchNo.Size = New System.Drawing.Size(155, 37)
        Me.txtBatchNo.TabIndex = 5
        Me.txtBatchNo.Text = "0"
        Me.txtBatchNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DGData
        '
        Me.DGData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        Me.DGData.BackgroundColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DGData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColRMName, Me.ColRMLot, Me.ColMax, Me.ColTarget, Me.ColMin, Me.ColActual, Me.ColDiff})
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGData.DefaultCellStyle = DataGridViewCellStyle14
        Me.DGData.Location = New System.Drawing.Point(337, 3)
        Me.DGData.Name = "DGData"
        Me.DGData.ReadOnly = True
        Me.DGData.RowHeadersVisible = False
        Me.DGData.Size = New System.Drawing.Size(1247, 208)
        Me.DGData.TabIndex = 5
        '
        'ColRMName
        '
        Me.ColRMName.HeaderText = "RM/Name"
        Me.ColRMName.Name = "ColRMName"
        Me.ColRMName.ReadOnly = True
        Me.ColRMName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColRMName.Width = 200
        '
        'ColRMLot
        '
        Me.ColRMLot.HeaderText = "RMLOT"
        Me.ColRMLot.Name = "ColRMLot"
        Me.ColRMLot.ReadOnly = True
        Me.ColRMLot.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColRMLot.Width = 280
        '
        'ColMax
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N2"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.ColMax.DefaultCellStyle = DataGridViewCellStyle9
        Me.ColMax.HeaderText = "MAX"
        Me.ColMax.Name = "ColMax"
        Me.ColMax.ReadOnly = True
        Me.ColMax.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColMax.Width = 150
        '
        'ColTarget
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "N2"
        Me.ColTarget.DefaultCellStyle = DataGridViewCellStyle10
        Me.ColTarget.HeaderText = "TARGET"
        Me.ColTarget.Name = "ColTarget"
        Me.ColTarget.ReadOnly = True
        Me.ColTarget.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColTarget.Width = 150
        '
        'ColMin
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "N2"
        Me.ColMin.DefaultCellStyle = DataGridViewCellStyle11
        Me.ColMin.HeaderText = "MIN"
        Me.ColMin.Name = "ColMin"
        Me.ColMin.ReadOnly = True
        Me.ColMin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColMin.Width = 150
        '
        'ColActual
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.Format = "N2"
        DataGridViewCellStyle12.NullValue = Nothing
        Me.ColActual.DefaultCellStyle = DataGridViewCellStyle12
        Me.ColActual.HeaderText = "ACTUAL"
        Me.ColActual.Name = "ColActual"
        Me.ColActual.ReadOnly = True
        Me.ColActual.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColActual.Width = 150
        '
        'ColDiff
        '
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle13.Format = "N2"
        Me.ColDiff.DefaultCellStyle = DataGridViewCellStyle13
        Me.ColDiff.HeaderText = "DIFF"
        Me.ColDiff.Name = "ColDiff"
        Me.ColDiff.ReadOnly = True
        Me.ColDiff.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColDiff.Width = 150
        '
        'ctrlPlcStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlText
        Me.Controls.Add(Me.DGData)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ctrlPlcStatus"
        Me.Size = New System.Drawing.Size(1587, 214)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.DGData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblFormula As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents DGData As System.Windows.Forms.DataGridView
    Friend WithEvents txtBatchOilNo As System.Windows.Forms.TextBox
    Friend WithEvents txtBatchNo As System.Windows.Forms.TextBox
    Friend WithEvents ColRMName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColRMLot As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColMax As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColTarget As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColMin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColActual As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColDiff As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblLineName As System.Windows.Forms.Label

End Class
