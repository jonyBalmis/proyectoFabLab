Public Class GestionUsuarios
    Private Enlace As BindingSource
    Dim resultado As New DataSet
    Dim usuarios As DataTable

    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles GUBuscarTextBox.Enter, GUBuscarTextBox.Leave
        HintTextBox(GUBuscarTextBox, "buscar")
    End Sub
    Private Sub GestionUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dataTable As DataTable = Usuario.SeleccionarUsuarios()
        Dim dataSet As New DataSet()
        dataSet.Tables.Add(dataTable)
        Enlace = New BindingSource(dataSet, "Usuarios")
        GUDataGridView.DataSource = Enlace
        HintTextBox(GUBuscarTextBox, "buscar")
        usuarios = Usuario.SeleccionarUsuarios
        GUDataGridView.DataSource = usuarios
        GUDataGridView.Columns(0).Visible = False
        GUDataGridView.Columns(8).Visible = False
        GUDataGridView.Columns(10).Visible = False
        GUDataGridView.Columns(11).Visible = False
        GUDataGridView.Columns(12).DisplayIndex = 8
    End Sub

    Private Sub GUBuscarTextBox_TextChanged(sender As Object, e As EventArgs) Handles GUBuscarTextBox.TextChanged

        Enlace.Filter = "nombre LIKE '" & GUBuscarTextBox.Text & "%'"
        GUDataGridView.DataSource = Enlace

    End Sub
End Class