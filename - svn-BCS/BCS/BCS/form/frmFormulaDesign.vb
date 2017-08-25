Public Class frmFormulaDesign
#Region "Public Variables"
    Public m_intFormulaId As Integer = -1
    Public m_intLineNo As Integer = -1
#End Region

#Region "Private Variables"
    'VIEW FOR VIEWING ONLY
    Dim m_strViewFormulaDesign As String = "V_FORMULA_DESIGN"

    Dim m_dtFormulaDetailInfo As DataTable

    'Show Column according to view
    Dim m_intColScale As Integer = 0
    Dim m_intColCheckBox As Integer = 1
    Dim m_intColCheckBoxCrusher As Integer = 2
    Dim m_intColRMName As Integer = 3
    Dim m_intColRMLot As Integer = 4
    Dim m_intColMax As Integer = 5
    Dim m_intColFinal As Integer = 6
    Dim m_intColMin As Integer = 7
    Dim m_intColSP1 As Integer = 8
    Dim m_intColSP2 As Integer = 9
    Dim m_intColCPS As Integer = 10
    Dim m_intColHzH As Integer = 11
    Dim m_intColHzM As Integer = 12
    Dim m_intColHzL As Integer = 13
    Dim m_intVisibleColumnCount As Integer = 14


    'Hidden Column
    Dim m_intColRevisionId As Integer = 14
    Dim m_intColumnCount As Integer = 15

    Dim m_strRoleId As String = "USR"

    'status
    Dim m_bView As Boolean = True
    Dim m_bEdit As Boolean = False
    Dim m_bNew As Boolean = False
    Dim m_bDelete As Boolean = False
    Dim m_bSave As Boolean = False

    'to check current cell object value
    Dim m_ObjCellValue As Object

    Dim m_intRevisionId As Integer = -1
    Dim m_intFormulaComboList As Integer()
    Private m_frmMain As frmBatchResult
#End Region

#Region "Constructor AND Destructor"
    Public Sub New(ByVal strRoleId As String, ByVal intFormulaId As Integer, ByRef frmMain As frmBatchResult)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        m_strRoleId = strRoleId
        m_intFormulaId = intFormulaId
        m_frmMain = frmMain
    End Sub
