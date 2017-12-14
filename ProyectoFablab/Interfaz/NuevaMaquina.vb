Public Class Form3
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
            My.Settings.maquinasImg + "",
            Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
            Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
            'ImagenPictureBox.ImageLocation = filename
        End If
    End Sub

    Private Sub AceptarButton_Click(sender As Object, e As EventArgs) Handles AceptarButton.Click
        Try
            ' Maquinas.Insertar(ModeloTextBox.Text, CDbl(PrecioTextBox.Text), CompraDateTimePicker.Value.Date, TelefonoTextBox.Text, NMComboBox.Text, NUDireccionTextBox.Text, NUOrganizacionTextBox.Text, NUTipoComboBox.Text, NUObservacionesRichTextBox.Text)
            'GuardarImagen(Usuario.ObtenerUltimoId())
            'MessageBox.Show(NUNombreTextBox.Text & " ha sido registrado.", "Usuario registrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Dispose()
        Catch ex As ArgumentException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class