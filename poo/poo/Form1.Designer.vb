<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.lblSueldo = New System.Windows.Forms.Label()
        Me.txtSueldo = New System.Windows.Forms.TextBox()
        Me.lblIsss = New System.Windows.Forms.Label()
        Me.lblAfp = New System.Windows.Forms.Label()
        Me.lblIsr = New System.Windows.Forms.Label()
        Me.lblVacaciones = New System.Windows.Forms.Label()
        Me.lblAguinaldo = New System.Windows.Forms.Label()
        Me.cboTiempo = New System.Windows.Forms.ComboBox()
        Me.lblTiempo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCalcular
        '
        Me.btnCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.Location = New System.Drawing.Point(257, 123)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(148, 59)
        Me.btnCalcular.TabIndex = 0
        Me.btnCalcular.Text = "CALCULAR"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'lblSueldo
        '
        Me.lblSueldo.AutoSize = True
        Me.lblSueldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSueldo.Location = New System.Drawing.Point(27, 29)
        Me.lblSueldo.Name = "lblSueldo"
        Me.lblSueldo.Size = New System.Drawing.Size(70, 20)
        Me.lblSueldo.TabIndex = 1
        Me.lblSueldo.Text = "Sueldo:"
        '
        'txtSueldo
        '
        Me.txtSueldo.Location = New System.Drawing.Point(103, 31)
        Me.txtSueldo.Name = "txtSueldo"
        Me.txtSueldo.Size = New System.Drawing.Size(144, 20)
        Me.txtSueldo.TabIndex = 2
        '
        'lblIsss
        '
        Me.lblIsss.AutoSize = True
        Me.lblIsss.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIsss.Location = New System.Drawing.Point(27, 79)
        Me.lblIsss.Name = "lblIsss"
        Me.lblIsss.Size = New System.Drawing.Size(56, 20)
        Me.lblIsss.TabIndex = 3
        Me.lblIsss.Text = "ISSS:"
        '
        'lblAfp
        '
        Me.lblAfp.AutoSize = True
        Me.lblAfp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAfp.Location = New System.Drawing.Point(27, 120)
        Me.lblAfp.Name = "lblAfp"
        Me.lblAfp.Size = New System.Drawing.Size(48, 20)
        Me.lblAfp.TabIndex = 4
        Me.lblAfp.Text = "AFP:"
        '
        'lblIsr
        '
        Me.lblIsr.AutoSize = True
        Me.lblIsr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIsr.Location = New System.Drawing.Point(27, 162)
        Me.lblIsr.Name = "lblIsr"
        Me.lblIsr.Size = New System.Drawing.Size(45, 20)
        Me.lblIsr.TabIndex = 5
        Me.lblIsr.Text = "ISR:"
        '
        'lblVacaciones
        '
        Me.lblVacaciones.AutoSize = True
        Me.lblVacaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVacaciones.Location = New System.Drawing.Point(27, 197)
        Me.lblVacaciones.Name = "lblVacaciones"
        Me.lblVacaciones.Size = New System.Drawing.Size(129, 20)
        Me.lblVacaciones.TabIndex = 6
        Me.lblVacaciones.Text = "VACACIONES:"
        '
        'lblAguinaldo
        '
        Me.lblAguinaldo.AutoSize = True
        Me.lblAguinaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAguinaldo.Location = New System.Drawing.Point(27, 238)
        Me.lblAguinaldo.Name = "lblAguinaldo"
        Me.lblAguinaldo.Size = New System.Drawing.Size(119, 20)
        Me.lblAguinaldo.TabIndex = 7
        Me.lblAguinaldo.Text = "AGUINALDO:"
        '
        'cboTiempo
        '
        Me.cboTiempo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTiempo.FormattingEnabled = True
        Me.cboTiempo.Items.AddRange(New Object() {"Menos de 1 Año.", "Entre 1 y 3 Años.", "Entre 3 y 10 Años.", "10 o mas Años."})
        Me.cboTiempo.Location = New System.Drawing.Point(339, 33)
        Me.cboTiempo.Name = "cboTiempo"
        Me.cboTiempo.Size = New System.Drawing.Size(121, 21)
        Me.cboTiempo.TabIndex = 8
        '
        'lblTiempo
        '
        Me.lblTiempo.AutoSize = True
        Me.lblTiempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTiempo.Location = New System.Drawing.Point(253, 31)
        Me.lblTiempo.Name = "lblTiempo"
        Me.lblTiempo.Size = New System.Drawing.Size(80, 20)
        Me.lblTiempo.TabIndex = 9
        Me.lblTiempo.Text = "TIEMPO:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(587, 283)
        Me.Controls.Add(Me.lblTiempo)
        Me.Controls.Add(Me.cboTiempo)
        Me.Controls.Add(Me.lblAguinaldo)
        Me.Controls.Add(Me.lblVacaciones)
        Me.Controls.Add(Me.lblIsr)
        Me.Controls.Add(Me.lblAfp)
        Me.Controls.Add(Me.lblIsss)
        Me.Controls.Add(Me.txtSueldo)
        Me.Controls.Add(Me.lblSueldo)
        Me.Controls.Add(Me.btnCalcular)
        Me.Name = "Form1"
        Me.Text = "Deducciones Ley"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalcular As Button
    Friend WithEvents lblSueldo As Label
    Friend WithEvents txtSueldo As TextBox
    Friend WithEvents lblIsss As Label
    Friend WithEvents lblAfp As Label
    Friend WithEvents lblIsr As Label
    Friend WithEvents lblVacaciones As Label
    Friend WithEvents lblAguinaldo As Label
    Friend WithEvents cboTiempo As ComboBox
    Friend WithEvents lblTiempo As Label
End Class
