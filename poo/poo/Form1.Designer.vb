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
        Me.cboDeptos = New System.Windows.Forms.ComboBox()
        Me.lblDepto = New System.Windows.Forms.Label()
        Me.lblMun = New System.Windows.Forms.Label()
        Me.cboMun = New System.Windows.Forms.ComboBox()
        Me.lblDistritos = New System.Windows.Forms.Label()
        Me.cboDistritos = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'cboDeptos
        '
        Me.cboDeptos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDeptos.FormattingEnabled = True
        Me.cboDeptos.Location = New System.Drawing.Point(90, 33)
        Me.cboDeptos.Name = "cboDeptos"
        Me.cboDeptos.Size = New System.Drawing.Size(175, 21)
        Me.cboDeptos.TabIndex = 3
        '
        'lblDepto
        '
        Me.lblDepto.AutoSize = True
        Me.lblDepto.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepto.ForeColor = System.Drawing.Color.Green
        Me.lblDepto.Location = New System.Drawing.Point(12, 32)
        Me.lblDepto.Name = "lblDepto"
        Me.lblDepto.Size = New System.Drawing.Size(72, 22)
        Me.lblDepto.TabIndex = 4
        Me.lblDepto.Text = "Depto:"
        '
        'lblMun
        '
        Me.lblMun.AutoSize = True
        Me.lblMun.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMun.ForeColor = System.Drawing.Color.Green
        Me.lblMun.Location = New System.Drawing.Point(286, 32)
        Me.lblMun.Name = "lblMun"
        Me.lblMun.Size = New System.Drawing.Size(58, 22)
        Me.lblMun.TabIndex = 6
        Me.lblMun.Text = "Mun:"
        '
        'cboMun
        '
        Me.cboMun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMun.FormattingEnabled = True
        Me.cboMun.Location = New System.Drawing.Point(350, 33)
        Me.cboMun.Name = "cboMun"
        Me.cboMun.Size = New System.Drawing.Size(175, 21)
        Me.cboMun.TabIndex = 5
        '
        'lblDistritos
        '
        Me.lblDistritos.AutoSize = True
        Me.lblDistritos.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDistritos.ForeColor = System.Drawing.Color.Green
        Me.lblDistritos.Location = New System.Drawing.Point(110, 84)
        Me.lblDistritos.Name = "lblDistritos"
        Me.lblDistritos.Size = New System.Drawing.Size(84, 22)
        Me.lblDistritos.TabIndex = 8
        Me.lblDistritos.Text = "Distrito:"
        '
        'cboDistritos
        '
        Me.cboDistritos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDistritos.FormattingEnabled = True
        Me.cboDistritos.Location = New System.Drawing.Point(200, 88)
        Me.cboDistritos.Name = "cboDistritos"
        Me.cboDistritos.Size = New System.Drawing.Size(175, 21)
        Me.cboDistritos.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(587, 186)
        Me.Controls.Add(Me.lblDistritos)
        Me.Controls.Add(Me.cboDistritos)
        Me.Controls.Add(Me.lblMun)
        Me.Controls.Add(Me.cboMun)
        Me.Controls.Add(Me.lblDepto)
        Me.Controls.Add(Me.cboDeptos)
        Me.Name = "Form1"
        Me.Text = "Direcciones en El Salvador"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboDeptos As ComboBox
    Friend WithEvents lblDepto As Label
    Friend WithEvents lblMun As Label
    Friend WithEvents cboMun As ComboBox
    Friend WithEvents lblDistritos As Label
    Friend WithEvents cboDistritos As ComboBox
End Class
