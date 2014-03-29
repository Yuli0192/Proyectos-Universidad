<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIniciarSession
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIniciarSession))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.pbIngresar = New System.Windows.Forms.PictureBox
        Me.lblCorreoUsuario = New System.Windows.Forms.Label
        Me.txtContrasenna = New System.Windows.Forms.TextBox
        Me.lblContrasenna = New System.Windows.Forms.Label
        Me.txtusuario = New System.Windows.Forms.TextBox
        Me.help = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbIngresar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.pbIngresar)
        Me.GroupBox1.Controls.Add(Me.lblCorreoUsuario)
        Me.GroupBox1.Controls.Add(Me.txtContrasenna)
        Me.GroupBox1.Controls.Add(Me.lblContrasenna)
        Me.GroupBox1.Controls.Add(Me.txtusuario)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(27, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(394, 173)
        Me.GroupBox1.TabIndex = 86
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Iniciar Sesión"
        '
        'pbIngresar
        '
        Me.pbIngresar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pbIngresar.BackgroundImage = CType(resources.GetObject("pbIngresar.BackgroundImage"), System.Drawing.Image)
        Me.pbIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbIngresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbIngresar.Location = New System.Drawing.Point(348, 128)
        Me.pbIngresar.Name = "pbIngresar"
        Me.pbIngresar.Size = New System.Drawing.Size(30, 30)
        Me.pbIngresar.TabIndex = 83
        Me.pbIngresar.TabStop = False
        Me.help.SetToolTip(Me.pbIngresar, "Ingresar")
        '
        'lblCorreoUsuario
        '
        Me.lblCorreoUsuario.AutoSize = True
        Me.lblCorreoUsuario.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreoUsuario.Location = New System.Drawing.Point(40, 36)
        Me.lblCorreoUsuario.Name = "lblCorreoUsuario"
        Me.lblCorreoUsuario.Size = New System.Drawing.Size(56, 18)
        Me.lblCorreoUsuario.TabIndex = 0
        Me.lblCorreoUsuario.Text = "Correo:"
        '
        'txtContrasenna
        '
        Me.txtContrasenna.Location = New System.Drawing.Point(141, 90)
        Me.txtContrasenna.Name = "txtContrasenna"
        Me.txtContrasenna.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContrasenna.Size = New System.Drawing.Size(237, 26)
        Me.txtContrasenna.TabIndex = 3
        '
        'lblContrasenna
        '
        Me.lblContrasenna.AutoSize = True
        Me.lblContrasenna.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContrasenna.Location = New System.Drawing.Point(40, 90)
        Me.lblContrasenna.Name = "lblContrasenna"
        Me.lblContrasenna.Size = New System.Drawing.Size(87, 18)
        Me.lblContrasenna.TabIndex = 1
        Me.lblContrasenna.Text = "Contraseña:"
        '
        'txtusuario
        '
        Me.txtusuario.Location = New System.Drawing.Point(141, 37)
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Size = New System.Drawing.Size(237, 26)
        Me.txtusuario.TabIndex = 2
        '
        'frmIniciarSession
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(445, 227)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(455, 259)
        Me.Name = "frmIniciarSession"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Iniciar Sesión"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pbIngresar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents pbIngresar As System.Windows.Forms.PictureBox
    Friend WithEvents lblCorreoUsuario As System.Windows.Forms.Label
    Friend WithEvents txtContrasenna As System.Windows.Forms.TextBox
    Friend WithEvents lblContrasenna As System.Windows.Forms.Label
    Friend WithEvents txtusuario As System.Windows.Forms.TextBox
    Friend WithEvents help As System.Windows.Forms.ToolTip
End Class
