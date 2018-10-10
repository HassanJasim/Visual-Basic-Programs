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
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnValidate = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(38, 51)
        Me.txtInput.MaxLength = 12
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(422, 22)
        Me.txtInput.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(133, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(239, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Please enter the product code below"
        '
        'btnValidate
        '
        Me.btnValidate.Location = New System.Drawing.Point(38, 89)
        Me.btnValidate.Name = "btnValidate"
        Me.btnValidate.Size = New System.Drawing.Size(422, 23)
        Me.btnValidate.TabIndex = 2
        Me.btnValidate.Text = "Validate"
        Me.btnValidate.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.BackColor = System.Drawing.SystemColors.Control
        Me.lblOutput.Location = New System.Drawing.Point(38, 126)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(422, 168)
        Me.lblOutput.TabIndex = 3
        Me.lblOutput.Text = "At least 7 characters, and no more than 12 characters" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "The first character must b" &
    "e A, M or P, either upper case or lower case" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "All other characters must be numer" &
    "ic (0 through 9)"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(38, 297)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(204, 23)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(256, 297)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(204, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 335)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.btnValidate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtInput)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtInput As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnValidate As Button
    Friend WithEvents lblOutput As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
