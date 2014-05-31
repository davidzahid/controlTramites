'LIBRERIAS IMPORTANTES PARA EXCEL'
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

        Try
            If (txtNombre.Text.Equals("MODESTA LUCIA SANDOVAL") Or txtNue.Text.Equals("1234")) Then
                MessageBox.Show("Usuario Existente")
                'datos que se cargaran de la base de datos 
                'en caso de que el nombre del beneficiario o el NUT exista'
                txtBeneficiario.Text = 2
                txtNombre.Text = "MODESTA LUCIA SANDOVAL"
                cbxNacionalidad.Text = "Nicaragua"
                cbxSexo.Text = "Femenina"
                cbxNacionalidad.Enabled = False
                cbxSexo.Enabled = False
                dtFechaNacimiento.Enabled = False
                frmControlTramites.Show()
                '-------------------------------'
            Else
                MessageBox.Show("Registre nuevo usuario")
                txtBeneficiario.Text = 2
                lblNombre.Enabled = True
                cbxNacionalidad.Enabled = True
                cbxSexo.Enabled = True
                dtFechaNacimiento.Enabled = True

            End If
        Catch ex As Exception

        End Try

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


    Private Sub dtFechaNacimiento_ValueChanged(sender As Object, e As EventArgs) Handles dtFechaNacimiento.ValueChanged
        txtFecha.Text = dtFechaNacimiento.Value
    End Sub

    Private Sub BeneficiariosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.BeneficiariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ControltramitesDataSet)

    End Sub
End Class
