using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class QueryMultipleSchedulesRequest : Request
	{
		private Guid[] resourceIdsField;
		private CrmDateTime startField;
		private CrmDateTime endField;
		private TimeCode[] timeCodesField;
		public Guid[] ResourceIds
		{
			get
			{
				return this.resourceIdsField;
			}
			set
			{
				this.resourceIdsField = value;
			}
		}
		public CrmDateTime Start
		{
			get
			{
				return this.startField;
			}
			set
			{
				this.startField = value;
			}
		}
		public CrmDateTime End
		{
			get
			{
				return this.endField;
			}
			set
			{
				this.endField = value;
			}
		}
		public TimeCode[] TimeCodes
		{
			get
			{
				return this.timeCodesField;
			}
			set
			{
				this.timeCodesField = value;
			}
		}
	}
}
