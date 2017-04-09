<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModelo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmModelo))
        Me.DataGridView7 = New System.Windows.Forms.DataGridView()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Button29 = New System.Windows.Forms.Button()
        Me.ComboBox12 = New System.Windows.Forms.ComboBox()
        Me.TextBox24 = New System.Windows.Forms.TextBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.TextBox25 = New System.Windows.Forms.TextBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        CType(Me.DataGridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView7
        '
        Me.DataGridView7.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView7.Location = New System.Drawing.Point(27, 277)
        Me.DataGridView7.Name = "DataGridView7"
        Me.DataGridView7.Size = New System.Drawing.Size(551, 216)
        Me.DataGridView7.TabIndex = 49
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Button29)
        Me.GroupBox7.Controls.Add(Me.ComboBox12)
        Me.GroupBox7.Controls.Add(Me.TextBox24)
        Me.GroupBox7.Controls.Add(Me.Label47)
        Me.GroupBox7.Controls.Add(Me.Label50)
        Me.GroupBox7.Controls.Add(Me.TextBox25)
        Me.GroupBox7.Controls.Add(Me.Label51)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(27, 72)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(551, 139)
        Me.GroupBox7.TabIndex = 47
        Me.GroupBox7.TabStop = False
        '
        'Button29
        '
        Me.Button29.Location = New System.Drawing.Point(373, 91)
        Me.Button29.Name = "Button29"
        Me.Button29.Size = New System.Drawing.Size(39, 26)
        Me.Button29.TabIndex = 32
        Me.Button29.Text = "..."
        Me.Button29.UseVisualStyleBackColor = True
        '
        'ComboBox12
        '
        Me.ComboBox12.BackColor = System.Drawing.Color.White
        Me.ComboBox12.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox12.FormattingEnabled = True
        Me.ComboBox12.Location = New System.Drawing.Point(133, 92)
        Me.ComboBox12.Name = "ComboBox12"
        Me.ComboBox12.Size = New System.Drawing.Size(234, 24)
        Me.ComboBox12.TabIndex = 31
        '
        'TextBox24
        '
        Me.TextBox24.Location = New System.Drawing.Point(133, 58)
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New System.Drawing.Size(376, 22)
        Me.TextBox24.TabIndex = 27
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.Location = New System.Drawing.Point(72, 94)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(53, 20)
        Me.Label47.TabIndex = 26
        Me.Label47.Text = "Marca"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.Location = New System.Drawing.Point(68, 58)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(59, 20)
        Me.Label50.TabIndex = 23
        Me.Label50.Text = "Modelo"
        '
        'TextBox25
        '
        Me.TextBox25.Location = New System.Drawing.Point(133, 26)
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.ReadOnly = True
        Me.TextBox25.Size = New System.Drawing.Size(155, 22)
        Me.TextBox25.TabIndex = 22
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.Location = New System.Drawing.Point(18, 24)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(109, 20)
        Me.Label51.TabIndex = 0
        Me.Label51.Text = "Código Modelo"
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox8.BackgroundImage = Global.ControlKeeper.My.Resources.Resources.laptop_png_laptop_hi
        Me.PictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox8.Location = New System.Drawing.Point(190, 6)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(58, 48)
        Me.PictureBox8.TabIndex = 50
        Me.PictureBox8.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel3.BackgroundImage = Global.ControlKeeper.My.Resources.Resources.br
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.PictureBox8)
        Me.Panel3.Location = New System.Drawing.Point(-2, -3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(609, 68)
        Me.Panel3.TabIndex = 65
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label13.Location = New System.Drawing.Point(258, 10)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(107, 38)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Modelo"
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
        Me.BtnCancelar.Location = New System.Drawing.Point(407, 219)
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
        Me.BtnGuardar.Location = New System.Drawing.Point(219, 219)
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
        Me.BtnModificar.Location = New System.Drawing.Point(312, 219)
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
        Me.BtnNuevo.Location = New System.Drawing.Point(126, 219)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(67, 51)
        Me.BtnNuevo.TabIndex = 75
        Me.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'FrmModelo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(605, 508)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.DataGridView7)
        Me.Controls.Add(Me.GroupBox7)
        Me.Name = "FrmModelo"
        Me.Text = "Gestión de Modelo"
        CType(Me.DataGridView7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents DataGridView7 As DataGridView
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Button29 As Button
    Friend WithEvents ComboBox12 As ComboBox
    Friend WithEvents TextBox24 As TextBox
    Friend WithEvents Label47 As Label
    Friend WithEvents Label50 As Label
    Friend WithEvents TextBox25 As TextBox
    Friend WithEvents Label51 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnNuevo As Button
End Class
