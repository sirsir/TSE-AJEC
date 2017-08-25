<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShift
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.DgShift = New System.Windows.Forms.DataGridView()
        Me.ColShiftName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColShiftStartHr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColShiftStartMin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColTo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColShiftEndHr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColShiftEndMin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.DgShift, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.DgShift, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(303, 182)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.btnCancel, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.btnOk, 0, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 145)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(297, 34)
        Me.TableLayoutPanel4.TabIndex = 3
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCancel.Location = New System.Drawing.Point(182, 5)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 23)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnOk.Location = New System.Drawing.Point(34, 5)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(80, 23)
        Me.btnOk.TabIndex = 0
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'DgShift
        '
        Me.DgShift.AllowUserToAddRows = False
        Me.DgShift.AllowUserToDeleteRows = False
        Me.DgShift.AllowUserToOrderColumns = True
        Me.DgShift.AllowUserToResizeColumns = False
        Me.DgShift.AllowUserToResizeRows = False
        Me.DgShift.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgShift.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColShiftName, Me.ColShiftStartHr, Me.ColShiftStartMin, Me.ColTo, Me.ColShiftEndHr, Me.ColShiftEndMin})
        Me.DgShift.Location = New System.Drawing.Point(3, 3)
        Me.DgShift.Name = "DgShift"
        Me.DgShift.RowHeadersVisible = False
        Me.DgShift.Size = New System.Drawing.Size(295, 136)
        Me.DgShift.TabIndex = 4
        '
        'ColShiftName
        '
        Me.ColShiftName.HeaderText = "NAME"
        Me.ColShiftName.Name = "ColShiftName"
        Me.ColShiftName.ReadOnly = True
        Me.ColShiftName.Width = 60
        '
        'ColShiftStartHr
        '
        Me.ColShiftStartHr.HeaderText = "HR"
        Me.ColShiftStartHr.Name = "ColShiftStartHr"
        Me.ColShiftStartHr.Width = 50
        '
        'ColShiftStartMin
        '
        Me.ColShiftStartMin.HeaderText = "MIN"
        Me.ColShiftStartMin.Name = "ColShiftStartMin"
        Me.ColShiftStartMin.Width = 50
        '
        'ColTo
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ColTo.DefaultCellStyle = DataGridViewCellStyle1
        Me.ColTo.HeaderText = ""
        Me.ColTo.Name = "ColTo"
        Me.ColTo.ReadOnly = True
        Me.ColTo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColTo.Width = 30
        '
        'ColShiftEndHr
        '
        Me.ColShiftEndHr.HeaderText = "HR"
        Me.ColShiftEndHr.Name = "ColShiftEndHr"
        Me.ColShiftEndHr.Width = 50
        '
        'ColShiftEndMin
        '
        Me.ColShiftEndMin.HeaderText = "MIN"
        Me.ColShiftEndMin.Name = "ColShiftEndMin"
        Me.ColShiftEndMin.Width = 50
        '
        'frmShift
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 204)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "frmShift"
        Me.Text = "Shift Time Management"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        CType(Me.DgShift, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents DgShift As System.Windows.Forms.DataGridView
    Friend WithEvents ColShiftName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColShiftStartHr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColShiftStartMin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColTo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColShiftEndHr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColShiftEndMin As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
