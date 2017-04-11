Imports System.Data.SqlClient
Public Class FrmEmpleado
    Private Sub FrmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HabilitarControles(True, False, False, False, False)
        Call MostrarTodosEmpleado()
        Call LlenarComboBoxCiudad()
        Call LlenarComboBoxEstadoCivil()
        Call LlenarComboBoxProfesion()
        Call LlenarComboBoxSexo()
        Call Limpiar()
    End Sub
    Private Sub HabilitarControles(ByVal Nuevo As Boolean, ByVal Guardar As Boolean, ByVal Modificar As Boolean, ByVal Cancelar As Boolean, ByVal Panel As Boolean)
        BtnNuevo.Enabled = Nuevo
        BtnGuardar.Enabled = Guardar
        BtnModificar.Enabled = Modificar
        BtnCancelar.Enabled = Cancelar
        PlEmpleado.Enabled = Panel
    End Sub
    Private Sub MostrarTodosEmpleado()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_MostraTodoEmpleado"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                End With

                Dim AdaptadorEmpleado As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                AdaptadorEmpleado.Fill(dt)
                DgvEmpleado.DataSource = dt

            Catch ex As Exception
                MessageBox.Show("Error al mostrar los datos de los empleados " + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Call HabilitarControles(False, True, False, True, True)
        Call Limpiar()
    End Sub
    Private Sub LlenarComboBoxEstadoCivil()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_MostrarTodoEstadoCivil"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .ExecuteNonQuery()
                End With
                Dim AdaptadorEstadoCilvil As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                AdaptadorEstadoCilvil.Fill(ds, "EstadoCivil")
                CboEstadoCivil.DataSource = ds.Tables(0)
                CboEstadoCivil.DisplayMember = ds.Tables(0).Columns("EstadoCivil").ToString
                CboEstadoCivil.ValueMember = ds.Tables(0).Columns("IdEstadoCivil").ToString

            Catch ex As Exception
                MessageBox.Show("Error al mostrar estado civil " + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub
    Private Sub LlenarComboBoxCiudad()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_MostrarTodoCiudad"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .ExecuteNonQuery()
                End With
                Dim AdaptadorCiudad As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                AdaptadorCiudad.Fill(ds, "Ciudad")
                CboCiudad.DataSource = ds.Tables(0)
                CboCiudad.DisplayMember = ds.Tables(0).Columns("Ciudad").ToString
                CboCiudad.ValueMember = ds.Tables(0).Columns("IdCiudad").ToString

            Catch ex As Exception
                MessageBox.Show("Error al mostrar los datos de la ciudad " + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub
    Private Sub LlenarComboBoxProfesion()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_MostrarTodoProfesion"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .ExecuteNonQuery()
                End With
                Dim AdaptadorProfesion As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                AdaptadorProfesion.Fill(ds, "Profesion")
                CboProfesion.DataSource = ds.Tables(0)
                CboProfesion.DisplayMember = ds.Tables(0).Columns("Profesion").ToString
                CboProfesion.ValueMember = ds.Tables(0).Columns("IdProfesion").ToString

            Catch ex As Exception
                MessageBox.Show("Error al mostrar los datos de profesión " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using
    End Sub
    Private Sub LlenarComboBoxSexo()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_MostrarTodoSexo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .ExecuteNonQuery()
                End With
                Dim AdaptadorSexo As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                AdaptadorSexo.Fill(ds, "Sexo")
                CboSexo.DataSource = ds.Tables(0)
                CboSexo.DisplayMember = ds.Tables(0).Columns("Sexo").ToString
                CboSexo.ValueMember = ds.Tables(0).Columns("IdSexo").ToString
            Catch ex As Exception
                MessageBox.Show("Error al mostrar los datos de sexo " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using
    End Sub
    Private Sub GuardarEmpleado()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_InsertarEmpleado"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@IdEmpleado", SqlDbType.VarChar, 15).Value = MtbCodigo.Text.Trim
                    .Parameters.Add("@Nombres", SqlDbType.NVarChar, 50).Value = TxtNombre.Text.Trim
                    .Parameters.Add("@Apellidos", SqlDbType.NVarChar, 50).Value = TxtApellido.Text.Trim
                    .Parameters.Add("@Telefono", SqlDbType.VarChar, 9).Value = MtbTelefono.Text
                    .Parameters.Add("@Correo", SqlDbType.NVarChar, 100).Value = TxtCorreo.Text.Trim
                    .Parameters.Add("@Direccion", SqlDbType.NVarChar, 200).Value = TxtDireccion.Text.Trim
                    .Parameters.Add("@IdSexo", SqlDbType.Int).Value = CboSexo.SelectedValue
                    .Parameters.Add("@IdEstadoCivil", SqlDbType.Int).Value = CboEstadoCivil.SelectedValue
                    .Parameters.Add("@IdProfesion", SqlDbType.Int).Value = CboProfesion.SelectedValue
                    .Parameters.Add("@IdCiudad", SqlDbType.Int).Value = CboCiudad.SelectedValue
                    .Parameters.Add("@Estado", SqlDbType.NVarChar, 20).Value = IdentificarEstado()
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Empleado Registrado con éxito", "Control Keeper")
            Catch ex As Exception
                MessageBox.Show("Error al guardar el empleado " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        Call GuardarEmpleado()
        Call MostrarTodosEmpleado()
        Call HabilitarControles(True, False, False, False, False)
        Call Limpiar()


    End Sub
    Private Sub Limpiar()
        MtbCodigo.Clear()
        TxtNombre.Clear()
        TxtApellido.Clear()
        MtbTelefono.Clear()
        TxtCorreo.Clear()
        TxtDireccion.Clear()
        CboCiudad.Text = Nothing
        CboProfesion.Text = Nothing
        CboEstadoCivil.Text = Nothing
        CboSexo.Text = Nothing
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        Call HabilitarControles(False, False, True, True, True)
        MtbCodigo.Enabled = False
        MtbCodigo.Text = DgvEmpleado.CurrentRow.Cells(0).Value
        TxtNombre.Text = DgvEmpleado.CurrentRow.Cells(1).Value.ToString
        TxtApellido.Text = DgvEmpleado.CurrentRow.Cells(2).Value.ToString
        MtbTelefono.Text = DgvEmpleado.CurrentRow.Cells(3).Value.ToString
        TxtCorreo.Text = DgvEmpleado.CurrentRow.Cells(4).Value.ToString
        TxtDireccion.Text = DgvEmpleado.CurrentRow.Cells(5).Value.ToString
        CboSexo.Text = DgvEmpleado.CurrentRow.Cells(6).Value.ToString
        CboEstadoCivil.Text = DgvEmpleado.CurrentRow.Cells(7).Value.ToString
        CboProfesion.Text = DgvEmpleado.CurrentRow.Cells(8).Value.ToString
        CboCiudad.Text = DgvEmpleado.CurrentRow.Cells(9).Value.ToString

        If DgvEmpleado.CurrentRow.Cells(10).Value.ToString = "Activo" Then
            ChkEstado.Checked = True
        Else
            ChkEstado.Checked = False
        End If

    End Sub
    Private Sub ChkEstado_CheckedChanged(sender As Object, e As EventArgs) Handles ChkEstado.CheckedChanged
        If ChkEstado.CheckState = CheckState.Checked Then
            ChkEstado.Text = "Activo"
        Else
            ChkEstado.Text = "No activo"
        End If
    End Sub
    Private Function IdentificarEstado() As String
        Dim var As String
        If ChkEstado.CheckState = CheckState.Checked Then
            var = "Activo"
        Else
            var = "No activo"
        End If
        Return var
    End Function
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Call HabilitarControles(True, False, False, False, False)
        Call Limpiar()
        MtbCodigo.Enabled = True
    End Sub
    Private Sub EditarEmpleado()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_ActualizarEmpleado"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@IdEmpleado", SqlDbType.VarChar, 15).Value = MtbCodigo.Text.Trim
                    .Parameters.Add("@Nombres", SqlDbType.NVarChar, 50).Value = TxtNombre.Text.Trim
                    .Parameters.Add("@Apellidos", SqlDbType.NVarChar, 50).Value = TxtApellido.Text.Trim
                    .Parameters.Add("@Telefono", SqlDbType.VarChar, 9).Value = MtbTelefono.Text
                    .Parameters.Add("@Correo", SqlDbType.NVarChar, 100).Value = TxtCorreo.Text.Trim
                    .Parameters.Add("@Direccion", SqlDbType.NVarChar, 200).Value = TxtDireccion.Text.Trim
                    .Parameters.Add("@IdSexo", SqlDbType.Int).Value = CboSexo.SelectedValue
                    .Parameters.Add("@IdEstadoCivil", SqlDbType.Int).Value = CboEstadoCivil.SelectedValue
                    .Parameters.Add("@IdProfesion", SqlDbType.Int).Value = CboProfesion.SelectedValue
                    .Parameters.Add("@IdCiudad", SqlDbType.Int).Value = CboCiudad.SelectedValue
                    .Parameters.Add("@Estado", SqlDbType.NVarChar, 20).Value = IdentificarEstado()
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Empleado editado con éxito", "Control Keeper")
            Catch ex As Exception
                MessageBox.Show("Error al editar el empleado " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using
    End Sub
    Private Sub EliminarEmpleado()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_EliminarEmpleado"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@IdEmpleado", SqlDbType.VarChar, 15).Value = DgvEmpleado.CurrentRow.Cells(0).Value.ToString
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Empleado eliminado con éxito", "Control Keeper")
            Catch ex As Exception
                MessageBox.Show("Error al eliminar el Empleado " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Call EditarEmpleado()
        Call HabilitarControles(True, False, False, False, False)
        Call Limpiar()
        Call MostrarTodosEmpleado()
        MtbCodigo.Enabled = True
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Call EliminarEmpleado()
        Call MostrarTodosEmpleado()
    End Sub
End Class