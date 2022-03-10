Public Class FrmOperadores

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Visible = False
        FrmPrincipal.Show()
    End Sub

    Private Sub FrmOperadores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Cargamos la lista de operadores
        Dim oOper As New Usuarios
        oOper.CargarOperadores()
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        'Seleccionamos el operador
        FrmPrincipal.txtOperador.Text = ListOperadores.SelectedItem
        Me.Visible = False
        FrmPrincipal.Show()
        FrmPrincipal.BtnRonda.Focus()
    End Sub

    Private Sub ListOperadores_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListOperadores.SelectedIndexChanged
        BtnAceptar.Focus()
    End Sub
End Class