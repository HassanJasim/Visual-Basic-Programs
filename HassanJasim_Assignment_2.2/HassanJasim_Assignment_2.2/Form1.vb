'Hassan Jasim
'400057926
Option Strict On
Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblWidth, dblDeltaH, dblHeight, dblDiameter, dblDepth, dblWorkDone, dblTotalWork As Double

        If Not Double.TryParse(txtDiameter.Text, dblDiameter) Then
            txtDiameter.Clear()
            txtDiameter.Focus()
            MsgBox("Please enter a valid Diameter",, "Error")
            Exit Sub
        End If
        If Not Double.TryParse(txtHeight.Text, dblHeight) Then
            txtHeight.Clear()
            txtHeight.Focus()
            MsgBox("Please enter a valid Height",, "Error")
            Exit Sub
        End If
        If Not Double.TryParse(txtDepth.Text, dblDepth) Then
            txtDepth.Clear()
            txtDepth.Focus()
            MsgBox("Please enter a valid Depth",, "Error")
            Exit Sub
        End If
        If Not Double.TryParse(txtThickness.Text, dblDeltaH) Then
            txtThickness.Clear()
            txtThickness.Focus()
            MsgBox("Please enter a valid Thickness",, "Error")
            Exit Sub
        End If

        Try
            dblDeltaH = CDbl(txtThickness.Text)
            dblHeight = CDbl(txtHeight.Text)
            dblDiameter = CDbl(txtDiameter.Text)
            dblDepth = CDbl(txtDepth.Text)
            dblWorkDone = 0

            For i = 1 To (dblDepth / dblDeltaH) Step dblDeltaH
                Work(dblDeltaH, dblHeight, dblDiameter, dblDepth, dblWidth, dblWorkDone)
                dblTotalWork += dblWorkDone
            Next
            lblOutput.Text &= "Tank Height = " & dblHeight & " m" & vbCr
            lblOutput.Text &= "Tank Diameter = " & dblDiameter & " m" & vbCr
            lblOutput.Text &= "Oil Height = " & dblDepth & " m" & vbCr
            lblOutput.Text &= "Delta H = " & dblDeltaH & " m" & vbCr
            lblOutput.Text &= "Work needed to remove the oil is = " & dblTotalWork.ToString("n3") & " J" & vbCr
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR")
        End Try
    End Sub
    Private Function Volume(ByVal DeltaH As Double, ByVal tankHeight As Double, ByVal tankDiameter As Double, ByVal oilDepth As Double, ByVal oilWidth As Double) As Double
        oilWidth = (tankDiameter * oilDepth) / tankHeight

        Return Math.PI * (oilWidth / 2) ^ 2 * DeltaH
    End Function
    Private Function Force(ByVal DeltaH As Double, ByVal tankHeight As Double, ByVal tankDiameter As Double, ByVal oilDepth As Double, ByVal oilWidth As Double) As Double
        Const row As Double = 2000
        Const earthG As Double = 9.81
        Dim V As Double

        V = Volume(DeltaH, tankHeight, tankDiameter, oilDepth, oilWidth)

        Return V * row * earthG
    End Function
    Private Function Work(ByVal DeltaH As Double, ByVal tankHeight As Double, ByVal tankDiameter As Double, ByVal oilDepth As Double, ByVal oilWidth As Double, ByRef workDone As Double) As Double
        Dim F As Double

        F = Force(DeltaH, tankHeight, tankDiameter, oilDepth, oilWidth)
        workDone = F * (tankHeight - oilDepth)
        Return workDone
    End Function
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDepth.Clear()
        txtDiameter.Clear()
        txtHeight.Clear()
        txtThickness.Clear()
        lblOutput.Text = String.Empty
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
