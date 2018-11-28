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
        Me.combxSelect = New System.Windows.Forms.ComboBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnProduce = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'combxSelect
        '
        Me.combxSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combxSelect.FormattingEnabled = True
        Me.combxSelect.Location = New System.Drawing.Point(263, 62)
        Me.combxSelect.Name = "combxSelect"
        Me.combxSelect.Size = New System.Drawing.Size(71, 24)
        Me.combxSelect.TabIndex = 0
        '
        'lblOutput
        '
        Me.lblOutput.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput.Location = New System.Drawing.Point(40, 162)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(527, 260)
        Me.lblOutput.TabIndex = 1
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(40, 426)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(261, 27)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(306, 426)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(261, 27)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(135, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(323, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Pick a number to produce a multiplication table for"
        '
        'btnProduce
        '
        Me.btnProduce.Location = New System.Drawing.Point(40, 125)
        Me.btnProduce.Name = "btnProduce"
        Me.btnProduce.Size = New System.Drawing.Size(527, 34)
        Me.btnProduce.TabIndex = 5
        Me.btnProduce.Text = "&Produce Multiplication Table"
        Me.btnProduce.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 482)
        Me.Controls.Add(Me.btnProduce)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.combxSelect)
        Me.Name = "Form1"
        Me.Text = " Multiplication Practice"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents combxSelect As ComboBox
    Friend WithEvents lblOutput As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnProduce As Button
End Class
