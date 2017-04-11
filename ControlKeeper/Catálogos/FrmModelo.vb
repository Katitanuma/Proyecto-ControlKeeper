﻿Imports System.Data.SqlClient
Public Class FrmModelo
    Private Sub HabilitarControles(ByVal Nuevo As Boolean, ByVal Guardar As Boolean, ByVal Modificar As Boolean, ByVal Cancelar As Boolean, ByVal Panel As Boolean)
        BtnNuevo.Enabled = Nuevo
        BtnGuardar.Enabled = Guardar
        BtnModificar.Enabled = Modificar
        BtnCancelar.Enabled = Cancelar
        PnlModelo.Enabled = Panel
    End Sub

    Private Sub Limpiar()
        TxtCodigoModelo.Text = ""
        TxtModelo.Text = ""
        CboMarca.Text = ""
    End Sub

    Private Sub MostrarTodoModelo()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_MostrarTodoModelo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                End With

                Dim AdaptadorModelo As New SqlDataAdapter(cmd)
                Dim Dt As New DataTable
                AdaptadorModelo.Fill(Dt)
                DgvModelo.DataSource = Dt

            Catch ex As Exception
                MessageBox.Show("Error al mostrar los datos de modelo " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using
    End Sub

    Private Sub FrmModelo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call HabilitarControles(True, False, False, False, False)
        Call MostrarTodoModelo()
        Call LlenarComboBoxMarca()
        Call Limpiar()
    End Sub

    Private Sub LlenarComboBoxMarca()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_MostrarTodoMarca"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .ExecuteNonQuery()
                End With
                Dim AdaptadorMarca As New SqlDataAdapter(cmd)
                Dim Ds As New DataSet
                AdaptadorMarca.Fill(Ds, "Marca")
                CboMarca.DataSource = Ds.Tables(0)
                CboMarca.DisplayMember = Ds.Tables(0).Columns("Marca").ToString
                CboMarca.ValueMember = Ds.Tables(0).Columns("IdMarca").ToString

            Catch ex As Exception
                MessageBox.Show("Error al mostrar la marca " + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub
    Private Sub InvestigarCorrelativoModelo()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_CorrelativoModelo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                End With
                Dim LectorCorrelativo As SqlDataReader
                LectorCorrelativo = cmd.ExecuteReader

                If LectorCorrelativo.Read Then
                    If LectorCorrelativo("Id") Is DBNull.Value Then
                        TxtCodigoModelo.Text = 1
                    Else
                        TxtCodigoModelo.Text = LectorCorrelativo("Id").ToString
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Con.Close()
            End Try
        End Using
    End Sub

    Private Function ExisteNombreModelo()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Dim Valor As Boolean
        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_ExisteModelo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@Modelo", SqlDbType.NVarChar, 50).Value = TxtModelo.Text.Trim
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

    Private Sub GuardarModelo()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_InsertarModelo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@Modelo", SqlDbType.NVarChar, 50).Value = TxtModelo.Text.Trim
                    .Parameters.Add("@IdMarca", SqlDbType.Int).Value = CInt(CboMarca.SelectedValue)
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Modelo almacenado con éxito", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call MostrarTodoModelo()
            Catch ex As Exception
                MessageBox.Show("Error al almacenar el modelo " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using
    End Sub

    Private Function ValidarModelo()
        Dim Estado As Boolean
        If TxtModelo.Text = "" Then
            MessageBox.Show("Ingrese el modelo", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtModelo.Focus()
            Estado = False
        Else
            Estado = True
        End If
        Return Estado
    End Function

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If ValidarModelo() = True Then
            If ExisteNombreModelo() = False Then
                Call GuardarModelo()
                Call HabilitarControles(True, False, False, False, False)
                Call Limpiar()
                Call MostrarTodoModelo()
            Else
                MessageBox.Show("Ya se encuentra registrado este modelo", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub EditarModelo()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_ActualizarModelo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .Parameters.Add("@IdModelo", SqlDbType.Int).Value = CInt(TxtCodigoModelo.Text)
                    .Parameters.Add("@Modelo", SqlDbType.NVarChar, 50).Value = TxtModelo.Text.Trim
                    .Parameters.Add("@IdMarca", SqlDbType.Int).Value = CInt(CboMarca.SelectedValue)
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Modelo modificado con éxito", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error al modificar el modelo " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If ValidarModelo() = True Then
            If ExisteNombreModelo() = False Then
                Call EditarModelo()
                Call MostrarTodoModelo()
                Call HabilitarControles(True, False, False, False, False)
                Call Limpiar()
            Else
                MessageBox.Show("Ya se encuentra registrado este modelo", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Call Limpiar()
        Call InvestigarCorrelativoModelo()
        Call HabilitarControles(False, True, False, True, True)
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Call HabilitarControles(True, False, False, False, False)
        Call Limpiar()
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        Call HabilitarControles(False, False, True, True, True)
        TxtCodigoModelo.Text = DgvModelo.CurrentRow.Cells(0).Value
        TxtModelo.Text = DgvModelo.CurrentRow.Cells(1).Value.ToString
        CboMarca.Text = DgvModelo.CurrentRow.Cells(2).Value.ToString
    End Sub

    Private Sub EliminarModelo()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_EliminarModelo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@IdModelo", SqlDbType.Int).Value = CInt(DgvModelo.CurrentRow.Cells(0).Value)
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Modelo eliminado con éxito", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error al eliminar el modelo " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Call EliminarModelo()
        Call MostrarTodoModelo()
    End Sub
End Class