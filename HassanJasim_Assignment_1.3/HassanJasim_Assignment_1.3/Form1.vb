'Hassan Jasim 400057926
Option Strict On
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 1 To 12
            combxSelect.Items.Add(i)
        Next
    End Sub

    Private Sub btnProduce_Click(sender As Object, e As EventArgs) Handles btnProduce.Click
        Dim selectedNum, product As Integer
        Try
            selectedNum = CInt(combxSelect.SelectedItem)
            For i = 1 To 12
                product = i * selectedNum
                lblOutput.Text &= i & " X " & selectedNum & " = " & product & vbCr
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR")
        End Try

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblOutput.Text = String.Empty
    End Sub
End Class