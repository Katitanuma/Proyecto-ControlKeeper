Imports System.Data.SqlClient
Public Class FrmProfesion
    Private Sub HabilitarControles(ByVal Nuevo As Boolean, ByVal Guardar As Boolean, ByVal Modificar As Boolean, ByVal Cancelar As Boolean, ByVal Panel As Boolean)
        BtnNuevo.Enabled = Nuevo
        BtnGuardar.Enabled = Guardar
        BtnModificar.Enabled = Modificar
        BtnCancelar.Enabled = Cancelar
        PnlProfesion.Enabled = Panel
    End Sub

    Private Sub FrmProfesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call HabilitarControles(True, False, False, False, False)
        Call MostrarTodoProfesion()
        Call Limpiar()
    End Sub

    Private Sub MostrarTodoProfesion()
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
                End With
                Dim AdaptadorProfesion As New SqlDataAdapter(cmd)
                Dim Dt As New DataTable
                AdaptadorProfesion.Fill(Dt)
                DgvProfesion.DataSource = Dt

            Catch ex As Exception
                MessageBox.Show("Error al mostrar los datos de las profesiones " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using
    End Sub

    Private Sub GuardarProfesion()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()

                With cmd
                    .CommandText = "Sp_InsertarProfesion"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@Profesion", SqlDbType.NVarChar, 50).Value = TxtProfesion.Text.Trim
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Profesión almacenada con éxito", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call MostrarTodoProfesion()

            Catch ex As Exception
                MessageBox.Show("Error al guardar la profesión " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If ValidarProfesion() = True Then
            If ExisteNombreProfesion() = False Then
                Call HabilitarControles(True, False, False, False, False)
                Call MostrarTodoProfesion()
                Call GuardarProfesion()
                Call Limpiar()
            Else
                MessageBox.Show("Ya se encuentra registrada esta profesión", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If

    End Sub

    Private Sub Limpiar()
        TxtCodigoProfesion.Text = ""
        TxtProfesion.Text = ""
    End Sub

    Private Sub InvestigarCorrelativoProfesion()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If
        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_CorrelativoProfesion"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                End With

                Dim LectorCorrelativo As SqlDataReader
                LectorCorrelativo = cmd.ExecuteReader

                If LectorCorrelativo.Read Then
                    If LectorCorrelativo("Id") Is DBNull.Value Then
                        TxtCodigoProfesion.Text = 1
                    Else
                        TxtCodigoProfesion.Text = LectorCorrelativo("Id").ToString
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Con.Close()
            End Try
        End Using
    End Sub

    Private Function ExisteNombreProfesion() As Boolean
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Dim Valor As Boolean
        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_ExisteProfesion"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .Parameters.Add("@Profesion", SqlDbType.NVarChar, 50).Value = TxtProfesion.Text.Trim
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

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Call HabilitarControles(False, True, False, True, True)
        Call Limpiar()
        Call InvestigarCorrelativoProfesion()
    End Sub

    Private Sub EditarProfesion()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If
        Using cmd As New SqlCommand
            Try
                Con.Open()

                With cmd
                    .CommandText = "Sp_ActualizarProfesion"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@IdProfesion", SqlDbType.Int).Value = CInt(TxtCodigoProfesion.Text)
                    .Parameters.Add("@Profesion", SqlDbType.NVarChar, 50).Value = TxtProfesion.Text.Trim
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Profesión modificada con éxito", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("Error al modificar la profesión " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If ValidarProfesion() = True Then
            Call EditarProfesion()
            Call MostrarTodoProfesion()
            Call HabilitarControles(True, False, False, False, False)
            Call Limpiar()
        End If
    End Sub

    Private Sub EliminarProfesion()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_EliminarProfesion"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@IdProfesion", SqlDbType.Int).Value = CInt(DgvProfesion.CurrentRow.Cells(0).Value)
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Profesión eliminada con éxito", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("Error al eliminar la profesión " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        If MessageBox.Show("¿Está seguro de eliminar el registro?", "Control Keeper",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            Call EliminarProfesion()
            Call MostrarTodoProfesion()
        End If
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        Call HabilitarControles(False, False, True, True, True)
        TxtCodigoProfesion.Text = DgvProfesion.CurrentRow.Cells(0).Value
        TxtProfesion.Text = DgvProfesion.CurrentRow.Cells(1).Value.ToString
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Call HabilitarControles(True, False, False, False, False)
        Call Limpiar()
    End Sub

    Private Function ValidarProfesion()
        Dim Estado As Boolean
        If TxtProfesion.Text = "" Then
            MessageBox.Show("Ingrese el nombre de la profesión", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtProfesion.Focus()
            Estado = False
        Else
            Estado = True
        End If
        Return Estado
    End Function

    Private Sub BusquedaFiltradasProfesion()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_BusquedaProfesion"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@Parametro", SqlDbType.NVarChar, 50).Value = TxtBusqueda.Text.Trim
                    .Connection = Con
                End With

                Dim AdaptadorBusqueda As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                AdaptadorBusqueda.Fill(dt)
                DgvProfesion.DataSource = dt


            Catch ex As Exception
                MessageBox.Show("Error al mostrar los datos " + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub

    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        If TxtBusqueda.Text = Nothing Then
            MostrarTodoProfesion()
        Else
            BusquedaFiltradasProfesion()
        End If
    End Sub

End Class