'HassanJasim
'400057926
Option Strict On
Public Class Form1
    Private Sub btnValidate_Click(sender As Object, e As EventArgs) Handles btnValidate.Click
        Dim strInput As String
        lblOutput.Text = String.Empty

        strInput = txtInput.Text

        If ValidateCode(strInput) Then
            lblOutput.Text &= "Your Code is Valid!!!"
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtInput.Clear()
        lblOutput.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Function ValidateCode(ByVal strInput As String) As Boolean
        Dim charOne As String
        Dim counter As Integer

        charOne = CStr(strInput.Substring(0, 1))

        If charOne.ToUpper() <> "A" And charOne.ToUpper() <> "M" And charOne.ToUpper() <> "P" Then
            lblOutput.Text &= "Your code must start with either ""A"", ""M"", ""P""" & vbCr
            counter += 1
        End If
        If strInput.Length - 1 < 7 Then
            lblOutput.Text &= "The code must be between 7 and 12 characters" & vbCr
            counter += 1
        End If
        For i = 1 To strInput.Length - 1
            If Not IsNumeric(strInput(i)) Then
                lblOutput.Text &= "Character " & i + 1 & " must be a number" & vbCr
                counter += 1
            End If
        Next

        Return counter = 0
    End Function
End Class
