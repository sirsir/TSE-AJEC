Public Class frmLogin

#Region "Public Variables"
    Public m_bLoginPass As Boolean = False
    Public m_strRoleId As String = "USR"
#End Region

#Region "Private Variables"
#End Region

#Region "Constructor AND Destructor"
    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub
#End Region

#Region "Events"
    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Add all user to ComboBox
        clsUsersInfo.AddUserToCombo(cmbUser)
    End Sub

    Private Sub txtPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress

        'Check "Enter" Key
        If e.KeyChar = Chr(13) Then
            m_bLoginPass = Login()

            'if password is correct then close the login form
            If m_bLoginPass Then
                Me.Close()
            End If

        End If

    End Sub
    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        m_bLoginPass = Login()

        'if password is correct then close the login form
        If m_bLoginPass Then
            Me.Close()
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
#End Region

#Region "Private Function"
    Private Function Login() As Boolean
        Try
            Login = False
            If Trim(cmbUser.Text) = String.Empty Or Trim(cmbUser.Text) = Nothing Then
                'username textbox is empty
                MsgBox("Please Select Username")
            Else
                If CheckAvailableUserId(Trim(cmbUser.Text)) Then
                    'username is found in database
                    If txtPassword.Text = String.Empty Or Nothing Then
                        'password textbox is empty
                        MsgBox("Please Enter Password")
                    Else
                        If clsUsersInfo.CheckPassword(Trim(cmbUser.Text), txtPassword.Text) Then
                            'password enter is match with username
                            m_strRoleId = clsUserRolesInfo.FindRoleId(Trim(cmbUser.Text))
                            Login = True
                        Else
                            'password enter is not match with username
                            MsgBox("Wrong Password")
                            txtPassword.Text = String.Empty
                        End If
                    End If
                Else
                    'ERROR:username is not found in database
                    MsgBox("Username '" & Trim(cmbUser.Text) & "' is not found.")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Login :" & ex.ToString)
            Login = False
        End Try
    End Function
    Private Function CheckAvailableUserId(ByVal strUser As String) As Boolean
        Try
            'check if the username selected is available
            CheckAvailableUserId = clsUsersInfo.CheckAvailableUser(strUser)
        Catch ex As Exception
            MessageBox.Show("CheckAvailableUserId :" & ex.ToString)
            CheckAvailableUserId = False
        End Try
    End Function
#End Region

#Region "Public Function"
#End Region
End Class
