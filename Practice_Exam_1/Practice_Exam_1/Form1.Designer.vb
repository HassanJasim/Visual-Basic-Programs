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
        Me.lstAngle = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rad3 = New System.Windows.Forms.RadioButton()
        Me.rad1 = New System.Windows.Forms.RadioButton()
        Me.rad5 = New System.Windows.Forms.RadioButton()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.btnSine = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstAngle
        '
        Me.lstAngle.FormattingEnabled = True
        Me.lstAngle.ItemHeight = 16
        Me.lstAngle.Location = New System.Drawing.Point(13, 13)
        Me.lstAngle.Name = "lstAngle"
        Me.lstAngle.Size = New System.Drawing.Size(83, 228)
        Me.lstAngle.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rad5)
        Me.GroupBox1.Controls.Add(Me.rad1)
        Me.GroupBox1.Controls.Add(Me.rad3)
        Me.GroupBox1.Location = New System.Drawing.Point(112, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(366, 77)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "K-Value"
        '
        'rad3
        '
        Me.rad3.AutoSize = True
        Me.rad3.Location = New System.Drawing.Point(166, 39)
        Me.rad3.Name = "rad3"
        Me.rad3.Size = New System.Drawing.Size(37, 21)
        Me.rad3.TabIndex = 0
        Me.rad3.TabStop = True
        Me.rad3.Text = "3"
        Me.rad3.UseVisualStyleBackColor = True
        '
        'rad1
        '
        Me.rad1.AutoSize = True
        Me.rad1.Location = New System.Drawing.Point(38, 39)
        Me.rad1.Name = "rad1"
        Me.rad1.Size = New System.Drawing.Size(37, 21)
        Me.rad1.TabIndex = 1
        Me.rad1.TabStop = True
        Me.rad1.Text = "1"
        Me.rad1.UseVisualStyleBackColor = True
        '
        'rad5
        '
        Me.rad5.AutoSize = True
        Me.rad5.Location = New System.Drawing.Point(299, 39)
        Me.rad5.Name = "rad5"
        Me.rad5.Size = New System.Drawing.Size(37, 21)
        Me.rad5.TabIndex = 2
        Me.rad5.TabStop = True
        Me.rad5.Text = "5"
        Me.rad5.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput.Location = New System.Drawing.Point(112, 97)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(366, 144)
        Me.lblOutput.TabIndex = 2
        '
        'btnSine
        '
        Me.btnSine.Location = New System.Drawing.Point(13, 257)
        Me.btnSine.Name = "btnSine"
        Me.btnSine.Size = New System.Drawing.Size(200, 32)
        Me.btnSine.TabIndex = 3
        Me.btnSine.Text = "Sine"
        Me.btnSine.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(278, 257)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(200, 32)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 301)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSine)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lstAngle)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstAngle As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rad5 As RadioButton
    Friend WithEvents rad1 As RadioButton
    Friend WithEvents rad3 As RadioButton
    Friend WithEvents lblOutput As Label
    Friend WithEvents btnSine As Button
    Friend WithEvents btnExit As Button
End Class
