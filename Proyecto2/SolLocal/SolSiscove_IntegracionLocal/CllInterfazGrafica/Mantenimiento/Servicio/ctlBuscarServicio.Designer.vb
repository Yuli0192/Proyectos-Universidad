<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlBuscarServicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctlBuscarServicio))
        Me.txtJuniorDolares = New System.Windows.Forms.TextBox
        Me.txtMasterDolares = New System.Windows.Forms.TextBox
        Me.txtMasterColones = New System.Windows.Forms.TextBox
        Me.txtSeniorDolares = New System.Windows.Forms.TextBox
        Me.txtSeniorColones = New System.Windows.Forms.TextBox
        Me.lblMasterDolares = New System.Windows.Forms.Label
        Me.lblMasterColones = New System.Windows.Forms.Label
        Me.lblSeniorDolares = New System.Windows.Forms.Label
        Me.lblSeniorColones = New System.Windows.Forms.Label
        Me.lblJuniorDolares = New System.Windows.Forms.Label
        Me.txtJuniorColones = New System.Windows.Forms.TextBox
        Me.lblJuniorColones = New System.Windows.Forms.Label
        Me.lblPrecioColones = New System.Windows.Forms.Label
        Me.txtDescripcion = New System.Windows.Forms.TextBox
        Me.lblDescripcion = New System.Windows.Forms.Label
        Me.txtPrecioDolares = New System.Windows.Forms.TextBox
        Me.lblPrecioDolares = New System.Windows.Forms.Label
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.lblNombre = New System.Windows.Forms.Label
        Me.txtCod = New System.Windows.Forms.TextBox
        Me.lbldentificador = New System.Windows.Forms.Label
        Me.txtPrecioColones = New System.Windows.Forms.TextBox
        Me.pbModificar2 = New System.Windows.Forms.PictureBox
        Me.help = New System.Windows.Forms.ToolTip(Me.components)
        Me.pbModificar = New System.Windows.Forms.PictureBox
        Me.pbEliminar = New System.Windows.Forms.PictureBox
        Me.txtCriterio = New System.Windows.Forms.TextBox
        Me.rdbNombre = New System.Windows.Forms.RadioButton
        Me.rdbId = New System.Windows.Forms.RadioButton
        Me.dvgServicios = New System.Windows.Forms.DataGridView
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nom = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.descp = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.precioencolones = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.precioendolares = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.comisionjuniorc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.comisionjuniord = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.comisionserniorc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.comisionseniord = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.comisionmasterc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.comisionmasterd = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.gpModificarServicio = New System.Windows.Forms.GroupBox
        Me.gbBuscarServicio = New System.Windows.Forms.GroupBox
        CType(Me.pbModificar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbModificar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvgServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.gpModificarServicio.SuspendLayout()
        Me.gbBuscarServicio.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtJuniorDolares
        '
        Me.txtJuniorDolares.Location = New System.Drawing.Point(237, 282)
        Me.txtJuniorDolares.Margin = New System.Windows.Forms.Padding(4)
        Me.txtJuniorDolares.MaxLength = 13
        Me.txtJuniorDolares.Name = "txtJuniorDolares"
        Me.txtJuniorDolares.Size = New System.Drawing.Size(174, 25)
        Me.txtJuniorDolares.TabIndex = 7
        '
        'txtMasterDolares
        '
        Me.txtMasterDolares.Location = New System.Drawing.Point(237, 410)
        Me.txtMasterDolares.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMasterDolares.MaxLength = 13
        Me.txtMasterDolares.Name = "txtMasterDolares"
        Me.txtMasterDolares.Size = New System.Drawing.Size(174, 25)
        Me.txtMasterDolares.TabIndex = 11
        '
        'txtMasterColones
        '
        Me.txtMasterColones.Location = New System.Drawing.Point(237, 378)
        Me.txtMasterColones.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMasterColones.MaxLength = 13
        Me.txtMasterColones.Name = "txtMasterColones"
        Me.txtMasterColones.Size = New System.Drawing.Size(174, 25)
        Me.txtMasterColones.TabIndex = 10
        '
        'txtSeniorDolares
        '
        Me.txtSeniorDolares.Location = New System.Drawing.Point(237, 346)
        Me.txtSeniorDolares.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSeniorDolares.MaxLength = 13
        Me.txtSeniorDolares.Name = "txtSeniorDolares"
        Me.txtSeniorDolares.Size = New System.Drawing.Size(174, 25)
        Me.txtSeniorDolares.TabIndex = 9
        '
        'txtSeniorColones
        '
        Me.txtSeniorColones.Location = New System.Drawing.Point(237, 314)
        Me.txtSeniorColones.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSeniorColones.MaxLength = 13
        Me.txtSeniorColones.Name = "txtSeniorColones"
        Me.txtSeniorColones.Size = New System.Drawing.Size(174, 25)
        Me.txtSeniorColones.TabIndex = 8
        '
        'lblMasterDolares
        '
        Me.lblMasterDolares.AutoSize = True
        Me.lblMasterDolares.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblMasterDolares.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lblMasterDolares.Location = New System.Drawing.Point(32, 410)
        Me.lblMasterDolares.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMasterDolares.Name = "lblMasterDolares"
        Me.lblMasterDolares.Size = New System.Drawing.Size(192, 18)
        Me.lblMasterDolares.TabIndex = 45
        Me.lblMasterDolares.Text = "Comision Master en dolares "
        '
        'lblMasterColones
        '
        Me.lblMasterColones.AutoSize = True
        Me.lblMasterColones.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblMasterColones.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lblMasterColones.Location = New System.Drawing.Point(32, 378)
        Me.lblMasterColones.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMasterColones.Name = "lblMasterColones"
        Me.lblMasterColones.Size = New System.Drawing.Size(189, 18)
        Me.lblMasterColones.TabIndex = 44
        Me.lblMasterColones.Text = "Comision Master en colones"
        '
        'lblSeniorDolares
        '
        Me.lblSeniorDolares.AutoSize = True
        Me.lblSeniorDolares.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblSeniorDolares.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lblSeniorDolares.Location = New System.Drawing.Point(32, 346)
        Me.lblSeniorDolares.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSeniorDolares.Name = "lblSeniorDolares"
        Me.lblSeniorDolares.Size = New System.Drawing.Size(181, 18)
        Me.lblSeniorDolares.TabIndex = 43
        Me.lblSeniorDolares.Text = "Comision Senior en dolares"
        '
        'lblSeniorColones
        '
        Me.lblSeniorColones.AutoSize = True
        Me.lblSeniorColones.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblSeniorColones.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lblSeniorColones.Location = New System.Drawing.Point(32, 314)
        Me.lblSeniorColones.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSeniorColones.Name = "lblSeniorColones"
        Me.lblSeniorColones.Size = New System.Drawing.Size(183, 18)
        Me.lblSeniorColones.TabIndex = 42
        Me.lblSeniorColones.Text = "Comision Senior en colones"
        '
        'lblJuniorDolares
        '
        Me.lblJuniorDolares.AutoSize = True
        Me.lblJuniorDolares.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblJuniorDolares.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lblJuniorDolares.Location = New System.Drawing.Point(32, 282)
        Me.lblJuniorDolares.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJuniorDolares.Name = "lblJuniorDolares"
        Me.lblJuniorDolares.Size = New System.Drawing.Size(179, 18)
        Me.lblJuniorDolares.TabIndex = 41
        Me.lblJuniorDolares.Text = "Comision Junior en dolares"
        '
        'txtJuniorColones
        '
        Me.txtJuniorColones.Location = New System.Drawing.Point(237, 250)
        Me.txtJuniorColones.Margin = New System.Windows.Forms.Padding(4)
        Me.txtJuniorColones.MaxLength = 13
        Me.txtJuniorColones.Name = "txtJuniorColones"
        Me.txtJuniorColones.Size = New System.Drawing.Size(174, 25)
        Me.txtJuniorColones.TabIndex = 6
        '
        'lblJuniorColones
        '
        Me.lblJuniorColones.AutoSize = True
        Me.lblJuniorColones.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblJuniorColones.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lblJuniorColones.Location = New System.Drawing.Point(32, 250)
        Me.lblJuniorColones.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJuniorColones.Name = "lblJuniorColones"
        Me.lblJuniorColones.Size = New System.Drawing.Size(181, 18)
        Me.lblJuniorColones.TabIndex = 36
        Me.lblJuniorColones.Text = "Comision Junior en colones"
        '
        'lblPrecioColones
        '
        Me.lblPrecioColones.AutoSize = True
        Me.lblPrecioColones.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPrecioColones.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lblPrecioColones.Location = New System.Drawing.Point(32, 186)
        Me.lblPrecioColones.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrecioColones.Name = "lblPrecioColones"
        Me.lblPrecioColones.Size = New System.Drawing.Size(120, 18)
        Me.lblPrecioColones.TabIndex = 35
        Me.lblPrecioColones.Text = "Precio en colones"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(237, 102)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescripcion.MaxLength = 256
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(174, 80)
        Me.txtDescripcion.TabIndex = 3
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblDescripcion.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lblDescripcion.Location = New System.Drawing.Point(32, 102)
        Me.lblDescripcion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(80, 18)
        Me.lblDescripcion.TabIndex = 33
        Me.lblDescripcion.Text = "Descripcion"
        '
        'txtPrecioDolares
        '
        Me.txtPrecioDolares.Location = New System.Drawing.Point(237, 218)
        Me.txtPrecioDolares.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrecioDolares.MaxLength = 13
        Me.txtPrecioDolares.Name = "txtPrecioDolares"
        Me.txtPrecioDolares.Size = New System.Drawing.Size(174, 25)
        Me.txtPrecioDolares.TabIndex = 5
        '
        'lblPrecioDolares
        '
        Me.lblPrecioDolares.AutoSize = True
        Me.lblPrecioDolares.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPrecioDolares.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lblPrecioDolares.Location = New System.Drawing.Point(32, 218)
        Me.lblPrecioDolares.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrecioDolares.Name = "lblPrecioDolares"
        Me.lblPrecioDolares.Size = New System.Drawing.Size(123, 18)
        Me.lblPrecioDolares.TabIndex = 31
        Me.lblPrecioDolares.Text = "Precio en dolares "
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(237, 70)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre.MaxLength = 30
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(174, 25)
        Me.txtNombre.TabIndex = 2
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblNombre.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lblNombre.Location = New System.Drawing.Point(32, 70)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(60, 18)
        Me.lblNombre.TabIndex = 29
        Me.lblNombre.Text = "Nombre"
        '
        'txtCod
        '
        Me.txtCod.Enabled = False
        Me.txtCod.Location = New System.Drawing.Point(237, 38)
        Me.txtCod.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCod.MaxLength = 15
        Me.txtCod.Name = "txtCod"
        Me.txtCod.ReadOnly = True
        Me.txtCod.Size = New System.Drawing.Size(174, 25)
        Me.txtCod.TabIndex = 28
        '
        'lbldentificador
        '
        Me.lbldentificador.AutoSize = True
        Me.lbldentificador.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbldentificador.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.lbldentificador.Location = New System.Drawing.Point(32, 38)
        Me.lbldentificador.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldentificador.Name = "lbldentificador"
        Me.lbldentificador.Size = New System.Drawing.Size(88, 18)
        Me.lbldentificador.TabIndex = 27
        Me.lbldentificador.Text = "Identificador"
        '
        'txtPrecioColones
        '
        Me.txtPrecioColones.Location = New System.Drawing.Point(237, 186)
        Me.txtPrecioColones.MaxLength = 13
        Me.txtPrecioColones.Name = "txtPrecioColones"
        Me.txtPrecioColones.Size = New System.Drawing.Size(174, 25)
        Me.txtPrecioColones.TabIndex = 4
        '
        'pbModificar2
        '
        Me.pbModificar2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pbModificar2.BackgroundImage = CType(resources.GetObject("pbModificar2.BackgroundImage"), System.Drawing.Image)
        Me.pbModificar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbModificar2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbModificar2.Location = New System.Drawing.Point(381, 445)
        Me.pbModificar2.Name = "pbModificar2"
        Me.pbModificar2.Size = New System.Drawing.Size(30, 30)
        Me.pbModificar2.TabIndex = 55
        Me.pbModificar2.TabStop = False
        Me.help.SetToolTip(Me.pbModificar2, "Confirmar Modificación")
        '
        'pbModificar
        '
        Me.pbModificar.AccessibleDescription = ""
        Me.pbModificar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pbModificar.BackgroundImage = CType(resources.GetObject("pbModificar.BackgroundImage"), System.Drawing.Image)
        Me.pbModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbModificar.Location = New System.Drawing.Point(308, 280)
        Me.pbModificar.Name = "pbModificar"
        Me.pbModificar.Size = New System.Drawing.Size(30, 30)
        Me.pbModificar.TabIndex = 52
        Me.pbModificar.TabStop = False
        Me.help.SetToolTip(Me.pbModificar, "Modificar")
        '
        'pbEliminar
        '
        Me.pbEliminar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pbEliminar.BackgroundImage = CType(resources.GetObject("pbEliminar.BackgroundImage"), System.Drawing.Image)
        Me.pbEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbEliminar.Location = New System.Drawing.Point(363, 280)
        Me.pbEliminar.Name = "pbEliminar"
        Me.pbEliminar.Size = New System.Drawing.Size(30, 30)
        Me.pbEliminar.TabIndex = 53
        Me.pbEliminar.TabStop = False
        Me.help.SetToolTip(Me.pbEliminar, "Eliminar")
        '
        'txtCriterio
        '
        Me.txtCriterio.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtCriterio.Location = New System.Drawing.Point(225, 38)
        Me.txtCriterio.Name = "txtCriterio"
        Me.txtCriterio.Size = New System.Drawing.Size(179, 27)
        Me.txtCriterio.TabIndex = 1
        Me.help.SetToolTip(Me.txtCriterio, "Ej: PP-098")
        '
        'rdbNombre
        '
        Me.rdbNombre.AutoSize = True
        Me.rdbNombre.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.rdbNombre.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.rdbNombre.Location = New System.Drawing.Point(12, 43)
        Me.rdbNombre.Name = "rdbNombre"
        Me.rdbNombre.Size = New System.Drawing.Size(78, 22)
        Me.rdbNombre.TabIndex = 11
        Me.rdbNombre.Text = "Nombre"
        Me.rdbNombre.UseVisualStyleBackColor = False
        '
        'rdbId
        '
        Me.rdbId.AutoSize = True
        Me.rdbId.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.rdbId.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.rdbId.Location = New System.Drawing.Point(100, 43)
        Me.rdbId.Name = "rdbId"
        Me.rdbId.Size = New System.Drawing.Size(106, 22)
        Me.rdbId.TabIndex = 10
        Me.rdbId.Text = "Identificador"
        Me.rdbId.UseVisualStyleBackColor = False
        '
        'dvgServicios
        '
        Me.dvgServicios.AllowUserToAddRows = False
        Me.dvgServicios.AllowUserToDeleteRows = False
        Me.dvgServicios.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dvgServicios.ColumnHeadersHeight = 26
        Me.dvgServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dvgServicios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.nom, Me.descp, Me.precioencolones, Me.precioendolares, Me.comisionjuniorc, Me.comisionjuniord, Me.comisionserniorc, Me.comisionseniord, Me.comisionmasterc, Me.comisionmasterd})
        Me.dvgServicios.Location = New System.Drawing.Point(17, 74)
        Me.dvgServicios.Name = "dvgServicios"
        Me.dvgServicios.ReadOnly = True
        Me.dvgServicios.RowHeadersVisible = False
        Me.dvgServicios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dvgServicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dvgServicios.Size = New System.Drawing.Size(387, 176)
        Me.dvgServicios.TabIndex = 13
        '
        'codigo
        '
        Me.codigo.HeaderText = "Cod"
        Me.codigo.MinimumWidth = 67
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        Me.codigo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.codigo.Width = 69
        '
        'nom
        '
        Me.nom.HeaderText = "Nombre"
        Me.nom.MinimumWidth = 100
        Me.nom.Name = "nom"
        Me.nom.ReadOnly = True
        Me.nom.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'descp
        '
        Me.descp.HeaderText = "Descripcion"
        Me.descp.MinimumWidth = 230
        Me.descp.Name = "descp"
        Me.descp.ReadOnly = True
        Me.descp.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.descp.Width = 230
        '
        'precioencolones
        '
        Me.precioencolones.HeaderText = "Precio en Colones"
        Me.precioencolones.MinimumWidth = 100
        Me.precioencolones.Name = "precioencolones"
        Me.precioencolones.ReadOnly = True
        Me.precioencolones.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.precioencolones.Visible = False
        '
        'precioendolares
        '
        Me.precioendolares.HeaderText = "Precio en Dolares"
        Me.precioendolares.MinimumWidth = 100
        Me.precioendolares.Name = "precioendolares"
        Me.precioendolares.ReadOnly = True
        Me.precioendolares.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.precioendolares.Visible = False
        '
        'comisionjuniorc
        '
        Me.comisionjuniorc.HeaderText = "Comisión Junior en Colones"
        Me.comisionjuniorc.MinimumWidth = 150
        Me.comisionjuniorc.Name = "comisionjuniorc"
        Me.comisionjuniorc.ReadOnly = True
        Me.comisionjuniorc.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.comisionjuniorc.Visible = False
        Me.comisionjuniorc.Width = 150
        '
        'comisionjuniord
        '
        Me.comisionjuniord.HeaderText = "Comisión Junior en Dólares"
        Me.comisionjuniord.MinimumWidth = 150
        Me.comisionjuniord.Name = "comisionjuniord"
        Me.comisionjuniord.ReadOnly = True
        Me.comisionjuniord.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.comisionjuniord.Visible = False
        Me.comisionjuniord.Width = 150
        '
        'comisionserniorc
        '
        Me.comisionserniorc.HeaderText = "Comisión Senior en Colones"
        Me.comisionserniorc.MinimumWidth = 150
        Me.comisionserniorc.Name = "comisionserniorc"
        Me.comisionserniorc.ReadOnly = True
        Me.comisionserniorc.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.comisionserniorc.Visible = False
        Me.comisionserniorc.Width = 150
        '
        'comisionseniord
        '
        Me.comisionseniord.HeaderText = "Comisión Senior en Dólares"
        Me.comisionseniord.MinimumWidth = 150
        Me.comisionseniord.Name = "comisionseniord"
        Me.comisionseniord.ReadOnly = True
        Me.comisionseniord.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.comisionseniord.Visible = False
        Me.comisionseniord.Width = 150
        '
        'comisionmasterc
        '
        Me.comisionmasterc.HeaderText = "Comisión Master en Colones"
        Me.comisionmasterc.MinimumWidth = 150
        Me.comisionmasterc.Name = "comisionmasterc"
        Me.comisionmasterc.ReadOnly = True
        Me.comisionmasterc.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.comisionmasterc.Visible = False
        Me.comisionmasterc.Width = 150
        '
        'comisionmasterd
        '
        Me.comisionmasterd.HeaderText = "Comisión Master en Dólares"
        Me.comisionmasterd.MinimumWidth = 150
        Me.comisionmasterd.Name = "comisionmasterd"
        Me.comisionmasterd.ReadOnly = True
        Me.comisionmasterd.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.comisionmasterd.Visible = False
        Me.comisionmasterd.Width = 150
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Controls.Add(Me.gpModificarServicio)
        Me.Panel1.Controls.Add(Me.gbBuscarServicio)
        Me.Panel1.Location = New System.Drawing.Point(62, 23)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(937, 607)
        Me.Panel1.TabIndex = 60
        '
        'gpModificarServicio
        '
        Me.gpModificarServicio.Controls.Add(Me.pbModificar2)
        Me.gpModificarServicio.Controls.Add(Me.txtPrecioColones)
        Me.gpModificarServicio.Controls.Add(Me.lbldentificador)
        Me.gpModificarServicio.Controls.Add(Me.txtJuniorDolares)
        Me.gpModificarServicio.Controls.Add(Me.txtCod)
        Me.gpModificarServicio.Controls.Add(Me.txtMasterDolares)
        Me.gpModificarServicio.Controls.Add(Me.lblNombre)
        Me.gpModificarServicio.Controls.Add(Me.txtMasterColones)
        Me.gpModificarServicio.Controls.Add(Me.txtNombre)
        Me.gpModificarServicio.Controls.Add(Me.txtSeniorDolares)
        Me.gpModificarServicio.Controls.Add(Me.lblPrecioDolares)
        Me.gpModificarServicio.Controls.Add(Me.txtSeniorColones)
        Me.gpModificarServicio.Controls.Add(Me.txtPrecioDolares)
        Me.gpModificarServicio.Controls.Add(Me.lblMasterDolares)
        Me.gpModificarServicio.Controls.Add(Me.lblDescripcion)
        Me.gpModificarServicio.Controls.Add(Me.lblMasterColones)
        Me.gpModificarServicio.Controls.Add(Me.txtDescripcion)
        Me.gpModificarServicio.Controls.Add(Me.lblSeniorDolares)
        Me.gpModificarServicio.Controls.Add(Me.lblPrecioColones)
        Me.gpModificarServicio.Controls.Add(Me.lblSeniorColones)
        Me.gpModificarServicio.Controls.Add(Me.lblJuniorColones)
        Me.gpModificarServicio.Controls.Add(Me.lblJuniorDolares)
        Me.gpModificarServicio.Controls.Add(Me.txtJuniorColones)
        Me.gpModificarServicio.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.gpModificarServicio.Location = New System.Drawing.Point(464, 15)
        Me.gpModificarServicio.Name = "gpModificarServicio"
        Me.gpModificarServicio.Size = New System.Drawing.Size(443, 485)
        Me.gpModificarServicio.TabIndex = 63
        Me.gpModificarServicio.TabStop = False
        Me.gpModificarServicio.Text = "Modificar Servicio"
        Me.gpModificarServicio.Visible = False
        '
        'gbBuscarServicio
        '
        Me.gbBuscarServicio.Controls.Add(Me.pbEliminar)
        Me.gbBuscarServicio.Controls.Add(Me.rdbNombre)
        Me.gbBuscarServicio.Controls.Add(Me.pbModificar)
        Me.gbBuscarServicio.Controls.Add(Me.rdbId)
        Me.gbBuscarServicio.Controls.Add(Me.txtCriterio)
        Me.gbBuscarServicio.Controls.Add(Me.dvgServicios)
        Me.gbBuscarServicio.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.gbBuscarServicio.Location = New System.Drawing.Point(18, 15)
        Me.gbBuscarServicio.Name = "gbBuscarServicio"
        Me.gbBuscarServicio.Size = New System.Drawing.Size(420, 331)
        Me.gbBuscarServicio.TabIndex = 62
        Me.gbBuscarServicio.TabStop = False
        Me.gbBuscarServicio.Text = "Buscar Servicio"
        '
        'ctlBuscarServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ctlBuscarServicio"
        Me.Size = New System.Drawing.Size(1024, 700)
        CType(Me.pbModificar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbModificar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvgServicios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.gpModificarServicio.ResumeLayout(False)
        Me.gpModificarServicio.PerformLayout()
        Me.gbBuscarServicio.ResumeLayout(False)
        Me.gbBuscarServicio.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtJuniorDolares As System.Windows.Forms.TextBox
    Friend WithEvents txtMasterDolares As System.Windows.Forms.TextBox
    Friend WithEvents txtMasterColones As System.Windows.Forms.TextBox
    Friend WithEvents txtSeniorDolares As System.Windows.Forms.TextBox
    Friend WithEvents txtSeniorColones As System.Windows.Forms.TextBox
    Friend WithEvents lblMasterDolares As System.Windows.Forms.Label
    Friend WithEvents lblMasterColones As System.Windows.Forms.Label
    Friend WithEvents lblSeniorDolares As System.Windows.Forms.Label
    Friend WithEvents lblSeniorColones As System.Windows.Forms.Label
    Friend WithEvents lblJuniorDolares As System.Windows.Forms.Label
    Friend WithEvents txtJuniorColones As System.Windows.Forms.TextBox
    Friend WithEvents lblJuniorColones As System.Windows.Forms.Label
    Friend WithEvents lblPrecioColones As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents txtPrecioDolares As System.Windows.Forms.TextBox
    Friend WithEvents lblPrecioDolares As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtCod As System.Windows.Forms.TextBox
    Friend WithEvents lbldentificador As System.Windows.Forms.Label
    Friend WithEvents txtPrecioColones As System.Windows.Forms.TextBox
    Friend WithEvents pbModificar2 As System.Windows.Forms.PictureBox
    Friend WithEvents help As System.Windows.Forms.ToolTip
    Friend WithEvents txtCriterio As System.Windows.Forms.TextBox
    Friend WithEvents rdbNombre As System.Windows.Forms.RadioButton
    Friend WithEvents rdbId As System.Windows.Forms.RadioButton
    Friend WithEvents pbModificar As System.Windows.Forms.PictureBox
    Friend WithEvents dvgServicios As System.Windows.Forms.DataGridView
    Friend WithEvents codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents precioencolones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents precioendolares As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents comisionjuniorc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents comisionjuniord As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents comisionserniorc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents comisionseniord As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents comisionmasterc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents comisionmasterd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pbEliminar As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents gbBuscarServicio As System.Windows.Forms.GroupBox
    Friend WithEvents gpModificarServicio As System.Windows.Forms.GroupBox

End Class
