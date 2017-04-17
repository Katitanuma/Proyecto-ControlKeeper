Imports System.Data.SqlClient
Public Class FrmDepartamento
    Public Var As Integer = 0
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click

        Call HabilitarControles(False, True, False, True, True)
        Call InvestigarCorrelativoDepartamento()

    End Sub


    Private Sub HabilitarControles(ByVal Nuevo As Boolean, ByVal Guardar As Boolean, ByVal Modificar As Boolean, ByVal Cancelar As Boolean, ByVal Panel As Boolean)

        BtnCancelar.Enabled = Cancelar
        BtnGuardar.Enabled = Guardar
        BtnModificar.Enabled = Modificar
        BtnNuevo.Enabled = Nuevo
        PnlDepartamento.Enabled = Panel

    End Sub

    Private Sub InvestigarCorrelativoDepartamento()

        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using Cmd As New SqlCommand

            Try
                Con.Open()

                With Cmd
                    .CommandText = "Sp_CorrelativoDepartamento"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                End With

                Dim LectorCorrelativo As SqlDataReader
                LectorCorrelativo = Cmd.ExecuteReader

                If LectorCorrelativo.Read Then
                    If LectorCorrelativo("Id") Is DBNull.Value Then
                        TxtIdDepartamento.Text = 1
                    Else
                        TxtIdDepartamento.Text = LectorCorrelativo("Id").ToString
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

        If ValidarDepartamento() = True Then

            If ExisteDepartamento() = False Then

                Call HabilitarControles(True, False, False, False, False)
                Call InsertarDepartamento()
                Call MostrarTodoDepartamento()
                Call LimpiarDepartamento()

            Else
                MessageBox.Show("Ya existe ese departamento", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click

        Call InvestigarCorrelativoDepartamento()
        Call LimpiarDepartamento()
        Call HabilitarControles(True, False, False, False, False)

    End Sub

    Private Function ExisteDepartamento() As Boolean

        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Dim Valor As Boolean
        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_ExisteDepartamento"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .Parameters.Add("@Departamento", SqlDbType.NVarChar, 50).Value = TxtDepartamento.Text.Trim
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

    Private Sub InsertarDepartamento()

        If Con.State = ConnectionState.Open Then
            Con.Open()
        End If

        Using Cmd As New SqlCommand

            Try

                Con.Open()

                With Cmd
                    .CommandText = "Sp_InsertarDepartamento"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@Departamento", SqlDbType.NVarChar, 50).Value = TxtDepartamento.Text.Trim
                    .ExecuteNonQuery()
                End With

                MessageBox.Show("Departamento almacenado con éxtio", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception

                MessageBox.Show("Error al almacencar el departamento" + ex.Message)

            Finally
                Con.Close()
            End Try

        End Using
    End Sub

    Private Sub EliminarDepartamento()

        If Con.State = ConnectionState.Open Then
            Con.Open()
        End If

        Using Cmd As New SqlCommand

            Try
                Con.Open()

                With Cmd
                    .CommandText = "Sp_EliminarDepartamento"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@IdDepartamento", SqlDbType.Int).Value = CInt(DgvDepartamento.CurrentRow.Cells(0).Value)
                    .ExecuteNonQuery()
                End With

                MessageBox.Show("Departamento eliminado con éxtio", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("Error al eliminar el departamento", ex.Message)

            Finally

                Con.Close()

            End Try

        End Using

    End Sub


    Private Sub ActualizarDepartamento()

        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using Cmd As New SqlCommand

            Try
                Con.Open()

                With Cmd
                    .CommandText = "Sp_ActualizarDepartamento"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@IdDepartamento", SqlDbType.Int).Value = TxtIdDepartamento.Text.Trim
                    .Parameters.Add("@Departamento", SqlDbType.NVarChar, 50).Value = TxtDepartamento.Text.Trim
                    .ExecuteNonQuery()

                End With

                MessageBox.Show("Departamento actualizado con éxtio", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception

                MsgBox("Error al actualizar el departamento" + ex.Message)

            Finally

                Con.Close()

            End Try

        End Using

    End Sub


    Private Sub MostrarTodoDepartamento()

        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using Cmd As New SqlCommand

            Try

                Con.Open()

                With Cmd
                    .CommandText = "Sp_MostrarTodoDepartamento"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                End With

                Dim AdaptadorDepartamento As New SqlDataAdapter(Cmd)
                Dim Dt As New DataTable

                AdaptadorDepartamento.Fill(Dt)
                DgvDepartamento.DataSource = Dt


            Catch ex As Exception

                MessageBox.Show("Error al mostrar los datos de los departamentos " + ex.Message)
            Finally

                Con.Close()

            End Try
        End Using
    End Sub

    Private Sub FrmDepartamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call HabilitarControles(True, False, False, False, False)

        Call MostrarTodoDepartamento()

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click

        If ValidarDepartamento() = True Then
            Call ActualizarDepartamento()
            Call MostrarTodoDepartamento()
            Call LimpiarDepartamento()
            Call HabilitarControles(True, False, False, False, False)
        End If
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click

        Call HabilitarControles(False, False, True, True, True)
        TxtIdDepartamento.Text = DgvDepartamento.CurrentRow.Cells(0).Value
        TxtDepartamento.Text = DgvDepartamento.CurrentRow.Cells(1).Value.ToString

    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        If MessageBox.Show("¿Está seguro de eliminar el registro?", "Control Keeper",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            Call HabilitarControles(True, False, False, False, False)
            Call EliminarDepartamento()
            Call MostrarTodoDepartamento()
        End If
    End Sub

    Private Sub LimpiarDepartamento()

        Call MostrarTodoDepartamento()
        TxtDepartamento.Text = ""
        TxtIdDepartamento.Text = ""

    End Sub

    Private Function ValidarDepartamento() As Boolean

        Dim Estado As Boolean

        If TxtDepartamento.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar el departamento", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        Else
            Estado = True

        End If

        Return Estado

    End Function


    Private Sub DgvDepartamento_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvDepartamento.CellDoubleClick
        If Var = 1 Then
            FrmCiudad.LlenarComboBoxDepartamento()
            FrmCiudad.CboDepartamento.Text = DgvDepartamento.CurrentRow.Cells(1).Value.ToString
            Me.Close()
        End If
    End Sub

    Private Sub BusquedaFiltradasDepartamento()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_BusquedaDepartamento"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@Parametro", SqlDbType.NVarChar, 50).Value = TxtBusqueda.Text.Trim
                    .Connection = Con
                End With

                Dim AdaptadorBusqueda As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                AdaptadorBusqueda.Fill(dt)
                DgvDepartamento.DataSource = dt


            Catch ex As Exception
                MessageBox.Show("Error al mostrar los datos " + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub

    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        If TxtBusqueda.Text = Nothing Then
            MostrarTodoDepartamento()
        Else
            BusquedaFiltradasDepartamento()
        End If
    End Sub
End Class
