'Hassan Jasim 400057926
Public Class Form1

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub BtnEarth_Click(sender As Object, e As EventArgs) Handles BtnEarth.Click

        txtMPerS.Text = 9.81
        txtMPerS.TextAlign = ContentAlignment.MiddleLeft
        txtMPerS.ForeColor = Color.Blue
        txtMPerS.BackColor = Color.Yellow


        txtFtPerS.Text = 32.19
        txtFtPerS.TextAlign = ContentAlignment.BottomLeft
        txtFtPerS.ForeColor = Color.Red
        txtFtPerS.BackColor = Color.Cyan

    End Sub

    Private Sub BtnMercury_Click(sender As Object, e As EventArgs) Handles BtnMercury.Click

        txtMPerS.Text = 3.61
        txtMPerS.TextAlign = ContentAlignment.MiddleRight
        txtMPerS.ForeColor = Color.Red
        txtMPerS.BackColor = Color.Cyan


        txtFtPerS.Text = 11.84
        txtFtPerS.TextAlign = ContentAlignment.TopRight
        txtFtPerS.ForeColor = Color.Blue
        txtFtPerS.BackColor = Color.Yellow
    End Sub

    Private Sub BtnMars_Click(sender As Object, e As EventArgs) Handles BtnMars.Click

        txtMPerS.Text = 3.75
        txtMPerS.TextAlign = HorizontalAlignment.Center
        txtMPerS.ForeColor = Color.Green
        txtMPerS.BackColor = Color.Yellow


        txtFtPerS.Text = 12.3
        txtFtPerS.TextAlign = HorizontalAlignment.Right
        txtFtPerS.ForeColor = Color.Yellow
        txtFtPerS.BackColor = Color.Green
    End Sub

End Class
