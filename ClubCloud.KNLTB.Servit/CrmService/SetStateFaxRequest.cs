using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateFaxRequest : Request
	{
		private Guid entityIdField;
		private FaxState faxStateField;
		private int faxStatusField;
		public Guid EntityId
		{
			get
			{
				return this.entityIdField;
			}
			set
			{
				this.entityIdField = value;
			}
		}
		public FaxState FaxState
		{
			get
			{
				return this.faxStateField;
			}
			set
			{
				this.faxStateField = value;
			}
		}
		public int FaxStatus
		{
			get
			{
				return this.faxStatusField;
			}
			set
			{
				this.faxStatusField = value;
			}
		}
	}
}
