using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_competentieRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_competentieState sgt_alg_competentieStateField;
		private int sgt_alg_competentieStatusField;
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
		public Sgt_alg_competentieState Sgt_alg_competentieState
		{
			get
			{
				return this.sgt_alg_competentieStateField;
			}
			set
			{
				this.sgt_alg_competentieStateField = value;
			}
		}
		public int Sgt_alg_competentieStatus
		{
			get
			{
				return this.sgt_alg_competentieStatusField;
			}
			set
			{
				this.sgt_alg_competentieStatusField = value;
			}
		}
	}
}
