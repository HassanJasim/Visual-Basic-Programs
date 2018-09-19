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
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BtnEarth = New System.Windows.Forms.Button()
        Me.BtnMercury = New System.Windows.Forms.Button()
        Me.BtnMars = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMPerS = New System.Windows.Forms.Label()
        Me.txtFtPerS = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(16, 195)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(356, 23)
        Me.BtnExit.TabIndex = 0
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'BtnEarth
        '
        Me.BtnEarth.Location = New System.Drawing.Point(16, 41)
        Me.BtnEarth.Name = "BtnEarth"
        Me.BtnEarth.Size = New System.Drawing.Size(94, 23)
        Me.BtnEarth.TabIndex = 1
        Me.BtnEarth.Text = "Earth"
        Me.BtnEarth.UseVisualStyleBackColor = True
        '
        'BtnMercury
        '
        Me.BtnMercury.Location = New System.Drawing.Point(147, 38)
        Me.BtnMercury.Name = "BtnMercury"
        Me.BtnMercury.Size = New System.Drawing.Size(94, 29)
        Me.BtnMercury.TabIndex = 2
        Me.BtnMercury.Text = "Mercury"
        Me.BtnMercury.UseVisualStyleBackColor = True
        '
        'BtnMars
        '
        Me.BtnMars.Location = New System.Drawing.Point(278, 41)
        Me.BtnMars.Name = "BtnMars"
        Me.BtnMars.Size = New System.Drawing.Size(94, 23)
        Me.BtnMars.TabIndex = 3
        Me.BtnMars.Text = "Mars"
        Me.BtnMars.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(51, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "m/s2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(296, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "ft/s2"
        '
        'txtMPerS
        '
        Me.txtMPerS.AllowDrop = True
        Me.txtMPerS.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtMPerS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtMPerS.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMPerS.Location = New System.Drawing.Point(16, 136)
        Me.txtMPerS.Name = "txtMPerS"
        Me.txtMPerS.Size = New System.Drawing.Size(124, 44)
        Me.txtMPerS.TabIndex = 12
        '
        'txtFtPerS
        '
        Me.txtFtPerS.AllowDrop = True
        Me.txtFtPerS.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtFtPerS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFtPerS.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFtPerS.Location = New System.Drawing.Point(248, 136)
        Me.txtFtPerS.Name = "txtFtPerS"
        Me.txtFtPerS.Size = New System.Drawing.Size(124, 44)
        Me.txtFtPerS.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 255)
        Me.Controls.Add(Me.txtFtPerS)
        Me.Controls.Add(Me.txtMPerS)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnMars)
        Me.Controls.Add(Me.BtnMercury)
        Me.Controls.Add(Me.BtnEarth)
        Me.Controls.Add(Me.BtnExit)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents BtnEarth As System.Windows.Forms.Button
    Friend WithEvents BtnMercury As System.Windows.Forms.Button
    Friend WithEvents BtnMars As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMPerS As System.Windows.Forms.Label
    Friend WithEvents txtFtPerS As System.Windows.Forms.Label

End Class
