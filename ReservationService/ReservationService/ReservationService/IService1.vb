' NOTE: You can use the "Rename" command on the context menu to change the interface name "IService1" in both code and config file together.
<ServiceContract()>
Public Interface IService1

    <OperationContract()>
    Function DeleteEmployee(ByVal EmployeeID As Integer) As Boolean

    <OperationContract()>
    Function InsertCustomer(ByVal DateCreated As DateTime, ByVal FullName As String, ByVal BillingAddress As String, ByVal BillingCity As String, ByVal BillingState As String, ByVal BillingZIPCide As String, ByVal EmailAddress As String) As Boolean

    <OperationContract>
    Function InsertEmployee(ByVal EmployeeNumber As Integer, ByVal FirstName As String, ByVal LastName As String, ByVal Title As String, ByVal HourlySalary As Double) As Boolean

    <OperationContract>
    Function InsertLoan(ByVal LoanType As String) As Boolean

    <OperationContract>
    Function InsertLoanAllocation(ByVal DatePreperd As DateTime, ByVal EmployeeID As Integer, ByVal CustomerID As Integer, ByVal AccountNumber As String, ByVal LoanTypeID As String, ByVal LoanAmount As Double, ByVal InterestRate As Decimal, ByVal Periods As Decimal) As Boolean
End Interface

