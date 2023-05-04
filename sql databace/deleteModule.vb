Imports System.Data.SqlClient

Module deleteModule

    Public Sub deleteProducts()
        formAdmin.pdeleteBtn.Text = MessageBox.Show("Are you sure you want to delete the selected product?", "WARNING: DELETION OF PRODUCT!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If formAdmin.pdeleteBtn.Text = DialogResult.Yes Then
            formAdmin.pdeleteBtn.Text = "Delete"
            Try
                dbConnection()
                sql = "DELETE FROM products_database WHERE Product_ID = @ProductID;"
                cmd = New SqlCommand
                With cmd
                    .Connection = conn
                    .CommandText = sql
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@ProductID", formAdmin.productID.Text)
                    result = .ExecuteNonQuery()
                    If result = 0 Then
                        MsgBox("Error in deleting product!")
                    Else
                        MsgBox("Successfully deleted the selected product!")
                        prodectchart -= 1
                    End If
                End With
            Catch ex As SqlException
                MsgBox(ex.Message)
            Finally
                conn.Close()
                cmd.Dispose()
                formAdmin.productID.Text = ""
            End Try
        Else
            formAdmin.pdeleteBtn.Text = "Delete"
        End If
       
    End Sub

    Public Sub deleteCategoryProducts()
        formAdmin.pcdeleteBtn.Text = MessageBox.Show("Are you sure you want to delete the selected product category?", "WARNING: DELETION OF PRODUCT CATEGORY!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If formAdmin.pcdeleteBtn.Text = DialogResult.Yes Then
            formAdmin.pcdeleteBtn.Text = "Delete"
            Try
                dbConnection()
                sql = "DELETE FROM category_database WHERE Category_ID = @CategoryID;"
                cmd = New SqlCommand
                With cmd
                    .Connection = conn
                    .CommandText = sql
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@CategoryID", formAdmin.categoryID.Text)
                    result = .ExecuteNonQuery()
                    If result = 0 Then
                        MsgBox("Error in deleting product category!")
                    Else
                        MsgBox("Successfully deleted the selected product category!")
                        catagorychart -= 1
                    End If
                End With
            Catch ex As SqlException
                MsgBox(ex.Message)
            Finally
                conn.Close()
                cmd.Dispose()
                formAdmin.categoryID.Text = ""
            End Try
        Else
            formAdmin.pcdeleteBtn.Text = "Delete"
        End If
      
    End Sub
    Public Sub deleteCustomer()
        formAdmin.DeletButt.Text = MessageBox.Show("Are you sure you want to delete the selected supplier?", "WARNING: DELETION OF SUPPLIER!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If formAdmin.DeletButt.Text = DialogResult.Yes Then
            formAdmin.DeletButt.Text = "Delete"
            Try
                dbConnection()
                sql = "DELETE FROM Custome_database WHERE Name = @Name;"
                cmd = New SqlCommand
                With cmd
                    .Connection = conn
                    .CommandText = sql
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@Name", formAdmin.customernameTB.Text)
                    result = .ExecuteNonQuery()
                    If result = 0 Then
                        MsgBox("Error in deleting customer!")
                    Else
                        MsgBox("Successfully deleted the selected customer!")
                        custchartnum -= 1
                    End If
                End With
            Catch ex As SqlException
                MsgBox(ex.Message)
            Finally
                conn.Close()
                cmd.Dispose()
            End Try
        Else
            formAdmin.DeletButt.Text = "Delete"
        End If

    End Sub
    Public Sub deleteSuppliers()
        formAdmin.sdeleteBtn.Text = MessageBox.Show("Are you sure you want to delete the selected supplier?", "WARNING: DELETION OF SUPPLIER!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If formAdmin.sdeleteBtn.Text = DialogResult.Yes Then
            formAdmin.sdeleteBtn.Text = "Delete"
            Try
                dbConnection()
                sql = "DELETE FROM suppliers_database WHERE Supplier_ID = @SupplierID;"
                cmd = New SqlCommand
                With cmd
                    .Connection = conn
                    .CommandText = sql
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@SupplierID", formAdmin.supplierID.Text)
                    result = .ExecuteNonQuery()
                    If result = 0 Then
                        MsgBox("Error in deleting supplier!")
                    Else
                        MsgBox("Successfully deleted the selected supplier!")
                        suppchartnum -= 1
                    End If
                End With
            Catch ex As SqlException
                MsgBox(ex.Message)
            Finally
                conn.Close()
                cmd.Dispose()
                formAdmin.supplierID.Text = ""
            End Try
        Else
            formAdmin.sdeleteBtn.Text = "Delete"
        End If
       
    End Sub

    Public Sub deleteEmployees()
        formAdmin.edeleteBtn.Text = MessageBox.Show("Are you sure you want to delete the selected employeeID?", "WARNING: DELETION OF EMPLOYEE!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If formAdmin.edeleteBtn.Text = DialogResult.Yes Then
            formAdmin.edeleteBtn.Text = "Delete"
            Try
                dbConnection()
                sql = "DELETE FROM employees_database WHERE Employee_ID = @Employee_ID;"
                cmd = New SqlCommand
                With cmd
                    .Connection = conn
                    .CommandText = sql
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@Employee_ID", formAdmin.Employeebut.Text)
                    result = .ExecuteNonQuery()
                    If result = 0 Then
                        MsgBox("Error in deleting employee!")
                    Else
                        MsgBox("Successfully deleted the selected employee!")
                        Empchartnum -= 1
                    End If
                End With
            Catch ex As SqlException
                MsgBox(ex.Message)
            Finally
                conn.Close()
                cmd.Dispose()
                formAdmin.employeeID.Text = ""
            End Try
        Else
            formAdmin.edeleteBtn.Text = "Delete"
        End If
    End Sub

End Module
