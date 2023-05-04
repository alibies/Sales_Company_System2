Imports System.Data.SqlClient

Module posModule


    Public Sub checkBarcode()
        If FormCasher.barcodeTB.Text = "" Then
            MsgBox("Scan or input the product ID or barcode!")
            FormCasher.barcodeTB.Focus()
        ElseIf seniordiscount = "YES" Then
            MsgBox("Cannot add new product for purchase, discount already applied!")
            formPayment.subtotalLbl.Text = FormCasher.subtotalLbl.Text
            formPayment.ShowDialog()
            formPayment.Dispose()
        ElseIf employeediscount = "YES" Then
            MsgBox("Cannot add new product for purchase, discount already applied!")
            formPayment.subtotalLbl.Text = FormCasher.subtotalLbl.Text
            formPayment.ShowDialog()
            formPayment.Dispose()
        Else
            Try
                dbConnection()
                sql = "SELECT * FROM products_database WHERE Product_ID_Barcode = @ProductID;"
                cmd = New SqlCommand
                With cmd
                    .Connection = conn
                    .CommandText = sql
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@ProductID", FormCasher.barcodeTB.Text)
                End With
                da = New SqlDataAdapter
                dt = New DataTable
                da.SelectCommand = cmd
                da.Fill(dt)
                If dt.Rows.Count > 0 Then
                    Dim productcode, itemdescription, unitprice As String
                    productcode = dt.Rows(0).Item(1)
                    itemdescription = dt.Rows(0).Item(2)
                    unitprice = dt.Rows(0).Item(3)
                    supportnameTR = dt.Rows(0).Item(6)
                    formQuantity.productIDLbl.Text = productcode
                    formQuantity.itemdescriptionLbl.Text = itemdescription
                    formQuantity.unitpriceLbl.Text = unitprice
                    formQuantity.ShowDialog()
                    formQuantity.Dispose()
                Else
                    MsgBox("The product ID or barcode has not yet been registered!")
                    FormCasher.barcodeTB.Text = ""
                    FormCasher.barcodeTB.Focus()
                End If
            Catch ex As SqlException
                MsgBox(ex.Message)
            Finally
                conn.Close()
                da.Dispose()
            End Try
        End If
    End Sub

    Public Sub quantityCalculation()
        If formQuantity.quantityTB.Text = "" Then
            MsgBox("Enter quantity!")
            formQuantity.quantityTB.Focus()
        Else
            totalunitprice = formQuantity.unitpriceLbl.Text * quantity
            vatprice = totalunitprice * vat
            newprice = totalunitprice - vatprice
            FormCasher.totalamountLbl.Text = FormCasher.totalamountLbl.Text + newprice
            FormCasher.vatLbl.Text = FormCasher.vatLbl.Text + vatprice
            FormCasher.subtotalLbl.Text = FormCasher.subtotalLbl.Text + totalunitprice
            FormCasher.DataGridView1.Rows.Add(New String() {formQuantity.productIDLbl.Text, formQuantity.itemdescriptionLbl.Text, formQuantity.unitpriceLbl.Text, quantity, totalunitprice})
            formQuantity.Close()
        End If
    End Sub
    Public Sub discountnumshow()
        seniordiscount = "YES"
        FormCasher.discountLbl.Text = Senior
        FormCasher.totalamountLbl.Text = FormCasher.totalamountLbl.Text - (FormCasher.totalamountLbl.Text * Senior)
    End Sub
End Module
