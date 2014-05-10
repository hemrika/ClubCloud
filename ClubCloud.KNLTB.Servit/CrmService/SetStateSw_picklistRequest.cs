using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSw_picklistRequest : Request
	{
		private Guid entityIdField;
		private Sw_picklistState sw_picklistStateField;
		private int sw_picklistStatusField;
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
		public Sw_picklistState Sw_picklistState
		{
			get
			{
				return this.sw_picklistStateField;
			}
			set
			{
				this.sw_picklistStateField = value;
			}
		}
		public int Sw_picklistStatus
		{
			get
			{
				return this.sw_picklistStatusField;
			}
			set
			{
				this.sw_picklistStatusField = value;
			}
		}
	}
}
