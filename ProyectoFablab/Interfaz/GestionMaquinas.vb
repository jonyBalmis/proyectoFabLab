Public Class GestionMaquinas
    Private Sub GestionMaquinas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim maquina As DataTable = Maquinas.ObtenerMaquinas
        GMTablaDataGridView.DataSource = maquina
        GMTablaDataGridView.Columns(0).Visible = False
        GMTablaDataGridView.Columns(3).Visible = False
        GMTablaDataGridView.Columns(6).Visible = False
        GMTablaDataGridView.Columns(7).Visible = False
        GMTablaDataGridView.Columns(5).DisplayIndex = 2

    End Sub


End Class