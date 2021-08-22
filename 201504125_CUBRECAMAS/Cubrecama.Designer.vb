<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cubrecama
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBoxCubrecamas = New System.Windows.Forms.GroupBox()
        Me.RadioButtonKing = New System.Windows.Forms.RadioButton()
        Me.RadioButtonQueen = New System.Windows.Forms.RadioButton()
        Me.RadioButtonMatrimonial = New System.Windows.Forms.RadioButton()
        Me.RadioButtonImperial = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxMaterial = New System.Windows.Forms.TextBox()
        Me.GroupBoxMateriales = New System.Windows.Forms.GroupBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TextBoxHiloCrudo = New System.Windows.Forms.TextBox()
        Me.TextBoxSeda = New System.Windows.Forms.TextBox()
        Me.TextBoxAlgodon = New System.Windows.Forms.TextBox()
        Me.TextBoxLino = New System.Windows.Forms.TextBox()
        Me.ButtonCalcular = New System.Windows.Forms.Button()
        Me.ButtonLimpiar = New System.Windows.Forms.Button()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.LabelCosto = New System.Windows.Forms.Label()
        Me.LabelVenta = New System.Windows.Forms.Label()
        Me.GroupBoxCubrecamas.SuspendLayout()
        Me.GroupBoxMateriales.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label1.Location = New System.Drawing.Point(229, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Precio venta"
        '
        'GroupBoxCubrecamas
        '
        Me.GroupBoxCubrecamas.Controls.Add(Me.RadioButtonKing)
        Me.GroupBoxCubrecamas.Controls.Add(Me.RadioButtonQueen)
        Me.GroupBoxCubrecamas.Controls.Add(Me.RadioButtonMatrimonial)
        Me.GroupBoxCubrecamas.Controls.Add(Me.RadioButtonImperial)
        Me.GroupBoxCubrecamas.Location = New System.Drawing.Point(34, 105)
        Me.GroupBoxCubrecamas.Name = "GroupBoxCubrecamas"
        Me.GroupBoxCubrecamas.Size = New System.Drawing.Size(217, 200)
        Me.GroupBoxCubrecamas.TabIndex = 1
        Me.GroupBoxCubrecamas.TabStop = False
        Me.GroupBoxCubrecamas.Text = "Cubrecamas"
        '
        'RadioButtonKing
        '
        Me.RadioButtonKing.AutoSize = True
        Me.RadioButtonKing.Location = New System.Drawing.Point(28, 146)
        Me.RadioButtonKing.Name = "RadioButtonKing"
        Me.RadioButtonKing.Size = New System.Drawing.Size(69, 28)
        Me.RadioButtonKing.TabIndex = 3
        Me.RadioButtonKing.Text = "King"
        Me.RadioButtonKing.UseVisualStyleBackColor = True
        '
        'RadioButtonQueen
        '
        Me.RadioButtonQueen.AutoSize = True
        Me.RadioButtonQueen.Location = New System.Drawing.Point(28, 112)
        Me.RadioButtonQueen.Name = "RadioButtonQueen"
        Me.RadioButtonQueen.Size = New System.Drawing.Size(90, 28)
        Me.RadioButtonQueen.TabIndex = 2
        Me.RadioButtonQueen.Text = "Queen"
        Me.RadioButtonQueen.UseVisualStyleBackColor = True
        '
        'RadioButtonMatrimonial
        '
        Me.RadioButtonMatrimonial.AutoSize = True
        Me.RadioButtonMatrimonial.Location = New System.Drawing.Point(28, 78)
        Me.RadioButtonMatrimonial.Name = "RadioButtonMatrimonial"
        Me.RadioButtonMatrimonial.Size = New System.Drawing.Size(135, 28)
        Me.RadioButtonMatrimonial.TabIndex = 1
        Me.RadioButtonMatrimonial.Text = "Matrimonial"
        Me.RadioButtonMatrimonial.UseVisualStyleBackColor = True
        '
        'RadioButtonImperial
        '
        Me.RadioButtonImperial.AutoSize = True
        Me.RadioButtonImperial.Location = New System.Drawing.Point(28, 44)
        Me.RadioButtonImperial.Name = "RadioButtonImperial"
        Me.RadioButtonImperial.Size = New System.Drawing.Size(101, 28)
        Me.RadioButtonImperial.TabIndex = 0
        Me.RadioButtonImperial.Text = "Imperial"
        Me.RadioButtonImperial.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(97, 334)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(219, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Materiales Pendientes"
        '
        'TextBoxMaterial
        '
        Me.TextBoxMaterial.Enabled = False
        Me.TextBoxMaterial.Location = New System.Drawing.Point(331, 331)
        Me.TextBoxMaterial.Name = "TextBoxMaterial"
        Me.TextBoxMaterial.Size = New System.Drawing.Size(100, 32)
        Me.TextBoxMaterial.TabIndex = 4
        '
        'GroupBoxMateriales
        '
        Me.GroupBoxMateriales.Controls.Add(Me.CheckBox4)
        Me.GroupBoxMateriales.Controls.Add(Me.CheckBox3)
        Me.GroupBoxMateriales.Controls.Add(Me.CheckBox2)
        Me.GroupBoxMateriales.Controls.Add(Me.CheckBox1)
        Me.GroupBoxMateriales.Controls.Add(Me.TextBoxHiloCrudo)
        Me.GroupBoxMateriales.Controls.Add(Me.TextBoxSeda)
        Me.GroupBoxMateriales.Controls.Add(Me.TextBoxAlgodon)
        Me.GroupBoxMateriales.Controls.Add(Me.TextBoxLino)
        Me.GroupBoxMateriales.Location = New System.Drawing.Point(300, 105)
        Me.GroupBoxMateriales.Name = "GroupBoxMateriales"
        Me.GroupBoxMateriales.Size = New System.Drawing.Size(358, 200)
        Me.GroupBoxMateriales.TabIndex = 2
        Me.GroupBoxMateriales.TabStop = False
        Me.GroupBoxMateriales.Text = "Materiales"
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(20, 145)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(126, 28)
        Me.CheckBox4.TabIndex = 11
        Me.CheckBox4.Text = "Hilo Crudo"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(20, 110)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(78, 28)
        Me.CheckBox3.TabIndex = 10
        Me.CheckBox3.Text = "Seda"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(20, 75)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(103, 28)
        Me.CheckBox2.TabIndex = 9
        Me.CheckBox2.Text = "Algodon"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(20, 40)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(69, 28)
        Me.CheckBox1.TabIndex = 8
        Me.CheckBox1.Text = "Lino"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TextBoxHiloCrudo
        '
        Me.TextBoxHiloCrudo.Enabled = False
        Me.TextBoxHiloCrudo.Location = New System.Drawing.Point(162, 141)
        Me.TextBoxHiloCrudo.Name = "TextBoxHiloCrudo"
        Me.TextBoxHiloCrudo.Size = New System.Drawing.Size(137, 32)
        Me.TextBoxHiloCrudo.TabIndex = 7
        '
        'TextBoxSeda
        '
        Me.TextBoxSeda.Enabled = False
        Me.TextBoxSeda.Location = New System.Drawing.Point(162, 106)
        Me.TextBoxSeda.Name = "TextBoxSeda"
        Me.TextBoxSeda.Size = New System.Drawing.Size(137, 32)
        Me.TextBoxSeda.TabIndex = 6
        '
        'TextBoxAlgodon
        '
        Me.TextBoxAlgodon.Enabled = False
        Me.TextBoxAlgodon.Location = New System.Drawing.Point(162, 71)
        Me.TextBoxAlgodon.Name = "TextBoxAlgodon"
        Me.TextBoxAlgodon.Size = New System.Drawing.Size(137, 32)
        Me.TextBoxAlgodon.TabIndex = 5
        '
        'TextBoxLino
        '
        Me.TextBoxLino.Enabled = False
        Me.TextBoxLino.Location = New System.Drawing.Point(162, 36)
        Me.TextBoxLino.Name = "TextBoxLino"
        Me.TextBoxLino.Size = New System.Drawing.Size(137, 32)
        Me.TextBoxLino.TabIndex = 4
        '
        'ButtonCalcular
        '
        Me.ButtonCalcular.BackColor = System.Drawing.Color.DodgerBlue
        Me.ButtonCalcular.Location = New System.Drawing.Point(161, 422)
        Me.ButtonCalcular.Name = "ButtonCalcular"
        Me.ButtonCalcular.Size = New System.Drawing.Size(98, 35)
        Me.ButtonCalcular.TabIndex = 5
        Me.ButtonCalcular.Text = "Calcular"
        Me.ButtonCalcular.UseVisualStyleBackColor = False
        '
        'ButtonLimpiar
        '
        Me.ButtonLimpiar.BackColor = System.Drawing.Color.Yellow
        Me.ButtonLimpiar.Location = New System.Drawing.Point(307, 422)
        Me.ButtonLimpiar.Name = "ButtonLimpiar"
        Me.ButtonLimpiar.Size = New System.Drawing.Size(98, 35)
        Me.ButtonLimpiar.TabIndex = 6
        Me.ButtonLimpiar.Text = "Limpiar"
        Me.ButtonLimpiar.UseVisualStyleBackColor = False
        '
        'ButtonSalir
        '
        Me.ButtonSalir.BackColor = System.Drawing.Color.OrangeRed
        Me.ButtonSalir.Location = New System.Drawing.Point(453, 422)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(98, 35)
        Me.ButtonSalir.TabIndex = 7
        Me.ButtonSalir.Text = "Salir"
        Me.ButtonSalir.UseVisualStyleBackColor = False
        '
        'LabelCosto
        '
        Me.LabelCosto.AutoSize = True
        Me.LabelCosto.Location = New System.Drawing.Point(497, 322)
        Me.LabelCosto.Name = "LabelCosto"
        Me.LabelCosto.Size = New System.Drawing.Size(78, 24)
        Me.LabelCosto.TabIndex = 8
        Me.LabelCosto.Text = "Costo: "
        '
        'LabelVenta
        '
        Me.LabelVenta.AutoSize = True
        Me.LabelVenta.Location = New System.Drawing.Point(497, 366)
        Me.LabelVenta.Name = "LabelVenta"
        Me.LabelVenta.Size = New System.Drawing.Size(75, 24)
        Me.LabelVenta.TabIndex = 9
        Me.LabelVenta.Text = "Venta: "
        '
        'Cubrecama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(741, 493)
        Me.Controls.Add(Me.LabelVenta)
        Me.Controls.Add(Me.LabelCosto)
        Me.Controls.Add(Me.ButtonSalir)
        Me.Controls.Add(Me.ButtonLimpiar)
        Me.Controls.Add(Me.ButtonCalcular)
        Me.Controls.Add(Me.TextBoxMaterial)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBoxMateriales)
        Me.Controls.Add(Me.GroupBoxCubrecamas)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "Cubrecama"
        Me.Text = "Precio de Venta"
        Me.GroupBoxCubrecamas.ResumeLayout(False)
        Me.GroupBoxCubrecamas.PerformLayout()
        Me.GroupBoxMateriales.ResumeLayout(False)
        Me.GroupBoxMateriales.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBoxCubrecamas As GroupBox
    Friend WithEvents RadioButtonKing As RadioButton
    Friend WithEvents RadioButtonQueen As RadioButton
    Friend WithEvents RadioButtonMatrimonial As RadioButton
    Friend WithEvents RadioButtonImperial As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxMaterial As TextBox
    Friend WithEvents GroupBoxMateriales As GroupBox
    Friend WithEvents TextBoxHiloCrudo As TextBox
    Friend WithEvents TextBoxSeda As TextBox
    Friend WithEvents TextBoxAlgodon As TextBox
    Friend WithEvents TextBoxLino As TextBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents ButtonCalcular As Button
    Friend WithEvents ButtonLimpiar As Button
    Friend WithEvents ButtonSalir As Button
    Friend WithEvents LabelCosto As Label
    Friend WithEvents LabelVenta As Label
End Class
