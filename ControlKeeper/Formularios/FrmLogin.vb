Imports System.Data.SqlClient
Public Class FrmLogin

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Function Validar() As Boolean
        Dim Estado As Boolean
        If UsernameTextBox.Text = Nothing And PasswordTextBox.Text = Nothing Then
            MsgBox("Ingrese el nombre de usuario y contraseña", MsgBoxStyle.Critical, "Control Keeper")
            Estado = False
            UsernameTextBox.Focus()
        ElseIf UsernameTextBox.Text = Nothing Then
            MsgBox("Ingrese el nombre de usuario", MsgBoxStyle.Critical, "Control Keeper")
            Estado = False
            UsernameTextBox.Focus()
        ElseIf PasswordTextBox.Text = Nothing Then
            MsgBox("Ingrese la contraseña del usuario", MsgBoxStyle.Critical, "Control Keeper")
            Estado = False
            PasswordTextBox.Focus()
        Else
            Estado = True
        End If
        Return Estado
    End Function

    Private Sub BtnIniciar_Click(sender As Object, e As EventArgs) Handles BtnIniciar.Click
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_Login"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .Parameters.Add("@Usuario", SqlDbType.NVarChar, 50).Value = UsernameTextBox.Text.Trim
                    .Parameters.Add("@Contrasena", SqlDbType.NVarChar, 100).Value = PasswordTextBox.Text.Trim
                End With
                Dim LectorUsuario As SqlDataReader = cmd.ExecuteReader
                If LectorUsuario.Read Then
                    If LectorUsuario("TipoUsuario").ToString = "Administrador" Then
                        If LectorUsuario("Estado").ToString = "Activo" Then
                            PasswordTextBox.Clear()
                            UsernameTextBox.Clear()
                            Me.Hide()
                            MDIControlKeeper.LblUsuario.Text = UsernameTextBox.Text.Trim
                            MDIControlKeeper.Show()
                        Else
                            MsgBox("Empleado Inactivo", MsgBoxStyle.Critical, "Control Keeper")
                        End If
                    Else
                        MsgBox("Este usuario no tiene acceso al sistema", MsgBoxStyle.Critical, "Control Keeper")
                    End If
                Else
                    MsgBox("Nombre de usuario o contraseña incorrecta", MsgBoxStyle.Critical, "Control Keeper")
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Using
    End Sub


    Private Sub PasswordTextBox_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles PasswordTextBox.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            BtnIniciar.PerformClick()
        End If
    End Sub


End Class
