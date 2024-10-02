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
        Me.lblMetros = New System.Windows.Forms.Label()
        Me.txtMetros = New System.Windows.Forms.TextBox()
        Me.lblRespuesta = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblMetros
        '
        Me.lblMetros.AutoSize = True
        Me.lblMetros.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMetros.Location = New System.Drawing.Point(30, 30)
        Me.lblMetros.Name = "lblMetros"
        Me.lblMetros.Size = New System.Drawing.Size(79, 24)
        Me.lblMetros.TabIndex = 0
        Me.lblMetros.Text = "Metros:"
        '
        'txtMetros
        '
        Me.txtMetros.Location = New System.Drawing.Point(115, 35)
        Me.txtMetros.Name = "txtMetros"
        Me.txtMetros.Size = New System.Drawing.Size(118, 20)
        Me.txtMetros.TabIndex = 1
        '
        'lblRespuesta
        '
        Me.lblRespuesta.AutoSize = True
        Me.lblRespuesta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRespuesta.Location = New System.Drawing.Point(30, 78)
        Me.lblRespuesta.Name = "lblRespuesta"
        Me.lblRespuesta.Size = New System.Drawing.Size(81, 24)
        Me.lblRespuesta.TabIndex = 2
        Me.lblRespuesta.Text = "Pago: $"
        '
        'btnCalcular
        '
        Me.btnCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.Location = New System.Drawing.Point(106, 133)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(156, 67)
        Me.btnCalcular.TabIndex = 3
        Me.btnCalcular.Text = "CALCULAR"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(436, 232)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.lblRespuesta)
        Me.Controls.Add(Me.txtMetros)
        Me.Controls.Add(Me.lblMetros)
        Me.Name = "Form1"
        Me.Text = "Consumo de agua potable"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMetros As Label
    Friend WithEvents txtMetros As TextBox
    Friend WithEvents lblRespuesta As Label
    Friend WithEvents btnCalcular As Button
End Class
