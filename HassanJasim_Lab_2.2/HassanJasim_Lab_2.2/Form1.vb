'Hassan Jasim 400057926
Option Strict On
Public Class Form1


    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim massOfPlanet, massOfObject, weight, distance As Double
        Const raduis As Double = 6380000.0
        Const gConstant As Double = 0.00000000006674

        If Not Double.TryParse(txtMassP.Text, massOfPlanet) Then
            MsgBox("Please enter a valid Mass of Planet", , "Error")
            txtMassP.Focus()
            Exit Sub
        End If
        If Not Double.TryParse(txtMassO.Text, massOfObject) Then
            MsgBox("Please enter a valid Mass of Object", , "Error")
            txtMassO.Focus()
            Exit Sub
        End If

        Try

            massOfPlanet = CDbl(txtMassP.Text)
            massOfObject = CDbl(txtMassO.Text)

            If massOfObject <> 0 And massOfPlanet <> 0 Then
                If rdbOnPlanet.Checked Then
                    distance = raduis
                    weight = (gConstant * massOfObject * massOfPlanet) / distance ^ 2
                End If
                If rdb100.Checked Then
                    distance = raduis + 100000
                    weight = (gConstant * massOfObject * massOfPlanet) / distance ^ 2
                End If
                If rdb500.Checked Then
                    distance = raduis + 500000
                    weight = (gConstant * massOfObject * massOfPlanet) / distance ^ 2
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR")
        End Try

        lblOutput.Text = "The Mass of Planet is " & massOfPlanet.ToString("e") & "kg" & vbCr
        lblOutput.Text &= "The Mass of the Object is " & massOfObject.ToString("e") & "kg" & vbCr
        lblOutput.Text &= "The distance between the object and the center of the planet is " & distance.ToString("e") & "m" & vbCr
        lblOutput.Text &= "The Weight of the Object is " & weight.ToString("e") & "N" & vbCr


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtMassO.Clear()
        txtMassP.Clear()
        lblOutput.Text = String.Empty
    End Sub
End Class
