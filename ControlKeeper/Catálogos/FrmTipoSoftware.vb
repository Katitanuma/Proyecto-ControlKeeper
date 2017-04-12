Imports System.Data.SqlClient
Public Class FrmTipoSoftware
    Private Sub HabilitarControles(ByVal Nuevo As Boolean, ByVal Guardar As Boolean, ByVal Modificar As Boolean, ByVal Cancelar As Boolean, ByVal Panel As Boolean)
        BtnNuevo.Enabled = Nuevo
        BtnGuardar.Enabled = Guardar
        BtnModificar.Enabled = Modificar
        BtnCancelar.Enabled = Cancelar
        PnlTipoSoftware.Enabled = Panel
    End Sub

    Private Sub Limpiar()
        TxtCodigoTipoSoftware.Text = ""
        TxtTipoSoftware.Text = ""
    End Sub

    Private Sub MostrarTodoTipoSoftware()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If
        Using cmd As New SqlCommand
            Try
                Con.Open()

                With cmd
                    .CommandText = "Sp_MostrarTodoTipoSoftware"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                End With

                Dim AdaptadorTipoSoftware As New SqlDataAdapter(cmd)
                Dim Dt As New DataTable
                AdaptadorTipoSoftware.Fill(Dt)
                DgvTipoSoftware.DataSource = Dt

            Catch ex As Exception
                MessageBox.Show("Error al mostrar los datos de los tipos de softwares " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using
    End Sub

    Private Sub FrmTipoSoftware_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call HabilitarControles(True, False, False, False, False)
        Call Limpiar()
        Call MostrarTodoTipoSoftware()
    End Sub

    Private Sub GuardarTipoSoftware()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_InsertarTipoSoftware"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@TipoSoftware", SqlDbType.NVarChar, 50).Value = TxtTipoSoftware.Text.Trim
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Tipo de software almacenado con éxito", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error al mostrar los datos de los tipos de softwares " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using
    End Sub

    Private Function ValidarTipoSoftware()
        Dim Estado As Boolean
        If TxtTipoSoftware.Text = "" Then
            MessageBox.Show("Ingrese el nombre del tipo de software", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtTipoSoftware.Focus()
            Estado = False
        Else
            Estado = True
        End If
        Return Estado
    End Function

    Private Function ExisteNombreTipoSoftware()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If
        Dim Valor As Boolean
        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_ExisteTipoSoftware"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@TipoSoftware", SqlDbType.NVarChar, 50).Value = TxtTipoSoftware.Text.Trim
                End With
                Dim existe As Integer = cmd.ExecuteScalar
                If existe = 0 Then
                    Valor = False
                Else
                    Valor = True
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                Con.Close()
            End Try
        End Using
        Return Valor
    End Function

    Private Sub InvestigarCorrelativoTipoSoftware()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_CorrelativoTipoSoftware"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                End With

                Dim LectorCorrelativo As SqlDataReader
                LectorCorrelativo = cmd.ExecuteReader

                If LectorCorrelativo.Read Then
                    If LectorCorrelativo("Id") Is DBNull.Value Then
                        TxtCodigoTipoSoftware.Text = 1
                    Else
                        TxtCodigoTipoSoftware.Text = LectorCorrelativo("Id").ToString
                    End If
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                Con.Close()
            End Try
        End Using
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If ValidarTipoSoftware() = True Then
            If ExisteNombreTipoSoftware() = False Then
                Call GuardarTipoSoftware()
                Call MostrarTodoTipoSoftware()
                Call HabilitarControles(True, False, False, False, False)
                Call Limpiar()
            Else
                MessageBox.Show("Ya se encuentra registrado este tipo de software", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub EditarTipoSoftware()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()

                With cmd
                    .CommandText = "Sp_ActualizarTipoSoftware"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@IdTipoSoftware", SqlDbType.Int).Value = CInt(TxtCodigoTipoSoftware.Text)
                    .Parameters.Add("@TipoSoftware", SqlDbType.NVarChar, 50).Value = TxtTipoSoftware.Text.Trim
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Tipo de Software modificado con éxito", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call MostrarTodoTipoSoftware()

            Catch ex As Exception
                MessageBox.Show("Error al modificar el tipo de software " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If ValidarTipoSoftware() = True Then
            Call EditarTipoSoftware()
            Call HabilitarControles(True, False, False, False, False)
            Call Limpiar()
            Call MostrarTodoTipoSoftware()
        End If
    End Sub

    Private Sub EliminarTipoSoftware()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_EliminarTipoSoftware"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@IdTipoSoftware", SqlDbType.Int).Value = CInt(DgvTipoSoftware.CurrentRow.Cells(0).Value)
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Tipo de software eliminado con éxito", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error al eliminar el tipo de software " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        If MessageBox.Show("¿Está seguro de eliminar el registro?", "Control Keeper",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            Call EliminarTipoSoftware()
            Call MostrarTodoTipoSoftware()
        End If
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        Call HabilitarControles(False, False, True, True, True)
        TxtCodigoTipoSoftware.Text = DgvTipoSoftware.CurrentRow.Cells(0).Value
        TxtTipoSoftware.Text = DgvTipoSoftware.CurrentRow.Cells(1).Value.ToString
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Call HabilitarControles(False, True, False, True, True)
        Call Limpiar()
        Call InvestigarCorrelativoTipoSoftware()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Call HabilitarControles(True, False, False, False, False)
        Call Limpiar()
    End Sub

    Private Sub BusquedaInteligenteTipoSoftware()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_BusquedaTipoSoftware"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@Parametro", SqlDbType.NVarChar, 50).Value = TxtBusqueda.Text.Trim
                    .Connection = Con
                End With

                Dim AdaptadorBusqueda As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                AdaptadorBusqueda.Fill(dt)
                DgvTipoSoftware.DataSource = dt


            Catch ex As Exception
                MessageBox.Show("Error al mostrar los datos " + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub

    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        If TxtBusqueda.Text = Nothing Then
            MostrarTodoTipoSoftware()
        Else
            BusquedaInteligenteTipoSoftware()
        End If
    End Sub
End Class