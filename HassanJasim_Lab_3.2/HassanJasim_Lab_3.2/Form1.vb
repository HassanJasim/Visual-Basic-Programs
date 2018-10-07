Option Strict On
Public Class Form1
    Private Sub btnFindPrimeNum_Click(sender As Object, e As EventArgs) Handles btnFindPrimeNum.Click
        Dim n, m As Integer
        If Not Integer.TryParse(txtMin.Text, m) Then
            txtMin.Clear()
            txtMin.Focus()
            MsgBox("Please enter a valid Minimum",, "ERROR")
            Exit Sub
        End If
        If Not Integer.TryParse(txtMax.Text, n) Then
            txtMax.Clear()
            txtMax.Focus()
            MsgBox("Please enter a valid Maximum",, "ERROR")
            Exit Sub
        End If
        If isInputValid(m, n) Then
            For i = m To n
                If isPrime(i) Then
                    lstOutput.Items.Add(i)
                End If
            Next
        End If
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        resetControls()
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub resetControls()
        lstOutput.Items.Clear()
        txtMax.Clear()
        txtMin.Clear()
    End Sub
    Private Function isInputValid(ByVal m As Integer, ByVal n As Integer) As Boolean
        If m > 1 And m < n Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Function isPrime(ByVal i As Integer) As Boolean
        For x = 2 To i / 2
            If i Mod x = 0 Then
                Return False
            End If
        Next
        Return True
    End Function
End Class
