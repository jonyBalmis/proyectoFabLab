
Public Class GestionUsuarios
    Private Enlace As BindingSource
    Dim resultado As New DataSet
    Dim usuarios As DataTable
    Dim nuevo As NuevoUsuario


    Private Sub GestionUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dataTable As DataTable = Usuario.SeleccionarUsuarios()
        Dim dataSet As New DataSet()
        dataSet.Tables.Add(dataTable)
        Enlace = New BindingSource(dataSet, "Usuarios")
        GUDataGridView.DataSource = Enlace
        usuarios = Usuario.SeleccionarUsuarios
        GUDataGridView.DataSource = usuarios
        GUDataGridView.Columns(0).Visible = False
        GUDataGridView.Columns(8).Visible = False
        GUDataGridView.Columns(10).Visible = False
        GUDataGridView.Columns(11).Visible = False
        GUDataGridView.Columns(12).DisplayIndex = 8
        GUDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub GUBuscarTextBox_TextChanged(sender As Object, e As EventArgs) Handles GUBuscarTextBox.TextChanged

        Enlace.Filter = "nombre LIKE '" & GUBuscarTextBox.Text & "%'"
        GUDataGridView.DataSource = Enlace

    End Sub

    Private Sub GUNuevoButton_Click(sender As Object, e As EventArgs) Handles GUNuevoButton.Click
        Dim nuevo As NuevoUsuario = New NuevoUsuario()
        nuevo.MdiParent = VentanaPrincipal
        nuevo.Show()

    End Sub

    Private Sub GUConsultarButton_Click(sender As Object, e As EventArgs) Handles GUConsultarButton.Click
        Dim consulta As NuevoUsuario = New NuevoUsuario()
        consulta.MdiParent = VentanaPrincipal

        If GUDataGridView.SelectedRows.Count = 1 Then
            consulta.NUNombreTextBox.Text = String.Format("{0}", GUDataGridView.SelectedRows(0).Cells(1).Value)
            consulta.NUNombreTextBox.ReadOnly = True
            consulta.NUApellidosTextBox.Text = String.Format("{0}", GUDataGridView.SelectedRows(0).Cells(2).Value)
            consulta.NUApellidosTextBox.ReadOnly = True
            consulta.NUFechaDateTimePicker.Value = DirectCast(GUDataGridView.SelectedRows(0).Cells(3).Value, DateTime)
            consulta.NUFechaDateTimePicker.Enabled = False
            consulta.NUTelefonoTextBox.Text = String.Format("{0}", GUDataGridView.SelectedRows(0).Cells(4).Value)
            consulta.NUTelefonoTextBox.ReadOnly = True
            consulta.NUEmailTextBox.Text = String.Format("{0}", GUDataGridView.SelectedRows(0).Cells(5).Value)
            consulta.NUEmailTextBox.ReadOnly = True
            consulta.NUDireccionTextBox.Text = String.Format("{0}", GUDataGridView.SelectedRows(0).Cells(6).Value)
            consulta.NUDireccionTextBox.ReadOnly = True
            consulta.NUOrganizacionTextBox.Text = String.Format("{0}", GUDataGridView.SelectedRows(0).Cells(7).Value)
            consulta.NUOrganizacionTextBox.ReadOnly = True
            consulta.NUObservacionesRichTextBox.Text = String.Format("{0}", GUDataGridView.SelectedRows(0).Cells(10).Value)
            consulta.NUObservacionesRichTextBox.ReadOnly = True
            consulta.NUTipoComboBox.Items.Add(String.Format("{0}", GUDataGridView.SelectedRows(0).Cells(12).Value))
            consulta.NUTipoComboBox.SelectedIndex = 0
            consulta.NUTipoComboBox.Enabled = False
            consulta.NUTipoButton.Visible = False
            consulta.NUExaminarButton.Visible = False
            consulta.NUFotoPictureBox.Image = ObtenerImagen(String.Format("{0}", GUDataGridView.SelectedRows(0).Cells(0).Value))
            consulta.NUFotoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
            consulta.Show()

        Else
            MessageBox.Show("Selecciona una fila :). ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    ''' <summary>
    ''' Obtiene la imagen del usuario.
    ''' </summary>
    ''' <param name="id">Identificador del usuario</param>
    ''' <returns>Imagen del usuario.</returns>
    Private Function ObtenerImagen(id As String) As Image

        Dim directorio As System.IO.DirectoryInfo = New System.IO.DirectoryInfo(My.Settings.UsuariosImg)


        If directorio.GetFiles(id & ".png").Count() = 0 And directorio.GetFiles(id & ".jpg").Count() = 0 Then
            Return Image.FromFile(My.Settings.UsuariosImg & "0.png")
        End If
        Return Image.FromFile(My.Settings.UsuariosImg & id & ".png")
    End Function
End Class