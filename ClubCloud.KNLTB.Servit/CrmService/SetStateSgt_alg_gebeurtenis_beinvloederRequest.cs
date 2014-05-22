using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_gebeurtenis_beinvloederRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_gebeurtenis_beinvloederState sgt_alg_gebeurtenis_beinvloederStateField;
		private int sgt_alg_gebeurtenis_beinvloederStatusField;
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
		public Sgt_alg_gebeurtenis_beinvloederState Sgt_alg_gebeurtenis_beinvloederState
		{
			get
			{
				return this.sgt_alg_gebeurtenis_beinvloederStateField;
			}
			set
			{
				this.sgt_alg_gebeurtenis_beinvloederStateField = value;
			}
		}
		public int Sgt_alg_gebeurtenis_beinvloederStatus
		{
			get
			{
				return this.sgt_alg_gebeurtenis_beinvloederStatusField;
			}
			set
			{
				this.sgt_alg_gebeurtenis_beinvloederStatusField = value;
			}
		}
	}
}