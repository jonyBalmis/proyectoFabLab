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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NuevoTipoMaquina))
        Me.CancelarTipoButton = New System.Windows.Forms.Button()
        Me.AceptarTipoButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AddTipoTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'CancelarTipoButton
        '
        Me.CancelarTipoButton.Location = New System.Drawing.Point(191, 123)
        Me.CancelarTipoButton.Margin = New System.Windows.Forms.Padding(4)
        Me.CancelarTipoButton.Name = "CancelarTipoButton"
        Me.CancelarTipoButton.Size = New System.Drawing.Size(100, 28)
        Me.CancelarTipoButton.TabIndex = 2
        Me.CancelarTipoButton.Text = "Cancelar"
        Me.CancelarTipoButton.UseVisualStyleBackColor = True
        '
        'AceptarTipoButton
        '
        Me.AceptarTipoButton.Location = New System.Drawing.Point(83, 123)
        Me.AceptarTipoButton.Margin = New System.Windows.Forms.Padding(4)
        Me.AceptarTipoButton.Name = "AceptarTipoButton"
        Me.AceptarTipoButton.Size = New System.Drawing.Size(100, 28)
        Me.AceptarTipoButton.TabIndex = 1
        Me.AceptarTipoButton.Text = "Aceptar"
        Me.AceptarTipoButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(79, 57)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Tipo de maquina"
        '
        'AddTipoTextBox
        '
        Me.AddTipoTextBox.Location = New System.Drawing.Point(83, 76)
        Me.AddTipoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.AddTipoTextBox.Name = "AddTipoTextBox"
        Me.AddTipoTextBox.Size = New System.Drawing.Size(207, 22)
        Me.AddTipoTextBox.TabIndex = 0
        '
        'NuevoTipoMaquina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 205)
        Me.Controls.Add(Me.CancelarTipoButton)
        Me.Controls.Add(Me.AceptarTipoButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AddTipoTextBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximumSize = New System.Drawing.Size(395, 252)
        Me.MinimumSize = New System.Drawing.Size(395, 252)
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
