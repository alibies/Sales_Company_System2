Public Class formPayment

    Private Sub cashTB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cashTB.KeyPress
        If Not charactersallowed.Contains(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub chargeTB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles chequeTB.KeyPress
        If Not charactersallowed.Contains(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        Me.Close()
    End Sub

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        Dim count As Double
        count = Double.Parse(FormCasher.subtotalLbl.Text)
        cheque = Double.Parse(chequeTB.Text)

        cash = Double.Parse(cashTB.Text)
        subtot = Double.Parse(subtotalLbl.Text)
        'accumulatedpayment = Double.Parse(cashTB.Text) + Double.Parse(chequeTB.Text)
        accumulatedpayment = cheque + cash
        ' change = (accumulatedpayment - Double.Parse(subtotalLbl.Text))
        change = accumulatedpayment - subtot
        If accumulatedpayment < subtot Then
            MsgBox("The customer needs " & change & " pesos more to proceed transaction!")
            accumulatedpayment = 0
        Else
            loginBtn.Text = MessageBox.Show("Are you sure you want to proceed the transaction?", "CONFIRMATION!", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If loginBtn.Text = DialogResult.Yes Then
                loginBtn.Text = "OK"
                For Each dr As DataGridViewRow In FormCasher.DataGridView1.Rows
                    productCodes = dr.Cells(0).Value.ToString()
                    quantityrow = dr.Cells(3).Value.ToString()
                    itemdesc = dr.Cells(1).Value.ToString()
                    updateQuantity()
                    retrieveStockinforDeduction()
                    addStockOutTransaction()
                    salescount += 1
                    salestotul += count

                Next
                loginBtn.Text = "OK"
                Me.Close()
                FormCasher.cashtenderedLbl.Text = accumulatedpayment
                FormCasher.changeLbl.Text = change
                dt = New DataTable
                With dt
                    .Columns.Add("Barcode")
                    .Columns.Add("Item Description")
                    .Columns.Add("Unit Price")
                    .Columns.Add("Quantity")
                    .Columns.Add("Total")
                    .Columns.Add("Subtotal")
                    .Columns.Add("Cash")
                    .Columns.Add("Change")
                    .Columns.Add("Discount")
                    .Columns.Add("Time")
                    .Columns.Add("Cashier")
                End With
                For Each dr As DataGridViewRow In FormCasher.DataGridView1.Rows
                    dt.Rows.Add(dr.Cells(0).Value, dr.Cells(1).Value, dr.Cells(2).Value, dr.Cells(3).Value, dr.Cells(4).Value, FormCasher.subtotalLbl.Text, FormCasher.cashtenderedLbl.Text, FormCasher.changeLbl.Text, FormCasher.discountLbl.Text, FormCasher.dateLbl.Text, FormCasher.cashierLbl.Text)
                Next
                '   Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
                '   rptDoc = New crystalReceipt
                ' rptDoc.SetDataSource(dt)
                ' formReceipt.receiptViewer.ReportSource = rptDoc
                ' formReceipt.ShowDialog()
                ' formReceipt.Dispose()
            End If
        End If
    End Sub
    Private Sub formPayment_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            loginBtn.PerformClick()
        End If
    End Sub

    Private Sub formPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        subtotalLbl.Text = FormCasher.totalamountLbl.Text
        Me.KeyPreview = True
    End Sub
End Class