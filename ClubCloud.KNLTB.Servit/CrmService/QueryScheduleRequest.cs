using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class QueryScheduleRequest : Request
	{
		private Guid resourceIdField;
		private CrmDateTime startField;
		private CrmDateTime endField;
		private TimeCode[] timeCodesField;
		public Guid ResourceId
		{
			get
			{
				return this.resourceIdField;
			}
			set
			{
				this.resourceIdField = value;
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
