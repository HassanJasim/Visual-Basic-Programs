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
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.txtSize = New System.Windows.Forms.TextBox()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.chkXe = New System.Windows.Forms.CheckBox()
        Me.chkXo = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'txtA
        '
        Me.txtA.Location = New System.Drawing.Point(12, 30)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(100, 22)
        Me.txtA.TabIndex = 0
        '
        'txtSize
        '
        Me.txtSize.Location = New System.Drawing.Point(390, 30)
        Me.txtSize.Name = "txtSize"
        Me.txtSize.Size = New System.Drawing.Size(100, 22)
        Me.txtSize.TabIndex = 2
        '
        'txtB
        '
        Me.txtB.Location = New System.Drawing.Point(205, 30)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(100, 22)
        Me.txtB.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "A"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(247, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "B"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(418, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Size"
        '
        'lblDisplay
        '
        Me.lblDisplay.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDisplay.Location = New System.Drawing.Point(9, 70)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(481, 164)
        Me.lblDisplay.TabIndex = 6
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(9, 237)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(103, 39)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(372, 237)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(118, 39)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'chkXe
        '
        Me.chkXe.AutoSize = True
        Me.chkXe.Location = New System.Drawing.Point(137, 247)
        Me.chkXe.Name = "chkXe"
        Me.chkXe.Size = New System.Drawing.Size(47, 21)
        Me.chkXe.TabIndex = 3
        Me.chkXe.Text = "Xe"
        Me.chkXe.UseVisualStyleBackColor = True
        '
        'chkXo
        '
        Me.chkXo.AutoSize = True
        Me.chkXo.Location = New System.Drawing.Point(274, 247)
        Me.chkXo.Name = "chkXo"
        Me.chkXo.Size = New System.Drawing.Size(47, 21)
        Me.chkXo.TabIndex = 4
        Me.chkXo.Text = "Xo"
        Me.chkXo.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 288)
        Me.Controls.Add(Me.chkXo)
        Me.Controls.Add(Me.chkXe)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.txtSize)
        Me.Controls.Add(Me.txtA)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtA As TextBox
    Friend WithEvents txtSize As TextBox
    Friend WithEvents txtB As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblDisplay As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents chkXe As CheckBox
    Friend WithEvents chkXo As CheckBox
End Class
