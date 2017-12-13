Public Class GestionUsuarios
    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles GUBuscarTextBox.Enter, GUBuscarTextBox.Leave
        HintTextBox(GUBuscarTextBox, "buscar")
    End Sub
    Private Sub GestionUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HintTextBox(GUBuscarTextBox, "buscar")
    End Sub
End Class