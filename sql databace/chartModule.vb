Imports System.Data.SqlClient
Module chartModule
    Public Sub chart()
        formAdmin.Chart1.Series("Customer").Points.AddXY("customer", custchartnum)
        formAdmin.Chart2.Series("Employes").Points.AddXY("Employes", Empchartnum)
        formAdmin.Chart3.Series("suppliers").Points.AddXY("suppliers", suppchartnum)
        formAdmin.Chart4.Series("Sales").Points.AddXY("Sales", salescount)
        formAdmin.Chart5.Series("Total").Points.AddXY("Total", salestotul)
        formAdmin.Chart6.Series("Total").Points.AddXY("2024", 8000)
        formAdmin.Chart6.Series("Total").Points.AddXY("2023", salestotul)
        formAdmin.Chart7.Series("prodect").Points.AddXY("prodect", prodectchart)
        formAdmin.Chart8.Series("catagory").Points.AddXY("catagory", catagorychart)
        formAdmin.Chart9.Series("Total").Points.AddXY("prodect", prodectchart)
        formAdmin.Chart9.Series("Total").Points.AddXY("catagory", catagorychart)
        formAdmin.Chart9.Series("Total").Points.AddXY("Stock IN", 5)
        formAdmin.Chart9.Series("Total").Points.AddXY("Stock out", 12)
        formAdmin.Chart9.Series("Total").Points.AddXY("Deffective", 3)
        formAdmin.Chart5.Show()

    End Sub
End Module
