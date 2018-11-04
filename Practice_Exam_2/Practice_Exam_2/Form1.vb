Option Strict On
Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblAvalue, dblBvalue, dblTemp As Double
        Dim intSize As Integer

        Dim Xe() As Double
        Dim Xo() As Double
        Dim X() As Double
        Dim Xprime() As Double
        Dim Y() As Double


        If Not Double.TryParse(txtA.Text, dblAvalue) Then
            txtA.Clear()
            txtA.Focus()
            MsgBox("Please enter a valid ""A"" Value",, "ERROR")
            Exit Sub
        End If
        If Not Double.TryParse(txtB.Text, dblBvalue) Then
            txtB.Clear()
            txtB.Focus()
            MsgBox("Please enter a valid ""B"" Value",, "ERROR")
            Exit Sub
        End If
        If Not Integer.TryParse(txtSize.Text, intSize) Then
            txtSize.Clear()
            txtSize.Focus()
            MsgBox("Please enter a valid ""Size""",, "ERROR")
            Exit Sub
        End If

        dblAvalue = CDbl(txtA.Text)
        dblBvalue = CDbl(txtB.Text)
        intSize = CInt(txtSize.Text)

        ReDim X(intSize - 1)
        ReDim Y(intSize - 1)
        ReDim Xprime(intSize - 1)
        ReDim Xe(intSize - 1)
        ReDim Xo(intSize - 1)


        For i = 0 To intSize - 1
            dblTemp = CDbl(InputBox("Please enter a value", "Input"))
            X(i) = dblTemp
            Xprime(i) = dblTemp
            Y(i) = dblAvalue * X(i) + dblBvalue
            'lblDisplay.Text &= X(i) & "    " & Y(i) & vbCr
        Next


        Array.Reverse(Xprime)


        For i = 0 To intSize - 1
            Xe(i) = 0.5 * (X(i) + Xprime(i))
            Xo(i) = 0.5 * (X(i) - Xprime(i))
            'lblDisplay.Text &= Xe(i) & "    " & Xo(i) & vbCr
        Next

        lblDisplay.Text &= "X[] =    "
        For i = 0 To intSize - 1
            lblDisplay.Text &= X(i) & "     "
        Next
        lblDisplay.Text &= vbCr

        lblDisplay.Text &= "X'[] =   "
        For i = 0 To intSize - 1
            lblDisplay.Text &= Xprime(i) & "     "
        Next
        lblDisplay.Text &= vbCr

        lblDisplay.Text &= "Y[] =    "
        For i = 0 To intSize - 1
            lblDisplay.Text &= Y(i) & "     "
        Next
        lblDisplay.Text &= vbCr

        If chkXe.Checked Then
            lblDisplay.Text &= "Xe[] =   "
            For i = 0 To intSize - 1
                lblDisplay.Text &= Xe(i) & "    "
            Next
            lblDisplay.Text &= vbCr
        End If

        If chkXo.Checked Then
            lblDisplay.Text &= "Xo[] =   "
            For i = 0 To intSize - 1
                lblDisplay.Text &= Xo(i) & "     "
            Next
            lblDisplay.Text &= vbCr
        End If


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
