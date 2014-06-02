Public Class frmControlTramites

    Private Sub frmControlTramites_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'corregir este dato para que cuando se asigne la edad del beneficiario'
        'timestamp.ToString(("dd/MM/yyyy HH:mm:ss tt")).ToString - frmBeneficiario.txtFecha.Text


        'DATOS EXTRAIDOS DEL FORMULARIO BENEFICIARIO'
        txtNombreB.Text = frmBeneficiario.txtNombre.Text
        txtNacionalidadB.Text = frmBeneficiario.cbxNacionalidad.Text
        txtSexoB.Text = frmBeneficiario.cbxSexo.Text

        'Extraer Fecha de Nacimiento del Beneficiario'
        dtFechaNacimientoB.Value = frmBeneficiario.txtFecha.Text()

        '____________________________________________'
        'CON LA SIGUIENTE FUNCIÓN SE EXTRAE LA EDAD DEL BENEFICIARIO
        Dim fnac As Date = Convert.ToDateTime(frmBeneficiario.txtFecha.Text())
        Dim Diferencia As TimeSpan
        Diferencia = Today.Subtract(fnac)
        txtEdad.Text = Fix(Diferencia.TotalDays / 365.25)

        '*******************************************'
    End Sub


End Class