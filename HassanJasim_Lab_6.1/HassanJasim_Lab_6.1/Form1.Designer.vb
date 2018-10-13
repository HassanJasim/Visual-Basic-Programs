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
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(236, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please enter the length of the array "
        '
        'lblOutput
        '
        Me.lblOutput.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput.Location = New System.Drawing.Point(37, 132)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(448, 264)
        Me.lblOutput.TabIndex = 1
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(37, 79)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(121, 23)
        Me.btnGenerate.TabIndex = 2
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(216, 79)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(110, 23)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(375, 79)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(110, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(375, 28)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(110, 22)
        Me.txtInput.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 421)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblOutput As Label
    Friend WithEvents btnGenerate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtInput As TextBox
End Class
