using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_gebeurtenis_beinvloederrolRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_gebeurtenis_beinvloederrolState sgt_alg_gebeurtenis_beinvloederrolStateField;
		private int sgt_alg_gebeurtenis_beinvloederrolStatusField;
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
		public Sgt_alg_gebeurtenis_beinvloederrolState Sgt_alg_gebeurtenis_beinvloederrolState
		{
			get
			{
				return this.sgt_alg_gebeurtenis_beinvloederrolStateField;
			}
			set
			{
				this.sgt_alg_gebeurtenis_beinvloederrolStateField = value;
			}
		}
		public int Sgt_alg_gebeurtenis_beinvloederrolStatus
		{
			get
			{
				return this.sgt_alg_gebeurtenis_beinvloederrolStatusField;
			}
			set
			{
				this.sgt_alg_gebeurtenis_beinvloederrolStatusField = value;
			}
		}
	}
}
