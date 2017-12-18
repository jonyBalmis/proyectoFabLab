<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentanaBienvenida
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
        Me.components = New System.ComponentModel.Container()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.EstrellaPictureBox3 = New System.Windows.Forms.PictureBox()
        Me.EstrellaPictureBox4 = New System.Windows.Forms.PictureBox()
        Me.EstrellaPictureBox5 = New System.Windows.Forms.PictureBox()
        Me.EstrellaPictureBox2 = New System.Windows.Forms.PictureBox()
        Me.EstrellaPictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.EstrellaPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstrellaPictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstrellaPictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstrellaPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstrellaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer
        '
        Me.Timer.Enabled = True
        Me.Timer.Interval = 900
        '
        'EstrellaPictureBox3
        '
        Me.EstrellaPictureBox3.Image = Global.ProyectoFablab.My.Resources.Resources.starBlue
        Me.EstrellaPictureBox3.Location = New System.Drawing.Point(88, 3)
        Me.EstrellaPictureBox3.Name = "EstrellaPictureBox3"
        Me.EstrellaPictureBox3.Size = New System.Drawing.Size(30, 24)
        Me.EstrellaPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.EstrellaPictureBox3.TabIndex = 16
        Me.EstrellaPictureBox3.TabStop = False
        '
        'EstrellaPictureBox4
        '
        Me.EstrellaPictureBox4.Image = Global.ProyectoFablab.My.Resources.Resources.starBlue
        Me.EstrellaPictureBox4.Location = New System.Drawing.Point(124, 3)
        Me.EstrellaPictureBox4.Name = "EstrellaPictureBox4"
        Me.EstrellaPictureBox4.Size = New System.Drawing.Size(30, 24)
        Me.EstrellaPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.EstrellaPictureBox4.TabIndex = 15
        Me.EstrellaPictureBox4.TabStop = False
        '
        'EstrellaPictureBox5
        '
        Me.EstrellaPictureBox5.Image = Global.ProyectoFablab.My.Resources.Resources.starBlue
        Me.EstrellaPictureBox5.Location = New System.Drawing.Point(160, 3)
        Me.EstrellaPictureBox5.Name = "EstrellaPictureBox5"
        Me.EstrellaPictureBox5.Size = New System.Drawing.Size(30, 24)
        Me.EstrellaPictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.EstrellaPictureBox5.TabIndex = 14
        Me.EstrellaPictureBox5.TabStop = False
        '
        'EstrellaPictureBox2
        '
        Me.EstrellaPictureBox2.Image = Global.ProyectoFablab.My.Resources.Resources.starBlue
        Me.EstrellaPictureBox2.Location = New System.Drawing.Point(52, 3)
        Me.EstrellaPictureBox2.Name = "EstrellaPictureBox2"
        Me.EstrellaPictureBox2.Size = New System.Drawing.Size(30, 24)
        Me.EstrellaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.EstrellaPictureBox2.TabIndex = 13
        Me.EstrellaPictureBox2.TabStop = False
        '
        'EstrellaPictureBox1
        '
        Me.EstrellaPictureBox1.Image = Global.ProyectoFablab.My.Resources.Resources.starBlue
        Me.EstrellaPictureBox1.Location = New System.Drawing.Point(16, 3)
        Me.EstrellaPictureBox1.Name = "EstrellaPictureBox1"
        Me.EstrellaPictureBox1.Size = New System.Drawing.Size(30, 24)
        Me.EstrellaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.EstrellaPictureBox1.TabIndex = 12
        Me.EstrellaPictureBox1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.ProyectoFablab.My.Resources.Resources.Proyectologo
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(406, 233)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.EstrellaPictureBox2)
        Me.Panel1.Controls.Add(Me.EstrellaPictureBox1)
        Me.Panel1.Controls.Add(Me.EstrellaPictureBox3)
        Me.Panel1.Controls.Add(Me.EstrellaPictureBox5)
        Me.Panel1.Controls.Add(Me.EstrellaPictureBox4)
        Me.Panel1.Location = New System.Drawing.Point(91, 175)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 32)
        Me.Panel1.TabIndex = 22
        '
        'VentanaBienvenida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(406, 233)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "VentanaBienvenida"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VentanaBienvenida"
        CType(Me.EstrellaPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstrellaPictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstrellaPictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstrellaPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstrellaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Timer As Timer
    Friend WithEvents EstrellaPictureBox3 As PictureBox
    Friend WithEvents EstrellaPictureBox4 As PictureBox
    Friend WithEvents EstrellaPictureBox5 As PictureBox
    Friend WithEvents EstrellaPictureBox2 As PictureBox
    Friend WithEvents EstrellaPictureBox1 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
End Class
