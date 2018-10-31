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
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.lstDisplay = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lblOutput
        '
        Me.lblOutput.Location = New System.Drawing.Point(403, 17)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(469, 151)
        Me.lblOutput.TabIndex = 11
        Me.lblOutput.Text = "                       Enter your Number in the following format" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "               " &
    "                               (xxx) xxx-xxxx"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(241, 397)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(145, 43)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(241, 268)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(145, 43)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(12, 268)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(154, 50)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "Add To Phone Book"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(100, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Please enter your phone number"
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(12, 197)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(374, 22)
        Me.txtPhoneNumber.TabIndex = 6
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(12, 116)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(374, 22)
        Me.txtAddress.TabIndex = 12
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(12, 35)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(374, 22)
        Me.txtName.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(118, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Please enter your address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(127, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 17)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Please enter your name"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(12, 386)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(154, 50)
        Me.btnSearch.TabIndex = 16
        Me.btnSearch.Text = "Search Phone Book"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(12, 327)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(154, 50)
        Me.btnDisplay.TabIndex = 17
        Me.btnDisplay.Text = "Display Phone Book"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'lstDisplay
        '
        Me.lstDisplay.FormattingEnabled = True
        Me.lstDisplay.ItemHeight = 16
        Me.lstDisplay.Location = New System.Drawing.Point(406, 171)
        Me.lstDisplay.Name = "lstDisplay"
        Me.lstDisplay.Size = New System.Drawing.Size(466, 276)
        Me.lstDisplay.TabIndex = 18
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 461)
        Me.Controls.Add(Me.lstDisplay)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPhoneNumber)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblOutput As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnDisplay As Button
    Friend WithEvents lstDisplay As ListBox
End Class
