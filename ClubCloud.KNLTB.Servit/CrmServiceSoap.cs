using System;
using System.CodeDom.Compiler;
using System.ServiceModel;
using System.Threading.Tasks;
using System.Web.Services;
using System.Web.Services.Description;
using System.Web.Services.Protocols;
namespace ClubCloud.KNLTB.ServIt
{
	//[GeneratedCode("System.ServiceModel", "4.0.0.0"), ServiceContract(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
    [WebServiceBinding(Name = "CrmServiceSoap", Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	public interface CrmServiceSoap
	{
        //[SoapDocumentMethod("http://schemas.microsoft.com/crm/2007/WebServices/Execute", RequestNamespace = "http://schemas.microsoft.com/crm/2007/WebServices", ResponseNamespace = "http://schemas.microsoft.com/crm/2007/WebServices", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]//, SoapHeader("CallerOriginTokenValue"), SoapHeader("CorrelationTokenValue"), SoapHeader("CrmAuthenticationTokenValue")]
		[OperationContract(Action = "http://schemas.microsoft.com/crm/2007/WebServices/Execute", ReplyAction = "*"), ServiceKnownType(typeof(CrmReference)), ServiceKnownType(typeof(Property[])), ServiceKnownType(typeof(activityparty[])), XmlSerializerFormat(SupportFaults = true)]//,SoapHeader("CallerOriginTokenValue"),SoapHeader("CorrelationTokenValue"),SoapHeader("CrmAuthenticationTokenValue")]
		ExecuteResponse Execute(ExecuteRequest request);
        [OperationContract(Action = "http://schemas.microsoft.com/crm/2007/WebServices/Execute", ReplyAction = "*"), SoapHeader("CallerOriginTokenValue"), SoapHeader("CorrelationTokenValue"), SoapHeader("CrmAuthenticationTokenValue")]
		Task<ExecuteResponse> ExecuteAsync(ExecuteRequest request);
        [OperationContract(Action = "http://schemas.microsoft.com/crm/2007/WebServices/Fetch", ReplyAction = "*"), ServiceKnownType(typeof(Property[])), ServiceKnownType(typeof(activityparty[])), ServiceKnownType(typeof(CrmReference)), XmlSerializerFormat(SupportFaults = true), SoapHeader("CallerOriginTokenValue"), SoapHeader("CorrelationTokenValue"), SoapHeader("CrmAuthenticationTokenValue")]
		FetchResponse Fetch(FetchRequest request);
        [OperationContract(Action = "http://schemas.microsoft.com/crm/2007/WebServices/Fetch", ReplyAction = "*"), SoapHeader("CallerOriginTokenValue"), SoapHeader("CorrelationTokenValue"), SoapHeader("CrmAuthenticationTokenValue")]
		Task<FetchResponse> FetchAsync(FetchRequest request);
        [OperationContract(Action = "http://schemas.microsoft.com/crm/2007/WebServices/Create", ReplyAction = "*"), ServiceKnownType(typeof(activityparty[])), ServiceKnownType(typeof(CrmReference)), ServiceKnownType(typeof(Property[])), XmlSerializerFormat(SupportFaults = true), SoapHeader("CallerOriginTokenValue"), SoapHeader("CorrelationTokenValue"), SoapHeader("CrmAuthenticationTokenValue")]
		CreateResponse1 Create(CreateRequest1 request);
        [OperationContract(Action = "http://schemas.microsoft.com/crm/2007/WebServices/Create", ReplyAction = "*"), SoapHeader("CallerOriginTokenValue"), SoapHeader("CorrelationTokenValue"), SoapHeader("CrmAuthenticationTokenValue")]
		Task<CreateResponse1> CreateAsync(CreateRequest1 request);
        [OperationContract(Action = "http://schemas.microsoft.com/crm/2007/WebServices/Delete", ReplyAction = "*"), ServiceKnownType(typeof(activityparty[])), ServiceKnownType(typeof(CrmReference)), ServiceKnownType(typeof(Property[])), XmlSerializerFormat(SupportFaults = true), SoapHeader("CallerOriginTokenValue"), SoapHeader("CorrelationTokenValue"), SoapHeader("CrmAuthenticationTokenValue")]
		DeleteResponse1 Delete(DeleteRequest1 request);
        [OperationContract(Action = "http://schemas.microsoft.com/crm/2007/WebServices/Delete", ReplyAction = "*"), SoapHeader("CallerOriginTokenValue"), SoapHeader("CorrelationTokenValue"), SoapHeader("CrmAuthenticationTokenValue")]
		Task<DeleteResponse1> DeleteAsync(DeleteRequest1 request);
        [OperationContract(Action = "http://schemas.microsoft.com/crm/2007/WebServices/Retrieve", ReplyAction = "*"), ServiceKnownType(typeof(activityparty[])), ServiceKnownType(typeof(CrmReference)), ServiceKnownType(typeof(Property[])), XmlSerializerFormat(SupportFaults = true), SoapHeader("CallerOriginTokenValue"), SoapHeader("CorrelationTokenValue"), SoapHeader("CrmAuthenticationTokenValue")]
		RetrieveResponse1 Retrieve(RetrieveRequest1 request);
        [OperationContract(Action = "http://schemas.microsoft.com/crm/2007/WebServices/Retrieve", ReplyAction = "*"), SoapHeader("CallerOriginTokenValue"), SoapHeader("CorrelationTokenValue"), SoapHeader("CrmAuthenticationTokenValue")]
		Task<RetrieveResponse1> RetrieveAsync(RetrieveRequest1 request);
        [OperationContract(Action = "http://schemas.microsoft.com/crm/2007/WebServices/RetrieveMultiple", ReplyAction = "*"), ServiceKnownType(typeof(CrmReference)), ServiceKnownType(typeof(Property[])), ServiceKnownType(typeof(activityparty[])), XmlSerializerFormat(SupportFaults = true), SoapHeader("CallerOriginTokenValue"), SoapHeader("CorrelationTokenValue"), SoapHeader("CrmAuthenticationTokenValue")]
		RetrieveMultipleResponse1 RetrieveMultiple(RetrieveMultipleRequest1 request);
        [OperationContract(Action = "http://schemas.microsoft.com/crm/2007/WebServices/RetrieveMultiple", ReplyAction = "*"), SoapHeader("CallerOriginTokenValue"), SoapHeader("CorrelationTokenValue"), SoapHeader("CrmAuthenticationTokenValue")]
		Task<RetrieveMultipleResponse1> RetrieveMultipleAsync(RetrieveMultipleRequest1 request);
        [OperationContract(Action = "http://schemas.microsoft.com/crm/2007/WebServices/Update", ReplyAction = "*"), ServiceKnownType(typeof(CrmReference)), ServiceKnownType(typeof(Property[])), ServiceKnownType(typeof(activityparty[])), XmlSerializerFormat(SupportFaults = true), SoapHeader("CallerOriginTokenValue"), SoapHeader("CorrelationTokenValue"), SoapHeader("CrmAuthenticationTokenValue")]
		UpdateResponse1 Update(UpdateRequest1 request);
        [OperationContract(Action = "http://schemas.microsoft.com/crm/2007/WebServices/Update", ReplyAction = "*"), SoapHeader("CallerOriginTokenValue"), SoapHeader("CorrelationTokenValue"), SoapHeader("CrmAuthenticationTokenValue")]
		Task<UpdateResponse1> UpdateAsync(UpdateRequest1 request);
	}
}
