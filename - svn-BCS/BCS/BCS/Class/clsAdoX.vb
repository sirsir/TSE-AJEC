Option Explicit On

Imports System.Data.OleDb

Public Class clsAdoX

#Region "MEMBER VARIABLE"
    Private m_adoconn As New OleDbConnection
    Private m_strConnectionString As String
    Private m_tran As OleDbTransaction
    Private m_objLogger As clsLogger
#End Region

#Region "CONSTRUCTOR AND DESTRUCTOR"
    Public Sub New()
        If My.Settings.AdoXConnectionString <> "" Then
            m_strConnectionString = My.Settings.AdoXConnectionString
            Initialize()
        End If
    End Sub

    Public Sub New(ByVal ConnectionString As String)
        m_strConnectionString = ConnectionString
        Initialize()
    End Sub

    Private Sub Initialize()
        m_tran = Nothing
        m_objLogger = New clsLogger
        OpenConnection(m_strConnectionString)
    End Sub

    Protected Overrides Sub Finalize()
        CloseConnection()
        MyBase.Finalize()
    End Sub
#End Region

#Region "PUBLIC PROPERTIES"
    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : DefaultActiveConnection
    '   Purpose         : Get or set default connection of this class
    '   Created         : Korakot 15/01/2007
    '   Modified        :
    '
    '   Syntax          : (Set) OleDbConnection
    '   Return Value    : (Get) OleDbConnection
    '--------------------------------------------------------------------------------------------------------
    Public Property DefaultActiveConnection() As OleDbConnection
        Get
            Return m_adoconn
            Exit Property
        End Get
        Set(ByVal value As OleDbConnection)
            m_strConnectionString = value.ConnectionString
            OpenConnection(m_strConnectionString)
        End Set
    End Property
#End Region

#Region "PUBLIC FUNCTION"

#Region "Connection"
    '-------------------------------------------------------------
    '   Function Name   : OpenConnection
    '   Purpose         : Open connection
    '   Created         : Korakot 31/01/2007
    '   Modified        :
    '
    '   Linked          : HandleError
    '-------------------------------------------------------------
    Public Sub OpenConnection()
        Try
            CloseConnection()
            m_adoconn.Open()
        Catch
            MsgBox("Error Sub OpenConnection")
        End Try
    End Sub

    '-------------------------------------------------------------
    '   Function Name   : CloseConnection
    '   Purpose         : Close connection
    '   Created         : Korakot 11/01/2007
    '   Modified        :
    '
    '   Linked          : HandleError
    '-------------------------------------------------------------
    Public Sub CloseConnection()
        Try
            If m_adoconn.State = ConnectionState.Open Then
                m_adoconn.Close()
            End If
        Catch ex As Exception
            'MsgBox("Error Sub CloseConnection")
            'Dim objLogger As New clsLogger
            m_objLogger.AppendLog("Cannot Close Connection", clsLogger.enumLogType.eError)
        End Try
    End Sub

    '-------------------------------------------------------------
    '   Function Name   : BeginTransaction
    '   Purpose         : Begin Transaction
    '   Created         : Korakot 18/01/2007
    '   Modified        :
    '
    '   Linked          : HandleError
    '                   : clsRedoLogKeeper.BeginTransComplete
    '-------------------------------------------------------------
    Public Sub BeginTransaction()
        Try
            m_tran = m_adoconn.BeginTransaction()

        Catch
            MsgBox("Error Sub BeginTransaction")
        End Try
    End Sub

    '-------------------------------------------------------------
    '   Function Name   : CommitTransaction
    '   Purpose         : Commit Transaction
    '   Created         : Korakot 18/01/2007
    '   Modified        :
    '
    '   Linked          : HandleError
    '-------------------------------------------------------------
    Public Sub CommitTransaction()
        Try
            If m_tran IsNot Nothing Then
                m_tran.Commit()

            End If

        Catch ex As Exception
            'HandleError("Sub CommitTransaction", ex)
            Throw ex
        End Try
    End Sub

    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : RollbackTransaction
    '   Purpose         : Rollback transaction and saving error
    '   Created         : Korakot 10/01/2007
    '   Modified        :
    '   
    '   Linked          : SaveError
    '                   : LoadError
    '                   : HandleError
    '--------------------------------------------------------------------------------------------------------
    Public Sub RollbackTransaction()
        Try
            'SaveError()

            If m_tran IsNot Nothing Then
                m_tran.Rollback()
            End If

            'LoadError()
        Catch ex As Exception
            'HandleError("Sub RollbackTransaction", ex)
            Throw ex
        End Try
    End Sub

    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : ConnectionFails
    '   Purpose         : Check connection fail
    '   Created         : Korakot 31/01/2007
    '   Modified        :
    '--------------------------------------------------------------------------------------------------------
    Public Function ConnectionFails() As Boolean
        Dim bFail As Boolean = True

        Try
            bFail = (m_adoconn.State = ConnectionState.Broken)
        Catch ex As Exception

        Finally
            ConnectionFails = bFail
        End Try
    End Function

    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : ConnectionFails
    '   Purpose         : Check connection fail
    '   Created         : Korakot 10/01/2007
    '   Modified        :
    '
    '   Syntax          : adocnn - database connection
    '--------------------------------------------------------------------------------------------------------
    Public Function ConnectionFails(ByVal adocnn As OleDbConnection) As Boolean
        Dim bFail As Boolean = True

        Try
            bFail = (adocnn.State = ConnectionState.Broken)
        Catch ex As Exception

        Finally
            ConnectionFails = bFail
        End Try
    End Function

    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : ResumeConnection
    '   Purpose         : Resume connection
    '   Created         : Korakot 11/01/2007
    '   Modified        :
    '
    '   Syntax          : adocnn - database connection
    '                   : bQuiet - show error message
    '
    '   Linked          : clsAdoX.ResumeConnection
    '--------------------------------------------------------------------------------------------------------
    Public Function ResumeConnection(Optional ByVal bQuiet As Boolean = True _
                                ) As Boolean
        Dim blnResult As Boolean

        blnResult = False

        If TryResumeConnection(bQuiet) Then
            If TryResumeConnection(bQuiet) Then
                blnResult = True
            End If
        End If

        Return blnResult
    End Function
