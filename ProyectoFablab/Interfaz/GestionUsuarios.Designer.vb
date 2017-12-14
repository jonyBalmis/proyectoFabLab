<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionUsuarios
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GUBuscarTextBox = New System.Windows.Forms.TextBox()
        Me.GUNuevoButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GUEliminarButton = New System.Windows.Forms.Button()
        Me.GUEditarButton = New System.Windows.Forms.Button()
        Me.GUConsultarButton = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GUDataGridView = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.GUDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 116.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(709, 361)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GUBuscarTextBox)
        Me.Panel2.Controls.Add(Me.GUNuevoButton)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(4, 4)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(701, 53)
        Me.Panel2.TabIndex = 2
        '
        'GUBuscarTextBox
        '
        Me.GUBuscarTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GUBuscarTextBox.Location = New System.Drawing.Point(75, 14)
        Me.GUBuscarTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.GUBuscarTextBox.Name = "GUBuscarTextBox"
        Me.GUBuscarTextBox.Size = New System.Drawing.Size(132, 22)
        Me.GUBuscarTextBox.TabIndex = 2
        '
        'GUNuevoButton
        '
        Me.GUNuevoButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GUNuevoButton.Location = New System.Drawing.Point(511, 10)
        Me.GUNuevoButton.Margin = New System.Windows.Forms.Padding(4)
        Me.GUNuevoButton.Name = "GUNuevoButton"
        Me.GUNuevoButton.Size = New System.Drawing.Size(127, 28)
        Me.GUNuevoButton.TabIndex = 1
        Me.GUNuevoButton.Text = "Nuevo Usuario"
        Me.GUNuevoButton.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.GUEliminarButton)
        Me.Panel1.Controls.Add(Me.GUEditarButton)
        Me.Panel1.Controls.Add(Me.GUConsultarButton)
        Me.Panel1.Location = New System.Drawing.Point(4, 248)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(701, 109)
        Me.Panel1.TabIndex = 1
        '
        'GUEliminarButton
        '
        Me.GUEliminarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GUEliminarButton.Location = New System.Drawing.Point(537, 28)
        Me.GUEliminarButton.Margin = New System.Windows.Forms.Padding(4)
        Me.GUEliminarButton.Name = "GUEliminarButton"
        Me.GUEliminarButton.Size = New System.Drawing.Size(100, 28)
        Me.GUEliminarButton.TabIndex = 2
        Me.GUEliminarButton.Text = "Eliminar"
        Me.GUEliminarButton.UseVisualStyleBackColor = True
        '
        'GUEditarButton
        '
        Me.GUEditarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GUEditarButton.Location = New System.Drawing.Point(417, 28)
        Me.GUEditarButton.Margin = New System.Windows.Forms.Padding(4)
        Me.GUEditarButton.Name = "GUEditarButton"
        Me.GUEditarButton.Size = New System.Drawing.Size(100, 28)
        Me.GUEditarButton.TabIndex = 1
        Me.GUEditarButton.Text = "Editar"
        Me.GUEditarButton.UseVisualStyleBackColor = True
        '
        'GUConsultarButton
        '
        Me.GUConsultarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GUConsultarButton.Location = New System.Drawing.Point(297, 28)
        Me.GUConsultarButton.Margin = New System.Windows.Forms.Padding(4)
        Me.GUConsultarButton.Name = "GUConsultarButton"
        Me.GUConsultarButton.Size = New System.Drawing.Size(100, 28)
        Me.GUConsultarButton.TabIndex = 0
        Me.GUConsultarButton.Text = "Consultar"
        Me.GUConsultarButton.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.GUDataGridView)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(4, 65)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(701, 175)
        Me.Panel3.TabIndex = 3
        '
        'GUDataGridView
        '
        Me.GUDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GUDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GUDataGridView.Location = New System.Drawing.Point(64, 0)
        Me.GUDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.GUDataGridView.Name = "GUDataGridView"
        Me.GUDataGridView.Size = New System.Drawing.Size(573, 175)
        Me.GUDataGridView.TabIndex = 1
        '
        'GestionUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 361)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "GestionUsuarios"
        Me.Text = "FabLab - Gestión de usuarios"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.GUDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GUBuscarTextBox As TextBox
    Friend WithEvents GUNuevoButton As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GUEliminarButton As Button
    Friend WithEvents GUEditarButton As Button
    Friend WithEvents GUConsultarButton As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GUDataGridView As DataGridView
End Class
