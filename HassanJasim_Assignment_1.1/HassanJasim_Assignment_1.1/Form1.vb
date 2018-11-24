'Hassan Jasim 400057926
Option Strict On
Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Const minSec As Integer = 60
        Const hourSec As Integer = 3600
        Const daySec As Integer = 86400
        Dim days, hours, minutes, seconds As Integer
        Dim inputSec As Integer


        If Not Integer.TryParse(txtSeconds.Text, inputSec) Then
            txtSeconds.Clear()
            txtSeconds.Focus()
            MsgBox("Please enter a valid number of seconds", , "Error")
            Exit Sub
        End If

        inputSec = CInt(txtSeconds.Text)

        If inputSec < 0 Then
            MsgBox("The number of seconds can't be negative", , "Error")
            txtSeconds.Clear()
            txtSeconds.Focus()
            Exit Sub
        End If

        Try
            days = CInt(Math.Floor(inputSec / daySec))

            If days >= 1 Then
                inputSec = inputSec - daySec * days
            End If

            hours = CInt(Math.Floor(inputSec / hourSec))

            If hours >= 1 Then
                inputSec = inputSec - hourSec * hours
            End If

            minutes = CInt(Math.Floor(inputSec / minSec))

            If minutes >= 1 Then
                inputSec = inputSec - minSec * minutes
            End If

            seconds = inputSec
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR")
        End Try



        lblOutput.Text = "Days: " & days & vbCr
        lblOutput.Text &= "Hours: " & hours & vbCr
        lblOutput.Text &= "Minutes: " & minutes & vbCr
        lblOutput.Text &= "Seconds: " & seconds & vbCr


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtSeconds.Clear()
        lblOutput.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
