<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alumnos
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
        Me.LblMatricula = New System.Windows.Forms.Label()
        Me.TxtMatricula = New System.Windows.Forms.TextBox()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.LblMateria = New System.Windows.Forms.Label()
        Me.TxtMateria = New System.Windows.Forms.TextBox()
        Me.TxtGrado = New System.Windows.Forms.TextBox()
        Me.LblGrado = New System.Windows.Forms.Label()
        Me.LblMaestro = New System.Windows.Forms.Label()
        Me.TxtMaestro = New System.Windows.Forms.TextBox()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblMatricula
        '
        Me.LblMatricula.AutoSize = True
        Me.LblMatricula.Location = New System.Drawing.Point(39, 30)
        Me.LblMatricula.Name = "LblMatricula"
        Me.LblMatricula.Size = New System.Drawing.Size(50, 13)
        Me.LblMatricula.TabIndex = 0
        Me.LblMatricula.Text = "Matricula"
        '
        'TxtMatricula
        '
        Me.TxtMatricula.Location = New System.Drawing.Point(99, 23)
        Me.TxtMatricula.Name = "TxtMatricula"
        Me.TxtMatricula.Size = New System.Drawing.Size(100, 20)
        Me.TxtMatricula.TabIndex = 1
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(39, 62)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(44, 13)
        Me.LblNombre.TabIndex = 2
        Me.LblNombre.Text = "Nombre"
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(99, 55)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(100, 20)
        Me.TxtNombre.TabIndex = 3
        '
        'LblMateria
        '
        Me.LblMateria.AutoSize = True
        Me.LblMateria.Location = New System.Drawing.Point(39, 100)
        Me.LblMateria.Name = "LblMateria"
        Me.LblMateria.Size = New System.Drawing.Size(42, 13)
        Me.LblMateria.TabIndex = 4
        Me.LblMateria.Text = "Materia"
        '
        'TxtMateria
        '
        Me.TxtMateria.Location = New System.Drawing.Point(99, 100)
        Me.TxtMateria.Name = "TxtMateria"
        Me.TxtMateria.Size = New System.Drawing.Size(100, 20)
        Me.TxtMateria.TabIndex = 5
        '
        'TxtGrado
        '
        Me.TxtGrado.Location = New System.Drawing.Point(99, 146)
        Me.TxtGrado.Name = "TxtGrado"
        Me.TxtGrado.Size = New System.Drawing.Size(100, 20)
        Me.TxtGrado.TabIndex = 6
        '
        'LblGrado
        '
        Me.LblGrado.AutoSize = True
        Me.LblGrado.Location = New System.Drawing.Point(39, 146)
        Me.LblGrado.Name = "LblGrado"
        Me.LblGrado.Size = New System.Drawing.Size(36, 13)
        Me.LblGrado.TabIndex = 7
        Me.LblGrado.Text = "Grado"
        '
        'LblMaestro
        '
        Me.LblMaestro.AutoSize = True
        Me.LblMaestro.Location = New System.Drawing.Point(38, 184)
        Me.LblMaestro.Name = "LblMaestro"
        Me.LblMaestro.Size = New System.Drawing.Size(45, 13)
        Me.LblMaestro.TabIndex = 8
        Me.LblMaestro.Text = "Maestro"
        '
        'TxtMaestro
        '
        Me.TxtMaestro.Location = New System.Drawing.Point(99, 184)
        Me.TxtMaestro.Name = "TxtMaestro"
        Me.TxtMaestro.Size = New System.Drawing.Size(100, 20)
        Me.TxtMaestro.TabIndex = 9
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(318, 30)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.BtnNuevo.TabIndex = 10
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(318, 81)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.BtnGuardar.TabIndex = 11
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(318, 136)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancelar.TabIndex = 12
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(318, 184)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalir.TabIndex = 13
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'Alumnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 388)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.TxtMaestro)
        Me.Controls.Add(Me.LblMaestro)
        Me.Controls.Add(Me.LblGrado)
        Me.Controls.Add(Me.TxtGrado)
        Me.Controls.Add(Me.TxtMateria)
        Me.Controls.Add(Me.LblMateria)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.TxtMatricula)
        Me.Controls.Add(Me.LblMatricula)
        Me.Name = "Alumnos"
        Me.Text = "Alumnos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblMatricula As System.Windows.Forms.Label
    Friend WithEvents TxtMatricula As System.Windows.Forms.TextBox
    Friend WithEvents LblNombre As System.Windows.Forms.Label
    Friend WithEvents TxtNombre As System.Windows.Forms.TextBox
    Friend WithEvents LblMateria As System.Windows.Forms.Label
    Friend WithEvents TxtMateria As System.Windows.Forms.TextBox
    Friend WithEvents TxtGrado As System.Windows.Forms.TextBox
    Friend WithEvents LblGrado As System.Windows.Forms.Label
    Friend WithEvents LblMaestro As System.Windows.Forms.Label
    Friend WithEvents TxtMaestro As System.Windows.Forms.TextBox
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnSalir As System.Windows.Forms.Button

End Class
