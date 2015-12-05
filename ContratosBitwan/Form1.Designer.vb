<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btn_generar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_num_contrato = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_nombre_completo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_celular = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_numero_documento = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_direccion_facturacion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_correo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_celular_alterno = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_barrio = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_fecha_peticion = New System.Windows.Forms.DateTimePicker()
        Me.txt_tipo_documento = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_departamento = New System.Windows.Forms.ComboBox()
        Me.txt_ciudad = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btn_generar
        '
        Me.btn_generar.Location = New System.Drawing.Point(205, 450)
        Me.btn_generar.Name = "btn_generar"
        Me.btn_generar.Size = New System.Drawing.Size(75, 23)
        Me.btn_generar.TabIndex = 0
        Me.btn_generar.Text = "Button1"
        Me.btn_generar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "N° Contrato:"
        '
        'txt_num_contrato
        '
        Me.txt_num_contrato.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_num_contrato.Location = New System.Drawing.Point(205, 30)
        Me.txt_num_contrato.Name = "txt_num_contrato"
        Me.txt_num_contrato.Size = New System.Drawing.Size(214, 29)
        Me.txt_num_contrato.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha Petición:"
        '
        'txt_nombre_completo
        '
        Me.txt_nombre_completo.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombre_completo.Location = New System.Drawing.Point(205, 100)
        Me.txt_nombre_completo.Name = "txt_nombre_completo"
        Me.txt_nombre_completo.Size = New System.Drawing.Size(214, 29)
        Me.txt_nombre_completo.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 21)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nombre Completo:"
        '
        'txt_celular
        '
        Me.txt_celular.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_celular.Location = New System.Drawing.Point(205, 205)
        Me.txt_celular.Name = "txt_celular"
        Me.txt_celular.Size = New System.Drawing.Size(214, 29)
        Me.txt_celular.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 21)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Celular:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_numero_documento
        '
        Me.txt_numero_documento.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_numero_documento.Location = New System.Drawing.Point(205, 170)
        Me.txt_numero_documento.Name = "txt_numero_documento"
        Me.txt_numero_documento.Size = New System.Drawing.Size(214, 29)
        Me.txt_numero_documento.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(28, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 21)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "N° Documento:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(28, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 21)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Tipo Documento:"
        '
        'txt_direccion_facturacion
        '
        Me.txt_direccion_facturacion.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_direccion_facturacion.Location = New System.Drawing.Point(205, 310)
        Me.txt_direccion_facturacion.Name = "txt_direccion_facturacion"
        Me.txt_direccion_facturacion.Size = New System.Drawing.Size(214, 29)
        Me.txt_direccion_facturacion.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(28, 318)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(171, 21)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Dirección Facturación:"
        '
        'txt_correo
        '
        Me.txt_correo.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_correo.Location = New System.Drawing.Point(205, 275)
        Me.txt_correo.Name = "txt_correo"
        Me.txt_correo.Size = New System.Drawing.Size(214, 29)
        Me.txt_correo.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(28, 283)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 21)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Correo:"
        '
        'txt_celular_alterno
        '
        Me.txt_celular_alterno.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_celular_alterno.Location = New System.Drawing.Point(205, 240)
        Me.txt_celular_alterno.Name = "txt_celular_alterno"
        Me.txt_celular_alterno.Size = New System.Drawing.Size(214, 29)
        Me.txt_celular_alterno.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(28, 248)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(123, 21)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Celular Alterno:"
        '
        'txt_barrio
        '
        Me.txt_barrio.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_barrio.Location = New System.Drawing.Point(205, 415)
        Me.txt_barrio.Name = "txt_barrio"
        Me.txt_barrio.Size = New System.Drawing.Size(214, 29)
        Me.txt_barrio.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(28, 423)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 21)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Barrio:"
        '
        'txt_fecha_peticion
        '
        Me.txt_fecha_peticion.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fecha_peticion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_fecha_peticion.Location = New System.Drawing.Point(205, 65)
        Me.txt_fecha_peticion.Name = "txt_fecha_peticion"
        Me.txt_fecha_peticion.Size = New System.Drawing.Size(214, 29)
        Me.txt_fecha_peticion.TabIndex = 21
        '
        'txt_tipo_documento
        '
        Me.txt_tipo_documento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_tipo_documento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txt_tipo_documento.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tipo_documento.FormattingEnabled = True
        Me.txt_tipo_documento.Items.AddRange(New Object() {"CC", "NIT", "CE"})
        Me.txt_tipo_documento.Location = New System.Drawing.Point(205, 135)
        Me.txt_tipo_documento.Name = "txt_tipo_documento"
        Me.txt_tipo_documento.Size = New System.Drawing.Size(214, 29)
        Me.txt_tipo_documento.TabIndex = 22
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(28, 353)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(120, 21)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Departamento:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(28, 388)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 21)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Ciudad:"
        '
        'txt_departamento
        '
        Me.txt_departamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_departamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txt_departamento.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_departamento.FormattingEnabled = True
        Me.txt_departamento.Items.AddRange(New Object() {"VALLE DEL CAUCA"})
        Me.txt_departamento.Location = New System.Drawing.Point(205, 345)
        Me.txt_departamento.Name = "txt_departamento"
        Me.txt_departamento.Size = New System.Drawing.Size(214, 29)
        Me.txt_departamento.TabIndex = 26
        '
        'txt_ciudad
        '
        Me.txt_ciudad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_ciudad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txt_ciudad.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ciudad.FormattingEnabled = True
        Me.txt_ciudad.Items.AddRange(New Object() {"ALCALÁ", "ANSERMANUEVO", "ARGELIA", "EL CAIRO", "CARTAGO", "ULLOA", "LA UNIÓN", "TORO"})
        Me.txt_ciudad.Location = New System.Drawing.Point(205, 380)
        Me.txt_ciudad.Name = "txt_ciudad"
        Me.txt_ciudad.Size = New System.Drawing.Size(214, 29)
        Me.txt_ciudad.TabIndex = 27
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(674, 507)
        Me.Controls.Add(Me.txt_ciudad)
        Me.Controls.Add(Me.txt_departamento)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txt_tipo_documento)
        Me.Controls.Add(Me.txt_fecha_peticion)
        Me.Controls.Add(Me.txt_barrio)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_direccion_facturacion)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_correo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_celular_alterno)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_celular)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_numero_documento)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_nombre_completo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_num_contrato)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_generar)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_generar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_num_contrato As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_nombre_completo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_celular As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_numero_documento As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_direccion_facturacion As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_correo As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_celular_alterno As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_barrio As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_fecha_peticion As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_tipo_documento As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_departamento As System.Windows.Forms.ComboBox
    Friend WithEvents txt_ciudad As System.Windows.Forms.ComboBox

End Class
