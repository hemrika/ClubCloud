using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_com_ingedeelde_ploegRequest : Request
	{
		private Guid entityIdField;
		private Sgt_com_ingedeelde_ploegState sgt_com_ingedeelde_ploegStateField;
		private int sgt_com_ingedeelde_ploegStatusField;
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
		public Sgt_com_ingedeelde_ploegState Sgt_com_ingedeelde_ploegState
		{
			get
			{
				return this.sgt_com_ingedeelde_ploegStateField;
			}
			set
			{
				this.sgt_com_ingedeelde_ploegStateField = value;
			}
		}
		public int Sgt_com_ingedeelde_ploegStatus
		{
			get
			{
				return this.sgt_com_ingedeelde_ploegStatusField;
			}
			set
			{
				this.sgt_com_ingedeelde_ploegStatusField = value;
			}
		}
	}
}
