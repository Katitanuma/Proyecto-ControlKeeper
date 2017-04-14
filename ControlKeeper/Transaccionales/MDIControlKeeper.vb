Imports System.ComponentModel
Imports System.Windows.Forms

Public Class MDIControlKeeper

    Private Sub MDIControlKeeper_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PnlMenu.Hide()
        PbTitulo.Visible = False
    End Sub

    Private Sub PbMenu_Click(sender As Object, e As EventArgs) Handles PbMenu.Click
        PnlMenu.Show()
        Call LocalizacionFormularios()
    End Sub

    Private Sub PnlInteraccion_MouseEnter(sender As Object, e As EventArgs) Handles PnlInteraccion.MouseEnter
        PnlMenu.Show()
        Call LocalizacionFormularios()
    End Sub

    Private Sub PnlInteraccion_MouseLeave(sender As Object, e As EventArgs) Handles PnlInteraccion.MouseLeave
        PnlMenu.Hide()
        Call LocalizacionFormulariosOcultadoPanel()
    End Sub

    Private Sub LocalizacionFormularios()
        FrmUsuario.Location = New Point(400, 110)
        FrmEmpleado.Location = New Point(238, 100)
        FrmCapacidadDiscoDuro.Location = New Point(450, 110)
        FrmCapacidadRAM.Location = New Point(450, 110)
        FrmCiudad.Location = New Point(450, 110)
        FrmComputadora.Location = New Point(400, 100)
        FrmComputadoraUsuario.Location = New Point(400, 110)
        FrmDepartamento.Location = New Point(450, 110)
        FrmDesarrollador.Location = New Point(400, 110)
        FrmTipoSoftware.Location = New Point(450, 110)
        FrmLogAuditoria.Location = New Point(400, 140)
        FrmMantenimiento.Location = New Point(380, 110)
        FrmMarca.Location = New Point(450, 110)
        FrmModelo.Location = New Point(415, 105)
        FrmProfesion.Location = New Point(400, 110)
        FrmSoftwareComputadora.Location = New Point(238, 95)
        FrmSoftware.Location = New Point(238, 95)
    End Sub

    Private Sub LocalizacionFormulariosOcultadoPanel()
        FrmUsuario.Location = New Point(330, 110)
        FrmEmpleado.Location = New Point(145, 85)
        FrmTipoSoftware.Location = New Point(375, 110)
        FrmDesarrollador.Location = New Point(315, 110)
        FrmSoftware.Location = New Point(130, 110)
        FrmComputadoraUsuario.Location = New Point(330, 110)
        FrmSoftwareComputadora.Location = New Point(120, 110)
        FrmCapacidadDiscoDuro.Location = New Point(375, 110)
        FrmModelo.Location = New Point(345, 110)
        FrmMarca.Location = New Point(380, 110)
        FrmComputadora.Location = New Point(320, 100)
        FrmMantenimiento.Location = New Point(280, 110)
        FrmCapacidadRAM.Location = New Point(375, 110)
        FrmCiudad.Location = New Point(385, 110)
        FrmEmpleado.Location = New Point(120, 110)
        FrmDepartamento.Location = New Point(375, 110)
        FrmProfesion.Location = New Point(330, 110)
        FrmLogAuditoria.Location = New Point(330, 140)
    End Sub

    Private Sub BtnOcultar_Click(sender As Object, e As EventArgs) Handles BtnOcultar.Click
        PnlMenu.Hide()
        Call LocalizacionFormulariosOcultadoPanel()
    End Sub

    Private Sub BtnUsuario_Click(sender As Object, e As EventArgs) Handles BtnUsuario.Click
        PnlLogo.Visible = False
        PbTitulo.Visible = True
        FrmUsuario.MdiParent = Me
        PnlMenu.Hide()
        FrmUsuario.Location = New Point(330, 110)
        FrmUsuario.Show()
    End Sub

    Private Sub BtnEmpleado_Click(sender As Object, e As EventArgs)
        PnlLogo.Visible = False
        PbTitulo.Visible = True
        FrmEmpleado.MdiParent = Me
        PnlMenu.Hide()
        FrmEmpleado.Location = New Point(145, 85)
        FrmEmpleado.Show()
    End Sub


    Private Sub BtnTipoSoftware_Click(sender As Object, e As EventArgs) Handles BtnTipoSoftware.Click
        PnlLogo.Visible = False
        PbTitulo.Visible = True
        FrmTipoSoftware.MdiParent = Me
        PnlMenu.Hide()
        FrmTipoSoftware.Location = New Point(375, 110)
        FrmTipoSoftware.Show()
    End Sub

    Private Sub BtnDesarrollador_Click(sender As Object, e As EventArgs) Handles BtnDesarrollador.Click
        PnlLogo.Visible = False
        PbTitulo.Visible = True
        FrmDesarrollador.MdiParent = Me
        PnlMenu.Hide()
        FrmDesarrollador.Location = New Point(315, 110)
        FrmDesarrollador.Show()
    End Sub

    Private Sub BtnSoftware_Click(sender As Object, e As EventArgs) Handles BtnSoftware.Click
        PnlLogo.Visible = False
        PbTitulo.Visible = True
        FrmSoftware.MdiParent = Me
        PnlMenu.Hide()
        FrmSoftware.Location = New Point(130, 110)
        FrmSoftware.Show()
    End Sub

    Private Sub BtnComputadoraUsuario_Click(sender As Object, e As EventArgs) Handles BtnComputadoraUsuario.Click
        PnlLogo.Visible = False
        PbTitulo.Visible = True
        FrmComputadoraUsuario.MdiParent = Me
        PnlMenu.Hide()
        FrmComputadoraUsuario.Location = New Point(330, 110)
        FrmComputadoraUsuario.Show()
    End Sub

    Private Sub BtnSoftwareComputadora_Click(sender As Object, e As EventArgs) Handles BtnSoftwareComputadora.Click
        PnlLogo.Visible = False
        PbTitulo.Visible = True
        FrmSoftwareComputadora.MdiParent = Me
        PnlMenu.Hide()
        FrmSoftwareComputadora.Location = New Point(120, 110)
        FrmSoftwareComputadora.Show()
    End Sub

    Private Sub BtnDiscoDuro_Click(sender As Object, e As EventArgs) Handles BtnDiscoDuro.Click
        PnlLogo.Visible = False
        PbTitulo.Visible = True
        FrmCapacidadDiscoDuro.MdiParent = Me
        PnlMenu.Hide()
        FrmCapacidadDiscoDuro.Location = New Point(375, 110)
        FrmCapacidadDiscoDuro.Show()
    End Sub

    Private Sub BtnModelo_Click(sender As Object, e As EventArgs) Handles BtnModelo.Click
        PnlLogo.Visible = False
        PbTitulo.Visible = True
        FrmModelo.MdiParent = Me
        PnlMenu.Hide()
        FrmModelo.Location = New Point(345, 110)
        FrmModelo.Show()
    End Sub

    Private Sub BtnMarca_Click(sender As Object, e As EventArgs) Handles BtnMarca.Click
        PnlLogo.Visible = False
        PbTitulo.Visible = True
        FrmMarca.MdiParent = Me
        PnlMenu.Hide()
        FrmMarca.Location = New Point(380, 110)
        FrmMarca.Show()
    End Sub

    Private Sub BtnComputadora_Click(sender As Object, e As EventArgs) Handles BtnComputadora.Click
        PnlLogo.Visible = False
        PbTitulo.Visible = True
        FrmComputadora.MdiParent = Me
        PnlMenu.Hide()
        FrmComputadora.Location = New Point(320, 100)
        FrmComputadora.Show()
    End Sub

    Private Sub BtnMantenimiento_Click(sender As Object, e As EventArgs) Handles BtnMantenimiento.Click
        PnlLogo.Visible = False
        PbTitulo.Visible = True
        FrmMantenimiento.MdiParent = Me
        PnlMenu.Hide()
        FrmMantenimiento.Location = New Point(280, 110)
        FrmMantenimiento.Show()
    End Sub

    Private Sub BtnCapacidadRAM_Click(sender As Object, e As EventArgs) Handles BtnCapacidadRAM.Click
        PnlLogo.Visible = False
        PbTitulo.Visible = True
        FrmCapacidadRAM.MdiParent = Me
        PnlMenu.Hide()
        FrmCapacidadRAM.Location = New Point(375, 110)
        FrmCapacidadRAM.Show()
    End Sub

    Private Sub BtnCiudad_Click(sender As Object, e As EventArgs) Handles BtnCiudad.Click
        PnlLogo.Visible = False
        PbTitulo.Visible = True
        FrmCiudad.MdiParent = Me
        PnlMenu.Hide()
        FrmCiudad.Location = New Point(385, 110)
        FrmCiudad.Show()
    End Sub

    Private Sub BtnEmpleado_Click_1(sender As Object, e As EventArgs) Handles BtnEmpleado.Click
        PnlLogo.Visible = False
        PbTitulo.Visible = True
        FrmEmpleado.MdiParent = Me
        PnlMenu.Hide()
        FrmEmpleado.Location = New Point(120, 110)
        FrmEmpleado.Show()
    End Sub

    Private Sub BtnDepartamento_Click(sender As Object, e As EventArgs) Handles BtnDepartamento.Click
        PnlLogo.Visible = False
        PbTitulo.Visible = True
        FrmDepartamento.MdiParent = Me
        PnlMenu.Hide()
        FrmDepartamento.Location = New Point(375, 110)
        FrmDepartamento.Show()
    End Sub

    Private Sub BtnProfesion_Click(sender As Object, e As EventArgs) Handles BtnProfesion.Click
        PnlLogo.Visible = False
        PbTitulo.Visible = True
        FrmProfesion.MdiParent = Me
        PnlMenu.Hide()
        FrmProfesion.Location = New Point(330, 110)
        FrmProfesion.Show()
    End Sub

    Private Sub RegistrosAuditoriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrosAuditoriaToolStripMenuItem.Click
        PnlLogo.Visible = False
        PbTitulo.Visible = True
        FrmLogAuditoria.MdiParent = Me
        PnlMenu.Hide()
        FrmLogAuditoria.Location = New Point(330, 140)
        FrmLogAuditoria.Show()
    End Sub

    Private Sub MDIControlKeeper_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Application.Exit()
    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        FrmLogin.Show()
        FrmLogin.UsernameTextBox.Focus()
        Me.Hide()
    End Sub

    Private Sub BtnUsuario_MouseHover(sender As Object, e As EventArgs) Handles BtnUsuario.MouseHover
        LblPerfiles.ForeColor = Color.Red
    End Sub

    Private Sub BtnEmpleado_MouseHover(sender As Object, e As EventArgs) Handles BtnEmpleado.MouseHover
        LblPerfiles.ForeColor = Color.Red
    End Sub

    Private Sub BtnCiudad_MouseHover(sender As Object, e As EventArgs) Handles BtnCiudad.MouseHover
        LblPerfiles.ForeColor = Color.Red
    End Sub

    Private Sub BtnDepartamento_MouseHover(sender As Object, e As EventArgs) Handles BtnDepartamento.MouseHover
        LblPerfiles.ForeColor = Color.Red
    End Sub

    Private Sub BtnProfesion_MouseHover(sender As Object, e As EventArgs) Handles BtnProfesion.MouseHover
        LblPerfiles.ForeColor = Color.Red
    End Sub

    Private Sub BtnCapacidadRAM_MouseHover(sender As Object, e As EventArgs) Handles BtnCapacidadRAM.MouseHover
        LblComputadora.ForeColor = Color.Red
    End Sub

    Private Sub BtnDiscoDuro_MouseHover(sender As Object, e As EventArgs) Handles BtnDiscoDuro.MouseHover
        LblComputadora.ForeColor = Color.Red
    End Sub

    Private Sub BtnMarca_MouseHover(sender As Object, e As EventArgs) Handles BtnMarca.MouseHover
        LblComputadora.ForeColor = Color.Red
    End Sub

    Private Sub BtnModelo_MouseHover(sender As Object, e As EventArgs) Handles BtnModelo.MouseHover
        LblComputadora.ForeColor = Color.Red
    End Sub

    Private Sub BtnComputadora_MouseHover(sender As Object, e As EventArgs) Handles BtnComputadora.MouseHover
        LblComputadora.ForeColor = Color.Red
    End Sub

    Private Sub BtnComputadoraUsuario_MouseHover(sender As Object, e As EventArgs) Handles BtnComputadoraUsuario.MouseHover
        LblComputadora.ForeColor = Color.Red
    End Sub

    Private Sub BtnSoftware_MouseHover(sender As Object, e As EventArgs) Handles BtnSoftware.MouseHover
        LblSoftware.ForeColor = Color.Red
    End Sub

    Private Sub BtnSoftwareComputadora_MouseHover(sender As Object, e As EventArgs) Handles BtnSoftwareComputadora.MouseHover
        LblSoftware.ForeColor = Color.Red
    End Sub

    Private Sub BtnTipoSoftware_MouseHover(sender As Object, e As EventArgs) Handles BtnTipoSoftware.MouseHover
        LblSoftware.ForeColor = Color.Red
    End Sub

    Private Sub BtnDesarrollador_MouseHover(sender As Object, e As EventArgs) Handles BtnDesarrollador.MouseHover
        LblSoftware.ForeColor = Color.Red
    End Sub

    Private Sub BtnMantenimiento_MouseHover(sender As Object, e As EventArgs) Handles BtnMantenimiento.MouseHover
        LblSoftware.ForeColor = Color.Red
    End Sub

    Private Sub BtnUsuario_MouseLeave(sender As Object, e As EventArgs) Handles BtnUsuario.MouseLeave
        LblPerfiles.ForeColor = Color.Black
    End Sub

    Private Sub BtnEmpleado_MouseLeave(sender As Object, e As EventArgs) Handles BtnEmpleado.MouseLeave
        LblPerfiles.ForeColor = Color.Black
    End Sub

    Private Sub BtnCiudad_MouseLeave(sender As Object, e As EventArgs) Handles BtnCiudad.MouseLeave
        LblPerfiles.ForeColor = Color.Black
    End Sub

    Private Sub BtnDepartamento_MouseLeave(sender As Object, e As EventArgs) Handles BtnDepartamento.MouseLeave
        LblPerfiles.ForeColor = Color.Black
    End Sub

    Private Sub BtnProfesion_MouseLeave(sender As Object, e As EventArgs) Handles BtnProfesion.MouseLeave
        LblPerfiles.ForeColor = Color.Black
    End Sub

    Private Sub BtnCapacidadRAM_MouseLeave(sender As Object, e As EventArgs) Handles BtnCapacidadRAM.MouseLeave
        LblComputadora.ForeColor = Color.Black
    End Sub

    Private Sub BtnDiscoDuro_MouseLeave(sender As Object, e As EventArgs) Handles BtnDiscoDuro.MouseLeave
        LblComputadora.ForeColor = Color.Black
    End Sub

    Private Sub BtnMarca_MouseLeave(sender As Object, e As EventArgs) Handles BtnMarca.MouseLeave
        LblComputadora.ForeColor = Color.Black
    End Sub

    Private Sub BtnModelo_MouseLeave(sender As Object, e As EventArgs) Handles BtnModelo.MouseLeave
        LblComputadora.ForeColor = Color.Black
    End Sub

    Private Sub BtnComputadora_MouseLeave(sender As Object, e As EventArgs) Handles BtnComputadora.MouseLeave
        LblComputadora.ForeColor = Color.Black
    End Sub

    Private Sub BtnComputadoraUsuario_MouseLeave(sender As Object, e As EventArgs) Handles BtnComputadoraUsuario.MouseLeave
        LblComputadora.ForeColor = Color.Black
    End Sub

    Private Sub BtnSoftware_MouseLeave(sender As Object, e As EventArgs) Handles BtnSoftware.MouseLeave
        LblSoftware.ForeColor = Color.Black
    End Sub

    Private Sub BtnSoftwareComputadora_MouseLeave(sender As Object, e As EventArgs) Handles BtnSoftwareComputadora.MouseLeave
        LblSoftware.ForeColor = Color.Black
    End Sub

    Private Sub BtnTipoSoftware_MouseLeave(sender As Object, e As EventArgs) Handles BtnTipoSoftware.MouseLeave
        LblSoftware.ForeColor = Color.Black
    End Sub

    Private Sub BtnDesarrollador_MouseLeave(sender As Object, e As EventArgs) Handles BtnDesarrollador.MouseLeave
        LblSoftware.ForeColor = Color.Black
    End Sub

    Private Sub BtnMantenimiento_MouseLeave(sender As Object, e As EventArgs) Handles BtnMantenimiento.MouseLeave
        LblSoftware.ForeColor = Color.Black
    End Sub

End Class
