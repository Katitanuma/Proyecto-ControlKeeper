<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCapacidadRAM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCapacidadRAM))
        Me.DgvCapacidadMemoriaRAM = New System.Windows.Forms.DataGridView()
        Me.CMSCapacidadRAM = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PnlCapacidadMemoriaRAM = New System.Windows.Forms.GroupBox()
        Me.TxtCapacidadRAM = New System.Windows.Forms.TextBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.TxtIdCapacidadRAM = New System.Windows.Forms.TextBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.DgvCapacidadMemoriaRAM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CMSCapacidadRAM.SuspendLayout()
        Me.PnlCapacidadMemoriaRAM.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvCapacidadMemoriaRAM
        '
        Me.DgvCapacidadMemoriaRAM.AllowUserToAddRows = False
        Me.DgvCapacidadMemoriaRAM.AllowUserToDeleteRows = False
        Me.DgvCapacidadMemoriaRAM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvCapacidadMemoriaRAM.BackgroundColor = System.Drawing.Color.White
        Me.DgvCapacidadMemoriaRAM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCapacidadMemoriaRAM.ContextMenuStrip = Me.CMSCapacidadRAM
        Me.DgvCapacidadMemoriaRAM.Location = New System.Drawing.Point(37, 273)
        Me.DgvCapacidadMemoriaRAM.Name = "DgvCapacidadMemoriaRAM"
        Me.DgvCapacidadMemoriaRAM.ReadOnly = True
        Me.DgvCapacidadMemoriaRAM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvCapacidadMemoriaRAM.Size = New System.Drawing.Size(448, 205)
        Me.DgvCapacidadMemoriaRAM.TabIndex = 72
        '
        'CMSCapacidadRAM
        '
        Me.CMSCapacidadRAM.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.CMSCapacidadRAM.Name = "CMSCapacidadRAM"
        Me.CMSCapacidadRAM.Size = New System.Drawing.Size(118, 48)
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
        'PnlCapacidadMemoriaRAM
        '
        Me.PnlCapacidadMemoriaRAM.Controls.Add(Me.TxtCapacidadRAM)
        Me.PnlCapacidadMemoriaRAM.Controls.Add(Me.Label50)
        Me.PnlCapacidadMemoriaRAM.Controls.Add(Me.TxtIdCapacidadRAM)
        Me.PnlCapacidadMemoriaRAM.Controls.Add(Me.Label51)
        Me.PnlCapacidadMemoriaRAM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PnlCapacidadMemoriaRAM.Location = New System.Drawing.Point(37, 80)
        Me.PnlCapacidadMemoriaRAM.Name = "PnlCapacidadMemoriaRAM"
        Me.PnlCapacidadMemoriaRAM.Size = New System.Drawing.Size(448, 85)
        Me.PnlCapacidadMemoriaRAM.TabIndex = 71
        Me.PnlCapacidadMemoriaRAM.TabStop = False
        '
        'TxtCapacidadRAM
        '
        Me.TxtCapacidadRAM.Location = New System.Drawing.Point(210, 53)
        Me.TxtCapacidadRAM.Name = "TxtCapacidadRAM"
        Me.TxtCapacidadRAM.Size = New System.Drawing.Size(198, 22)
        Me.TxtCapacidadRAM.TabIndex = 27
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.Location = New System.Drawing.Point(6, 53)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(201, 20)
        Me.Label50.TabIndex = 23
        Me.Label50.Text = "Capacidad de Memoria RAM"
        '
        'TxtIdCapacidadRAM
        '
        Me.TxtIdCapacidadRAM.Location = New System.Drawing.Point(210, 21)
        Me.TxtIdCapacidadRAM.Name = "TxtIdCapacidadRAM"
        Me.TxtIdCapacidadRAM.ReadOnly = True
        Me.TxtIdCapacidadRAM.Size = New System.Drawing.Size(142, 22)
        Me.TxtIdCapacidadRAM.TabIndex = 22
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.Location = New System.Drawing.Point(39, 21)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(167, 20)
        Me.Label51.TabIndex = 0
        Me.Label51.Text = "Código Capacidad RAM"
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
        Me.BtnCancelar.Location = New System.Drawing.Point(368, 181)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(67, 51)
        Me.BtnCancelar.TabIndex = 76
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
        Me.BtnGuardar.Location = New System.Drawing.Point(180, 181)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(67, 51)
        Me.BtnGuardar.TabIndex = 75
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
        Me.BtnModificar.Location = New System.Drawing.Point(273, 181)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(67, 51)
        Me.BtnModificar.TabIndex = 74
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
        Me.BtnNuevo.Location = New System.Drawing.Point(87, 181)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(67, 51)
        Me.BtnNuevo.TabIndex = 73
        Me.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.BtnNuevo, "Nuevo")
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel1.BackgroundImage = Global.ControlKeeper.My.Resources.Resources.br
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.PictureBox10)
        Me.Panel1.Controls.Add(Me.Label45)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(527, 74)
        Me.Panel1.TabIndex = 70
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox10.BackgroundImage = Global.ControlKeeper.My.Resources.Resources.ram_98420_960_720
        Me.PictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox10.Location = New System.Drawing.Point(20, 0)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(73, 62)
        Me.PictureBox10.TabIndex = 39
        Me.PictureBox10.TabStop = False
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.BackColor = System.Drawing.Color.Transparent
        Me.Label45.Font = New System.Drawing.Font("Comic Sans MS", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.Navy
        Me.Label45.Location = New System.Drawing.Point(94, 12)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(412, 40)
        Me.Label45.TabIndex = 25
        Me.Label45.Text = "Capacidad de Memoria RAM"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 11.25!)
        Me.Label1.Location = New System.Drawing.Point(34, 245)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 20)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Búsqueda "
        '
        'TxtBusqueda
        '
        Me.TxtBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBusqueda.Location = New System.Drawing.Point(111, 246)
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.Size = New System.Drawing.Size(374, 21)
        Me.TxtBusqueda.TabIndex = 77
        '
        'FrmCapacidadRAM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(526, 490)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtBusqueda)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.DgvCapacidadMemoriaRAM)
        Me.Controls.Add(Me.PnlCapacidadMemoriaRAM)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCapacidadRAM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Gestión de Capacidad de RAM"
        CType(Me.DgvCapacidadMemoriaRAM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CMSCapacidadRAM.ResumeLayout(False)
        Me.PnlCapacidadMemoriaRAM.ResumeLayout(False)
        Me.PnlCapacidadMemoriaRAM.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents DgvCapacidadMemoriaRAM As DataGridView
    Friend WithEvents PnlCapacidadMemoriaRAM As GroupBox
    Friend WithEvents TxtCapacidadRAM As TextBox
    Friend WithEvents Label50 As Label
    Friend WithEvents TxtIdCapacidadRAM As TextBox
    Friend WithEvents Label51 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label45 As Label
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents CMSCapacidadRAM As ContextMenuStrip
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtBusqueda As TextBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
