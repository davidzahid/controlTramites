﻿'LIBRERIAS IMPORTANTES PARA EXCEL'
Imports Microsoft.Office.Core
Imports Microsoft.Office.Interop.Excel
Imports System.Data

'PARA QUE NO MARQUE ERROR AL AGREGAR LIBRERIAS SE DEBE AGREGAR LA REFERENCIA'
'Microsoft Excel #.# Object Library'


Public Class frmBeneficiario
 


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ControltramitesDataSet.beneficiarios' Puede moverla o quitarla según sea necesario.
        Me.BeneficiariosTableAdapter.Fill(Me.ControltramitesDataSet.beneficiarios)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnVerificar.Click
        'RECIBE SELECCION DE txtnue

        Try
            If (txtNue.Text.Length) > 0 Then
                txtBeneficiario.Text = Val(Me.BeneficiariosTableAdapter.consultar_nue(txtNue.Text))

                If (txtBeneficiario.Text = Val(Me.BeneficiariosTableAdapter.consultar_nue(txtNue.Text))) Then
                    'AGREGAMOS DATOS DEL BENEFICIARIO EN CASO DE QUE ÉSTE EXISTA'
                    txtNombre.Text = (Me.BeneficiariosTableAdapter.consulta_nombre_nue(txtNue.Text))
                    cbxSexo.Text = (Me.BeneficiariosTableAdapter.consulta_sexo_nue(txtNue.Text))
                    cbxNacionalidad.Text = (Me.BeneficiariosTableAdapter.consulta_nacionalidad_nue(txtNue.Text))
                    cbxTipoBeneficiario.Text = (Me.BeneficiariosTableAdapter.consulta_tipo_nue(txtNue.Text))
                    dtFechaNacimiento.Value = (Me.BeneficiariosTableAdapter.consulta_fechanacimiento_nue(txtNue.Text))


                    If (cbxTipoBeneficiario.Text = "Empresa") Then
                        cbxNacionalidad.Text = (Me.BeneficiariosTableAdapter.consulta_nacionalidad_nue(txtNue.Text))
                        cbxTipoBeneficiario.Text = (Me.BeneficiariosTableAdapter.consulta_tipo_nue(txtNue.Text))
                    ElseIf (cbxTipoBeneficiario.Text = "Persona") Then
                        txtNombre.Text = (Me.BeneficiariosTableAdapter.consulta_nombre_nue(txtNue.Text))
                        cbxSexo.Text = (Me.BeneficiariosTableAdapter.consulta_sexo_nue(txtNue.Text))
                        cbxNacionalidad.Text = (Me.BeneficiariosTableAdapter.consulta_nacionalidad_nue(txtNue.Text))
                        cbxTipoBeneficiario.Text = (Me.BeneficiariosTableAdapter.consulta_tipo_nue(txtNue.Text))
                        dtFechaNacimiento.Value = (Me.BeneficiariosTableAdapter.consulta_fechanacimiento_nue(txtNue.Text))
                    End If
                    ''
                    Dim result As Integer = MessageBox.Show("Para continuar, presionar Aceptar", "Beneficiario Encontrado con Nue", MessageBoxButtons.OKCancel)
                    If result = DialogResult.Cancel Then
                        MessageBox.Show("Presiono cancelar")
                        'Agregar función mas adelante'
                    ElseIf result = DialogResult.OK Then
                        frmControlTramites.Show()
                    End If

                End If

                'FINALIZA CICLO DE VERIFICACIÓN DE NUE'
            ElseIf (txtNombre.Text.Length > 0) Then
                txtBeneficiario.Text = Val(Me.BeneficiariosTableAdapter.consultar_nombre(txtNombre.Text))

                If (txtBeneficiario.Text = Val(Me.BeneficiariosTableAdapter.consultar_nombre(txtNombre.Text))) Then
                    'AGREGAMOS DATOS DEL BENEFICIARIO EN CASO DE QUE ÉSTE EXISTA'

               
                    If (cbxTipoBeneficiario.Text = "Empresa") Then
                        cbxNacionalidad.Text = (Me.BeneficiariosTableAdapter.consulta_nacionalidad_nombre(txtNombre.Text))
                        cbxTipoBeneficiario.Text = (Me.BeneficiariosTableAdapter.consulta_tipo_nombre(txtNombre.Text))
                    ElseIf (cbxTipoBeneficiario.Text = "Persona") Then
                        cbxSexo.Text = (Me.BeneficiariosTableAdapter.consulta_sexo_nombre(txtNombre.Text))
                        cbxNacionalidad.Text = (Me.BeneficiariosTableAdapter.consulta_nacionalidad_nombre(txtNombre.Text))
                        cbxTipoBeneficiario.Text = (Me.BeneficiariosTableAdapter.consulta_tipo_nombre(txtNombre.Text))
                        dtFechaNacimiento.Value = (Me.BeneficiariosTableAdapter.consulta_fechanacimiento_nombre(txtNombre.Text))
                        txtNue.Text = (Me.BeneficiariosTableAdapter.consulta_nue_nombre(txtNombre.Text))
                    End If
                    ''
                    Dim result As Integer = MessageBox.Show("Para continuar, presionar Aceptar", "Beneficiario Encontrado con Nombre", MessageBoxButtons.OKCancel)
                    If result = DialogResult.Cancel Then
                        MessageBox.Show("Cancel pressed")
                    ElseIf result = DialogResult.OK Then
                        frmControlTramites.Show()
                    End If


                End If

                'FINALIZA CICLO DE VERIFICACIÓN DE NUE'
            Else

                MessageBox.Show("Ingrese NUE o NOMBRE")
            End If



        Catch ex As Exception
      
            If (txtNue.Text.Length) > 0 Then
                If (txtBeneficiario.Text < Val(Me.BeneficiariosTableAdapter.consultar_nue(txtNue.Text))) Then
                    Dim result As Integer = MessageBox.Show("Lamentablemente el beneficiario con NUE: " + txtNue.Text + " no existe, ¿desea registrarlo?", "Aviso", MessageBoxButtons.OKCancel)
                    If result = DialogResult.Cancel Then
                        MessageBox.Show("Presiono cancelar")
                        'Agregar función mas adelante'
                    ElseIf result = DialogResult.OK Then

                        txtNue.Focus()
                    End If
                End If
            ElseIf (txtNombre.Text.Length) > 0 Then
                If (txtBeneficiario.Text < Val(Me.BeneficiariosTableAdapter.consultar_nombre(txtNombre.Text))) Then
                    Dim result As Integer = MessageBox.Show("Lamentablemente el beneficiario con Nombre: " + txtNombre.Text + " no existe, ¿desea registrarlo?", "Aviso", MessageBoxButtons.OKCancel)
                    If result = DialogResult.Cancel Then
                        MessageBox.Show("Presiono cancelar")
                        'Agregar función mas adelante'
                    ElseIf result = DialogResult.OK Then

                        txtNue.Focus()
                    End If
                End If
            End If
        End Try

        '        
        '       Try
        'If (txtNombre.Text.Equals("MODESTA LUCIA SANDOVAL") Or txtNue.Text.Equals("1234")) Then
        '    MessageBox.Show("Usuario Existente")
        'datos que se cargaran de la base de datos 
        'en caso de que el nombre del beneficiario o el NUT exista'
        'txtBeneficiario.Text = 2
        'txtNombre.Text = "MODESTA LUCIA SANDOVAL"
        'cbxNacionalidad.Text = "Nicaragua"
        'cbxSexo.Text = "Femenina"
        'cbxNacionalidad.Enabled = False
        'cbxSexo.Enabled = False
        'dtFechaNacimiento.Enabled = False
        'frmControlTramites.Show()
        '-------------------------------'
        'Else
        'MessageBox.Show("Registre nuevo usuario")
        'txtBeneficiario.Text = 2
        'lblNombre.Enabled = True
        'cbxNacionalidad.Enabled = True
        'cbxSexo.Enabled = True
        'dtFechaNacimiento.Enabled = True

        'End If
        'Catch ex As Exception

        '        End Try

    End Sub


    Private Sub btnPrueba_Click(sender As Object, e As EventArgs) Handles btnPrueba.Click
        Dim apExcel = New Microsoft.Office.Interop.Excel.Application
        Dim Libro = apExcel.Workbooks.Add
        Libro.Sheets(1).cells(2, 2) = txtNombre.Text
        SaveFileDialog1.DefaultExt = "*.xlsx"
        SaveFileDialog1.FileName = "Un nombre"
        SaveFileDialog1.Filter = "Archivos de excel (*.xlsx)|*.xlsx"
        SaveFileDialog1.ShowDialog()

        Libro.SaveAs(SaveFileDialog1.FileName)
        apExcel.Quit()
        Libro = Nothing
    End Sub




    Private Sub BeneficiariosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.BeneficiariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ControltramitesDataSet)

    End Sub

    Private Sub dtFechaNacimiento_ValueChanged(sender As Object, e As EventArgs) Handles dtFechaNacimiento.ValueChanged
        txtFecha.Text = dtFechaNacimiento.Value
    End Sub

   

  
    Private Sub cbxTipoBeneficiario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxTipoBeneficiario.SelectedIndexChanged
        Refresh()
        If (cbxTipoBeneficiario.Text = "Empresa") Then
            txtNue.Enabled = False
            cbxSexo.Enabled = False
            dtFechaNacimiento.Enabled = False

            txtNue.Clear()
            cbxSexo.ResetText()
            dtFechaNacimiento.ResetText()

            txtNombre.Focus()
        ElseIf (cbxTipoBeneficiario.Text = "Persona") Then
            txtNue.Enabled = True
            cbxSexo.Enabled = True
            dtFechaNacimiento.Enabled = True
            txtNue.Focus()
        End If
    End Sub


End Class
