using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_com_tussenstand_afdeling_logboekRequest : Request
	{
		private Guid entityIdField;
		private Sgt_com_tussenstand_afdeling_logboekState sgt_com_tussenstand_afdeling_logboekStateField;
		private int sgt_com_tussenstand_afdeling_logboekStatusField;
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
		public Sgt_com_tussenstand_afdeling_logboekState Sgt_com_tussenstand_afdeling_logboekState
		{
			get
			{
				return this.sgt_com_tussenstand_afdeling_logboekStateField;
			}
			set
			{
				this.sgt_com_tussenstand_afdeling_logboekStateField = value;
			}
		}
		public int Sgt_com_tussenstand_afdeling_logboekStatus
		{
			get
			{
				return this.sgt_com_tussenstand_afdeling_logboekStatusField;
			}
			set
			{
				this.sgt_com_tussenstand_afdeling_logboekStatusField = value;
			}
		}
	}
}
