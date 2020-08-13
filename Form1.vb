Public Class Form1
    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
        Dim ntabla, i As SByte
        ntabla = textTabla.Text

        LstTablas.Items.Clear()
        If ntabla <= 12 Then
            For i = 1 To 10
                LstTablas.Items.Add(ntabla.ToString() + "x" + i.ToString() + "=" + (ntabla * i).ToString())
            Next
        Else
            LstTablas.Items.Add("por favor ingrese solo tablas menores o iguales a 12.")
        End If

    End Sub
End Class
