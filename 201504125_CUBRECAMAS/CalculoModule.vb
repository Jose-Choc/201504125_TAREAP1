Module CalculoModule
    'Total de material a utilizar
    Public materialTotal As Decimal
    'Precio de venta
    Public costo As Decimal = 0
    Public venta As Decimal = 0
    'Cantidad de material
    Public totalLino As Decimal = 0
    Public totalAlgodon As Decimal = 0
    Public totalSeda As Decimal = 0
    Public totalHiloCrudo As Decimal = 0
    'Precio de material
    Public precioLino As Decimal = 15
    Public precioAlgodon As Decimal = 23.99
    Public precioSeda As Decimal = 30.99
    Public precioHiloCrudo As Decimal = 39.99

    'Funcion para verificar el precio de mano de obra
    Public Function precioMano() As Decimal
        If Cubrecama.RadioButtonImperial.Checked Then
            Return 65.5
        End If
        If Cubrecama.RadioButtonMatrimonial.Checked Then
            Return 85.99
        End If
        If Cubrecama.RadioButtonQueen.Checked Then
            Return 99.99
        End If
        If Cubrecama.RadioButtonKing.Checked Then
            Return 105.99
        End If
        Return 0
    End Function
    Public Function totalMaterialInicial() As Decimal
        If Cubrecama.RadioButtonImperial.Checked Then
            Return 3
        End If
        If Cubrecama.RadioButtonMatrimonial.Checked Then
            Return 5
        End If
        If Cubrecama.RadioButtonQueen.Checked Then
            Return 6
        End If
        If Cubrecama.RadioButtonKing.Checked Then
            Return 7
        End If
        Return 0
    End Function

    Public Sub resetForm()
        Cubrecama.RadioButtonImperial.Checked = False
        Cubrecama.RadioButtonMatrimonial.Checked = False
        Cubrecama.RadioButtonQueen.Checked = False
        Cubrecama.RadioButtonKing.Checked = False
        Cubrecama.CheckBox1.Checked = False
        Cubrecama.CheckBox2.Checked = False
        Cubrecama.CheckBox3.Checked = False
        Cubrecama.CheckBox4.Checked = False
        Cubrecama.TextBoxLino.Text = ""
        Cubrecama.TextBoxAlgodon.Text = ""
        Cubrecama.TextBoxSeda.Text = ""
        Cubrecama.TextBoxHiloCrudo.Text = ""
        Cubrecama.TextBoxMaterial.Text = ""
    End Sub
    Public Sub calculoFinal()
        Dim materialIngresada = totalLino + totalAlgodon + totalSeda + totalHiloCrudo
        If totalMaterialInicial() < materialIngresada Then
            MessageBox.Show("Has sobrepasado el total material a usar")
            resetForm()
        Else
            costo = (totalLino * precioLino) + (totalAlgodon * precioAlgodon) + (totalSeda * precioSeda) + (totalHiloCrudo * precioHiloCrudo) + precioMano()
            venta = costo + costo * 0.65

            Cubrecama.LabelCosto.Text = "Costo: " + costo.ToString()
            Cubrecama.LabelVenta.Text = "Costo: " + venta.ToString()
        End If
    End Sub
End Module
