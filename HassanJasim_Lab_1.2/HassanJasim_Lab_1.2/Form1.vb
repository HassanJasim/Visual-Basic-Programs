'Hassan Jasim 400057926
Public Class Form1


    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim dblvelocity, dblmass, dblraduis, dblcharge, dblmagneticField As Double


        dblmass = CDbl(txtMass.Text)
        dblvelocity = CDbl(txtVelocity.Text)
        dblraduis = CDbl(txtRaduis.Text)
        dblcharge = CDbl(txtCharge.Text)

        dblmagneticField = (dblmass * dblvelocity) / (dblraduis * dblcharge)



        lblOuput.Text = "The Mass is: " & dblmass.ToString("e2") & vbCr
        lblOuput.Text &= "The Velocity is: " & dblvelocity.ToString("e2") & vbCr
        lblOuput.Text &= "The raduis is: " & dblraduis & vbCr
        lblOuput.Text &= "The Charge is: " & dblcharge.ToString("e2") & vbCr
        lblOuput.Text &= "The Magnetic Field is: " & dblmagneticField.ToString("n3") & vbCr

    End Sub



    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
