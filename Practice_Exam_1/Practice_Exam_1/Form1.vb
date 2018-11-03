Option Strict On
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 5 To 90 Step 5
            lstAngle.Items.Add(i)
            If i = 60 Then
                lstAngle.SelectedItem = i
            End If
        Next

        rad3.Checked = True
    End Sub

    Private Sub btnSine_Click(sender As Object, e As EventArgs) Handles btnSine.Click
        Dim dblAngle As Double
        Dim dblKvalue As Double
        Dim dblSineValue As Double

        Try
            dblAngle = CDbl(lstAngle.SelectedItem())

            If rad1.Checked Then
                dblKvalue = 1
            ElseIf rad3.Checked Then
                dblKvalue = 3
            ElseIf rad5.Checked Then
                dblKvalue = 5
            End If


            lblOutput.Text &= "Angle: " & dblAngle & vbCr
            lblOutput.Text &= "Terms: " & dblKvalue & vbCr

            dblAngle = dblAngle * Math.PI / 180
            dblSineValue = sineX(dblAngle, dblKvalue)


            lblOutput.Text &= "Calculated: " & dblSineValue & vbCr
            lblOutput.Text &= "Exact:         " & Math.Sin(dblAngle)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR")
        End Try

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Function sineX(ByVal dblAngle As Double, ByVal dblKvalue As Double) As Double
        Dim dblSine As Double

        For i = 0 To dblKvalue
            dblSine += ((-1) ^ i) * (dblAngle ^ (2 * i + 1)) / factorial((2 * i + 1))
        Next

        Return dblSine
    End Function

    Private Function factorial(ByVal dblnumber As Double) As Double
        Dim dblanswer As Double = 1

        For i = 1 To dblnumber
            dblanswer *= i
        Next

        Return dblanswer
    End Function

End Class
