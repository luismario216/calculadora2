Public Class Form1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        'Dim es una variable reservada para declarar una variable
        Dim num1, num2, respuesta As Double 'Declaro las variables en linea separadas por comas del mismo tipo.

        num1 = txtnum1.Text
        num2 = txtnum2.Text

        If optSuma.Checked Then
            lblrespuesta.Text = num1 + num2 'realizamos la suma
        End If

        If optResta.Checked Then
            lblrespuesta.Text = num1 - num2 'realizamos la resta
        End If

        If optMultiplicar.Checked Then
            lblrespuesta.Text = num1 * num2 'realizamos la multiplicacion
        End If

        If optDividir.Checked Then
            lblrespuesta.Text = num1 / num2 'realizamos la division
        End If

        If optPorcentaje.Checked Then
            lblrespuesta.Text = num1 * num2 / 100 'proceso de porcentaje
        End If

        If optExponencia.Checked Then
            lblrespuesta.Text = num1 ^ num2
        End If

        If RadioButton7.Checked Then
            lblrespuesta.Text = num1 Mod num2
        End If
    End Sub
End Class
