<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUsuario))
        Me.DgvUsuario = New System.Windows.Forms.DataGridView()
        Me.CmsUsuario = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.PlUsuario = New System.Windows.Forms.Panel()
        Me.BtnAbrirFrmEmpleado = New System.Windows.Forms.Button()
        Me.CboNombreEmpleado = New System.Windows.Forms.ComboBox()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.CboTipoUsuario = New System.Windows.Forms.ComboBox()
        Me.TxtContrasena = New System.Windows.Forms.TextBox()
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.TxtIdUsuario = New System.Windows.Forms.TextBox()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DgvUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CmsUsuario.SuspendLayout()
        Me.PlUsuario.SuspendLayout()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgvUsuario
        '
        Me.DgvUsuario.AllowUserToAddRows = False
        Me.DgvUsuario.AllowUserToDeleteRows = False
        Me.DgvUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvUsuario.BackgroundColor = System.Drawing.Color.White
        Me.DgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvUsuario.ContextMenuStrip = Me.CmsUsuario
        Me.DgvUsuario.Location = New System.Drawing.Point(15, 372)
        Me.DgvUsuario.Name = "DgvUsuario"
        Me.DgvUsuario.ReadOnly = True
        Me.DgvUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvUsuario.Size = New System.Drawing.Size(599, 151)
        Me.DgvUsuario.TabIndex = 57
        '
        'CmsUsuario
        '
        Me.CmsUsuario.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.CmsUsuario.Name = "CmsUsuario"
        Me.CmsUsuario.Size = New System.Drawing.Size(118, 48)
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
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.BackColor = System.Drawing.Color.Transparent
        Me.Label66.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label66.Location = New System.Drawing.Point(271, 12)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(114, 38)
        Me.Label66.TabIndex = 52
        Me.Label66.Text = "Usuario"
        '
        'PlUsuario
        '
        Me.PlUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PlUsuario.Controls.Add(Me.BtnAbrirFrmEmpleado)
        Me.PlUsuario.Controls.Add(Me.CboNombreEmpleado)
        Me.PlUsuario.Controls.Add(Me.Label65)
        Me.PlUsuario.Controls.Add(Me.CboTipoUsuario)
        Me.PlUsuario.Controls.Add(Me.TxtContrasena)
        Me.PlUsuario.Controls.Add(Me.TxtUsuario)
        Me.PlUsuario.Controls.Add(Me.Label60)
        Me.PlUsuario.Controls.Add(Me.Label62)
        Me.PlUsuario.Controls.Add(Me.Label63)
        Me.PlUsuario.Controls.Add(Me.TxtIdUsuario)
        Me.PlUsuario.Controls.Add(Me.Label64)
        Me.PlUsuario.Location = New System.Drawing.Point(15, 85)
        Me.PlUsuario.Name = "PlUsuario"
        Me.PlUsuario.Size = New System.Drawing.Size(598, 192)
        Me.PlUsuario.TabIndex = 50
        '
        'BtnAbrirFrmEmpleado
        '
        Me.BtnAbrirFrmEmpleado.Location = New System.Drawing.Point(554, 147)
        Me.BtnAbrirFrmEmpleado.Name = "BtnAbrirFrmEmpleado"
        Me.BtnAbrirFrmEmpleado.Size = New System.Drawing.Size(36, 27)
        Me.BtnAbrirFrmEmpleado.TabIndex = 58
        Me.BtnAbrirFrmEmpleado.Text = "..."
        Me.BtnAbrirFrmEmpleado.UseVisualStyleBackColor = True
        '
        'CboNombreEmpleado
        '
        Me.CboNombreEmpleado.BackColor = System.Drawing.Color.White
        Me.CboNombreEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboNombreEmpleado.FormattingEnabled = True
        Me.CboNombreEmpleado.Location = New System.Drawing.Point(160, 150)
        Me.CboNombreEmpleado.Name = "CboNombreEmpleado"
        Me.CboNombreEmpleado.Size = New System.Drawing.Size(388, 21)
        Me.CboNombreEmpleado.TabIndex = 57
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.Location = New System.Drawing.Point(3, 149)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(154, 20)
        Me.Label65.TabIndex = 54
        Me.Label65.Text = "Nombre de Empleado"
        '
        'CboTipoUsuario
        '
        Me.CboTipoUsuario.BackColor = System.Drawing.Color.White
        Me.CboTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTipoUsuario.FormattingEnabled = True
        Me.CboTipoUsuario.Location = New System.Drawing.Point(160, 114)
        Me.CboTipoUsuario.Name = "CboTipoUsuario"
        Me.CboTipoUsuario.Size = New System.Drawing.Size(263, 21)
        Me.CboTipoUsuario.TabIndex = 51
        '
        'TxtContrasena
        '
        Me.TxtContrasena.Location = New System.Drawing.Point(160, 80)
        Me.TxtContrasena.Name = "TxtContrasena"
        Me.TxtContrasena.Size = New System.Drawing.Size(301, 20)
        Me.TxtContrasena.TabIndex = 49
        Me.TxtContrasena.UseSystemPasswordChar = True
        '
        'TxtUsuario
        '
        Me.TxtUsuario.Location = New System.Drawing.Point(160, 46)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(301, 20)
        Me.TxtUsuario.TabIndex = 48
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.Location = New System.Drawing.Point(62, 113)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(96, 20)
        Me.Label60.TabIndex = 47
        Me.Label60.Text = "Tipo Usuario"
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label62.Location = New System.Drawing.Point(70, 79)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(87, 20)
        Me.Label62.TabIndex = 45
        Me.Label62.Text = "Contraseña"
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.Location = New System.Drawing.Point(97, 44)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(62, 20)
        Me.Label63.TabIndex = 44
        Me.Label63.Text = "Usuario"
        '
        'TxtIdUsuario
        '
        Me.TxtIdUsuario.Location = New System.Drawing.Point(160, 12)
        Me.TxtIdUsuario.Name = "TxtIdUsuario"
        Me.TxtIdUsuario.ReadOnly = True
        Me.TxtIdUsuario.Size = New System.Drawing.Size(177, 20)
        Me.TxtIdUsuario.TabIndex = 43
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.Location = New System.Drawing.Point(48, 9)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(112, 20)
        Me.Label64.TabIndex = 42
        Me.Label64.Text = "Código Usuario"
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
        Me.BtnNuevo.Location = New System.Drawing.Point(128, 283)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(67, 51)
        Me.BtnNuevo.TabIndex = 53
        Me.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.BtnNuevo, "Nuevo")
        Me.BtnNuevo.UseVisualStyleBackColor = False
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
        Me.BtnModificar.Location = New System.Drawing.Point(325, 283)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(67, 51)
        Me.BtnModificar.TabIndex = 54
        Me.BtnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.BtnModificar, "Modificar")
        Me.BtnModificar.UseVisualStyleBackColor = False
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
        Me.BtnGuardar.Location = New System.Drawing.Point(227, 283)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(67, 51)
        Me.BtnGuardar.TabIndex = 55
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.BtnGuardar, "Guardar")
        Me.BtnGuardar.UseVisualStyleBackColor = False
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
        Me.BtnCancelar.Location = New System.Drawing.Point(426, 283)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(67, 51)
        Me.BtnCancelar.TabIndex = 56
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.BtnCancelar, "Cancelar")
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'PictureBox11
        '
        Me.PictureBox11.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox11.BackgroundImage = Global.ControlKeeper.My.Resources.Resources.sesiones
        Me.PictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox11.Location = New System.Drawing.Point(214, 7)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(47, 48)
        Me.PictureBox11.TabIndex = 51
        Me.PictureBox11.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel3.BackgroundImage = Global.ControlKeeper.My.Resources.Resources.br
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Label66)
        Me.Panel3.Controls.Add(Me.PictureBox11)
        Me.Panel3.Location = New System.Drawing.Point(0, 1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(637, 68)
        Me.Panel3.TabIndex = 62
        '
        'TxtBusqueda
        '
        Me.TxtBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBusqueda.Location = New System.Drawing.Point(96, 346)
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.Size = New System.Drawing.Size(517, 21)
        Me.TxtBusqueda.TabIndex = 63
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 11.25!)
        Me.Label1.Location = New System.Drawing.Point(17, 344)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 20)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Búsqueda "
        '
        'FrmUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(634, 535)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtBusqueda)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.DgvUsuario)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.PlUsuario)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Gestión de Usuario"
        CType(Me.DgvUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CmsUsuario.ResumeLayout(False)
        Me.PlUsuario.ResumeLayout(False)
        Me.PlUsuario.PerformLayout()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DgvUsuario As DataGridView
    Friend WithEvents Label66 As Label
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PlUsuario As Panel
    Friend WithEvents BtnAbrirFrmEmpleado As Button
    Friend WithEvents CboNombreEmpleado As ComboBox
    Friend WithEvents Label65 As Label
    Friend WithEvents CboTipoUsuario As ComboBox
    Friend WithEvents TxtContrasena As TextBox
    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents Label60 As Label
    Friend WithEvents Label62 As Label
    Friend WithEvents Label63 As Label
    Friend WithEvents TxtIdUsuario As TextBox
    Friend WithEvents Label64 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Panel3 As Panel
    Friend WithEvents CmsUsuario As ContextMenuStrip
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents TxtBusqueda As TextBox
    Friend WithEvents Label1 As Label
End Class
