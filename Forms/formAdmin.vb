Imports System.Data.SqlClient
Imports System.IO

Public Class formAdmin

    Dim file As String

    Function GetDirPath(ByVal file As String) As String
        Dim fi As New FileInfo(file)
        Return fi.Directory.ToString
    End Function

    Private Sub pclearBtn_Click(sender As Object, e As EventArgs) Handles pclearBtn.Click
        clearProducts()
    End Sub

    Private Sub paddBtn_Click(sender As Object, e As EventArgs) Handles paddBtn.Click
        If productidTB.Text = "" Then
            MsgBox("Input product ID or barcode!")
        ElseIf productnameTB.Text = "" Then
            MsgBox("Input product name!")
        ElseIf priceTB.Text = "" Then
            MsgBox("Input price!")
        ElseIf pricecodeTB.Text = "" Then
            MsgBox("Input price code!")
        ElseIf productcategoryCB.Text = "" Then
            MsgBox("Select product category!")
        ElseIf nameofsupplierCB.Text = "" Then
            MsgBox("Select name of supplier!")
        ElseIf unitTB.Text = "" Then
            MsgBox("Input unit!")
        Else
            addProducts()
            retrieveProducts()
            clearProducts()
            retrievePClist()
            retrieveNSlist()
            retrieveProductQuantity()
            retrieveProductsforDefective()
        End If
    End Sub

    Private Sub pupdateBtn_Click(sender As Object, e As EventArgs) Handles pupdateBtn.Click
        If productidTB.Text = "" Then
            MsgBox("Input product ID or barcode!")
        ElseIf productnameTB.Text = "" Then
            MsgBox("Input product name!")
        ElseIf priceTB.Text = "" Then
            MsgBox("Input price!")
        ElseIf pricecodeTB.Text = "" Then
            MsgBox("Input price code!")
        ElseIf productcategoryCB.Text = "" Then
            MsgBox("Select product category!")
        ElseIf nameofsupplierCB.Text = "" Then
            MsgBox("Select name of supplier!")
        Else
            updateProducts()
            retrieveProducts()
            clearProducts()
            retrievePClist()
            retrieveNSlist()
            retrieveProductQuantity()
            retrieveProductsforDefective()
        End If
    End Sub

    Private Sub pdeleteBtn_Click(sender As Object, e As EventArgs) Handles pdeleteBtn.Click
        If productID.Text = "" Then
            MsgBox("Select from the product table to be deleted!")
        Else
            deleteProducts()
            retrieveProducts()
            clearProducts()
            retrievePClist()
            retrieveNSlist()
            retrieveProductQuantity()
            retrieveProductsforDefective()
        End If
    End Sub

    Private Sub pcclearBtn_Click(sender As Object, e As EventArgs) Handles pcclearBtn.Click
        clearProductCategory()
    End Sub

    Private Sub pcaddBtn_Click(sender As Object, e As EventArgs) Handles pcaddBtn.Click
        If categorynameTB.Text = "" Then
            MsgBox("Input product category!")
        Else
            addCategoryProducts()
            clearProductCategory()
            retrieveProductsCategory()
            retrievePClist()
        End If
    End Sub

    Private Sub pcupdateBtn_Click(sender As Object, e As EventArgs) Handles pcupdateBtn.Click
        If categorynameTB.Text = "" Then
            MsgBox("Input product category!")
        ElseIf categoryID.Text = "" Then
            MsgBox("Select product category to be deleted or updated!")
        Else
            updateCategoryProducts()
            clearProductCategory()
            retrieveProductsCategory()
            retrievePClist()
        End If
    End Sub

    Private Sub pcdeleteBtn_Click(sender As Object, e As EventArgs) Handles pcdeleteBtn.Click
        If categorynameTB.Text = "" Then
            MsgBox("Input product category!")
        ElseIf categoryID.Text = "" Then
            MsgBox("Select product category to be deleted or updated!")
        Else
            deleteCategoryProducts()
            clearProductCategory()
            retrieveProductsCategory()
            retrievePClist()
        End If
    End Sub

    Private Sub sclearBtn_Click(sender As Object, e As EventArgs) Handles sclearBtn.Click
        clearSuppliers()
    End Sub

    Private Sub saddBtn_Click(sender As Object, e As EventArgs) Handles saddBtn.Click
        If suppliernameTB.Text = "" Then
            MsgBox("Input supplier name!")
        ElseIf addressTB.Text = "" Then
            MsgBox("Input address!")
        ElseIf contactnoTB.Text = "" Then
            MsgBox("Input contact number!")
        ElseIf tinnumberTB.Text = "" Then
            MsgBox("Input TIN number!")
        Else
            addSuppliers()
            retrieveSuppliers()
            retrieveNSlist()
            clearSuppliers()
        End If
    End Sub

    Private Sub supdateBtn_Click(sender As Object, e As EventArgs) Handles supdateBtn.Click
        If suppliernameTB.Text = "" Then
            MsgBox("Input supplier name!")
        ElseIf addressTB.Text = "" Then
            MsgBox("Input address!")
        ElseIf contactnoTB.Text = "" Then
            MsgBox("Input contact number!")
        ElseIf tinnumberTB.Text = "" Then
            MsgBox("Input TIN number!")
        ElseIf supplierID.Text = "" Then
            MsgBox("Select supplier to be deleted or updated!")
        Else
            updateSuppliers()
            retrieveSuppliers()
            retrieveNSlist()
            clearSuppliers()
        End If
    End Sub

    Private Sub sdeleteBtn_Click(sender As Object, e As EventArgs) Handles sdeleteBtn.Click
        If supplierID.Text = "" Then
            MsgBox("Select supplier to be deleted or updated!")
        Else
            deleteSuppliers()
            retrieveSuppliers()
            retrieveNSlist()
            clearSuppliers()
        End If
    End Sub

    Private Sub eclearBtn_Click(sender As Object, e As EventArgs) Handles eclearBtn.Click
        clearEmployees()
    End Sub

    Private Sub eaddBtn_Click(sender As Object, e As EventArgs) Handles eaddBtn.Click
        If firstnameTB.Text = "" Then
            MsgBox("Input firstname!")
        ElseIf middlenameTB.Text = "" Then
            MsgBox("Input middlename!")
        ElseIf lastnameTB.Text = "" Then
            MsgBox("Input lastname!")
        ElseIf usernameTB.Text = "" Then
            MsgBox("Input username!")
        ElseIf PasswordTB.Text = "" Then
            MsgBox("Input password!")
        Else
            addEmployees()
            retrieveEmployees()
            clearEmployees()
        End If
    End Sub

    Private Sub eupdateBtn_Click(sender As Object, e As EventArgs) Handles eupdateBtn.Click
        If firstnameTB.Text = "" Then
            MsgBox("Input firstname!")
        ElseIf middlenameTB.Text = "" Then
            MsgBox("Input middlename!")
        ElseIf lastnameTB.Text = "" Then
            MsgBox("Input lastname!")
        ElseIf employeeID.Text = "" Then
            MsgBox("Select employee to be deleted or updated!")
        Else
            updateEmployees()
            retrieveEmployees()
            clearEmployees()
        End If
    End Sub

    Private Sub edeleteBtn_Click(sender As Object, e As EventArgs) Handles edeleteBtn.Click
        If Employeebut.Text = "" Then
            MsgBox("Select employeeID to be deleted or updated!")
        Else
            deleteEmployees()
            retrieveEmployees()
            clearEmployees()
        End If
    End Sub

    Private Sub formAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        retrieveProducts()
        reterieveCustomer()
        retrieveEmployees()
        retrievePClist()
        retrieveProductsCategory()
        retrieveSuppliers()
        retrieveNSlist()
        retrieveOverallSales()
        retrieveProductQuantity()
        retrieveStockTrail()
        retrieveStockOutTrail()
        retrieveProductsforDefective()
        retrieveDefectiveProductList()
        retrieveExpirationList()
        retrieveEmployeeLogs()
        retrieveEmployeeLogsList()
        retrieveLessProducts()
        chart()
        seniordiscountTB.Text = My.Settings("Senior").ToString
        vatTB.Text = My.Settings("Vat").ToString
        For Each dr As DataGridViewRow In Me.expirationDGV.Rows
            Dim dateexpiration As String = dr.Cells(5).Value.ToString
            If dateexpiration = Date.Now.ToString("MM/dd/yyyy") Then
                MsgBox("Your stock " & dr.Cells(2).Value.ToString & " has expired! It is now considered as sales out!")
                Try
                    dbConnection()
                    sql = "UPDATE products_database SET Quantity = Quantity - @Quantity WHERE Product_ID_Barcode = @ID, Name = @Name, Name_of_Supplier = @Supplier;"
                    cmd = New SqlCommand
                    With cmd
                        .Connection = conn
                        .CommandText = sql
                        .Parameters.Clear()
                        .Parameters.AddWithValue("@Quantity", dr.Cells(3).Value.ToString)
                        .Parameters.AddWithValue("@ID", dr.Cells(1).Value.ToString)
                        .Parameters.AddWithValue("@Name", dr.Cells(2).Value.ToString)
                        .Parameters.AddWithValue("@Supplier", dr.Cells(4).Value.ToString)
                        .ExecuteNonQuery()
                    End With
                Catch ex As SqlException
                    MsgBox(ex.Message)
                Finally
                    conn.Close()
                End Try
                Try
                    dbConnection()
                    sql = "DELETE FROM stocks_database WHERE ID = @ID;"
                    cmd = New SqlCommand
                    With cmd
                        .Connection = conn
                        .CommandText = sql
                        .Parameters.Clear()
                        .Parameters.AddWithValue("@ID", dr.Cells(0).Value.ToString)
                        .ExecuteNonQuery()
                    End With
                Catch ex As SqlException
                    MsgBox(ex.Message)
                Finally
                    conn.Close()
                End Try
            End If
        Next
        Me.KeyPreview = True
    End Sub

    Private Sub productsDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles productsDGV.CellContentClick
        If e.RowIndex >= 0 Then
            Dim index As Integer
            index = e.RowIndex
            Dim row As DataGridViewRow
            row = productsDGV.Rows(index)
            productID.Text = row.Cells(0).Value.ToString()
            productidTB.Text = row.Cells(1).Value.ToString()
            productnameTB.Text = row.Cells(2).Value.ToString()
            priceTB.Text = row.Cells(3).Value.ToString()
            productcategoryCB.Text = row.Cells(4).Value.ToString()
            pricecodeTB.Text = row.Cells(5).Value.ToString()
            nameofsupplierCB.Text = row.Cells(6).Value.ToString()
            deliveryDTP.Value = row.Cells(7).Value.ToString()
            unitTB.Text = row.Cells(8).Value.ToString()
        End If
    End Sub

    Private Sub productscategoryDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles productscategoryDGV.CellContentClick
        If e.RowIndex >= 0 Then
            Dim index As Integer
            index = e.RowIndex
            Dim row As DataGridViewRow
            row = productscategoryDGV.Rows(index)
            categoryID.Text = row.Cells(0).Value.ToString()
            categorynameTB.Text = row.Cells(1).Value.ToString()
        End If
    End Sub

    Private Sub supplierDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles supplierDGV.CellContentClick
        If e.RowIndex >= 0 Then
            Dim index As Integer
            index = e.RowIndex
            Dim row As DataGridViewRow
            row = supplierDGV.Rows(index)
            supplierID.Text = row.Cells(0).Value.ToString()
            suppliernameTB.Text = row.Cells(1).Value.ToString()
            addressTB.Text = row.Cells(2).Value.ToString()
            contactnoTB.Text = row.Cells(3).Value.ToString()
            tinnumberTB.Text = row.Cells(4).Value.ToString()
        End If
    End Sub

    Private Sub employeeDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles employeeDGV.CellContentClick
        If e.RowIndex >= 0 Then
            Dim index As Integer
            index = e.RowIndex
            Dim row As DataGridViewRow
            row = employeeDGV.Rows(index)
            employeeID.Text = row.Cells(0).Value.ToString()
            firstnameTB.Text = row.Cells(1).Value.ToString()
            middlenameTB.Text = row.Cells(2).Value.ToString()
            lastnameTB.Text = row.Cells(3).Value.ToString()
            usernameTB.Text = row.Cells(4).Value.ToString()
            PasswordTB.Text = row.Cells(5).Value.ToString()
            userlevelCB.Text = row.Cells(6).Value.ToString()
        End If
    End Sub

    Private Sub logoutBtn_Click(sender As Object, e As EventArgs) Handles logoutBtn.Click
        checkmasrefresh = "NO"
        logoutBtn.Text = MessageBox.Show("Are you sure you want to logout?", "WARNING: LOGGING OUT.", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If logoutBtn.Text = DialogResult.Yes Then
            logoutBtn.Text = "Logout"
            Me.Close()
            formLogin.Show()
            formLogin.usernameTB.Focus()
        Else
            logoutBtn.Text = "Logout"
        End If
    End Sub

    Private Sub coverageCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles coverageCB.SelectedIndexChanged
        If coverageCB.SelectedItem = "Overall" Then
            retrieveOverallSales()
            MsgBox("Showing overall sales!")
            monthCB.Enabled = False
            dayCB.Enabled = False
            yearCB.Enabled = False
            searchBtn.Enabled = False
            monthCB.SelectedItem = ""
            dayCB.SelectedItem = ""
            yearCB.SelectedItem = ""
        ElseIf coverageCB.SelectedItem = "Daily" Then
            monthCB.Enabled = True
            dayCB.Enabled = True
            yearCB.Enabled = True
            searchBtn.Enabled = True
            monthCB.SelectedItem = ""
            dayCB.SelectedItem = ""
            yearCB.SelectedItem = ""
        ElseIf coverageCB.SelectedItem = "Monthly" Then
            monthCB.Enabled = True
            dayCB.Enabled = False
            yearCB.Enabled = False
            searchBtn.Enabled = True
            monthCB.SelectedItem = ""
            dayCB.SelectedItem = ""
            yearCB.SelectedItem = ""
        ElseIf coverageCB.SelectedItem = "Yearly" Then
            monthCB.Enabled = False
            dayCB.Enabled = False
            yearCB.Enabled = True
            searchBtn.Enabled = True
            monthCB.SelectedItem = ""
            dayCB.SelectedItem = ""
            yearCB.SelectedItem = ""
        Else
            monthCB.Enabled = False
            dayCB.Enabled = False
            yearCB.Enabled = False
            searchBtn.Enabled = False
            monthCB.SelectedItem = ""
            dayCB.SelectedItem = ""
            yearCB.SelectedItem = ""
        End If
    End Sub

    Private Sub searchBtn_Click(sender As Object, e As EventArgs) Handles searchBtn.Click
        If coverageCB.SelectedItem = "Daily" Then
            If monthCB.SelectedItem = "" Then
                MsgBox("Select month!")
            ElseIf dayCB.SelectedItem = "" Then
                MsgBox("Select day!")
            ElseIf yearCB.SelectedItem = "" Then
                MsgBox("Select year!")
            Else
                retrieveDailySales()
            End If
        ElseIf coverageCB.SelectedItem = "Monthly" Then
            If monthCB.SelectedItem = "" Then
                MsgBox("Select month!")
            Else
                retrieveMonthlySales()
            End If
        ElseIf coverageCB.SelectedItem = "Yearly" Then
            If yearCB.SelectedItem = "" Then
                MsgBox("Select year!")
            Else
                retrieveYearlySales()
            End If
        End If
    End Sub

    Private Sub printpreviewBtn_Click(sender As Object, e As EventArgs) Handles printpreviewBtn.Click
        If salesDGV.Rows.Count <= 0 Then
            MsgBox("No data to be print preview!")
        Else
            If coverageCB.SelectedItem = "" Then
                dt = New DataTable
                With dt
                    .Columns.Add("Transaction ID")
                    .Columns.Add("Subtotal")
                    .Columns.Add("Date")
                    .Columns.Add("Time")
                    .Columns.Add("Description")
                    .Columns.Add("Total Sales")
                End With
                totalsales = 0
                For Each dr As DataGridViewRow In salesDGV.Rows
                    totalsales = totalsales + Double.Parse(dr.Cells(1).Value)
                    dt.Rows.Add(dr.Cells(0).Value, dr.Cells(1).Value, dr.Cells(2).Value, dr.Cells(3).Value, "OVERALL SALES REPORT.", totalsales.ToString)
                Next
                '  Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
                ' rptDoc = New salesReports
                ' rptDoc.SetDataSource(dt)
                ' formSales.salesReportViewer.ReportSource = rptDoc
                formSales.ShowDialog()
                formSales.Dispose()
            ElseIf coverageCB.SelectedItem = "Overall" Then
                dt = New DataTable
                With dt
                    .Columns.Add("Transaction ID")
                    .Columns.Add("Subtotal")
                    .Columns.Add("Date")
                    .Columns.Add("Time")
                    .Columns.Add("Description")
                    .Columns.Add("Total Sales")
                End With
                totalsales = 0
                For Each dr As DataGridViewRow In salesDGV.Rows
                    totalsales = totalsales + Double.Parse(dr.Cells(1).Value)
                    dt.Rows.Add(dr.Cells(0).Value, dr.Cells(1).Value, dr.Cells(2).Value, dr.Cells(3).Value, "OVERALL SALES REPORT.", totalsales.ToString)
                Next
                ' Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
                'rptDoc = New salesReports
                'rptDoc.SetDataSource(dt)
                'formSales.salesReportViewer.ReportSource = rptDoc ''
                formSales.ShowDialog()
                formSales.Dispose()
            ElseIf coverageCB.SelectedItem = "Daily" Then
                dt = New DataTable
                With dt
                    .Columns.Add("Transaction ID")
                    .Columns.Add("Subtotal")
                    .Columns.Add("Date")
                    .Columns.Add("Time")
                    .Columns.Add("Description")
                    .Columns.Add("Total Sales")
                End With
                totalsales = 0
                For Each dr As DataGridViewRow In salesDGV.Rows
                    totalsales = totalsales + Double.Parse(dr.Cells(1).Value)
                    dt.Rows.Add(dr.Cells(0).Value, dr.Cells(1).Value, dr.Cells(2).Value, dr.Cells(3).Value, "DAILY SALES REPORT FOR THE DAY OF " + monthCB.SelectedItem + " " + dayCB.SelectedItem + ", " + yearCB.SelectedItem + ".", totalsales.ToString)
                Next
                ' Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
                ' rptDoc = New salesReports
                'rptDoc.SetDataSource(dt)
                'formSales.salesReportViewer.ReportSource = rptDoc
                formSales.ShowDialog()
                formSales.Dispose()
            ElseIf coverageCB.SelectedItem = "Monthly" Then
                dt = New DataTable
                With dt
                    .Columns.Add("Transaction ID")
                    .Columns.Add("Subtotal")
                    .Columns.Add("Date")
                    .Columns.Add("Time")
                    .Columns.Add("Description")
                    .Columns.Add("Total Sales")
                End With
                totalsales = 0
                For Each dr As DataGridViewRow In salesDGV.Rows
                    totalsales = totalsales + Double.Parse(dr.Cells(1).Value)
                    dt.Rows.Add(dr.Cells(0).Value, dr.Cells(1).Value, dr.Cells(2).Value, dr.Cells(3).Value, "MONTHLY SALES REPORT FOR THE MONTH OF " + monthCB.SelectedItem + ".", totalsales.ToString)
                Next
                '  Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
                ' rptDoc = New salesReports
                'rptDoc.SetDataSource(dt)
                'formSales.salesReportViewer.ReportSource = rptDoc
                formSales.ShowDialog()
                formSales.Dispose()
            ElseIf coverageCB.SelectedItem = "Yearly" Then
                dt = New DataTable
                With dt
                    .Columns.Add("Transaction ID")
                    .Columns.Add("Subtotal")
                    .Columns.Add("Date")
                    .Columns.Add("Time")
                    .Columns.Add("Description")
                    .Columns.Add("Total Sales")
                End With
                totalsales = 0
                For Each dr As DataGridViewRow In salesDGV.Rows
                    totalsales = totalsales + Double.Parse(dr.Cells(1).Value)
                    dt.Rows.Add(dr.Cells(0).Value, dr.Cells(1).Value, dr.Cells(2).Value, dr.Cells(3).Value, "YEARLY SALES REPORT FOR THE YEAR OF " + yearCB.SelectedItem + ".", totalsales.ToString)
                Next
                'Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
                'rptDoc = New salesReports
                'rptDoc.SetDataSource(dt)
                'formSales.salesReportViewer.ReportSource = rptDoc
                formSales.ShowDialog()
                formSales.Dispose()
            End If
        End If
    End Sub

    Private Sub employeediscountTB_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not charactersallowed.Contains(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub seniordiscountTB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles seniordiscountTB.KeyPress
        If Not charactersallowed.Contains(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub seniordiscountTB_TextChanged(sender As Object, e As EventArgs) Handles seniordiscountTB.TextChanged
        If seniordiscountTB.TextLength < 2 Then
            MsgBox("Format is fixed! Base your discount in decimal format!")
            seniordiscountTB.Text = "0."
        End If
    End Sub


    Private Sub seniorchangeBtn_Click(sender As Object, e As EventArgs) Handles seniorchangeBtn.Click

        My.Settings.Item("Senior") = Double.Parse(seniordiscountTB.Text)
        FormCasher.discountLbl.Text = seniordiscountTB.Text
        My.Settings.Save()
        MsgBox("Successfully saved new discount for senior!")
    End Sub

    Private Sub stockinclearBtn_Click(sender As Object, e As EventArgs) Handles stockinclearBtn.Click
        stockinnameTB.Text = ""
        stockinquantityTB.Text = ""
        stockinproductLbl.Text = ""
        expirationDTP.Value = ("MM/dd/yyyy")
    End Sub

    Private Sub stockinDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles stockinDGV.CellContentClick
        If e.RowIndex >= 0 Then
            Dim index As Integer
            index = e.RowIndex
            Dim row As DataGridViewRow
            row = stockinDGV.Rows(index)
            stockinproductLbl.Text = row.Cells(0).Value.ToString()
            stockinnameTB.Text = row.Cells(1).Value.ToString()
            stockinsuppliernameLbl.Text = row.Cells(3).Value.ToString()
        End If
    End Sub

    Private Sub stockinaddBtn_Click(sender As Object, e As EventArgs) Handles stockinaddBtn.Click
        If stockinnameTB.Text = "" Then
            MsgBox("Please select a product in the data grid view!")
        ElseIf stockinquantityTB.Text = "" Then
            MsgBox("Please input the quantity for stock in!")
            ' ElseIf Date.Parse(expirationDTP.Value.ToString("MM/dd/yyyy")) <= Date.Parse(Date.Now.ToLongTimeString("MM/dd/yyyy")) Then
            ' MsgBox("Select the expiration date of the stock!")
        Else
            updateStockQuantity()
        End If
    End Sub

    Private Sub stockinquantityTB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles stockinquantityTB.KeyPress
        If Not charactersallowed.Contains(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub expmonthCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles expmonthCB.SelectedIndexChanged
        If expmonthCB.SelectedItem = "" Then
            expdayCB.Enabled = False
        ElseIf expmonthCB.SelectedItem = "January" Then
            expdayCB.Enabled = True
            monthexp = "01"
        ElseIf expmonthCB.SelectedItem = "February" Then
            expdayCB.Enabled = True
            monthexp = "02"
        ElseIf expmonthCB.SelectedItem = "March" Then
            expdayCB.Enabled = True
            monthexp = "03"
        ElseIf expmonthCB.SelectedItem = "April" Then
            expdayCB.Enabled = True
            monthexp = "04"
        ElseIf expmonthCB.SelectedItem = "May" Then
            expdayCB.Enabled = True
            monthexp = "05"
        ElseIf expmonthCB.SelectedItem = "June" Then
            expdayCB.Enabled = True
            monthexp = "06"
        ElseIf expmonthCB.SelectedItem = "July" Then
            expdayCB.Enabled = True
            monthexp = "07"
        ElseIf expmonthCB.SelectedItem = "August" Then
            expdayCB.Enabled = True
            monthexp = "08"
        ElseIf expmonthCB.SelectedItem = "September" Then
            expdayCB.Enabled = True
            monthexp = "09"
        ElseIf expmonthCB.SelectedItem = "October" Then
            expdayCB.Enabled = True
            monthexp = "10"
        ElseIf expmonthCB.SelectedItem = "November" Then
            expdayCB.Enabled = True
            monthexp = "11"
        ElseIf expmonthCB.SelectedItem = "December" Then
            expdayCB.Enabled = True
            monthexp = "12"
        End If
    End Sub

    Private Sub expdayCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles expdayCB.SelectedIndexChanged
        If expdayCB.SelectedItem = "" Then
            expyearCB.Enabled = False
        Else
            expyearCB.Enabled = True
        End If
    End Sub

    Private Sub expSearchBtn_Click(sender As Object, e As EventArgs) Handles expSearchBtn.Click
        If expyearCB.SelectedItem = "" Then
            MsgBox("Please select the year of the expiration date!")
        Else
            retrieveExpirationDateofStocks()
        End If
    End Sub

    Private Sub expyearCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles expyearCB.SelectedIndexChanged
        If expyearCB.SelectedItem = "" Then
            expSearchBtn.Enabled = False
        Else
            expSearchBtn.Enabled = True
        End If
    End Sub

    Private Sub defectiveClearBtn_Click(sender As Object, e As EventArgs) Handles defectiveClearBtn.Click
        defectiveidLbl.Text = ""
        defectivenameTB.Text = ""
        defectivequantityTB.Text = ""
        defectivesupplierTB.Text = ""
        remarksTB.Text = ""
    End Sub

    Private Sub defectiveDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles defectiveDGV.CellContentClick
        If e.RowIndex >= 0 Then
            Dim index As Integer
            index = e.RowIndex
            Dim row As DataGridViewRow
            row = defectiveDGV.Rows(index)
            defectiveidLbl.Text = row.Cells(0).Value.ToString()
            defectivenameTB.Text = row.Cells(1).Value.ToString()
            defectivesupplierTB.Text = row.Cells(3).Value.ToString()
        End If
    End Sub

    Private Sub defectivequantityTB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles defectivequantityTB.KeyPress
        If Not charactersallowed.Contains(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub defectiveAddBtn_Click(sender As Object, e As EventArgs) Handles defectiveAddBtn.Click
        If defectivenameTB.Text = "" Then
            MsgBox("Please select which product to set defective!")
        ElseIf defectivequantityTB.Text = "" Then
            MsgBox("Please input how many quantity to be labeled as defective!")
        ElseIf remarksTB.Text = "" Then
            MsgBox("Please input the remarks for the defective item!")
        ElseIf defectivestatusCB.SelectedItem = "" Then
            MsgBox("Please select the status of the defective item!")
        Else
            retrieveItem2()
            If Integer.Parse(quantitycheck) < Integer.Parse(defectivequantityTB.Text) Then
                MsgBox("Declaring defective item must not exceed to the existing quantity of the product!")
            Else
                retrieveDefectiveProductsifNull()
            End If
        End If
    End Sub

    Private Sub salesreportBtnn_Click(sender As Object, e As EventArgs) Handles salesreportBtnn.Click
        Try
            dbConnection()
            sql = "SELECT Transaction_ID,Customer_name, Subtotal, Date, Time FROM sales_database;"
            cmd = New SqlCommand(sql, conn)
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .ExecuteNonQuery()
            End With
            da = New SqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)
            reportsDGV.DataSource = dt
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dt = New DataTable
            With dt
                .Columns.Add("Transaction ID")
                .Columns.Add("Customer_name")
                .Columns.Add("Subtotal")
                .Columns.Add("Date")
                .Columns.Add("Time")
                .Columns.Add("Description")
                .Columns.Add("Total Sales")
            End With
            totalsales2 = 0
            For Each dr As DataGridViewRow In reportsDGV.Rows
                totalsales2 = totalsales2 + Double.Parse(dr.Cells(1).Value)
                dt.Rows.Add(dr.Cells(0).Value, dr.Cells(1).Value, dr.Cells(2).Value, dr.Cells(3).Value, "OVERALL SALES REPORT.", totalsales2.ToString)
            Next
            ' Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            'rptDoc = New salesReports
            'rptDoc.SetDataSource(dt)
            'formSales.salesReportViewer.ReportSource = rptDoc
            formSales.ShowDialog()
            formSales.Dispose()
        End Try
    End Sub

    Private Sub defectivereportsBtn_Click(sender As Object, e As EventArgs) Handles defectivereportsBtn.Click
        Try
            dbConnection()
            sql = "SELECT * FROM defective_database;"
            cmd = New SqlCommand(sql, conn)
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .ExecuteNonQuery()
            End With
            da = New SqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)
            reportsDGV.DataSource = dt
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dt = New DataTable
            With dt
                .Columns.Add("Product ID")
                .Columns.Add("Name")
                .Columns.Add("Supplier Name")
                .Columns.Add("Quantity")
                .Columns.Add("Remarks")
            End With
            For Each dr As DataGridViewRow In reportsDGV.Rows
                dt.Rows.Add(dr.Cells(0).Value, dr.Cells(1).Value, dr.Cells(2).Value, dr.Cells(3).Value, dr.Cells(4).Value)
            Next
            ' Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            ' rptDoc = New defectiveReports
            ' rptDoc.SetDataSource(dt)
            ' formSales.salesReportViewer.ReportSource = rptDoc
            formSales.ShowDialog()
            formSales.Dispose()
        End Try
    End Sub

    Private Sub stockinreportsBtn_Click(sender As Object, e As EventArgs) Handles stockinreportsBtn.Click
        Try
            dbConnection()
            sql = "SELECT Product_ID_Barcode, Name, Supplier_Name, Quantity, Date, Expiration_Date FROM stocks_database WHERE Status = 'STOCK IN';"
            cmd = New SqlCommand(sql, conn)
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .ExecuteNonQuery()
            End With
            da = New SqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)
            reportsDGV.DataSource = dt
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dt = New DataTable
            With dt
                .Columns.Add("Product ID")
                .Columns.Add("Name")
                .Columns.Add("Supplier Name")
                .Columns.Add("Quantity")
                .Columns.Add("Date")
                .Columns.Add("Expiration Date")
            End With
            For Each dr As DataGridViewRow In reportsDGV.Rows
                dt.Rows.Add(dr.Cells(0).Value, dr.Cells(1).Value, dr.Cells(2).Value, dr.Cells(3).Value, dr.Cells(4).Value, dr.Cells(5).Value)
            Next
            'Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            'rptDoc = New stockinReports
            'rptDoc.SetDataSource(dt)
            'formSales.salesReportViewer.ReportSource = rptDoc
            formSales.ShowDialog()
            formSales.Dispose()
        End Try
    End Sub

    Private Sub stockoutreportBtn_Click(sender As Object, e As EventArgs) Handles stockoutreportBtn.Click
        Try
            dbConnection()
            sql = "SELECT Product_ID_Barcode, Name, Supplier_Name, Quantity, Date FROM stocks_database WHERE Status = 'STOCK OUT';"
            cmd = New SqlCommand(sql, conn)
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .ExecuteNonQuery()
            End With
            da = New SqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)
            reportsDGV.DataSource = dt
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dt = New DataTable
            With dt
                .Columns.Add("Product ID")
                .Columns.Add("Name")
                .Columns.Add("Supplier Name")
                .Columns.Add("Quantity")
                .Columns.Add("Date")
            End With
            For Each dr As DataGridViewRow In reportsDGV.Rows
                dt.Rows.Add(dr.Cells(0).Value, dr.Cells(1).Value, dr.Cells(2).Value, dr.Cells(3).Value, dr.Cells(4).Value)
            Next
            ' Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            ' rptDoc = New stockoutReports
            ' rptDoc.SetDataSource(dt)
            ' formSales.salesReportViewer.ReportSource = rptDoc
            formSales.ShowDialog()
            formSales.Dispose()
        End Try
    End Sub

    Private Sub expirationBtn_Click(sender As Object, e As EventArgs) Handles expirationBtn.Click
        Try
            dbConnection()
            sql = "SELECT Product_ID_Barcode, Name, Supplier_Name, Quantity, Expiration_Date FROM stocks_database WHERE Status = 'STOCK IN';"
            cmd = New SqlCommand(sql, conn)
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .ExecuteNonQuery()
            End With
            da = New SqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)
            reportsDGV.DataSource = dt
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dt = New DataTable
            With dt
                .Columns.Add("Product ID")
                .Columns.Add("Name")
                .Columns.Add("Supplier Name")
                .Columns.Add("Quantity")
                .Columns.Add("Date")
            End With
            For Each dr As DataGridViewRow In reportsDGV.Rows
                dt.Rows.Add(dr.Cells(0).Value, dr.Cells(1).Value, dr.Cells(2).Value, dr.Cells(3).Value, dr.Cells(4).Value)
            Next
            'Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            'rptDoc = New expirationReports
            'rptDoc.SetDataSource(dt)
            'formSales.salesReportViewer.ReportSource = rptDoc
            formSales.ShowDialog()
            formSales.Dispose()
        End Try
    End Sub

    Private Sub productsReportBtn_Click(sender As Object, e As EventArgs) Handles productsReportBtn.Click
        Try
            dbConnection()
            sql = "SELECT Product_ID_Barcode, Name, Name_of_Supplier, Category, Quantity FROM products_database;"
            cmd = New SqlCommand(sql, conn)
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .ExecuteNonQuery()
            End With
            da = New SqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)
            reportsDGV.DataSource = dt
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dt = New DataTable
            With dt
                .Columns.Add("Product ID")
                .Columns.Add("Name")
                .Columns.Add("Supplier Name")
                .Columns.Add("Product Category")
                .Columns.Add("Quantity")
            End With
            For Each dr As DataGridViewRow In reportsDGV.Rows
                dt.Rows.Add(dr.Cells(0).Value, dr.Cells(1).Value, dr.Cells(2).Value, dr.Cells(3).Value, dr.Cells(4).Value)
            Next
            ' Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
            ' rptDoc = New productsReports
            ' rptDoc.SetDataSource(dt)
            ' formSales.salesReportViewer.ReportSource = rptDoc
            formSales.ShowDialog()
            formSales.Dispose()
        End Try
    End Sub

    Private Sub vatchangeBtn_Click(sender As Object, e As EventArgs) Handles vatchangeBtn.Click
        My.Settings.Item("Vat") = Double.Parse(vatTB.Text)
        My.Settings.Save()
        MsgBox("Successfully saved new value added tax!")
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles coverageCBstockin.SelectedIndexChanged
        If coverageCBstockin.SelectedItem = "Overall" Then
            MsgBox("Showing overall stocks in!")
            monthCBstockin.Visible = False
            yearCBstockin.Visible = False
            yearLbl.Visible = False
            monthLbl.Visible = False
            supplierLbl.Visible = False
            supplierCBstockin.Visible = False
            productTBstockin.Visible = False
            productLbl.Visible = False
            productTBstockin.Text = ""
            supplierCBstockin.SelectedItem = ""
            monthCBstockin.SelectedItem = ""
            yearCBstockin.SelectedItem = ""
            retrieveOverallStocksin()
        ElseIf coverageCBstockin.SelectedItem = "Monthly" Then
            productLbl.Visible = False
            monthCBstockin.Visible = True
            dayCB.Visible = False
            yearCBstockin.Visible = False
            searchBtn.Visible = True
            yearLbl.Visible = False
            monthLbl.Visible = True
            supplierLbl.Visible = False
            supplierCBstockin.Visible = False
            productTBstockin.Visible = False
            productTBstockin.Text = ""
            supplierCBstockin.SelectedItem = ""
            monthCBstockin.SelectedItem = ""
            yearCBstockin.SelectedItem = ""

        ElseIf coverageCBstockin.SelectedItem = "Yearly" Then
            productLbl.Visible = False
            monthCBstockin.Visible = False
            dayCB.Visible = False
            yearCBstockin.Visible = True
            searchBtn.Visible = True
            yearLbl.Visible = True
            monthLbl.Visible = False
            supplierLbl.Visible = False
            supplierCBstockin.Visible = False
            productTBstockin.Visible = False
            productTBstockin.Text = ""
            supplierCBstockin.SelectedItem = ""
            monthCBstockin.SelectedItem = ""
            yearCBstockin.SelectedItem = ""
        ElseIf coverageCBstockin.SelectedItem = "Supplier" Then
            monthCBstockin.Visible = False
            dayCB.Visible = False
            yearCBstockin.Visible = True
            searchBtn.Visible = False
            yearLbl.Visible = False
            monthLbl.Visible = False
            supplierLbl.Visible = True
            supplierCBstockin.Visible = True
            productTBstockin.Visible = False
            productLbl.Visible = False
            productTBstockin.Text = ""
            supplierCBstockin.SelectedItem = ""
            monthCBstockin.SelectedItem = ""
            yearCBstockin.SelectedItem = ""
        ElseIf coverageCBstockin.SelectedItem = "Product" Then
            monthCBstockin.Visible = False
            yearCBstockin.Visible = False
            searchBtn.Visible = False
            supplierLbl.Visible = False
            supplierCBstockin.Visible = False
            productTBstockin.Visible = True
            productLbl.Visible = True
            productTBstockin.Text = ""
            supplierCBstockin.SelectedItem = ""
            monthCBstockin.SelectedItem = ""
            yearCBstockin.SelectedItem = ""
        Else
            monthCBstockin.Visible = False
            yearCBstockin.Visible = False
            searchBtn.Visible = False
            supplierLbl.Visible = False
            supplierCBstockin.Visible = False
            productTBstockin.Visible = False
            productLbl.Visible = False
            productTBstockin.Text = ""
            supplierCBstockin.SelectedItem = ""
            monthCBstockin.SelectedItem = ""
            yearCBstockin.SelectedItem = ""
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles searchBtn2.Click
        If coverageCBstockin.SelectedItem = "Monthly" Then
            If monthCBstockin.SelectedItem = "" Then
                MsgBox("Select month!")
            Else
                retrieveMonthlyStockIn()
            End If
        ElseIf coverageCBstockin.SelectedItem = "Yearly" Then
            If yearCBstockin.SelectedItem = "" Then
                MsgBox("Select year!")
            Else
                retrieveYearlyStockIn()
            End If
        ElseIf coverageCBstockin.SelectedItem = "Supplier" Then
            If supplierCBstockin.SelectedItem = "" Then
                MsgBox("Select supplier!")
            Else
                retrieveSupplierStockIn()
            End If
        ElseIf coverageCBstockin.SelectedItem = "Product" Then
            If productTBstockin.Text = "" Then
                MsgBox("Input name of the product!")
            Else
                retrieveProductStockIn()
            End If
        End If
    End Sub

    Private Sub monthCBstockin_SelectedIndexChanged(sender As Object, e As EventArgs) Handles monthCBstockin.SelectedIndexChanged
        If monthCBstockin.SelectedItem = "January" Then
            monthstockin = "01"
        ElseIf monthCBstockin.SelectedItem = "February" Then
            monthstockin = "02"
        ElseIf monthCBstockin.SelectedItem = "March" Then
            monthstockin = "03"
        ElseIf monthCBstockin.SelectedItem = "April" Then
            monthstockin = "04"
        ElseIf monthCBstockin.SelectedItem = "May" Then
            monthstockin = "05"
        ElseIf monthCBstockin.SelectedItem = "June" Then
            monthstockin = "06"
        ElseIf monthCBstockin.SelectedItem = "July" Then
            monthstockin = "07"
        ElseIf monthCBstockin.SelectedItem = "August" Then
            monthstockin = "08"
        ElseIf monthCBstockin.SelectedItem = "September" Then
            monthstockin = "09"
        ElseIf monthCBstockin.SelectedItem = "October" Then
            monthstockin = "10"
        ElseIf monthCBstockin.SelectedItem = "November" Then
            monthstockin = "11"
        ElseIf monthCBstockin.SelectedItem = "December" Then
            monthstockin = "12"
        Else
            monthstockin = ""
        End If
    End Sub

    Private Sub yearCBstockin_SelectedIndexChanged(sender As Object, e As EventArgs) Handles yearCBstockin.SelectedIndexChanged
        If yearCBstockin.SelectedItem = "" Then
            yearstockin = ""
        Else
            yearstockin = yearCBstockin.Text
        End If
    End Sub

    Private Sub printpreviewBtn2_Click(sender As Object, e As EventArgs) Handles printpreviewBtn2.Click
        dt = New DataTable
        With dt
            .Columns.Add("Product ID")
            .Columns.Add("Name")
            .Columns.Add("Supplier Name")
            .Columns.Add("Quantity")
            .Columns.Add("Date")
            .Columns.Add("Expiration Date")
        End With
        For Each dr As DataGridViewRow In DataGridView1.Rows
            dt.Rows.Add(dr.Cells(0).Value, dr.Cells(1).Value, dr.Cells(2).Value, dr.Cells(3).Value, dr.Cells(4).Value, dr.Cells(5).Value)
        Next
        ' Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
        'rptDoc = New stockinReports
        'rptDoc.SetDataSource(dt)
        'formSales.salesReportViewer.ReportSource = rptDoc
        formSales.ShowDialog()
        formSales.Dispose()
    End Sub

    Private Sub coverageCBstockout_SelectedIndexChanged(sender As Object, e As EventArgs) Handles coverageCBstockout.SelectedIndexChanged
        If coverageCBstockout.SelectedItem = "Overall" Then
            MsgBox("Showing overall stocks out!")
            monthCBstockout.Visible = False
            yearCBstockout.Visible = False
            yearLbl2.Visible = False
            monthLbl2.Visible = False
            supplierLbl2.Visible = False
            supplierCBstockout.Visible = False
            productTBstockout.Visible = False
            productLbl2.Visible = False
            productTBstockout.Text = ""
            supplierCBstockout.SelectedItem = ""
            monthCBstockout.SelectedItem = ""
            yearCBstockout.SelectedItem = ""
            retrieveOverallStocksout()
        ElseIf coverageCBstockout.SelectedItem = "Monthly" Then
            productLbl2.Visible = False
            monthCBstockout.Visible = True
            dayCB.Visible = False
            yearCBstockout.Visible = False
            searchBtn.Visible = True
            yearLbl2.Visible = False
            monthLbl2.Visible = True
            supplierLbl2.Visible = False
            supplierCBstockout.Visible = False
            productTBstockout.Visible = False
            productTBstockout.Text = ""
            supplierCBstockout.SelectedItem = ""
            monthCBstockout.SelectedItem = ""
            yearCBstockout.SelectedItem = ""
        ElseIf coverageCBstockout.SelectedItem = "Yearly" Then
            productLbl2.Visible = False
            monthCBstockout.Visible = False
            dayCB.Visible = False
            yearCBstockout.Visible = True
            searchBtn.Visible = True
            yearLbl2.Visible = True
            monthLbl2.Visible = False
            supplierLbl2.Visible = False
            supplierCBstockout.Visible = False
            productTBstockout.Visible = False
            productTBstockout.Text = ""
            supplierCBstockout.SelectedItem = ""
            monthCBstockout.SelectedItem = ""
            yearCBstockout.SelectedItem = ""
        ElseIf coverageCBstockout.SelectedItem = "Product" Then
            productLbl2.Visible = True
            monthCBstockout.Visible = False
            dayCB.Visible = False
            yearCBstockout.Visible = False
            yearLbl2.Visible = False
            monthLbl2.Visible = False
            supplierLbl2.Visible = False
            supplierCBstockout.Visible = False
            productTBstockout.Visible = True
            productTBstockout.Text = ""
            supplierCBstockout.SelectedItem = ""
            monthCBstockout.SelectedItem = ""
            yearCBstockout.SelectedItem = ""
        Else
            monthCBstockout.Visible = False
            yearCBstockout.Visible = False
            searchBtn.Visible = False
            supplierLbl2.Visible = False
            supplierCBstockout.Visible = False
            productTBstockout.Visible = False
            productLbl2.Visible = False
            productTBstockout.Text = ""
            supplierCBstockout.SelectedItem = ""
            monthCBstockout.SelectedItem = ""
            yearCBstockout.SelectedItem = ""
        End If
    End Sub

    Private Sub monthCBstockout_SelectedIndexChanged(sender As Object, e As EventArgs) Handles monthCBstockout.SelectedIndexChanged
        If monthCBstockout.SelectedItem = "January" Then
            monthstockin = "01"
        ElseIf monthCBstockout.SelectedItem = "February" Then
            monthstockin = "02"
        ElseIf monthCBstockout.SelectedItem = "March" Then
            monthstockin = "03"
        ElseIf monthCBstockout.SelectedItem = "April" Then
            monthstockin = "04"
        ElseIf monthCBstockout.SelectedItem = "May" Then
            monthstockin = "05"
        ElseIf monthCBstockout.SelectedItem = "June" Then
            monthstockin = "06"
        ElseIf monthCBstockout.SelectedItem = "July" Then
            monthstockin = "07"
        ElseIf monthCBstockout.SelectedItem = "August" Then
            monthstockin = "08"
        ElseIf monthCBstockout.SelectedItem = "September" Then
            monthstockin = "09"
        ElseIf monthCBstockout.SelectedItem = "October" Then
            monthstockin = "10"
        ElseIf monthCBstockout.SelectedItem = "November" Then
            monthstockin = "11"
        ElseIf monthCBstockout.SelectedItem = "December" Then
            monthstockin = "12"
        Else
            monthstockin = ""
        End If
    End Sub

    Private Sub yearCBstockout_SelectedIndexChanged(sender As Object, e As EventArgs) Handles yearCBstockout.SelectedIndexChanged
        If yearCBstockout.SelectedItem = "" Then
            yearstockin = ""
        Else
            yearstockin = yearCBstockout.Text
        End If
    End Sub

    Private Sub searchBtn3_Click(sender As Object, e As EventArgs) Handles searchBtn3.Click
        If coverageCBstockout.SelectedItem = "Monthly" Then
            If monthCBstockout.SelectedItem = "" Then
                MsgBox("Select month!")
            Else
                retrieveMonthlyStocksout()
            End If
        ElseIf coverageCBstockout.SelectedItem = "Yearly" Then
            If yearCBstockout.SelectedItem = "" Then
                MsgBox("Select year!")
            Else
                retrieveYearlyStocksout()
            End If
        ElseIf coverageCBstockout.SelectedItem = "Product" Then
            If productTBstockout.Text = "" Then
                MsgBox("Input name of the product!")
            Else
                retrieveProductStocksout()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        dt = New DataTable
        With dt
            .Columns.Add("Product ID")
            .Columns.Add("Name")
            .Columns.Add("Supplier Name")
            .Columns.Add("Quantity")
            .Columns.Add("Date")
        End With
        For Each dr As DataGridViewRow In reportsDGV.Rows
            dt.Rows.Add(dr.Cells(0).Value, dr.Cells(1).Value, dr.Cells(2).Value, dr.Cells(3).Value, dr.Cells(4).Value)
        Next
        ' Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
        'rptDoc = New stockoutReports
        ' rptDoc.SetDataSource(dt)
        ' formSales.salesReportViewer.ReportSource = rptDoc
        formSales.ShowDialog()
        formSales.Dispose()
    End Sub

    Private Sub searchproductBtn_Click(sender As Object, e As EventArgs) Handles searchproductBtn.Click
        If searchproductTB.Text = "" Then
            MsgBox("Input product name to be search!")
        Else
            retrieveProductsforSearch()
        End If
    End Sub

    Private Sub stockinsearchBtn_Click(sender As Object, e As EventArgs) Handles stockinsearchBtn.Click
        If stockinsearchTB.Text = "" Then
            MsgBox("Input product name to be search!")
        Else
            retrieveProductQuantityforSearch()
        End If
    End Sub


    Private Sub backupBtn_Click(sender As Object, e As EventArgs) Handles backupBtn.Click
        backupBtn.Text = MessageBox.Show("Want to back up your database?", "BACK-UP DATABASE!", MessageBoxButtons.YesNo)
        If backupBtn.Text = DialogResult.Yes Then
            backupBtn.Text = "Backup Database"
            Dim file As String
            sfd.Filter = "SQL Dump File (*.sql)|*.sql|All files (*.*)|*.*"
            sfd.FileName = "Database Backup " + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".sql"
            If sfd.ShowDialog = DialogResult.OK Then
                file = sfd.FileName
                Dim myProcess As New Process()
                myProcess.StartInfo.FileName = "cmd.exe"
                myProcess.StartInfo.UseShellExecute = False
                myProcess.StartInfo.WorkingDirectory = "C:\xampp\mysql\bin"
                myProcess.StartInfo.RedirectStandardInput = True
                myProcess.StartInfo.RedirectStandardOutput = True
                myProcess.Start()
                Dim myStreamWriter As StreamWriter = myProcess.StandardInput
                Dim mystreamreader As StreamReader = myProcess.StandardOutput
                myStreamWriter.WriteLine("mysqldump -u root --password= " & _
            "-h localhost ""newpost_database"" > """ + file + """ ")
                myStreamWriter.Close()
                myProcess.WaitForExit()
                myProcess.Close()
                MsgBox("Successfully created new backup for Newpost POS and Inventory System!", MsgBoxStyle.Information, "Backup")
            End If
        Else
            backupBtn.Text = "Backup Database"
        End If
    End Sub

    Private Sub restoreBtn_Click(sender As Object, e As EventArgs) Handles restoreBtn.Click
        restoreBtn.Text = MessageBox.Show("Are you sure you want to restore database?", "RESTORING DATABASE!", MessageBoxButtons.YesNo)
        If restoreBtn.Text = DialogResult.Yes Then
            restoreBtn.Text = "Restore Database"
            Dim OFD As FileDialog = New OpenFileDialog()
            Dim file As String
            OFD.Filter = "SQL Dump File (*.sql)|*.sql|All files (*.*)|*.*"
            If OFD.ShowDialog = DialogResult.OK Then
                file = OFD.FileName
                Dim myProcess As New Process()
                myProcess.StartInfo.FileName = "cmd.exe"
                myProcess.StartInfo.UseShellExecute = False
                myProcess.StartInfo.WorkingDirectory = "C:\xampp\mysql\bin"
                myProcess.StartInfo.RedirectStandardInput = True
                myProcess.StartInfo.RedirectStandardOutput = True
                myProcess.Start()
                Dim myStreamWriter As StreamWriter = myProcess.StandardInput
                Dim mystreamreader As StreamReader = myProcess.StandardOutput
                myStreamWriter.WriteLine("mysql -u root --password= " & _
                    "-h localhost ""newpost_database"" < """ + file + """ ")
                myStreamWriter.Close()
                myProcess.WaitForExit()
                myProcess.Close()
                MsgBox("Newpost POS and Inventory System database has been restored!", MsgBoxStyle.Information, "Restore")
            End If
        Else
            restoreBtn.Text = "Restore Database"
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        dt = New DataTable
        With dt
            .Columns.Add("Product ID")
            .Columns.Add("Name")
            .Columns.Add("Quantity")
            .Columns.Add("Name of Supplier")
        End With
        For Each dr As DataGridViewRow In DataGridView5.Rows
            dt.Rows.Add(dr.Cells(0).Value, dr.Cells(1).Value, dr.Cells(2).Value, dr.Cells(3).Value)
        Next
        'Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
        ' rptDoc = New reorderReports
        '' rptDoc.SetDataSource(dt)
        '' formSales.salesReportViewer.ReportSource = rptDoc
        formSales.ShowDialog()
        formSales.Dispose()
    End Sub

    Private Sub ButtCustom_Click(sender As Object, e As EventArgs) Handles ButtCustom.Click
        If addressCUSTTB.Text = "" Then
            MsgBox("Input address!")
        ElseIf customernameTB.Text = "" Then
            MsgBox("Input customer name!")
        ElseIf contactnoCUSTTB.Text = "" Then
            MsgBox("Input contact number!")
        ElseIf tinnumberCUSTTB.Text = "" Then
            MsgBox("Input TIN number!")
            MsgBox("Select customer to be deleted or updated!")
        Else
            addcustomers()
            updataCustomer()
            reterieveCustomer()
            CleanCustomer()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        If addressCUSTTB.Text = "" Then
            MsgBox("Input address!")
        ElseIf contactnoCUSTTB.Text = "" Then
            MsgBox("Input contact number!")
        ElseIf tinnumberCUSTTB.Text = "" Then
            MsgBox("Input TIN number!")
        ElseIf customernameTB.Text = "" Then
            MsgBox("Input customer name!")
        Else
            updataCustomer()
            reterieveCustomer()
            CleanCustomer()
        End If
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        CleanCustomer()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles DeletButt.Click
        If customernameTB.Text = "" Then
            MsgBox("Select customer to be deleted or updated!")
        Else
            deleteCustomer()
            updataCustomer()
            reterieveCustomer()
            CleanCustomer()
        End If
    End Sub

    Private Sub CustomerDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CustomerDGV.CellContentClick
        If e.RowIndex >= 0 Then
            Dim index As Integer
            index = e.RowIndex
            Dim row As DataGridViewRow
            row = CustomerDGV.Rows(index)
            ' customerID.Text = row.Cells(0).Value.ToString()
            customernameTB.Text = row.Cells(1).Value.ToString()
            addressCUSTTB.Text = row.Cells(2).Value.ToString()
            contactnoCUSTTB.Text = row.Cells(3).Value.ToString()
            tinnumberCUSTTB.Text = row.Cells(4).Value.ToString()
        End If
    End Sub

    Private Sub Refreshlb_Click(sender As Object, e As EventArgs) Handles Refreshlb.Click
        Me.Close()
        Refre()
    End Sub
End Class