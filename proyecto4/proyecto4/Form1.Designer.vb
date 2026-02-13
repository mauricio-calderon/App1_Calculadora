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
        Me.num1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.botonMas = New System.Windows.Forms.Button()
        Me.num2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.botonMenos = New System.Windows.Forms.Button()
        Me.botonPor = New System.Windows.Forms.Button()
        Me.botonEntre = New System.Windows.Forms.Button()
        Me.boton0 = New System.Windows.Forms.Button()
        Me.boton1 = New System.Windows.Forms.Button()
        Me.boton2 = New System.Windows.Forms.Button()
        Me.boton3 = New System.Windows.Forms.Button()
        Me.boton4 = New System.Windows.Forms.Button()
        Me.boton5 = New System.Windows.Forms.Button()
        Me.boton6 = New System.Windows.Forms.Button()
        Me.boton7 = New System.Windows.Forms.Button()
        Me.boton8 = New System.Windows.Forms.Button()
        Me.boton9 = New System.Windows.Forms.Button()
        Me.botonBorrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'num1
        '
        Me.num1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num1.Location = New System.Drawing.Point(244, 16)
        Me.num1.Margin = New System.Windows.Forms.Padding(4)
        Me.num1.Name = "num1"
        Me.num1.Size = New System.Drawing.Size(220, 44)
        Me.num1.TabIndex = 0
        Me.num1.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(17, 13)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 47)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "NUMERO 1"
        '
        'botonMas
        '
        Me.botonMas.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botonMas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.botonMas.Location = New System.Drawing.Point(878, 12)
        Me.botonMas.Margin = New System.Windows.Forms.Padding(4)
        Me.botonMas.Name = "botonMas"
        Me.botonMas.Size = New System.Drawing.Size(103, 94)
        Me.botonMas.TabIndex = 2
        Me.botonMas.Text = "+"
        Me.botonMas.UseVisualStyleBackColor = True
        '
        'num2
        '
        Me.num2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num2.Location = New System.Drawing.Point(244, 82)
        Me.num2.Margin = New System.Windows.Forms.Padding(4)
        Me.num2.Name = "num2"
        Me.num2.Size = New System.Drawing.Size(220, 44)
        Me.num2.TabIndex = 4
        Me.num2.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(17, 82)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(202, 47)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "NUMERO 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(17, 158)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(238, 47)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "RESULTADO:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cambria Math", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(243, 80)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 206)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "0"
        '
        'botonMenos
        '
        Me.botonMenos.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botonMenos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.botonMenos.Location = New System.Drawing.Point(878, 132)
        Me.botonMenos.Margin = New System.Windows.Forms.Padding(4)
        Me.botonMenos.Name = "botonMenos"
        Me.botonMenos.Size = New System.Drawing.Size(103, 94)
        Me.botonMenos.TabIndex = 8
        Me.botonMenos.Text = "-"
        Me.botonMenos.UseVisualStyleBackColor = True
        '
        'botonPor
        '
        Me.botonPor.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botonPor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.botonPor.Location = New System.Drawing.Point(878, 247)
        Me.botonPor.Margin = New System.Windows.Forms.Padding(4)
        Me.botonPor.Name = "botonPor"
        Me.botonPor.Size = New System.Drawing.Size(103, 94)
        Me.botonPor.TabIndex = 9
        Me.botonPor.Text = "x"
        Me.botonPor.UseVisualStyleBackColor = True
        '
        'botonEntre
        '
        Me.botonEntre.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botonEntre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.botonEntre.Location = New System.Drawing.Point(878, 362)
        Me.botonEntre.Margin = New System.Windows.Forms.Padding(4)
        Me.botonEntre.Name = "botonEntre"
        Me.botonEntre.Size = New System.Drawing.Size(103, 94)
        Me.botonEntre.TabIndex = 10
        Me.botonEntre.Text = "÷"
        Me.botonEntre.UseVisualStyleBackColor = True
        '
        'boton0
        '
        Me.boton0.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boton0.ForeColor = System.Drawing.Color.Black
        Me.boton0.Location = New System.Drawing.Point(632, 362)
        Me.boton0.Name = "boton0"
        Me.boton0.Size = New System.Drawing.Size(103, 94)
        Me.boton0.TabIndex = 11
        Me.boton0.Text = "0"
        Me.boton0.UseVisualStyleBackColor = True
        '
        'boton1
        '
        Me.boton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boton1.ForeColor = System.Drawing.Color.Black
        Me.boton1.Location = New System.Drawing.Point(508, 247)
        Me.boton1.Name = "boton1"
        Me.boton1.Size = New System.Drawing.Size(103, 94)
        Me.boton1.TabIndex = 12
        Me.boton1.Text = "1"
        Me.boton1.UseVisualStyleBackColor = True
        '
        'boton2
        '
        Me.boton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boton2.ForeColor = System.Drawing.Color.Black
        Me.boton2.Location = New System.Drawing.Point(632, 247)
        Me.boton2.Name = "boton2"
        Me.boton2.Size = New System.Drawing.Size(103, 94)
        Me.boton2.TabIndex = 13
        Me.boton2.Text = "2"
        Me.boton2.UseVisualStyleBackColor = True
        '
        'boton3
        '
        Me.boton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boton3.ForeColor = System.Drawing.Color.Black
        Me.boton3.Location = New System.Drawing.Point(756, 247)
        Me.boton3.Name = "boton3"
        Me.boton3.Size = New System.Drawing.Size(103, 94)
        Me.boton3.TabIndex = 14
        Me.boton3.Text = "3"
        Me.boton3.UseVisualStyleBackColor = True
        '
        'boton4
        '
        Me.boton4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boton4.ForeColor = System.Drawing.Color.Black
        Me.boton4.Location = New System.Drawing.Point(508, 132)
        Me.boton4.Name = "boton4"
        Me.boton4.Size = New System.Drawing.Size(103, 94)
        Me.boton4.TabIndex = 15
        Me.boton4.Text = "4"
        Me.boton4.UseVisualStyleBackColor = True
        '
        'boton5
        '
        Me.boton5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boton5.ForeColor = System.Drawing.Color.Black
        Me.boton5.Location = New System.Drawing.Point(632, 132)
        Me.boton5.Name = "boton5"
        Me.boton5.Size = New System.Drawing.Size(103, 94)
        Me.boton5.TabIndex = 16
        Me.boton5.Text = "5"
        Me.boton5.UseVisualStyleBackColor = True
        '
        'boton6
        '
        Me.boton6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boton6.ForeColor = System.Drawing.Color.Black
        Me.boton6.Location = New System.Drawing.Point(756, 132)
        Me.boton6.Name = "boton6"
        Me.boton6.Size = New System.Drawing.Size(103, 94)
        Me.boton6.TabIndex = 17
        Me.boton6.Text = "6"
        Me.boton6.UseVisualStyleBackColor = True
        '
        'boton7
        '
        Me.boton7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boton7.ForeColor = System.Drawing.Color.Black
        Me.boton7.Location = New System.Drawing.Point(508, 12)
        Me.boton7.Name = "boton7"
        Me.boton7.Size = New System.Drawing.Size(103, 94)
        Me.boton7.TabIndex = 18
        Me.boton7.Text = "7"
        Me.boton7.UseVisualStyleBackColor = True
        '
        'boton8
        '
        Me.boton8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boton8.ForeColor = System.Drawing.Color.Black
        Me.boton8.Location = New System.Drawing.Point(632, 12)
        Me.boton8.Name = "boton8"
        Me.boton8.Size = New System.Drawing.Size(103, 94)
        Me.boton8.TabIndex = 19
        Me.boton8.Text = "8"
        Me.boton8.UseVisualStyleBackColor = True
        '
        'boton9
        '
        Me.boton9.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boton9.ForeColor = System.Drawing.Color.Black
        Me.boton9.Location = New System.Drawing.Point(756, 12)
        Me.boton9.Name = "boton9"
        Me.boton9.Size = New System.Drawing.Size(103, 94)
        Me.boton9.TabIndex = 20
        Me.boton9.Text = "9"
        Me.boton9.UseVisualStyleBackColor = True
        '
        'botonBorrar
        '
        Me.botonBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botonBorrar.ForeColor = System.Drawing.Color.Black
        Me.botonBorrar.Location = New System.Drawing.Point(756, 362)
        Me.botonBorrar.Name = "botonBorrar"
        Me.botonBorrar.Size = New System.Drawing.Size(103, 94)
        Me.botonBorrar.TabIndex = 21
        Me.botonBorrar.Text = "C"
        Me.botonBorrar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SpringGreen
        Me.ClientSize = New System.Drawing.Size(997, 475)
        Me.Controls.Add(Me.botonBorrar)
        Me.Controls.Add(Me.boton9)
        Me.Controls.Add(Me.boton8)
        Me.Controls.Add(Me.boton7)
        Me.Controls.Add(Me.boton6)
        Me.Controls.Add(Me.boton5)
        Me.Controls.Add(Me.boton4)
        Me.Controls.Add(Me.boton3)
        Me.Controls.Add(Me.boton2)
        Me.Controls.Add(Me.boton1)
        Me.Controls.Add(Me.boton0)
        Me.Controls.Add(Me.botonEntre)
        Me.Controls.Add(Me.botonPor)
        Me.Controls.Add(Me.botonMenos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.num2)
        Me.Controls.Add(Me.botonMas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.num1)
        Me.Controls.Add(Me.Label4)
        Me.ForeColor = System.Drawing.Color.DarkKhaki
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents num1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents botonMas As Button
    Friend WithEvents num2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents botonMenos As Button
    Friend WithEvents botonPor As Button
    Friend WithEvents botonEntre As Button
    Friend WithEvents boton0 As Button
    Friend WithEvents boton1 As Button
    Friend WithEvents boton2 As Button
    Friend WithEvents boton3 As Button
    Friend WithEvents boton4 As Button
    Friend WithEvents boton5 As Button
    Friend WithEvents boton6 As Button
    Friend WithEvents boton7 As Button
    Friend WithEvents boton8 As Button
    Friend WithEvents boton9 As Button
    Friend WithEvents botonBorrar As Button
End Class
