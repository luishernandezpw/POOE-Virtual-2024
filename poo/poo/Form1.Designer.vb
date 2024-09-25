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
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.lblNum1 = New System.Windows.Forms.Label()
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.cboOpcion = New System.Windows.Forms.ComboBox()
        Me.lblOpcion = New System.Windows.Forms.Label()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.lblNum2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnProcesar
        '
        Me.btnProcesar.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcesar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnProcesar.Location = New System.Drawing.Point(179, 146)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(162, 55)
        Me.btnProcesar.TabIndex = 0
        Me.btnProcesar.Text = "Calcular"
        Me.btnProcesar.UseVisualStyleBackColor = True
        '
        'lblNum1
        '
        Me.lblNum1.AutoSize = True
        Me.lblNum1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum1.ForeColor = System.Drawing.Color.Green
        Me.lblNum1.Location = New System.Drawing.Point(12, 25)
        Me.lblNum1.Name = "lblNum1"
        Me.lblNum1.Size = New System.Drawing.Size(75, 22)
        Me.lblNum1.TabIndex = 1
        Me.lblNum1.Text = "Num 1:"
        '
        'txtNum1
        '
        Me.txtNum1.Location = New System.Drawing.Point(93, 29)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(136, 20)
        Me.txtNum1.TabIndex = 2
        '
        'cboOpcion
        '
        Me.cboOpcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOpcion.FormattingEnabled = True
        Me.cboOpcion.Items.AddRange(New Object() {"Suma", "Resta", "Multiplicacion", "Division"})
        Me.cboOpcion.Location = New System.Drawing.Point(338, 62)
        Me.cboOpcion.Name = "cboOpcion"
        Me.cboOpcion.Size = New System.Drawing.Size(155, 21)
        Me.cboOpcion.TabIndex = 3
        '
        'lblOpcion
        '
        Me.lblOpcion.AutoSize = True
        Me.lblOpcion.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOpcion.ForeColor = System.Drawing.Color.Green
        Me.lblOpcion.Location = New System.Drawing.Point(248, 58)
        Me.lblOpcion.Name = "lblOpcion"
        Me.lblOpcion.Size = New System.Drawing.Size(84, 22)
        Me.lblOpcion.TabIndex = 4
        Me.lblOpcion.Text = "Opcion:"
        '
        'txtNum2
        '
        Me.txtNum2.Location = New System.Drawing.Point(93, 81)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(136, 20)
        Me.txtNum2.TabIndex = 6
        '
        'lblNum2
        '
        Me.lblNum2.AutoSize = True
        Me.lblNum2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum2.ForeColor = System.Drawing.Color.Green
        Me.lblNum2.Location = New System.Drawing.Point(12, 77)
        Me.lblNum2.Name = "lblNum2"
        Me.lblNum2.Size = New System.Drawing.Size(75, 22)
        Me.lblNum2.TabIndex = 5
        Me.lblNum2.Text = "Num 2:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(537, 246)
        Me.Controls.Add(Me.txtNum2)
        Me.Controls.Add(Me.lblNum2)
        Me.Controls.Add(Me.lblOpcion)
        Me.Controls.Add(Me.cboOpcion)
        Me.Controls.Add(Me.txtNum1)
        Me.Controls.Add(Me.lblNum1)
        Me.Controls.Add(Me.btnProcesar)
        Me.Name = "Form1"
        Me.Text = "Saludar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnProcesar As Button
    Friend WithEvents lblNum1 As Label
    Friend WithEvents txtNum1 As TextBox
    Friend WithEvents cboOpcion As ComboBox
    Friend WithEvents lblOpcion As Label
    Friend WithEvents txtNum2 As TextBox
    Friend WithEvents lblNum2 As Label
End Class
