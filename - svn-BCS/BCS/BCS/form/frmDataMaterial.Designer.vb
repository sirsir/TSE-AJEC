<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDataMaterial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDataMaterial))
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.lblDataFormula = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DgFinal = New System.Windows.Forms.DataGridView()
        Me.ColAddFinal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgOver = New System.Windows.Forms.DataGridView()
        Me.ColAddOver = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgUnder = New System.Windows.Forms.DataGridView()
        Me.ColAddUnder = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgSP1 = New System.Windows.Forms.DataGridView()
        Me.ColAddSP1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgSP2 = New System.Windows.Forms.DataGridView()
        Me.ColAddSP2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgCPS = New System.Windows.Forms.DataGridView()
        Me.ColAddCPS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbBinName = New System.Windows.Forms.ComboBox()
        Me.cmbRMCode = New System.Windows.Forms.ComboBox()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.PbDataFormula = New System.Windows.Forms.PictureBox()
        Me.DgDetail = New System.Windows.Forms.DataGridView()
        Me.ColRMCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColBinTank = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColFinal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColOver = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColUnder = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColSP1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColSP2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColCPS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DsBCS = New BCS.dsBCS()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.DgFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgOver, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgUnder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgSP1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgSP2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgCPS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbDataFormula, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsBCS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlText
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.DgDetail, 0, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(1, 1)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 175.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(869, 469)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.SystemColors.Control
        Me.TableLayoutPanel2.ColumnCount = 5
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnExit, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnSave, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnDelete, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnNew, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblDataFormula, 4, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(863, 44)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.Location = New System.Drawing.Point(243, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(74, 38)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(163, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(74, 38)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.Location = New System.Drawing.Point(83, 3)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(74, 38)
        Me.btnDelete.TabIndex = 1
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.Location = New System.Drawing.Point(3, 3)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(74, 38)
        Me.btnNew.TabIndex = 0
        Me.btnNew.Text = "New"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'lblDataFormula
        '
        Me.lblDataFormula.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblDataFormula.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblDataFormula.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDataFormula.Location = New System.Drawing.Point(397, 12)
        Me.lblDataFormula.Name = "lblDataFormula"
        Me.lblDataFormula.Size = New System.Drawing.Size(463, 20)
        Me.lblDataFormula.TabIndex = 4
        Me.lblDataFormula.Text = "DATA FORMULA"
        Me.lblDataFormula.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackColor = System.Drawing.SystemColors.ControlText
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.PbDataFormula, 1, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 53)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(863, 169)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 3
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.Controls.Add(Me.Label3, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label2, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.DgFinal, 0, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.DgOver, 1, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.DgUnder, 2, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.DgSP1, 0, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.DgSP2, 1, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.DgCPS, 2, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.cmbBinName, 2, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.cmbRMCode, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.txtCode, 0, 1)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 4
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66877!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66877!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33123!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33123!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(425, 163)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(285, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 23)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Bin Name"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(144, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 23)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "R/M CODE"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DgFinal
        '
        Me.DgFinal.AllowUserToDeleteRows = False
        Me.DgFinal.AllowUserToResizeColumns = False
        Me.DgFinal.AllowUserToResizeRows = False
        Me.DgFinal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgFinal.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.DgFinal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgFinal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColAddFinal})
        Me.DgFinal.Location = New System.Drawing.Point(3, 57)
        Me.DgFinal.Name = "DgFinal"
        Me.DgFinal.RowHeadersVisible = False
        Me.DgFinal.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black
        Me.DgFinal.RowsDefaultCellStyle = DataGridViewCellStyle14
        Me.DgFinal.Size = New System.Drawing.Size(135, 48)
        Me.DgFinal.TabIndex = 0
        '
        'ColAddFinal
        '
        Me.ColAddFinal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColAddFinal.HeaderText = "      FINAL"
        Me.ColAddFinal.MaxInputLength = 11
        Me.ColAddFinal.Name = "ColAddFinal"
        '
        'DgOver
        '
        Me.DgOver.AllowUserToDeleteRows = False
        Me.DgOver.AllowUserToOrderColumns = True
        Me.DgOver.AllowUserToResizeColumns = False
        Me.DgOver.AllowUserToResizeRows = False
        Me.DgOver.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgOver.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.DgOver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgOver.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColAddOver})
        Me.DgOver.Location = New System.Drawing.Point(144, 57)
        Me.DgOver.Name = "DgOver"
        Me.DgOver.RowHeadersVisible = False
        Me.DgOver.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black
        Me.DgOver.RowsDefaultCellStyle = DataGridViewCellStyle16
        Me.DgOver.Size = New System.Drawing.Size(135, 48)
        Me.DgOver.TabIndex = 1
        '
        'ColAddOver
        '
        Me.ColAddOver.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColAddOver.HeaderText = "      OVER"
        Me.ColAddOver.MaxInputLength = 11
        Me.ColAddOver.Name = "ColAddOver"
        '
        'DgUnder
        '
        Me.DgUnder.AllowUserToDeleteRows = False
        Me.DgUnder.AllowUserToResizeColumns = False
        Me.DgUnder.AllowUserToResizeRows = False
        Me.DgUnder.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgUnder.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.DgUnder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgUnder.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColAddUnder})
        Me.DgUnder.Location = New System.Drawing.Point(285, 57)
        Me.DgUnder.Name = "DgUnder"
        Me.DgUnder.RowHeadersVisible = False
        Me.DgUnder.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black
        Me.DgUnder.RowsDefaultCellStyle = DataGridViewCellStyle18
        Me.DgUnder.Size = New System.Drawing.Size(137, 48)
        Me.DgUnder.TabIndex = 2
        '
        'ColAddUnder
        '
        Me.ColAddUnder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColAddUnder.HeaderText = "      UNDER"
        Me.ColAddUnder.MaxInputLength = 11
        Me.ColAddUnder.Name = "ColAddUnder"
        '
        'DgSP1
        '
        Me.DgSP1.AllowUserToDeleteRows = False
        Me.DgSP1.AllowUserToResizeColumns = False
        Me.DgSP1.AllowUserToResizeRows = False
        Me.DgSP1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgSP1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle19
        Me.DgSP1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgSP1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColAddSP1})
        Me.DgSP1.Location = New System.Drawing.Point(3, 111)
        Me.DgSP1.Name = "DgSP1"
        Me.DgSP1.RowHeadersVisible = False
        Me.DgSP1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Black
        Me.DgSP1.RowsDefaultCellStyle = DataGridViewCellStyle20
        Me.DgSP1.Size = New System.Drawing.Size(135, 48)
        Me.DgSP1.TabIndex = 3
        '
        'ColAddSP1
        '
        Me.ColAddSP1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColAddSP1.HeaderText = "       SP1"
        Me.ColAddSP1.MaxInputLength = 11
        Me.ColAddSP1.Name = "ColAddSP1"
        '
        'DgSP2
        '
        Me.DgSP2.AllowUserToDeleteRows = False
        Me.DgSP2.AllowUserToResizeColumns = False
        Me.DgSP2.AllowUserToResizeRows = False
        Me.DgSP2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgSP2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle21
        Me.DgSP2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgSP2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColAddSP2})
        Me.DgSP2.Location = New System.Drawing.Point(144, 111)
        Me.DgSP2.Name = "DgSP2"
        Me.DgSP2.RowHeadersVisible = False
        Me.DgSP2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle22.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.Black
        Me.DgSP2.RowsDefaultCellStyle = DataGridViewCellStyle22
        Me.DgSP2.Size = New System.Drawing.Size(135, 48)
        Me.DgSP2.TabIndex = 4
        '
        'ColAddSP2
        '
        Me.ColAddSP2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColAddSP2.HeaderText = "       SP2"
        Me.ColAddSP2.MaxInputLength = 11
        Me.ColAddSP2.Name = "ColAddSP2"
        '
        'DgCPS
        '
        Me.DgCPS.AllowUserToDeleteRows = False
        Me.DgCPS.AllowUserToResizeColumns = False
        Me.DgCPS.AllowUserToResizeRows = False
        Me.DgCPS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgCPS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle23
        Me.DgCPS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgCPS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColAddCPS})
        Me.DgCPS.Location = New System.Drawing.Point(285, 111)
        Me.DgCPS.MultiSelect = False
        Me.DgCPS.Name = "DgCPS"
        Me.DgCPS.RowHeadersVisible = False
        Me.DgCPS.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle24.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.Black
        Me.DgCPS.RowsDefaultCellStyle = DataGridViewCellStyle24
        Me.DgCPS.Size = New System.Drawing.Size(137, 48)
        Me.DgCPS.TabIndex = 5
        '
        'ColAddCPS
        '
        Me.ColAddCPS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColAddCPS.HeaderText = "        CPS"
        Me.ColAddCPS.MaxInputLength = 11
        Me.ColAddCPS.Name = "ColAddCPS"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 23)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "CODE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbBinName
        '
        Me.cmbBinName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBinName.FormattingEnabled = True
        Me.cmbBinName.Location = New System.Drawing.Point(285, 30)
        Me.cmbBinName.Name = "cmbBinName"
        Me.cmbBinName.Size = New System.Drawing.Size(137, 21)
        Me.cmbBinName.TabIndex = 9
        '
        'cmbRMCode
        '
        Me.cmbRMCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRMCode.FormattingEnabled = True
        Me.cmbRMCode.Location = New System.Drawing.Point(144, 30)
        Me.cmbRMCode.Name = "cmbRMCode"
        Me.cmbRMCode.Size = New System.Drawing.Size(135, 21)
        Me.cmbRMCode.TabIndex = 10
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(3, 30)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(135, 20)
        Me.txtCode.TabIndex = 11
        '
        'PbDataFormula
        '
        Me.PbDataFormula.BackColor = System.Drawing.SystemColors.Control
        Me.PbDataFormula.Location = New System.Drawing.Point(434, 3)
        Me.PbDataFormula.Name = "PbDataFormula"
        Me.PbDataFormula.Size = New System.Drawing.Size(426, 163)
        Me.PbDataFormula.TabIndex = 1
        Me.PbDataFormula.TabStop = False
        '
        'DgDetail
        '
        Me.DgDetail.AllowUserToDeleteRows = False
        Me.DgDetail.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DgDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgDetail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColRMCode, Me.ColBinTank, Me.ColCode, Me.ColFinal, Me.ColOver, Me.ColUnder, Me.ColSP1, Me.ColSP2, Me.ColCPS})
        Me.DgDetail.Location = New System.Drawing.Point(3, 228)
        Me.DgDetail.Name = "DgDetail"
        Me.DgDetail.ReadOnly = True
        Me.DgDetail.Size = New System.Drawing.Size(863, 238)
        Me.DgDetail.TabIndex = 2
        '
        'ColRMCode
        '
        Me.ColRMCode.HeaderText = "R/M CODE"
        Me.ColRMCode.Name = "ColRMCode"
        Me.ColRMCode.ReadOnly = True
        Me.ColRMCode.Width = 90
        '
        'ColBinTank
        '
        Me.ColBinTank.HeaderText = "BIN/TANK"
        Me.ColBinTank.Name = "ColBinTank"
        Me.ColBinTank.ReadOnly = True
        Me.ColBinTank.Width = 90
        '
        'ColCode
        '
        Me.ColCode.HeaderText = "CODE"
        Me.ColCode.Name = "ColCode"
        Me.ColCode.ReadOnly = True
        Me.ColCode.Width = 80
        '
        'ColFinal
        '
        Me.ColFinal.HeaderText = "FINAL"
        Me.ColFinal.Name = "ColFinal"
        Me.ColFinal.ReadOnly = True
        Me.ColFinal.Width = 90
        '
        'ColOver
        '
        Me.ColOver.HeaderText = "OVER"
        Me.ColOver.Name = "ColOver"
        Me.ColOver.ReadOnly = True
        Me.ColOver.Width = 90
        '
        'ColUnder
        '
        Me.ColUnder.HeaderText = "UNDER"
        Me.ColUnder.Name = "ColUnder"
        Me.ColUnder.ReadOnly = True
        Me.ColUnder.Width = 90
        '
        'ColSP1
        '
        Me.ColSP1.HeaderText = "SP1"
        Me.ColSP1.Name = "ColSP1"
        Me.ColSP1.ReadOnly = True
        Me.ColSP1.Width = 90
        '
        'ColSP2
        '
        Me.ColSP2.HeaderText = "SP2"
        Me.ColSP2.Name = "ColSP2"
        Me.ColSP2.ReadOnly = True
        Me.ColSP2.Width = 90
        '
        'ColCPS
        '
        Me.ColCPS.HeaderText = "CPS"
        Me.ColCPS.Name = "ColCPS"
        Me.ColCPS.ReadOnly = True
        Me.ColCPS.Width = 90
        '
        'DsBCS
        '
        Me.DsBCS.DataSetName = "dsBCS"
        Me.DsBCS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmDataMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(871, 472)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "frmDataMaterial"
        Me.Text = "frmDataMaterial"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        CType(Me.DgFinal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgOver, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgUnder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgSP1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgSP2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgCPS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbDataFormula, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsBCS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents lblDataFormula As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents DgFinal As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DgOver As System.Windows.Forms.DataGridView
    Friend WithEvents DgSP1 As System.Windows.Forms.DataGridView
    Friend WithEvents DgSP2 As System.Windows.Forms.DataGridView
    Friend WithEvents DgCPS As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbBinName As System.Windows.Forms.ComboBox
    Friend WithEvents cmbRMCode As System.Windows.Forms.ComboBox
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents PbDataFormula As System.Windows.Forms.PictureBox
    Friend WithEvents DgDetail As System.Windows.Forms.DataGridView
    Friend WithEvents ColAddFinal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColAddOver As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColAddUnder As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColAddSP1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColAddSP2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColAddCPS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DgUnder As System.Windows.Forms.DataGridView
    Friend WithEvents ColRMCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColBinTank As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColFinal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColOver As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColUnder As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColSP1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColSP2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColCPS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DsBCS As BCS.dsBCS
End Class
