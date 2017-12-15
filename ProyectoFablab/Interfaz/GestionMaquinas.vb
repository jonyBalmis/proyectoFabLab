Public Class GestionMaquinas
    Private source As BindingSource
    Dim dataSet As DataSet
    Dim hintActivo As Boolean = True



    Private Sub GestionMaquinas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CargarDatos()
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

        nueva.MdiParent = VentanaPrincipal
        nueva.Show()
    End Sub

    Private Sub ConsultarButton_Click(sender As Object, e As EventArgs) Handles ConsultarButton.Click
        Dim consulta As New Form3()
        consulta.MdiParent = VentanaPrincipal
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
                'consulta.NUFotoPictureBox.Image = ObtenerImagen(String.Format("{0}", GUDataGridView.SelectedRows(0).Cells(0).Value))
                'consulta.NUFotoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
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
        consulta.MdiParent = VentanaPrincipal
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
                'consulta.NUFotoPictureBox.Image = ObtenerImagen(String.Format("{0}", GUDataGridView.SelectedRows(0).Cells(0).Value))
                'consulta.NUFotoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
                consulta.AceptarButton.Text = "Guardar"
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
End Class