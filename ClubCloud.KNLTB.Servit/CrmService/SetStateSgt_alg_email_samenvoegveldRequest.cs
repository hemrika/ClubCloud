using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_email_samenvoegveldRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_email_samenvoegveldState sgt_alg_email_samenvoegveldStateField;
		private int sgt_alg_email_samenvoegveldStatusField;
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
		public Sgt_alg_email_samenvoegveldState Sgt_alg_email_samenvoegveldState
		{
			get
			{
				return this.sgt_alg_email_samenvoegveldStateField;
			}
			set
			{
				this.sgt_alg_email_samenvoegveldStateField = value;
			}
		}
		public int Sgt_alg_email_samenvoegveldStatus
		{
			get
			{
				return this.sgt_alg_email_samenvoegveldStatusField;
			}
			set
			{
				this.sgt_alg_email_samenvoegveldStatusField = value;
			}
		}
	}
}