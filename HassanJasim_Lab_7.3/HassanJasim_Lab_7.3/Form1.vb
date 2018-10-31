''Hassan Jasim
'ID: 400057926
Option Strict On
Imports System.IO
Public Class Form1

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim strName, strAddress, strPhoneNumber As String
        lblOutput.Text = String.Empty

        Dim outFile As StreamWriter

        outFile = File.AppendText("Address Book.txt")

        If txtName.Text = String.Empty Then
            MsgBox("Please enter a name",, "ERROR")
            Exit Sub
        End If

        If txtAddress.Text = String.Empty Then
            MsgBox("Please enter an address",, "ERROR")
            Exit Sub
        End If

        If txtPhoneNumber.Text = String.Empty Then
            MsgBox("Please enter a phone number",, "ERROR")
            Exit Sub
        End If

        strName = txtName.Text
        strAddress = txtAddress.Text
        strPhoneNumber = txtPhoneNumber.Text

        If ValidateNumber(strPhoneNumber) Then
            lblOutput.Text &= "Your information has been added to the address book"
        End If

        outFile.Write(strName & "   ")
        outFile.Write(strAddress & "   ")
        outFile.WriteLine(strPhoneNumber)
        outFile.Close()
        txtPhoneNumber.Clear()
        txtName.Clear()
        txtAddress.Clear()

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim strName, addressLine As String
        Dim tempStr As String = String.Empty
        Dim inputFile As StreamReader
        lblOutput.Text = String.Empty
        If File.Exists("Address Book.txt") Then
            inputFile = File.OpenText("Address Book.txt")
        Else
            MsgBox("File Does not Exists",, "ERROR")
            Exit Sub
        End If

        strName = InputBox("Please enter then name of the person", "Input")

        Do Until inputFile.EndOfStream
            addressLine = inputFile.ReadLine()
            For i = 0 To addressLine.Length - 1
                If addressLine(i) = " " Then
                    tempStr = addressLine.Substring(0, i)
                    Exit For
                End If
            Next

            If strName.ToLower() = tempStr.Trim().ToLower() Then
                lstDisplay.Items.Add(addressLine)
            End If

        Loop
        inputFile.Close()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim addressLine As String
        Dim inputFile As StreamReader
        lstDisplay.Items.Clear()

        If File.Exists("Address Book.txt") Then
            inputFile = File.OpenText("Address Book.txt")
        Else
            MsgBox("File Does not Exists",, "ERROR")
            Exit Sub
        End If

        Do Until inputFile.EndOfStream
            addressLine = inputFile.ReadLine()
            lstDisplay.Items.Add(addressLine)
        Loop
        inputFile.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblOutput.Text = "                       Enter your Number in the following format
                                              (xxx) xxx-xxxx"
        txtPhoneNumber.Clear()
        txtName.Clear()
        txtAddress.Clear()
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
                    lblOutput.Text &= Convert.ToInt16(strInput(i)) & vbCr
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
