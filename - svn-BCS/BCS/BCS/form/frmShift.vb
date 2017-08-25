Public Class frmShift

#Region "Public Variables"
#End Region

#Region "Private Variables"
    Private m_intColName As Integer = 0
    Private m_intColStartHr As Integer = 1
    Private m_intColStartMin As Integer = 2
    Private m_intColTo As Integer = 3
    Private m_intColEndHr As Integer = 4
    Private m_intColEndMin As Integer = 5

    'to check current cell object value
    Dim m_ObjCellValue As Object
#End Region

#Region "Properties"
#End Region

#Region "Constructor AND Destructor"
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub
#End Region

#Region "Events"
    Private Sub frmShift_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim objShiftInfo As DataTable = clsShiftInfo.FindAll
        Dim i As Integer
        DgShift.Rows.Clear()
        DgShift.Rows.Add(objShiftInfo.Rows.Count)
        DgShift.Columns(m_intColTo).DefaultCellStyle.BackColor = Color.Gray
        For i = 0 To DgShift.Rows.Count - 1
            DgShift.Item(m_intColName, i).Value = objShiftInfo.Rows(i).Item("SHIFT_NAME")
            DgShift.Item(m_intColStartHr, i).Value = objShiftInfo.Rows(i).Item("TIME_START_HR")
            DgShift.Item(m_intColStartMin, i).Value = objShiftInfo.Rows(i).Item("TIME_START_MIN")
            DgShift.Item(m_intColTo, i).Value = " - "
            DgShift.Item(m_intColEndHr, i).Value = objShiftInfo.Rows(i).Item("TIME_END_HR")
            DgShift.Item(m_intColEndMin, i).Value = objShiftInfo.Rows(i).Item("TIME_END_MIN")
        Next
    End Sub

    Private Sub DgShift_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgShift.CellEnter
        Try
            'get old value before edit
            m_ObjCellValue = DgShift.Item(e.ColumnIndex, e.RowIndex).Value
        Catch ex As Exception
            MessageBox.Show("DgShift_CellEnter : " & ex.ToString())
        End Try
    End Sub
    Private Sub DgShift_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgShift.CellEndEdit
        Dim intValue As Integer
        Try
            'check if it was edited in lock column then cannot make change in that specific column
            If e.ColumnIndex = m_intColTo Then
                GoTo Exit1
            End If

            'if the value is NULL, make it String.Empty
            If DgShift.Item(e.ColumnIndex, e.RowIndex).Value Is Nothing Then
                DgShift.Item(e.ColumnIndex, e.RowIndex).Value = String.Empty
            End If

            'if no old value, make it String.Empty
            If m_ObjCellValue Is Nothing Then
                m_ObjCellValue = String.Empty
            End If

            'if old value = new value then no change occur
            If DgShift.Item(e.ColumnIndex, e.RowIndex).Value.ToString = m_ObjCellValue.ToString Then
                GoTo Exit1
            End If

            If e.ColumnIndex = m_intColName Then
                'for string column
                If DgShift.Item(e.ColumnIndex, e.RowIndex).Value.ToString.Length > 32 Then
                    'input previous value into the table detail
                    DgShift.Item(e.ColumnIndex, e.RowIndex).Value = m_ObjCellValue
                End If
            ElseIf e.ColumnIndex = m_intColStartHr Or e.ColumnIndex = m_intColEndHr Then
                'for integer column
                If Integer.TryParse(DgShift.Item(e.ColumnIndex, e.RowIndex).Value.ToString, intValue) Then
                    If intValue > 23 Then
                        intValue = 23
                    ElseIf intValue < 0 Then
                        intValue = 0
                    End If

                    'input into the table detail
                    DgShift.Item(e.ColumnIndex, e.RowIndex).Value = intValue
                Else
                    'input previous value into the table detail
                    DgShift.Item(e.ColumnIndex, e.RowIndex).Value = m_ObjCellValue
                End If
            ElseIf e.ColumnIndex = m_intColStartMin Or e.ColumnIndex = m_intColEndMin Then
                'for integer column
                If Integer.TryParse(DgShift.Item(e.ColumnIndex, e.RowIndex).Value.ToString, intValue) Then
                    If intValue > 59 Then
                        intValue = 59
                    ElseIf intValue < 0 Then
                        intValue = 0
                    End If

                    'input into the table detail
                    DgShift.Item(e.ColumnIndex, e.RowIndex).Value = intValue
                Else
                    'input previous value into the table detail
                    DgShift.Item(e.ColumnIndex, e.RowIndex).Value = m_ObjCellValue
                End If
            End If
