using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_bestuursorgaanRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_bestuursorgaanState sgt_alg_bestuursorgaanStateField;
		private int sgt_alg_bestuursorgaanStatusField;
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
		public Sgt_alg_bestuursorgaanState Sgt_alg_bestuursorgaanState
		{
			get
			{
				return this.sgt_alg_bestuursorgaanStateField;
			}
			set
			{
				this.sgt_alg_bestuursorgaanStateField = value;
			}
		}
		public int Sgt_alg_bestuursorgaanStatus
		{
			get
			{
				return this.sgt_alg_bestuursorgaanStatusField;
			}
			set
			{
				this.sgt_alg_bestuursorgaanStatusField = value;
			}
		}
	}
}