Imports System.Data.SqlClient

Module addModule

    Public Sub addProducts()
        Try
            dbConnection()
            sql = "INSERT INTO products_database (Product_ID_Barcode,Name,Price,Quantity,Category,Price_Code,Name_of_Supplier,Delivery_Date,Unit) VALUES" &
                "(@ProductID, @Name, @Price, @Quantity, @Category, @PriceCode, @Supplier, @DeliveryDate, @Unit);"
            cmd = New SqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@ProductID", formAdmin.productidTB.Text)
                .Parameters.AddWithValue("@Name", formAdmin.productnameTB.Text)
                .Parameters.AddWithValue("@Price", formAdmin.priceTB.Text)
                .Parameters.AddWithValue("@Quantity", formAdmin.Texunty.Text)
                .Parameters.AddWithValue("@Category", formAdmin.productcategoryCB.Text)
                .Parameters.AddWithValue("@PriceCode", formAdmin.pricecodeTB.Text)
                .Parameters.AddWithValue("@Supplier", formAdmin.nameofsupplierCB.Text)
                .Parameters.AddWithValue("@DeliveryDate", formAdmin.deliveryDTP.Value.ToString("MM/dd/yyyy"))
                .Parameters.AddWithValue("@Unit", formAdmin.unitTB.Text)
                result = .ExecuteNonQuery()
                If result = 0 Then
                    MsgBox("Error in adding new product!")
                Else
                    MsgBox("Successfully added new product!")
                    prodectchart += 1
                End If
            End With
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            cmd.Dispose()
        End Try
    End Sub

    Public Sub addCategoryProducts()
        Try
            dbConnection()
            sql = "INSERT INTO category_database (Name) VALUES (@Name);"
            cmd = New SqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@Name", formAdmin.categorynameTB.Text)
                result = .ExecuteNonQuery()
                If result = 0 Then
                    MsgBox("Error in adding new product category!")
                Else
                    MsgBox("Successfully added new product category!")
                    catagorychart += 1
                End If
            End With
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            cmd.Dispose()
        End Try
    End Sub

    Public Sub addSuppliers()
        Try
            dbConnection()
            sql = "INSERT INTO suppliers_database (Name,Address,Contact_Number,TIN) VALUES (@Name, @Address, @ContactNo, @TinNo);"
            cmd = New SqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@Name", formAdmin.suppliernameTB.Text)
                .Parameters.AddWithValue("@Address", formAdmin.addressTB.Text)
                .Parameters.AddWithValue("@ContactNo", formAdmin.contactnoTB.Text)
                .Parameters.AddWithValue("@TinNo", formAdmin.tinnumberTB.Text)
                result = .ExecuteNonQuery()
                If result = 0 Then
                    MsgBox("Error in adding new supplier!")
                Else
                    MsgBox("Successfully added new supplier!")
                    suppchartnum += 1
                End If
            End With
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            cmd.Dispose()
        End Try
    End Sub
    Public Sub addcustomers()
        Try
            dbConnection()
            sql = "INSERT INTO Custome_database (Name,Address,Contact_Number,TIN) VALUES (@Name, @Address, @ContactNo, @TinNo);"
            cmd = New SqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@Name", formAdmin.customernameTB.Text)
                .Parameters.AddWithValue("@Address", formAdmin.addressCUSTTB.Text)
                .Parameters.AddWithValue("@ContactNo", formAdmin.contactnoCUSTTB.Text)
                .Parameters.AddWithValue("@TinNo", formAdmin.tinnumberCUSTTB.Text)
                result = .ExecuteNonQuery()
                If result = 0 Then
                    MsgBox("Error in adding new customer!")
                Else
                    MsgBox("Successfully added new customer!")
                    custchartnum += 1
                End If
            End With
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            cmd.Dispose()
        End Try
    End Sub
    Public Sub addEmployees()
        Try
            dbConnection()
            sql = "INSERT INTO employees_database (First_Name,Middle_Name,Last_Name,Username,Password,User_Level) VALUES (@FirstName, @MiddleName, @LastName, @Username, @Password,@User_Level);"
            cmd = New SqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@FirstName", formAdmin.firstnameTB.Text)
                .Parameters.AddWithValue("@MiddleName", formAdmin.middlenameTB.Text)
                .Parameters.AddWithValue("@LastName", formAdmin.lastnameTB.Text)
                .Parameters.AddWithValue("@Username", formAdmin.usernameTB.Text)
                .Parameters.AddWithValue("@Password", formAdmin.PasswordTB.Text)
                .Parameters.AddWithValue("@User_Level", formAdmin.userlevelCB.SelectedItem)
                result = .ExecuteNonQuery()
                If result = 0 Then
                    MsgBox("Error in adding new employee!")
                Else
                    MsgBox("Successfully added new employee!")
                    Empchartnum += 1
                End If
            End With
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            cmd.Dispose()
        End Try
    End Sub

    Public Sub addTransaction()
        Try
            dbConnection()
            sql = "INSERT INTO sales_database (Customer_name,Subtotal,Cash,CashChange,Date,Time,Month,Day,Year) VALUES (@Customer_name,@Subtotal, @Cash, @CashChange, @Date, @Time, @Month, @Day, @Year);"
            cmd = New SqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@Customer_name", FormCasher.nameofcustomerCB.Text)
                .Parameters.AddWithValue("@Subtotal", FormCasher.subtotalLbl.Text)
                .Parameters.AddWithValue("@Cash", FormCasher.cashtenderedLbl.Text)
                .Parameters.AddWithValue("@CashChange", FormCasher.changeLbl.Text)
                .Parameters.AddWithValue("@Date", Date.Now.ToString("MMMM dd, yyyy"))
                .Parameters.AddWithValue("@Time", TimeOfDay.ToString("hh:mm:ss tt"))
                .Parameters.AddWithValue("@Month", Date.Now.ToString("MMMM"))
                .Parameters.AddWithValue("@Day", Date.Now.ToString("dd"))
                .Parameters.AddWithValue("@Year", Date.Now.ToString("yyyy"))
                .ExecuteNonQuery()
            End With
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            cmd.Dispose()
        End Try
    End Sub

    Public Sub addCashierLog()
        Try
            dbConnection()
            sql = "INSERT INTO employees_logs (Cashier,Subtotal,Discount,CashTendered,ChangeTendered) VALUES (@Cashier, @Subtotal, @Discount, @CashTendered, @ChangeTendered);"
            cmd = New SqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@Cashier", FormCasher.Label14.Text)
                .Parameters.AddWithValue("@Subtotal", FormCasher.subtotalLbl.Text)
                .Parameters.AddWithValue("@Discount", FormCasher.discountLbl.Text)
                .Parameters.AddWithValue("@CashTendered", FormCasher.cashtenderedLbl.Text)
                .Parameters.AddWithValue("@ChangeTendered", FormCasher.changeLbl.Text)
                .ExecuteNonQuery()
            End With
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            cmd.Dispose()
        End Try
    End Sub

    Public Sub addEmployeeLoggedIn()
        Try
            employeeid = My.Settings("Employee")
            dbConnection()
            sql = "INSERT INTO employee_loginlogs (Cashier,LOGGED_IN,LOGGED_OUT) VALUES ( @Cashier, @Loggedin,@LOGGED_OUT);"
            cmd = New SqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                ' .Parameters.AddWithValue("@ID", logidforcashier)
                .Parameters.AddWithValue("@Cashier", FormCasher.Label14.Text)
                .Parameters.AddWithValue("@Loggedin",  Date.Now.ToString)
                .Parameters.AddWithValue("@LOGGED_OUT", Date.Now.ToString)
                .ExecuteNonQuery()
            End With
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            cmd.Dispose()
        End Try
    End Sub

    Public Sub addStockTransaction()
        Try
            dbConnection()
            sql = "INSERT INTO stocks_database (Product_ID_Barcode,Name,Supplier_Name,Quantity,Status,Date,Expiration_Date,Month,Year) VALUES (@ProductID, @Name, @SupplierName, @Quantity, @Status, @Date, @ExpirationDate, @Month, @Year);"
            cmd = New SqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@ProductID", formAdmin.stockinproductLbl.Text)
                .Parameters.AddWithValue("@Name", formAdmin.stockinnameTB.Text)
                .Parameters.AddWithValue("@SupplierName", formAdmin.stockinsuppliernameLbl.Text)
                .Parameters.AddWithValue("@Quantity", formAdmin.stockinquantityTB.Text)
                .Parameters.AddWithValue("@Status", formAdmin.ComboBox1.SelectedItem)
                .Parameters.AddWithValue("@Date", Date.Now.ToString("MM/dd/yyyy"))
                .Parameters.AddWithValue("@ExpirationDate", formAdmin.expirationDTP.Value.ToString("MM/dd/yyyy"))
                .Parameters.AddWithValue("@Year", Date.Now.ToString("yyyy"))
                .Parameters.AddWithValue("@Month", Date.Now.ToString("MM"))
                .ExecuteNonQuery()
            End With
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            retrieveExpirationList()
            formAdmin.stockinproductLbl.Text = ""
            formAdmin.stockinnameTB.Text = ""
            formAdmin.stockinquantityTB.Text = ""
            '  formAdmin.expirationDTP.Value = Date.Now.AddYears("MM/dd/yyyy")
        End Try
    End Sub

    Public Sub addStockOutTransaction()
        Try
            dbConnection()
            sql = "INSERT INTO stocks_database (Product_ID_Barcode,Name,Supplier_Name,Quantity,Status,Date,Expiration_Date,Month,Year) VALUES (@ProductID, @Name,@Supplier_Name, @Quantity, @Status, @Date,@Expiration_Date, @Month, @Year);"
            cmd = New SqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@ProductID", productCodes)
                .Parameters.AddWithValue("@Name", itemdesc)
                .Parameters.AddWithValue("@Supplier_Name", supportnameTR)
                .Parameters.AddWithValue("@Quantity", quantityrow)
                .Parameters.AddWithValue("@Status", "STOCK OUT")
                .Parameters.AddWithValue("@Date", Date.Now.ToString("MM/dd/yyyy"))
                .Parameters.AddWithValue("@Expiration_Date", Date.Now.ToString("MM/dd/yyyy"))
                .Parameters.AddWithValue("@Month", Date.Now.ToString("MM"))
                .Parameters.AddWithValue("@Year", Date.Now.ToString("yyyy"))
                .ExecuteNonQuery()
            End With
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub addDefectiveQuantity()
        Try
            dbConnection()
            sql = "INSERT INTO stocks_database (Product_ID_Barcode,Name,Supplier_Name,Quantity,Status,Date,Remarks) VALUES (@ProductID, @Name, @SupplierName, @Quantity, @Status,@Date, @Remarks);"
            cmd = New SqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@ProductID", formAdmin.defectiveidLbl.Text)
                .Parameters.AddWithValue("@Name", formAdmin.defectivenameTB.Text)
                .Parameters.AddWithValue("@SupplierName", formAdmin.defectivesupplierTB.Text)
                .Parameters.AddWithValue("@Quantity", formAdmin.defectivequantityTB.Text)
                .Parameters.AddWithValue("@Status", "DEFECTIVE")
                .Parameters.AddWithValue("@Date", Date.Now.ToString("MM/dd/yyyy"))
                .Parameters.AddWithValue("@Remarks", formAdmin.remarksTB.Text)
                result = .ExecuteNonQuery()
            End With
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            If result = 0 Then
                MsgBox("Error in defining the product as defective!")
            Else
                MsgBox("Successfully marked the product's quantity as defective!")
            End If
            addDefectiveInformation()
            updateDefQuantity()
            addDefectiveOutTransaction()
            retrieveDefectiveProductList()
            retrieveProductsforDefective()
            retrieveStockOutTrail()
            formAdmin.defectiveidLbl.Text = ""
            formAdmin.defectivenameTB.Text = ""
            formAdmin.defectivequantityTB.Text = ""
            formAdmin.defectivesupplierTB.Text = ""
            formAdmin.remarksTB.Text = ""
            formAdmin.defectivestatusCB.SelectedItem = ""
        End Try
    End Sub

    Public Sub addDefectiveInformation()
        Try
            dbConnection()
            sql = "INSERT INTO defective_database (Name,Supplier_Name,Quantity,Remarks,Defective_Status) VALUES (@Name, @SupplierName, @Quantity, @Remarks, @DefectiveStatus);"
            cmd = New SqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                '.Parameters.AddWithValue("@ID", formAdmin.defectiveidLbl.Text)
                .Parameters.AddWithValue("@Name", formAdmin.defectivenameTB.Text)
                .Parameters.AddWithValue("@SupplierName", formAdmin.defectivesupplierTB.Text)
                .Parameters.AddWithValue("@Quantity", formAdmin.defectivequantityTB.Text)
                .Parameters.AddWithValue("@Remarks", formAdmin.remarksTB.Text)
                .Parameters.AddWithValue("@DefectiveStatus", formAdmin.defectivestatusCB.SelectedItem)
                .ExecuteNonQuery()
            End With
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub addDefectiveOutTransaction()

        Try
            dbConnection()
            sql = "INSERT INTO stocks_database (Product_ID_Barcode,Name,Quantity,Status,Date) VALUES (@ProductID, @Name, @Quantity, @Status, @Date);"
            cmd = New SqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@ProductID", formAdmin.defectiveidLbl.Text)
                .Parameters.AddWithValue("@Name", formAdmin.defectivenameTB.Text)
                .Parameters.AddWithValue("@Quantity", formAdmin.defectivequantityTB.Text)
                .Parameters.AddWithValue("@Status", "DEFECTIVE")
                .Parameters.AddWithValue("@Date", formAdmin.expirationDTP.Text)
                .ExecuteNonQuery()
            End With
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

End Module
