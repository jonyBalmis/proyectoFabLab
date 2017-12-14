Public Class GestionMaquinas
    Private source As BindingSource
    Dim dataSet As DataSet

    Private Sub GestionMaquinas_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        dataSet = New DataSet()
        dataSet.Tables.Add(Maquinas.ObtenerMaquinas())
        source = New BindingSource(dataSet, "Maquinas")
        HintTextBox(GMBuscarTextBox, "Buscar...")
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

    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles GMBuscarTextBox.Enter, GMBuscarTextBox.Leave
        HintTextBox(GMBuscarTextBox, "Buscar...")
    End Sub


    Private Sub GMBuscarTextBox_TextChanged(sender As Object, e As EventArgs) Handles GMBuscarTextBox.TextChanged
        source.Filter = "modelo LIKE '%" & GMBuscarTextBox.Text & "%'"
        GMTablaDataGridView.DataSource = source
    End Sub

End Class