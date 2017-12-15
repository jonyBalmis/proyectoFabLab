Imports Microsoft.ProjectOxford.Vision
Imports System.IO
Public Class NuevoUsuario
    Public Property id() As Integer
    Private imagenSeleccionada As Boolean

    Private Sub NuevoUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        imagenSeleccionada = False
    End Sub

    Private Sub NUAceptarButton_Click(sender As Object, e As EventArgs) Handles NUAceptarButton.Click
        Try
            If NUAceptarButton.Text.Equals("Aceptar") Then
                Usuario.Insertar(NUNombreTextBox.Text, NUApellidosTextBox.Text, NUFechaDateTimePicker.Value.Date, NUTelefonoTextBox.Text, NUEmailTextBox.Text, NUDireccionTextBox.Text, NUOrganizacionTextBox.Text, NUTipoComboBox.Text, NUObservacionesRichTextBox.Text)
                Me.id = Usuario.ObtenerUltimoId()
                GuardarImagen(Me.id)
                VentanaPrincipal.ActualizarEstados()
                MessageBox.Show(NUNombreTextBox.Text & " ha sido registrado.", "Usuario registrado", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ElseIf NUAceptarButton.Text.Equals("Guardar") Then
                'La id se obtiene desde la instancia creada en GestionUsuarios botón Editar
                Usuario.ActualizarUsuario(Me.id, NUNombreTextBox.Text, NUApellidosTextBox.Text, NUFechaDateTimePicker.Value.Date, NUTelefonoTextBox.Text, NUEmailTextBox.Text, NUDireccionTextBox.Text, NUOrganizacionTextBox.Text, NUTipoComboBox.Text, NUObservacionesRichTextBox.Text)
                GuardarImagen(Me.id)
                MessageBox.Show("Los datos de " & NUNombreTextBox.Text & " han sido guardados.", "Datos guardados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            Me.Dispose()
        Catch ex As ArgumentException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub NUCancelarButton_Click(sender As Object, e As EventArgs) Handles NUCancelarButton.Click
        Me.Close()
    End Sub

    Private Sub NUTipoButton_Click(sender As Object, e As EventArgs) Handles NUTipoButton.Click
        Dim nuevoTipo As NuevoTipoUsuario = New NuevoTipoUsuario()
        nuevoTipo.Show()

    End Sub



    Private Sub NuevoUsuario_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim respuesta As DialogResult

        respuesta = MessageBox.Show("¿Estas seguro que deseas salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If Not respuesta = DialogResult.Yes Then
            e.Cancel = True
        End If
    End Sub

    Private Sub NUExaminarButton_Click(sender As Object, e As EventArgs) Handles NUExaminarButton.Click
        Dim seleccionarImagen As New OpenFileDialog()
        Dim rutaImagen As String
        seleccionarImagen.Filter = "Imágenes (*.jpg)|*.jpg |Imágenes(*.png)|*.png|Todas las imágenes(*.*)|*.*"

        If seleccionarImagen.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            rutaImagen = seleccionarImagen.FileName
            Me.NUFotoPictureBox.Image = Image.FromFile(rutaImagen)
            Me.NUFotoPictureBox.ImageLocation = rutaImagen
            Me.NUFotoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
            imagenSeleccionada = True
        End If
    End Sub


    Private Async Sub GuardarImagen(identificador As Integer)
        Dim thumbnail As Byte()
        Dim nombreImagen As String

        If imagenSeleccionada Then
            thumbnail = Await ConseguirThumbnail(NUFotoPictureBox.ImageLocation)
            nombreImagen = identificador & Path.GetExtension(NUFotoPictureBox.ImageLocation)
            File.WriteAllBytes(My.Settings.UsuariosImg & nombreImagen, thumbnail)
        End If


    End Sub

    Public Sub ActualizarComboBox()
        NUTipoComboBox.DisplayMember = "tipo"
        NUTipoComboBox.DataSource = TipoUsuario.SeleccionarTipos()
    End Sub

    Private Sub NuevoUsuario_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        ActualizarComboBox()
    End Sub
End Class