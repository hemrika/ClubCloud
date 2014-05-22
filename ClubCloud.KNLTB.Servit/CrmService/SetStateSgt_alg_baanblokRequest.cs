using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_baanblokRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_baanblokState sgt_alg_baanblokStateField;
		private int sgt_alg_baanblokStatusField;
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
		public Sgt_alg_baanblokState Sgt_alg_baanblokState
		{
			get
			{
				return this.sgt_alg_baanblokStateField;
			}
			set
			{
				this.sgt_alg_baanblokStateField = value;
			}
		}
		public int Sgt_alg_baanblokStatus
		{
			get
			{
				return this.sgt_alg_baanblokStatusField;
			}
			set
			{
				this.sgt_alg_baanblokStatusField = value;
			}
		}
	}
}