<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBatchList
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvBatchList = New System.Windows.Forms.DataGridView()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.cmbShift = New System.Windows.Forms.ComboBox()
        Me.gbDateTime = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblLine = New System.Windows.Forms.Label()
        Me.cmbFormula = New System.Windows.Forms.ComboBox()
        Me.lblFormula = New System.Windows.Forms.Label()
        Me.lblShift = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnSetShift = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.cmbRMType = New System.Windows.Forms.ComboBox()
        Me.btnReBatch = New System.Windows.Forms.Button()
        CType(Me.dgvBatchList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDateTime.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvBatchList
        '
        Me.dgvBatchList.AllowUserToAddRows = False
        Me.dgvBatchList.AllowUserToDeleteRows = False
        Me.dgvBatchList.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dgvBatchList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBatchList.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvBatchList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvBatchList.Location = New System.Drawing.Point(12, 109)
        Me.dgvBatchList.Name = "dgvBatchList"
        Me.dgvBatchList.RowHeadersVisible = False
        Me.dgvBatchList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBatchList.Size = New System.Drawing.Size(1160, 643)
        Me.dgvBatchList.TabIndex = 0
        '
        'dtpFrom
        '
        Me.dtpFrom.Checked = False
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFrom.Location = New System.Drawing.Point(63, 26)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.ShowCheckBox = True
        Me.dtpFrom.ShowUpDown = True
        Me.dtpFrom.Size = New System.Drawing.Size(188, 23)
        Me.dtpFrom.TabIndex = 1
        '
        'dtpTo
        '
        Me.dtpTo.Checked = False
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTo.Location = New System.Drawing.Point(63, 58)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.ShowCheckBox = True
        Me.dtpTo.ShowUpDown = True
        Me.dtpTo.Size = New System.Drawing.Size(188, 23)
        Me.dtpTo.TabIndex = 2
        '
        'cmbShift
        '
        Me.cmbShift.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbShift.FormattingEnabled = True
        Me.cmbShift.Location = New System.Drawing.Point(459, 67)
        Me.cmbShift.Name = "cmbShift"
        Me.cmbShift.Size = New System.Drawing.Size(110, 24)
        Me.cmbShift.TabIndex = 3
        '
        'gbDateTime
        '
        Me.gbDateTime.Controls.Add(Me.Label2)
        Me.gbDateTime.Controls.Add(Me.Label1)
        Me.gbDateTime.Controls.Add(Me.dtpFrom)
        Me.gbDateTime.Controls.Add(Me.dtpTo)
        Me.gbDateTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDateTime.Location = New System.Drawing.Point(107, 12)
        Me.gbDateTime.Name = "gbDateTime"
        Me.gbDateTime.Size = New System.Drawing.Size(261, 90)
        Me.gbDateTime.TabIndex = 4
        Me.gbDateTime.TabStop = False
        Me.gbDateTime.Text = "BATCH DATE TIME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "TO:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "FROM:"
        '
        'lblLine
        '
        Me.lblLine.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblLine.BackColor = System.Drawing.Color.Red
        Me.lblLine.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLine.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblLine.Location = New System.Drawing.Point(12, 0)
        Me.lblLine.Name = "lblLine"
        Me.lblLine.Size = New System.Drawing.Size(89, 15)
        Me.lblLine.TabIndex = 5
        Me.lblLine.Text = "LINE"
        Me.lblLine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbFormula
        '
        Me.cmbFormula.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFormula.FormattingEnabled = True
        Me.cmbFormula.Location = New System.Drawing.Point(459, 37)
        Me.cmbFormula.Name = "cmbFormula"
        Me.cmbFormula.Size = New System.Drawing.Size(205, 24)
        Me.cmbFormula.TabIndex = 6
        '
        'lblFormula
        '
        Me.lblFormula.AutoSize = True
        Me.lblFormula.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormula.Location = New System.Drawing.Point(374, 41)
        Me.lblFormula.Name = "lblFormula"
        Me.lblFormula.Size = New System.Drawing.Size(79, 17)
        Me.lblFormula.TabIndex = 7
        Me.lblFormula.Text = "FORMULA:"
        '
        'lblShift
        '
        Me.lblShift.AutoSize = True
        Me.lblShift.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShift.Location = New System.Drawing.Point(402, 71)
        Me.lblShift.Name = "lblShift"
        Me.lblShift.Size = New System.Drawing.Size(51, 17)
        Me.lblShift.TabIndex = 8
        Me.lblShift.Text = "SHIFT:"
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(670, 35)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(110, 26)
        Me.btnSearch.TabIndex = 9
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnSetShift
        '
        Me.btnSetShift.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetShift.Location = New System.Drawing.Point(670, 67)
        Me.btnSetShift.Name = "btnSetShift"
        Me.btnSetShift.Size = New System.Drawing.Size(110, 26)
        Me.btnSetShift.TabIndex = 10
        Me.btnSetShift.Text = "SET SHIFT"
        Me.btnSetShift.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(1049, 38)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(103, 50)
        Me.btnPrint.TabIndex = 11
        Me.btnPrint.Text = "PRINT SELECTED"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'cmbRMType
        '
        Me.cmbRMType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRMType.FormattingEnabled = True
        Me.cmbRMType.Items.AddRange(New Object() {"Weight", "Liquid"})
        Me.cmbRMType.Location = New System.Drawing.Point(915, 51)
        Me.cmbRMType.Name = "cmbRMType"
        Me.cmbRMType.Size = New System.Drawing.Size(128, 24)
        Me.cmbRMType.TabIndex = 12
        '
        'btnReBatch
        '
        Me.btnReBatch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReBatch.Location = New System.Drawing.Point(801, 52)
        Me.btnReBatch.Name = "btnReBatch"
        Me.btnReBatch.Size = New System.Drawing.Size(91, 23)
        Me.btnReBatch.TabIndex = 13
        Me.btnReBatch.Text = "RE-BATCH"
        Me.btnReBatch.UseVisualStyleBackColor = True
        '
        'frmBatchList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 741)
        Me.Controls.Add(Me.btnReBatch)
        Me.Controls.Add(Me.cmbRMType)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnSetShift)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.lblShift)
        Me.Controls.Add(Me.lblFormula)
        Me.Controls.Add(Me.cmbFormula)
        Me.Controls.Add(Me.lblLine)
        Me.Controls.Add(Me.gbDateTime)
        Me.Controls.Add(Me.cmbShift)
        Me.Controls.Add(Me.dgvBatchList)
        Me.Name = "frmBatchList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Batch List"
        CType(Me.dgvBatchList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDateTime.ResumeLayout(False)
        Me.gbDateTime.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvBatchList As System.Windows.Forms.DataGridView
    Friend WithEvents dtpFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbShift As System.Windows.Forms.ComboBox
    Friend WithEvents gbDateTime As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblLine As System.Windows.Forms.Label
    Friend WithEvents cmbFormula As System.Windows.Forms.ComboBox
    Friend WithEvents lblFormula As System.Windows.Forms.Label
    Friend WithEvents lblShift As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnSetShift As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents cmbRMType As System.Windows.Forms.ComboBox
    Friend WithEvents btnReBatch As System.Windows.Forms.Button
End Class
