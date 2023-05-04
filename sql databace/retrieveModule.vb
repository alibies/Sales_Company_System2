Imports System.Data.SqlClient

Module retrieveModule

    Public Sub retrieveProducts()
        Try
            dbConnection()
            sql = "SELECT Product_ID, Product_ID_Barcode, Name, Price, Category, Price_Code, Name_of_Supplier, Delivery_Date, Unit, Quantity FROM products_database;"
            cmd = New SqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .ExecuteNonQuery()
            End With
            dt = New DataTable
            da = New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(dt)
            formAdmin.productsDGV.DataSource = dt
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            da.Dispose()
            cmd.Dispose()
        End Try
    End Sub

    Public Sub retrieveLessProducts()
        Try
            dbConnection()
            sql = "SELECT Product_ID_Barcode, Name, Quantity, Name_of_Supplier FROM products_database WHERE Quantity <= 10;"
            cmd = New SqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .ExecuteNonQuery()
            End With
            dt = New DataTable
            da = New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(dt)
            formAdmin.DataGridView5.DataSource = dt
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            If dt.Rows.Count > 0 And checkmasrefresh = "NO" Then
                checkmasrefresh = "Yes"
                MsgBox("Please check your stocks that are below 10 quantity at the 'Re-order Stocks' tab.")
            Else

            End If
        End Try
    End Sub

    Public Sub retrieveProductsforSearch()
        Try
            dbConnection()
            sql = "SELECT Product_ID, Product_ID_Barcode, Name, Price, Category, Price_Code, Name_of_Supplier, Delivery_Date, Unit, Quantity FROM products_database WHERE Name = @Name;"
            cmd = New SqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@Name", formAdmin.searchproductTB.Text)
                .ExecuteNonQuery()
            End With
            dt = New DataTable
            da = New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(dt)
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            da.Dispose()
            cmd.Dispose()
            If dt.Rows.Count = 0 Then
                MsgBox("No results!")
            Else
                MsgBox("Showing product details!")
            End If
            formAdmin.productsDGV.DataSource = dt
        End Try
    End Sub

    Public Sub retrieveEmployeeLogs()
        Try
            dbConnection()
            sql = "SELECT * FROM employees_logs;"
            cmd = New SqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .ExecuteNonQuery()
            End With
            dt = New DataTable
            da = New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(dt)
            formAdmin.DataGridView3.DataSource = dt
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            da.Dispose()
            cmd.Dispose()
        End Try
    End Sub

    Public Sub retrieveProductsCategory()
        Try
            dbConnection()
            sql = "SELECT * FROM category_database;"
            cmd = New SqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .ExecuteNonQuery()
            End With
            dt = New DataTable
            da = New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(dt)
            formAdmin.productscategoryDGV.DataSource = dt
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            da.Dispose()
            cmd.Dispose()
        End Try
    End Sub

    Public Sub retrieveSuppliers()
        Try
            dbConnection()
            sql = "SELECT * FROM suppliers_database;"
            cmd = New SqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .ExecuteNonQuery()
            End With
            dt = New DataTable
            da = New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(dt)
            formAdmin.supplierDGV.DataSource = dt
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            da.Dispose()
            cmd.Dispose()
        End Try
    End Sub
    Public Sub reterieveCustomer()
        Try
            dbConnection()
            sql = "SELECT * FROM Custome_database;"
            cmd = New SqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .ExecuteNonQuery()
            End With
            dt = New DataTable
            da = New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(dt)
            formAdmin.CustomerDGV.DataSource = dt
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            da.Dispose()
            cmd.Dispose()
        End Try
    End Sub

    Public Sub retrieveEmployees()
        Try
            dbConnection()
            sql = "SELECT * FROM employees_database;"
            cmd = New SqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .ExecuteNonQuery()
            End With
            dt = New DataTable
            da = New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(dt)
            formAdmin.employeeDGV.DataSource = dt
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            da.Dispose()
            cmd.Dispose()
        End Try
    End Sub

    Public Sub retrievePClist()
        Try
            dbConnection()
            sql = "SELECT *FROM category_database;"
            cmd = New SqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            formAdmin.productcategoryCB.Items.Clear()
            While dr.Read
                formAdmin.productcategoryCB.Items.Add(dr("name"))
            End While
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dr.Close()
        End Try
    End Sub

    Public Sub retrievecustomerlist()
        Try
            dbConnection()
            sql = "SELECT *FROM Custome_database;"
            cmd = New SqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            FormCasher.nameofcustomerCB.Items.Clear()
            While dr.Read
                FormCasher.nameofcustomerCB.Items.Add(dr("name"))
            End While
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dr.Close()
        End Try
    End Sub
    Public Sub retrieveNSlist()
        Try
            dbConnection()
            sql = "SELECT * FROM suppliers_database;"
            cmd = New SqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            formAdmin.nameofsupplierCB.Items.Clear()
            formAdmin.supplierCBstockin.Items.Clear()
            formAdmin.supplierCBstockout.Items.Clear()
            formAdmin.supplierCBstockin.Items.Add("")
            formAdmin.supplierCBstockout.Items.Add("")
            While dr.Read
                formAdmin.nameofsupplierCB.Items.Add(dr("Name"))
                formAdmin.supplierCBstockin.Items.Add(dr("Name"))
                formAdmin.supplierCBstockout.Items.Add(dr("Name"))
            End While
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dr.Close()
        End Try
    End Sub

    Public Sub retrieveItem()
        Try
            dbConnection()
            sql = "SELECT Name, Quantity FROM products_database WHERE Product_ID_Barcode = '" & productCodes & "';"
            cmd = New SqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                quantitycheck = dr.GetString("Quantity")
            End While
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dr.Close()
        End Try
    End Sub

    Public Sub retrieveItem2()
        Try
            dbConnection()
            sql = "SELECT Quantity FROM products_database WHERE Product_ID_Barcode = '" & formAdmin.defectiveidLbl.Text & "';"
            cmd = New SqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                quantitycheck = dr("Quantity")
            End While
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dr.Close()
        End Try
    End Sub

    Public Sub retrieveDefectiveItem()
        Try
            dbConnection()
            sql = "SELECT * FROM stocks_database WHERE Product_ID_Barcode = '" & productCodes & "' And Status = 'DEFECTIVE';"
            cmd = New SqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                defectivequantitycheck = dr("Quantity")
            End While
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dr.Close()
            defectstotalquality = (Integer.Parse(quantitycheck) - Integer.Parse(defectivequantitycheck))
        End Try
    End Sub

    Public Sub retrieveOverallSales()
        Try
            dbConnection()
            sql = "SELECT Transaction_ID,Customer_name, Subtotal, Date, Time FROM sales_database;"
            cmd = New SqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .ExecuteNonQuery()
            End With
            dt = New DataTable
            da = New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(dt)
            formAdmin.salesDGV.DataSource = dt
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            cmd.Dispose()
        End Try
    End Sub

    Public Sub retrieveDailySales()
        Try
            dbConnection()
            sql = "SELECT Transaction_ID,Customer_name, Subtotal, Date, Time FROM sales_database WHERE Month = @Month AND Day = @Day AND Year = @Year;"
            cmd = New SqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@Month", formAdmin.monthCB.SelectedItem)
                .Parameters.AddWithValue("@Day", formAdmin.dayCB.SelectedItem)
                .Parameters.AddWithValue("@Year", formAdmin.yearCB.SelectedItem)
                .ExecuteNonQuery()
            End With
            dt = New DataTable
            da = New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                MsgBox("No results!")
            Else
                MsgBox("Showing results!")
            End If
            formAdmin.salesDGV.DataSource = dt
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            cmd.Dispose()
        End Try
    End Sub

    Public Sub retrieveMonthlySales()
        Try
            dbConnection()
            sql = "SELECT Transaction_ID,Customer_name, Subtotal, Date, Time FROM sales_database WHERE Month = @Month;"
            cmd = New SqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@Month", formAdmin.monthCB.SelectedItem)
                .ExecuteNonQuery()
            End With
            dt = New DataTable
            da = New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                MsgBox("No results!")
            Else
                MsgBox("Showing results!")
            End If
            formAdmin.salesDGV.DataSource = dt
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            cmd.Dispose()
        End Try
    End Sub

    Public Sub retrieveYearlySales()
        Try
            dbConnection()
            sql = "SELECT Transaction_ID,Customer_name, Subtotal, Date, Time FROM sales_database WHERE Year = @Year;"
            cmd = New SqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@Year", formAdmin.yearCB.SelectedItem)
                .ExecuteNonQuery()
            End With
            dt = New DataTable
            da = New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                MsgBox("No results!")
            Else
                MsgBox("Showing results!")
            End If
            formAdmin.salesDGV.DataSource = dt
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            cmd.Dispose()
        End Try
    End Sub
    Public Sub retrievevoidtranactoin()

        Try
            FormCasher.Close()
            dbConnection()
            sql = "SELECT * FROM employees_database WHERE Username = @Username AND Password = @Password AND User_Level = @UserLevel;"
            cmd = New SqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@Username", formLogin.usernameTB.Text)
                .Parameters.AddWithValue("@Password", formLogin.passwordTB.Text)
                .Parameters.AddWithValue("@UserLevel", formLogin.userlevelCB.SelectedItem)
                .ExecuteNonQuery()
            End With
            da = New SqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            da.Dispose()
            If dt.Rows.Count > 0 Then
                Dim username, password, fullname, userlevel As String
                username = dt.Rows(0).Item(4)
                password = dt.Rows(0).Item(5)
                userlevel = dt.Rows(0).Item(6)
                fullname = dt.Rows(0).Item(1) + "  " + dt.Rows(0).Item(2) + " " + dt.Rows(0).Item(3)
                If formLogin.usernameTB.Text = username And formLogin.passwordTB.Text = password And userlevel = "Cashier" Then

                    FormCasher.Show()
                    formLogin.Hide()
                End If
            End If
        End Try
    End Sub
    Public Sub retrieveLoginDetails()

        If formLogin.usernameTB.Text = "" Then
            MsgBox("Input username!")
            formLogin.usernameTB.Focus()
        ElseIf formLogin.passwordTB.Text = "" Then
            MsgBox("Input password!")
            formLogin.passwordTB.Focus()
        ElseIf formLogin.userlevelCB.SelectedItem = "" Then
            MsgBox("Select user level!")
            formLogin.userlevelCB.Focus()

        Else

            Try
                dbConnection()
                sql = "SELECT * FROM employees_database WHERE Username = @Username AND Password = @Password AND User_Level = @UserLevel;"
                cmd = New SqlCommand
                With cmd
                    .Connection = conn
                    .CommandText = sql
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@Username", formLogin.usernameTB.Text)
                    .Parameters.AddWithValue("@Password", formLogin.passwordTB.Text)
                    .Parameters.AddWithValue("@UserLevel", formLogin.userlevelCB.SelectedItem)
                    .ExecuteNonQuery()
                End With
                da = New SqlDataAdapter
                dt = New DataTable
                da.SelectCommand = cmd
                da.Fill(dt)
            Catch ex As SqlException
                MsgBox(ex.Message)
            Finally
                conn.Close()
                da.Dispose()
                If dt.Rows.Count > 0 Then
                    Dim username, password, fullname, userlevel As String
                    username = dt.Rows(0).Item(4)
                    password = dt.Rows(0).Item(5)
                    userlevel = dt.Rows(0).Item(6)
                    fullname = dt.Rows(0).Item(1) + "  " + dt.Rows(0).Item(2) + " " + dt.Rows(0).Item(3)
                    If formLogin.usernameTB.Text = username And formLogin.passwordTB.Text = password And userlevel = "Cashier" Then
                        MsgBox("Welcome<< " + fullname + ">>(:")

                        FormCasher.Show()
                        formLogin.Hide()

                    ElseIf formLogin.usernameTB.Text = username And formLogin.passwordTB.Text = password And userlevel = "Administrator" Then
                        MsgBox("Welcome<< " + fullname + ">>(:")
                        formLogin.usernameTB.Text = ""
                        formLogin.passwordTB.Text = ""
                        formLogin.userlevelCB.SelectedItem = ""
                        formAdmin.Show()
                        formLogin.Hide()
                    End If
                Else
                    MsgBox("Incorrect username or password!")
                    formLogin.usernameTB.Focus()
                End If
            End Try
        End If

    End Sub

    Public Sub logid()

        Try
            dbConnection()
            sql = "SELECT * FROM employee_id;"
            cmd = New SqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            While dr.Read
                Dim logidnumber = dr("ID")
                logidforcashier = logidnumber
            End While
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            dr.Close()
        End Try

    End Sub

    Public Sub retrieveProductQuantity()
        Try
            dbConnection()
            sql = "SELECT Product_ID_Barcode, Name, Quantity, Name_of_Supplier FROM products_database;"
            cmd = New SqlCommand(sql, conn)
            da = New SqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)
            formAdmin.stockinDGV.DataSource = dt
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub retrieveProductQuantityforSearch()
        Try
            dbConnection()
            sql = "SELECT Product_ID_Barcode, Name, Quantity, Name_of_Supplier FROM products_database WHERE Name = @Name;"
            cmd = New SqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@Name", formAdmin.stockinsearchTB.Text)
            End With
            da = New SqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            If dt.Rows.Count = 0 Then
                MsgBox("No results!")
            Else
                MsgBox("Showing product details!")
                formAdmin.stockinDGV.DataSource = dt
            End If
        End Try
    End Sub

    Public Sub retrieveStockTrail()
        Try
            dbConnection()
            sql = "SELECT Product_ID_Barcode, Name, Supplier_Name, Quantity, Status, Date, Expiration_Date FROM stocks_database WHERE Status = 'STOCK IN';"
            cmd = New SqlCommand(sql, conn)
            da = New SqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)
            formAdmin.stockoutDGV.DataSource = dt
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub retrieveStockOutTrail()
        Try
            dbConnection()
            sql = "SELECT Product_ID_Barcode, Name, Quantity, Status, Date FROM stocks_database WHERE Status = 'STOCK OUT' OR Status = 'DEFECTIVE';"
            cmd = New SqlCommand(sql, conn)
            da = New SqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)
            formAdmin.salesoutDGV.DataSource = dt
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub retrieveExpirationDateofStocks()
        Try
            dbConnection()
            sql = "SELECT ID, Product_ID_Barcode, Name, Quantity, Supplier_Name, Expiration_Date FROM stocks_database WHERE Expiration_Date = @ExpirationDate AND Status = @Status;"
            cmd = New SqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@ExpirationDate", monthexp + "/" + formAdmin.expdayCB.SelectedItem + "/" + formAdmin.expyearCB.SelectedItem)
            End With
            da = New SqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            If dt.Rows.Count = 0 Then
                MsgBox("No results!")
            Else
                MsgBox("Showing results!")
            End If
            formAdmin.expirationDGV.DataSource = dt
        End Try
    End Sub

    Public Sub retrieveProductsforDefective()
        Try
            dbConnection()
            sql = "SELECT Product_ID_Barcode, Name, Quantity, Name_of_Supplier FROM products_database;"
            cmd = New SqlCommand(sql, conn)
            da = New SqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)
            formAdmin.defectiveDGV.DataSource = dt
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub retrieveDefectiveProductsifNull()
        Try
            dbConnection()
            sql = "SELECT * FROM stocks_database WHERE Status = @Status And Product_ID_Barcode = @ProductID;"
            cmd = New SqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@Status", "DEFECTIVE")
                .Parameters.AddWithValue("@ProductID", formAdmin.defectiveidLbl.Text)
                .ExecuteNonQuery()
            End With
            da = New SqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            If dt.Rows.Count = 0 Then
                addDefectiveQuantity()
                retrieveProductQuantity()
            Else
                updateDefectiveQuantity()
                retrieveProductQuantity()
            End If
        End Try
    End Sub

    Public Sub retrieveDefectiveProductList()
        Try
            dbConnection()
            sql = "SELECT * FROM defective_database;"
            cmd = New SqlCommand
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
            formAdmin.defectivelistDGV.DataSource = dt
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub retrieveEmployeeLogsList()
        Try
            dbConnection()
            sql = "SELECT * FROM employee_loginlogs;"
            cmd = New SqlCommand
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
            formAdmin.DataGridView4.DataSource = dt
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub retrieveExpirationList()
        Try
            dbConnection()
            sql = "SELECT ID, Product_ID_Barcode, Name, Quantity, Supplier_Name, Expiration_Date FROM stocks_database WHERE Year = @ExpirationDate AND Status = @Status;"
            cmd = New SqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@Status", "STOCK IN")
                .Parameters.AddWithValue("@ExpirationDate", Date.Now.ToString("yyyy"))
                .ExecuteNonQuery()
            End With
            da = New SqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)
            formAdmin.expirationDGV.DataSource = dt
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub retrieveStockinforDeduction()
        Try
            dbConnection()
            sql = "SELECT ID, MIN(Expiration_Date), Quantity FROM stocks_database WHERE Name = @Name AND Status = @Status AND Product_ID_Barcode = @IDBarcode;"
            cmd = New SqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@Name", itemdesc)
                .Parameters.AddWithValue("@IDBarcode", productCodes)
                .Parameters.AddWithValue("@Status", "STOCK IN")
                .ExecuteNonQuery()
            End With
            da = New SqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            da.Dispose()
            If dt.Rows.Count > 0 Then
                updateStockinquantityLatest()
            End If
        End Try
    End Sub

    Public Sub retrieveOverallStocksin()
        Try
            dbConnection()
            sql = "SELECT Product_ID_Barcode, Name, Supplier_Name, Quantity, Date, Expiration_Date FROM stocks_database WHERE Status = 'STOCK IN';"
            cmd = New SqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .ExecuteNonQuery()
            End With
            dt = New DataTable
            da = New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(dt)
            formAdmin.DataGridView1.DataSource = dt
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            cmd.Dispose()
            yearstockin = ""
            monthstockin = ""
            formAdmin.yearCBstockin.SelectedItem = ""
            formAdmin.monthCBstockin.SelectedItem = ""
            formAdmin.supplierCBstockin.SelectedItem = ""
            formAdmin.productTBstockin.Text = ""
        End Try
    End Sub

    Public Sub retrieveMonthlyStockIn()
        Try
            dbConnection()
            sql = "SELECT Product_ID_Barcode, Name, Supplier_Name, Quantity, Date, Expiration_Date FROM stocks_database WHERE Status = 'STOCK IN' AND Month = @Month;"
            cmd = New SqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@Month", monthstockin)
                .ExecuteNonQuery()
            End With
            dt = New DataTable
            da = New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(dt)
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            cmd.Dispose()
            If dt.Rows.Count = 0 Then
                MsgBox("No results!")
            Else
                MsgBox("Showing results!")
            End If
            formAdmin.DataGridView1.DataSource = dt
            yearstockin = ""
            monthstockin = ""
            formAdmin.yearCBstockin.SelectedItem = ""
            formAdmin.monthCBstockin.SelectedItem = ""
            formAdmin.supplierCBstockin.SelectedItem = ""
            formAdmin.productTBstockin.Text = ""
        End Try
    End Sub

    Public Sub retrieveYearlyStockIn()
        Try
            dbConnection()
            sql = "SELECT Product_ID_Barcode, Name, Supplier_Name, Quantity, Date, Expiration_Date FROM stocks_database WHERE Status = 'STOCK IN' AND Year = @Year;"
            cmd = New SqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@Year", yearstockin)
                .ExecuteNonQuery()
            End With
            dt = New DataTable
            da = New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(dt)
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            cmd.Dispose()
            If dt.Rows.Count = 0 Then
                MsgBox("No results!")
            Else
                MsgBox("Showing results!")
            End If
            formAdmin.DataGridView1.DataSource = dt
            yearstockin = ""
            monthstockin = ""
            formAdmin.yearCBstockin.SelectedItem = ""
            formAdmin.monthCBstockin.SelectedItem = ""
            formAdmin.supplierCBstockin.SelectedItem = ""
            formAdmin.productTBstockin.Text = ""
        End Try
    End Sub

    Public Sub retrieveSupplierStockIn()
        Try
            dbConnection()
            sql = "SELECT Product_ID_Barcode, Name, Supplier_Name, Quantity, Date, Expiration_Date FROM stocks_database WHERE Status = 'STOCK IN' AND Supplier_Name = @Supplier;"
            cmd = New SqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@Supplier", formAdmin.supplierCBstockin.SelectedItem)
                .ExecuteNonQuery()
            End With
            dt = New DataTable
            da = New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(dt)
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            cmd.Dispose()
            If dt.Rows.Count = 0 Then
                MsgBox("No results!")
            Else
                MsgBox("Showing results!")
            End If
            formAdmin.DataGridView1.DataSource = dt
            yearstockin = ""
            monthstockin = ""
            formAdmin.yearCBstockin.SelectedItem = ""
            formAdmin.monthCBstockin.SelectedItem = ""
            formAdmin.supplierCBstockin.SelectedItem = ""
            formAdmin.productTBstockin.Text = ""
        End Try
    End Sub

    Public Sub retrieveProductStockIn()
        Try
            dbConnection()
            sql = "SELECT Product_ID_Barcode, Name, Supplier_Name, Quantity, Date, Expiration_Date FROM stocks_database WHERE Status = 'STOCK IN' AND Name = @Name;"
            cmd = New SqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@Name", formAdmin.productTBstockin.Text)
                .ExecuteNonQuery()
            End With
            dt = New DataTable
            da = New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(dt)
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            cmd.Dispose()
            If dt.Rows.Count = 0 Then
                MsgBox("No results!")
            Else
                MsgBox("Showing results!")
            End If
            formAdmin.DataGridView1.DataSource = dt
            yearstockin = ""
            monthstockin = ""
            formAdmin.yearCBstockin.SelectedItem = ""
            formAdmin.monthCBstockin.SelectedItem = ""
            formAdmin.supplierCBstockin.SelectedItem = ""
            formAdmin.productTBstockin.Text = ""
        End Try
    End Sub

    Public Sub retrieveOverallStocksout()
        Try
            dbConnection()
            sql = "SELECT Product_ID_Barcode, Name, Quantity, Date FROM stocks_database WHERE Status = 'STOCK OUT';"
            cmd = New SqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .ExecuteNonQuery()
            End With
            dt = New DataTable
            da = New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(dt)
            formAdmin.DataGridView2.DataSource = dt
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            cmd.Dispose()
            yearstockin = ""
            monthstockin = ""
            formAdmin.yearCBstockout.SelectedItem = ""
            formAdmin.monthCBstockout.SelectedItem = ""
            formAdmin.supplierCBstockout.SelectedItem = ""
            formAdmin.productTBstockout.Text = ""
        End Try
    End Sub

    Public Sub retrieveMonthlyStocksout()
        Try
            dbConnection()
            sql = "SELECT Product_ID_Barcode, Name, Quantity, Date FROM stocks_database WHERE Status = 'STOCK OUT' AND Month = @Month;"
            cmd = New SqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@Month", monthstockin)
                .ExecuteNonQuery()
            End With
            dt = New DataTable
            da = New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(dt)
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            cmd.Dispose()
            If dt.Rows.Count = 0 Then
                MsgBox("No results!")
            Else
                MsgBox("Showing results!")
            End If
            formAdmin.DataGridView2.DataSource = dt
            yearstockin = ""
            monthstockin = ""
            formAdmin.yearCBstockout.SelectedItem = ""
            formAdmin.monthCBstockout.SelectedItem = ""
            formAdmin.supplierCBstockout.SelectedItem = ""
            formAdmin.productTBstockout.Text = ""
        End Try
    End Sub

    Public Sub retrieveYearlyStocksout()
        Try
            dbConnection()
            sql = "SELECT Product_ID_Barcode, Name, Quantity, Date FROM stocks_database WHERE Status = 'STOCK OUT' AND Year = @Year;"
            cmd = New SqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@Year", yearstockin)
                .ExecuteNonQuery()
            End With
            dt = New DataTable
            da = New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(dt)
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            cmd.Dispose()
            If dt.Rows.Count = 0 Then
                MsgBox("No results!")
            Else
                MsgBox("Showing results!")
            End If
            formAdmin.DataGridView2.DataSource = dt
            yearstockin = ""
            monthstockin = ""
            formAdmin.yearCBstockout.SelectedItem = ""
            formAdmin.monthCBstockout.SelectedItem = ""
            formAdmin.supplierCBstockout.SelectedItem = ""
            formAdmin.productTBstockout.Text = ""
        End Try
    End Sub

    Public Sub retrieveProductStocksout()
        Try
            dbConnection()
            sql = "SELECT Product_ID_Barcode, Name, Quantity, Date FROM stocks_database WHERE Status = 'STOCK OUT' AND Name = @Name;"
            cmd = New SqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@Name", formAdmin.productTBstockout.Text)
                .ExecuteNonQuery()
            End With
            dt = New DataTable
            da = New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(dt)
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            cmd.Dispose()
            If dt.Rows.Count = 0 Then
                MsgBox("No results!")
            Else
                MsgBox("Showing results!")
            End If
            formAdmin.DataGridView2.DataSource = dt
            yearstockin = ""
            monthstockin = ""
            formAdmin.yearCBstockout.SelectedItem = ""
            formAdmin.monthCBstockout.SelectedItem = ""
            formAdmin.supplierCBstockout.SelectedItem = ""
            formAdmin.productTBstockout.Text = ""
        End Try
    End Sub
    Public Sub refre()
        formAdmin.Show()
    End Sub
End Module
