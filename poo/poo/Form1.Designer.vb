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
        Me.components = New System.ComponentModel.Container()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.lblRespuesta = New System.Windows.Forms.Label()
        Me.btnConvertir = New System.Windows.Forms.Button()
        Me.erpConsumo = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblValorLetras = New System.Windows.Forms.Label()
        CType(Me.erpConsumo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumero.Location = New System.Drawing.Point(30, 30)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(91, 24)
        Me.lblNumero.TabIndex = 0
        Me.lblNumero.Text = "Numero:"
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(127, 35)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(118, 20)
        Me.txtNumero.TabIndex = 1
        '
        'lblRespuesta
        '
        Me.lblRespuesta.AutoSize = True
        Me.lblRespuesta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRespuesta.Location = New System.Drawing.Point(30, 78)
        Me.lblRespuesta.Name = "lblRespuesta"
        Me.lblRespuesta.Size = New System.Drawing.Size(72, 24)
        Me.lblRespuesta.TabIndex = 2
        Me.lblRespuesta.Text = "Letras:"
        '
        'btnConvertir
        '
        Me.btnConvertir.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvertir.Location = New System.Drawing.Point(106, 133)
        Me.btnConvertir.Name = "btnConvertir"
        Me.btnConvertir.Size = New System.Drawing.Size(156, 67)
        Me.btnConvertir.TabIndex = 3
        Me.btnConvertir.Text = "CONVERTIR"
        Me.btnConvertir.UseVisualStyleBackColor = True
        '
        'erpConsumo
        '
        Me.erpConsumo.ContainerControl = Me
        '
        'lblValorLetras
        '
        Me.lblValorLetras.AutoSize = True
        Me.lblValorLetras.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValorLetras.Location = New System.Drawing.Point(111, 78)
        Me.lblValorLetras.Name = "lblValorLetras"
        Me.lblValorLetras.Size = New System.Drawing.Size(55, 24)
        Me.lblValorLetras.TabIndex = 6
        Me.lblValorLetras.Text = "Cero"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(555, 226)
        Me.Controls.Add(Me.lblValorLetras)
        Me.Controls.Add(Me.btnConvertir)
        Me.Controls.Add(Me.lblRespuesta)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.lblNumero)
        Me.Name = "Form1"
        Me.Text = "Convertir numeros a letras"
        CType(Me.erpConsumo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNumero As Label
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents lblRespuesta As Label
    Friend WithEvents btnConvertir As Button
    Friend WithEvents erpConsumo As ErrorProvider
    Friend WithEvents lblValorLetras As Label
End Class
