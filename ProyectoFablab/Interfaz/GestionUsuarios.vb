Public Class GestionUsuarios
    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles GUBuscarTextBox.Enter, GUBuscarTextBox.Leave
        HintTextBox(GUBuscarTextBox, "buscar")
    End Sub
    Private Sub GestionUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HintTextBox(GUBuscarTextBox, "buscar")

        Dim usuarios As DataTable = Usuario.SeleccionarUsuarios
        GUDataGridView.DataSource = usuarios
        GUDataGridView.Columns(0).Visible = False
        GUDataGridView.Columns(3).Visible = False
        GUDataGridView.Columns(6).Visible = False
        GUDataGridView.Columns(7).Visible = False
        GUDataGridView.Columns(5).DisplayIndex = 2
    End Sub
End Class