#End Region

    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : ExecuteStoredProc
    '   Purpose         : Get date value for sql string
    '   Created         : Korakot 11/01/2007
    '   Modified        :
    '
    '   Syntax          : strStoredProcName - Store procedure name
    '                   : arrInputParams - Parameter of store procedure
    '                   : adocmdCommand - OleDbCommand : command for returning parameter
    '                   : adocnnActiveConnection - database connection
    '
    '   Example         :   Dim adocmd As New OleDbCommand
    '                       dim adoX as new clsAdoX(ConnectionString)
    '                       Dim bDup As Boolean
    '
    '                       ExecuteStoredProc("P_GET_ITEM_ID_DUP", new string() {"A-100"}, adocmd, True, True)
    '
    '                       bDup = adocmd.Parameters(2).Value   'return value
    '
    '   Linked          : CSV_AppendValue
    '                   : clsMiscellaneous.NullValue
    '                   : HandleError
    '                   : clsAdoX.RollbackTrans
    '--------------------------------------------------------------------------------------------------------
    Public Function ExecuteStoredProc(ByVal strStoredProcName As String _
                        , Optional ByVal arrInputParams As Object = Nothing _
                        , Optional ByRef adocmd As OleDbCommand = Nothing _
                        , Optional ByVal blnEnableHandling As Boolean = False _
                        , Optional ByVal blnRollbackTranErrorOccurred As Boolean = True _
                        ) As Boolean

        Dim adocmdInUse As OleDbCommand
        Dim blnError As Boolean
        Dim intRecordsAffected As Integer

        If adocmd Is Nothing Then
            adocmd = New OleDbCommand
        End If

        adocmdInUse = adocmd

        Try
            blnError = False

            With adocmdInUse
                If m_adoconn Is Nothing Then
                    blnError = True
                    'AutoTransaction = False     'Don't care transaction
                    GoTo ExitPoint
                Else
                    .Connection = m_adoconn
                End If

                .Transaction = m_tran

                strStoredProcName = LTrim(strStoredProcName)

                .CommandType = CommandType.StoredProcedure
                .CommandText = strStoredProcName

                'Synchronize Store Procedure Parameter 
                OleDbCommandBuilder.DeriveParameters(adocmdInUse)

                'set parameter
                If .Parameters.Count > 0 Then
                    SetParameter(adocmdInUse, arrInputParams)
                End If

                intRecordsAffected = .ExecuteNonQuery()

            End With

