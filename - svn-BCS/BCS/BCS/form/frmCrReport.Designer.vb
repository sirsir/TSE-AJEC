<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCrReport
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
        Me.pnlCrReport = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'pnlCrReport
        '
        Me.pnlCrReport.Location = New System.Drawing.Point(5, 3)
        Me.pnlCrReport.Name = "pnlCrReport"
        Me.pnlCrReport.Size = New System.Drawing.Size(1200, 756)
        Me.pnlCrReport.TabIndex = 0
        '
        'frmCrReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1207, 771)
        Me.Controls.Add(Me.pnlCrReport)
        Me.Name = "frmCrReport"
        Me.Text = "Daily Report"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlCrReport As System.Windows.Forms.Panel
End Class
