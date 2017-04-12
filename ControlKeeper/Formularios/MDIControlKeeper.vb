Imports System.ComponentModel
Imports System.Windows.Forms

Public Class MDIControlKeeper



    Private Sub MDIControlKeeper_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PnlMenu.Hide()
    End Sub

    Private Sub BtnUsuario_Click(sender As Object, e As EventArgs) Handles BtnUsuario.Click
        FrmUsuario.MdiParent = Me
        PnlMenu.Hide()
        FrmUsuario.Location = New Point(330, 110)
        'FrmUsuario.Dock = DockStyle.Fill
        'FrmUsuario.FormBorderStyle = FormBorderStyle.None
        FrmUsuario.Show()
    End Sub

    Private Sub PnlDespliegue_MouseEnter(sender As Object, e As EventArgs) Handles PnlDespliegue.MouseEnter
        PnlMenu.Show()
        FrmUsuario.Location = New Point(240, 85)
        FrmEmpleado.Location = New Point(240, 85)
    End Sub

    Private Sub PnlDespliegue_Click(sender As Object, e As EventArgs) Handles PnlDespliegue.Click
        PnlMenu.Show()
        FrmUsuario.Location = New Point(240, 85)
        FrmEmpleado.Location = New Point(240, 85)
    End Sub

    Private Sub BtnOcultar_Click(sender As Object, e As EventArgs) Handles BtnOcultar.Click
        PnlMenu.Hide()
        FrmUsuario.Location = New Point(145, 85)
        FrmEmpleado.Location = New Point(145, 85)
    End Sub

    Private Sub BtnEmpleado_Click(sender As Object, e As EventArgs)
        FrmEmpleado.MdiParent = Me
        PnlMenu.Hide()
        FrmEmpleado.Location = New Point(145, 85)
        'FrmUsuario.Dock = DockStyle.Fill
        'FrmUsuario.FormBorderStyle = FormBorderStyle.None
        FrmEmpleado.Show()
    End Sub


    Private Sub BtnTipoSoftware_Click(sender As Object, e As EventArgs) Handles BtnTipoSoftware.Click
        FrmTipoSoftware.MdiParent = Me
        PnlMenu.Hide()
        FrmTipoSoftware.Location = New Point(375, 110)
        FrmTipoSoftware.Show()
    End Sub

    Private Sub BtnDesarrollador_Click(sender As Object, e As EventArgs) Handles BtnDesarrollador.Click
        FrmDesarrollador.MdiParent = Me
        PnlMenu.Hide()
        FrmDesarrollador.Location = New Point(315, 110)
        FrmDesarrollador.Show()
    End Sub

    Private Sub BtnSoftware_Click(sender As Object, e As EventArgs) Handles BtnSoftware.Click
        FrmSoftware.MdiParent = Me
        PnlMenu.Hide()
        FrmSoftware.Location = New Point(130, 110)
        FrmSoftware.Show()
    End Sub

    Private Sub BtnComputadoraUsuario_Click(sender As Object, e As EventArgs) Handles BtnComputadoraUsuario.Click
        FrmComputadoraUsuario.MdiParent = Me
        PnlMenu.Hide()
        FrmComputadoraUsuario.Location = New Point(330, 110)
        FrmComputadoraUsuario.Show()
    End Sub

    Private Sub BtnSoftwareComputadora_Click(sender As Object, e As EventArgs) Handles BtnSoftwareComputadora.Click
        FrmSoftwareComputadora.MdiParent = Me
        PnlMenu.Hide()
        FrmSoftwareComputadora.Location = New Point(120, 110)
        FrmSoftwareComputadora.Show()
    End Sub

    Private Sub BtnDiscoDuro_Click(sender As Object, e As EventArgs) Handles BtnDiscoDuro.Click
        FrmCapacidadDiscoDuro.MdiParent = Me
        PnlMenu.Hide()
        FrmCapacidadDiscoDuro.Location = New Point(375, 110)
        FrmCapacidadDiscoDuro.Show()
    End Sub

    Private Sub BtnModelo_Click(sender As Object, e As EventArgs) Handles BtnModelo.Click
        FrmModelo.MdiParent = Me
        PnlMenu.Hide()
        FrmModelo.Location = New Point(345, 110)
        FrmModelo.Show()
    End Sub

    Private Sub BtnMarca_Click(sender As Object, e As EventArgs) Handles BtnMarca.Click
        FrmMarca.MdiParent = Me
        PnlMenu.Hide()
        FrmMarca.Location = New Point(380, 110)
        FrmMarca.Show()
    End Sub

    Private Sub BtnComputadora_Click(sender As Object, e As EventArgs) Handles BtnComputadora.Click
        FrmComputadora.MdiParent = Me
        PnlMenu.Hide()
        FrmComputadora.Location = New Point(320, 110)
        FrmComputadora.Show()
    End Sub

    Private Sub BtnMantenimiento_Click(sender As Object, e As EventArgs) Handles BtnMantenimiento.Click
        FrmMantenimiento.MdiParent = Me
        PnlMenu.Hide()
        FrmMantenimiento.Location = New Point(280, 110)
        FrmMantenimiento.Show()
    End Sub

    Private Sub BtnCapacidadRAM_Click(sender As Object, e As EventArgs) Handles BtnCapacidadRAM.Click
        FrmCapacidadRAM.MdiParent = Me
        PnlMenu.Hide()
        FrmCapacidadRAM.Location = New Point(375, 110)
        FrmCapacidadRAM.Show()
    End Sub

    Private Sub BtnCiudad_Click(sender As Object, e As EventArgs) Handles BtnCiudad.Click
        FrmCiudad.MdiParent = Me
        PnlMenu.Hide()
        FrmCiudad.Location = New Point(385, 110)
        FrmCiudad.Show()
    End Sub

    Private Sub BtnEmpleado_Click_1(sender As Object, e As EventArgs) Handles BtnEmpleado.Click
        FrmEmpleado.MdiParent = Me
        PnlMenu.Hide()
        FrmEmpleado.Location = New Point(120, 110)
        FrmEmpleado.Show()
    End Sub

    Private Sub BtnDepartamento_Click(sender As Object, e As EventArgs) Handles BtnDepartamento.Click
        FrmDepartamento.MdiParent = Me
        PnlMenu.Hide()
        FrmDepartamento.Location = New Point(375, 110)
        FrmDepartamento.Show()
    End Sub

    Private Sub BtnProfesion_Click(sender As Object, e As EventArgs) Handles BtnProfesion.Click
        FrmProfesion.MdiParent = Me
        PnlMenu.Hide()
        FrmProfesion.Location = New Point(330, 110)
        FrmProfesion.Show()
    End Sub

    Private Sub RegistrosAuditoriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrosAuditoriaToolStripMenuItem.Click
        FrmLogAuditoria.MdiParent = Me
        PnlMenu.Hide()
        FrmLogAuditoria.Location = New Point(330, 110)

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
End Class
