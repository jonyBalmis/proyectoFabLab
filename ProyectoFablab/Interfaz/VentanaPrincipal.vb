Class VentanaPrincipal

    Private Sub NuevoUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoUsuarioToolStripMenuItem.Click
        Dim nuevo As NuevoUsuario = New NuevoUsuario()
        nuevo.MdiParent = Me
        nuevo.ActualizarComboBox()
        nuevo.Show()
    End Sub

    Private Sub VentanaPrincipal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        VentanaBienvenida.Close()
    End Sub



    Private Sub GestionDeUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDeUsuariosToolStripMenuItem.Click
        Dim gestion As GestionUsuarios = New GestionUsuarios()
        gestion.MdiParent = Me
        gestion.Show()
    End Sub

    Private Sub GestionIcoToolStripButton_Click(sender As Object, e As EventArgs) Handles GestionIcoToolStripButton.Click
        GestionDeUsuariosToolStripMenuItem.PerformClick()
    End Sub

    Private Sub UsuarioIcoToolStripButton_Click(sender As Object, e As EventArgs) Handles UsuarioIcoToolStripButton.Click

        NuevoUsuarioToolStripMenuItem.PerformClick()

    End Sub

    Private Sub VentanaPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InfoUToolStripStatusLabel.Text = "Usuarios: " & Usuario.ContarUsuarios()
    End Sub

    Private Sub AcercaDe_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click, AcercaDeToolStripMenuItem.Click
        Dim acerca As AcercaDe = New AcercaDe()
        acerca.MdiParent = Me
        acerca.Show()

    End Sub

    Private Sub NuevaMaquina_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click, NuevaMáquinaToolStripMenuItem.Click
        Dim nueva As Form3 = New Form3()
        nueva.MdiParent = Me
        nueva.Show()
    End Sub

    Private Sub GestionarMaquinas_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click, GestiónDeMáquinasToolStripMenuItem.Click
        Dim gestion As GestionMaquinas = New GestionMaquinas()
        gestion.MdiParent = Me
        gestion.Show()
    End Sub

    Private Sub CascadaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CascadaToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub MosaicoHorizontalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MosaicoHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub MosaicoVerticalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MosaicoVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub MinizarVentanasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinizarVentanasToolStripMenuItem.Click

        For Each ventana As Form In Me.MdiChildren

            ventana.WindowState = FormWindowState.Minimized

        Next

    End Sub


End Class
