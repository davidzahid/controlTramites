﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBeneficiario
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
        Me.id_beneficiario = New System.Windows.Forms.Label()
        Me.txtBeneficiario = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNacionalidad = New System.Windows.Forms.Label()
        Me.cbxNacionalidad = New System.Windows.Forms.ComboBox()
        Me.cbxSexo = New System.Windows.Forms.ComboBox()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.dtFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnVerificar = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.btnPrueba = New System.Windows.Forms.Button()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.txtNue = New System.Windows.Forms.TextBox()
        Me.lblNue = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'id_beneficiario
        '
        Me.id_beneficiario.AutoSize = True
        Me.id_beneficiario.Location = New System.Drawing.Point(37, 38)
        Me.id_beneficiario.Name = "id_beneficiario"
        Me.id_beneficiario.Size = New System.Drawing.Size(82, 13)
        Me.id_beneficiario.TabIndex = 0
        Me.id_beneficiario.Text = "ID Beneficiario: "
        '
        'txtBeneficiario
        '
        Me.txtBeneficiario.Enabled = False
        Me.txtBeneficiario.Location = New System.Drawing.Point(137, 35)
        Me.txtBeneficiario.Name = "txtBeneficiario"
        Me.txtBeneficiario.Size = New System.Drawing.Size(82, 20)
        Me.txtBeneficiario.TabIndex = 1
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(37, 80)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 4
        Me.lblNombre.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(114, 77)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(302, 20)
        Me.txtNombre.TabIndex = 5
        '
        'lblNacionalidad
        '
        Me.lblNacionalidad.AutoSize = True
        Me.lblNacionalidad.Location = New System.Drawing.Point(37, 124)
        Me.lblNacionalidad.Name = "lblNacionalidad"
        Me.lblNacionalidad.Size = New System.Drawing.Size(69, 13)
        Me.lblNacionalidad.TabIndex = 7
        Me.lblNacionalidad.Text = "Nacionalidad"
        '
        'cbxNacionalidad
        '
        Me.cbxNacionalidad.Enabled = False
        Me.cbxNacionalidad.FormattingEnabled = True
        Me.cbxNacionalidad.Items.AddRange(New Object() {"Italiana", "China", "Mexicana", "Guatemalteca", "Italiana", "Francesa", "Española", "Cubana", "Brasileña"})
        Me.cbxNacionalidad.Location = New System.Drawing.Point(114, 121)
        Me.cbxNacionalidad.Name = "cbxNacionalidad"
        Me.cbxNacionalidad.Size = New System.Drawing.Size(161, 21)
        Me.cbxNacionalidad.TabIndex = 8
        '
        'cbxSexo
        '
        Me.cbxSexo.Enabled = False
        Me.cbxSexo.FormattingEnabled = True
        Me.cbxSexo.Items.AddRange(New Object() {"Masculino", "Femenino"})
        Me.cbxSexo.Location = New System.Drawing.Point(318, 121)
        Me.cbxSexo.Name = "cbxSexo"
        Me.cbxSexo.Size = New System.Drawing.Size(98, 21)
        Me.cbxSexo.TabIndex = 9
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Location = New System.Drawing.Point(281, 124)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(31, 13)
        Me.lblSexo.TabIndex = 10
        Me.lblSexo.Text = "Sexo"
        '
        'dtFechaNacimiento
        '
        Me.dtFechaNacimiento.Checked = False
        Me.dtFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaNacimiento.Location = New System.Drawing.Point(316, 157)
        Me.dtFechaNacimiento.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dtFechaNacimiento.Name = "dtFechaNacimiento"
        Me.dtFechaNacimiento.Size = New System.Drawing.Size(100, 20)
        Me.dtFechaNacimiento.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(204, 159)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Fecha de Nacimiento"
        '
        'btnVerificar
        '
        Me.btnVerificar.BackColor = System.Drawing.Color.Ivory
        Me.btnVerificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerificar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnVerificar.Location = New System.Drawing.Point(341, 221)
        Me.btnVerificar.Name = "btnVerificar"
        Me.btnVerificar.Size = New System.Drawing.Size(75, 23)
        Me.btnVerificar.TabIndex = 13
        Me.btnVerificar.Text = "Verificar"
        Me.btnVerificar.UseVisualStyleBackColor = False
        '
        'btnPrueba
        '
        Me.btnPrueba.BackColor = System.Drawing.Color.Ivory
        Me.btnPrueba.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrueba.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnPrueba.Location = New System.Drawing.Point(44, 221)
        Me.btnPrueba.Name = "btnPrueba"
        Me.btnPrueba.Size = New System.Drawing.Size(75, 23)
        Me.btnPrueba.TabIndex = 14
        Me.btnPrueba.Text = "Prueba"
        Me.btnPrueba.UseVisualStyleBackColor = False
        Me.btnPrueba.Visible = False
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(137, 183)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(279, 20)
        Me.txtFecha.TabIndex = 15
        Me.txtFecha.Visible = False
        '
        'txtNue
        '
        Me.txtNue.Location = New System.Drawing.Point(316, 35)
        Me.txtNue.Name = "txtNue"
        Me.txtNue.Size = New System.Drawing.Size(100, 20)
        Me.txtNue.TabIndex = 16
        '
        'lblNue
        '
        Me.lblNue.AutoSize = True
        Me.lblNue.Location = New System.Drawing.Point(271, 40)
        Me.lblNue.Name = "lblNue"
        Me.lblNue.Size = New System.Drawing.Size(30, 13)
        Me.lblNue.TabIndex = 17
        Me.lblNue.Text = "NUE"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Empresa", "Persona"})
        Me.ComboBox1.Location = New System.Drawing.Point(93, 155)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(105, 21)
        Me.ComboBox1.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Tipo:"
        '
        'frmBeneficiario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(467, 301)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.lblNue)
        Me.Controls.Add(Me.txtNue)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.btnPrueba)
        Me.Controls.Add(Me.btnVerificar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtFechaNacimiento)
        Me.Controls.Add(Me.lblSexo)
        Me.Controls.Add(Me.cbxSexo)
        Me.Controls.Add(Me.cbxNacionalidad)
        Me.Controls.Add(Me.lblNacionalidad)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.txtBeneficiario)
        Me.Controls.Add(Me.id_beneficiario)
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Name = "frmBeneficiario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Beneficiario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents id_beneficiario As System.Windows.Forms.Label
    Friend WithEvents txtBeneficiario As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblNacionalidad As System.Windows.Forms.Label
    Friend WithEvents cbxNacionalidad As System.Windows.Forms.ComboBox
    Friend WithEvents cbxSexo As System.Windows.Forms.ComboBox
    Friend WithEvents lblSexo As System.Windows.Forms.Label
    Friend WithEvents dtFechaNacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnVerificar As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btnPrueba As System.Windows.Forms.Button
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents txtNue As System.Windows.Forms.TextBox
    Friend WithEvents lblNue As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class