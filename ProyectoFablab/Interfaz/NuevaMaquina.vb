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
        Dim dlg As New OpenFileDialog()
        dlg.FileName = ""
        dlg.DefaultExt = ".png"
        dlg.Filter = "Imagen (.png)|*.png"
        Dim result As Boolean = CBool(dlg.ShowDialog())
        If result = True Then
            Dim filename As String = dlg.FileName
            My.Computer.FileSystem.CopyFile(
            filename,
            My.Settings.MaquinasImg + "",
            Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
            Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
            'ImagenPictureBox.ImageLocation = filename
        End If
    End Sub

    Private Sub AceptarButton_Click(sender As Object, e As EventArgs) Handles AceptarButton.Click
        Try
            If AceptarButton.Text.Equals("Aceptar") Then
                Maquinas.Insertar(ModeloTextBox.Text, CDbl(PrecioTextBox.Text), CompraDateTimePicker.Value.Date, TelefonoTextBox.Text, NMComboBox.Text, DescripcionRichTextBox.Text, CaracteristicasRichTextBox.Text)
                'GuardarImagen(Usuario.ObtenerUltimoId())
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
        End If
    End Sub

    Private Sub ModeloTextBox_Validated(sender As Object, e As EventArgs) Handles ModeloTextBox.Validated
        ErrorProvider1.SetError(DirectCast(sender, Control), "")
    End Sub

    Private Sub PrecioTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles PrecioTextBox.Validating
        If PrecioTextBox.Text.Equals("") Then
            ErrorProvider1.SetError(DirectCast(sender, Control), "Este campo no puede estar vacio")
        ElseIf Double.Parse(PrecioTextBox.Text) < 0 Then
            ErrorProvider1.SetError(DirectCast(sender, Control), "El precio por hora tiene que ser mayor que 0")
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
End Class