Imports System.Data.SqlClient
Public Class FrmLogAuditoria
    Private Sub MostrarTodosLogAuditoria()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_MostrarTodoLogAuditoria"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                End With

                Dim AdaptadorLog As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                AdaptadorLog.Fill(dt)
                DgvLogAuditoria.DataSource = dt

            Catch ex As Exception
                MessageBox.Show("Error al mostrar los datos del log de auditoria" + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub
    Private Sub BusquedaFiltradasLogAuditoria()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_BusquedaLogAuditoria"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@Parametro", SqlDbType.NVarChar, 50).Value = TxtBusqueda.Text.Trim
                    .Connection = Con
                End With

                Dim AdaptadorBusqueda As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                AdaptadorBusqueda.Fill(dt)
                DgvLogAuditoria.DataSource = dt


            Catch ex As Exception
                MessageBox.Show("Error al mostrar los datos " + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub

    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        If TxtBusqueda.Text = Nothing Then
            MostrarTodosLogAuditoria()
        Else
            BusquedaFiltradasLogAuditoria()
        End If
    End Sub

    Private Sub FrmLogAuditoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarTodosLogAuditoria()
    End Sub
End Class