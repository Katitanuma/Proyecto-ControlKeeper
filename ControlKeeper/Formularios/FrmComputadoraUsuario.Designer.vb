<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmComputadoraUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmComputadoraUsuario))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.DgvComputadoraUsuario = New System.Windows.Forms.DataGridView()
        Me.CmsAsignacionComputadora = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlComputadoraUsuario = New System.Windows.Forms.GroupBox()
        Me.CboUsuario = New System.Windows.Forms.ComboBox()
        Me.CboSerie = New System.Windows.Forms.ComboBox()
        Me.BtnAbrirFrmUsuario = New System.Windows.Forms.Button()
        Me.BtnAbrirFrmComputadora = New System.Windows.Forms.Button()
        Me.ChkEstado = New System.Windows.Forms.CheckBox()
        Me.DtpFechaAsignacion = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtObservacion = New System.Windows.Forms.TextBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvComputadoraUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CmsAsignacionComputadora.SuspendLayout()
        Me.PlComputadoraUsuario.SuspendLayout()
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
        Me.Panel1.Location = New System.Drawing.Point(2, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(636, 74)
        Me.Panel1.TabIndex = 70
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.BackColor = System.Drawing.Color.Transparent
        Me.Label45.Font = New System.Drawing.Font("Comic Sans MS", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.Navy
        Me.Label45.Location = New System.Drawing.Point(140, 11)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(397, 40)
        Me.Label45.TabIndex = 25
        Me.Label45.Text = "Asignación de Computadora"
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox10.BackgroundImage = Global.ControlKeeper.My.Resources.Resources.IconoPC
        Me.PictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox10.Location = New System.Drawing.Point(66, 1)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(70, 62)
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
        Me.BtnCancelar.Location = New System.Drawing.Point(416, 238)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(67, 51)
        Me.BtnCancelar.TabIndex = 82
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
        Me.BtnGuardar.Location = New System.Drawing.Point(229, 238)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(67, 51)
        Me.BtnGuardar.TabIndex = 81
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
        Me.BtnModificar.Location = New System.Drawing.Point(321, 238)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(67, 51)
        Me.BtnModificar.TabIndex = 80
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
        Me.BtnNuevo.Location = New System.Drawing.Point(135, 238)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(67, 51)
        Me.BtnNuevo.TabIndex = 79
        Me.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'DgvComputadoraUsuario
        '
        Me.DgvComputadoraUsuario.AllowUserToAddRows = False
        Me.DgvComputadoraUsuario.AllowUserToDeleteRows = False
        Me.DgvComputadoraUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvComputadoraUsuario.BackgroundColor = System.Drawing.Color.White
        Me.DgvComputadoraUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvComputadoraUsuario.ContextMenuStrip = Me.CmsAsignacionComputadora
        Me.DgvComputadoraUsuario.Location = New System.Drawing.Point(12, 298)
        Me.DgvComputadoraUsuario.Name = "DgvComputadoraUsuario"
        Me.DgvComputadoraUsuario.ReadOnly = True
        Me.DgvComputadoraUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvComputadoraUsuario.Size = New System.Drawing.Size(612, 195)
        Me.DgvComputadoraUsuario.TabIndex = 78
        '
        'CmsAsignacionComputadora
        '
        Me.CmsAsignacionComputadora.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.CmsAsignacionComputadora.Name = "CmsAsignacionComputadora"
        Me.CmsAsignacionComputadora.Size = New System.Drawing.Size(118, 48)
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
        'PlComputadoraUsuario
        '
        Me.PlComputadoraUsuario.Controls.Add(Me.CboUsuario)
        Me.PlComputadoraUsuario.Controls.Add(Me.CboSerie)
        Me.PlComputadoraUsuario.Controls.Add(Me.BtnAbrirFrmUsuario)
        Me.PlComputadoraUsuario.Controls.Add(Me.BtnAbrirFrmComputadora)
        Me.PlComputadoraUsuario.Controls.Add(Me.ChkEstado)
        Me.PlComputadoraUsuario.Controls.Add(Me.DtpFechaAsignacion)
        Me.PlComputadoraUsuario.Controls.Add(Me.Label2)
        Me.PlComputadoraUsuario.Controls.Add(Me.Label1)
        Me.PlComputadoraUsuario.Controls.Add(Me.TxtObservacion)
        Me.PlComputadoraUsuario.Controls.Add(Me.Label50)
        Me.PlComputadoraUsuario.Controls.Add(Me.Label51)
        Me.PlComputadoraUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlComputadoraUsuario.Location = New System.Drawing.Point(12, 78)
        Me.PlComputadoraUsuario.Name = "PlComputadoraUsuario"
        Me.PlComputadoraUsuario.Size = New System.Drawing.Size(612, 154)
        Me.PlComputadoraUsuario.TabIndex = 77
        Me.PlComputadoraUsuario.TabStop = False
        '
        'CboUsuario
        '
        Me.CboUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboUsuario.FormattingEnabled = True
        Me.CboUsuario.Location = New System.Drawing.Point(160, 83)
        Me.CboUsuario.Name = "CboUsuario"
        Me.CboUsuario.Size = New System.Drawing.Size(348, 24)
        Me.CboUsuario.TabIndex = 62
        '
        'CboSerie
        '
        Me.CboSerie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboSerie.FormattingEnabled = True
        Me.CboSerie.Location = New System.Drawing.Point(159, 16)
        Me.CboSerie.Name = "CboSerie"
        Me.CboSerie.Size = New System.Drawing.Size(383, 24)
        Me.CboSerie.TabIndex = 61
        '
        'BtnAbrirFrmUsuario
        '
        Me.BtnAbrirFrmUsuario.Location = New System.Drawing.Point(514, 81)
        Me.BtnAbrirFrmUsuario.Name = "BtnAbrirFrmUsuario"
        Me.BtnAbrirFrmUsuario.Size = New System.Drawing.Size(36, 27)
        Me.BtnAbrirFrmUsuario.TabIndex = 60
        Me.BtnAbrirFrmUsuario.Text = "..."
        Me.BtnAbrirFrmUsuario.UseVisualStyleBackColor = True
        '
        'BtnAbrirFrmComputadora
        '
        Me.BtnAbrirFrmComputadora.Location = New System.Drawing.Point(548, 15)
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
        Me.ChkEstado.Location = New System.Drawing.Point(395, 49)
        Me.ChkEstado.Name = "ChkEstado"
        Me.ChkEstado.Size = New System.Drawing.Size(112, 24)
        Me.ChkEstado.TabIndex = 32
        Me.ChkEstado.Text = "No asignada"
        Me.ChkEstado.UseVisualStyleBackColor = True
        '
        'DtpFechaAsignacion
        '
        Me.DtpFechaAsignacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaAsignacion.Location = New System.Drawing.Point(159, 50)
        Me.DtpFechaAsignacion.Name = "DtpFechaAsignacion"
        Me.DtpFechaAsignacion.Size = New System.Drawing.Size(107, 22)
        Me.DtpFechaAsignacion.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 20)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Fecha de Asignación"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(57, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 20)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Observación"
        '
        'TxtObservacion
        '
        Me.TxtObservacion.Location = New System.Drawing.Point(160, 119)
        Me.TxtObservacion.Name = "TxtObservacion"
        Me.TxtObservacion.Size = New System.Drawing.Size(433, 22)
        Me.TxtObservacion.TabIndex = 27
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.Location = New System.Drawing.Point(91, 83)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(62, 20)
        Me.Label50.TabIndex = 23
        Me.Label50.Text = "Usuario"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.Location = New System.Drawing.Point(12, 17)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(141, 20)
        Me.Label51.TabIndex = 0
        Me.Label51.Text = "Serie Computadora"
        '
        'FrmComputadoraUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(636, 508)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.DgvComputadoraUsuario)
        Me.Controls.Add(Me.PlComputadoraUsuario)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmComputadoraUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Detalle Asignación de Computadora"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvComputadoraUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CmsAsignacionComputadora.ResumeLayout(False)
        Me.PlComputadoraUsuario.ResumeLayout(False)
        Me.PlComputadoraUsuario.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label45 As Label
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents DgvComputadoraUsuario As DataGridView
    Friend WithEvents PlComputadoraUsuario As GroupBox
    Friend WithEvents CboUsuario As ComboBox
    Friend WithEvents CboSerie As ComboBox
    Friend WithEvents BtnAbrirFrmUsuario As Button
    Friend WithEvents BtnAbrirFrmComputadora As Button
    Friend WithEvents ChkEstado As CheckBox
    Friend WithEvents DtpFechaAsignacion As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtObservacion As TextBox
    Friend WithEvents Label50 As Label
    Friend WithEvents Label51 As Label
    Friend WithEvents CmsAsignacionComputadora As ContextMenuStrip
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
End Class
