'Hassan Jasim
'400057926
Option Strict On
Imports System.IO
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim outFile As StreamWriter
        outFile = File.CreateText("Data.txt")
        outFile.WriteLine("10,5")
        outFile.WriteLine("15,20")
        outFile.WriteLine("20,18")
        outFile.WriteLine("25,40")
        outFile.WriteLine("40,33")
        outFile.WriteLine("50,54")
        outFile.WriteLine("55,70")
        outFile.WriteLine("60,60")
        outFile.WriteLine("75,78")
        outFile.Close()
    End Sub

    Private Sub btnEstimate_Click(sender As Object, e As EventArgs) Handles btnEstimate.Click
        Dim inputFile As StreamReader
        Dim timeArray() As Double = {10, 15, 20, 25, 40, 50, 55, 60, 75}
        Dim tStrengthArray() As Double = {5, 20, 18, 40, 33, 54, 70, 60, 78}
        Dim SofT(,) As Double = {{10, 15, 20, 25, 40, 50, 55, 60, 75},
                                  {5, 20, 18, 40, 33, 54, 70, 60, 78}}
        Dim fileTimeArray() As Double
        Dim fileTesileArray() As Double
        Dim inputTimeArray() As Double
        Dim inputTensileArray() As Double
        Dim tempArray(1) As String
        Dim arrayLength As Integer
        Dim dblSlope, dblYint, dblTime, dblTstrength As Double

        If rad1D.Checked Then
            Tensile_1D(timeArray, tStrengthArray, dblSlope, dblYint)
            If getTime(dblTime) Then
                dblTstrength = dblTime * dblSlope + dblYint
            End If
            printValues(dblSlope, dblYint, dblTime, dblTstrength)
        ElseIf rad2D.Checked Then
            Tensile_2D(SofT, dblSlope, dblYint)
            If getTime(dblTime) Then
                dblTstrength = dblTime * dblSlope + dblYint
            End If
            printValues(dblSlope, dblYint, dblTime, dblTstrength)
        ElseIf radInput.Checked Then
            arrayLength = CInt(InputBox("Please enter the number of data collected", "Array Length"))
            ReDim inputTimeArray(arrayLength - 1)
            ReDim inputTensileArray(arrayLength - 1)
            inputTensileArray = getInputArray(inputTimeArray, inputTensileArray, arrayLength)
            Tensile_1D(inputTimeArray, inputTensileArray, dblSlope, dblYint)
            If getTime(dblTime) Then
                dblTstrength = dblTime * dblSlope + dblYint
            End If
            printValues(dblSlope, dblYint, dblTime, dblTstrength)
        ElseIf radFile.Checked Then
            If File.Exists("Data.txt") Then
                inputFile = File.OpenText("Data.txt")
                arrayLength = 0
                Do Until inputFile.EndOfStream
                    inputFile.ReadLine()
                    arrayLength += 1
                Loop
                inputFile.Close()
                inputFile = File.OpenText("Data.txt")
                ReDim fileTimeArray(arrayLength - 1)
                ReDim fileTesileArray(arrayLength - 1)
                Do Until inputFile.EndOfStream
                    For i = 0 To arrayLength - 1
                        tempArray = Split(inputFile.ReadLine(), ",")
                        fileTimeArray(i) = CDbl(tempArray(0))
                        fileTesileArray(i) = CDbl(tempArray(1))
                    Next
                Loop
                Tensile_1D(fileTimeArray, fileTesileArray, dblSlope, dblYint)
                If getTime(dblTime) Then
                    dblTstrength = dblTime * dblSlope + dblYint
                End If
                printValues(dblSlope, dblYint, dblTime, dblTstrength)
                inputFile.Close()
            Else
                MsgBox("File does not exist",, "ERROR")
            End If
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblDisplay.Text = String.Empty
        rad1D.Checked = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Tensile_1D(ByVal timeArray() As Double, ByVal tStrengthArray() As Double, ByRef dblSlope As Double, ByRef dblYint As Double)
        Dim sum1, sum2, sum3, sum4 As Double
        For i = 0 To timeArray.Length - 1
            sum1 += timeArray(i) * tStrengthArray(i)
            sum2 += timeArray(i)
            sum3 += tStrengthArray(i)
            sum4 += timeArray(i) ^ 2
        Next
        dblSlope = ((9 * sum1) - (sum2 * sum3)) / ((9 * sum4) - (sum2 ^ 2))
        dblYint = (sum3 / 9) - ((sum2 / 9) * dblSlope)
    End Sub

    Private Sub Tensile_2D(ByVal SofT(,) As Double, ByRef dblSlope As Double, ByRef dblYint As Double)
        Dim sum1, sum2, sum3, sum4 As Double
        For i = 0 To 8
            sum1 += SofT(0, i) * SofT(1, i)
            sum2 += SofT(0, i)
            sum3 += SofT(1, i)
            sum4 += SofT(0, i) ^ 2
        Next
        dblSlope = ((9 * sum1) - (sum2 * sum3)) / ((9 * sum4) - (sum2 ^ 2))
        dblYint = (sum3 / 9) - ((sum2 / 9) * dblSlope)
    End Sub

    Private Function getTime(ByRef dblTime As Double) As Boolean

        dblTime = CDbl(InputBox("Please enter the value of time (10 - 75 inclusive)", "Input"))
        If dblTime <= 75 And dblTime >= 10 Then
            Return True
        Else
            MsgBox("Please enter a time between 10 - 75 (inclusive)")
            Return False
        End If
    End Function

    Private Function getInputArray(ByRef inputTimeArray() As Double, ByVal inputTensileArray() As Double, ByVal arrayLength As Integer) As Double()
        For i = 0 To arrayLength - 1
            inputTimeArray(i) = CInt(InputBox("Please enter the time", "Input"))
            inputTensileArray(i) = CInt(InputBox("Please enter the tensile strength", "Input"))
        Next
        Return inputTensileArray
    End Function

    Private Sub printValues(ByVal dblSlope As Double, ByVal dblYint As Double, ByVal dblTime As Double, ByVal dblTstrength As Double)
        lblDisplay.Text = "The time is: " & dblTime.ToString("n3") & vbCr & "The slope is: " & dblSlope.ToString("n3") & vbCr & "The Y-int is: " & dblYint.ToString("n3") & vbCr & "The Tensile Strength is: " & dblTstrength.ToString("n3")
    End Sub

End Class
