<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class main_page
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtReynolds = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtRho = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMu = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNu = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRefDim = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtVelocity = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtNuTilda = New System.Windows.Forms.TextBox()
        Me.labelNuTilda = New System.Windows.Forms.Label()
        Me.btnCalculateTM = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtC_mu = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtl = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtI = New System.Windows.Forms.TextBox()
        Me.txtEpsOmega = New System.Windows.Forms.TextBox()
        Me.txtk = New System.Windows.Forms.TextBox()
        Me.labelEpsOmega = New System.Windows.Forms.Label()
        Me.labelK = New System.Windows.Forms.Label()
        Me.btnInputs2 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtReTM = New System.Windows.Forms.TextBox()
        Me.txtDhTM = New System.Windows.Forms.TextBox()
        Me.txtVelocityTM = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cmdTurbModel = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.txtY = New System.Windows.Forms.TextBox()
        Me.cmdCalculateYplus = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtMuYplus = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtYplus = New System.Windows.Forms.TextBox()
        Me.txtReYplus = New System.Windows.Forms.TextBox()
        Me.txtRhoYplus = New System.Windows.Forms.TextBox()
        Me.txtVelocityYplus = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(364, 561)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtReynolds)
        Me.TabPage1.Controls.Add(Me.btnCalculate)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(356, 535)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Reynolds Number"
        '
        'txtReynolds
        '
        Me.txtReynolds.Location = New System.Drawing.Point(195, 426)
        Me.txtReynolds.Name = "txtReynolds"
        Me.txtReynolds.ReadOnly = True
        Me.txtReynolds.Size = New System.Drawing.Size(99, 20)
        Me.txtReynolds.TabIndex = 9
        Me.txtReynolds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(141, 360)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 12
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(62, 429)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Reynolds Number"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtRho)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtMu)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtNu)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtRefDim)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtVelocity)
        Me.GroupBox1.Location = New System.Drawing.Point(33, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(291, 270)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Inputs"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(21, 201)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(14, 13)
        Me.RadioButton2.TabIndex = 11
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(21, 131)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(14, 13)
        Me.RadioButton1.TabIndex = 10
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(43, 220)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Density [kg/m³]"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtRho
        '
        Me.txtRho.Location = New System.Drawing.Point(176, 217)
        Me.txtRho.Name = "txtRho"
        Me.txtRho.ReadOnly = True
        Me.txtRho.Size = New System.Drawing.Size(99, 20)
        Me.txtRho.TabIndex = 8
        Me.txtRho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(43, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Dynamic viscosity [Pa.s]"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMu
        '
        Me.txtMu.Location = New System.Drawing.Point(176, 182)
        Me.txtMu.Name = "txtMu"
        Me.txtMu.ReadOnly = True
        Me.txtMu.Size = New System.Drawing.Size(99, 20)
        Me.txtMu.TabIndex = 6
        Me.txtMu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Kinematic viscosity [m²/s]"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNu
        '
        Me.txtNu.Location = New System.Drawing.Point(176, 127)
        Me.txtNu.Name = "txtNu"
        Me.txtNu.ReadOnly = True
        Me.txtNu.Size = New System.Drawing.Size(99, 20)
        Me.txtNu.TabIndex = 4
        Me.txtNu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Characteristic length [m]"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtRefDim
        '
        Me.txtRefDim.Location = New System.Drawing.Point(176, 70)
        Me.txtRefDim.Name = "txtRefDim"
        Me.txtRefDim.Size = New System.Drawing.Size(99, 20)
        Me.txtRefDim.TabIndex = 2
        Me.txtRefDim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Velocity [m/s]"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtVelocity
        '
        Me.txtVelocity.Location = New System.Drawing.Point(176, 35)
        Me.txtVelocity.Name = "txtVelocity"
        Me.txtVelocity.Size = New System.Drawing.Size(99, 20)
        Me.txtVelocity.TabIndex = 0
        Me.txtVelocity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtNuTilda)
        Me.TabPage2.Controls.Add(Me.labelNuTilda)
        Me.TabPage2.Controls.Add(Me.btnCalculateTM)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Controls.Add(Me.txtEpsOmega)
        Me.TabPage2.Controls.Add(Me.txtk)
        Me.TabPage2.Controls.Add(Me.labelEpsOmega)
        Me.TabPage2.Controls.Add(Me.labelK)
        Me.TabPage2.Controls.Add(Me.btnInputs2)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.cmdTurbModel)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(356, 535)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Turbulence Model"
        '
        'txtNuTilda
        '
        Me.txtNuTilda.Location = New System.Drawing.Point(222, 479)
        Me.txtNuTilda.Name = "txtNuTilda"
        Me.txtNuTilda.ReadOnly = True
        Me.txtNuTilda.Size = New System.Drawing.Size(100, 20)
        Me.txtNuTilda.TabIndex = 16
        Me.txtNuTilda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtNuTilda.Visible = False
        '
        'labelNuTilda
        '
        Me.labelNuTilda.AutoSize = True
        Me.labelNuTilda.Location = New System.Drawing.Point(33, 482)
        Me.labelNuTilda.Name = "labelNuTilda"
        Me.labelNuTilda.Size = New System.Drawing.Size(132, 13)
        Me.labelNuTilda.TabIndex = 15
        Me.labelNuTilda.Text = "Turbulent vicosity modified"
        Me.labelNuTilda.Visible = False
        '
        'btnCalculateTM
        '
        Me.btnCalculateTM.Location = New System.Drawing.Point(141, 423)
        Me.btnCalculateTM.Name = "btnCalculateTM"
        Me.btnCalculateTM.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculateTM.TabIndex = 12
        Me.btnCalculateTM.Text = "Calculate"
        Me.btnCalculateTM.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.txtC_mu)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.txtl)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.txtI)
        Me.GroupBox4.Location = New System.Drawing.Point(38, 272)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(283, 132)
        Me.GroupBox4.TabIndex = 14
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Inputs 2"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(15, 98)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(87, 13)
        Me.Label20.TabIndex = 12
        Me.Label20.Text = "Coefficient C_mu"
        '
        'txtC_mu
        '
        Me.txtC_mu.Location = New System.Drawing.Point(163, 98)
        Me.txtC_mu.Name = "txtC_mu"
        Me.txtC_mu.Size = New System.Drawing.Size(100, 20)
        Me.txtC_mu.TabIndex = 12
        Me.txtC_mu.Text = "0,09"
        Me.txtC_mu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(15, 61)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(112, 13)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Turbulent length scale"
        '
        'txtl
        '
        Me.txtl.Location = New System.Drawing.Point(163, 61)
        Me.txtl.Name = "txtl"
        Me.txtl.Size = New System.Drawing.Size(100, 20)
        Me.txtl.TabIndex = 11
        Me.txtl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(15, 27)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(125, 13)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Initial turbulence intensity"
        '
        'txtI
        '
        Me.txtI.Location = New System.Drawing.Point(163, 27)
        Me.txtI.Name = "txtI"
        Me.txtI.Size = New System.Drawing.Size(100, 20)
        Me.txtI.TabIndex = 10
        Me.txtI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEpsOmega
        '
        Me.txtEpsOmega.Location = New System.Drawing.Point(222, 495)
        Me.txtEpsOmega.Name = "txtEpsOmega"
        Me.txtEpsOmega.ReadOnly = True
        Me.txtEpsOmega.Size = New System.Drawing.Size(100, 20)
        Me.txtEpsOmega.TabIndex = 14
        Me.txtEpsOmega.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtEpsOmega.Visible = False
        '
        'txtk
        '
        Me.txtk.Location = New System.Drawing.Point(222, 462)
        Me.txtk.Name = "txtk"
        Me.txtk.ReadOnly = True
        Me.txtk.Size = New System.Drawing.Size(100, 20)
        Me.txtk.TabIndex = 13
        Me.txtk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtk.Visible = False
        '
        'labelEpsOmega
        '
        Me.labelEpsOmega.AutoSize = True
        Me.labelEpsOmega.Location = New System.Drawing.Point(35, 500)
        Me.labelEpsOmega.Name = "labelEpsOmega"
        Me.labelEpsOmega.Size = New System.Drawing.Size(134, 13)
        Me.labelEpsOmega.TabIndex = 9
        Me.labelEpsOmega.Text = "Turbulence dissipation rate"
        Me.labelEpsOmega.Visible = False
        '
        'labelK
        '
        Me.labelK.AutoSize = True
        Me.labelK.Location = New System.Drawing.Point(35, 464)
        Me.labelK.Name = "labelK"
        Me.labelK.Size = New System.Drawing.Size(136, 13)
        Me.labelK.TabIndex = 7
        Me.labelK.Text = "Turbulent kinetic energy (k)"
        Me.labelK.Visible = False
        '
        'btnInputs2
        '
        Me.btnInputs2.Location = New System.Drawing.Point(120, 232)
        Me.btnInputs2.Name = "btnInputs2"
        Me.btnInputs2.Size = New System.Drawing.Size(129, 23)
        Me.btnInputs2.TabIndex = 8
        Me.btnInputs2.Text = "Calculate inputs 2"
        Me.btnInputs2.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtReTM)
        Me.GroupBox3.Controls.Add(Me.txtDhTM)
        Me.GroupBox3.Controls.Add(Me.txtVelocityTM)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Location = New System.Drawing.Point(38, 71)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(284, 142)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Inputs"
        '
        'txtReTM
        '
        Me.txtReTM.Location = New System.Drawing.Point(163, 100)
        Me.txtReTM.Name = "txtReTM"
        Me.txtReTM.Size = New System.Drawing.Size(100, 20)
        Me.txtReTM.TabIndex = 9
        Me.txtReTM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDhTM
        '
        Me.txtDhTM.Location = New System.Drawing.Point(163, 66)
        Me.txtDhTM.Name = "txtDhTM"
        Me.txtDhTM.Size = New System.Drawing.Size(100, 20)
        Me.txtDhTM.TabIndex = 8
        Me.txtDhTM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtVelocityTM
        '
        Me.txtVelocityTM.Location = New System.Drawing.Point(163, 28)
        Me.txtVelocityTM.Name = "txtVelocityTM"
        Me.txtVelocityTM.Size = New System.Drawing.Size(100, 20)
        Me.txtVelocityTM.TabIndex = 7
        Me.txtVelocityTM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(15, 35)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(71, 13)
        Me.Label18.TabIndex = 6
        Me.Label18.Text = "Velocity [m/s]"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(15, 69)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(120, 13)
        Me.Label17.TabIndex = 5
        Me.Label17.Text = "Characteristic length [m]"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(15, 103)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(51, 13)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "Reynolds"
        '
        'cmdTurbModel
        '
        Me.cmdTurbModel.FormattingEnabled = True
        Me.cmdTurbModel.Items.AddRange(New Object() {"k-epsilon", "k-omega", "Spalart-Allmaras"})
        Me.cmdTurbModel.Location = New System.Drawing.Point(191, 32)
        Me.cmdTurbModel.Name = "cmdTurbModel"
        Me.cmdTurbModel.Size = New System.Drawing.Size(121, 21)
        Me.cmdTurbModel.TabIndex = 1
        Me.cmdTurbModel.Text = "Select a model"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(53, 35)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(93, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Turbulence Model"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.txtY)
        Me.TabPage3.Controls.Add(Me.cmdCalculateYplus)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.GroupBox2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(356, 535)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Wall Distance (Y+)"
        '
        'txtY
        '
        Me.txtY.Location = New System.Drawing.Point(193, 453)
        Me.txtY.Name = "txtY"
        Me.txtY.ReadOnly = True
        Me.txtY.Size = New System.Drawing.Size(100, 20)
        Me.txtY.TabIndex = 10
        '
        'cmdCalculateYplus
        '
        Me.cmdCalculateYplus.Location = New System.Drawing.Point(141, 362)
        Me.cmdCalculateYplus.Name = "cmdCalculateYplus"
        Me.cmdCalculateYplus.Size = New System.Drawing.Size(75, 23)
        Me.cmdCalculateYplus.TabIndex = 9
        Me.cmdCalculateYplus.Text = "Calculate"
        Me.cmdCalculateYplus.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(64, 456)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Wall Distance [m]"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtMuYplus)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txtYplus)
        Me.GroupBox2.Controls.Add(Me.txtReYplus)
        Me.GroupBox2.Controls.Add(Me.txtRhoYplus)
        Me.GroupBox2.Controls.Add(Me.txtVelocityYplus)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(29, 32)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(299, 255)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Inputs"
        '
        'txtMuYplus
        '
        Me.txtMuYplus.Location = New System.Drawing.Point(161, 108)
        Me.txtMuYplus.Name = "txtMuYplus"
        Me.txtMuYplus.Size = New System.Drawing.Size(100, 20)
        Me.txtMuYplus.TabIndex = 6
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(32, 111)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(122, 13)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Dynamic Viscosity [Pa.s]"
        '
        'txtYplus
        '
        Me.txtYplus.Location = New System.Drawing.Point(161, 177)
        Me.txtYplus.Name = "txtYplus"
        Me.txtYplus.Size = New System.Drawing.Size(100, 20)
        Me.txtYplus.TabIndex = 8
        '
        'txtReYplus
        '
        Me.txtReYplus.Location = New System.Drawing.Point(161, 143)
        Me.txtReYplus.Name = "txtReYplus"
        Me.txtReYplus.Size = New System.Drawing.Size(100, 20)
        Me.txtReYplus.TabIndex = 7
        '
        'txtRhoYplus
        '
        Me.txtRhoYplus.Location = New System.Drawing.Point(161, 75)
        Me.txtRhoYplus.Name = "txtRhoYplus"
        Me.txtRhoYplus.Size = New System.Drawing.Size(100, 20)
        Me.txtRhoYplus.TabIndex = 5
        '
        'txtVelocityYplus
        '
        Me.txtVelocityYplus.Location = New System.Drawing.Point(161, 41)
        Me.txtVelocityYplus.Name = "txtVelocityYplus"
        Me.txtVelocityYplus.Size = New System.Drawing.Size(100, 20)
        Me.txtVelocityYplus.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(32, 180)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Desired Y+"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(32, 146)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Reynolds"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(32, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Density [kg/m³]"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(32, 44)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Velocity [m/s]"
        '
        'main_page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 561)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "main_page"
        Me.Text = "CFD Tools"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents txtReynolds As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNu As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtRefDim As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtVelocity As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label6 As Label
    Friend WithEvents txtRho As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMu As TextBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtYplus As TextBox
    Friend WithEvents txtReYplus As TextBox
    Friend WithEvents txtRhoYplus As TextBox
    Friend WithEvents txtVelocityYplus As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cmdCalculateYplus As Button
    Friend WithEvents txtMuYplus As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtY As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cmdTurbModel As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents labelEpsOmega As Label
    Friend WithEvents labelK As Label
    Friend WithEvents btnInputs2 As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtEpsOmega As TextBox
    Friend WithEvents txtk As TextBox
    Friend WithEvents txtl As TextBox
    Friend WithEvents txtI As TextBox
    Friend WithEvents txtReTM As TextBox
    Friend WithEvents txtDhTM As TextBox
    Friend WithEvents txtVelocityTM As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnCalculateTM As Button
    Friend WithEvents Label20 As Label
    Friend WithEvents txtC_mu As TextBox
    Friend WithEvents txtNuTilda As TextBox
    Friend WithEvents labelNuTilda As Label
End Class
