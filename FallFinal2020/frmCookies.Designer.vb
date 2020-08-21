<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCookies
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCookies))
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBakeryName = New System.Windows.Forms.TextBox()
        Me.lblHeadingBakeryName = New System.Windows.Forms.Label()
        Me.btnCookie = New System.Windows.Forms.Button()
        Me.lblCookies = New System.Windows.Forms.Label()
        Me.btnUpgrade1 = New System.Windows.Forms.Button()
        Me.btnUpgrade2 = New System.Windows.Forms.Button()
        Me.btnUpgrade3 = New System.Windows.Forms.Button()
        Me.btnUpgrade4 = New System.Windows.Forms.Button()
        Me.btnUpgrade5 = New System.Windows.Forms.Button()
        Me.btnUpgrade6 = New System.Windows.Forms.Button()
        Me.lblUpgradesHeading = New System.Windows.Forms.Label()
        Me.lblCPS = New System.Windows.Forms.Label()
        Me.lblUp1Owned = New System.Windows.Forms.Label()
        Me.lblUp1Cost = New System.Windows.Forms.Label()
        Me.lblUp2Cost = New System.Windows.Forms.Label()
        Me.lblUp2Owned = New System.Windows.Forms.Label()
        Me.lblUp3Cost = New System.Windows.Forms.Label()
        Me.lblUp3Owned = New System.Windows.Forms.Label()
        Me.lblUp4Cost = New System.Windows.Forms.Label()
        Me.lblUp4Owned = New System.Windows.Forms.Label()
        Me.lblUp5Cost = New System.Windows.Forms.Label()
        Me.lblUp5Owned = New System.Windows.Forms.Label()
        Me.lblUp6Cost = New System.Windows.Forms.Label()
        Me.lblUp6Owned = New System.Windows.Forms.Label()
        Me.lblCPC = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.Location = New System.Drawing.Point(172, 136)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(110, 35)
        Me.lblTimer.TabIndex = 2
        Me.lblTimer.Text = "timer"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("OCR A Extended", 19.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(147, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(983, 54)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Cookie Clicker in Visual Basic"
        '
        'txtBakeryName
        '
        Me.txtBakeryName.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBakeryName.Location = New System.Drawing.Point(331, 298)
        Me.txtBakeryName.Name = "txtBakeryName"
        Me.txtBakeryName.Size = New System.Drawing.Size(583, 41)
        Me.txtBakeryName.TabIndex = 4
        Me.txtBakeryName.Text = "Enter Your Bakery Name"
        Me.txtBakeryName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblHeadingBakeryName
        '
        Me.lblHeadingBakeryName.AutoSize = True
        Me.lblHeadingBakeryName.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeadingBakeryName.Location = New System.Drawing.Point(508, 244)
        Me.lblHeadingBakeryName.Name = "lblHeadingBakeryName"
        Me.lblHeadingBakeryName.Size = New System.Drawing.Size(243, 35)
        Me.lblHeadingBakeryName.TabIndex = 5
        Me.lblHeadingBakeryName.Text = "Bakery Name:"
        '
        'btnCookie
        '
        Me.btnCookie.Font = New System.Drawing.Font("OCR A Extended", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCookie.Image = Global.FallFinal2020.My.Resources.Resources.chocolate_chip_cookie
        Me.btnCookie.Location = New System.Drawing.Point(35, 552)
        Me.btnCookie.Name = "btnCookie"
        Me.btnCookie.Size = New System.Drawing.Size(543, 449)
        Me.btnCookie.TabIndex = 6
        Me.btnCookie.Text = "Cookie"
        Me.btnCookie.UseVisualStyleBackColor = True
        '
        'lblCookies
        '
        Me.lblCookies.AutoSize = True
        Me.lblCookies.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCookies.Location = New System.Drawing.Point(231, 391)
        Me.lblCookies.Name = "lblCookies"
        Me.lblCookies.Size = New System.Drawing.Size(155, 35)
        Me.lblCookies.TabIndex = 7
        Me.lblCookies.Text = "Cookies"
        '
        'btnUpgrade1
        '
        Me.btnUpgrade1.Font = New System.Drawing.Font("OCR A Extended", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpgrade1.Location = New System.Drawing.Point(692, 574)
        Me.btnUpgrade1.Name = "btnUpgrade1"
        Me.btnUpgrade1.Size = New System.Drawing.Size(199, 48)
        Me.btnUpgrade1.TabIndex = 8
        Me.btnUpgrade1.Text = "CPS + 1"
        Me.btnUpgrade1.UseVisualStyleBackColor = True
        '
        'btnUpgrade2
        '
        Me.btnUpgrade2.Font = New System.Drawing.Font("OCR A Extended", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpgrade2.Location = New System.Drawing.Point(692, 746)
        Me.btnUpgrade2.Name = "btnUpgrade2"
        Me.btnUpgrade2.Size = New System.Drawing.Size(199, 48)
        Me.btnUpgrade2.TabIndex = 9
        Me.btnUpgrade2.Text = "CPS + 5"
        Me.btnUpgrade2.UseVisualStyleBackColor = True
        '
        'btnUpgrade3
        '
        Me.btnUpgrade3.Font = New System.Drawing.Font("OCR A Extended", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpgrade3.Location = New System.Drawing.Point(692, 951)
        Me.btnUpgrade3.Name = "btnUpgrade3"
        Me.btnUpgrade3.Size = New System.Drawing.Size(199, 48)
        Me.btnUpgrade3.TabIndex = 10
        Me.btnUpgrade3.Text = "CPC + 5"
        Me.btnUpgrade3.UseVisualStyleBackColor = True
        '
        'btnUpgrade4
        '
        Me.btnUpgrade4.Font = New System.Drawing.Font("OCR A Extended", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpgrade4.Location = New System.Drawing.Point(970, 574)
        Me.btnUpgrade4.Name = "btnUpgrade4"
        Me.btnUpgrade4.Size = New System.Drawing.Size(199, 48)
        Me.btnUpgrade4.TabIndex = 11
        Me.btnUpgrade4.Text = "CPS + 10"
        Me.btnUpgrade4.UseVisualStyleBackColor = True
        '
        'btnUpgrade5
        '
        Me.btnUpgrade5.Font = New System.Drawing.Font("OCR A Extended", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpgrade5.Location = New System.Drawing.Point(970, 746)
        Me.btnUpgrade5.Name = "btnUpgrade5"
        Me.btnUpgrade5.Size = New System.Drawing.Size(199, 48)
        Me.btnUpgrade5.TabIndex = 12
        Me.btnUpgrade5.Text = "CPS + 50"
        Me.btnUpgrade5.UseVisualStyleBackColor = True
        '
        'btnUpgrade6
        '
        Me.btnUpgrade6.Font = New System.Drawing.Font("OCR A Extended", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpgrade6.Location = New System.Drawing.Point(970, 951)
        Me.btnUpgrade6.Name = "btnUpgrade6"
        Me.btnUpgrade6.Size = New System.Drawing.Size(199, 84)
        Me.btnUpgrade6.TabIndex = 13
        Me.btnUpgrade6.Text = "CPS + 50" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CPC + 10"
        Me.btnUpgrade6.UseVisualStyleBackColor = True
        '
        'lblUpgradesHeading
        '
        Me.lblUpgradesHeading.AutoSize = True
        Me.lblUpgradesHeading.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpgradesHeading.Location = New System.Drawing.Point(852, 426)
        Me.lblUpgradesHeading.Name = "lblUpgradesHeading"
        Me.lblUpgradesHeading.Size = New System.Drawing.Size(167, 35)
        Me.lblUpgradesHeading.TabIndex = 14
        Me.lblUpgradesHeading.Text = "Upgrades"
        '
        'lblCPS
        '
        Me.lblCPS.AutoSize = True
        Me.lblCPS.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCPS.Location = New System.Drawing.Point(111, 437)
        Me.lblCPS.Name = "lblCPS"
        Me.lblCPS.Size = New System.Drawing.Size(375, 35)
        Me.lblCPS.TabIndex = 15
        Me.lblCPS.Text = "Cookies Per Second"
        '
        'lblUp1Owned
        '
        Me.lblUp1Owned.AutoSize = True
        Me.lblUp1Owned.Font = New System.Drawing.Font("OCR A Extended", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUp1Owned.Location = New System.Drawing.Point(710, 487)
        Me.lblUp1Owned.Name = "lblUp1Owned"
        Me.lblUp1Owned.Size = New System.Drawing.Size(157, 30)
        Me.lblUp1Owned.TabIndex = 16
        Me.lblUp1Owned.Text = "Owned: 0"
        '
        'lblUp1Cost
        '
        Me.lblUp1Cost.AutoSize = True
        Me.lblUp1Cost.Font = New System.Drawing.Font("OCR A Extended", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUp1Cost.Location = New System.Drawing.Point(710, 527)
        Me.lblUp1Cost.Name = "lblUp1Cost"
        Me.lblUp1Cost.Size = New System.Drawing.Size(175, 30)
        Me.lblUp1Cost.TabIndex = 17
        Me.lblUp1Cost.Text = "Cost: 100"
        '
        'lblUp2Cost
        '
        Me.lblUp2Cost.AutoSize = True
        Me.lblUp2Cost.Font = New System.Drawing.Font("OCR A Extended", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUp2Cost.Location = New System.Drawing.Point(710, 699)
        Me.lblUp2Cost.Name = "lblUp2Cost"
        Me.lblUp2Cost.Size = New System.Drawing.Size(175, 30)
        Me.lblUp2Cost.TabIndex = 19
        Me.lblUp2Cost.Text = "Cost: 250"
        '
        'lblUp2Owned
        '
        Me.lblUp2Owned.AutoSize = True
        Me.lblUp2Owned.Font = New System.Drawing.Font("OCR A Extended", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUp2Owned.Location = New System.Drawing.Point(716, 656)
        Me.lblUp2Owned.Name = "lblUp2Owned"
        Me.lblUp2Owned.Size = New System.Drawing.Size(157, 30)
        Me.lblUp2Owned.TabIndex = 18
        Me.lblUp2Owned.Text = "Owned: 0"
        '
        'lblUp3Cost
        '
        Me.lblUp3Cost.AutoSize = True
        Me.lblUp3Cost.Font = New System.Drawing.Font("OCR A Extended", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUp3Cost.Location = New System.Drawing.Point(716, 897)
        Me.lblUp3Cost.Name = "lblUp3Cost"
        Me.lblUp3Cost.Size = New System.Drawing.Size(175, 30)
        Me.lblUp3Cost.TabIndex = 21
        Me.lblUp3Cost.Text = "Cost: 300"
        '
        'lblUp3Owned
        '
        Me.lblUp3Owned.AutoSize = True
        Me.lblUp3Owned.Font = New System.Drawing.Font("OCR A Extended", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUp3Owned.Location = New System.Drawing.Point(734, 855)
        Me.lblUp3Owned.Name = "lblUp3Owned"
        Me.lblUp3Owned.Size = New System.Drawing.Size(157, 30)
        Me.lblUp3Owned.TabIndex = 20
        Me.lblUp3Owned.Text = "Owned: 0"
        '
        'lblUp4Cost
        '
        Me.lblUp4Cost.AutoSize = True
        Me.lblUp4Cost.Font = New System.Drawing.Font("OCR A Extended", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUp4Cost.Location = New System.Drawing.Point(979, 527)
        Me.lblUp4Cost.Name = "lblUp4Cost"
        Me.lblUp4Cost.Size = New System.Drawing.Size(175, 30)
        Me.lblUp4Cost.TabIndex = 23
        Me.lblUp4Cost.Text = "Cost: 500"
        '
        'lblUp4Owned
        '
        Me.lblUp4Owned.AutoSize = True
        Me.lblUp4Owned.Font = New System.Drawing.Font("OCR A Extended", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUp4Owned.Location = New System.Drawing.Point(979, 487)
        Me.lblUp4Owned.Name = "lblUp4Owned"
        Me.lblUp4Owned.Size = New System.Drawing.Size(157, 30)
        Me.lblUp4Owned.TabIndex = 22
        Me.lblUp4Owned.Text = "Owned: 0"
        '
        'lblUp5Cost
        '
        Me.lblUp5Cost.AutoSize = True
        Me.lblUp5Cost.Font = New System.Drawing.Font("OCR A Extended", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUp5Cost.Location = New System.Drawing.Point(976, 699)
        Me.lblUp5Cost.Name = "lblUp5Cost"
        Me.lblUp5Cost.Size = New System.Drawing.Size(193, 30)
        Me.lblUp5Cost.TabIndex = 25
        Me.lblUp5Cost.Text = "Cost: 1000"
        '
        'lblUp5Owned
        '
        Me.lblUp5Owned.AutoSize = True
        Me.lblUp5Owned.Font = New System.Drawing.Font("OCR A Extended", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUp5Owned.Location = New System.Drawing.Point(994, 656)
        Me.lblUp5Owned.Name = "lblUp5Owned"
        Me.lblUp5Owned.Size = New System.Drawing.Size(157, 30)
        Me.lblUp5Owned.TabIndex = 24
        Me.lblUp5Owned.Text = "Owned: 0"
        '
        'lblUp6Cost
        '
        Me.lblUp6Cost.AutoSize = True
        Me.lblUp6Cost.Font = New System.Drawing.Font("OCR A Extended", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUp6Cost.Location = New System.Drawing.Point(976, 906)
        Me.lblUp6Cost.Name = "lblUp6Cost"
        Me.lblUp6Cost.Size = New System.Drawing.Size(193, 30)
        Me.lblUp6Cost.TabIndex = 27
        Me.lblUp6Cost.Text = "Cost: 3000"
        '
        'lblUp6Owned
        '
        Me.lblUp6Owned.AutoSize = True
        Me.lblUp6Owned.Font = New System.Drawing.Font("OCR A Extended", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUp6Owned.Location = New System.Drawing.Point(997, 864)
        Me.lblUp6Owned.Name = "lblUp6Owned"
        Me.lblUp6Owned.Size = New System.Drawing.Size(157, 30)
        Me.lblUp6Owned.TabIndex = 26
        Me.lblUp6Owned.Text = "Owned: 0"
        '
        'lblCPC
        '
        Me.lblCPC.AutoSize = True
        Me.lblCPC.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCPC.Location = New System.Drawing.Point(131, 483)
        Me.lblCPC.Name = "lblCPC"
        Me.lblCPC.Size = New System.Drawing.Size(355, 35)
        Me.lblCPC.TabIndex = 28
        Me.lblCPC.Text = "Cookies Per Click"
        '
        'frmCookies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1252, 1103)
        Me.Controls.Add(Me.lblCPC)
        Me.Controls.Add(Me.lblUp6Cost)
        Me.Controls.Add(Me.lblUp6Owned)
        Me.Controls.Add(Me.lblUp5Cost)
        Me.Controls.Add(Me.lblUp5Owned)
        Me.Controls.Add(Me.lblUp4Cost)
        Me.Controls.Add(Me.lblUp4Owned)
        Me.Controls.Add(Me.lblUp3Cost)
        Me.Controls.Add(Me.lblUp3Owned)
        Me.Controls.Add(Me.lblUp2Cost)
        Me.Controls.Add(Me.lblUp2Owned)
        Me.Controls.Add(Me.lblUp1Cost)
        Me.Controls.Add(Me.lblUp1Owned)
        Me.Controls.Add(Me.lblCPS)
        Me.Controls.Add(Me.lblUpgradesHeading)
        Me.Controls.Add(Me.btnUpgrade6)
        Me.Controls.Add(Me.btnUpgrade5)
        Me.Controls.Add(Me.btnUpgrade4)
        Me.Controls.Add(Me.btnUpgrade3)
        Me.Controls.Add(Me.btnUpgrade2)
        Me.Controls.Add(Me.btnUpgrade1)
        Me.Controls.Add(Me.lblCookies)
        Me.Controls.Add(Me.btnCookie)
        Me.Controls.Add(Me.lblHeadingBakeryName)
        Me.Controls.Add(Me.txtBakeryName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTimer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCookies"
        Me.Text = "Cookie Clicker in Visual Basic"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTimer As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBakeryName As TextBox
    Friend WithEvents lblHeadingBakeryName As Label
    Friend WithEvents btnCookie As Button
    Friend WithEvents lblCookies As Label
    Friend WithEvents btnUpgrade1 As Button
    Friend WithEvents btnUpgrade2 As Button
    Friend WithEvents btnUpgrade3 As Button
    Friend WithEvents btnUpgrade5 As Button
    Friend WithEvents btnUpgrade6 As Button
    Friend WithEvents lblUpgradesHeading As Label
    Friend WithEvents btnUpgrade4 As Button
    Friend WithEvents lblCPS As Label
    Friend WithEvents lblUp1Owned As Label
    Friend WithEvents lblUp1Cost As Label
    Friend WithEvents lblUp2Cost As Label
    Friend WithEvents lblUp2Owned As Label
    Friend WithEvents lblUp3Cost As Label
    Friend WithEvents lblUp3Owned As Label
    Friend WithEvents lblUp4Cost As Label
    Friend WithEvents lblUp4Owned As Label
    Friend WithEvents lblUp5Cost As Label
    Friend WithEvents lblUp5Owned As Label
    Friend WithEvents lblUp6Cost As Label
    Friend WithEvents lblUp6Owned As Label
    Friend WithEvents lblCPC As Label
End Class
