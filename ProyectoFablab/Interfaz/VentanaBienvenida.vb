Public Class VentanaBienvenida
    Private contador As Integer
    Private aplicacion As VentanaPrincipal
    Private estrellas() As PictureBox
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer.Tick

        If contador = 5 Then
            Me.Hide()
            aplicacion.Show()
        Else
            estrellas(contador).Image = My.Resources.StarBlueEyes
            contador += 1
        End If
    End Sub

    Private Sub VentanaBienvenida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        contador = 0
        aplicacion = New VentanaPrincipal()
        estrellas = {EstrellaPictureBox1, EstrellaPictureBox2, EstrellaPictureBox3, EstrellaPictureBox4, EstrellaPictureBox5}
    End Sub
End Class