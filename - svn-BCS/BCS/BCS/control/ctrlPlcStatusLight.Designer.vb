<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtrlPlcStatusLight
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CtrlPlcStatusLight))
        Me.GbStatusLine = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PbEndProcessOn = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PbEndProcessOff = New System.Windows.Forms.PictureBox()
        Me.PbRunReturnOn = New System.Windows.Forms.PictureBox()
        Me.PbRunReturnOff = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GbDischargeLine = New System.Windows.Forms.GroupBox()
        Me.PbRM4DischargeOn = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PbRM3DischargeOn = New System.Windows.Forms.PictureBox()
        Me.PbRM2DischargeOn = New System.Windows.Forms.PictureBox()
        Me.PbRM1DischargeOn = New System.Windows.Forms.PictureBox()
        Me.PbRM3DischargeOff = New System.Windows.Forms.PictureBox()
        Me.PbRM2DischargeOff = New System.Windows.Forms.PictureBox()
        Me.PbRM1DischargeOff = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PbRM4DischargeOff = New System.Windows.Forms.PictureBox()
        Me.GbStatusRun = New System.Windows.Forms.GroupBox()
        Me.PbRM4CompleteOn = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PbRM2CompleteOn = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PbRM3CompleteOn = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PbRM1CompleteOn = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PbRM1CompleteOff = New System.Windows.Forms.PictureBox()
        Me.PbRM4CompleteOff = New System.Windows.Forms.PictureBox()
        Me.PbRM3CompleteOff = New System.Windows.Forms.PictureBox()
        Me.PbRM2CompleteOff = New System.Windows.Forms.PictureBox()
        Me.GbStatusLine.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PbEndProcessOn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbEndProcessOff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbRunReturnOn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbRunReturnOff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GbDischargeLine.SuspendLayout()
        CType(Me.PbRM4DischargeOn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbRM3DischargeOn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbRM2DischargeOn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbRM1DischargeOn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbRM3DischargeOff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbRM2DischargeOff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbRM1DischargeOff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbRM4DischargeOff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbStatusRun.SuspendLayout()
        CType(Me.PbRM4CompleteOn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbRM2CompleteOn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbRM3CompleteOn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbRM1CompleteOn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbRM1CompleteOff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbRM4CompleteOff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbRM3CompleteOff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbRM2CompleteOff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GbStatusLine
        '
        Me.GbStatusLine.Controls.Add(Me.TableLayoutPanel2)
        Me.GbStatusLine.Location = New System.Drawing.Point(3, 3)
        Me.GbStatusLine.Name = "GbStatusLine"
        Me.GbStatusLine.Size = New System.Drawing.Size(434, 278)
        Me.GbStatusLine.TabIndex = 0
        Me.GbStatusLine.TabStop = False
        Me.GbStatusLine.Text = "STATUS LINE : B1"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel1, 0, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(5, 12)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(423, 260)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Black
        Me.GroupBox1.Controls.Add(Me.PbEndProcessOn)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.PbEndProcessOff)
        Me.GroupBox1.Controls.Add(Me.PbRunReturnOn)
        Me.GroupBox1.Controls.Add(Me.PbRunReturnOff)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(417, 54)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "STATUSRUN"
        '
        'PbEndProcessOn
        '
        Me.PbEndProcessOn.ErrorImage = Global.BCS.My.Resources.Resources.img_lighton
        Me.PbEndProcessOn.ImageLocation = "resource/Image"
        Me.PbEndProcessOn.InitialImage = CType(resources.GetObject("PbEndProcessOn.InitialImage"), System.Drawing.Image)
        Me.PbEndProcessOn.Location = New System.Drawing.Point(217, 10)
        Me.PbEndProcessOn.Name = "PbEndProcessOn"
        Me.PbEndProcessOn.Size = New System.Drawing.Size(30, 30)
        Me.PbEndProcessOn.TabIndex = 6
        Me.PbEndProcessOn.TabStop = False
        Me.PbEndProcessOn.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(253, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(140, 24)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "ENDPROCESS"
        '
        'PbEndProcessOff
        '
        Me.PbEndProcessOff.ErrorImage = Global.BCS.My.Resources.Resources.img_lightoff
        Me.PbEndProcessOff.Image = Global.BCS.My.Resources.Resources.img_lightoff_1600X900
        Me.PbEndProcessOff.ImageLocation = "resource/Image"
        Me.PbEndProcessOff.InitialImage = CType(resources.GetObject("PbEndProcessOff.InitialImage"), System.Drawing.Image)
        Me.PbEndProcessOff.Location = New System.Drawing.Point(217, 10)
        Me.PbEndProcessOff.Name = "PbEndProcessOff"
        Me.PbEndProcessOff.Size = New System.Drawing.Size(30, 30)
        Me.PbEndProcessOff.TabIndex = 5
        Me.PbEndProcessOff.TabStop = False
        '
        'PbRunReturnOn
        '
        Me.PbRunReturnOn.ErrorImage = Global.BCS.My.Resources.Resources.img_lighton
        Me.PbRunReturnOn.ImageLocation = "resource/Image"
        Me.PbRunReturnOn.InitialImage = CType(resources.GetObject("PbRunReturnOn.InitialImage"), System.Drawing.Image)
        Me.PbRunReturnOn.Location = New System.Drawing.Point(9, 10)
        Me.PbRunReturnOn.Name = "PbRunReturnOn"
        Me.PbRunReturnOn.Size = New System.Drawing.Size(30, 30)
        Me.PbRunReturnOn.TabIndex = 4
        Me.PbRunReturnOn.TabStop = False
        Me.PbRunReturnOn.Visible = False
        '
        'PbRunReturnOff
        '
        Me.PbRunReturnOff.ErrorImage = Global.BCS.My.Resources.Resources.img_lightoff
        Me.PbRunReturnOff.Image = Global.BCS.My.Resources.Resources.img_lightoff_1600X900
        Me.PbRunReturnOff.ImageLocation = "resource/Image"
        Me.PbRunReturnOff.InitialImage = CType(resources.GetObject("PbRunReturnOff.InitialImage"), System.Drawing.Image)
        Me.PbRunReturnOff.Location = New System.Drawing.Point(9, 10)
        Me.PbRunReturnOff.Name = "PbRunReturnOff"
        Me.PbRunReturnOff.Size = New System.Drawing.Size(30, 30)
        Me.PbRunReturnOff.TabIndex = 3
        Me.PbRunReturnOff.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(45, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(133, 24)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "RUN RETURN"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GbDischargeLine, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GbStatusRun, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 63)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 197.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(417, 194)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'GbDischargeLine
        '
        Me.GbDischargeLine.BackColor = System.Drawing.Color.Black
        Me.GbDischargeLine.Controls.Add(Me.PbRM4DischargeOn)
        Me.GbDischargeLine.Controls.Add(Me.Label7)
        Me.GbDischargeLine.Controls.Add(Me.PbRM3DischargeOn)
        Me.GbDischargeLine.Controls.Add(Me.PbRM2DischargeOn)
        Me.GbDischargeLine.Controls.Add(Me.PbRM1DischargeOn)
        Me.GbDischargeLine.Controls.Add(Me.PbRM3DischargeOff)
        Me.GbDischargeLine.Controls.Add(Me.PbRM2DischargeOff)
        Me.GbDischargeLine.Controls.Add(Me.PbRM1DischargeOff)
        Me.GbDischargeLine.Controls.Add(Me.Label6)
        Me.GbDischargeLine.Controls.Add(Me.Label5)
        Me.GbDischargeLine.Controls.Add(Me.Label4)
        Me.GbDischargeLine.Controls.Add(Me.PbRM4DischargeOff)
        Me.GbDischargeLine.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbDischargeLine.ForeColor = System.Drawing.Color.DodgerBlue
        Me.GbDischargeLine.Location = New System.Drawing.Point(211, 3)
        Me.GbDischargeLine.Name = "GbDischargeLine"
        Me.GbDischargeLine.Size = New System.Drawing.Size(203, 188)
        Me.GbDischargeLine.TabIndex = 1
        Me.GbDischargeLine.TabStop = False
        Me.GbDischargeLine.Text = "DISCHARGE LINEB1"
        '
        'PbRM4DischargeOn
        '
        Me.PbRM4DischargeOn.ErrorImage = Global.BCS.My.Resources.Resources.img_lighton
        Me.PbRM4DischargeOn.ImageLocation = "resource/Image"
        Me.PbRM4DischargeOn.InitialImage = CType(resources.GetObject("PbRM4DischargeOn.InitialImage"), System.Drawing.Image)
        Me.PbRM4DischargeOn.Location = New System.Drawing.Point(6, 148)
        Me.PbRM4DischargeOn.Name = "PbRM4DischargeOn"
        Me.PbRM4DischargeOn.Size = New System.Drawing.Size(30, 30)
        Me.PbRM4DischargeOn.TabIndex = 10
        Me.PbRM4DischargeOn.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(42, 154)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(163, 24)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "RM4 DISCHARGE"
        '
        'PbRM3DischargeOn
        '
        Me.PbRM3DischargeOn.ErrorImage = Global.BCS.My.Resources.Resources.img_lighton
        Me.PbRM3DischargeOn.ImageLocation = "resource/Image"
        Me.PbRM3DischargeOn.InitialImage = CType(resources.GetObject("PbRM3DischargeOn.InitialImage"), System.Drawing.Image)
        Me.PbRM3DischargeOn.Location = New System.Drawing.Point(6, 104)
        Me.PbRM3DischargeOn.Name = "PbRM3DischargeOn"
        Me.PbRM3DischargeOn.Size = New System.Drawing.Size(30, 30)
        Me.PbRM3DischargeOn.TabIndex = 8
        Me.PbRM3DischargeOn.TabStop = False
        '
        'PbRM2DischargeOn
        '
        Me.PbRM2DischargeOn.ErrorImage = Global.BCS.My.Resources.Resources.img_lighton
        Me.PbRM2DischargeOn.ImageLocation = "resource/Image"
        Me.PbRM2DischargeOn.InitialImage = CType(resources.GetObject("PbRM2DischargeOn.InitialImage"), System.Drawing.Image)
        Me.PbRM2DischargeOn.Location = New System.Drawing.Point(6, 60)
        Me.PbRM2DischargeOn.Name = "PbRM2DischargeOn"
        Me.PbRM2DischargeOn.Size = New System.Drawing.Size(30, 30)
        Me.PbRM2DischargeOn.TabIndex = 7
        Me.PbRM2DischargeOn.TabStop = False
        '
        'PbRM1DischargeOn
        '
        Me.PbRM1DischargeOn.ErrorImage = Global.BCS.My.Resources.Resources.img_lighton
        Me.PbRM1DischargeOn.ImageLocation = "resource/Image"
        Me.PbRM1DischargeOn.InitialImage = CType(resources.GetObject("PbRM1DischargeOn.InitialImage"), System.Drawing.Image)
        Me.PbRM1DischargeOn.Location = New System.Drawing.Point(6, 16)
        Me.PbRM1DischargeOn.Name = "PbRM1DischargeOn"
        Me.PbRM1DischargeOn.Size = New System.Drawing.Size(30, 30)
        Me.PbRM1DischargeOn.TabIndex = 6
        Me.PbRM1DischargeOn.TabStop = False
        '
        'PbRM3DischargeOff
        '
        Me.PbRM3DischargeOff.ErrorImage = Global.BCS.My.Resources.Resources.img_lightoff
        Me.PbRM3DischargeOff.Image = Global.BCS.My.Resources.Resources.img_lightoff_1600X900
        Me.PbRM3DischargeOff.ImageLocation = "resource/Image"
        Me.PbRM3DischargeOff.InitialImage = CType(resources.GetObject("PbRM3DischargeOff.InitialImage"), System.Drawing.Image)
        Me.PbRM3DischargeOff.Location = New System.Drawing.Point(6, 104)
        Me.PbRM3DischargeOff.Name = "PbRM3DischargeOff"
        Me.PbRM3DischargeOff.Size = New System.Drawing.Size(30, 30)
        Me.PbRM3DischargeOff.TabIndex = 5
        Me.PbRM3DischargeOff.TabStop = False
        '
        'PbRM2DischargeOff
        '
        Me.PbRM2DischargeOff.ErrorImage = Global.BCS.My.Resources.Resources.img_lightoff
        Me.PbRM2DischargeOff.Image = Global.BCS.My.Resources.Resources.img_lightoff_1600X900
        Me.PbRM2DischargeOff.ImageLocation = "resource/Image"
        Me.PbRM2DischargeOff.InitialImage = CType(resources.GetObject("PbRM2DischargeOff.InitialImage"), System.Drawing.Image)
        Me.PbRM2DischargeOff.Location = New System.Drawing.Point(6, 60)
        Me.PbRM2DischargeOff.Name = "PbRM2DischargeOff"
        Me.PbRM2DischargeOff.Size = New System.Drawing.Size(30, 30)
        Me.PbRM2DischargeOff.TabIndex = 4
        Me.PbRM2DischargeOff.TabStop = False
        '
        'PbRM1DischargeOff
        '
        Me.PbRM1DischargeOff.ErrorImage = Global.BCS.My.Resources.Resources.img_lightoff
        Me.PbRM1DischargeOff.Image = Global.BCS.My.Resources.Resources.img_lightoff_1600X900
        Me.PbRM1DischargeOff.ImageLocation = "resource/Image"
        Me.PbRM1DischargeOff.InitialImage = CType(resources.GetObject("PbRM1DischargeOff.InitialImage"), System.Drawing.Image)
        Me.PbRM1DischargeOff.Location = New System.Drawing.Point(6, 16)
        Me.PbRM1DischargeOff.Name = "PbRM1DischargeOff"
        Me.PbRM1DischargeOff.Size = New System.Drawing.Size(30, 30)
        Me.PbRM1DischargeOff.TabIndex = 3
        Me.PbRM1DischargeOff.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(42, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(163, 24)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "RM3 DISCHARGE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(42, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(163, 24)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "RM2 DISCHARGE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(42, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(163, 24)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "RM1 DISCHARGE"
        '
        'PbRM4DischargeOff
        '
        Me.PbRM4DischargeOff.ErrorImage = Global.BCS.My.Resources.Resources.img_lightoff
        Me.PbRM4DischargeOff.Image = Global.BCS.My.Resources.Resources.img_lightoff_1600X900
        Me.PbRM4DischargeOff.ImageLocation = "resource/Image"
        Me.PbRM4DischargeOff.InitialImage = CType(resources.GetObject("PbRM4DischargeOff.InitialImage"), System.Drawing.Image)
        Me.PbRM4DischargeOff.Location = New System.Drawing.Point(6, 148)
        Me.PbRM4DischargeOff.Name = "PbRM4DischargeOff"
        Me.PbRM4DischargeOff.Size = New System.Drawing.Size(30, 30)
        Me.PbRM4DischargeOff.TabIndex = 11
        Me.PbRM4DischargeOff.TabStop = False
        '
        'GbStatusRun
        '
        Me.GbStatusRun.BackColor = System.Drawing.Color.Black
        Me.GbStatusRun.Controls.Add(Me.PbRM4CompleteOn)
        Me.GbStatusRun.Controls.Add(Me.Label9)
        Me.GbStatusRun.Controls.Add(Me.PbRM2CompleteOn)
        Me.GbStatusRun.Controls.Add(Me.Label3)
        Me.GbStatusRun.Controls.Add(Me.PbRM3CompleteOn)
        Me.GbStatusRun.Controls.Add(Me.Label1)
        Me.GbStatusRun.Controls.Add(Me.PbRM1CompleteOn)
        Me.GbStatusRun.Controls.Add(Me.Label2)
        Me.GbStatusRun.Controls.Add(Me.PbRM1CompleteOff)
        Me.GbStatusRun.Controls.Add(Me.PbRM4CompleteOff)
        Me.GbStatusRun.Controls.Add(Me.PbRM3CompleteOff)
        Me.GbStatusRun.Controls.Add(Me.PbRM2CompleteOff)
        Me.GbStatusRun.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GbStatusRun.Location = New System.Drawing.Point(3, 3)
        Me.GbStatusRun.Name = "GbStatusRun"
        Me.GbStatusRun.Size = New System.Drawing.Size(202, 191)
        Me.GbStatusRun.TabIndex = 0
        Me.GbStatusRun.TabStop = False
        Me.GbStatusRun.Text = "COMPLETERM"
        '
        'PbRM4CompleteOn
        '
        Me.PbRM4CompleteOn.ErrorImage = Global.BCS.My.Resources.Resources.img_lighton
        Me.PbRM4CompleteOn.ImageLocation = "resource/Image"
        Me.PbRM4CompleteOn.InitialImage = CType(resources.GetObject("PbRM4CompleteOn.InitialImage"), System.Drawing.Image)
        Me.PbRM4CompleteOn.Location = New System.Drawing.Point(6, 148)
        Me.PbRM4CompleteOn.Name = "PbRM4CompleteOn"
        Me.PbRM4CompleteOn.Size = New System.Drawing.Size(30, 30)
        Me.PbRM4CompleteOn.TabIndex = 11
        Me.PbRM4CompleteOn.TabStop = False
        Me.PbRM4CompleteOn.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(42, 154)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(158, 24)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "RM4 COMPLETE"
        '
        'PbRM2CompleteOn
        '
        Me.PbRM2CompleteOn.ErrorImage = Global.BCS.My.Resources.Resources.img_lighton
        Me.PbRM2CompleteOn.ImageLocation = "resource/Image"
        Me.PbRM2CompleteOn.InitialImage = CType(resources.GetObject("PbRM2CompleteOn.InitialImage"), System.Drawing.Image)
        Me.PbRM2CompleteOn.Location = New System.Drawing.Point(6, 60)
        Me.PbRM2CompleteOn.Name = "PbRM2CompleteOn"
        Me.PbRM2CompleteOn.Size = New System.Drawing.Size(30, 30)
        Me.PbRM2CompleteOn.TabIndex = 9
        Me.PbRM2CompleteOn.TabStop = False
        Me.PbRM2CompleteOn.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(42, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 24)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "RM2 COMPLETE"
        '
        'PbRM3CompleteOn
        '
        Me.PbRM3CompleteOn.ErrorImage = Global.BCS.My.Resources.Resources.img_lighton
        Me.PbRM3CompleteOn.ImageLocation = "resource/Image"
        Me.PbRM3CompleteOn.InitialImage = CType(resources.GetObject("PbRM3CompleteOn.InitialImage"), System.Drawing.Image)
        Me.PbRM3CompleteOn.Location = New System.Drawing.Point(6, 104)
        Me.PbRM3CompleteOn.Name = "PbRM3CompleteOn"
        Me.PbRM3CompleteOn.Size = New System.Drawing.Size(30, 30)
        Me.PbRM3CompleteOn.TabIndex = 7
        Me.PbRM3CompleteOn.TabStop = False
        Me.PbRM3CompleteOn.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(42, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 24)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "RM3 COMPLETE"
        '
        'PbRM1CompleteOn
        '
        Me.PbRM1CompleteOn.ErrorImage = Global.BCS.My.Resources.Resources.img_lighton
        Me.PbRM1CompleteOn.ImageLocation = "resource/Image"
        Me.PbRM1CompleteOn.InitialImage = CType(resources.GetObject("PbRM1CompleteOn.InitialImage"), System.Drawing.Image)
        Me.PbRM1CompleteOn.Location = New System.Drawing.Point(6, 16)
        Me.PbRM1CompleteOn.Name = "PbRM1CompleteOn"
        Me.PbRM1CompleteOn.Size = New System.Drawing.Size(30, 30)
        Me.PbRM1CompleteOn.TabIndex = 5
        Me.PbRM1CompleteOn.TabStop = False
        Me.PbRM1CompleteOn.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(42, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "RM1 COMPLETE"
        '
        'PbRM1CompleteOff
        '
        Me.PbRM1CompleteOff.ErrorImage = Global.BCS.My.Resources.Resources.img_lightoff
        Me.PbRM1CompleteOff.Image = Global.BCS.My.Resources.Resources.img_lightoff_1600X900
        Me.PbRM1CompleteOff.ImageLocation = "resource/Image"
        Me.PbRM1CompleteOff.InitialImage = CType(resources.GetObject("PbRM1CompleteOff.InitialImage"), System.Drawing.Image)
        Me.PbRM1CompleteOff.Location = New System.Drawing.Point(6, 16)
        Me.PbRM1CompleteOff.Name = "PbRM1CompleteOff"
        Me.PbRM1CompleteOff.Size = New System.Drawing.Size(30, 30)
        Me.PbRM1CompleteOff.TabIndex = 4
        Me.PbRM1CompleteOff.TabStop = False
        '
        'PbRM4CompleteOff
        '
        Me.PbRM4CompleteOff.ErrorImage = Global.BCS.My.Resources.Resources.img_lightoff
        Me.PbRM4CompleteOff.Image = Global.BCS.My.Resources.Resources.img_lightoff_1600X900
        Me.PbRM4CompleteOff.ImageLocation = "resource/Image"
        Me.PbRM4CompleteOff.InitialImage = CType(resources.GetObject("PbRM4CompleteOff.InitialImage"), System.Drawing.Image)
        Me.PbRM4CompleteOff.Location = New System.Drawing.Point(6, 148)
        Me.PbRM4CompleteOff.Name = "PbRM4CompleteOff"
        Me.PbRM4CompleteOff.Size = New System.Drawing.Size(30, 30)
        Me.PbRM4CompleteOff.TabIndex = 14
        Me.PbRM4CompleteOff.TabStop = False
        '
        'PbRM3CompleteOff
        '
        Me.PbRM3CompleteOff.ErrorImage = Global.BCS.My.Resources.Resources.img_lightoff
        Me.PbRM3CompleteOff.Image = Global.BCS.My.Resources.Resources.img_lightoff_1600X900
        Me.PbRM3CompleteOff.ImageLocation = "resource/Image"
        Me.PbRM3CompleteOff.InitialImage = CType(resources.GetObject("PbRM3CompleteOff.InitialImage"), System.Drawing.Image)
        Me.PbRM3CompleteOff.Location = New System.Drawing.Point(6, 104)
        Me.PbRM3CompleteOff.Name = "PbRM3CompleteOff"
        Me.PbRM3CompleteOff.Size = New System.Drawing.Size(30, 30)
        Me.PbRM3CompleteOff.TabIndex = 13
        Me.PbRM3CompleteOff.TabStop = False
        '
        'PbRM2CompleteOff
        '
        Me.PbRM2CompleteOff.ErrorImage = Global.BCS.My.Resources.Resources.img_lightoff
        Me.PbRM2CompleteOff.Image = Global.BCS.My.Resources.Resources.img_lightoff_1600X900
        Me.PbRM2CompleteOff.ImageLocation = "resource/Image"
        Me.PbRM2CompleteOff.InitialImage = CType(resources.GetObject("PbRM2CompleteOff.InitialImage"), System.Drawing.Image)
        Me.PbRM2CompleteOff.Location = New System.Drawing.Point(6, 60)
        Me.PbRM2CompleteOff.Name = "PbRM2CompleteOff"
        Me.PbRM2CompleteOff.Size = New System.Drawing.Size(30, 30)
        Me.PbRM2CompleteOff.TabIndex = 12
        Me.PbRM2CompleteOff.TabStop = False
        '
        'CtrlPlcStatusLight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Controls.Add(Me.GbStatusLine)
        Me.Name = "CtrlPlcStatusLight"
        Me.Size = New System.Drawing.Size(440, 284)
        Me.GbStatusLine.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PbEndProcessOn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbEndProcessOff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbRunReturnOn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbRunReturnOff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GbDischargeLine.ResumeLayout(False)
        Me.GbDischargeLine.PerformLayout()
        CType(Me.PbRM4DischargeOn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbRM3DischargeOn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbRM2DischargeOn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbRM1DischargeOn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbRM3DischargeOff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbRM2DischargeOff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbRM1DischargeOff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbRM4DischargeOff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbStatusRun.ResumeLayout(False)
        Me.GbStatusRun.PerformLayout()
        CType(Me.PbRM4CompleteOn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbRM2CompleteOn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbRM3CompleteOn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbRM1CompleteOn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbRM1CompleteOff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbRM4CompleteOff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbRM3CompleteOff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbRM2CompleteOff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GbStatusLine As System.Windows.Forms.GroupBox
    Friend WithEvents GbStatusRun As System.Windows.Forms.GroupBox
    Friend WithEvents PbRM1CompleteOff As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GbDischargeLine As System.Windows.Forms.GroupBox
    Friend WithEvents PbRM3DischargeOff As System.Windows.Forms.PictureBox
    Friend WithEvents PbRM2DischargeOff As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PbRM1DischargeOff As System.Windows.Forms.PictureBox
    Friend WithEvents PbRM1CompleteOn As System.Windows.Forms.PictureBox
    Friend WithEvents PbRM1DischargeOn As System.Windows.Forms.PictureBox
    Friend WithEvents PbRM3DischargeOn As System.Windows.Forms.PictureBox
    Friend WithEvents PbRM2DischargeOn As System.Windows.Forms.PictureBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PbEndProcessOn As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PbEndProcessOff As System.Windows.Forms.PictureBox
    Friend WithEvents PbRunReturnOn As System.Windows.Forms.PictureBox
    Friend WithEvents PbRunReturnOff As System.Windows.Forms.PictureBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents PbRM4DischargeOn As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PbRM4DischargeOff As System.Windows.Forms.PictureBox
    Friend WithEvents PbRM4CompleteOn As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PbRM2CompleteOn As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PbRM3CompleteOn As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PbRM4CompleteOff As System.Windows.Forms.PictureBox
    Friend WithEvents PbRM3CompleteOff As System.Windows.Forms.PictureBox
    Friend WithEvents PbRM2CompleteOff As System.Windows.Forms.PictureBox

End Class
