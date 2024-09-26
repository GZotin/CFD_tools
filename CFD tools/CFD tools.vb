
Imports Svg
Public Class main_page
    Private Sub main_page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load the SVG file
        Dim svgDoc As SvgDocument = SvgDocument.Open("C:\Users\Gustavo\Documents\GitHub\CFD_tools\CFD tools\images\eqn_Re.svg")

        ' Render the SVG to a bitmap
        Dim bmp As Bitmap = svgDoc.Draw()

        ' Set the PictureBox image
        PictureBox1.Image = bmp
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage

        txtNu.ReadOnly = True
        txtMu.ReadOnly = True
        txtRho.ReadOnly = True

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim U As Decimal
        Dim Dh As Decimal
        Dim nu As Decimal
        Dim mu As Decimal
        Dim rho As Decimal

        U = txtVelocity.Text
        Dh = txtRefDim.Text
        nu = txtNu.Text
        mu = txtMu.Text
        rho = txtRho.Text

        Dim Re As Decimal

        If RadioButton1.Checked = True Then
            Re = U * Dh / nu
        End If

        If RadioButton2.Checked = True Then
            Re = rho * U * Dh / mu
        End If

        txtReynolds.Text = Re

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        txtNu.ReadOnly = False
        txtMu.ReadOnly = True
        txtRho.ReadOnly = True
        txtNu.Text = ""
        txtMu.Text = 0
        txtRho.Text = 0

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        txtNu.ReadOnly = True
        txtMu.ReadOnly = False
        txtRho.ReadOnly = False
        txtNu.Text = 0
        txtMu.Text = ""
        txtRho.Text = ""
    End Sub

    Private Sub cmdCalculateYplus_Click(sender As Object, e As EventArgs) Handles cmdCalculateYplus.Click
        Dim UYplus As Decimal
        Dim rhoYplus As Decimal
        Dim muYplus As Decimal
        Dim ReYplus As Decimal
        Dim Yplus As Decimal

        UYplus = txtVelocityYplus.Text
        rhoYplus = txtRhoYplus.Text
        muYplus = txtMuYplus.Text
        ReYplus = txtReYplus.Text
        Yplus = txtYplus.Text

        Dim nuYplus As Decimal
        Dim Cf As Decimal
        Dim Tau_w As Decimal
        Dim u_Tau As Decimal
        Dim Y As Decimal

        nuYplus = muYplus / rhoYplus
        Cf = 0.0576 * ReYplus ^ (-1 / 5)
        Tau_w = 1 / 2 * (Cf * rhoYplus * UYplus ^ 2)
        u_Tau = (Tau_w / rhoYplus) ^ (1 / 2)
        Y = Yplus * nuYplus / u_Tau

        txtY.Text = Y.ToString("E")

    End Sub

End Class
