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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmComputadora))
        Me.DgvComputadora = New System.Windows.Forms.DataGridView()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.CboModelo = New System.Windows.Forms.ComboBox()
        Me.TxtSerie = New System.Windows.Forms.TextBox()
        Me.CboRAM = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        CType(Me.DgvComputadora, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgvComputadora
        '
        Me.DgvComputadora.BackgroundColor = System.Drawing.Color.White
        Me.DgvComputadora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvComputadora.Location = New System.Drawing.Point(17, 313)
        Me.DgvComputadora.Name = "DgvComputadora"
        Me.DgvComputadora.Size = New System.Drawing.Size(602, 182)
        Me.DgvComputadora.TabIndex = 23
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.ComboBox3)
        Me.GroupBox2.Controls.Add(Me.Label59)
        Me.GroupBox2.Controls.Add(Me.ComboBox2)
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.CboModelo)
        Me.GroupBox2.Controls.Add(Me.TxtSerie)
        Me.GroupBox2.Controls.Add(Me.CboRAM)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(17, 75)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(602, 171)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(459, 56)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(112, 24)
        Me.CheckBox1.TabIndex = 32
        Me.CheckBox1.Text = "No asignada"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'ComboBox3
        '
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(151, 91)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox3.TabIndex = 31
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.Location = New System.Drawing.Point(319, 91)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(134, 20)
        Me.Label59.TabIndex = 30
        Me.Label59.Text = "Tipo Computadora"
        '
        'ComboBox2
        '
        Me.ComboBox2.BackColor = System.Drawing.Color.White
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(459, 91)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(133, 24)
        Me.ComboBox2.TabIndex = 29
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(459, 131)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(133, 24)
        Me.ComboBox1.TabIndex = 28
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(112, 91)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(36, 20)
        Me.Label20.TabIndex = 26
        Me.Label20.Text = "Año"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(108, 127)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(42, 20)
        Me.Label21.TabIndex = 25
        Me.Label21.Text = "RAM"
        '
        'CboModelo
        '
        Me.CboModelo.BackColor = System.Drawing.Color.White
        Me.CboModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboModelo.FormattingEnabled = True
        Me.CboModelo.Location = New System.Drawing.Point(151, 56)
        Me.CboModelo.Name = "CboModelo"
        Me.CboModelo.Size = New System.Drawing.Size(234, 24)
        Me.CboModelo.TabIndex = 24
        '
        'TxtSerie
        '
        Me.TxtSerie.Location = New System.Drawing.Point(151, 21)
        Me.TxtSerie.Name = "TxtSerie"
        Me.TxtSerie.Size = New System.Drawing.Size(397, 22)
        Me.TxtSerie.TabIndex = 22
        '
        'CboRAM
        '
        Me.CboRAM.BackColor = System.Drawing.Color.White
        Me.CboRAM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboRAM.FormattingEnabled = True
        Me.CboRAM.Location = New System.Drawing.Point(151, 127)
        Me.CboRAM.Name = "CboRAM"
        Me.CboRAM.Size = New System.Drawing.Size(121, 24)
        Me.CboRAM.TabIndex = 21
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(290, 131)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(163, 20)
        Me.Label22.TabIndex = 3
        Me.Label22.Text = "Tamaño de Disco Duro"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(89, 55)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(59, 20)
        Me.Label23.TabIndex = 2
        Me.Label23.Text = "Modelo"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(7, 20)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(141, 20)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "Serie Computadora"
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
        Me.BtnCancelar.Location = New System.Drawing.Point(422, 255)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(67, 51)
        Me.BtnCancelar.TabIndex = 74
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
        Me.BtnGuardar.Location = New System.Drawing.Point(234, 255)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(67, 51)
        Me.BtnGuardar.TabIndex = 73
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
        Me.BtnModificar.Location = New System.Drawing.Point(327, 255)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(67, 51)
        Me.BtnModificar.TabIndex = 72
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
        Me.BtnNuevo.Location = New System.Drawing.Point(141, 255)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(67, 51)
        Me.BtnNuevo.TabIndex = 71
        Me.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'FrmComputadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(636, 508)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.DgvComputadora)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "FrmComputadora"
        Me.Text = "Gestión de Computadora"
        CType(Me.DgvComputadora, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents DgvComputadora As DataGridView
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label59 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents CboModelo As ComboBox
    Friend WithEvents TxtSerie As TextBox
    Friend WithEvents CboRAM As ComboBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnNuevo As Button
End Class
