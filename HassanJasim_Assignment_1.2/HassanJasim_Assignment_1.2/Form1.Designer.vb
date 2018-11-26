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
        Me.txtLength = New System.Windows.Forms.TextBox()
        Me.txtRadius = New System.Windows.Forms.TextBox()
        Me.txtAcceleration = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lbOutput = New System.Windows.Forms.ListBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Length of Cable (m)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Radius of Cable (m)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Acceleration (m/s2)"
        '
        'txtLength
        '
        Me.txtLength.Location = New System.Drawing.Point(211, 30)
        Me.txtLength.Name = "txtLength"
        Me.txtLength.Size = New System.Drawing.Size(342, 22)
        Me.txtLength.TabIndex = 3
        '
        'txtRadius
        '
        Me.txtRadius.Location = New System.Drawing.Point(211, 74)
        Me.txtRadius.Name = "txtRadius"
        Me.txtRadius.Size = New System.Drawing.Size(342, 22)
        Me.txtRadius.TabIndex = 4
        '
        'txtAcceleration
        '
        Me.txtAcceleration.Location = New System.Drawing.Point(211, 118)
        Me.txtAcceleration.Name = "txtAcceleration"
        Me.txtAcceleration.Size = New System.Drawing.Size(342, 22)
        Me.txtAcceleration.TabIndex = 5
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(33, 153)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(520, 23)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lbOutput
        '
        Me.lbOutput.Font = New System.Drawing.Font("Courier New", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbOutput.FormattingEnabled = True
        Me.lbOutput.ItemHeight = 20
        Me.lbOutput.Location = New System.Drawing.Point(33, 182)
        Me.lbOutput.Name = "lbOutput"
        Me.lbOutput.Size = New System.Drawing.Size(520, 364)
        Me.lbOutput.TabIndex = 7
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(33, 569)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(250, 23)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(303, 569)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(250, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 625)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lbOutput)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtAcceleration)
        Me.Controls.Add(Me.txtRadius)
        Me.Controls.Add(Me.txtLength)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLength As TextBox
    Friend WithEvents txtRadius As TextBox
    Friend WithEvents txtAcceleration As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lbOutput As ListBox
End Class
