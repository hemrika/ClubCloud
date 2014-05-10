using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSw_lookuptemplateRequest : Request
	{
		private Guid entityIdField;
		private Sw_lookuptemplateState sw_lookuptemplateStateField;
		private int sw_lookuptemplateStatusField;
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
		public Sw_lookuptemplateState Sw_lookuptemplateState
		{
			get
			{
				return this.sw_lookuptemplateStateField;
			}
			set
			{
				this.sw_lookuptemplateStateField = value;
			}
		}
		public int Sw_lookuptemplateStatus
		{
			get
			{
				return this.sw_lookuptemplateStatusField;
			}
			set
			{
				this.sw_lookuptemplateStatusField = value;
			}
		}
	}
}
