'Hassan Jasim 400057926
Option Strict On
Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim xComp, yComp, resultant, angle, finalAngle As Double


        Try


            If Not Double.TryParse(txtXComp.Text, xComp) Then
                MsgBox("The X component is invalid", , "ERROR")
                txtXComp.Focus()
                Exit Sub
            End If
            If Not Double.TryParse(txtYComp.Text, yComp) Then
                MsgBox("The Y component is invalid", , "ERROR")
                txtYComp.Focus()
                Exit Sub
            End If


            xComp = CDbl(txtXComp.Text)
            yComp = CDbl(txtYComp.Text)



            If xComp <> 0 And yComp <> 0 Then

                resultant = Math.Sqrt((xComp ^ 2) + (yComp ^ 2))
                angle = Math.Atan(yComp / xComp)


                If xComp < 0 And yComp > 0 Then
                    finalAngle = Math.PI + angle

                ElseIf xComp < 0 And yComp < 0 Then
                    finalAngle = Math.PI + angle

                ElseIf xComp > 0 And yComp < 0 Then
                    finalAngle = (2 * Math.PI) + angle

                Else
                    finalAngle = angle
                End If

                angle = angle * (180 / Math.PI)
                finalAngle = finalAngle * (180 / Math.PI)
                lblOutput.Text = "The X component is " & xComp & "N" & vbCr
                lblOutput.Text &= "The Y component is " & yComp & "N" & vbCr
                lblOutput.Text &= "The Resultant is " & resultant.ToString("n1") & "N" & vbCr
                lblOutput.Text &= "The Final Angle is " & finalAngle.ToString("n1") & " Degrees" & vbCr
                If chkAngle.Checked Then
                    lblOutput.Text &= "The Intermediate Angle is " & angle.ToString("n1") & " Degrees" & vbCr
                End If

            Else
                MessageBox.Show("The X & Y component can't be ZERO", "ERROR")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try



    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtXComp.Clear()
        txtYComp.Clear()
        lblOutput.Text = String.Empty
        chkAngle.Checked = False
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
