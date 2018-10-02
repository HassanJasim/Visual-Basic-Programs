'Hassan Jasim 400057926
Option Strict On
Public Class Form1
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim itemQuantity As Integer
        Dim itemPrice, Subtotal, HST, totalPrice As Double
        Dim itemName As String = String.Empty

        If txtName.Text = String.Empty Then
            txtName.Clear()
            txtName.Focus()
            MsgBox("Please Enter a valid item name",, "ERROR")
            Exit Sub
        End If

        itemName = txtName.Text
        itemName = itemName.Trim()

        If Not Integer.TryParse(txtQuantity.Text, itemQuantity) Then
            txtQuantity.Clear()
            txtQuantity.Focus()
            MsgBox("Please Enter a valid Quantity",, "ERROR")
            Exit Sub
        End If

        If Not Double.TryParse(txtPrice.Text, itemPrice) Then
            txtPrice.Clear()
            txtPrice.Focus()
            MessageBox.Show("Item Price cannot be alphabetical!")
            Exit Sub
        End If

        If itemQuantity <= 0 Then
            MessageBox.Show("Item Quantity cannot be less than or equal to Zero")
            Exit Sub
        End If

        If itemPrice <= 0 Then
            MessageBox.Show("Item Price cannot be less than or equal to Zero")
            Exit Sub
        End If

        Subtotal = price(itemPrice, itemQuantity)

        If chkTax.Checked Then
            HST = Subtotal * 0.13
            totalPrice = HST + Subtotal
            lstOutput.Items.Add("Item's Name: " & itemName.ToString() & vbCrLf)
            lstOutput.Items.Add("Item's Quantity: " & itemQuantity.ToString() & vbCrLf)
            lstOutput.Items.Add("Item's Price: " & itemPrice.ToString("c") & vbCrLf)
            lstOutput.Items.Add("Subtotal: " & Subtotal.ToString("c") & vbCrLf)
            lstOutput.Items.Add("HST: " & HST.ToString("c") & vbCrLf)
            lstOutput.Items.Add("Total Amount: " & totalPrice.ToString("c"))
        Else
            lstOutput.Items.Add("Item's Name: " & itemName.ToString() & vbCrLf)
            lstOutput.Items.Add("Item's Quantity: " & itemQuantity.ToString() & vbCrLf)
            lstOutput.Items.Add("Item's Price: " & itemPrice.ToString("c") & vbCrLf)
            lstOutput.Items.Add("Subtotal: " & Subtotal.ToString("c") & vbCrLf)
        End If

        txtName.Text = String.Empty
        txtPrice.Text = String.Empty
        txtQuantity.Text = String.Empty
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtName.Clear()
        txtPrice.Clear()
        txtQuantity.Clear()
        lstOutput.Items.Clear()
        radRed.Checked = False
        radYellow.Checked = False
        chkTax.Checked = False
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Function price(ByVal itemPrice As Double, ByVal itemQuantity As Integer) As Double

        Dim Subtotal As Double
        Dim Discount As Double

        If radRed.Checked Then
            Subtotal = itemPrice * itemQuantity

            If itemQuantity = 1 Then
                Discount = Subtotal * 0.2
                Subtotal -= Discount

            ElseIf itemQuantity = 2 Then
                Discount = Subtotal * 0.3
                Subtotal -= Discount

            ElseIf itemQuantity > 2 Then
                Discount = Subtotal * 0.4
                Subtotal -= Discount
            End If
        End If

        If radYellow.Checked Then
            Subtotal = itemPrice * itemQuantity
            If itemQuantity = 2 Then
                Discount = Subtotal * 0.1
                Subtotal -= Discount

            ElseIf itemQuantity > 2 Then
                Discount = Subtotal * 0.15
                Subtotal -= Discount
            End If
        End If

        Return Subtotal
    End Function
End Class
