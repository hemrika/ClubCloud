using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_activiteitenplanRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_activiteitenplanState sgt_alg_activiteitenplanStateField;
		private int sgt_alg_activiteitenplanStatusField;
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
		public Sgt_alg_activiteitenplanState Sgt_alg_activiteitenplanState
		{
			get
			{
				return this.sgt_alg_activiteitenplanStateField;
			}
			set
			{
				this.sgt_alg_activiteitenplanStateField = value;
			}
		}
		public int Sgt_alg_activiteitenplanStatus
		{
			get
			{
				return this.sgt_alg_activiteitenplanStatusField;
			}
			set
			{
				this.sgt_alg_activiteitenplanStatusField = value;
			}
		}
	}
}
