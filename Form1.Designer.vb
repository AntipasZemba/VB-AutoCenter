<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtFirstNam = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtBase = New System.Windows.Forms.TextBox()
        Me.lblAF = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.txtTrade = New System.Windows.Forms.TextBox()
        Me.lblAmtDue = New System.Windows.Forms.Label()
        Me.chckStereo = New System.Windows.Forms.CheckBox()
        Me.chckLeather = New System.Windows.Forms.CheckBox()
        Me.chckNavigation = New System.Windows.Forms.CheckBox()
        Me.radStandard = New System.Windows.Forms.RadioButton()
        Me.radPearlized = New System.Windows.Forms.RadioButton()
        Me.radCustom = New System.Windows.Forms.RadioButton()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(242, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(242, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Last Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(242, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Base Price:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(242, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Accessories and Finish:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(242, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Sales Tax:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(242, 189)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Subtotal:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(242, 230)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Trade In Allowance:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(242, 261)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Amount Due:"
        '
        'txtFirstNam
        '
        Me.txtFirstNam.Location = New System.Drawing.Point(388, 27)
        Me.txtFirstNam.Name = "txtFirstNam"
        Me.txtFirstNam.Size = New System.Drawing.Size(105, 20)
        Me.txtFirstNam.TabIndex = 8
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(388, 53)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(105, 20)
        Me.txtLastName.TabIndex = 9
        '
        'txtBase
        '
        Me.txtBase.Location = New System.Drawing.Point(388, 79)
        Me.txtBase.Name = "txtBase"
        Me.txtBase.Size = New System.Drawing.Size(105, 20)
        Me.txtBase.TabIndex = 10
        '
        'lblAF
        '
        Me.lblAF.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAF.Location = New System.Drawing.Point(388, 125)
        Me.lblAF.Name = "lblAF"
        Me.lblAF.Size = New System.Drawing.Size(105, 19)
        Me.lblAF.TabIndex = 11
        '
        'lblTax
        '
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTax.Location = New System.Drawing.Point(388, 154)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(105, 19)
        Me.lblTax.TabIndex = 12
        '
        'lblSubtotal
        '
        Me.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSubtotal.Location = New System.Drawing.Point(388, 183)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(105, 19)
        Me.lblSubtotal.TabIndex = 13
        '
        'txtTrade
        '
        Me.txtTrade.Location = New System.Drawing.Point(388, 223)
        Me.txtTrade.Name = "txtTrade"
        Me.txtTrade.Size = New System.Drawing.Size(105, 20)
        Me.txtTrade.TabIndex = 14
        '
        'lblAmtDue
        '
        Me.lblAmtDue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAmtDue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmtDue.Location = New System.Drawing.Point(388, 255)
        Me.lblAmtDue.Name = "lblAmtDue"
        Me.lblAmtDue.Size = New System.Drawing.Size(105, 19)
        Me.lblAmtDue.TabIndex = 15
        '
        'chckStereo
        '
        Me.chckStereo.AutoSize = True
        Me.chckStereo.Location = New System.Drawing.Point(69, 87)
        Me.chckStereo.Name = "chckStereo"
        Me.chckStereo.Size = New System.Drawing.Size(57, 17)
        Me.chckStereo.TabIndex = 16
        Me.chckStereo.Text = "Stereo"
        Me.chckStereo.UseVisualStyleBackColor = True
        '
        'chckLeather
        '
        Me.chckLeather.AutoSize = True
        Me.chckLeather.Location = New System.Drawing.Point(69, 110)
        Me.chckLeather.Name = "chckLeather"
        Me.chckLeather.Size = New System.Drawing.Size(97, 17)
        Me.chckLeather.TabIndex = 17
        Me.chckLeather.Text = "Leather Interior"
        Me.chckLeather.UseVisualStyleBackColor = True
        '
        'chckNavigation
        '
        Me.chckNavigation.AutoSize = True
        Me.chckNavigation.Location = New System.Drawing.Point(69, 135)
        Me.chckNavigation.Name = "chckNavigation"
        Me.chckNavigation.Size = New System.Drawing.Size(77, 17)
        Me.chckNavigation.TabIndex = 18
        Me.chckNavigation.Text = "Navigation"
        Me.chckNavigation.UseVisualStyleBackColor = True
        '
        'radStandard
        '
        Me.radStandard.AutoSize = True
        Me.radStandard.Location = New System.Drawing.Point(69, 182)
        Me.radStandard.Name = "radStandard"
        Me.radStandard.Size = New System.Drawing.Size(68, 17)
        Me.radStandard.TabIndex = 19
        Me.radStandard.TabStop = True
        Me.radStandard.Text = "Standard"
        Me.radStandard.UseVisualStyleBackColor = True
        '
        'radPearlized
        '
        Me.radPearlized.AutoSize = True
        Me.radPearlized.Location = New System.Drawing.Point(69, 205)
        Me.radPearlized.Name = "radPearlized"
        Me.radPearlized.Size = New System.Drawing.Size(68, 17)
        Me.radPearlized.TabIndex = 20
        Me.radPearlized.TabStop = True
        Me.radPearlized.Text = "Pearlized"
        Me.radPearlized.UseVisualStyleBackColor = True
        '
        'radCustom
        '
        Me.radCustom.AutoSize = True
        Me.radCustom.Location = New System.Drawing.Point(69, 228)
        Me.radCustom.Name = "radCustom"
        Me.radCustom.Size = New System.Drawing.Size(60, 17)
        Me.radCustom.TabIndex = 21
        Me.radCustom.TabStop = True
        Me.radCustom.Text = "Custom"
        Me.radCustom.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(101, 323)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 22
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(228, 323)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 23
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnExit.Location = New System.Drawing.Point(358, 323)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 24
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(40, 64)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 13)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Accessories"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(40, 166)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 13)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Finish"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(539, 379)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.radCustom)
        Me.Controls.Add(Me.radPearlized)
        Me.Controls.Add(Me.radStandard)
        Me.Controls.Add(Me.chckNavigation)
        Me.Controls.Add(Me.chckLeather)
        Me.Controls.Add(Me.chckStereo)
        Me.Controls.Add(Me.lblAmtDue)
        Me.Controls.Add(Me.txtTrade)
        Me.Controls.Add(Me.lblSubtotal)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblAF)
        Me.Controls.Add(Me.txtBase)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstNam)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VB Auto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtFirstNam As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtBase As TextBox
    Friend WithEvents lblAF As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents txtTrade As TextBox
    Friend WithEvents lblAmtDue As Label
    Friend WithEvents chckStereo As CheckBox
    Friend WithEvents chckLeather As CheckBox
    Friend WithEvents chckNavigation As CheckBox
    Friend WithEvents radStandard As RadioButton
    Friend WithEvents radPearlized As RadioButton
    Friend WithEvents radCustom As RadioButton
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
End Class
