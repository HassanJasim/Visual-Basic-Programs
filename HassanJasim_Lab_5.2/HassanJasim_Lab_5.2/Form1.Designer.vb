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
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnMakeCall = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(39, 47)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(466, 22)
        Me.txtPhoneNumber.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(172, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Please enter your phone number"
        '
        'btnMakeCall
        '
        Me.btnMakeCall.Location = New System.Drawing.Point(39, 76)
        Me.btnMakeCall.Name = "btnMakeCall"
        Me.btnMakeCall.Size = New System.Drawing.Size(466, 23)
        Me.btnMakeCall.TabIndex = 2
        Me.btnMakeCall.Text = "Call Me"
        Me.btnMakeCall.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(39, 289)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(229, 23)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(274, 289)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(231, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.Location = New System.Drawing.Point(39, 106)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(466, 168)
        Me.lblOutput.TabIndex = 5
        Me.lblOutput.Text = "                       Enter your Number in the following format" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "               " &
    "                               (xxx) xxx-xxxx"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 327)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnMakeCall)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPhoneNumber)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnMakeCall As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblOutput As Label
End Class
