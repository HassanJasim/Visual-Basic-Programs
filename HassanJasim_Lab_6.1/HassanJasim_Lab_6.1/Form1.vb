'Hassan Jasim 
'400057926
Option Strict On
Public Class Form1
    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim intArraySize, counter, max, min As Integer


        If Not Integer.TryParse(txtInput.Text, intArraySize) Then
            txtInput.Clear()
            txtInput.Focus()
            MsgBox("Please enter a valid array size",, "ERROR")
            Exit Sub
        End If

        Try
            intArraySize = CInt(txtInput.Text)

            If intArraySize <= 0 Then
                txtInput.Clear()
                txtInput.Focus()
                MsgBox("Please enter a positive array size",, "ERROR")
                Exit Sub
            End If

            Dim randomArray(intArraySize) As Integer

            Randomize()

            For i = 0 To intArraySize - 1
                randomArray(i) = CInt(1000 * Rnd() + 1)
                counter += 1
                If counter = 10 Then
                    lblOutput.Text &= randomArray(i) & vbCr
                    counter = 0
                Else
                    lblOutput.Text &= randomArray(i) & Space(5)
                End If
            Next

            min = 1001
            max = randomArray(0)


            For i = 0 To intArraySize - 1
                If randomArray(i) < min Then
                    min = randomArray(i)
                End If

                If randomArray(i) > max Then
                    max = randomArray(i)
                End If
            Next

            lblOutput.Text &= vbCr & vbCr & vbCr
            lblOutput.Text &= "The Max is " & max & vbCr
            lblOutput.Text &= "The Min is " & min & vbCr

        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR")
        End Try
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtInput.Clear()
        lblOutput.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
