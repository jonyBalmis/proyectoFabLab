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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.96552!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.03448!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(667, 384)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.GUBuscarTextBox)
        Me.Panel2.Controls.Add(Me.GUNuevoButton)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(661, 56)
        Me.Panel2.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.ProyectoFablab.My.Resources.Resources.search
        Me.PictureBox1.Location = New System.Drawing.Point(194, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 20)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'GUBuscarTextBox
        '
        Me.GUBuscarTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GUBuscarTextBox.Location = New System.Drawing.Point(48, 24)
        Me.GUBuscarTextBox.Name = "GUBuscarTextBox"
        Me.GUBuscarTextBox.Size = New System.Drawing.Size(140, 20)
        Me.GUBuscarTextBox.TabIndex = 1
        '
        'GUNuevoButton
        '
        Me.GUNuevoButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GUNuevoButton.Location = New System.Drawing.Point(518, 21)
        Me.GUNuevoButton.Name = "GUNuevoButton"
        Me.GUNuevoButton.Size = New System.Drawing.Size(95, 23)
        Me.GUNuevoButton.TabIndex = 2
        Me.GUNuevoButton.Text = "Nuevo Usuario"
        Me.GUNuevoButton.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GUEliminarButton)
        Me.Panel1.Controls.Add(Me.GUEditarButton)
        Me.Panel1.Controls.Add(Me.GUConsultarButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 334)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(661, 47)
        Me.Panel1.TabIndex = 1
        '
        'GUEliminarButton
        '
        Me.GUEliminarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GUEliminarButton.Location = New System.Drawing.Point(537, 15)
        Me.GUEliminarButton.Name = "GUEliminarButton"
        Me.GUEliminarButton.Size = New System.Drawing.Size(75, 23)
        Me.GUEliminarButton.TabIndex = 6
        Me.GUEliminarButton.Text = "Eliminar"
        Me.GUEliminarButton.UseVisualStyleBackColor = True
        '
        'GUEditarButton
        '
        Me.GUEditarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GUEditarButton.Location = New System.Drawing.Point(450, 15)
        Me.GUEditarButton.Name = "GUEditarButton"
        Me.GUEditarButton.Size = New System.Drawing.Size(75, 23)
        Me.GUEditarButton.TabIndex = 5
        Me.GUEditarButton.Text = "Editar"
        Me.GUEditarButton.UseVisualStyleBackColor = True
        '
        'GUConsultarButton
        '
        Me.GUConsultarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GUConsultarButton.Location = New System.Drawing.Point(363, 15)
        Me.GUConsultarButton.Name = "GUConsultarButton"
        Me.GUConsultarButton.Size = New System.Drawing.Size(75, 23)
        Me.GUConsultarButton.TabIndex = 4
        Me.GUConsultarButton.Text = "Consultar"
        Me.GUConsultarButton.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.GUDataGridView)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 65)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(661, 263)
        Me.Panel3.TabIndex = 3
        '
        'GUDataGridView
        '
        Me.GUDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GUDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GUDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.GUDataGridView.Name = "GUDataGridView"
        Me.GUDataGridView.Size = New System.Drawing.Size(661, 263)
        Me.GUDataGridView.TabIndex = 3
        '
        'GestionUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 384)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "GestionUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FabLab - Gestión de usuarios"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PictureBox1 As PictureBox
End Class