#End Region
#Region "Events"

    Private Sub frmFormulaDesign_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'If m_intLineNo = 1 Then
        '    m_frmMain.btnFormulaB1.Enabled = True
        'ElseIf m_intLineNo = 2 Then
        '    m_frmMain.btnFormulaB2.Enabled = True
        'End If

        m_frmMain.btnFormulaB1.Enabled = True
        m_frmMain.btnFormulaB2.Enabled = True
    End Sub
    Private Sub frmFormulaDesign_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'set header text for form
            Me.Text = "Formula Design For Line " & clsLineInfo.FindLineCode(m_intLineNo)

            'set view mode
            SetMode("View")

            'load formula combobox list and detail
            LoadFormula()
        Catch ex As Exception
            MessageBox.Show("frmFormulaDesign_Load : " & ex.ToString())
        End Try
    End Sub



    Private Sub cmbFormula_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFormula.SelectedIndexChanged
        Try
            'get selected index from formula ComboBox
            Dim intSelectedIndex As Integer = cmbFormula.SelectedIndex

            'check if the Combobox has selected
            If intSelectedIndex >= 0 Then
                If GetMode() = "View" Then
                    'in View mode can browse the formula detail freely
                    m_intFormulaId = m_intFormulaComboList(intSelectedIndex)
                    LoadFormulaDetail()
                    SetButtonActive(Nothing)
                ElseIf GetMode() = "New" Then
                    'in New mode need to ask before load formula detail and change to View mode
                    If MsgBox("New formula is not saved. Are you sure to close and view the existing formula?", MsgBoxStyle.OkCancel) = 1 Then
                        SetMode("View")
                        LoadFormula()
                        SetButtonActive(Nothing)
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("cmbFormula_SelectedIndexChanged : " & ex.ToString())
        End Try
    End Sub



    Private Sub DgFormulaDesigner_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgFormulaDesigner.CellEnter
        Try
            'get old value before edit
            m_ObjCellValue = DgFormulaDesigner.Item(e.ColumnIndex, e.RowIndex).Value
        Catch ex As Exception
            MessageBox.Show("DgFormulaDesigner_CellEnter : " & ex.ToString())
        End Try
    End Sub

    Private Sub DgFormulaDesigner_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgFormulaDesigner.CellEndEdit
        Try
            Dim dblValue As Double = 0
            Dim intValue As Integer = 0

            'check if it was edited in lock column then cannot make change in that specific column
            If e.ColumnIndex = m_intColScale Or e.ColumnIndex = m_intColCheckBox Or e.ColumnIndex = m_intColRMName Then
                GoTo Exit1
            End If

            'if the value is NULL, make it String.Empty
            If DgFormulaDesigner.Item(e.ColumnIndex, e.RowIndex).Value Is Nothing Then
                DgFormulaDesigner.Item(e.ColumnIndex, e.RowIndex).Value = String.Empty
            End If

            'if no old value, make it String.Empty
            If m_ObjCellValue Is Nothing Then
                m_ObjCellValue = String.Empty
            End If

            'if old value = new value then no change occur
            If DgFormulaDesigner.Item(e.ColumnIndex, e.RowIndex).Value.ToString = m_ObjCellValue.ToString Then
                GoTo Exit1
            End If

            If e.ColumnIndex = m_intColRMLot Then
                'RMLot Column is String Column
                If DgFormulaDesigner.Item(e.ColumnIndex, e.RowIndex).Value.ToString.Length > 10 Then
                    'input previous value into the table detail
                    DgFormulaDesigner.Item(e.ColumnIndex, e.RowIndex).Value = m_ObjCellValue
                End If
            ElseIf e.ColumnIndex = m_intColCheckBox Then
                Checked(e.RowIndex, DgFormulaDesigner.Item(e.ColumnIndex, e.RowIndex).Value)
            ElseIf e.ColumnIndex = m_intColCheckBoxCrusher Then
                'Checked(e.RowIndex, DgFormulaDesigner.Item(e.ColumnIndex, e.RowIndex).Value)
            ElseIf e.ColumnIndex <> m_intColScale And e.ColumnIndex <> m_intColRMName Then
                'other columns are double with 2decimal place
                If Double.TryParse(DgFormulaDesigner.Item(e.ColumnIndex, e.RowIndex).Value.ToString, dblValue) Then

                    'the format must be 00000000.00 and cannot be negative value
                    'If dblValue > 99.99 Then
                    '    dblValue = 99.99
                    'Else
                    If dblValue < 0 Then
                        dblValue = 0
                    End If

                    'input into the table detail
                    DgFormulaDesigner.Item(e.ColumnIndex, e.RowIndex).Value = Format(dblValue, ".00")
                Else
                    'input previous value into the table detail
                    DgFormulaDesigner.Item(e.ColumnIndex, e.RowIndex).Value = m_ObjCellValue
                End If
            Else
                'input previous value into the table detail
                DgFormulaDesigner.Item(e.ColumnIndex, e.RowIndex).Value = m_ObjCellValue
            End If
