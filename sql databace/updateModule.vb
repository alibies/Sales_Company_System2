Imports System.Data.SqlClient

Module updateModule

    Public Sub updateProducts()
        Try
            dbConnection()
            sql = "UPDATE products_database SET Product_ID_Barcode = @BarcodeID, Name = @Name, Price = @Price, Category = @Category, Price_Code = @PriceCode, Name_of_Supplier = @Supplier, Delivery_Date = @DeliveryDate, Unit = @Unit , Quantity= @Quantity WHERE Product_ID = @ProductID;"
            cmd = New SqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@BarcodeID", formAdmin.productidTB.Text)
                .Parameters.AddWithValue("@ProductID", formAdmin.productID.Text)
                .Parameters.AddWithValue("@Name", formAdmin.productnameTB.Text)
                .Parameters.AddWithValue("@Price", formAdmin.priceTB.Text)
                .Parameters.AddWithValue("@Category", formAdmin.productcategoryCB.Text)
                .Parameters.AddWithValue("@PriceCode", formAdmin.pricecodeTB.Text)
                .Parameters.AddWithValue("@Supplier", formAdmin.nameofsupplierCB.Text)
                .Parameters.AddWithValue("@DeliveryDate", formAdmin.deliveryDTP.Value.ToString("MM/dd/yyyy"))
                .Parameters.AddWithValue("@Unit", formAdmin.unitTB.Text)
                .Parameters.AddWithValue("@Quantity", formAdmin.Texunty.Text)
                result = .ExecuteNonQuery()
                If result = 0 Then
                    MsgBox("Error in updating product!")
                Else
                    MsgBox("Successfully updated the selected product!")
                End If
            End With
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            cmd.Dispose()
            formAdmin.productID.Text = ""
        End Try
    End Sub

    Public Sub updateCategoryProducts()
        Try
            dbConnection()
            sql = "UPDATE category_database SET Name = @Name WHERE Category_ID = @CategoryID;"
            cmd = New SqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@Name", formAdmin.categorynameTB.Text)
                .Parameters.AddWithValue("@CategoryID", formAdmin.categoryID.Text)
                result = .ExecuteNonQuery()
                If result = 0 Then
                    MsgBox("Error in updating product category!")
                Else
                    MsgBox("Successfully updated the selected product category!")
                End If
            End With
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            cmd.Dispose()
            formAdmin.categoryID.Text = ""
        End Try
    End Sub

    Public Sub updateSuppliers()
        Try
            dbConnection()
            sql = "UPDATE suppliers_database SET Name = @Name, Address = @Address, Contact_Number = @ContactNo, TIN = @TinNo WHERE Supplier_ID = @SupplierID;"
            cmd = New SqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@Name", formAdmin.suppliernameTB.Text)
                .Parameters.AddWithValue("@Address", formAdmin.addressTB.Text)
                .Parameters.AddWithValue("@ContactNo", formAdmin.contactnoTB.Text)
                .Parameters.AddWithValue("@TinNo", formAdmin.tinnumberTB.Text)
                .Parameters.AddWithValue("@SupplierID", formAdmin.supplierID.Text)
                result = .ExecuteNonQuery()
                If result = 0 Then
                    MsgBox("Error in updating supplier!")
                Else
                    MsgBox("Successfully updated the selected supplier!")
                End If
            End With
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            cmd.Dispose()
            formAdmin.supplierID.Text = ""
        End Try
    End Sub


    Public Sub updateEmployees()
        Try
            dbConnection()
            sql = "UPDATE employees_database SET First_Name = @FirstName, Middle_Name = @MiddleName, Last_Name = @LastName, Username = @Username, Password = @Password, User_Level = @UserLevel WHERE Employee_ID = @EmployeeID;"
            cmd = New SqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@FirstName", formAdmin.firstnameTB.Text)
                .Parameters.AddWithValue("@MiddleName", formAdmin.middlenameTB.Text)
                .Parameters.AddWithValue("@LastName", formAdmin.lastnameTB.Text)
                .Parameters.AddWithValue("@EmployeeID", formAdmin.employeeID.Text)
                .Parameters.AddWithValue("@Username", formAdmin.usernameTB.Text)
                .Parameters.AddWithValue("@Password", formAdmin.PasswordTB.Text)
                .Parameters.AddWithValue("@UserLevel", formAdmin.userlevelCB.SelectedItem)
                result = .ExecuteNonQuery()
                If result = 0 Then
                    MsgBox("Error in updating employee!")
                Else
                    MsgBox("Successfully updated the selected employee!")
                End If
            End With
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            cmd.Dispose()
        End Try
    End Sub

    Public Sub updateQuantity()
        Try
            dbConnection()
            sql = "UPDATE products_database SET Quantity = Quantity - @Quantity WHERE Product_ID_Barcode = @ProductCode;"
            cmd = New SqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@Quantity", quantityrow)
                .Parameters.AddWithValue("@ProductCode", productCodes)
                .ExecuteNonQuery()
            End With
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub updateDefQuantity()
        Try
            dbConnection()
            sql = "UPDATE products_database SET Quantity = Quantity - @Quantity WHERE Product_ID_Barcode = @ProductCode;"
            cmd = New SqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@Quantity", formAdmin.defectivequantityTB.Text)
                .Parameters.AddWithValue("@ProductCode", formAdmin.defectiveidLbl.Text)
                .ExecuteNonQuery()
            End With
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub updateStockQuantity()
        Try
            dbConnection()
            sql = "UPDATE products_database SET Quantity = Quantity + @Quantity WHERE Product_ID_Barcode = @ProductCode AND Name_of_Supplier = @Supplier AND Status=@Status;"
            cmd = New SqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@Quantity", formAdmin.stockinquantityTB.Text)
                .Parameters.AddWithValue("@ProductCode", formAdmin.stockinproductLbl.Text)
                .Parameters.AddWithValue("@Supplier", formAdmin.stockinsuppliernameLbl.Text)
                .Parameters.AddWithValue("@Status", formAdmin.ComboBox1.SelectedItem)
                result = .ExecuteNonQuery()
                If result = 0 Then
                    MsgBox("Error in updating stocks!")
                Else
                    MsgBox("Successfully added stocks!")
                End If
            End With
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            addStockTransaction()
            retrieveProductQuantity()
            retrieveStockTrail()
            retrieveProductsforDefective()
            retrieveProducts
        End Try
    End Sub

    Public Sub updateDefectiveQuantity()
        Try
            dbConnection()
            sql = "UPDATE stocks_database SET Quantity = Quantity + @Quantity, Remarks = @Remarks WHERE Product_ID_Barcode = @ProductID And Status = @Status;"
            cmd = New SqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@Quantity", formAdmin.defectivequantityTB.Text)
                .Parameters.AddWithValue("@ProductID", formAdmin.defectiveidLbl.Text)
                .Parameters.AddWithValue("@Status", "DEFECTIVE")
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
        End Try
    End Sub

    Public Sub updateStockinquantityLatest()
        Try
            idno = dt.Rows(0).Item(0)
            dbConnection()
            sql = "UPDATE stocks_database SET Quantity = Quantity - @Quantity WHERE ID = @ID;"
            cmd = New SqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@Quantity", quantityrow)
                .Parameters.AddWithValue("@ID", idno)
                .ExecuteNonQuery()
            End With
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub updateloginlogs()
        Try
            dbConnection()
            sql = "UPDATE employee_loginlogs SET LOGGED_OUT = @LoggedOut WHERE ID = @ID;"
            cmd = New SqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@LoggedOut", Date.Now.ToString("MM/dd/yy hh:mm:ss tt"))
                .Parameters.AddWithValue("@ID", logidforcashier)
                result = .ExecuteNonQuery()
            End With
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub updatelogidtoone()
        dbConnection()
        newnumber = Integer.Parse(logidforcashier) + 1
        newlogidnumber = newnumber
        If newlogidnumber.Length = 1 Then
            newlogidnumber = "00" + newlogidnumber
        ElseIf newlogidnumber.Length = 2 Then
            newlogidnumber = "0" + newlogidnumber
        Else
            newlogidnumber = newlogidnumber
        End If
        Try
            dbConnection()
            sql = "UPDATE employee_id SET ID = @ID;"
            cmd = New SqlCommand
            With cmd
                .Connection = conn
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@ID", newlogidnumber)
                result = .ExecuteNonQuery()
            End With
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Public Sub updataCustomer()
        Try
            dbConnection()
            sql = "UPDATE Custome_database SET Name = @Name, Address = @Address, Contact_Number = @ContactNo, TIN = @TinNo WHERE Name = @Name;"
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
                    MsgBox("Error in updating Customer!")
                Else
                    MsgBox("Successfully updated the selected Customer!")
                End If
            End With
        Catch ex As SqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            cmd.Dispose()
        End Try
    End Sub


End Module
