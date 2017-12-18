Imports System.IO

Public Class GestionMaquinas
    Private source As BindingSource
    Dim dataSet As DataSet
    Dim hintActivo As Boolean = True



    Private Sub GestionMaquinas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatos()
        GMTablaDataGridView.Columns(1).HeaderText = "Modelo"
        GMTablaDataGridView.Columns(2).HeaderText = "Precio / Hora"
        GMTablaDataGridView.Columns(9).HeaderText = "Tipo de Máquina"
        GMTablaDataGridView.Columns(4).HeaderText = "Teléfono SAT"
    End Sub
    Public Sub CargarDatos()
        dataSet = New DataSet()
        dataSet.Tables.Add(Maquinas.ObtenerMaquinas())
        source = New BindingSource(dataSet, "Maquinas")
        GMTablaDataGridView.DataSource = Maquinas.ObtenerMaquinas()
        GMTablaDataGridView.Columns(0).Visible = False
        GMTablaDataGridView.Columns(3).Visible = False
        GMTablaDataGridView.Columns(5).Visible = False
        GMTablaDataGridView.Columns(6).Visible = False
        GMTablaDataGridView.Columns(7).Visible = False
        GMTablaDataGridView.Columns(8).Visible = False
        GMTablaDataGridView.Columns(9).DisplayIndex = 2
        GMTablaDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub



    Private Sub GMBuscarTextBox_TextChanged(sender As Object, e As EventArgs) Handles GMBuscarTextBox.TextChanged

        source.Filter = "modelo LIKE '%" & GMBuscarTextBox.Text & "%'"
        GMTablaDataGridView.DataSource = source
    End Sub

    Private Sub NuevaButton_Click(sender As Object, e As EventArgs) Handles NuevaButton.Click
        Dim nueva As New Form3()

        nueva.MdiParent = VentanaPrincipal.ActiveForm
        nueva.Show()
    End Sub

    Private Sub ConsultarButton_Click(sender As Object, e As EventArgs) Handles ConsultarButton.Click
        Dim consulta As New Form3()
        consulta.MdiParent = VentanaPrincipal.ActiveForm
        Try
            If GMTablaDataGridView.SelectedRows.Count = 1 Then
                consulta.ModeloTextBox.Text = String.Format("{0}", GMTablaDataGridView.SelectedRows(0).Cells(1).Value)
                consulta.ModeloTextBox.ReadOnly = True
                consulta.PrecioTextBox.Text = String.Format("{0}", GMTablaDataGridView.SelectedRows(0).Cells(2).Value)
                consulta.PrecioTextBox.ReadOnly = True
                consulta.CompraDateTimePicker.Value = DirectCast(GMTablaDataGridView.SelectedRows(0).Cells(3).Value, DateTime)
                consulta.CompraDateTimePicker.Enabled = False
                consulta.TelefonoTextBox.Text = String.Format("{0}", GMTablaDataGridView.SelectedRows(0).Cells(4).Value)
                consulta.TelefonoTextBox.ReadOnly = True
                consulta.NMComboBox.Text = String.Format("{0}", GMTablaDataGridView.SelectedRows(0).Cells(5).Value)
                consulta.NMComboBox.Enabled = False
                consulta.DescripcionRichTextBox.Text = String.Format("{0}", GMTablaDataGridView.SelectedRows(0).Cells(6).Value)
                consulta.DescripcionRichTextBox.ReadOnly = True
                consulta.CaracteristicasRichTextBox.Text = String.Format("{0}", GMTablaDataGridView.SelectedRows(0).Cells(7).Value)
                consulta.CaracteristicasRichTextBox.ReadOnly = True
                consulta.AnadirButton.Visible = False
                consulta.ExaminarButton.Visible = False
                consulta.Text = "Consulta"

                Dim imgs As String() = Directory.GetFiles(My.Settings.MaquinasImg, DirectCast(GMTablaDataGridView.SelectedRows(0).Cells(0).Value, Integer) & "*")

                For Each img As String In imgs
                    Dim bitmap As New Bitmap(My.Settings.MaquinasImg & img)
                    Dim picturebox As New PictureBox()
                    picturebox.Size = New Size(150, 120)
                    picturebox.Image = DirectCast(bitmap, Image)
                    picturebox.SizeMode = PictureBoxSizeMode.StretchImage
                    consulta.ImagenesFlowLayoutPanel.Controls.Add(picturebox)
                Next
                consulta.AceptarButton.Visible = False
                consulta.CancelarButton.Text = "Salir"
                consulta.Show()

            Else
                MessageBox.Show("Selecciona una fila. ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As ArgumentException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub EditarButton_Click(sender As Object, e As EventArgs) Handles EditarButton.Click
        Dim consulta As New Form3()
        consulta.MdiParent = VentanaPrincipal.ActiveForm
        Try
            If GMTablaDataGridView.SelectedRows.Count = 1 Then
                consulta.id = DirectCast(GMTablaDataGridView.SelectedRows(0).Cells(0).Value, Integer)
                consulta.ModeloTextBox.Text = String.Format("{0}", GMTablaDataGridView.SelectedRows(0).Cells(1).Value)
                consulta.PrecioTextBox.Text = String.Format("{0}", GMTablaDataGridView.SelectedRows(0).Cells(2).Value)
                consulta.CompraDateTimePicker.Value = DirectCast(GMTablaDataGridView.SelectedRows(0).Cells(3).Value, DateTime)
                consulta.TelefonoTextBox.Text = String.Format("{0}", GMTablaDataGridView.SelectedRows(0).Cells(4).Value)
                consulta.NMComboBox.Text = String.Format("{0}", GMTablaDataGridView.SelectedRows(0).Cells(5).Value)
                consulta.DescripcionRichTextBox.Text = String.Format("{0}", GMTablaDataGridView.SelectedRows(0).Cells(6).Value)
                consulta.CaracteristicasRichTextBox.Text = String.Format("{0}", GMTablaDataGridView.SelectedRows(0).Cells(7).Value)
                Dim imgs As String() = Directory.GetFiles(My.Settings.MaquinasImg, DirectCast(GMTablaDataGridView.SelectedRows(0).Cells(0).Value, Integer) & "*")

                For Each img As String In imgs
                    Dim bitmap As New Bitmap(My.Settings.MaquinasImg & img)
                    Dim picturebox As New PictureBox()
                    picturebox.Size = New Size(150, 120)
                    picturebox.Image = DirectCast(bitmap, Image)
                    picturebox.SizeMode = PictureBoxSizeMode.StretchImage
                    consulta.ImagenesFlowLayoutPanel.Controls.Add(picturebox)
                Next
                consulta.AceptarButton.Text = "Guardar"
                consulta.Text = "Editar"
                consulta.Show()

            Else
                MessageBox.Show("Selecciona una fila. ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As ArgumentException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub EliminarButton_Click(sender As Object, e As EventArgs) Handles EliminarButton.Click
        Try
            If GMTablaDataGridView.SelectedRows.Count = 1 Then
                Try
                    Maquinas.Eliminar(DirectCast(GMTablaDataGridView.SelectedRows(0).Cells(0).Value, Integer))
                Catch ex As ArgumentException
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
                CargarDatos()
            Else
                MessageBox.Show("Selecciona una fila. ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As ArgumentException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GestionMaquinas_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        CargarDatos()
    End Sub
    ''' <summary>
    ''' Obtiene las imagenes de las maquinas.
    ''' </summary>
    ''' <param name="id">Identificador </param>
    ''' <returns>Imagenes de las maquinas.</returns>
    Private Function ObtenerImagenes(id As String) As Image
        Dim directorio As System.IO.DirectoryInfo = New System.IO.DirectoryInfo(My.Settings.MaquinasImg)

        If directorio.GetFiles(id & ".png").Count() = 0 And directorio.GetFiles(id & ".jpg").Count() = 0 Then
            Return Image.FromFile(My.Settings.UsuariosImg & "0.png")
        End If
        Return Image.FromFile(My.Settings.UsuariosImg & id & ".png")
    End Function
End Class