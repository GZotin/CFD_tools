
Public Class main_page

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

    Private Sub cmdTurbModel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmdTurbModel.SelectedIndexChanged
        If cmdTurbModel.SelectedIndex = 0 Then 'k-eps
            labelEpsOmega.Text = "Turbulence dissipation rate (eps)"
            labelK.Visible = True
            labelEpsOmega.Visible = True
            txtk.Visible = True
            txtEpsOmega.Visible = True

            labelNuTilda.Visible = False
            txtNuTilda.Visible = False

            txtReTM.ReadOnly = False
            txtI.ReadOnly = False
        End If

        If cmdTurbModel.SelectedIndex = 1 Then 'k-omg
            labelEpsOmega.Text = "Specific dissipation rate (omega)"
            labelK.Visible = True
            labelEpsOmega.Visible = True
            txtk.Visible = True
            txtEpsOmega.Visible = True

            labelNuTilda.Visible = False
            txtNuTilda.Visible = False

            txtReTM.ReadOnly = False
            txtI.ReadOnly = False
        End If

        If cmdTurbModel.SelectedIndex = 2 Then 'SA
            labelNuTilda.Text = "Modified turbulent viscosity (nu_tilda)"
            labelNuTilda.Visible = True
            txtNuTilda.Visible = True

            labelK.Visible = False
            labelEpsOmega.Visible = False
            txtk.Visible = False
            txtEpsOmega.Visible = False

            txtReTM.ReadOnly = True
            txtI.ReadOnly = True
        End If

    End Sub

    Private Sub btnTurbModel_Click(sender As Object, e As EventArgs) Handles btnInputs2.Click
        Dim UTM As Decimal
        Dim DhTM As Decimal
        Dim ReTM As Decimal
        Dim l As Decimal
        Dim I As Decimal

        UTM = txtVelocityTM.Text
        DhTM = txtDhTM.Text
        l = 0.07 * DhTM


        If cmdTurbModel.SelectedIndex = 0 Or cmdTurbModel.SelectedIndex = 1 Then
            ReTM = txtReTM.Text
            I = 0.16 * ReTM ^ (-1 / 8)
        Else
            I = 0
            txtReTM.Text = 0
        End If

        txtl.Text = l.ToString("E")
        txtI.Text = I.ToString("E")
    End Sub

    Private Sub btnCalculateTM_Click(sender As Object, e As EventArgs) Handles btnCalculateTM.Click
        Dim UTM As Decimal
        Dim DhTM As Decimal
        Dim ReTM As Decimal
        Dim l As Decimal
        Dim I As Decimal
        Dim C_mu As Decimal

        UTM = txtVelocityTM.Text
        DhTM = txtDhTM.Text
        ReTM = txtReTM.Text
        l = txtl.Text
        I = txtI.Text
        C_mu = txtC_mu.Text

        Dim k As Decimal
        Dim eps As Decimal
        Dim omega As Decimal
        Dim NuTilda As Decimal

        If cmdTurbModel.SelectedIndex = 0 Then 'k-eps
            k = 3 / 2 * (UTM * I) ^ 2
            txtk.Text = k.ToString("E")
            eps = C_mu ^ (0.75) * k ^ (3 / 2) / l
            txtEpsOmega.Text = eps.ToString("E")
        End If

        If cmdTurbModel.SelectedIndex = 1 Then 'k-omg
            k = 3 / 2 * (UTM * I) ^ 2
            txtk.Text = k.ToString("E")
            omega = k ^ (0.5) / (C_mu ^ (0.25) * l)
            txtEpsOmega.Text = omega.ToString("E")
        End If

        If cmdTurbModel.SelectedIndex = 2 Then 'SA
            NuTilda = C_mu ^ (1 / 4) * UTM * l
            txtNuTilda.Text = NuTilda.ToString("E")
        End If
    End Sub
End Class
