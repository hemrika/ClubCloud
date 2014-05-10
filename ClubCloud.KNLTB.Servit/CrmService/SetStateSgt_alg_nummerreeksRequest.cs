using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_nummerreeksRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_nummerreeksState sgt_alg_nummerreeksStateField;
		private int sgt_alg_nummerreeksStatusField;
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
		public Sgt_alg_nummerreeksState Sgt_alg_nummerreeksState
		{
			get
			{
				return this.sgt_alg_nummerreeksStateField;
			}
			set
			{
				this.sgt_alg_nummerreeksStateField = value;
			}
		}
		public int Sgt_alg_nummerreeksStatus
		{
			get
			{
				return this.sgt_alg_nummerreeksStatusField;
			}
			set
			{
				this.sgt_alg_nummerreeksStatusField = value;
			}
		}
	}
}