ExitPoint:
        Catch ex As Exception
            blnError = True

            If blnEnableHandling Then
                MsgBox("Error Sub ExecuteStoredProc")
            End If

        Finally
            If blnError Then
                If blnRollbackTranErrorOccurred Then
                    RollbackTransaction()
                End If
            End If

            'Return Value
            ExecuteStoredProc = (Not blnError)
        End Try
    End Function

    Private Sub SetParameter(ByRef adocmd As OleDbCommand, ByRef arrInputParams As Object)
        Dim i As Integer
        Dim j As Integer
        Dim k As Integer

        With adocmd
            If IsNothing(arrInputParams) Then
                ' MSSQL 2000 Only
                For k = 1 To .Parameters.Count - 1
                    .Parameters(k).Direction = ParameterDirection.Output
                Next
            Else
                If (VarType(arrInputParams) And vbArray) = vbArray Then
                    j = LBound(arrInputParams)

                    For i = 1 To .Parameters.Count - 1
                        If (.Parameters(i).Direction = ParameterDirection.Input _
                          Or .Parameters(i).Direction = ParameterDirection.InputOutput) _
                            And j <= UBound(arrInputParams) Then

                            'modified by Mr.Supachawal on 2003/12/18 because True = -1
                            '                           .Parameters(i).Value = arrInputParams(j)
                            If (VarType(arrInputParams(j)) And vbBoolean) = vbBoolean Then
                                .Parameters(i).Value = IIf(arrInputParams(j), 1, 0)
                            Else
                                .Parameters(i).Value = arrInputParams(j)
                            End If

                            j = j + 1
                        Else
                            Exit For
                        End If
                    Next
                Else        'one input parameter only
                    If (VarType(arrInputParams) And vbBoolean) = vbBoolean Then
                        .Parameters(1).Value = IIf(arrInputParams, 1, 0)
                    Else
                        .Parameters(1).Value = arrInputParams
                    End If

                    i = 2
                End If

                ' Oak insert else for setting direction as ParameterDirection.Output
                ' MSSQL 2000 Only
                For k = i To .Parameters.Count - 1
                    .Parameters(k).Direction = ParameterDirection.Output
                Next
            End If
        End With
    End Sub

    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : GetDataReader
    '   Purpose         : Get data from database to oledbDataReader
    '   Created         : Korakot 11/01/2007
    '   Modified        :
    '
    '   Syntax          : strSQL - String SQL
    '   Returned        : oledbDataReader
    '
    '   Example         :   dim adoX as new clsAdoX(ConnectionString)
    '                       dim dr as oledbDataReader
    '   
    '                       dr = adoX.CreateReader(strSQL)
    '--------------------------------------------------------------------------------------------------------
    Public Function GetDataReader(ByVal strSQL As String) As OleDbDataReader
        Dim dr As OleDbDataReader = Nothing

        Try
            Dim command As OleDbCommand

            If m_tran Is Nothing Then
                command = New OleDbCommand(strSQL, m_adoconn)
            Else
                command = New OleDbCommand(strSQL, m_adoconn, m_tran)
            End If

            dr = command.ExecuteReader()
        Catch
            MsgBox("Error Function GetDataReader")

        Finally
            GetDataReader = dr
        End Try
    End Function

    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : GetDataTable
    '   Purpose         : Get data from database to DataTable
    '   Created         : Korakot 11/01/2007
    '   Modified        :
    '
    '   Syntax          : strSQL - String SQL
    '   Returned        : oledbDataReader
    '
    '   Example         :   dim adoX as new clsAdoX(ConnectionString)
    '                       dim dt as DataTable
    '   
    '                       dt = adoX.GetDataTable(strSQL)
    '--------------------------------------------------------------------------------------------------------
    Public Function GetDataTable(ByVal strSQL As String, Optional ByVal blnEnableHandling As Boolean = False) As DataTable
        Dim dt As New DataTable

        Try
            Dim command As OleDbCommand
            Dim da As OleDbDataAdapter

            If m_tran Is Nothing Then
                command = New OleDbCommand(strSQL, m_adoconn)
            Else
                command = New OleDbCommand(strSQL, m_adoconn, m_tran)
            End If

            'add by Him 2008/01/03 set timeout = 0
            command.CommandTimeout = 0

            da = New OleDbDataAdapter(command)
            da.Fill(dt)

        Catch ex As Exception

            If blnEnableHandling Then
                MsgBox("Error Function GetDataTable")
            End If

        Finally
            GetDataTable = dt
        End Try
    End Function

    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : Execute
    '   Purpose         : Execute SQL Query
    '   Created         : Korakot 11/01/2007
    '   Modified        :
    '
    '   Syntax          : strSQL - String SQL
    '   Returned        : integer (row effected)
    '
    '   Example         :   Dim AdoX As New clsAdoX(OleDbConnection1.ConnectionString)
    '
    '                       Try
    '                           Dim i As Integer
    '                           AdoX.BeginTransaction()
    '
    '                           For i = 0 To 4
    '                               If AdoX.Execute("UPDATE TABLE_NAME SET COLUMN_NAME = 'X'") < 0 Then
    '                                   HandleError("Sub Button1_Click", AdoX.LastErrorInfoCSV)
    '                                   GoTo ExitPoint
    '                               End If
    '                           Next
    '                           AdoX.CommitTransaction()
    '                   ExitPoint:
    '                       Catch ex As Exception
    '                           AdoX.RollbackTransaction()
    '                           HandleError("Sub Button1_Click", ex)
    '                       End Try
    '
    '   Linked          : clsRedoLogKeeper.ExecuteComplete
    '                   : HandleError
    '--------------------------------------------------------------------------------------------------------
    Public Function Execute(ByVal strSQL As String _
                            , Optional ByVal blnEnableHandling As Boolean = False _
                            , Optional ByVal blnRollbackTranErrorOccurred As Boolean = True) As Integer
        Dim adocmd As OleDbCommand = Nothing
        Dim intRecordsAffected As Integer = -1

        Try
            If m_tran Is Nothing Then
                adocmd = New OleDbCommand(strSQL, m_adoconn)
            Else
                adocmd = New OleDbCommand(strSQL, m_adoconn, m_tran)
            End If

            intRecordsAffected = adocmd.ExecuteNonQuery

            '2008/08/04 - add by HIM 
            'for case execute command that not return intRecordsAffected value(Ex. restore DB)
            If intRecordsAffected < 0 Then
                intRecordsAffected = 0
            End If

        Catch ex As Exception
            If blnRollbackTranErrorOccurred Then
                RollbackTransaction()
            End If

            If blnEnableHandling Then
                MsgBox("Error Function Execute")
            End If

        Finally

            Execute = intRecordsAffected
        End Try
    End Function
