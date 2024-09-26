Public Class main_page
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim U As Decimal
        Dim Dh As Decimal
        Dim nu As Decimal

        U = txtVelocity.Text
        Dh = txtRefDim.Text
        nu = txtNu.Text

        Dim Re As Decimal

        Re = U * Dh / nu

        txtReynolds.Text = Re
    End Sub

End Class