Exit1:
        Catch ex As Exception
            MessageBox.Show("DgFormulaDesigner_CellEndEdit : " & ex.ToString())
        End Try
    End Sub
    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If CheckShiftIntercept() Then
            For i = 0 To DgShift.Rows.Count - 1
                clsShiftInfo.Update(i + 1, _
                                    DgShift.Item(m_intColName, i).Value, _
                                    DgShift.Item(m_intColStartHr, i).Value, _
                                    DgShift.Item(m_intColStartMin, i).Value, _
                                    DgShift.Item(m_intColEndHr, i).Value, _
                                    DgShift.Item(m_intColEndMin, i).Value
                                    )
            Next
            Me.Close()
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
#End Region

#Region "Private Function"
    Private Function GetTimeSpan(ByVal intHour As Integer, ByVal intMin As Integer) As TimeSpan
        GetTimeSpan = TimeSpan.Parse(intHour & ":" & intMin)
    End Function
    Private Function CheckShiftIntercept() As Boolean
        Dim tmShiftStart As TimeSpan
        Dim tmShiftEnd As TimeSpan
        Dim tmShiftStartForCompare As TimeSpan
        Dim tmShiftEndForCompare As TimeSpan
        CheckShiftIntercept = False
        For i As Integer = 0 To DgShift.Rows.Count - 2
            tmShiftStart = GetTimeSpan(DgShift.Item(m_intColStartHr, i).Value, DgShift.Item(m_intColStartMin, i).Value)
            tmShiftEnd = GetTimeSpan(DgShift.Item(m_intColEndHr, i).Value, DgShift.Item(m_intColEndMin, i).Value)
            For j As Integer = i + 1 To DgShift.Rows.Count - 1
                tmShiftStartForCompare = GetTimeSpan(DgShift.Item(m_intColStartHr, j).Value, DgShift.Item(m_intColStartMin, j).Value)
                tmShiftEndForCompare = GetTimeSpan(DgShift.Item(m_intColEndHr, j).Value, DgShift.Item(m_intColEndMin, j).Value)
                If tmShiftStart = tmShiftStartForCompare Or tmShiftStart = tmShiftEndForCompare _
                Or tmShiftEnd = tmShiftStartForCompare Or tmShiftEnd = tmShiftEndForCompare Then
                    CheckShiftIntercept = False
                    MessageBox.Show("กะ " & clsShiftInfo.FindShiftName(i + 1) & "และกะ " & clsShiftInfo.FindShiftName(j + 1) & "มีช่วงเวลาที่ซ้ำซ้อนกันอยู่ กรุณาแก้ค่าใหม่")
                    GoTo Exit1
                End If
                If tmShiftStart <= tmShiftEnd Then
                    'shift start and end in same day
                    If tmShiftStartForCompare <= tmShiftEndForCompare Then
                        'shift for compare start and end in same day
                        If (tmShiftEnd < tmShiftStartForCompare And tmShiftStart < tmShiftStartForCompare) _
                            Or (tmShiftEndForCompare < tmShiftStart And tmShiftStartForCompare < tmShiftStart) _
                            Then
                            CheckShiftIntercept = True
                        Else
                            CheckShiftIntercept = False
                            MessageBox.Show("กะ " & clsShiftInfo.FindShiftName(i + 1) & "และกะ " & clsShiftInfo.FindShiftName(j + 1) & "มีช่วงเวลาที่ซ้ำซ้อนกันอยู่ กรุณาแก้ค่าใหม่")
                            GoTo Exit1
                        End If
                    Else
                        'shift for compare start and end in different day
                        If tmShiftStart > tmShiftEndForCompare _
                        And tmShiftStartForCompare > tmShiftStart _
                        And tmShiftStartForCompare > tmShiftEnd Then
                            CheckShiftIntercept = True
                        Else
                            CheckShiftIntercept = False
                            MessageBox.Show("กะ " & clsShiftInfo.FindShiftName(i + 1) & "และกะ " & clsShiftInfo.FindShiftName(j + 1) & "มีช่วงเวลาที่ซ้ำซ้อนกันอยู่ กรุณาแก้ค่าใหม่")
                            GoTo Exit1
                        End If
                    End If
                Else
                    'shift start and end in different day
                    If tmShiftEnd < tmShiftStartForCompare _
                    And tmShiftEndForCompare < tmShiftStart Then
                        CheckShiftIntercept = True
                    Else
                        CheckShiftIntercept = False
                        MessageBox.Show("กะ" & clsShiftInfo.FindShiftName(i + 1) & " และกะ" & clsShiftInfo.FindShiftName(j + 1) & " มีช่วงเวลาที่ซ้ำซ้อนกันอยู่ กรุณาแก้เวลาใหม่")
                        GoTo Exit1
                    End If
                End If
            Next
        Next
        If CheckShiftIntercept = False Then
            MessageBox.Show("ไม่มีกะทำงาน")
        End If
Exit1:
    End Function
#End Region
End Class