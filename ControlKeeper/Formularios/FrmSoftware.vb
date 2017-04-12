Imports System.Data.SqlClient
Public Class FrmSoftware

    Public var As Integer = 0
    Private Sub FrmSoftware_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HabilitarControles(True, False, False, False, False)
        Call MostrarTodoSoftware()
        Call LlenarComboBoxDesarrollador()
        Call LlenarComboBoxTipoSoftware()
        Call Limpiar()
    End Sub
    Private Sub HabilitarControles(ByVal Nuevo As Boolean, ByVal Guardar As Boolean, ByVal Modificar As Boolean, ByVal Cancelar As Boolean, ByVal Panel As Boolean)
        BtnNuevo.Enabled = Nuevo
        BtnGuardar.Enabled = Guardar
        BtnModificar.Enabled = Modificar
        BtnCancelar.Enabled = Cancelar
        PnlSoftware.Enabled = Panel
    End Sub

    Private Sub MostrarTodoSoftware()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_MostrarTodoSoftware"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                End With

                Dim AdaptadorUsuario As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                AdaptadorUsuario.Fill(dt)
                DgvSoftware.DataSource = dt


            Catch ex As Exception
                MessageBox.Show("Error al mostrar los datos de los Softwares " + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Call HabilitarControles(False, True, False, True, True)
        Call Limpiar()
        Call InvestigarCorrelativoSoftware()
    End Sub
    Private Sub LlenarComboBoxDesarrollador()
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
                    .ExecuteNonQuery()
                End With
                Dim AdaptadorDesarrollador As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                AdaptadorDesarrollador.Fill(ds, "Desarrollador")
                CboEditor.DataSource = ds.Tables(0)
                CboEditor.DisplayMember = ds.Tables(0).Columns("NombreDesarrollador").ToString
                CboEditor.ValueMember = ds.Tables(0).Columns("IdDesarrollador").ToString

            Catch ex As Exception
                MessageBox.Show("Error al mostrar los datos de los desarrolladores" + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub

    Private Sub GuardarSfotware()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_InsertarSoftware"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@Nombre", SqlDbType.NVarChar, 50).Value = TxtNombreSoftware.Text.Trim
                    .Parameters.Add("@Descripcion", SqlDbType.NVarChar, 50).Value = TxtDescripcion.Text.Trim
                    .Parameters.Add("@IdDesarrollador", SqlDbType.Int).Value = CInt(CboEditor.SelectedValue)
                    .Parameters.Add("@Versionsoftware", SqlDbType.VarChar, 20).Value = TxtVersion.Text.Trim
                    .Parameters.Add("@IdTipoSoftware", SqlDbType.Int).Value = CInt(CboEditor.SelectedValue)
                    .Parameters.Add("@Tamano", SqlDbType.NVarChar, 50).Value = TxtTamaño.Text
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Software Registrado con éxito", "Control Keeper")
            Catch ex As Exception
                MessageBox.Show("Error al guardar el software" + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using



    End Sub

    Private Sub LlenarComboBoxTipoSoftware()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_MostrarTodoTipoSoftware"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .ExecuteNonQuery()
                End With
                Dim AdaptadorTipoUsuario As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                AdaptadorTipoUsuario.Fill(ds, "TipoSoftware")
                CboTipoSoftware.DataSource = ds.Tables(0)
                CboTipoSoftware.DisplayMember = ds.Tables(0).Columns("TipoSoftware").ToString
                CboTipoSoftware.ValueMember = ds.Tables(0).Columns("IdTiposoftware").ToString

            Catch ex As Exception
                MessageBox.Show("Error al mostrar tipo usuario " + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        If ValidarSoftware() = True Then

            If ExisteNombreSoftware() = False Then
                Call GuardarSfotware()
                Call MostrarTodoSoftware()
                Call HabilitarControles(True, False, False, False, False)
                Call Limpiar()
            Else
                MessageBox.Show("Ya se encuentra registrado ese software", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            End If
        End If

    End Sub
    Private Sub Limpiar()
        TxtCodigoSoftware.Text = ""
        TxtDescripcion.Text = ""
        TxtNombreSoftware.Text = ""
        CboEditor.Text = Nothing
        TxtTamaño.Text = ""
        TxtVersion.Text = ""
        CboTipoSoftware.Text = Nothing
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        Call HabilitarControles(False, False, True, True, True)
        TxtCodigoSoftware.Text = DgvSoftware.CurrentRow.Cells(0).Value
        TxtNombreSoftware.Text = DgvSoftware.CurrentRow.Cells(1).Value.ToString
        TxtDescripcion.Text = DgvSoftware.CurrentRow.Cells(2).Value.ToString
        CboEditor.Text = DgvSoftware.CurrentRow.Cells(6).Value.ToString
        TxtVersion.Text = DgvSoftware.CurrentRow.Cells(3).Value.ToString
        CboTipoSoftware.Text = DgvSoftware.CurrentRow.Cells(5).Value.ToString
        TxtTamaño.Text = DgvSoftware.CurrentRow.Cells(4).Value.ToString
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Call HabilitarControles(True, False, False, False, False)
        Call Limpiar()
    End Sub
    Private Sub EditarSoftware()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_ActualizarSoftware"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@IdSoftware", SqlDbType.Int).Value = CInt(TxtCodigoSoftware.Text)
                    .Parameters.Add("@Nombre", SqlDbType.NVarChar, 50).Value = TxtNombreSoftware.Text.Trim
                    .Parameters.Add("@Descripcion", SqlDbType.NVarChar, 50).Value = TxtDescripcion.Text.Trim
                    .Parameters.Add("@IdDesarrollador", SqlDbType.Int).Value = CInt(CboEditor.SelectedValue)
                    .Parameters.Add("@VersionSoftware", SqlDbType.NVarChar, 50).Value = TxtVersion.Text.Trim
                    .Parameters.Add("@IdTipoSoftware", SqlDbType.Int).Value = CInt(CboTipoSoftware.SelectedValue)
                    .Parameters.Add("@Tamano", SqlDbType.NVarChar, 50).Value = TxtTamaño.Text.Trim
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Software editado con éxito", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error al editar el software " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using

    End Sub
    Private Sub EliminarSoftware()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_EliminarSoftware"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@IdSoftware", SqlDbType.Int).Value = CInt(DgvSoftware.CurrentRow.Cells(0).Value)
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("software eliminado con éxito", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error al eliminar el software " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click

        If ValidarSoftware() = True Then

            If ExisteNombreSoftware() = False Then

                Call EditarSoftware()
                Call HabilitarControles(True, False, False, False, False)
                Call Limpiar()
                Call MostrarTodoSoftware()

            Else
                MessageBox.Show("Ya se encuentra registrado ese software", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If

        End If
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click

        If MessageBox.Show("¿Está seguro de eliminar el registro?", "Control Keeper",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then

            Call HabilitarControles(True, False, False, False, False)

            Call EliminarSoftware()
            Call MostrarTodoSoftware()
        End If
    End Sub

    Private Sub InvestigarCorrelativoSoftware()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If
        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_CorrelativoSoftware"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                End With
                Dim LectorCorrelativo As SqlDataReader
                LectorCorrelativo = cmd.ExecuteReader

                If LectorCorrelativo.Read Then
                    If LectorCorrelativo("Id") Is DBNull.Value Then
                        TxtCodigoSoftware.Text = 1
                    Else
                        TxtCodigoSoftware.Text = LectorCorrelativo("Id").ToString
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Con.Close()
            End Try
        End Using
    End Sub
    Private Function ExisteNombreSoftware() As Boolean
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Dim Valor As Boolean
        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_ExisteNombreSoftware"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .Parameters.Add("@Nombre", SqlDbType.NVarChar, 50).Value = TxtNombreSoftware.Text.Trim
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

    Private Function ValidarSoftware() As Boolean

        Dim Estado As Boolean

        If TxtDescripcion.Text = Nothing And TxtNombreSoftware.Text = Nothing And TxtTamaño.Text = Nothing And TxtVersion.Text = Nothing And CboEditor.Text = Nothing And CboTipoSoftware.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar todos los campos", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtNombreSoftware.Text = Nothing And TxtTamaño.Text = Nothing And TxtVersion.Text = Nothing And CboEditor.Text = Nothing And CboTipoSoftware.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar todos los campos", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtDescripcion.Text = Nothing And TxtTamaño.Text = Nothing And TxtVersion.Text = Nothing And CboEditor.Text = Nothing And CboTipoSoftware.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar todos los campos", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtDescripcion.Text = Nothing And TxtNombreSoftware.Text = Nothing And TxtVersion.Text = Nothing And CboEditor.Text = Nothing And CboTipoSoftware.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar todos los campos", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtDescripcion.Text = Nothing And TxtNombreSoftware.Text = Nothing And TxtTamaño.Text = Nothing And CboEditor.Text = Nothing And CboTipoSoftware.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar todos los campos", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtDescripcion.Text = Nothing And TxtNombreSoftware.Text = Nothing And TxtTamaño.Text = Nothing And TxtVersion.Text = Nothing And CboTipoSoftware.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar todos los campos", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtDescripcion.Text = Nothing And TxtNombreSoftware.Text = Nothing And TxtTamaño.Text = Nothing And TxtVersion.Text = Nothing And CboEditor.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar todos los campos", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtTamaño.Text = Nothing And TxtVersion.Text = Nothing And CboEditor.Text = Nothing And CboTipoSoftware.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar todos los campos", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtDescripcion.Text = Nothing And TxtVersion.Text = Nothing And CboEditor.Text = Nothing And CboTipoSoftware.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar todos los campos", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtDescripcion.Text = Nothing And TxtNombreSoftware.Text = Nothing And CboEditor.Text = Nothing And CboTipoSoftware.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar todos los campos", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtDescripcion.Text = Nothing And TxtNombreSoftware.Text = Nothing And TxtTamaño.Text = Nothing And CboTipoSoftware.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar todos los campos", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtDescripcion.Text = Nothing And TxtNombreSoftware.Text = Nothing And TxtTamaño.Text = Nothing And TxtVersion.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar todos los campos", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtVersion.Text = Nothing And CboEditor.Text = Nothing And CboTipoSoftware.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar todos los campos", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtDescripcion.Text = Nothing And CboEditor.Text = Nothing And CboTipoSoftware.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar todos los campos", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtDescripcion.Text = Nothing And TxtNombreSoftware.Text = Nothing And CboTipoSoftware.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar todos los campos", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtDescripcion.Text = Nothing And TxtNombreSoftware.Text = Nothing And TxtTamaño.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar todos los campos", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf CboEditor.Text = Nothing And CboTipoSoftware.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar todos los campos", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtDescripcion.Text = Nothing And CboTipoSoftware.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar todos los campos", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtDescripcion.Text = Nothing And TxtNombreSoftware.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar todos los campos", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtDescripcion.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar la descripción", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtNombreSoftware.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar el nombre del software", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtTamaño.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar el tamaño del software", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf TxtVersion.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar la versión del software", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf CboEditor.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar seleccionar el editor del software", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        ElseIf CboTipoSoftware.Text = Nothing Then

            MessageBox.Show("Tiene que ingresar seleccionar el tipo de software", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Estado = False

        Else
            Estado = True


        End If

        Return Estado

    End Function



    Private Sub DgvSoftware_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvSoftware.CellDoubleClick
        If var = 1 Then
            FrmSoftwareComputadora.LlenarComboBoxSoftware()
            FrmSoftwareComputadora.CboSerie.Text = DgvSoftware.CurrentRow.Cells(1).Value.ToString
            Me.Close()
        End If
    End Sub
End Class