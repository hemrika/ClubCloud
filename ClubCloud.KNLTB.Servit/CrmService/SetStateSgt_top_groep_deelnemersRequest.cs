using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_top_groep_deelnemersRequest : Request
	{
		private Guid entityIdField;
		private Sgt_top_groep_deelnemersState sgt_top_groep_deelnemersStateField;
		private int sgt_top_groep_deelnemersStatusField;
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
		public Sgt_top_groep_deelnemersState Sgt_top_groep_deelnemersState
		{
			get
			{
				return this.sgt_top_groep_deelnemersStateField;
			}
			set
			{
				this.sgt_top_groep_deelnemersStateField = value;
			}
		}
		public int Sgt_top_groep_deelnemersStatus
		{
			get
			{
				return this.sgt_top_groep_deelnemersStatusField;
			}
			set
			{
				this.sgt_top_groep_deelnemersStatusField = value;
			}
		}
	}
}
