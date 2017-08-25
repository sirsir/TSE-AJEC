<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGraphic
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGraphic))
        Me.lblCream = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pbCreamMotorOn = New System.Windows.Forms.PictureBox()
        Me.pbCreamMotorOff = New System.Windows.Forms.PictureBox()
        Me.pbSugarMotorOn = New System.Windows.Forms.PictureBox()
        Me.pbSugarMotorOff = New System.Windows.Forms.PictureBox()
        Me.pbCoffeeMotorOff = New System.Windows.Forms.PictureBox()
        Me.pbCoffeeMotorOn = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblCoffee = New System.Windows.Forms.Label()
        Me.lblSugar = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.PbCreamOn = New System.Windows.Forms.PictureBox()
        Me.pbCoffeeOn = New System.Windows.Forms.PictureBox()
        Me.PbSugarOn = New System.Windows.Forms.PictureBox()
        CType(Me.pbCreamMotorOn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCreamMotorOff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSugarMotorOn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSugarMotorOff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCoffeeMotorOff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCoffeeMotorOn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbCreamOn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCoffeeOn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbSugarOn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCream
        '
        Me.lblCream.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCream.AutoSize = True
        Me.lblCream.BackColor = System.Drawing.Color.Transparent
        Me.lblCream.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCream.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblCream.Location = New System.Drawing.Point(442, 473)
        Me.lblCream.Name = "lblCream"
        Me.lblCream.Size = New System.Drawing.Size(97, 31)
        Me.lblCream.TabIndex = 1
        Me.lblCream.Text = "000.00"
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblTotal.ForeColor = System.Drawing.Color.Black
        Me.lblTotal.Location = New System.Drawing.Point(474, 626)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(45, 24)
        Me.lblTotal.TabIndex = 3
        Me.lblTotal.Text = "00.00%"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblTotal.Visible = False
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(477, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Cream"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(221, 161)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 40)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Coffee Hopper"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbCreamMotorOn
        '
        Me.pbCreamMotorOn.BackColor = System.Drawing.Color.Transparent
        Me.pbCreamMotorOn.Image = Global.BCS.My.Resources.Resources.GearRunning
        Me.pbCreamMotorOn.Location = New System.Drawing.Point(505, 335)
        Me.pbCreamMotorOn.Name = "pbCreamMotorOn"
        Me.pbCreamMotorOn.Size = New System.Drawing.Size(99, 14)
        Me.pbCreamMotorOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCreamMotorOn.TabIndex = 12
        Me.pbCreamMotorOn.TabStop = False
        Me.pbCreamMotorOn.Visible = False
        '
        'pbCreamMotorOff
        '
        Me.pbCreamMotorOff.BackColor = System.Drawing.Color.Transparent
        Me.pbCreamMotorOff.Image = Global.BCS.My.Resources.Resources.GearStop
        Me.pbCreamMotorOff.Location = New System.Drawing.Point(505, 335)
        Me.pbCreamMotorOff.Name = "pbCreamMotorOff"
        Me.pbCreamMotorOff.Size = New System.Drawing.Size(99, 14)
        Me.pbCreamMotorOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCreamMotorOff.TabIndex = 11
        Me.pbCreamMotorOff.TabStop = False
        '
        'pbSugarMotorOn
        '
        Me.pbSugarMotorOn.BackColor = System.Drawing.Color.Transparent
        Me.pbSugarMotorOn.Image = Global.BCS.My.Resources.Resources.GearRunning
        Me.pbSugarMotorOn.Location = New System.Drawing.Point(659, 335)
        Me.pbSugarMotorOn.Name = "pbSugarMotorOn"
        Me.pbSugarMotorOn.Size = New System.Drawing.Size(97, 14)
        Me.pbSugarMotorOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbSugarMotorOn.TabIndex = 10
        Me.pbSugarMotorOn.TabStop = False
        Me.pbSugarMotorOn.Visible = False
        '
        'pbSugarMotorOff
        '
        Me.pbSugarMotorOff.BackColor = System.Drawing.Color.Transparent
        Me.pbSugarMotorOff.Image = Global.BCS.My.Resources.Resources.GearStop
        Me.pbSugarMotorOff.Location = New System.Drawing.Point(659, 335)
        Me.pbSugarMotorOff.Name = "pbSugarMotorOff"
        Me.pbSugarMotorOff.Size = New System.Drawing.Size(97, 14)
        Me.pbSugarMotorOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbSugarMotorOff.TabIndex = 9
        Me.pbSugarMotorOff.TabStop = False
        '
        'pbCoffeeMotorOff
        '
        Me.pbCoffeeMotorOff.BackColor = System.Drawing.Color.Transparent
        Me.pbCoffeeMotorOff.Image = Global.BCS.My.Resources.Resources.GearStop
        Me.pbCoffeeMotorOff.Location = New System.Drawing.Point(253, 335)
        Me.pbCoffeeMotorOff.Name = "pbCoffeeMotorOff"
        Me.pbCoffeeMotorOff.Size = New System.Drawing.Size(122, 14)
        Me.pbCoffeeMotorOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCoffeeMotorOff.TabIndex = 8
        Me.pbCoffeeMotorOff.TabStop = False
        '
        'pbCoffeeMotorOn
        '
        Me.pbCoffeeMotorOn.BackColor = System.Drawing.Color.Transparent
        Me.pbCoffeeMotorOn.Image = Global.BCS.My.Resources.Resources.GearRunning
        Me.pbCoffeeMotorOn.Location = New System.Drawing.Point(253, 335)
        Me.pbCoffeeMotorOn.Name = "pbCoffeeMotorOn"
        Me.pbCoffeeMotorOn.Size = New System.Drawing.Size(122, 14)
        Me.pbCoffeeMotorOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCoffeeMotorOn.TabIndex = 7
        Me.pbCoffeeMotorOn.TabStop = False
        Me.pbCoffeeMotorOn.Visible = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(219, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Coffee"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(726, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Sugar"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(474, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 40)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Cream Hopper"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(727, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 40)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Sugar Hopper"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(221, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 40)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Vibrating Hopper"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(474, 79)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 40)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Vibrating Hopper"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(723, 79)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 40)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Vibrating Hopper"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(350, 464)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(63, 40)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "Stock Hopper"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(602, 464)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(63, 40)
        Me.Label17.TabIndex = 27
        Me.Label17.Text = "Stock Hopper"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCoffee
        '
        Me.lblCoffee.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCoffee.AutoSize = True
        Me.lblCoffee.BackColor = System.Drawing.Color.Transparent
        Me.lblCoffee.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCoffee.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblCoffee.Location = New System.Drawing.Point(184, 473)
        Me.lblCoffee.Name = "lblCoffee"
        Me.lblCoffee.Size = New System.Drawing.Size(97, 31)
        Me.lblCoffee.TabIndex = 28
        Me.lblCoffee.Text = "000.00"
        '
        'lblSugar
        '
        Me.lblSugar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSugar.AutoSize = True
        Me.lblSugar.BackColor = System.Drawing.Color.Transparent
        Me.lblSugar.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSugar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblSugar.Location = New System.Drawing.Point(705, 473)
        Me.lblSugar.Name = "lblSugar"
        Me.lblSugar.Size = New System.Drawing.Size(97, 31)
        Me.lblSugar.TabIndex = 29
        Me.lblSugar.Text = "000.00"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(275, 473)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 31)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "kg"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(534, 473)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 31)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "kg"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(796, 473)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 31)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "kg"
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.Location = New System.Drawing.Point(932, 12)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(74, 38)
        Me.btnExit.TabIndex = 34
        Me.btnExit.Text = "Exit"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'PbCreamOn
        '
        Me.PbCreamOn.BackColor = System.Drawing.Color.Transparent
        Me.PbCreamOn.Image = Global.BCS.My.Resources.Resources.m2
        Me.PbCreamOn.Location = New System.Drawing.Point(456, 327)
        Me.PbCreamOn.Name = "PbCreamOn"
        Me.PbCreamOn.Size = New System.Drawing.Size(42, 37)
        Me.PbCreamOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbCreamOn.TabIndex = 35
        Me.PbCreamOn.TabStop = False
        Me.PbCreamOn.Visible = False
        '
        'pbCoffeeOn
        '
        Me.pbCoffeeOn.BackColor = System.Drawing.Color.Transparent
        Me.pbCoffeeOn.Image = Global.BCS.My.Resources.Resources.m2
        Me.pbCoffeeOn.Location = New System.Drawing.Point(205, 327)
        Me.pbCoffeeOn.Name = "pbCoffeeOn"
        Me.pbCoffeeOn.Size = New System.Drawing.Size(42, 37)
        Me.pbCoffeeOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCoffeeOn.TabIndex = 36
        Me.pbCoffeeOn.TabStop = False
        Me.pbCoffeeOn.Visible = False
        '
        'PbSugarOn
        '
        Me.PbSugarOn.BackColor = System.Drawing.Color.Transparent
        Me.PbSugarOn.Image = Global.BCS.My.Resources.Resources.m6
        Me.PbSugarOn.Location = New System.Drawing.Point(758, 327)
        Me.PbSugarOn.Name = "PbSugarOn"
        Me.PbSugarOn.Size = New System.Drawing.Size(42, 37)
        Me.PbSugarOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbSugarOn.TabIndex = 37
        Me.PbSugarOn.TabStop = False
        Me.PbSugarOn.Visible = False
        '
        'frmGraphic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.BCS.My.Resources.Resources.graphic_BG
        Me.ClientSize = New System.Drawing.Size(1018, 744)
        Me.ControlBox = False
        Me.Controls.Add(Me.PbSugarOn)
        Me.Controls.Add(Me.pbCoffeeOn)
        Me.Controls.Add(Me.PbCreamOn)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblSugar)
        Me.Controls.Add(Me.lblCoffee)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pbCreamMotorOn)
        Me.Controls.Add(Me.pbCreamMotorOff)
        Me.Controls.Add(Me.pbSugarMotorOn)
        Me.Controls.Add(Me.pbSugarMotorOff)
        Me.Controls.Add(Me.pbCoffeeMotorOff)
        Me.Controls.Add(Me.pbCoffeeMotorOn)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblCream)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmGraphic"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmGraphic"
        CType(Me.pbCreamMotorOn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCreamMotorOff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSugarMotorOn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSugarMotorOff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCoffeeMotorOff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCoffeeMotorOn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbCreamOn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCoffeeOn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbSugarOn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCream As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents pbCoffeeMotorOn As System.Windows.Forms.PictureBox
    Friend WithEvents pbCoffeeMotorOff As System.Windows.Forms.PictureBox
    Friend WithEvents pbSugarMotorOn As System.Windows.Forms.PictureBox
    Friend WithEvents pbSugarMotorOff As System.Windows.Forms.PictureBox
    Friend WithEvents pbCreamMotorOff As System.Windows.Forms.PictureBox
    Friend WithEvents pbCreamMotorOn As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lblCoffee As System.Windows.Forms.Label
    Friend WithEvents lblSugar As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents PbCreamOn As System.Windows.Forms.PictureBox
    Friend WithEvents pbCoffeeOn As System.Windows.Forms.PictureBox
    Friend WithEvents PbSugarOn As System.Windows.Forms.PictureBox
End Class
