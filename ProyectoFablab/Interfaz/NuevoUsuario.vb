Public Class NuevoUsuario

    Private Sub NuevoUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NUTipoComboBox.DisplayMember = "tipo"
        NUTipoComboBox.DataSource = Negocio.TiposUsuarios()
    End Sub

    Private Sub NUAceptarButton_Click(sender As Object, e As EventArgs) Handles NUAceptarButton.Click
        Try
            Negocio.InsertarUsuario(NUNombreTextBox.Text, NUApellidosTextBox.Text, NUFechaDateTimePicker.Value.Date, NUTelefonoTextBox.Text, NUEmailTextBox.Text, NUDireccionTextBox.Text, NUOrganizacionTextBox.Text, NUTipoComboBox.Text, NUObservacionesRichTextBox.Text)
            MessageBox.Show(NUNombreTextBox.Text & " ha sido registrado.", "Usuario registrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Dispose()
        Catch ex As ArgumentException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub NUCancelarButton_Click(sender As Object, e As EventArgs) Handles NUCancelarButton.Click
        Me.Close()
    End Sub

    Private Sub TipoButton_Click(sender As Object, e As EventArgs) Handles TipoButton.Click
        MessageBox.Show("Confirmado", "Nuevo usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

    End Sub



    Private Sub NuevoUsuario_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim respuesta As DialogResult

        respuesta = MessageBox.Show("¿Estas seguro que deseas salir?", "Nuevo usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If Not respuesta = DialogResult.Yes Then
            e.Cancel = True
        End If
    End Sub

    Private Sub NUExaminaButton_Click(sender As Object, e As EventArgs) Handles NUExaminaButton.Click

    End Sub
End Class