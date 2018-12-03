'Hassan Jasim
'400057926
Option Strict On
Public Class Form1
    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        Dim body As Graphics = Me.CreateGraphics()
        Dim legs As Graphics = Me.CreateGraphics()
        Dim head As Graphics = Me.CreateGraphics()
        Dim ears As Graphics = Me.CreateGraphics()
        Static counter As Integer
        Dim pen As New Pen(Color.Black)
        Dim brush As New SolidBrush(Color.FromArgb(139, 69, 19))
        Dim brush2 As New SolidBrush(Color.FromArgb(210, 180, 140))
        Dim a As New Point(370, 85)
        Dim b As New Point(360, 115)
        Dim c As New Point(380, 115)
        Dim a1 As New Point(380, 85)
        Dim b1 As New Point(370, 115)
        Dim c1 As New Point(390, 115)
        Dim ear1() As Point = {a, b, c}
        Dim ear2() As Point = {a1, b1, c1}

        If counter = 0 Then
            body.FillEllipse(brush, 175, 125, 200, 50)
            counter += 1
            lblDisplay.Text = "Click again"
        ElseIf counter = 1 Then
            head.FillEllipse(brush, 350, 110, 50, 50)
            counter += 1

        ElseIf counter = 2 Then
            legs.DrawLine(pen, 225, 170, 250, 200)
            counter += 1

        ElseIf counter = 3 Then
            legs.DrawLine(pen, 225, 170, 200, 200)
            counter += 1

        ElseIf counter = 4 Then
            legs.DrawLine(pen, 325, 170, 300, 200)
            counter += 1

        ElseIf counter = 5 Then
            legs.DrawLine(pen, 325, 170, 350, 200)
            counter += 1

        ElseIf counter = 6 Then
            ears.FillPolygon(brush2, ear1)
            counter += 1

        ElseIf counter = 7 Then
            ears.FillPolygon(brush2, ear2)
            counter += 1
            lblDisplay.Text = "Painting Finished!!!!!"
        End If

    End Sub
End Class
