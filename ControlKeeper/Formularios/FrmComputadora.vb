Imports System.Data.SqlClient
Public Class FrmComputadora
    Public Var As Integer = 0

    Private Function ValidarComputadora() As Boolean
        Dim Estado As Boolean
        If TxtSerie.Text = Nothing Then
            MsgBox("Ingrese la serie de la computadora", MsgBoxStyle.Critical, "Control Keeper")
            TxtSerie.Focus()
            Estado = False
        ElseIf CboMarca.Text = Nothing Then
            MsgBox("Seleccione la marca de la computadora", MsgBoxStyle.Critical, "Control Keeper")
            Estado = False
        ElseIf CboModelo.Text = Nothing Then
            MsgBox("Seleccione el modelo de la computadora", MsgBoxStyle.Critical, "Control Keeper")
            Estado = False
        ElseIf CboAño.Text = Nothing Then
            MsgBox("Seleccione el año de la computadora", MsgBoxStyle.Critical, "Control Keeper")
            Estado = False
        ElseIf CboRAM.Text = Nothing Then
            MsgBox("Seleccione el tamaño de la memoria RAM de la computadora", MsgBoxStyle.Critical, "Control Keeper")
            Estado = False
        ElseIf CboTipoComputadora.Text = Nothing Then
            MsgBox("Seleccione el tipo de computadora", MsgBoxStyle.Critical, "Control Keeper")
            Estado = False
        ElseIf CboCapacidadDiscoDuro.Text = Nothing Then
            MsgBox("Seleccione la capacidad del disco duro de la computadora", MsgBoxStyle.Critical, "Control Keeper")
            Estado = False
        Else
            Estado = True
        End If
        Return Estado
    End Function
    Private Sub FrmComputadora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HabilitarControles(True, False, False, False, False)
        Call MostrarTodasComputadoras()
        Call LlenarComboBoxCapacidadRAM()
        Call LlenarComboBoxCapacidadDiscoDuro()
        Call LlenarComboBoxMarca()
        Call LlenarComboBoxAño()
        Call LlenarComboBoxTipoComputadora()
        Call Limpiar()
    End Sub
    Private Sub HabilitarControles(ByVal Nuevo As Boolean, ByVal Guardar As Boolean, ByVal Modificar As Boolean, ByVal Cancelar As Boolean, ByVal Panel As Boolean)
        BtnNuevo.Enabled = Nuevo
        BtnGuardar.Enabled = Guardar
        BtnModificar.Enabled = Modificar
        BtnCancelar.Enabled = Cancelar
        PlComputadora.Enabled = Panel
    End Sub
    Private Sub MostrarTodasComputadoras()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_MostrarTodoComputadora"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                End With

                Dim AdaptadorComputadora As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                AdaptadorComputadora.Fill(dt)
                DgvComputadora.DataSource = dt
                DgvComputadora.Columns(9).Visible = False
            Catch ex As Exception
                MessageBox.Show("Error al mostrar los datos de las Computadoras " + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Call HabilitarControles(False, True, False, True, True)
        Call Limpiar()
    End Sub
    Private Sub LlenarComboBoxCapacidadRAM()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_MostrarTodoCapacidadMemoriaRAM"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .ExecuteNonQuery()
                End With
                Dim AdaptadorCapacidadMemoriaRAM As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                AdaptadorCapacidadMemoriaRAM.Fill(ds, "CapacidadMemoriaRAM")
                CboRAM.DataSource = ds.Tables(0)
                CboRAM.DisplayMember = ds.Tables(0).Columns("CapacidadMemoriaRAM").ToString
                CboRAM.ValueMember = ds.Tables(0).Columns("IdCapacidadMemoriaRAM").ToString

            Catch ex As Exception
                MessageBox.Show("Error al mostrar capacidad de memoria RAM" + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub

    Private Sub LlenarComboBoxCapacidadDiscoDuro()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_MostrarTodoCapacidadDiscoDuro"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .ExecuteNonQuery()
                End With
                Dim AdaptadorCapacidadDiscoDuro As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                AdaptadorCapacidadDiscoDuro.Fill(ds, "CapacidadDiscoDuro")
                CboCapacidadDiscoDuro.DataSource = ds.Tables(0)
                CboCapacidadDiscoDuro.DisplayMember = ds.Tables(0).Columns("CapacidadDiscoDuro").ToString
                CboCapacidadDiscoDuro.ValueMember = ds.Tables(0).Columns("IdCapacidadDiscoDuro").ToString

            Catch ex As Exception
                MessageBox.Show("Error al mostrar capacidad de disco duro " + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
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
                Dim ds As New DataSet
                AdaptadorMarca.Fill(ds, "Marca")
                CboMarca.DataSource = ds.Tables(0)
                CboMarca.DisplayMember = ds.Tables(0).Columns("Marca").ToString
                CboMarca.ValueMember = ds.Tables(0).Columns("IdMarca").ToString

            Catch ex As Exception
                MessageBox.Show("Error al mostrar las marcas de computadora " + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub
    Private Sub LlenarComboBoxTipoComputadora()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_MostrarTodoTipoComputadora"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .ExecuteNonQuery()
                End With
                Dim AdaptadorTipoComputadora As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                AdaptadorTipoComputadora.Fill(ds, "TipoComputadora")
                CboTipoComputadora.DataSource = ds.Tables(0)
                CboTipoComputadora.DisplayMember = ds.Tables(0).Columns("TipoComputadora").ToString
                CboTipoComputadora.ValueMember = ds.Tables(0).Columns("IdTipoComputadora").ToString

            Catch ex As Exception
                MessageBox.Show("Error al mostrar las tipos de computadoras " + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub
    Private Sub LlenarComboBoxAño()
        For i As Integer = 1950 To 2100
            CboAño.Items.Add(i.ToString)
        Next
    End Sub
    Private Function IdentificarMouse() As Integer
        Dim var As Integer
        If ChkMouse.CheckState = CheckState.Checked Then
            var = 1
        Else
            var = 0
        End If
        Return var
    End Function
    Private Function IdentificarTeclado() As Integer
        Dim var As Integer
        If ChkTeclado.CheckState = CheckState.Checked Then
            var = 1
        Else
            var = 0
        End If
        Return var
    End Function
    Private Function IdentificarEstadoAsignacion() As String
        Dim var As String
        If ChkEstado.CheckState = CheckState.Checked Then
            var = "Asignada"
        Else
            var = "No Asignada"
        End If
        Return var
    End Function
    Private Sub GuardarComputadora()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_InsertarComputadora"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@IdComputadora", SqlDbType.NVarChar, 50).Value = TxtSerie.Text.Trim
                    .Parameters.Add("@IdModelo", SqlDbType.Int).Value = CInt(CboModelo.SelectedValue)
                    .Parameters.Add("@IdCapacidadDiscoDuro", SqlDbType.Int).Value = CInt(CboCapacidadDiscoDuro.SelectedValue)
                    .Parameters.Add("@IdCapacidadMemoriaRAM", SqlDbType.Int).Value = CInt(CboRAM.SelectedValue)
                    .Parameters.Add("@AñoComputadora", SqlDbType.NVarChar, 10).Value = CboAño.SelectedItem
                    .Parameters.Add("@IdTipoComputadora", SqlDbType.Int).Value = CInt(CboTipoComputadora.SelectedValue)
                    .Parameters.Add("@Estado", SqlDbType.NVarChar, 20).Value = IdentificarEstadoAsignacion()
                    .Parameters.Add("@Mouse", SqlDbType.Bit).Value = IdentificarMouse()
                    .Parameters.Add("@Teclado", SqlDbType.Bit).Value = IdentificarTeclado()
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Computadora registrada con exito", "Control Keeper")
            Catch ex As Exception
                MessageBox.Show("Error al guardar la computadora " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If ValidarComputadora() = True Then
            If ExisteIdComputadora() = False Then
                Call GuardarComputadora()
                Call MostrarTodasComputadoras()
                Call HabilitarControles(True, False, False, False, False)
                Call Limpiar()
            Else
                MessageBox.Show("Ya se encuentra registrado esa Computadora", "Control Keeper", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            End If
        End If


    End Sub
    Private Sub Limpiar()
        TxtSerie.Clear()
        CboCapacidadDiscoDuro.Text = Nothing
        CboRAM.Text = Nothing
        CboMarca.Text = Nothing
        CboModelo.Text = Nothing
        CboAño.Text = Nothing
        CboTipoComputadora.Text = Nothing
        ChkEstado.Checked = False
        ChkMouse.Checked = False
        ChkTeclado.Checked = False
    End Sub


    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        Call HabilitarControles(False, False, True, True, True)
        TxtSerie.Enabled = False
        TxtSerie.Text = DgvComputadora.CurrentRow.Cells(0).Value.ToString
        CboAño.Text = DgvComputadora.CurrentRow.Cells(1).Value.ToString
        CboMarca.Text = DgvComputadora.CurrentRow.Cells(9).Value.ToString
        CboModelo.Text = DgvComputadora.CurrentRow.Cells(2).Value.ToString
        CboCapacidadDiscoDuro.Text = DgvComputadora.CurrentRow.Cells(3).Value.ToString
        CboRAM.Text = DgvComputadora.CurrentRow.Cells(4).Value.ToString
        CboTipoComputadora.Text = DgvComputadora.CurrentRow.Cells(5).Value.ToString
        If DgvComputadora.CurrentRow.Cells(6).Value.ToString = "Asignada" Then
            ChkEstado.Checked = True
        Else
            ChkEstado.Checked = False
        End If
        If DgvComputadora.CurrentRow.Cells(7).Value.ToString = "True" Then
            ChkMouse.Checked = True
        Else
            ChkMouse.Checked = False
        End If
        If DgvComputadora.CurrentRow.Cells(8).Value.ToString = "True" Then
            ChkTeclado.Checked = True
        Else
            ChkTeclado.Checked = False
        End If

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Call HabilitarControles(True, False, False, False, False)
        Call Limpiar()
        TxtSerie.Enabled = True
    End Sub
    Private Sub EditarComputadora()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_ActualizarComputadora"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con

                    .Parameters.Add("@IdComputadora", SqlDbType.NVarChar, 50).Value = TxtSerie.Text.Trim
                    .Parameters.Add("@IdModelo", SqlDbType.Int).Value = CInt(CboModelo.SelectedValue)
                    .Parameters.Add("@IdCapacidadDiscoDuro", SqlDbType.Int).Value = CInt(CboCapacidadDiscoDuro.SelectedValue)
                    .Parameters.Add("@IdCapacidadMemoriaRAM", SqlDbType.Int).Value = CInt(CboRAM.SelectedValue)
                    .Parameters.Add("@AñoComputadora", SqlDbType.NVarChar, 10).Value = CboAño.SelectedItem
                    .Parameters.Add("@IdTipoComputadora", SqlDbType.Int).Value = CInt(CboTipoComputadora.SelectedValue)
                    .Parameters.Add("@Estado", SqlDbType.NVarChar, 20).Value = IdentificarEstadoAsignacion()
                    .Parameters.Add("@Mouse", SqlDbType.Bit).Value = IdentificarMouse()
                    .Parameters.Add("@Teclado", SqlDbType.Bit).Value = IdentificarTeclado()
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Computadora editada con exito", "Control Keeper")
            Catch ex As Exception
                MessageBox.Show("Error al editar la computadora " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using

    End Sub
    Private Sub EliminarComputadora()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_EliminarComputadora"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .Parameters.Add("@IdComputadora", SqlDbType.NVarChar, 50).Value = DgvComputadora.CurrentRow.Cells(0).Value.ToString.Trim
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Computadora eliminada con exito", "Control Keeper")
            Catch ex As Exception
                MessageBox.Show("Error al eliminar la computadora " + ex.Message)
            Finally
                Con.Close()
            End Try
        End Using

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If ValidarComputadora() = True Then
            Call EditarComputadora()
            Call HabilitarControles(True, False, False, False, False)
            Call Limpiar()
            Call MostrarTodasComputadoras()
            TxtSerie.Enabled = True
        End If

    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        If MessageBox.Show("¿Está seguro de eliminar el registro?", "Control Keeper",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            Call EliminarComputadora()
            Call MostrarTodasComputadoras()
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
                    .CommandText = "Sp_ExisteIdComputadora"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .Parameters.Add("@IdComputadora", SqlDbType.NVarChar, 50).Value = TxtSerie.Text.Trim
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
    Private Sub LlenarComboBoxModelo(ByVal IdMarca As Integer)
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_MostrarModelosxMarca"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Con
                    .Parameters.Add("@IdMarca", SqlDbType.Int).Value = IdMarca
                    .ExecuteNonQuery()
                End With
                Dim AdaptadorModelo As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                AdaptadorModelo.Fill(ds, "Modelo")
                CboModelo.DataSource = ds.Tables(0)
                CboModelo.DisplayMember = ds.Tables(0).Columns("Modelo").ToString
                CboModelo.ValueMember = ds.Tables(0).Columns("IdModelo").ToString

            Catch ex As Exception
                MessageBox.Show("Error al mostrar las modelo de computadora " + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub

    Private Sub ChkEstado_CheckedChanged(sender As Object, e As EventArgs) Handles ChkEstado.CheckedChanged
        If ChkEstado.CheckState = CheckState.Checked Then
            ChkEstado.Text = "Asignada"
        Else
            ChkEstado.Text = "No Asignada"
        End If
    End Sub

    Private Sub CboMarca_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboMarca.SelectedIndexChanged
        If IsNumeric(CboMarca.SelectedValue) Then
            CboModelo.Enabled = True
            LlenarComboBoxModelo(CInt(CboMarca.SelectedValue))
        Else
            CboModelo.Enabled = False
        End If

    End Sub


    Private Sub DgvComputadora_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvComputadora.CellDoubleClick
        If Var = 1 Then
            FrmComputadoraUsuario.LlenarComboBoxSerie()
            FrmComputadoraUsuario.CboSerie.Text = DgvComputadora.CurrentRow.Cells(0).Value.ToString
            Me.Close()
        ElseIf Var = 2 Then
            FrmSoftwareComputadora.LlenarComboBoxSerie()
            FrmSoftwareComputadora.CboSerie.Text = DgvComputadora.CurrentRow.Cells(0).Value.ToString
            Me.Close()
        End If
    End Sub
    Private Sub BusquedaFiltradasComputadora()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Using cmd As New SqlCommand
            Try
                Con.Open()
                With cmd
                    .CommandText = "Sp_BusquedaComputadora"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@Parametro", SqlDbType.NVarChar, 50).Value = TxtBusqueda.Text.Trim
                    .Connection = Con
                End With

                Dim AdaptadorBusqueda As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                AdaptadorBusqueda.Fill(dt)
                DgvComputadora.DataSource = dt
                DgvComputadora.Columns(9).Visible = False


            Catch ex As Exception
                MessageBox.Show("Error al mostrar los datos " + ex.Message)
            Finally
                Con.Close()
            End Try

        End Using
    End Sub

    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        If TxtBusqueda.Text = Nothing Then
            MostrarTodasComputadoras()
        Else
            BusquedaFiltradasComputadora()
        End If
    End Sub
End Class