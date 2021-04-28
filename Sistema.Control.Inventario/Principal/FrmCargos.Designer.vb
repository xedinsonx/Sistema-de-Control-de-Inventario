<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCargos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCargos))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.dgvdatos = New System.Windows.Forms.DataGridView()
        Me.lblid = New System.Windows.Forms.Label()
        CType(Me.dgvdatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(117, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Registro de Cargos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descripcion Cargo"
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Enabled = False
        Me.txtdescripcion.Location = New System.Drawing.Point(137, 54)
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(137, 20)
        Me.txtdescripcion.TabIndex = 2
        '
        'btnnuevo
        '
        Me.btnnuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnnuevo.Image = CType(resources.GetObject("btnnuevo.Image"), System.Drawing.Image)
        Me.btnnuevo.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnnuevo.Location = New System.Drawing.Point(12, 86)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(78, 42)
        Me.btnnuevo.TabIndex = 3
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Image = CType(resources.GetObject("btncancelar.Image"), System.Drawing.Image)
        Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btncancelar.Location = New System.Drawing.Point(96, 86)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(85, 42)
        Me.btncancelar.TabIndex = 4
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btnmodificar
        '
        Me.btnmodificar.Image = CType(resources.GetObject("btnmodificar.Image"), System.Drawing.Image)
        Me.btnmodificar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnmodificar.Location = New System.Drawing.Point(187, 86)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(87, 42)
        Me.btnmodificar.TabIndex = 5
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnmodificar.UseVisualStyleBackColor = True
        '
        'btneliminar
        '
        Me.btneliminar.Image = CType(resources.GetObject("btneliminar.Image"), System.Drawing.Image)
        Me.btneliminar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btneliminar.Location = New System.Drawing.Point(280, 86)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(82, 42)
        Me.btneliminar.TabIndex = 6
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'btncerrar
        '
        Me.btncerrar.Image = CType(resources.GetObject("btncerrar.Image"), System.Drawing.Image)
        Me.btncerrar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btncerrar.Location = New System.Drawing.Point(368, 86)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(72, 42)
        Me.btncerrar.TabIndex = 7
        Me.btncerrar.Text = "Cerrar"
        Me.btncerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncerrar.UseVisualStyleBackColor = True
        '
        'dgvdatos
        '
        Me.dgvdatos.AllowUserToAddRows = False
        Me.dgvdatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdatos.Location = New System.Drawing.Point(12, 140)
        Me.dgvdatos.Name = "dgvdatos"
        Me.dgvdatos.Size = New System.Drawing.Size(428, 209)
        Me.dgvdatos.TabIndex = 8
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Location = New System.Drawing.Point(280, 57)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(39, 13)
        Me.lblid.TabIndex = 9
        Me.lblid.Text = "Label3"
        Me.lblid.Visible = False
        '
        'FrmCargos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 373)
        Me.Controls.Add(Me.lblid)
        Me.Controls.Add(Me.dgvdatos)
        Me.Controls.Add(Me.btncerrar)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btnmodificar)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnnuevo)
        Me.Controls.Add(Me.txtdescripcion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmCargos"
        Me.Text = "Registro de Cargos"
        CType(Me.dgvdatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtdescripcion As TextBox
    Friend WithEvents btnnuevo As Button
    Friend WithEvents btncancelar As Button
    Friend WithEvents btnmodificar As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents btncerrar As Button
    Friend WithEvents dgvdatos As DataGridView
    Friend WithEvents lblid As Label
End Class
