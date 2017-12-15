
Public Class GestionUsuarios
    Private Enlace As BindingSource
    Dim resultado As New DataSet
    Dim usuarios As DataTable
    Dim nuevo As NuevoUsuario
    Dim _actualizar As Boolean


    Private Sub GestionUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Actualizar = True
    End Sub

    Public Sub CargarDatos()
        Dim dataTable As DataTable = Usuario.SeleccionarUsuarios()
        Dim dataSet As New DataSet()
        dataSet.Tables.Add(dataTable)
        Enlace = New BindingSource(dataSet, "Usuarios")
        GUDataGridView.DataSource = Enlace
        usuarios = Usuario.SeleccionarUsuarios
        GUDataGridView.DataSource = usuarios
        GUDataGridView.Columns(0).Visible = False
        GUDataGridView.Columns(3).Visible = False
        GUDataGridView.Columns(4).Visible = False
        GUDataGridView.Columns(5).Visible = False
        GUDataGridView.Columns(6).Visible = False
        GUDataGridView.Columns(8).Visible = False
        GUDataGridView.Columns(10).Visible = False
        GUDataGridView.Columns(11).Visible = False
        GUDataGridView.Columns(12).DisplayIndex = 3
        GUDataGridView.Columns(1).HeaderText = "Nombre"
        GUDataGridView.Columns(2).HeaderText = "Apellidos"
        GUDataGridView.Columns(7).HeaderText = "Organización"
        GUDataGridView.Columns(9).HeaderText = "Fecha de alta"
        GUDataGridView.Columns(12).HeaderText = "Tipos de usuario"
        GUDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

    End Sub

    Public Property Actualizar() As Boolean
        Get
            Return _actualizar
        End Get
        Set(value As Boolean)
            If value Then
                CargarDatos()
            End If
        End Set
    End Property
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
        Try
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
                consulta.NUAceptarButton.Visible = False
                consulta.NUCancelarButton.Text = "Salir"
                consulta.Show()

            Else
                MessageBox.Show("Selecciona una fila :). ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As ArgumentException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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

    Private Sub GUEditarButton_Click(sender As Object, e As EventArgs) Handles GUEditarButton.Click
        Dim consulta As NuevoUsuario = New NuevoUsuario()
        consulta.MdiParent = VentanaPrincipal
        Try
            If GUDataGridView.SelectedRows.Count = 1 Then
                consulta.id = DirectCast(GUDataGridView.SelectedRows(0).Cells(0).Value, Integer)
                consulta.NUNombreTextBox.Text = String.Format("{0}", GUDataGridView.SelectedRows(0).Cells(1).Value)
                consulta.NUApellidosTextBox.Text = String.Format("{0}", GUDataGridView.SelectedRows(0).Cells(2).Value)
                consulta.NUFechaDateTimePicker.Value = DirectCast(GUDataGridView.SelectedRows(0).Cells(3).Value, DateTime)
                consulta.NUTelefonoTextBox.Text = String.Format("{0}", GUDataGridView.SelectedRows(0).Cells(4).Value)
                consulta.NUEmailTextBox.Text = String.Format("{0}", GUDataGridView.SelectedRows(0).Cells(5).Value)
                consulta.NUDireccionTextBox.Text = String.Format("{0}", GUDataGridView.SelectedRows(0).Cells(6).Value)
                consulta.NUOrganizacionTextBox.Text = String.Format("{0}", GUDataGridView.SelectedRows(0).Cells(7).Value)
                consulta.NUObservacionesRichTextBox.Text = String.Format("{0}", GUDataGridView.SelectedRows(0).Cells(10).Value)
                consulta.ActualizarComboBox()
                consulta.NUTipoComboBox.SelectedIndex = DirectCast(GUDataGridView.SelectedRows(0).Cells(11).Value, Integer) - 1
                consulta.NUTipoComboBox.SelectedIndex = 0
                consulta.NUFotoPictureBox.Image = ObtenerImagen(String.Format("{0}", GUDataGridView.SelectedRows(0).Cells(0).Value))
                consulta.NUFotoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
                consulta.NUAceptarButton.Text = "Guardar"
                consulta.Show()
            Else
                MessageBox.Show("Selecciona una fila :). ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As ArgumentException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GestionUsuarios_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        Actualizar = True
    End Sub

    Private Sub GUEliminarButton_Click(sender As Object, e As EventArgs) Handles GUEliminarButton.Click
        Dim respuesta As DialogResult
        Try
            If GUDataGridView.SelectedRows.Count = 1 Then
                Try
                    respuesta = MessageBox.Show("¿Estas seguro que deseas eliminar a este usuario?", "Eliminar usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                    If respuesta = DialogResult.Yes Then
                        Usuario.EliminarUsuario(DirectCast(GUDataGridView.SelectedRows(0).Cells(0).Value, Integer))
                        MessageBox.Show("El usuario ha sido eliminado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Actualizar = True
                    End If

                Catch ex As ArgumentException
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            Else
                MessageBox.Show("Selecciona una fila :). ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As ArgumentException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class