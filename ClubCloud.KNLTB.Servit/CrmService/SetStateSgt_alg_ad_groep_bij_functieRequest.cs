using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_ad_groep_bij_functieRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_ad_groep_bij_functieState sgt_alg_ad_groep_bij_functieStateField;
		private int sgt_alg_ad_groep_bij_functieStatusField;
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
		public Sgt_alg_ad_groep_bij_functieState Sgt_alg_ad_groep_bij_functieState
		{
			get
			{
				return this.sgt_alg_ad_groep_bij_functieStateField;
			}
			set
			{
				this.sgt_alg_ad_groep_bij_functieStateField = value;
			}
		}
		public int Sgt_alg_ad_groep_bij_functieStatus
		{
			get
			{
				return this.sgt_alg_ad_groep_bij_functieStatusField;
			}
			set
			{
				this.sgt_alg_ad_groep_bij_functieStatusField = value;
			}
		}
	}
}
