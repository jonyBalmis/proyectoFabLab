Public Class GestionMaquinas
    Private source As BindingSource
    Dim dataSet As DataSet
    Dim hintActivo As Boolean = True

    Private Sub GestionMaquinas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    End Sub
End Class