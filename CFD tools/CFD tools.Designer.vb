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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
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
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.cmdCalculateYplus = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtY = New System.Windows.Forms.TextBox()
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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
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
        Me.TabControl1.Size = New System.Drawing.Size(661, 637)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.txtReynolds)
        Me.TabPage1.Controls.Add(Me.btnCalculate)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(653, 611)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Reynolds Number"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(74, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(239, 120)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'txtReynolds
        '
        Me.txtReynolds.Location = New System.Drawing.Point(189, 482)
        Me.txtReynolds.Name = "txtReynolds"
        Me.txtReynolds.ReadOnly = True
        Me.txtReynolds.Size = New System.Drawing.Size(99, 20)
        Me.txtReynolds.TabIndex = 9
        Me.txtReynolds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(124, 439)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 12
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(56, 485)
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
        Me.GroupBox1.Location = New System.Drawing.Point(38, 135)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(291, 270)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Inputs"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(21, 206)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(14, 13)
        Me.RadioButton2.TabIndex = 11
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(21, 138)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(14, 13)
        Me.RadioButton1.TabIndex = 10
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(43, 225)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Density [kg/m³]"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtRho
        '
        Me.txtRho.Location = New System.Drawing.Point(176, 222)
        Me.txtRho.Name = "txtRho"
        Me.txtRho.Size = New System.Drawing.Size(99, 20)
        Me.txtRho.TabIndex = 8
        Me.txtRho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(43, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Dynamic viscosity [Pa.s]"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMu
        '
        Me.txtMu.Location = New System.Drawing.Point(176, 187)
        Me.txtMu.Name = "txtMu"
        Me.txtMu.Size = New System.Drawing.Size(99, 20)
        Me.txtMu.TabIndex = 6
        Me.txtMu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Kinematic viscosity [m²/s]"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNu
        '
        Me.txtNu.Location = New System.Drawing.Point(176, 134)
        Me.txtNu.Name = "txtNu"
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
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(653, 611)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Turbulence Model"
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
        Me.TabPage3.Size = New System.Drawing.Size(653, 611)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Wall Distance (Y+)"
        '
        'cmdCalculateYplus
        '
        Me.cmdCalculateYplus.Location = New System.Drawing.Point(141, 320)
        Me.cmdCalculateYplus.Name = "cmdCalculateYplus"
        Me.cmdCalculateYplus.Size = New System.Drawing.Size(75, 23)
        Me.cmdCalculateYplus.TabIndex = 9
        Me.cmdCalculateYplus.Text = "Calculate"
        Me.cmdCalculateYplus.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(70, 377)
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
        Me.GroupBox2.Location = New System.Drawing.Point(38, 32)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(299, 255)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Inputs"
        '
        'txtY
        '
        Me.txtY.Location = New System.Drawing.Point(199, 374)
        Me.txtY.Name = "txtY"
        Me.txtY.ReadOnly = True
        Me.txtY.Size = New System.Drawing.Size(100, 20)
        Me.txtY.TabIndex = 10
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
        Me.ClientSize = New System.Drawing.Size(661, 637)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "main_page"
        Me.Text = "CFD Tools"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
    Friend WithEvents PictureBox1 As PictureBox
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
End Class
