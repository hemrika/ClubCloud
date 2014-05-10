using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services.Protocols;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlRoot(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices", IsNullable = true), XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/CoreTypes")]
	[Serializable]
	public class CorrelationToken : SoapHeader
	{
		private Guid correlationIdField;
		private CrmDateTime correlationUpdatedTimeField;
		private int depthField;
		public Guid CorrelationId
		{
			get
			{
				return this.correlationIdField;
			}
			set
			{
				this.correlationIdField = value;
			}
		}
		public CrmDateTime CorrelationUpdatedTime
		{
			get
			{
				return this.correlationUpdatedTimeField;
			}
			set
			{
				this.correlationUpdatedTimeField = value;
			}
		}
		public int Depth
		{
			get
			{
				return this.depthField;
			}
			set
			{
				this.depthField = value;
			}
		}
	}
}
