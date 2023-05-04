Imports System.Data.SqlClient

Module publicVariables

    Public conn As SqlConnection
    Public cmd As SqlCommand
    Public da As SqlDataAdapter
    Public dr As SqlDataReader

    Public dt As DataTable
    Public dt2 As DataTable

    Public result As Integer
    Public sql As String

    Public itemdescription As String
    Public supportnameTR As String
    Public quantity As String
    Public charactersallowed As String = "1234567890."
    Public vat As Double = My.Settings("Vat")
    Public Senior As Double = My.Settings("Senior")
    Public vatprice As Double
    Public newprice As Double
    Public totalunitprice As Double
    Public postotal As Double
    Public postotalamount As Double
    Public posvat As Double
    Public cash As Double = 0
    Public subtot As Double = 0
    Public cheque As Double = 0
    Public cellevent As Double = 0
    Public accumulatedpayment As Double = 0
    Public change As Double
    Public quantityrow As String
    Public loginEmplo As String
    Public productCodes As String
    Public itemdesc As String
    Public quantitycheck As String
    Public defectivequantitycheck As String
    Public defectstotalquality As Integer
    Public namecheck As String
    Public row As DataGridViewRow
    Public posproductcode As String
    Public positemdescription As String
    Public totalsales As Double = 0
    Public totalsales2 As Double = 0
    Public employeediscount As String = "NO"
    Public seniordiscount As String = "NO"
    Public checkmasrefresh As String = "NO"
    Public discounted As Double = 0
    Public newdiscount As Double = 0

    Public idno As String
    Public monthexp As String
    Public monthstockin As String
    Public yearstockin As String

    Public storedid As Integer
    Public employeeid As Double

    Public logidforcashier As String
    Public newnumber As Integer
    Public newlogidnumber As String

    Public custchartnum As Integer = 4
    Public catagorychart As Integer = 3
    Public prodectchart As Integer = 6
    Public Empchartnum As Integer = 4
    Public suppchartnum As Integer = 2
    Public salescount As Integer = 13
    Public salestotul As Integer = 2932
End Module
