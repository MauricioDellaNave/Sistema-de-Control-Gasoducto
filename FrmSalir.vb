Public Class FrmSalir


    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        FrmPrincipal.Show()
    End Sub

    Private Sub btnTeclado_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTeclado.Click
        If Me.InputPanel1.Enabled = True Then
            Me.InputPanel1.Enabled = False
        Else
            Me.InputPanel1.Enabled = True
        End If
        txtClave.Focus()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim oUsuario As New Usuarios
        If oUsuario.ValidarSupervisor(Me.txtClave.Text) Then
            Application.Exit()
        Else
            MsgBox("La clave ingresada es incorrecta", MsgBoxStyle.Exclamation, "Informacion del sistema")
            Me.txtClave.Text = ""
            Me.txtClave.Focus()
        End If
    End Sub

    Private Sub FrmSalir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtClave.Focus()
        txtPlanta.Text = FrmPrincipal.txtPlanta.Text
        txtOperador.Text = FrmPrincipal.txtOperador.Text
    End Sub

    Private Sub txtClave_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtClave.KeyDown
        If e.KeyData = Keys.Enter Then
            Dim oUsuario As New Usuarios
            If oUsuario.ValidarSupervisor(Me.txtClave.Text) Then
                Application.Exit()
            Else
                MsgBox("La clave ingresada es incorrecta", MsgBoxStyle.Exclamation, "Informacion del sistema")
                Me.txtClave.Text = ""
                Me.txtClave.Focus()
            End If
        End If

    End Sub

End Class