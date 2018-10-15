'Hassan Jasim 
'400057926
Option Strict On
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim elementNames() As String = {"Aluminium     ", "Brass            ", "Copper         ", "Nylon            ", "Steel             ", "Teflon           "}
        Dim youngsModulus() As Double = {6.9, 9.0, 11.0, 0.37, 21.0, 0.037}


        For i = 0 To elementNames.Length - 1
            lstYoungM.Items.Add(elementNames(i) & "  " & youngsModulus(i))
        Next

    End Sub
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblArea, dblLength, dblChange, dblForce, dblYoung As Double
        Dim counter As Integer
        Dim tempStr, materialName As String

        tempStr = CStr(lstYoungM.SelectedItem)
        materialName = String.Empty

        For i = 0 To tempStr.Length - 1
            If IsNumeric(tempStr(i)) Then
                tempStr = tempStr.Substring(i)
                Exit For
            End If
            If tempStr(i) = " " Then
                materialName = tempStr.Substring(0, i - counter)
                counter += 1
            End If
        Next

        dblYoung = CDbl(tempStr)

        If Not Double.TryParse(txtArea.Text, dblArea) Then
            txtArea.Clear()
            txtArea.Focus()
            MsgBox("Please enter a valid Area",, "Error")
            Exit Sub
        End If
        If Not Double.TryParse(txtLength.Text, dblLength) Then
            txtLength.Clear()
            txtLength.Focus()
            MsgBox("Please enter a valid Length",, "Error")
            Exit Sub
        End If
        If Not Double.TryParse(txtChange.Text, dblChange) Then
            txtChange.Clear()
            txtChange.Focus()
            MsgBox("Please enter a valid Change in length",, "Error")
            Exit Sub
        End If

        Try
            dblArea = CDbl(txtArea.Text)
            dblChange = CDbl(txtChange.Text)
            dblLength = CDbl(txtLength.Text)

            If dblArea >= 0.01 And dblArea <= 0.2 Then
                If dblLength >= 10 And dblLength <= 20 Then
                    If dblChange > 0 And dblChange <= 0.0015 Then
                        dblForce = (dblChange / dblLength) * dblArea * (dblYoung * 10 ^ 9)
                        lblOutput.Text = "The forcce needed to change a " & dblLength & "m " & " rod of " & materialName & " by " & dblChange & "m, is " & dblForce & "N, if it has a cross-sectional area of " & dblArea & "m^2"
                    Else
                        txtChange.Clear()
                        txtChange.Focus()
                        MsgBox("Please enter a Change in length within the given range",, "Error")
                    End If
                Else
                    txtLength.Clear()
                    txtLength.Focus()
                    MsgBox("Please enter a Length within the given range",, "Error")
                End If
            Else
                txtArea.Clear()
                txtArea.Focus()
                MsgBox("Please enter an Area within the given range",, "Error")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR")
        End Try

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtArea.Clear()
        txtLength.Clear()
        txtChange.Clear()
        lblOutput.Text = String.Empty
        lstYoungM.SelectedIndex = -1
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
