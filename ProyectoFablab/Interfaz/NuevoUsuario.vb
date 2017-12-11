Public Class NuevoUsuario

    Private Sub NuevoUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NUTipoComboBox.DisplayMember = "tipo"
        NUTipoComboBox.DataSource = Negocio.TiposUsuarios()
    End Sub

    Private Sub NUAceptarButton_Click(sender As Object, e As EventArgs) Handles NUAceptarButton.Click
        Try
            Negocio.InsertarUsuario(NUNombreTextBox.Text, NUApellidosTextBox.Text, NUFechaNacMaskedTextBox.Text, NUTelefonoMaskedTextBox.Text, NUEmailTextBox.Text, NUDireccionTextBox.Text, NUOrganizacionTextBox.Text, NUTipoComboBox.Text, NUObservacionesTextBox.Text)
            MessageBox.Show(NUNombreTextBox.Text & " ha sido registrado.", "Usuario registrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch ex As ArgumentException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub NUCancelarButton_Click(sender As Object, e As EventArgs) Handles NUCancelarButton.Click
        Dim respuesta As DialogResult

        respuesta = MessageBox.Show("¿Estas seguro que deseas salir?", "Nuevo usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If respuesta = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        MessageBox.Show("Confirmado", "Nuevo usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

    End Sub
End Class