Imports System.Data.SqlClient
Public Class FrmSoftwareComputadora
    Private Function ValidarSoftwareComputadora() As Boolean
        Dim Estado As Boolean
        If CboSerie.Text = Nothing Then
            MsgBox("Seleccione la serie de la computadora", MsgBoxStyle.Critical, "Control Keeper")
            Estado = False
        ElseIf CboSoftware.Text = Nothing Then
            MsgBox("Seleccione el Software a instalar", MsgBoxStyle.Critical, "Control Keeper")
            Estado = False
        ElseIf CboUsuario.Text = Nothing Then
            MsgBox("Seleccione el usuario de instalación del software", MsgBoxStyle.Critical, "Control Keeper")
            Estado = False
        Else
            Estado = True
        End If
        Return Estado
    End Function
    Private Sub FrmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HabilitarControles(True, False, False, False, False)
        Call MostrarTodasSoftwareComputadora()
        Call LlenarComboBoxSerie()
        Call LlenarComboBoxUsuario()
        Call LlenarComboBoxSoftware()
        Call Limpiar()
    End Sub
    Private Sub HabilitarControles(ByVal Nuevo As Boolean, ByVal Guardar As Boolean, ByVal Modificar As Boolean, ByVal Cancelar As Boolean, ByVal Panel As Boolean)
        BtnNuevo.Enabled = Nuevo
        BtnGuardar.Enabled = Guardar
        BtnModificar.Enabled = Modificar
        BtnCancelar.Enabled = Cancelar
        PlInstalacionSoftware.Enabled = Panel
    End Sub
    Private Sub MostrarTodasSoftwareComputadora()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_MostrarTodoSoftwareComputadora"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                End With

                Dim AdaptadorSoftwareComputadora As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                AdaptadorSoftwareComputadora.Fill(dt)
                DgvInstalacionSoftware.DataSource = dt
                DgvInstalacionSoftware.Columns(9).Visible = False
            Catch ex As Exception
                MessageBox.Show("Error al mostrar los datos de las instalaciones de software" + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Call HabilitarControles(False, True, False, True, True)
        Call Limpiar()
    End Sub


    Public Sub LlenarComboBoxSerie()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_MostrarSerieComputadora"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .ExecuteNonQuery()
                End With
                Dim AdaptadorComputadora As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                AdaptadorComputadora.Fill(ds, "Computadora")
                CboSerie.DataSource = ds.Tables(0)
                CboSerie.DisplayMember = ds.Tables(0).Columns("IdComputadora").ToString
                CboSerie.ValueMember = ds.Tables(0).Columns("IdComputadora").ToString

            Catch ex As Exception
                MessageBox.Show("Error al mostrar la serie de las computadoras " + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub
    Public Sub LlenarComboBoxUsuario()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_MostrarIdUsuario"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .ExecuteNonQuery()
                End With
                Dim AdaptadorUsuario As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                AdaptadorUsuario.Fill(ds, "Usuario")
                CboUsuario.DataSource = ds.Tables(0)
                CboUsuario.DisplayMember = ds.Tables(0).Columns("Usuario").ToString
                CboUsuario.ValueMember = ds.Tables(0).Columns("IdUsuario").ToString

            Catch ex As Exception
                MessageBox.Show("Error al mostrar los Usuario " + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub
    Private Function IdentificarEstadoInstalacion() As String
        Dim var As String
        If ChkEstado.CheckState = CheckState.Checked Then
            var = "Instalado"
        Else
            var = "No instalado"
        End If
        Return var
    End Function
    Public Sub LlenarComboBoxSoftware()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_MostrarSoftware"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .ExecuteNonQuery()
                End With
                Dim AdaptadorSoftware As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                AdaptadorSoftware.Fill(ds, "Softaware")
                CboSoftware.DataSource = ds.Tables(0)
                CboSoftware.DisplayMember = ds.Tables(0).Columns("Nombre").ToString
                CboSoftware.ValueMember = ds.Tables(0).Columns("IdSoftware").ToString

            Catch ex As Exception
                MessageBox.Show("Error al mostrar datos de software " + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub

    Private Sub GuardarComputadoraUsuario()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_InsertarSoftwareComputadora"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@IdComputadora", SqlDbType.NVarChar, 50).Value = CboSerie.SelectedValue
                    .Parameters.Add("@IdSoftware", SqlDbType.Int).Value = CInt(CboSoftware.SelectedValue)
                    .Parameters.Add("@Observacion", SqlDbType.NVarChar, 200).Value = TxtObservacion.Text.Trim
                    .Parameters.Add("@FechaInstalacion", SqlDbType.Date).Value = DtpFechaInstalacion.Text
                    .Parameters.Add("@IdUsuario", SqlDbType.Int).Value = CInt(CboUsuario.SelectedValue)
                    .Parameters.Add("@NumLicencia", SqlDbType.NVarChar, 50).Value = TxtLicencia.Text.Trim
                    .Parameters.Add("@FechaVencimiento", SqlDbType.Date).Value = DtpFechaVencimiento.Text
                    .Parameters.Add("@Estado", SqlDbType.NVarChar, 20).Value = IdentificarEstadoInstalacion()
                    .Parameters.Add("@FechaDesinstalacion", SqlDbType.Date).Value = DtpFechaDesinstalacion.Text
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Instalacion de software registrada con exito", "Control Keeper")
            Catch ex As Exception
                MessageBox.Show("Error al registrar la instalacion " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If ValidarSoftwareComputadora() = True Then
            If ExisteIdComputadora() = False Then
                Call GuardarComputadoraUsuario()
                Call MostrarTodasSoftwareComputadora()
                Call HabilitarControles(True, False, False, False, False)
                Call Limpiar()
            Else
                MessageBox.Show("Ya se encuentra instalado ese software en esa Computadora", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            End If
        End If


    End Sub
    Private Sub Limpiar()
        CboSerie.Text = Nothing
        CboUsuario.Text = Nothing
        CboSoftware.Text = Nothing
        TxtLicencia.Clear()
        TxtObservacion.Clear()
        DtpFechaDesinstalacion.ResetText()
        DtpFechaInstalacion.ResetText()
        DtpFechaVencimiento.ResetText()
        ChkEstado.Checked = False

    End Sub


    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        Call HabilitarControles(False, False, True, True, True)
        CboSerie.Enabled = False
        CboSoftware.Enabled = False
        CboSerie.Text = DgvInstalacionSoftware.CurrentRow.Cells(0).Value.ToString
        CboSoftware.Text = DgvInstalacionSoftware.CurrentRow.Cells(1).Value.ToString
        TxtObservacion.Text = DgvInstalacionSoftware.CurrentRow.Cells(2).Value.ToString
        DtpFechaInstalacion.Text = DgvInstalacionSoftware.CurrentRow.Cells(3).Value.ToString
        CboUsuario.Text = DgvInstalacionSoftware.CurrentRow.Cells(4).Value.ToString
        TxtLicencia.Text = DgvInstalacionSoftware.CurrentRow.Cells(5).Value.ToString
        DtpFechaVencimiento.Text = DgvInstalacionSoftware.CurrentRow.Cells(6).Value.ToString


        If DgvInstalacionSoftware.CurrentRow.Cells(7).Value.ToString = "Instalado" Then
            ChkEstado.Checked = True
        Else
            ChkEstado.Checked = False
        End If
        DtpFechaDesinstalacion.Text = DgvInstalacionSoftware.CurrentRow.Cells(8).Value.ToString

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Call HabilitarControles(True, False, False, False, False)
        Call Limpiar()
        CboSerie.Enabled = True

    End Sub
    Private Sub EditarComputadoraUsuario()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_ActualizarSoftwareComputadora"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@IdComputadora", SqlDbType.NVarChar, 50).Value = CboSerie.SelectedValue
                    .Parameters.Add("@IdSoftware", SqlDbType.Int).Value = CInt(CboSoftware.SelectedValue)
                    .Parameters.Add("@Observacion", SqlDbType.NVarChar, 200).Value = TxtObservacion.Text.Trim
                    .Parameters.Add("@FechaInstalacion", SqlDbType.Date).Value = DtpFechaInstalacion.Text
                    .Parameters.Add("@IdUsuario", SqlDbType.Int).Value = CInt(CboUsuario.SelectedValue)
                    .Parameters.Add("@NumLicencia", SqlDbType.NVarChar, 50).Value = TxtLicencia.Text.Trim
                    .Parameters.Add("@FechaVencimiento", SqlDbType.Date).Value = DtpFechaVencimiento.Text
                    .Parameters.Add("@Estado", SqlDbType.NVarChar, 20).Value = IdentificarEstadoInstalacion()
                    .Parameters.Add("@FechaDesinstalacion", SqlDbType.Date).Value = DtpFechaDesinstalacion.Text
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Instalacion de software editada con exito", "Control Keeper")
            Catch ex As Exception
                MessageBox.Show("Error al Editar la instalacion " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using
    End Sub
    Private Sub EliminarComputadoraUsuario()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_EliminarSoftwareComputadora"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .Parameters.Add("@IdComputadora", SqlDbType.NVarChar, 50).Value = DgvInstalacionSoftware.CurrentRow.Cells(0).Value.ToString.Trim
                    .Parameters.Add("@IdSoftware", SqlDbType.Int).Value = CInt(DgvInstalacionSoftware.CurrentRow.Cells(9).Value.ToString.Trim)
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Instalacion de software eliminada con exito", "Control Keeper")
            Catch ex As Exception
                MessageBox.Show("Error al eliminar la instalación " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If ValidarSoftwareComputadora() = True Then
            Call EditarComputadoraUsuario()
            Call HabilitarControles(True, False, False, False, False)
            Call Limpiar()
            Call MostrarTodasSoftwareComputadora()
            CboSoftware.Enabled = True
            CboSerie.Enabled = True
        End If

    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        If MessageBox.Show("¿Está seguro de eliminar el registro?", "Control Keeper",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            Call EliminarComputadoraUsuario()
            Call MostrarTodasSoftwareComputadora()
        End If
    End Sub


    Private Function ExisteIdComputadora() As Boolean
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Dim Valor As Boolean
        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_ExisteSoftwareComputadora"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .Parameters.Add("@IdComputadora", SqlDbType.NVarChar, 50).Value = CboSerie.SelectedValue
                    .Parameters.Add("@IdSoftware", SqlDbType.Int).Value = CInt(CboSoftware.SelectedValue)
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


    Private Sub ChkEstado_CheckedChanged(sender As Object, e As EventArgs) Handles ChkEstado.CheckedChanged
        If ChkEstado.CheckState = CheckState.Checked Then
            ChkEstado.Text = "Instalado"
        Else
            ChkEstado.Text = "No instalado"
        End If
    End Sub

    Private Sub BtnAbrirFrmComputadora_Click(sender As Object, e As EventArgs) Handles BtnAbrirFrmComputadora.Click
        FrmComputadora.MdiParent = MDIControlKeeper
        FrmComputadora.Var = 2
        FrmComputadora.Location = New Point(320, 110)
        FrmComputadora.Show()

    End Sub

    Private Sub BtnAbrirFrmSoftware_Click(sender As Object, e As EventArgs) Handles BtnAbrirFrmSoftware.Click
        FrmSoftware.MdiParent = MDIControlKeeper
        FrmSoftware.var = 1
        FrmSoftware.Location = New Point(130, 110)
        FrmSoftware.Show()
    End Sub

    Private Sub BtnAbrirFrmUsuario_Click(sender As Object, e As EventArgs) Handles BtnAbrirFrmUsuario.Click
        FrmUsuario.MdiParent = MDIControlKeeper
        FrmUsuario.Var = 2
        FrmUsuario.Location = New Point(330, 110)
        FrmUsuario.Show()

    End Sub

    Private Sub BusquedaInteligenteSoftwareComputadora()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_BusquedaSoftwareComputadora"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@Parametro", SqlDbType.NVarChar, 50).Value = TxtBusqueda.Text.Trim
                    .Connection = Con
                End With

                Dim AdaptadorBusqueda As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                AdaptadorBusqueda.Fill(dt)
                DgvInstalacionSoftware.DataSource = dt
                DgvInstalacionSoftware.Columns(9).Visible = False

            Catch ex As Exception
                MessageBox.Show("Error al mostrar los datos " + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub

    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        If TxtBusqueda.Text = Nothing Then
            MostrarTodasSoftwareComputadora()
        Else
            BusquedaInteligenteSoftwareComputadora()
        End If
    End Sub
End Class