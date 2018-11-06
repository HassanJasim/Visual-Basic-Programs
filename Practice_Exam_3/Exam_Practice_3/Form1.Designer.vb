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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkAcceleration = New System.Windows.Forms.CheckBox()
        Me.chkDisplacment = New System.Windows.Forms.CheckBox()
        Me.chkVelocity = New System.Windows.Forms.CheckBox()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkVelocity)
        Me.GroupBox1.Controls.Add(Me.chkDisplacment)
        Me.GroupBox1.Controls.Add(Me.chkAcceleration)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(610, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selection"
        '
        'chkAcceleration
        '
        Me.chkAcceleration.AutoSize = True
        Me.chkAcceleration.Location = New System.Drawing.Point(28, 40)
        Me.chkAcceleration.Name = "chkAcceleration"
        Me.chkAcceleration.Size = New System.Drawing.Size(108, 21)
        Me.chkAcceleration.TabIndex = 0
        Me.chkAcceleration.Text = "Acceleration"
        Me.chkAcceleration.UseVisualStyleBackColor = True
        '
        'chkDisplacment
        '
        Me.chkDisplacment.AutoSize = True
        Me.chkDisplacment.Location = New System.Drawing.Point(248, 40)
        Me.chkDisplacment.Name = "chkDisplacment"
        Me.chkDisplacment.Size = New System.Drawing.Size(107, 21)
        Me.chkDisplacment.TabIndex = 1
        Me.chkDisplacment.Text = "Displacment"
        Me.chkDisplacment.UseVisualStyleBackColor = True
        '
        'chkVelocity
        '
        Me.chkVelocity.AutoSize = True
        Me.chkVelocity.Location = New System.Drawing.Point(500, 40)
        Me.chkVelocity.Name = "chkVelocity"
        Me.chkVelocity.Size = New System.Drawing.Size(79, 21)
        Me.chkVelocity.TabIndex = 2
        Me.chkVelocity.Text = "Velocity"
        Me.chkVelocity.UseVisualStyleBackColor = True
        '
        'lblDisplay
        '
        Me.lblDisplay.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDisplay.Location = New System.Drawing.Point(13, 120)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(610, 350)
        Me.lblDisplay.TabIndex = 1
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(13, 482)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(178, 32)
        Me.btnCreate.TabIndex = 2
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(229, 482)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(178, 32)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(445, 482)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(178, 32)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 529)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkVelocity As CheckBox
    Friend WithEvents chkDisplacment As CheckBox
    Friend WithEvents chkAcceleration As CheckBox
    Friend WithEvents lblDisplay As Label
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
End Class
