<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSoftwareComputadora
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSoftwareComputadora))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.DgvInstalacionSoftware = New System.Windows.Forms.DataGridView()
        Me.CmsInstalacionSoftware = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlInstalacionSoftware = New System.Windows.Forms.GroupBox()
        Me.BtnAbrirFrmUsuario = New System.Windows.Forms.Button()
        Me.CboUsuario = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DtpFechaDesinstalacion = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DtpFechaVencimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtLicencia = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CboSoftware = New System.Windows.Forms.ComboBox()
        Me.CboSerie = New System.Windows.Forms.ComboBox()
        Me.BtnAbrirFrmSoftware = New System.Windows.Forms.Button()
        Me.BtnAbrirFrmComputadora = New System.Windows.Forms.Button()
        Me.ChkEstado = New System.Windows.Forms.CheckBox()
        Me.DtpFechaInstalacion = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtObservacion = New System.Windows.Forms.TextBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvInstalacionSoftware, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CmsInstalacionSoftware.SuspendLayout()
        Me.PlInstalacionSoftware.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel1.BackgroundImage = Global.ControlKeeper.My.Resources.Resources.br
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label45)
        Me.Panel1.Controls.Add(Me.PictureBox10)
        Me.Panel1.Location = New System.Drawing.Point(0, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1069, 74)
        Me.Panel1.TabIndex = 77
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.BackColor = System.Drawing.Color.Transparent
        Me.Label45.Font = New System.Drawing.Font("Comic Sans MS", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.Navy
        Me.Label45.Location = New System.Drawing.Point(366, 12)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(358, 40)
        Me.Label45.TabIndex = 25
        Me.Label45.Text = "Instalación de Software"
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox10.BackgroundImage = Global.ControlKeeper.My.Resources.Resources.software__1_
        Me.PictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox10.Location = New System.Drawing.Point(310, 6)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(51, 51)
        Me.PictureBox10.TabIndex = 39
        Me.PictureBox10.TabStop = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.BtnCancelar.BackgroundImage = CType(resources.GetObject("BtnCancelar.BackgroundImage"), System.Drawing.Image)
        Me.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.BtnCancelar.FlatAppearance.BorderSize = 0
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.ForeColor = System.Drawing.Color.Black
        Me.BtnCancelar.Image = Global.ControlKeeper.My.Resources.Resources.C3
        Me.BtnCancelar.Location = New System.Drawing.Point(622, 241)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(67, 51)
        Me.BtnCancelar.TabIndex = 89
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.Transparent
        Me.BtnGuardar.BackgroundImage = CType(resources.GetObject("BtnGuardar.BackgroundImage"), System.Drawing.Image)
        Me.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.BtnGuardar.FlatAppearance.BorderSize = 0
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.ForeColor = System.Drawing.Color.Black
        Me.BtnGuardar.Image = Global.ControlKeeper.My.Resources.Resources.G3
        Me.BtnGuardar.Location = New System.Drawing.Point(435, 241)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(67, 51)
        Me.BtnGuardar.TabIndex = 88
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'BtnModificar
        '
        Me.BtnModificar.BackColor = System.Drawing.Color.Transparent
        Me.BtnModificar.BackgroundImage = CType(resources.GetObject("BtnModificar.BackgroundImage"), System.Drawing.Image)
        Me.BtnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnModificar.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.BtnModificar.FlatAppearance.BorderSize = 0
        Me.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.ForeColor = System.Drawing.Color.Black
        Me.BtnModificar.Image = Global.ControlKeeper.My.Resources.Resources.A3
        Me.BtnModificar.Location = New System.Drawing.Point(527, 241)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(67, 51)
        Me.BtnModificar.TabIndex = 87
        Me.BtnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnModificar.UseVisualStyleBackColor = False
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackColor = System.Drawing.Color.Transparent
        Me.BtnNuevo.BackgroundImage = CType(resources.GetObject("BtnNuevo.BackgroundImage"), System.Drawing.Image)
        Me.BtnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.BtnNuevo.FlatAppearance.BorderSize = 0
        Me.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.ForeColor = System.Drawing.Color.Black
        Me.BtnNuevo.Image = Global.ControlKeeper.My.Resources.Resources.N3
        Me.BtnNuevo.Location = New System.Drawing.Point(341, 241)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(67, 51)
        Me.BtnNuevo.TabIndex = 86
        Me.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'DgvInstalacionSoftware
        '
        Me.DgvInstalacionSoftware.AllowUserToAddRows = False
        Me.DgvInstalacionSoftware.AllowUserToDeleteRows = False
        Me.DgvInstalacionSoftware.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvInstalacionSoftware.BackgroundColor = System.Drawing.Color.White
        Me.DgvInstalacionSoftware.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvInstalacionSoftware.ContextMenuStrip = Me.CmsInstalacionSoftware
        Me.DgvInstalacionSoftware.Location = New System.Drawing.Point(12, 336)
        Me.DgvInstalacionSoftware.Name = "DgvInstalacionSoftware"
        Me.DgvInstalacionSoftware.ReadOnly = True
        Me.DgvInstalacionSoftware.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvInstalacionSoftware.Size = New System.Drawing.Size(1045, 190)
        Me.DgvInstalacionSoftware.TabIndex = 85
        '
        'CmsInstalacionSoftware
        '
        Me.CmsInstalacionSoftware.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.CmsInstalacionSoftware.Name = "CmsInstalacionSoftware"
        Me.CmsInstalacionSoftware.Size = New System.Drawing.Size(118, 48)
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'PlInstalacionSoftware
        '
        Me.PlInstalacionSoftware.Controls.Add(Me.BtnAbrirFrmUsuario)
        Me.PlInstalacionSoftware.Controls.Add(Me.CboUsuario)
        Me.PlInstalacionSoftware.Controls.Add(Me.Label6)
        Me.PlInstalacionSoftware.Controls.Add(Me.DtpFechaDesinstalacion)
        Me.PlInstalacionSoftware.Controls.Add(Me.Label5)
        Me.PlInstalacionSoftware.Controls.Add(Me.DtpFechaVencimiento)
        Me.PlInstalacionSoftware.Controls.Add(Me.Label4)
        Me.PlInstalacionSoftware.Controls.Add(Me.TxtLicencia)
        Me.PlInstalacionSoftware.Controls.Add(Me.Label3)
        Me.PlInstalacionSoftware.Controls.Add(Me.CboSoftware)
        Me.PlInstalacionSoftware.Controls.Add(Me.CboSerie)
        Me.PlInstalacionSoftware.Controls.Add(Me.BtnAbrirFrmSoftware)
        Me.PlInstalacionSoftware.Controls.Add(Me.BtnAbrirFrmComputadora)
        Me.PlInstalacionSoftware.Controls.Add(Me.ChkEstado)
        Me.PlInstalacionSoftware.Controls.Add(Me.DtpFechaInstalacion)
        Me.PlInstalacionSoftware.Controls.Add(Me.Label2)
        Me.PlInstalacionSoftware.Controls.Add(Me.Label1)
        Me.PlInstalacionSoftware.Controls.Add(Me.TxtObservacion)
        Me.PlInstalacionSoftware.Controls.Add(Me.Label50)
        Me.PlInstalacionSoftware.Controls.Add(Me.Label51)
        Me.PlInstalacionSoftware.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlInstalacionSoftware.Location = New System.Drawing.Point(12, 78)
        Me.PlInstalacionSoftware.Name = "PlInstalacionSoftware"
        Me.PlInstalacionSoftware.Size = New System.Drawing.Size(1046, 154)
        Me.PlInstalacionSoftware.TabIndex = 84
        Me.PlInstalacionSoftware.TabStop = False
        '
        'BtnAbrirFrmUsuario
        '
        Me.BtnAbrirFrmUsuario.Location = New System.Drawing.Point(1004, 113)
        Me.BtnAbrirFrmUsuario.Name = "BtnAbrirFrmUsuario"
        Me.BtnAbrirFrmUsuario.Size = New System.Drawing.Size(36, 27)
        Me.BtnAbrirFrmUsuario.TabIndex = 71
        Me.BtnAbrirFrmUsuario.Text = "..."
        Me.BtnAbrirFrmUsuario.UseVisualStyleBackColor = True
        '
        'CboUsuario
        '
        Me.CboUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboUsuario.FormattingEnabled = True
        Me.CboUsuario.Location = New System.Drawing.Point(749, 115)
        Me.CboUsuario.Name = "CboUsuario"
        Me.CboUsuario.Size = New System.Drawing.Size(250, 24)
        Me.CboUsuario.TabIndex = 70
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(684, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 20)
        Me.Label6.TabIndex = 69
        Me.Label6.Text = "Usuario"
        '
        'DtpFechaDesinstalacion
        '
        Me.DtpFechaDesinstalacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaDesinstalacion.Location = New System.Drawing.Point(749, 84)
        Me.DtpFechaDesinstalacion.Name = "DtpFechaDesinstalacion"
        Me.DtpFechaDesinstalacion.Size = New System.Drawing.Size(107, 22)
        Me.DtpFechaDesinstalacion.TabIndex = 68
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(571, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(175, 20)
        Me.Label5.TabIndex = 67
        Me.Label5.Text = "Fecha de Desinstalación"
        '
        'DtpFechaVencimiento
        '
        Me.DtpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaVencimiento.Location = New System.Drawing.Point(750, 51)
        Me.DtpFechaVencimiento.Name = "DtpFechaVencimiento"
        Me.DtpFechaVencimiento.Size = New System.Drawing.Size(107, 22)
        Me.DtpFechaVencimiento.TabIndex = 66
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(588, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 20)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Fecha de Vencimiento"
        '
        'TxtLicencia
        '
        Me.TxtLicencia.Location = New System.Drawing.Point(750, 18)
        Me.TxtLicencia.Name = "TxtLicencia"
        Me.TxtLicencia.Size = New System.Drawing.Size(288, 22)
        Me.TxtLicencia.TabIndex = 64
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(682, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 20)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Licencia"
        '
        'CboSoftware
        '
        Me.CboSoftware.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboSoftware.FormattingEnabled = True
        Me.CboSoftware.Location = New System.Drawing.Point(158, 83)
        Me.CboSoftware.Name = "CboSoftware"
        Me.CboSoftware.Size = New System.Drawing.Size(348, 24)
        Me.CboSoftware.TabIndex = 62
        '
        'CboSerie
        '
        Me.CboSerie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboSerie.FormattingEnabled = True
        Me.CboSerie.Location = New System.Drawing.Point(158, 16)
        Me.CboSerie.Name = "CboSerie"
        Me.CboSerie.Size = New System.Drawing.Size(351, 24)
        Me.CboSerie.TabIndex = 61
        '
        'BtnAbrirFrmSoftware
        '
        Me.BtnAbrirFrmSoftware.Location = New System.Drawing.Point(510, 81)
        Me.BtnAbrirFrmSoftware.Name = "BtnAbrirFrmSoftware"
        Me.BtnAbrirFrmSoftware.Size = New System.Drawing.Size(36, 27)
        Me.BtnAbrirFrmSoftware.TabIndex = 60
        Me.BtnAbrirFrmSoftware.Text = "..."
        Me.BtnAbrirFrmSoftware.UseVisualStyleBackColor = True
        '
        'BtnAbrirFrmComputadora
        '
        Me.BtnAbrirFrmComputadora.Location = New System.Drawing.Point(512, 15)
        Me.BtnAbrirFrmComputadora.Name = "BtnAbrirFrmComputadora"
        Me.BtnAbrirFrmComputadora.Size = New System.Drawing.Size(36, 27)
        Me.BtnAbrirFrmComputadora.TabIndex = 59
        Me.BtnAbrirFrmComputadora.Text = "..."
        Me.BtnAbrirFrmComputadora.UseVisualStyleBackColor = True
        '
        'ChkEstado
        '
        Me.ChkEstado.AutoSize = True
        Me.ChkEstado.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkEstado.Location = New System.Drawing.Point(395, 51)
        Me.ChkEstado.Name = "ChkEstado"
        Me.ChkEstado.Size = New System.Drawing.Size(115, 24)
        Me.ChkEstado.TabIndex = 32
        Me.ChkEstado.Text = "No instalado"
        Me.ChkEstado.UseVisualStyleBackColor = True
        '
        'DtpFechaInstalacion
        '
        Me.DtpFechaInstalacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaInstalacion.Location = New System.Drawing.Point(158, 50)
        Me.DtpFechaInstalacion.Name = "DtpFechaInstalacion"
        Me.DtpFechaInstalacion.Size = New System.Drawing.Size(107, 22)
        Me.DtpFechaInstalacion.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(2, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 20)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Fecha de Instalación"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(58, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 20)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Observación"
        '
        'TxtObservacion
        '
        Me.TxtObservacion.Location = New System.Drawing.Point(158, 119)
        Me.TxtObservacion.Name = "TxtObservacion"
        Me.TxtObservacion.Size = New System.Drawing.Size(388, 22)
        Me.TxtObservacion.TabIndex = 27
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.Location = New System.Drawing.Point(78, 83)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(76, 20)
        Me.Label50.TabIndex = 23
        Me.Label50.Text = "Software"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.Location = New System.Drawing.Point(14, 17)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(141, 20)
        Me.Label51.TabIndex = 0
        Me.Label51.Text = "Serie Computadora"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 11.25!)
        Me.Label7.Location = New System.Drawing.Point(15, 308)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 20)
        Me.Label7.TabIndex = 91
        Me.Label7.Text = "Busqueda "
        '
        'TxtBusqueda
        '
        Me.TxtBusqueda.Location = New System.Drawing.Point(94, 310)
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.Size = New System.Drawing.Size(529, 20)
        Me.TxtBusqueda.TabIndex = 90
        '
        'FrmSoftwareComputadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1067, 538)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtBusqueda)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.DgvInstalacionSoftware)
        Me.Controls.Add(Me.PlInstalacionSoftware)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmSoftwareComputadora"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Detalle Instalación de Software"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvInstalacionSoftware, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CmsInstalacionSoftware.ResumeLayout(False)
        Me.PlInstalacionSoftware.ResumeLayout(False)
        Me.PlInstalacionSoftware.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label45 As Label
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents DgvInstalacionSoftware As DataGridView
    Friend WithEvents CmsInstalacionSoftware As ContextMenuStrip
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PlInstalacionSoftware As GroupBox
    Friend WithEvents CboUsuario As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DtpFechaDesinstalacion As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents DtpFechaVencimiento As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtLicencia As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CboSoftware As ComboBox
    Friend WithEvents CboSerie As ComboBox
    Friend WithEvents BtnAbrirFrmSoftware As Button
    Friend WithEvents BtnAbrirFrmComputadora As Button
    Friend WithEvents ChkEstado As CheckBox
    Friend WithEvents DtpFechaInstalacion As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtObservacion As TextBox
    Friend WithEvents Label50 As Label
    Friend WithEvents Label51 As Label
    Friend WithEvents BtnAbrirFrmUsuario As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtBusqueda As TextBox
End Class
