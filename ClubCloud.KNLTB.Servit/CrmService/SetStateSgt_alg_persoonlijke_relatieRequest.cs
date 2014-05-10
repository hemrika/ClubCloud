using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_persoonlijke_relatieRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_persoonlijke_relatieState sgt_alg_persoonlijke_relatieStateField;
		private int sgt_alg_persoonlijke_relatieStatusField;
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
		public Sgt_alg_persoonlijke_relatieState Sgt_alg_persoonlijke_relatieState
		{
			get
			{
				return this.sgt_alg_persoonlijke_relatieStateField;
			}
			set
			{
				this.sgt_alg_persoonlijke_relatieStateField = value;
			}
		}
		public int Sgt_alg_persoonlijke_relatieStatus
		{
			get
			{
				return this.sgt_alg_persoonlijke_relatieStatusField;
			}
			set
			{
				this.sgt_alg_persoonlijke_relatieStatusField = value;
			}
		}
	}
}
