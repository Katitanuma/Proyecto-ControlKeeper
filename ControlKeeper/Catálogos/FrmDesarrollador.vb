Imports System.Data.SqlClient
Public Class FrmDesarrollador
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click

        Call HabilitarControles(False, True, False, True, True)
        Call InvestigarCorrelativoDesarrollador()

    End Sub

    Private Sub HabilitarControles(ByVal Nuevo As Boolean, ByVal Guardar As Boolean, ByVal Modificar As Boolean, ByVal Cancelar As Boolean, ByVal Panel As Boolean)

        BtnCancelar.Enabled = Cancelar
        BtnGuardar.Enabled = Guardar
        BtnModificar.Enabled = Modificar
        BtnNuevo.Enabled = Nuevo
        PnlDesarrollador.Enabled = Panel

    End Sub

    Private Sub InvestigarCorrelativoDesarrollador()

        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using Cmd As New SqlCommand

            Try

                Con.Open()

                With Cmd
                    .CommandText = "Sp_CorrelativoDesarrollador"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                End With

                Dim LectorCorrelativo As SqlDataReader
                LectorCorrelativo = Cmd.ExecuteReader

                If LectorCorrelativo.Read Then
                    If LectorCorrelativo("Id") Is DBNull.Value Then
                        TxtIdDesarrollador.Text = 1
                    Else
                        TxtIdDesarrollador.Text = LectorCorrelativo("Id").ToString
                    End If
                End If

            Catch ex As Exception

                MsgBox(ex.Message)
            Finally
                Con.Close()

            End Try
        End Using
    End Sub


    Private Function ExisteNombreDesarrollador() As Boolean
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Dim Valor As Boolean
        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_ExisteDesarrollador"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .Parameters.Add("@NombreDesarrollador", SqlDbType.NVarChar, 50).Value = TxtNombreDesarrollador.Text.Trim

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


    Private Function ExistePaginaWebeDesarrollador() As Boolean
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Dim Valor As Boolean
        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_ExistePaginaWeb"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@PaginaWeb", SqlDbType.NVarChar, 100).Value = TxtPaginaWeb.Text.Trim

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

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Call InvestigarCorrelativoDesarrollador()
        Call LimpiarDesarrollador()
        Call HabilitarControles(True, False, False, False, False)
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        If ValidarDesarrollador() = True Then

            If ExisteNombreDesarrollador() = False And ExistePaginaWebeDesarrollador() = False Then

                Call HabilitarControles(True, False, False, False, False)
                Call InsertarDesarrollador()
                Call MostrarTodoDesarrollador()
                Call LimpiarDesarrollador()

            Else
                MessageBox.Show("Ese desarrollador o página web ya se encuentran almacenados", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If

        End If

    End Sub

    Private Function ValidarDesarrollador() As Boolean

        Dim Estado As Boolean

        If TxtNombreDesarrollador.Text = Nothing And TxtPaginaWeb.Text = Nothing Then
            MessageBox.Show("Tiene que ingresar el nombre del desarrollador y la página web", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Estado = False

        ElseIf TxtNombreDesarrollador.Text = Nothing Then
            MessageBox.Show("Tiene que ingresar el nombre del desarrollador", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Estado = False

        ElseIf TxtPaginaWeb.Text = Nothing Then
            MessageBox.Show("Tiene que ingresar la página web", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        Else
            Estado = True
        End If

        Return Estado

    End Function


    Private Sub InsertarDesarrollador()

        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using Cmd As New SqlCommand

            Try
                Con.Open()

                With Cmd
                    .CommandText = "Sp_InsertarDesarrollador"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@NombreDesarrollador", SqlDbType.NVarChar, 50).Value = TxtNombreDesarrollador.Text.Trim
                    .Parameters.Add("@PaginaWeb", SqlDbType.NVarChar, 100).Value = TxtPaginaWeb.Text.Trim
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Desarrollador almacenado con éxito", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error al ingresar el desarrollador" + ex.Message)

            Finally
                Con.Close()
            End Try
        End Using
    End Sub

    Private Sub ActualizarDesarrollador()

        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using Cmd As New SqlCommand

            Try
                Con.Open()

                With Cmd
                    .CommandText = "Sp_ActualizarDesarrollador"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@IdDesarrollador", SqlDbType.Int).Value = CInt(TxtIdDesarrollador.Text.Trim)
                    .Parameters.Add("@NombreDesarrollador", SqlDbType.NVarChar, 50).Value = TxtNombreDesarrollador.Text.Trim
                    .Parameters.Add("@PaginaWeb", SqlDbType.NVarChar, 100).Value = TxtPaginaWeb.Text.Trim
                    .ExecuteNonQuery()

                End With
                MessageBox.Show("Desarrollador modificado con éxito", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error al modificar el desarrollador" + ex.Message)

            Finally
                Con.Close()
            End Try
        End Using
    End Sub


    Private Sub EliminarDesarrollador()

        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using Cmd As New SqlCommand

            Try
                Con.Open()

                With Cmd
                    .CommandText = "Sp_EliminarDesarrollador"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@IdDesarrollador", SqlDbType.Int).Value = CInt(DgvDesarrollador.CurrentRow.Cells(0).Value)
                    .ExecuteNonQuery()

                End With
                MessageBox.Show("Desarrollador eliminado con éxito", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error al eliminar el desarrollador" + ex.Message)

            Finally
                Con.Close()
            End Try
        End Using
    End Sub

    Private Sub MostrarTodoDesarrollador()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_MostrarTodoDesarrollador"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                End With

                Dim AdaptadorDesarrollador As New SqlDataAdapter(cmd)
                Dim Dt As New DataTable
                AdaptadorDesarrollador.Fill(Dt)
                DgvDesarrollador.DataSource = Dt


            Catch ex As Exception
                MessageBox.Show("Error al mostrar los datos de los desarrolladores " + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub

    Private Sub FrmDesarrollador_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call HabilitarControles(True, False, False, False, False)
        Call MostrarTodoDesarrollador()

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click

        If ValidarDesarrollador() = True Then
            Call HabilitarControles(True, False, False, False, False)
            Call ActualizarDesarrollador()
            Call MostrarTodoDesarrollador()
            Call LimpiarDesarrollador()

        End If
    End Sub

    Private Sub LimpiarDesarrollador()

        TxtIdDesarrollador.Text = ""
        TxtNombreDesarrollador.Text = ""
        TxtPaginaWeb.Text = ""

    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        Call HabilitarControles(False, False, True, True, True)
        TxtIdDesarrollador.Text = DgvDesarrollador.CurrentRow.Cells(0).Value
        TxtNombreDesarrollador.Text = DgvDesarrollador.CurrentRow.Cells(1).Value.ToString
        TxtPaginaWeb.Text = DgvDesarrollador.CurrentRow.Cells(2).Value.ToString
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        If MessageBox.Show("¿Está seguro de eliminar el registro?", "Control Keeper",
           MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            Call HabilitarControles(True, False, False, False, False)
            Call EliminarDesarrollador()
            Call MostrarTodoDesarrollador()
        End If
    End Sub

    Private Sub BusquedaInteligenteDesarrollador()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_BusquedaDesarrollador"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@Parametro", SqlDbType.NVarChar, 50).Value = TxtBusqueda.Text.Trim
                    .Connection = Con
                End With

                Dim AdaptadorBusqueda As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                AdaptadorBusqueda.Fill(dt)
                DgvDesarrollador.DataSource = dt


            Catch ex As Exception
                MessageBox.Show("Error al mostrar los datos " + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub

    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        If TxtBusqueda.Text = Nothing Then
            MostrarTodoDesarrollador()
        Else
            BusquedaInteligenteDesarrollador()
        End If
    End Sub
End Class