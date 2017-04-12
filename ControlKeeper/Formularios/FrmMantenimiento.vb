Imports System.Data.SqlClient
Public Class FrmMantenimiento
    Private Sub FrmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HabilitarControles(True, False, False, False, False)
        Call MostrarTodosMantenimiento()
        Call LlenarComboBoxUsuario()
        Call Limpiar()
    End Sub
    Private Sub HabilitarControles(ByVal Nuevo As Boolean, ByVal Guardar As Boolean, ByVal Modificar As Boolean, ByVal Cancelar As Boolean, ByVal Panel As Boolean)
        BtnNuevo.Enabled = Nuevo
        BtnGuardar.Enabled = Guardar
        BtnModificar.Enabled = Modificar
        BtnCancelar.Enabled = Cancelar
        PlMantemiento.Enabled = Panel
    End Sub
    Private Sub MostrarTodosMantenimiento()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_MostrarTodoMantenimiento"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                End With

                Dim AdaptadorMantenimiento As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                AdaptadorMantenimiento.Fill(dt)
                DgvMantenimiento.DataSource = dt

            Catch ex As Exception
                MessageBox.Show("Error al mostrar los datos de los mantenimientos" + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Call HabilitarControles(False, True, False, True, True)
        Call Limpiar()
        Call InvestigarCorrelativoMantenimiento()
    End Sub
    Private Sub LlenarComboBoxUsuario()
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
                    .ExecuteNonQuery()
                End With
                Dim AdaptadorUsuario As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                AdaptadorUsuario.Fill(ds, "Usuario")
                CboUsuario.DataSource = ds.Tables(0)
                CboUsuario.DisplayMember = ds.Tables(0).Columns("Usuario").ToString
                CboUsuario.ValueMember = ds.Tables(0).Columns("IdUsuario").ToString

            Catch ex As Exception
                MessageBox.Show("Error al mostrar los Usuario " + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub
    Private Sub GuardarMantenimiento()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_InsertarMantenimiento"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@Descripcion", SqlDbType.NVarChar, 200).Value = TxtDescripcion.Text.Trim
                    .Parameters.Add("@HoraInicio", SqlDbType.Time, 7).Value = DtpHoraInicio.Text
                    .Parameters.Add("@HoraFinalizar", SqlDbType.Time, 7).Value = DtpHoraFinalizacion.Text
                    .Parameters.Add("@FechaMantenimiento", SqlDbType.Date).Value = DtpFechaMantenimiento.Text
                    .Parameters.Add("@IdUsuario", SqlDbType.Int).Value = CInt(CboUsuario.SelectedValue)
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Mantenimiento registrado con exito", "Control Keeper")
            Catch ex As Exception
                MessageBox.Show("Error al registrar el mantenimiento " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using

    End Sub
    Private Sub InvestigarCorrelativoMantenimiento()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If
        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_CorrelativoMantenimiento"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                End With
                Dim LectorCorrelativo As SqlDataReader
                LectorCorrelativo = cmd.ExecuteReader

                If LectorCorrelativo.Read Then
                    If LectorCorrelativo("Id") Is DBNull.Value Then
                        TxtIdMantenimiento.Text = 1
                    Else
                        TxtIdMantenimiento.Text = LectorCorrelativo("Id").ToString
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Con.Close()
            End Try
        End Using
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Call GuardarMantenimiento()
        Call MostrarTodosMantenimiento()
        Call HabilitarControles(True, False, False, False, False)
        Call Limpiar()
    End Sub
    Private Sub Limpiar()
        TxtIdMantenimiento.Text = Nothing
        CboUsuario.Text = Nothing
        TxtDescripcion.Text = Nothing
        DtpHoraFinalizacion.ResetText()
        DtpHoraInicio.ResetText()
        DtpFechaMantenimiento.ResetText()
    End Sub
    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        Call HabilitarControles(False, False, True, True, True)

        TxtIdMantenimiento.Text = DgvMantenimiento.CurrentRow.Cells(0).Value.ToString
        TxtDescripcion.Text = DgvMantenimiento.CurrentRow.Cells(1).Value.ToString
        DtpHoraInicio.Text = DgvMantenimiento.CurrentRow.Cells(2).Value.ToString
        DtpHoraFinalizacion.Text = DgvMantenimiento.CurrentRow.Cells(3).Value.ToString
        DtpFechaMantenimiento.Text = DgvMantenimiento.CurrentRow.Cells(4).Value.ToString
        CboUsuario.Text = DgvMantenimiento.CurrentRow.Cells(5).Value.ToString
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Call HabilitarControles(True, False, False, False, False)
        Call Limpiar()
    End Sub
    Private Sub EditarMantenimiento()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_ActualizarMantenimiento"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .Parameters.Add("@IdMantenimiento", SqlDbType.Int).Value = CInt(TxtIdMantenimiento.Text)
                    .Parameters.Add("@Descripcion", SqlDbType.NVarChar, 200).Value = TxtDescripcion.Text.Trim
                    .Parameters.Add("@HoraInicio", SqlDbType.Time, 7).Value = DtpHoraInicio.Text
                    .Parameters.Add("@HoraFinalizar", SqlDbType.Time, 7).Value = DtpHoraFinalizacion.Text
                    .Parameters.Add("@FechaMantenimiento", SqlDbType.Date).Value = DtpFechaMantenimiento.Text
                    .Parameters.Add("@IdUsario", SqlDbType.Int).Value = CInt(CboUsuario.SelectedValue)
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Registro editado con exito", "Control Keeper")
            Catch ex As Exception
                MessageBox.Show("Error al editar el mantenimiento " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using
    End Sub
    Private Sub EliminarMantenimiento()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_EliminarMantenimiento"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .Parameters.Add("@IdMantenimiento", SqlDbType.Int).Value = CInt(DgvMantenimiento.CurrentRow.Cells(0).Value)
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Mantenimiento eliminado con exito", "Control Keeper")
            Catch ex As Exception
                MessageBox.Show("Error al eliminar el mantenimiento " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using

    End Sub
    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Call EditarMantenimiento()
        Call HabilitarControles(True, False, False, False, False)
        Call Limpiar()
        Call MostrarTodosMantenimiento()
    End Sub
    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        If MessageBox.Show("¿Está seguro de eliminar el registro?", "Control Keeper",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            Call EliminarMantenimiento()
            Call MostrarTodosMantenimiento()
        End If
    End Sub
End Class