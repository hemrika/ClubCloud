using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(WrapperName = "Retrieve", WrapperNamespace = "http://schemas.microsoft.com/crm/2007/WebServices", IsWrapped = true)]
	public class RetrieveRequest1
	{
		[MessageHeader(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices"), XmlElement(IsNullable = true)]
		public CrmAuthenticationToken CrmAuthenticationToken;
		[MessageHeader(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices"), XmlElement(IsNullable = true)]
		public CallerOriginToken CallerOriginToken;
		[MessageHeader(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices"), XmlElement(IsNullable = true)]
		public CorrelationToken CorrelationToken;
		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices", Order = 0)]
		public string entityName;
		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices", Order = 1)]
		public Guid id;
		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices", Order = 2)]
		public ColumnSetBase columnSet;
		public RetrieveRequest1()
		{
		}
		public RetrieveRequest1(CrmAuthenticationToken CrmAuthenticationToken, CallerOriginToken CallerOriginToken, CorrelationToken CorrelationToken, string entityName, Guid id, ColumnSetBase columnSet)
		{
			this.CrmAuthenticationToken = CrmAuthenticationToken;
			this.CallerOriginToken = CallerOriginToken;
			this.CorrelationToken = CorrelationToken;
			this.entityName = entityName;
			this.id = id;
			this.columnSet = columnSet;
		}
	}
}
