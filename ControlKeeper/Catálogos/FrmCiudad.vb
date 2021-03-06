﻿Imports System.Data.SqlClient
Public Class FrmCiudad

    Private Sub FrmCiudad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HabilitarControles(True, False, False, False, False)
        Call MostrarTodociudad()
        Call LlenarComboBoxDepartamento()
        Call Limpiar()
    End Sub
    Private Sub HabilitarControles(ByVal Nuevo As Boolean, ByVal Guardar As Boolean, ByVal Modificar As Boolean, ByVal Cancelar As Boolean, ByVal Panel As Boolean)
        BtnNuevo.Enabled = Nuevo
        BtnGuardar.Enabled = Guardar
        BtnModificar.Enabled = Modificar
        BtnCancelar.Enabled = Cancelar
        PnlCiudad.Enabled = Panel
    End Sub
    Private Sub MostrarTodociudad()
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
                End With

                Dim AdaptadorCiudad As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                AdaptadorCiudad.Fill(dt)
                DgvCiudad.DataSource = dt

            Catch ex As Exception
                MessageBox.Show("Error al mostrar los datos de las ciudades" + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Call HabilitarControles(False, True, False, True, True)
        Call InvestigarCorrelativoCiudad()
    End Sub
    Public Sub LlenarComboBoxDepartamento()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_MostrarTodoDepartamento"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .ExecuteNonQuery()
                End With
                Dim AdaptadorDepartamento As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                AdaptadorDepartamento.Fill(ds, "Departamento")
                CboDepartamento.DataSource = ds.Tables(0)
                CboDepartamento.DisplayMember = ds.Tables(0).Columns("Departamento").ToString
                CboDepartamento.ValueMember = ds.Tables(0).Columns("IdDepartamento").ToString

            Catch ex As Exception
                MessageBox.Show("Error al mostrar los datos de los departamentos " + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub
    Private Sub GuardarCiudad()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_InsertarCiudad"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@Ciudad", SqlDbType.NVarChar, 50).Value = TxtCiudad.Text.Trim
                    .Parameters.Add("@IdDepartamento", SqlDbType.Int).Value = CInt(CboDepartamento.SelectedValue)
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Ciudad almacenada con éxito", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error al almacenar la ciudad " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        If ValidarCiudad() = True Then

            If ExisteCiudad() = False Then
                Call GuardarCiudad()
                Call MostrarTodociudad()
                Call HabilitarControles(True, False, False, False, False)
                Call Limpiar()
            Else
                MessageBox.Show("Ya se encuentra registrada esa ciudad", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            End If
        End If
    End Sub
        Private Sub Limpiar()

        TxtIdCiudad.Text = ""
        TxtCiudad.Text = ""
        CboDepartamento.Text = Nothing

    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        Call HabilitarControles(False, False, True, True, True)
        TxtIdCiudad.Text = DgvCiudad.CurrentRow.Cells(0).Value
        TxtCiudad.Text = DgvCiudad.CurrentRow.Cells(1).Value.ToString
        CboDepartamento.Text = DgvCiudad.CurrentRow.Cells(2).Value.ToString
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
            Call HabilitarControles(True, False, False, False, False)
            Call Limpiar()
        End Sub
    Private Sub EditarCiudad()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_ActualizarCiudad"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@IdCiudad", SqlDbType.Int).Value = CInt(TxtIdCiudad.Text)
                    .Parameters.Add("@Ciudad", SqlDbType.NVarChar, 50).Value = TxtCiudad.Text.Trim
                    .Parameters.Add("@IdDepartamento", SqlDbType.Int).Value = CInt(CboDepartamento.SelectedValue)
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Ciudad editada con éxito", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error al editar la ciudad" + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using

    End Sub
    Private Sub EliminarCiudad()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_EliminarCiudad"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@IdCiudad", SqlDbType.Int).Value = CInt(DgvCiudad.CurrentRow.Cells(0).Value)
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Ciudad eliminada con éxito", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error al eliminar la ciudad" + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click

        If ValidarCiudad() = True Then


            Call EditarCiudad()
            Call HabilitarControles(True, False, False, False, False)
                Call Limpiar()
            Call MostrarTodociudad()
        End If
    End Sub

        Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click

        If MessageBox.Show("¿Está seguro de eliminar el registro?", "Control Keeper",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            Call EliminarCiudad()
            Call MostrarTodociudad()
            HabilitarControles(True, False, False, False, False)

        End If
    End Sub

    Private Sub InvestigarCorrelativoCiudad()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If
        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_CorrelativoCiudad"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                End With
                Dim LectorCorrelativo As SqlDataReader
                LectorCorrelativo = cmd.ExecuteReader

                If LectorCorrelativo.Read Then
                    If LectorCorrelativo("Id") Is DBNull.Value Then
                        TxtIdCiudad.Text = 1
                    Else
                        TxtIdCiudad.Text = LectorCorrelativo("Id").ToString
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Con.Close()
            End Try
        End Using
    End Sub
    Private Function ExisteCiudad() As Boolean
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Dim Valor As Boolean
        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_ExisteCiudad"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .Parameters.Add("@Ciudad", SqlDbType.NVarChar, 50).Value = TxtCiudad.Text.Trim
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

    Private Sub BtnBusqueDepartamento_Click(sender As Object, e As EventArgs) Handles BtnBusqueDepartamento.Click
        FrmDepartamento.MdiParent = MDIControlKeeper
        FrmDepartamento.Var = 1
        FrmDepartamento.Location = New Point(385, 110)
        FrmDepartamento.Show()

    End Sub

    Private Function ValidarCiudad() As Boolean

        Dim Estado As Boolean

        If TxtCiudad.Text = Nothing And CboDepartamento.Text = Nothing Then


            MessageBox.Show("Tiene que ingresar todos los campos", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtCiudad.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar la ciudad", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False


        ElseIf CboDepartamento.Text = Nothing Then


            MessageBox.Show("Tiene que seleccionar un departamento", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        Else
            Estado = True

        End If

        Return Estado
    End Function

    Private Sub BusquedaFiltradasCiudad()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_BusquedaCiudad"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@Parametro", SqlDbType.NVarChar, 50).Value = TxtBusqueda.Text.Trim
                    .Connection = Con
                End With

                Dim AdaptadorBusqueda As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                AdaptadorBusqueda.Fill(dt)
                DgvCiudad.DataSource = dt


            Catch ex As Exception
                MessageBox.Show("Error al mostrar los datos " + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub

    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        If TxtBusqueda.Text = Nothing Then
            MostrarTodociudad()
        Else
            BusquedaFiltradasCiudad()
        End If
    End Sub
End Class