Public Class GestionMaquinas
    Private Sub GestionMaquinas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HintTextBox(GMBuscarTextBox, "Buscar...")
        Dim maquina As DataTable = Maquinas.ObtenerMaquinas
        GMTablaDataGridView.DataSource = maquina
        GMTablaDataGridView.Columns(0).Visible = False
        GMTablaDataGridView.Columns(3).Visible = False
        GMTablaDataGridView.Columns(6).Visible = False
        GMTablaDataGridView.Columns(7).Visible = False
        GMTablaDataGridView.Columns(5).DisplayIndex = 2

    End Sub

    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles GMBuscarTextBox.Enter, GMBuscarTextBox.Leave
        HintTextBox(GMBuscarTextBox, "Buscar...")
    End Sub
End Class