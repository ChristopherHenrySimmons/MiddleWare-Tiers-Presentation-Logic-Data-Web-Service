Imports System.Data.SqlClient

Public Class Service1
    Implements IService1

#Region "DeleteEmployee"
    Public Function DeleteEmployee(ByVal EmployeeID As Integer) As Boolean Implements IService1.DeleteEmployee

        Dim objConnection As SqlConnection
        Dim objCommand As SqlCommand
        Dim retValue As Boolean

        'change
        objConnection = New SqlConnection("Data Source=PE203-30\MSSQLSVR;Initial Catalog=WattsALoan;Integrated Security=True")
        objCommand = New SqlCommand("DeleteEmployee", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        Dim objParameter1 As New SqlParameter("@EmployeeID", SqlDbType.Int)
        objCommand.Parameters.Add(objParameter1)
        objParameter1.Direction = ParameterDirection.Input
        objParameter1.Value = EmployeeID


        Dim objOutputParameter As New SqlParameter("@Response", SqlDbType.Bit)
        objCommand.Parameters.Add(objOutputParameter)
        objOutputParameter.Direction = ParameterDirection.Output

        objConnection.Open()

        objCommand.ExecuteNonQuery()
        retValue = objCommand.Parameters("@Response").Value
        objConnection.Close()

        If retValue Then Return True

        Return False


    End Function
#End Region

#Region "Inserts"

#Region "InsertCustomer"
    Public Function InsertCustomer(ByVal DateCreated As DateTime, ByVal FullName As String, ByVal BillingAddress As String, ByVal BillingCity As String, ByVal BillingState As String, ByVal BillingZIPCide As String, ByVal EmailAddress As String) As Boolean Implements IService1.InsertCustomer

        Dim objConnection As SqlConnection
        Dim objCommand As SqlCommand
        Dim retValue As Boolean

        'change
        objConnection = New SqlConnection("Data Source=PE203-30\MSSQLSVR;Initial Catalog=WattsALoan;Integrated Security=True")
        objCommand = New SqlCommand("InsertCustomer", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        Dim objParameter1 As New SqlParameter("@DateCreated", SqlDbType.DateTime2)
        objCommand.Parameters.Add(objParameter1)
        objParameter1.Direction = ParameterDirection.Input
        objParameter1.Value = DateCreated

        Dim objParameter2 As New SqlParameter("@FullName", SqlDbType.NVarChar)
        objCommand.Parameters.Add(objParameter2)
        objParameter2.Direction = ParameterDirection.Input
        objParameter2.Value = FullName

        Dim objParameter3 As New SqlParameter("@BillingAddress", SqlDbType.NVarChar)
        objCommand.Parameters.Add(objParameter3)
        objParameter3.Direction = ParameterDirection.Input
        objParameter3.Value = BillingAddress

        Dim objParameter4 As New SqlParameter("@BillingCity", SqlDbType.NVarChar)
        objCommand.Parameters.Add(objParameter4)
        objParameter4.Direction = ParameterDirection.Input
        objParameter4.Value = BillingCity

        Dim objParameter5 As New SqlParameter("@BillingState", SqlDbType.NVarChar)
        objCommand.Parameters.Add(objParameter5)
        objParameter5.Direction = ParameterDirection.Input
        objParameter5.Value = BillingState

        Dim objParameter6 As New SqlParameter("@BillingZIPCide", SqlDbType.NVarChar)
        objCommand.Parameters.Add(objParameter6)
        objParameter6.Direction = ParameterDirection.Input
        objParameter6.Value = BillingZIPCide

        Dim objParameter7 As New SqlParameter("@EmailAddress", SqlDbType.NVarChar)
        objCommand.Parameters.Add(objParameter7)
        objParameter7.Direction = ParameterDirection.Input
        objParameter7.Value = EmailAddress

        Dim objOutputParameter As New SqlParameter("@Response", SqlDbType.Bit)
        objCommand.Parameters.Add(objOutputParameter)
        objOutputParameter.Direction = ParameterDirection.Output

        objConnection.Open()

        objCommand.ExecuteNonQuery()
        retValue = objCommand.Parameters("@Response").Value
        objConnection.Close()

        If retValue Then Return True

        Return False


    End Function
#End Region

#Region "InsertEmployee"
    Public Function InsertEmployee(ByVal EmployeeNumber As Integer, ByVal FirstName As String, ByVal LastName As String, ByVal Title As String, ByVal HourlySalary As Double) As Boolean Implements IService1.InsertEmployee

        Dim objConnection As SqlConnection
        Dim objCommand As SqlCommand
        Dim retValue As Boolean

        'change
        objConnection = New SqlConnection("Data Source=PE203-30\MSSQLSVR;Initial Catalog=WattsALoan;Integrated Security=True")
        objCommand = New SqlCommand("InsertCustomer", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        Dim objParameter1 As New SqlParameter("@EmployeeNumber", SqlDbType.NVarChar, 10)
        objCommand.Parameters.Add(objParameter1)
        objParameter1.Direction = ParameterDirection.Input
        objParameter1.Value = EmployeeNumber

        Dim objParameter2 As New SqlParameter("@FirstName", SqlDbType.NVarChar, 20)
        objCommand.Parameters.Add(objParameter2)
        objParameter2.Direction = ParameterDirection.Input
        objParameter2.Value = FirstName

        Dim objParameter3 As New SqlParameter("@LastName", SqlDbType.NVarChar, 10)
        objCommand.Parameters.Add(objParameter3)
        objParameter3.Direction = ParameterDirection.Input
        objParameter3.Value = LastName

        Dim objParameter4 As New SqlParameter("@Title", SqlDbType.NVarChar, 100)
        objCommand.Parameters.Add(objParameter4)
        objParameter4.Direction = ParameterDirection.Input
        objParameter4.Value = Title

        Dim objParameter5 As New SqlParameter("@HourlySalary", SqlDbType.Money)
        objCommand.Parameters.Add(objParameter5)
        objParameter5.Direction = ParameterDirection.Input
        objParameter5.Value = HourlySalary

        Dim objOutputParameter As New SqlParameter("@Response", SqlDbType.Bit)
        objCommand.Parameters.Add(objOutputParameter)
        objOutputParameter.Direction = ParameterDirection.Output

        objConnection.Open()

        objCommand.ExecuteNonQuery()
        retValue = objCommand.Parameters("@Response").Value
        objConnection.Close()

        If retValue Then Return True

        Return False


    End Function
#End Region
#End Region

End Class