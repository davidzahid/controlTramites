<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmControlTramites
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblFechaIngreso = New System.Windows.Forms.Label()
        Me.dtFecha = New System.Windows.Forms.DateTimePicker()
        Me.lblNut = New System.Windows.Forms.Label()
        Me.txtNut = New System.Windows.Forms.TextBox()
        Me.lblDocumentoRecibido = New System.Windows.Forms.Label()
        Me.txtDocumentoRecibido = New System.Windows.Forms.TextBox()
        Me.lblTramiteSolicitado = New System.Windows.Forms.Label()
        Me.cbxTramiteSolicitado = New System.Windows.Forms.ComboBox()
        Me.lblResidente = New System.Windows.Forms.Label()
        Me.cbxResidente = New System.Windows.Forms.ComboBox()
        Me.lblPersonaAutorizada = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.Label()
        Me.lblNacionalidad = New System.Windows.Forms.Label()
        Me.txtNombreB = New System.Windows.Forms.TextBox()
        Me.txtNacionalidadB = New System.Windows.Forms.TextBox()
        Me.lblEdad = New System.Windows.Forms.Label()
        Me.lblActividad = New System.Windows.Forms.Label()
        Me.cbxActividad = New System.Windows.Forms.ComboBox()
        Me.lblSexoB = New System.Windows.Forms.Label()
        Me.lblFechaNacimientoB = New System.Windows.Forms.Label()
        Me.txtSexoB = New System.Windows.Forms.TextBox()
        Me.dtFechaNacimientoB = New System.Windows.Forms.DateTimePicker()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.txtPersonaAutorizada = New System.Windows.Forms.TextBox()
        Me.cbxStatus = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxResuelve = New System.Windows.Forms.ComboBox()
        Me.cbxRecibido = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblFechaIngreso
        '
        Me.lblFechaIngreso.AutoSize = True
        Me.lblFechaIngreso.Location = New System.Drawing.Point(43, 44)
        Me.lblFechaIngreso.Name = "lblFechaIngreso"
        Me.lblFechaIngreso.Size = New System.Drawing.Size(96, 13)
        Me.lblFechaIngreso.TabIndex = 0
        Me.lblFechaIngreso.Text = "Fecha de Ingreso: "
        '
        'dtFecha
        '
        Me.dtFecha.Location = New System.Drawing.Point(145, 40)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Size = New System.Drawing.Size(200, 20)
        Me.dtFecha.TabIndex = 1
        '
        'lblNut
        '
        Me.lblNut.AutoSize = True
        Me.lblNut.Location = New System.Drawing.Point(45, 79)
        Me.lblNut.Name = "lblNut"
        Me.lblNut.Size = New System.Drawing.Size(33, 13)
        Me.lblNut.TabIndex = 2
        Me.lblNut.Text = "NUT:"
        '
        'txtNut
        '
        Me.txtNut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNut.Location = New System.Drawing.Point(97, 75)
        Me.txtNut.Name = "txtNut"
        Me.txtNut.Size = New System.Drawing.Size(100, 22)
        Me.txtNut.TabIndex = 3
        '
        'lblDocumentoRecibido
        '
        Me.lblDocumentoRecibido.AutoSize = True
        Me.lblDocumentoRecibido.Location = New System.Drawing.Point(285, 80)
        Me.lblDocumentoRecibido.Name = "lblDocumentoRecibido"
        Me.lblDocumentoRecibido.Size = New System.Drawing.Size(110, 13)
        Me.lblDocumentoRecibido.TabIndex = 4
        Me.lblDocumentoRecibido.Text = "Documento Recibido:"
        '
        'txtDocumentoRecibido
        '
        Me.txtDocumentoRecibido.Location = New System.Drawing.Point(402, 77)
        Me.txtDocumentoRecibido.Name = "txtDocumentoRecibido"
        Me.txtDocumentoRecibido.Size = New System.Drawing.Size(114, 20)
        Me.txtDocumentoRecibido.TabIndex = 5
        '
        'lblTramiteSolicitado
        '
        Me.lblTramiteSolicitado.AutoSize = True
        Me.lblTramiteSolicitado.Location = New System.Drawing.Point(45, 121)
        Me.lblTramiteSolicitado.Name = "lblTramiteSolicitado"
        Me.lblTramiteSolicitado.Size = New System.Drawing.Size(94, 13)
        Me.lblTramiteSolicitado.TabIndex = 6
        Me.lblTramiteSolicitado.Text = "Tramite Solicitado:"
        '
        'cbxTramiteSolicitado
        '
        Me.cbxTramiteSolicitado.FormattingEnabled = True
        Me.cbxTramiteSolicitado.Location = New System.Drawing.Point(160, 118)
        Me.cbxTramiteSolicitado.Name = "cbxTramiteSolicitado"
        Me.cbxTramiteSolicitado.Size = New System.Drawing.Size(356, 21)
        Me.cbxTramiteSolicitado.TabIndex = 7
        '
        'lblResidente
        '
        Me.lblResidente.AutoSize = True
        Me.lblResidente.Location = New System.Drawing.Point(45, 201)
        Me.lblResidente.Name = "lblResidente"
        Me.lblResidente.Size = New System.Drawing.Size(58, 13)
        Me.lblResidente.TabIndex = 8
        Me.lblResidente.Text = "Residente:"
        '
        'cbxResidente
        '
        Me.cbxResidente.FormattingEnabled = True
        Me.cbxResidente.Location = New System.Drawing.Point(109, 198)
        Me.cbxResidente.Name = "cbxResidente"
        Me.cbxResidente.Size = New System.Drawing.Size(195, 21)
        Me.cbxResidente.TabIndex = 9
        '
        'lblPersonaAutorizada
        '
        Me.lblPersonaAutorizada.AutoSize = True
        Me.lblPersonaAutorizada.Location = New System.Drawing.Point(129, 261)
        Me.lblPersonaAutorizada.Name = "lblPersonaAutorizada"
        Me.lblPersonaAutorizada.Size = New System.Drawing.Size(102, 13)
        Me.lblPersonaAutorizada.TabIndex = 12
        Me.lblPersonaAutorizada.Text = "Persona Autorizada:"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(45, 294)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(40, 13)
        Me.lblStatus.TabIndex = 14
        Me.lblStatus.Text = "Status:"
        '
        'txtNombre
        '
        Me.txtNombre.AutoSize = True
        Me.txtNombre.Location = New System.Drawing.Point(44, 162)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(47, 13)
        Me.txtNombre.TabIndex = 16
        Me.txtNombre.Text = "Nombre:"
        '
        'lblNacionalidad
        '
        Me.lblNacionalidad.AutoSize = True
        Me.lblNacionalidad.Location = New System.Drawing.Point(340, 162)
        Me.lblNacionalidad.Name = "lblNacionalidad"
        Me.lblNacionalidad.Size = New System.Drawing.Size(69, 13)
        Me.lblNacionalidad.TabIndex = 16
        Me.lblNacionalidad.Text = "Nacionalidad"
        '
        'txtNombreB
        '
        Me.txtNombreB.Location = New System.Drawing.Point(97, 159)
        Me.txtNombreB.Name = "txtNombreB"
        Me.txtNombreB.Size = New System.Drawing.Size(237, 20)
        Me.txtNombreB.TabIndex = 17
        '
        'txtNacionalidadB
        '
        Me.txtNacionalidadB.Location = New System.Drawing.Point(416, 159)
        Me.txtNacionalidadB.Name = "txtNacionalidadB"
        Me.txtNacionalidadB.Size = New System.Drawing.Size(100, 20)
        Me.txtNacionalidadB.TabIndex = 18
        '
        'lblEdad
        '
        Me.lblEdad.AutoSize = True
        Me.lblEdad.Location = New System.Drawing.Point(45, 261)
        Me.lblEdad.Name = "lblEdad"
        Me.lblEdad.Size = New System.Drawing.Size(35, 13)
        Me.lblEdad.TabIndex = 19
        Me.lblEdad.Text = "Edad:"
        '
        'lblActividad
        '
        Me.lblActividad.AutoSize = True
        Me.lblActividad.Location = New System.Drawing.Point(318, 201)
        Me.lblActividad.Name = "lblActividad"
        Me.lblActividad.Size = New System.Drawing.Size(54, 13)
        Me.lblActividad.TabIndex = 20
        Me.lblActividad.Text = "Actividad:"
        '
        'cbxActividad
        '
        Me.cbxActividad.FormattingEnabled = True
        Me.cbxActividad.Location = New System.Drawing.Point(378, 198)
        Me.cbxActividad.Name = "cbxActividad"
        Me.cbxActividad.Size = New System.Drawing.Size(137, 21)
        Me.cbxActividad.TabIndex = 21
        '
        'lblSexoB
        '
        Me.lblSexoB.AutoSize = True
        Me.lblSexoB.Location = New System.Drawing.Point(45, 232)
        Me.lblSexoB.Name = "lblSexoB"
        Me.lblSexoB.Size = New System.Drawing.Size(34, 13)
        Me.lblSexoB.TabIndex = 22
        Me.lblSexoB.Text = "Sexo:"
        '
        'lblFechaNacimientoB
        '
        Me.lblFechaNacimientoB.AutoSize = True
        Me.lblFechaNacimientoB.Location = New System.Drawing.Point(203, 232)
        Me.lblFechaNacimientoB.Name = "lblFechaNacimientoB"
        Me.lblFechaNacimientoB.Size = New System.Drawing.Size(111, 13)
        Me.lblFechaNacimientoB.TabIndex = 23
        Me.lblFechaNacimientoB.Text = "Fecha de Nacimiento:"
        '
        'txtSexoB
        '
        Me.txtSexoB.Location = New System.Drawing.Point(85, 229)
        Me.txtSexoB.Name = "txtSexoB"
        Me.txtSexoB.Size = New System.Drawing.Size(100, 20)
        Me.txtSexoB.TabIndex = 24
        '
        'dtFechaNacimientoB
        '
        Me.dtFechaNacimientoB.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaNacimientoB.Location = New System.Drawing.Point(379, 229)
        Me.dtFechaNacimientoB.Name = "dtFechaNacimientoB"
        Me.dtFechaNacimientoB.Size = New System.Drawing.Size(137, 20)
        Me.dtFechaNacimientoB.TabIndex = 25
        '
        'txtEdad
        '
        Me.txtEdad.Location = New System.Drawing.Point(85, 258)
        Me.txtEdad.MaxLength = 3
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(38, 20)
        Me.txtEdad.TabIndex = 26
        '
        'txtPersonaAutorizada
        '
        Me.txtPersonaAutorizada.Location = New System.Drawing.Point(237, 258)
        Me.txtPersonaAutorizada.Name = "txtPersonaAutorizada"
        Me.txtPersonaAutorizada.Size = New System.Drawing.Size(278, 20)
        Me.txtPersonaAutorizada.TabIndex = 27
        '
        'cbxStatus
        '
        Me.cbxStatus.FormattingEnabled = True
        Me.cbxStatus.Location = New System.Drawing.Point(91, 291)
        Me.cbxStatus.Name = "cbxStatus"
        Me.cbxStatus.Size = New System.Drawing.Size(174, 21)
        Me.cbxStatus.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 325)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Recibido Por:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 351)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Lo resuelve:"
        '
        'cbxResuelve
        '
        Me.cbxResuelve.FormattingEnabled = True
        Me.cbxResuelve.Location = New System.Drawing.Point(132, 348)
        Me.cbxResuelve.Name = "cbxResuelve"
        Me.cbxResuelve.Size = New System.Drawing.Size(383, 21)
        Me.cbxResuelve.TabIndex = 31
        '
        'cbxRecibido
        '
        Me.cbxRecibido.FormattingEnabled = True
        Me.cbxRecibido.Location = New System.Drawing.Point(132, 322)
        Me.cbxRecibido.Name = "cbxRecibido"
        Me.cbxRecibido.Size = New System.Drawing.Size(384, 21)
        Me.cbxRecibido.TabIndex = 31
        '
        'frmControlTramites
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 496)
        Me.Controls.Add(Me.cbxRecibido)
        Me.Controls.Add(Me.cbxResuelve)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxStatus)
        Me.Controls.Add(Me.txtPersonaAutorizada)
        Me.Controls.Add(Me.txtEdad)
        Me.Controls.Add(Me.dtFechaNacimientoB)
        Me.Controls.Add(Me.txtSexoB)
        Me.Controls.Add(Me.lblFechaNacimientoB)
        Me.Controls.Add(Me.lblSexoB)
        Me.Controls.Add(Me.cbxActividad)
        Me.Controls.Add(Me.lblActividad)
        Me.Controls.Add(Me.lblEdad)
        Me.Controls.Add(Me.txtNacionalidadB)
        Me.Controls.Add(Me.txtNombreB)
        Me.Controls.Add(Me.lblNacionalidad)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblPersonaAutorizada)
        Me.Controls.Add(Me.cbxResidente)
        Me.Controls.Add(Me.lblResidente)
        Me.Controls.Add(Me.cbxTramiteSolicitado)
        Me.Controls.Add(Me.lblTramiteSolicitado)
        Me.Controls.Add(Me.txtDocumentoRecibido)
        Me.Controls.Add(Me.lblDocumentoRecibido)
        Me.Controls.Add(Me.txtNut)
        Me.Controls.Add(Me.lblNut)
        Me.Controls.Add(Me.dtFecha)
        Me.Controls.Add(Me.lblFechaIngreso)
        Me.Name = "frmControlTramites"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Control de Tramites"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFechaIngreso As System.Windows.Forms.Label
    Friend WithEvents dtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblNut As System.Windows.Forms.Label
    Friend WithEvents txtNut As System.Windows.Forms.TextBox
    Friend WithEvents lblDocumentoRecibido As System.Windows.Forms.Label
    Friend WithEvents txtDocumentoRecibido As System.Windows.Forms.TextBox
    Friend WithEvents lblTramiteSolicitado As System.Windows.Forms.Label
    Friend WithEvents cbxTramiteSolicitado As System.Windows.Forms.ComboBox
    Friend WithEvents lblResidente As System.Windows.Forms.Label
    Friend WithEvents cbxResidente As System.Windows.Forms.ComboBox
    Friend WithEvents lblPersonaAutorizada As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.Label
    Friend WithEvents lblNacionalidad As System.Windows.Forms.Label
    Friend WithEvents txtNombreB As System.Windows.Forms.TextBox
    Friend WithEvents txtNacionalidadB As System.Windows.Forms.TextBox
    Friend WithEvents lblEdad As System.Windows.Forms.Label
    Friend WithEvents lblActividad As System.Windows.Forms.Label
    Friend WithEvents cbxActividad As System.Windows.Forms.ComboBox
    Friend WithEvents lblSexoB As System.Windows.Forms.Label
    Friend WithEvents lblFechaNacimientoB As System.Windows.Forms.Label
    Friend WithEvents txtSexoB As System.Windows.Forms.TextBox
    Friend WithEvents dtFechaNacimientoB As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtEdad As System.Windows.Forms.TextBox
    Friend WithEvents txtPersonaAutorizada As System.Windows.Forms.TextBox
    Friend WithEvents cbxStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbxResuelve As System.Windows.Forms.ComboBox
    Friend WithEvents cbxRecibido As System.Windows.Forms.ComboBox
End Class
