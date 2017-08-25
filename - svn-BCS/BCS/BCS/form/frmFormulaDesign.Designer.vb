<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFormulaDesign
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.cmbFormula = New System.Windows.Forms.ComboBox()
        Me.ButtonNameEdit = New System.Windows.Forms.Button()
        Me.DgFormulaDesigner = New System.Windows.Forms.DataGridView()
        Me.ColScale = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColCheck = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ColCheckBoxCrusher = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ColRMName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColRMLot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColMax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColFinal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColMin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColSP1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColSP2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColCPS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HZ_H = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HZ_M = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HZ_L = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColRevisionId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.DgFormulaDesigner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.DgFormulaDesigner, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1343, 335)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.SystemColors.Control
        Me.TableLayoutPanel2.ColumnCount = 9
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 121.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 121.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 58.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnDelete, 7, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnExit, 6, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnSave, 5, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnNew, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnEdit, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.cmbFormula, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.ButtonNameEdit, 3, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1337, 69)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Formula"
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Image = Global.BCS.My.Resources.Resources.btn_delete
        Me.btnDelete.Location = New System.Drawing.Point(1013, 3)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(114, 63)
        Me.btnDelete.TabIndex = 1
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelete.UseVisualStyleBackColor = True
        Me.btnDelete.Visible = False
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Image = Global.BCS.My.Resources.Resources.btn_exit
        Me.btnExit.Location = New System.Drawing.Point(892, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(114, 63)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = Global.BCS.My.Resources.Resources.btn_save
        Me.btnSave.Location = New System.Drawing.Point(771, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(114, 63)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Image = Global.BCS.My.Resources.Resources.btn_new
        Me.btnNew.Location = New System.Drawing.Point(647, 3)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(114, 63)
        Me.btnNew.TabIndex = 0
        Me.btnNew.Text = "   New"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(363, 3)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(144, 63)
        Me.btnEdit.TabIndex = 4
        Me.btnEdit.Text = "แก้ไขรายการ"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'cmbFormula
        '
        Me.cmbFormula.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbFormula.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFormula.FormattingEnabled = True
        Me.cmbFormula.Location = New System.Drawing.Point(123, 18)
        Me.cmbFormula.Name = "cmbFormula"
        Me.cmbFormula.Size = New System.Drawing.Size(234, 32)
        Me.cmbFormula.TabIndex = 6
        '
        'ButtonNameEdit
        '
        Me.ButtonNameEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtonNameEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNameEdit.Location = New System.Drawing.Point(513, 3)
        Me.ButtonNameEdit.Name = "ButtonNameEdit"
        Me.ButtonNameEdit.Size = New System.Drawing.Size(128, 63)
        Me.ButtonNameEdit.TabIndex = 7
        Me.ButtonNameEdit.Text = "แก้ไขชื่อ"
        Me.ButtonNameEdit.UseVisualStyleBackColor = False
        '
        'DgFormulaDesigner
        '
        Me.DgFormulaDesigner.AllowUserToAddRows = False
        Me.DgFormulaDesigner.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveBorder
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgFormulaDesigner.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgFormulaDesigner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgFormulaDesigner.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColScale, Me.ColCheck, Me.ColCheckBoxCrusher, Me.ColRMName, Me.ColRMLot, Me.ColMax, Me.ColFinal, Me.ColMin, Me.ColSP1, Me.ColSP2, Me.ColCPS, Me.HZ_H, Me.HZ_M, Me.HZ_L, Me.ColRevisionId})
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgFormulaDesigner.DefaultCellStyle = DataGridViewCellStyle11
        Me.DgFormulaDesigner.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgFormulaDesigner.Location = New System.Drawing.Point(3, 78)
        Me.DgFormulaDesigner.Name = "DgFormulaDesigner"
        Me.DgFormulaDesigner.RowHeadersVisible = False
        Me.DgFormulaDesigner.Size = New System.Drawing.Size(1337, 254)
        Me.DgFormulaDesigner.TabIndex = 2
        '
        'ColScale
        '
        Me.ColScale.HeaderText = "SCALE"
        Me.ColScale.MaxInputLength = 11
        Me.ColScale.Name = "ColScale"
        Me.ColScale.ReadOnly = True
        '
        'ColCheck
        '
        Me.ColCheck.HeaderText = "CHECK"
        Me.ColCheck.Name = "ColCheck"
        Me.ColCheck.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColCheck.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ColCheck.Width = 60
        '
        'ColCheckBoxCrusher
        '
        Me.ColCheckBoxCrusher.HeaderText = "Crusher"
        Me.ColCheckBoxCrusher.Name = "ColCheckBoxCrusher"
        Me.ColCheckBoxCrusher.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColCheckBoxCrusher.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ColCheckBoxCrusher.Width = 60
        '
        'ColRMName
        '
        Me.ColRMName.HeaderText = "R/M Name"
        Me.ColRMName.MaxInputLength = 11
        Me.ColRMName.Name = "ColRMName"
        Me.ColRMName.ReadOnly = True
        '
        'ColRMLot
        '
        Me.ColRMLot.HeaderText = "RM/LOT"
        Me.ColRMLot.MaxInputLength = 11
        Me.ColRMLot.Name = "ColRMLot"
        Me.ColRMLot.Width = 120
        '
        'ColMax
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        Me.ColMax.DefaultCellStyle = DataGridViewCellStyle2
        Me.ColMax.HeaderText = "MAX"
        Me.ColMax.MaxInputLength = 11
        Me.ColMax.Name = "ColMax"
        Me.ColMax.Width = 90
        '
        'ColFinal
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        Me.ColFinal.DefaultCellStyle = DataGridViewCellStyle3
        Me.ColFinal.HeaderText = "FINAL"
        Me.ColFinal.MaxInputLength = 11
        Me.ColFinal.Name = "ColFinal"
        Me.ColFinal.Width = 90
        '
        'ColMin
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        Me.ColMin.DefaultCellStyle = DataGridViewCellStyle4
        Me.ColMin.HeaderText = "MIN"
        Me.ColMin.MaxInputLength = 11
        Me.ColMin.Name = "ColMin"
        Me.ColMin.Width = 90
        '
        'ColSP1
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        Me.ColSP1.DefaultCellStyle = DataGridViewCellStyle5
        Me.ColSP1.HeaderText = "SP1"
        Me.ColSP1.MaxInputLength = 11
        Me.ColSP1.Name = "ColSP1"
        Me.ColSP1.Width = 90
        '
        'ColSP2
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        Me.ColSP2.DefaultCellStyle = DataGridViewCellStyle6
        Me.ColSP2.HeaderText = "SP2"
        Me.ColSP2.MaxInputLength = 11
        Me.ColSP2.Name = "ColSP2"
        Me.ColSP2.Width = 90
        '
        'ColCPS
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N2"
        Me.ColCPS.DefaultCellStyle = DataGridViewCellStyle7
        Me.ColCPS.HeaderText = "CPS"
        Me.ColCPS.MaxInputLength = 11
        Me.ColCPS.Name = "ColCPS"
        Me.ColCPS.Width = 90
        '
        'HZ_H
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.HZ_H.DefaultCellStyle = DataGridViewCellStyle8
        Me.HZ_H.HeaderText = "Hz-H"
        Me.HZ_H.Name = "HZ_H"
        Me.HZ_H.Width = 90
        '
        'HZ_M
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.HZ_M.DefaultCellStyle = DataGridViewCellStyle9
        Me.HZ_M.HeaderText = "Hz-M"
        Me.HZ_M.Name = "HZ_M"
        Me.HZ_M.Width = 90
        '
        'HZ_L
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.HZ_L.DefaultCellStyle = DataGridViewCellStyle10
        Me.HZ_L.HeaderText = "Hz-L"
        Me.HZ_L.Name = "HZ_L"
        Me.HZ_L.Width = 90
        '
        'ColRevisionId
        '
        Me.ColRevisionId.HeaderText = "Revision Id"
        Me.ColRevisionId.Name = "ColRevisionId"
        Me.ColRevisionId.Visible = False
        '
        'frmFormulaDesign
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1343, 335)
        Me.ControlBox = False
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmFormulaDesign"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FORMULA DESIGN"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.DgFormulaDesigner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbFormula As System.Windows.Forms.ComboBox
    Friend WithEvents DgFormulaDesigner As System.Windows.Forms.DataGridView
    Friend WithEvents ColScale As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColCheck As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ColCheckBoxCrusher As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ColRMName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColRMLot As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColMax As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColFinal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColMin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColSP1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColSP2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColCPS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HZ_H As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HZ_M As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HZ_L As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColRevisionId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ButtonNameEdit As System.Windows.Forms.Button

End Class
