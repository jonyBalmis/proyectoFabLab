Class VentanaPrincipal
    Private Sub NuevoUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoUsuarioToolStripMenuItem.Click
        Dim nuevo As NuevoUsuario = New NuevoUsuario()
        nuevo.Show()
    End Sub

    Private Sub VentanaPrincipal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        VentanaBienvenida.Close()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        NuevoUsuarioToolStripMenuItem.PerformClick()
    End Sub


End Class
