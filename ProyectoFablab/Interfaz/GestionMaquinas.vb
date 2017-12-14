Public Class GestionMaquinas
    Private maquina As DataTable
    Private source As BindingSource


    Private Sub GestionMaquinas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HintTextBox(GMBuscarTextBox, "Buscar...")
        maquina = Maquinas.ObtenerMaquinas

        source = New BindingSource(maquina.DataSet, "Maquinas")
        GMTablaDataGridView.DataSource = maquina
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

    Private Sub GMBuscarTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles GMBuscarTextBox.KeyPress

        source.Filter = "nombre LIKE '%" & GMBuscarTextBox.Text & "%'"
    End Sub
End Class