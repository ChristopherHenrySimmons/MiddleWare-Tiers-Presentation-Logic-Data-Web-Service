﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace ServiceReference1
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="ServiceReference1.IService1")>  _
    Public Interface IService1
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IService1/DeleteEmployee", ReplyAction:="http://tempuri.org/IService1/DeleteEmployeeResponse")>  _
        Function DeleteEmployee(ByVal EmployeeID As Integer) As Boolean
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IService1/InsertCustomer", ReplyAction:="http://tempuri.org/IService1/InsertCustomerResponse")>  _
        Function InsertCustomer(ByVal DateCreated As Date, ByVal FullName As String, ByVal BillingAddress As String, ByVal BillingCity As String, ByVal BillingState As String, ByVal BillingZIPCide As String, ByVal EmailAddress As String) As Boolean
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IService1/InsertEmployee", ReplyAction:="http://tempuri.org/IService1/InsertEmployeeResponse")>  _
        Function InsertEmployee(ByVal EmployeeNumber As Integer, ByVal FirstName As String, ByVal LastName As String, ByVal Title As String, ByVal HourlySalary As Double) As Boolean
    End Interface
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface IService1Channel
        Inherits ServiceReference1.IService1, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class Service1Client
        Inherits System.ServiceModel.ClientBase(Of ServiceReference1.IService1)
        Implements ServiceReference1.IService1
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        Public Function DeleteEmployee(ByVal EmployeeID As Integer) As Boolean Implements ServiceReference1.IService1.DeleteEmployee
            Return MyBase.Channel.DeleteEmployee(EmployeeID)
        End Function
        
        Public Function InsertCustomer(ByVal DateCreated As Date, ByVal FullName As String, ByVal BillingAddress As String, ByVal BillingCity As String, ByVal BillingState As String, ByVal BillingZIPCide As String, ByVal EmailAddress As String) As Boolean Implements ServiceReference1.IService1.InsertCustomer
            Return MyBase.Channel.InsertCustomer(DateCreated, FullName, BillingAddress, BillingCity, BillingState, BillingZIPCide, EmailAddress)
        End Function
        
        Public Function InsertEmployee(ByVal EmployeeNumber As Integer, ByVal FirstName As String, ByVal LastName As String, ByVal Title As String, ByVal HourlySalary As Double) As Boolean Implements ServiceReference1.IService1.InsertEmployee
            Return MyBase.Channel.InsertEmployee(EmployeeNumber, FirstName, LastName, Title, HourlySalary)
        End Function
    End Class
End Namespace
