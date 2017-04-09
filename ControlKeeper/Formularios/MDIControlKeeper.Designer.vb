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
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.BtnEmpleado = New System.Windows.Forms.Button()
        Me.BtnOcultar = New System.Windows.Forms.Button()
        Me.BtnUsuario = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PnlDespliegue = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PnlMenu = New System.Windows.Forms.Panel()
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.PnlDespliegue.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MenuStrip.BackgroundImage = Global.ControlKeeper.My.Resources.Resources.imagen_prueb
        Me.MenuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(31, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1318, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "&Archivo"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(31, 707)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1318, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'Button6
        '
        Me.Button6.BackgroundImage = Global.ControlKeeper.My.Resources.Resources.Imagen21
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Location = New System.Drawing.Point(105, 356)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(67, 65)
        Me.Button6.TabIndex = 5
        Me.ToolTip.SetToolTip(Me.Button6, "Software")
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackgroundImage = Global.ControlKeeper.My.Resources.Resources.Imagen22
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(78, 180)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(67, 65)
        Me.Button5.TabIndex = 4
        Me.ToolTip.SetToolTip(Me.Button5, "Computadora")
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.ControlKeeper.My.Resources.Resources.Imagen18
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(98, 268)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(67, 65)
        Me.Button4.TabIndex = 3
        Me.ToolTip.SetToolTip(Me.Button4, "Mantenimiento")
        Me.Button4.UseVisualStyleBackColor = True
        '
        'BtnEmpleado
        '
        Me.BtnEmpleado.BackgroundImage = Global.ControlKeeper.My.Resources.Resources.Imagen16
        Me.BtnEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnEmpleado.FlatAppearance.BorderSize = 0
        Me.BtnEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEmpleado.Location = New System.Drawing.Point(53, 99)
        Me.BtnEmpleado.Name = "BtnEmpleado"
        Me.BtnEmpleado.Size = New System.Drawing.Size(67, 65)
        Me.BtnEmpleado.TabIndex = 2
        Me.ToolTip.SetToolTip(Me.BtnEmpleado, "Empleado")
        Me.BtnEmpleado.UseVisualStyleBackColor = True
        '
        'BtnOcultar
        '
        Me.BtnOcultar.BackColor = System.Drawing.Color.White
        Me.BtnOcultar.BackgroundImage = Global.ControlKeeper.My.Resources.Resources.tachuela2
        Me.BtnOcultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnOcultar.Location = New System.Drawing.Point(126, 18)
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
        Me.BtnUsuario.Location = New System.Drawing.Point(15, 26)
        Me.BtnUsuario.Name = "BtnUsuario"
        Me.BtnUsuario.Size = New System.Drawing.Size(67, 65)
        Me.BtnUsuario.TabIndex = 0
        Me.ToolTip.SetToolTip(Me.BtnUsuario, "Usuario")
        Me.BtnUsuario.UseVisualStyleBackColor = True
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
        Me.PnlDespliegue.Controls.Add(Me.Panel2)
        Me.PnlDespliegue.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnlDespliegue.Location = New System.Drawing.Point(0, 0)
        Me.PnlDespliegue.Name = "PnlDespliegue"
        Me.PnlDespliegue.Size = New System.Drawing.Size(31, 729)
        Me.PnlDespliegue.TabIndex = 0
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
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.ControlKeeper.My.Resources.Resources.Ultimate_Material_Lollipop_Collection1
        Me.Panel1.Controls.Add(Me.Label54)
        Me.Panel1.Controls.Add(Me.PictureBox1)
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
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.ControlKeeper.My.Resources.Resources.Logo_Control_Keeper
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(41, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(67, 75)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PnlMenu
        '
        Me.PnlMenu.BackColor = System.Drawing.Color.Transparent
        Me.PnlMenu.BackgroundImage = Global.ControlKeeper.My.Resources.Resources.dar
        Me.PnlMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PnlMenu.Controls.Add(Me.Button6)
        Me.PnlMenu.Controls.Add(Me.Button5)
        Me.PnlMenu.Controls.Add(Me.Button4)
        Me.PnlMenu.Controls.Add(Me.BtnEmpleado)
        Me.PnlMenu.Controls.Add(Me.BtnOcultar)
        Me.PnlMenu.Controls.Add(Me.BtnUsuario)
        Me.PnlMenu.Location = New System.Drawing.Point(30, 110)
        Me.PnlMenu.Name = "PnlMenu"
        Me.PnlMenu.Size = New System.Drawing.Size(207, 619)
        Me.PnlMenu.TabIndex = 10
        '
        'MDIControlKeeper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.BackgroundImage = Global.ControlKeeper.My.Resources.Resources.md1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1349, 729)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PnlDespliegue)
        Me.Controls.Add(Me.PnlMenu)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
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
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents Label54 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BtnUsuario As Button
    Friend WithEvents PnlDespliegue As Panel
    Friend WithEvents BtnOcultar As Button
    Friend WithEvents BtnEmpleado As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PnlMenu As Panel
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel2 As Panel
End Class
