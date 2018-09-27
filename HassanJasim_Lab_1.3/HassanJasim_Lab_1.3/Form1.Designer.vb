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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMagF1 = New System.Windows.Forms.TextBox()
        Me.txtMagF2 = New System.Windows.Forms.TextBox()
        Me.txtMagF3 = New System.Windows.Forms.TextBox()
        Me.txtAngF1 = New System.Windows.Forms.TextBox()
        Me.txtAngF2 = New System.Windows.Forms.TextBox()
        Me.txtAngF3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Force 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Force 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Force 3"
        '
        'txtMagF1
        '
        Me.txtMagF1.Location = New System.Drawing.Point(168, 51)
        Me.txtMagF1.Name = "txtMagF1"
        Me.txtMagF1.Size = New System.Drawing.Size(100, 22)
        Me.txtMagF1.TabIndex = 3
        '
        'txtMagF2
        '
        Me.txtMagF2.Location = New System.Drawing.Point(168, 106)
        Me.txtMagF2.Name = "txtMagF2"
        Me.txtMagF2.Size = New System.Drawing.Size(100, 22)
        Me.txtMagF2.TabIndex = 4
        '
        'txtMagF3
        '
        Me.txtMagF3.Location = New System.Drawing.Point(168, 161)
        Me.txtMagF3.Name = "txtMagF3"
        Me.txtMagF3.Size = New System.Drawing.Size(100, 22)
        Me.txtMagF3.TabIndex = 5
        '
        'txtAngF1
        '
        Me.txtAngF1.Location = New System.Drawing.Point(353, 51)
        Me.txtAngF1.Name = "txtAngF1"
        Me.txtAngF1.Size = New System.Drawing.Size(100, 22)
        Me.txtAngF1.TabIndex = 6
        '
        'txtAngF2
        '
        Me.txtAngF2.Location = New System.Drawing.Point(353, 106)
        Me.txtAngF2.Name = "txtAngF2"
        Me.txtAngF2.Size = New System.Drawing.Size(100, 22)
        Me.txtAngF2.TabIndex = 7
        '
        'txtAngF3
        '
        Me.txtAngF3.Location = New System.Drawing.Point(353, 161)
        Me.txtAngF3.Name = "txtAngF3"
        Me.txtAngF3.Size = New System.Drawing.Size(100, 22)
        Me.txtAngF3.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(185, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Force (N)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(380, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Angle"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(29, 208)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(205, 23)
        Me.btnCalculate.TabIndex = 11
        Me.btnCalculate.Text = "Calculate Resultant"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(240, 208)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(213, 23)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput.Location = New System.Drawing.Point(29, 238)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(424, 316)
        Me.lblOutput.TabIndex = 13
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(29, 557)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(424, 23)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 589)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtAngF3)
        Me.Controls.Add(Me.txtAngF2)
        Me.Controls.Add(Me.txtAngF1)
        Me.Controls.Add(Me.txtMagF3)
        Me.Controls.Add(Me.txtMagF2)
        Me.Controls.Add(Me.txtMagF1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtMagF1 As System.Windows.Forms.TextBox
    Friend WithEvents txtMagF2 As System.Windows.Forms.TextBox
    Friend WithEvents txtMagF3 As System.Windows.Forms.TextBox
    Friend WithEvents txtAngF1 As System.Windows.Forms.TextBox
    Friend WithEvents txtAngF2 As System.Windows.Forms.TextBox
    Friend WithEvents txtAngF3 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblOutput As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
