<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MDIControlKeeper
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIControlKeeper))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrosAuditoriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.LblUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnComputadora = New System.Windows.Forms.Button()
        Me.BtnOcultar = New System.Windows.Forms.Button()
        Me.BtnUsuario = New System.Windows.Forms.Button()
        Me.BtnSoftwareComputadora = New System.Windows.Forms.Button()
        Me.BtnProfesion = New System.Windows.Forms.Button()
        Me.BtnModelo = New System.Windows.Forms.Button()
        Me.BtnMarca = New System.Windows.Forms.Button()
        Me.BtnMantenimiento = New System.Windows.Forms.Button()
        Me.BtnCiudad = New System.Windows.Forms.Button()
        Me.BtnDepartamento = New System.Windows.Forms.Button()
        Me.BtnEmpleado = New System.Windows.Forms.Button()
        Me.BtnComputadoraUsuario = New System.Windows.Forms.Button()
        Me.BtnCapacidadRAM = New System.Windows.Forms.Button()
        Me.BtnDesarrollador = New System.Windows.Forms.Button()
        Me.BtnDiscoDuro = New System.Windows.Forms.Button()
        Me.BtnSoftware = New System.Windows.Forms.Button()
        Me.BtnTipoSoftware = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PnlDespliegue = New System.Windows.Forms.Panel()
        Me.PnlInteraccion = New System.Windows.Forms.Panel()
        Me.PbMenu = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.PbTitulo = New System.Windows.Forms.PictureBox()
        Me.PnlMenu = New System.Windows.Forms.Panel()
        Me.LblPerfiles = New System.Windows.Forms.Label()
        Me.LblSoftware = New System.Windows.Forms.Label()
        Me.LblComputadora = New System.Windows.Forms.Label()
        Me.PnlLogo = New System.Windows.Forms.Panel()
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.PnlDespliegue.SuspendLayout()
        CType(Me.PbMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PbTitulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MenuStrip.BackgroundImage = Global.ControlKeeper.My.Resources.Resources.imagen_prueb
        Me.MenuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(36, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1313, 25)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrosAuditoriaToolStripMenuItem, Me.CerrarSesiónToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(67, 21)
        Me.ArchivoToolStripMenuItem.Text = "&Archivo"
        '
        'RegistrosAuditoriaToolStripMenuItem
        '
        Me.RegistrosAuditoriaToolStripMenuItem.Image = Global.ControlKeeper.My.Resources.Resources.report
        Me.RegistrosAuditoriaToolStripMenuItem.Name = "RegistrosAuditoriaToolStripMenuItem"
        Me.RegistrosAuditoriaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.RegistrosAuditoriaToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.RegistrosAuditoriaToolStripMenuItem.Text = "Auditoría"
        '
        'CerrarSesiónToolStripMenuItem
        '
        Me.CerrarSesiónToolStripMenuItem.Image = Global.ControlKeeper.My.Resources.Resources.user
        Me.CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem"
        Me.CerrarSesiónToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.CerrarSesiónToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.CerrarSesiónToolStripMenuItem.Text = "Cambio de Sesión"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LblUsuario})
        Me.StatusStrip.Location = New System.Drawing.Point(36, 707)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1313, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'LblUsuario
        '
        Me.LblUsuario.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(46, 17)
        Me.LblUsuario.Text = "Status"
        '
        'BtnComputadora
        '
        Me.BtnComputadora.BackgroundImage = Global.ControlKeeper.My.Resources.Resources.Imagen22
        Me.BtnComputadora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnComputadora.FlatAppearance.BorderSize = 0
        Me.BtnComputadora.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnComputadora.Location = New System.Drawing.Point(70, 331)
        Me.BtnComputadora.Name = "BtnComputadora"
        Me.BtnComputadora.Size = New System.Drawing.Size(52, 50)
        Me.BtnComputadora.TabIndex = 4
        Me.ToolTip.SetToolTip(Me.BtnComputadora, "Computadora")
        Me.BtnComputadora.UseVisualStyleBackColor = True
        '
        'BtnOcultar
        '
        Me.BtnOcultar.BackColor = System.Drawing.Color.White
        Me.BtnOcultar.BackgroundImage = Global.ControlKeeper.My.Resources.Resources.tachuela2
        Me.BtnOcultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnOcultar.Location = New System.Drawing.Point(134, 20)
        Me.BtnOcultar.Name = "BtnOcultar"
        Me.BtnOcultar.Size = New System.Drawing.Size(26, 22)
        Me.BtnOcultar.TabIndex = 1
        Me.ToolTip.SetToolTip(Me.BtnOcultar, "Ocultar")
        Me.BtnOcultar.UseVisualStyleBackColor = False
        '
        'BtnUsuario
        '
        Me.BtnUsuario.BackgroundImage = Global.ControlKeeper.My.Resources.Resources.Imagen17
        Me.BtnUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnUsuario.FlatAppearance.BorderSize = 0
        Me.BtnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUsuario.Location = New System.Drawing.Point(27, 65)
        Me.BtnUsuario.Name = "BtnUsuario"
        Me.BtnUsuario.Size = New System.Drawing.Size(52, 50)
        Me.BtnUsuario.TabIndex = 0
        Me.ToolTip.SetToolTip(Me.BtnUsuario, "Usuario")
        Me.BtnUsuario.UseVisualStyleBackColor = True
        '
        'BtnSoftwareComputadora
        '
        Me.BtnSoftwareComputadora.BackgroundImage = Global.ControlKeeper.My.Resources.Resources.SOFTWARECOMPUTADORAbtnn
        Me.BtnSoftwareComputadora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSoftwareComputadora.FlatAppearance.BorderSize = 0
        Me.BtnSoftwareComputadora.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSoftwareComputadora.Location = New System.Drawing.Point(101, 494)
        Me.BtnSoftwareComputadora.Name = "BtnSoftwareComputadora"
        Me.BtnSoftwareComputadora.Size = New System.Drawing.Size(52, 50)
        Me.BtnSoftwareComputadora.TabIndex = 18
        Me.ToolTip.SetToolTip(Me.BtnSoftwareComputadora, "Instalación de Software")
        Me.BtnSoftwareComputadora.UseVisualStyleBackColor = True
        '
        'BtnProfesion
        '
        Me.BtnProfesion.BackgroundImage = Global.ControlKeeper.My.Resources.Resources.PROFESIONbtnn
        Me.BtnProfesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnProfesion.FlatAppearance.BorderSize = 0
        Me.BtnProfesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnProfesion.Location = New System.Drawing.Point(89, 65)
        Me.BtnProfesion.Name = "BtnProfesion"
        Me.BtnProfesion.Size = New System.Drawing.Size(52, 50)
        Me.BtnProfesion.TabIndex = 16
        Me.ToolTip.SetToolTip(Me.BtnProfesion, "Profesión")
        Me.BtnProfesion.UseVisualStyleBackColor = True
        '
        'BtnModelo
        '
        Me.BtnModelo.BackgroundImage = Global.ControlKeeper.My.Resources.Resources.MODELObtnn
        Me.BtnModelo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnModelo.FlatAppearance.BorderSize = 0
        Me.BtnModelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModelo.Location = New System.Drawing.Point(16, 331)
        Me.BtnModelo.Name = "BtnModelo"
        Me.BtnModelo.Size = New System.Drawing.Size(52, 50)
        Me.BtnModelo.TabIndex = 15
        Me.ToolTip.SetToolTip(Me.BtnModelo, "Modelo")
        Me.BtnModelo.UseVisualStyleBackColor = True
        '
        'BtnMarca
        '
        Me.BtnMarca.BackgroundImage = Global.ControlKeeper.My.Resources.Resources.MARCAbtnn
        Me.BtnMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnMarca.FlatAppearance.BorderSize = 0
        Me.BtnMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMarca.Location = New System.Drawing.Point(16, 275)
        Me.BtnMarca.Name = "BtnMarca"
        Me.BtnMarca.Size = New System.Drawing.Size(52, 50)
        Me.BtnMarca.TabIndex = 14
        Me.ToolTip.SetToolTip(Me.BtnMarca, "Marca")
        Me.BtnMarca.UseVisualStyleBackColor = True
        '
        'BtnMantenimiento
        '
        Me.BtnMantenimiento.BackgroundImage = Global.ControlKeeper.My.Resources.Resources.MANTENIMIENTObtnn
        Me.BtnMantenimiento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnMantenimiento.FlatAppearance.BorderSize = 0
        Me.BtnMantenimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMantenimiento.Location = New System.Drawing.Point(70, 446)
        Me.BtnMantenimiento.Name = "BtnMantenimiento"
        Me.BtnMantenimiento.Size = New System.Drawing.Size(52, 50)
        Me.BtnMantenimiento.TabIndex = 13
        Me.ToolTip.SetToolTip(Me.BtnMantenimiento, "Mantenimiento")
        Me.BtnMantenimiento.UseVisualStyleBackColor = True
        '
        'BtnCiudad
        '
        Me.BtnCiudad.BackgroundImage = Global.ControlKeeper.My.Resources.Resources.CIUDADbtnn
        Me.BtnCiudad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCiudad.FlatAppearance.BorderSize = 0
        Me.BtnCiudad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCiudad.Location = New System.Drawing.Point(89, 118)
        Me.BtnCiudad.Name = "BtnCiudad"
        Me.BtnCiudad.Size = New System.Drawing.Size(52, 50)
        Me.BtnCiudad.TabIndex = 8
        Me.ToolTip.SetToolTip(Me.BtnCiudad, "Ciudad")
        Me.BtnCiudad.UseVisualStyleBackColor = True
        '
        'BtnDepartamento
        '
        Me.BtnDepartamento.BackgroundImage = Global.ControlKeeper.My.Resources.Resources.DEPARTAMENTObtnn
        Me.BtnDepartamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnDepartamento.FlatAppearance.BorderSize = 0
        Me.BtnDepartamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDepartamento.Location = New System.Drawing.Point(56, 166)
        Me.BtnDepartamento.Name = "BtnDepartamento"
        Me.BtnDepartamento.Size = New System.Drawing.Size(52, 50)
        Me.BtnDepartamento.TabIndex = 9
        Me.ToolTip.SetToolTip(Me.BtnDepartamento, "Departamento")
        Me.BtnDepartamento.UseVisualStyleBackColor = True
        '
        'BtnEmpleado
        '
        Me.BtnEmpleado.BackgroundImage = Global.ControlKeeper.My.Resources.Resources.EMPLEADObtnn
        Me.BtnEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnEmpleado.FlatAppearance.BorderSize = 0
        Me.BtnEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEmpleado.Location = New System.Drawing.Point(27, 117)
        Me.BtnEmpleado.Name = "BtnEmpleado"
        Me.BtnEmpleado.Size = New System.Drawing.Size(52, 50)
        Me.BtnEmpleado.TabIndex = 11
        Me.ToolTip.SetToolTip(Me.BtnEmpleado, "Empleado")
        Me.BtnEmpleado.UseVisualStyleBackColor = True
        '
        'BtnComputadoraUsuario
        '
        Me.BtnComputadoraUsuario.BackgroundImage = Global.ControlKeeper.My.Resources.Resources.CCOMPUTADORAUSUARIObtnn
        Me.BtnComputadoraUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnComputadoraUsuario.FlatAppearance.BorderSize = 0
        Me.BtnComputadoraUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnComputadoraUsuario.Location = New System.Drawing.Point(125, 275)
        Me.BtnComputadoraUsuario.Name = "BtnComputadoraUsuario"
        Me.BtnComputadoraUsuario.Size = New System.Drawing.Size(52, 50)
        Me.BtnComputadoraUsuario.TabIndex = 7
        Me.ToolTip.SetToolTip(Me.BtnComputadoraUsuario, "Asignación de Computadora")
        Me.BtnComputadoraUsuario.UseVisualStyleBackColor = True
        '
        'BtnCapacidadRAM
        '
        Me.BtnCapacidadRAM.BackgroundImage = Global.ControlKeeper.My.Resources.Resources.CAPACIDADRAMbtnn
        Me.BtnCapacidadRAM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCapacidadRAM.FlatAppearance.BorderSize = 0
        Me.BtnCapacidadRAM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCapacidadRAM.Location = New System.Drawing.Point(70, 275)
        Me.BtnCapacidadRAM.Name = "BtnCapacidadRAM"
        Me.BtnCapacidadRAM.Size = New System.Drawing.Size(52, 50)
        Me.BtnCapacidadRAM.TabIndex = 6
        Me.ToolTip.SetToolTip(Me.BtnCapacidadRAM, "Capacidad RAM")
        Me.BtnCapacidadRAM.UseVisualStyleBackColor = True
        '
        'BtnDesarrollador
        '
        Me.BtnDesarrollador.BackgroundImage = Global.ControlKeeper.My.Resources.Resources.DESARROLLADORbtnn
        Me.BtnDesarrollador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnDesarrollador.FlatAppearance.BorderSize = 0
        Me.BtnDesarrollador.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDesarrollador.Location = New System.Drawing.Point(39, 545)
        Me.BtnDesarrollador.Name = "BtnDesarrollador"
        Me.BtnDesarrollador.Size = New System.Drawing.Size(52, 50)
        Me.BtnDesarrollador.TabIndex = 10
        Me.ToolTip.SetToolTip(Me.BtnDesarrollador, "Desarrollador")
        Me.BtnDesarrollador.UseVisualStyleBackColor = True
        '
        'BtnDiscoDuro
        '
        Me.BtnDiscoDuro.BackgroundImage = Global.ControlKeeper.My.Resources.Resources.CAPACIDADISCODURObtnn
        Me.BtnDiscoDuro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnDiscoDuro.FlatAppearance.BorderSize = 0
        Me.BtnDiscoDuro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDiscoDuro.Location = New System.Drawing.Point(125, 331)
        Me.BtnDiscoDuro.Name = "BtnDiscoDuro"
        Me.BtnDiscoDuro.Size = New System.Drawing.Size(52, 50)
        Me.BtnDiscoDuro.TabIndex = 5
        Me.ToolTip.SetToolTip(Me.BtnDiscoDuro, "Capacidad Disco Duro")
        Me.BtnDiscoDuro.UseVisualStyleBackColor = True
        '
        'BtnSoftware
        '
        Me.BtnSoftware.BackgroundImage = Global.ControlKeeper.My.Resources.Resources.SOFTWAREbtnnnn
        Me.BtnSoftware.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSoftware.FlatAppearance.BorderSize = 0
        Me.BtnSoftware.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSoftware.Location = New System.Drawing.Point(39, 493)
        Me.BtnSoftware.Name = "BtnSoftware"
        Me.BtnSoftware.Size = New System.Drawing.Size(52, 50)
        Me.BtnSoftware.TabIndex = 17
        Me.ToolTip.SetToolTip(Me.BtnSoftware, "Software")
        Me.BtnSoftware.UseVisualStyleBackColor = True
        '
        'BtnTipoSoftware
        '
        Me.BtnTipoSoftware.BackgroundImage = Global.ControlKeeper.My.Resources.Resources.TIPOSOFTWAREbtnn
        Me.BtnTipoSoftware.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnTipoSoftware.FlatAppearance.BorderSize = 0
        Me.BtnTipoSoftware.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTipoSoftware.Location = New System.Drawing.Point(100, 545)
        Me.BtnTipoSoftware.Name = "BtnTipoSoftware"
        Me.BtnTipoSoftware.Size = New System.Drawing.Size(52, 50)
        Me.BtnTipoSoftware.TabIndex = 19
        Me.ToolTip.SetToolTip(Me.BtnTipoSoftware, "Tipo Software")
        Me.BtnTipoSoftware.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.Panel3.BackgroundImage = Global.ControlKeeper.My.Resources.Resources.log1
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Location = New System.Drawing.Point(-52, 100)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1502, 13)
        Me.Panel3.TabIndex = 13
        '
        'PnlDespliegue
        '
        Me.PnlDespliegue.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.PnlDespliegue.BackgroundImage = Global.ControlKeeper.My.Resources.Resources.fin_barn
        Me.PnlDespliegue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlDespliegue.Controls.Add(Me.PnlInteraccion)
        Me.PnlDespliegue.Controls.Add(Me.PbMenu)
        Me.PnlDespliegue.Controls.Add(Me.Label7)
        Me.PnlDespliegue.Controls.Add(Me.Panel2)
        Me.PnlDespliegue.Controls.Add(Me.Label6)
        Me.PnlDespliegue.Controls.Add(Me.Label4)
        Me.PnlDespliegue.Controls.Add(Me.Label5)
        Me.PnlDespliegue.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnlDespliegue.Location = New System.Drawing.Point(0, 0)
        Me.PnlDespliegue.Name = "PnlDespliegue"
        Me.PnlDespliegue.Size = New System.Drawing.Size(36, 729)
        Me.PnlDespliegue.TabIndex = 0
        '
        'PnlInteraccion
        '
        Me.PnlInteraccion.BackColor = System.Drawing.Color.Transparent
        Me.PnlInteraccion.Location = New System.Drawing.Point(7, 276)
        Me.PnlInteraccion.Name = "PnlInteraccion"
        Me.PnlInteraccion.Size = New System.Drawing.Size(22, 438)
        Me.PnlInteraccion.TabIndex = 17
        '
        'PbMenu
        '
        Me.PbMenu.BackColor = System.Drawing.Color.Transparent
        Me.PbMenu.BackgroundImage = Global.ControlKeeper.My.Resources.Resources.home
        Me.PbMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PbMenu.Location = New System.Drawing.Point(3, 133)
        Me.PbMenu.Name = "PbMenu"
        Me.PbMenu.Size = New System.Drawing.Size(31, 33)
        Me.PbMenu.TabIndex = 15
        Me.PbMenu.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(6, 227)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 24)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Ú"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.PowderBlue
        Me.Panel2.BackgroundImage = Global.ControlKeeper.My.Resources.Resources.archiv
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel2.Location = New System.Drawing.Point(-1, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(46, 25)
        Me.Panel2.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(6, 205)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 24)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "N"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(5, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 24)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "M"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(6, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 24)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "E"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.ControlKeeper.My.Resources.Resources.Ultimate_Material_Lollipop_Collection1
        Me.Panel1.Controls.Add(Me.Label54)
        Me.Panel1.Controls.Add(Me.PbTitulo)
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1373, 77)
        Me.Panel1.TabIndex = 9
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.BackColor = System.Drawing.Color.Transparent
        Me.Label54.Font = New System.Drawing.Font("Bauhaus 93", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.ForeColor = System.Drawing.Color.Navy
        Me.Label54.Location = New System.Drawing.Point(112, 0)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(482, 73)
        Me.Label54.TabIndex = 3
        Me.Label54.Text = "Control Keeper"
        '
        'PbTitulo
        '
        Me.PbTitulo.BackColor = System.Drawing.Color.Transparent
        Me.PbTitulo.BackgroundImage = Global.ControlKeeper.My.Resources.Resources.Logo_Control_Keeper
        Me.PbTitulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PbTitulo.Location = New System.Drawing.Point(41, 0)
        Me.PbTitulo.Name = "PbTitulo"
        Me.PbTitulo.Size = New System.Drawing.Size(67, 75)
        Me.PbTitulo.TabIndex = 2
        Me.PbTitulo.TabStop = False
        '
        'PnlMenu
        '
        Me.PnlMenu.BackColor = System.Drawing.Color.Transparent
        Me.PnlMenu.BackgroundImage = Global.ControlKeeper.My.Resources.Resources.dar
        Me.PnlMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlMenu.Controls.Add(Me.LblPerfiles)
        Me.PnlMenu.Controls.Add(Me.LblSoftware)
        Me.PnlMenu.Controls.Add(Me.LblComputadora)
        Me.PnlMenu.Controls.Add(Me.BtnUsuario)
        Me.PnlMenu.Controls.Add(Me.BtnSoftwareComputadora)
        Me.PnlMenu.Controls.Add(Me.BtnProfesion)
        Me.PnlMenu.Controls.Add(Me.BtnModelo)
        Me.PnlMenu.Controls.Add(Me.BtnMarca)
        Me.PnlMenu.Controls.Add(Me.BtnMantenimiento)
        Me.PnlMenu.Controls.Add(Me.BtnCiudad)
        Me.PnlMenu.Controls.Add(Me.BtnDepartamento)
        Me.PnlMenu.Controls.Add(Me.BtnEmpleado)
        Me.PnlMenu.Controls.Add(Me.BtnComputadoraUsuario)
        Me.PnlMenu.Controls.Add(Me.BtnCapacidadRAM)
        Me.PnlMenu.Controls.Add(Me.BtnDesarrollador)
        Me.PnlMenu.Controls.Add(Me.BtnDiscoDuro)
        Me.PnlMenu.Controls.Add(Me.BtnComputadora)
        Me.PnlMenu.Controls.Add(Me.BtnOcultar)
        Me.PnlMenu.Controls.Add(Me.BtnSoftware)
        Me.PnlMenu.Controls.Add(Me.BtnTipoSoftware)
        Me.PnlMenu.Location = New System.Drawing.Point(30, 110)
        Me.PnlMenu.Name = "PnlMenu"
        Me.PnlMenu.Size = New System.Drawing.Size(218, 619)
        Me.PnlMenu.TabIndex = 10
        '
        'LblPerfiles
        '
        Me.LblPerfiles.AutoSize = True
        Me.LblPerfiles.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPerfiles.Location = New System.Drawing.Point(53, 42)
        Me.LblPerfiles.Name = "LblPerfiles"
        Me.LblPerfiles.Size = New System.Drawing.Size(64, 21)
        Me.LblPerfiles.TabIndex = 22
        Me.LblPerfiles.Text = "Perfiles"
        '
        'LblSoftware
        '
        Me.LblSoftware.AutoSize = True
        Me.LblSoftware.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSoftware.Location = New System.Drawing.Point(62, 426)
        Me.LblSoftware.Name = "LblSoftware"
        Me.LblSoftware.Size = New System.Drawing.Size(76, 21)
        Me.LblSoftware.TabIndex = 21
        Me.LblSoftware.Text = "Software"
        '
        'LblComputadora
        '
        Me.LblComputadora.AutoSize = True
        Me.LblComputadora.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblComputadora.ForeColor = System.Drawing.Color.Black
        Me.LblComputadora.Location = New System.Drawing.Point(47, 251)
        Me.LblComputadora.Name = "LblComputadora"
        Me.LblComputadora.Size = New System.Drawing.Size(102, 21)
        Me.LblComputadora.TabIndex = 20
        Me.LblComputadora.Text = "Computadora"
        '
        'PnlLogo
        '
        Me.PnlLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.PnlLogo.BackgroundImage = Global.ControlKeeper.My.Resources.Resources.Logo_Control_Keeper
        Me.PnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlLogo.Location = New System.Drawing.Point(535, 227)
        Me.PnlLogo.Name = "PnlLogo"
        Me.PnlLogo.Size = New System.Drawing.Size(342, 379)
        Me.PnlLogo.TabIndex = 15
        '
        'MDIControlKeeper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.BackgroundImage = Global.ControlKeeper.My.Resources.Resources.md1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1349, 729)
        Me.Controls.Add(Me.PnlLogo)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PnlDespliegue)
        Me.Controls.Add(Me.PnlMenu)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.MaximizeBox = False
        Me.Name = "MDIControlKeeper"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menú Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.PnlDespliegue.ResumeLayout(False)
        Me.PnlDespliegue.PerformLayout()
        CType(Me.PbMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PbTitulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlMenu.ResumeLayout(False)
        Me.PnlMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents LblUsuario As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents Label54 As Label
    Friend WithEvents PbTitulo As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BtnUsuario As Button
    Friend WithEvents PnlDespliegue As Panel
    Friend WithEvents BtnOcultar As Button
    Friend WithEvents BtnComputadora As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PnlMenu As Panel
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnDiscoDuro As Button
    Friend WithEvents BtnCapacidadRAM As Button
    Friend WithEvents BtnComputadoraUsuario As Button
    Friend WithEvents BtnCiudad As Button
    Friend WithEvents BtnDepartamento As Button
    Friend WithEvents BtnDesarrollador As Button
    Friend WithEvents BtnEmpleado As Button
    Friend WithEvents BtnMantenimiento As Button
    Friend WithEvents BtnMarca As Button
    Friend WithEvents BtnModelo As Button
    Friend WithEvents BtnProfesion As Button
    Friend WithEvents BtnSoftware As Button
    Friend WithEvents BtnSoftwareComputadora As Button
    Friend WithEvents BtnTipoSoftware As Button
    Friend WithEvents LblPerfiles As Label
    Friend WithEvents LblSoftware As Label
    Friend WithEvents LblComputadora As Label
    Friend WithEvents RegistrosAuditoriaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PbMenu As PictureBox
    Friend WithEvents PnlLogo As Panel
    Friend WithEvents PnlInteraccion As Panel
End Class
