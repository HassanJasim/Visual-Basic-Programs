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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMass = New System.Windows.Forms.TextBox()
        Me.txtVelocity = New System.Windows.Forms.TextBox()
        Me.txtRaduis = New System.Windows.Forms.TextBox()
        Me.txtCharge = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblOuput = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mass (kg)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Velocity (m/s)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Raduis (m)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Charge"
        '
        'txtMass
        '
        Me.txtMass.Location = New System.Drawing.Point(145, 23)
        Me.txtMass.Name = "txtMass"
        Me.txtMass.Size = New System.Drawing.Size(233, 22)
        Me.txtMass.TabIndex = 4
        '
        'txtVelocity
        '
        Me.txtVelocity.Location = New System.Drawing.Point(145, 62)
        Me.txtVelocity.Name = "txtVelocity"
        Me.txtVelocity.Size = New System.Drawing.Size(233, 22)
        Me.txtVelocity.TabIndex = 5
        '
        'txtRaduis
        '
        Me.txtRaduis.Location = New System.Drawing.Point(145, 101)
        Me.txtRaduis.Name = "txtRaduis"
        Me.txtRaduis.Size = New System.Drawing.Size(233, 22)
        Me.txtRaduis.TabIndex = 6
        '
        'txtCharge
        '
        Me.txtCharge.Location = New System.Drawing.Point(145, 140)
        Me.txtCharge.Name = "txtCharge"
        Me.txtCharge.Size = New System.Drawing.Size(233, 22)
        Me.txtCharge.TabIndex = 7
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(28, 184)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(350, 28)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "Calculate Magnetic Field"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblOuput
        '
        Me.lblOuput.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblOuput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOuput.Location = New System.Drawing.Point(28, 237)
        Me.lblOuput.Name = "lblOuput"
        Me.lblOuput.Size = New System.Drawing.Size(350, 224)
        Me.lblOuput.TabIndex = 9
        '
        'btnExit
        '
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExit.Location = New System.Drawing.Point(28, 477)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(350, 25)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 517)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblOuput)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtCharge)
        Me.Controls.Add(Me.txtRaduis)
        Me.Controls.Add(Me.txtVelocity)
        Me.Controls.Add(Me.txtMass)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtMass As System.Windows.Forms.TextBox
    Friend WithEvents txtVelocity As System.Windows.Forms.TextBox
    Friend WithEvents txtRaduis As System.Windows.Forms.TextBox
    Friend WithEvents txtCharge As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lblOuput As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
