'Hassan Jasim 
'ID:400057926
Option Strict On
Public Class Form1
    Private Sub btnTriangles_Click(sender As Object, e As EventArgs) Handles btnTriangles.Click
        Dim ArrayTriangle(4, 2) As Integer
        Dim Perimeter(4, 1) As Integer
        Dim Area(4, 1) As Double

        getTriangleSides(ArrayTriangle)
        getProperties(ArrayTriangle, Perimeter, Area)
        lblOutput.TextAlign = ContentAlignment.TopLeft

        lblOutput.Text = "Triangle:    Side a:     Side b:     Side c:     Perimeter:     Area:" & vbCrLf

        For i As Integer = 0 To 4
            lblOutput.Text &= (i + 1).ToString & "                 " & ArrayTriangle(i, 0).ToString("f1") & "           " & ArrayTriangle(i, 1).ToString("n1") & "           " & ArrayTriangle(i, 2).ToString("n1") & "           " & Perimeter(i, 1).ToString("n1") & "            " & Area(i, 1).ToString("n1") & vbCrLf
        Next
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblOutput.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub getTriangleSides(ByVal ArrayTriangle(,) As Integer)
        Dim rand As New Random

        For i As Integer = 0 To 4
            Do Until (ArrayTriangle(i, 0) + ArrayTriangle(i, 1)) > ArrayTriangle(i, 2) And (ArrayTriangle(i, 1) + ArrayTriangle(i, 2)) > ArrayTriangle(i, 0) And (ArrayTriangle(i, 0) + ArrayTriangle(i, 2)) > ArrayTriangle(i, 1)
                For j As Integer = 0 To 2
                    ArrayTriangle(i, j) = rand.Next(9) + 1
                Next
            Loop
        Next
    End Sub

    Private Sub getProperties(ByVal ArrayTriangle(,) As Integer, ByVal Perimeter(,) As Integer, ByVal Area(,) As Double)
        Dim p(4) As Double

        For i As Integer = 0 To 4
            For j As Integer = 0 To 2
                Perimeter(i, 1) = ArrayTriangle(i, 0) + ArrayTriangle(i, 1) + ArrayTriangle(i, 2)
                p(i) = Perimeter(i, 1) / 2
                Area(i, 1) = Math.Sqrt(p(i) * (p(i) - ArrayTriangle(i, 0)) * (p(i) - ArrayTriangle(i, 1)) * (p(i) - ArrayTriangle(i, 2)))
            Next
        Next
    End Sub
End Class
