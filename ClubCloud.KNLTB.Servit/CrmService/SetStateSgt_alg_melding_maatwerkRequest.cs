using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_melding_maatwerkRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_melding_maatwerkState sgt_alg_melding_maatwerkStateField;
		private int sgt_alg_melding_maatwerkStatusField;
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
		public Sgt_alg_melding_maatwerkState Sgt_alg_melding_maatwerkState
		{
			get
			{
				return this.sgt_alg_melding_maatwerkStateField;
			}
			set
			{
				this.sgt_alg_melding_maatwerkStateField = value;
			}
		}
		public int Sgt_alg_melding_maatwerkStatus
		{
			get
			{
				return this.sgt_alg_melding_maatwerkStatusField;
			}
			set
			{
				this.sgt_alg_melding_maatwerkStatusField = value;
			}
		}
	}
}
