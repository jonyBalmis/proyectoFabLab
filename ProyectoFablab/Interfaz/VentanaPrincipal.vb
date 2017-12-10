Class VentanaPrincipal
    Private Sub NuevoUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoUsuarioToolStripMenuItem.Click

    End Sub

    Private Sub VentanaPrincipal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        VentanaBienvenida.Close()
    End Sub
End Class
