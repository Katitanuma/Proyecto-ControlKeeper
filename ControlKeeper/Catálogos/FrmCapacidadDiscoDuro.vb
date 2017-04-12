Imports System.Data.SqlClient
Public Class FrmCapacidadDiscoDuro
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        HabilitarControles(False, True, False, True, True)
        Call InvestigarCorrelativoCapacidadDiscoDuro()
    End Sub


    Private Sub GuardarCapacidadDiscoDuro()

        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If


        Try
            Con.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_InsertarCapacidadDiscoDuro"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@CapacidadDiscoDuro", SqlDbType.NVarChar, 20).Value = TxtCapacidadDiscoDuro.Text
                    .ExecuteNonQuery()
                    MessageBox.Show("Registro almacenado con éxito", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Information)


                End With

            End Using

        Catch ex As Exception
            MessageBox.Show("Error al almacenar la capacidad de disco duro" + ex.Message)

        Finally
            Con.Close()

        End Try
    End Sub


    Private Sub EliminarCapacidadDiscoDuro()

        If Con.State = ConnectionState.Open Then

            Con.Close()
        End If

        Try
            Con.Open()

            Using Cmd As New SqlCommand

                With Cmd
                    .CommandText = "Sp_EliminarCapacidadDiscoDuro"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@IdCapacidadDiscoDuro", SqlDbType.Int).Value = DgvCapacidadDiscoDuro.CurrentRow.Cells(0).Value
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Registro eliminado con éxito", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al eliminar la capacidad de disco duro" + ex.Message)

        Finally
            Con.Close()
        End Try



    End Sub

    Private Sub ActualizarCapacidadDiscoDuro()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If


        Try
            Con.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_ActualizarCapacidadDiscoDuro"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@IdCapacidadDiscoDuro", SqlDbType.Int).Value = Trim(TxtIdCapacidadDiscoDuro.Text)
                    .Parameters.Add("@CapacidadDiscoDuro", SqlDbType.NVarChar, 20).Value = Trim(TxtCapacidadDiscoDuro.Text)
                    .ExecuteNonQuery()
                    MessageBox.Show("Registro actualizado con éxito", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Information)


                End With

            End Using


        Catch ex As Exception
            MessageBox.Show("Error al actualizar la capacidad de disco duro", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Finally
            Con.Close()

        End Try
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click

        If ValidarCapacidadDiscoDuro() = True Then
            If ExisteCapacidadDiscoDuro() = False Then
                Call ActualizarCapacidadDiscoDuro()
                Call HabilitarControles(True, False, False, False, False)
                Call MostrarTodoCapacidadDiscoDuro()
                Call Limpiar()
            Else
                MessageBox.Show("Ya se encuentra registrada esta capacidad de disco duro", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        End If

    End Sub

    Private Sub MostrarTodoCapacidadDiscoDuro()

        If Con.State = ConnectionState.Open Then

            Con.Close()
        End If

        Try
            Con.Open()

            Using Cmd As New SqlCommand

                With Cmd
                    .CommandText = "Sp_MostrarTodoCapacidadDiscoDuro"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    Dim AdaptadorCapacidadDiscoDuro As New SqlDataAdapter(Cmd)
                    Dim Dt As New DataTable

                    AdaptadorCapacidadDiscoDuro.Fill(Dt)
                    DgvCapacidadDiscoDuro.DataSource = Dt
                    'gvCapacidadDiscoDuro.Columns(2).Visible = True


                End With

            End Using

        Catch ex As Exception
            MessageBox.Show("Error al mostrar los datos de las capacidades de disco duro" + ex.Message)

        Finally
            Con.Close()

        End Try



    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click

        Call HabilitarControles(True, False, False, False, False)
        Call Limpiar()
        Call InvestigarCorrelativoCapacidadDiscoDuro()


    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        If ValidarCapacidadDiscoDuro() = True Then

            If ExisteCapacidadDiscoDuro() = False Then

                Call GuardarCapacidadDiscoDuro()
                Call MostrarTodoCapacidadDiscoDuro()
                Call HabilitarControles(True, False, False, False, False)
                Call Limpiar()
            Else
                MessageBox.Show("Ya se encuentra registrada esa capacidad de disco duro", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        End If

    End Sub


    Private Sub HabilitarControles(ByVal Nuevo As Boolean, ByVal Guardar As Boolean, ByVal Modificar As Boolean, ByVal Cancelar As Boolean, ByVal Panel As Boolean)
        BtnNuevo.Enabled = Nuevo
        BtnGuardar.Enabled = Guardar
        BtnModificar.Enabled = Modificar
        BtnCancelar.Enabled = Cancelar
        PnlCapacidadDiscoDuro.Enabled = Panel
    End Sub


    Private Sub InvestigarCorrelativoCapacidadDiscoDuro()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using Cmd As New SqlCommand

            Try

                Con.Open()

                With Cmd
                    .CommandText = "Sp_CorrelativoCapacidadDiscoDuro"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                End With

                Dim LectorCorrelativo As SqlDataReader
                LectorCorrelativo = Cmd.ExecuteReader

                If LectorCorrelativo.Read Then
                    If LectorCorrelativo("Id") Is DBNull.Value Then
                        TxtIdCapacidadDiscoDuro.Text = 1

                    Else
                        TxtIdCapacidadDiscoDuro.Text = LectorCorrelativo("Id").ToString
                    End If
                End If


            Catch ex As Exception
                MsgBox(ex.Message)

            Finally
                Con.Close()
            End Try

        End Using


    End Sub


    Private Function ExisteCapacidadDiscoDuro() As Boolean
        If Con.State = ConnectionState.Open Then
            Con.Close()

        End If


        Dim Valor As Boolean
        Using Cmd As New SqlCommand

            Try
                Con.Open()

                With Cmd
                    .CommandText = "Sp_ExisteCapacidadDiscoDuro"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@CapacidadDiscoDuro", SqlDbType.NVarChar, 20).Value = TxtCapacidadDiscoDuro.Text.Trim



                End With

                Dim Existe As Integer = Cmd.ExecuteScalar

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

    Private Sub Limpiar()
        TxtCapacidadDiscoDuro.Text = ""
        TxtIdCapacidadDiscoDuro.Text = ""
    End Sub

    Private Sub FrmCapacidadDiscoDuro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call MostrarTodoCapacidadDiscoDuro()
        Call HabilitarControles(True, False, False, False, False)


    End Sub

    Private Sub EditarToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click

        Call HabilitarControles(False, False, True, True, True)
        TxtIdCapacidadDiscoDuro.Text = DgvCapacidadDiscoDuro.CurrentRow.Cells(0).Value
        TxtCapacidadDiscoDuro.Text = DgvCapacidadDiscoDuro.CurrentRow.Cells(1).Value.ToString

    End Sub

    Private Sub EliminarToolStripMenuItem_Click_2(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        If MessageBox.Show("¿Está seguro de eliminar el registro?", "Control Keeper",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            Call HabilitarControles(True, False, False, False, False)
            Call EliminarCapacidadDiscoDuro()
            Call MostrarTodoCapacidadDiscoDuro()
        End If

    End Sub

    Private Function ValidarCapacidadDiscoDuro()

        Dim Estado As Boolean

        If TxtCapacidadDiscoDuro.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar la Capacidad de disco duro", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Estado = False

        Else
            Estado = True
        End If

        Return Estado

    End Function

End Class