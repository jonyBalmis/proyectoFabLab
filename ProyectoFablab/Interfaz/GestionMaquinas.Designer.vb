<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GestionMaquinas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestionMaquinas))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BuscarPictureBox = New System.Windows.Forms.PictureBox()
        Me.GMBuscarTextBox = New System.Windows.Forms.TextBox()
        Me.NuevaButton = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GMTablaDataGridView = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.EliminarButton = New System.Windows.Forms.Button()
        Me.EditarButton = New System.Windows.Forms.Button()
        Me.ConsultarButton = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.BuscarPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.GMTablaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(889, 473)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BuscarPictureBox)
        Me.Panel1.Controls.Add(Me.GMBuscarTextBox)
        Me.Panel1.Controls.Add(Me.NuevaButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 2)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(883, 66)
        Me.Panel1.TabIndex = 0
        '
        'BuscarPictureBox
        '
        Me.BuscarPictureBox.Image = Global.ProyectoFablab.My.Resources.Resources.search
        Me.BuscarPictureBox.Location = New System.Drawing.Point(287, 22)
        Me.BuscarPictureBox.Margin = New System.Windows.Forms.Padding(4)
        Me.BuscarPictureBox.Name = "BuscarPictureBox"
        Me.BuscarPictureBox.Size = New System.Drawing.Size(40, 25)
        Me.BuscarPictureBox.TabIndex = 2
        Me.BuscarPictureBox.TabStop = False
        '
        'GMBuscarTextBox
        '
        Me.GMBuscarTextBox.Location = New System.Drawing.Point(12, 22)
        Me.GMBuscarTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GMBuscarTextBox.Name = "GMBuscarTextBox"
        Me.GMBuscarTextBox.Size = New System.Drawing.Size(267, 22)
        Me.GMBuscarTextBox.TabIndex = 1
        '
        'NuevaButton
        '
        Me.NuevaButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NuevaButton.Location = New System.Drawing.Point(715, 17)
        Me.NuevaButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NuevaButton.Name = "NuevaButton"
        Me.NuevaButton.Size = New System.Drawing.Size(119, 32)
        Me.NuevaButton.TabIndex = 0
        Me.NuevaButton.Text = "Nueva máquina"
        Me.NuevaButton.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GMTablaDataGridView)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 72)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(883, 327)
        Me.Panel2.TabIndex = 1
        '
        'GMTablaDataGridView
        '
        Me.GMTablaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GMTablaDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GMTablaDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.GMTablaDataGridView.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GMTablaDataGridView.Name = "GMTablaDataGridView"
        Me.GMTablaDataGridView.RowTemplate.Height = 24
        Me.GMTablaDataGridView.Size = New System.Drawing.Size(883, 327)
        Me.GMTablaDataGridView.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.EliminarButton)
        Me.Panel3.Controls.Add(Me.EditarButton)
        Me.Panel3.Controls.Add(Me.ConsultarButton)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 403)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(883, 68)
        Me.Panel3.TabIndex = 2
        '
        'EliminarButton
        '
        Me.EliminarButton.Location = New System.Drawing.Point(756, 22)
        Me.EliminarButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.EliminarButton.Name = "EliminarButton"
        Me.EliminarButton.Size = New System.Drawing.Size(96, 27)
        Me.EliminarButton.TabIndex = 2
        Me.EliminarButton.Text = "Elimiar"
        Me.EliminarButton.UseVisualStyleBackColor = True
        '
        'EditarButton
        '
        Me.EditarButton.Location = New System.Drawing.Point(653, 22)
        Me.EditarButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.EditarButton.Name = "EditarButton"
        Me.EditarButton.Size = New System.Drawing.Size(96, 27)
        Me.EditarButton.TabIndex = 1
        Me.EditarButton.Text = "Editar"
        Me.EditarButton.UseVisualStyleBackColor = True
        '
        'ConsultarButton
        '
        Me.ConsultarButton.Location = New System.Drawing.Point(552, 22)
        Me.ConsultarButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ConsultarButton.Name = "ConsultarButton"
        Me.ConsultarButton.Size = New System.Drawing.Size(96, 27)
        Me.ConsultarButton.TabIndex = 0
        Me.ConsultarButton.Text = "Consultar"
        Me.ConsultarButton.UseVisualStyleBackColor = True
        '
        'GestionMaquinas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 473)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "GestionMaquinas"
        Me.Text = "FabLab-Gestion de Maquinas"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BuscarPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.GMTablaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents EliminarButton As Button
    Friend WithEvents EditarButton As Button
    Friend WithEvents ConsultarButton As Button
    Friend WithEvents GMTablaDataGridView As DataGridView
    Friend WithEvents GMBuscarTextBox As TextBox
    Friend WithEvents NuevaButton As Button
    Friend WithEvents BuscarPictureBox As PictureBox
End Class
