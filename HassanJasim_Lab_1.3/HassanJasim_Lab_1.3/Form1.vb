'Hassan Jasim 400057926
Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Initializing Variables
        Dim force1, force1X, force1Y, angle1 As Double
        Dim force2, force2X, force2Y, angle2 As Double
        Dim force3, force3X, force3Y, angle3 As Double
        Dim resultantForce, tForceX, tForceY, resultantAngle As Double

        Try
            'Setting the angle
            angle1 = CDbl(txtAngF1.Text)
            angle2 = CDbl(txtAngF2.Text)
            angle3 = CDbl(txtAngF3.Text)

            angle1 = angle1 * (Math.PI / 180)
            angle2 = angle2 * (Math.PI / 180)
            angle3 = angle3 * (Math.PI / 180)

            'Setting the Magnitude
            force1 = CDbl(txtMagF1.Text)
            force2 = CDbl(txtMagF2.Text)
            force3 = CDbl(txtMagF3.Text)
            'X & Y for F1
            force1X = force1 * Math.Sin(angle1)
            force1Y = force1 * Math.Cos(angle1)
            'X & Y for F2
            force2X = force2 * Math.Sin(angle2)
            force2Y = force2 * Math.Cos(angle2)
            'X & Y for F3
            force3X = force3 * Math.Sin(angle3)
            force3Y = force3 * Math.Cos(angle3)

            'Calculating the resultant
            tForceX = force1X + force2X + force3X
            tForceY = force1Y + force2Y + force3Y
            resultantForce = Math.Sqrt(tForceX ^ 2 + tForceY ^ 2)
            resultantAngle = Math.Atan(tForceY \ tForceX)

            resultantAngle = resultantAngle * (180 / Math.PI)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try

        lblOutput.Text = Space(14) & "X-Comp" & Space(5) & "Y-Comp" & vbCr
        lblOutput.Text &= "F1:" & Space(10) & force1X.ToString("n3") & "N" & Space(5) & force1Y.ToString("n3") & "N" & vbCr
        lblOutput.Text &= "F2:" & Space(10) & force2X.ToString("n3") & "N" & Space(5) & force2Y.ToString("n3") & "N" & vbCr
        lblOutput.Text &= "F3:" & Space(10) & force3X.ToString("n3") & "N" & Space(5) & force3Y.ToString("n3") & "N" & vbCr
        lblOutput.Text &= "Sum:" & Space(9) & tForceX.ToString("n3") & "N" & Space(5) & tForceY.ToString("n3") & "N" & vbCr
        lblOutput.Text &= "Resultant:" & Space(4) & resultantForce.ToString("n3") & "N" & Space(5) & resultantAngle.ToString("n3")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAngF1.Clear()
        txtAngF2.Clear()
        txtAngF3.Clear()
        txtMagF1.Clear()
        txtMagF2.Clear()
        txtMagF3.Clear()
        lblOutput.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
