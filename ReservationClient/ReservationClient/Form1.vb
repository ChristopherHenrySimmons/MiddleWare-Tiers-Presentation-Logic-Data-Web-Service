Imports System.Data.SqlClient
Imports System.Data

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim objConnection As SqlConnection
        Dim objCommand As SqlCommand
        Dim retValue As Boolean

        'change
        objConnection = New SqlConnection("Data Source=PE203-30\MSSQLSVR;Initial Catalog=TICKETS;Integrated Security=True")
        objCommand = New SqlCommand("Reserve", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        Dim objParameter1 As New SqlParameter("@seatType", SqlDbType.VarChar, 50)
        objCommand.Parameters.Add(objParameter1)
        objParameter1.Direction = ParameterDirection.Input
        objParameter1.Value = seatType.Text

        Dim objParameter2 As New SqlParameter("@classType", SqlDbType.VarChar, 50)
        objCommand.Parameters.Add(objParameter2)
        objParameter2.Direction = ParameterDirection.Input
        objParameter2.Value = classType.Text

        Dim objOutputParameter As New SqlParameter("@Response", SqlDbType.Bit)
        objCommand.Parameters.Add(objOutputParameter)
        objOutputParameter.Direction = ParameterDirection.Output

        objConnection.Open()

        objCommand.ExecuteNonQuery()
        retValue = objCommand.Parameters("@Response").Value
        objConnection.Close()

        TextBox1.Text = retValue.ToString

    End Sub

    Private Sub ButtonInsert_Click(sender As Object, e As EventArgs) Handles ButtonInsert.Click
        Dim objConnection As SqlConnection
        Dim objCommand As SqlCommand
        Dim retValue As Boolean

        'change
        objConnection = New SqlConnection("Data Source=PE203-30\MSSQLSVR;Initial Catalog=WattsALoan;Integrated Security=True")
        objCommand = New SqlCommand("InsertCustomer", objConnection)
        objCommand.CommandType = CommandType.StoredProcedure

        'Dim objParameter1 As New SqlParameter("@DateCreated", SqlDbType.DateTime2)
        'objCommand.Parameters.Add(objParameter1)
        'objParameter1.Direction = ParameterDirection.Input
        'objParameter1.Value = DateCreated

        Dim objParameter2 As New SqlParameter("@FullName", SqlDbType.NVarChar)
        objCommand.Parameters.Add(objParameter2)
        objParameter2.Direction = ParameterDirection.Input
        objParameter2.Value = TextBoxFullName

        Dim objParameter3 As New SqlParameter("@BillingAddress", SqlDbType.NVarChar)
        objCommand.Parameters.Add(objParameter3)
        objParameter3.Direction = ParameterDirection.Input
        objParameter3.Value = TextBoxBillingAddress

        Dim objParameter4 As New SqlParameter("@BillingCity", SqlDbType.NVarChar)
        objCommand.Parameters.Add(objParameter4)
        objParameter4.Direction = ParameterDirection.Input
        objParameter4.Value = TextBoxBillingCity

        Dim objParameter5 As New SqlParameter("@BillingState", SqlDbType.NVarChar)
        objCommand.Parameters.Add(objParameter5)
        objParameter5.Direction = ParameterDirection.Input
        objParameter5.Value = TextBoxBillingState

        Dim objParameter6 As New SqlParameter("@BillingZIPCide", SqlDbType.NVarChar)
        objCommand.Parameters.Add(objParameter6)
        objParameter6.Direction = ParameterDirection.Input
        objParameter6.Value = TextBoxBillingZIPCide

        Dim objParameter7 As New SqlParameter("@EmailAddress", SqlDbType.NVarChar)
        objCommand.Parameters.Add(objParameter7)
        objParameter7.Direction = ParameterDirection.Input
        objParameter7.Value = TextBoxEmailAddress

        Dim objOutputParameter As New SqlParameter("@Response", SqlDbType.Bit)
        objCommand.Parameters.Add(objOutputParameter)
        objOutputParameter.Direction = ParameterDirection.Output

        objConnection.Open()

        objCommand.ExecuteNonQuery()
        retValue = objCommand.Parameters("@Response").Value
        objConnection.Close()

        TextBoxInsertCustomerReturn.Text = retValue.ToString
    End Sub

    Private Sub ButtonDeleteEmployee_Click(sender As Object, e As EventArgs) Handles ButtonDeleteEmployee.Click
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
        objParameter1.Value = TextBoxEmployeeID.Text

        Dim objOutputParameter As New SqlParameter("@Response", SqlDbType.Bit)
        objCommand.Parameters.Add(objOutputParameter)
        objOutputParameter.Direction = ParameterDirection.Output

        objConnection.Open()

        objCommand.ExecuteNonQuery()
        retValue = objCommand.Parameters("@Response").Value
        objConnection.Close()

        TextBoxDeleteEmployeeReturn.Text = retValue.ToString
    End Sub
End Class