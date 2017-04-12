<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmComputadora
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmComputadora))
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.DgvComputadora = New System.Windows.Forms.DataGridView()
        Me.CmsComputadora = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlComputadora = New System.Windows.Forms.GroupBox()
        Me.ChkTeclado = New System.Windows.Forms.CheckBox()
        Me.ChkMouse = New System.Windows.Forms.CheckBox()
        Me.CboMarca = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ChkEstado = New System.Windows.Forms.CheckBox()
        Me.CboAño = New System.Windows.Forms.ComboBox()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.CboTipoComputadora = New System.Windows.Forms.ComboBox()
        Me.CboCapacidadDiscoDuro = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.CboModelo = New System.Windows.Forms.ComboBox()
        Me.TxtSerie = New System.Windows.Forms.TextBox()
        Me.CboRAM = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.DgvComputadora, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CmsComputadora.SuspendLayout()
        Me.PlComputadora.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label13.Location = New System.Drawing.Point(226, 12)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(195, 38)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = " Computadora"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = Global.ControlKeeper.My.Resources.Resources.computadora
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(177, 7)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(51, 47)
        Me.PictureBox3.TabIndex = 24
        Me.PictureBox3.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel3.BackgroundImage = Global.ControlKeeper.My.Resources.Resources.br
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.PictureBox3)
        Me.Panel3.Location = New System.Drawing.Point(-1, -2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(637, 68)
        Me.Panel3.TabIndex = 64
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
        Me.BtnCancelar.Location = New System.Drawing.Point(417, 259)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(67, 51)
        Me.BtnCancelar.TabIndex = 80
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
        Me.BtnGuardar.Location = New System.Drawing.Point(229, 259)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(67, 51)
        Me.BtnGuardar.TabIndex = 79
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
        Me.BtnModificar.Location = New System.Drawing.Point(322, 260)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(67, 51)
        Me.BtnModificar.TabIndex = 78
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
        Me.BtnNuevo.Location = New System.Drawing.Point(136, 259)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(67, 51)
        Me.BtnNuevo.TabIndex = 77
        Me.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'DgvComputadora
        '
        Me.DgvComputadora.AllowUserToAddRows = False
        Me.DgvComputadora.AllowUserToDeleteRows = False
        Me.DgvComputadora.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvComputadora.BackgroundColor = System.Drawing.Color.White
        Me.DgvComputadora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvComputadora.ContextMenuStrip = Me.CmsComputadora
        Me.DgvComputadora.Location = New System.Drawing.Point(12, 353)
        Me.DgvComputadora.Name = "DgvComputadora"
        Me.DgvComputadora.ReadOnly = True
        Me.DgvComputadora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvComputadora.Size = New System.Drawing.Size(602, 182)
        Me.DgvComputadora.TabIndex = 76
        '
        'CmsComputadora
        '
        Me.CmsComputadora.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.CmsComputadora.Name = "CmsComputadora"
        Me.CmsComputadora.Size = New System.Drawing.Size(118, 48)
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
        'PlComputadora
        '
        Me.PlComputadora.Controls.Add(Me.ChkTeclado)
        Me.PlComputadora.Controls.Add(Me.ChkMouse)
        Me.PlComputadora.Controls.Add(Me.CboMarca)
        Me.PlComputadora.Controls.Add(Me.Label1)
        Me.PlComputadora.Controls.Add(Me.ChkEstado)
        Me.PlComputadora.Controls.Add(Me.CboAño)
        Me.PlComputadora.Controls.Add(Me.Label59)
        Me.PlComputadora.Controls.Add(Me.CboTipoComputadora)
        Me.PlComputadora.Controls.Add(Me.CboCapacidadDiscoDuro)
        Me.PlComputadora.Controls.Add(Me.Label20)
        Me.PlComputadora.Controls.Add(Me.Label21)
        Me.PlComputadora.Controls.Add(Me.CboModelo)
        Me.PlComputadora.Controls.Add(Me.TxtSerie)
        Me.PlComputadora.Controls.Add(Me.CboRAM)
        Me.PlComputadora.Controls.Add(Me.Label22)
        Me.PlComputadora.Controls.Add(Me.Label23)
        Me.PlComputadora.Controls.Add(Me.Label24)
        Me.PlComputadora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlComputadora.Location = New System.Drawing.Point(12, 75)
        Me.PlComputadora.Name = "PlComputadora"
        Me.PlComputadora.Size = New System.Drawing.Size(602, 179)
        Me.PlComputadora.TabIndex = 75
        Me.PlComputadora.TabStop = False
        '
        'ChkTeclado
        '
        Me.ChkTeclado.AutoSize = True
        Me.ChkTeclado.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkTeclado.Location = New System.Drawing.Point(459, 63)
        Me.ChkTeclado.Name = "ChkTeclado"
        Me.ChkTeclado.Size = New System.Drawing.Size(83, 24)
        Me.ChkTeclado.TabIndex = 36
        Me.ChkTeclado.Text = "Teclado"
        Me.ChkTeclado.UseVisualStyleBackColor = True
        '
        'ChkMouse
        '
        Me.ChkMouse.AutoSize = True
        Me.ChkMouse.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkMouse.Location = New System.Drawing.Point(459, 42)
        Me.ChkMouse.Name = "ChkMouse"
        Me.ChkMouse.Size = New System.Drawing.Size(72, 24)
        Me.ChkMouse.TabIndex = 35
        Me.ChkMouse.Text = "Mouse"
        Me.ChkMouse.UseVisualStyleBackColor = True
        '
        'CboMarca
        '
        Me.CboMarca.BackColor = System.Drawing.Color.White
        Me.CboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboMarca.FormattingEnabled = True
        Me.CboMarca.Location = New System.Drawing.Point(151, 46)
        Me.CboMarca.Name = "CboMarca"
        Me.CboMarca.Size = New System.Drawing.Size(234, 24)
        Me.CboMarca.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(89, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 20)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Marca"
        '
        'ChkEstado
        '
        Me.ChkEstado.AutoSize = True
        Me.ChkEstado.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkEstado.Location = New System.Drawing.Point(459, 84)
        Me.ChkEstado.Name = "ChkEstado"
        Me.ChkEstado.Size = New System.Drawing.Size(112, 24)
        Me.ChkEstado.TabIndex = 32
        Me.ChkEstado.Text = "No asignada"
        Me.ChkEstado.UseVisualStyleBackColor = True
        '
        'CboAño
        '
        Me.CboAño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboAño.FormattingEnabled = True
        Me.CboAño.Location = New System.Drawing.Point(151, 107)
        Me.CboAño.Name = "CboAño"
        Me.CboAño.Size = New System.Drawing.Size(121, 24)
        Me.CboAño.TabIndex = 31
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.Location = New System.Drawing.Point(319, 107)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(134, 20)
        Me.Label59.TabIndex = 30
        Me.Label59.Text = "Tipo Computadora"
        '
        'CboTipoComputadora
        '
        Me.CboTipoComputadora.BackColor = System.Drawing.Color.White
        Me.CboTipoComputadora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTipoComputadora.FormattingEnabled = True
        Me.CboTipoComputadora.Location = New System.Drawing.Point(459, 107)
        Me.CboTipoComputadora.Name = "CboTipoComputadora"
        Me.CboTipoComputadora.Size = New System.Drawing.Size(133, 24)
        Me.CboTipoComputadora.TabIndex = 29
        '
        'CboCapacidadDiscoDuro
        '
        Me.CboCapacidadDiscoDuro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCapacidadDiscoDuro.FormattingEnabled = True
        Me.CboCapacidadDiscoDuro.Location = New System.Drawing.Point(459, 147)
        Me.CboCapacidadDiscoDuro.Name = "CboCapacidadDiscoDuro"
        Me.CboCapacidadDiscoDuro.Size = New System.Drawing.Size(133, 24)
        Me.CboCapacidadDiscoDuro.TabIndex = 28
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(112, 107)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(36, 20)
        Me.Label20.TabIndex = 26
        Me.Label20.Text = "Año"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(108, 143)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(42, 20)
        Me.Label21.TabIndex = 25
        Me.Label21.Text = "RAM"
        '
        'CboModelo
        '
        Me.CboModelo.BackColor = System.Drawing.Color.White
        Me.CboModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboModelo.Enabled = False
        Me.CboModelo.FormattingEnabled = True
        Me.CboModelo.Location = New System.Drawing.Point(151, 76)
        Me.CboModelo.Name = "CboModelo"
        Me.CboModelo.Size = New System.Drawing.Size(234, 24)
        Me.CboModelo.TabIndex = 24
        '
        'TxtSerie
        '
        Me.TxtSerie.Location = New System.Drawing.Point(151, 19)
        Me.TxtSerie.Name = "TxtSerie"
        Me.TxtSerie.Size = New System.Drawing.Size(397, 22)
        Me.TxtSerie.TabIndex = 22
        '
        'CboRAM
        '
        Me.CboRAM.BackColor = System.Drawing.Color.White
        Me.CboRAM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboRAM.FormattingEnabled = True
        Me.CboRAM.Location = New System.Drawing.Point(151, 143)
        Me.CboRAM.Name = "CboRAM"
        Me.CboRAM.Size = New System.Drawing.Size(121, 24)
        Me.CboRAM.TabIndex = 21
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(290, 147)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(163, 20)
        Me.Label22.TabIndex = 3
        Me.Label22.Text = "Tamaño de Disco Duro"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(89, 76)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(59, 20)
        Me.Label23.TabIndex = 2
        Me.Label23.Text = "Modelo"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(7, 18)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(141, 20)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "Serie Computadora"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 11.25!)
        Me.Label2.Location = New System.Drawing.Point(15, 325)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 20)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "Busqueda "
        '
        'TxtBusqueda
        '
        Me.TxtBusqueda.Location = New System.Drawing.Point(94, 327)
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.Size = New System.Drawing.Size(520, 20)
        Me.TxtBusqueda.TabIndex = 81
        '
        'FrmComputadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(636, 547)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtBusqueda)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.DgvComputadora)
        Me.Controls.Add(Me.PlComputadora)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "FrmComputadora"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Gestión de Computadora"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DgvComputadora, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CmsComputadora.ResumeLayout(False)
        Me.PlComputadora.ResumeLayout(False)
        Me.PlComputadora.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents DgvComputadora As DataGridView
    Friend WithEvents PlComputadora As GroupBox
    Friend WithEvents ChkTeclado As CheckBox
    Friend WithEvents ChkMouse As CheckBox
    Friend WithEvents CboMarca As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ChkEstado As CheckBox
    Friend WithEvents CboAño As ComboBox
    Friend WithEvents Label59 As Label
    Friend WithEvents CboTipoComputadora As ComboBox
    Friend WithEvents CboCapacidadDiscoDuro As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents CboModelo As ComboBox
    Friend WithEvents TxtSerie As TextBox
    Friend WithEvents CboRAM As ComboBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents CmsComputadora As ContextMenuStrip
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtBusqueda As TextBox
End Class
