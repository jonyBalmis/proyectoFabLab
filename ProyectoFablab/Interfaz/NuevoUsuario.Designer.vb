<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevoUsuario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.NUDireccionTextBox = New System.Windows.Forms.TextBox()
        Me.NUEmailTextBox = New System.Windows.Forms.TextBox()
        Me.NUATipoButton = New System.Windows.Forms.Button()
        Me.NUTipoComboBox = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.NUOrganizacionTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NUFechaNacMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NUTelefonoMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NUApellidosTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NUNombreTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NUCancelarButton = New System.Windows.Forms.Button()
        Me.NUAceptarButton = New System.Windows.Forms.Button()
        Me.NUObservacionesTextBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NUDireccionTextBox
        '
        Me.NUDireccionTextBox.Location = New System.Drawing.Point(606, 109)
        Me.NUDireccionTextBox.Name = "NUDireccionTextBox"
        Me.NUDireccionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NUDireccionTextBox.TabIndex = 24
        '
        'NUEmailTextBox
        '
        Me.NUEmailTextBox.Location = New System.Drawing.Point(338, 111)
        Me.NUEmailTextBox.Name = "NUEmailTextBox"
        Me.NUEmailTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NUEmailTextBox.TabIndex = 22
        '
        'NUATipoButton
        '
        Me.NUATipoButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.NUATipoButton.FlatAppearance.BorderSize = 0
        Me.NUATipoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NUATipoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NUATipoButton.Location = New System.Drawing.Point(465, 158)
        Me.NUATipoButton.Name = "NUATipoButton"
        Me.NUATipoButton.Size = New System.Drawing.Size(47, 23)
        Me.NUATipoButton.TabIndex = 28
        Me.NUATipoButton.UseVisualStyleBackColor = True
        '
        'NUTipoComboBox
        '
        Me.NUTipoComboBox.FormattingEnabled = True
        Me.NUTipoComboBox.Location = New System.Drawing.Point(338, 158)
        Me.NUTipoComboBox.Name = "NUTipoComboBox"
        Me.NUTipoComboBox.Size = New System.Drawing.Size(121, 21)
        Me.NUTipoComboBox.TabIndex = 26
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(280, 167)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 13)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Tipo"
        '
        'NUOrganizacionTextBox
        '
        Me.NUOrganizacionTextBox.Location = New System.Drawing.Point(116, 161)
        Me.NUOrganizacionTextBox.Name = "NUOrganizacionTextBox"
        Me.NUOrganizacionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NUOrganizacionTextBox.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(39, 167)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Organización"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(494, 117)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 13)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Dirección postal"
        '
        'NUFechaNacMaskedTextBox
        '
        Me.NUFechaNacMaskedTextBox.Location = New System.Drawing.Point(606, 58)
        Me.NUFechaNacMaskedTextBox.Mask = "00/00/0000"
        Me.NUFechaNacMaskedTextBox.Name = "NUFechaNacMaskedTextBox"
        Me.NUFechaNacMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NUFechaNacMaskedTextBox.TabIndex = 19
        Me.NUFechaNacMaskedTextBox.ValidatingType = GetType(Date)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(494, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Fecha de nacimiento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(277, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "E-mail"
        '
        'NUTelefonoMaskedTextBox
        '
        Me.NUTelefonoMaskedTextBox.Location = New System.Drawing.Point(116, 111)
        Me.NUTelefonoMaskedTextBox.Mask = "000000000"
        Me.NUTelefonoMaskedTextBox.Name = "NUTelefonoMaskedTextBox"
        Me.NUTelefonoMaskedTextBox.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.NUTelefonoMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NUTelefonoMaskedTextBox.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Teléfono"
        '
        'NUApellidosTextBox
        '
        Me.NUApellidosTextBox.Location = New System.Drawing.Point(338, 58)
        Me.NUApellidosTextBox.Name = "NUApellidosTextBox"
        Me.NUApellidosTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NUApellidosTextBox.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(277, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Apellidos"
        '
        'NUNombreTextBox
        '
        Me.NUNombreTextBox.Location = New System.Drawing.Point(116, 58)
        Me.NUNombreTextBox.Name = "NUNombreTextBox"
        Me.NUNombreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NUNombreTextBox.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Nombre"
        '
        'NUCancelarButton
        '
        Me.NUCancelarButton.Location = New System.Drawing.Point(606, 390)
        Me.NUCancelarButton.Name = "NUCancelarButton"
        Me.NUCancelarButton.Size = New System.Drawing.Size(75, 23)
        Me.NUCancelarButton.TabIndex = 34
        Me.NUCancelarButton.Text = "Cancelar"
        Me.NUCancelarButton.UseVisualStyleBackColor = True
        '
        'NUAceptarButton
        '
        Me.NUAceptarButton.Location = New System.Drawing.Point(497, 390)
        Me.NUAceptarButton.Name = "NUAceptarButton"
        Me.NUAceptarButton.Size = New System.Drawing.Size(75, 23)
        Me.NUAceptarButton.TabIndex = 33
        Me.NUAceptarButton.Text = "Aceptar"
        Me.NUAceptarButton.UseVisualStyleBackColor = True
        '
        'NUObservacionesTextBox
        '
        Me.NUObservacionesTextBox.Location = New System.Drawing.Point(42, 235)
        Me.NUObservacionesTextBox.Multiline = True
        Me.NUObservacionesTextBox.Name = "NUObservacionesTextBox"
        Me.NUObservacionesTextBox.Size = New System.Drawing.Size(339, 132)
        Me.NUObservacionesTextBox.TabIndex = 32
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(42, 213)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 13)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Observaciones"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ProyectoFablab.My.Resources.Resources.add
        Me.PictureBox1.Location = New System.Drawing.Point(478, 156)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(23, 23)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        '
        'NuevoUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 445)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.NUCancelarButton)
        Me.Controls.Add(Me.NUAceptarButton)
        Me.Controls.Add(Me.NUObservacionesTextBox)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.NUDireccionTextBox)
        Me.Controls.Add(Me.NUEmailTextBox)
        Me.Controls.Add(Me.NUATipoButton)
        Me.Controls.Add(Me.NUTipoComboBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.NUOrganizacionTextBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.NUFechaNacMaskedTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NUTelefonoMaskedTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.NUApellidosTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NUNombreTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "NuevoUsuario"
        Me.Text = "FabLab-Nuevo usuario"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NUDireccionTextBox As TextBox
    Friend WithEvents NUEmailTextBox As TextBox
    Friend WithEvents NUATipoButton As Button
    Friend WithEvents NUTipoComboBox As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents NUOrganizacionTextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents NUFechaNacMaskedTextBox As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents NUTelefonoMaskedTextBox As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents NUApellidosTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents NUNombreTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents NUCancelarButton As Button
    Friend WithEvents NUAceptarButton As Button
    Friend WithEvents NUObservacionesTextBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
