using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_soortbalRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_soortbalState sgt_toe_soortbalStateField;
		private int sgt_toe_soortbalStatusField;
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
		public Sgt_toe_soortbalState Sgt_toe_soortbalState
		{
			get
			{
				return this.sgt_toe_soortbalStateField;
			}
			set
			{
				this.sgt_toe_soortbalStateField = value;
			}
		}
		public int Sgt_toe_soortbalStatus
		{
			get
			{
				return this.sgt_toe_soortbalStatusField;
			}
			set
			{
				this.sgt_toe_soortbalStatusField = value;
			}
		}
	}
}
