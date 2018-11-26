'Hassan Jasim 400057926
Option Strict On
Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim accel, length, radius, mass, stretch, percentStretch As Double
        Const young As Double = 200000000000.0
        Const gravity As Double = 9.81

        If Not Double.TryParse(txtLength.Text, length) Then
            txtLength.Clear()
            txtLength.Focus()
            MsgBox("Please enter a valid Cable length",, "ERROR")
            Exit Sub
        End If
        If Not Double.TryParse(txtRadius.Text, radius) Then
            txtRadius.Clear()
            txtRadius.Focus()
            MsgBox("Please enter a valid Radius",, "ERROR")
            Exit Sub
        End If
        If Not Double.TryParse(txtAcceleration.Text, accel) Then
            txtAcceleration.Clear()
            txtAcceleration.Focus()
            MsgBox("Please enter a valid Acceleration",, "ERROR")
            Exit Sub
        End If

        Try
            accel = CDbl(txtAcceleration.Text)
            length = CDbl(txtLength.Text)
            radius = CDbl(txtRadius.Text)

            lbOutput.Items.Add("The Length of the cable is " & length)
            lbOutput.Items.Add("The Radius of the cable is " & radius)
            lbOutput.Items.Add("The Acceleration of the cable is " & accel)
            lbOutput.Items.Add("Young's modulus of the cable is " & young.ToString("e"))
            lbOutput.Items.Add("The gravitational acceleration is " & gravity)
            lbOutput.Items.Add("")
            lbOutput.Items.Add("Mass (kg)" & Space(12) & "Stretch (m)")

            For mass = 1000 To 5000 Step 200
                stretch = (mass * length * (accel + gravity)) / (young * Math.PI * radius ^ 2)

                percentStretch = stretch / length * 100

                If percentStretch > 0.3 Then
                    lbOutput.Items.Add(mass & Space(15) & stretch.ToString("e3") & "***")
                Else
                    lbOutput.Items.Add(mass & Space(15) & stretch.ToString("e3"))
                End If
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR")
        End Try

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lbOutput.Items.Clear()
        txtAcceleration.Text = String.Empty
        txtLength.Text = String.Empty
        txtRadius.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
