Imports System.Data.SqlClient
Public Class FrmMarca
    Public Var As Integer = 0
    Private Sub HabilitarControles(ByVal Nuevo As Boolean, ByVal Guardar As Boolean, ByVal Modificar As Boolean, ByVal Cancelar As Boolean, ByVal Panel As Boolean)
        BtnNuevo.Enabled = Nuevo
        BtnGuardar.Enabled = Guardar
        BtnModificar.Enabled = Modificar
        BtnCancelar.Enabled = Cancelar
        PnlMarca.Enabled = Panel
    End Sub

    Private Sub Limpiar()
        TxtCodigoMarca.Text = ""
        TxtMarca.Text = ""
    End Sub

    Private Sub MostrarTodoMarca()
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
                End With

                Dim AdaptadorMarca As New SqlDataAdapter(cmd)
                Dim Dt As New DataTable
                AdaptadorMarca.Fill(Dt)
                DgvMarca.DataSource = Dt

            Catch ex As Exception
                MessageBox.Show("Error al mostrar los datos de las marcas " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using
    End Sub

    Private Sub FrmMarca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call HabilitarControles(True, False, False, False, False)
        Call Limpiar()
        Call MostrarTodoMarca()
    End Sub

    Private Sub GuardarMarca()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_InsertarMarca"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@Marca", SqlDbType.NVarChar, 50).Value = TxtMarca.Text.Trim
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Marca almacenada con éxito", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error al mostrar los datos de Marca " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If ValidarMarca() = True Then
            If ExisteNombreMarca() = False Then
                Call GuardarMarca()
                Call MostrarTodoMarca()
                Call HabilitarControles(True, False, False, False, False)
                Call Limpiar()
            Else
                MessageBox.Show("Ya se encuentra registrada esta marca", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub EditarMarca()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()

                With cmd
                    .CommandText = "Sp_ActualizarMarca"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@IdMarca", SqlDbType.Int).Value = CInt(TxtCodigoMarca.Text)
                    .Parameters.Add("@Marca", SqlDbType.NVarChar, 50).Value = TxtMarca.Text.Trim
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Marca modificada con éxito", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call MostrarTodoMarca()

            Catch ex As Exception
                MessageBox.Show("Error al modificar la marca " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If ValidarMarca() = True Then
            If ExisteNombreMarca() = False Then
                Call EditarMarca()
                Call HabilitarControles(True, False, False, False, False)
                Call Limpiar()
                Call MostrarTodoMarca()
            Else
                MessageBox.Show("Ya se encuentra registrada esta marca", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub EliminarMarca()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_EliminarMarca"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@IdMarca", SqlDbType.Int).Value = CInt(DgvMarca.CurrentRow.Cells(0).Value)
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Marca eliminada con éxito", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error al eliminar la marca " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        If MessageBox.Show("¿Está seguro de eliminar el registro?", "Control Keeper",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            Call EliminarMarca()
            Call MostrarTodoMarca()
        End If
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        Call HabilitarControles(False, False, True, True, True)
        TxtCodigoMarca.Text = DgvMarca.CurrentRow.Cells(0).Value
        TxtMarca.Text = DgvMarca.CurrentRow.Cells(1).Value.ToString
    End Sub

    Private Function ExisteNombreMarca()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If
        Dim Valor As Boolean
        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_ExisteMarca"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@Marca", SqlDbType.NVarChar, 50).Value = TxtMarca.Text.Trim
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

    Private Sub InvestigarCorrelativoMarca()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_CorrelativoMarca"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                End With

                Dim LectorCorrelativo As SqlDataReader
                LectorCorrelativo = cmd.ExecuteReader

                If LectorCorrelativo.Read Then
                    If LectorCorrelativo("Id") Is DBNull.Value Then
                        TxtCodigoMarca.Text = 1
                    Else
                        TxtCodigoMarca.Text = LectorCorrelativo("Id").ToString
                    End If
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                Con.Close()
            End Try
        End Using
    End Sub

    Private Function ValidarMarca()
        Dim Estado As Boolean
        If TxtMarca.Text = "" Then
            MessageBox.Show("Ingrese el nombre de la marca", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtMarca.Focus()
            Estado = False
        Else
            Estado = True
        End If
        Return Estado
    End Function

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Call HabilitarControles(False, True, False, True, True)
        Call Limpiar()
        Call InvestigarCorrelativoMarca()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Call HabilitarControles(True, False, False, False, False)
        Call Limpiar()
    End Sub



    Private Sub DgvMarca_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvMarca.CellDoubleClick
        If Var = 1 Then
            FrmModelo.LlenarComboBoxMarca()
            FrmModelo.CboMarca.Text = DgvMarca.CurrentRow.Cells(1).Value.ToString
            Me.Close()
        End If
    End Sub
End Class