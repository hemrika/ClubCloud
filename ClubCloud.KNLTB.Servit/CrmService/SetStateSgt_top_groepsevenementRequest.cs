using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_top_groepsevenementRequest : Request
	{
		private Guid entityIdField;
		private Sgt_top_groepsevenementState sgt_top_groepsevenementStateField;
		private int sgt_top_groepsevenementStatusField;
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
		public Sgt_top_groepsevenementState Sgt_top_groepsevenementState
		{
			get
			{
				return this.sgt_top_groepsevenementStateField;
			}
			set
			{
				this.sgt_top_groepsevenementStateField = value;
			}
		}
		public int Sgt_top_groepsevenementStatus
		{
			get
			{
				return this.sgt_top_groepsevenementStatusField;
			}
			set
			{
				this.sgt_top_groepsevenementStatusField = value;
			}
		}
	}
}