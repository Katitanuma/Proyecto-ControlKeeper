<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimiento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMantenimiento))
        Me.DgvMantenimiento = New System.Windows.Forms.DataGridView()
        Me.CmsMantenimiento = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.PlMantemiento = New System.Windows.Forms.GroupBox()
        Me.CboUsuario = New System.Windows.Forms.ComboBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.DtpFechaMantenimiento = New System.Windows.Forms.DateTimePicker()
        Me.DtpHoraFinalizacion = New System.Windows.Forms.DateTimePicker()
        Me.DtpHoraInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.TxtIdMantenimiento = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        CType(Me.DgvMantenimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CmsMantenimiento.SuspendLayout()
        Me.PlMantemiento.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgvMantenimiento
        '
        Me.DgvMantenimiento.AllowUserToAddRows = False
        Me.DgvMantenimiento.AllowUserToDeleteRows = False
        Me.DgvMantenimiento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvMantenimiento.BackgroundColor = System.Drawing.Color.White
        Me.DgvMantenimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvMantenimiento.ContextMenuStrip = Me.CmsMantenimiento
        Me.DgvMantenimiento.Location = New System.Drawing.Point(17, 321)
        Me.DgvMantenimiento.Name = "DgvMantenimiento"
        Me.DgvMantenimiento.ReadOnly = True
        Me.DgvMantenimiento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvMantenimiento.Size = New System.Drawing.Size(690, 175)
        Me.DgvMantenimiento.TabIndex = 34
        '
        'CmsMantenimiento
        '
        Me.CmsMantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.CmsMantenimiento.Name = "CmsMantenimiento"
        Me.CmsMantenimiento.Size = New System.Drawing.Size(118, 48)
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
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Navy
        Me.Label26.Location = New System.Drawing.Point(275, 10)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(205, 38)
        Me.Label26.TabIndex = 33
        Me.Label26.Text = "Mantenimiento"
        '
        'PlMantemiento
        '
        Me.PlMantemiento.Controls.Add(Me.CboUsuario)
        Me.PlMantemiento.Controls.Add(Me.Label33)
        Me.PlMantemiento.Controls.Add(Me.DtpFechaMantenimiento)
        Me.PlMantemiento.Controls.Add(Me.DtpHoraFinalizacion)
        Me.PlMantemiento.Controls.Add(Me.DtpHoraInicio)
        Me.PlMantemiento.Controls.Add(Me.Label27)
        Me.PlMantemiento.Controls.Add(Me.TxtDescripcion)
        Me.PlMantemiento.Controls.Add(Me.Label28)
        Me.PlMantemiento.Controls.Add(Me.Label29)
        Me.PlMantemiento.Controls.Add(Me.Label30)
        Me.PlMantemiento.Controls.Add(Me.TxtIdMantenimiento)
        Me.PlMantemiento.Controls.Add(Me.Label32)
        Me.PlMantemiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlMantemiento.Location = New System.Drawing.Point(19, 73)
        Me.PlMantemiento.Name = "PlMantemiento"
        Me.PlMantemiento.Size = New System.Drawing.Size(688, 149)
        Me.PlMantemiento.TabIndex = 32
        Me.PlMantemiento.TabStop = False
        '
        'CboUsuario
        '
        Me.CboUsuario.BackColor = System.Drawing.Color.White
        Me.CboUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboUsuario.FormattingEnabled = True
        Me.CboUsuario.Location = New System.Drawing.Point(482, 110)
        Me.CboUsuario.Name = "CboUsuario"
        Me.CboUsuario.Size = New System.Drawing.Size(198, 24)
        Me.CboUsuario.TabIndex = 38
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(417, 111)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(62, 20)
        Me.Label33.TabIndex = 37
        Me.Label33.Text = "Usuario"
        '
        'DtpFechaMantenimiento
        '
        Me.DtpFechaMantenimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaMantenimiento.Location = New System.Drawing.Point(576, 79)
        Me.DtpFechaMantenimiento.Name = "DtpFechaMantenimiento"
        Me.DtpFechaMantenimiento.Size = New System.Drawing.Size(104, 22)
        Me.DtpFechaMantenimiento.TabIndex = 36
        '
        'DtpHoraFinalizacion
        '
        Me.DtpHoraFinalizacion.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DtpHoraFinalizacion.Location = New System.Drawing.Point(175, 108)
        Me.DtpHoraFinalizacion.Name = "DtpHoraFinalizacion"
        Me.DtpHoraFinalizacion.Size = New System.Drawing.Size(114, 22)
        Me.DtpHoraFinalizacion.TabIndex = 35
        '
        'DtpHoraInicio
        '
        Me.DtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DtpHoraInicio.Location = New System.Drawing.Point(175, 79)
        Me.DtpHoraInicio.Name = "DtpHoraInicio"
        Me.DtpHoraInicio.Size = New System.Drawing.Size(114, 22)
        Me.DtpHoraInicio.TabIndex = 34
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(396, 79)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(177, 20)
        Me.Label27.TabIndex = 32
        Me.Label27.Text = "Fecha de Mantenimiento"
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Location = New System.Drawing.Point(175, 48)
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(505, 22)
        Me.TxtDescripcion.TabIndex = 28
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(63, 78)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(109, 20)
        Me.Label28.TabIndex = 26
        Me.Label28.Text = "Hora de Inicio"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(22, 108)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(150, 20)
        Me.Label29.TabIndex = 25
        Me.Label29.Text = "Hora de Finalización"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(81, 48)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(90, 20)
        Me.Label30.TabIndex = 24
        Me.Label30.Text = "Descripción"
        '
        'TxtIdMantenimiento
        '
        Me.TxtIdMantenimiento.Location = New System.Drawing.Point(175, 20)
        Me.TxtIdMantenimiento.Name = "TxtIdMantenimiento"
        Me.TxtIdMantenimiento.ReadOnly = True
        Me.TxtIdMantenimiento.Size = New System.Drawing.Size(192, 22)
        Me.TxtIdMantenimiento.TabIndex = 22
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(11, 18)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(161, 20)
        Me.Label32.TabIndex = 0
        Me.Label32.Text = "Código Mantenimiento"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.BackgroundImage = Global.ControlKeeper.My.Resources.Resources.software
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox5.Location = New System.Drawing.Point(207, 2)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(55, 57)
        Me.PictureBox5.TabIndex = 35
        Me.PictureBox5.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel3.BackgroundImage = Global.ControlKeeper.My.Resources.Resources.br
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Label26)
        Me.Panel3.Controls.Add(Me.PictureBox5)
        Me.Panel3.Location = New System.Drawing.Point(-1, -1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(729, 68)
        Me.Panel3.TabIndex = 66
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
        Me.BtnCancelar.Location = New System.Drawing.Point(471, 228)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(67, 51)
        Me.BtnCancelar.TabIndex = 78
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
        Me.BtnGuardar.Location = New System.Drawing.Point(283, 228)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(67, 51)
        Me.BtnGuardar.TabIndex = 77
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
        Me.BtnModificar.Location = New System.Drawing.Point(376, 228)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(67, 51)
        Me.BtnModificar.TabIndex = 76
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
        Me.BtnNuevo.Location = New System.Drawing.Point(190, 228)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(67, 51)
        Me.BtnNuevo.TabIndex = 75
        Me.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 11.25!)
        Me.Label1.Location = New System.Drawing.Point(16, 293)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 20)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "Busqueda "
        '
        'TxtBusqueda
        '
        Me.TxtBusqueda.Location = New System.Drawing.Point(95, 295)
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.Size = New System.Drawing.Size(612, 20)
        Me.TxtBusqueda.TabIndex = 79
        '
        'FrmMantenimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(727, 508)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtBusqueda)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.DgvMantenimiento)
        Me.Controls.Add(Me.PlMantemiento)
        Me.Name = "FrmMantenimiento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Mantenimiento"
        CType(Me.DgvMantenimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CmsMantenimiento.ResumeLayout(False)
        Me.PlMantemiento.ResumeLayout(False)
        Me.PlMantemiento.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents DgvMantenimiento As DataGridView
    Friend WithEvents Label26 As Label
    Friend WithEvents PlMantemiento As GroupBox
    Friend WithEvents CboUsuario As ComboBox
    Friend WithEvents Label33 As Label
    Friend WithEvents DtpFechaMantenimiento As DateTimePicker
    Friend WithEvents DtpHoraFinalizacion As DateTimePicker
    Friend WithEvents DtpHoraInicio As DateTimePicker
    Friend WithEvents Label27 As Label
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents TxtIdMantenimiento As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents CmsMantenimiento As ContextMenuStrip
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtBusqueda As TextBox
End Class
