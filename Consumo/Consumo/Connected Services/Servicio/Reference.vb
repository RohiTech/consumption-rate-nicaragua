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


Namespace Servicio
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute([Namespace]:="http://servicios.bcn.gob.ni/", ConfigurationName:="Servicio.Tipo_Cambio_BCNSoap")>  _
    Public Interface Tipo_Cambio_BCNSoap
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://servicios.bcn.gob.ni/RecuperaTC_Dia", ReplyAction:="*")>  _
        Function RecuperaTC_Dia(ByVal Ano As Integer, ByVal Mes As Integer, ByVal Dia As Integer) As Double
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://servicios.bcn.gob.ni/RecuperaTC_Dia", ReplyAction:="*")>  _
        Function RecuperaTC_DiaAsync(ByVal Ano As Integer, ByVal Mes As Integer, ByVal Dia As Integer) As System.Threading.Tasks.Task(Of Double)
        
        'CODEGEN: Generating message contract since element name RecuperaTC_MesResult from namespace http://servicios.bcn.gob.ni/ is not marked nillable
        <System.ServiceModel.OperationContractAttribute(Action:="http://servicios.bcn.gob.ni/RecuperaTC_Mes", ReplyAction:="*")>  _
        Function RecuperaTC_Mes(ByVal request As Servicio.RecuperaTC_MesRequest) As Servicio.RecuperaTC_MesResponse
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://servicios.bcn.gob.ni/RecuperaTC_Mes", ReplyAction:="*")>  _
        Function RecuperaTC_MesAsync(ByVal request As Servicio.RecuperaTC_MesRequest) As System.Threading.Tasks.Task(Of Servicio.RecuperaTC_MesResponse)
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class RecuperaTC_MesRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="RecuperaTC_Mes", [Namespace]:="http://servicios.bcn.gob.ni/", Order:=0)>  _
        Public Body As Servicio.RecuperaTC_MesRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As Servicio.RecuperaTC_MesRequestBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://servicios.bcn.gob.ni/")>  _
    Partial Public Class RecuperaTC_MesRequestBody
        
        <System.Runtime.Serialization.DataMemberAttribute(Order:=0)>  _
        Public Ano As Integer
        
        <System.Runtime.Serialization.DataMemberAttribute(Order:=1)>  _
        Public Mes As Integer
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Ano As Integer, ByVal Mes As Integer)
            MyBase.New
            Me.Ano = Ano
            Me.Mes = Mes
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class RecuperaTC_MesResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="RecuperaTC_MesResponse", [Namespace]:="http://servicios.bcn.gob.ni/", Order:=0)>  _
        Public Body As Servicio.RecuperaTC_MesResponseBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As Servicio.RecuperaTC_MesResponseBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://servicios.bcn.gob.ni/")>  _
    Partial Public Class RecuperaTC_MesResponseBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public RecuperaTC_MesResult As System.Xml.XmlElement
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal RecuperaTC_MesResult As System.Xml.XmlElement)
            MyBase.New
            Me.RecuperaTC_MesResult = RecuperaTC_MesResult
        End Sub
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface Tipo_Cambio_BCNSoapChannel
        Inherits Servicio.Tipo_Cambio_BCNSoap, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class Tipo_Cambio_BCNSoapClient
        Inherits System.ServiceModel.ClientBase(Of Servicio.Tipo_Cambio_BCNSoap)
        Implements Servicio.Tipo_Cambio_BCNSoap
        
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
        
        Public Function RecuperaTC_Dia(ByVal Ano As Integer, ByVal Mes As Integer, ByVal Dia As Integer) As Double Implements Servicio.Tipo_Cambio_BCNSoap.RecuperaTC_Dia
            Return MyBase.Channel.RecuperaTC_Dia(Ano, Mes, Dia)
        End Function
        
        Public Function RecuperaTC_DiaAsync(ByVal Ano As Integer, ByVal Mes As Integer, ByVal Dia As Integer) As System.Threading.Tasks.Task(Of Double) Implements Servicio.Tipo_Cambio_BCNSoap.RecuperaTC_DiaAsync
            Return MyBase.Channel.RecuperaTC_DiaAsync(Ano, Mes, Dia)
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function Servicio_Tipo_Cambio_BCNSoap_RecuperaTC_Mes(ByVal request As Servicio.RecuperaTC_MesRequest) As Servicio.RecuperaTC_MesResponse Implements Servicio.Tipo_Cambio_BCNSoap.RecuperaTC_Mes
            Return MyBase.Channel.RecuperaTC_Mes(request)
        End Function
        
        Public Function RecuperaTC_Mes(ByVal Ano As Integer, ByVal Mes As Integer) As System.Xml.XmlElement
            Dim inValue As Servicio.RecuperaTC_MesRequest = New Servicio.RecuperaTC_MesRequest()
            inValue.Body = New Servicio.RecuperaTC_MesRequestBody()
            inValue.Body.Ano = Ano
            inValue.Body.Mes = Mes
            Dim retVal As Servicio.RecuperaTC_MesResponse = CType(Me,Servicio.Tipo_Cambio_BCNSoap).RecuperaTC_Mes(inValue)
            Return retVal.Body.RecuperaTC_MesResult
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function Servicio_Tipo_Cambio_BCNSoap_RecuperaTC_MesAsync(ByVal request As Servicio.RecuperaTC_MesRequest) As System.Threading.Tasks.Task(Of Servicio.RecuperaTC_MesResponse) Implements Servicio.Tipo_Cambio_BCNSoap.RecuperaTC_MesAsync
            Return MyBase.Channel.RecuperaTC_MesAsync(request)
        End Function
        
        Public Function RecuperaTC_MesAsync(ByVal Ano As Integer, ByVal Mes As Integer) As System.Threading.Tasks.Task(Of Servicio.RecuperaTC_MesResponse)
            Dim inValue As Servicio.RecuperaTC_MesRequest = New Servicio.RecuperaTC_MesRequest()
            inValue.Body = New Servicio.RecuperaTC_MesRequestBody()
            inValue.Body.Ano = Ano
            inValue.Body.Mes = Mes
            Return CType(Me,Servicio.Tipo_Cambio_BCNSoap).RecuperaTC_MesAsync(inValue)
        End Function
    End Class
End Namespace