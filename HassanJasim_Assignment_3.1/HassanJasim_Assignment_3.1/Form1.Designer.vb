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
        Me.Options = New System.Windows.Forms.GroupBox()
        Me.radFile = New System.Windows.Forms.RadioButton()
        Me.rad2D = New System.Windows.Forms.RadioButton()
        Me.radInput = New System.Windows.Forms.RadioButton()
        Me.rad1D = New System.Windows.Forms.RadioButton()
        Me.btnEstimate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.Options.SuspendLayout()
        Me.SuspendLayout()
        '
        'Options
        '
        Me.Options.Controls.Add(Me.radFile)
        Me.Options.Controls.Add(Me.rad2D)
        Me.Options.Controls.Add(Me.radInput)
        Me.Options.Controls.Add(Me.rad1D)
        Me.Options.Location = New System.Drawing.Point(12, 12)
        Me.Options.Name = "Options"
        Me.Options.Size = New System.Drawing.Size(234, 92)
        Me.Options.TabIndex = 0
        Me.Options.TabStop = False
        Me.Options.Text = "Options"
        '
        'radFile
        '
        Me.radFile.AutoSize = True
        Me.radFile.Location = New System.Drawing.Point(137, 50)
        Me.radFile.Name = "radFile"
        Me.radFile.Size = New System.Drawing.Size(86, 21)
        Me.radFile.TabIndex = 3
        Me.radFile.TabStop = True
        Me.radFile.Text = "File Input"
        Me.radFile.UseVisualStyleBackColor = True
        '
        'rad2D
        '
        Me.rad2D.AutoSize = True
        Me.rad2D.Location = New System.Drawing.Point(137, 22)
        Me.rad2D.Name = "rad2D"
        Me.rad2D.Size = New System.Drawing.Size(85, 21)
        Me.rad2D.TabIndex = 2
        Me.rad2D.TabStop = True
        Me.rad2D.Text = "2D Array"
        Me.rad2D.UseVisualStyleBackColor = True
        '
        'radInput
        '
        Me.radInput.AutoSize = True
        Me.radInput.Location = New System.Drawing.Point(16, 50)
        Me.radInput.Name = "radInput"
        Me.radInput.Size = New System.Drawing.Size(107, 21)
        Me.radInput.TabIndex = 1
        Me.radInput.TabStop = True
        Me.radInput.Text = "Input Values"
        Me.radInput.UseVisualStyleBackColor = True
        '
        'rad1D
        '
        Me.rad1D.AutoSize = True
        Me.rad1D.Location = New System.Drawing.Point(16, 22)
        Me.rad1D.Name = "rad1D"
        Me.rad1D.Size = New System.Drawing.Size(85, 21)
        Me.rad1D.TabIndex = 0
        Me.rad1D.TabStop = True
        Me.rad1D.Text = "1D Array"
        Me.rad1D.UseVisualStyleBackColor = True
        '
        'btnEstimate
        '
        Me.btnEstimate.Location = New System.Drawing.Point(252, 19)
        Me.btnEstimate.Name = "btnEstimate"
        Me.btnEstimate.Size = New System.Drawing.Size(75, 85)
        Me.btnEstimate.TabIndex = 1
        Me.btnEstimate.Text = "Estimate"
        Me.btnEstimate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(333, 62)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 42)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(333, 19)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 37)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblDisplay
        '
        Me.lblDisplay.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDisplay.Location = New System.Drawing.Point(13, 111)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(395, 217)
        Me.lblDisplay.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 340)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnEstimate)
        Me.Controls.Add(Me.Options)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Options.ResumeLayout(False)
        Me.Options.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Options As GroupBox
    Friend WithEvents radFile As RadioButton
    Friend WithEvents rad2D As RadioButton
    Friend WithEvents radInput As RadioButton
    Friend WithEvents rad1D As RadioButton
    Friend WithEvents btnEstimate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblDisplay As Label
End Class
