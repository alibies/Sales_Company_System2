Module clearModule

    Public Sub clearProducts()
        formAdmin.productID.Text = ""
        formAdmin.productidTB.Text = ""
        formAdmin.productnameTB.Text = ""
        formAdmin.priceTB.Text = ""
        formAdmin.pricecodeTB.Text = ""
        formAdmin.productcategoryCB.Text = ""
        formAdmin.nameofsupplierCB.Text = ""
        formAdmin.unitTB.Text = ""
    End Sub

    Public Sub clearProductCategory()
        formAdmin.categorynameTB.Text = ""
    End Sub

    Public Sub clearSuppliers()
        formAdmin.suppliernameTB.Text = ""
        formAdmin.addressTB.Text = ""
        formAdmin.contactnoTB.Text = ""
        formAdmin.tinnumberTB.Text = ""
    End Sub
    Public Sub CleanCustomer()
        formAdmin.customernameTB.Text = ""
        formAdmin.addressCUSTTB.Text = ""
        formAdmin.contactnoCUSTTB.Text = ""
        formAdmin.tinnumberCUSTTB.Text = ""
    End Sub

    Public Sub clearEmployees()
        formAdmin.firstnameTB.Text = ""
        formAdmin.middlenameTB.Text = ""
        formAdmin.lastnameTB.Text = ""
        formAdmin.usernameTB.Text = ""
        formAdmin.PasswordTB.Text = ""
    End Sub
End Module
