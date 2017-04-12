Imports System.Data.SqlClient
Public Class FrmUsuario
    Public Var As Integer = 0

    Private Function ValidarUsuario() As Boolean
        Dim Estado As Boolean
        If TxtUsuario.Text = Nothing Then
            MsgBox("Ingrese el nombre de usuario", MsgBoxStyle.Critical, "Control Keeper")
            TxtUsuario.Focus()
            Estado = False
        ElseIf TxtContrasena.Text = Nothing Then
            MsgBox("Seleccione el contraseña", MsgBoxStyle.Critical, "Control Keeper")
            TxtContrasena.Focus()
            Estado = False
        ElseIf CboTipoUsuario.Text = Nothing Then
            MsgBox("Seleccione el tipo de usuario", MsgBoxStyle.Critical, "Control Keeper")
            Estado = False
        ElseIf CboNombreEmpleado.Text = Nothing Then
            MsgBox("Seleccione el empleado", MsgBoxStyle.Critical, "Control Keeper")
            Estado = False
        Else
            Estado = True
        End If
        Return Estado
    End Function
    Private Sub FrmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HabilitarControles(True, False, False, False, False)
        Call MostrarTodosUsuarios()
        Call LlenarComboBoxTipoUsuario()
        Call LlenarComboBoxNombreEmpleado()
        Call Limpiar()
    End Sub
    Private Sub HabilitarControles(ByVal Nuevo As Boolean, ByVal Guardar As Boolean, ByVal Modificar As Boolean, ByVal Cancelar As Boolean, ByVal Panel As Boolean)
        BtnNuevo.Enabled = Nuevo
        BtnGuardar.Enabled = Guardar
        BtnModificar.Enabled = Modificar
        BtnCancelar.Enabled = Cancelar
        PlUsuario.Enabled = Panel
    End Sub
    Private Sub MostrarTodosUsuarios()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_MostrarTodoUsuario"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                End With

                Dim AdaptadorUsuario As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                AdaptadorUsuario.Fill(dt)
                DgvUsuario.DataSource = dt
                DgvUsuario.Columns(4).Visible = False

            Catch ex As Exception
                MessageBox.Show("Error al mostrar los datos de los usuarios " + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Call HabilitarControles(False, True, False, True, True)
        Call Limpiar()
        Call InvestigarCorrelativoUsuario()
    End Sub
    Private Sub LlenarComboBoxTipoUsuario()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_MostrarTodoTipoUsuario"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .ExecuteNonQuery()
                End With
                Dim AdaptadorTipoUsuario As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                AdaptadorTipoUsuario.Fill(ds, "TipoUsuario")
                CboTipoUsuario.DataSource = ds.Tables(0)
                CboTipoUsuario.DisplayMember = ds.Tables(0).Columns("TipoUsuario").ToString
                CboTipoUsuario.ValueMember = ds.Tables(0).Columns("IdTipoUsuario").ToString

            Catch ex As Exception
                MessageBox.Show("Error al mostrar tipo usuario " + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub
    Public Sub LlenarComboBoxNombreEmpleado()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_MostrarIdentificacionEmpleado"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .ExecuteNonQuery()
                End With
                Dim AdaptadorTipoUsuario As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                AdaptadorTipoUsuario.Fill(ds, "Empleado")
                CboNombreEmpleado.DataSource = ds.Tables(0)
                CboNombreEmpleado.DisplayMember = ds.Tables(0).Columns("NombreCompletoEmpleado").ToString
                CboNombreEmpleado.ValueMember = ds.Tables(0).Columns("IdEmpleado").ToString

            Catch ex As Exception
                MessageBox.Show("Error al mostrar el nombre completo de los empleados " + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub
    Private Sub GuardarUsuario()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_InsertarUsuario"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@Usuario", SqlDbType.NVarChar, 50).Value = TxtUsuario.Text.Trim
                    .Parameters.Add("@Constrasena", SqlDbType.NVarChar, 100).Value = TxtContrasena.Text.Trim
                    .Parameters.Add("@IdTipoUsuario", SqlDbType.Int).Value = CInt(CboTipoUsuario.SelectedValue)
                    .Parameters.Add("@IdEmpleado", SqlDbType.VarChar, 15).Value = CboNombreEmpleado.SelectedValue
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Usuario Registrado con éxito", "Control Keeper")
            Catch ex As Exception
                MessageBox.Show("Error al guardar el usuario " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If ValidarUsuario() = True Then
            If ExisteNombreUsuario() = False Then
                Call GuardarUsuario()
                Call MostrarTodosUsuarios()
                Call HabilitarControles(True, False, False, False, False)
                Call Limpiar()
            Else
                MessageBox.Show("Ya se encuentra registrado ese usuario", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            End If
        End If


    End Sub
    Private Sub Limpiar()
        TxtIdUsuario.Clear()
        TxtUsuario.Clear()
        TxtContrasena.Clear()
        CboNombreEmpleado.Text = Nothing
        CboTipoUsuario.Text = Nothing
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        Call HabilitarControles(False, False, True, True, True)
        TxtIdUsuario.Text = DgvUsuario.CurrentRow.Cells(0).Value
        TxtUsuario.Text = DgvUsuario.CurrentRow.Cells(1).Value.ToString
        CboTipoUsuario.Text = DgvUsuario.CurrentRow.Cells(2).Value.ToString
        CboNombreEmpleado.Text = DgvUsuario.CurrentRow.Cells(3).Value.ToString
        TxtContrasena.Text = DgvUsuario.CurrentRow.Cells(4).Value.ToString
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Call HabilitarControles(True, False, False, False, False)
        Call Limpiar()
    End Sub
    Private Sub EditarUsuario()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_ActualizarUsuario"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@IdUsuario", SqlDbType.Int).Value = CInt(TxtIdUsuario.Text)
                    .Parameters.Add("@Usuario", SqlDbType.NVarChar, 50).Value = TxtUsuario.Text.Trim
                    .Parameters.Add("@Constrasena", SqlDbType.NVarChar, 100).Value = TxtContrasena.Text.Trim
                    .Parameters.Add("@IdTipoUsuario", SqlDbType.Int).Value = CInt(CboTipoUsuario.SelectedValue)
                    .Parameters.Add("@IdEmpleado", SqlDbType.VarChar, 15).Value = CboNombreEmpleado.SelectedValue
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Usuario editado con éxito", "Control Keeper")
            Catch ex As Exception
                MessageBox.Show("Error al editar el usuario " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using

    End Sub
    Private Sub EliminarUsuario()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_EliminarUsuario"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@IdUsuario", SqlDbType.Int).Value = CInt(DgvUsuario.CurrentRow.Cells(0).Value)
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Usuario eliminado con éxito", "Control Keeper")
            Catch ex As Exception
                MessageBox.Show("Error al eliminar el usuario " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If ValidarUsuario() = True Then
            Call EditarUsuario()
            Call HabilitarControles(True, False, False, False, False)
            Call Limpiar()
            Call MostrarTodosUsuarios()
        End If
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        If MessageBox.Show("¿Está seguro de eliminar el registro?", "Control Keeper",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            Call EliminarUsuario()
            Call MostrarTodosUsuarios()
        End If
    End Sub

    Private Sub InvestigarCorrelativoUsuario()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If
        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_CorrelativoUsuario"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                End With
                Dim LectorCorrelativo As SqlDataReader
                LectorCorrelativo = cmd.ExecuteReader

                If LectorCorrelativo.Read Then
                    If LectorCorrelativo("Id") Is DBNull.Value Then
                        TxtIdUsuario.Text = 1
                    Else
                        TxtIdUsuario.Text = LectorCorrelativo("Id").ToString
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Con.Close()
            End Try
        End Using
    End Sub
    Private Function ExisteNombreUsuario() As Boolean
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Dim Valor As Boolean
        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_ExisteUsuario"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .Parameters.Add("@Usuario", SqlDbType.NVarChar, 50).Value = TxtUsuario.Text.Trim
                End With
                Dim Existe As Integer = cmd.ExecuteScalar
                If Existe = 0 Then
                    Valor = False
                Else
                    Valor = True
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Con.Close()
            End Try
        End Using
        Return Valor
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnAbrirFrmEmpleado.Click
        FrmEmpleado.MdiParent = MDIControlKeeper
        FrmEmpleado.Var = 1
        FrmEmpleado.Location = New Point(120, 110)
        FrmEmpleado.Show()

    End Sub


    Private Sub DgvUsuario_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvUsuario.CellDoubleClick
        If Var = 1 Then
            FrmComputadoraUsuario.LlenarComboBoxUsuario()
            FrmComputadoraUsuario.CboUsuario.Text = DgvUsuario.CurrentRow.Cells(1).Value.ToString
            Me.Close()
        ElseIf Var = 2 Then
            FrmSoftwareComputadora.LlenarComboBoxUsuario()
            FrmSoftwareComputadora.CboUsuario.Text = DgvUsuario.CurrentRow.Cells(1).Value.ToString
            Me.Close()
        End If
    End Sub
    Private Sub BusquedaInteligenteUsuario()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_BusquedaUsuario"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@Parametro", SqlDbType.NVarChar, 50).Value = TxtBusqueda.Text.Trim
                    .Connection = Con
                End With

                Dim AdaptadorBusqueda As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                AdaptadorBusqueda.Fill(dt)
                DgvUsuario.DataSource = dt
                DgvUsuario.Columns(4).Visible = False

            Catch ex As Exception
                MessageBox.Show("Error al mostrar los datos " + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub

    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        If TxtBusqueda.Text = Nothing Then
            MostrarTodosUsuarios()
        Else
            BusquedaInteligenteUsuario()
        End If
    End Sub
End Class