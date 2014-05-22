using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_com_competitierechtRequest : Request
	{
		private Guid entityIdField;
		private Sgt_com_competitierechtState sgt_com_competitierechtStateField;
		private int sgt_com_competitierechtStatusField;
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
		public Sgt_com_competitierechtState Sgt_com_competitierechtState
		{
			get
			{
				return this.sgt_com_competitierechtStateField;
			}
			set
			{
				this.sgt_com_competitierechtStateField = value;
			}
		}
		public int Sgt_com_competitierechtStatus
		{
			get
			{
				return this.sgt_com_competitierechtStatusField;
			}
			set
			{
				this.sgt_com_competitierechtStatusField = value;
			}
		}
	}
}