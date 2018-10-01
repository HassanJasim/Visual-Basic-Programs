<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMassP = New System.Windows.Forms.TextBox()
        Me.txtMassO = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdb500 = New System.Windows.Forms.RadioButton()
        Me.rdb100 = New System.Windows.Forms.RadioButton()
        Me.rdbOnPlanet = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter the Mass of Planet (kg)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(217, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter the Mass of the Object (kg)"
        '
        'txtMassP
        '
        Me.txtMassP.Location = New System.Drawing.Point(259, 30)
        Me.txtMassP.Name = "txtMassP"
        Me.txtMassP.Size = New System.Drawing.Size(211, 22)
        Me.txtMassP.TabIndex = 3
        '
        'txtMassO
        '
        Me.txtMassO.Location = New System.Drawing.Point(259, 82)
        Me.txtMassO.Name = "txtMassO"
        Me.txtMassO.Size = New System.Drawing.Size(211, 22)
        Me.txtMassO.TabIndex = 4
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(32, 225)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(438, 27)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate &Weight"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(32, 426)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(214, 28)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(252, 426)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(218, 28)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput.Location = New System.Drawing.Point(32, 255)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(438, 168)
        Me.lblOutput.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdb500)
        Me.GroupBox1.Controls.Add(Me.rdb100)
        Me.GroupBox1.Controls.Add(Me.rdbOnPlanet)
        Me.GroupBox1.Location = New System.Drawing.Point(32, 133)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(438, 86)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Choose Distance above the Planet"
        '
        'rdb500
        '
        Me.rdb500.AutoSize = True
        Me.rdb500.Location = New System.Drawing.Point(312, 38)
        Me.rdb500.Name = "rdb500"
        Me.rdb500.Size = New System.Drawing.Size(71, 21)
        Me.rdb500.TabIndex = 2
        Me.rdb500.TabStop = True
        Me.rdb500.Text = "500km"
        Me.rdb500.UseVisualStyleBackColor = True
        '
        'rdb100
        '
        Me.rdb100.AutoSize = True
        Me.rdb100.Location = New System.Drawing.Point(196, 39)
        Me.rdb100.Name = "rdb100"
        Me.rdb100.Size = New System.Drawing.Size(71, 21)
        Me.rdb100.TabIndex = 1
        Me.rdb100.TabStop = True
        Me.rdb100.Text = "100km"
        Me.rdb100.UseVisualStyleBackColor = True
        '
        'rdbOnPlanet
        '
        Me.rdbOnPlanet.AutoSize = True
        Me.rdbOnPlanet.Location = New System.Drawing.Point(35, 40)
        Me.rdbOnPlanet.Name = "rdbOnPlanet"
        Me.rdbOnPlanet.Size = New System.Drawing.Size(116, 21)
        Me.rdbOnPlanet.TabIndex = 0
        Me.rdbOnPlanet.TabStop = True
        Me.rdbOnPlanet.Text = "On the Planet"
        Me.rdbOnPlanet.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 470)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtMassO)
        Me.Controls.Add(Me.txtMassP)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMassP As System.Windows.Forms.TextBox
    Friend WithEvents txtMassO As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblOutput As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdb500 As System.Windows.Forms.RadioButton
    Friend WithEvents rdb100 As System.Windows.Forms.RadioButton
    Friend WithEvents rdbOnPlanet As System.Windows.Forms.RadioButton

End Class
