'HassanJasim
'400057926
Option Strict On
Public Class Form1
    Private Sub btnMakeCall_Click(sender As Object, e As EventArgs) Handles btnMakeCall.Click
        Dim strInput As String
        lblOutput.Text = String.Empty

        strInput = txtPhoneNumber.Text

        If ValidateNumber(strInput) Then
            lblOutput.Text &= "Your Number is valid"
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblOutput.Text = "                       Enter your Number in the following format
                                              (xxx) xxx-xxxx"
        txtPhoneNumber.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Function ValidateNumber(ByVal strInput As String) As Boolean
        Dim errorCounter As Integer

        For i = 0 To strInput.Length - 1
            If i = 0 Then
                If Not strInput(i) = "(" Then
                    lblOutput.Text &= "The first charater must be ""(""" & vbCr
                    errorCounter += 1
                End If
            End If
            If i = 1 Then
                If Not Convert.ToInt16(strInput(i)) - 48 > 0 Then
                    lblOutput.Text &= "The first number must be greater than 0" & vbCr
                    errorCounter += 1
                End If
            End If

            If i = 4 Then
                If Not strInput(i) = ")" Then
                    lblOutput.Text &= "The Fifth charater must be "")""" & vbCr
                    errorCounter += 1
                End If
            End If

            If i = 5 Then
                If Not strInput(i) = " " Then
                    lblOutput.Text &= "The sixth charater must be "" """ & vbCr
                    errorCounter += 1
                End If
            End If

            If i = 9 Then
                If Not strInput(i) = "-" Then
                    lblOutput.Text &= "The tenth charater must be ""-""" & vbCr
                    errorCounter += 1
                End If
            End If

            If i <> 0 And i <> 1 And i <> 4 And i <> 5 And i <> 9 Then
                If Not IsNumeric(strInput(i)) Then
                    lblOutput.Text &= "The " & i + 1 & " charater must be a number " & vbCr
                    errorCounter += 1
                End If
            End If
        Next

        Return errorCounter = 0

    End Function
End Class
