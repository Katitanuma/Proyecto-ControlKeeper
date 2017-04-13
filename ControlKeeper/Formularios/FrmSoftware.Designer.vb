<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSoftware
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSoftware))
        Me.DgvSoftware = New System.Windows.Forms.DataGridView()
        Me.CMSSoftware = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PnlSoftware = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CboTipoSoftware = New System.Windows.Forms.ComboBox()
        Me.TxtTamaño = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.CboEditor = New System.Windows.Forms.ComboBox()
        Me.TxtVersion = New System.Windows.Forms.TextBox()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.TxtNombreSoftware = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TxtCodigoSoftware = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.DgvSoftware, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CMSSoftware.SuspendLayout()
        Me.PnlSoftware.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvSoftware
        '
        Me.DgvSoftware.AllowUserToAddRows = False
        Me.DgvSoftware.AllowUserToDeleteRows = False
        Me.DgvSoftware.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvSoftware.BackgroundColor = System.Drawing.Color.White
        Me.DgvSoftware.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvSoftware.ContextMenuStrip = Me.CMSSoftware
        Me.DgvSoftware.Location = New System.Drawing.Point(24, 325)
        Me.DgvSoftware.Name = "DgvSoftware"
        Me.DgvSoftware.ReadOnly = True
        Me.DgvSoftware.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvSoftware.Size = New System.Drawing.Size(1008, 190)
        Me.DgvSoftware.TabIndex = 27
        '
        'CMSSoftware
        '
        Me.CMSSoftware.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.CMSSoftware.Name = "CMSSoftware"
        Me.CMSSoftware.Size = New System.Drawing.Size(118, 48)
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
        'PnlSoftware
        '
        Me.PnlSoftware.Controls.Add(Me.Label1)
        Me.PnlSoftware.Controls.Add(Me.CboTipoSoftware)
        Me.PnlSoftware.Controls.Add(Me.TxtTamaño)
        Me.PnlSoftware.Controls.Add(Me.Label25)
        Me.PnlSoftware.Controls.Add(Me.CboEditor)
        Me.PnlSoftware.Controls.Add(Me.TxtVersion)
        Me.PnlSoftware.Controls.Add(Me.TxtDescripcion)
        Me.PnlSoftware.Controls.Add(Me.TxtNombreSoftware)
        Me.PnlSoftware.Controls.Add(Me.Label15)
        Me.PnlSoftware.Controls.Add(Me.Label16)
        Me.PnlSoftware.Controls.Add(Me.Label17)
        Me.PnlSoftware.Controls.Add(Me.Label18)
        Me.PnlSoftware.Controls.Add(Me.TxtCodigoSoftware)
        Me.PnlSoftware.Controls.Add(Me.Label19)
        Me.PnlSoftware.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PnlSoftware.Location = New System.Drawing.Point(24, 75)
        Me.PnlSoftware.Name = "PnlSoftware"
        Me.PnlSoftware.Size = New System.Drawing.Size(1008, 156)
        Me.PnlSoftware.TabIndex = 25
        Me.PnlSoftware.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(680, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 20)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Tipo Software"
        '
        'CboTipoSoftware
        '
        Me.CboTipoSoftware.BackColor = System.Drawing.Color.White
        Me.CboTipoSoftware.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTipoSoftware.FormattingEnabled = True
        Me.CboTipoSoftware.Location = New System.Drawing.Point(796, 109)
        Me.CboTipoSoftware.Name = "CboTipoSoftware"
        Me.CboTipoSoftware.Size = New System.Drawing.Size(177, 24)
        Me.CboTipoSoftware.TabIndex = 34
        '
        'TxtTamaño
        '
        Me.TxtTamaño.Location = New System.Drawing.Point(796, 21)
        Me.TxtTamaño.Name = "TxtTamaño"
        Me.TxtTamaño.Size = New System.Drawing.Size(177, 22)
        Me.TxtTamaño.TabIndex = 33
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(728, 21)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(62, 20)
        Me.Label25.TabIndex = 32
        Me.Label25.Text = "Tamaño"
        '
        'CboEditor
        '
        Me.CboEditor.BackColor = System.Drawing.Color.White
        Me.CboEditor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboEditor.FormattingEnabled = True
        Me.CboEditor.Location = New System.Drawing.Point(166, 109)
        Me.CboEditor.Name = "CboEditor"
        Me.CboEditor.Size = New System.Drawing.Size(265, 24)
        Me.CboEditor.TabIndex = 31
        '
        'TxtVersion
        '
        Me.TxtVersion.Location = New System.Drawing.Point(796, 53)
        Me.TxtVersion.Name = "TxtVersion"
        Me.TxtVersion.Size = New System.Drawing.Size(177, 22)
        Me.TxtVersion.TabIndex = 30
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Location = New System.Drawing.Point(166, 77)
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(508, 22)
        Me.TxtDescripcion.TabIndex = 28
        '
        'TxtNombreSoftware
        '
        Me.TxtNombreSoftware.Location = New System.Drawing.Point(166, 48)
        Me.TxtNombreSoftware.Name = "TxtNombreSoftware"
        Me.TxtNombreSoftware.Size = New System.Drawing.Size(508, 22)
        Me.TxtNombreSoftware.TabIndex = 27
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(55, 109)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(105, 20)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "Desarrollador"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(725, 53)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(61, 20)
        Me.Label16.TabIndex = 25
        Me.Label16.Text = "Versión"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(69, 79)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(90, 20)
        Me.Label17.TabIndex = 24
        Me.Label17.Text = "Descripción"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(10, 50)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(149, 20)
        Me.Label18.TabIndex = 23
        Me.Label18.Text = "Nombre de Sofware"
        '
        'TxtCodigoSoftware
        '
        Me.TxtCodigoSoftware.Location = New System.Drawing.Point(166, 19)
        Me.TxtCodigoSoftware.Name = "TxtCodigoSoftware"
        Me.TxtCodigoSoftware.ReadOnly = True
        Me.TxtCodigoSoftware.Size = New System.Drawing.Size(177, 22)
        Me.TxtCodigoSoftware.TabIndex = 22
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(34, 17)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(126, 20)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "Código Software"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel3.BackgroundImage = Global.ControlKeeper.My.Resources.Resources.br
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.PictureBox4)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Location = New System.Drawing.Point(-1, 1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1058, 68)
        Me.Panel3.TabIndex = 66
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.BackgroundImage = Global.ControlKeeper.My.Resources.Resources.Install1
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(406, 5)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(51, 48)
        Me.PictureBox4.TabIndex = 35
        Me.PictureBox4.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Navy
        Me.Label14.Location = New System.Drawing.Point(456, 9)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(150, 38)
        Me.Label14.TabIndex = 34
        Me.Label14.Text = " Software"
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
        Me.BtnCancelar.Location = New System.Drawing.Point(633, 237)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(67, 51)
        Me.BtnCancelar.TabIndex = 78
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.BtnCancelar, "Cancelar")
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
        Me.BtnGuardar.Location = New System.Drawing.Point(445, 237)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(67, 51)
        Me.BtnGuardar.TabIndex = 77
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.BtnGuardar, "Guardar")
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
        Me.BtnModificar.Location = New System.Drawing.Point(538, 237)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(67, 51)
        Me.BtnModificar.TabIndex = 76
        Me.BtnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.BtnModificar, "Modificar")
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
        Me.BtnNuevo.Location = New System.Drawing.Point(352, 237)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(67, 51)
        Me.BtnNuevo.TabIndex = 75
        Me.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.BtnNuevo, "Nuevo")
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 11.25!)
        Me.Label2.Location = New System.Drawing.Point(26, 297)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 20)
        Me.Label2.TabIndex = 80
        Me.Label2.Text = "Búsqueda "
        '
        'TxtBusqueda
        '
        Me.TxtBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBusqueda.Location = New System.Drawing.Point(109, 299)
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.Size = New System.Drawing.Size(480, 21)
        Me.TxtBusqueda.TabIndex = 79
        '
        'FrmSoftware
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1056, 527)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtBusqueda)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.DgvSoftware)
        Me.Controls.Add(Me.PnlSoftware)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSoftware"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Software"
        CType(Me.DgvSoftware, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CMSSoftware.ResumeLayout(False)
        Me.PnlSoftware.ResumeLayout(False)
        Me.PnlSoftware.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgvSoftware As DataGridView
    Friend WithEvents PnlSoftware As GroupBox
    Friend WithEvents TxtTamaño As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents CboEditor As ComboBox
    Friend WithEvents TxtVersion As TextBox
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents TxtNombreSoftware As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents TxtCodigoSoftware As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label14 As Label
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents CboTipoSoftware As ComboBox
    Friend WithEvents CMSSoftware As ContextMenuStrip
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtBusqueda As TextBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
