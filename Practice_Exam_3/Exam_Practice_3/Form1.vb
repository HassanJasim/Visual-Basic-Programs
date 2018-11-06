Option Strict On
Imports System.IO
Public Class Form1

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim outFile As StreamWriter
        Dim forcesNum As Integer

        outFile = File.CreateText("input.txt")

        forcesNum = CInt(InputBox("Please enter the number of forces", "Input"))

        outFile.WriteLine(forcesNum)

        For i = 1 To forcesNum
            outFile.WriteLine(InputBox("Please enter the value of the force", "Input"))
        Next
        outFile.WriteLine(InputBox("Please enter the mass", "Input"))

        outFile.Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim inputFile As StreamReader
        Dim forcesNum As Integer
        Dim dblNetForce As Double
        Dim dblMass As Double
        Dim dblAcceleration(), dblVelocity(), dblDisplacement() As Double



        If File.Exists("input.txt") Then
            inputFile = File.OpenText("input.txt")

            forcesNum = CInt(inputFile.ReadLine())

            For i = 1 To forcesNum
                dblNetForce += CDbl(inputFile.ReadLine())
            Next

            Do Until inputFile.EndOfStream
                dblMass = CDbl(inputFile.ReadLine())
            Loop

            'lblDisplay.Text = dblNetForce & "        " & dblMass & vbCr












            inputFile.Close()
        Else
            MsgBox("The file does not exist",, "ERROR")
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
