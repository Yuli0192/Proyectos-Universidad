<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlRegistrarUsuario
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctlRegistrarUsuario))
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.lblNombre = New System.Windows.Forms.Label
        Me.pbReg = New System.Windows.Forms.PictureBox
        Me.pbLimpiar = New System.Windows.Forms.PictureBox
        Me.lblApellido1 = New System.Windows.Forms.Label
        Me.lblApellido2 = New System.Windows.Forms.Label
        Me.lblCedula = New System.Windows.Forms.Label
        Me.lblCorreo = New System.Windows.Forms.Label
        Me.txtApellido2 = New System.Windows.Forms.TextBox
        Me.txtApellido1 = New System.Windows.Forms.TextBox
        Me.txtCed = New System.Windows.Forms.TextBox
        Me.txtCorreo = New System.Windows.Forms.TextBox
        Me.txtContrasenna = New System.Windows.Forms.TextBox
        Me.lblCotrasenna = New System.Windows.Forms.Label
        Me.lblRol = New System.Windows.Forms.Label
        Me.lblDepartamento = New System.Windows.Forms.Label
        Me.cbxRol = New System.Windows.Forms.ComboBox
        Me.cbxDepartamento = New System.Windows.Forms.ComboBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.pbReg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLimpiar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(179, 89)
        Me.txtNombre.MaxLength = 30
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(181, 27)
        Me.txtNombre.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.txtNombre, "Ej: Juan")
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lblNombre.Location = New System.Drawing.Point(39, 89)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(60, 18)
        Me.lblNombre.TabIndex = 30
        Me.lblNombre.Text = "Nombre"
        '
        'pbReg
        '
        Me.pbReg.BackgroundImage = CType(resources.GetObject("pbReg.BackgroundImage"), System.Drawing.Image)
        Me.pbReg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbReg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbReg.Location = New System.Drawing.Point(284, 337)
        Me.pbReg.Name = "pbReg"
        Me.pbReg.Size = New System.Drawing.Size(30, 30)
        Me.pbReg.TabIndex = 54
        Me.pbReg.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pbReg, "Registrar")
        '
        'pbLimpiar
        '
        Me.pbLimpiar.BackgroundImage = CType(resources.GetObject("pbLimpiar.BackgroundImage"), System.Drawing.Image)
        Me.pbLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbLimpiar.Location = New System.Drawing.Point(332, 337)
        Me.pbLimpiar.Name = "pbLimpiar"
        Me.pbLimpiar.Size = New System.Drawing.Size(30, 30)
        Me.pbLimpiar.TabIndex = 55
        Me.pbLimpiar.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pbLimpiar, "Limpiar")
        '
        'lblApellido1
        '
        Me.lblApellido1.AutoSize = True
        Me.lblApellido1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido1.Location = New System.Drawing.Point(39, 123)
        Me.lblApellido1.Name = "lblApellido1"
        Me.lblApellido1.Size = New System.Drawing.Size(101, 18)
        Me.lblApellido1.TabIndex = 59
        Me.lblApellido1.Text = "Primer Apellido"
        '
        'lblApellido2
        '
        Me.lblApellido2.AutoSize = True
        Me.lblApellido2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido2.Location = New System.Drawing.Point(39, 156)
        Me.lblApellido2.Name = "lblApellido2"
        Me.lblApellido2.Size = New System.Drawing.Size(116, 18)
        Me.lblApellido2.TabIndex = 60
        Me.lblApellido2.Text = "Segundo Apellido"
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedula.Location = New System.Drawing.Point(39, 60)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(51, 18)
        Me.lblCedula.TabIndex = 61
        Me.lblCedula.Text = "Cédula"
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreo.Location = New System.Drawing.Point(39, 191)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(124, 18)
        Me.lblCorreo.TabIndex = 62
        Me.lblCorreo.Text = "Correo Electrónico"
        '
        'txtApellido2
        '
        Me.txtApellido2.Location = New System.Drawing.Point(179, 156)
        Me.txtApellido2.MaxLength = 13
        Me.txtApellido2.Name = "txtApellido2"
        Me.txtApellido2.Size = New System.Drawing.Size(181, 27)
        Me.txtApellido2.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.txtApellido2, "Ej: Gonzales")
        '
        'txtApellido1
        '
        Me.txtApellido1.Location = New System.Drawing.Point(179, 123)
        Me.txtApellido1.MaxLength = 13
        Me.txtApellido1.Name = "txtApellido1"
        Me.txtApellido1.Size = New System.Drawing.Size(181, 27)
        Me.txtApellido1.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.txtApellido1, "Ej: Gonzales")
        '
        'txtCed
        '
        Me.txtCed.Location = New System.Drawing.Point(179, 56)
        Me.txtCed.MaxLength = 13
        Me.txtCed.Name = "txtCed"
        Me.txtCed.Size = New System.Drawing.Size(181, 27)
        Me.txtCed.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txtCed, "Ej: 207050575")
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(179, 189)
        Me.txtCorreo.MaxLength = 50
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(181, 27)
        Me.txtCorreo.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.txtCorreo, "ej: tex@text.text")
        '
        'txtContrasenna
        '
        Me.txtContrasenna.Location = New System.Drawing.Point(179, 223)
        Me.txtContrasenna.MaxLength = 50
        Me.txtContrasenna.Name = "txtContrasenna"
        Me.txtContrasenna.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContrasenna.Size = New System.Drawing.Size(181, 27)
        Me.txtContrasenna.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.txtContrasenna, "123abc")
        Me.txtContrasenna.UseSystemPasswordChar = True
        '
        'lblCotrasenna
        '
        Me.lblCotrasenna.AutoSize = True
        Me.lblCotrasenna.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCotrasenna.Location = New System.Drawing.Point(39, 223)
        Me.lblCotrasenna.Name = "lblCotrasenna"
        Me.lblCotrasenna.Size = New System.Drawing.Size(82, 18)
        Me.lblCotrasenna.TabIndex = 68
        Me.lblCotrasenna.Text = "Contraseña"
        '
        'lblRol
        '
        Me.lblRol.AutoSize = True
        Me.lblRol.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRol.Location = New System.Drawing.Point(39, 257)
        Me.lblRol.Name = "lblRol"
        Me.lblRol.Size = New System.Drawing.Size(27, 18)
        Me.lblRol.TabIndex = 69
        Me.lblRol.Text = "Rol"
        '
        'lblDepartamento
        '
        Me.lblDepartamento.AutoSize = True
        Me.lblDepartamento.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartamento.Location = New System.Drawing.Point(39, 291)
        Me.lblDepartamento.Name = "lblDepartamento"
        Me.lblDepartamento.Size = New System.Drawing.Size(102, 18)
        Me.lblDepartamento.TabIndex = 70
        Me.lblDepartamento.Text = "Departamento"
        '
        'cbxRol
        '
        Me.cbxRol.DisplayMember = "Rol de usuario"
        Me.cbxRol.FormattingEnabled = True
        Me.cbxRol.Location = New System.Drawing.Point(179, 257)
        Me.cbxRol.Name = "cbxRol"
        Me.cbxRol.Size = New System.Drawing.Size(181, 27)
        Me.cbxRol.TabIndex = 7
        Me.cbxRol.ValueMember = "Rol de usuario"
        '
        'cbxDepartamento
        '
        Me.cbxDepartamento.FormattingEnabled = True
        Me.cbxDepartamento.Location = New System.Drawing.Point(179, 291)
        Me.cbxDepartamento.Name = "cbxDepartamento"
        Me.cbxDepartamento.Size = New System.Drawing.Size(181, 27)
        Me.cbxDepartamento.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.cbxDepartamento, "Departamento al que pertenecerá el usuario")
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1024, 700)
        Me.Panel1.TabIndex = 74
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbxDepartamento)
        Me.GroupBox1.Controls.Add(Me.cbxRol)
        Me.GroupBox1.Controls.Add(Me.lblDepartamento)
        Me.GroupBox1.Controls.Add(Me.pbLimpiar)
        Me.GroupBox1.Controls.Add(Me.lblRol)
        Me.GroupBox1.Controls.Add(Me.pbReg)
        Me.GroupBox1.Controls.Add(Me.lblCotrasenna)
        Me.GroupBox1.Controls.Add(Me.txtContrasenna)
        Me.GroupBox1.Controls.Add(Me.txtCorreo)
        Me.GroupBox1.Controls.Add(Me.txtCed)
        Me.GroupBox1.Controls.Add(Me.txtApellido1)
        Me.GroupBox1.Controls.Add(Me.txtApellido2)
        Me.GroupBox1.Controls.Add(Me.lblCorreo)
        Me.GroupBox1.Controls.Add(Me.lblCedula)
        Me.GroupBox1.Controls.Add(Me.lblApellido2)
        Me.GroupBox1.Controls.Add(Me.lblApellido1)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.lblNombre)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(279, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(419, 401)
        Me.GroupBox1.TabIndex = 74
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registrar Usuario"
        '
        'ctlRegistrarUsuario
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ctlRegistrarUsuario"
        Me.Size = New System.Drawing.Size(1024, 700)
        CType(Me.pbReg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLimpiar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents pbReg As System.Windows.Forms.PictureBox
    Friend WithEvents pbLimpiar As System.Windows.Forms.PictureBox
    Friend WithEvents lblApellido1 As System.Windows.Forms.Label
    Friend WithEvents lblApellido2 As System.Windows.Forms.Label
    Friend WithEvents lblCedula As System.Windows.Forms.Label
    Friend WithEvents lblCorreo As System.Windows.Forms.Label
    Friend WithEvents txtApellido2 As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido1 As System.Windows.Forms.TextBox
    Friend WithEvents txtCed As System.Windows.Forms.TextBox
    Friend WithEvents txtCorreo As System.Windows.Forms.TextBox
    Friend WithEvents txtContrasenna As System.Windows.Forms.TextBox
    Friend WithEvents lblCotrasenna As System.Windows.Forms.Label
    Friend WithEvents lblRol As System.Windows.Forms.Label
    Friend WithEvents lblDepartamento As System.Windows.Forms.Label
    Friend WithEvents cbxRol As System.Windows.Forms.ComboBox
    Friend WithEvents cbxDepartamento As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
