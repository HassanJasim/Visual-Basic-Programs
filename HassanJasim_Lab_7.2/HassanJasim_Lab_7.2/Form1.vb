'Hassan Jasim
'ID: 400057926
Option Strict On
Imports System.IO
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstOutput.Items.Add("Side A     Side B      Side C      Perimeter       Area")
        getTriangleSides()
        getProperties()
    End Sub

    Private Sub getTriangleSides()
        Dim sideA, sideB, sideC As Integer
        Dim rand As New Random()
        Dim outFile As StreamWriter

        Randomize()

        outFile = File.CreateText("Triangles.txt")

        For i = 0 To 100
            sideA = rand.Next(9) + 1
            sideB = rand.Next(9) + 1

            Do Until sideC < 10 And (sideA + sideB) > sideC And (sideA + sideC) > sideB And (sideB + sideC) > sideA
                sideC = rand.Next(9) + 1
            Loop

            outFile.WriteLine(sideA & "," & sideB & "," & sideC)

        Next

        outFile.Close()
    End Sub

    Private Sub getProperties()
        Dim inFile As StreamReader
        Dim intPerimeter, sideA, sideB, sideC As Integer
        Dim dblArea, intP As Double
        Dim tempString As String


        If File.Exists("Triangles.txt") Then
            inFile = File.OpenText("Triangles.txt")

            Do Until inFile.EndOfStream
                tempString = inFile.ReadLine()

                sideA = Convert.ToInt32(tempString.ElementAt(0)) - 48
                sideB = Convert.ToInt32(tempString.ElementAt(2)) - 48
                sideC = Convert.ToInt32(tempString.ElementAt(4)) - 48

                intPerimeter = sideA + sideB + sideC
                intP = intPerimeter / 2

                dblArea = Math.Sqrt(intP * (intP - sideA) * (intP - sideC) * (intP - sideC))

                If dblArea >= 20 And dblArea <= 25 Then
                    lstOutput.Items.Add("   " & sideA & "              " & sideB & "               " & sideC & "              " & intPerimeter & "              " & dblArea.ToString("n1"))
                End If
            Loop

            inFile.Close()
        Else
            MsgBox("File does not exits",, "ERROR")
        End If


    End Sub
End Class
