'Hassan Jasim 
'400057926
Option Strict On
Imports System.IO
Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Const gasConstant As Double = 8.314
        Const moles As Double = 1000
        Dim inputFile As StreamReader
        Dim outFile As StreamWriter
        Dim intermString As String
        Dim idxPressure, idxTemperature, idxVolume As Integer
        Dim intermArray(2) As String
        Dim dblPressure, dblVolume, dblTemperature As Double

        If File.Exists("idealGas.txt") Then
            inputFile = File.OpenText("idealGas.txt")

            Do Until inputFile.EndOfStream
                intermString = inputFile.ReadLine()

                idxPressure = intermString.IndexOf("Pressure")
                idxTemperature = intermString.IndexOf("Temperature")
                idxVolume = intermString.IndexOf("Volume")

                If idxPressure = 0 Then
                    intermArray = Split(intermString, " ")
                    dblPressure = CDbl(intermArray(1))
                ElseIf idxTemperature = 0 Then
                    intermArray = Split(intermString, " ")
                    dblTemperature = CDbl(intermArray(1))
                ElseIf idxVolume = 0 Then
                    intermArray = Split(intermString, " ")
                    dblVolume = CDbl(intermArray(1))
                End If

            Loop
            inputFile.Close()


            If dblPressure = 0 Then
                dblPressure = (moles * gasConstant * dblTemperature) / dblVolume
            ElseIf dblTemperature = 0 Then
                dblTemperature = (dblPressure * dblVolume) / (moles * gasConstant)
            ElseIf dblVolume = 0 Then
                dblVolume = (moles * gasConstant * dblTemperature) / dblPressure
            End If


            lblDisplay.Text = "Pressure: " & dblPressure.ToString("n2") & " Pa" & vbCr
            lblDisplay.Text &= "Temperature: " & dblTemperature.ToString("n2") & " K" & vbCr
            lblDisplay.Text &= "Volume: " & dblVolume.ToString("n2") & " m^3" & vbCr
            lblDisplay.Text &= "Gas Constant: " & gasConstant & " J/(k*mol)" & vbCr
            lblDisplay.Text &= "Moles: " & moles & " moles" & vbCr

            outFile = File.CreateText("idealGas.txt")

            outFile.WriteLine("Pressure: " & dblPressure.ToString("n2") & " Pa")
            outFile.WriteLine("Temperature: " & dblTemperature.ToString("n2") & " K")
            outFile.WriteLine("Volume: " & dblVolume.ToString("n2") & " m^3")
            outFile.WriteLine("Gas Constant: " & gasConstant & " J/(k*mol)")
            outFile.WriteLine("Moles: " & moles & " moles")

            outFile.Close()
        Else
            MsgBox("File does not exist",, "ERROR")
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblDisplay.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
