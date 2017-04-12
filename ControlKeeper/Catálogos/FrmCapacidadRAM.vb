Imports System.Data.SqlClient
Public Class FrmCapacidadRAM
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Call HabilitarControles(False, True, False, True, True)
        Call InvestigarCorrelativoCapacidadMemoriaRAM()

    End Sub

    Private Sub HabilitarControles(ByVal Nuevo As Boolean, ByVal Guardar As Boolean, ByVal Modificar As Boolean, ByVal Cancelar As Boolean, ByVal Panel As Boolean)
        BtnCancelar.Enabled = Cancelar
        BtnGuardar.Enabled = Guardar
        BtnModificar.Enabled = Modificar
        BtnNuevo.Enabled = Nuevo
        PnlCapacidadMemoriaRAM.Enabled = Panel

    End Sub

    Private Sub FrmCapacidadRAM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call HabilitarControles(True, False, False, False, False)
        Call MostrarTodoCapacidadMemoriaRAM()


    End Sub

    Private Sub MostrarTodoCapacidadMemoriaRAM()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using Cmd As New SqlCommand

            Try

                Con.Open()

                With Cmd
                    .CommandText = "Sp_MostrarTodoCapacidadMemoriaRAM"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                End With

                Dim AdaptadorCapacidadMemoriaRAM As New SqlDataAdapter(Cmd)
                Dim Dt As New DataTable

                AdaptadorCapacidadMemoriaRAM.Fill(Dt)
                DgvCapacidadMemoriaRAM.DataSource = Dt


            Catch ex As Exception
                MessageBox.Show("Error al mostrar los datos de las capacidades de memoria RAM" + ex.Message)

            Finally

                Con.Close()

            End Try

        End Using


    End Sub

    Private Sub GuardarCapacidadMemoriaRAM()

        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using Cmd As New SqlCommand

            Try
                Con.Open()

                With Cmd
                    .CommandText = "Sp_InsertarCapacidadMemoriaRAM"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@CapacidadMemoriaRAM", SqlDbType.NVarChar, 20).Value = TxtCapacidadRAM.Text.Trim
                    .ExecuteNonQuery()

                End With
                MessageBox.Show("Capacidad de meroria RAM almacenada con éxito", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Information)


            Catch ex As Exception
                MessageBox.Show("Error al almacenar la Capacidad de meroria RAM", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Finally
                Con.Close()
            End Try
        End Using
    End Sub

    Private Sub ModificarCapacidadMemoriaRAM()

        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If


        Using Cmd As New SqlCommand

            Try

                Con.Open()

                With Cmd
                    .CommandText = "Sp_ActualizarCapacidadMemoriaRAM"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@IdCapacidadMemoriaRAM", SqlDbType.Int).Value = TxtIdCapacidadRAM.Text
                    .Parameters.Add("@CapacidadMemoriaRAM", SqlDbType.NVarChar, 20).Value = TxtCapacidadRAM.Text

                    .ExecuteNonQuery()

                End With

                MessageBox.Show("Capacidad de meroria RAM editada con éxito", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("Error al editar la Capacidad de meroria RAM" + ex.Message)

            Finally
                Con.Close()
            End Try
        End Using
    End Sub

    Private Sub EliminarCapacidadMemoriaRAM()

        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using Cmd As New SqlCommand

            Try
                Con.Open()

                With Cmd
                    .CommandText = "Sp_EliminarCapacidadMemoriaRAM"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@IdCapacidadMemoriaRAM", SqlDbType.Int).Value = DgvCapacidadMemoriaRAM.CurrentRow.Cells(0).Value
                    .ExecuteNonQuery()

                End With


            Catch ex As Exception
                MessageBox.Show("Error al eliminar la Capacidad de meroria RAM", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Finally
                Con.Close()

            End Try
        End Using
    End Sub




    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        If ValidarCapacidadMemoriaRAM() = True Then

            If ExisteCapacidadMemoriaRAM() = False Then


                Call GuardarCapacidadMemoriaRAM()
                HabilitarControles(True, False, False, False, False)
                Call MostrarTodoCapacidadMemoriaRAM()
                Call LimpiarCapacidadMemoriaRAM()
                Call InvestigarCorrelativoCapacidadMemoriaRAM()


            End If
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        HabilitarControles(True, False, False, False, False)
        TxtCapacidadRAM.Text = ""
        TxtIdCapacidadRAM.Text = ""
        Call InvestigarCorrelativoCapacidadMemoriaRAM()
        Call LimpiarCapacidadMemoriaRAM()
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        HabilitarControles(False, False, True, True, True)
        TxtIdCapacidadRAM.Text = DgvCapacidadMemoriaRAM.CurrentRow.Cells(0).Value
        TxtCapacidadRAM.Text = DgvCapacidadMemoriaRAM.CurrentRow.Cells(1).Value.ToString
    End Sub


    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click

        If ValidarCapacidadMemoriaRAM() = True Then

            If ExisteCapacidadMemoriaRAM() = False Then

                Call ModificarCapacidadMemoriaRAM()
                HabilitarControles(True, False, False, False, False)
                Call MostrarTodoCapacidadMemoriaRAM()
            Else
                MsgBox("Ya existe es capacidad de memoria RAM")
            End If

        End If
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        If MessageBox.Show("¿Está seguro de eliminar el registro?", "Control Keeper",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            Call HabilitarControles(True, False, False, False, False)
            Call EliminarCapacidadMemoriaRAM()
            Call MostrarTodoCapacidadMemoriaRAM()

            MessageBox.Show("Capacidad de memoria RAM eliminada con éxito")
        End If
    End Sub


    Private Sub InvestigarCorrelativoCapacidadMemoriaRAM()

        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If
        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_CorrelativoCapacidadMemoriaRAM"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                End With
                Dim LectorCorrelativo As SqlDataReader
                LectorCorrelativo = cmd.ExecuteReader

                If LectorCorrelativo.Read Then
                    If LectorCorrelativo("Id") Is DBNull.Value Then
                        TxtIdCapacidadRAM.Text = 1
                    Else
                        TxtIdCapacidadRAM.Text = LectorCorrelativo("Id").ToString
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Con.Close()
            End Try
        End Using


    End Sub

    Private Sub LimpiarCapacidadMemoriaRAM()
        TxtCapacidadRAM.Text = ""
        TxtIdCapacidadRAM.Text = ""
    End Sub



    Private Function ValidarCapacidadMemoriaRAM()

        Dim Estado As Boolean

        If TxtCapacidadRAM.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar la Capacidad de memoria RAM", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Estado = False

        Else
            Estado = True
        End If

        Return Estado

    End Function

    Private Function ExisteCapacidadMemoriaRAM() As Boolean
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Dim Valor As Boolean
        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_ExisteCapacidadMemoriaRAM"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .Parameters.Add("@CapacidadMemoriaRAM", SqlDbType.NVarChar, 20).Value = TxtCapacidadRAM.Text.Trim
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


End Class