<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlRegistrarGrupo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctlRegistrarGrupo))
        Me.pbLimpiar = New System.Windows.Forms.PictureBox
        Me.pbRegistrar = New System.Windows.Forms.PictureBox
        Me.gbxRegistrarGrupo = New System.Windows.Forms.GroupBox
        Me.pbRegistrarGrupo = New System.Windows.Forms.PictureBox
        Me.pbLimpiarForm = New System.Windows.Forms.PictureBox
        Me.gbxVendedores = New System.Windows.Forms.GroupBox
        Me.pbDeleteVendedor = New System.Windows.Forms.PictureBox
        Me.lbVendedoresDisp = New System.Windows.Forms.ListBox
        Me.pbAddVendedor = New System.Windows.Forms.PictureBox
        Me.lbVendedores = New System.Windows.Forms.ListBox
        Me.gbxServicios = New System.Windows.Forms.GroupBox
        Me.lbServicios = New System.Windows.Forms.ListBox
        Me.lbServiciosDisp = New System.Windows.Forms.ListBox
        Me.pbDeleteServicio = New System.Windows.Forms.PictureBox
        Me.pbAddServicio = New System.Windows.Forms.PictureBox
        Me.cmbEncargado = New System.Windows.Forms.ComboBox
        Me.txtDescripcion = New System.Windows.Forms.TextBox
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.lblEncargado = New System.Windows.Forms.Label
        Me.lblDescripcion = New System.Windows.Forms.Label
        Me.lblCodigo = New System.Windows.Forms.Label
        Me.help = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.pbLimpiar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRegistrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxRegistrarGrupo.SuspendLayout()
        CType(Me.pbRegistrarGrupo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLimpiarForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxVendedores.SuspendLayout()
        CType(Me.pbDeleteVendedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbAddVendedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxServicios.SuspendLayout()
        CType(Me.pbDeleteServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbAddServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbLimpiar
        '
        Me.pbLimpiar.BackgroundImage = CType(resources.GetObject("pbLimpiar.BackgroundImage"), System.Drawing.Image)
        Me.pbLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbLimpiar.Location = New System.Drawing.Point(149, 803)
        Me.pbLimpiar.Name = "pbLimpiar"
        Me.pbLimpiar.Size = New System.Drawing.Size(33, 33)
        Me.pbLimpiar.TabIndex = 58
        Me.pbLimpiar.TabStop = False
        '
        'pbRegistrar
        '
        Me.pbRegistrar.BackgroundImage = CType(resources.GetObject("pbRegistrar.BackgroundImage"), System.Drawing.Image)
        Me.pbRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbRegistrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbRegistrar.Location = New System.Drawing.Point(91, 803)
        Me.pbRegistrar.Name = "pbRegistrar"
        Me.pbRegistrar.Size = New System.Drawing.Size(33, 33)
        Me.pbRegistrar.TabIndex = 57
        Me.pbRegistrar.TabStop = False
        '
        'gbxRegistrarGrupo
        '
        Me.gbxRegistrarGrupo.Controls.Add(Me.pbRegistrarGrupo)
        Me.gbxRegistrarGrupo.Controls.Add(Me.pbLimpiarForm)
        Me.gbxRegistrarGrupo.Controls.Add(Me.gbxVendedores)
        Me.gbxRegistrarGrupo.Controls.Add(Me.gbxServicios)
        Me.gbxRegistrarGrupo.Controls.Add(Me.cmbEncargado)
        Me.gbxRegistrarGrupo.Controls.Add(Me.txtDescripcion)
        Me.gbxRegistrarGrupo.Controls.Add(Me.txtCodigo)
        Me.gbxRegistrarGrupo.Controls.Add(Me.lblEncargado)
        Me.gbxRegistrarGrupo.Controls.Add(Me.lblDescripcion)
        Me.gbxRegistrarGrupo.Controls.Add(Me.lblCodigo)
        Me.gbxRegistrarGrupo.Font = New System.Drawing.Font("Tahoma", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxRegistrarGrupo.Location = New System.Drawing.Point(232, 30)
        Me.gbxRegistrarGrupo.Name = "gbxRegistrarGrupo"
        Me.gbxRegistrarGrupo.Size = New System.Drawing.Size(530, 519)
        Me.gbxRegistrarGrupo.TabIndex = 59
        Me.gbxRegistrarGrupo.TabStop = False
        Me.gbxRegistrarGrupo.Text = "Registrar Grupo De Ventas"
        '
        'pbRegistrarGrupo
        '
        Me.pbRegistrarGrupo.BackgroundImage = CType(resources.GetObject("pbRegistrarGrupo.BackgroundImage"), System.Drawing.Image)
        Me.pbRegistrarGrupo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbRegistrarGrupo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbRegistrarGrupo.Location = New System.Drawing.Point(411, 477)
        Me.pbRegistrarGrupo.Name = "pbRegistrarGrupo"
        Me.pbRegistrarGrupo.Size = New System.Drawing.Size(33, 33)
        Me.pbRegistrarGrupo.TabIndex = 60
        Me.pbRegistrarGrupo.TabStop = False
        Me.help.SetToolTip(Me.pbRegistrarGrupo, "Registrar")
        '
        'pbLimpiarForm
        '
        Me.pbLimpiarForm.BackgroundImage = CType(resources.GetObject("pbLimpiarForm.BackgroundImage"), System.Drawing.Image)
        Me.pbLimpiarForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbLimpiarForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbLimpiarForm.Location = New System.Drawing.Point(465, 477)
        Me.pbLimpiarForm.Name = "pbLimpiarForm"
        Me.pbLimpiarForm.Size = New System.Drawing.Size(33, 33)
        Me.pbLimpiarForm.TabIndex = 60
        Me.pbLimpiarForm.TabStop = False
        Me.help.SetToolTip(Me.pbLimpiarForm, "Limpiar")
        '
        'gbxVendedores
        '
        Me.gbxVendedores.Controls.Add(Me.pbDeleteVendedor)
        Me.gbxVendedores.Controls.Add(Me.lbVendedoresDisp)
        Me.gbxVendedores.Controls.Add(Me.pbAddVendedor)
        Me.gbxVendedores.Controls.Add(Me.lbVendedores)
        Me.gbxVendedores.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxVendedores.Location = New System.Drawing.Point(17, 323)
        Me.gbxVendedores.Name = "gbxVendedores"
        Me.gbxVendedores.Size = New System.Drawing.Size(485, 148)
        Me.gbxVendedores.TabIndex = 7
        Me.gbxVendedores.TabStop = False
        Me.gbxVendedores.Text = "Vendedores"
        '
        'pbDeleteVendedor
        '
        Me.pbDeleteVendedor.BackgroundImage = CType(resources.GetObject("pbDeleteVendedor.BackgroundImage"), System.Drawing.Image)
        Me.pbDeleteVendedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbDeleteVendedor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbDeleteVendedor.Location = New System.Drawing.Point(225, 85)
        Me.pbDeleteVendedor.Name = "pbDeleteVendedor"
        Me.pbDeleteVendedor.Size = New System.Drawing.Size(33, 33)
        Me.pbDeleteVendedor.TabIndex = 64
        Me.pbDeleteVendedor.TabStop = False
        Me.help.SetToolTip(Me.pbDeleteVendedor, "Quitar vendedor al grupo")
        '
        'lbVendedoresDisp
        '
        Me.lbVendedoresDisp.FormattingEnabled = True
        Me.lbVendedoresDisp.ItemHeight = 18
        Me.lbVendedoresDisp.Location = New System.Drawing.Point(25, 34)
        Me.lbVendedoresDisp.Name = "lbVendedoresDisp"
        Me.lbVendedoresDisp.Size = New System.Drawing.Size(188, 94)
        Me.lbVendedoresDisp.TabIndex = 1
        '
        'pbAddVendedor
        '
        Me.pbAddVendedor.BackgroundImage = CType(resources.GetObject("pbAddVendedor.BackgroundImage"), System.Drawing.Image)
        Me.pbAddVendedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbAddVendedor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbAddVendedor.Location = New System.Drawing.Point(225, 46)
        Me.pbAddVendedor.Name = "pbAddVendedor"
        Me.pbAddVendedor.Size = New System.Drawing.Size(33, 33)
        Me.pbAddVendedor.TabIndex = 63
        Me.pbAddVendedor.TabStop = False
        Me.help.SetToolTip(Me.pbAddVendedor, "Asignar vendedor al grupo")
        '
        'lbVendedores
        '
        Me.lbVendedores.FormattingEnabled = True
        Me.lbVendedores.ItemHeight = 18
        Me.lbVendedores.Location = New System.Drawing.Point(270, 34)
        Me.lbVendedores.Name = "lbVendedores"
        Me.lbVendedores.Size = New System.Drawing.Size(188, 94)
        Me.lbVendedores.TabIndex = 0
        '
        'gbxServicios
        '
        Me.gbxServicios.Controls.Add(Me.lbServicios)
        Me.gbxServicios.Controls.Add(Me.lbServiciosDisp)
        Me.gbxServicios.Controls.Add(Me.pbDeleteServicio)
        Me.gbxServicios.Controls.Add(Me.pbAddServicio)
        Me.gbxServicios.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxServicios.Location = New System.Drawing.Point(17, 169)
        Me.gbxServicios.Name = "gbxServicios"
        Me.gbxServicios.Size = New System.Drawing.Size(485, 148)
        Me.gbxServicios.TabIndex = 6
        Me.gbxServicios.TabStop = False
        Me.gbxServicios.Text = "Servicios"
        '
        'lbServicios
        '
        Me.lbServicios.FormattingEnabled = True
        Me.lbServicios.ItemHeight = 18
        Me.lbServicios.Location = New System.Drawing.Point(270, 36)
        Me.lbServicios.Name = "lbServicios"
        Me.lbServicios.Size = New System.Drawing.Size(188, 94)
        Me.lbServicios.TabIndex = 1
        '
        'lbServiciosDisp
        '
        Me.lbServiciosDisp.FormattingEnabled = True
        Me.lbServiciosDisp.ItemHeight = 18
        Me.lbServiciosDisp.Location = New System.Drawing.Point(25, 36)
        Me.lbServiciosDisp.Name = "lbServiciosDisp"
        Me.lbServiciosDisp.Size = New System.Drawing.Size(188, 94)
        Me.lbServiciosDisp.TabIndex = 0
        '
        'pbDeleteServicio
        '
        Me.pbDeleteServicio.BackgroundImage = CType(resources.GetObject("pbDeleteServicio.BackgroundImage"), System.Drawing.Image)
        Me.pbDeleteServicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbDeleteServicio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbDeleteServicio.Location = New System.Drawing.Point(225, 86)
        Me.pbDeleteServicio.Name = "pbDeleteServicio"
        Me.pbDeleteServicio.Size = New System.Drawing.Size(33, 33)
        Me.pbDeleteServicio.TabIndex = 62
        Me.pbDeleteServicio.TabStop = False
        Me.help.SetToolTip(Me.pbDeleteServicio, "Quitar servicio del grupo")
        '
        'pbAddServicio
        '
        Me.pbAddServicio.BackgroundImage = CType(resources.GetObject("pbAddServicio.BackgroundImage"), System.Drawing.Image)
        Me.pbAddServicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbAddServicio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbAddServicio.Location = New System.Drawing.Point(225, 47)
        Me.pbAddServicio.Name = "pbAddServicio"
        Me.pbAddServicio.Size = New System.Drawing.Size(33, 33)
        Me.pbAddServicio.TabIndex = 61
        Me.pbAddServicio.TabStop = False
        Me.help.SetToolTip(Me.pbAddServicio, "Asignar servicio al grupo")
        '
        'cmbEncargado
        '
        Me.cmbEncargado.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEncargado.FormattingEnabled = True
        Me.cmbEncargado.Location = New System.Drawing.Point(130, 142)
        Me.cmbEncargado.Name = "cmbEncargado"
        Me.cmbEncargado.Size = New System.Drawing.Size(372, 26)
        Me.cmbEncargado.TabIndex = 5
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(130, 66)
        Me.txtDescripcion.MaxLength = 256
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(372, 71)
        Me.txtDescripcion.TabIndex = 4
        Me.help.SetToolTip(Me.txtDescripcion, "Grupo 1")
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(130, 34)
        Me.txtCodigo.MaxLength = 50
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(372, 28)
        Me.txtCodigo.TabIndex = 3
        Me.help.SetToolTip(Me.txtCodigo, "G-01")
        '
        'lblEncargado
        '
        Me.lblEncargado.AutoSize = True
        Me.lblEncargado.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEncargado.Location = New System.Drawing.Point(22, 140)
        Me.lblEncargado.Name = "lblEncargado"
        Me.lblEncargado.Size = New System.Drawing.Size(81, 18)
        Me.lblEncargado.TabIndex = 2
        Me.lblEncargado.Text = "Encargado:"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.Location = New System.Drawing.Point(22, 66)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(85, 18)
        Me.lblDescripcion.TabIndex = 1
        Me.lblDescripcion.Text = "Descripcion:"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.Location = New System.Drawing.Point(22, 34)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(56, 18)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.Text = "Codigo:"
        '
        'ctlRegistrarGrupo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Controls.Add(Me.gbxRegistrarGrupo)
        Me.Controls.Add(Me.pbLimpiar)
        Me.Controls.Add(Me.pbRegistrar)
        Me.Name = "ctlRegistrarGrupo"
        Me.Size = New System.Drawing.Size(1024, 700)
        CType(Me.pbLimpiar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRegistrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxRegistrarGrupo.ResumeLayout(False)
        Me.gbxRegistrarGrupo.PerformLayout()
        CType(Me.pbRegistrarGrupo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLimpiarForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxVendedores.ResumeLayout(False)
        CType(Me.pbDeleteVendedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbAddVendedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxServicios.ResumeLayout(False)
        CType(Me.pbDeleteServicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbAddServicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbLimpiar As System.Windows.Forms.PictureBox
    Friend WithEvents pbRegistrar As System.Windows.Forms.PictureBox
    Friend WithEvents gbxRegistrarGrupo As System.Windows.Forms.GroupBox
    Friend WithEvents pbRegistrarGrupo As System.Windows.Forms.PictureBox
    Friend WithEvents pbLimpiarForm As System.Windows.Forms.PictureBox
    Friend WithEvents gbxVendedores As System.Windows.Forms.GroupBox
    Friend WithEvents pbDeleteVendedor As System.Windows.Forms.PictureBox
    Friend WithEvents lbVendedoresDisp As System.Windows.Forms.ListBox
    Friend WithEvents pbAddVendedor As System.Windows.Forms.PictureBox
    Friend WithEvents lbVendedores As System.Windows.Forms.ListBox
    Friend WithEvents gbxServicios As System.Windows.Forms.GroupBox
    Friend WithEvents lbServicios As System.Windows.Forms.ListBox
    Friend WithEvents lbServiciosDisp As System.Windows.Forms.ListBox
    Friend WithEvents pbDeleteServicio As System.Windows.Forms.PictureBox
    Friend WithEvents pbAddServicio As System.Windows.Forms.PictureBox
    Friend WithEvents cmbEncargado As System.Windows.Forms.ComboBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents lblEncargado As System.Windows.Forms.Label
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents help As System.Windows.Forms.ToolTip

End Class
