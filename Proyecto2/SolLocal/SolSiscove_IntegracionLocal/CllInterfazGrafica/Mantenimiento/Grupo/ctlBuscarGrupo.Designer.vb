<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlBuscarGrupo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctlBuscarGrupo))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.gbxRegistrarGrupo = New System.Windows.Forms.GroupBox
        Me.pbModificar2 = New System.Windows.Forms.PictureBox
        Me.cmbEncargado = New System.Windows.Forms.ComboBox
        Me.txtDescripcion = New System.Windows.Forms.TextBox
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.lblEncargado = New System.Windows.Forms.Label
        Me.lblDescripcion = New System.Windows.Forms.Label
        Me.lblCodigo = New System.Windows.Forms.Label
        Me.gbxVendedores = New System.Windows.Forms.GroupBox
        Me.pbDeleteVendedor = New System.Windows.Forms.PictureBox
        Me.pbAddVendedor = New System.Windows.Forms.PictureBox
        Me.lbVendedoresDisp = New System.Windows.Forms.ListBox
        Me.lbVendedores = New System.Windows.Forms.ListBox
        Me.gbxServicios = New System.Windows.Forms.GroupBox
        Me.pbDeleteServicio = New System.Windows.Forms.PictureBox
        Me.pbAddServicio = New System.Windows.Forms.PictureBox
        Me.lbServicios = New System.Windows.Forms.ListBox
        Me.lbServiciosDisp = New System.Windows.Forms.ListBox
        Me.gbxBuscarGrupo = New System.Windows.Forms.GroupBox
        Me.pbVerVentasGrupo = New System.Windows.Forms.PictureBox
        Me.pbVerVentasGenerales = New System.Windows.Forms.PictureBox
        Me.pbEliminar = New System.Windows.Forms.PictureBox
        Me.pbModificar = New System.Windows.Forms.PictureBox
        Me.dvgGrupo = New System.Windows.Forms.DataGridView
        Me.txtCriterio = New System.Windows.Forms.TextBox
        Me.lblBuscar = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.pbPie = New System.Windows.Forms.PictureBox
        Me.help = New System.Windows.Forms.ToolTip(Me.components)
        Me.gbxRegistrarGrupo.SuspendLayout()
        CType(Me.pbModificar2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxVendedores.SuspendLayout()
        CType(Me.pbDeleteVendedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbAddVendedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxServicios.SuspendLayout()
        CType(Me.pbDeleteServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbAddServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxBuscarGrupo.SuspendLayout()
        CType(Me.pbVerVentasGrupo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbVerVentasGenerales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbModificar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvgGrupo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.pbPie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxRegistrarGrupo
        '
        Me.gbxRegistrarGrupo.Controls.Add(Me.pbModificar2)
        Me.gbxRegistrarGrupo.Controls.Add(Me.cmbEncargado)
        Me.gbxRegistrarGrupo.Controls.Add(Me.txtDescripcion)
        Me.gbxRegistrarGrupo.Controls.Add(Me.txtCodigo)
        Me.gbxRegistrarGrupo.Controls.Add(Me.lblEncargado)
        Me.gbxRegistrarGrupo.Controls.Add(Me.lblDescripcion)
        Me.gbxRegistrarGrupo.Controls.Add(Me.lblCodigo)
        Me.gbxRegistrarGrupo.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxRegistrarGrupo.Location = New System.Drawing.Point(470, 27)
        Me.gbxRegistrarGrupo.Name = "gbxRegistrarGrupo"
        Me.gbxRegistrarGrupo.Size = New System.Drawing.Size(442, 201)
        Me.gbxRegistrarGrupo.TabIndex = 1
        Me.gbxRegistrarGrupo.TabStop = False
        Me.gbxRegistrarGrupo.Text = "Informacion Principal"
        '
        'pbModificar2
        '
        Me.pbModificar2.BackgroundImage = CType(resources.GetObject("pbModificar2.BackgroundImage"), System.Drawing.Image)
        Me.pbModificar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbModificar2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbModificar2.Location = New System.Drawing.Point(390, 162)
        Me.pbModificar2.Name = "pbModificar2"
        Me.pbModificar2.Size = New System.Drawing.Size(30, 30)
        Me.pbModificar2.TabIndex = 59
        Me.pbModificar2.TabStop = False
        Me.help.SetToolTip(Me.pbModificar2, "Confirmar Modificación")
        '
        'cmbEncargado
        '
        Me.cmbEncargado.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEncargado.FormattingEnabled = True
        Me.cmbEncargado.Location = New System.Drawing.Point(118, 130)
        Me.cmbEncargado.Name = "cmbEncargado"
        Me.cmbEncargado.Size = New System.Drawing.Size(302, 26)
        Me.cmbEncargado.TabIndex = 5
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(118, 55)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(302, 71)
        Me.txtDescripcion.TabIndex = 4
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(118, 24)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(302, 26)
        Me.txtCodigo.TabIndex = 3
        '
        'lblEncargado
        '
        Me.lblEncargado.AutoSize = True
        Me.lblEncargado.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEncargado.Location = New System.Drawing.Point(15, 130)
        Me.lblEncargado.Name = "lblEncargado"
        Me.lblEncargado.Size = New System.Drawing.Size(81, 18)
        Me.lblEncargado.TabIndex = 2
        Me.lblEncargado.Text = "Encargado:"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.Location = New System.Drawing.Point(15, 55)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(85, 18)
        Me.lblDescripcion.TabIndex = 1
        Me.lblDescripcion.Text = "Descripcion:"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.Location = New System.Drawing.Point(15, 24)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(56, 18)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.Text = "Codigo:"
        '
        'gbxVendedores
        '
        Me.gbxVendedores.Controls.Add(Me.pbDeleteVendedor)
        Me.gbxVendedores.Controls.Add(Me.pbAddVendedor)
        Me.gbxVendedores.Controls.Add(Me.lbVendedoresDisp)
        Me.gbxVendedores.Controls.Add(Me.lbVendedores)
        Me.gbxVendedores.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxVendedores.Location = New System.Drawing.Point(470, 234)
        Me.gbxVendedores.Name = "gbxVendedores"
        Me.gbxVendedores.Size = New System.Drawing.Size(442, 130)
        Me.gbxVendedores.TabIndex = 7
        Me.gbxVendedores.TabStop = False
        Me.gbxVendedores.Text = "Vendedores"
        '
        'pbDeleteVendedor
        '
        Me.pbDeleteVendedor.BackgroundImage = CType(resources.GetObject("pbDeleteVendedor.BackgroundImage"), System.Drawing.Image)
        Me.pbDeleteVendedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbDeleteVendedor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbDeleteVendedor.Location = New System.Drawing.Point(205, 76)
        Me.pbDeleteVendedor.Name = "pbDeleteVendedor"
        Me.pbDeleteVendedor.Size = New System.Drawing.Size(33, 33)
        Me.pbDeleteVendedor.TabIndex = 83
        Me.pbDeleteVendedor.TabStop = False
        Me.help.SetToolTip(Me.pbDeleteVendedor, "Quitar Vendedor")
        '
        'pbAddVendedor
        '
        Me.pbAddVendedor.BackgroundImage = CType(resources.GetObject("pbAddVendedor.BackgroundImage"), System.Drawing.Image)
        Me.pbAddVendedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbAddVendedor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbAddVendedor.Location = New System.Drawing.Point(205, 37)
        Me.pbAddVendedor.Name = "pbAddVendedor"
        Me.pbAddVendedor.Size = New System.Drawing.Size(33, 33)
        Me.pbAddVendedor.TabIndex = 82
        Me.pbAddVendedor.TabStop = False
        Me.help.SetToolTip(Me.pbAddVendedor, "Asignar Vendedor")
        '
        'lbVendedoresDisp
        '
        Me.lbVendedoresDisp.FormattingEnabled = True
        Me.lbVendedoresDisp.ItemHeight = 18
        Me.lbVendedoresDisp.Location = New System.Drawing.Point(23, 24)
        Me.lbVendedoresDisp.Name = "lbVendedoresDisp"
        Me.lbVendedoresDisp.Size = New System.Drawing.Size(170, 94)
        Me.lbVendedoresDisp.TabIndex = 1
        '
        'lbVendedores
        '
        Me.lbVendedores.FormattingEnabled = True
        Me.lbVendedores.ItemHeight = 18
        Me.lbVendedores.Location = New System.Drawing.Point(250, 24)
        Me.lbVendedores.Name = "lbVendedores"
        Me.lbVendedores.Size = New System.Drawing.Size(170, 94)
        Me.lbVendedores.TabIndex = 0
        '
        'gbxServicios
        '
        Me.gbxServicios.Controls.Add(Me.pbDeleteServicio)
        Me.gbxServicios.Controls.Add(Me.pbAddServicio)
        Me.gbxServicios.Controls.Add(Me.lbServicios)
        Me.gbxServicios.Controls.Add(Me.lbServiciosDisp)
        Me.gbxServicios.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxServicios.Location = New System.Drawing.Point(470, 370)
        Me.gbxServicios.Name = "gbxServicios"
        Me.gbxServicios.Size = New System.Drawing.Size(442, 137)
        Me.gbxServicios.TabIndex = 6
        Me.gbxServicios.TabStop = False
        Me.gbxServicios.Text = "Servicios"
        '
        'pbDeleteServicio
        '
        Me.pbDeleteServicio.BackgroundImage = CType(resources.GetObject("pbDeleteServicio.BackgroundImage"), System.Drawing.Image)
        Me.pbDeleteServicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbDeleteServicio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbDeleteServicio.Location = New System.Drawing.Point(205, 89)
        Me.pbDeleteServicio.Name = "pbDeleteServicio"
        Me.pbDeleteServicio.Size = New System.Drawing.Size(33, 33)
        Me.pbDeleteServicio.TabIndex = 83
        Me.pbDeleteServicio.TabStop = False
        Me.help.SetToolTip(Me.pbDeleteServicio, "Quitar Servicio")
        '
        'pbAddServicio
        '
        Me.pbAddServicio.BackgroundImage = CType(resources.GetObject("pbAddServicio.BackgroundImage"), System.Drawing.Image)
        Me.pbAddServicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbAddServicio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbAddServicio.Location = New System.Drawing.Point(205, 38)
        Me.pbAddServicio.Name = "pbAddServicio"
        Me.pbAddServicio.Size = New System.Drawing.Size(33, 33)
        Me.pbAddServicio.TabIndex = 82
        Me.pbAddServicio.TabStop = False
        Me.help.SetToolTip(Me.pbAddServicio, "Asignar Servicio")
        '
        'lbServicios
        '
        Me.lbServicios.FormattingEnabled = True
        Me.lbServicios.ItemHeight = 18
        Me.lbServicios.Location = New System.Drawing.Point(250, 26)
        Me.lbServicios.Name = "lbServicios"
        Me.lbServicios.Size = New System.Drawing.Size(170, 94)
        Me.lbServicios.TabIndex = 1
        '
        'lbServiciosDisp
        '
        Me.lbServiciosDisp.FormattingEnabled = True
        Me.lbServiciosDisp.ItemHeight = 18
        Me.lbServiciosDisp.Location = New System.Drawing.Point(23, 26)
        Me.lbServiciosDisp.Name = "lbServiciosDisp"
        Me.lbServiciosDisp.Size = New System.Drawing.Size(170, 94)
        Me.lbServiciosDisp.TabIndex = 0
        '
        'gbxBuscarGrupo
        '
        Me.gbxBuscarGrupo.Controls.Add(Me.pbVerVentasGrupo)
        Me.gbxBuscarGrupo.Controls.Add(Me.pbVerVentasGenerales)
        Me.gbxBuscarGrupo.Controls.Add(Me.pbEliminar)
        Me.gbxBuscarGrupo.Controls.Add(Me.pbModificar)
        Me.gbxBuscarGrupo.Controls.Add(Me.dvgGrupo)
        Me.gbxBuscarGrupo.Controls.Add(Me.txtCriterio)
        Me.gbxBuscarGrupo.Controls.Add(Me.lblBuscar)
        Me.gbxBuscarGrupo.Controls.Add(Me.gbxRegistrarGrupo)
        Me.gbxBuscarGrupo.Controls.Add(Me.gbxVendedores)
        Me.gbxBuscarGrupo.Controls.Add(Me.gbxServicios)
        Me.gbxBuscarGrupo.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.gbxBuscarGrupo.Location = New System.Drawing.Point(16, 16)
        Me.gbxBuscarGrupo.Name = "gbxBuscarGrupo"
        Me.gbxBuscarGrupo.Size = New System.Drawing.Size(931, 526)
        Me.gbxBuscarGrupo.TabIndex = 8
        Me.gbxBuscarGrupo.TabStop = False
        Me.gbxBuscarGrupo.Text = "Buscar Grupo De Ventas"
        '
        'pbVerVentasGrupo
        '
        Me.pbVerVentasGrupo.BackgroundImage = CType(resources.GetObject("pbVerVentasGrupo.BackgroundImage"), System.Drawing.Image)
        Me.pbVerVentasGrupo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbVerVentasGrupo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbVerVentasGrupo.Location = New System.Drawing.Point(251, 433)
        Me.pbVerVentasGrupo.Name = "pbVerVentasGrupo"
        Me.pbVerVentasGrupo.Size = New System.Drawing.Size(30, 30)
        Me.pbVerVentasGrupo.TabIndex = 59
        Me.pbVerVentasGrupo.TabStop = False
        Me.help.SetToolTip(Me.pbVerVentasGrupo, "Ver Ventas ")
        '
        'pbVerVentasGenerales
        '
        Me.pbVerVentasGenerales.BackgroundImage = CType(resources.GetObject("pbVerVentasGenerales.BackgroundImage"), System.Drawing.Image)
        Me.pbVerVentasGenerales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbVerVentasGenerales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbVerVentasGenerales.Location = New System.Drawing.Point(298, 433)
        Me.pbVerVentasGenerales.Name = "pbVerVentasGenerales"
        Me.pbVerVentasGenerales.Size = New System.Drawing.Size(30, 30)
        Me.pbVerVentasGenerales.TabIndex = 58
        Me.pbVerVentasGenerales.TabStop = False
        Me.help.SetToolTip(Me.pbVerVentasGenerales, "Ver Ventas Generales")
        '
        'pbEliminar
        '
        Me.pbEliminar.BackgroundImage = CType(resources.GetObject("pbEliminar.BackgroundImage"), System.Drawing.Image)
        Me.pbEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbEliminar.Location = New System.Drawing.Point(406, 433)
        Me.pbEliminar.Name = "pbEliminar"
        Me.pbEliminar.Size = New System.Drawing.Size(30, 30)
        Me.pbEliminar.TabIndex = 57
        Me.pbEliminar.TabStop = False
        Me.help.SetToolTip(Me.pbEliminar, "Eliminar")
        '
        'pbModificar
        '
        Me.pbModificar.AccessibleDescription = ""
        Me.pbModificar.BackgroundImage = CType(resources.GetObject("pbModificar.BackgroundImage"), System.Drawing.Image)
        Me.pbModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbModificar.Location = New System.Drawing.Point(350, 433)
        Me.pbModificar.Name = "pbModificar"
        Me.pbModificar.Size = New System.Drawing.Size(30, 30)
        Me.pbModificar.TabIndex = 56
        Me.pbModificar.TabStop = False
        Me.help.SetToolTip(Me.pbModificar, "Modificar")
        '
        'dvgGrupo
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dvgGrupo.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dvgGrupo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dvgGrupo.BackgroundColor = System.Drawing.Color.White
        Me.dvgGrupo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dvgGrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgGrupo.Location = New System.Drawing.Point(22, 83)
        Me.dvgGrupo.Name = "dvgGrupo"
        Me.dvgGrupo.RowHeadersVisible = False
        Me.dvgGrupo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dvgGrupo.Size = New System.Drawing.Size(414, 338)
        Me.dvgGrupo.TabIndex = 10
        '
        'txtCriterio
        '
        Me.txtCriterio.Location = New System.Drawing.Point(81, 36)
        Me.txtCriterio.Name = "txtCriterio"
        Me.txtCriterio.Size = New System.Drawing.Size(355, 25)
        Me.txtCriterio.TabIndex = 9
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscar.Location = New System.Drawing.Point(19, 36)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(56, 18)
        Me.lblBuscar.TabIndex = 8
        Me.lblBuscar.Text = "Codigo:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.pbPie)
        Me.Panel1.Controls.Add(Me.gbxBuscarGrupo)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1000, 663)
        Me.Panel1.TabIndex = 59
        '
        'pbPie
        '
        Me.pbPie.BackgroundImage = CType(resources.GetObject("pbPie.BackgroundImage"), System.Drawing.Image)
        Me.pbPie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbPie.Location = New System.Drawing.Point(41, 614)
        Me.pbPie.Name = "pbPie"
        Me.pbPie.Size = New System.Drawing.Size(913, 42)
        Me.pbPie.TabIndex = 81
        Me.pbPie.TabStop = False
        '
        'ctlBuscarGrupo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ctlBuscarGrupo"
        Me.Size = New System.Drawing.Size(1024, 700)
        Me.gbxRegistrarGrupo.ResumeLayout(False)
        Me.gbxRegistrarGrupo.PerformLayout()
        CType(Me.pbModificar2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxVendedores.ResumeLayout(False)
        CType(Me.pbDeleteVendedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbAddVendedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxServicios.ResumeLayout(False)
        CType(Me.pbDeleteServicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbAddServicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxBuscarGrupo.ResumeLayout(False)
        Me.gbxBuscarGrupo.PerformLayout()
        CType(Me.pbVerVentasGrupo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbVerVentasGenerales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbModificar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvgGrupo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.pbPie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbxRegistrarGrupo As System.Windows.Forms.GroupBox
    Friend WithEvents gbxVendedores As System.Windows.Forms.GroupBox
    Friend WithEvents lbVendedoresDisp As System.Windows.Forms.ListBox
    Friend WithEvents lbVendedores As System.Windows.Forms.ListBox
    Friend WithEvents gbxServicios As System.Windows.Forms.GroupBox
    Friend WithEvents lbServicios As System.Windows.Forms.ListBox
    Friend WithEvents lbServiciosDisp As System.Windows.Forms.ListBox
    Friend WithEvents cmbEncargado As System.Windows.Forms.ComboBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents lblEncargado As System.Windows.Forms.Label
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents gbxBuscarGrupo As System.Windows.Forms.GroupBox
    Friend WithEvents lblBuscar As System.Windows.Forms.Label
    Friend WithEvents dvgGrupo As System.Windows.Forms.DataGridView
    Friend WithEvents txtCriterio As System.Windows.Forms.TextBox
    Friend WithEvents pbModificar2 As System.Windows.Forms.PictureBox
    Friend WithEvents pbEliminar As System.Windows.Forms.PictureBox
    Friend WithEvents pbModificar As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pbPie As System.Windows.Forms.PictureBox
    Friend WithEvents pbAddVendedor As System.Windows.Forms.PictureBox
    Friend WithEvents pbDeleteServicio As System.Windows.Forms.PictureBox
    Friend WithEvents pbAddServicio As System.Windows.Forms.PictureBox
    Friend WithEvents pbDeleteVendedor As System.Windows.Forms.PictureBox
    Friend WithEvents pbVerVentasGenerales As System.Windows.Forms.PictureBox
    Friend WithEvents help As System.Windows.Forms.ToolTip
    Friend WithEvents pbVerVentasGrupo As System.Windows.Forms.PictureBox

End Class
