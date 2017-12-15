<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevoTipoMaquina
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
        Me.CancelarTipoButton = New System.Windows.Forms.Button()
        Me.AceptarTipoButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AddTipoTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'CancelarTipoButton
        '
        Me.CancelarTipoButton.Location = New System.Drawing.Point(143, 100)
        Me.CancelarTipoButton.Name = "CancelarTipoButton"
        Me.CancelarTipoButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelarTipoButton.TabIndex = 11
        Me.CancelarTipoButton.Text = "Cancelar"
        Me.CancelarTipoButton.UseVisualStyleBackColor = True
        '
        'AceptarTipoButton
        '
        Me.AceptarTipoButton.Location = New System.Drawing.Point(62, 100)
        Me.AceptarTipoButton.Name = "AceptarTipoButton"
        Me.AceptarTipoButton.Size = New System.Drawing.Size(75, 23)
        Me.AceptarTipoButton.TabIndex = 10
        Me.AceptarTipoButton.Text = "Aceptar"
        Me.AceptarTipoButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(59, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Tipo de maquina"
        '
        'AddTipoTextBox
        '
        Me.AddTipoTextBox.Location = New System.Drawing.Point(62, 62)
        Me.AddTipoTextBox.Name = "AddTipoTextBox"
        Me.AddTipoTextBox.Size = New System.Drawing.Size(156, 20)
        Me.AddTipoTextBox.TabIndex = 8
        '
        'NuevoTipoMaquina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(278, 169)
        Me.Controls.Add(Me.CancelarTipoButton)
        Me.Controls.Add(Me.AceptarTipoButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AddTipoTextBox)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "NuevoTipoMaquina"
        Me.Text = "NuevoTipoMaquina"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CancelarTipoButton As Button
    Friend WithEvents AceptarTipoButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents AddTipoTextBox As TextBox
End Class
