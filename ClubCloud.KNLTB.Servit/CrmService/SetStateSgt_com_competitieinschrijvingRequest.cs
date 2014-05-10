using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_com_competitieinschrijvingRequest : Request
	{
		private Guid entityIdField;
		private Sgt_com_competitieinschrijvingState sgt_com_competitieinschrijvingStateField;
		private int sgt_com_competitieinschrijvingStatusField;
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
		public Sgt_com_competitieinschrijvingState Sgt_com_competitieinschrijvingState
		{
			get
			{
				return this.sgt_com_competitieinschrijvingStateField;
			}
			set
			{
				this.sgt_com_competitieinschrijvingStateField = value;
			}
		}
		public int Sgt_com_competitieinschrijvingStatus
		{
			get
			{
				return this.sgt_com_competitieinschrijvingStatusField;
			}
			set
			{
				this.sgt_com_competitieinschrijvingStatusField = value;
			}
		}
	}
}