Exit1:
        Catch ex As Exception
            MessageBox.Show("DgFormulaDesigner_CellEndEdit : " & ex.ToString())
        End Try
    End Sub

    Private Sub DgFormulaDesigner_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgFormulaDesigner.CellContentClick
        If GetMode() = "Edit" And e.ColumnIndex = m_intColCheckBox Then
            Checked(e.RowIndex, DgFormulaDesigner.Rows(e.RowIndex).Cells(m_intColCheckBox).EditedFormattedValue)
        ElseIf GetMode() = "Edit" And e.ColumnIndex = m_intColCheckBoxCrusher Then
            Checked(e.RowIndex, DgFormulaDesigner.Rows(e.RowIndex).Cells(m_intColCheckBoxCrusher).EditedFormattedValue)
        End If
    End Sub
    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Try
            If GetMode() = "Edit" Then
                If MsgBox("Edit formula is not saved. Are you sure to finish editing formula?", MsgBoxStyle.OkCancel) = 1 Then
                    SetMode("View")
                    SetButtonActive(Nothing)
                    LoadFormulaDetail()
                End If
            Else
                If cmbFormula.SelectedIndex > -1 Then
                    SetMode("Edit")
                    SetButtonActive("Edit")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("btnEdit_Click : " & ex.ToString())
        End Try
    End Sub

    Private Sub cmbFormula_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles cmbFormula.KeyDown
        '    Dim intLastIndex As Integer = cmbFormula.SelectedIndex

        '    cmbFormula.Items(cmbFormula.SelectedIndex) = cmbFormula.Items(cmbFormula.SelectedIndex)


        '    ButtonNameEdit_Click(sender, e)
        '    'cmbFormula.Items(cmbFormula.SelectedIndex) = cmbFormula.Items(cmbFormula.SelectedIndex)
        '    cmbFormula.SelectedIndex = intLastIndex
    End Sub

    Private Sub ButtonNameEdit_Click(sender As System.Object, e As System.EventArgs) Handles ButtonNameEdit.Click

        Try
            If GetMode() = "Edit" Then
                If MsgBox("Edit formula is not saved. Are you sure to finish editing formula?", MsgBoxStyle.OkCancel) = 1 Then
                    SetMode("View")
                    SetButtonActive(Nothing)
                    LoadFormulaDetail()
                End If
            Else
                If cmbFormula.SelectedIndex > -1 Then
                    'SetMode("Edit")
                    'SetButtonActive("Edit")
                    SaveFormulaName()

                Else
                    MsgBox("Please select the formula name to be editted")



                    'strNewName = InputBox(clsFormulaInfo.FindByFormulaCodeLineNo(m_intFormulaId, m_intLineNo).FormulaName() & "===Replace to===>", "Input formula name:")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("btnNameEdit_Click : " & ex.ToString())
        End Try
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Try
            If m_strRoleId = "ADM" Then
                If GetMode() = "New" Then
                    If MsgBox("New formula is not saved. Are you sure to close?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                        SetMode("View")
                        SetButtonActive(Nothing)
                        SaveFormula()
                    End If
                Else
                    If MsgBox("Do you want to create new formula?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                        SetMode("New")
                        SetButtonActive("New")
                        NewFormula()
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("btnNew_Click : " & ex.ToString())
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If cmbFormula.SelectedIndex <> -1 Then

                If GetMode() = "New" Then
                    Clear()
                Else
                    If MsgBox("Are you sure to delete the Formula '" & cmbFormula.Text & "'", MsgBoxStyle.OkCancel) = 1 Then
                        SetMode("Delete")
                        SetButtonActive("Delete")
                        DeleteFormula()
                    End If
                End If
                SetMode("View")
                SetButtonActive(Nothing)
            End If
        Catch ex As Exception
            MessageBox.Show("btnDelete_Click : " & ex.ToString())
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If MsgBox("Confirm Saving Data", MsgBoxStyle.OkCancel) = 1 Then
                If ChkBeforeSave() Then
                    SaveFormula()
                    SetMode("View")
                    SetButtonActive("View")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("btnSave_Click : " & ex.ToString())
        End Try
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Try
            If GetMode() = "New" Then
                If MsgBox("New formula is not saved. Are you sure to close?", MsgBoxStyle.OkCancel) = 1 Then
                    SetButtonActive("Exit")
                    Me.Close()
                End If
            ElseIf GetMode() = "Edit" Then
                If MsgBox("Edit formula is not saved. Are you sure to close?", MsgBoxStyle.OkCancel) = 1 Then
                    SetButtonActive("Exit")
                    Me.Close()
                End If
            Else
                SetButtonActive("Exit")
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("btnExit_Click : " & ex.ToString())
        End Try
    End Sub
#End Region

#Region "Private Function"
    Private Sub Clear()
        Try
            cmbFormula.SelectedIndex = -1
            m_intFormulaComboList = clsFormulaInfo.AddFormulaNameToCombo(cmbFormula, m_intLineNo)
            DgFormulaDesigner.Rows.Clear()
        Catch ex As Exception
            MessageBox.Show("Clear : " & ex.ToString())
        End Try
    End Sub
    Private Sub LoadFormulaDetail()
        Dim iCol As Integer = 0
        Dim iRow As Integer = 0
        Dim sSqlCmd As String = "SELECT * FROM " & m_strViewFormulaDesign & _
                                            " WHERE REVISION_ID = (SELECT MAX(REVISION_ID) FROM REVISION WHERE FORMULA_ID = " & m_intFormulaId & _
                                            " )"

        'LOAD COLUMNS with ORDER
        sSqlCmd = sSqlCmd.Replace("*", "SCALE_NAME,CHECKED,CRUSHER,RM_CODE,RM_LOT,MAX_VALUE,FINAL_VALUE,MIN_VALUE,SP1_VALUE,SP2_VALUE,CPS_VALUE,HZ_H,HZ_M,HZ_L,REVISION_ID")

        Try
            m_dtFormulaDetailInfo = clsAdoxCached.GetDataTable(sSqlCmd)
            If m_dtFormulaDetailInfo.Rows.Count > 0 Then
                'Scale and RM Name is fixed and cannot be edited by both admin and user.
                LoadScaleAndRMName()

                'Input info into table
                For iRow = 0 To m_dtFormulaDetailInfo.Rows.Count - 1
                    For iCol = m_intColCheckBox To m_intVisibleColumnCount - 1
                        'DgFormulaDesigner.Item(iCol, iRow).Value = m_dtFormulaDetailInfo.Rows(iRow).Item(iCol)
                        DgFormulaDesigner.Item(iCol, iRow).Value = m_dtFormulaDetailInfo.Rows(iRow).Item(iCol)
                    Next
                    If Not m_dtFormulaDetailInfo.Rows(iRow).Item(m_intColCheckBox) = 1 Then
                        DgFormulaDesigner.Item(m_intColSP1, iRow).Value = 0
                        DgFormulaDesigner.Item(m_intColSP2, iRow).Value = 0
                        DgFormulaDesigner.Item(m_intColCPS, iRow).Value = 0
                    End If
                Next
                m_intRevisionId = m_dtFormulaDetailInfo.Rows(0).Item(m_dtFormulaDetailInfo.Columns.Count - 1)
            End If
        Catch ex As Exception
            MessageBox.Show("LoadFormulaDetail : " & ex.ToString())
        End Try
    End Sub
    Private Sub LoadScaleAndRMName()
        Dim dt As DataTable
        Dim intCountRow As Integer = 0
        Dim i As Integer = 0
        Try
            dt = clsRMInfo.FindAll()
            intCountRow = dt.Rows.Count
            DgFormulaDesigner.Rows.Clear()
            DgFormulaDesigner.Rows.Add(intCountRow)

            For i = 0 To intCountRow - 1
                DgFormulaDesigner.Item(m_intColRMName, i).Value = dt.Rows(i).Item("RM_CODE").ToString
                DgFormulaDesigner.Item(m_intColScale, i).Value = clsScaleInfo.FindScaleName(dt.Rows(i).Item("SCALE_ID"))
            Next
        Catch ex As Exception
            MessageBox.Show("LoadScaleAndRMName : " & ex.ToString())
        End Try
    End Sub
    Private Function ChkBeforeSave() As Boolean
        Dim bChkPass As Boolean = False
        Dim i As Integer = 0
        Dim j As Integer = 0
        Try
            If cmbFormula.Text = String.Empty Or cmbFormula.Text = Nothing Then
                MsgBox("Please Enter Fomula Name")
                GoTo goExit
            ElseIf GetMode() = "New" Then

                Dim strNewname As String = Trim(cmbFormula.Text)

                If strNewname <> "" AndAlso cmbFormula.FindStringExact(strNewname) > -1 Then
                    MsgBox("This formula name already exists! Please re-enter the new name.")
                    GoTo goExit
                End If
            End If

            For i = 0 To DgFormulaDesigner.Rows.Count - 1

                For j = m_intColRMLot To m_intVisibleColumnCount - 1
                    If DgFormulaDesigner.Item(j, i).Value Is Nothing OrElse _
                        DgFormulaDesigner.Item(j, i).Value.ToString = String.Empty Then
                        MsgBox("Please Enter All Formula Detail")
                        GoTo goExit
                    End If
                Next
            Next
            bChkPass = True
goExit:
            ChkBeforeSave = bChkPass
        Catch ex As Exception
            MessageBox.Show("ChkBeforeSave : " & ex.ToString())
            ChkBeforeSave = False
        End Try
    End Function

    Private Sub DgFormulaDesignerSetAction()
        Try
            If m_bView Then
                DgFormulaDesigner.Columns(m_intColScale).ReadOnly = True
                DgFormulaDesigner.Columns(m_intColCheckBox).ReadOnly = True
                DgFormulaDesigner.Columns(m_intColCheckBoxCrusher).ReadOnly = True
                DgFormulaDesigner.Columns(m_intColRMName).ReadOnly = True
                DgFormulaDesigner.Columns(m_intColRMLot).ReadOnly = True
                DgFormulaDesigner.Columns(m_intColMax).ReadOnly = True
                DgFormulaDesigner.Columns(m_intColFinal).ReadOnly = True
                DgFormulaDesigner.Columns(m_intColMin).ReadOnly = True
                DgFormulaDesigner.Columns(m_intColSP1).ReadOnly = True
                DgFormulaDesigner.Columns(m_intColSP2).ReadOnly = True
                DgFormulaDesigner.Columns(m_intColCPS).ReadOnly = True
            ElseIf m_bEdit And m_strRoleId = "USR" Then
                DgFormulaDesigner.Columns(m_intColScale).ReadOnly = True
                DgFormulaDesigner.Columns(m_intColCheckBox).ReadOnly = False
                DgFormulaDesigner.Columns(m_intColCheckBoxCrusher).ReadOnly = False
                DgFormulaDesigner.Columns(m_intColRMName).ReadOnly = True
                DgFormulaDesigner.Columns(m_intColRMLot).ReadOnly = False
                DgFormulaDesigner.Columns(m_intColMax).ReadOnly = True
                DgFormulaDesigner.Columns(m_intColFinal).ReadOnly = True
                DgFormulaDesigner.Columns(m_intColMin).ReadOnly = True
                DgFormulaDesigner.Columns(m_intColSP1).ReadOnly = True
                DgFormulaDesigner.Columns(m_intColSP2).ReadOnly = True
                DgFormulaDesigner.Columns(m_intColCPS).ReadOnly = True
            ElseIf m_bNew Or (m_strRoleId = "ADM" And m_bEdit) Then
                DgFormulaDesigner.Columns(m_intColScale).ReadOnly = True
                DgFormulaDesigner.Columns(m_intColCheckBox).ReadOnly = False
                DgFormulaDesigner.Columns(m_intColCheckBoxCrusher).ReadOnly = False
                DgFormulaDesigner.Columns(m_intColRMName).ReadOnly = True
                DgFormulaDesigner.Columns(m_intColRMLot).ReadOnly = False
                DgFormulaDesigner.Columns(m_intColMax).ReadOnly = False
                DgFormulaDesigner.Columns(m_intColFinal).ReadOnly = False
                DgFormulaDesigner.Columns(m_intColMin).ReadOnly = False
                DgFormulaDesigner.Columns(m_intColSP1).ReadOnly = False
                DgFormulaDesigner.Columns(m_intColSP2).ReadOnly = False
                DgFormulaDesigner.Columns(m_intColCPS).ReadOnly = False
            End If
        Catch ex As Exception
            MessageBox.Show("DgFormulaDesignerSetAction : " & ex.ToString())
        End Try
    End Sub

    Private Sub Checked(ByVal intRow As Integer, ByVal bChecked As Boolean)
        Try
            If bChecked Then
                DgFormulaDesigner.Item(m_intColSP1, intRow).ReadOnly = False
                DgFormulaDesigner.Item(m_intColSP2, intRow).ReadOnly = False
                DgFormulaDesigner.Item(m_intColCPS, intRow).ReadOnly = False
                DgFormulaDesigner.Item(m_intColSP1, intRow).Value = m_dtFormulaDetailInfo.Rows(intRow).Item(m_intColSP1)
                DgFormulaDesigner.Item(m_intColSP2, intRow).Value = m_dtFormulaDetailInfo.Rows(intRow).Item(m_intColSP2)
                DgFormulaDesigner.Item(m_intColCPS, intRow).Value = m_dtFormulaDetailInfo.Rows(intRow).Item(m_intColCPS)
            Else
                DgFormulaDesigner.Item(m_intColSP1, intRow).Value = 0
                DgFormulaDesigner.Item(m_intColSP2, intRow).Value = 0
                DgFormulaDesigner.Item(m_intColCPS, intRow).Value = 0
                DgFormulaDesigner.Item(m_intColSP1, intRow).ReadOnly = True
                DgFormulaDesigner.Item(m_intColSP2, intRow).ReadOnly = True
                DgFormulaDesigner.Item(m_intColCPS, intRow).ReadOnly = True
            End If
        Catch ex As Exception
            MessageBox.Show("Checked : " & ex.ToString())
        End Try
    End Sub
    Private Sub NewFormula()
        Try
            Clear()
            LoadScaleAndRMName()
            DgFormulaDesignerSetAction()
        Catch ex As Exception
            MessageBox.Show("NewFormula : " & ex.ToString())
        End Try
    End Sub
    Private Sub LoadFormula()
        Try
            Clear()
            If (m_intFormulaId > 0) Then
                'cmbFormula.Text = clsFormulaInfo.Find(m_intFormulaId).FormulaName

                cmbFormula.Text = clsFormulaInfo.FindByFormulaCodeLineNo(m_intFormulaId, m_intLineNo).FormulaName()
            Else
                cmbFormula.SelectedIndex = -1
            End If
            LoadFormulaDetail()
            DgFormulaDesignerSetAction()
        Catch ex As Exception
            MessageBox.Show("LoadFormula : " & ex.ToString())
        End Try
    End Sub

    Private Sub SaveFormulaName()
        Dim strNewname, strOldname As String

        'strOldname = clsFormulaInfo.FindByFormulaCodeLineNo(m_intFormulaId, m_intLineNo).FormulaName()
        strOldname = cmbFormula.Text

        strNewname = strOldname

        Do While True
            strNewname = InputBox("OLD NAME: " & strOldname & Environment.NewLine & Environment.NewLine & Environment.NewLine & Environment.NewLine & Environment.NewLine & "NEW NAME:", "Change Formula Name", strOldname)

            If strNewname <> "" AndAlso cmbFormula.FindStringExact(strNewname) = -1 Then
                Exit Do
            ElseIf strNewname <> "" AndAlso cmbFormula.FindStringExact(strNewname) > -1 Then
                MsgBox("This formula name already exists! Please change re-enter the new name.")
            ElseIf strNewname = "" Then
                Exit Do


            End If

        Loop



        If strNewname = strOldname Or strNewname = "" Then
            MsgBox("Formula rename is CANCEL.")
            Exit Sub
        End If

        'Dim sSqlCmd As String = _
        '    " Update [FORMULA_MASTER] fm" & _
        '    " SET fm.[FORMULA_NAME] = " & strNewname & _
        '    " WHERE fm.[LINE_NO] = " & m_intLineNo & _
        '    " AND fm.[FORMULA_CODE] = " & m_intFormulaId

        Dim sSqlCmd As String = _
            "Update fm" & _
            " SET fm.[FORMULA_NAME] = '" & strNewname & "'" & _
            " FROM [FORMULA_MASTER] fm" & _
            " WHERE fm.[LINE_NO] = " & m_intLineNo & _
            " AND fm.[FORMULA_NAME] = '" & strOldname & "'" & _
            " AND fm.[FORMULA_CODE] = " & (cmbFormula.SelectedIndex + 1)

        'MsgBox(sSqlCmd)



        clsAdoxCached.Execute(sSqlCmd)
        clsLog.AddLog(clsLog.eWriteLog.FormulaDesignRename, "[" & strOldname & "]==>[" & strNewname & "]")

        If cmbFormula.SelectedIndex > -1 Then
            cmbFormula.Items(cmbFormula.SelectedIndex) = strNewname
        End If


    End Sub
    Private Sub SaveFormula()
        'Save Header
        'Dim intLineNo As Integer = 1
        Dim intNextRevisionNo As Integer = -1
        Dim intLastestRevisionNo As Integer = -1
        Dim i As Integer
        Dim objFormulaInfo As clsFormulaInfo = Nothing
        Dim objOldFormulaDetailInfo As clsFormulaDetailInfo = Nothing
        Dim objRevisionInfo As clsRevisionInfo = Nothing
        Try
            clsAdoxCached.BeginTransaction()

            Dim dtRMInfo As DataTable = clsRMInfo.FindAll()
            'get object FormulaInfo
            If GetMode() = "New" Then
                objFormulaInfo = clsFormulaInfo.Create(clsFormulaInfo.FindLastestCode(m_intLineNo) + 1, Trim(cmbFormula.Text), m_intLineNo)
                clsLog.AddLog(clsLog.eWriteLog.FormulaDesignNewSave, "[" & objFormulaInfo.FormulaName & "]")
            ElseIf GetMode() = "Edit" Then
                objFormulaInfo = clsFormulaInfo.Find(m_intFormulaId)
                clsLog.AddLog(clsLog.eWriteLog.FormulaDesignEditSave, "[" & objFormulaInfo.FormulaName & "]")
            End If

            'Create new RevisionInfo
            intNextRevisionNo = clsRevisionInfo.FindLastestID() + 1
            objRevisionInfo = clsRevisionInfo.Create(objFormulaInfo.FormulaId, intNextRevisionNo, False)

            SetMode("Save")
            'Save Detail
            For i = 0 To DgFormulaDesigner.RowCount - 1
                Dim int4CHECKED As Integer
                Dim int4CRUSHER As Integer
                If DgFormulaDesigner.Item(m_intColCheckBox, i).Value Then
                    int4CHECKED = 1
                Else
                    int4CHECKED = 0
                End If

                If DgFormulaDesigner.Item(m_intColCheckBoxCrusher, i).Value Then
                    int4CRUSHER = 1
                Else
                    int4CRUSHER = 0
                End If


                If int4CHECKED = 1 Then
                    clsFormulaDetailInfo.Create(dtRMInfo.Rows(i).Item("RM_NO"), _
                                                objRevisionInfo.RevisionId, _
                                               int4CHECKED, _
                                               int4CRUSHER, _
                                                Trim(DgFormulaDesigner.Item(m_intColRMLot, i).Value), _
                                                CDbl(Trim(DgFormulaDesigner.Item(m_intColMax, i).Value)), _
                                                CDbl(Trim(DgFormulaDesigner.Item(m_intColFinal, i).Value)), _
                                                CDbl(Trim(DgFormulaDesigner.Item(m_intColMin, i).Value)), _
                                                CDbl(Trim(DgFormulaDesigner.Item(m_intColSP1, i).Value)), _
                                                CDbl(Trim(DgFormulaDesigner.Item(m_intColSP2, i).Value)), _
                                                CDbl(Trim(DgFormulaDesigner.Item(m_intColCPS, i).Value)), _
                                                CDbl(Trim(DgFormulaDesigner.Item(m_intColHzH, i).Value)), _
                                                CDbl(Trim(DgFormulaDesigner.Item(m_intColHzM, i).Value)), _
                                                CDbl(Trim(DgFormulaDesigner.Item(m_intColHzL, i).Value)) _
                                                )
                Else
                    objOldFormulaDetailInfo = clsFormulaDetailInfo.Find(i + 1, m_intRevisionId)
                    clsFormulaDetailInfo.Create(dtRMInfo.Rows(i).Item("RM_NO"), _
                            objRevisionInfo.RevisionId, _
                            int4CHECKED, _
                            int4CRUSHER, _
                            Trim(DgFormulaDesigner.Item(m_intColRMLot, i).Value), _
                            m_dtFormulaDetailInfo.Rows(i).Item("MAX_VALUE"), _
                            m_dtFormulaDetailInfo.Rows(i).Item("FINAL_VALUE"), _
                            m_dtFormulaDetailInfo.Rows(i).Item("MIN_VALUE"), _
                            m_dtFormulaDetailInfo.Rows(i).Item("SP1_VALUE"), _
                            m_dtFormulaDetailInfo.Rows(i).Item("SP2_VALUE"), _
                            m_dtFormulaDetailInfo.Rows(i).Item("CPS_VALUE"), _
                            m_dtFormulaDetailInfo.Rows(i).Item("HZ_H"), _
                            m_dtFormulaDetailInfo.Rows(i).Item("HZ_M"), _
                            m_dtFormulaDetailInfo.Rows(i).Item("HZ_L") _
                            )
                End If
            Next
            clsRevisionInfo.SetNextRevision(objFormulaInfo.FormulaCode, m_intLineNo)
            clsAdoxCached.CommitTransaction()

            m_frmMain.m_intOldFormulaCode(m_intLineNo - 1) = -1

            Dim objBatchComm As clsBatchComm
            objBatchComm = DirectCast(m_frmMain.ArrayBatchComm(m_intLineNo - 1), clsBatchComm)
            objBatchComm.FormulaToSend = objFormulaInfo.FormulaCode

            m_intRevisionId = intNextRevisionNo
            m_intFormulaId = objFormulaInfo.FormulaId
            m_intFormulaComboList = clsFormulaInfo.AddFormulaNameToCombo(cmbFormula, m_intLineNo)
            If objFormulaInfo IsNot Nothing _
                AndAlso objFormulaInfo.FormulaName IsNot Nothing _
                AndAlso objFormulaInfo.FormulaName <> String.Empty Then
                cmbFormula.SelectedIndex = cmbFormula.Items.IndexOf(objFormulaInfo.FormulaName)
            Else
                cmbFormula.SelectedIndex = -1
            End If
        Catch ex As Exception
            MessageBox.Show("SaveFormula : " & ex.ToString())
            clsAdoxCached.RollbackTransaction()
        End Try
        SetButtonActive(Nothing)
    End Sub

    Private Sub DeleteFormula()
        Dim strFormulaName As String
        Try
            strFormulaName = clsFormulaInfo.Find(m_intFormulaId).FormulaName

            'Delete Detail
            clsFormulaDetailInfo.Delete(m_intRevisionId)
            clsRevisionInfo.DeleteAllByFormula(m_intFormulaId)
            clsFormulaInfo.Delete(m_intFormulaId)
            Clear()
            clsLog.AddLog(clsLog.eWriteLog.FormulaDesignDelete, "[" & strFormulaName & "]")
        Catch ex As Exception
            MessageBox.Show("DeleteFormula : " & ex.ToString())
        End Try
    End Sub
    Private Sub SetMode(ByVal strMode As String)
        Try
            If strMode = "New" Then
                cmbFormula.Enabled = True
                btnSave.Enabled = True
                btnDelete.Enabled = True
                btnEdit.Enabled = False
                btnNew.Enabled = True
                m_bView = False
                m_bEdit = False
                m_bNew = True
                m_bDelete = False
                m_bSave = False
            ElseIf strMode = "Edit" Then
                cmbFormula.Enabled = False
                btnSave.Enabled = True
                btnDelete.Enabled = False
                btnEdit.Enabled = True
                btnNew.Enabled = False
                m_bView = False
                m_bEdit = True
                m_bNew = False
                m_bDelete = False
                m_bSave = False
            ElseIf strMode = "View" Then
                cmbFormula.Enabled = True
                btnSave.Enabled = False
                btnDelete.Enabled = True
                btnEdit.Enabled = True
                btnNew.Enabled = True
                m_bView = True
                m_bEdit = False
                m_bNew = False
                m_bDelete = False
                m_bSave = False
            ElseIf strMode = "Delete" Then
                m_bView = False
                m_bEdit = False
                m_bNew = False
                m_bDelete = True
                m_bSave = False
            ElseIf strMode = "Save" Then
                m_bView = False
                m_bEdit = False
                m_bNew = False
                m_bDelete = False
                m_bSave = True
            End If
            If m_strRoleId = "USR" Then
                btnNew.Enabled = False
                btnDelete.Enabled = False
            End If
            DgFormulaDesignerSetAction()
        Catch ex As Exception
            MessageBox.Show("SetMode : " & ex.ToString())
        End Try
    End Sub

    Private Function GetMode() As String
        Try
            GetMode = Nothing
            If m_bNew Then
                GetMode = "New"
            ElseIf m_bEdit Then
                GetMode = "Edit"
            ElseIf m_bView Then
                GetMode = "View"
            ElseIf m_bDelete Then
                GetMode = "Delete"
            ElseIf m_bSave Then
                GetMode = "Save"
            End If
        Catch ex As Exception
            MessageBox.Show("GetMode : " & ex.ToString())
            GetMode = Nothing
        End Try
    End Function
    Private Sub SetButtonActive(ByVal strButton As String)
        Try
            If strButton = "New" Then
                btnEdit.FlatStyle = FlatStyle.Standard
                ButtonNameEdit.Enabled = False
                ButtonNameEdit.FlatStyle = FlatStyle.Flat
                btnNew.FlatStyle = FlatStyle.Flat
                btnDelete.FlatStyle = FlatStyle.Standard
                btnSave.FlatStyle = FlatStyle.Standard
                btnExit.FlatStyle = FlatStyle.Standard
            ElseIf strButton = "Edit" Then
                ButtonNameEdit.Enabled = False
                btnEdit.FlatStyle = FlatStyle.Flat
                ButtonNameEdit.FlatStyle = FlatStyle.Standard
                btnNew.FlatStyle = FlatStyle.Standard
                btnDelete.FlatStyle = FlatStyle.Standard
                btnSave.FlatStyle = FlatStyle.Standard
                btnExit.FlatStyle = FlatStyle.Standard
            ElseIf strButton = "Save" Then
                ButtonNameEdit.Enabled = True
                btnEdit.FlatStyle = FlatStyle.Standard
                ButtonNameEdit.FlatStyle = FlatStyle.Standard
                btnNew.FlatStyle = FlatStyle.Standard
                btnDelete.FlatStyle = FlatStyle.Standard
                btnSave.FlatStyle = FlatStyle.Flat
                btnExit.FlatStyle = FlatStyle.Standard
            ElseIf strButton = "Delete" Then
                btnEdit.FlatStyle = FlatStyle.Standard
                ButtonNameEdit.Enabled = True
                ButtonNameEdit.FlatStyle = FlatStyle.Standard
                btnNew.FlatStyle = FlatStyle.Standard
                btnDelete.FlatStyle = FlatStyle.Flat
                btnSave.FlatStyle = FlatStyle.Standard
                btnExit.FlatStyle = FlatStyle.Standard
            ElseIf strButton = "Exit" Then
                btnEdit.FlatStyle = FlatStyle.Standard
                ButtonNameEdit.Enabled = True
                ButtonNameEdit.FlatStyle = FlatStyle.Standard
                btnNew.FlatStyle = FlatStyle.Standard
                btnDelete.FlatStyle = FlatStyle.Standard
                btnSave.FlatStyle = FlatStyle.Standard
                btnExit.FlatStyle = FlatStyle.Flat
            Else
                ButtonNameEdit.Enabled = True
                btnEdit.FlatStyle = FlatStyle.Standard
                btnNew.FlatStyle = FlatStyle.Standard
                ButtonNameEdit.FlatStyle = FlatStyle.Standard
                btnDelete.FlatStyle = FlatStyle.Standard
                btnSave.FlatStyle = FlatStyle.Standard
                btnExit.FlatStyle = FlatStyle.Standard
            End If
        Catch ex As Exception
            MessageBox.Show("SetButtonActive : " & ex.ToString())
        End Try
    End Sub
#End Region

#Region "Public Function"

#End Region



End Class