#End Region

#Region "PRIVATE FUNCTION"
    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : GetFileNameWithoutDirectory
    '   Purpose         : Remove Directory from FileName
    '   Created         : Pentita 14/06/2012
    '   Modified        :
    '
    '   Syntax          : strFilename - Old Filename before remove directory
    '                   : strFileNameWithoutDirectory - FileName without directory
    '
    '   Linked          : 
    '--------------------------------------------------------------------------------------------------------
    Private Function GetFileNameWithoutDirectory(ByVal strFilename)
        Dim strFileNameWithoutDirectory As String = ""
        Dim intChar As Integer
        For intChar = strFilename.ToString.Length() - 1 To 0
            If strFilename.ToString.Substring(intChar, 1) = "\" Then
                strFileNameWithoutDirectory = strFilename.ToString.Substring(intChar + 1)
                Exit For
            End If
        Next
        Return strFileNameWithoutDirectory
    End Function
    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : GetFileNameWithoutExtension
    '   Purpose         : Remove Directory from FileName
    '   Created         : Pentita 14/06/2012
    '   Modified        :
    '
    '   Syntax          : strFilename - Old Filename before remove directory
    '                   : strFileNameWithoutDirectory - FileName without directory
    '
    '   Linked          : 
    '--------------------------------------------------------------------------------------------------------
    Private Function GetFileNameWithoutExtension(ByVal strFilename)
        Dim strFileNameWithoutExtension As String = ""
        Dim intChar As Integer
        For intChar = 0 To strFilename.ToString.Length() - 1
            If strFilename.ToString.Substring(intChar, 1) = "." Then
                strFileNameWithoutExtension = strFilename.ToString.Substring(0, intChar - 1)
                Exit For
            End If
        Next
        Return strFileNameWithoutExtension
    End Function
    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : TryResumeConnection
    '   Purpose         : try to resume connection
    '   Created         : Korakot 11/01/2007
    '   Modified        :
    '
    '   Syntax          : adocnn - database connection
    '                   : bQuiet - show error message
    '
    '   Linked          : clsAdoX.UnconditionalCloseConnection
    '                   : HandleError
    '--------------------------------------------------------------------------------------------------------
    Private Function TryResumeConnection(Optional ByVal blnQuiet As Boolean = True _
                                    ) As Boolean

        Dim blnResult As Boolean

        Try
            blnResult = True
            CloseConnection()
            m_adoconn.Open()
        Catch ex As Exception

            blnResult = False

            If Not blnQuiet Then
                MsgBox("Error Function ResumeConnection")
            End If
        Finally
            If Not blnResult Then
                CloseConnection()
            End If

            'Return Value
            TryResumeConnection = blnResult
        End Try
    End Function

    '-------------------------------------------------------------
    '   Function Name   : OpenConnection
    '   Purpose         : Open connection
    '   Created         : Korakot 18/01/2007
    '   Modified        :
    '
    '   Syntax          : ConnectionString - Connection String
    '
    '   Linked          : HandleError
    '-------------------------------------------------------------
    Private Sub OpenConnection(ByVal ConnectionString As String)
        Try
            CloseConnection()
            m_adoconn = New OleDbConnection(ConnectionString)
            m_adoconn.Open()
        Catch
            m_objLogger.AppendLog("Cannot Open Connection", clsLogger.enumLogType.eError)
            'MsgBox("Error Sub OpenConnection")
        End Try
    End Sub
#End Region

End Class

