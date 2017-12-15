Imports System.IO

Public Class Form3
    Public Property id() As Integer
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarComboBox()

    End Sub
    Public Sub ActualizarComboBox()
        NMComboBox.DisplayMember = "tipo"
        NMComboBox.DataSource = TipoMaquina.ObtenerMaquinas()
    End Sub

    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles CancelarButton.Click
        Me.Close()
    End Sub
    Private Sub Examinar_Click(sender As Object, e As EventArgs) Handles ExaminarButton.Click
        Dim seleccionarImagen As New OpenFileDialog()
        Dim rutaImagen As String
        seleccionarImagen.Filter = "Imágenes (*.jpg)|*.jpg |Imágenes(*.png)|*.png|Todas las imágenes(*.*)|*.*"

        If seleccionarImagen.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            rutaImagen = seleccionarImagen.FileName
            Dim picturebox As New PictureBox()
            picturebox.Size = New Size(150, 120)
            picturebox.Image = Image.FromFile(rutaImagen)
            picturebox.ImageLocation = rutaImagen
            picturebox.SizeMode = PictureBoxSizeMode.StretchImage
            ImagenesFlowLayoutPanel.Controls.Add(picturebox)
            GuardarImagen(id, picturebox)
        End If
    End Sub
    Private Async Sub GuardarImagen(identificador As Integer, picture As PictureBox)
        Dim thumbnail As Byte()
        Dim nombreImagen As String
        thumbnail = Await ConseguirThumbnail(picture.ImageLocation)
        nombreImagen = identificador & Path.GetExtension(picture.ImageLocation)
        File.WriteAllBytes(My.Settings.MaquinasImg & nombreImagen, thumbnail)
    End Sub


    Private Sub AceptarButton_Click(sender As Object, e As EventArgs) Handles AceptarButton.Click
        Try
            If AceptarButton.Text.Equals("Aceptar") Then
                Maquinas.Insertar(ModeloTextBox.Text, CDbl(PrecioTextBox.Text), CompraDateTimePicker.Value.Date, TelefonoTextBox.Text, NMComboBox.Text, DescripcionRichTextBox.Text, CaracteristicasRichTextBox.Text)
                MessageBox.Show(ModeloTextBox.Text & " ha sido registrado.", "Maquina registrada", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf AceptarButton.Text.Equals("Guardar") Then
                Maquinas.Actualizar(id, ModeloTextBox.Text, CDbl(PrecioTextBox.Text), CompraDateTimePicker.Value.Date, TelefonoTextBox.Text, NMComboBox.Text, DescripcionRichTextBox.Text, CaracteristicasRichTextBox.Text)
                MessageBox.Show(ModeloTextBox.Text & " actualizado con exito.", "Maquina registrada", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            Me.Dispose()
        Catch ex As ArgumentException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PrecioTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PrecioTextBox.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TelefonoTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TelefonoTextBox.KeyPress
        If Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub ModeloTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ModeloTextBox.Validating
        If ModeloTextBox.Text.Equals("") Then
            ErrorProvider1.SetError(DirectCast(sender, Control), "Este campo no puede estar vacio")
            e.Cancel = True
        End If
    End Sub

    Private Sub ModeloTextBox_Validated(sender As Object, e As EventArgs) Handles ModeloTextBox.Validated
        ErrorProvider1.SetError(DirectCast(sender, Control), "")
    End Sub

    Private Sub PrecioTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles PrecioTextBox.Validating
        If PrecioTextBox.Text.Equals("") Then
            ErrorProvider1.SetError(DirectCast(sender, Control), "Este campo no puede estar vacio")
            e.Cancel = True
        ElseIf Double.Parse(PrecioTextBox.Text) < 0 Then
            ErrorProvider1.SetError(DirectCast(sender, Control), "El precio por hora tiene que ser mayor que 0")
            e.Cancel = True
        End If
    End Sub

    Private Sub PrecioTextBox_Validated(sender As Object, e As EventArgs) Handles PrecioTextBox.Validated
        ErrorProvider1.SetError(DirectCast(sender, Control), "")

    End Sub

    Private Sub Form3_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        ActualizarComboBox()
    End Sub

    Private Sub AnadirButton_Click(sender As Object, e As EventArgs) Handles AnadirButton.Click
        Dim nuevotipo As NuevoTipoMaquina = New NuevoTipoMaquina()
        nuevotipo.MdiParent = VentanaPrincipal
        nuevotipo.Show()
    End Sub
    Private Sub CargarImgsMaquinaSeleccionada()

        Dim arrayImgs As String() = Directory.GetFiles(My.Settings.MaquinasImg, id & "*")

        For Each img As String In arrayImgs

            Dim bitmap As New Bitmap(My.Settings.MaquinasImg & img)

            AddImagenAListaImgs(bitmap)

        Next

    End Sub
    Private Sub AddImagenAListaImgs(ByRef imagen As Bitmap)

        Dim pb As New PictureBox()
        pb.Size = New Size(142, 122)

        pb.Image = DirectCast(imagen, Image)
        pb.SizeMode = PictureBoxSizeMode.StretchImage

        ImagenesFlowLayoutPanel.Controls.Add(pb)

    End Sub
End Class