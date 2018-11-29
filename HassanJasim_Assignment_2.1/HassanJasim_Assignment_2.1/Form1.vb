'Hassan Jasim
'400057926
Option Strict On
Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblKValue, dblP0Value, dblTime As Double

        If Not Double.TryParse(txtP0.Text, dblP0Value) Then
            txtP0.Clear()
            txtP0.Focus()
            MsgBox("Please enter a valid P0 value",, "Error")
            Exit Sub
        End If

        If Not Double.TryParse(txtK.Text, dblKValue) Then
            txtK.Clear()
            txtK.Focus()
            MsgBox("Please enter a valid K value",, "Error")
            Exit Sub
        End If

        Try
            dblKValue = CDbl(txtK.Text)
            dblP0Value = CDbl(txtP0.Text)
            dblTime = 0
            If dblP0Value > 0 And (dblKValue >= -0.08 And dblKValue <= 0.08) Then

                If dblKValue > 0 Then
                    DoubleTime(dblKValue, dblP0Value, dblTime)
                    lblOutput.Text &= "P0 = " & dblP0Value & vbCr
                    lblOutput.Text &= "K value = " & dblKValue & vbCr
                    lblOutput.Text &= "P(t) = " & dblP0Value * 2 & vbCr
                    dblTime = dblTime / 60
                    lblOutput.Text &= "The time it took to get to P0 = " & dblTime.ToString("n3") & "min" & vbCr
                End If

                If dblKValue < 0 Then
                    HalfTime(dblKValue, dblP0Value, dblTime)
                    lblOutput.Text &= "P0 = " & dblP0Value & vbCr
                    lblOutput.Text &= "K value = " & dblKValue & vbCr
                    lblOutput.Text &= "P(t) = " & dblP0Value / 2 & vbCr
                    dblTime = dblTime / 60
                    lblOutput.Text &= "The time it took to get to P0 = " & dblTime.ToString("n3") & "min" & vbCr
                End If

            Else
                If dblP0Value < 0 Then
                    MsgBox("Please enter a Positive P0 value",, "Error")
                End If
                If dblKValue < -0.08 Or dblKValue > 0.08 Then
                    MsgBox("Please enter a K value within the given range",, "Error")
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub
    Private Function DoubleTime(ByVal K As Double, ByVal P0 As Double, ByRef time As Double) As Double
        lblOutput.Text = Space(35) & "This is a Growth Model" & vbCr
        Dim dblPt As Double = 2 * P0

        time = (Math.Log(dblPt / P0)) / (K)

        Return time
    End Function
    Private Function HalfTime(ByVal K As Double, ByVal P0 As Double, ByRef time As Double) As Double
        lblOutput.Text = Space(35) & "This is a Decay Model" & vbCr
        Dim dblPt As Double = P0 / 2

        time = (Math.Log(dblPt / P0)) / (K)

        Return time
    End Function
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtK.Clear()
        txtP0.Clear()
        lblOutput.Text = String.Empty
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
