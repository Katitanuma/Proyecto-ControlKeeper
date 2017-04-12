Imports System.Data.SqlClient
Public Class FrmComputadoraUsuario
    Private Function ValidarComputadoraUsuario() As Boolean
        Dim Estado As Boolean
        If CboSerie.Text = Nothing Then
            MsgBox("Seleccione la serie de la computadora", MsgBoxStyle.Critical, "Control Keeper")
            Estado = False
        ElseIf CboUsuario.Text = Nothing Then
            MsgBox("Seleccione el usuario a asignar computadora", MsgBoxStyle.Critical, "Control Keeper")
            Estado = False
        Else
            Estado = True
        End If
        Return Estado
    End Function
    Private Sub FrmComputadoraUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HabilitarControles(True, False, False, False, False)
        Call MostrarTodasComputadorasUsuario()
        Call LlenarComboBoxSerie()
        Call LlenarComboBoxUsuario()
        Call Limpiar()
    End Sub
    Private Sub HabilitarControles(ByVal Nuevo As Boolean, ByVal Guardar As Boolean, ByVal Modificar As Boolean, ByVal Cancelar As Boolean, ByVal Panel As Boolean)
        BtnNuevo.Enabled = Nuevo
        BtnGuardar.Enabled = Guardar
        BtnModificar.Enabled = Modificar
        BtnCancelar.Enabled = Cancelar
        PlComputadoraUsuario.Enabled = Panel
    End Sub
    Private Sub MostrarTodasComputadorasUsuario()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_MostrarTodoComputadoraUsuario"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                End With

                Dim AdaptadorComputadoraUsuario As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                AdaptadorComputadoraUsuario.Fill(dt)
                DgvComputadoraUsuario.DataSource = dt

            Catch ex As Exception
                MessageBox.Show("Error al mostrar los datos de las Computadoras de la asignacion de usuario" + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Call HabilitarControles(False, True, False, True, True)
        Call Limpiar()
    End Sub


    Public Sub LlenarComboBoxSerie()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_MostrarSerieComputadora"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .ExecuteNonQuery()
                End With
                Dim AdaptadorComputadora As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                AdaptadorComputadora.Fill(ds, "Computadora")
                CboSerie.DataSource = ds.Tables(0)
                CboSerie.DisplayMember = ds.Tables(0).Columns("IdComputadora").ToString
                CboSerie.ValueMember = ds.Tables(0).Columns("IdComputadora").ToString

            Catch ex As Exception
                MessageBox.Show("Error al mostrar la serie de las computadoras " + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub
    Public Sub LlenarComboBoxUsuario()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_MostrarIdUsuario"
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
    Private Function IdentificarEstadoAsignacion() As String
        Dim var As String
        If ChkEstado.CheckState = CheckState.Checked Then
            var = "Asignada"
        Else
            var = "No Asignada"
        End If
        Return var
    End Function
    Private Sub GuardarComputadoraUsuario()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_InsertarComputadoraUsuario"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@IdComputadora", SqlDbType.NVarChar, 50).Value = CboSerie.SelectedValue
                    .Parameters.Add("@IdUsuario", SqlDbType.Int).Value = CInt(CboUsuario.SelectedValue)
                    .Parameters.Add("@Observacion", SqlDbType.NVarChar, 200).Value = TxtObservacion.Text.Trim
                    .Parameters.Add("@FechaAsignacion", SqlDbType.Date).Value = DtpFechaAsignacion.Text
                    .Parameters.Add("@Estado", SqlDbType.NVarChar, 20).Value = IdentificarEstadoAsignacion()

                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Asignacion registrada con exito", "Control Keeper")
            Catch ex As Exception
                MessageBox.Show("Error al guardar la Asignación " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If ValidarComputadoraUsuario() = True Then
            If ExisteIdComputadora() = False Then
                Call GuardarComputadoraUsuario()
                Call MostrarTodasComputadorasUsuario()
                Call HabilitarControles(True, False, False, False, False)
                Call Limpiar()
            Else
                MessageBox.Show("Ya se encuentra registrada esa Computadora", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            End If
        End If


    End Sub
    Private Sub Limpiar()
        CboSerie.Text = Nothing
        CboUsuario.Text = Nothing
        DtpFechaAsignacion.ResetText()
        TxtObservacion.Text = Nothing
        ChkEstado.Checked = False

    End Sub


    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        Call HabilitarControles(False, False, True, True, True)
        CboSerie.Enabled = False
        CboSerie.Text = DgvComputadoraUsuario.CurrentRow.Cells(0).Value.ToString
        TxtObservacion.Text = DgvComputadoraUsuario.CurrentRow.Cells(1).Value.ToString
        DtpFechaAsignacion.Text = DgvComputadoraUsuario.CurrentRow.Cells(2).Value.ToString
        CboUsuario.Text = DgvComputadoraUsuario.CurrentRow.Cells(3).Value.ToString

        If DgvComputadoraUsuario.CurrentRow.Cells(4).Value.ToString = "Asignada" Then
            ChkEstado.Checked = True
        Else
            ChkEstado.Checked = False
        End If


    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Call HabilitarControles(True, False, False, False, False)
        Call Limpiar()
        CboSerie.Enabled = True
        CboUsuario.Enabled = True
    End Sub
    Private Sub EditarComputadoraUsuario()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_ActualizarComputadoraUsuario"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@IdComputadora", SqlDbType.NVarChar, 50).Value = CboSerie.SelectedValue
                    .Parameters.Add("@IdUsuario", SqlDbType.Int).Value = CInt(CboUsuario.SelectedValue)
                    .Parameters.Add("@Observacion", SqlDbType.NVarChar, 200).Value = TxtObservacion.Text.Trim
                    .Parameters.Add("@FechaAsignacion", SqlDbType.Date).Value = DtpFechaAsignacion.Text
                    .Parameters.Add("@Estado", SqlDbType.NVarChar, 20).Value = IdentificarEstadoAsignacion()
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Asignación editada con exito", "Control Keeper")
            Catch ex As Exception
                MessageBox.Show("Error al editar la asignación " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using

    End Sub
    Private Sub EliminarComputadoraUsuario()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_EliminarComputadoraUsuario"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .Parameters.Add("@IdComputadora", SqlDbType.NVarChar, 50).Value = DgvComputadoraUsuario.CurrentRow.Cells(0).Value.ToString.Trim
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Asignacion eliminada con exito", "Control Keeper")
            Catch ex As Exception
                MessageBox.Show("Error al eliminar la asignacion " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If ValidarComputadoraUsuario() = True Then
            Call EditarComputadoraUsuario()
            Call HabilitarControles(True, False, False, False, False)
            Call Limpiar()
            Call MostrarTodasComputadorasUsuario()
            CboUsuario.Enabled = True
            CboSerie.Enabled = True
        End If

    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        If MessageBox.Show("¿Está seguro de eliminar el registro?", "Control Keeper",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            Call EliminarComputadoraUsuario()
            Call MostrarTodasComputadorasUsuario()
        End If
    End Sub


    Private Function ExisteIdComputadora() As Boolean
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Dim Valor As Boolean
        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_ExisteIdComputadoraUsuario"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .Parameters.Add("@IdComputadora", SqlDbType.NVarChar, 50).Value = CboUsuario.SelectedValue
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


    Private Sub ChkEstado_CheckedChanged(sender As Object, e As EventArgs) Handles ChkEstado.CheckedChanged
        If ChkEstado.CheckState = CheckState.Checked Then
            ChkEstado.Text = "Asignada"
        Else
            ChkEstado.Text = "No Asignada"
        End If
    End Sub


    Private Sub BtnAbrirFrmUsuario_Click(sender As Object, e As EventArgs) Handles BtnAbrirFrmUsuario.Click
        FrmUsuario.MdiParent = MDIControlKeeper
        FrmUsuario.Location = New Point(330, 110)
        FrmUsuario.Show()
        FrmUsuario.Var = 1
    End Sub

    Private Sub BtnAbrirFrmComputadora_Click(sender As Object, e As EventArgs) Handles BtnAbrirFrmComputadora.Click
        FrmComputadora.MdiParent = MDIControlKeeper
        FrmComputadora.Show()
        FrmComputadora.Location = New Point(320, 110)
        FrmComputadora.Var = 1
    End Sub

    Private Sub BusquedaFiltradasComputadoraUsuario()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_BusquedaComputadoraUsuario"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@Parametro", SqlDbType.NVarChar, 50).Value = TxtBusqueda.Text.Trim
                    .Connection = Con
                End With

                Dim AdaptadorBusqueda As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                AdaptadorBusqueda.Fill(dt)
                DgvComputadoraUsuario.DataSource = dt


            Catch ex As Exception
                MessageBox.Show("Error al mostrar los datos " + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub

    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        If TxtBusqueda.Text = Nothing Then
            MostrarTodasComputadorasUsuario()
        Else
            BusquedaFiltradasComputadoraUsuario()
        End If
    End Sub
End Class