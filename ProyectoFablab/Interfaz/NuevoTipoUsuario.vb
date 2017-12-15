Public Class NuevoTipoUsuario
    Private Sub AceptarTipoButton_Click(sender As Object, e As EventArgs) Handles AceptarTipoButton.Click

        Try
            TipoUsuario.InsertarTipo(AddTipoTextBox.Text)
            ' NuevoUsuario.ActualizarComboBox()
            Me.Close()
        Catch ex As ArgumentException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub CancelarTipoButton_Click(sender As Object, e As EventArgs) Handles CancelarTipoButton.Click
        Me.Close()
    End Sub
End Class