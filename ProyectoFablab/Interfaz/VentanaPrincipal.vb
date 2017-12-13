Class VentanaPrincipal

    Private Sub NuevoUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoUsuarioToolStripMenuItem.Click
        Dim nuevo As NuevoUsuario = New NuevoUsuario()

        nuevo.Show()
    End Sub

    Private Sub VentanaPrincipal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        VentanaBienvenida.Close()
    End Sub



    Private Sub GestionDeUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDeUsuariosToolStripMenuItem.Click
        Dim gestion As GestionUsuarios = New GestionUsuarios()

        gestion.Show()
    End Sub

    Private Sub GestionIcoToolStripButton_Click(sender As Object, e As EventArgs) Handles GestionIcoToolStripButton.Click
        GestionDeUsuariosToolStripMenuItem.PerformClick()
    End Sub

    Private Sub UsuarioIcoToolStripButton_Click(sender As Object, e As EventArgs) Handles UsuarioIcoToolStripButton.Click
        NuevoUsuarioToolStripMenuItem.PerformClick()
    End Sub

    Private Sub VentanaPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
