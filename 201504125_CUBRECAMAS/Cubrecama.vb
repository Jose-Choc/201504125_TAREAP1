Public Class Cubrecama
    Private Sub RadioButtonImperial_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonImperial.CheckedChanged
        If RadioButtonImperial.Checked Then
            CalculoModule.materialTotal = 3
            TextBoxMaterial.Text = CalculoModule.materialTotal.ToString() + " Yardas"
        End If
    End Sub

    Private Sub RadioButtonMatrimonial_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonMatrimonial.CheckedChanged
        CalculoModule.materialTotal = 5
        TextBoxMaterial.Text = CalculoModule.materialTotal.ToString() + " Yardas"
    End Sub

    Private Sub RadioButtonQueen_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonQueen.CheckedChanged
        CalculoModule.materialTotal = 6
        TextBoxMaterial.Text = CalculoModule.materialTotal.ToString() + " Yardas"
    End Sub

    Private Sub RadioButtonKing_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonKing.CheckedChanged
        CalculoModule.materialTotal = 7
        TextBoxMaterial.Text = CalculoModule.materialTotal.ToString() + " Yardas"
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBoxLino.Enabled = True
        Else
            TextBoxLino.Enabled = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            TextBoxAlgodon.Enabled = True
        Else
            TextBoxAlgodon.Enabled = False
        End If
    End Sub
    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then
            TextBoxSeda.Enabled = True
        Else
            TextBoxSeda.Enabled = False
        End If
    End Sub
    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked Then
            TextBoxHiloCrudo.Enabled = True
        Else
            TextBoxHiloCrudo.Enabled = False
        End If
    End Sub
    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        If MessageBox.Show("Esta seguro de salir", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
            Close()
        End If
    End Sub

    Private Sub ButtonLimpiar_Click(sender As Object, e As EventArgs) Handles ButtonLimpiar.Click
        CalculoModule.resetForm()
    End Sub
    Private Sub ButtonCalcular_Click(sender As Object, e As EventArgs) Handles ButtonCalcular.Click
        totalLino = Val(TextBoxLino.Text)
        totalAlgodon = Val(TextBoxAlgodon.Text)
        totalSeda = Val(TextBoxSeda.Text)
        totalHiloCrudo = Val(TextBoxHiloCrudo.Text)
        calculoFinal()
    End Sub
End Class
