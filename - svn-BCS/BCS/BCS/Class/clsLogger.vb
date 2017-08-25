Public Class clsLogger

#Region "Constant"
	Public Const LOG_PATH As Object = ".\log"
#End Region

    Public Enum enumLogType
        eError
        eInfo
    End Enum

#Region "Attribure"
	Private m_strSubSystem As String
#End Region

#Region "Construtor"
	Sub New(Optional ByVal strSubSystem As String = "")
		If strSubSystem = String.Empty Then
			strSubSystem = My.Application.Info.ProductName
		End If

		m_strSubSystem = strSubSystem.ToLower

		reset()
	End Sub

	Public Sub reset()
	End Sub
#End Region

#Region "Method"
	'-----------------------------------------------------------------------------------------------------------------------
	'   Function Name   : AppendLog
	'   Purpose         : Append log text to log file
	'   Created         : Danzler Alan Smith 11/08/2008
	'   Modified        :
	'
	'   Syntax          : strLogText - Log text
	'
	'   Example         : objLogger.AppendLog("TSE is very best.")
	'-----------------------------------------------------------------------------------------------------------------------
    Private Sub AppendLog(ByVal strLogText As String, ByVal sLogType As String)
        Debug.Assert(sLogType.Length > 1)

        Dim strActualFileName As String
        Dim strActualLogText As String
        Dim strLogPath As String

        strActualFileName = My.Computer.FileSystem.CombinePath(My.Application.Info.DirectoryPath, LOG_PATH)
        strLogPath = strActualFileName
        If m_strSubSystem <> String.Empty Then
            strActualFileName &= "\" & m_strSubSystem
        End If

        My.Computer.FileSystem.CreateDirectory(strActualFileName)

        strActualFileName &= "\" & m_strSubSystem & Now.ToString("yyyyMMdd") & "_" & sLogType.Substring(1) & ".log"

        strActualLogText = "[" & Now.ToString("yyyy/MM/dd HH:mm:ss.ffff") & "] " & strLogText & vbCrLf
        My.Computer.FileSystem.WriteAllText(strActualFileName.ToLower, strActualLogText, True)

        Try
            For Each strFile As String In My.Computer.FileSystem.GetFiles(strLogPath, _
                                                                          FileIO.SearchOption.SearchAllSubDirectories, _
                                                                          "*.log")
                If My.Computer.FileSystem.GetFileInfo(strFile).LastWriteTime < Now.AddDays(-10) Then
                    My.Computer.FileSystem.DeleteFile(strFile)
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub

    Public Sub AppendLog(ByVal strLogText As String, ByVal nLogType As enumLogType)
        AppendLog(strLogText, nLogType.ToString)
    End Sub

    Public Sub AppendLog(ByVal objException As Exception)
        AppendLog(objException.Message, "eException_message")
        AppendLog(objException.ToString, "eException_stack")
    End Sub

#End Region

#Region "SqlCmd"
	Public Function SqlCmd_Statement( _
			ByRef objParam1 As Object, _
			ByVal vParam2 As VariantType) As String
		SqlCmd_Statement = _
				" "
	End Function
#End Region
End Class
