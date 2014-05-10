using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSw_lookupdefinitionRequest : Request
	{
		private Guid entityIdField;
		private Sw_lookupdefinitionState sw_lookupdefinitionStateField;
		private int sw_lookupdefinitionStatusField;
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
		public Sw_lookupdefinitionState Sw_lookupdefinitionState
		{
			get
			{
				return this.sw_lookupdefinitionStateField;
			}
			set
			{
				this.sw_lookupdefinitionStateField = value;
			}
		}
		public int Sw_lookupdefinitionStatus
		{
			get
			{
				return this.sw_lookupdefinitionStatusField;
			}
			set
			{
				this.sw_lookupdefinitionStatusField = value;
			}
		}
	}
}
