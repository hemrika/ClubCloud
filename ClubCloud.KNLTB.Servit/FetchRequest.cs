using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(WrapperName = "Fetch", WrapperNamespace = "http://schemas.microsoft.com/crm/2007/WebServices", IsWrapped = true)]
	public class FetchRequest
	{
		[MessageHeader(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices"), XmlElement(IsNullable = true)]
		public CrmAuthenticationToken CrmAuthenticationToken;
		[MessageHeader(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices"), XmlElement(IsNullable = true)]
		public CallerOriginToken CallerOriginToken;
		[MessageHeader(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices"), XmlElement(IsNullable = true)]
		public CorrelationToken CorrelationToken;
		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices", Order = 0)]
		public string fetchXml;
		public FetchRequest()
		{
		}
		public FetchRequest(CrmAuthenticationToken CrmAuthenticationToken, CallerOriginToken CallerOriginToken, CorrelationToken CorrelationToken, string fetchXml)
		{
			this.CrmAuthenticationToken = CrmAuthenticationToken;
			this.CallerOriginToken = CallerOriginToken;
			this.CorrelationToken = CorrelationToken;
			this.fetchXml = fetchXml;
		}
	}
}
